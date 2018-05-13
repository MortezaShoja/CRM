<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeGharardad
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
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboVahedtype = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboZone = New System.Windows.Forms.ComboBox
        Me.cboMajmooeName = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtGharardadNo1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblID1 = New System.Windows.Forms.Label
        Me.txtMoshtariName1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cboGhateNo1 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtGharardadNo2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblID2 = New System.Windows.Forms.Label
        Me.txtMoshtariName2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboGhateNo2 = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboMajmooeName2 = New System.Windows.Forms.ComboBox
        Me.cboZone2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboVahedtype2 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnTransfer = New System.Windows.Forms.Button
        Me.lblTmpID = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(196, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 19)
        Me.Label14.TabIndex = 174
        Me.Label14.Text = "نوع واحد :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(196, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 19)
        Me.Label11.TabIndex = 173
        Me.Label11.Text = "منطقه (Zone) :"
        '
        'cboVahedtype
        '
        Me.cboVahedtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboVahedtype.FormattingEnabled = True
        Me.cboVahedtype.Location = New System.Drawing.Point(6, 95)
        Me.cboVahedtype.Name = "cboVahedtype"
        Me.cboVahedtype.Size = New System.Drawing.Size(184, 34)
        Me.cboVahedtype.TabIndex = 170
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 19)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "نام مجموعه :"
        '
        'cboZone
        '
        Me.cboZone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Location = New System.Drawing.Point(6, 135)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(184, 34)
        Me.cboZone.TabIndex = 171
        '
        'cboMajmooeName
        '
        Me.cboMajmooeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboMajmooeName.FormattingEnabled = True
        Me.cboMajmooeName.Location = New System.Drawing.Point(6, 55)
        Me.cboMajmooeName.Name = "cboMajmooeName"
        Me.cboMajmooeName.Size = New System.Drawing.Size(184, 34)
        Me.cboMajmooeName.TabIndex = 169
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtGharardadNo1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblID1)
        Me.GroupBox1.Controls.Add(Me.txtMoshtariName1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboGhateNo1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboMajmooeName)
        Me.GroupBox1.Controls.Add(Me.cboZone)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboVahedtype)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(306, 301)
        Me.GroupBox1.TabIndex = 175
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "انتقال از قطعه"
        '
        'txtGharardadNo1
        '
        Me.txtGharardadNo1.Enabled = False
        Me.txtGharardadNo1.Location = New System.Drawing.Point(6, 215)
        Me.txtGharardadNo1.Name = "txtGharardadNo1"
        Me.txtGharardadNo1.Size = New System.Drawing.Size(184, 33)
        Me.txtGharardadNo1.TabIndex = 184
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(196, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 19)
        Me.Label10.TabIndex = 183
        Me.Label10.Text = "شماره قرارداد :"
        '
        'lblID1
        '
        Me.lblID1.AutoSize = True
        Me.lblID1.Font = New System.Drawing.Font("B Nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID1.Location = New System.Drawing.Point(6, 29)
        Me.lblID1.Name = "lblID1"
        Me.lblID1.Size = New System.Drawing.Size(0, 16)
        Me.lblID1.TabIndex = 179
        '
        'txtMoshtariName1
        '
        Me.txtMoshtariName1.Enabled = False
        Me.txtMoshtariName1.Location = New System.Drawing.Point(6, 254)
        Me.txtMoshtariName1.Name = "txtMoshtariName1"
        Me.txtMoshtariName1.Size = New System.Drawing.Size(184, 33)
        Me.txtMoshtariName1.TabIndex = 182
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 19)
        Me.Label7.TabIndex = 181
        Me.Label7.Text = "نام خریدار :"
        '
        'cboGhateNo1
        '
        Me.cboGhateNo1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboGhateNo1.FormattingEnabled = True
        Me.cboGhateNo1.Location = New System.Drawing.Point(6, 175)
        Me.cboGhateNo1.Name = "cboGhateNo1"
        Me.cboGhateNo1.Size = New System.Drawing.Size(184, 34)
        Me.cboGhateNo1.TabIndex = 176
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 177
        Me.Label5.Text = "شماره قطعه :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtGharardadNo2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblID2)
        Me.GroupBox2.Controls.Add(Me.txtMoshtariName2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboGhateNo2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cboMajmooeName2)
        Me.GroupBox2.Controls.Add(Me.cboZone2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cboVahedtype2)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(324, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 301)
        Me.GroupBox2.TabIndex = 176
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "انتقال به"
        '
        'txtGharardadNo2
        '
        Me.txtGharardadNo2.Enabled = False
        Me.txtGharardadNo2.Location = New System.Drawing.Point(6, 215)
        Me.txtGharardadNo2.Name = "txtGharardadNo2"
        Me.txtGharardadNo2.Size = New System.Drawing.Size(184, 33)
        Me.txtGharardadNo2.TabIndex = 185
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(196, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 19)
        Me.Label9.TabIndex = 184
        Me.Label9.Text = "شماره قرارداد :"
        '
        'lblID2
        '
        Me.lblID2.AutoSize = True
        Me.lblID2.Font = New System.Drawing.Font("B Nazanin", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID2.Location = New System.Drawing.Point(6, 29)
        Me.lblID2.Name = "lblID2"
        Me.lblID2.Size = New System.Drawing.Size(0, 16)
        Me.lblID2.TabIndex = 183
        '
        'txtMoshtariName2
        '
        Me.txtMoshtariName2.Enabled = False
        Me.txtMoshtariName2.Location = New System.Drawing.Point(6, 254)
        Me.txtMoshtariName2.Name = "txtMoshtariName2"
        Me.txtMoshtariName2.Size = New System.Drawing.Size(184, 33)
        Me.txtMoshtariName2.TabIndex = 180
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(196, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 19)
        Me.Label8.TabIndex = 179
        Me.Label8.Text = "نام خریدار :"
        '
        'cboGhateNo2
        '
        Me.cboGhateNo2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboGhateNo2.FormattingEnabled = True
        Me.cboGhateNo2.Location = New System.Drawing.Point(6, 175)
        Me.cboGhateNo2.Name = "cboGhateNo2"
        Me.cboGhateNo2.Size = New System.Drawing.Size(184, 34)
        Me.cboGhateNo2.TabIndex = 178
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(196, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "شماره قطعه :"
        '
        'cboMajmooeName2
        '
        Me.cboMajmooeName2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboMajmooeName2.FormattingEnabled = True
        Me.cboMajmooeName2.Location = New System.Drawing.Point(6, 55)
        Me.cboMajmooeName2.Name = "cboMajmooeName2"
        Me.cboMajmooeName2.Size = New System.Drawing.Size(184, 34)
        Me.cboMajmooeName2.TabIndex = 169
        '
        'cboZone2
        '
        Me.cboZone2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboZone2.FormattingEnabled = True
        Me.cboZone2.Location = New System.Drawing.Point(6, 135)
        Me.cboZone2.Name = "cboZone2"
        Me.cboZone2.Size = New System.Drawing.Size(184, 34)
        Me.cboZone2.TabIndex = 171
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(196, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 19)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "نام مجموعه :"
        '
        'cboVahedtype2
        '
        Me.cboVahedtype2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboVahedtype2.FormattingEnabled = True
        Me.cboVahedtype2.Location = New System.Drawing.Point(6, 95)
        Me.cboVahedtype2.Name = "cboVahedtype2"
        Me.cboVahedtype2.Size = New System.Drawing.Size(184, 34)
        Me.cboVahedtype2.TabIndex = 170
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 19)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "منطقه (Zone) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 174
        Me.Label3.Text = "نوع واحد :"
        '
        'btnTransfer
        '
        Me.btnTransfer.Location = New System.Drawing.Point(555, 319)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(75, 34)
        Me.btnTransfer.TabIndex = 177
        Me.btnTransfer.Text = "انتقال"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'lblTmpID
        '
        Me.lblTmpID.AutoSize = True
        Me.lblTmpID.Location = New System.Drawing.Point(14, 323)
        Me.lblTmpID.Name = "lblTmpID"
        Me.lblTmpID.Size = New System.Drawing.Size(69, 19)
        Me.lblTmpID.TabIndex = 178
        Me.lblTmpID.Text = "کد شناسائی"
        '
        'frmChangeGharardad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 362)
        Me.Controls.Add(Me.lblTmpID)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangeGharardad"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "frmChangeGharardad"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboVahedtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboZone As System.Windows.Forms.ComboBox
    Friend WithEvents cboMajmooeName As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboMajmooeName2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboZone2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboVahedtype2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents lblTmpID As System.Windows.Forms.Label
    Friend WithEvents cboGhateNo1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboGhateNo2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMoshtariName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMoshtariName2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblID1 As System.Windows.Forms.Label
    Friend WithEvents lblID2 As System.Windows.Forms.Label
    Friend WithEvents txtGharardadNo1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtGharardadNo2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
