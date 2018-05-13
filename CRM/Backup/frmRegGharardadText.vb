Public Class frmRegGharardadText
    Private SqlCon, SQLCon2 As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private TitleID As String
    Private MadehID As String
    Private MadehNoID As String
    Private BandID As String
    Private GharardadID As String
    Public GharardadNo As String


    Private Sub frmRegGharardadText_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'GharardadNo = "1"
        FillGrid()
        FillGharardadText()
        FillCboMadeh()
        FillCboMadehNo()
        FillCboTitle()
    End Sub


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        RefreshText()
        FillGharardadText()
        GetRowCount()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click

        Cmd.CommandText = "insert into GharardadText (GharardadNo,Row,BandRow,TitleID,MadehID,MadehNoID,BandID,MadehRow) values (N'" & GharardadNo & "','" & Me.NumericRow.Value & "','" & Me.NumericBandRow.Value & "','" & TitleID & "','" & MadehID & "','" & MadehNoID & "','" & BandID & "','" & Me.NuMadehRow.Value & "')"
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
        FillGharardadText()
        GetRowCount()

    End Sub


    Private Sub FillGrid()

        If GharardadNo = String.Empty Then
            Exit Sub
        End If

        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()

        Try

            Cmd.CommandText = "Select ID as 'کد شناسائی',Title as 'موضوع قرارداد',MadehNo + ' : ' + Madeh as 'ماده',BandRow as 'شماره بند', BandText as 'متن بند' from Gharardad_V where GharardadNo=N'" & GharardadNo & "'"

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

            '-------------------------
            Sdr.Close()
            Cmd.CommandText = "Select * from Gharardad_V where GharardadNo=N'" & GharardadNo & "' Order By Row"
            Dim DataAdapter0 As New SqlClient.SqlDataAdapter(Cmd.CommandText, SqlCon.SqlCon)
            Dim DataSet0 As New DataSet
            DataAdapter0.Fill(DataSet0)
            If System.IO.Directory.Exists("c:\XML") = False Then
                System.IO.Directory.CreateDirectory("c:\XML")
            End If
            DataSet0.WriteXml("c:\XML\GharardadText.xml")

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

        Dim cmdt As New SqlClient.SqlCommand("Select Row,BandRow,Title,Madeh,MadehNo,BandText,TitleID,MadehID,MadehNoID,BandID,MadehRow From Gharardad_V where ID='" & GID & "'", SQLCon2.SqlCon)

        SQLCon2.SqlCon.Open()
        Dim sdrt As SqlClient.SqlDataReader = cmdt.ExecuteReader
        Try
            While sdrt.Read

                Me.NumericRow.Value = Integer.Parse(sdrt(0).ToString)
                Me.NumericBandRow.Value = Integer.Parse(sdrt(1).ToString)
                Me.cboTitle.Text = sdrt(2).ToString
                Me.cboMadeh.Text = sdrt(3).ToString
                Me.cboMadehNo.Text = sdrt(4).ToString
                Me.cboBand.Text = sdrt(5).ToString
                TitleID = sdrt(6).ToString
                MadehID = sdrt(7).ToString
                MadehNoID = sdrt(8).ToString
                BandID = sdrt(9).ToString
                Me.NuMadehRow.Value = Integer.Parse(sdrt(10))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SQLCon2.SqlCon.Close()
        End Try
    End Sub


    Private Sub RefreshText()
        ' Me.cboBand.Text = String.Empty
        ' Me.cboMadeh.Text = String.Empty
        ' Me.cboTitle.Text = String.Empty
        Me.NumericBandRow.Value = 0
        Me.NumericRow.Value = 0
    End Sub


    Private Sub DbgView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DbgView.CellClick
        Try
            FillTextBox(Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString)
            GharardadID = Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString

        Catch ex As Exception

        End Try
    End Sub



    Private Sub DbgView_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DbgView.KeyDown, DbgView.KeyUp
        Try
            FillTextBox(Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString)
            GharardadID = Me.DbgView.CurrentRow.Cells.Item(0).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Cmd.CommandText = "delete GharardadText where ID='" & GharardadID & "'"
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
        RefreshText()
        FillGharardadText()
        FillGrid()

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Cmd.CommandText = "Update GharardadText set Row='" & Me.NumericRow.Value & "',BandRow ='" & Me.NumericBandRow.Value & "',TitleID='" & TitleID & "',MadehID='" & MadehID & "',MadehNoID='" & MadehNoID & "',BandID='" & BandID & "',MadehRow='" & Me.NuMadehRow.Value & "' where ID='" & GharardadID & "'"
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
        FillGharardadText()
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
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Madeh from Madeh Order By Row", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr3 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr3.Read
            Me.cboMadeh.Items.Add(sdr3(0).ToString)
        End While
        sdr3.Close()
        SqlCon.SqlCon.Close()

    End Sub
    Private Sub FillCboMadehNo()
        Me.cboMadehNo.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT MadehNo from MadehNo Order By Row", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr3 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr3.Read
            Me.cboMadehNo.Items.Add(sdr3(0).ToString)
        End While
        sdr3.Close()
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub FillCboBand()
        If TitleID = "" Or MadehID = "" Then
            Exit Sub
        Else
            Me.cboBand.Items.Clear()
            Dim cmd2 As New SqlClient.SqlCommand("SELECT BandText from Band where TitleID='" & TitleID & "' And MadehID='" & MadehID & "'  Order By BandNo", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Dim sdr3 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr3.Read
                Me.cboBand.Items.Add(sdr3(0).ToString)
            End While
            sdr3.Close()
            SqlCon.SqlCon.Close()
        End If
        Me.cboBand.Text = String.Empty
    End Sub


    Private Sub GetRowCount()
        If TitleID = "" Or MadehID = "" Then
            Exit Sub
        Else
            Cmd.CommandText = "Select Count (*) from GharardadText where GharardadNo=N'" & GharardadNo & "'"
            Cmd.Connection = SqlCon.SqlCon

            SqlCon.SqlCon.Open()
            Try
                Sdr = Cmd.ExecuteReader
                If Sdr.Read Then
                    Me.NumericRow.Value = (Integer.Parse(Sdr(0).ToString) + 1)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Finally
                SqlCon.SqlCon.Close()
            End Try
            GetBandNo()

        End If
    End Sub

    Private Sub GetBandNo()
        
        Cmd.CommandText = "Select Count (*) from GharardadText where GharardadNo=N'" & GharardadNo & "' AND MadehID='" & MadehID & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Sdr = Cmd.ExecuteReader
            If Sdr.Read Then
                Me.NumericBandRow.Value = (Integer.Parse(Sdr(0).ToString) + 1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

    End Sub

    Private Sub cboTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTitle.SelectedIndexChanged
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Title where Title =N'" & Me.cboTitle.Text & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            TitleID = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
        GetRowCount()
        FillCboBand()
    End Sub

    Private Sub cboMadeh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMadeh.SelectedIndexChanged
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Madeh where Madeh=N'" & Me.cboMadeh.Text & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            MadehID = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
        GetRowCount()
        FillCboBand()
    End Sub

    Private Sub cboBand_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBand.SelectedIndexChanged
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Band where Bandtext =N'" & Me.cboBand.Text & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            BandID = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
        GetRowCount()
        Me.txtBandView.Text = Me.cboBand.Text
    End Sub



    Private Sub FillGharardadText()
        If System.IO.Directory.Exists("c:\XML") = False Then
            System.IO.Directory.CreateDirectory("c:\XML")
        End If
        Dim TblXML As New DataTable
        TblXML.Columns.Add("Madeh")
        TblXML.Columns.Add("BandText")

        Me.txtGharardadText.Text = String.Empty

        'Dim cmd2 As New SqlClient.SqlCommand("SELECT ID,Madeh from Madeh Order By Row", SQLCon2.SqlCon)
        'Dim cmd2 As New SqlClient.SqlCommand("select * from Madeh_v Order By Row", SQLCon2.SqlCon)
        Dim cmd2 As New SqlClient.SqlCommand("select MadehNo + ' : ' + Madeh as Made,MadehID,MadehRow from Gharardad_v Where GharardadNo=N'" & GharardadNo & "' group By MadehNo,Madeh,MadehID,MadehRow Order By MadehRow", SQLCon2.SqlCon)
        SQLCon2.SqlCon.Open()
        Dim sdr3 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        Dim MadehIDArray(sdr3.RecordsAffected) As String

        TblXML.TableName = "GharardadText"
        TblXML.Columns.Add("MText")
        TblXML.Columns.Add("BText")


        If GharardadNo = String.Empty Then
            Exit Sub
        End If


        While sdr3.Read
            Dim RowXML As DataRow = TblXML.NewRow
            Me.txtGharardadText.Text += sdr3(0).ToString & vbCrLf
            RowXML(0) = sdr3(0).ToString
            ''-----------------------------------

            Cmd.Connection = SqlCon.SqlCon

            Try

                Cmd.CommandText = "Select ID,Title,Madeh,BandRow,BandText from Gharardad_V where GharardadNo=N'" & GharardadNo & "' AND MadehID='" & sdr3(1).ToString & "' Order by BandRow"
                SqlCon.SqlCon.Open()
                Sdr = Cmd.ExecuteReader

                Dim SdrCount As String = String.Empty
                Dim MadeCount As String = String.Empty

                While (Sdr.Read)
                    SdrCount += Sdr(4).ToString & "⅛"
                    MadeCount += Sdr(3).ToString & "⅛"
                End While

                Dim Txt() As String = SdrCount.ToString.Split("⅛")
                Dim MD() As String = MadeCount.ToString.Split("⅛")
                Dim J As Integer = Txt.Length
                Dim Txx As String = String.Empty
                If Txt.Length - 1 = 1 Then
                    For I As Integer = 0 To Txt.Length - 2
                        Me.txtGharardadText.Text += Txt(I).ToString & vbCrLf
                        Txx += Txt(I).ToString & vbCrLf

                    Next
                Else
                    For I As Integer = 0 To Txt.Length - 2
                        Me.txtGharardadText.Text += MD(I).ToString & "- " & Txt(I).ToString & vbCrLf
                        Txx += MD(I).ToString & ") " & Txt(I).ToString & vbCrLf
                    Next
                End If
                RowXML(1) = Txx
                TblXML.Rows.Add(RowXML)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "خطا در خواندن اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Finally
                SqlCon.SqlCon.Close()
            End Try

        End While
        sdr3.Close()
        SQLCon2.SqlCon.Close()
        TblXML.WriteXml("c:\XML\GharardadText.Xml")
    End Sub


    Private Sub cboMadehNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMadehNo.SelectedIndexChanged
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from MadehNo where MadehNo =N'" & Me.cboMadehNo.Text & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            MadehNoID = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
        GetRowCount()
        FillCboBand()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim TC As New Counter
        MessageBox.Show(TC.TabsarehCount(GharardadNo))
    End Sub

End Class