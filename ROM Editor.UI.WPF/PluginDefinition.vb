﻿Imports SkyEditorBase
Imports ROMEditor.Roms
Imports SkyEditorBase.Interfaces

Public Class PluginDefinition
    Implements iSkyEditorPlugin

    Public ReadOnly Property Credits As String Implements iSkyEditorPlugin.Credits
        Get
            Return PluginHelper.GetLanguageItem("RomEditorCredits", "Rom Editor Credits:\n     psy_commando (Pokemon portraits, most of the research)\n     Grovyle91 (Language strings)\n     evandixon (Personality test, bgp files)")
        End Get
    End Property

    Public ReadOnly Property PluginAuthor As String Implements iSkyEditorPlugin.PluginAuthor
        Get
            Return "evandixon"
        End Get
    End Property

    Public ReadOnly Property PluginName As String Implements iSkyEditorPlugin.PluginName
        Get
            Return PluginHelper.GetLanguageItem("ROM Editor UI (WPF)")
        End Get
    End Property

    Public Sub Load(Manager As PluginManager) Implements iSkyEditorPlugin.Load
        'Load the plugin this one depends on
        Manager.LoadPlugin(New ROMEditor.PluginDefinition)
    End Sub

    Public Sub UnLoad(Manager As PluginManager) Implements iSkyEditorPlugin.UnLoad

    End Sub

    Public Sub PrepareForDistribution() Implements iSkyEditorPlugin.PrepareForDistribution

    End Sub
End Class