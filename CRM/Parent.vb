Imports System.Windows.Forms

Public Class Parent
    Private CD As New CurrentDate

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub btnRegTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegTitle.Click
        Dim frm As New frmRegTitle
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegMadeh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegMadeh.Click
        Dim frm As New frmRegMadeh
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegBand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegBand.Click
        Dim frm As New frmRegBand
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnSodoorGharardad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSodoorGharardad.Click
        Dim frm As New frmSelectPlace
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegMajmooe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegMajmooe.Click
        Dim frm As New frmRegMajmooe
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegZel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegZel.Click
        Dim frm As New frmRegZel
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegTabaghe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegTabaghe.Click
        Dim frm As New frmRegTabaghe
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegVahed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegVahed.Click
        Dim frm As New frmRegVahedName
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegNoeVahed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegNoeVahed.Click
        Dim frm As New frmRegVahedType
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegMantaghe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegMantaghe.Click
        Dim frm As New frmRegZone
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegNama_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegNama.Click
        Dim frm As New frmRegView
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegVahedeFroosh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegVahedeFroosh.Click
        Dim frm As New frmRegOffice
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegMoshaver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegMoshaver.Click
        Dim frm As New frmRegSallerName
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegVaziyateVahed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegVaziyateVahed.Click
        Dim frm As New frmRegVaziyateVahed
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnEditGharardad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditGharardad.Click
        Dim frm As New frmCallGharardad
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegMadeno_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegMadeno.Click
        Dim frm As New frmregMadehNo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegGender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegGender.Click
        Dim frm As New frmRegGender
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegForooshande_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegForooshande.Click
        Dim frm As New frmRegForooshande
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub btnRegNoeVekalat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegNoeVekalat.Click
        Dim frm As New frmRegNoeVekalat
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub گزارشکلیToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles گزارشکلیToolStripMenuItem.Click
        Dim frm As New frmrptFullReport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub انتقالقراردادToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles انتقالقراردادToolStripMenuItem.Click
        Dim frm As New frmChangeGharardad
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub گزارشاقساطToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles گزارشاقساطToolStripMenuItem.Click
        Dim frm As New frmRptAghsat
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub فروشمشاورینToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles فروشمشاورینToolStripMenuItem.Click
        Dim frm As New frmSalesReport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub حذفقراردادToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles حذفقراردادToolStripMenuItem.Click
        Dim frm As New frmDeleteGharadad
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub مغایراتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مغایراتToolStripMenuItem.Click
        Dim MG As New RptMoghayeraat
        MG.Generate()
        Dim frm As New frmReporter
        frm.MdiParent = Me
        frm.CrystalReportViewer1.ReportSource = frm.RptMoghayerat1
        frm.RptMoghayerat1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        frm.RptMoghayerat1.PrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Vertical
        frm.Show()
    End Sub

    Private Sub گزارشToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles گزارشToolStripMenuItem.Click
        Dim frm As New frmCheckReport
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ثبتمراجعهکنندهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ثبتمراجعهکنندهToolStripMenuItem.Click
        Dim frm As New frmRegMorajein
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub گزارشمراجعهکنندگانToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles گزارشمراجعهکنندگانToolStripMenuItem.Click
        Dim frm As New frmPeygiri
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ارسالپیامکبامتنمشخصToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ارسالپیامکبامتنمشخصToolStripMenuItem.Click
        Dim frm As New frmSendSMS
        frm.MdiParent = Me
        frm.Show()
    End Sub


    Private Sub ثبتهزینههایToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ثبتهزینههایToolStripMenuItem.Click
        Dim frm As New frmRegMostahdisat
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ثبتاطلاعاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ثبتاطلاعاتToolStripMenuItem.Click
        Dim frm As New frmRegBankMellatInfo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub نمایشاطلاعاتToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles نمایشاطلاعاتToolStripMenuItem.Click
        Dim frm As New frmViewBankInfo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub اصلاحواحدهایفروختهشدهToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اصلاحواحدهایفروختهشدهToolStripMenuItem.Click
        Dim LST As String = "ID='"
        Dim SQLCONection As New SQL
        Dim cmd2 As New SqlClient.SqlCommand("select V.ID,G.GharardadNo,G.Name,G.Lname,V.Sold from GharardadNO G left Join Vahedname V on G.VahedNoID=V.ID where sold='0'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            LST += sdr2(0).ToString & "' OR ID='"
        End While
        SQLCONection.SqlCon.Close()
        LST = Mid(LST, 1, LST.Length - 7)

        Dim cmd3 As New SqlClient.SqlCommand("Update VahedName Set Sold='1' Where " & LST & "", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        cmd3.ExecuteNonQuery()
        SQLCONection.SqlCon.Close()

    End Sub

    Private Sub ثبتاطلاعاتبانکپاسارگادToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ثبتاطلاعاتبانکپاسارگادToolStripMenuItem.Click
        Dim frm As New frmRegBankPasargadInfo
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub کنسلکردنقراردادToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles کنسلکردنقراردادToolStripMenuItem1.Click
        Dim frm As New frmCancelingContract
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub مشخصاتقراردادهایکنسلیToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles مشخصاتقراردادهایکنسلیToolStripMenuItem.Click
        Dim frm As New frmCallGharardadCanceli
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class
