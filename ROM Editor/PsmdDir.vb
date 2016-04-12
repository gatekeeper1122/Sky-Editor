﻿Imports ROMEditor.FileFormats
Imports SkyEditorBase.Interfaces

Public Class PsmdDir
    Implements iOpenableFile
    Implements iContainer(Of PokemonDataInfo)
    Implements iContainer(Of Experience)

    Public Property PokemonInfo As PokemonDataInfo Implements iContainer(Of PokemonDataInfo).Item
    Public Property PokemonExpTable As Experience Implements iContainer(Of Experience).Item
    Public Property LanguageFiles As Dictionary(Of String, FarcF5)
    Public Property DungeonFixedPokemon As FixedPokemon
    Protected Property PokemonNameHashes As List(Of Integer)
    Public Property PokemonNames As List(Of String)
    Protected Property CommonLanguages As Dictionary(Of String, MessageBin)

    Public Function GetEnglishCommon() As MessageBin
        If CommonLanguages.ContainsKey("message_us.bin") Then
            Return CommonLanguages("message_us.bin")
        ElseIf CommonLanguages.ContainsKey("message_en.bin") Then
            Return CommonLanguages("message_en.bin")
        Else
            Return Nothing
        End If
    End Function

    Public Sub New()
        MyBase.New
    End Sub

    Public Sub OpenFile(RootDirectory As String) Implements iOpenableFile.OpenFile
        PokemonInfo = New PokemonDataInfo
        PokemonInfo.OpenFile(IO.Path.Combine(RootDirectory, "romfs", "pokemon", "pokemon_data_info.bin"))

        PokemonExpTable = New Experience
        PokemonExpTable.OpenFile(IO.Path.Combine(RootDirectory, "romfs", "pokemon", "experience.bin"))

        LanguageFiles = New Dictionary(Of String, FarcF5)
        CommonLanguages = New Dictionary(Of String, MessageBin)
        For Each item In {"message_en.bin", "message_fr.bin", "message_ge.bin", "message_it.bin", "message_sp.bin", "message_us.bin", "message.bin"}
            Dim filename = IO.Path.Combine(RootDirectory, "romfs", item)
            If IO.File.Exists(filename) Then
                Dim f As New FarcF5
                f.OpenFile(filename)
                LanguageFiles.Add(item, f)
                Dim m As New MessageBin
                m.CreateFile(item, f.GetFileData("common"))
                CommonLanguages.Add(item, m)
            End If
        Next

        DungeonFixedPokemon = New FixedPokemon
        DungeonFixedPokemon.OpenFile(IO.Path.Combine(RootDirectory, "romfs", "dungeon", "fixed_pokemon.bin"))

        PokemonNameHashes = New List(Of Integer)
        For Each item In My.Resources.PSMD_Pokemon_Name_Hashes.Split(vbCrLf)
            PokemonNameHashes.Add(CInt(item.Trim))
        Next

        Dim en = GetEnglishCommon()
        PokemonNames = New List(Of String)
        PokemonNames.Add("-----")
        For Each item In PokemonNameHashes
            PokemonNames.Add(((From s In en.Strings Where s.HashSigned = item).First).Entry)
        Next
    End Sub
End Class