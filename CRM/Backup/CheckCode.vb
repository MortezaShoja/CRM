Public Class CheckCode

    'Public Function VarizBehesab(ByVal Code As Integer)
    '    Dim Value As Integer = 0
    '    Dim SqlConCheckCode As New SQL
    '    Dim cmdCheckCode As New SqlClient.SqlCommand("Select Price from BankMellat Where Serial=N'" & Code & "' Or Sharh Like N'%" & Code & "%'", SqlConGetSum.SqlCon)
    '    SqlConCheckCode.SqlCon.Open()
    '    Dim SdrCheckCode As SqlClient.SqlDataReader = cmdCheckCode.ExecuteReader
    '    Try
    '        If SdrCheckCode.Read Then
    '            Value = SdrCheckCode(0).ToString
    '        End If
    '    Catch ex As Exception
    '        Value = 0
    '    Finally
    '        SqlConCheckCode.SqlCon.Close()
    '    End Try
    '    Return Value
    'End Function

    'Public Function VarizBehesab(ByVal Code As Integer)
    '    Dim Value As Integer = 0
    '    Dim SqlConCheckCode As New SQL
    '    Dim cmdCheckCode As New SqlClient.SqlCommand("Select Price from BankMellat Where Serial=N'" & Code & "' Or Sharh Like N'%" & Code & "%'", SqlConGetSum.SqlCon)
    '    SqlConCheckCode.SqlCon.Open()
    '    Dim SdrCheckCode As SqlClient.SqlDataReader = cmdCheckCode.ExecuteReader
    '    Try
    '        If SdrCheckCode.Read Then
    '            Value = SdrCheckCode(0).ToString
    '        End If
    '    Catch ex As Exception
    '        Value = 0
    '    Finally
    '        SqlConCheckCode.SqlCon.Close()
    '    End Try
    '    Return Value
    'End Function

End Class
