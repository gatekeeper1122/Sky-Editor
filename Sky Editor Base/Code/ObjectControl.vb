﻿Public MustInherit Class ObjectControl
    Inherits UserControl
    Public Sub New()
        MyBase.New()
    End Sub

    Public Property ContainedObject As Object

    Public Overridable Sub RefreshDisplay()

    End Sub

    Public Overridable Sub UpdateObject()

    End Sub
    Overridable ReadOnly Property SupportedTypes As Type()
        Get
            Return {}
        End Get
    End Property
    ''' <summary>
    ''' Priority for this control to be used in relevant circumstances.  Higher values are more likely to be used.
    ''' Useless for ObjectTabs or EditorTabs.
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Overridable Function UsagePriority(Type As Type) As Integer
        Return 0
    End Function
End Class