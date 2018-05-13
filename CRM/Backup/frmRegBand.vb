Public Class frmRegBand



    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private TitleID As String
    Private MadehID As String
    Private BandID As String

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        RefreshText()
        GetRowCount()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click

        Cmd.CommandText = "insert into Band (TitleID,MadehID,BandNo,BandText,TabsarehCount) values ('" & TitleID & "','" & MadehID & "','" & Me.NumericBand.Value & "',N'" & Me.txtBandText.Text & "','" & Me.NumericTabsare.Value & "')"
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
        GetRowCount()

    End Sub

    Private Sub FillGrid()

        If TitleID = String.Empty Then
            Exit Sub
        End If

        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()

        Try

            Cmd.CommandText = "Select ID as 'کد شناسائی',BandNo as 'شماره بند',BandText as 'متن بند' from Band where TitleID='" & TitleID & "' and MadehID='" & MadehID & "' order by BandNo"

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
        MadehID = GID

        Dim cmd As New SqlClient.SqlCommand("Select TitleID,MadehID,BandNo,BandText,TabsarehCount from Band where ID='" & GID & "'", SqlCon.SqlCon)

        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            While sdr.Read

                TitleID = sdr(0).ToString
                MadehID = sdr(1).ToString
                Me.NumericBand.Value = Integer.Parse(sdr(2))
                Me.txtBandText.Text = sdr(3).ToString
                Me.NumericTabsare.Value = Integer.Parse(sdr(4))

            End While
        Catch ex As Exception
            RefreshText()
        Finally

            SqlCon.SqlCon.Close()
        End Try
    End Sub


    Private Sub RefreshText()
        Me.txtBandText.Text = String.Empty
        Me.NumericBand.Value = 0
        Me.NumericTabsare.Value = 0
    End Sub


    Private Sub frmRegMadeh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
        FillCboMadeh()
        FillCboTitle()
    End Sub

    Private Sub DbgView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbgView.CellClick
        Try
            FillTextBox(Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString)
            BandID = Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DbgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DbgView.KeyDown, DbgView.KeyUp
        Try
            FillTextBox(Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString)
            BandID = Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Cmd.CommandText = "delete Band where ID='" & BandID & "'"
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
        Cmd.CommandText = "Update Band set TitleID='" & TitleID & "',MadehID='" & MadehID & "',BandNo='" & Me.NumericBand.Value & "',TabsarehCount='" & Me.NumericTabsare.Value & "',BandText=N'" & Me.txtBandText.Text & "' where ID='" & BandID & "'"
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

    Private Sub FillCboTitle()
        Me.cboTitle.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Title from Title", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboTitle.Items.Add(sdr2(0).ToString)
        End While
        sdr2.Close()
        SqlCon.SqlCon.Close()

    End Sub


    Private Sub FillCboMadeh()
        Me.cboMadeh.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Madeh from Madeh  Order By Row", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr3 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr3.Read
            Me.cboMadeh.Items.Add(sdr3(0).ToString)
        End While
        sdr3.Close()
        SqlCon.SqlCon.Close()

    End Sub

    Private Sub GetRowCount()
        If TitleID = "" Or MadehID = "" Then
            Exit Sub
        Else
            Cmd.CommandText = "Select Count (*) from band where TitleID='" & TitleID & "' And MadehID='" & MadehID & "'"
            Cmd.Connection = SqlCon.SqlCon

            SqlCon.SqlCon.Open()
            Try
                Sdr = Cmd.ExecuteReader
                If Sdr.Read Then
                    Me.NumericBand.Value = Integer.Parse(Sdr(0).ToString) + 1
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Finally
                SqlCon.SqlCon.Close()
            End Try
        End If
    End Sub
    Private Sub cboTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTitle.SelectedIndexChanged
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Title where Title =N'" & Me.cboTitle.Text & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            TitleID = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
        If MadehID <> String.Empty Then
            FillGrid()
        End If
        RefreshText()
        GetRowCount()
    End Sub

    Private Sub cboMadeh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMadeh.SelectedIndexChanged
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Madeh where Madeh=N'" & Me.cboMadeh.Text & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            MadehID = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
        FillGrid()
        RefreshText()
        GetRowCount()
    End Sub

End Class