﻿Public Class frmRegMadeh

    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private MadehID As String

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        RefreshText()
        GetRowCount()
        Me.txtMadeh.Focus()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click

        Cmd.CommandText = "insert into Madeh (Madeh,Row) values (N'" & Me.txtMadeh.Text & "','" & Me.NumericRow.Value & "')"
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
      
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()

        Try

            Cmd.CommandText = "Select ID as 'کد شناسائی',Madeh as 'عنوان قراداد' from Madeh Order By Row "

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

        GetRowCount()
    End Sub

    Private Sub GetRowCount()
        Cmd.CommandText = "Select Count (*) from Madeh"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Sdr = Cmd.ExecuteReader
            If Sdr.Read Then
                Me.NumericRow.Value = Integer.Parse(Sdr(0).ToString) + 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
    End Sub

    Private Sub FillTextBox(ByVal GID As String)

        If GID = "" Then
            RefreshText()
            Exit Sub
        End If
        MadehID = GID

        Dim cmd As New SqlClient.SqlCommand("Select Madeh,Row from Madeh where ID='" & GID & "'", SqlCon.SqlCon)

        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            While sdr.Read


                Me.txtMadeh.Text = sdr(0).ToString
                Me.NumericRow.Value = sdr(1)
            End While
        Catch ex As Exception
            RefreshText()
        Finally

            SqlCon.SqlCon.Close()
        End Try

    End Sub


    Private Sub RefreshText()
        Me.txtMadeh.Text = String.Empty
        Me.NumericRow.Value = 0
    End Sub


    Private Sub frmRegMadeh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
    End Sub

    Private Sub DbgView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbgView.CellClick
        Try
            FillTextBox(Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DbgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DbgView.KeyDown, DbgView.KeyUp
        Try
            FillTextBox(Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Cmd.CommandText = "delete Madeh where ID='" & MadehID & "'"
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
        Cmd.CommandText = "Update Madeh set Madeh=N'" & Me.txtMadeh.Text & "',Row='" & Me.NumericRow.Value & "' where ID='" & MadehID & "'"
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


End Class