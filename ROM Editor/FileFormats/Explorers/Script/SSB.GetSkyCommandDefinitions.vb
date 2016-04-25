﻿Namespace FileFormats.Explorers.Script
    Partial Class SSB
        Protected Shared Function GetSkyCommandDefinitions() As List(Of CommandDefinition)
            Dim out As New List(Of CommandDefinition)
            out.Add(New CommandDefinition(&H000, 0))
            out.Add(New CommandDefinition(&H001, 1))
            out.Add(New CommandDefinition(&H002, 1))
            out.Add(New CommandDefinition(&H003, 2))
            out.Add(New CommandDefinition(&H004, 2))
            out.Add(New CommandDefinition(&H005, 2))
            out.Add(New CommandDefinition(&H006, 6))
            out.Add(New CommandDefinition(&H007, 2))
            out.Add(New CommandDefinition(&H008, 2))
            out.Add(New CommandDefinition(&H009, 1))
            out.Add(New CommandDefinition(&H00A, 0))
            out.Add(New CommandDefinition(&H00B, 2))
            out.Add(New CommandDefinition(&H00C, 2))
            out.Add(New CommandDefinition(&H00D, 2))
            out.Add(New CommandDefinition(&H00E, 1))
            out.Add(New CommandDefinition(&H00F, 1))
            out.Add(New CommandDefinition(&H010, 2))
            out.Add(New CommandDefinition(&H011, 2))
            out.Add(New CommandDefinition(&H012, 1))
            out.Add(New CommandDefinition(&H013, 2))
            out.Add(New CommandDefinition(&H014, 2))
            out.Add(New CommandDefinition(&H015, 2))
            out.Add(New CommandDefinition(&H016, 2))
            out.Add(New CommandDefinition(&H017, 1))
            out.Add(New CommandDefinition(&H018, 1))
            out.Add(New CommandDefinition(&H019, 3))
            out.Add(New CommandDefinition(&H01A, 1))
            out.Add(New CommandDefinition(&H01B, 1))
            out.Add(New CommandDefinition(&H01C, 2))
            out.Add(New CommandDefinition(&H01D, 2))
            out.Add(New CommandDefinition(&H01E, 1))
            out.Add(New CommandDefinition(&H01F, 1))
            out.Add(New CommandDefinition(&H020, 3, "SOUND:FadeInBgm"))
            out.Add(New CommandDefinition(&H021, 0))
            out.Add(New CommandDefinition(&H022, 2))
            out.Add(New CommandDefinition(&H023, 1))
            out.Add(New CommandDefinition(&H024, 1))
            out.Add(New CommandDefinition(&H025, 3))
            out.Add(New CommandDefinition(&H026, 0))
            out.Add(New CommandDefinition(&H027, 2))
            out.Add(New CommandDefinition(&H028, 3))
            out.Add(New CommandDefinition(&H029, 3))
            out.Add(New CommandDefinition(&H02A, 2))
            out.Add(New CommandDefinition(&H02B, 2))
            out.Add(New CommandDefinition(&H02C, 2))
            out.Add(New CommandDefinition(&H02D, 3))
            out.Add(New CommandDefinition(&H02E, 4))
            out.Add(New CommandDefinition(&H02F, 4))
            out.Add(New CommandDefinition(&H030, 4))
            out.Add(New CommandDefinition(&H031, 4))
            out.Add(New CommandDefinition(&H032, 4))
            out.Add(New CommandDefinition(&H033, 4))
            out.Add(New CommandDefinition(&H034, 4))
            out.Add(New CommandDefinition(&H035, 4))
            out.Add(New CommandDefinition(&H036, 2))
            out.Add(New CommandDefinition(&H037, 1))
            out.Add(New CommandDefinition(&H038, 1))
            out.Add(New CommandDefinition(&H039, 1))
            out.Add(New CommandDefinition(&H03A, 1))
            out.Add(New CommandDefinition(&H03B, 1))
            'out.Add(New CommandDefinition(&H03C, 0)) 'Unknown
            out.Add(New CommandDefinition(&H03D, 5))
            out.Add(New CommandDefinition(&H03E, 1))
            out.Add(New CommandDefinition(&H03F, 1))
            out.Add(New CommandDefinition(&H040, 1))
            'out.Add(New CommandDefinition(&H041, 0))'Unknown
            out.Add(New CommandDefinition(&H042, 5))
            out.Add(New CommandDefinition(&H043, 1))
            out.Add(New CommandDefinition(&H044, 1))
            out.Add(New CommandDefinition(&H045, 1))
            'out.Add(New CommandDefinition(&H046, 0))'Unknown
            out.Add(New CommandDefinition(&H047, 5))
            out.Add(New CommandDefinition(&H048, 0))
            out.Add(New CommandDefinition(&H049, 3))
            out.Add(New CommandDefinition(&H04A, 0))
            out.Add(New CommandDefinition(&H04B, 0))
            out.Add(New CommandDefinition(&H04C, 4))
            out.Add(New CommandDefinition(&H04D, 1))
            out.Add(New CommandDefinition(&H04E, 1))
            out.Add(New CommandDefinition(&H04F, 1))
            'out.Add(New CommandDefinition(&H050, 0))'Unknown
            out.Add(New CommandDefinition(&H051, 5))
            out.Add(New CommandDefinition(&H052, 1))
            out.Add(New CommandDefinition(&H053, 1))
            out.Add(New CommandDefinition(&H054, 1))
            'out.Add(New CommandDefinition(&H055, 0))'Unknown
            out.Add(New CommandDefinition(&H056, 5))
            out.Add(New CommandDefinition(&H057, 1))
            out.Add(New CommandDefinition(&H058, 1))
            out.Add(New CommandDefinition(&H059, 1))
            'out.Add(New CommandDefinition(&H05A, 0))'Unknown
            out.Add(New CommandDefinition(&H05B, 5))
            out.Add(New CommandDefinition(&H05C, 0))
            out.Add(New CommandDefinition(&H05D, 3))
            out.Add(New CommandDefinition(&H05E, 0))
            out.Add(New CommandDefinition(&H05F, 0))
            out.Add(New CommandDefinition(&H060, 4))
            out.Add(New CommandDefinition(&H061, 0))
            out.Add(New CommandDefinition(&H062, 1))
            out.Add(New CommandDefinition(&H063, 2))
            out.Add(New CommandDefinition(&H064, 2))
            out.Add(New CommandDefinition(&H065, 2))
            out.Add(New CommandDefinition(&H066, 3))
            out.Add(New CommandDefinition(&H067, 2))
            out.Add(New CommandDefinition(&H068, 3))
            out.Add(New CommandDefinition(&H069, 3))
            out.Add(New CommandDefinition(&H06A, 1))
            out.Add(New CommandDefinition(&H06B, 1))
            out.Add(New CommandDefinition(&H06C, 2))
            out.Add(New CommandDefinition(&H06D, 2))
            out.Add(New CommandDefinition(&H06E, 1))
            out.Add(New CommandDefinition(&H06F, 0))
            out.Add(New CommandDefinition(&H070, 0))
            out.Add(New CommandDefinition(&H071, 0))
            out.Add(New CommandDefinition(&H072, 1))
            out.Add(New CommandDefinition(&H073, 2))
            out.Add(New CommandDefinition(&H074, 3))
            out.Add(New CommandDefinition(&H075, 3))
            out.Add(New CommandDefinition(&H076, 3))
            out.Add(New CommandDefinition(&H077, 1))
            out.Add(New CommandDefinition(&H078, 1))
            out.Add(New CommandDefinition(&H079, 2))
            out.Add(New CommandDefinition(&H07A, 0))
            out.Add(New CommandDefinition(&H07B, 1))
            out.Add(New CommandDefinition(&H07C, 1))
            out.Add(New CommandDefinition(&H07D, 2))
            out.Add(New CommandDefinition(&H07E, 2))
            out.Add(New CommandDefinition(&H07F, 2))
            out.Add(New CommandDefinition(&H080, 3))
            out.Add(New CommandDefinition(&H081, 0))
            out.Add(New CommandDefinition(&H082, 0))
            out.Add(New CommandDefinition(&H083, 2))
            out.Add(New CommandDefinition(&H084, 3))
            out.Add(New CommandDefinition(&H085, 2))
            out.Add(New CommandDefinition(&H086, 2))
            out.Add(New CommandDefinition(&H087, 1))
            out.Add(New CommandDefinition(&H088, 1))
            out.Add(New CommandDefinition(&H089, 1))
            out.Add(New CommandDefinition(&H08A, 1))
            out.Add(New CommandDefinition(&H08B, 1))
            out.Add(New CommandDefinition(&H08C, 2))
            out.Add(New CommandDefinition(&H08D, 2))
            out.Add(New CommandDefinition(&H08E, 2))
            out.Add(New CommandDefinition(&H08F, 3))
            out.Add(New CommandDefinition(&H090, 1))
            out.Add(New CommandDefinition(&H091, 2))
            out.Add(New CommandDefinition(&H092, 2))
            out.Add(New CommandDefinition(&H093, 1))
            out.Add(New CommandDefinition(&H094, 1))
            out.Add(New CommandDefinition(&H095, 0))
            out.Add(New CommandDefinition(&H096, 0)) 'pausescript
            out.Add(New CommandDefinition(&H097, 0))
            out.Add(New CommandDefinition(&H098, 1))
            out.Add(New CommandDefinition(&H099, 2))
            out.Add(New CommandDefinition(&H09A, 1))
            out.Add(New CommandDefinition(&H09B, 0))
            out.Add(New CommandDefinition(&H09C, 1))
            out.Add(New CommandDefinition(&H09D, 1))
            out.Add(New CommandDefinition(&H09E, 1, "WINDOW:Monologue"))
            out.Add(New CommandDefinition(&H09F, 2))
            out.Add(New CommandDefinition(&H0A0, 1, "WINDOW:SysMsg"))
            out.Add(New CommandDefinition(&H0A1, 0))
            out.Add(New CommandDefinition(&H0A2, 0)) 'deletepicspeak
            out.Add(New CommandDefinition(&H0A3, 1))
            out.Add(New CommandDefinition(&H0A4, 3))
            out.Add(New CommandDefinition(&H0A5, 3))
            out.Add(New CommandDefinition(&H0A6, 3))
            out.Add(New CommandDefinition(&H0A7, 1))
            out.Add(New CommandDefinition(&H0A8, 2))
            out.Add(New CommandDefinition(&H0A9, 1))
            out.Add(New CommandDefinition(&H0AA, 2)) ', "msgChoice"))
            out.Add(New CommandDefinition(&H0AB, 3))
            out.Add(New CommandDefinition(&H0AC, 1)) ', "msgHeroType"))
            out.Add(New CommandDefinition(&H0AD, 1)) ', "msgPartnerType"))
            out.Add(New CommandDefinition(&H0AE, 1, "WINDOW:Talk"))
            out.Add(New CommandDefinition(&H0AF, 3))
            out.Add(New CommandDefinition(&H0B0, 2))
            'out.Add(New CommandDefinition(&H0B1, 0))'Unknown
            out.Add(New CommandDefinition(&H0B2, 5))
            'out.Add(New CommandDefinition(&H0B3, 0))'Unknown
            out.Add(New CommandDefinition(&H0B4, 3))
            out.Add(New CommandDefinition(&H0B5, 3))
            out.Add(New CommandDefinition(&H0B6, 3))
            out.Add(New CommandDefinition(&H0B7, 2))
            'out.Add(New CommandDefinition(&H0B8, 0)) 'Unknown
            out.Add(New CommandDefinition(&H0B9, 5))
            'out.Add(New CommandDefinition(&H0BA, 0)) 'Unknown
            out.Add(New CommandDefinition(&H0BB, 3))
            out.Add(New CommandDefinition(&H0BC, 3))
            out.Add(New CommandDefinition(&H0BD, 3))
            out.Add(New CommandDefinition(&H0BE, 2))
            out.Add(New CommandDefinition(&H0BF, 3))
            out.Add(New CommandDefinition(&H0C0, 2))
            out.Add(New CommandDefinition(&H0C1, 3))
            'out.Add(New CommandDefinition(&H0C2, 10))'Unknown
            out.Add(New CommandDefinition(&H0C3, 5))
            out.Add(New CommandDefinition(&H0C4, 6))
            'out.Add(New CommandDefinition(&H0C5, 0))'Unknown
            out.Add(New CommandDefinition(&H0C6, 3))
            out.Add(New CommandDefinition(&H0C7, 3))
            out.Add(New CommandDefinition(&H0C8, 3))
            out.Add(New CommandDefinition(&H0C9, 1))
            out.Add(New CommandDefinition(&H0CA, 1))
            out.Add(New CommandDefinition(&H0CB, 1))
            out.Add(New CommandDefinition(&H0CC, 3))
            out.Add(New CommandDefinition(&H0CD, 4))
            out.Add(New CommandDefinition(&H0CE, 4))
            out.Add(New CommandDefinition(&H0CF, 1))
            out.Add(New CommandDefinition(&H0D0, 1))
            out.Add(New CommandDefinition(&H0D1, 1))
            out.Add(New CommandDefinition(&H0D2, 1))
            out.Add(New CommandDefinition(&H0D3, 1))
            out.Add(New CommandDefinition(&H0D4, 1))
            out.Add(New CommandDefinition(&H0D5, 0))
            out.Add(New CommandDefinition(&H0D6, 1))
            out.Add(New CommandDefinition(&H0D7, 4))
            out.Add(New CommandDefinition(&H0D8, 4))
            out.Add(New CommandDefinition(&H0D9, 2))
            out.Add(New CommandDefinition(&H0DA, 2))
            out.Add(New CommandDefinition(&H0DB, 2))
            out.Add(New CommandDefinition(&H0DC, 2))
            out.Add(New CommandDefinition(&H0DD, 8))
            out.Add(New CommandDefinition(&H0DE, 6))
            out.Add(New CommandDefinition(&H0DF, 6))
            out.Add(New CommandDefinition(&H0E0, 4))
            out.Add(New CommandDefinition(&H0E1, 4))
            out.Add(New CommandDefinition(&H0E2, 2))
            out.Add(New CommandDefinition(&H0E3, 2))
            out.Add(New CommandDefinition(&H0E4, 2))
            out.Add(New CommandDefinition(&H0E5, 2))
            out.Add(New CommandDefinition(&H0E6, 4))
            out.Add(New CommandDefinition(&H0E7, 4))
            out.Add(New CommandDefinition(&H0E8, 2))
            out.Add(New CommandDefinition(&H0E9, 2))
            out.Add(New CommandDefinition(&H0EA, 2))
            out.Add(New CommandDefinition(&H0EB, 2))
            out.Add(New CommandDefinition(&H0EC, 8))
            out.Add(New CommandDefinition(&H0ED, 6))
            out.Add(New CommandDefinition(&H0EE, 6))
            out.Add(New CommandDefinition(&H0EF, 4))
            out.Add(New CommandDefinition(&H0F0, 4))
            out.Add(New CommandDefinition(&H0F1, 2))
            out.Add(New CommandDefinition(&H0F2, 2))
            out.Add(New CommandDefinition(&H0F3, 2))
            out.Add(New CommandDefinition(&H0F4, 2))
            out.Add(New CommandDefinition(&H0F5, 3))
            out.Add(New CommandDefinition(&H0F6, 3))
            out.Add(New CommandDefinition(&H0F7, 2))
            out.Add(New CommandDefinition(&H0F8, 1))
            out.Add(New CommandDefinition(&H0F9, 3))
            out.Add(New CommandDefinition(&H0FA, 2))
            out.Add(New CommandDefinition(&H0FB, 2))
            out.Add(New CommandDefinition(&H0FC, 1))
            out.Add(New CommandDefinition(&H0FD, 1))
            out.Add(New CommandDefinition(&H0FE, 1))
            out.Add(New CommandDefinition(&H0FF, 2))
            out.Add(New CommandDefinition(&H100, 1))
            out.Add(New CommandDefinition(&H101, 2))
            out.Add(New CommandDefinition(&H102, 2))
            out.Add(New CommandDefinition(&H103, 1))
            out.Add(New CommandDefinition(&H104, 1))
            out.Add(New CommandDefinition(&H105, 1))
            out.Add(New CommandDefinition(&H106, 6))
            out.Add(New CommandDefinition(&H107, 1))
            out.Add(New CommandDefinition(&H108, 2))
            out.Add(New CommandDefinition(&H109, 0))
            out.Add(New CommandDefinition(&H10A, 1))
            out.Add(New CommandDefinition(&H10B, 4))
            out.Add(New CommandDefinition(&H10C, 2))
            out.Add(New CommandDefinition(&H10D, 2))
            out.Add(New CommandDefinition(&H10E, 1))
            out.Add(New CommandDefinition(&H10F, 3))
            out.Add(New CommandDefinition(&H110, 3))
            out.Add(New CommandDefinition(&H111, 2))
            'out.Add(New CommandDefinition(&H112, 0))'Unknown
            out.Add(New CommandDefinition(&H113, 5))
            'out.Add(New CommandDefinition(&H114, 0))'Unknown
            out.Add(New CommandDefinition(&H115, 3))
            out.Add(New CommandDefinition(&H116, 3))
            out.Add(New CommandDefinition(&H117, 3))
            out.Add(New CommandDefinition(&H118, 2))
            'out.Add(New CommandDefinition(&H119, 0)) 'Unknown
            out.Add(New CommandDefinition(&H11A, 5))
            'out.Add(New CommandDefinition(&H11B, 0)) 'Unknown
            out.Add(New CommandDefinition(&H11C, 3))
            out.Add(New CommandDefinition(&H11D, 3))
            out.Add(New CommandDefinition(&H11E, 2))
            out.Add(New CommandDefinition(&H11F, 3))
            out.Add(New CommandDefinition(&H120, 2))
            out.Add(New CommandDefinition(&H121, 3))
            'out.Add(New CommandDefinition(&H122, 0))'Unknown
            out.Add(New CommandDefinition(&H123, 5))
            out.Add(New CommandDefinition(&H124, 6))
            'out.Add(New CommandDefinition(&H125, 0))'Unknown
            out.Add(New CommandDefinition(&H126, 3))
            out.Add(New CommandDefinition(&H127, 1))
            out.Add(New CommandDefinition(&H128, 0, "SOUND:StopBgm"))
            out.Add(New CommandDefinition(&H129, 0))
            out.Add(New CommandDefinition(&H12A, 1))
            out.Add(New CommandDefinition(&H12B, 1))
            out.Add(New CommandDefinition(&H12C, 3))
            out.Add(New CommandDefinition(&H12D, 3))
            out.Add(New CommandDefinition(&H12E, 1))
            out.Add(New CommandDefinition(&H12F, 1))
            out.Add(New CommandDefinition(&H130, 3))
            out.Add(New CommandDefinition(&H131, 2))
            out.Add(New CommandDefinition(&H132, 2))
            out.Add(New CommandDefinition(&H133, 3))
            out.Add(New CommandDefinition(&H134, 1))
            out.Add(New CommandDefinition(&H135, 1))
            out.Add(New CommandDefinition(&H136, 2))
            out.Add(New CommandDefinition(&H137, 1))
            out.Add(New CommandDefinition(&H138, 1))
            out.Add(New CommandDefinition(&H139, 1))
            out.Add(New CommandDefinition(&H13A, 3))
            out.Add(New CommandDefinition(&H13B, 1))
            out.Add(New CommandDefinition(&H13C, 1))
            out.Add(New CommandDefinition(&H13D, 1))
            out.Add(New CommandDefinition(&H13E, 3))
            out.Add(New CommandDefinition(&H13F, 1))
            out.Add(New CommandDefinition(&H140, 1))
            out.Add(New CommandDefinition(&H141, 1))
            out.Add(New CommandDefinition(&H142, 1))
            out.Add(New CommandDefinition(&H143, 4))
            out.Add(New CommandDefinition(&H144, 1))
            out.Add(New CommandDefinition(&H145, 1))
            out.Add(New CommandDefinition(&H146, 1))
            out.Add(New CommandDefinition(&H147, 1))
            out.Add(New CommandDefinition(&H148, 1))
            out.Add(New CommandDefinition(&H149, 0))
            out.Add(New CommandDefinition(&H14A, 3))
            out.Add(New CommandDefinition(&H14B, 3))
            out.Add(New CommandDefinition(&H14C, 3))
            out.Add(New CommandDefinition(&H14D, 3))
            out.Add(New CommandDefinition(&H14E, 3))
            out.Add(New CommandDefinition(&H14F, 8))
            out.Add(New CommandDefinition(&H150, 3))
            out.Add(New CommandDefinition(&H151, 4))
            out.Add(New CommandDefinition(&H152, 1))
            out.Add(New CommandDefinition(&H153, 2))
            out.Add(New CommandDefinition(&H154, 2))
            out.Add(New CommandDefinition(&H155, 5))
            out.Add(New CommandDefinition(&H156, 1))
            out.Add(New CommandDefinition(&H157, 1, "TASK:Sleep"))
            out.Add(New CommandDefinition(&H158, 0))
            out.Add(New CommandDefinition(&H159, 0))
            out.Add(New CommandDefinition(&H15A, 0))
            out.Add(New CommandDefinition(&H15B, 1))
            out.Add(New CommandDefinition(&H15C, 1))
            out.Add(New CommandDefinition(&H15D, 0))
            out.Add(New CommandDefinition(&H15E, 0))
            out.Add(New CommandDefinition(&H15F, 0))
            out.Add(New CommandDefinition(&H160, 1))
            out.Add(New CommandDefinition(&H161, 1))
            out.Add(New CommandDefinition(&H162, 1))
            out.Add(New CommandDefinition(&H163, 0))
            out.Add(New CommandDefinition(&H164, 2))
            out.Add(New CommandDefinition(&H165, 2))
            out.Add(New CommandDefinition(&H166, 2))
            out.Add(New CommandDefinition(&H167, 1))
            out.Add(New CommandDefinition(&H168, 1))
            out.Add(New CommandDefinition(&H169, 0))
            out.Add(New CommandDefinition(&H16A, 0))
            out.Add(New CommandDefinition(&H16B, 2))
            out.Add(New CommandDefinition(&H16C, 0))
            out.Add(New CommandDefinition(&H16D, 0))
            out.Add(New CommandDefinition(&H16E, 0))
            out.Add(New CommandDefinition(&H16F, 1))
            out.Add(New CommandDefinition(&H170, 0))
            out.Add(New CommandDefinition(&H171, 0))
            out.Add(New CommandDefinition(&H172, 0))
            out.Add(New CommandDefinition(&H173, 1))
            out.Add(New CommandDefinition(&H174, 1))
            out.Add(New CommandDefinition(&H175, 0))
            out.Add(New CommandDefinition(&H176, 1))
            out.Add(New CommandDefinition(&H177, 0))
            out.Add(New CommandDefinition(&H178, 1))
            out.Add(New CommandDefinition(&H179, 1))
            out.Add(New CommandDefinition(&H17A, 1))
            out.Add(New CommandDefinition(&H17B, 1))
            out.Add(New CommandDefinition(&H17C, 1))
            out.Add(New CommandDefinition(&H17D, 1))
            out.Add(New CommandDefinition(&H17E, 1))
            Return out
        End Function
    End Class
End Namespace
