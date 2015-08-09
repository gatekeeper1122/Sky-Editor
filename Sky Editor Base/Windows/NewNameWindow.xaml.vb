﻿Namespace SkyEditorWindows
    Public Class NewNameWindow
        Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
            DialogResult = True
            Me.Close()
        End Sub

        Public Property SelectedName As String
            Get
                Return txtName.Text
            End Get
            Set(value As String)
                txtName.Text = value
            End Set
        End Property

        Private Sub GameTypeSelector_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
            PluginHelper.TranslateForm(Me)
            'btnOK.Content = PluginHelper.GetLanguageItem("OK")
            'lbGame.Content = PluginHelper.GetLanguageItem("Name")
            'lbGameSelectorQuestion.Content = PluginHelper.GetLanguageItem("GameSelectorQuestion", "What game is this save for?")
            'Me.Title = PluginHelper.GetLanguageItem("GameSelectorTitle", "Game Selector")
        End Sub
        Public Shadows Function ShowDialog() As Boolean
            Return MyBase.ShowDialog
        End Function
        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

        End Sub
        Public Sub New(Message As String, Title As String)
            Me.New
            Me.Title = Title
            lbGameSelectorQuestion.Content = Message
        End Sub
    End Class

End Namespace