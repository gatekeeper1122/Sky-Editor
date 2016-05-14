﻿Imports ROMEditor.FileFormats.PSMD
Imports SkyEditor.Core.ConsoleCommands
Imports SkyEditorBase

Namespace ConsoleCommands
    Public Class PSMDLangSearch
        Inherits ConsoleCommandAsync

        Public Overrides Async Function MainAsync(Arguments() As String) As Task
            If IO.Directory.Exists(Arguments(0)) Then
                Dim languageEntries As New Dictionary(Of String, Dictionary(Of UInteger, String))
                Dim totalList As New Dictionary(Of UInteger, String)
                For Each item In IO.Directory.GetFiles(Arguments(0))
                    Dim msg As New MessageBin
                    Await msg.OpenFile(item, New SkyEditor.Core.Windows.IOProvider)
                    languageEntries.Add(IO.Path.GetFileNameWithoutExtension(item), New Dictionary(Of UInteger, String))
                    For Each s In msg.Strings
                        languageEntries(IO.Path.GetFileNameWithoutExtension(item)).Add(s.Hash, s.Entry)
                        If Not totalList.ContainsKey(s.Hash) Then
                            totalList.Add(s.Hash, s.Entry)
                        Else
                            Console.WriteLine("Unable to add " & s.Hash & ": " & s.Entry)
                        End If
                    Next
                    msg.Dispose()
                Next

                Dim q = (From s In totalList Where s.Value.Contains("Stick")).ToList

                Console.WriteLine("Language loaded.")
                Console.WriteLine("In-console searching not implemented.  Please attach debugger.")
            Else
                Console.WriteLine($"Directory ""{Arguments(0)}"" not found.")
            End If
        End Function
    End Class

End Namespace
