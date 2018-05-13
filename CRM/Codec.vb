Public Class Codec
    Private TextCode As String


    Public Function Code(ByVal Text As String)
        TextCode = String.Empty
        For i As Integer = 1 To Text.ToString.Length
            TextCode += Asc(Mid(Text, i, 1).ToString) & ","
        Next

        Return (Mid(TextCode, 1, TextCode.ToString.Length - 1))

    End Function

    Public Function DeCode(ByVal Code As String)

        Dim TextDecode() = Code.ToString.Split(",")

        For j As Integer = 0 To TextDecode.Length - 1
            TextCode += Chr(Integer.Parse(TextDecode(j)))
        Next
        Return (TextCode)

    End Function

End Class
