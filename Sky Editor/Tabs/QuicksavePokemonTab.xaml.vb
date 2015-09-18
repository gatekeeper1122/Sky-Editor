﻿Imports SkyEditorBase
Namespace Tabs
    Public Class QuicksavePokemonTab
        Inherits ObjectTab
        Public Overrides Sub RefreshDisplay()
            Dim Save = DirectCast(Me.ContainedObject, GenericSave)
            If Save.IsOfType(GameStrings.SkySave) Then
                Dim p = Save.Convert(Of Saves.SkySave)()
                lbActivePokemon.Items.Clear()
                For Each apkm In p.QuicksavePokemon
                    'If apkm.IsValid Then
                    lbActivePokemon.Items.Add(apkm)
                    'End If
                Next
            End If
        End Sub
        Public Overrides Sub UpdateObject()
            Dim Save = DirectCast(Me.ContainedObject, GenericSave)
            If Save.IsOfType(GameStrings.SkySave) Then
                Dim p = Save.Convert(Of Saves.SkySave)()
                Dim apkms As New List(Of Saves.SkySave.QuicksavePkm)
                For Each item In lbActivePokemon.Items
                    apkms.Add(item)
                Next
                p.QuicksavePokemon = apkms.ToArray
                Save = Save.Convert(p)
            End If
        End Sub
        Private Sub ActivePokemonTab_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
            Me.Header = PluginHelper.GetLanguageItem("Quicksave Pokemon")
        End Sub
        Sub RefreshActivePKMDisplay()
            Dim pkms As New List(Of Saves.SkySave.QuicksavePkm)
            For Each p In lbActivePokemon.Items
                pkms.Add(p)
            Next
            lbActivePokemon.Items.Clear()
            For count As Integer = 0 To pkms.Count - 1
                'If pkms(count).ID > 0 Then
                lbActivePokemon.Items.Add(pkms(count))
                'End If
            Next
        End Sub
        Sub ShowActivePkmEditDialog()
            If lbActivePokemon.SelectedIndex > -1 Then
                Dim w As New SkyEditorBase.ObjectWindow(Me.GetPluginManager)
                w.ObjectToEdit = lbActivePokemon.SelectedItem
                w.ShowDialog()
                lbActivePokemon.SelectedItem = w.ObjectToEdit
                RefreshActivePKMDisplay()
            End If
        End Sub
        Private Sub btnEditActivePokemon_Click(sender As Object, e As RoutedEventArgs) Handles btnEditActivePokemon.Click
            ShowActivePkmEditDialog()
        End Sub
        Private Sub lbActivePokemon_MouseDoubleClick(sender As Object, e As MouseButtonEventArgs) Handles lbActivePokemon.MouseDoubleClick
            ShowActivePkmEditDialog()
        End Sub
        Public Overrides ReadOnly Property SupportedTypes As Type()
            Get
                Return {GetType(Saves.SkySave)}
            End Get
        End Property
        Public Overrides ReadOnly Property SortOrder As Integer
            Get
                Return 20
            End Get
        End Property
    End Class

End Namespace