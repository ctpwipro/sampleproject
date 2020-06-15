
Partial Class _Default
    Inherits Page

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        Dim t As New B()
        t.i = 9
        t.X()
        t.F()
        Dim f = Net.GlobalProxySelection.GetEmptyWebProxy()

    End Sub

End Class

Class Test
    Protected i As Integer = 0

    Protected Sub X()

    End Sub
End Class

Class B
    Inherits Test

    Public Sub New()

    End Sub
    Public Sub F()
        X()
        i = 9
    End Sub
End Class