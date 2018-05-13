Public Class frmrptFullReport

    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private Cu As New Currency
    Private SallerNameID As String
    Private OfficeNameID As String
    Private Shart As String


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

    Private Function GetMajmooeNameID(ByVal MajmooeName As String)
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
    Private Function GetZoneID(ByVal Zone As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Zone where Zone=N'" & Zone & "'", SQLCONection.SqlCon)
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
        FillCboOfficeName()
        RefreshDate()
    End Sub

    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If Me.cboMajmooeName.Text = "" And Me.cboVahedtype.Text = "" And Me.cboZone.Text = "" Then
            If Me.cboOfficeName.Text <> "" And Me.cboSallerName.Text <> "" Then
                Shart = "Where OfficeNameID='" & GetOfficeNameID(Me.cboOfficeName.Text) & "' AND SallerNameID='" & GetSallerNameID(Me.cboSallerName.Text) & "' AND GharardadRegDate Between N'" & Me.txtDate1.Text & "' And N'" & Me.txtDate2.Text & "'"
            ElseIf Me.cboOfficeName.Text <> "" And Me.cboSallerName.Text = "" Then
                Shart = "Where OfficeNameID='" & GetOfficeNameID(Me.cboOfficeName.Text) & "' AND GharardadRegDate Between N'" & Me.txtDate1.Text & "' And N'" & Me.txtDate2.Text & "'"
            Else
                Shart = "Where GharardadRegDate Between N'" & Me.txtDate1.Text & "' And N'" & Me.txtDate2.Text & "'"
            End If
        Else
            If Me.cboOfficeName.Text <> "" And Me.cboSallerName.Text <> "" Then
                Shart = "AND OfficeNameID='" & GetOfficeNameID(Me.cboOfficeName.Text) & "' AND SallerNameID='" & GetSallerNameID(Me.cboSallerName.Text) & "' AND GharardadRegDate Between N'" & Me.txtDate1.Text & "' And N'" & Me.txtDate2.Text & "'"
            ElseIf Me.cboOfficeName.Text <> "" And Me.cboSallerName.Text = "" Then
                Shart = "AND OfficeNameID='" & GetOfficeNameID(Me.cboOfficeName.Text) & "' AND GharardadRegDate Between N'" & Me.txtDate1.Text & "' And N'" & Me.txtDate2.Text & "'"
            Else
                Shart = "AND GharardadRegDate Between N'" & Me.txtDate1.Text & "' And N'" & Me.txtDate2.Text & "'"
            End If
        End If



        'Dim RPT As New RptPishGharardad
        'If RPT.Generate("7047F8D1-8E7A-426E-9D0C-FB959E46516E") = True Then
        '    Dim frm As New frmReporter
        '    frm.MdiParent = Mehregan.Parent
        '    frm.Show()
        'End If
        If Me.cboMajmooeName.Text = "" And Me.cboVahedtype.Text = "" And Me.cboZone.Text = "" Then
            Dim RPT As New RptGenFull
            If RPT.GenerateFullReport(Shart, Me.cboKharidType.Text, Me.cboPardakhtType.Text) = True Then
                Dim frm As New frmReporter
                frm.MdiParent = Mehregan.Parent
                frm.CrystalReportViewer1.ReportSource = frm.rptFullReport1
                frm.rptFullReport1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                frm.Show()
            End If
        ElseIf Me.cboMajmooeName.Text <> "" And Me.cboVahedtype.Text = "" And Me.cboZone.Text = "" Then
            Dim RPT As New RptGenFull
            If RPT.GenerateProjectReport(GetMajmooeNameID(Me.cboMajmooeName.Text), Shart, Me.cboKharidType.Text, Me.cboPardakhtType.Text) = True Then
                Dim frm As New frmReporter
                frm.MdiParent = Mehregan.Parent
                frm.CrystalReportViewer1.ReportSource = frm.rptFullReport1
                frm.rptFullReport1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                frm.Show()
            End If
        ElseIf Me.cboMajmooeName.Text <> "" And Me.cboVahedtype.Text <> "" And Me.cboZone.Text = "" Then
            Dim RPT As New RptGenFull
            If RPT.GenerateVahedReport(GetMajmooeNameID(Me.cboMajmooeName.Text), GetVahedTypeID(Me.cboVahedtype.Text), Shart, Me.cboKharidType.Text, Me.cboPardakhtType.Text) = True Then
                Dim frm As New frmReporter
                frm.MdiParent = Mehregan.Parent
                frm.CrystalReportViewer1.ReportSource = frm.rptFullReport1
                frm.rptFullReport1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                frm.Show()
            End If
        ElseIf Me.cboMajmooeName.Text <> "" And Me.cboVahedtype.Text <> "" And Me.cboZone.Text <> "" Then
            Dim RPT As New RptGenFull
            If RPT.GenerateFaseReport(GetMajmooeNameID(Me.cboMajmooeName.Text), GetVahedTypeID(Me.cboVahedtype.Text), GetZoneID(Me.cboZone.Text), Shart, Me.cboKharidType.Text, Me.cboPardakhtType.Text) = True Then
                Dim frm As New frmReporter
                frm.MdiParent = Mehregan.Parent
                frm.CrystalReportViewer1.ReportSource = frm.rptFullReport1
                frm.rptFullReport1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                frm.Show()
            End If
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
        Dim cmd2 As New SqlClient.SqlCommand("SELECT SallerName from SallerName where OfficeID='" & OfficeID & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

        While sdr2.Read
            Me.cboSallerName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub cboOfficeName_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOfficeName.SelectedIndexChanged
        Try
            OfficeNameID = GetOfficeNameID(Me.cboOfficeName.Text)
        Catch ex As Exception
            OfficeNameID = String.Empty
        End Try

        FillCboSaller()
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

    Private Sub RefreshDate()

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

    Private Sub btnSales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSales.Click
        If Me.cboMajmooeName.Text = "" And Me.cboVahedtype.Text = "" And Me.cboZone.Text = "" Then
            If Me.cboOfficeName.Text <> "" And Me.cboSallerName.Text <> "" Then
                Shart = "Where OfficeNameID='" & GetOfficeNameID(Me.cboOfficeName.Text) & "' AND SallerNameID='" & GetSallerNameID(Me.cboSallerName.Text) & "' AND GharardadRegDate Between N'" & Me.txtDate1.Text & "' And N'" & Me.txtDate2.Text & "'"
            ElseIf Me.cboOfficeName.Text <> "" And Me.cboSallerName.Text = "" Then
                Shart = "Where OfficeNameID='" & GetOfficeNameID(Me.cboOfficeName.Text) & "' AND GharardadRegDate Between N'" & Me.txtDate1.Text & "' And N'" & Me.txtDate2.Text & "'"
            Else
                Shart = "Where GharardadRegDate Between N'" & Me.txtDate1.Text & "' And N'" & Me.txtDate2.Text & "'"
            End If
        Else
            If Me.cboOfficeName.Text <> "" And Me.cboSallerName.Text <> "" Then
                Shart = "AND OfficeNameID='" & GetOfficeNameID(Me.cboOfficeName.Text) & "' AND SallerNameID='" & GetSallerNameID(Me.cboSallerName.Text) & "' AND GharardadRegDate Between N'" & Me.txtDate1.Text & "' And N'" & Me.txtDate2.Text & "'"
            ElseIf Me.cboOfficeName.Text <> "" And Me.cboSallerName.Text = "" Then
                Shart = "AND OfficeNameID='" & GetOfficeNameID(Me.cboOfficeName.Text) & "' AND GharardadRegDate Between N'" & Me.txtDate1.Text & "' And N'" & Me.txtDate2.Text & "'"
            Else
                Shart = "AND GharardadRegDate Between N'" & Me.txtDate1.Text & "' And N'" & Me.txtDate2.Text & "'"
            End If
        End If

        If Shart = "" Then
            If Me.cboKharidType.Text <> "" Then
                Shart += "Where G.CashType=N'" & Me.cboKharidType.Text & "'"
            End If
            If Me.cboPardakhtType.Text <> "" Then
                Shart += "Where G.Noeaghsat=N'" & Me.cboPardakhtType.Text & "'"
            End If
        Else
            If Me.cboKharidType.Text <> "" Then
                Shart += "And G.CashType=N'" & Me.cboKharidType.Text & "'"
            End If
            If Me.cboPardakhtType.Text <> "" Then
                Shart += "And G.Noeaghsat=N'" & Me.cboPardakhtType.Text & "'"
            End If
        End If


        'Dim RPT As New RptPishGharardad
        'If RPT.Generate("7047F8D1-8E7A-426E-9D0C-FB959E46516E") = True Then
        '    Dim frm As New frmReporter
        '    frm.MdiParent = Mehregan.Parent
        '    frm.Show()
        'End If
        If Me.cboMajmooeName.Text = "" And Me.cboVahedtype.Text = "" And Me.cboZone.Text = "" Then
            Dim RPT As New RptGenFull
            If RPT.GenerateFullReport(Shart, Me.cboKharidType.Text, Me.cboPardakhtType.Text) = True Then
                Dim frm As New frmReporter
                frm.MdiParent = Mehregan.Parent
                frm.CrystalReportViewer1.ReportSource = frm.RptGenAllSalesRpt1
                frm.RptGenAllSalesRpt1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                frm.Show()
            End If
        ElseIf Me.cboMajmooeName.Text <> "" And Me.cboVahedtype.Text = "" And Me.cboZone.Text = "" Then
            Dim RPT As New RptGenFull
            If RPT.GenerateProjectReport(GetMajmooeNameID(Me.cboMajmooeName.Text), Shart, Me.cboKharidType.Text, Me.cboPardakhtType.Text) = True Then
                Dim frm As New frmReporter
                frm.MdiParent = Mehregan.Parent
                frm.CrystalReportViewer1.ReportSource = frm.RptGenAllSalesRpt1
                frm.RptGenAllSalesRpt1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                frm.Show()
            End If
        ElseIf Me.cboMajmooeName.Text <> "" And Me.cboVahedtype.Text <> "" And Me.cboZone.Text = "" Then
            Dim RPT As New RptGenFull
            If RPT.GenerateVahedReport(GetMajmooeNameID(Me.cboMajmooeName.Text), GetVahedTypeID(Me.cboVahedtype.Text), Shart, Me.cboKharidType.Text, Me.cboPardakhtType.Text) = True Then
                Dim frm As New frmReporter
                frm.MdiParent = Mehregan.Parent
                frm.CrystalReportViewer1.ReportSource = frm.RptGenAllSalesRpt1
                frm.RptGenAllSalesRpt1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                frm.Show()
            End If
        ElseIf Me.cboMajmooeName.Text <> "" And Me.cboVahedtype.Text <> "" And Me.cboZone.Text <> "" Then
            Dim RPT As New RptGenFull
            If RPT.GenerateFaseReport(GetMajmooeNameID(Me.cboMajmooeName.Text), GetVahedTypeID(Me.cboVahedtype.Text), GetZoneID(Me.cboZone.Text), Shart, Me.cboKharidType.Text, Me.cboPardakhtType.Text) = True Then
                Dim frm As New frmReporter
                frm.MdiParent = Mehregan.Parent
                frm.CrystalReportViewer1.ReportSource = frm.RptGenAllSalesRpt1
                frm.RptGenAllSalesRpt1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
                frm.Show()
            End If
        End If
    End Sub
End Class