<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegGharardadText
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegGharardadText))
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboTitle = New System.Windows.Forms.ComboBox
        Me.cboMadeh = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboBand = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnReg = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.DbgView = New System.Windows.Forms.DataGridView
        Me.NumericRow = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBandView = New System.Windows.Forms.TextBox
        Me.txtGharardadText = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.NumericBandRow = New System.Windows.Forms.NumericUpDown
        Me.cboMadehNo = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.NuMadehRow = New System.Windows.Forms.NumericUpDown
        CType(Me.DbgView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericRow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericBandRow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NuMadehRow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نوع قرارداد :"
        '
        'cboTitle
        '
        Me.cboTitle.FormattingEnabled = True
        Me.cboTitle.Location = New System.Drawing.Point(85, 12)
        Me.cboTitle.Name = "cboTitle"
        Me.cboTitle.Size = New System.Drawing.Size(237, 28)
        Me.cboTitle.TabIndex = 1
        '
        'cboMadeh
        '
        Me.cboMadeh.FormattingEnabled = True
        Me.cboMadeh.Location = New System.Drawing.Point(522, 12)
        Me.cboMadeh.Name = "cboMadeh"
        Me.cboMadeh.Size = New System.Drawing.Size(233, 28)
        Me.cboMadeh.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ماده :"
        '
        'cboBand
        '
        Me.cboBand.FormattingEnabled = True
        Me.cboBand.Location = New System.Drawing.Point(85, 46)
        Me.cboBand.Name = "cboBand"
        Me.cboBand.Size = New System.Drawing.Size(427, 28)
        Me.cboBand.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "بند :"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(518, 80)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 28)
        Me.btnEdit.TabIndex = 25
        Me.btnEdit.Text = "ویرایش"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(437, 80)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 28)
        Me.btnNew.TabIndex = 24
        Me.btnNew.Text = "جدید"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(599, 80)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(75, 28)
        Me.btnReg.TabIndex = 23
        Me.btnReg.Text = "ثبت"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(680, 80)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 28)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'DbgView
        '
        Me.DbgView.AllowDrop = True
        Me.DbgView.AllowUserToAddRows = False
        Me.DbgView.AllowUserToDeleteRows = False
        Me.DbgView.AllowUserToOrderColumns = True
        Me.DbgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DbgView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DbgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DbgView.Location = New System.Drawing.Point(12, 114)
        Me.DbgView.Name = "DbgView"
        Me.DbgView.ReadOnly = True
        Me.DbgView.Size = New System.Drawing.Size(743, 109)
        Me.DbgView.TabIndex = 26
        '
        'NumericRow
        '
        Me.NumericRow.Location = New System.Drawing.Point(564, 46)
        Me.NumericRow.Name = "NumericRow"
        Me.NumericRow.Size = New System.Drawing.Size(57, 28)
        Me.NumericRow.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(518, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "ردیف :"
        '
        'txtBandView
        '
        Me.txtBandView.Location = New System.Drawing.Point(12, 229)
        Me.txtBandView.Multiline = True
        Me.txtBandView.Name = "txtBandView"
        Me.txtBandView.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtBandView.Size = New System.Drawing.Size(743, 113)
        Me.txtBandView.TabIndex = 29
        '
        'txtGharardadText
        '
        Me.txtGharardadText.Location = New System.Drawing.Point(12, 348)
        Me.txtGharardadText.Multiline = True
        Me.txtGharardadText.Name = "txtGharardadText"
        Me.txtGharardadText.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtGharardadText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtGharardadText.Size = New System.Drawing.Size(743, 286)
        Me.txtGharardadText.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(632, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "شماره بند :"
        '
        'NumericBandRow
        '
        Me.NumericBandRow.Location = New System.Drawing.Point(698, 46)
        Me.NumericBandRow.Name = "NumericBandRow"
        Me.NumericBandRow.Size = New System.Drawing.Size(57, 28)
        Me.NumericBandRow.TabIndex = 31
        '
        'cboMadehNo
        '
        Me.cboMadehNo.FormattingEnabled = True
        Me.cboMadehNo.Location = New System.Drawing.Point(431, 12)
        Me.cboMadehNo.Name = "cboMadehNo"
        Me.cboMadehNo.Size = New System.Drawing.Size(81, 28)
        Me.cboMadehNo.TabIndex = 33
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(291, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "جدید"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NuMadehRow
        '
        Me.NuMadehRow.Location = New System.Drawing.Point(368, 12)
        Me.NuMadehRow.Name = "NuMadehRow"
        Me.NuMadehRow.Size = New System.Drawing.Size(57, 28)
        Me.NuMadehRow.TabIndex = 35
        '
        'frmRegGharardadText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 646)
        Me.Controls.Add(Me.NuMadehRow)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cboMadehNo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumericBandRow)
        Me.Controls.Add(Me.txtGharardadText)
        Me.Controls.Add(Me.txtBandView)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NumericRow)
        Me.Controls.Add(Me.DbgView)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.cboBand)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboMadeh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboTitle)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegGharardadText"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تنظیم متن قرارداد :::..."
        CType(Me.DbgView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericRow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericBandRow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NuMadehRow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTitle As System.Windows.Forms.ComboBox
    Friend WithEvents cboMadeh As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboBand As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents DbgView As System.Windows.Forms.DataGridView
    Friend WithEvents NumericRow As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBandView As System.Windows.Forms.TextBox
    Friend WithEvents txtGharardadText As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NumericBandRow As System.Windows.Forms.NumericUpDown
    Friend WithEvents cboMadehNo As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents NuMadehRow As System.Windows.Forms.NumericUpDown
End Class
