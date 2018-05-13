Public Class frmRegOffice
    Dim SqlCon As New SQL
    Dim Cmd As New SqlClient.SqlCommand
    Dim Sdr As SqlClient.SqlDataReader
    Dim tbl As New DataTable
    Dim dvw As DataView
    Dim b As Boolean
    Dim OfficeID As String


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        Me.txtOfficeName.Text = ""

    End Sub

    Private Sub FillGrid()
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()


        Try


            Cmd.CommandText = "Select  OfficeName as 'نام دفتر فروش',id as 'کد شناسائی'  from OfficeName"

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
            Me.DbgOffice.DataSource = dvw


        Catch ex As Exception

        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.DbgOffice.Refresh()


    End Sub

    Private Sub frmRegOffice_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillGrid()
    End Sub

    Private Sub dbgOffice_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dbgOffice.CellClick
        Try
            OfficeID = Me.dbgOffice.CurrentRow.Cells.Item(1).Value.ToString
            FillTextBox(OfficeID)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dbgOffice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgOffice.CellMouseClick
        Try
            OfficeID = Me.dbgOffice.CurrentRow.Cells.Item(1).Value.ToString
            FillTextBox(OfficeID)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dbgOffice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dbgOffice.KeyUp, dbgOffice.KeyDown
        Try
            OfficeID = Me.dbgOffice.CurrentRow.Cells.Item(1).Value.ToString
            FillTextBox(OfficeID)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Cmd.CommandText = "Delete OfficeName where Id='" & OfficeID & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtOfficeName.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Cmd.CommandText = "insert into OfficeName (Officename) values (N'" & Me.txtOfficeName.Text & "')"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtOfficeName.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Cmd.CommandText = "Update OfficeName set Officename=N'" & Me.txtOfficeName.Text & "' where Id='" & OfficeID & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtOfficeName.Text = ""
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


        Dim cmd As New SqlClient.SqlCommand("SELECT OfficeName From OfficeName where ID='" & GID & "'", SqlCon.SqlCon)

        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            While sdr.Read

                Me.txtOfficeName.Text = sdr(0)

            End While
        Catch ex As Exception
            RefreshText()
        Finally

            SqlCon.SqlCon.Close()
        End Try



    End Sub

    Private Sub RefreshText()
        Me.txtOfficeName.Text = ""
    End Sub

    
End Class