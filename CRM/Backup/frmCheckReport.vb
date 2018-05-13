Public Class frmCheckReport
    Private SqlCon, SqlCon2 As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private CD As New CurrentDate
    Private CU As Currency



    Private Sub frmCheckReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CD = New CurrentDate
        Me.txtFromDate.Text = GetFirstCheckDate()
        Me.txtDate.Text = GetLastCheckDate()
        FillCboMajmooe()
        FillGrid()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmReporter
        frm.MdiParent = Mehregan.Parent
        frm.CrystalReportViewer1.ReportSource = frm.RptChekz1
        frm.RptChekz1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'Auto Print
        'frm.rptAghsat1.PrintToPrinter(1, True, 0, 0)
        frm.Show()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        FillGrid()
    End Sub

    Private Sub FillGrid()
        Dim Sort As String = "B.Date"
        Dim SHART As String = String.Empty
        Select Case Me.ComboBox1.SelectedIndex
            Case Is = 0
                Sort = "B.Date"
            Case Is = 1
                Sort = "G.LName"
            Case Is = 2
                Sort = "G.GharardadNo"
        End Select

        If Me.cboMajmooeName.Text <> "" Then
            SHART = " G.MajmooeNameID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "' And "
        Else
            SHART = String.Empty
        End If

        '------------------------------------------
        Dim Counter As Integer = 0
        CU = New Currency
        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean
        Try
            Cmd.Connection = SqlCon.SqlCon
            tbl.Clear()
            Cmd.CommandText = "Select Row_Number() Over (Order by O.OfficeName) as 'ردیف',B.Serial as 'شماره چک',B.Date as 'تاریخ سررسید',B.OwnerBank as 'نام بانک',B.BankShobe as 'شعبه',B.BankCode as 'کد شعبه',G.Name + ' ' + G.LName as 'نام و نام خانوادگی',G.GharardadNo as 'شماره قرارداد',B.Pardakhte as 'بابت',B.Price From Bank B inner join GharardadNo G On G.VahedNoID=B.ID inner join OfficeName O on O.ID=G.OfficeNameID inner join SallerName S On S.ID=G.SallerNameID where " & SHART & " B.FormType=N'چکی' And B.date Between N'" & Me.txtFromDate.Text & "' And N'" & Me.txtDate.Text & "' Order By " & Sort & ",B.AccountOwner Desc"

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
                row(6) = Sdr(6)
                row(7) = Sdr(7)
                row(8) = Sdr(8)
                row(9) = CU.CodeNumber(Sdr(9))
                Counter += 1
                tbl.Rows.Add(row)
            End While
            dvw = New DataView(tbl)
            Me.dbgCheck.DataSource = dvw
            tbl.TableName = "Aghsat"
            tbl.WriteXml("c:\Reports\CheckS.xml")

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "1خطا در بارگذاری اطلاعات ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgCheck.Refresh()
        MessageBox.Show(Counter)
    End Sub
    Private Function GetFirstCheckDate()
        Dim value As String = 0

        Dim cmd2 As New SqlClient.SqlCommand("select top(1) date from bank where formtype=N'چکی' order by date asc", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        If sdr2.Read Then
            value = sdr2(0).ToString
        End If
        SqlCon.SqlCon.Close()

        Return value
    End Function

    Private Function GetLastCheckDate()
        Dim value As String = 0

        Dim cmd2 As New SqlClient.SqlCommand("select top(1) date from bank where formtype=N'چکی' order by date desc", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        If sdr2.Read Then
            value = sdr2(0).ToString
        End If
        SqlCon.SqlCon.Close()

        Return value
    End Function

    Private Sub FillCboMajmooe()
        Me.cboMajmooeName.Items.Clear()
        Me.cboMajmooeName.Items.Add("")
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Majmooe from Majmooe", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboMajmooeName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Function GetMajmooeID(ByVal MajmooeName As String)
        Dim Value As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Majmooe Where Majmooe=N'" & MajmooeName & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Value = sdr2(0).ToString
        End While
        SqlCon.SqlCon.Close()
        Return Value
    End Function

End Class