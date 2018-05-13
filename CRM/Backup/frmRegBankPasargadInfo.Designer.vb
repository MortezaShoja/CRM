<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegBankPasargadInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.cboAccountNo = New System.Windows.Forms.ComboBox
        Me.btnOpenDLG = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cboAccountNo
        '
        Me.cboAccountNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAccountNo.FormattingEnabled = True
        Me.cboAccountNo.Items.AddRange(New Object() {"پاسارگاد میدان مادر پس انداز رضا شجاع 212-800-486813-1", "پاسارگاد میدان هروی پس انداز رضا شجاع 282-8000-486813-1", "پاسارگاد میدان مادر پس انداز مرتضی شجاع 212-800-394577-1", "پاسارگاد میدان مادر جاری مرتضی شجاع 212-10-394577-1"})
        Me.cboAccountNo.Location = New System.Drawing.Point(150, 15)
        Me.cboAccountNo.Margin = New System.Windows.Forms.Padding(6)
        Me.cboAccountNo.Name = "cboAccountNo"
        Me.cboAccountNo.Size = New System.Drawing.Size(282, 34)
        Me.cboAccountNo.TabIndex = 7
        '
        'btnOpenDLG
        '
        Me.btnOpenDLG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenDLG.Location = New System.Drawing.Point(15, 14)
        Me.btnOpenDLG.Margin = New System.Windows.Forms.Padding(6)
        Me.btnOpenDLG.Name = "btnOpenDLG"
        Me.btnOpenDLG.Size = New System.Drawing.Size(123, 37)
        Me.btnOpenDLG.TabIndex = 6
        Me.btnOpenDLG.Text = "انتخاب فایل بانک"
        Me.btnOpenDLG.UseVisualStyleBackColor = True
        '
        'frmRegBankPasargadInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 64)
        Me.Controls.Add(Me.cboAccountNo)
        Me.Controls.Add(Me.btnOpenDLG)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegBankPasargadInfo"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "frmRegBankPasargadInfo"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cboAccountNo As System.Windows.Forms.ComboBox
    Friend WithEvents btnOpenDLG As System.Windows.Forms.Button
End Class
