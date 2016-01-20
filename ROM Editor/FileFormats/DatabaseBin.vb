﻿Imports SkyEditorBase
Imports SkyEditorBase.Interfaces

Namespace FileFormats
    Public Class DatabaseBin
        Implements iOpenableFile

        ''' <summary>
        ''' Matches string hashes to the strings contained in the file.
        ''' </summary>
        ''' <returns>The games' scripts refer to the strings by this hash.</returns>
        Public Property Strings As List(Of String)

        Public Sub OpenFile(Filename As String) Implements iOpenableFile.OpenFile
            Dim total As New Text.StringBuilder
            Using f As New GenericFile(Filename, True)
                Dim subHeaderPointer = f.Int(4)
                Dim stringPointerOffset = f.Int(subHeaderPointer + 4)
                Dim numEntries = f.Int(subHeaderPointer + 8) * 4

                For count = 0 To numEntries - 1
                    Dim entryPointer = f.Int(stringPointerOffset + count * 4)

                    If entryPointer > 0 Then
                        Dim s As New Text.StringBuilder()
                        Dim e = Text.UnicodeEncoding.Unicode

                        'Parse the null-terminated UTF-16 string
                        Dim j As Integer = 0
                        Dim cRaw As Byte()
                        Dim c As String
                        Do
                            cRaw = f.RawData(entryPointer + j * 2, 2)
                            c = e.GetString(cRaw)

                            If Not c = vbNullChar Then
                                s.Append(c)
                            End If

                            j += 1
                        Loop Until c = vbNullChar

                        Strings.Add(s.ToString)
                        total.AppendLine(s.ToString)
                    Else
                        Strings.Add("")
                    End If
                Next
            End Using
        End Sub

        Public Sub New()
            MyBase.New
            Strings = New List(Of String)
        End Sub
    End Class

End Namespace