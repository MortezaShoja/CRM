Public Class TextToRTL
    Private Out As String

    Public Function Convert(ByVal Text As String, ByVal SplitBy As Char)
        Dim Cr() As String = Text.ToString.Split(SplitBy)
        For I As Integer = Cr.Length - 1 To 0 Step -1
            Out += Cr(I).ToString + "-"
        Next
        Return Mid(Out, 1, Out.Length - 1)
    End Function

End Class
