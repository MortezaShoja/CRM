Public Class GenderID
    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private Shart As String
    Private Cbo As String


    Public Function GetGenderID(ByVal Gender As String)



        Dim Ret As String = String.Empty
        Cmd.CommandText = ("SELECT ID from Gender where " & Gender & "")
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Sdr = Cmd.ExecuteReader
        While Sdr.Read
            Ret = Sdr(0).ToString
        End While
        SqlCon.SqlCon.Close()

        If Ret <> String.Empty Then
            Return "'" & Ret & "'"
        Else
            Return "Null"
        End If

    End Function

    Public Function GetGender(ByVal ID As String, Optional ByVal Haghighi As Boolean = False, Optional ByVal Hoghooghi As Boolean = False)

        Shart = String.Empty
            If Haghighi = True Then
                Shart = "And Haghighi=1"
            ElseIf Hoghooghi = True Then
                Shart = "And Hoghooghi=1"
            Else
                Return "Error"
                Exit Function
            End If
            '---------------------------------------------------------
            Dim Ret As String = String.Empty
            Cmd.CommandText = ("SELECT Gender from Gender where ID='" & ID & "'  " & Shart & " ")
            Cmd.Connection = SqlCon.SqlCon

            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            While Sdr.Read
                Ret = Sdr(0).ToString
            End While
            SqlCon.SqlCon.Close()
        Return Ret

    End Function

    Public Function FillComboBox(Optional ByVal Haghighi As Boolean = False, Optional ByVal Hoghooghi As Boolean = False)

        Cbo = String.Empty

        Shart = String.Empty
        If Haghighi = True Then
            Shart = "Where Haghighi=1"
        ElseIf Hoghooghi = True Then
            Shart = "Where Hoghooghi=1"
        Else
            Return "Error"
            Exit Function
        End If



        Cmd.CommandText = ("SELECT Gender from Gender " & Shart & "")
        Cmd.Connection = SqlCon.SqlCon
        SqlCon.SqlCon.Open()
        Sdr = Cmd.ExecuteReader
        While Sdr.Read
            Me.Cbo += (Sdr(0).ToString) & ","
        End While
        SqlCon.SqlCon.Close()

        Return Cbo

    End Function

End Class
