﻿Imports SkyEditorBase
Imports SaveEditor.Saves
Imports SkyEditorBase.Interfaces

Namespace Tabs
    Public Class SkyGeneralTab
        Inherits UserControl
        Implements SkyEditorBase.Interfaces.iObjectControl

        ''' <summary>
        ''' Updates UI elements to display certain properties.
        ''' </summary>
        Public Sub RefreshDisplay()
            With GetEditingObject(Of SkySave)()
                numGeneral_StoredMoney.Value = .StoredMoney
                numGeneral_HeldMoney.Value = .HeldMoney
                numGeneral_SpEpisodeHeldMoney.Value = .SpEpisode_HeldMoney
                numGeneral_Adventures.Value = .Adventures
                txtGeneral_TeamName.Text = .TeamName
                numGeneral_RankPoints.Value = .ExplorerRank
            End With
        End Sub

        ''' <summary>
        ''' Updates the EditingObject using data in UI elements.
        ''' </summary>
        Public Sub UpdateObject()
            With GetEditingObject(Of SkySave)()
                .StoredMoney = numGeneral_StoredMoney.Value
                .HeldMoney = numGeneral_HeldMoney.Value
                .SpEpisode_HeldMoney = numGeneral_SpEpisodeHeldMoney.Value
                .Adventures = numGeneral_Adventures.Value
                .TeamName = txtGeneral_TeamName.Text
                .ExplorerRank = numGeneral_RankPoints.Value
            End With
        End Sub

        Private Sub GeneralTab_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
            Me.Header = PluginHelper.GetLanguageItem("Category_General", "General")
            lblGeneral_Adventures.Content = PluginHelper.GetLanguageItem("Adventures", "Adventures:")
            lblGeneral_HeldMoney.Content = PluginHelper.GetLanguageItem("General_HeldMoney", "Held Money:")
            lblGeneral_SpEpisodeHeldMoney.Content = PluginHelper.GetLanguageItem("General_SpEpisodeHeldMoney", "Sp. Episode Held Money:")
            lblGeneral_StoredMoney.Content = PluginHelper.GetLanguageItem("General_StoredMoney", "Stored Money:")
            lblGeneral_TeamName.Content = PluginHelper.GetLanguageItem("General_TeamName", "Team Name:")
            lblGeneral_RankPoints.Content = PluginHelper.GetLanguageItem("Rank Points", "Rank Points:")

            numGeneral_Adventures.Maximum = Integer.MaxValue
            numGeneral_Adventures.Minimum = Integer.MinValue
            numGeneral_StoredMoney.Maximum = 9999999 'Integer.MaxValue '16580607
            numGeneral_StoredMoney.Minimum = 0
        End Sub

        Private Sub OnModified(sender As Object, e As EventArgs) Handles txtGeneral_TeamName.TextChanged,
                                                                         numGeneral_StoredMoney.ValueChanged,
                                                                         numGeneral_HeldMoney.ValueChanged,
                                                                         numGeneral_SpEpisodeHeldMoney.ValueChanged,
                                                                         numGeneral_Adventures.ValueChanged,
                                                                         numGeneral_RankPoints.ValueChanged
            IsModified = True
        End Sub

        Public Function GetSupportedTypes() As IEnumerable(Of Type) Implements iObjectControl.GetSupportedTypes
            Return {GetType(Saves.SkySave)}
        End Function

        Public Function GetSortOrder(CurrentType As Type, IsTab As Boolean) As Integer Implements iObjectControl.GetSortOrder
            Return 0
        End Function

#Region "IObjectControl Support"
        ''' <summary>
        ''' Called when Header is changed.
        ''' </summary>
        Public Event HeaderUpdated(sender As Object, e As EventArguments.HeaderUpdatedEventArgs) Implements iObjectControl.HeaderUpdated

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
                If Not oldValue = _isModified Then
                    RaiseEvent IsModifiedChanged(Me, New EventArgs)
                End If
            End Set
        End Property
        Dim _isModified As Boolean
#End Region

    End Class
End Namespace