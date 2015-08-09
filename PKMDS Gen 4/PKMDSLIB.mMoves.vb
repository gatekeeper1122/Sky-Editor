﻿Partial Class PokemonLib
    Class mMoves
        Implements SkyEditor.Interfaces.iAttack
        Public Value As Moves
        Public Name As String
        Public Power As UInt16
        Public Accuracy As Decimal
        Public BasePP As Byte
        Public CurrentPP As Byte
        Public TotalPP As Byte
        Public Type As mType
        Public Description As String
        Public BattleCategory As mBattleCategory
        Public ContestCategory As mContestCategory

        Public Sub New()
            Value = 0US
            Name = String.Empty
            Power = 0US
            Accuracy = 0D
            BasePP = 0
            CurrentPP = 0
            TotalPP = 0
            Type = New mType
            Description = String.Empty
            BattleCategory = New mBattleCategory
            ContestCategory = New mContestCategory
        End Sub

        Public Sub New(ByVal index As Moves)
            On Error Resume Next
            Value = index
            Name = dPKMMoves(index)(0)
            Power = UInt16.Parse(dPKMMoves(index)(3))
            Accuracy = Decimal.Parse(dPKMMoves(index)(5))
            Type = New mType(Byte.Parse(dPKMMoves(index)(4)))
            Description = dPKMMoves(index)(1)
            BasePP = Byte.Parse(dPKMMoves(index)(6))
            BattleCategory = New mBattleCategory(Val(dPKMMoves(index)(11)))
            ContestCategory = New mContestCategory(Val(dPKMMoves(index)(12)))
        End Sub

        Public Function GetAttackDictionary() As IDictionary(Of Integer, String) Implements SkyEditor.Interfaces.iAttack.GetAttackDictionary
            Dim out As New Dictionary(Of Integer, String)
            For Each item In dPKMMoves
                out.Add(item.Key, item.Value(0))
            Next
            Return out
        End Function

        Public Property ID As Integer Implements SkyEditor.Interfaces.iAttack.ID
            Get
                Return Value
            End Get
            Set(value As Integer)
                Me.Value = value
            End Set
        End Property
    End Class
End Class