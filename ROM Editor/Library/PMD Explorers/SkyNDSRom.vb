﻿Imports System.Drawing
Imports System.Runtime.Serialization.Formatters.Binary
Imports SkyEditorBase
Imports ROMEditor.FileFormats

Namespace PMD_Explorers
    Public Class SkyNDSRom
        Inherits GenericNDSRom

        Public Sub New(Filename As String)
            MyBase.New(Filename)
            'Unpack()
        End Sub
        ''' <summary>
        ''' Should only be used to make a new ROM, loading files already in the Current ROM directory.
        ''' </summary>
        ''' <param name="RawData"></param>
        ''' <remarks></remarks>
        Public Sub New(RawData As Byte())
            MyBase.New(RawData)
        End Sub
        Public Overrides ReadOnly Property SaveID As String
            Get
                Return Constants.SkyNDSRom
            End Get
        End Property

        Public Overrides Sub DebugInfo()
            MyBase.DebugInfo()
            'Dim m = MonsterMDFile.FromBytes(IO.File.ReadAllBytes(IO.Path.Combine(PluginDefinition.GetResourceDirectory, "current\data\balance\monster.md")))
        End Sub

        Public Async Function GetPortraitsFile() As Task(Of Kaomado)
            Await EnsureUnpacked()
            Dim x = New Kaomado(IO.Path.Combine(PluginDefinition.GetResourceDirectory, "current\data\font\kaomado.kao"))
            Await x.EnsureUnpacked
            Return x
        End Function
        Public Async Function GetPersonalityTestOverlay() As Task(Of Overlay13)
            Await EnsureUnpacked()
            Return New Overlay13(IO.Path.Combine(Environment.CurrentDirectory, "Resources\Plugins\ROMEditor\Current\overlay\overlay_0013.bin"))
        End Function
        Public Async Function GetLanguageString() As Task(Of LanguageString)
            Await EnsureUnpacked()
            Return New LanguageString
        End Function
    End Class
End Namespace