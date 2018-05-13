Public Class GhestCount
    Private SqlCon As SQL

    Public Function GhestRow(ByVal VahedNameID As String, ByVal Pardakhte As String, ByVal SanadCode As String)
        Dim Value As Integer = 0
        SqlCon = New SQL
        Dim cmd3 As New Data.SqlClient.SqlCommand("select Row_Number() Over (Order by Date) as 'Row',Row as 'SanadCode' from bank Where Pardakhte=N'" & Pardakhte & "' And ID='" & VahedNameID & "' order by Date", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr3 As Data.SqlClient.SqlDataReader = cmd3.ExecuteReader
        While sdr3.Read
            If sdr3(1).ToString = SanadCode Then
                Value = sdr3(0)
                Exit While
            End If
        End While
        SqlCon.SqlCon.Close()
        sdr3.Close()
        Return Value
    End Function
End Class
