﻿Imports SkyEditorBase
Public Class DeSmuMePlugin
    Implements iSkyEditorPlugin
    Public ReadOnly Property Credits As String Implements iSkyEditorPlugin.Credits
        Get
            Return ""
        End Get
    End Property

    Public Sub Load(ByRef Window As iMainWindow) Implements iSkyEditorPlugin.Load
        Window.RegisterMenuItem(New DesmumeMenuItem(Window))
    End Sub

    Public ReadOnly Property PluginAuthor As String Implements iSkyEditorPlugin.PluginAuthor
        Get
            Return "evandixon"
        End Get
    End Property

    Public ReadOnly Property PluginName As String Implements iSkyEditorPlugin.PluginName
        Get
            Return "DeSmuMe Integration"
        End Get
    End Property

    Public Sub UnLoad(ByRef Window As iMainWindow) Implements iSkyEditorPlugin.UnLoad

    End Sub

    Public Sub PrepareForDistribution() Implements iSkyEditorPlugin.PrepareForDistribution
        Try
            Dim folder = IO.Path.Combine(Environment.CurrentDirectory, "Resources/Plugins/DeSmuMe/")
            For Each d In IO.Directory.GetDirectories(folder)
                DeveloperConsole.Writeline("Deleting directory " & d)
                IO.Directory.Delete(d, True)
            Next
        Catch ex As Exception
            DeveloperConsole.Writeline(ex.ToString)
        End Try
    End Sub
End Class
