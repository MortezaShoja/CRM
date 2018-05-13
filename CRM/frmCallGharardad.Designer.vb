<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCallGharardad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCallGharardad))
        Me.dbgView = New System.Windows.Forms.DataGridView
        Me.txtLname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDate2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDate1 = New System.Windows.Forms.TextBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtSerial = New System.Windows.Forms.TextBox
        Me.cboMajmooeName = New System.Windows.Forms.ComboBox
        Me.cboZone = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTozihat = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtHeadGroupName = New System.Windows.Forms.TextBox
        Me.btnPrint = New System.Windows.Forms.Button
        CType(Me.dbgView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dbgView
        '
        Me.dbgView.AllowUserToAddRows = False
        Me.dbgView.AllowUserToDeleteRows = False
        Me.dbgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dbgView.Location = New System.Drawing.Point(16, 166)
        Me.dbgView.Name = "dbgView"
        Me.dbgView.ReadOnly = True
        Me.dbgView.Size = New System.Drawing.Size(814, 231)
        Me.dbgView.TabIndex = 12
        '
        'txtLname
        '
        Me.txtLname.Location = New System.Drawing.Point(319, 10)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(130, 33)
        Me.txtLname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(225, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "نام خانوادگی :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(253, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "تا تاریخ :"
        '
        'txtDate2
        '
        Me.txtDate2.Location = New System.Drawing.Point(319, 50)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.Size = New System.Drawing.Size(130, 33)
        Me.txtDate2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "از تاریخ :"
        '
        'txtDate1
        '
        Me.txtDate1.Location = New System.Drawing.Point(89, 49)
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.Size = New System.Drawing.Size(130, 33)
        Me.txtDate1.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(700, 88)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(130, 72)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "جستجو"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 26)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "نام :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(89, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(130, 33)
        Me.txtName.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(472, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 26)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "شماره تماس :"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(564, 10)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(130, 33)
        Me.txtPhone.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(475, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 26)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "شماره اوراق :"
        '
        'txtSerial
        '
        Me.txtSerial.Location = New System.Drawing.Point(564, 49)
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(130, 33)
        Me.txtSerial.TabIndex = 5
        '
        'cboMajmooeName
        '
        Me.cboMajmooeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboMajmooeName.FormattingEnabled = True
        Me.cboMajmooeName.Location = New System.Drawing.Point(89, 89)
        Me.cboMajmooeName.Name = "cboMajmooeName"
        Me.cboMajmooeName.Size = New System.Drawing.Size(130, 34)
        Me.cboMajmooeName.TabIndex = 6
        '
        'cboZone
        '
        Me.cboZone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Location = New System.Drawing.Point(319, 89)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(130, 34)
        Me.cboZone.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 26)
        Me.Label2.TabIndex = 194
        Me.Label2.Text = "نام مجموعه :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(279, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 26)
        Me.Label11.TabIndex = 195
        Me.Label11.Text = "فاز :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 26)
        Me.Label6.TabIndex = 197
        Me.Label6.Text = "توضیحات :"
        '
        'txtTozihat
        '
        Me.txtTozihat.Location = New System.Drawing.Point(89, 127)
        Me.txtTozihat.Name = "txtTozihat"
        Me.txtTozihat.Size = New System.Drawing.Size(605, 33)
        Me.txtTozihat.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(479, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 26)
        Me.Label7.TabIndex = 199
        Me.Label7.Text = "نام سرگروه :"
        '
        'txtHeadGroupName
        '
        Me.txtHeadGroupName.Location = New System.Drawing.Point(564, 88)
        Me.txtHeadGroupName.Name = "txtHeadGroupName"
        Me.txtHeadGroupName.Size = New System.Drawing.Size(130, 33)
        Me.txtHeadGroupName.TabIndex = 8
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(700, 10)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(130, 72)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "چاپ لیست قطعات"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'frmCallGharardad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 412)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtHeadGroupName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTozihat)
        Me.Controls.Add(Me.cboMajmooeName)
        Me.Controls.Add(Me.cboZone)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDate2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDate1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.dbgView)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCallGharardad"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "فرم نمایش قراردادها :::..."
        CType(Me.dbgView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dbgView As System.Windows.Forms.DataGridView
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDate2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDate1 As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents cboMajmooeName As System.Windows.Forms.ComboBox
    Friend WithEvents cboZone As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTozihat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHeadGroupName As System.Windows.Forms.TextBox
    Friend WithEvents btnPrint As System.Windows.Forms.Button
End Class
