Public Class MonyCheck
    Private Answer As Boolean
    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private CU As New Currency
    Private Hprice, Nprice, Sprice, Cprice, SumPrice As Integer


    Public Function MonyCheck(ByVal OwnerID As String, ByVal GharardadPrice As Integer, ByVal Price As Integer, ByVal Saghf As Integer)
        '----------------------------------- HPrice -------------------------
        Cmd.Connection = SqlCon.SqlCon
        Cmd.CommandText = "SELECT Sum(Hprice) From Havale where ID=N'" & OwnerID & "'"

        SqlCon.SqlCon.Open()
        Sdr = Cmd.ExecuteReader
        Try
            While Sdr.Read
                If Sdr(0).ToString <> "" Then
                    Hprice = Sdr(0)
                Else
                    Hprice = 0
                End If
            End While
        Catch ex As Exception

        Finally

            SqlCon.SqlCon.Close()
        End Try
        '----------------------------------- Nprice -------------------------
        Cmd.Connection = SqlCon.SqlCon
        Cmd.CommandText = "SELECT Sum(Nprice) From Naghdi where ID=N'" & OwnerID & "' "

        SqlCon.SqlCon.Open()
        Sdr = Cmd.ExecuteReader
        Try
            While Sdr.Read
                If Sdr(0).ToString <> "" Then
                    Nprice = Sdr(0)
                Else
                    Nprice = 0
                End If
            End While
        Catch ex As Exception

        Finally

            SqlCon.SqlCon.Close()
        End Try
        '----------------------------------- Sprice -------------------------
        Cmd.Connection = SqlCon.SqlCon
        Cmd.CommandText = "SELECT Sum(Sprice) From Safte where ID=N'" & OwnerID & "' "

        SqlCon.SqlCon.Open()
        Sdr = Cmd.ExecuteReader
        Try
            While Sdr.Read
                If Sdr(0).ToString <> "" Then
                    Sprice = Sdr(0)
                Else
                    Sprice = 0
                End If
            End While
        Catch ex As Exception

        Finally

            SqlCon.SqlCon.Close()
        End Try
        '----------------------------------- Cprice -------------------------
        Cmd.Connection = SqlCon.SqlCon
        Cmd.CommandText = "SELECT Sum(Cprice) From [Check] where ID=N'" & OwnerID & "'"

        SqlCon.SqlCon.Open()
        Sdr = Cmd.ExecuteReader
        Try
            While Sdr.Read
                If Sdr(0).ToString <> "" Then
                    Cprice = Sdr(0)
                Else
                    Cprice = 0
                End If
            End While
        Catch ex As Exception

        Finally

            SqlCon.SqlCon.Close()
        End Try

        SumPrice = Hprice + Nprice + Sprice + Cprice

        'If GharardadPrice < (SumPrice + Price) Then
        '    MessageBox.Show("شما مجاز به درج مبلغ فوق نمی باشید" & vbCrLf & " شما با سقف مبلغ " & CU.CodeNumber(Saghf) & " مجاز به درج مبلغ می باشید ", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        '    'MessageBox.Show("شما مجاز به درج مبلغ فوق نمی باشید", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        '    Answer = False
        ''If (SumPrice + Price) > GharardadPrice Then
        ''    If (GharardadPrice - (SumPrice + Price)) >= 0 Then
        ''        MessageBox.Show("شما مجاز به درج مبلغ فوق نمی باشید" & vbCrLf & " شما با سقف مبلغ " & CU.CodeNumber(GharardadPrice - (SumPrice + Price)) & " مجاز به درج مبلغ می باشید ", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        ''    ElseIf SumPrice - GharardadPrice >= 0 Then
        ''        MessageBox.Show("شما مجاز به درج مبلغ فوق نمی باشید" & vbCrLf & " شما با سقف مبلغ " & CU.CodeNumber((SumPrice - GharardadPrice)) & " مجاز به درج مبلغ می باشید ", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        ''    Else
        ''        MessageBox.Show("شما مجاز به درج مبلغ فوق نمی باشید" & vbCrLf & " شما با سقف مبلغ " & CU.CodeNumber(Saghf) & " مجاز به درج مبلغ می باشید ", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        ''    End If

        ''    Answer = False
        ''Else
        ''    Answer = True
        ''End If

        If Not Price = 0 Then
            If SumPrice <= 0 Then
                If (Price) > 0 And Price <= Saghf Then
                    Answer = True
                    Return Answer
                    Exit Function
                Else
                    Answer = False
                    MessageBox.Show("شما مجاز به درج مبلغ فوق نمی باشید" & vbCrLf & " شما با سقف مبلغ " & CU.CodeNumber(Saghf) & " مجاز به درج مبلغ می باشید ", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                End If
            Else
                If (SumPrice + Price) <= GharardadPrice Then

                    If (Price) > 0 And (Price) <= (Saghf) Then
                        Answer = True
                        Return Answer
                        Exit Function
                    Else
                        Answer = False
                        MessageBox.Show("شما مجاز به درج مبلغ فوق نمی باشید" & vbCrLf & " شما با سقف مبلغ " & CU.CodeNumber(Saghf - SumPrice) & " مجاز به درج مبلغ می باشید ", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                    End If
                Else
                    If (Price) <= GharardadPrice Then
                        Answer = False
                        MessageBox.Show("شما مجاز به درج مبلغ فوق نمی باشید" & vbCrLf & " شما با سقف مبلغ " & CU.CodeNumber(SumPrice - SumPrice) & " مجاز به درج مبلغ می باشید ", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                    Else
                        Answer = False
                        MessageBox.Show("شما مجاز به درج مبلغ فوق نمی باشید" & vbCrLf & " شما با سقف مبلغ " & CU.CodeNumber(Saghf) & " مجاز به درج مبلغ می باشید ", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                    End If

                End If
            End If
        Else
            Answer = False
            MessageBox.Show("شما مجاز به درج مبلغ فوق نمی باشید", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End If
        Return (Answer)

    End Function
End Class
