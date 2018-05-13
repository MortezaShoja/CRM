<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegVahedName
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegVahedName))
        Me.cboMajmooeName = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dbgVahedName = New System.Windows.Forms.DataGridView
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnReg = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtVahedCode = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtMetrajKol = New System.Windows.Forms.TextBox
        Me.txtMetrajTeras = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtTozihat = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cboTabaghe = New System.Windows.Forms.ComboBox
        Me.cboZel = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtTedadOtagh = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMetrajZamin = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMetrajBana = New System.Windows.Forms.TextBox
        Me.txtTedadTeras = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMetrajBalkon = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTedadBalkon = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTedadService = New System.Windows.Forms.NumericUpDown
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboVahedtype = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtVahedNo = New System.Windows.Forms.TextBox
        Me.cboZone = New System.Windows.Forms.ComboBox
        Me.cboView = New System.Windows.Forms.ComboBox
        Me.cboVaziyateVahed = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.btnRegWithCount = New System.Windows.Forms.Button
        Me.txtCount = New System.Windows.Forms.TextBox
        CType(Me.dbgVahedName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTedadOtagh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTedadTeras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTedadBalkon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTedadService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboMajmooeName
        '
        Me.cboMajmooeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboMajmooeName.FormattingEnabled = True
        Me.cboMajmooeName.Location = New System.Drawing.Point(115, 12)
        Me.cboMajmooeName.Name = "cboMajmooeName"
        Me.cboMajmooeName.Size = New System.Drawing.Size(154, 34)
        Me.cboMajmooeName.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 26)
        Me.Label4.TabIndex = 98
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
        Me.dbgVahedName.Location = New System.Drawing.Point(12, 287)
        Me.dbgVahedName.MultiSelect = False
        Me.dbgVahedName.Name = "dbgVahedName"
        Me.dbgVahedName.Size = New System.Drawing.Size(889, 142)
        Me.dbgVahedName.TabIndex = 25
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(540, 435)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 38)
        Me.btnUpdate.TabIndex = 23
        Me.btnUpdate.Text = "تغییرات"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(459, 435)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 38)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(378, 435)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(75, 38)
        Me.btnReg.TabIndex = 21
        Me.btnReg.Text = "ثبت"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(297, 435)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 38)
        Me.btnNew.TabIndex = 22
        Me.btnNew.Text = "جدید"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(678, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 26)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "کد واحد :"
        '
        'txtVahedCode
        '
        Me.txtVahedCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVahedCode.Enabled = False
        Me.txtVahedCode.Location = New System.Drawing.Point(747, 129)
        Me.txtVahedCode.Name = "txtVahedCode"
        Me.txtVahedCode.ReadOnly = True
        Me.txtVahedCode.Size = New System.Drawing.Size(154, 33)
        Me.txtVahedCode.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 26)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "شماره واحد :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(604, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 26)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "متراژ واحد (متر مربع) :"
        '
        'txtMetrajKol
        '
        Me.txtMetrajKol.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMetrajKol.Location = New System.Drawing.Point(747, 91)
        Me.txtMetrajKol.Name = "txtMetrajKol"
        Me.txtMetrajKol.Size = New System.Drawing.Size(154, 33)
        Me.txtMetrajKol.TabIndex = 16
        Me.txtMetrajKol.Text = "0"
        '
        'txtMetrajTeras
        '
        Me.txtMetrajTeras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMetrajTeras.Location = New System.Drawing.Point(418, 7)
        Me.txtMetrajTeras.Name = "txtMetrajTeras"
        Me.txtMetrajTeras.Size = New System.Drawing.Size(154, 33)
        Me.txtMetrajTeras.TabIndex = 7
        Me.txtMetrajTeras.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(635, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 26)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "تعداد اطاق خواب:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(366, 166)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 26)
        Me.Label18.TabIndex = 130
        Me.Label18.Text = "طبقه :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(669, 171)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 26)
        Me.Label19.TabIndex = 132
        Me.Label19.Text = "توضیحات :"
        '
        'txtTozihat
        '
        Me.txtTozihat.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTozihat.ForeColor = System.Drawing.Color.White
        Me.txtTozihat.Location = New System.Drawing.Point(747, 166)
        Me.txtTozihat.Multiline = True
        Me.txtTozihat.Name = "txtTozihat"
        Me.txtTozihat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTozihat.Size = New System.Drawing.Size(154, 113)
        Me.txtTozihat.TabIndex = 20
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(369, 205)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 26)
        Me.Label20.TabIndex = 134
        Me.Label20.Text = "ضلع :"
        '
        'cboTabaghe
        '
        Me.cboTabaghe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboTabaghe.FormattingEnabled = True
        Me.cboTabaghe.Location = New System.Drawing.Point(418, 163)
        Me.cboTabaghe.Name = "cboTabaghe"
        Me.cboTabaghe.Size = New System.Drawing.Size(154, 34)
        Me.cboTabaghe.TabIndex = 11
        '
        'cboZel
        '
        Me.cboZel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboZel.FormattingEnabled = True
        Me.cboZel.Location = New System.Drawing.Point(418, 203)
        Me.cboZel.Name = "cboZel"
        Me.cboZel.Size = New System.Drawing.Size(154, 34)
        Me.cboZel.TabIndex = 12
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(323, 247)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(89, 26)
        Me.Label21.TabIndex = 136
        Me.Label21.Text = "نما (View) :"
        '
        'txtTedadOtagh
        '
        Me.txtTedadOtagh.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTedadOtagh.Location = New System.Drawing.Point(748, 13)
        Me.txtTedadOtagh.Name = "txtTedadOtagh"
        Me.txtTedadOtagh.Size = New System.Drawing.Size(154, 33)
        Me.txtTedadOtagh.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 26)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "متراژ زمین :"
        '
        'txtMetrajZamin
        '
        Me.txtMetrajZamin.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMetrajZamin.Location = New System.Drawing.Point(115, 209)
        Me.txtMetrajZamin.Name = "txtMetrajZamin"
        Me.txtMetrajZamin.Size = New System.Drawing.Size(154, 33)
        Me.txtMetrajZamin.TabIndex = 5
        Me.txtMetrajZamin.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 26)
        Me.Label2.TabIndex = 142
        Me.Label2.Text = "متراژ بنا :"
        '
        'txtMetrajBana
        '
        Me.txtMetrajBana.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMetrajBana.Location = New System.Drawing.Point(115, 248)
        Me.txtMetrajBana.Name = "txtMetrajBana"
        Me.txtMetrajBana.Size = New System.Drawing.Size(154, 33)
        Me.txtMetrajBana.TabIndex = 6
        Me.txtMetrajBana.Text = "0"
        '
        'txtTedadTeras
        '
        Me.txtTedadTeras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTedadTeras.Location = New System.Drawing.Point(418, 85)
        Me.txtTedadTeras.Name = "txtTedadTeras"
        Me.txtTedadTeras.Size = New System.Drawing.Size(154, 33)
        Me.txtTedadTeras.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(333, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 26)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "تعداد تراس :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(333, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 26)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "متراژ بالکن :"
        '
        'txtMetrajBalkon
        '
        Me.txtMetrajBalkon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMetrajBalkon.Location = New System.Drawing.Point(418, 46)
        Me.txtMetrajBalkon.Name = "txtMetrajBalkon"
        Me.txtMetrajBalkon.Size = New System.Drawing.Size(154, 33)
        Me.txtMetrajBalkon.TabIndex = 8
        Me.txtMetrajBalkon.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(334, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 26)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "متراژ تراس :"
        '
        'txtTedadBalkon
        '
        Me.txtTedadBalkon.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTedadBalkon.Location = New System.Drawing.Point(418, 124)
        Me.txtTedadBalkon.Name = "txtTedadBalkon"
        Me.txtTedadBalkon.Size = New System.Drawing.Size(154, 33)
        Me.txtTedadBalkon.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(332, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 26)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "تعداد بالکن :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(-2, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(111, 26)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "منطقه (Zone) :"
        '
        'txtTedadService
        '
        Me.txtTedadService.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTedadService.Location = New System.Drawing.Point(748, 52)
        Me.txtTedadService.Name = "txtTedadService"
        Me.txtTedadService.Size = New System.Drawing.Size(154, 33)
        Me.txtTedadService.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(649, 54)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 26)
        Me.Label13.TabIndex = 154
        Me.Label13.Text = "تعداد سرویس :"
        '
        'cboVahedtype
        '
        Me.cboVahedtype.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboVahedtype.FormattingEnabled = True
        Me.cboVahedtype.Location = New System.Drawing.Point(115, 52)
        Me.cboVahedtype.Name = "cboVahedtype"
        Me.cboVahedtype.Size = New System.Drawing.Size(154, 34)
        Me.cboVahedtype.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(42, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 26)
        Me.Label14.TabIndex = 156
        Me.Label14.Text = "نوع واحد :"
        '
        'txtVahedNo
        '
        Me.txtVahedNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtVahedNo.Location = New System.Drawing.Point(115, 131)
        Me.txtVahedNo.Name = "txtVahedNo"
        Me.txtVahedNo.Size = New System.Drawing.Size(154, 33)
        Me.txtVahedNo.TabIndex = 3
        '
        'cboZone
        '
        Me.cboZone.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboZone.FormattingEnabled = True
        Me.cboZone.Location = New System.Drawing.Point(115, 91)
        Me.cboZone.Name = "cboZone"
        Me.cboZone.Size = New System.Drawing.Size(154, 34)
        Me.cboZone.TabIndex = 2
        '
        'cboView
        '
        Me.cboView.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboView.FormattingEnabled = True
        Me.cboView.Location = New System.Drawing.Point(418, 243)
        Me.cboView.Name = "cboView"
        Me.cboView.Size = New System.Drawing.Size(154, 34)
        Me.cboView.TabIndex = 13
        '
        'cboVaziyateVahed
        '
        Me.cboVaziyateVahed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cboVaziyateVahed.FormattingEnabled = True
        Me.cboVaziyateVahed.Location = New System.Drawing.Point(115, 168)
        Me.cboVaziyateVahed.Name = "cboVaziyateVahed"
        Me.cboVaziyateVahed.Size = New System.Drawing.Size(154, 34)
        Me.cboVaziyateVahed.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 171)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 26)
        Me.Label15.TabIndex = 158
        Me.Label15.Text = "وضعیت واحد :"
        '
        'btnRegWithCount
        '
        Me.btnRegWithCount.Location = New System.Drawing.Point(12, 435)
        Me.btnRegWithCount.Name = "btnRegWithCount"
        Me.btnRegWithCount.Size = New System.Drawing.Size(97, 38)
        Me.btnRegWithCount.TabIndex = 159
        Me.btnRegWithCount.Text = "ثبت با تعداد"
        Me.btnRegWithCount.UseVisualStyleBackColor = True
        '
        'txtCount
        '
        Me.txtCount.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCount.Location = New System.Drawing.Point(115, 440)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(44, 33)
        Me.txtCount.TabIndex = 160
        Me.txtCount.Text = "0"
        '
        'frmRegVahedName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 481)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.btnRegWithCount)
        Me.Controls.Add(Me.cboVaziyateVahed)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.cboView)
        Me.Controls.Add(Me.cboZone)
        Me.Controls.Add(Me.txtVahedNo)
        Me.Controls.Add(Me.cboVahedtype)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtTedadService)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtTedadBalkon)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMetrajBalkon)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTedadTeras)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMetrajBana)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMetrajZamin)
        Me.Controls.Add(Me.txtVahedCode)
        Me.Controls.Add(Me.txtTedadOtagh)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cboZel)
        Me.Controls.Add(Me.cboTabaghe)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtTozihat)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtMetrajTeras)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtMetrajKol)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboMajmooeName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dbgVahedName)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.btnNew)
        Me.Font = New System.Drawing.Font("B Nazanin", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRegVahedName"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.Text = "فرم ثبت نام واحد :::..."
        CType(Me.dbgVahedName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTedadOtagh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTedadTeras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTedadBalkon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTedadService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMajmooeName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dbgVahedName As System.Windows.Forms.DataGridView
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtVahedCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMetrajKol As System.Windows.Forms.TextBox
    Friend WithEvents txtMetrajTeras As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtTozihat As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cboTabaghe As System.Windows.Forms.ComboBox
    Friend WithEvents cboZel As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtTedadOtagh As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMetrajZamin As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMetrajBana As System.Windows.Forms.TextBox
    Friend WithEvents txtTedadTeras As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMetrajBalkon As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTedadBalkon As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTedadService As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboVahedtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtVahedNo As System.Windows.Forms.TextBox
    Friend WithEvents cboZone As System.Windows.Forms.ComboBox
    Friend WithEvents cboView As System.Windows.Forms.ComboBox
    Friend WithEvents cboVaziyateVahed As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnRegWithCount As System.Windows.Forms.Button
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
End Class
