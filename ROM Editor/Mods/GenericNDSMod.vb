﻿Imports System.Text
Imports SkyEditorBase

Namespace Mods
    Public Class ModSourceContainer
        Public Property ModName As String
        Public Property Author As String
        Public Property Description As String
        Public Property UpdateURL As String
        Public Property DependenciesBefore As List(Of String)
        Public Property DependenciesAfter As List(Of String)
        Public Property Version As String
    End Class
    Public Class GenericMod
        Inherits ObjectFile(Of ModSourceContainer)
        Public Sub New(Filename As String)
            MyBase.New(Filename)
        End Sub
        Public Sub New()
            MyBase.New
        End Sub

        Protected ReadOnly Property ModDirectory As String
            Get
                Return IO.Path.Combine(IO.Path.GetDirectoryName(OriginalFilename), IO.Path.GetFileNameWithoutExtension(OriginalFilename))
            End Get
        End Property
        Protected ReadOnly Property ModOutputDirectory As String
            Get
                Return IO.Path.Combine(IO.Path.GetDirectoryName(OriginalFilename), IO.Path.GetFileNameWithoutExtension(OriginalFilename), "ModFiles")
            End Get
        End Property
        Protected ReadOnly Property ROMDirectory As String
            Get
                Return IO.Path.Combine(IO.Path.GetDirectoryName(OriginalFilename), IO.Path.GetFileNameWithoutExtension(OriginalFilename), "RawFiles")
            End Get
        End Property


        Public Overridable Function FilesToCopy() As IEnumerable(Of String)
            Return New List(Of String)
        End Function
        Public Overridable Function SupportsDelete() As Boolean
            Return Not PluginHelper.IsMethodOverridden(Me.GetType.GetMethod("FilesToCopy"))
        End Function
        Public Overridable Async Function InitializeAsync(CurrentProject As Project) As Task
            Await Task.Run(New Action(Sub()
                                          Initialize(CurrentProject)
                                      End Sub))
        End Function
        Public Overridable Sub Initialize(CurrentProject As Project)

        End Sub
        Public Overridable Async Function BuildAsync(CurrentProject As Project) As Task
            Await Task.Run(New Action(Sub()
                                          Build(CurrentProject)
                                      End Sub))
        End Function
        Public Overridable Sub Build(CurrentProject As Project)

        End Sub
        Public Overridable Function SupportedGameCodes() As IEnumerable(Of Type)
            Return {GetType(Roms.iPackedRom)}
        End Function
        Public Overrides Function DefaultExtension() As String
            Return ".modsrc"
        End Function
    End Class

End Namespace