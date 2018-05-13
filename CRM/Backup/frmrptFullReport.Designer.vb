<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptFullReport
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
        Me.cboZone = New System.Windows.Forms.ComboBox
        Me.cboVahedtype = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboMajmooeName = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnView = New System.Windows.Forms.Button
        Me.cboSallerName = New System.Windows.Forms.ComboBox
        Me.cboOfficeName = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDate2 = New System.Windows.Forms.TextBox
        Me.txtDate1 = New System.Windows.Forms.TextBox
        Me.btnSales = New System.Windows.Forms.Button
        Me.cboKharidType = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboPardakhtType = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cboZone
        '
        Me.cboZone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Location = New System.Drawing.Point(112, 92)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(184, 34)
        Me.cboZone.TabIndex = 2
        '
        'cboVahedtype
        '
        Me.cboVahedtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboVahedtype.FormattingEnabled = True
        Me.cboVahedtype.Location = New System.Drawing.Point(112, 52)
        Me.cboVahedtype.Name = "cboVahedtype"
        Me.cboVahedtype.Size = New System.Drawing.Size(184, 34)
        Me.cboVahedtype.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(39, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 19)
        Me.Label14.TabIndex = 168
        Me.Label14.Text = "نوع واحد :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 19)
        Me.Label11.TabIndex = 167
        Me.Label11.Text = "منطقه (Zone) :"
        '
        'cboMajmooeName
        '
        Me.cboMajmooeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboMajmooeName.FormattingEnabled = True
        Me.cboMajmooeName.Location = New System.Drawing.Point(112, 12)
        Me.cboMajmooeName.Name = "cboMajmooeName"
        Me.cboMajmooeName.Size = New System.Drawing.Size(184, 34)
        Me.cboMajmooeName.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "نام مجموعه :"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(112, 410)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(184, 34)
        Me.btnView.TabIndex = 7
        Me.btnView.Text = "گزارش فروش ریز"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'cboSallerName
        '
        Me.cboSallerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSallerName.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboSallerName.FormattingEnabled = True
        Me.cboSallerName.Location = New System.Drawing.Point(112, 252)
        Me.cboSallerName.Name = "cboSallerName"
        Me.cboSallerName.Size = New System.Drawing.Size(184, 34)
        Me.cboSallerName.TabIndex = 4
        '
        'cboOfficeName
        '
        Me.cboOfficeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboOfficeName.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboOfficeName.FormattingEnabled = True
        Me.cboOfficeName.Location = New System.Drawing.Point(112, 212)
        Me.cboOfficeName.Name = "cboOfficeName"
        Me.cboOfficeName.Size = New System.Drawing.Size(184, 34)
        Me.cboOfficeName.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label25.Location = New System.Drawing.Point(35, 255)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 26)
        Me.Label25.TabIndex = 175
        Me.Label25.Text = "نام مشاور :"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label26.Location = New System.Drawing.Point(44, 218)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 26)
        Me.Label26.TabIndex = 174
        Me.Label26.Text = "نام دفتر :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 295)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 26)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "از تاریخ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.Location = New System.Drawing.Point(46, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 26)
        Me.Label2.TabIndex = 179
        Me.Label2.Text = "تا تاریخ :"
        '
        'txtDate2
        '
        Me.txtDate2.Location = New System.Drawing.Point(112, 331)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.Size = New System.Drawing.Size(184, 33)
        Me.txtDate2.TabIndex = 6
        '
        'txtDate1
        '
        Me.txtDate1.Location = New System.Drawing.Point(112, 292)
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.Size = New System.Drawing.Size(184, 33)
        Me.txtDate1.TabIndex = 5
        '
        'btnSales
        '
        Me.btnSales.Location = New System.Drawing.Point(112, 370)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(184, 34)
        Me.btnSales.TabIndex = 180
        Me.btnSales.Text = "گزارش فروش"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'cboKharidType
        '
        Me.cboKharidType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboKharidType.FormattingEnabled = True
        Me.cboKharidType.Items.AddRange(New Object() {"", "نقدی", "قسطی"})
        Me.cboKharidType.Location = New System.Drawing.Point(112, 132)
        Me.cboKharidType.Name = "cboKharidType"
        Me.cboKharidType.Size = New System.Drawing.Size(184, 34)
        Me.cboKharidType.TabIndex = 181
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 182
        Me.Label3.Text = "نوع خرید :"
        '
        'cboPardakhtType
        '
        Me.cboPardakhtType.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboPardakhtType.FormattingEnabled = True
        Me.cboPardakhtType.Items.AddRange(New Object() {"", "نقدی", "چکی", "واریز به حساب", "حواله", "سفته", "تهاتر"})
        Me.cboPardakhtType.Location = New System.Drawing.Point(112, 172)
        Me.cboPardakhtType.Name = "cboPardakhtType"
        Me.cboPardakhtType.Size = New System.Drawing.Size(184, 34)
        Me.cboPardakhtType.TabIndex = 183
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 184
        Me.Label5.Text = "نوع پرداخت :"
        '
        'frmrptFullReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 489)
        Me.Controls.Add(Me.cboPardakhtType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboKharidType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.txtDate2)
        Me.Controls.Add(Me.txtDate1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboSallerName)
        Me.Controls.Add(Me.cboOfficeName)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.cboZone)
        Me.Controls.Add(Me.cboVahedtype)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboMajmooeName)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmrptFullReport"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "frmrptFullReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboZone As System.Windows.Forms.ComboBox
    Friend WithEvents cboVahedtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboMajmooeName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents cboSallerName As System.Windows.Forms.ComboBox
    Friend WithEvents cboOfficeName As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDate2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDate1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents cboKharidType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboPardakhtType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
