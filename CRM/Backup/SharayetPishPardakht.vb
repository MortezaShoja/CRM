Public Class SharayetPishPardakht

    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private I As Integer = 1
    Private Data As String = String.Empty
    Private CheckCount, HavaleCount As Integer
    Private CU As New Currency
    Private nTow As New NumberToWord
    Private NoePishPardakht As String
    Private RD As New ReturnDate


    Public Function Generate(ByVal ID As String)
        Data = String.Empty
        GenerateCheck(ID)
        Havale(ID)
        Naghdi(ID)
        Return Data
    End Function

    Private Function GenerateCheck(ByVal ID As String)

        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT count(*) as 'تعداد چک' From [Check] Where ID=N'" & ID & "' And Pardakhte=N'پیش پرداخت'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            If Sdr.HasRows = True Then
                While Sdr.Read
                    CheckCount = Integer.Parse(Sdr(0))
                    If CheckCount = 0 Then Return "" : Exit Function
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در شمارش چک", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        If Data <> "" Then Data += " و الباقی "
        Data += "طی " & CheckCount.ToString & "فقره چک بانکی "
        '------------------------------------------------------

        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT CaccountOwner,CaccountNo,CcheckNo,CownerBank,CBankShobe,CBankCode,Cprice,CDate From [Check] Where ID=N'" & ID & "' And Pardakhte=N'پیش پرداخت'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            If Sdr.HasRows = True Then
                While Sdr.Read
                    If Sdr(0).ToString <> "" Then
                        Data += " به نام: " & Sdr(0)
                    End If
                    If Sdr(1).ToString <> "" Then
                        Data += " عهده حساب شماره: " & Sdr(1)
                    End If
                    If Sdr(2).ToString <> "" Then
                        Data += " به شماره چک: " & Sdr(2)
                    End If
                    If Sdr(3).ToString <> "" Then
                        Data += " عهده بانک: " & Sdr(3)
                    End If
                    If Sdr(4).ToString <> "" Then
                        Data += " شعبه: " & Sdr(4)
                    End If
                    If Sdr(5).ToString <> "" Then
                        Data += " کد: " & Sdr(5)
                    End If
                    If Sdr(6).ToString <> "" Then
                        Data += " به مبلغ: " & CU.CodeNumberRTL(Sdr(6)) & " معادل " & nTow.Convert(Sdr(6))
                    End If
                    If Sdr(7).ToString <> "" Then
                        Data += " به تاریخ: " & RD.Return(Sdr(7))
                    End If

                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در ساخت مشخصات چک", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Return Data

    End Function



    Private Function Havale(ByVal ID As String)

        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT count(*) as 'تعداد حواله' From Havale Where ID=N'" & ID & "' And Pardakhte=N'پیش پرداخت'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            If Sdr.HasRows = True Then
                While Sdr.Read
                    HavaleCount = Integer.Parse(Sdr(0))
                    If HavaleCount = 0 Then Return "" : Exit Function
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در شمارش حواله", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        If Data <> "" Then Data += " و الباقی "
        Data += "طی " & HavaleCount.ToString & "فقره حواله "
        '------------------------------------------------------

        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT HhavaleNo,Hdate,Hprice,Hbank,Hshobe,HbankCode From Havale Where ID=N'" & ID & "' And Pardakhte=N'پیش پرداخت'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            If Sdr.HasRows = True Then
                While Sdr.Read
                    If Sdr(0).ToString <> "" Then
                        Data += " به شماره حواله: " & Sdr(0)
                    End If
                    If Sdr(1).ToString <> "" Then
                        Data += " به تاریخ: " & RD.Return(Sdr(1))
                    End If
                    If Sdr(2).ToString <> "" Then
                        Data += " به مبلغ: " & CU.CodeNumberRTL(Sdr(2)) & " معادل " & nTow.Convert(Sdr(2))
                    End If
                    If Sdr(3).ToString <> "" Then
                        Data += " عهده بانک: " & Sdr(3)
                    End If
                    If Sdr(4).ToString <> "" Then
                        Data += " شعبه: " & Sdr(4)
                    End If
                    If Sdr(5).ToString <> "" Then
                        Data += " کد: " & Sdr(5)
                    End If

                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در ساخت مشخصات حواله", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Return Data

    End Function

    Private Function Naghdi(ByVal ID As String)


        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT count(*) as 'تعداد نقدی' From Naghdi Where ID=N'" & ID & "' And Pardakhte=N'پیش پرداخت'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            If Sdr.HasRows = True Then
                While Sdr.Read
                    HavaleCount = Integer.Parse(Sdr(0))
                    If HavaleCount = 0 Then Return "" : Exit Function
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در پورداخت نقدی", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        If Data <> "" Then Data += " و الباقی "
        '------------------------------------------------------
        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT Nprice From Naghdi Where ID=N'" & ID & "' And Pardakhte=N'پیش پرداخت'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            If Sdr.HasRows = True Then
                While Sdr.Read
                    If Sdr(0).ToString <> "" Then
                        Data += " به مبلغ: " & CU.CodeNumberRTL(Sdr(0)) & " معادل " & nTow.Convert(Sdr(0))
                    End If
                End While
            End If
            Data += " نقداً"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در ساخت پرداخت نقدی", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Return Data

    End Function

End Class
