Public Class frmRegBankMellatInfo
    Private SqlCon As SQL
    Private Temp(11) As String
    Private Counter, Counter2 As Integer
    Private Start As Boolean

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click
        If Me.cboAccountNo.Text <> "" Then
            Start = False
            Counter = 0
            Counter2 = 0

            Me.btnRead.Enabled = False
            For Each TblElement As System.Windows.Forms.HtmlElement In Me.WebBrowser1.Document.All
                Dim Taghi As String = TblElement.InnerText
                If TblElement.InnerText = "مانده" And Start = False Then Start = True

                If UCase(TblElement.TagName.ToString).Contains("TD") And Counter < 12 And Start = True Then
                    Temp(Counter) = TblElement.InnerText
                    Counter += 1
                ElseIf Counter = 11 Then
                    If Temp(0) <> "مانده" And Start = True Then
                        SaveToBank(Temp(0), Temp(1), Temp(2), Temp(3), Temp(4), Temp(5), Temp(6), Temp(7), Temp(8), Temp(9))
                        Counter2 += 1
                    End If
                    Counter = 0
                End If
            Next
            MessageBox.Show("کلیه اطلاعات با موفقیت خوانده و ثبت گردید" & vbCrLf & "تعداد رکوردهای ثبت شده " & Counter2 & " می باشد ", "ثبت اطلاعات در بانک داده", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Me.btnRead.Enabled = True
        Else
            MessageBox.Show("لطفاً شماره حساب را انتخاب کنید")
        End If

    End Sub

    Private Sub SaveToBank(ByVal Mande As String, ByVal Mablagh As String, ByVal Sharh As String, ByVal VarizKonnade As String, ByVal Serial As String, ByVal Shenase As String, ByVal CodeHesab As String, ByVal Shobe As String, ByVal Zaman As String, ByVal Tarikh As String)

        SqlCon = New SQL
        Try
            Mande = Mande.Replace(",", "")
            Mablagh = Mablagh.Replace(",", "")
            Dim cmd4 As New Data.SqlClient.SqlCommand("Insert Into BankMellat (Mande,Mablagh,Sharh,VarizKonnade,Serial,Shenase,CodeHesab,Shobe,Zaman,Tarikh,AccountNO) Values (N'" & GetArabicNumber(Mande) & "',N'" & GetArabicNumber(Mablagh) & "',N'" & GetArabicNumber(Sharh) & "',N'" & GetArabicNumber(VarizKonnade) & "',N'" & GetArabicNumber(Serial) & "',N'" & GetArabicNumber(Shenase) & "',N'" & GetArabicNumber(CodeHesab) & "',N'" & GetArabicNumber(Shobe) & "',N'" & GetArabicNumber(Zaman) & "',N'" & GetArabicNumber(Tarikh) & "',N'" & Me.cboAccountNo.Text & "')", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            cmd4.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            SqlCon.SqlCon.Close()
        End Try

    End Sub

    Private Function GetArabicNumber(ByVal Number As String)
        Dim Value As String = Number
        Value = Value.Replace("۰", "0")
        Value = Value.Replace("۱", "1")
        Value = Value.Replace("۲", "2")
        Value = Value.Replace("۳", "3")
        Value = Value.Replace("۴", "4")
        Value = Value.Replace("۵", "5")
        Value = Value.Replace("۶", "6")
        Value = Value.Replace("۷", "7")
        Value = Value.Replace("۸", "8")
        Value = Value.Replace("۹", "9")
        Return Value
    End Function

    'Private Function GetArabicNumber(ByVal Number As String)
    '    Dim Value As String = Number
    '    Value = Value.Replace("0", "۰")
    '    Value = Value.Replace("1", "۱")
    '    Value = Value.Replace("2", "۲")
    '    Value = Value.Replace("3", "۳")
    '    Value = Value.Replace("4", "۴")
    '    Value = Value.Replace("5", "۵")
    '    Value = Value.Replace("6", "۶")
    '    Value = Value.Replace("7", "۷")
    '    Value = Value.Replace("8", "۸")
    '    Value = Value.Replace("9", "۹")
    '    Return Value
    'End Function


    Private Sub OpenDLG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDLG.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = "C:temp"
        OpenFileDialog1.ShowDialog()

        Me.WebBrowser1.Navigate(Me.OpenFileDialog1.FileName.ToString)


    End Sub

    Private Shared Function ArabicToWestern(ByVal input As String) As String
        Dim western As System.Text.StringBuilder = New System.Text.StringBuilder
        For Each num As Char In input
            western.Append(Char.GetNumericValue(num))
        Next
        Return western.ToString
    End Function



End Class

