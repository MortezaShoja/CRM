<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVarizBeHesab
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVarizBeHesab))
        Me.bntPaste = New System.Windows.Forms.Button
        Me.btnCopy = New System.Windows.Forms.Button
        Me.dbgBank = New System.Windows.Forms.DataGridView
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnReg = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtFishNo = New System.Windows.Forms.TextBox
        Me.txtPeygiriCode = New System.Windows.Forms.TextBox
        Me.txtDestinationAccount = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtAccountNo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAccountOwnerName = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ChkPardakhtShod = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.cboSayerJahate = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPardakhtDate = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTozihat = New System.Windows.Forms.TextBox
        Me.txtSandCode = New System.Windows.Forms.TextBox
        Me.txtSumAll = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboPartOf = New System.Windows.Forms.ComboBox
        CType(Me.dbgBank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bntPaste
        '
        Me.bntPaste.Location = New System.Drawing.Point(133, 319)
        Me.bntPaste.Name = "bntPaste"
        Me.bntPaste.Size = New System.Drawing.Size(75, 33)
        Me.bntPaste.TabIndex = 19
        Me.bntPaste.Text = "Paste"
        Me.bntPaste.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(214, 319)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 33)
        Me.btnCopy.TabIndex = 18
        Me.btnCopy.Text = "Copy"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'dbgBank
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dbgBank.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dbgBank.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dbgBank.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dbgBank.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dbgBank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgBank.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dbgBank.Location = New System.Drawing.Point(13, 360)
        Me.dbgBank.MultiSelect = False
        Me.dbgBank.Name = "dbgBank"
        Me.dbgBank.Size = New System.Drawing.Size(619, 165)
        Me.dbgBank.TabIndex = 21
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(314, 321)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 33)
        Me.btnNew.TabIndex = 17
        Me.btnNew.Text = "جدید"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.Enabled = False
        Me.btnReg.Location = New System.Drawing.Point(395, 321)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(75, 33)
        Me.btnReg.TabIndex = 14
        Me.btnReg.Text = "ثبت"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(476, 321)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 33)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "تغییرات"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(557, 321)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(364, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 26)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "ساعت واریز :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(363, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 26)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "شماره فیش :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 26)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "تاریخ سررسید :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 26)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "کد پیگیری :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 26)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "مبلغ (ریال) :"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(452, 129)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(181, 33)
        Me.txtTime.TabIndex = 10
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(133, 168)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(181, 33)
        Me.txtDate.TabIndex = 4
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(134, 12)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(181, 33)
        Me.txtPrice.TabIndex = 1
        Me.txtPrice.Text = "0"
        '
        'txtFishNo
        '
        Me.txtFishNo.Location = New System.Drawing.Point(452, 49)
        Me.txtFishNo.Name = "txtFishNo"
        Me.txtFishNo.Size = New System.Drawing.Size(181, 33)
        Me.txtFishNo.TabIndex = 8
        '
        'txtPeygiriCode
        '
        Me.txtPeygiriCode.Location = New System.Drawing.Point(506, 8)
        Me.txtPeygiriCode.Name = "txtPeygiriCode"
        Me.txtPeygiriCode.Size = New System.Drawing.Size(127, 33)
        Me.txtPeygiriCode.TabIndex = 6
        '
        'txtDestinationAccount
        '
        Me.txtDestinationAccount.Location = New System.Drawing.Point(452, 168)
        Me.txtDestinationAccount.Name = "txtDestinationAccount"
        Me.txtDestinationAccount.Size = New System.Drawing.Size(181, 33)
        Me.txtDestinationAccount.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(356, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 26)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "حساب مقصد :"
        '
        'txtAccountNo
        '
        Me.txtAccountNo.Location = New System.Drawing.Point(134, 90)
        Me.txtAccountNo.Name = "txtAccountNo"
        Me.txtAccountNo.Size = New System.Drawing.Size(181, 33)
        Me.txtAccountNo.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 26)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "حساب مبدإ :"
        '
        'txtAccountOwnerName
        '
        Me.txtAccountOwnerName.Location = New System.Drawing.Point(134, 129)
        Me.txtAccountOwnerName.Name = "txtAccountOwnerName"
        Me.txtAccountOwnerName.Size = New System.Drawing.Size(181, 33)
        Me.txtAccountOwnerName.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 26)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "نام صاحب حساب :"
        '
        'ChkPardakhtShod
        '
        Me.ChkPardakhtShod.AutoSize = True
        Me.ChkPardakhtShod.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPardakhtShod.Location = New System.Drawing.Point(18, 319)
        Me.ChkPardakhtShod.Name = "ChkPardakhtShod"
        Me.ChkPardakhtShod.Size = New System.Drawing.Size(102, 30)
        Me.ChkPardakhtShod.TabIndex = 12
        Me.ChkPardakhtShod.Text = "پرداخت شده"
        Me.ChkPardakhtShod.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 26)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "توضیحات :"
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Location = New System.Drawing.Point(558, 207)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 108)
        Me.btnPrint.TabIndex = 20
        Me.btnPrint.Text = "چاپ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cboSayerJahate
        '
        Me.cboSayerJahate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSayerJahate.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboSayerJahate.FormattingEnabled = True
        Me.cboSayerJahate.Items.AddRange(New Object() {"نقدی", "چکی", "واریز به حساب", "حواله", "سفته", "تهاتر"})
        Me.cboSayerJahate.Location = New System.Drawing.Point(134, 281)
        Me.cboSayerJahate.Name = "cboSayerJahate"
        Me.cboSayerJahate.Size = New System.Drawing.Size(418, 34)
        Me.cboSayerJahate.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(81, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 26)
        Me.Label10.TabIndex = 159
        Me.Label10.Text = "جهت :"
        '
        'txtPardakhtDate
        '
        Me.txtPardakhtDate.Location = New System.Drawing.Point(452, 90)
        Me.txtPardakhtDate.Name = "txtPardakhtDate"
        Me.txtPardakhtDate.Size = New System.Drawing.Size(181, 33)
        Me.txtPardakhtDate.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(352, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 26)
        Me.Label11.TabIndex = 162
        Me.Label11.Text = "تاریخ پرداخت :"
        '
        'txtTozihat
        '
        Me.txtTozihat.Location = New System.Drawing.Point(134, 207)
        Me.txtTozihat.Multiline = True
        Me.txtTozihat.Name = "txtTozihat"
        Me.txtTozihat.Size = New System.Drawing.Size(418, 68)
        Me.txtTozihat.TabIndex = 12
        '
        'txtSandCode
        '
        Me.txtSandCode.BackColor = System.Drawing.SystemColors.Control
        Me.txtSandCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSandCode.Enabled = False
        Me.txtSandCode.ForeColor = System.Drawing.Color.Red
        Me.txtSandCode.Location = New System.Drawing.Point(12, 287)
        Me.txtSandCode.Name = "txtSandCode"
        Me.txtSandCode.Size = New System.Drawing.Size(42, 26)
        Me.txtSandCode.TabIndex = 0
        Me.txtSandCode.Text = "0"
        Me.txtSandCode.Visible = False
        '
        'txtSumAll
        '
        Me.txtSumAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSumAll.Enabled = False
        Me.txtSumAll.Location = New System.Drawing.Point(134, 51)
        Me.txtSumAll.Name = "txtSumAll"
        Me.txtSumAll.Size = New System.Drawing.Size(181, 33)
        Me.txtSumAll.TabIndex = 163
        Me.txtSumAll.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(27, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 26)
        Me.Label12.TabIndex = 164
        Me.Label12.Text = "مبلغ کل (ریال) :"
        '
        'cboPartOf
        '
        Me.cboPartOf.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboPartOf.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboPartOf.FormattingEnabled = True
        Me.cboPartOf.Items.AddRange(New Object() {"کل", "ازمحل"})
        Me.cboPartOf.Location = New System.Drawing.Point(452, 8)
        Me.cboPartOf.Name = "cboPartOf"
        Me.cboPartOf.Size = New System.Drawing.Size(52, 34)
        Me.cboPartOf.TabIndex = 165
        Me.cboPartOf.Text = "کل"
        '
        'frmVarizBeHesab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 539)
        Me.Controls.Add(Me.cboPartOf)
        Me.Controls.Add(Me.txtSumAll)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSandCode)
        Me.Controls.Add(Me.txtPardakhtDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboSayerJahate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtTozihat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ChkPardakhtShod)
        Me.Controls.Add(Me.txtAccountOwnerName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtAccountNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDestinationAccount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPeygiriCode)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtFishNo)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtTime)
        Me.Controls.Add(Me.bntPaste)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.dbgBank)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVarizBeHesab"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "فرم ثبت اطلاعات واریز به حساب :::.."
        CType(Me.dbgBank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bntPaste As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents dbgBank As System.Windows.Forms.DataGridView
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtFishNo As System.Windows.Forms.TextBox
    Friend WithEvents txtPeygiriCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDestinationAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAccountNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAccountOwnerName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChkPardakhtShod As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cboSayerJahate As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPardakhtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTozihat As System.Windows.Forms.TextBox
    Friend WithEvents txtSandCode As System.Windows.Forms.TextBox
    Friend WithEvents txtSumAll As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cboPartOf As System.Windows.Forms.ComboBox
End Class
