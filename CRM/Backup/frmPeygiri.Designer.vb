<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeygiri
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPeigiriSubject = New System.Windows.Forms.TextBox
        Me.txtPeigiriTime = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPeigiriDate = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboPeygiriConandeUser = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNatijeText = New System.Windows.Forms.TextBox
        Me.txtNatijeTime = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtNatijeDate = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cboMoshaver = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboMoshtariName = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.btnReg = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtReportDate = New System.Windows.Forms.TextBox
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.dbgEvents = New System.Windows.Forms.DataGridView
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dbgEvents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtPeigiriSubject)
        Me.GroupBox3.Controls.Add(Me.txtPeigiriTime)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtPeigiriDate)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 221)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(645, 158)
        Me.GroupBox3.TabIndex = 170
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "موضوع پیگیری :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(516, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 26)
        Me.Label14.TabIndex = 168
        Me.Label14.Text = "موضوع پیگیری :"
        '
        'txtPeigiriSubject
        '
        Me.txtPeigiriSubject.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPeigiriSubject.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtPeigiriSubject.Location = New System.Drawing.Point(6, 71)
        Me.txtPeigiriSubject.Multiline = True
        Me.txtPeigiriSubject.Name = "txtPeigiriSubject"
        Me.txtPeigiriSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPeigiriSubject.Size = New System.Drawing.Size(504, 76)
        Me.txtPeigiriSubject.TabIndex = 2
        '
        'txtPeigiriTime
        '
        Me.txtPeigiriTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPeigiriTime.ForeColor = System.Drawing.Color.White
        Me.txtPeigiriTime.Location = New System.Drawing.Point(6, 32)
        Me.txtPeigiriTime.Name = "txtPeigiriTime"
        Me.txtPeigiriTime.Size = New System.Drawing.Size(178, 33)
        Me.txtPeigiriTime.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(190, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 26)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "ساعت پیگیری :"
        '
        'txtPeigiriDate
        '
        Me.txtPeigiriDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPeigiriDate.ForeColor = System.Drawing.Color.White
        Me.txtPeigiriDate.Location = New System.Drawing.Point(332, 32)
        Me.txtPeigiriDate.Name = "txtPeigiriDate"
        Me.txtPeigiriDate.Size = New System.Drawing.Size(178, 33)
        Me.txtPeigiriDate.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(515, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 26)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "تاریخ پیگیری :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboPeygiriConandeUser)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(645, 78)
        Me.GroupBox1.TabIndex = 171
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "مشخصات کاربر :"
        '
        'cboPeygiriConandeUser
        '
        Me.cboPeygiriConandeUser.FormattingEnabled = True
        Me.cboPeygiriConandeUser.Location = New System.Drawing.Point(6, 32)
        Me.cboPeygiriConandeUser.Name = "cboPeygiriConandeUser"
        Me.cboPeygiriConandeUser.Size = New System.Drawing.Size(178, 34)
        Me.cboPeygiriConandeUser.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "شخص پیگیری کننده :"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserName.Enabled = False
        Me.txtUserName.ForeColor = System.Drawing.Color.White
        Me.txtUserName.Location = New System.Drawing.Point(332, 32)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(178, 33)
        Me.txtUserName.TabIndex = 0
        Me.txtUserName.Text = "ca636913-5070-4a50-8a72-7927dd5621cb"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(515, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "نام کاربر :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNatijeText)
        Me.GroupBox2.Controls.Add(Me.txtNatijeTime)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNatijeDate)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 385)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(645, 158)
        Me.GroupBox2.TabIndex = 171
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "نتیجه پیگیری :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(516, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 26)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "نتیجه پیگیری :"
        '
        'txtNatijeText
        '
        Me.txtNatijeText.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNatijeText.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.txtNatijeText.Location = New System.Drawing.Point(6, 71)
        Me.txtNatijeText.Multiline = True
        Me.txtNatijeText.Name = "txtNatijeText"
        Me.txtNatijeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNatijeText.Size = New System.Drawing.Size(504, 76)
        Me.txtNatijeText.TabIndex = 2
        '
        'txtNatijeTime
        '
        Me.txtNatijeTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNatijeTime.ForeColor = System.Drawing.Color.White
        Me.txtNatijeTime.Location = New System.Drawing.Point(6, 32)
        Me.txtNatijeTime.Name = "txtNatijeTime"
        Me.txtNatijeTime.Size = New System.Drawing.Size(178, 33)
        Me.txtNatijeTime.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ساعت نتیجه گیری :"
        '
        'txtNatijeDate
        '
        Me.txtNatijeDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtNatijeDate.ForeColor = System.Drawing.Color.White
        Me.txtNatijeDate.Location = New System.Drawing.Point(332, 32)
        Me.txtNatijeDate.Name = "txtNatijeDate"
        Me.txtNatijeDate.Size = New System.Drawing.Size(178, 33)
        Me.txtNatijeDate.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(515, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "تاریخ نتیجه گیری :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboMoshaver)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtMobile)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.cboMoshtariName)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtPhone)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 96)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(645, 119)
        Me.GroupBox4.TabIndex = 172
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "مشخصات مشتری :"
        '
        'cboMoshaver
        '
        Me.cboMoshaver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboMoshaver.FormattingEnabled = True
        Me.cboMoshaver.Location = New System.Drawing.Point(6, 32)
        Me.cboMoshaver.Name = "cboMoshaver"
        Me.cboMoshaver.Size = New System.Drawing.Size(178, 34)
        Me.cboMoshaver.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(190, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 26)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "شماره تماس :"
        '
        'txtMobile
        '
        Me.txtMobile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtMobile.ForeColor = System.Drawing.Color.White
        Me.txtMobile.Location = New System.Drawing.Point(332, 72)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(178, 33)
        Me.txtMobile.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(515, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 26)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "شماره همراه :"
        '
        'cboMoshtariName
        '
        Me.cboMoshtariName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cboMoshtariName.FormattingEnabled = True
        Me.cboMoshtariName.Location = New System.Drawing.Point(331, 32)
        Me.cboMoshtariName.Name = "cboMoshtariName"
        Me.cboMoshtariName.Size = New System.Drawing.Size(178, 34)
        Me.cboMoshtariName.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(190, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 26)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "نام مشاور :"
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPhone.ForeColor = System.Drawing.Color.White
        Me.txtPhone.Location = New System.Drawing.Point(6, 72)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(178, 33)
        Me.txtPhone.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(515, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 26)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "نام مشتری :"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnReg)
        Me.GroupBox5.Controls.Add(Me.btnPrint)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtReportDate)
        Me.GroupBox5.Controls.Add(Me.btnNew)
        Me.GroupBox5.Controls.Add(Me.btnEdit)
        Me.GroupBox5.Controls.Add(Me.btnDelete)
        Me.GroupBox5.Controls.Add(Me.dbgEvents)
        Me.GroupBox5.Location = New System.Drawing.Point(660, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(270, 531)
        Me.GroupBox5.TabIndex = 173
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "گزارش پیگیری ها :"
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(94, 450)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(82, 32)
        Me.btnReg.TabIndex = 0
        Me.btnReg.Text = "ثبت"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(6, 450)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(82, 70)
        Me.btnPrint.TabIndex = 2
        Me.btnPrint.Text = "چاپ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(169, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 26)
        Me.Label15.TabIndex = 172
        Me.Label15.Text = "تاریخ گزارش :"
        '
        'txtReportDate
        '
        Me.txtReportDate.BackColor = System.Drawing.Color.Orange
        Me.txtReportDate.ForeColor = System.Drawing.Color.White
        Me.txtReportDate.Location = New System.Drawing.Point(6, 32)
        Me.txtReportDate.Name = "txtReportDate"
        Me.txtReportDate.Size = New System.Drawing.Size(157, 33)
        Me.txtReportDate.TabIndex = 5
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(182, 450)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(82, 32)
        Me.btnNew.TabIndex = 1
        Me.btnNew.Text = "جدید"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(182, 488)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(82, 32)
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "تغییرات"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(94, 488)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(82, 32)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dbgEvents
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dbgEvents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dbgEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dbgEvents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dbgEvents.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dbgEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgEvents.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dbgEvents.Location = New System.Drawing.Point(6, 71)
        Me.dbgEvents.MultiSelect = False
        Me.dbgEvents.Name = "dbgEvents"
        Me.dbgEvents.Size = New System.Drawing.Size(258, 373)
        Me.dbgEvents.TabIndex = 15
        '
        'frmPeygiri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(938, 550)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPeygiri"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "frmPeygiri"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.dbgEvents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPeigiriSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtPeigiriTime As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPeigiriDate As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNatijeText As System.Windows.Forms.TextBox
    Friend WithEvents txtNatijeTime As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNatijeDate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboPeygiriConandeUser As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMoshaver As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboMoshtariName As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtReportDate As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dbgEvents As System.Windows.Forms.DataGridView
End Class
