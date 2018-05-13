Public Class frmRegZone

    Private SqlCon, SqlCon0 As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private MajmooeID As String
    Private ZoneID As String

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        RefreshText()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click

        Cmd.CommandText = "insert into Zone (MajmooeID,Zone,CodingCode) values ('" & MajmooeID & "',N'" & Me.txtZone.Text & "',N'" & Me.txtCodingCode.Text & "')"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            RefreshText()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()

    End Sub

    Private Sub FillGrid()

        If MajmooeID = String.Empty Then
            Exit Sub
        End If

        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()

        Try

            Cmd.CommandText = "Select ID as 'کد شناسائی',Zone as 'منطقه/محله',CodingCode as 'کد شماره گذاری' from Zone where MajmooeID='" & MajmooeID & "'"

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
            Me.DbgView.DataSource = dvw


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا در خواندن اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.DbgView.Refresh()


    End Sub



    Private Sub FillTextBox(ByVal GID As String)

        If GID = "" Then
            RefreshText()
            Exit Sub
        End If

        Dim cmd As New SqlClient.SqlCommand("Select MajmooeID,Zone,CodingCode from Zone where ID='" & GID & "'", SqlCon.SqlCon)

        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            While sdr.Read

                Me.cboMajmooe.Text = GetMajmooe(sdr(0).ToString)
                Me.txtZone.Text = sdr(1).ToString
                Me.txtCodingCode.Text = sdr(2).ToString

            End While
        Catch ex As Exception
            RefreshText()
        Finally

            SqlCon.SqlCon.Close()
        End Try
    End Sub


    Private Sub RefreshText()
        Me.cboMajmooe.Text = String.Empty
        'Me.txtCodingCode.Text = String.Empty
        Me.txtZone.Text = String.Empty
    End Sub


    Private Sub frmRegZone_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
        FillCboMajmooe()
    End Sub

    Private Sub DbgView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbgView.CellClick
        Try
            FillTextBox(Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString)
            ZoneID = Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DbgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DbgView.KeyDown, DbgView.KeyUp
        Try
            FillTextBox(Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString)
            ZoneID = Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Cmd.CommandText = "delete Zone where ID='" & ZoneID & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            RefreshText()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Cmd.CommandText = "Update Zone set MajmooeID='" & MajmooeID & "',Zone=N'" & Me.txtZone.Text & "',CodingCode=N'" & Me.txtCodingCode.Text & "' where ID='" & ZoneID & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            RefreshText()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub FillCboMajmooe()
        Me.cboMajmooe.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Majmooe from Majmooe", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboMajmooe.Items.Add(sdr2(0).ToString)
        End While
        sdr2.Close()
        SqlCon.SqlCon.Close()

    End Sub



    Private Sub cboMajmooe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajmooe.SelectedIndexChanged
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Majmooe where majmooe =N'" & Me.cboMajmooe.Text & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            MajmooeID = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
        FillGrid()
        Me.txtCodingCode.Text = String.Empty
        Me.txtZone.Text = String.Empty
    End Sub

    Private Function GetMajmooe(ByVal ID As String)
        Dim M As String = String.Empty

        Dim cmd0 As New SqlClient.SqlCommand("SELECT Majmooe from Majmooe where ID ='" & ID & "'", SqlCon0.SqlCon)
        SqlCon0.SqlCon.Open()
        Dim sdr0 As SqlClient.SqlDataReader = cmd0.ExecuteReader
        While sdr0.Read
            M = sdr0(0).ToString
        End While
        SqlCon0.SqlCon.Close()
        sdr0.Close()
        Return M

    End Function


End Class