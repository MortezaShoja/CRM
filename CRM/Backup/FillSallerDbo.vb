Public Class FillSallerDbo

    Private SqlConnection As New SQL
    Private cmdClass As New SqlClient.SqlCommand
    Private sdrClass As SqlClient.SqlDataReader
    Private TypePrice As Integer

    Public Sub FillSallerDbo(ByVal OfficeName As String, ByVal SallerName As String, ByVal GharardadNo As String, ByVal GharardadID As String, ByVal RegDate As String, ByVal RegDay As String, ByVal KharidarName As String, ByVal Phone As String, ByVal Type As String)

        '-------------------------------------- Get Price ------------------------------
        cmdClass.CommandText = "select Price from TypePrice where Type=N'" & Type & "'"
        cmdClass.Connection = SqlConnection.SqlCon
        SqlConnection.SqlCon.Open()
        Try
            sdrClass = cmdClass.ExecuteReader()

            If sdrClass.Read Then
                TypePrice = Integer.Parse(sdrClass(0).ToString)
            End If
            sdrClass.Close()

        Catch ex As Exception

        Finally
            SqlConnection.SqlCon.Close()
        End Try

        '------------------------------------- Insert -------------------------------------
        Try
            cmdClass.CommandText = "insert into SallerSallsDbo (Officename,SallerName,GharardadNo,GharardadID,RegDate,RegDay,KharidarName,Phone,Type,Price) Values (N'" & OfficeName & "',N'" & SallerName & "',N'" & GharardadNo & "',N'" & GharardadID & "',N'" & RegDate & "',N'" & RegDay & "',N'" & KharidarName & "',N'" & Phone & "',N'" & Type & "'," & TypePrice & ")"
            SqlConnection.SqlCon.Open()
            CmdClass.ExecuteNonQuery()
        Catch ex As Exception
            'MessageBox.Show(cmdClass.CommandText.ToString)
            MessageBox.Show("اطلاعات این قرارداد قبلاً ثبت شده اند" & vbCrLf & ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlConnection.SqlCon.Close()
        End Try

    End Sub

End Class
