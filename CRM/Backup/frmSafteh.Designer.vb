<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPardakhteSafteh
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPardakhteSafteh))
        Me.bntPaste = New System.Windows.Forms.Button
        Me.btnCopy = New System.Windows.Forms.Button
        Me.dbgCheck = New System.Windows.Forms.DataGridView
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnReg = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.txtSafteNo = New System.Windows.Forms.TextBox
        Me.txtMoteahedName = New System.Windows.Forms.TextBox
        Me.cboHavaleKard = New System.Windows.Forms.ComboBox
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
        Me.bntPaste.Location = New System.Drawing.Point(132, 321)
        Me.bntPaste.Name = "bntPaste"
        Me.bntPaste.Size = New System.Drawing.Size(75, 33)
        Me.bntPaste.TabIndex = 8
        Me.bntPaste.Text = "Paste"
        Me.bntPaste.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(213, 321)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 33)
        Me.btnCopy.TabIndex = 7
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
        Me.dbgCheck.Location = New System.Drawing.Point(12, 360)
        Me.dbgCheck.MultiSelect = False
        Me.dbgCheck.Name = "dbgCheck"
        Me.dbgCheck.Size = New System.Drawing.Size(619, 165)
        Me.dbgCheck.TabIndex = 13
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(313, 321)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 33)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "جدید"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.Enabled = False
        Me.btnReg.Location = New System.Drawing.Point(394, 321)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(75, 33)
        Me.btnReg.TabIndex = 10
        Me.btnReg.Text = "ثبت"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(475, 321)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 33)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "تغییرات"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(556, 321)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(356, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 26)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "آدرس متعهد :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(366, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 26)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "تلفن تماس :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(42, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 26)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "شماره سفته :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(345, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 26)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "تاریخ سررسید :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 26)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "نام متعهد :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 26)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "حواله کرد :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 26)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "مبلغ سفته (ریال) :"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(450, 51)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(181, 33)
        Me.txtPhone.TabIndex = 5
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(450, 12)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(181, 33)
        Me.txtDate.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(450, 90)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(181, 72)
        Me.txtAddress.TabIndex = 6
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(133, 12)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(181, 33)
        Me.txtPrice.TabIndex = 0
        Me.txtPrice.Text = "0"
        '
        'txtSafteNo
        '
        Me.txtSafteNo.Location = New System.Drawing.Point(133, 51)
        Me.txtSafteNo.Name = "txtSafteNo"
        Me.txtSafteNo.Size = New System.Drawing.Size(181, 33)
        Me.txtSafteNo.TabIndex = 1
        '
        'txtMoteahedName
        '
        Me.txtMoteahedName.Location = New System.Drawing.Point(133, 129)
        Me.txtMoteahedName.Name = "txtMoteahedName"
        Me.txtMoteahedName.Size = New System.Drawing.Size(181, 33)
        Me.txtMoteahedName.TabIndex = 3
        '
        'cboHavaleKard
        '
        Me.cboHavaleKard.FormattingEnabled = True
        Me.cboHavaleKard.Items.AddRange(New Object() {"رضا شجاع"})
        Me.cboHavaleKard.Location = New System.Drawing.Point(133, 89)
        Me.cboHavaleKard.Name = "cboHavaleKard"
        Me.cboHavaleKard.Size = New System.Drawing.Size(181, 34)
        Me.cboHavaleKard.TabIndex = 57
        Me.cboHavaleKard.Text = "رضا شجاع"
        '
        'ChkPardakhtShod
        '
        Me.ChkPardakhtShod.AutoSize = True
        Me.ChkPardakhtShod.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPardakhtShod.Location = New System.Drawing.Point(16, 329)
        Me.ChkPardakhtShod.Name = "ChkPardakhtShod"
        Me.ChkPardakhtShod.Size = New System.Drawing.Size(102, 30)
        Me.ChkPardakhtShod.TabIndex = 69
        Me.ChkPardakhtShod.Text = "پرداخت شده"
        Me.ChkPardakhtShod.UseVisualStyleBackColor = True
        '
        'txtTozihat
        '
        Me.txtTozihat.Location = New System.Drawing.Point(132, 207)
        Me.txtTozihat.Multiline = True
        Me.txtTozihat.Name = "txtTozihat"
        Me.txtTozihat.Size = New System.Drawing.Size(416, 68)
        Me.txtTozihat.TabIndex = 70
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(54, 218)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 26)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "توضیحات :"
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Location = New System.Drawing.Point(556, 207)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 108)
        Me.btnPrint.TabIndex = 72
        Me.btnPrint.Text = "چاپ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cboSayerJahate
        '
        Me.cboSayerJahate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSayerJahate.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboSayerJahate.FormattingEnabled = True
        Me.cboSayerJahate.Items.AddRange(New Object() {"نقدی", "چکی", "واریز به حساب", "حواله", "سفته", "تهاتر"})
        Me.cboSayerJahate.Location = New System.Drawing.Point(132, 281)
        Me.cboSayerJahate.Name = "cboSayerJahate"
        Me.cboSayerJahate.Size = New System.Drawing.Size(418, 34)
        Me.cboSayerJahate.TabIndex = 156
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(79, 293)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 26)
        Me.Label10.TabIndex = 155
        Me.Label10.Text = "جهت :"
        '
        'txtPardakhtDate
        '
        Me.txtPardakhtDate.Location = New System.Drawing.Point(450, 168)
        Me.txtPardakhtDate.Name = "txtPardakhtDate"
        Me.txtPardakhtDate.Size = New System.Drawing.Size(181, 33)
        Me.txtPardakhtDate.TabIndex = 157
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(350, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 26)
        Me.Label11.TabIndex = 158
        Me.Label11.Text = "تاریخ پرداخت :"
        '
        'frmPardakhteSafteh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 539)
        Me.Controls.Add(Me.txtPardakhtDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboSayerJahate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtTozihat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ChkPardakhtShod)
        Me.Controls.Add(Me.cboHavaleKard)
        Me.Controls.Add(Me.txtMoteahedName)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtSafteNo)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.bntPaste)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.dbgCheck)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPardakhteSafteh"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "فرم ثبت اطلاعات سفته ها :::.."
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtSafteNo As System.Windows.Forms.TextBox
    Friend WithEvents txtMoteahedName As System.Windows.Forms.TextBox
    Friend WithEvents cboHavaleKard As System.Windows.Forms.ComboBox
    Friend WithEvents ChkPardakhtShod As System.Windows.Forms.CheckBox
    Friend WithEvents txtTozihat As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cboSayerJahate As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPardakhtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
