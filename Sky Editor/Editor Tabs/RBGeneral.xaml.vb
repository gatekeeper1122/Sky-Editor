﻿Imports SkyEditorBase

Public Class RBGeneral
    Inherits EditorTab
    Public Overrides Sub RefreshDisplay(Save As GenericSave)
        If TypeOf Save Is RBSave Then
            With RBSave.FromBase(Save)
                txtGeneral_TeamName.Text = .TeamName
                numGeneral_HeldMoney.Value = .HeldMoney
                numGeneral_StoredMoney.Value = .StoredMoney
                numGeneral_RescuePoints.Value = .RescuePoints
            End With
            cbGeneral_Base.SelectedItem = Lists.RBBaseTypesInverse(RBSave.FromBase(Save).BaseType)
        End If
    End Sub

    Public Overrides ReadOnly Property SupportedGames As String()
        Get
            Return {GameConstants.RBSave}
        End Get
    End Property

    Public Overrides Function UpdateSave(Save As GenericSave) As GenericSave
        Dim out As GenericSave = Nothing
        If TypeOf Save Is RBSave Then
            Dim rb = RBSave.FromBase(Save)
            With rb
                .TeamName = txtGeneral_TeamName.Text
                .HeldMoney = numGeneral_HeldMoney.Value
                .StoredMoney = numGeneral_StoredMoney.Value
                .RescuePoints = numGeneral_RescuePoints.Value
                .BaseType = Lists.RBBaseTypes(cbGeneral_Base.SelectedItem)
            End With
            out = rb.ToBase
        End If
        Return out
    End Function

    Private Sub GeneralTab_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Me.Header = Lists.SkyEditorLanguageText("Category_General")
        lblGeneral_Adventures.Content = Lists.SkyEditorLanguageText("Adventures")
        lblGeneral_HeldMoney.Content = Lists.SkyEditorLanguageText("General_HeldMoney")
        lblGeneral_RescuePoints.Content = Lists.SkyEditorLanguageText("RescuePoints")
        lblGeneral_StoredMoney.Content = Lists.SkyEditorLanguageText("General_StoredMoney")
        lblGeneral_TeamName.Content = Lists.SkyEditorLanguageText("General_TeamName")

        numGeneral_Adventures.Maximum = Integer.MaxValue
        numGeneral_Adventures.Minimum = Integer.MinValue
        numGeneral_StoredMoney.Maximum = 9999999 'Integer.MaxValue '16580607
        numGeneral_StoredMoney.Minimum = 0

        'Load Base Type dropdown
        For Each item In Lists.RBBaseTypes.Keys
            cbGeneral_Base.Items.Add(item)
        Next
    End Sub
End Class
