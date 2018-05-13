Public Class frmRegTabaghe

    Dim SqlCon As New SQL
    Dim Cmd As New SqlClient.SqlCommand
    Dim Sdr As SqlClient.SqlDataReader
    Dim tbl As New DataTable
    Dim dvw As DataView
    Dim b As Boolean
    Dim TabagheID As String


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        Me.txtTabaghe.Text = ""

    End Sub

    Private Sub FillGrid()
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()


        Try


            Cmd.CommandText = "Select  Row as 'ردیف',Tabaghe as 'طبقه',TabagheCode as 'کد شماره گذاری',id as 'کد شناسائی'  from Tabaghe Order By TabagheCode"

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
            Me.dbgTabaghe.DataSource = dvw


        Catch ex As Exception

        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgTabaghe.Refresh()


    End Sub

    Private Sub frmRegTabaghe_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillGrid()
    End Sub

    Private Sub dbgTabaghe_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dbgTabaghe.CellClick
        Try
            TabagheID = Me.dbgTabaghe.CurrentRow.Cells.Item(3).Value.ToString
            FillTextBox(TabagheID)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dbgTabaghe_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgTabaghe.CellMouseClick
        Try
            TabagheID = Me.dbgTabaghe.CurrentRow.Cells.Item(3).Value.ToString
            FillTextBox(TabagheID)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dbgTabaghe_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dbgTabaghe.KeyUp, dbgTabaghe.KeyDown
        Try
            TabagheID = Me.dbgTabaghe.CurrentRow.Cells.Item(3).Value.ToString
            FillTextBox(TabagheID)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Cmd.CommandText = "Delete Tabaghe where Id='" & TabagheID & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtTabaghe.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Cmd.CommandText = "insert into Tabaghe (Tabaghe,TabagheCode,Row) values (N'" & Me.txtTabaghe.Text & "',N'" & Me.txtTabagheCode.Text & "','" & Integer.Parse(Me.txtRow.Text) & "')"
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
        Cmd.CommandText = "Update Tabaghe set Tabaghe=N'" & Me.txtTabaghe.Text & "',TabagheCode=N'" & Me.txtTabagheCode.Text & "',Row='" & Integer.Parse(Me.txtRow.Text) & "' where Id='" & TabagheID & "'"
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


        Dim cmd As New SqlClient.SqlCommand("SELECT Tabaghe,TabagheCode,Row From Tabaghe where ID='" & GID & "'", SqlCon.SqlCon)

        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            While sdr.Read

                Me.txtTabaghe.Text = sdr(0).ToString
                Me.txtTabagheCode.Text = sdr(1).ToString
                Me.txtRow.Text = sdr(2).ToString

            End While
        Catch ex As Exception
            RefreshText()
        Finally

            SqlCon.SqlCon.Close()
        End Try



    End Sub

    Private Sub RefreshText()
        Me.txtTabaghe.Text = String.Empty
        Me.txtTabagheCode.Text = String.Empty
    End Sub

End Class