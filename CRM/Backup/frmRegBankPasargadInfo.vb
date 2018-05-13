Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmRegBankPasargadInfo

    Private SqlCon As SQL
    Private Temp(11) As String
    Private Start As Boolean
    Private Sub SaveToBank(ByVal Mande As String, ByVal Mablagh As String, ByVal Sharh As String, ByVal VarizKonnade As String, ByVal Serial As String, ByVal Shenase As String, ByVal CodeHesab As String, ByVal Shobe As String, ByVal Zaman As String, ByVal Tarikh As String)

        SqlCon = New SQL
        Try
            Mande = Mande.Replace(",", "")
            Mablagh = Mablagh.Replace(",", "")
            Dim cmd4 As New Data.SqlClient.SqlCommand("Insert Into BankMellat (Mande,Mablagh,Sharh,VarizKonnade,Serial,Shenase,CodeHesab,Shobe,Zaman,Tarikh,AccountNO) Values (N'" & Mande & "',N'" & Mablagh & "',N'" & Sharh & "',N'" & VarizKonnade & "',N'" & Serial & "',N'" & Shenase & "',N'" & CodeHesab & "',N'" & Shobe & "',N'" & Zaman & "',N'" & Tarikh & "',N'" & Me.cboAccountNo.Text & "')", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            cmd4.ExecuteNonQuery()
        Catch ex As Exception

        Finally
            SqlCon.SqlCon.Close()
        End Try

    End Sub

    Private Shared Function ArabicToWestern(ByVal input As String) As String
        Dim western As System.Text.StringBuilder = New System.Text.StringBuilder
        For Each num As Char In input
            western.Append(Char.GetNumericValue(num))
        Next
        Return western.ToString
    End Function

    Private Sub OpenDLG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenDLG.Click

        If Me.cboAccountNo.Text <> "" Then
            Dim Counter As Integer = 0
            Me.btnOpenDLG.Enabled = False

            OpenFileDialog1.Title = "Please Select a File"
            OpenFileDialog1.InitialDirectory = "C:temp"
            OpenFileDialog1.ShowDialog()
            If MessageBox.Show("آیا مایلید اطلاعات در سیستم ثیت گردد", "ثبت اطلاعات بانک پاسارگاد", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False) = Windows.Forms.DialogResult.Yes Then
                Dim Data As Object(,) = GetExcelData(Me.OpenFileDialog1.FileName.ToString)
                For I As Integer = 3 To (Data.Length / 12) - 1
                    Dim Mablagh As String
                    If Data(I, 11) = 0 Then
                        Mablagh = "-" & Data(I, 10)
                    Else
                        Mablagh = "+" & Data(I, 11)
                    End If
                    SaveToBank(Data(I, 12), Mablagh, Data(I, 9), "", Data(I, 8) & vbCrLf & Data(I, 6), Data(I, 7), "", Data(I, 2) & vbCrLf & Data(I, 3), ReturnTime(Data(I, 5)), Data(I, 4))
                    Counter += 1
                Next
                MessageBox.Show("کلیه اطلاعات با موفقیت خوانده و ثبت گردید" & vbCrLf & "تعداد رکوردهای ثبت شده " & Counter & " می باشد ", "ثبت اطلاعات در بانک داده", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Me.btnOpenDLG.Enabled = True
            Else
                MessageBox.Show("هیچ گونه اطلاعاتی ثبت نشد", "ثبت اطلاعات بانک پاسارگاد", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False)
            End If
        Else
            MessageBox.Show("لطفاً شماره حساب را انتخاب کنید")
        End If

    End Sub

    Private Function ReturnTime(ByVal StartInstel As Object)
        Dim StrInstel As String
        Dim a, c As Double
        Dim b, d As Integer

        'StartInstel gets a time like "16:15:34" from excel, only it will be in a 
        'double format for a day like "0.677476845"

        a = StartInstel * 24                'StartInstel = 0.677476845
        If a < 10 Then
            b = Microsoft.VisualBasic.Left(a, 1)
            c = a - b
            d = c * 60
            StrInstel = "0" & b & ":" & d
        ElseIf a >= 10 Then
            b = Microsoft.VisualBasic.Left(a, 2)
            c = a - b
            d = c * 60
            StrInstel = b & ":" & d
        End If
        Return StrInstel
    End Function

    Private Function GetExcelData(ByVal ExcelFileAddress As String) As Object(,)
        Dim application = New Excel.Application()
        Dim workbook As Excel.Workbook = application.Workbooks.Open(ExcelFileAddress)
        Dim worksheet As Excel.Worksheet = workbook.Sheets(1)

        Dim usedRange = worksheet.UsedRange
        Dim usedRangeAs2DArray As Object(,) = usedRange.Value2

        'workbook.Save()
        workbook.Close()
        application.Quit()

        Return usedRangeAs2DArray
    End Function

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class