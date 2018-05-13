Public Class GetSmsCenterInfo
    Private SqlCon As SQL

    Public Function GetSMSAghsatInfo()
        Dim Value(6) As String
        SqlCon = New SQL
        '                                                        0                1               2               3            4               5               
        Dim cmd4 As New Data.SqlClient.SqlCommand("Select YadavariSendTime,SarResidSendTime,DirkardSendTime,CarierNumber,CarierUserName,CarierPassword From SMSAghsatInfo ", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr4 As Data.SqlClient.SqlDataReader = cmd4.ExecuteReader
        If sdr4.Read Then
            Value(0) = sdr4(0)
            Value(1) = sdr4(1)
            Value(2) = sdr4(2)
            Value(3) = sdr4(3)
            Value(4) = sdr4(4)
            Value(5) = sdr4(5)
        End If
        SqlCon.SqlCon.Close()
        sdr4.Close()
        Return Value
    End Function

End Class
