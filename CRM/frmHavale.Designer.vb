<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPardakhteHavale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPardakhteHavale))
        Me.bntPaste = New System.Windows.Forms.Button
        Me.btnCopy = New System.Windows.Forms.Button
        Me.dbgCheck = New System.Windows.Forms.DataGridView
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnReg = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.txtBankCode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtBankShobe = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBankName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtHavaleNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChkPardakhtShod = New System.Windows.Forms.CheckBox
        Me.txtTozihat = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.cboSayerJahate = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPardakhtDate = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.dbgCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bntPaste
        '
        Me.bntPaste.Location = New System.Drawing.Point(145, 290)
        Me.bntPaste.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bntPaste.Name = "bntPaste"
        Me.bntPaste.Size = New System.Drawing.Size(83, 36)
        Me.bntPaste.TabIndex = 7
        Me.bntPaste.Text = "Paste"
        Me.bntPaste.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(234, 290)
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(83, 36)
        Me.btnCopy.TabIndex = 6
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'dbgCheck
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dbgCheck.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dbgCheck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dbgCheck.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dbgCheck.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dbgCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgCheck.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dbgCheck.Location = New System.Drawing.Point(14, 334)
        Me.dbgCheck.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dbgCheck.MultiSelect = False
        Me.dbgCheck.Name = "dbgCheck"
        Me.dbgCheck.Size = New System.Drawing.Size(681, 174)
        Me.dbgCheck.TabIndex = 12
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(344, 290)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(83, 36)
        Me.btnNew.TabIndex = 8
        Me.btnNew.Text = "جدید"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.Enabled = False
        Me.btnReg.Location = New System.Drawing.Point(434, 290)
        Me.btnReg.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(83, 36)
        Me.btnReg.TabIndex = 9
        Me.btnReg.Text = "ثبت"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(523, 290)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(83, 36)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "تغییرات"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(612, 290)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(83, 36)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtBankCode
        '
        Me.txtBankCode.Location = New System.Drawing.Point(495, 98)
        Me.txtBankCode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBankCode.Name = "txtBankCode"
        Me.txtBankCode.Size = New System.Drawing.Size(200, 33)
        Me.txtBankCode.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(419, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 26)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "کد بانک :"
        '
        'txtBankShobe
        '
        Me.txtBankShobe.Location = New System.Drawing.Point(495, 57)
        Me.txtBankShobe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBankShobe.Name = "txtBankShobe"
        Me.txtBankShobe.Size = New System.Drawing.Size(200, 33)
        Me.txtBankShobe.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(403, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 26)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "شعبه بانک :"
        '
        'txtBankName
        '
        Me.txtBankName.Location = New System.Drawing.Point(495, 16)
        Me.txtBankName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.Size = New System.Drawing.Size(200, 33)
        Me.txtBankName.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(418, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 26)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "نام بانک :"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(146, 98)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(200, 33)
        Me.txtPrice.TabIndex = 2
        Me.txtPrice.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 26)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "مبلغ حواله (ریال) :"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(146, 57)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(200, 33)
        Me.txtDate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 26)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "تاریخ حواله :"
        '
        'txtHavaleNo
        '
        Me.txtHavaleNo.Location = New System.Drawing.Point(146, 16)
        Me.txtHavaleNo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHavaleNo.Name = "txtHavaleNo"
        Me.txtHavaleNo.Size = New System.Drawing.Size(200, 33)
        Me.txtHavaleNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 26)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "شماره حواله :"
        '
        'ChkPardakhtShod
        '
        Me.ChkPardakhtShod.AutoSize = True
        Me.ChkPardakhtShod.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPardakhtShod.Location = New System.Drawing.Point(17, 290)
        Me.ChkPardakhtShod.Name = "ChkPardakhtShod"
        Me.ChkPardakhtShod.Size = New System.Drawing.Size(102, 30)
        Me.ChkPardakhtShod.TabIndex = 70
        Me.ChkPardakhtShod.Text = "پرداخت شده"
        Me.ChkPardakhtShod.UseVisualStyleBackColor = True
        '
        'txtTozihat
        '
        Me.txtTozihat.Location = New System.Drawing.Point(146, 177)
        Me.txtTozihat.Multiline = True
        Me.txtTozihat.Name = "txtTozihat"
        Me.txtTozihat.Size = New System.Drawing.Size(468, 68)
        Me.txtTozihat.TabIndex = 71
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 26)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "توضیحات :"
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Location = New System.Drawing.Point(620, 177)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 108)
        Me.btnPrint.TabIndex = 73
        Me.btnPrint.Text = "چاپ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cboSayerJahate
        '
        Me.cboSayerJahate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSayerJahate.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboSayerJahate.FormattingEnabled = True
        Me.cboSayerJahate.Items.AddRange(New Object() {"نقدی", "چکی", "واریز به حساب", "حواله", "سفته", "تهاتر"})
        Me.cboSayerJahate.Location = New System.Drawing.Point(145, 251)
        Me.cboSayerJahate.Name = "cboSayerJahate"
        Me.cboSayerJahate.Size = New System.Drawing.Size(469, 34)
        Me.cboSayerJahate.TabIndex = 154
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(92, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 26)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "جهت :"
        '
        'txtPardakhtDate
        '
        Me.txtPardakhtDate.Location = New System.Drawing.Point(495, 138)
        Me.txtPardakhtDate.Name = "txtPardakhtDate"
        Me.txtPardakhtDate.Size = New System.Drawing.Size(200, 33)
        Me.txtPardakhtDate.TabIndex = 155
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(387, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 26)
        Me.Label11.TabIndex = 156
        Me.Label11.Text = "تاریخ پرداخت :"
        '
        'frmPardakhteHavale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 524)
        Me.Controls.Add(Me.txtPardakhtDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboSayerJahate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtTozihat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ChkPardakhtShod)
        Me.Controls.Add(Me.bntPaste)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.dbgCheck)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtBankCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBankShobe)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBankName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHavaleNo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 8, 7, 8)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPardakhteHavale"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "فرم ثبت اطلاعات حواله ها :::..."
        CType(Me.dbgCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bntPaste As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents dbgCheck As System.Windows.Forms.DataGridView
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtBankCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBankShobe As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBankName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHavaleNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkPardakhtShod As System.Windows.Forms.CheckBox
    Friend WithEvents txtTozihat As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cboSayerJahate As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPardakhtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
