Public Class frmRptAghsat

    Private SqlCon, SqlCon2 As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private CD As New CurrentDate
    Private CU As Currency
    Private DC As DateConvertor
    Private NtoW As NumberToWord

    Private SallerNameID As String
    Private OfficeNameID As String


    Private Sub frmAghsat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CD = New CurrentDate
        DC = New DateConvertor
        DC.Convertor()
        Me.txtFromDate.Text = DC.Hyear & "/" & DC.Hmonth & "/" & "01"
        Me.txtDate.Text = CD.GetDate
        FillCboOfficeName()

        Shart()
        
    End Sub

    Private Sub FillGridCheck(ByVal Shart As String)

        Dim Sort As String = "B.Date"
        Select Case Me.cboSortOption.SelectedIndex
            Case Is = 0
                Sort = "B.Date"
            Case Is = 1
                Sort = "G.LName"
            Case Is = 2
                Sort = "G.GharardadNo"
            Case Is = 3
                Sort = "B.AccountOwner"
            Case Is = 4
                Sort = "B.Price"
            Case Is = 5
                Sort = "B.Jahate"
        End Select

        Dim AscDescc As String = String.Empty
        Select Case Me.cboAcsDesc.SelectedIndex
            Case Is = 0
                AscDescc = "desc"
            Case Is = 1
                AscDescc = "asc"
        End Select
        '-----------------------------------------------------

        CU = New Currency
        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean
        Dim Passed As Boolean
        Select Case Me.cboGozareshType.Text
            Case Is = "پرداخت شده"
                Passed = True
            Case Is = "پرداخت نشده"
                Passed = False
        End Select
        Try
            Cmd.Connection = SqlCon.SqlCon
            tbl.Clear()
            'Cmd.CommandText = "Select Row_Number() Over (Order by " & Sort & ") as 'ردیف',O.OfficeName as 'دفتر فروش',S.SallerName as 'مشاور',B.FormType as 'نوع اقساط',G.Name + ' ' + G.LName as 'نام و نام خانوادگی',G.GharardadNo as 'شماره قرارداد',B.price as 'مبلغ-ریال',B.Jahate as 'پرداخت بابت',B.Serial as 'شماره اوراق', B.CodePeygiri as 'کد پیگیری',B.date as 'تاریخ سر رسید',B.PardakhtDate as 'تاریخ پرداخت',G.HomePhone as 'تلفن منزل',G.WorkPhone as 'تلفن محل کار',G.Mobile as 'تلفن همراه',G.ID as 'کد شناسائی' From Bank B inner join GharardadNo G On G.VahedNoID=B.ID inner join OfficeName O on O.ID=G.OfficeNameID inner join SallerName S On S.ID=G.SallerNameID where B.date Between N'" & Me.txtFromDate.Text & "' And N'" & Me.txtDate.Text & "' And Passed='" & Passed & "' " & Shart & " Order By " & Sort & ",FormType " & AscDescc & ""
            Cmd.CommandText = "Select Row_Number() Over (Order by " & Sort & ") as 'ردیف',O.OfficeName as 'دفتر فروش',S.SallerName as 'مشاور',B.FormType as 'نوع اقساط',G.Name + ' ' + G.LName as 'نام و نام خانوادگی',G.GharardadNo as 'شماره قرارداد',B.price as 'مبلغ-ریال',B.AccountNo as 'حساب مبدإ',B.DestinationAccount as 'حساب مقصد',B.Jahate as 'پرداخت بابت',B.Serial as 'شماره اوراق', B.CodePeygiri as 'کد پیگیری',B.date as 'تاریخ سر رسید',B.PardakhtDate as 'تاریخ پرداخت',G.HomePhone as 'تلفن منزل',G.WorkPhone as 'تلفن محل کار',G.Mobile as 'تلفن همراه',B.Tozihat as 'توضیحات',G.ID as 'کد شناسائی' From Bank B inner join GharardadNo G On G.VahedNoID=B.ID inner join OfficeName O on O.ID=G.OfficeNameID inner join SallerName S On S.ID=G.SallerNameID where B.date Between N'" & Me.txtFromDate.Text & "' And N'" & Me.txtDate.Text & "' And Passed='" & Passed & "' " & Shart & " Order By " & Sort & " " & AscDescc & ""

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


                row(0) = Sdr(0)
                row(1) = Sdr(1)
                row(2) = Sdr(2)
                row(3) = Sdr(3)
                row(4) = Sdr(4)
                row(5) = Sdr(5)
                row(6) = CU.CodeNumberNoRiyal(Sdr(6))
                Me.txtSum.Text += Sdr(6)
                row(7) = Sdr(8)
                row(8) = Sdr(8)
                row(9) = Sdr(9)
                row(10) = Sdr(10)
                row(11) = Sdr(11)
                row(12) = Sdr(12)
                row(13) = Sdr(13)
                row(14) = Sdr(14)
                row(15) = Sdr(15)
                row(16) = Sdr(16)
                row(17) = Sdr(17)
                row(18) = Sdr(18)

                tbl.Rows.Add(row)
            End While
            dvw = New DataView(tbl)
            Me.dbgAghsat.DataSource = dvw
            tbl.TableName = "Aghsat"
            tbl.WriteXml("c:\Reports\Aghsat.xml")
            tbl.WriteXmlSchema("c:\Reports\Aghsat.SChem.xml")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "1خطا در بارگذاری اطلاعات ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgAghsat.Refresh()
        NtoW = New NumberToWord
        Me.txtMoadel.Text = NtoW.Convert(Me.txtSum.Text)

        Dim s As String = Me.txtSum.Text
        Me.txtSum.Text = CU.CodeNumber(s)

        GetSumPrice()
    End Sub

    Private Sub GetSumPrice()
        CU = New Currency
        Dim tbl1 As New DataTable
        Dim dvw1 As DataView
        Dim b1 As Boolean

        Try
            'populating columns
            If Not b1 Then
                tbl1.Columns.Add("جمع مبلغ")
                tbl1.Columns.Add("تاریخ گزارش")
                b1 = True
            End If

            'populating rows
            Dim row1 As DataRow = tbl1.NewRow
            row1(0) = Me.txtSum.Text & "       معادل       " & Me.txtMoadel.Text
            row1(1) = Me.txtDate.Text
            tbl1.Rows.Add(row1)

            dvw1 = New DataView(tbl1)
            tbl1.TableName = "Aghsat_Sum"
            tbl1.WriteXml("c:\Reports\Aghsat_Sum.xml")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "1خطا در بارگذاری اطلاعات ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        SqlCon.SqlCon.Close()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Shart()
    End Sub

    Private Sub Shart()
        Me.txtSum.Text = 0
        Me.txtMoadel.Text = ""

        Dim SH As String = String.Empty

        If Me.cboReportType.Text <> "" Then
            SH = " AND Pardakhte=N'" & Me.cboReportType.Text & "'"
        End If

        If Me.cboNoeAghsat.Text = "نقدی-سفته-واریز به حساب" Then
            SH = " AND (FormType=N'نقدی' OR FormType=N'سفته' OR FormType=N'واریز به حساب')"
        Else
            If Me.cboNoeAghsat.Text <> "" Then
                SH = " AND FormType=N'" & Me.cboNoeAghsat.Text & "'"
            End If
        End If


        If Me.cboOfficeName.Text <> "" Then
            SH += " AND G.OfficeNameID='" & GetOfficeNameID(Me.cboOfficeName.Text) & "'"
        End If

        If Me.cboSallerName.Text <> "" Then
            SH += " AND G.SallerNameID='" & GetSallerNameID(Me.cboSallerName.Text) & "'"
        End If
        FillGridCheck(SH)
    End Sub
    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        If Me.cboGozareshType.Text = "پرداخت نشده" Then
            Dim frm As New frmReporter
            frm.MdiParent = Mehregan.Parent
            frm.CrystalReportViewer1.ReportSource = frm.rptAghsatFalse1
            frm.rptAghsatFalse1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            'Auto Print
            'frm.rptAghsat1.PrintToPrinter(1, True, 0, 0)
            frm.Show()
        Else
            Dim frm As New frmReporter
            frm.MdiParent = Mehregan.Parent
            frm.CrystalReportViewer1.ReportSource = frm.rptAghsatTrue1
            frm.rptAghsatTrue1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
            'Auto Print
            'frm.rptAghsat1.PrintToPrinter(1, True, 0, 0)
            frm.Show()
        End If
    End Sub

    Private Sub FillCboOfficeName()
        Me.cboOfficeName.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT OfficeName from OfficeName", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboOfficeName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub FillCboSaller()
        Me.cboSallerName.Items.Clear()
        Dim OfficeID As String = String.Empty
        '---------------------- Get Office ID -----------------------
        Dim cmdOfficeID As New SqlClient.SqlCommand("SELECT ID from OfficeName where OfficeName=N'" & Me.cboOfficeName.Text & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdrOfficeID As SqlClient.SqlDataReader = cmdOfficeID.ExecuteReader

        While sdrOfficeID.Read
            OfficeID = (sdrOfficeID(0).ToString)
        End While
        SqlCon.SqlCon.Close()
        '-----------------------------------------------

        '-------------- Fill Cbo Box ----------------------
        Dim cmd2 As New SqlClient.SqlCommand("SELECT SallerName from SallerName where OfficeID='" & OfficeID & "'", SqlCon2.SqlCon)
        SqlCon2.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

        While sdr2.Read
            Me.cboSallerName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon2.SqlCon.Close()
    End Sub

    Private Sub cboOfficeName_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOfficeName.SelectedIndexChanged
        Try
            OfficeNameID = GetOfficeNameID(Me.cboOfficeName.Text)
        Catch ex As Exception
            OfficeNameID = String.Empty
        End Try

        FillCboSaller()
        Shart()
    End Sub

#Region "OfficeName"
    Private Function GetOfficeNameID(ByVal OfficeNameName As String)
        If OfficeNameName <> String.Empty Then
            Dim SQLCONection As New SQL
            Dim V As String = String.Empty
            Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from OfficeName where OfficeName=N'" & OfficeNameName & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                V = sdr2(0).ToString
            End While
            SQLCONection.SqlCon.Close()
            Return V
        Else
            Return ""
        End If
    End Function
    Private Function GetOfficeName(ByVal OfficeNameID As String)
        If OfficeNameID <> String.Empty Then
            Dim SQLCONection As New SQL
            Dim V As String = String.Empty
            Dim cmd2 As New SqlClient.SqlCommand("SELECT OfficeName from OfficeName where ID='" & OfficeNameID & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                V = sdr2(0).ToString
            End While
            SQLCONection.SqlCon.Close()
            Return V
        Else
            Return ""
        End If
    End Function
#End Region

#Region "SallerName"
    Private Function GetSallerNameID(ByVal SallerName As String)
        If SallerName <> String.Empty Then
            Dim SQLCONection As New SQL
            Dim V As String = String.Empty
            Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from SallerName where SallerName=N'" & SallerName & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                V = sdr2(0).ToString
            End While
            SQLCONection.SqlCon.Close()
            Return V
        Else
            Return ""
        End If
    End Function
    Private Function GetSallerName(ByVal SallerNameID As String)
        If SallerNameID <> String.Empty Then
            Dim SQLCONection As New SQL
            Dim V As String = String.Empty
            Dim cmd2 As New SqlClient.SqlCommand("SELECT SallerName from SallerName where ID='" & SallerNameID & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                V = sdr2(0).ToString
            End While
            SQLCONection.SqlCon.Close()
            Return V
        Else
            Return ""
        End If
    End Function
#End Region



    Private Sub dbgCheck_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dbgAghsat.CellDoubleClick
        Dim Value(3) As String
        Dim cmd2 As New SqlClient.SqlCommand("Select VahedNoID,VahedCode,GharardadNo from GharardadNo Where GharardadNo=N'" & Me.dbgAghsat.CurrentRow.Cells.Item(5).Value.ToString & "'", SqlCon2.SqlCon)
        SqlCon2.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

        While sdr2.Read
            Value(0) = sdr2(0).ToString
            Value(1) = sdr2(1).ToString
            Value(2) = sdr2(2).ToString
        End While
        SqlCon2.SqlCon.Close()
        '----------------------------------------
        Try
            Dim frm As New frmRegGharardad
            frm.MdiParent = Mehregan.Parent
            frm.Show()
            frm.OwnerID = Guid.NewGuid.ToString
            frm.VahedNameID = Value(0)
            frm.txtVahedCode.Text = Value(1)
            frm.txtGharardadNo.Text = Value(2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboGozareshType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGozareshType.SelectedIndexChanged, cboReportType.SelectedIndexChanged, cboNoeAghsat.SelectedIndexChanged, cboSortOption.SelectedIndexChanged, cboAcsDesc.SelectedIndexChanged
        Shart()
    End Sub
End Class