<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSendSMS
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
        Me.cboMajmooeName = New System.Windows.Forms.ComboBox
        Me.cboZone = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtLname = New System.Windows.Forms.TextBox
        Me.chkSallerList = New System.Windows.Forms.CheckedListBox
        Me.txtMessageText = New System.Windows.Forms.TextBox
        Me.btnSendMessages = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSampleNumber = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cboMajmooeName
        '
        Me.cboMajmooeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboMajmooeName.FormattingEnabled = True
        Me.cboMajmooeName.Location = New System.Drawing.Point(100, 51)
        Me.cboMajmooeName.Name = "cboMajmooeName"
        Me.cboMajmooeName.Size = New System.Drawing.Size(130, 34)
        Me.cboMajmooeName.TabIndex = 204
        '
        'cboZone
        '
        Me.cboZone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Location = New System.Drawing.Point(330, 51)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(130, 34)
        Me.cboZone.TabIndex = 205
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 26)
        Me.Label2.TabIndex = 206
        Me.Label2.Text = "نام مجموعه :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(290, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 26)
        Me.Label11.TabIndex = 207
        Me.Label11.Text = "فاز :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(100, 12)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(130, 33)
        Me.txtName.TabIndex = 196
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(236, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 26)
        Me.Label1.TabIndex = 198
        Me.Label1.Text = "نام خانوادگی :"
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(330, 12)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(130, 33)
        Me.txtLname.TabIndex = 197
        '
        'chkSallerList
        '
        Me.chkSallerList.FormattingEnabled = True
        Me.chkSallerList.Location = New System.Drawing.Point(17, 119)
        Me.chkSallerList.Name = "chkSallerList"
        Me.chkSallerList.Size = New System.Drawing.Size(307, 172)
        Me.chkSallerList.TabIndex = 208
        '
        'txtMessageText
        '
        Me.txtMessageText.Location = New System.Drawing.Point(330, 91)
        Me.txtMessageText.Multiline = True
        Me.txtMessageText.Name = "txtMessageText"
        Me.txtMessageText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMessageText.Size = New System.Drawing.Size(360, 200)
        Me.txtMessageText.TabIndex = 209
        '
        'btnSendMessages
        '
        Me.btnSendMessages.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.btnSendMessages.Location = New System.Drawing.Point(328, 297)
        Me.btnSendMessages.Name = "btnSendMessages"
        Me.btnSendMessages.Size = New System.Drawing.Size(360, 33)
        Me.btnSendMessages.TabIndex = 210
        Me.btnSendMessages.Text = "ارسال پیامک"
        Me.btnSendMessages.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSendMessages.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(466, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 26)
        Me.Label8.TabIndex = 212
        Me.Label8.Text = "شماره تماس :"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(558, 12)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(130, 33)
        Me.txtPhone.TabIndex = 211
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(558, 52)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(130, 33)
        Me.btnSearch.TabIndex = 213
        Me.btnSearch.Text = "جستجو"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(17, 83)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(145, 30)
        Me.CheckBox1.TabIndex = 214
        Me.CheckBox1.Text = "انتخاب کل مشترکین"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 26)
        Me.Label3.TabIndex = 215
        Me.Label3.Text = "نام :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 26)
        Me.Label4.TabIndex = 217
        Me.Label4.Text = "شماره آزمایشی :"
        '
        'txtSampleNumber
        '
        Me.txtSampleNumber.Location = New System.Drawing.Point(121, 297)
        Me.txtSampleNumber.Name = "txtSampleNumber"
        Me.txtSampleNumber.Size = New System.Drawing.Size(201, 33)
        Me.txtSampleNumber.TabIndex = 216
        Me.txtSampleNumber.Text = "09193091961"
        '
        'frmSendSMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 338)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSampleNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.btnSendMessages)
        Me.Controls.Add(Me.txtMessageText)
        Me.Controls.Add(Me.chkSallerList)
        Me.Controls.Add(Me.cboMajmooeName)
        Me.Controls.Add(Me.cboZone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLname)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSendSMS"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "frmSendSMS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMajmooeName As System.Windows.Forms.ComboBox
    Friend WithEvents cboZone As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents chkSallerList As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtMessageText As System.Windows.Forms.TextBox
    Friend WithEvents btnSendMessages As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSampleNumber As System.Windows.Forms.TextBox
End Class
