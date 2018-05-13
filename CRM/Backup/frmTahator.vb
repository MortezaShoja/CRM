Public Class frmPardakhteTahator

    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private Date1, Day1 As String
    Public OwnerID, Type, FormType As String
    Private Row As String
    Private Tmp(2) As String
    Private Cu As New Currency
    Public Price As String
    Public SayerVisible As Boolean
    Public MajmooeID As String
    Public Canceli As Boolean
    Private Mony As Integer
    Private Answer As Boolean
    Private MC As New MonyCheck
    'Public Pish As Boolean
    Public GharardadPrice As String = String.Empty
    Private GetSum As New GetSum

    Private txtP As Boolean


    Private Sub frmCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Dc As New DateConvertor
        Dc.Convertor()
        Date1 = Dc.Hyear + "/" + Dc.Hmonth + "/" + Dc.Hday
        Day1 = Dc.HweekDay
        SUM()
        '-------------------------------------
        FillGrid()
        Me.btnNew.Enabled = False
        Me.btnReg.Enabled = True
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False
        FillCboSayerePardakhtHa(SayerVisible)

        Me.Text = " فرم ثبت دریافتی " & FormType & " :::..."
    End Sub

    Private Sub txtPardakhtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPardakhtDate.GotFocus
        Dim DM As New DateMode
        Try
            Me.txtPardakhtDate.Text = DM.DECodeDate(Me.txtPardakhtDate.Text)
        Catch ex As Exception
            Me.txtPardakhtDate.Focus()
        End Try
    End Sub

    Private Sub txtPardakhtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPardakhtDate.LostFocus
        Dim DM As New DateMode
        Try
            Me.txtPardakhtDate.Text = DM.CodeDate(Me.txtPardakhtDate.Text)
        Catch ex As Exception
            Me.txtPardakhtDate.Focus()
        End Try
    End Sub

    Private Sub FillCboSayerePardakhtHa(ByVal ENB As Boolean)
        If ENB = True Then
            Me.cboSayerJahate.Items.Clear()
            Me.cboSayerJahate.Items.Add("")
            Dim SQLCONection As New SQL
            Dim cmd2 As New SqlClient.SqlCommand("SELECT Jahate from SayerePardakhtHa Where MajmooeID='" & MajmooeID & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                Me.cboSayerJahate.Items.Add(sdr2(0).ToString)
            End While
            SQLCONection.SqlCon.Close()
        Else
            Me.cboSayerJahate.Text = "اقساط"
            Me.cboSayerJahate.Enabled = False
        End If
    End Sub

    Private Sub cboSayerJahate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSayerJahate.SelectedIndexChanged
        Try
            Cu = New Currency
            If Integer.Parse(Cu.DeCodeNumber(Me.txtPrice.Text)) = 0 Then
                Dim SQLCONection As New SQL
                Dim cmd2 As New SqlClient.SqlCommand("SELECT Price from SayerePardakhtHa Where Jahate=N'" & Me.cboSayerJahate.Text & "'", SQLCONection.SqlCon)
                SQLCONection.SqlCon.Open()
                Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
                If sdr2.Read Then
                    Me.txtPrice.Text = Cu.CodeNumber(sdr2(0).ToString)
                End If
                SQLCONection.SqlCon.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Me.btnNew.Enabled = False
        Me.btnReg.Enabled = True
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False
        Me.btnPrint.Enabled = False
        RefreshText()

    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click

        Me.btnNew.Enabled = True
        Me.btnReg.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False

        Dim DbName As String = String.Empty
        If Canceli = False Then
            DbName = "Bank"
        Else
            DbName = "GharardadDelBank"
        End If

        '----------------------------
        Try
            Cmd.CommandText = "insert into " & DbName & " (ID,Price,Date,Passed,RegDate,RegDay,Pardakhte,FormType,Tozihat,Jahate,PardakhtDate) values ('" & OwnerID & "'," & Cu.DeCodeNumber(Me.txtPrice.Text) & ",N'" & Me.txtDate.Text & "','" & Me.ChkPardakhtShod.Checked & "',N'" & Date1 & "',N'" & Day1 & "',N'" & Type & "',N'" & FormType & "',N'" & Me.txtTozihat.Text & "',N'" & Me.cboSayerJahate.Text & "',N'" & Me.txtPardakhtDate.Text & "')"
            Cmd.Connection = SqlCon.SqlCon

            SqlCon.SqlCon.Open()

            Cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        RefreshText()
        FillGrid()

    End Sub

    Private Sub RefreshText()

        Me.btnNew.Enabled = False
        Me.btnReg.Enabled = True
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False
        Me.ChkPardakhtShod.Checked = False

        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox AndAlso c.Text <> "" Then
                c.Text = ""
            End If
        Next
        Me.txtPrice.Focus()
        Me.txtPrice.Text = "0"
        SUM()
    End Sub

    Private Sub FillGrid()
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()

        Dim DbName As String = String.Empty
        If Canceli = False Then
            DbName = "Bank"
        Else
            DbName = "GharardadDelBank"
        End If

        Try
            Cmd.CommandText = "Select  Row_Number() Over(order by Date Desc) as 'ردیف', Passed as 'وضعیت پرداخت',Price as 'مبلغ پرداخت نقدی',Date as 'تاریخ سررسید',Tozihat as 'توضیحات',Row as 'کد شناسائی'  from " & DbName & " where ID=N'" & OwnerID & "' and Pardakhte=N'" & Type & "' And FormType=N'" & FormType & "'  order by RegDate"

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
            End While
            dvw = New DataView(tbl)
            Me.dbgTahator.DataSource = dvw


        Catch ex As Exception

        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgTahator.Refresh()


    End Sub

    Private Sub FillTextBox(ByVal Row As String)

        Dim DbName As String = String.Empty
        If Canceli = False Then
            DbName = "Bank"
        Else
            DbName = "GharardadDelBank"
        End If

        Dim cmd As New SqlClient.SqlCommand("SELECT Price,date,Tozihat,Passed,Jahate,PardakhtDate From " & DbName & " where Row='" & Row & "'", SqlCon.SqlCon)

        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            While sdr.Read


                Me.txtPrice.Text = Cu.CodeNumber(sdr(0).ToString)
                Me.txtDate.Text = sdr(1).ToString
                Me.txtTozihat.Text = sdr(2).ToString
                Me.ChkPardakhtShod.Checked = sdr(3)
                Me.cboSayerJahate.Text = sdr(4).ToString
                Me.txtPardakhtDate.Text = sdr(5).ToString

                Me.btnNew.Enabled = True
                Me.btnReg.Enabled = False
                Me.btnEdit.Enabled = True
                Me.btnDelete.Enabled = True
                Me.btnPrint.Enabled = True
            End While
        Catch ex As Exception
            RefreshText()
        Finally

            SqlCon.SqlCon.Close()
        End Try

    End Sub

    Private Sub dbgCheck_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dbgTahator.CellClick

        Try
            Row = Me.dbgTahator.CurrentRow.Cells.Item(5).Value.ToString
            FillTextBox(Row)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dbgCheck_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dbgTahator.KeyDown, dbgTahator.KeyUp
        Try
            Row = Me.dbgTahator.CurrentRow.Cells.Item(5).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("آیا مایلید اطلاعات فوق حذف گردد؟", "حذف اطلاعات", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.Yes = True Then
            Dim DbName As String = String.Empty
            If Canceli = False Then
                DbName = "Bank"
            Else
                DbName = "GharardadDelBank"
            End If


            Try
                Dim cmd As New SqlClient.SqlCommand("Delete " & DbName & " where Row='" & Row & "'", SqlCon.SqlCon)
                SqlCon.SqlCon.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                RefreshText()
            Finally
                SqlCon.SqlCon.Close()
                FillGrid()
            End Try
            RefreshText()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Me.btnNew.Enabled = True
        Me.btnReg.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False

        Dim DbName As String = String.Empty
        If Canceli = False Then
            DbName = "Bank"
        Else
            DbName = "GharardadDelBank"
        End If

        '----------------------------
        Dim Result As Windows.Forms.DialogResult = MessageBox.Show("آیا اطلاعات به تاریخ امروز باز نویسی شود", "تاریخ بازنگری", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        If Result = Windows.Forms.DialogResult.Yes Then
            Cmd.CommandText = "Update " & DbName & " Set Price=" & Cu.DeCodeNumber(Me.txtPrice.Text) & ",Date=N'" & Me.txtDate.Text & "',Passed='" & Me.ChkPardakhtShod.Checked & "',RegDate=N'" & Date1 & "',RegDay=N'" & Day1 & "',Tozihat=N'" & Me.txtTozihat.Text & "',Jahate=N'" & Me.cboSayerJahate.Text & "',PardakhtDate=N'" & Me.txtPardakhtDate.Text & "' where Row='" & Row & "'"
        ElseIf Result = Windows.Forms.DialogResult.No Then
            Cmd.CommandText = "Update " & DbName & " Set Price=" & Cu.DeCodeNumber(Me.txtPrice.Text) & ",Date=N'" & Me.txtDate.Text & "',Passed='" & Me.ChkPardakhtShod.Checked & "',Tozihat=N'" & Me.txtTozihat.Text & "',Jahate=N'" & Me.cboSayerJahate.Text & "',PardakhtDate=N'" & Me.txtPardakhtDate.Text & "' where Row='" & Row & "'"
        ElseIf Result = Windows.Forms.DialogResult.Cancel Then
            FillGrid()
            RefreshText()
            Exit Sub
        End If

        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
        RefreshText()

    End Sub

    Private Sub txtPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.GotFocus

        Try
            Me.txtPrice.Text = Cu.DeCodeNumber(Me.txtPrice.Text)
        Catch ex As Exception
            Me.txtPrice.Focus()
        End Try

    End Sub
    Private Sub txtPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.LostFocus

        Try
            Me.txtPrice.Text = Cu.CodeNumber(Me.txtPrice.Text)
        Catch ex As Exception
            Me.txtPrice.Focus()
        End Try

    End Sub


    Private Sub txtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
        Dim DM As New DateMode
        Try
            Me.txtDate.Text = DM.DECodeDate(Me.txtDate.Text)
        Catch ex As Exception
            Me.txtDate.Focus()
        End Try
    End Sub

    Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
        Dim DM As New DateMode
        Try
            Me.txtDate.Text = DM.CodeDate(Me.txtDate.Text)
        Catch ex As Exception
            Me.txtDate.Focus()
        End Try
    End Sub

    Private Sub SUM()
        'If Pish = True Then
        '    Me.txtPrice.Text = Price - Double.Parse(GetSumPish.GetSum(OwnerID))
        'Else
        '    Me.txtPrice.Text = Price - Double.Parse(GetSum.GetSum(OwnerID, "اقساط"))
        'End If

        If Type = "اقساط" Or Type = "نقدی" Then
            Me.txtPrice.Text = Cu.CodeNumber(Price - (Double.Parse(GetSum.GetSum(OwnerID, "اقساط") + Double.Parse(GetSum.GetSum(OwnerID, "نقدی")))) + Double.Parse(GetSum.GetSum(OwnerID, "سایر پرداخت ها")))
        Else
            Me.txtPrice.Text = Cu.CodeNumber(Price - Double.Parse(GetSum.GetSum(OwnerID, Type)) + Double.Parse(GetSum.GetSum(OwnerID, "سایر پرداخت ها")))
        End If


    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Me.ChkPardakhtShod.Checked = True Then
            Dim RptRD As New RptResidDaryaftVajh
            RptRD.Generate(Row)

            Dim frm As New frmReporter
            'frm.MdiParent = Mehregan.Parent
            frm.CrystalReportViewer1.ReportSource = frm.rptResideDaryaft1
            frm.rptResideDaryaft1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
            frm.rptResideDaryaft1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            frm.Show()
        Else
            MessageBox.Show("امکان چاپ قسط پرداخت نشده نمی باشد", "خطا در چاپ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False)
        End If

    End Sub
    Private Sub ChkPardakhtShod_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPardakhtShod.CheckedChanged
        ChkChecked()
    End Sub
    Private Sub ChkChecked()
        If Me.ChkPardakhtShod.Checked = True Then
            Me.BackColor = Color.Green
        Else
            Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub txtPardakhtDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPardakhtDate.TextChanged
        If Me.txtPardakhtDate.Text <> "" Then
            Me.ChkPardakhtShod.Checked = True
        Else
            Me.ChkPardakhtShod.Checked = False
        End If
    End Sub

End Class