Public Class frmVarizBeHesab


    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private Date1, Day1 As String
    Public OwnerID, Type, FormType As String
    Private Tmp(4) As String
    Private Cu As New Currency
    Private Mony As Integer
    Public Price, Saghf As String
    Public GharardadPrice As String
    Public SayerVisible As Boolean
    Public MajmooeID As String
    Public Canceli As Boolean
    Private Answer As Boolean
    Private MC As New MonyCheck
    'Private GetSum As New GetSum
    Private GetSum As New GetSum

    ' Public Pish As Boolean

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
        Cmd.CommandText = "insert into " & DbName & " (ID,price,AccountNo,accountOwner,Serial,CodePeygiri,date,VarizTime,destinationAccount,Tozihat,Passed,RegDate,RegDay,Pardakhte,FormType,Jahate,PardakhtDate) values ('" & OwnerID & "'," & Cu.DeCodeNumber(Me.txtPrice.Text) & ",N'" & Me.txtAccountNo.Text & "',N'" & Me.txtAccountOwnerName.Text & "',N'" & Me.txtFishNo.Text & "',N'" & Me.txtPeygiriCode.Text & "',N'" & Me.txtDate.Text & "',N'" & Me.txtTime.Text & "',N'" & Me.txtDestinationAccount.Text & "',N'" & Me.txtTozihat.Text & "','" & Me.ChkPardakhtShod.Checked & "',N'" & Date1 & "',N'" & Day1 & "',N'" & Type & "',N'" & FormType & "',N'" & Me.cboSayerJahate.Text & "',N'" & Me.txtPardakhtDate.Text & "')"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
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
            Cmd.CommandText = "Select  Row_Number() Over(order by Date Desc) as 'ردیف', Passed as 'وضعیت پرداخت',price as 'مبلغ قسط' ,accountOwner as 'نام صاحب حساب',date as 'تاریخ سررسید',Row as 'کد شناسائی'  from " & DbName & " where ID=N'" & OwnerID & "'  and Pardakhte=N'" & Type & "' And FormType=N'" & FormType & "' order by Date Desc"

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
            Me.dbgBank.DataSource = dvw

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgBank.Refresh()


    End Sub

    Private Sub FillTextBox(ByVal Row As String)
        Dim DbName As String = String.Empty
        If Canceli = False Then
            DbName = "Bank"
        Else
            DbName = "GharardadDelBank"
        End If

        '                                             0       1           2      3          4       5       6           7               8       9       10      11      
        Dim cmd As New SqlClient.SqlCommand("SELECT price,AccountNo,accountOwner,Serial,CodePeygiri,date,VarizTime,destinationAccount,Tozihat,Passed,Jahate,PardakhtDate From " & DbName & " where Row='" & Row & "'", SqlCon.SqlCon)

        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            While sdr.Read
                Me.txtPrice.Text = Cu.CodeNumber(sdr(0).ToString)
                Me.txtAccountNo.Text = sdr(1).ToString
                Me.txtAccountOwnerName.Text = sdr(2).ToString
                Me.txtFishNo.Text = sdr(3).ToString
                Me.txtPeygiriCode.Text = sdr(4).ToString
                Me.txtDate.Text = sdr(5).ToString
                Me.txtTime.Text = sdr(6).ToString
                Me.txtDestinationAccount.Text = sdr(7).ToString
                Me.txtTozihat.Text = sdr(8).ToString
                Me.ChkPardakhtShod.Checked = sdr(9)
                Me.cboSayerJahate.Text = sdr(10).ToString
                Me.txtPardakhtDate.Text = sdr(11).ToString

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
        Me.txtSumAll.Text = GetSumAll(DbName, Me.txtPeygiriCode.Text)
        ChkChecked()
    End Sub

    Private Sub dbgCheck_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dbgBank.CellClick, dbgBank.CellClick
        Try
            Me.txtSandCode.Text = Me.dbgBank.CurrentRow.Cells.Item(5).Value.ToString
            FillTextBox(Me.txtSandCode.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            RefreshText()
        End Try
    End Sub

    Private Sub dbgCheck_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dbgBank.KeyDown, dbgBank.KeyUp, dbgBank.KeyUp, dbgBank.KeyDown
        Try
            Me.txtSandCode.Text = Me.dbgBank.CurrentRow.Cells.Item(5).Value.ToString
            FillTextBox(Me.txtSandCode.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
            RefreshText()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim DbName As String = String.Empty
        If Canceli = False Then
            DbName = "Bank"
        Else
            DbName = "GharardadDelBank"
        End If

        If MessageBox.Show("آیا مایلید اطلاعات فوق حذف گردد؟", "حذف اطلاعات", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.Yes = True Then
            Try
                Dim cmd As New SqlClient.SqlCommand("Delete " & DbName & " where Row='" & Me.txtSandCode.Text & "'", SqlCon.SqlCon)
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

        '----------------------------
        'Dim Result As Windows.Forms.DialogResult = MessageBox.Show("?آیا اطلاعات به تاریخ امروز باز نویسی شود", "تاریخ بازنگری", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        'If Result = Windows.Forms.DialogResult.Yes Then
        '    Cmd.CommandText = "Update Bank Set price=" & Cu.DeCodeNumber(Me.txtPrice.Text) & ",AccountNo=N'" & Me.txtAccountNo.Text & "',accountOwner=N'" & Me.txtAccountOwnerName.Text & "',Serial=N'" & Me.txtFishNo.Text & "',Codepeygiri=N'" & Me.txtPeygiriCode.Text & "',date=N'" & Me.txtDate.Text & "',VarizTime=N'" & Me.txtTime.Text & "',destinationAccount=N'" & Me.txtDestinationAccount.Text & "',Tozihat=N'" & Me.txtTozihat.Text & "',Passed='" & Me.ChkPardakhtShod.Checked & "',UpdateDate=N'" & Date1 & "',UpdateDay=N'" & Day1 & "',Pardakhte = N'" & Type & "',Jahate=N'" & Me.cboSayerJahate.Text & "',PardakhtDate=N'" & Me.txtPardakhtDate.Text & "' where Row='" & Me.txtSandCode.Text & "'"
        'ElseIf Result = Windows.Forms.DialogResult.No Then
        '    Cmd.CommandText = "Update Bank Set price=" & Cu.DeCodeNumber(Me.txtPrice.Text) & ",AccountNo=N'" & Me.txtAccountNo.Text & "',accountOwner=N'" & Me.txtAccountOwnerName.Text & "',Serial=N'" & Me.txtFishNo.Text & "',Codepeygiri=N'" & Me.txtPeygiriCode.Text & "',date=N'" & Me.txtDate.Text & "',VarizTime=N'" & Me.txtTime.Text & "',destinationAccount=N'" & Me.txtDestinationAccount.Text & "',Tozihat=N'" & Me.txtTozihat.Text & "',Passed='" & Me.ChkPardakhtShod.Checked & "',Jahate=N'" & Me.cboSayerJahate.Text & "',PardakhtDate=N'" & Me.txtPardakhtDate.Text & "' where Row='" & Me.txtSandCode.Text & "'"
        'ElseIf Result = Windows.Forms.DialogResult.Cancel Then
        '    'FillGrid()
        '    'RefreshText()
        '    Exit Sub
        'End If
        Dim DbName As String = String.Empty
        If Canceli = False Then
            DbName = "Bank"
        Else
            DbName = "GharardadDelBank"
        End If

        Try
            Cmd.CommandText = "Update " & DbName & " Set price=" & Cu.DeCodeNumber(Me.txtPrice.Text) & ",AccountNo=N'" & Me.txtAccountNo.Text & "',accountOwner=N'" & Me.txtAccountOwnerName.Text & "',Serial=N'" & Me.txtFishNo.Text & "',Codepeygiri=N'" & Me.txtPeygiriCode.Text & "',date=N'" & Me.txtDate.Text & "',VarizTime=N'" & Me.txtTime.Text & "',destinationAccount=N'" & Me.txtDestinationAccount.Text & "',Tozihat=N'" & Me.txtTozihat.Text & "',Passed='" & Me.ChkPardakhtShod.Checked & "',UpdateDate=N'" & Date1 & "',UpdateDay=N'" & Day1 & "',Pardakhte = N'" & Type & "',Jahate=N'" & Me.cboSayerJahate.Text & "',PardakhtDate=N'" & Me.txtPardakhtDate.Text & "' where Row='" & Me.txtSandCode.Text & "'"
            Cmd.Connection = SqlCon.SqlCon
            SqlCon.SqlCon.Open()
            Cmd.ExecuteNonQuery()
            MessageBox.Show("اطلاعات با موفقیت بروز  رسانی گردید.", "بروزرسانی اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...btnEdit_Click", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
        RefreshText()

    End Sub

    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Tmp(0) = Me.txtPrice.Text
        Tmp(1) = Me.txtAccountNo.Text
        Tmp(2) = Me.txtAccountOwnerName.Text
        Tmp(3) = Me.txtDestinationAccount.Text
    End Sub

    Private Sub bntPaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntPaste.Click
        Me.txtPrice.Text = Tmp(0)
        Me.txtAccountNo.Text = Tmp(1)
        Me.txtAccountOwnerName.Text = Tmp(2)
        Me.txtDestinationAccount.Text = Tmp(3)
        Me.txtPrice.Focus()
    End Sub

    Private Sub txtPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.GotFocus
        Try
            Me.txtPrice.Text = Cu.DeCodeNumber(Me.txtPrice.Text)
        Catch ex As Exception
            txtPrice.Focus()
        End Try
    End Sub
    Private Sub txtPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.LostFocus
        Try
            Me.txtPrice.Text = Cu.CodeNumber(Me.txtPrice.Text)
        Catch ex As Exception
            txtPrice.Focus()
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

    Private Function MonyCheck()

        Dim DbName As String = String.Empty
        If Canceli = False Then
            DbName = "Bank"
        Else
            DbName = "GharardadDelBank"
        End If

        Cmd.Connection = SqlCon.SqlCon
        Cmd.CommandText = "SELECT Sum(Cprice) From " & DbName & " where ID=N'" & OwnerID & "'  and Pardakhte=N'" & Type & "'"

        SqlCon.SqlCon.Open()
        Sdr = Cmd.ExecuteReader
        Try
            While Sdr.Read
                Mony = Integer.Parse(Sdr(0).ToString)
            End While
        Catch ex As Exception
            'MessageBox.Show("خطا در شمارش مبالغ چکها", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Answer = False
        Finally

            SqlCon.SqlCon.Close()
        End Try

        If Price - Mony <= 0 Then
            MessageBox.Show("شما مجاز به درج مبلغ فوق نمی باشید", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Answer = False
        ElseIf Not (Price - Mony) >= Cu.DeCodeNumber(Me.txtPrice.Text) Then
            MessageBox.Show("شما مجاز به درج مبلغ فوق نمی باشید" & vbCrLf & " شما با سقف مبلغ " & Cu.CodeNumber(Price - Mony) & " مجاز به درج مبلغ می باشید ", "...::: خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Answer = False
        Else
            Answer = True
        End If

        Return (Answer)

    End Function
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
            RptRD.Generate(Me.txtSandCode.Text)

            Dim frm As New frmReporter
            frm.MdiParent = Mehregan.Parent
            frm.CrystalReportViewer1.ReportSource = frm.rptResideDaryaft1
            frm.rptResideDaryaft1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
            frm.rptResideDaryaft1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            frm.Show()
            Me.Visible = False
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

    Private Sub txtPeygiriCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeygiriCode.KeyPress, txtFishNo.KeyPress
        If e.KeyChar = Chr(13) And Me.cboPartOf.Text = "کل" Then
            If Me.ChkPardakhtShod.Checked = False Then
                SearchData()
            End If

        ElseIf e.KeyChar = Chr(13) And Me.cboPartOf.Text = "ازمحل" Then

            Dim DbName As String = String.Empty
            If Canceli = False Then
                DbName = "Bank"
            Else
                DbName = "GharardadDelBank"
            End If

            '                                             0       1           2      3          4       5       6           7               8       9       10      11      
            Dim cmd As New SqlClient.SqlCommand("SELECT price,AccountNo,accountOwner,Serial,CodePeygiri,date,VarizTime,destinationAccount,Tozihat,Passed,Jahate,PardakhtDate From " & DbName & " where CodePeygiri='" & Me.txtPeygiriCode.Text & "'", SqlCon.SqlCon)

            SqlCon.SqlCon.Open()
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            Try
                While sdr.Read
                    Me.txtPrice.Text = Cu.CodeNumber(sdr(0).ToString)
                    Me.txtAccountNo.Text = sdr(1).ToString
                    Me.txtAccountOwnerName.Text = sdr(2).ToString
                    Me.txtFishNo.Text = sdr(3).ToString
                    Me.txtPeygiriCode.Text = sdr(4).ToString
                    Me.txtDate.Text = sdr(5).ToString
                    Me.txtTime.Text = sdr(6).ToString
                    Me.txtDestinationAccount.Text = sdr(7).ToString
                    Me.txtTozihat.Text = sdr(8).ToString
                    Me.ChkPardakhtShod.Checked = sdr(9)
                    Me.cboSayerJahate.Text = sdr(10).ToString
                    Me.txtPardakhtDate.Text = sdr(11).ToString

                End While
            Catch ex As Exception
                RefreshText()
            Finally
                SqlCon.SqlCon.Close()
            End Try
            Me.txtSumAll.Text = GetSumAll(DbName, Me.txtPeygiriCode.Text)
        End If
    End Sub

    Private Sub SearchData()
        Cu = New Currency
        Dim Shart As String = String.Empty
        If Me.txtPeygiriCode.Text <> "" Then
            Shart = " Where (Serial Like N'%" & Me.txtPeygiriCode.Text & "%' OR Sharh Like N'%" & Me.txtPeygiriCode.Text & "%' Or Varizkonnade Like N'%" & Me.txtPeygiriCode.Text & "%') And Mablagh=N'+" & Cu.DeCodeNumber(Me.txtPrice.Text) & "'"
        ElseIf Me.txtFishNo.Text <> "" Then
            Shart = " Where (Serial Like N'%" & Me.txtFishNo.Text & "%' OR Sharh Like N'%" & Me.txtFishNo.Text & "%' Or Varizkonnade Like N'%" & Me.txtFishNo.Text & "%') And Mablagh=N'+" & Cu.DeCodeNumber(Me.txtPrice.Text) & "'"
        End If

        Dim SQLCONection As New SQL
        Try
            '                                                       0                   1                       2                       3                 4                     5
            Dim cmd2 As New SqlClient.SqlCommand("Select Mablagh as 'مبلغ گردش',Sharh as 'شرح',VarizKonnade as 'واریز کننده/ذینفع',zaman as 'زمان',Tarikh as 'تاریخ',AccountNo as 'شماره حساب مقصد' from bankMellat " & Shart & "", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            If sdr2.Read Then
                Me.txtPrice.Text = Cu.CodeNumber(Integer.Parse(sdr2(0).ToString))
                Me.txtTozihat.Text += sdr2(1).ToString
                Me.txtAccountNo.Text = sdr2(2).ToString
                Me.txtTime.Text = sdr2(3).ToString
                Me.txtPardakhtDate.Text = sdr2(4).ToString
                Me.txtDestinationAccount.Text = sdr2(5).ToString
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            SQLCONection.SqlCon.Close()
        End Try
    End Sub

    Private Function GetSumAll(ByVal DbName As String, ByVal CP As String)
        Cu = New Currency
        Dim Value As String = 0
        Dim cmd As New SqlClient.SqlCommand("SELECT Sum(Price) From " & DbName & " where CodePeygiri='" & CP & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            While sdr.Read
                Value = sdr(0).ToString
            End While
        Catch ex As Exception
        Finally
            SqlCon.SqlCon.Close()
        End Try
        Return Cu.CodeNumber(Value)
    End Function

End Class

