Public Class frmRegGender
    Dim SqlCon As New SQL
    Dim Cmd As New SqlClient.SqlCommand
    Dim Sdr As SqlClient.SqlDataReader
    Dim tbl As New DataTable
    Dim dvw As DataView
    Dim b As Boolean
    Dim Gender As String


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        Me.txtGender.Text = ""

    End Sub

    Private Sub FillGrid()
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()


        Try


            Cmd.CommandText = "Select  Gender as 'نام دفتر فروش',id as 'کد شناسائی'  from Gender"

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
            Me.dbgGender.DataSource = dvw


        Catch ex As Exception

        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgGender.Refresh()


    End Sub

    Private Sub frmRegOffice_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillGrid()
    End Sub

    Private Sub dbgOffice_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dbgGender.CellClick
        Try
            Gender = Me.dbgGender.CurrentRow.Cells.Item(1).Value.ToString
            FillTextBox(Gender)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dbgOffice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgGender.CellMouseClick
        Try
            Gender = Me.dbgGender.CurrentRow.Cells.Item(1).Value.ToString
            FillTextBox(Gender)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dbgOffice_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dbgGender.KeyUp, dbgGender.KeyDown
        Try
            Gender = Me.dbgGender.CurrentRow.Cells.Item(1).Value.ToString
            FillTextBox(Gender)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Cmd.CommandText = "Delete Gender where Id='" & Gender & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtGender.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Cmd.CommandText = "insert into Gender (Gender,Haghighi,Hoghooghi) values (N'" & Me.txtGender.Text & "','" & Me.rbHaghighi.Checked & "','" & Me.rbHoghooghi.Checked & "')"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtGender.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Cmd.CommandText = "Update Gender set Gender=N'" & Me.txtGender.Text & "',Haghighi='" & Me.rbHaghighi.Checked & "',Hoghooghi='" & Me.rbHoghooghi.Checked & "' where Id='" & Gender & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtGender.Text = ""
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


        Dim cmd As New SqlClient.SqlCommand("SELECT Gender,Haghighi,Hoghooghi From Gender where ID='" & GID & "'", SqlCon.SqlCon)

        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            While sdr.Read

                Me.txtGender.Text = sdr(0)
                Me.rbHaghighi.Checked = sdr(1)
                Me.rbHoghooghi.Checked = sdr(2)

            End While
        Catch ex As Exception
            RefreshText()
        Finally

            SqlCon.SqlCon.Close()
        End Try



    End Sub

    Private Sub RefreshText()
        Me.txtGender.Text = ""
    End Sub

End Class