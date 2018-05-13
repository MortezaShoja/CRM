Public Class frmSelectPlace
    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private Cu As New Currency

    Private Sub FillCboVahedtype()
        Me.cboVahedtype.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT VahedType from VahedType", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboVahedtype.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub
    Private Sub FillCboMajmooe()
        Me.cboMajmooeName.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Majmooe from Majmooe", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboMajmooeName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub
    Private Sub FillCboZone()
        Me.cboZone.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Zone from Zone where MajmooeID='" & getmajmooeid(Me.cboMajmooeName.Text) & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboZone.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub
    Private Sub cboMajmooeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajmooeName.SelectedIndexChanged
        FillCboZone()
    End Sub

    Private Sub cboVahedtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVahedtype.SelectedIndexChanged
        FillCboZone()
    End Sub

    Private Sub cboZone_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboZone.SelectedIndexChanged
        FillGrid()
    End Sub

    Private Sub FillGrid()
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()
        Dim MID As String = GetMajmooeID(Me.cboMajmooeName.Text)
        Dim VtID As String = GetVahedTypeID(Me.cboVahedtype.Text)

        Try

            Cmd.CommandText = "Select Row_Number() Over(Order by VahedNo) as 'ردیف',VahedNo as 'شماره واحد',CodeVahed as 'کد واحد',MetrajZamin as 'متراژ زمین',MetrajBana as 'متراژ بنا',MetrajKol as 'متراژ کل',Tozihat as 'توضیحات',ID as 'کد شناسائی' from VahedName where MajmooeID='" & MID & "' And VahedTypeID='" & VtID & "' AND ZoneID='" & GetZoneID(Me.cboZone.Text, GetMajmooeID(Me.cboMajmooeName.Text)) & "' AND Sold='0' Order by VahedNo"


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
            tbl.TableName = "Ghataat"
            tbl.WriteXml("c:\Reports\Ghataat.xml")
            Me.dbgVahedName.DataSource = dvw


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToCharArray, "خطا در بارگذاری اطلاعات دیتا گیرید", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgVahedName.Refresh()

    End Sub

    Private Sub dbgVahedName_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgVahedName.CellMouseDoubleClick
        Dim frm As New frmRegGharardad
        frm.MdiParent = Mehregan.Parent
        frm.Show()
        frm.OwnerID = Guid.NewGuid.ToString
        frm.VahedNameID = Me.dbgVahedName.CurrentRow.Cells.Item(7).Value.ToString
        frm.txtVahedCode.Text = Me.dbgVahedName.CurrentRow.Cells.Item(1).Value.ToString
        frm.txtGharardadNo.Text = Me.dbgVahedName.CurrentRow.Cells.Item(2).Value.ToString
        frm.MajmooeName = Me.cboMajmooeName.Text
        frm.Zone = Me.cboZone.Text
    End Sub


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

    Private Function GetMajmooeNameCode(ByVal MajmooeName As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT CodingCode from Majmooe where Majmooe=N'" & MajmooeName & "'", SQLCONection.SqlCon)
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
        Dim cmd2 As New SqlClient.SqlCommand("SELECT CodingCode from Zone where Zone=N'" & Zone & "''", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function
    Private Function GetZoneID(ByVal Zone As String, ByVal MajmooeID As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Zone where Zone=N'" & Zone & "' AND MajmooeID='" & MajmooeID & "'", SQLCONection.SqlCon)
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
    Private Function GetVahedTypeCode(ByVal VahedType As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT CodingCode from VahedType where VahedType=N'" & VahedType & "'", SQLCONection.SqlCon)
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

    Private Sub frmSelectPlace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCboVahedtype()
        FillCboMajmooe()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim frm As New frmReporter
        frm.MdiParent = Mehregan.Parent
        frm.CrystalReportViewer1.ReportSource = frm.Ghataat1
        frm.Ghataat1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        'Auto Print
        'frm.rptAghsat1.PrintToPrinter(1, True, 0, 0)
        frm.Show()
    End Sub
End Class