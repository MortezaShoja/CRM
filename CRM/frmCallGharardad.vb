Public Class frmCallGharardad


    Private GharardadID As String
    Private Where As String = String.Empty
    Private DC As New DateConvertor
    Public FillTextBoxID As String
    Public Dialog As Boolean
    Private CC As Integer


    Private Sub FillGrid()

        Dim SqlCon As New SQL
        Dim Cmd As New SqlClient.SqlCommand
        Dim Sdr As SqlClient.SqlDataReader
        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean

        CC = 0

        '------------
        If Me.cboMajmooeName.Text <> String.Empty Then
            Where += " G.MajmooeNameID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "' AND "
        End If
        '------------
        If Me.txtTozihat.Text <> String.Empty Then
            Where += " G.Discription Like N'%" & Me.txtTozihat.Text & "%' AND "
        End If
        '------------
        If Me.txtHeadGroupName.Text <> String.Empty Then
            Where += " G.HeadGroup Like N'%" & Me.txtHeadGroupName.Text & "%' AND "
        End If
        '------------
        If Me.cboZone.Text <> String.Empty Then
            Where += " V.ZoneID='" & GetZoneID(GetMajmooeID(Me.cboMajmooeName.Text), Me.cboZone.Text) & "' AND "
        End If
        '------------
        If Me.txtName.Text <> String.Empty Then
            Where = " G.Name Like N'%" & Me.txtName.Text & "%' AND "
        End If
        '------------
        If Me.txtLname.Text <> String.Empty Then
            Where += " G.LName Like N'%" & Me.txtLname.Text & "%' AND "
        End If
        '------------
        If Me.txtSerial.Text <> String.Empty Then
            Where += " (B.Serial Like N'%" & Me.txtSerial.Text & "%' Or B.CodePeygiri Like N'%" & Me.txtSerial.Text & "%') AND "
        End If
        '------------
        If Me.txtPhone.Text <> String.Empty Then
            Where += " (G.HomePhone Like N'%" & Me.txtPhone.Text & "%' Or G.WorkPhone Like N'%" & Me.txtPhone.Text & "%' OR G.Mobile Like N'%" & Me.txtPhone.Text & "%') AND "
        End If
        '------------
        If Me.txtDate1.Text <> String.Empty And Me.txtDate2.Text <> String.Empty Then
            Where += " G.GharardadRegDate between '" & Me.txtDate1.Text & "' AND '" & Me.txtDate2.Text & "' AND"
        End If


        If Where <> String.Empty Then
            Where = Mid(Where, 1, Where.Length - 4)
            Where = " Where " + Where
        Else
            Where = "None"
        End If


        Try
            Cmd.Connection = SqlCon.SqlCon
            tbl.Clear()
            Cmd.CommandText = "Select Row_Number() Over(Order by G.MajmooeNameID,Z.Zone,G.VahedCode) as 'ردیف',G.[Name]+' '+G.LName as 'نام و نام خانوادگی',M.Majmooe as 'محل پروژه',Z.Zone as 'فاز فروش',G.VahedCode as 'شماره قطعه',G.Gharardadno as 'شماره قرارداد',O.OfficeName as 'واحد فروش',S.SallerName as 'نام مشاور',G.VahedNoID as 'کد شناسائی' from GharardadNo G Inner Join VahedName V On G.VahedNoID=V.ID Inner Join Zone Z On Z.ID=V.ZoneID Inner join Majmooe M on M.ID=G.MajmooeNameID inner join OfficeName O on O.ID=G.OfficeNameid Inner Join SallerName S On S.ID=G.SallerNameID left Join Bank B On V.ID=B.ID  " & Where & " Group by G.[Name],G.LName,M.Majmooe,Z.Zone,G.VahedCode,G.Gharardadno,O.OfficeName,S.SallerName,G.VahedNoID,G.MajmooeNameID Order By G.MajmooeNameID,Z.Zone,G.VahedCode"
            'Cmd.CommandText = "Select G.[Name]+' '+G.LName as 'نام و نام خانوادگی',M.Majmooe as 'محل پروژه',Z.Zone as 'فاز فروش',G.VahedCode as 'شماره قطعه',G.Gharardadno as 'شماره قرارداد',O.OfficeName as 'واحد فروش',S.SallerName as 'نام مشاور',G.VahedNoID as 'کد شناسائی' from GharardadNo G Inner Join VahedName V On G.VahedNoID=V.ID Inner Join Zone Z On Z.ID=V.ZoneID Inner join Majmooe M on M.ID=G.MajmooeNameID inner join OfficeName O on O.ID=G.OfficeNameid Inner Join SallerName S On S.ID=G.SallerNameID Inner Join Bank B On G.VahedNoID=B.ID  " & Where & " Order By G.MajmooeNameID,Z.Zone,G.VahedCode"
            'Cmd.CommandText = "Select  Name + ' ' + LName as 'نام و نام خانوادگی',VahedNoID as 'کد واحد',VahedCode as 'شماره قطعه',GharardadNo as 'شماره قرارداد',RegDate + ' '+ regDay as 'تاریخ ثبت'  from GharardadNo " & Where & "order by VahedCode"
            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            Dim fc As Integer
            While (Sdr.Read)
                CC += 1
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
            Me.dbgView.DataSource = dvw
        Catch ex As Exception

        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgView.Refresh()



        Where = String.Empty

    End Sub

    Private Sub txtDate1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate1.GotFocus
        Dim DM As New DateMode
        Try
            Me.txtDate1.Text = DM.DECodeDate(Me.txtDate1.Text)
        Catch ex As Exception
            'Me.txtDate1.Focus()
        End Try
    End Sub

    Private Sub txtDate1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate1.LostFocus
        Dim DM As New DateMode
        Try
            Me.txtDate1.Text = DM.CodeDate(Me.txtDate1.Text)
        Catch ex As Exception
            'Me.txtDate1.Focus()
        End Try
    End Sub

    Private Sub txtDate2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate2.GotFocus
        Dim DM As New DateMode
        Try
            Me.txtDate2.Text = DM.DECodeDate(Me.txtDate2.Text)
        Catch ex As Exception
            'Me.txtDate2.Focus()
        End Try
    End Sub

    Private Sub txtDate2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate2.LostFocus
        Dim DM As New DateMode
        Try
            Me.txtDate2.Text = DM.CodeDate(Me.txtDate2.Text)
        Catch ex As Exception
            'Me.txtDate2.Focus()
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        SerachData()
    End Sub

    Private Sub SerachData()
        FillGrid()
        RefreshText()
        RefreshDate()
        MessageBox.Show("تعداد " & CC.ToString & " عدد قرارداد یافته شد", "جستجو", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    End Sub
    Private Sub RefreshText()
        Dim Tc As Control
        For Each Tc In Me.Controls
            If TypeOf Tc Is TextBox AndAlso Tc.Text <> "" Then
                Tc.Text = String.Empty
            End If
        Next
    End Sub

    Private Sub frmCallGharardad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshDate()
        FillGrid()
        FillCboMajmooe()
    End Sub
    Private Sub RefreshDate()
        Dim SqlCon As New SQL
        Dim cmd1 As New SqlClient.SqlCommand("SELECT top 1 GharardadRegDate from GharardadNo order by GharardadRegDate Asc", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr1 As SqlClient.SqlDataReader = cmd1.ExecuteReader
        While sdr1.Read
            Me.txtDate1.Text = sdr1(0).ToString
        End While
        SqlCon.SqlCon.Close()
        '------------------------------------
        Dim cmd2 As New SqlClient.SqlCommand("SELECT top 1 GharardadRegDate from GharardadNo order by GharardadRegDate Desc", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.txtDate2.Text = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub txtDate1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDate1.TextChanged
        Me.txtDate2.Text = Me.txtDate1.Text
    End Sub

    Private Sub dbgView_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgView.CellMouseDoubleClick

        Dim frm As New frmRegGharardad
        frm.MdiParent = Mehregan.Parent
        frm.Show()
        frm.OwnerID = Guid.NewGuid.ToString
        frm.VahedNameID = Me.dbgView.CurrentRow.Cells.Item(8).Value.ToString
        frm.txtVahedCode.Text = Me.dbgView.CurrentRow.Cells.Item(5).Value.ToString
        frm.txtGharardadNo.Text = Me.dbgView.CurrentRow.Cells.Item(6).Value.ToString
        'frm.MajmooeName = Me.cboMajmooeName.Text
        'frm.Zone = Me.cboZone.Text

    End Sub


    Private Sub FillCboMajmooe()

        Me.cboMajmooeName.Items.Clear()
        Me.cboMajmooeName.Items.Add("")
        Dim SqlCon As New SQL
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Majmooe from Majmooe", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboMajmooeName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub cboMajmooeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajmooeName.SelectedIndexChanged
        If Me.cboMajmooeName.Text <> "" Then
            Me.cboZone.Items.Clear()
            Me.cboZone.Items.Add("")
            Dim SqlCon As New SQL
            Dim cmd2 As New SqlClient.SqlCommand("SELECT Zone from Zone where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                Me.cboZone.Items.Add(sdr2(0).ToString)
            End While
            SqlCon.SqlCon.Close()
            Me.cboZone.Text = ""
        Else
            Me.cboZone.Items.Clear()
            Me.cboZone.Text = ""
        End If
    End Sub

    'Private Sub cboVahedtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.cboZone.Items.Clear()
    '    Dim cmd2 As New SqlClient.SqlCommand("SELECT Zone from Zone where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "'", SqlCon.SqlCon)
    '    SqlCon.SqlCon.Open()
    '    Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
    '    While sdr2.Read
    '        Me.cboZone.Items.Add(sdr2(0).ToString)
    '    End While
    '    SqlCon.SqlCon.Close()
    'End Sub

    Private Function GetMajmooeID(ByVal MajmooeName As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Majmooe where Majmooe=N'" & MajmooeName & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function

    Private Function GetMajmooe(ByVal ID As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Majmooe from Majmooe where ID=N'" & ID & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function
    Private Function GetZoneCode(ByVal Zone As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT CodingCode from Zone where Zone=N'" & Zone & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function
    Private Function GetZoneID(ByVal MajmooeID As String, ByVal Zone As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Zone where MajmooeID='" & MajmooeID & "' And Zone=N'" & Zone & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function

    Private Function GetZone(ByVal ID As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Zone from Zone where ID='" & ID & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function

    Private Function GetVahedTypeID(ByVal VahedType As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from VahedType where VahedType=N'" & VahedType & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function
    Private Function GetVahedType(ByVal ID As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT VahedType from VahedType where ID=N'" & ID & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function

    Private Sub txtName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtName.KeyPress, txtLname.KeyPress, txtDate1.KeyPress, txtDate2.KeyPress, txtPhone.KeyPress, txtSerial.KeyPress, txtHeadGroupName.KeyPress, txtTozihat.KeyPress, cboMajmooeName.KeyPress, cboZone.KeyPress
        If e.KeyChar = Chr(13) Then
            SerachData()
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim SqlCon As New SQL
        Dim Cmd As New SqlClient.SqlCommand
        Dim Sdr As SqlClient.SqlDataReader
        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean

        Try
            Cmd.Connection = SqlCon.SqlCon
            tbl.Clear()
            'Cmd.CommandText = "select M.Majmooe,Z.Zone,V.Vahedno,G.Gender,G.Name + ' ' + G.lname,G.gharardadNo,G.Mobile,G.HomePhone,G.WorkPhone from GharardadNo G  full outer join VahedName V on V.ID=G.VahedNoID Inner join Zone Z on V.ZoneID=Z.ID Inner join Majmooe M On V.MajmooeID=M.ID where V.MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "' And V. ZoneID='" & GetZoneID(GetMajmooeID(Me.cboMajmooeName.Text), Me.cboZone.Text) & "' Order by V.VahedNo"
            Cmd.CommandText = "select M.Majmooe,Z.Zone,V.Vahedno,G.Gender,G.Name + ' ' + G.lname,G.gharardadNo,G.Mobile,G.HomePhone,G.WorkPhone from GharardadNo G  inner join VahedName V on V.ID=G.VahedNoID Inner join Zone Z on V.ZoneID=Z.ID Inner join Majmooe M On V.MajmooeID=M.ID where V.MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "' And V. ZoneID='" & GetZoneID(GetMajmooeID(Me.cboMajmooeName.Text), Me.cboZone.Text) & "' Order by V.VahedNo"

            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            Dim fc As Integer
            While (Sdr.Read)

                'populating columns

                If Not b Then
                    tbl.Columns.Add("نام مجموعه")
                    tbl.Columns.Add("فاز فروش")
                    tbl.Columns.Add("شماره واحد")
                    tbl.Columns.Add("نام خریدار")
                    tbl.Columns.Add("شماره قرارداد")
                    tbl.Columns.Add("شماره همراه")
                    tbl.Columns.Add("شماره منزل")
                    tbl.Columns.Add("شماره محل کار")
                    b = True
                End If

                'populating rows
                Dim row As DataRow = tbl.NewRow

                row(0) = Sdr(0).ToString
                row(1) = Sdr(1).ToString
                row(2) = Sdr(2).ToString
                Dim Gender As String = String.Empty
                Select Case Sdr(3).ToString
                    Case Is = 0
                        Gender = "جناب آقای "
                    Case Is = 1
                        Gender = "سرکار خانم "
                End Select
                row(3) = Gender & Sdr(4).ToString
                row(4) = Sdr(5).ToString
                row(5) = Sdr(6).ToString
                row(6) = Sdr(7).ToString
                row(7) = Sdr(8).ToString



                tbl.Rows.Add(row)
            End While
            dvw = New DataView(tbl)
            tbl.TableName = "GharardadLists"
            tbl.WriteXml("c:\Reports\GharardadLists.xml")

            Dim frm As New frmReporter
            frm.MdiParent = Mehregan.Parent
            frm.CrystalReportViewer1.ReportSource = frm.RptGharardadLists1
            frm.RptGharardadLists1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            'Auto Print
            'frm.RptGharardadLists1.PrintToPrinter(1, True, 0, 0)
            frm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, " GharardadLists خطا در بارگذاری اطلاعات ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
    End Sub
End Class