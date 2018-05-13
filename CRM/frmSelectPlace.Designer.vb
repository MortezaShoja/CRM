<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectPlace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectPlace))
        Me.cboZone = New System.Windows.Forms.ComboBox
        Me.cboVahedtype = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboMajmooeName = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dbgVahedName = New System.Windows.Forms.DataGridView
        Me.btnPrint = New System.Windows.Forms.Button
        CType(Me.dbgVahedName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboZone
        '
        Me.cboZone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Location = New System.Drawing.Point(699, 12)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(91, 34)
        Me.cboZone.TabIndex = 159
        '
        'cboVahedtype
        '
        Me.cboVahedtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboVahedtype.FormattingEnabled = True
        Me.cboVahedtype.Location = New System.Drawing.Point(392, 12)
        Me.cboVahedtype.Name = "cboVahedtype"
        Me.cboVahedtype.Size = New System.Drawing.Size(184, 34)
        Me.cboVahedtype.TabIndex = 158
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(319, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 26)
        Me.Label14.TabIndex = 162
        Me.Label14.Text = "نوع واحد :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(582, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 26)
        Me.Label11.TabIndex = 161
        Me.Label11.Text = "منطقه (Zone) :"
        '
        'cboMajmooeName
        '
        Me.cboMajmooeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboMajmooeName.FormattingEnabled = True
        Me.cboMajmooeName.Location = New System.Drawing.Point(129, 12)
        Me.cboMajmooeName.Name = "cboMajmooeName"
        Me.cboMajmooeName.Size = New System.Drawing.Size(184, 34)
        Me.cboMajmooeName.TabIndex = 157
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 26)
        Me.Label4.TabIndex = 160
        Me.Label4.Text = "نام مجموعه :"
        '
        'dbgVahedName
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dbgVahedName.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dbgVahedName.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dbgVahedName.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dbgVahedName.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dbgVahedName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgVahedName.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dbgVahedName.Location = New System.Drawing.Point(12, 53)
        Me.dbgVahedName.MultiSelect = False
        Me.dbgVahedName.Name = "dbgVahedName"
        Me.dbgVahedName.Size = New System.Drawing.Size(889, 310)
        Me.dbgVahedName.TabIndex = 163
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(796, 12)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(105, 34)
        Me.btnPrint.TabIndex = 164
        Me.btnPrint.Text = "چاپ"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmSelectPlace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 375)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.dbgVahedName)
        Me.Controls.Add(Me.cboZone)
        Me.Controls.Add(Me.cboVahedtype)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cboMajmooeName)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectPlace"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "فرم انتخاب مجموعه :::..."
        CType(Me.dbgVahedName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboZone As System.Windows.Forms.ComboBox
    Friend WithEvents cboVahedtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboMajmooeName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dbgVahedName As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
