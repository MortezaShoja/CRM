<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegGender
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
        Me.dbgGender = New System.Windows.Forms.DataGridView
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnReg = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtGender = New System.Windows.Forms.TextBox
        Me.rbHoghooghi = New System.Windows.Forms.RadioButton
        Me.rbHaghighi = New System.Windows.Forms.RadioButton
        CType(Me.dbgGender, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbgGender
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dbgGender.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dbgGender.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dbgGender.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dbgGender.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dbgGender.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgGender.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dbgGender.Location = New System.Drawing.Point(21, 76)
        Me.dbgGender.MultiSelect = False
        Me.dbgGender.Name = "dbgGender"
        Me.dbgGender.Size = New System.Drawing.Size(318, 150)
        Me.dbgGender.TabIndex = 12
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(264, 232)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 38)
        Me.btnUpdate.TabIndex = 11
        Me.btnUpdate.Text = "تغییرات"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(183, 232)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 38)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(102, 232)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(75, 38)
        Me.btnReg.TabIndex = 9
        Me.btnReg.Text = "ثبت"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(21, 232)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 38)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "جدید"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "عنوان خریدار :"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(100, 12)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(239, 28)
        Me.txtGender.TabIndex = 6
        '
        'rbHoghooghi
        '
        Me.rbHoghooghi.AutoSize = True
        Me.rbHoghooghi.Location = New System.Drawing.Point(247, 46)
        Me.rbHoghooghi.Name = "rbHoghooghi"
        Me.rbHoghooghi.Size = New System.Drawing.Size(92, 24)
        Me.rbHoghooghi.TabIndex = 13
        Me.rbHoghooghi.TabStop = True
        Me.rbHoghooghi.Text = "خریدار حقوقی"
        Me.rbHoghooghi.UseVisualStyleBackColor = True
        '
        'rbHaghighi
        '
        Me.rbHaghighi.AutoSize = True
        Me.rbHaghighi.Location = New System.Drawing.Point(100, 46)
        Me.rbHaghighi.Name = "rbHaghighi"
        Me.rbHaghighi.Size = New System.Drawing.Size(92, 24)
        Me.rbHaghighi.TabIndex = 14
        Me.rbHaghighi.TabStop = True
        Me.rbHaghighi.Text = "خریدار حقیقی"
        Me.rbHaghighi.UseVisualStyleBackColor = True
        '
        'frmRegGender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 280)
        Me.Controls.Add(Me.rbHaghighi)
        Me.Controls.Add(Me.rbHoghooghi)
        Me.Controls.Add(Me.dbgGender)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGender)
        Me.Font = New System.Drawing.Font("B Nazanin", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegGender"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "فرم ثبت عنوان خریدار :::..."
        CType(Me.dbgGender, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dbgGender As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents rbHoghooghi As System.Windows.Forms.RadioButton
    Friend WithEvents rbHaghighi As System.Windows.Forms.RadioButton
End Class
