Public Class frmRegMorajein
    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private Row As String
    Private CD As CurrentDate


    Private Sub frmRegMorajein_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.btnNew.Enabled = False
        Me.btnReg.Enabled = True
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False
        CD = New CurrentDate
        Me.txtMorajeTime.Text = Now.Hour & ":" & Now.Minute
        Me.txtMorajeDate.Text = CD.GetDate
        Me.txtReportDate.Text = CD.GetDate


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
            Me.cboMorajeName.Items.Add(sdr(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub FillCboMolaghatShavande()
        Dim cmd As New SqlClient.SqlCommand("SELECT Name + ' ' + Lname as 'FullName' from Persenel", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        While sdr.Read
            Me.cboMolaghatName.Items.Add(sdr(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Me.btnNew.Enabled = True
        Me.btnReg.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnDelete.Enabled = False

        Cmd.CommandText = "insert into Morajein (MorajeDate,MorajeTime,MorajeName,MoshaverID,MorajeJob,MorajeHomePhone,MorajeWorkPhone,MorajeFax,MorajeMobile,MorajeEmail,MorajeEllat,MolaghatNames,MolaghatNatije) values (N'" & Me.txtMorajeDate.Text & "',N'" & Me.txtMorajeTime.Text & "',N'" & Me.cboMorajeName.Text & "',N'" & Me.cboMoshaver.Text & "',N'" & Me.txtMorajeJob.Text & "',N'" & Me.txtMorajeHomePhone.Text & "',N'" & Me.txtMorajeWorkPhone.Text & "',N'" & Me.txtMorajeFax.Text & "',N'" & Me.txtMorajeMobile.Text & "',N'" & Me.txtMorajeEmail.Text & "',N'" & Me.cboMorajeEllat.Text & "',N'" & Me.txtMolaghatNames.Text & "',N'" & Me.txtMolaghatNatije.Text & "')"
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
        FillData(Me.dbgEvents.CurrentRow.Cells.Item(13).Value.ToString)
    End Sub

    Private Sub FillData(ByVal IDD As String)
        RefreshText()
        Me.btnNew.Enabled = True
        Me.btnReg.Enabled = False
        Me.btnEdit.Enabled = True
        Me.btnDelete.Enabled = True

        Try
            Dim cmd As New SqlClient.SqlCommand("Select ID,MorajeDate,MorajeTime,MorajeName,MoshaverID,MorajeJob,MorajeHomePhone,MorajeWorkPhone,MorajeFax,MorajeMobile,MorajeEmail,MorajeEllat,MolaghatNames,MolaghatNatije From Morajein Where ID='" & IDD & "'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            While sdr.Read
                Row = sdr(0).ToString
                Me.txtMorajeDate.Text = sdr(1).ToString
                Me.txtMorajeTime.Text = sdr(2).ToString
                Me.cboMorajeName.Text = sdr(3).ToString
                Me.cboMoshaver.Text = sdr(4).ToString
                Me.txtMorajeJob.Text = sdr(5).ToString
                Me.txtMorajeHomePhone.Text = sdr(6).ToString
                Me.txtMorajeWorkPhone.Text = sdr(7).ToString
                Me.txtMorajeFax.Text = sdr(8).ToString
                Me.txtMorajeMobile.Text = sdr(9).ToString
                Me.txtMorajeEmail.Text = sdr(10).ToString
                Me.cboMorajeEllat.Text = sdr(11).ToString
                Me.txtMolaghatNames.Text = sdr(12).ToString
                Me.txtMolaghatNatije.Text = sdr(13).ToString
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

        Dim c1 As Control
        For Each c1 In Me.GroupBox1.Controls
            If TypeOf c1 Is TextBox AndAlso c1.Text <> "" Then
                c1.Text = ""
            End If
        Next

        Dim c2 As Control
        For Each c2 In Me.GroupBox2.Controls
            If TypeOf c2 Is TextBox AndAlso c2.Text <> "" Then
                c2.Text = ""
            End If
        Next


        Me.cboMolaghatName.Text = ""
        Me.cboMorajeEllat.Text = ""
        Me.cboMorajeName.Text = ""
        Me.cboMoshaver.Text = ""

        CD = New CurrentDate
        Me.txtMorajeTime.Text = Now.Hour & ":" & Now.Minute
        Me.txtMorajeDate.Text = CD.GetDate
        Me.txtReportDate.Text = CD.GetDate

    End Sub
    Private Sub FillGrid()
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()
        Try
            Cmd.CommandText = "Select MorajeName as 'نام مراجعه کننده',MoshaverID as 'نام مشاور',MorajeJob as 'شلغ',MorajeHomePhone as 'تلفن منزل',MorajeWorkPhone as 'تلفن محل کار',MorajeFax as 'نمابر',MorajeMobile as 'موبایل',MorajeEmail as 'پست الکترونیکی',MorajeEllat as 'علت مراجعه',MolaghatNames as 'ملاقات شونده',MolaghatNatije as 'نتیجه ملاقات',MorajeDate as 'تاریخ مراجعه',MorajeTime as 'زمان مراجعه',ID as 'کد شناسائی' From Morajein Where MorajeDate=N'" & Me.txtReportDate.Text & "' Order By ID"
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
            tbl.TableName = "Morajein"
            tbl.WriteXml("c:\Reports\Morajein.xml")
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
            Cmd.CommandText = "Update Morajein Set MorajeDate=N'" & Me.txtMorajeDate.Text & "',MorajeTime=N'" & Me.txtMorajeTime.Text & "', MorajeName=N'" & Me.cboMorajeName.Text & "', MoshaverID=N'" & Me.cboMoshaver.Text & "', MorajeJob=N'" & Me.txtMorajeJob.Text & "', MorajeHomePhone=N'" & Me.txtMorajeHomePhone.Text & "', MorajeWorkPhone=N'" & Me.txtMorajeWorkPhone.Text & "', MorajeFax=N'" & Me.txtMorajeFax.Text & "', MorajeMobile=N'" & Me.txtMorajeMobile.Text & "', MorajeEmail=N'" & Me.txtMorajeEmail.Text & "', MorajeEllat=N'" & Me.cboMorajeEllat.Text & "', MolaghatNames=N'" & Me.txtMolaghatNames.Text & "', MolaghatNatije=N'" & Me.txtMolaghatNatije.Text & "' where ID='" & Row & "'"
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
                Dim cmd As New SqlClient.SqlCommand("Delete Morajein where ID='" & Row & "'", SqlCon.SqlCon)
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

    Private Sub btnRegMolaghatName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegMolaghatName.Click
        Me.txtMolaghatNames.Text += Me.cboMolaghatName.Text & vbCrLf
    End Sub

    Private Sub txtReportDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReportDate.KeyPress
        If e.KeyChar = Chr(13) Then
            FillGrid()
        End If
    End Sub

    Private Sub cboMorajeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMorajeName.SelectedIndexChanged
        Try
            Dim cmd As New SqlClient.SqlCommand("select G.Job,G.Mobile,G.homephone,G.fax,G.email,G.WorkPhone,S.SallerName from gharardadno G inner join SallerName S on S.ID=G.SallerNameID where G.Name + ' ' + G.Lname=N'" & Me.cboMorajeName.Text & "'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
            While sdr.Read
                Me.txtMorajeJob.Text = sdr(0).ToString
                Me.txtMorajeMobile.Text = sdr(1).ToString
                Me.txtMorajeHomePhone.Text = sdr(2).ToString
                Me.txtMorajeFax.Text = sdr(3).ToString
                Me.txtMorajeEmail.Text = sdr(4).ToString
                Me.txtMorajeWorkPhone.Text = sdr(5).ToString
                Me.cboMoshaver.Text = sdr(6).ToString
            End While
        Catch ex As Exception

        Finally
            SqlCon.SqlCon.Close()
        End Try

    End Sub
End Class