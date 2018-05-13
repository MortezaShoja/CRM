Public Class SharayetAghsat

    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private I As Integer = 1
    Private Data As String = String.Empty
    Private CheckCount, HavaleCount, SafteCount As Integer
    Private CU As New Currency
    Private nTow As New NumberToWord
    Private NoePishPardakht As String
    Private RD As New ReturnDate

    Public Function Generate(ByVal ID As String)
        Data = String.Empty
        Naghdi(ID)
        Havale(ID)
        GenerateCheck(ID)
        Safte(ID)
        Return Data
    End Function

    Private Function Naghdi(ByVal ID As String)

        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT count(*) as 'تعداد نقدی' From Naghdi Where ID=N'" & ID & "' And Pardakhte=N'اقساط'", SqlCon.SqlCon)
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
        'Data += vbCrLf
        '------------------------------------------------------
        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT Nprice From Naghdi Where ID=N'" & ID & "' And Pardakhte=N'اقساط'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            If Sdr.HasRows = True Then
                While Sdr.Read
                    If Sdr(0).ToString <> "" Then
                        Data += " مبلغ: " & CU.CodeNumberRTL(Sdr(0)) & " معادل " & nTow.Convert(Sdr(0))
                    End If
                End While
            End If
            Data += " بصورت نقدی "
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در ساخت پرداخت نقدی", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Return Data

    End Function




    Private Function Havale(ByVal ID As String)

        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT count(*) as 'تعداد حواله' From Havale Where ID=N'" & ID & "' And Pardakhte=N'اقساط'", SqlCon.SqlCon)
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
        'Data += vbCrLf
        If Data <> "" Then Data += vbCrLf & " و الباقی طی" & HavaleCount & " " & "فقره حواله" & vbCrLf
        Data += "|" & "ردیف" & "| " & "  شماره حواله  " & " | " & "  تاریخ حواله   " & " | " & "    مبلغ (ریال)    " & " | " & "عهده بانک" & " | " & "    شعبه    " & " | " & "   کد   " & " | "
        '------------------------------------------------------

        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT HhavaleNo,Hdate,Hprice,Hbank,Hshobe,HbankCode From Havale Where ID=N'" & ID & "' And Pardakhte=N'اقساط'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            If Sdr.HasRows = True Then
                Dim C As Integer = 1
                While Sdr.Read
                    Data += vbCrLf & "|   " & C & "    | "

                    If Sdr(0).ToString.Length < 15 Then
                        Dim Sl As Integer = (15 - Sdr(0).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(0).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(0).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(1).ToString.Length < 14 Then
                        Dim Sl As Integer = (14 - Sdr(1).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(1).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(1).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(2).ToString.Length < 12 Then
                        Dim Sl As Integer = (12 - Sdr(2).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(2).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(2).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(3).ToString.Length < 10 Then
                        Dim Sl As Integer = (10 - Sdr(3).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(3).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(3).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(4).ToString.Length < 10 Then
                        Dim Sl As Integer = (10 - Sdr(4).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(4).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(4).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(5).ToString.Length < 6 Then
                        Dim Sl As Integer = (6 - Sdr(5).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(5).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(5).ToString & " | "
                    End If
                    '----------------------------------------------------   
                    C += 1
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در ساخت مشخصات حواله", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Return Data

    End Function



    Private Function GenerateCheck(ByVal ID As String)

        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT count(*) as 'تعداد چک' From [Check] Where ID=N'" & ID & "' And Pardakhte=N'اقساط'", SqlCon.SqlCon)
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
        If Data <> "" Then Data += vbCrLf & " و الباقی طی" & CheckCount & " " & "فقره چک بانکی" & vbCrLf
        Data += "|" & "ردیف" & "|" & " نام صاحب حساب " & " | " & "  شماره حساب  " & " | " & "  شماره چک  " & " | " & "عهده بانک" & " | " & "    شعبه    " & " | " & "   کد   " & " | " & "     مبلغ(ریال)    " & " | " & " تاریخ چک " & " | "
        '------------------------------------------------------

        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT CaccountOwner,CaccountNo,CcheckNo,CownerBank,CBankShobe,CBankCode,Cprice,CDate From [Check] Where ID=N'" & ID & "' And Pardakhte=N'اقساط'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            If Sdr.HasRows = True Then
                Dim C As Integer = 1
                While Sdr.Read
                    Data += vbCrLf & "|   " & C & "    | "

                    If Sdr(0).ToString.Length < 15 Then
                        Dim Sl As Integer = (15 - Sdr(0).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(0).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(0).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(1).ToString.Length < 14 Then
                        Dim Sl As Integer = (14 - Sdr(1).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(1).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(1).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(2).ToString.Length < 12 Then
                        Dim Sl As Integer = (12 - Sdr(2).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(2).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(2).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(3).ToString.Length < 10 Then
                        Dim Sl As Integer = (10 - Sdr(3).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(3).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(3).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(4).ToString.Length < 10 Then
                        Dim Sl As Integer = (10 - Sdr(4).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(4).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(4).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(5).ToString.Length < 6 Then
                        Dim Sl As Integer = (6 - Sdr(5).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(5).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(5).ToString & " | "
                    End If
                    '----------------------------------------------------                    If Sdr(3).ToString.Length < 10 Then
                    If Sdr(6).ToString.Length < 18 Then
                        Dim Sl As Integer = (18 - Sdr(6).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(6).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(6).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(7).ToString.Length < 10 Then
                        Dim Sl As Integer = (10 - Sdr(7).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(7).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(7).ToString & " | "
                    End If


                    C += 1
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در ساخت مشخصات چک", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Return Data

    End Function


    Private Function Safte(ByVal ID As String)

        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT count(*) as 'تعداد سفته' From Safte Where ID=N'" & ID & "' And Pardakhte=N'اقساط'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            If Sdr.HasRows = True Then
                While Sdr.Read
                    SafteCount = Integer.Parse(Sdr(0))
                    If SafteCount = 0 Then Return "" : Exit Function
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در شمارش سفته", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        'Data += vbCrLf
        If Data <> "" Then Data += vbCrLf & " و الباقی طی" & SafteCount & " " & "فقره سفته" & vbCrLf
        Data += "|" & "ردیف" & "| " & "    نام متعهد    " & " | " & "  شماره سفته   " & " | " & "    مبلغ (ریال)    " & " | " & "  تاریخ سررسید  " & " | "
        '------------------------------------------------------

        Try
            Dim Cmd As New SqlClient.SqlCommand("SELECT SmoteahedName,SsafteNo,Sprice,SsarresidDate From Safte Where ID=N'" & ID & "' And Pardakhte=N'اقساط'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            If Sdr.HasRows = True Then
                Dim C As Integer = 1
                While Sdr.Read
                    Data += vbCrLf & "|   " & C & "    | "

                    If Sdr(0).ToString.Length < 15 Then
                        Dim Sl As Integer = (15 - Sdr(0).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(0).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(0).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(1).ToString.Length < 14 Then
                        Dim Sl As Integer = (14 - Sdr(1).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(1).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(1).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(2).ToString.Length < 12 Then
                        Dim Sl As Integer = (12 - Sdr(2).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(2).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(2).ToString & " | "
                    End If
                    '----------------------------------------------------
                    If Sdr(3).ToString.Length < 10 Then
                        Dim Sl As Integer = (10 - Sdr(3).ToString.Length) / 2
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += Sdr(3).ToString
                        For L As Integer = 1 To Sl + 1
                            Data += " "
                        Next
                        Data += " | "
                    Else
                        Data += Sdr(3).ToString & " | "
                    End If
                    '----------------------------------------------------
  
                    C += 1
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطا در ساخت مشخصات حواله", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Return Data

    End Function



End Class
