Public Class Counter
    Private SqlCon, SQLCon2 As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader

    Public Function TabsarehCount(ByVal GharardadNo)
        Dim R As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT sum(TabsarehCount) from Gharardad_V where GharardadNo='" & GharardadNo & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            R = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
        Return (R)
    End Function

    Public Function BandCount(ByVal GharardadNo)
        Dim R As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT count(*) from Gharardad_V where GharardadNo='" & GharardadNo & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            R = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
        Return (Integer.Parse(R) + 1).ToString
    End Function
End Class
