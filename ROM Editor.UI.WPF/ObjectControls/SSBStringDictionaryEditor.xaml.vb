﻿Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Timers
Imports System.Windows.Controls
Imports SkyEditorBase
Imports SkyEditorBase.Interfaces

Public Class SSBStringDictionaryEditor
    Inherits UserControl
    Implements iObjectControl

    Public Class KVPWrapper
        Implements INotifyPropertyChanged

        Public Property Key As Integer
            Get
                Return _key
            End Get
            Set(value As Integer)
                _key = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Key)))
            End Set
        End Property
        Dim _key As Integer
        Public Property Value As String
            Get
                Return _value
            End Get
            Set(value As String)
                _value = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(NameOf(Me.Value)))
            End Set
        End Property
        Dim _value As String
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    End Class

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        searchTimer = New Timers.Timer(500)
        cancelSearch = False
    End Sub

    Private WithEvents searchTimer As Timers.Timer
    Private cancelSearch As Boolean
    Private searchTask As Task
    Private mainSource As ObservableCollection(Of KVPWrapper)

    Public Sub RefreshDisplay()
        mainSource = New ObservableCollection(Of KVPWrapper)
        For Each item In GetEditingObject(Of Dictionary(Of Integer, String))()
            Dim n = New KVPWrapper With {.Key = item.Key, .Value = item.Value}
            AddHandler n.PropertyChanged, AddressOf Me.OnObjModified
            mainSource.Add(n)
        Next
        lstEntries.ItemsSource = mainSource
        IsModified = False
    End Sub

    Public Sub UpdateObject()
        GetEditingObject(Of Dictionary(Of Integer, String)).Clear()
        For Each item In mainSource
            GetEditingObject(Of Dictionary(Of Integer, String)).Add(item.Key, item.Value)
        Next
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As TextChangedEventArgs) Handles txtSearch.TextChanged
        cancelSearch = True
        searchTimer.Stop()
        searchTimer.Start()
    End Sub


    Private Async Sub searchTimer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles searchTimer.Elapsed
        searchTimer.Stop()
        Dim searchText As String = ""
        Dispatcher.Invoke(Sub()
                              searchText = txtSearch.Text
                          End Sub)
        'Wait for the current task to stop itself
        If searchTask IsNot Nothing Then
            Await searchTask
        End If
        'Start a new async task
        searchTask = Task.Run(New Action(Sub()
                                             RunSearch(searchText)
                                         End Sub))
    End Sub

    Private Sub RunSearch(SearchText As String)
        cancelSearch = False
        If String.IsNullOrEmpty(SearchText) Then
            Dispatcher.Invoke(Sub()
                                  lstEntries.ItemsSource = mainSource
                              End Sub)
        Else
            Dim results As New ObservableCollection(Of KVPWrapper)
            Dispatcher.Invoke(Sub()
                                  lstEntries.ItemsSource = results
                              End Sub)

            Dim searchTerms = SearchText.Split(" ")

            For Each item In mainSource
                If cancelSearch = True Then
                    'If we get here, the search textbox has been changed, so we'll stop searching
                    Exit For
                End If

                Dim isMatch As Boolean
                For Each term In searchTerms
                    isMatch = False 'For every term, we'll set isMatch to false

                    'The entry must match every term
                    If item.Key.ToString.Contains(term) Then
                        isMatch = True
                    ElseIf item.Value.ToLower.Contains(term.ToLower) Then
                        isMatch = True
                    End If

                    'If any terms aren't a match, then we don't use this entry
                    If Not isMatch Then
                        Exit For
                    End If
                Next

                If isMatch Then
                    Dispatcher.Invoke(Sub()
                                          results.Add(item)
                                      End Sub)
                End If
            Next
        End If
    End Sub

    Private Sub OnObjModified(sender As Object, e As EventArgs)
        IsModified = True
    End Sub

    Private Sub OnLoaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        If Not DesignerProperties.GetIsInDesignMode(Me) Then
            Me.Header = EditingLanguage
            columnID.Header = PluginHelper.GetLanguageItem("ID")
            columnEntry.Header = PluginHelper.GetLanguageItem("Entry")
            lblSearch.Content = PluginHelper.GetLanguageItem("Search: ")
        End If
    End Sub

    Public Function GetSupportedTypes() As IEnumerable(Of Type) Implements iObjectControl.GetSupportedTypes
        Return {GetType(Dictionary(Of Integer, String))}
    End Function

    Public Function GetSortOrder(CurrentType As Type, IsTab As Boolean) As Integer Implements iObjectControl.GetSortOrder
        Return 0
    End Function

    Public Sub AddItem(ID As Integer)
        Dim newItem As New KVPWrapper With {.Key = ID, .Value = ""}
        AddHandler newItem.PropertyChanged, AddressOf Me.OnObjModified
        mainSource.Add(newItem)
        lstEntries.ScrollIntoView(newItem)
    End Sub

    Public Property EditingLanguage As String

#Region "IObjectControl Support"
    Public Function SupportsObject(Obj As Object) As Boolean Implements iObjectControl.SupportsObject
        Return True
    End Function

    Public Function IsBackupControl(Obj As Object) As Boolean Implements iObjectControl.IsBackupControl
        Return False
    End Function

    ''' <summary>
    ''' Called when Header is changed.
    ''' </summary>
    Public Event HeaderUpdated As iObjectControl.HeaderUpdatedEventHandler Implements iObjectControl.HeaderUpdated

    ''' <summary>
    ''' Called when IsModified is changed.
    ''' </summary>
    Public Event IsModifiedChanged As iObjectControl.IsModifiedChangedEventHandler Implements iObjectControl.IsModifiedChanged

    ''' <summary>
    ''' Returns the value of the Header.  Only used when the iObjectControl is behaving as a tab.
    ''' </summary>
    ''' <returns></returns>
    Public Property Header As String Implements iObjectControl.Header
        Get
            Return _header
        End Get
        Set(value As String)
            Dim oldValue = _header
            _header = value
            RaiseEvent HeaderUpdated(Me, New EventArguments.HeaderUpdatedEventArgs(oldValue, value))
        End Set
    End Property
    Dim _header As String

    ''' <summary>
    ''' Returns the current EditingObject, after casting it to type T.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <returns></returns>
    Protected Function GetEditingObject(Of T)() As T
        Return PluginHelper.Cast(Of T)(_editingObject)
    End Function

    ''' <summary>
    ''' Returns the current EditingObject.
    ''' It is recommended to use GetEditingObject(Of T), since it returns iContainter(Of T).Item if the EditingObject implements that interface.
    ''' </summary>
    ''' <returns></returns>
    Protected Function GetEditingObject() As Object
        Return _editingObject
    End Function

    ''' <summary>
    ''' The way to get the EditingObject from outside this class.  Refreshes the display on set, and updates the object on get.
    ''' Calling this from inside this class could result in a stack overflow, especially if called from UpdateObject, so use GetEditingObject or GetEditingObject(Of T) instead.
    ''' </summary>
    ''' <returns></returns>
    Public Property EditingObject As Object Implements iObjectControl.EditingObject
        Get
            UpdateObject()
            Return _editingObject
        End Get
        Set(value As Object)
            _editingObject = value
            RefreshDisplay()
        End Set
    End Property
    Dim _editingObject As Object

    ''' <summary>
    ''' Whether or not the EditingObject has been modified without saving.
    ''' Set to true when the user changes anything in the GUI.
    ''' Set to false when the object is saved, or if the user undoes every change.
    ''' </summary>
    ''' <returns></returns>
    Public Property IsModified As Boolean Implements iObjectControl.IsModified
        Get
            Return _isModified
        End Get
        Set(value As Boolean)
            Dim oldValue As Boolean = _isModified
            _isModified = value
            'If Not oldValue = _isModified Then
            RaiseEvent IsModifiedChanged(Me, New EventArgs)
            'End If
        End Set
    End Property
    Dim _isModified As Boolean
#End Region
End Class