﻿Public Class frmRegMajmooe

    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private ID As String

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        RefreshText()
        Me.txtMajmooeName.Focus()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click

        Cmd.CommandText = "insert into Majmooe (Majmooe,Address,Details,CodingCodeEN,CodingCodeFA) values (N'" & Me.txtMajmooeName.Text & "',N'" & Me.TxtAddress.Text & "',N'" & Me.txtDetails.Text & "',N'" & Me.txtCodingCodeEN.Text & "',N'" & Me.txtCodingCodeFA.Text & "')"
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

            Cmd.CommandText = "Select ID as 'کد شناسائی',Majmooe as'نام مجموعه' from Majmooe "

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
        ID = GID

        Dim cmd As New SqlClient.SqlCommand("Select Majmooe,Address,Details,CodingCodeEN,CodingCodeFA from Majmooe where ID='" & GID & "'", SqlCon.SqlCon)

        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            While sdr.Read
                Me.txtMajmooeName.Text = sdr(0).ToString
                Me.TxtAddress.Text = sdr(1).ToString
                Me.txtDetails.Text = sdr(2).ToString
                Me.txtCodingCodeEN.Text = sdr(3).ToString
                Me.txtCodingCodeFA.Text = sdr(4).ToString
            End While
        Catch ex As Exception
            RefreshText()
        Finally

            SqlCon.SqlCon.Close()
        End Try

    End Sub


    Private Sub RefreshText()
        Me.txtMajmooeName.Text = String.Empty
        Me.TxtAddress.Text = String.Empty
        Me.txtDetails.Text = String.Empty
        Me.txtCodingCodeEN.Text = String.Empty
        Me.txtCodingCodeFA.Text = String.Empty
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
        Cmd.CommandText = "delete Majmooe where ID='" & ID & "'"
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
        Cmd.CommandText = "Update Majmooe set Majmooe=N'" & Me.txtMajmooeName.Text & "',Address=N'" & Me.TxtAddress.Text & "',Details=N'" & Me.txtDetails.Text & "',CodingCodeEN=N'" & Me.txtCodingCodeEN.Text & "' ,CodingCodeFA=N'" & Me.txtCodingCodeFA.Text & "' where ID='" & ID & "'"
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