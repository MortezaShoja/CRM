<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPardakhteTahator
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPardakhteTahator))
        Me.dbgTahator = New System.Windows.Forms.DataGridView
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnReg = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.txtPrice = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTozihat = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ChkPardakhtShod = New System.Windows.Forms.CheckBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.cboSayerJahate = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPardakhtDate = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.dbgTahator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbgTahator
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dbgTahator.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dbgTahator.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dbgTahator.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dbgTahator.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dbgTahator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgTahator.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dbgTahator.Location = New System.Drawing.Point(12, 208)
        Me.dbgTahator.MultiSelect = False
        Me.dbgTahator.Name = "dbgTahator"
        Me.dbgTahator.Size = New System.Drawing.Size(619, 165)
        Me.dbgTahator.TabIndex = 71
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(127, 169)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 33)
        Me.btnNew.TabIndex = 67
        Me.btnNew.Text = "جدید"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.Enabled = False
        Me.btnReg.Location = New System.Drawing.Point(208, 169)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(75, 33)
        Me.btnReg.TabIndex = 68
        Me.btnReg.Text = "ثبت"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Enabled = False
        Me.btnEdit.Location = New System.Drawing.Point(289, 169)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 33)
        Me.btnEdit.TabIndex = 69
        Me.btnEdit.Text = "تغییرات"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(370, 169)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 33)
        Me.btnDelete.TabIndex = 70
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(126, 13)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(182, 33)
        Me.txtPrice.TabIndex = 66
        Me.txtPrice.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 26)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "مبلغ نقدی (ریال)"
        '
        'txtTozihat
        '
        Me.txtTozihat.Location = New System.Drawing.Point(127, 90)
        Me.txtTozihat.Name = "txtTozihat"
        Me.txtTozihat.Size = New System.Drawing.Size(410, 33)
        Me.txtTozihat.TabIndex = 73
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 26)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "توضیحات"
        '
        'ChkPardakhtShod
        '
        Me.ChkPardakhtShod.AutoSize = True
        Me.ChkPardakhtShod.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPardakhtShod.Location = New System.Drawing.Point(529, 15)
        Me.ChkPardakhtShod.Name = "ChkPardakhtShod"
        Me.ChkPardakhtShod.Size = New System.Drawing.Size(102, 30)
        Me.ChkPardakhtShod.TabIndex = 75
        Me.ChkPardakhtShod.Text = "پرداخت شده"
        Me.ChkPardakhtShod.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(419, 12)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(117, 33)
        Me.txtDate.TabIndex = 76
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(314, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 26)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "تاریخ سررسید :"
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Location = New System.Drawing.Point(543, 51)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(88, 112)
        Me.btnPrint.TabIndex = 78
        Me.btnPrint.Text = "چاپ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'cboSayerJahate
        '
        Me.cboSayerJahate.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboSayerJahate.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cboSayerJahate.FormattingEnabled = True
        Me.cboSayerJahate.Items.AddRange(New Object() {"نقدی", "چکی", "واریز به حساب", "حواله", "سفته", "تهاتر"})
        Me.cboSayerJahate.Location = New System.Drawing.Point(127, 129)
        Me.cboSayerJahate.Name = "cboSayerJahate"
        Me.cboSayerJahate.Size = New System.Drawing.Size(410, 34)
        Me.cboSayerJahate.TabIndex = 158
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(74, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 26)
        Me.Label10.TabIndex = 157
        Me.Label10.Text = "جهت :"
        '
        'txtPardakhtDate
        '
        Me.txtPardakhtDate.Location = New System.Drawing.Point(419, 51)
        Me.txtPardakhtDate.Name = "txtPardakhtDate"
        Me.txtPardakhtDate.Size = New System.Drawing.Size(118, 33)
        Me.txtPardakhtDate.TabIndex = 159
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(319, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 26)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "تاریخ پرداخت :"
        '
        'frmPardakhteTahator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 392)
        Me.Controls.Add(Me.txtPardakhtDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboSayerJahate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ChkPardakhtShod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTozihat)
        Me.Controls.Add(Me.dbgTahator)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPardakhteTahator"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "فرم ثبت دریافتی تهاتری :::..."
        CType(Me.dbgTahator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dbgTahator As System.Windows.Forms.DataGridView
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTozihat As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkPardakhtShod As System.Windows.Forms.CheckBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents cboSayerJahate As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPardakhtDate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
