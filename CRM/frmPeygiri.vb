Public Class frmPeygiri
    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private Row As String
    Private CD As CurrentDate
    Public UserID As String


    Private Sub frmPeygiri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnNew.Enabled = False
        Me.btnReg.Enabled = True
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False
        CD = New CurrentDate
        Me.txtPeigiriTime.Text = Now.Hour & ":" & Now.Minute
        Me.txtPeigiriDate.Text = CD.GetDate
        Me.txtReportDate.Text = CD.GetDate


        UserID = Me.txtUserName.Text

        FillCboMoshaver()
        FillCboMorajeinName()
        FillGrid()
    End Sub


    Private Sub FillCboMoshaver()
        Dim cmd As New SqlClient.SqlCommand("SELECT SallerName from SallerName", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        While sdr.Read
            Me.cboMoshaver.Items.Add(sdr(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub


    Private Sub FillCboMorajeinName()
        Dim cmd As New SqlClient.SqlCommand("select Name + ' ' + Lname as 'FullName' from gharardadno group by name,lname", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        While sdr.Read
            Me.cboMoshtariName.Items.Add(sdr(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Me.btnNew.Enabled = True
        Me.btnReg.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False

        Cmd.CommandText = "Insert Into Peygiri (UserID,PeygiriKonnande,MoshtariName,MoshaverName,Mobile,Phone,PeygiriDate,PeygiriTime,PeygiriSubject,NatijeDate,NatijeTime,NatijeSubject) Values (N'" & UserID & "',N'" & Me.cboPeygiriConandeUser.Text & "',N'" & Me.cboMoshtariName.Text & "',N'" & Me.cboMoshaver.Text & "',N'" & Me.txtMobile.Text & "',N'" & Me.txtPhone.Text & "',N'" & Me.txtPeigiriDate.Text & "',N'" & Me.txtPeigiriTime.Text & "',N'" & Me.txtPeigiriSubject.Text & "',N'" & Me.txtNatijeDate.Text & "',N'" & Me.txtNatijeTime.Text & "',N'" & Me.txtNatijeText.Text & "')"
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

    Private Sub dbgView_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgEvents.CellMouseDoubleClick
        FillData(Me.dbgEvents.CurrentRow.Cells.Item(11).Value.ToString)
    End Sub

    Private Sub FillData(ByVal IDD As String)
        RefreshText()
        Me.btnNew.Enabled = True
        Me.btnReg.Enabled = False
        Me.btnEdit.Enabled = True
        Me.btnDelete.Enabled = True

        Try
            Dim cmd As New SqlClient.SqlCommand("Select PeygiriKonnande,MoshtariName,MoshaverName,Mobile,Phone,PeygiriDate,PeygiriTime,PeygiriSubject,NatijeDate,NatijeTime,NatijeSubject From Peygiri Where ID='" & IDD & "'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            While sdr.Read
                Row = sdr(0).ToString

            End While
        Catch ex As Exception
            RefreshText()
        Finally
            SqlCon.SqlCon.Close()
        End Try
    End Sub

    Private Sub RefreshText()
        Me.btnNew.Enabled = False
        Me.btnReg.Enabled = True
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False

        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox AndAlso c.Text <> "" Then
                c.Text = ""
            End If
        Next


        Dim c2 As Control
        For Each c2 In Me.GroupBox2.Controls
            If TypeOf c2 Is TextBox AndAlso c2.Text <> "" Then
                c2.Text = ""
            End If
        Next

        Dim c3 As Control
        For Each c3 In Me.GroupBox3.Controls
            If TypeOf c3 Is TextBox AndAlso c3.Text <> "" Then
                c3.Text = ""
            End If
        Next

        Dim c4 As Control
        For Each c4 In Me.GroupBox4.Controls
            If TypeOf c4 Is TextBox AndAlso c4.Text <> "" Then
                c4.Text = ""
            End If
        Next


        Me.cboPeygiriConandeUser.Text = ""
        Me.cboMoshtariName.Text = ""
        Me.cboMoshaver.Text = ""

        CD = New CurrentDate
        Me.txtReportDate.Text = CD.GetDate

    End Sub
    Private Sub FillGrid()
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()
        Try
            Cmd.CommandText = "Select MoshtariName,PeygiriKonnande,MoshaverName,Mobile,Phone,PeygiriDate,PeygiriTime,PeygiriSubject,NatijeDate,NatijeTime,NatijeSubject,UserID From Peygiri Where PeygiriDate=N'" & Me.txtReportDate.Text & "' And UserID='" & UserID & "' Order By ID"
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
            Me.dbgEvents.DataSource = dvw
            tbl.TableName = "Peygiri"
            tbl.WriteXml("c:\Reports\Peygiri.xml")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا در خواندن اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Me.btnNew.Enabled = True
        Me.btnReg.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False

        '----------------------------
        Dim Result As Windows.Forms.DialogResult = MessageBox.Show("آیا اطلاعات به تاریخ امروز باز نویسی شود", "تاریخ بازنگری", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        If Result = Windows.Forms.DialogResult.Yes Then
            Cmd.CommandText = "Update peygiri Set UserID='" & UserID & "', PeygiriKonnande=N'" & Me.cboPeygiriConandeUser.Text & "', MoshtariName=N'" & Me.cboMoshtariName.Text & "', MoshaverName=N'" & Me.cboMoshaver.Text & "', Mobile=N'" & Me.txtMobile.Text & "', Phone=N'" & Me.txtPhone.Text & "', PeygiriDate=N'" & Me.txtPeigiriDate.Text & "', PeygiriTime=N'" & Me.txtPeigiriTime.Text & "', PeygiriSubject=N'" & Me.txtPeigiriSubject.Text & "', NatijeDate=N'" & Me.txtNatijeDate.Text & "', NatijeTime=N'" & Me.txtNatijeTime.Text & "', NatijeSubject=N'" & Me.txtNatijeText.Text & "' where ID='" & Row & "'"
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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("آیا مایلید اطلاعات فوق حذف گردد؟", "حذف اطلاعات", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.Yes = True Then
            Try
                Dim cmd As New SqlClient.SqlCommand("Delete Peygiri where ID='" & Row & "'", SqlCon.SqlCon)
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

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Me.btnNew.Enabled = False
        Me.btnReg.Enabled = True
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False
        Me.btnPrint.Enabled = False
        RefreshText()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim RptRD As New RptResidDaryaftVajh
        RptRD.Generate(Row)

        Dim frm As New frmReporter
        'frm.MdiParent = Mehregan.Parent
        frm.CrystalReportViewer1.ReportSource = frm.rptMorajein1
        frm.rptMorajein1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
        frm.rptMorajein1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        frm.ShowDialog()
    End Sub

    Private Sub txtReportDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReportDate.KeyPress
        If e.KeyChar = Chr(13) Then
            FillGrid()
        End If
    End Sub

    Private Sub cboMorajeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMoshtariName.SelectedIndexChanged
        Try
            Dim cmd As New SqlClient.SqlCommand("select G.Mobile,G.homephone,S.SallerName from gharardadno G inner join SallerName S on S.ID=G.SallerNameID where G.Name + ' ' + G.Lname=N'" & Me.cboMoshtariName.Text & "'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            While sdr.Read
                Me.txtMobile.Text = sdr(0).ToString
                Me.txtPhone.Text = sdr(1).ToString
                Me.cboMoshaver.Text = sdr(2).ToString
            End While
        Catch ex As Exception

        Finally
            SqlCon.SqlCon.Close()
        End Try

    End Sub

End Class