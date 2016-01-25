﻿Imports SkyEditorBase
Imports SkyEditorBase.Interfaces

Namespace Projects
    Public Class DSModPackProject
        Inherits Project
        Implements iContainer(Of ModpackInfo)

        Public Property Info As ModpackInfo Implements Interfaces.iContainer(Of ModpackInfo).Item
            Get
                Return Me.Setting("ModpackInfo")
            End Get
            Set(value As ModpackInfo)
                Me.Setting("ModpackInfo") = value
            End Set
        End Property

        Public Property BaseRomProject As String
            Get
                Return Me.Setting("BaseRomProject")
            End Get
            Set(value As String)
                Me.Setting("BaseRomProject") = value
            End Set
        End Property

        ''' <summary>
        ''' Gets the directory non-project mods are stored in.
        ''' </summary>
        ''' <returns></returns>
        Public Overridable Function GetSourceModsDir() As String
            Return IO.Path.Combine(GetRootDirectory, "Mods")
        End Function

        'Gets the directory mods in the current modpack build are stored in.
        Public Overridable Function GetModsDir() As String
            Return IO.Path.Combine(GetModPackDir, "Mods")
        End Function
        Public Overridable Function GetToolsDir() As String
            Return IO.Path.Combine(GetModPackDir, "Tools")
        End Function
        Public Overridable Function GetPatchersDir() As String
            Return IO.Path.Combine(GetModPackDir, "Tools", "Patchers")
        End Function
        Public Overridable Function GetModPackDir() As String
            Return IO.Path.Combine(IO.Path.GetDirectoryName(Me.Filename), "Modpack Files")
        End Function

        ''' <summary>
        ''' Gets the directory the modpack will be outputted to.
        ''' </summary>
        ''' <returns></returns>
        Public Overridable Function OutputDir() As String
            Return IO.Path.Combine(IO.Path.GetDirectoryName(Me.Filename), "Output")
        End Function

        Public Overridable Function GetBaseRomFilename(Solution As Solution) As String
            Dim p As BaseRomProject = Solution.GetProjectsByName(BaseRomProject).FirstOrDefault
            Return p.GetProjectItemByPath("/BaseRom").GetFilename
        End Function

        Public Overrides Function CanBuild(Solution As Solution) As Boolean
            Dim p As BaseRomProject = Solution.GetProjectsByName(BaseRomProject).FirstOrDefault
            Return (p IsNot Nothing)
        End Function

        Public Overrides Async Function Build(Solution As Solution) As Task
            Const patcherVersion As String = "alpha 4"
            Dim modpackDir = GetModPackDir()
            Dim modpackModsDir = GetModsDir()
            Dim modpackToolsDir = GetToolsDir()
            Dim modpackToolsPatchersDir = GetPatchersDir()
            Dim modsSourceDir = GetSourceModsDir()

            If Not IO.Directory.Exists(modpackDir) Then
                IO.Directory.CreateDirectory(modpackDir)
            End If
            If Not IO.Directory.Exists(modpackModsDir) Then
                IO.Directory.CreateDirectory(modpackModsDir)
            End If
            If Not IO.Directory.Exists(modpackToolsDir) Then
                IO.Directory.CreateDirectory(modpackToolsDir)
            End If
            If Not IO.Directory.Exists(modpackToolsPatchersDir) Then
                IO.Directory.CreateDirectory(modpackToolsPatchersDir)
            End If
            If Not IO.Directory.Exists(modsSourceDir) Then
                IO.Directory.CreateDirectory(modsSourceDir)
            End If
            If Not IO.Directory.Exists(OutputDir) Then
                IO.Directory.CreateDirectory(OutputDir)
            End If

            'Clear the files that are currently in the modpack directory
            For Each item In IO.Directory.GetFiles(modpackDir)
                IO.File.Delete(item)
            Next

            'Copy external mods
            For Each item In IO.Directory.GetFiles(modsSourceDir)
                Dim sourceFilename = item
                Dim destFilename = IO.Path.Combine(modpackModsDir, IO.Path.GetFileName(sourceFilename))
                IO.File.Copy(sourceFilename, destFilename, True)
            Next

            'Copy mods from other projects
            For Each item In Me.GetReferences(Solution)
                If TypeOf item Is GenericModProject Then
                    Dim sourceFilename = DirectCast(item, GenericModProject).GetModOutputFilename(BaseRomProject)
                    Dim destFilename = IO.Path.Combine(modpackModsDir, IO.Path.GetFileName(sourceFilename))
                    If IO.File.Exists(sourceFilename) Then
                        IO.File.Copy(sourceFilename, destFilename, True)
                    End If
                End If
            Next

            Dim patchers As New List(Of FilePatcher)
            '-Copy xdelta
            'IO.File.Copy(PluginHelper.GetResourceName("xdelta/xdelta3.exe"), IO.Path.Combine(toolsDir, "xdelta3.exe"), True)
            '-Ensure xdelta is registered as a patching program
            Dim xdelta As New FilePatcher
            xdelta.ApplyPatchProgram = "xdelta\xdelta3.exe"
            xdelta.ApplyPatchArguments = "-d -n -s ""{0}"" ""{1}"" ""{2}"""
            xdelta.MergeSafe = False
            xdelta.PatchExtension = "xdelta"
            patchers.Add(xdelta)
            '-Copy patchers
            IO.File.WriteAllText(IO.Path.Combine(modpackToolsDir, "patchers.json"), Utilities.Json.Serialize(patchers))
            For Each item In patchers
                If Not IO.Directory.Exists(IO.Path.GetDirectoryName(IO.Path.Combine(GetPatchersDir, item.ApplyPatchProgram))) Then
                    IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(IO.Path.Combine(GetPatchersDir, item.ApplyPatchProgram)))
                End If
                IO.File.Copy(IO.Path.Combine(PluginHelper.GetResourceDirectory, item.ApplyPatchProgram), IO.Path.Combine(GetPatchersDir, item.ApplyPatchProgram), True)
                '--Copy Dependencies
                If item.ApplyPatchDependencies IsNot Nothing Then
                    For Each d In item.ApplyPatchDependencies
                        If Not IO.Directory.Exists(IO.Path.GetDirectoryName(IO.Path.Combine(GetPatchersDir, d.Value))) Then
                            IO.Directory.CreateDirectory(IO.Path.GetDirectoryName(IO.Path.Combine(GetPatchersDir, d.Value)))
                        End If
                        IO.File.Copy(IO.Path.Combine(PluginHelper.GetResourceDirectory, d.Key), IO.Path.Combine(GetPatchersDir, d.Value), True)
                    Next
                End If
            Next

            CopyPatcherProgram(Solution)

            IO.File.WriteAllText(IO.Path.Combine(modpackModsDir, "Modpack Info"), Utilities.Json.Serialize(Me.Info))

            '-Zip it
            Utilities.Zip.Zip(modpackDir, IO.Path.Combine(OutputDir, Me.Info.Name & " " & Me.Info.Version & "-" & patcherVersion & ".zip"))

            'Apply patch
            PluginHelper.StartLoading(PluginHelper.GetLanguageItem("Applying patch", "Applying patch..."))

            Await ApplyPatchAsync(Solution)
        End Function

        Public Overridable Sub CopyPatcherProgram(Solution As Solution)
            Select Case Solution.Setting("System")
                Case "3DS"
                    '-Copy ctrtool
                    IO.File.Copy(PluginHelper.GetResourceName("ctrtool.exe"), IO.Path.Combine(GetToolsDir, "ctrtool.exe"), True)
                    IO.File.Copy(PluginHelper.GetResourceName("3DS Builder.exe"), IO.Path.Combine(GetToolsDir, "3DS Builder.exe"), True)
                Case "NDS"
                    '-Copy ndstool
                    IO.File.Copy(PluginHelper.GetResourceName("ndstool.exe"), IO.Path.Combine(GetToolsDir, "ndstool.exe"), True)
                Case Else
                    PluginHelper.Writeline("Unknown system.  Not copying appropriate tools.", PluginHelper.LineType.Error)
            End Select

            '-Copy patching wizard
            IO.File.Copy(PluginHelper.GetResourceName("DSPatcher.exe"), IO.Path.Combine(GetModPackDir, "DSPatcher.exe"), True)
            IO.File.Copy(PluginHelper.GetResourceName("ICSharpCode.SharpZipLib.dll"), IO.Path.Combine(GetModPackDir, "ICSharpCode.SharpZipLib.dll"), True)
        End Sub

        Public Overridable Async Function ApplyPatchAsync(Solution As Solution) As Task
            Select Case Solution.Setting("System")
                Case "3DS"
                    Await PluginHelper.RunProgram(IO.Path.Combine(GetModPackDir, "DSPatcher.exe"), String.Format("""{0}"" ""{1}""", GetBaseRomFilename(Solution), IO.Path.Combine(OutputDir, "PatchedRom.3ds")), False)
                Case "NDS"
                    Await PluginHelper.RunProgram(IO.Path.Combine(GetModPackDir, "DSPatcher.exe"), String.Format("""{0}"" ""{1}""", GetBaseRomFilename(Solution), IO.Path.Combine(OutputDir, "PatchedRom.nds")), False)
            End Select
        End Function
    End Class

End Namespace