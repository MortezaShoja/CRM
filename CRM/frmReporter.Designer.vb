<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporter))
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.rptPishGhrardad1 = New Mehregan.rptPishGhrardad
        Me.rptGharardad1 = New Mehregan.rptGharardad
        Me.rptFullReport1 = New Mehregan.rptFullReport
        Me.rptSales1 = New Mehregan.rptSales
        Me.RptMoghayerat1 = New Mehregan.RptMoghayerat
        Me.rptResideDaryaft1 = New Mehregan.rptResideDaryaft
        Me.RptGenAllSalesRpt1 = New Mehregan.RptGenAllSalesRpt
        Me.Ghataat1 = New Mehregan.Ghataat
        Me.RptChekz1 = New Mehregan.RptChekz
        Me.rptMorajein1 = New Mehregan.rptMorajein
        Me.rptBankInfo1 = New Mehregan.rptBankInfo
        Me.RptBankRowInfo1 = New Mehregan.RptBankRowInfo
        Me.RptGharardadLists1 = New Mehregan.RptGharardadLists
        Me.rptAghsatFalse1 = New Mehregan.rptAghsatFalse
        Me.rptAghsatTrue1 = New Mehregan.rptAghsatTrue
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(901, 499)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReporter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 499)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReporter"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "گزارشات :::..."
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptFullReport1 As Mehregan.rptFullReport
    Friend WithEvents rptGharardad1 As Mehregan.rptGharardad
    Friend WithEvents rptPishGhrardad1 As Mehregan.rptPishGhrardad
    Friend WithEvents rptSales1 As Mehregan.rptSales
    Friend WithEvents RptMoghayerat1 As Mehregan.RptMoghayerat
    Friend WithEvents rptResideDaryaft1 As Mehregan.rptResideDaryaft
    Friend WithEvents RptGenAllSalesRpt1 As Mehregan.RptGenAllSalesRpt
    Friend WithEvents Ghataat1 As Mehregan.Ghataat
    Friend WithEvents RptChekz1 As Mehregan.RptChekz
    Friend WithEvents rptMorajein1 As Mehregan.rptMorajein
    Friend WithEvents rptBankInfo1 As Mehregan.rptBankInfo
    Friend WithEvents RptBankRowInfo1 As Mehregan.RptBankRowInfo
    Friend WithEvents RptGharardadLists1 As Mehregan.RptGharardadLists
    Friend WithEvents rptAghsatFalse1 As Mehregan.rptAghsatFalse
    Friend WithEvents rptAghsatTrue1 As Mehregan.rptAghsatTrue
End Class
