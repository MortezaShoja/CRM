<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRptAghsat
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
        Me.dbgAghsat = New System.Windows.Forms.DataGridView
        Me.btnView = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.cboNoeAghsat = New System.Windows.Forms.ComboBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboOfficeName = New System.Windows.Forms.ComboBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.cboSallerName = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cboGozareshType = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboReportType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFromDate = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboSortOption = New System.Windows.Forms.ComboBox
        Me.txtSum = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMoadel = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboAcsDesc = New System.Windows.Forms.ComboBox
        CType(Me.dbgAghsat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbgAghsat
        '
        Me.dbgAghsat.AllowUserToAddRows = False
        Me.dbgAghsat.AllowUserToDeleteRows = False
        Me.dbgAghsat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dbgAghsat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dbgAghsat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dbgAghsat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgAghsat.Location = New System.Drawing.Point(12, 124)
        Me.dbgAghsat.Name = "dbgAghsat"
        Me.dbgAghsat.ReadOnly = True
        Me.dbgAghsat.Size = New System.Drawing.Size(996, 358)
        Me.dbgAghsat.TabIndex = 17
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(931, 12)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 35)
        Me.btnView.TabIndex = 18
        Me.btnView.Text = "نمایش"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(391, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 26)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "نوع اقساط :"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(931, 53)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 35)
        Me.btnPrint.TabIndex = 21
        Me.btnPrint.Text = "چاپ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cboNoeAghsat
        '
        Me.cboNoeAghsat.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboNoeAghsat.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboNoeAghsat.FormattingEnabled = True
        Me.cboNoeAghsat.Items.AddRange(New Object() {"نقدی-سفته-واریز به حساب", "نقدی", "چکی", "واریز به حساب", "حواله", "سفته", "تهاتر"})
        Me.cboNoeAghsat.Location = New System.Drawing.Point(471, 11)
        Me.cboNoeAghsat.Name = "cboNoeAghsat"
        Me.cboNoeAghsat.Size = New System.Drawing.Size(99, 34)
        Me.cboNoeAghsat.TabIndex = 23
        Me.cboNoeAghsat.Text = "نقدی-سفته-واریز به حساب"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(277, 51)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(99, 33)
        Me.txtDate.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 26)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "تا تاریخ :"
        '
        'cboOfficeName
        '
        Me.cboOfficeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboOfficeName.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboOfficeName.FormattingEnabled = True
        Me.cboOfficeName.Location = New System.Drawing.Point(644, 12)
        Me.cboOfficeName.Name = "cboOfficeName"
        Me.cboOfficeName.Size = New System.Drawing.Size(99, 34)
        Me.cboOfficeName.TabIndex = 69
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label26.Location = New System.Drawing.Point(576, 15)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 26)
        Me.Label26.TabIndex = 70
        Me.Label26.Text = "نام دفتر :"
        '
        'cboSallerName
        '
        Me.cboSallerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSallerName.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboSallerName.FormattingEnabled = True
        Me.cboSallerName.Location = New System.Drawing.Point(826, 12)
        Me.cboSallerName.Name = "cboSallerName"
        Me.cboSallerName.Size = New System.Drawing.Size(99, 34)
        Me.cboSallerName.TabIndex = 71
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label25.Location = New System.Drawing.Point(749, 14)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(71, 26)
        Me.Label25.TabIndex = 72
        Me.Label25.Text = "نام مشاور :"
        '
        'cboGozareshType
        '
        Me.cboGozareshType.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboGozareshType.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboGozareshType.FormattingEnabled = True
        Me.cboGozareshType.Items.AddRange(New Object() {"پرداخت شده", "پرداخت نشده"})
        Me.cboGozareshType.Location = New System.Drawing.Point(277, 11)
        Me.cboGozareshType.Name = "cboGozareshType"
        Me.cboGozareshType.Size = New System.Drawing.Size(99, 34)
        Me.cboGozareshType.TabIndex = 74
        Me.cboGozareshType.Text = "پرداخت نشده"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 26)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "نوع پرداخت :"
        '
        'cboReportType
        '
        Me.cboReportType.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboReportType.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboReportType.FormattingEnabled = True
        Me.cboReportType.Items.AddRange(New Object() {"پیش پرداخت", "اقساط"})
        Me.cboReportType.Location = New System.Drawing.Point(83, 11)
        Me.cboReportType.Name = "cboReportType"
        Me.cboReportType.Size = New System.Drawing.Size(99, 34)
        Me.cboReportType.TabIndex = 76
        Me.cboReportType.Text = "اقساط"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 26)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "نوع گزارش :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 26)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "از تاریخ :"
        '
        'txtFromDate
        '
        Me.txtFromDate.Location = New System.Drawing.Point(80, 51)
        Me.txtFromDate.Name = "txtFromDate"
        Me.txtFromDate.Size = New System.Drawing.Size(102, 33)
        Me.txtFromDate.TabIndex = 81
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(382, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 26)
        Me.Label8.TabIndex = 93
        Me.Label8.Text = "مرتب سازی :"
        '
        'cboSortOption
        '
        Me.cboSortOption.FormattingEnabled = True
        Me.cboSortOption.Items.AddRange(New Object() {"تاریخ", "نام خانوادگی", "شماره قرارداد", "نام صاحب حساب", "مبلغ", "علت پرداخت"})
        Me.cboSortOption.Location = New System.Drawing.Point(471, 51)
        Me.cboSortOption.Name = "cboSortOption"
        Me.cboSortOption.Size = New System.Drawing.Size(99, 34)
        Me.cboSortOption.TabIndex = 92
        Me.cboSortOption.Text = "تاریخ"
        '
        'txtSum
        '
        Me.txtSum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSum.Location = New System.Drawing.Point(80, 92)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.ReadOnly = True
        Me.txtSum.Size = New System.Drawing.Size(151, 26)
        Me.txtSum.TabIndex = 77
        Me.txtSum.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 26)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "جمع کل :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(237, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 26)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "معادل :"
        '
        'txtMoadel
        '
        Me.txtMoadel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMoadel.Location = New System.Drawing.Point(294, 90)
        Me.txtMoadel.Name = "txtMoadel"
        Me.txtMoadel.ReadOnly = True
        Me.txtMoadel.Size = New System.Drawing.Size(712, 26)
        Me.txtMoadel.TabIndex = 80
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(586, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 26)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "ترتیب :"
        '
        'cboAcsDesc
        '
        Me.cboAcsDesc.FormattingEnabled = True
        Me.cboAcsDesc.Items.AddRange(New Object() {"صعودی", "نزولی"})
        Me.cboAcsDesc.Location = New System.Drawing.Point(644, 52)
        Me.cboAcsDesc.Name = "cboAcsDesc"
        Me.cboAcsDesc.Size = New System.Drawing.Size(99, 34)
        Me.cboAcsDesc.TabIndex = 94
        Me.cboAcsDesc.Text = "نزولی"
        '
        'frmRptAghsat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 494)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboAcsDesc)
        Me.Controls.Add(Me.dbgAghsat)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboSortOption)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFromDate)
        Me.Controls.Add(Me.txtMoadel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSum)
        Me.Controls.Add(Me.cboReportType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboGozareshType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboSallerName)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cboOfficeName)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.cboNoeAghsat)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnView)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptAghsat"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "frmAghsat"
        CType(Me.dbgAghsat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dbgAghsat As System.Windows.Forms.DataGridView
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cboNoeAghsat As System.Windows.Forms.ComboBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboOfficeName As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cboSallerName As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cboGozareshType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboReportType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFromDate As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboSortOption As System.Windows.Forms.ComboBox
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMoadel As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboAcsDesc As System.Windows.Forms.ComboBox
End Class
