Public Class frmRegForooshande
    Dim SqlCon As New SQL
    Dim Cmd As New SqlClient.SqlCommand
    Dim Sdr As SqlClient.SqlDataReader
    Dim tbl As New DataTable
    Dim dvw As DataView
    Dim b As Boolean
    Dim ForooshandeID As String


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        RefreshText()

    End Sub

    Private Sub FillGrid()

        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()

        Try
            Cmd.CommandText = "Select  Forooshande as 'نام فروشنده',id as 'کد شناسائی'  from Forooshande"

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

        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgOffice.Refresh()


    End Sub

    Private Sub frmRegOffice_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillGrid()
    End Sub

    Private Sub dbgOffice_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dbgOffice.CellClick
        Try
            ForooshandeID = Me.dbgOffice.CurrentRow.Cells.Item(1).Value.ToString
            FillTextBox(ForooshandeID)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dbgOffice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgOffice.CellMouseClick
        Try
            ForooshandeID = Me.dbgOffice.CurrentRow.Cells.Item(1).Value.ToString
            FillTextBox(ForooshandeID)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dbgOffice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dbgOffice.KeyUp, dbgOffice.KeyDown
        Try
            ForooshandeID = Me.dbgOffice.CurrentRow.Cells.Item(1).Value.ToString
            FillTextBox(ForooshandeID)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Cmd.CommandText = "Delete Forooshande where Id='" & ForooshandeID & "'"
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

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Cmd.CommandText = "insert into Forooshande (Forooshande,Address) values (N'" & Me.txtForooshandeName.Text & "',N'" & Me.txtAddress.Text & "')"
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
        Cmd.CommandText = "Update Forooshande set Forooshande=N'" & Me.txtForooshandeName.Text & "', Address=N'" & Me.txtAddress.Text & "' where Id='" & ForooshandeID & "'"
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


        Dim cmd As New SqlClient.SqlCommand("SELECT Forooshande,Address From Forooshande where ID='" & GID & "'", SqlCon.SqlCon)

        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            While sdr.Read

                Me.txtForooshandeName.Text = sdr(0).ToString
                Me.txtAddress.Text = sdr(1).ToString

            End While
        Catch ex As Exception
            RefreshText()
        Finally

            SqlCon.SqlCon.Close()
        End Try



    End Sub

    Private Sub RefreshText()
        Me.txtForooshandeName.Text = String.Empty
        Me.txtAddress.Text = String.Empty
    End Sub

End Class