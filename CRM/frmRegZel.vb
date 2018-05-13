Public Class frmRegZel


    Dim SqlCon As New SQL
    Dim Cmd As New SqlClient.SqlCommand
    Dim Sdr As SqlClient.SqlDataReader
    Dim tbl As New DataTable
    Dim dvw As DataView
    Dim b As Boolean
    Dim ZelID As String


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        Me.txtZel.Text = ""

    End Sub

    Private Sub FillGrid()
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()


        Try


            Cmd.CommandText = "Select  Zel as 'ضلع',ZelCode as 'کد شماره گذاری',id as 'کد شناسائی'  from Zel order by ZelCode"

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
            Me.dbgZel.DataSource = dvw


        Catch ex As Exception

        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgZel.Refresh()


    End Sub

    Private Sub frmRegZel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillGrid()
    End Sub

    Private Sub dbgZel_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dbgZel.CellClick
        Try
            ZelID = Me.dbgZel.CurrentRow.Cells.Item(2).Value.ToString
            FillTextBox(ZelID)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dbgZel_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgZel.CellMouseClick
        Try
            ZelID = Me.dbgZel.CurrentRow.Cells.Item(2).Value.ToString
            FillTextBox(ZelID)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dbgZel_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dbgZel.KeyUp, dbgZel.KeyDown
        Try
            ZelID = Me.dbgZel.CurrentRow.Cells.Item(2).Value.ToString
            FillTextBox(ZelID)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Cmd.CommandText = "Delete Zel where Id='" & ZelID & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtZel.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Cmd.CommandText = "insert into Zel (Zel,ZelCode) values (N'" & Me.txtZel.Text & "',N'" & Me.txtZelCode.Text & "')"
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

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Cmd.CommandText = "Update Zel set Zel=N'" & Me.txtZel.Text & "',ZelCode=N'" & Me.txtZelCode.Text & "' where Id='" & ZelID & "'"
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


    Private Sub FillTextBox(ByVal GID As String)

        If GID = "" Then
            RefreshText()
            Exit Sub
        End If


        Dim cmd As New SqlClient.SqlCommand("SELECT Zel,ZelCode From Zel where ID='" & GID & "'", SqlCon.SqlCon)

        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            While sdr.Read

                Me.txtZel.Text = sdr(0).ToString
                Me.txtZelCode.Text = sdr(1).ToString

            End While
        Catch ex As Exception
            RefreshText()
        Finally

            SqlCon.SqlCon.Close()
        End Try



    End Sub

    Private Sub RefreshText()
        Me.txtZel.Text = String.Empty
        Me.txtZelCode.Text = String.Empty
    End Sub

End Class