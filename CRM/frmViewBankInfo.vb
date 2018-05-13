Public Class frmViewBankInfo
    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private CD As CurrentDate
    Private CU As Currency

    Private Sub frmViewBankInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CD = New CurrentDate
        Me.txtDate1.Text = CD.GetDate
        Me.txtDate2.Text = Me.txtDate1.Text
    End Sub

    Private Sub SearchData()
        'b = False
        CU = New Currency
        Dim Shart As String = String.Empty
        If Me.txtAccountNo.Text <> "" Then Shart += " Varizkonnade Like N'%" & Me.txtAccountNo.Text & "%' OR Sharh Like N'%" & Me.txtAccountNo.Text & "%' AND "
        If Me.txtDate1.Text <> "" Then Shart += " (Tarikh Between N'" & Me.txtDate1.Text & "' AND N'" & Me.txtDate2.Text & "') AND "
        If Me.txtPeygirino.Text <> "" Then Shart += " Serial Like N'" & Me.txtPeygirino.Text & "' AND "
        If Me.txtPrice.Text <> "" Then Shart += " Mablagh= N'" & Me.txtPrice.Text & "' AND "
        If Shart <> "" Then
            Shart = Mid(Shart, 1, Shart.Length - 4)
            Shart = " Where " + Shart
        End If

        Try
            Cmd.Connection = SqlCon.SqlCon
            tbl.Clear()
            '                               1                           2                   3                   4                               5                   6                               7                       8               9               10                  11                          12
            Cmd.CommandText = "Select Mande as 'مانده حساب',Mablagh as 'مبلغ گردش',Sharh as 'شرح',VarizKonnade as 'واریز کننده/ذینفع',Serial as 'شماره سریال',Shenase as 'شناسه واریز کننده',CodeHesab as 'کد حسابگری',Shobe as 'شعبه',Zaman as 'زمان',Tarikh as 'تاریخ',AccountNo as 'شماره حساب مقصد',ID as 'کد شناسائی' from bankMellat " & Shart & ""
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            Dim fc As Integer
            While (Sdr.Read)
                'populating columns
                If Not b Then
                    For fc = 0 To Sdr.FieldCount - 1
                        tbl.Columns.Add(Sdr.GetName(fc))
                    Next
                    b = True
                End If
                'populating rows
                Dim row As DataRow = tbl.NewRow


                row(0) = CU.CodeNumberNoRiyal(Sdr(0))
                row(1) = CU.CodeNumberNoRiyal(Sdr(1))
                'row(0) = Sdr(0)
                'row(1) = Sdr(1)
                row(2) = Sdr(2)
                row(3) = Sdr(3)
                row(4) = Sdr(4)
                row(5) = Sdr(5)
                row(6) = Sdr(6)
                row(7) = Sdr(7)
                row(8) = Sdr(8)
                row(9) = Sdr(9)
                row(10) = Sdr(10)
                row(11) = Sdr(11)

                tbl.Rows.Add(row)
                tbl.TableName = "BankInfo"
                tbl.WriteXml("C:\Reports\RptBankInfo.XML")
            End While
            dvw = New DataView(tbl)
            Me.DataGridView1.DataSource = dvw
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            SqlCon.SqlCon.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SearchData()
    End Sub

    Private Sub DbgView_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            FillRptRow(Me.DataGridView1.CurrentRow.Cells.Item(11).Value.ToString)
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub DbgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DataGridView1.KeyDown, DataGridView1.KeyUp
    '    Try
    '        FillRptRow(Me.DataGridView1.CurrentRow.Cells.Item(11).Value.ToString)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub FillRptRow(ByVal RowID As String)
        b = False
        Try
            Cmd.Connection = SqlCon.SqlCon
            tbl.Clear()
            Cmd.CommandText = "Select * from BankMellat where ID=N'" & RowID & "'"
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            Dim fc As Integer
            While (Sdr.Read)
                'populating columns
                If Not b Then
                    For fc = 0 To Sdr.FieldCount - 1
                        tbl.Columns.Add(Sdr.GetName(fc))
                    Next
                    b = True
                End If
                'populating rows
                Dim row As DataRow = tbl.NewRow

                For fc = 0 To Sdr.FieldCount - 1
                    row(fc) = Sdr(fc)
                Next
                tbl.Rows.Add(row)
                tbl.TableName = "RptBankRow"
                tbl.WriteXml("C:\Reports\RptBankRow.XML")
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        'Dim DataAdapter As New SqlClient.SqlDataAdapter("Select * from BankMellat where ID=N'" & RowID & "'", SqlCon.SqlCon)
        'Dim DataSet As New DataSet
        'DataAdapter.Fill(DataSet)
        'DataSet.WriteXml("c:\Reports\RptBankRow.xml")
        'SqlCon.SqlCon.Close()
        '-------------------------------------------
        Dim frm As New frmReporter
        frm.MdiParent = Mehregan.Parent
        frm.CrystalReportViewer1.ReportSource = frm.RptBankRowInfo1
        frm.RptBankRowInfo1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'Auto Print
        'frm.rptAghsat1.PrintToPrinter(1, True, 0, 0)
        frm.Show()
    End Sub
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


    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim frm As New frmReporter
        frm.MdiParent = Mehregan.Parent
        frm.CrystalReportViewer1.ReportSource = frm.rptBankInfo1
        frm.rptBankInfo1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'Auto Print
        'frm.rptAghsat1.PrintToPrinter(1, True, 0, 0)
        frm.Show()
    End Sub


    Private Sub txtDate1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate1.GotFocus
        Dim DM As New DateMode
        Try
            Me.txtDate1.Text = DM.DECodeDate(Me.txtDate1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDate1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate1.LostFocus
        Dim DM As New DateMode
        Try
            Me.txtDate1.Text = DM.CodeDate(Me.txtDate1.Text)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtDate2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate2.GotFocus
        Dim DM As New DateMode
        Try
            Me.txtDate2.Text = DM.DECodeDate(Me.txtDate2.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDate2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate2.LostFocus
        Dim DM As New DateMode
        Try
            Me.txtDate2.Text = DM.CodeDate(Me.txtDate2.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtAccountNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAccountNo.KeyPress, txtPeygirino.KeyPress, txtDate1.KeyPress, txtDate2.KeyPress, txtPrice.KeyPress
        If e.KeyChar = Chr(13) Then
            SearchData()
        End If
    End Sub

End Class