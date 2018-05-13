Public Class frmRegVahedName
    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private VahedNameID As String
    Private CU As New Currency


    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        RefreshText()


    End Sub

    Private Sub FillGrid()
        If Me.cboZone.Text <> String.Empty Then
            Cmd.Connection = SqlCon.SqlCon
            tbl.Clear()
            Dim MID As String = GetMajmooeID(Me.cboMajmooeName.Text)
            Dim VtID As String = GetVahedTypeID(Me.cboVahedtype.Text)

            Try

                Cmd.CommandText = "Select ID as 'ک شناسائی',CodeVahed as 'کد واحد',MetrajZamin as 'متراژ زمین',MetrajBana as 'متراژ بنا',MetrajKol as 'متراژ کل',Tozihat as 'توضیحات' from VahedName where MajmooeID='" & MID & "' And VahedTypeID='" & VtID & "' AND ZoneID='" & GetZoneID(Me.cboZone.Text.ToString, GetMajmooeID(Me.cboMajmooeName.Text)) & "' order by VahedNo desc"


                SqlCon.SqlCon.Open()

                Sdr = Cmd.ExecuteReader
                Dim fc As Integer
                While (Sdr.Read)


                    'populating columns
                    If Not b Then
                        For fc = 0 To Sdr.FieldCount - 1
                            tbl.Columns.Add(Sdr.GetName(fc))
                        Next
                        b = True
                    End If
                    'populating rows
                    Dim row As DataRow = tbl.NewRow

                    For fc = 0 To Sdr.FieldCount - 1
                        row(fc) = Sdr(fc)
                    Next
                    tbl.Rows.Add(row)
                End While
                dvw = New DataView(tbl)
                Me.dbgVahedName.DataSource = dvw


            Catch ex As Exception
                MessageBox.Show(ex.Message.ToCharArray, "خطا در بارگذاری اطلاعات دیتا گیرید", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Finally
                SqlCon.SqlCon.Close()
            End Try

            Me.dbgVahedName.Refresh()

        End If
    End Sub

    Private Sub frmRegVahedName_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        FillCboVahedtype()
        FillCboMajmooe()
        FillCboTabaghe()
        FillCboZel()
        FillCboVaziyateVahed()
    End Sub

    Private Sub dbgVahedName_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dbgVahedName.CellClick
        Try
            VahedNameID = Me.dbgVahedName.CurrentRow.Cells.Item(0).Value.ToString
            FillTextBox(VahedNameID)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub dbgVahedName_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgVahedName.CellMouseClick
        Try
            VahedNameID = Me.dbgVahedName.CurrentRow.Cells.Item(0).Value.ToString
            FillTextBox(VahedNameID)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dbgVahedName_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dbgVahedName.KeyUp, dbgVahedName.KeyDown
        Try
            VahedNameID = Me.dbgVahedName.CurrentRow.Cells.Item(0).Value.ToString
            FillTextBox(VahedNameID)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Cmd.CommandText = "Delete VahedName where Id='" & VahedNameID & "'"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
            RefreshText()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Register()
    End Sub

    Private Sub Register()
        Dim MID As String = GetMajmooeID(Me.cboMajmooeName.Text)
        Dim VtID As String = GetVahedTypeID(Me.cboVahedtype.Text)

        Cmd.CommandText = "insert into VahedName (MajmooeID,VahedTypeID,ZoneID,MetrajZamin,MetrajBana,MetrajTeras,MetrajBalkon,TedadTeras,TedadBalkon,Tabaghe,Zel,VahedNo,Nama,TedadKhab,TedadService,Metrajkol,CodeVahed,Tozihat,Vaziyat) Values ('" & MID & "','" & VtID & "',N'" & GetZoneID(Me.cboZone.Text, GetMajmooeID(Me.cboMajmooeName.Text)) & "','" & Me.txtMetrajZamin.Text & "','" & Me.txtMetrajBana.Text & "','" & Me.txtMetrajTeras.Text & "','" & Me.txtMetrajBalkon.Text & "','" & Me.txtTedadTeras.Value & "','" & Me.txtTedadBalkon.Value & "',N'" & Me.cboTabaghe.Text & "',N'" & Me.cboZel.Text & "',N'" & Me.txtVahedNo.Text & "',N'" & Me.cboView.Text & "','" & Me.txtTedadOtagh.Value & "','" & Me.txtTedadService.Value & "','" & Me.txtMetrajKol.Text & "',N'" & Me.txtVahedCode.Text & "',N'" & Me.txtTozihat.Text & "',N'" & Me.cboVaziyateVahed.Text & "')"
        Cmd.Connection = SqlCon.SqlCon

        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        RefreshText()
        FillGrid()
        Me.txtMetrajZamin.Focus()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim MID As String = GetMajmooeID(Me.cboMajmooeName.Text)
        Try
            Cmd.CommandText = "Update VahedName set MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "',VahedTypeID='" & GetVahedTypeID(Me.cboVahedtype.Text) & "',ZoneID='" & GetZoneID(Me.cboZone.Text, GetMajmooeID(Me.cboMajmooeName.Text)) & "',MetrajZamin='" & Me.txtMetrajZamin.Text & "',MetrajBana='" & Me.txtMetrajBana.Text & "',MetrajTeras='" & Me.txtMetrajTeras.Text & "',MetrajBalkon='" & Me.txtMetrajBalkon.Text & "',TedadTeras='" & Me.txtTedadTeras.Value & "',TedadBalkon='" & Me.txtTedadBalkon.Value & "',Tabaghe=N'" & Me.cboTabaghe.Text & "',Zel=N'" & Me.cboZel.Text & "',VahedNo=N'" & Me.txtVahedNo.Text & "',Nama=N'" & Me.cboView.Text & "',TedadKhab='" & Me.txtTedadOtagh.Value & "',TedadService='" & Me.txtTedadService.Value & "',Metrajkol='" & Me.txtMetrajKol.Text & "',CodeVahed=N'" & Me.txtVahedCode.Text & "',Tozihat=N'" & Me.txtTozihat.Text & "',Vaziyat=N'" & Me.cboVaziyateVahed.Text & "' where Id='" & VahedNameID & "'"
            Cmd.Connection = SqlCon.SqlCon

            SqlCon.SqlCon.Open()

            Cmd.ExecuteNonQuery()
            RefreshText()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
        FillGrid()
    End Sub


    Private Sub FillTextBox(ByVal GID As String)

        If GID = "" Then
            RefreshText()
            Exit Sub
        End If
        Dim SqlConTEXT As New SQL
        Try
            Dim cmd As New SqlClient.SqlCommand("Select MajmooeID,VahedTypeID,ZoneID,MetrajZamin,MetrajBana,MetrajTeras,MetrajBalkon,TedadTeras,TedadBalkon,Tabaghe,Zel,VahedNo,Nama,TedadKhab,TedadService,Metrajkol,CodeVahed,Tozihat,Vaziyat from VahedName Where ID='" & GID & "'", SqlConTEXT.SqlCon)

            SqlConTEXT.SqlCon.Open()
            Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader

            While sdr.Read
                Me.cboMajmooeName.Text = GetMajmooe(sdr(0).ToString)
                Me.cboVahedtype.Text = GetVahedType(sdr(1).ToString)
                Me.cboZone.Text = GetZone(sdr(2).ToString)
                Me.txtMetrajZamin.Text = sdr(3)
                Me.txtMetrajBana.Text = sdr(4)
                Me.txtMetrajTeras.Text = sdr(5)
                Me.txtMetrajBalkon.Text = sdr(6)
                Me.txtTedadTeras.Value = sdr(7)
                Me.txtTedadBalkon.Value = sdr(8)
                Me.cboTabaghe.Text = sdr(9)
                Me.cboZel.Text = sdr(10)
                Me.txtVahedNo.Text = sdr(11)
                Me.cboView.Text = sdr(12)
                Me.txtTedadOtagh.Value = sdr(13)
                Me.txtTedadService.Value = sdr(14)
                Me.txtMetrajKol.Text = sdr(15)
                Me.txtVahedCode.Text = sdr(16)
                Me.txtTozihat.Text = sdr(17)
                Me.cboVaziyateVahed.Text = sdr(18).ToString

            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToCharArray, "خطا در خواندن اطلاعات و بارگذاری آنها", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally

            SqlConTEXT.SqlCon.Close()
        End Try



    End Sub

    Private Sub RefreshText()
        Dim C As Control
        For Each C In Me.Controls
            If TypeOf C Is TextBox AndAlso C.Text <> "" Then
                C.Text = ""
            End If
        Next

        Me.cboTabaghe.Text = String.Empty
        Me.cboZel.Text = String.Empty
        Me.cboView.Text = String.Empty

        For Each C In Me.Controls
            If TypeOf C Is NumericUpDown AndAlso C.Text <> "" Then
                C.Text = 0
            End If
        Next

        Me.txtVahedNo.Text = String.Empty
        Me.cboVaziyateVahed.Text = String.Empty
        ToZiro()
    End Sub
    Private Sub ToZiro()

        Me.txtMetrajZamin.Text = 0
        Me.txtMetrajBana.Text = 0
        Me.txtMetrajTeras.Text = 0
        Me.txtMetrajBalkon.Text = 0
        Me.txtMetrajKol.Text = 0


    End Sub


    Private Sub FillCboTabaghe()
        Me.cboTabaghe.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Tabaghe from Tabaghe Order By Row", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboTabaghe.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub


    Private Sub FillCboVaziyateVahed()
        Me.cboVaziyateVahed.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Vaziyat from VaziyateVahed", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboVaziyateVahed.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub FillCboVahedtype()
        Me.cboVahedtype.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT VahedType from VahedType", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboVahedtype.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub
    Private Sub FillCboZel()
        Me.cboZel.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Zel from Zel", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboZel.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub FillCboMajmooe()
        Me.cboZel.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Majmooe from Majmooe", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboMajmooeName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub
    Private Sub FillCboZone()

        Me.cboZone.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Zone from Zone where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboZone.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()

    End Sub
    Private Sub FillCboView()
        Me.cboView.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Nama from Nama where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboView.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Function GetMajmooeID(ByVal MajmooeName As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Majmooe where Majmooe=N'" & MajmooeName & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function

    Private Function GetMajmooeNameCode(ByVal MajmooeName As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT CodingCodeFA from Majmooe where Majmooe=N'" & MajmooeName & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function
    Private Function GetMajmooe(ByVal ID As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Majmooe from Majmooe where ID=N'" & ID & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function
    Private Function GetZoneCode(ByVal Zone As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT CodingCode from Zone where Zone=N'" & Zone & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function
    Private Function GetVahedTypeCode(ByVal VahedType As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT CodingCode from VahedType where VahedType=N'" & VahedType & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function
    Private Function GetVahedTypeID(ByVal VahedType As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from VahedType where VahedType=N'" & VahedType & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function
    Private Function GetVahedType(ByVal ID As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT VahedType from VahedType where ID=N'" & ID & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function

    Private Function GetSum()
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Count (*) from VahedName where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "' AND VahedTypeID='" & GetVahedTypeID(Me.cboVahedtype.Text) & "' AND ZoneID=N'" & GetZoneID(Me.cboZone.Text.ToString, GetMajmooeID(Me.cboMajmooeName.Text)) & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function

    Private Sub GetMetrajKol()
        Me.txtMetrajKol.Text = (Integer.Parse(Me.txtMetrajBana.Text) + Integer.Parse(Me.txtMetrajTeras.Text) + Integer.Parse(Me.txtMetrajBalkon.Text)).ToString
        Me.txtVahedCode.Focus()
    End Sub

    Private Sub txtMetrajKol_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMetrajKol.GotFocus
        GetMetrajKol()
    End Sub

    Private Sub BtnGetCode()
        Try
            If Me.cboMajmooeName.Text <> String.Empty And Me.cboVahedtype.Text <> String.Empty Then
                Me.txtVahedCode.Enabled = True
                FillCboZone()
                FillGrid()
            Else
                Me.cboZone.Items.Clear()
                Me.txtVahedCode.Enabled = False
            End If
        Catch ex As Exception

        End Try
      
    End Sub

    Private Sub cboMajmooeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajmooeName.SelectedIndexChanged
        BtnGetCode()
        If Me.cboMajmooeName.Text <> String.Empty Then
            FillCboView()
        End If


    End Sub

    Private Sub cboVahedtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVahedtype.SelectedIndexChanged
        BtnGetCode()

    End Sub

    Private Sub txtVahedCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVahedCode.GotFocus
        MakeCode()
    End Sub

    Private Sub MakeCode()

        GetMetrajKol()

        'Dim Z As String = String.Empty
        'Select Case Integer.Parse(Me.txtMetrajZamin.Text)
        '    Case Is <= 50
        '        Z = "A"
        '    Case Is <= 100
        '        Z = "B"
        '    Case Is <= 150
        '        Z = "C"
        '    Case Is <= 200
        '        Z = "D"
        '    Case Is <= 250
        '        Z = "E"
        '    Case Is <= 300
        '        Z = "F"
        '    Case Is <= 350
        '        Z = "G"
        '    Case Is <= 400
        '        Z = "H"
        '    Case Is <= 450
        '        Z = "I"
        '    Case Is <= 500
        '        Z = "J"
        '    Case Is <= 550
        '        Z = "K"
        '    Case Is <= 600
        '        Z = "L"
        '    Case Is <= 650
        '        Z = "M"
        '    Case Is <= 700
        '        Z = "N"
        '    Case Is <= 750
        '        Z = "O"
        '    Case Is <= 800
        '        Z = "P"
        '    Case Is <= 850
        '        Z = "Q"
        '    Case Is <= 900
        '        Z = "R"
        '    Case Is <= 950
        '        Z = "S"
        '    Case Is <= 1000
        '        Z = "T"
        '    Case Is <= 1050
        '        Z = "U"
        '    Case Is <= 1100
        '        Z = "V"
        '    Case Is <= 1150
        '        Z = "W"
        '    Case Is <= 1200
        '        Z = "X"
        '    Case Is <= 1250
        '        Z = "Y"
        '    Case Is <= 1300
        '        Z = "Z"
        '    Case Is > 1301
        '        Z = "ٍٍOut of range"
        'End Select


        'Me.txtVahedCode.Text = GetMajmooeNameCode(Me.cboMajmooeName.Text) & "/" & GetVahedTypeCode(Me.cboVahedtype.Text) & Z & "/" & GetZoneCode(Me.cboZone.Text) & "-" & Me.txtVahedNo.Text
        Me.txtVahedCode.Text = GetMajmooeNameCode(Me.cboMajmooeName.Text) & "/" & GetVahedTypeCode(Me.cboVahedtype.Text) & "/" & GetZoneCode(Me.cboZone.Text) & "-" & Me.txtVahedNo.Text
        Me.txtTozihat.Focus()
    End Sub

    Private Sub cboZone_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboZone.SelectedIndexChanged
        FillGrid()
    End Sub

    Private Function GetZoneID(ByVal Zone As String, ByVal MajmooeID As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Zone where Zone=N'" & Zone & "' AND MajmooeID='" & MajmooeID & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function

    Private Function GetZone(ByVal ID As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Zone from Zone where ID='" & ID & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            V = sdr2(0).ToString
        End While
        SQLCONection.SqlCon.Close()
        Return V
    End Function
   


    Private Sub btnRegWithCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegWithCount.Click
        Dim Temp(3) As String
        Temp(0) = Me.txtVahedNo.Text
        Temp(1) = Me.cboVaziyateVahed.Text
        Temp(2) = Me.txtMetrajZamin.Text
        For I As Integer = 1 To Integer.Parse(Me.txtCount.Text)
            Me.txtVahedNo.Text = Temp(0)
            Me.cboVaziyateVahed.Text = Temp(1)
            Me.txtMetrajZamin.Text = Temp(2)
            MakeCode()
            Register()
            Temp(0) = Integer.Parse(Temp(0)) + 1
        Next

    End Sub

End Class