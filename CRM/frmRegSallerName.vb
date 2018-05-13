Public Class frmRegSallerName
    Dim SqlCon As New SQL
    Dim Cmd As New SqlClient.SqlCommand
    Dim Sdr As SqlClient.SqlDataReader
    Dim tbl As New DataTable
    Dim dvw As DataView
    Dim b As Boolean
    Dim SallerID As String


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click

        Me.txtSallerName.Text = ""

    End Sub

    Private Sub FillGrid()
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()


        Try


            Cmd.CommandText = "select SallerName.SallerName AS 'نام مشاور', Officename.OfficeName AS 'نام دفتر',SallerName.[ID] AS 'کد شناسائی' from SallerName Inner Join OfficeName On SallerName.OfficeId=OfficeName.ID where sallerName.Officeid='" & GetOfficeID() & "' Order by Officename.OfficeName,SallerName.[ID]"

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
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.DbgOffice.Refresh()


    End Sub

    Private Sub frmRegOffice_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCboOfficeName()

    End Sub


    Private Sub dbgOffice_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgOffice.CellMouseClick
        SallerID = Me.dbgOffice.CurrentRow.Cells.Item(2).Value.ToString
        Me.txtSallerName.Text = Me.dbgOffice.CurrentRow.Cells.Item(0).Value.ToString
        Me.cboOfficeName.Text = Me.dbgOffice.CurrentRow.Cells.Item(1).Value.ToString
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Cmd.CommandText = "Delete SallerName where Id='" & SallerID & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtSallerName.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Dim OfficeID As String = String.Empty
        '---------------------- Get Place ID -----------------------
        Dim cmdOfficeID As New SqlClient.SqlCommand("SELECT ID from OfficeName where OfficeName=N'" & Me.cboOfficeName.Text & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdrOfficeID As SqlClient.SqlDataReader = cmdOfficeID.ExecuteReader

        While sdrOfficeID.Read
            OfficeID = (sdrOfficeID(0).ToString)
        End While
        SqlCon.SqlCon.Close()
        '-----------------------------------------------



        Cmd.CommandText = "insert into SallerName (SallerName,OfficeID) values (N'" & Me.txtSallerName.Text & "','" & OfficeID & "')"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtSallerName.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim OfficeID As String = String.Empty
        '---------------------- Get Place ID -----------------------
        Dim cmdOfficeID As New SqlClient.SqlCommand("SELECT ID from OfficeName where OfficeName=N'" & Me.cboOfficeName.Text & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdrOfficeID As SqlClient.SqlDataReader = cmdOfficeID.ExecuteReader

        While sdrOfficeID.Read
            OfficeID = (sdrOfficeID(0).ToString)
        End While
        SqlCon.SqlCon.Close()
        '-----------------------------------------------

        Cmd.CommandText = "Update SallerName set OfficeID='" & OfficeID & "' ,SallerName=N'" & Me.txtSallerName.Text & "' where Id='" & SallerID & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            Me.txtSallerName.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub FillCboOfficeName()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT OfficeName from OfficeName", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

        While sdr2.Read
            Me.cboOfficeName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub cboOfficeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOfficeName.SelectedIndexChanged
        FillGrid()
    End Sub
    Private Function GetOfficeID()
        Try
            Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from OfficeName where OfficeName=N'" & Me.cboOfficeName.Text & "'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

            If sdr2.Read Then
                Return (sdr2(0).ToString)
            Else
                Return (String.Empty)
            End If
            SqlCon.SqlCon.Close()
        Catch ex As Exception
            Return (String.Empty)
        Finally
            SqlCon.SqlCon.Close()
        End Try

    End Function

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class