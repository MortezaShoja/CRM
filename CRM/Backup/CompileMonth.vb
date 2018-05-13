Public Class CompileMonth

    Public Function Convert(ByVal StartMonth As String, ByVal EndMonth As String)

        Dim SM() As String = StartMonth.Split("/")
        Dim EM() As String = EndMonth.Split("/")

        Dim Y As Integer = Integer.Parse(EM(0)) - Integer.Parse(SM(0))
        Dim M As Integer = Integer.Parse(EM(1)) - Integer.Parse(SM(1))
        Y = Y * 12

        Return (Y + M + 1).ToString

    End Function


End Class
