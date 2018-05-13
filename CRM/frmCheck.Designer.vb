<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPardakhteCheck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPardakhteCheck))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAccountOwner = New System.Windows.Forms.TextBox
        Me.txtAccountNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCheckNo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtShobeCode = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtShobeName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnReg = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.dbgCheck = New System.Windows.Forms.DataGridView
        Me.btnCopy = New System.Windows.Forms.Button
        Me.bntPaste = New System.Windows.Forms.Button
        Me.txtTozihat = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.ChkPardakhtShod = New System.Windows.Forms.CheckBox
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboSayerJahate = New System.Windows.Forms.ComboBox
        Me.txtPardakhtDate = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtSumPrice = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        CType(Me.dbgCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نام صاحب حساب :"
        '
        'txtAccountOwner
        '
        Me.txtAccountOwner.Location = New System.Drawing.Point(132, 12)
        Me.txtAccountOwner.Name = "txtAccountOwner"
        Me.txtAccountOwner.Size = New System.Drawing.Size(182, 33)
        Me.txtAccountOwner.TabIndex = 0
        '
        'txtAccountNo
        '
        Me.txtAccountNo.Location = New System.Drawing.Point(132, 51)
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(182, 33)
        Me.txtAccountNo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "شماره حساب :"
        '
        'txtCheckNo
        '
        Me.txtCheckNo.Location = New System.Drawing.Point(132, 90)
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.Size = New System.Drawing.Size(182, 33)
        Me.txtCheckNo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "شماره چک F12 :"
        '
        'txtBank
        '
        Me.txtBank.Location = New System.Drawing.Point(132, 129)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(182, 33)
        Me.txtBank.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "عهده بانک :"
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(449, 129)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(182, 33)
        Me.txtDate.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(344, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 26)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "تاریخ سررسید :"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(449, 51)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(182, 33)
        Me.txtPrice.TabIndex = 6
        Me.txtPrice.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(364, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 26)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "مبلغ (ریال):"
        '
        'txtShobeCode
        '
        Me.txtShobeCode.Location = New System.Drawing.Point(449, 12)
        Me.txtShobeCode.Name = "txtShobeCode"
        Me.txtShobeCode.Size = New System.Drawing.Size(182, 33)
        Me.txtShobeCode.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(377, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 26)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "کد شعبه :"
        '
        'txtShobeName
        '
        Me.txtShobeName.Location = New System.Drawing.Point(132, 168)
        Me.txtShobeName.Name = "txtShobeName"
        Me.txtShobeName.Size = New System.Drawing.Size(182, 33)
        Me.txtShobeName.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(48, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 26)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "شعبه بانک :"
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(556, 320)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(475, 320)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 33)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "تغییرات"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.Enabled = False
        Me.btnReg.Location = New System.Drawing.Point(394, 320)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(75, 33)
        Me.btnReg.TabIndex = 11
        Me.btnReg.Text = "ثبت"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(313, 320)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 33)
        Me.btnNew.TabIndex = 10
        Me.btnNew.Text = "جدید"
        Me.btnNew.UseVisualStyleBackColor = True
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
        Me.dbgCheck.Location = New System.Drawing.Point(12, 359)
        Me.dbgCheck.MultiSelect = False
        Me.dbgCheck.Name = "dbgCheck"
        Me.dbgCheck.Size = New System.Drawing.Size(619, 165)
        Me.dbgCheck.TabIndex = 14
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(213, 320)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 33)
        Me.btnCopy.TabIndex = 8
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'bntPaste
        '
        Me.bntPaste.Location = New System.Drawing.Point(132, 320)
        Me.bntPaste.Name = "bntPaste"
        Me.bntPaste.Size = New System.Drawing.Size(75, 33)
        Me.bntPaste.TabIndex = 9
        Me.bntPaste.Text = "Paste"
        Me.bntPaste.UseVisualStyleBackColor = True
        '
        'txtTozihat
        '
        Me.txtTozihat.Location = New System.Drawing.Point(132, 207)
        Me.txtTozihat.Multiline = True
        Me.txtTozihat.Name = "txtTozihat"
        Me.txtTozihat.Size = New System.Drawing.Size(418, 68)
        Me.txtTozihat.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 229)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 26)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "توضیحات :"
        '
        'ChkPardakhtShod
        '
        Me.ChkPardakhtShod.AutoSize = True
        Me.ChkPardakhtShod.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPardakhtShod.Location = New System.Drawing.Point(10, 320)
        Me.ChkPardakhtShod.Name = "ChkPardakhtShod"
        Me.ChkPardakhtShod.Size = New System.Drawing.Size(102, 30)
        Me.ChkPardakhtShod.TabIndex = 69
        Me.ChkPardakhtShod.Text = "پرداخت شده"
        Me.ChkPardakhtShod.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Location = New System.Drawing.Point(556, 207)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 107)
        Me.btnPrint.TabIndex = 70
        Me.btnPrint.Text = "چاپ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(79, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 26)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "جهت :"
        '
        'cboSayerJahate
        '
        Me.cboSayerJahate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSayerJahate.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboSayerJahate.FormattingEnabled = True
        Me.cboSayerJahate.Items.AddRange(New Object() {"نقدی", "چکی", "واریز به حساب", "حواله", "سفته", "تهاتر"})
        Me.cboSayerJahate.Location = New System.Drawing.Point(132, 280)
        Me.cboSayerJahate.Name = "cboSayerJahate"
        Me.cboSayerJahate.Size = New System.Drawing.Size(418, 34)
        Me.cboSayerJahate.TabIndex = 152
        '
        'txtPardakhtDate
        '
        Me.txtPardakhtDate.Location = New System.Drawing.Point(449, 168)
        Me.txtPardakhtDate.Name = "txtPardakhtDate"
        Me.txtPardakhtDate.Size = New System.Drawing.Size(182, 33)
        Me.txtPardakhtDate.TabIndex = 153
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(344, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 26)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "تاریخ پرداخت :"
        '
        'txtSumPrice
        '
        Me.txtSumPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSumPrice.Enabled = False
        Me.txtSumPrice.Location = New System.Drawing.Point(449, 90)
        Me.txtSumPrice.Name = "txtSumPrice"
        Me.txtSumPrice.Size = New System.Drawing.Size(182, 33)
        Me.txtSumPrice.TabIndex = 155
        Me.txtSumPrice.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(332, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 26)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "جمع مبلغ (ریال) :"
        '
        'frmPardakhteCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 541)
        Me.Controls.Add(Me.txtSumPrice)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPardakhtDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboSayerJahate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.ChkPardakhtShod)
        Me.Controls.Add(Me.txtTozihat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bntPaste)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.dbgCheck)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtShobeCode)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtShobeName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBank)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCheckNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAccountNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAccountOwner)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPardakhteCheck"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "فرم ثبت اطلاعات چکها :::..."
        CType(Me.dbgCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAccountOwner As System.Windows.Forms.TextBox
    Friend WithEvents txtAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCheckNo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtShobeCode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtShobeName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents dbgCheck As System.Windows.Forms.DataGridView
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents bntPaste As System.Windows.Forms.Button
    Friend WithEvents txtTozihat As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ChkPardakhtShod As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboSayerJahate As System.Windows.Forms.ComboBox
    Friend WithEvents txtPardakhtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSumPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
