Public Class GenerateCode



    Private SqlConnection As New SQL
    Private cmdClass As New SqlClient.SqlCommand
    Private sdrClass As SqlClient.SqlDataReader
    Private VC, PC, [Date] As String
    Private DC As New DateConvertor


    Public Function GetVahedCode(ByVal VahedName As String, ByVal Count As Integer)
        '-------------------------------------------------------------
        cmdClass.CommandText = "select VahedCode from VahedName where VahedName=N'" & VahedName & "'"
        cmdClass.Connection = SqlConnection.SqlCon
        SqlConnection.SqlCon.Open()
        Try
            sdrClass = cmdClass.ExecuteReader()

            If sdrClass.Read Then
                VC = sdrClass(0).ToString
            End If
            sdrClass.Close()

        Catch ex As Exception

        Finally
            SqlConnection.SqlCon.Close()
        End Try
        Return (VC + (Count + 1).ToString)

    End Function


    Public Function GetGharardadNo(ByVal ShahrNameID As String, ByVal MajmooeNameID As String, ByVal PhaseNo As String, ByVal Count As Integer)

        DC.Convertor()
        [Date] = Mid(DC.Hyear.ToString, 4, 2) & DC.Hmonth.ToString
        '-------------------------------------------------------------
        cmdClass.CommandText = "select Pasvand from PhaseNO where ShahrID='" & ShahrNameID & "' AND MajmooeNameID='" & MajmooeNameID & "' AND PhaseNo='" & PhaseNo & "'"
        cmdClass.Connection = SqlConnection.SqlCon
        SqlConnection.SqlCon.Open()
        Try
            sdrClass = cmdClass.ExecuteReader()

            If sdrClass.Read Then
                PC = sdrClass(0).ToString
            End If
            sdrClass.Close()

        Catch ex As Exception

        Finally
            SqlConnection.SqlCon.Close()
        End Try
        Return [Date] + ((Count + 1).ToString + PC)

    End Function
End Class
