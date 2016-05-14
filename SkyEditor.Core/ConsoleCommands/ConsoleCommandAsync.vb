﻿Namespace ConsoleCommands
    Public MustInherit Class ConsoleCommandAsync
        Public MustOverride Function MainAsync(Arguments As String()) As Task
        Public Overridable ReadOnly Property CommandName As String
            Get
                Return Me.GetType.Name
            End Get
        End Property

    End Class

End Namespace

