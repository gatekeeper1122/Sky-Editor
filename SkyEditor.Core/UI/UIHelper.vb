﻿Imports System.Reflection
Imports SkyEditor.Core.Utilities

Namespace UI
    Public Class UIHelper

        'Prevent creating instances of this static class
        Private Sub New()
        End Sub

        ''' <summary>
        ''' Gets the currently registered MenuActions in heiarchy form.
        ''' </summary>
        ''' <param name="pluginManager">Instance of the current plugin manager.</param>
        ''' <param name="isDevMode">Whether or not to get the dev-only menu items.</param>
        ''' <returns></returns>
        Public Shared Function GetMenuItemInfo(pluginManager As PluginManager, isDevMode As Boolean) As List(Of MenuItemInfo)
            Dim menuItems As New List(Of MenuItemInfo)
            For Each ActionType In pluginManager.GetRegisteredTypes(GetType(MenuAction).GetTypeInfo)
                'While we're registering the type, we need an instance to get extra information, like where to put it
                Dim ActionInstance As MenuAction = ReflectionHelpers.CreateInstance(ActionType)

                'DevOnly menu actions are only supported if we're in dev mode.
                If isDevMode OrElse Not ActionInstance.DevOnly Then

                    'Generate the MenuItem

                    If ActionInstance.ActionPath.Count >= 1 Then
                        'Create parent menu items
                        Dim parent = From m In menuItems Where m.Header = ActionInstance.ActionPath(0)

                        Dim current As MenuItemInfo
                        If parent.Any Then
                            current = parent.First
                            If current.ActionTypes.Count = 0 Then
                                current.SortOrder = Math.Min(current.SortOrder, ActionInstance.SortOrder)
                            End If
                        Else
                            Dim m As New MenuItemInfo
                            m.Header = ActionInstance.ActionPath(0)
                            m.Children = New List(Of MenuItemInfo)
                            m.ActionTypes = New List(Of TypeInfo)
                            m.SortOrder = ActionInstance.SortOrder
                            If ActionInstance.ActionPath.Count = 1 Then
                                m.ActionTypes.Add(ActionType)
                            End If
                            menuItems.Add(m)
                            current = m
                        End If


                        For count = 1 To ActionInstance.ActionPath.Count - 2
                            Dim index = count 'To avoid potential issues with using the below linq expression.  Might not be needed, but it's probably best to avoid potential issues.
                            parent = From m As MenuItemInfo In current.Children Where m.Header = ActionInstance.ActionPath(index)
                            If parent.Any Then
                                current = parent.First
                                If current.ActionTypes.Count = 0 Then
                                    current.SortOrder = Math.Min(current.SortOrder, ActionInstance.SortOrder)
                                End If
                            Else
                                Dim m As New MenuItemInfo
                                m.Header = ActionInstance.ActionPath(count)
                                m.Children = New List(Of MenuItemInfo)
                                m.SortOrder = ActionInstance.SortOrder
                                If count = 0 Then
                                    menuItems.Add(m)
                                Else
                                    current.Children.Add(m)
                                End If
                                current = m
                            End If
                        Next


                        If ActionInstance.ActionPath.Count > 1 Then
                            'Check to see if the menu item exists
                            parent = From m As MenuItemInfo In current.Children Where m.Header = ActionInstance.ActionPath.Last

                            If parent.Any Then
                                Dim m = DirectCast(parent.First, MenuItemInfo)
                                m.ActionTypes = New List(Of TypeInfo)
                                m.ActionTypes.Add(ActionType)
                            Else
                                'Add the menu item, and give it a proper tag
                                Dim m As New MenuItemInfo
                                m.Children = New List(Of MenuItemInfo)
                                m.Header = ActionInstance.ActionPath.Last
                                m.SortOrder = ActionInstance.SortOrder
                                m.ActionTypes = New List(Of TypeInfo)
                                m.ActionTypes.Add(ActionType)
                                current.Children.Add(m)
                            End If
                        End If

                    Else 'Count=0
                        Throw New ArgumentException(My.Resources.Language.ErrorMenuActionEmptyActionPath)
                    End If
                End If
            Next
            Return menuItems
        End Function

        ''' <summary>
        ''' Returns a new instance of each registered ObjectControl.
        ''' </summary>
        ''' <returns></returns>
        Private Shared Function GetObjectControls(Manager As PluginManager) As IEnumerable(Of IObjectControl)
            Return Manager.GetRegisteredObjects(Of IObjectControl)()
        End Function

        ''' <summary>
        ''' Gets an object control that can edit the given object.
        ''' </summary>
        ''' <param name="ObjectToEdit"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetObjectControl(ObjectToEdit As Object, RequestedTabTypes As IEnumerable(Of Type), Manager As PluginManager) As IObjectControl
            Dim out As IObjectControl = Nothing
            If ObjectToEdit IsNot Nothing Then
                'Look for a supported Object Control
                For Each item In (From o In GetObjectControls(Manager) Order By o.GetSortOrder(ObjectToEdit.GetType, False) Descending)
                    'We're only looking for the first non-backup control
                    If out Is Nothing OrElse out.IsBackupControl(ObjectToEdit) Then
                        'Check to see if the control supports what we want to edit
                        For Each t In item.GetSupportedTypes
                            If ReflectionHelpers.IsOfType(ObjectToEdit, t.GetTypeInfo) Then

                                'If the control supports our object, we also want to make sure it's supported in the environment.
                                'It must be one of the types in RequestedTabTypes
                                Dim isSupported As Boolean = False
                                For Each r In RequestedTabTypes
                                    If ReflectionHelpers.IsOfType(item, r.GetTypeInfo) Then
                                        isSupported = True
                                        Exit For
                                    End If
                                Next

                                If isSupported Then
                                    out = item '.GetType.GetConstructor({}).Invoke({})
                                    Exit For
                                End If
                            End If
                        Next
                    Else
                        Exit For
                    End If
                Next
            End If
            out.SetPluginManager(Manager)
            Return out
        End Function

        ''' <summary>
        ''' Returns a list of iObjectControl that edit the given ObjectToEdit.
        ''' </summary>
        ''' <param name="ObjectToEdit">Object the iObjectControl should edit.</param>
        ''' <param name="RequestedTabTypes">Limits what types of iObjectControl should be returned.  If the iObjectControl is not of any type in this IEnumerable, it will not be used.  If empty or nothing, no constraints will be applied, which is not recommended because the iObjectControl could be made for a different environment (for example, a Windows Forms user control being used in a WPF environment).</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetRefreshedTabs(ObjectToEdit As Object, RequestedTabTypes As IEnumerable(Of Type), Manager As PluginManager) As IEnumerable(Of IObjectControl)
            If ObjectToEdit Is Nothing Then
                Throw New ArgumentNullException(NameOf(ObjectToEdit))
            End If
            Dim objType = ObjectToEdit.GetType
            Dim allTabs As New List(Of IObjectControl)

            'This is our cache of reference-only object controls.
            'We use this to find out which object controls support the given object.
            'It's a static variable because we're likely going to be calling GetRefreshedTabs multiple times,
            'So we'll only have to take a little more time the first time we run this
            Static objControls As List(Of IObjectControl) = Nothing
            If objControls Is Nothing Then
                objControls = GetObjectControls(Manager)
            End If

            For Each etab In (From e In objControls Order By e.GetSortOrder(objType, True) Ascending)
                Dim isMatch = False
                'Check to see if the tab itself is supported
                'It must be one of the types in RequestedTabTypes
                For Each t In RequestedTabTypes
                    If ReflectionHelpers.IsOfType(etab, t.GetTypeInfo) Then
                        isMatch = True
                        Exit For
                    End If
                Next
                'Check to see if the tab support the type of the given object
                Dim supportedTypes = etab.GetSupportedTypes
                If isMatch Then
                    isMatch = supportedTypes.Count > 0
                End If
                If isMatch Then
                    For Each t In supportedTypes
                        If ObjectToEdit Is Nothing OrElse Not ReflectionHelpers.IsOfType(ObjectToEdit, t.GetTypeInfo) Then
                            isMatch = False
                            Exit For
                        End If
                    Next
                End If
                'Check to see if the tab support the object itself
                If isMatch Then
                    isMatch = etab.SupportsObject(ObjectToEdit)
                End If
                'This is a supported tab.  We're adding it!
                If isMatch Then
                    'etab.EditingObject = ObjectToEdit
                    'allTabs.Add(etab)
                    'Create another instance of etab, since etab is our cached, search-only instance.
                    Dim t As IObjectControl = ReflectionHelpers.CreateInstance(etab.GetType.GetTypeInfo)
                    t.SetPluginManager(Manager)
                    t.EditingObject = ObjectToEdit
                    allTabs.Add(t)
                End If
            Next

            Dim backupTabs As New List(Of IObjectControl)
            Dim notBackup As New List(Of IObjectControl)

            'Sort the backup vs non-backup tabs
            For Each item In allTabs
                If item.IsBackupControl(ObjectToEdit) Then
                    backupTabs.Add(item)
                Else
                    notBackup.Add(item)
                End If
            Next

            'And use the non-backup ones if available
            If notBackup.Count > 0 Then
                Return notBackup
            Else
                Dim toUse = (From b In backupTabs Order By b.GetSortOrder(objType, True)).FirstOrDefault
                If toUse Is Nothing Then
                    Return {}
                Else
                    Return {toUse}
                End If
            End If
        End Function
    End Class
End Namespace
