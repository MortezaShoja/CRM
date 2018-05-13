Public Class frmSalesReport

    Private SqlCon, SqlCon2 As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl, tbl1 As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private SallerNameID As String
    Private OfficeNameID As String


    Private Sub frmSalesReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDate1.Text = GetFirstDate()
        Me.txtDate2.Text = GetLastDate()
        FillCboOfficeName()
        FillGridALL()
    End Sub

    Private Function GetFirstDate()
        Dim Value As String = ""
        Me.cboOfficeName.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("select top(1) Gharardadregdate from gharardadno order by Gharardadregdate asc", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Value = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
        Return Value
    End Function

    Private Function GetLastDate()
        Dim Value As String = ""
        Me.cboOfficeName.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("select top(1) Gharardadregdate from gharardadno order by Gharardadregdate desc", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Value = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
        Return Value
    End Function

    Private Sub FillCboOfficeName()
        Me.cboOfficeName.Items.Clear()
        Me.cboOfficeName.Items.Add("")
        Dim cmd2 As New SqlClient.SqlCommand("SELECT OfficeName from OfficeName", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboOfficeName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub cboOfficeName_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOfficeName.SelectedIndexChanged
        Try
            OfficeNameID = GetOfficeNameID(Me.cboOfficeName.Text)
        Catch ex As Exception
            OfficeNameID = String.Empty
        End Try

        FillGridALL()
    End Sub

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


    Private Sub FillGridALL()
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()

        Try

            If Me.cboOfficeName.Text = "" Then
                Cmd.CommandText = "select Row_Number() Over(Order by Count(S.SallerName) desc) as 'ردیف',O.OfficeName as 'نام واحد فروش',S.SallerName as 'نام مشاور',Count(S.SallerName) as 'تعداد فروش' from gharardadno G Inner Join SallerName S on S.ID=G.SallerNameID Inner join OfficeName O On O.ID=G.OfficeNameID where G.GharardadRegDate Between N'" & Me.txtDate1.Text & "' and N'" & Me.txtDate2.Text & "' Group by S.SallerName, o.OfficeName"
            Else
                Cmd.CommandText = "select Row_Number() Over(Order by Count(S.SallerName) desc) as 'ردیف',O.OfficeName as 'نام واحد فروش',S.SallerName as 'نام مشاور',Count(S.SallerName) as 'تعداد فروش' from gharardadno G Inner Join SallerName S on S.ID=G.SallerNameID Inner join OfficeName O On O.ID=G.OfficeNameID Where G.OfficeNameID='" & GetOfficeNameID(Me.cboOfficeName.Text) & "' And G.GharardadRegDate Between N'" & Me.txtDate1.Text & "' and N'" & Me.txtDate2.Text & "' Group by S.SallerName, o.OfficeName"
            End If

            SqlCon.SqlCon.Open()

            Sdr = Cmd.ExecuteReader

            Dim fc As Integer = 0
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
            tbl.TableName = "SalesReport"
            tbl.WriteXml("C:\Reports\SalesReport.XML")
            Me.dbgSales.DataSource = dvw

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToCharArray, "خطا در بارگذاری اطلاعات دیتا گیرید", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgSales.Refresh()

        '----------------------------------------------- Date Report ----------------------------
        tbl1 = New DataTable
        tbl1.Clear()
        tbl1.TableName = "DateReport"
        tbl1.Clear()
        tbl1.Columns.Add("از تاریخ")
        tbl1.Columns.Add("تا تاریخ")
        Dim row2 As DataRow = tbl1.NewRow
        row2(0) = Me.txtDate1.Text
        row2(1) = Me.txtDate2.Text
        tbl1.Rows.Add(row2)
        tbl1.WriteXml("C:\Reports\RptSalesReportDate.XML")




    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FillGridALL()
    End Sub

    Private Sub txtDate1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate1.GotFocus
        Try
            Dim DM As New DateMode
            Me.txtDate1.Text = DM.DECodeDate(Me.txtDate1.Text)
        Catch ex As Exception
            txtDate1.Focus()
        End Try
    End Sub

    Private Sub txtDate1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate1.LostFocus
        Try
            Dim DM As New DateMode
            Me.txtDate1.Text = DM.CodeDate(Me.txtDate1.Text)
        Catch ex As Exception
            txtDate1.Focus()
        End Try
    End Sub

    Private Sub txtDate2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate2.GotFocus
        Try
            Dim DM As New DateMode
            Me.txtDate2.Text = DM.DECodeDate(Me.txtDate2.Text)
        Catch ex As Exception
            txtDate2.Focus()
        End Try
    End Sub

    Private Sub txtDate2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate2.LostFocus
        Try
            Dim DM As New DateMode
            Me.txtDate2.Text = DM.CodeDate(Me.txtDate2.Text)
        Catch ex As Exception
            txtDate2.Focus()
        End Try
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

 
        '---------------------------------------------------
        Dim frm As New frmReporter
        frm.CrystalReportViewer1.ReportSource = frm.rptSales1
        frm.MdiParent = Mehregan.Parent
        'frm.rptSales1.PrintToPrinter(1, True, 0, 0)
        frm.Show()
    End Sub
End Class