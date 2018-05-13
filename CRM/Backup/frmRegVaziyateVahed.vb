Public Class frmRegVaziyateVahed
    Dim SqlCon As New SQL
    Dim Cmd As New SqlClient.SqlCommand
    Dim Sdr As SqlClient.SqlDataReader
    Dim tbl As New DataTable
    Dim dvw As DataView
    Dim b As Boolean
    Dim VaziyatID As String


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        Me.txtVaziyateVaged.Text = ""

    End Sub

    Private Sub FillGrid()
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()


        Try


            Cmd.CommandText = "select Vaziyat as 'وضعیت واحد',ID as 'کد شناسائی' from VaziyateVahed"

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
            Me.dbgOffice.DataSource = dvw


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgOffice.Refresh()


    End Sub

    Private Sub dbgOffice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgOffice.CellMouseClick
        VaziyatID = Me.dbgOffice.CurrentRow.Cells.Item(1).Value.ToString
        Me.txtVaziyateVaged.Text = Me.dbgOffice.CurrentRow.Cells.Item(0).Value.ToString
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Cmd.CommandText = "Delete VaziyateVahed where Id='" & VaziyatID & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtVaziyateVaged.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click

        Cmd.CommandText = "insert into VaziyateVahed (Vaziyat) values (N'" & Me.txtVaziyateVaged.Text & "')"
        Cmd.Connection = SqlCon.SqlCon
        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtVaziyateVaged.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        Cmd.CommandText = "Update VaziyateVahed set Vaziyat=N'" & Me.txtVaziyateVaged.Text & "' where Id='" & VaziyatID & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtVaziyateVaged.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub


    Private Sub cboOfficeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FillGrid()
    End Sub

    Private Sub frmRegVaziyateVahed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
    End Sub
End Class