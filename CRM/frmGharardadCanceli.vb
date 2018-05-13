Public Class frmGharardadCanceli


    Private SallerNameID As String
    Private OfficeNameID As String
    Private Cu As New Currency
    Private Ml As New MelliCode
    Private Prn As New PrintGharardad
    Private Dc As New DateConvertor
    Private GetSumCanceli As New GetSumCanceli

    Private GharardadNameID As String
    Private CG As CodeGenerator
    Private AC As AsnadCounter

    Public GharardadID As String
    Public MajmooeName As String
    Public Zone As String
    Public ParvandeNo As String
    Private NtoW As NumberToWord
    Private GS As GetSumCanceli



    Private Sub frmRegGharardadNo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        FillCboOfficeName()
        FillCboNoeVekalat()
        FillCboHeadGroup()
        RefreshText()

        Dc.Convertor()
        Me.txtRegDate.Text = Dc.Hyear + "/" + Dc.Hmonth + "/" + Dc.Hday & " " & Dc.HweekDay

    End Sub

    Private Sub frmRegGharardad_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        CG = New CodeGenerator
        Me.txtMajmooeName.Text = MajmooeName
        'Me.txtGharardadNo.Text = CG.GenerateGharadadNo(MajmooeName, Zone)

        FillCoGrid()

        If GharardadID <> String.Empty Then
            FillTextBox(GharardadID)
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UnLockedText()
        RefreshText()
        'Me.btnReg.Enabled = True
        Me.txtRegDate.Enabled = False
        Me.txtMajmooeName.Enabled = False
        GharardadID = Guid.NewGuid.ToString
    End Sub

    Private Sub FillCboHeadGroup()

        Dim SqlCon As New SQL
        Me.cboHeadGroup.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT HeadGroup from GharardadDel Group By HeadGroup Order by HeadGroup", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboHeadGroup.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub GetHeadGroupName()
        If Me.cboHeadGroup.Text = "" Or Me.cboHeadGroup.Text = " " Then
            Me.cboHeadGroup.Text = Me.cboGenderHagh.Text & " " & Me.txtHaghName.Text & " " & Me.txtHaghLname.Text
        End If
    End Sub

    Private Sub txtHaghName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHaghName.TextChanged, txtHaghLname.TextChanged
        GetHeadGroupName()
    End Sub

    Private Sub FillGridMemberGroups()
        Dim SqlCon As New SQL
        Dim Cmd As New SqlClient.SqlCommand
        Dim Sdr As SqlClient.SqlDataReader
        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean


        Cmd = New SqlClient.SqlCommand
        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()
        tbl.Columns.Clear()
        b = False
        Try
            'Cmd.CommandText = "Select Row_Number() Over(Order by G.MajmooeName,Z.Zone,G.VahedCode) as 'ردیف',G.[Name]+' '+G.LName as 'نام و نام خانوادگی',M.Majmooe as 'محل پروژه',Z.Zone as 'فاز فروش',G.VahedCode as 'شماره قطعه',G.Gharardadno as 'شماره قرارداد',O.OfficeName as 'واحد فروش',S.SallerName as 'نام مشاور',G.VahedNoID as 'کد شناسائی' from GharardadDel G Inner Join VahedName V On G.VahedNoID=V.ID Inner Join Zone Z On Z.ID=V.ZoneID Inner join Majmooe M on M.ID=G.MajmooeName inner join OfficeName O on O.ID=G.OfficeNameid Inner Join SallerName S On S.ID=G.SallerNameID left Join Bank B On V.ID=B.ID  Where G.HeadGroup=N'" & Me.cboHeadGroup.Text & "' Group by G.HeadGroup,G.[Name],G.LName,M.Majmooe,Z.Zone,G.VahedCode,G.Gharardadno,O.OfficeName,S.SallerName,G.VahedNoID,G.MajmooeName Order By G.MajmooeName,Z.Zone,G.VahedCode"
            Cmd.CommandText = "Select Row_Number() Over(Order by G.MajmooeName,G.VahedCode) as 'ردیف',G.[Name]+' '+G.LName as 'نام و نام خانوادگی',M.Majmooe as 'محل پروژه',G.VahedCode as 'شماره قطعه',G.Gharardadno as 'شماره قرارداد',O.OfficeName as 'واحد فروش',S.SallerName as 'نام مشاور',G.VahedNoID as 'کد شناسائی' from GharardadDel G Inner Join Majmooe M on M.ID=G.MajmooeName inner join OfficeName O on O.ID=G.OfficeNameid Inner Join SallerName S On S.ID=G.SallerNameID left Join GharardadDelBank B On G.VahedNoID=B.ID Where G.HeadGroup=N'" & Me.cboHeadGroup.Text & "' Group by G.HeadGroup,G.[Name],G.LName,M.Majmooe,G.VahedCode,G.Gharardadno,O.OfficeName,S.SallerName,G.VahedNoID,G.MajmooeName Order By G.MajmooeName,G.VahedCode"

            SqlCon.SqlCon.Open()
            Sdr = Cmd.ExecuteReader
            Dim fc As Integer = 0
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
            Me.dbgMemberGroups.DataSource = dvw

            '-------------------------

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا در خواندن اطلاعات سرگروه ها", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try

        Me.dbgMemberGroups.Refresh()

    End Sub

    Private Sub FillCboNoeVekalat()

        Dim SqlCon As New SQL
        Me.cbonoeVekalat.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT NoeVekalat from NoeVekalat", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cbonoeVekalat.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub
    Private Sub FillCboOfficeName()
        Dim SqlCon As New SQL
        Me.cboOfficeName.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT OfficeName from OfficeName", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboOfficeName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub FillCboSaller()
        Dim SqlCon As New SQL
        Me.cboSallerName.Items.Clear()
        Dim OfficeID As String = String.Empty
        '---------------------- Get Office ID -----------------------
        Dim cmdOfficeID As New SqlClient.SqlCommand("SELECT ID from OfficeName where OfficeName=N'" & Me.cboOfficeName.Text & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdrOfficeID As SqlClient.SqlDataReader = cmdOfficeID.ExecuteReader

        While sdrOfficeID.Read
            OfficeID = (sdrOfficeID(0).ToString)
        End While
        SqlCon.SqlCon.Close()
        '-----------------------------------------------

        '-------------- Fill Cbo Box ----------------------
        Dim SqlCon2 As New SQL
        Dim cmd2 As New SqlClient.SqlCommand("SELECT SallerName from SallerName where OfficeID='" & OfficeID & "'", SqlCon2.SqlCon)
        SqlCon2.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader

        While sdr2.Read
            Me.cboSallerName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon2.SqlCon.Close()
    End Sub

    Private Sub cboOfficeName_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOfficeName.SelectedIndexChanged
        Try
            OfficeNameID = GetOfficeNameID(Me.cboOfficeName.Text)
        Catch ex As Exception
            OfficeNameID = String.Empty
        End Try

        FillCboSaller()
    End Sub

    Private Sub btnRegPisSHarayet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegPisSHarayet.Click
        CboSelector(Me.cboNoePishPardakht, Cu.DeCodeNumber(Me.txtPishpardakht.Text), "پیش پرداخت", True)
        FilldbgAllPardakht()
    End Sub

    Private Sub btnMandeSharayet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegMandeSharayet.Click
        CboSelector(Me.cboNoeAghsat, Cu.DeCodeNumber(Me.txtAghsat.Text), "اقساط", False)
        FilldbgAllPardakht()
    End Sub

    Private Sub txtGharardadPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGharardadPrice.GotFocus
        Try
            Dim TmpPrice As String = Me.txtGharardadPrice.Text.Replace(",", "")
            TmpPrice = TmpPrice.Replace("ریال", "")
            If IsNumeric(TmpPrice) = True Then
                Me.txtGharardadPrice.Text = Cu.DeCodeNumber(Me.txtGharardadPrice.Text)
            End If
        Catch ex As Exception
            Me.txtGharardadPrice.Focus()
        End Try
    End Sub

    Private Sub txtGharardadPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGharardadPrice.LostFocus

        Try
            Me.txtGharardadPrice.Text = Cu.CodeNumber(Me.txtGharardadPrice.Text)
        Catch ex As Exception
            Me.txtGharardadPrice.Focus()
        End Try

    End Sub

    Private Sub txtTakhfif_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTakhfif.GotFocus

        Try
            Dim TmpPrice As String = Me.txtTakhfif.Text.Replace(",", "")
            TmpPrice = TmpPrice.Replace("ریال", "")
            If IsNumeric(TmpPrice) = True Then
                Me.txtTakhfif.Text = Cu.DeCodeNumber(Me.txtTakhfif.Text)
            End If
        Catch ex As Exception
            Me.txtTakhfif.Focus()
        End Try

    End Sub

    Private Sub txtTakhfif_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTakhfif.LostFocus

        Dim Takhf() As String = Me.txtTakhfif.Text.ToString.Split("%")

        If Takhf.Length = 1 And IsNumeric(Takhf(0)) = True Then
            Try
                Dim CN As String = Cu.CodeNumber(Me.txtTakhfif.Text)
                Me.txtTakhfif.Text = CN
            Catch ex As Exception
                Me.txtTakhfif.Focus()
            End Try
        End If

    End Sub

    Private Sub txtPishpardakht_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPishpardakht.GotFocus
        Try
            Dim Tmp As String = Me.txtPishpardakht.Text.Replace(",", "")
            Tmp = Tmp.Replace("ریال", "")
            If IsNumeric(Tmp) = True Then
                Me.txtPishpardakht.Text = Cu.DeCodeNumber(Me.txtPishpardakht.Text)
            End If
        Catch ex As Exception
            Me.txtPishpardakht.Focus()
        End Try

    End Sub

    Private Sub txtPishpardakht_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPishpardakht.LostFocus
        Try
            Me.txtPishpardakht.Text = Cu.CodeNumber(Me.txtPishpardakht.Text)
        Catch ex As Exception
            Me.txtPishpardakht.Focus()
        End Try
    End Sub

    Private Sub txtAghsat_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAghsat.GotFocus
        Try
            Dim Tmp As String = Me.txtAghsat.Text.Replace(",", "")
            Tmp = Tmp.Replace("ریال", "")
            If IsNumeric(Tmp) = True Then
                Me.txtAghsat.Text = Cu.DeCodeNumber(Me.txtAghsat.Text)
            End If
        Catch ex As Exception
            Me.txtAghsat.Focus()
        End Try
    End Sub

    Private Sub txtAghsat_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAghsat.LostFocus

        Try
            Me.txtAghsat.Text = Cu.CodeNumber(Me.txtAghsat.Text)
        Catch ex As Exception
            Me.txtAghsat.Focus()
        End Try

    End Sub

    Private Sub txtMelliCode_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHaghMelliCode.GotFocus
        Try
            Me.txtHaghMelliCode.Text = Ml.DeCodeMelliCode(Me.txtHaghMelliCode.Text)
        Catch ex As Exception
            Me.txtHaghMelliCode.Focus()
        End Try

    End Sub


    Private Sub txtMelliCode_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHaghMelliCode.LostFocus
        Try
            Me.txtHaghMelliCode.Text = Ml.CodeMelliCode(Me.txtHaghMelliCode.Text)
        Catch ex As Exception
            Me.txtHaghMelliCode.Focus()
        End Try

    End Sub

    Private Sub txtRegDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRegDate.GotFocus
        Try

            Dim DM As New DateMode
            Me.txtRegDate.Text = DM.DECodeDate(Me.txtRegDate.Text)
        Catch ex As Exception
            txtRegDate.Focus()
        End Try
    End Sub

    Private Sub txtRegDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRegDate.LostFocus
        Try

            Dim DM As New DateMode
            Me.txtRegDate.Text = DM.CodeDate(Me.txtRegDate.Text)
        Catch ex As Exception
            txtRegDate.Focus()
        End Try
    End Sub

    Private Sub txtTT_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHaghTT.GotFocus
        Try
            Dim DM As New DateMode
            Me.txtHaghTT.Text = DM.DECodeDate(Me.txtHaghTT.Text)
        Catch ex As Exception
            Me.txtHaghTT.Focus()
        End Try
    End Sub

    Private Sub txtTT_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtHaghTT.LostFocus
        Try
            Dim DM As New DateMode
            Me.txtHaghTT.Text = DM.CodeDate(Me.txtHaghTT.Text)
        Catch ex As Exception
            Me.txtHaghTT.Focus()
        End Try
    End Sub


    Private Sub LockedText()
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = False
            End If
        Next
        '------------ComboBox-------------
        For Each c In Me.Controls
            If TypeOf c Is ComboBox Then
                c.Enabled = False
            End If
        Next

    End Sub

    Private Sub UnLockedText()
        Dim c As Control
        For Each c In Me.Controls
            If TypeOf c Is TextBox Then
                c.Enabled = True
            End If
        Next
        '------------ComboBox-------------
        For Each c In Me.Controls
            If TypeOf c Is ComboBox Then
                c.Enabled = True
            End If
        Next
    End Sub



#Region "OfficeName"
    Private Function GetOfficeNameID(ByVal OfficeNameName As String)
        If OfficeNameName <> String.Empty Then
            Dim SQLCONection As New SQL
            Dim V As String = String.Empty
            Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from OfficeName where OfficeName=N'" & OfficeNameName & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                V = sdr2(0).ToString
            End While
            SQLCONection.SqlCon.Close()
            Return V
        Else
            Return ""
        End If
    End Function
    Private Function GetOfficeName(ByVal OfficeNameID As String)
        If OfficeNameID <> String.Empty Then
            Dim SQLCONection As New SQL
            Dim V As String = String.Empty
            Dim cmd2 As New SqlClient.SqlCommand("SELECT OfficeName from OfficeName where ID='" & OfficeNameID & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                V = sdr2(0).ToString
            End While
            SQLCONection.SqlCon.Close()
            Return V
        Else
            Return ""
        End If
    End Function
#End Region

#Region "SallerName"
    Private Function GetSallerNameID(ByVal SallerName As String)
        If SallerName <> String.Empty Then
            Dim SQLCONection As New SQL
            Dim V As String = String.Empty
            Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from SallerName where SallerName=N'" & SallerName & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                V = sdr2(0).ToString
            End While
            SQLCONection.SqlCon.Close()
            Return V
        Else
            Return ""
        End If
    End Function
    Private Function GetSallerName(ByVal SallerNameID As String)
        If SallerNameID <> String.Empty Then
            Dim SQLCONection As New SQL
            Dim V As String = String.Empty
            Dim cmd2 As New SqlClient.SqlCommand("SELECT SallerName from SallerName where ID='" & SallerNameID & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                V = sdr2(0).ToString
            End While
            SQLCONection.SqlCon.Close()
            Return V
        Else
            Return ""
        End If
    End Function
#End Region

#Region "GharardadName"
    '    Private Function GetGharardadNameID(ByVal Title As String)
    '        If Title <> String.Empty Then
    '            Dim SQLCONection As New SQL
    '            Dim V As String = String.Empty
    '            Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Title where Title=N'" & Title & "'", SQLCONection.SqlCon)
    '            SQLCONection.SqlCon.Open()
    '            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
    '            While sdr2.Read
    '                V = sdr2(0).ToString
    '            End While
    '            SQLCONection.SqlCon.Close()
    '            Return V
    '        Else
    '            Return ""
    '        End If
    '    End Function
    '    Private Function GetGharardadName(ByVal TitleID As String)
    '        If TitleID <> String.Empty Then
    '            Dim SQLCONection As New SQL
    '            Dim V As String = String.Empty
    '            Dim cmd2 As New SqlClient.SqlCommand("SELECT Title from Title where ID=N'" & TitleID & "'", SQLCONection.SqlCon)
    '            SQLCONection.SqlCon.Open()
    '            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
    '            While sdr2.Read
    '                V = sdr2(0).ToString
    '            End While
    '            SQLCONection.SqlCon.Close()
    '            Return V
    '        Else
    '            Return ""
    '        End If
    '    End Function
#End Region

#Region "GetMajmooeNameID"
    Private Function GetMajmooeNameID(ByVal MajmooeName As String)
        If MajmooeName <> String.Empty Then
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
        Else
            Return ""
        End If
    End Function
    Private Function GetMajmooeName(ByVal ID As String)
        If ID <> String.Empty Then
            Dim SQLCONection As New SQL
            Dim V As String = String.Empty
            Dim cmd2 As New SqlClient.SqlCommand("SELECT Majmooe from Majmooe where ID='" & ID & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                V = sdr2(0).ToString
            End While
            SQLCONection.SqlCon.Close()
            Return V
        Else
            Return ""
        End If
    End Function

#End Region


#Region "Vakil"
    Private Function GetNoeVekalatID(ByVal NoeVekalat As String)
        If NoeVekalat <> String.Empty Then
            Dim SQLCONection As New SQL
            Dim V As String = String.Empty
            Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from NoeVekalat where NoeVekalat=N'" & NoeVekalat & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                V = sdr2(0).ToString
            End While
            SQLCONection.SqlCon.Close()
            Return "'" & V & "'"
        Else
            Return "Null"
        End If
    End Function
    Private Function GetNoeVekalat(ByVal NoeVekalatID As String)
        If NoeVekalatID <> String.Empty Then
            Dim SQLCONection As New SQL
            Dim V As String = String.Empty
            Dim cmd2 As New SqlClient.SqlCommand("SELECT NoeVekalat from NoeVekalat where ID=N'" & NoeVekalatID & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                V = sdr2(0).ToString
            End While
            SQLCONection.SqlCon.Close()
            Return V
        Else
            Return ""
        End If
    End Function
#End Region

    'Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click

    '    If Me.cboNoePishPardakht.Text <> "" And Me.cboNoeAghsat.Text <> "" Then
    '        Dim Reged As Boolean = False

    '        Dim X As String = String.Empty

    '        If Me.cboCashType.Text = "قسطی" And Me.cboNoeAghsat.Text = String.Empty Then
    '            X += "نوع اقساط" & vbCrLf
    '        End If
    '        If Me.cboCashType.Text = String.Empty Then X += "نوع پرداخت" & vbCrLf

    '        If Me.cboNoePishPardakht.Text = String.Empty Then X += "نوع پیش پرداخت" & vbCrLf
    '        If Me.cboOfficeName.Text = String.Empty Then X += "نام دفتر" & vbCrLf
    '        If Me.cboSallerName.Text = String.Empty Then X += "نام مشاور" & vbCrLf


    '        If X = String.Empty Then


    '            Dim TabIndex As Integer = Me.TabNoeKharidar.SelectedIndex

    '            RefreshCoText()
    '            'Me.txtGharardadNo.Text = CG.GenerateGharadadNo(MajmooeName, Zone)
    '            '-----------------------------
    '            Dim SqlCon As New SQL
    '            Dim Cmd As New SqlClient.SqlCommand
    '            Cmd = New SqlClient.SqlCommand
    '            Cmd.CommandText = "insert into GharardadNo (TabIndex,VahedNoID,OfficeNameID,SallerNameID,CoName,CoRegNo,CoManager,CoValidators,CoConnector,CoPhone,CoFax,CoEmail,CoAddress,[Name],LName,FName,ShSh,MelliCode,TT,MT,HomePhone,WorkPhone,Mobile,Email,Address,GharardadRegDate,PostalCode,RegDate,RegDay,CashType,GharardadPrice,Pishpardakht,NoePishPardakht,Aghsat,NoeAghsat,GharardadNo,VahedCode,Discription,MajmooeNameID,Gender,VakilNoeVekalatID,VakilGender,VakilName,VakilLname,VakilFName,VakilShSh ,VakilMelliCode,VakilBemojebe,VakilVekalatNo,VakilVekalatDate,Takhfif,MobayeAmlaak,MobayeDaftar,Shora,Amlaak,Forooshande1,Forooshande2,Rahgiri,EmzaKharidar,Taidiye,CodeRahgiri,TahvilGharardad) Values ('" & TabIndex & "','" & VahedNameID & "','" & OfficeNameID & "','" & SallerNameID & "',N'" & Me.txtCoName.Text & "',N'" & Me.txtCoRegNo.Text & "',N'" & Me.txtCoManager.Text & "',N'" & Me.txtCoValidators.Text & "',N'" & Me.txtCoConnector.Text & "',N'" & Me.txtCoPhone.Text & "',N'" & Me.txtCoFax.Text & "',N'" & Me.txtCoEmail.Text & "',N'" & Me.txtCoAddress.Text & "',N'" & Me.txtHaghName.Text & "',N'" & Me.txtHaghLname.Text & "',N'" & Me.txtHaghFname.Text & "',N'" & Me.txtHaghShSh.Text & "',N'" & Me.txtHaghMelliCode.Text & "',N'" & Me.txtHaghTT.Text & "',N'" & Me.txtHaghMT.Text & "',N'" & Me.txtHaghHomePhone.Text & "',N'" & Me.txtHaghWorkPhone.Text & "',N'" & Me.txtHaghMobile.Text & "',N'" & Me.txtHaghEmail.Text & "',N'" & Me.txtHaghAddress.Text & "',N'" & Me.txtGharardadRegDate.Text & "',N'" & Me.txtHaghPostalCode.Text & "',N'" & Dc.Hyear + "/" + Dc.Hmonth + "/" + Dc.Hday & "',N'" & Dc.HweekDay & "',N'" & Me.cboCashType.Text & "',N'" & Cu.DeCodeNumber(Me.txtGharardadPrice.Text) & "','" & Cu.DeCodeNumber(Me.txtPishpardakht.Text) & "',N'" & Me.cboNoePishPardakht.Text & "','" & Cu.DeCodeNumber(Me.txtAghsat.Text) & "',N'" & Me.cboNoeAghsat.Text & "',N'" & Me.txtGharardadNo.Text & "',N'" & Me.txtVahedCode.Text & "',N'" & Me.txtDiscription.Text & "','" & GetMajmooeNameID(Me.txtMajmooeName.Text) & "'," & Me.cboGenderHagh.SelectedIndex & "," & GetNoeVekalatID(Me.cbonoeVekalat.Text) & "," & Me.cboGenderHagh.SelectedIndex & ",N'" & Me.txtVakilName.Text & "',N'" & Me.txtVakilLName.Text & "',N'" & Me.txtVakilFName.Text & "',N'" & Me.txtVakilShSh.Text & "',N'" & Me.txtVakilMelliCode.Text & "',N'" & Me.txtVakilBemojeb.Text & "',N'" & Me.txtVakilVekalatNo.Text & "',N'" & Me.txtVakilDate.Text & "',N'" & Cu.DeCodeNumber(Me.txtTakhfif.Text) & "','" & RbMobayeChecked() & "','" & Me.chkMobayeDaftar.Checked & "','" & Me.chkMohrShora.Checked & "','" & Me.chkMohrAmlaak.Checked & "','" & Me.chkForooshande1.Checked & "','" & Me.chkForooshande2.Checked & "','" & Me.chkRahgiri.Checked & "','" & Me.chkEmzaKharidar.Checked & "','" & Taidiyeh() & "',N'" & Me.txtCodeRahgiri.Text & "','" & Me.chkTahvilGharardad.Checked & "')"
    '            Cmd.Connection = SqlCon.SqlCon

    '            SqlCon.SqlCon.Open()
    '            Try
    '                Cmd.ExecuteNonQuery()
    '                Reged = True
    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message.ToString, "خطا در ثبت اطلاعات :::...btnReg_Click", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    '            Finally
    '                SqlCon.SqlCon.Close()
    '            End Try

    '            'Me.Close()

    '        Else
    '            MessageBox.Show("لطفاٌ مشخصات زیر را تکمیل کنید" & vbCrLf & X, " خطا در تکمیل مشخصات :::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    '        End If

    '        If Reged = True Then
    '            SetSold()
    '        End If

    '        RefreshText()

    '        Me.Close()
    '    Else
    '        MessageBox.Show("لطفاٌ نوع پرداخت را مشخص کنید", " خطا در تکمیل مشخصات :::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    '    End If
    'End Sub

    Private Sub SetSold()
        Dim SqlCon As New SQL
        Dim Cmd As New SqlClient.SqlCommand
        Cmd = New SqlClient.SqlCommand
        Cmd.Connection = SqlCon.SqlCon
        Cmd.CommandText = "Update VahedName set Sold='1' Where ID='" & GharardadID & "'"
        SqlCon.SqlCon.Open()
        Try
            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا در ثبت اطلاعات فروش", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
    End Sub

    Private Sub cboSallerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSallerName.SelectedIndexChanged
        SallerNameID = GetSallerNameID(Me.cboSallerName.Text)
    End Sub

    Private Sub CboSelector(ByVal CBO As ComboBox, ByVal Price As String, ByVal Type As String, ByVal Pish As Boolean, Optional ByVal SayerePardakhtHa As Boolean = False)

        Select Case CBO.Text

            Case Is = "نقدی"
                'Dim frm As New frmPardakhteNaghdi
                Dim frm As New frmPardakhteTahator
                'frm.MdiParent = Mehregan.Parent
                frm.OwnerID = GharardadID
                frm.Type = Type
                frm.FormType = "نقدی"
                frm.MajmooeID = GetMajmooeNameID(Me.txtMajmooeName.Text)
                frm.Price = Cu.DeCodeNumber(Price)
                frm.SayerVisible = SayerePardakhtHa
                'frm.Pish = Pish
                frm.Canceli = True
                frm.GharardadPrice = Cu.DeCodeNumber(Me.txtGharardadPrice.Text)
                frm.ShowDialog()
            Case Is = "چکی"
                Dim frm As New frmPardakhteCheck
                'frm.MdiParent = Mehregan.Parent
                frm.OwnerID = GharardadID
                frm.Type = Type
                frm.FormType = "چکی"
                frm.MajmooeID = GetMajmooeNameID(Me.txtMajmooeName.Text)
                frm.Price = Cu.DeCodeNumber(Price)
                frm.SayerVisible = SayerePardakhtHa
                'frm.Pish = Pish
                frm.Canceli = True
                frm.GharardadPrice = Cu.DeCodeNumber(Me.txtGharardadPrice.Text)
                frm.txtAccountOwner.Text = Me.txtHaghName.Text & " " & Me.txtHaghLname.Text
                frm.ShowDialog()
            Case Is = "حواله"
                Dim frm As New frmPardakhteHavale
                'frm.MdiParent = Mehregan.Parent
                frm.OwnerID = GharardadID
                frm.Type = Type
                frm.FormType = "حواله"
                frm.MajmooeID = GetMajmooeNameID(Me.txtMajmooeName.Text)
                frm.Price = Cu.DeCodeNumber(Price)
                frm.SayerVisible = SayerePardakhtHa
                'frm.Pish = Pish
                frm.Canceli = True
                frm.GharardadPrice = Cu.DeCodeNumber(Me.txtGharardadPrice.Text).ToString
                frm.ShowDialog()
            Case Is = "سفته"
                Dim frm As New frmPardakhteSafteh
                'frm.MdiParent = Mehregan.Parent
                frm.OwnerID = GharardadID
                frm.Type = Type
                frm.FormType = "سفته"
                frm.MajmooeID = GetMajmooeNameID(Me.txtMajmooeName.Text)
                frm.txtMoteahedName.Text = Me.txtHaghName.Text & " " & Me.txtHaghLname.Text
                frm.Price = Cu.DeCodeNumber(Price)
                frm.SayerVisible = SayerePardakhtHa
                'frm.Pish = Pish
                frm.Canceli = True
                frm.GharardadPrice = Cu.DeCodeNumber(Me.txtGharardadPrice.Text).ToString
                frm.ShowDialog()
            Case Is = "تهاتر"
                Dim frm As New frmPardakhteTahator
                'frm.MdiParent = Mehregan.Parent
                frm.OwnerID = GharardadID
                frm.Type = Type
                frm.FormType = "تهاتر"
                frm.MajmooeID = GetMajmooeNameID(Me.txtMajmooeName.Text)
                frm.Price = Cu.DeCodeNumber(Price)
                frm.SayerVisible = SayerePardakhtHa
                'frm.Pish = Pish
                frm.Canceli = True
                frm.ShowDialog()
                frm.GharardadPrice = Cu.DeCodeNumber(Me.txtGharardadPrice.Text).ToString
            Case Is = "واریز به حساب"
                Dim frm As New frmVarizBeHesab
                'frm.MdiParent = Mehregan.Parent
                frm.OwnerID = GharardadID
                frm.Type = Type
                frm.FormType = "واریز به حساب"
                frm.MajmooeID = GetMajmooeNameID(Me.txtMajmooeName.Text)
                frm.Price = Cu.DeCodeNumber(Price)
                frm.SayerVisible = SayerePardakhtHa
                'frm.Pish = Pish
                frm.Canceli = True
                frm.ShowDialog()
                frm.GharardadPrice = Cu.DeCodeNumber(Me.txtGharardadPrice.Text).ToString

        End Select

    End Sub

    Private Sub cboCashType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCashType.SelectedIndexChanged

        '  GharardadNameID = GetGharardadNameID(Me.cboCashType.Text)

        If Me.cboCashType.Text = "نقدی" Then
            Me.txtAghsat.Enabled = False
            Me.cboNoeAghsat.Enabled = False
            Me.btnRegMandeSharayet.Enabled = False
            Me.cboNoeAghsat.Text = "نقدی"
        Else
            Me.txtAghsat.Enabled = True
            Me.cboNoeAghsat.Enabled = True
            Me.btnRegMandeSharayet.Enabled = True
            '---------
        End If
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick

        If Me.txtTakhfif.Text = String.Empty Then Me.txtTakhfif.Text = "0"

        Dim S1 As Integer = GetSumCanceli.GetSum(GharardadID, "پیش پرداخت")
        Dim S2 As Integer = GetSumCanceli.GetSum(GharardadID, "اقساط")
        Dim S3 As Integer = GetSumCanceli.GetSum(GharardadID, "نقدی")

        Try
            Me.txtAghsat.Text = Cu.CodeNumber(Cu.DeCodeNumber(Me.txtPrice.Text) - Cu.DeCodeNumber(Me.txtPishpardakht.Text))
            Me.txtMandePishPardakht.Text = Cu.CodeNumber(Cu.DeCodeNumber(Me.txtPishpardakht.Text) - S1)
            Me.txtMandeAghsat1.Text = Cu.CodeNumber((Cu.DeCodeNumber(Me.txtAghsat.Text) - (S2 + S3)))

            Dim Takhf() As String = Me.txtTakhfif.Text.ToString.Split("%")
            Dim Car() As Char = Takhf(0).ToCharArray


            'Dim cCount As String = String.Empty
            'For C As Integer = 0 To Car.Length - 1

            '    If Not IsNumeric(Car(C)) = True Then
            '        Me.txtTakhfif.Text = cCount
            '        Exit Sub
            '    End If
            '    cCount += Car(C).ToString
            'Next


            If Takhf.Length = 2 And IsNumeric(Takhf(0)) = True Then
                Dim TT As String = Cu.DeCodeNumber(Me.txtGharardadPrice.Text) - (Cu.DeCodeNumber(Me.txtGharardadPrice.Text) * Double.Parse(Cu.DeCodeNumber(Takhf(0).ToString)) / 100)
                Me.txtPrice.Text = Cu.CodeNumber(Double.Parse(TT))
            ElseIf Takhf.Length = 1 And IsNumeric(Takhf(0)) Then
                Me.txtPrice.Text = Cu.CodeNumber(Cu.DeCodeNumber(Me.txtGharardadPrice.Text) - Double.Parse(Cu.DeCodeNumber(Me.txtTakhfif.Text)))
            ElseIf IsNumeric(Me.txtTakhfif.Text) = True Then
                Me.txtPrice.Text = Me.txtGharardadPrice.Text
            End If

        Catch exX As Exception
            'MessageBox.Show(exX.Message.ToString, "خطا در جمع مبالغ پرداختی  Timer", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End Try

        '-----------------------------------------
        GS = New GetSumCanceli
        Dim SM As String = GS.GetSumPardakhtNaShode(GharardadID, "اقساط") + GS.GetSumPardakhtNaShode(GharardadID, "نقدی") + GS.GetSumPardakhtNaShode(GharardadID, "پیش پرداخت") + GS.GetSumPardakhtNaShode(GharardadID, "سایر پرداخت ها")
        NtoW = New NumberToWord
        Me.lblBedehi.Text = Cu.CodeNumber(SM) & " معادل " & NtoW.Convert(SM)

    End Sub

    Private Sub FillTextBox(ByVal GharardadID As String)
        Dim SqlCon As New SQL
        Dim Cmd As New SqlClient.SqlCommand
        Cmd = New SqlClient.SqlCommand
        Cmd.Connection = SqlCon.SqlCon
        Cmd.CommandText = "Select G.GharardadNo,G.VahedCode,G.OfficeNameID,G.SallerNameID,G.Name,G.LName,G.FName,G.ShSh,G.MelliCode,G.TT,G.MT,G.HomePhone,G.WorkPhone,G.Mobile,G.Email,G.Address,G.GharardadRegDate,G.PostalCode,G.RegDate,G.RegDay,G.CashType,G.GharardadPrice,G.Pishpardakht,G.NoePishPardakht,G.Aghsat,G.NoeAghsat,G.Discription,G.MajmooeName,G.TabIndex,G.CoName,G.CoRegNo,G.CoManager,G.CoValidators,G.CoConnector,G.CoPhone,G.CoFax,G.CoEmail,G.CoAddress,G.Gender,G.VakilNoeVekalatID,G.VakilGender,G.VakilName,G.VakilLname,G.VakilFName,G.VakilShSh,G.VakilMelliCode,G.VakilBemojebe,G.VakilVekalatNo,G.VakilVekalatDate,G.Takhfif,G.MobayeAmlaak,G.MobayeDaftar,G.Shora,G.Amlaak,G.Forooshande1,G.Forooshande2,G.Rahgiri,G.EmzaKharidar,G.Taidiye,G.CodeRahgiri,G.TahvilGharardad,G.Metraj,G.HeadGroup,G.CancelDate + ' ' + G.CancelDay,G.Ellat from GharardadDel G where G.VahedNoID='" & GharardadID & "' "

        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = Cmd.ExecuteReader
        Try
            While sdr.Read

                Me.txtGharardadNo.Text = sdr(0).ToString
                Me.txtVahedCode.Text = sdr(1).ToString
                '-----------
                ' GharardadNameID = sdr(2).ToString
                '-----------
                OfficeNameID = sdr(2).ToString
                '-----------
                SallerNameID = sdr(3).ToString
                '-----------
                Me.txtHaghName.Text = sdr(4).ToString
                Me.txtHaghLname.Text = sdr(5).ToString
                Me.txtHaghFname.Text = sdr(6).ToString
                Me.txtHaghShSh.Text = sdr(7).ToString
                Me.txtHaghMelliCode.Text = sdr(8).ToString
                Me.txtHaghTT.Text = sdr(9).ToString
                Me.txtHaghMT.Text = sdr(10).ToString
                Me.txtHaghHomePhone.Text = sdr(11).ToString
                Me.txtHaghWorkPhone.Text = sdr(12).ToString
                Me.txtHaghMobile.Text = sdr(13).ToString
                Me.txtHaghEmail.Text = sdr(14).ToString
                Me.txtHaghAddress.Text = sdr(15).ToString
                Me.txtGharardadRegDate.Text = sdr(16).ToString
                Me.txtHaghPostalCode.Text = sdr(17).ToString
                Me.txtRegDate.Text = sdr(18).ToString & sdr(19)
                Me.cboCashType.Text = sdr(20).ToString

                Me.txtGharardadPrice.Text = sdr(21).ToString
                Me.txtPishpardakht.Text = Cu.CodeNumber(sdr(22).ToString)
                Me.cboNoePishPardakht.Text = sdr(23).ToString
                Me.txtAghsat.Text = Cu.CodeNumber(sdr(24).ToString)
                Me.cboNoeAghsat.Text = sdr(25).ToString
                Me.txtDiscription.Text = sdr(26).ToString
                Me.txtMajmooeName.Text = GetMajmooeName(sdr(27).ToString)
                Me.TabNoeKharidar.SelectTab(Integer.Parse(sdr(28)))
                Me.txtCoName.Text = sdr(29).ToString
                Me.txtCoRegNo.Text = sdr(30).ToString
                Me.txtCoManager.Text = sdr(31).ToString
                Me.txtCoValidators.Text = sdr(32).ToString
                Me.txtCoConnector.Text = sdr(33).ToString
                Me.txtCoPhone.Text = sdr(34).ToString
                Me.txtCoFax.Text = sdr(35).ToString
                Me.txtCoEmail.Text = sdr(36).ToString
                Me.txtCoAddress.Text = sdr(37).ToString
                Me.cboGenderHagh.SelectedIndex = sdr(38)

                Me.cbonoeVekalat.Text = GetNoeVekalat(sdr(39).ToString)
                If sdr(40).ToString <> String.Empty Then
                    Me.cboGenderVakil.SelectedIndex = sdr(40)
                End If
                Me.txtVakilName.Text = sdr(41).ToString
                Me.txtVakilLName.Text = sdr(42).ToString
                Me.txtVakilFName.Text = sdr(43).ToString
                Me.txtVakilShSh.Text = sdr(44).ToString
                Me.txtVakilMelliCode.Text = sdr(45).ToString
                Me.txtVakilBemojeb.Text = sdr(46).ToString
                Me.txtVakilVekalatNo.Text = sdr(47).ToString
                Me.txtVakilDate.Text = sdr(48).ToString
                Me.txtTakhfif.Text = sdr(49).ToString
                RbMobayeLoad(sdr(50))
                Me.chkMobayeDaftar.Checked = sdr(51)
                Me.chkMohrShora.Checked = sdr(52)
                Me.chkMohrAmlaak.Checked = sdr(53)
                Me.chkForooshande1.Checked = sdr(54)
                Me.chkForooshande2.Checked = sdr(55)
                Me.chkRahgiri.Checked = sdr(56)
                Me.chkEmzaKharidar.Checked = sdr(57)
                Select Case sdr(58)
                    Case Is = True
                        Me.btnTaidiye.BackColor = Color.Green
                    Case Is = False
                        Me.btnTaidiye.BackColor = Color.Red
                End Select
                'Me.btnReg.Enabled = False
                Me.txtCodeRahgiri.Text = sdr(59).ToString
                Me.chkTahvilGharardad.Checked = sdr(60)
                Me.txtMetrajeZamin.Text = sdr(61).ToString
                Me.cboHeadGroup.Text = sdr(62).ToString
                Me.txtCancelDate.Text = sdr(63).ToString
                Me.txtCanceliDetails.Text = sdr(64).ToString

            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا در خواندن و نمایش اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False)
        Finally

            SqlCon.SqlCon.Close()
        End Try

        Try

            'Me.cboCashType.Text = GetGharardadName(GharardadNameID.ToString)
            Me.cboOfficeName.Text = GetOfficeName(OfficeNameID.ToString)
            Me.cboSallerName.Text = GetSallerName(SallerNameID.ToString)

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا در نمایش اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False)
        End Try

        Me.TabNoeKharidar.Focus()
        Me.Timer.Enabled = True
        CheckVaziyat()
        FilldbgSayerPardakhtHa()
        FilldbgAllPardakht()
        BedehiSayer()
        FillGridMemberGroups()
    End Sub


    Private Sub BedehiSayer()
        Cu = New Currency
        NtoW = New NumberToWord
        Me.txtBedehiSayer.Text = Cu.CodeNumber(GetSumCanceli.GetSumPardakhtNaShode(GharardadID, "سایر پرداخت ها")) & "    معادل    " & NtoW.Convert(GetSumCanceli.GetSumPardakhtNaShode(GharardadID, "سایر پرداخت ها"))
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        GetHeadGroupName()

        Dim Result As Windows.Forms.DialogResult = MessageBox.Show("آیا مایلید اطلاعات جدید ثبت گردند؟", "ثبت تغییرات", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign)
        Dim TabIndex As Integer = Me.TabNoeKharidar.SelectedIndex

        If Result = Windows.Forms.DialogResult.Yes Then
            Dim SqlCon As New SQL
            Dim Cmd As New SqlClient.SqlCommand
            Cmd = New SqlClient.SqlCommand
            Cmd.Connection = SqlCon.SqlCon
            'Cmd.CommandText = "Update GharardadDel Set TabIndex='" & TabIndex & "',VahedNoID='" & GharardadID & "',VahedCode=N'" & Me.txtVahedCode.Text & "',OfficeNameID='" & OfficeNameID & "',SallerNameID='" & SallerNameID & "',CoName=N'" & Me.txtCoName.Text & "',CoRegNo=N'" & Me.txtCoRegNo.Text & "',CoManager=N'" & Me.txtCoManager.Text & "',CoValidators=N'" & Me.txtCoValidators.Text & "',CoConnector=N'" & Me.txtCoConnector.Text & "',CoPhone=N'" & Me.txtCoPhone.Text & "',CoFax=N'" & Me.txtCoFax.Text & "',CoEmail=N'" & Me.txtCoEmail.Text & "',CoAddress=N'" & Me.txtCoAddress.Text & "',Gender=" & Me.cboGenderHagh.SelectedIndex & ",Name=N'" & Me.txtHaghName.Text & "',LName=N'" & Me.txtHaghLname.Text & "',FName=N'" & Me.txtHaghFname.Text & "',ShSh=N'" & Me.txtHaghShSh.Text & "',MelliCode=N'" & Me.txtHaghMelliCode.Text & "',TT=N'" & Me.txtHaghTT.Text & "',MT=N'" & Me.txtHaghMT.Text & "',HomePhone=N'" & Me.txtHaghHomePhone.Text & "',WorkPhone=N'" & Me.txtHaghWorkPhone.Text & "',Mobile=N'" & Me.txtHaghMobile.Text & "',Email=N'" & Me.txtHaghEmail.Text & "',Address=N'" & Me.txtHaghAddress.Text & "',GharardadRegDate=N'" & Me.txtGharardadRegDate.Text & "',PostalCode=N'" & Me.txtHaghPostalCode.Text & "',RegDate=N'" & Dc.Hyear + "/" + Dc.Hmonth + "/" + Dc.Hday & "',RegDay=N'" & Dc.HweekDay & "',CashType=N'" & Me.cboCashType.Text & "',GharardadPrice=N'" & Cu.DeCodeNumber(Me.txtGharardadPrice.Text) & "',Pishpardakht='" & Cu.DeCodeNumber(Me.txtPishpardakht.Text) & "',NoePishPardakht=N'" & Me.cboNoePishPardakht.Text & "',Aghsat='" & Cu.DeCodeNumber(Me.txtAghsat.Text) & "',NoeAghsat=N'" & Me.cboNoeAghsat.Text & "',Discription=N'" & Me.txtDiscription.Text & "',MajmooeNameID='" & GetMajmooeNameID(Me.txtMajmooeName.Text) & "',VakilNoeVekalatID=" & GetNoeVekalatID(Me.cbonoeVekalat.Text) & ",VakilGender=" & Me.cboGenderHagh.SelectedIndex & ",VakilName=N'" & Me.txtVakilName.Text & "',VakilLname=N'" & Me.txtVakilLName.Text & "',VakilFName=N'" & Me.txtVakilFName.Text & "',VakilShSh=N'" & Me.txtVakilShSh.Text & "' ,VakilMelliCode=N'" & Me.txtVakilMelliCode.Text & "',VakilBemojebe=N'" & Me.txtVakilBemojeb.Text & "',VakilVekalatNo=N'" & Me.txtVakilVekalatNo.Text & "',VakilVekalatDate=N'" & Me.txtVakilDate.Text & "',Takhfif=N'" & Cu.DeCodeNumber(txtTakhfif.Text) & "',MobayeAmlaak='" & RbMobayeChecked() & "', MobayeDaftar='" & Me.chkMobayeDaftar.Checked & "', Shora='" & Me.chkMohrShora.Checked & "', Amlaak='" & Me.chkMohrAmlaak.Checked & "', Forooshande1='" & Me.chkForooshande1.Checked & "', Forooshande2='" & Me.chkForooshande2.Checked & "', Rahgiri='" & Me.chkRahgiri.Checked & "', EmzaKharidar='" & Me.chkEmzaKharidar.Checked & "',Taidiye='" & Taidiyeh() & "',CodeRahgiri=N'" & Me.txtCodeRahgiri.Text & "',TahvilGharardad='" & Me.chkTahvilGharardad.Checked & "',HeadGroup=N'" & Me.cboHeadGroup.Text & "' where VahedNoID='" & GharardadID & "'"
            Cmd.CommandText = "Update GHarardadDel Set TabIndex='" & TabIndex & "',VahedNoID='" & GharardadID & "',VahedCode=N'" & Me.txtVahedCode.Text & "',OfficeNameID='" & OfficeNameID & "',SallerNameID='" & SallerNameID & "',CoName=N'" & Me.txtCoName.Text & "',CoRegNo=N'" & Me.txtCoRegNo.Text & "',CoManager=N'" & Me.txtCoManager.Text & "',CoValidators=N'" & Me.txtCoValidators.Text & "',CoConnector=N'" & Me.txtCoConnector.Text & "',CoPhone=N'" & Me.txtCoPhone.Text & "',CoFax=N'" & Me.txtCoFax.Text & "',CoEmail=N'" & Me.txtCoEmail.Text & "',CoAddress=N'" & Me.txtCoAddress.Text & "',Gender=" & Me.cboGenderHagh.SelectedIndex & ",Name=N'" & Me.txtHaghName.Text & "',LName=N'" & Me.txtHaghLname.Text & "',FName=N'" & Me.txtHaghFname.Text & "',ShSh=N'" & Me.txtHaghShSh.Text & "',MelliCode=N'" & Me.txtHaghMelliCode.Text & "',TT=N'" & Me.txtHaghTT.Text & "',MT=N'" & Me.txtHaghMT.Text & "',HomePhone=N'" & Me.txtHaghHomePhone.Text & "',WorkPhone=N'" & Me.txtHaghWorkPhone.Text & "',Mobile=N'" & Me.txtHaghMobile.Text & "',Email=N'" & Me.txtHaghEmail.Text & "',Address=N'" & Me.txtHaghAddress.Text & "',GharardadRegDate=N'" & Me.txtGharardadRegDate.Text & "',PostalCode=N'" & Me.txtHaghPostalCode.Text & "',RegDate=N'" & Dc.Hyear + "/" + Dc.Hmonth + "/" + Dc.Hday & "',RegDay=N'" & Dc.HweekDay & "',CashType=N'" & Me.cboCashType.Text & "',GharardadPrice=N'" & Cu.DeCodeNumber(Me.txtGharardadPrice.Text) & "',Pishpardakht='" & Cu.DeCodeNumber(Me.txtPishpardakht.Text) & "',NoePishPardakht=N'" & Me.cboNoePishPardakht.Text & "',Aghsat='" & Cu.DeCodeNumber(Me.txtAghsat.Text) & "',NoeAghsat=N'" & Me.cboNoeAghsat.Text & "',Discription=N'" & Me.txtDiscription.Text & "',MajmooeName='" & Me.txtMajmooeName.Text & "',VakilNoeVekalatID=" & GetNoeVekalatID(Me.cbonoeVekalat.Text) & ",VakilGender=" & Me.cboGenderHagh.SelectedIndex & ",VakilName=N'" & Me.txtVakilName.Text & "',VakilLname=N'" & Me.txtVakilLName.Text & "',VakilFName=N'" & Me.txtVakilFName.Text & "',VakilShSh=N'" & Me.txtVakilShSh.Text & "' ,VakilMelliCode=N'" & Me.txtVakilMelliCode.Text & "',VakilBemojebe=N'" & Me.txtVakilBemojeb.Text & "',VakilVekalatNo=N'" & Me.txtVakilVekalatNo.Text & "',VakilVekalatDate=N'" & Me.txtVakilDate.Text & "',Takhfif=N'" & Cu.DeCodeNumber(txtTakhfif.Text) & "',MobayeAmlaak='" & RbMobayeChecked() & "', MobayeDaftar='" & Me.chkMobayeDaftar.Checked & "', Shora='" & Me.chkMohrShora.Checked & "', Amlaak='" & Me.chkMohrAmlaak.Checked & "', Forooshande1='" & Me.chkForooshande1.Checked & "', Forooshande2='" & Me.chkForooshande2.Checked & "', Rahgiri='" & Me.chkRahgiri.Checked & "', EmzaKharidar='" & Me.chkEmzaKharidar.Checked & "',Taidiye='" & Taidiyeh() & "',CodeRahgiri=N'" & Me.txtCodeRahgiri.Text & "',TahvilGharardad='" & Me.chkTahvilGharardad.Checked & "',HeadGroup=N'" & Me.cboHeadGroup.Text & "'  where VahedNoID='" & GharardadID & "'"
            SqlCon.SqlCon.Open()
            Try
                Cmd.ExecuteNonQuery()
                'RefreshText()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Finally
                SqlCon.SqlCon.Close()
            End Try
        End If

        FillCoGrid()
    End Sub

    Private Sub btnPrintView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintView.Click

        If System.IO.Directory.Exists("C:\Reports") = False Then
            System.IO.Directory.CreateDirectory("C:\Reports")
        End If

        Dim PG As New RptPishGharardad
        PG.Generate(GharardadID)
        Dim frm As New frmReporter
        frm.MdiParent = Mehregan.Parent
        frm.CrystalReportViewer1.ReportSource = frm.rptPishGhrardad1
        frm.rptPishGhrardad1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
        frm.rptPishGhrardad1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        frm.rptPishGhrardad1.PrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Horizontal
        frm.rptPishGhrardad1.PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto
        frm.Show()

        '-------------------------------
        '' Declare an object of your report.
        'Dim objReportObject As New rptPishGhrardad
        ''Declare a printoptions object of the objReportObjects print option.  Set the settings.
        'Dim PrintOptions As CrystalDecisions.CrystalReports.Engine.PrintOptions = objReportObject.PrintOptions
        'PrintOptions.PrinterName = "Your Printer Name Here"
        'PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
        'PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.DefaultPaperSize
        'PrintOptions.PrinterDuplex = CrystalDecisions.Shared.PrinterDuplex.Default
        'PrintOptions.PaperSource = CrystalDecisions.Shared.PaperSource.Auto
        '' Send the report to the printer.
        'objReportObject.PrintToPrinter(1, False, 1, 2)
    End Sub

    Private Sub btnprnGHarardad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprnGHarardad.Click


        ''Me.Timer.Enabled = False
        ''Prn.PrintGharardad(GharardadID)
        ''Dim frm As New frmRptViewer
        ''frm.CrystalReportViewer1.ReportSource = frm.rptGharardad1
        ''frm.rptGharardad1.PrintToPrinter(1, True, 0, 0)
        ''Me.Timer.Enabled = True
        'Dim MCount As String = String.Empty




        'Dim TC As New Counter
        'Dim frm As New frmRegGharardadText
        'frm.GharardadNo = Me.txtGharardadNo.Text
        'frm.ShowDialog()

        ''-------------------------------------

        'Dim cmd As New SqlClient.SqlCommand("select TOP(1) MadehRow FROM Gharardad_v where gharardadno='" & Me.txtGharardadNo.Text & "' order by madehrow desc", SqlCon.SqlCon)
        'SqlCon.SqlCon.Open()
        'Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        'Try
        '    While sdr.Read
        '        MCount = sdr(0)
        '    End While

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message.ToString, "خطا در شمارش تعداد ماده", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        'Finally
        '    SqlCon.SqlCon.Close()
        'End Try

        ''------------------------------------------
        'Dim Bana(6) As String

        'Dim cmd2 As New SqlClient.SqlCommand("select * from Bana_v where VahedNameID ='" & VahedNameID & "'", SqlCon.SqlCon)
        'Dim Gen As String = String.Empty
        'SqlCon.SqlCon.Open()
        'Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        'Try
        '    While sdr2.Read

        '        Bana(0) = sdr2(1).ToString
        '        Bana(1) = sdr2(2).ToString
        '        Bana(2) = sdr2(3).ToString
        '        Bana(3) = sdr2(4).ToString
        '        Bana(4) = sdr2(5).ToString
        '        Bana(5) = (Integer.Parse(sdr2(6)) + Integer.Parse(sdr2(7))).ToString

        '    End While

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message.ToString, "خطا در شمارش تعداد ماده", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        'Finally
        '    SqlCon.SqlCon.Close()
        'End Try

        ''------------------------------------------
        'AC = New AsnadCounter
        ''------------------------------------------

        'Dim TRtl As New TextToRTL

        'Dim Xr As New FillGharardadTextXML
        'Xr.FillXML(Me.txtHaghName.Text & " " & Me.txtHaghLname.Text, Me.txtHaghFname.Text, Me.txtHaghShSh.Text, TRtl.Convert(Me.txtHaghMelliCode.Text, "-"), Bana(0), Bana(1), Me.txtMajmooeName.Text, Bana(2), Bana(3), Bana(4), Bana(5), Me.txtGharardadPrice.Text, Me.txtPishpardakht.Text, Me.txtAghsat.Text, AC.Count(VahedNameID, "اقساط"), " 8000000 ", " 7000000 ", Me.txtHaghAddress.Text, MCount, TC.BandCount("1"), TC.TabsarehCount("1"), 3)

        'Dim frm2 As New frmReporter
        'frm2.MdiParent = Mehregan.Parent
        'frm2.Show()
    End Sub

    Public Sub RefreshText()
        Dim Tc As Control
        For Each Tc In Me.Controls
            If TypeOf Tc Is TextBox AndAlso Tc.Text <> "" Then
                Tc.Text = ""
            End If
        Next

        Dim cc As Control
        For Each cc In Me.Controls
            If TypeOf cc Is ComboBox AndAlso cc.Text <> "" Then
                cc.Text = ""
            End If
        Next


        Me.txtGharardadPrice.Text = "0"
        Me.txtPrice.Text = "0"
        Me.txtPishpardakht.Text = "0"
        Me.txtAghsat.Text = "0"
        Me.txtTakhfif.Text = "0"
        Me.SallerNameID = String.Empty
        OfficeNameID = String.Empty
        GharardadID = String.Empty
        GharardadID = String.Empty
        GharardadNameID = String.Empty
    End Sub

    Public Sub RefreshCoText()

        Dim Tc As Control
        For Each Tc In Me.TabNoeKharidar.TabPages.Item(1).Controls
            If TypeOf Tc Is TextBox AndAlso Mid(Tc.Name.ToString, 1, 5) = "txtCo" Then
                Tc.Text = ""
            End If
        Next
    End Sub

    Public Sub RefreshPText()

        Dim Tc As Control
        For Each Tc In Me.TabNoeKharidar.TabPages.Item(1).Controls
            If TypeOf Tc Is TextBox AndAlso Mid(Tc.Name.ToString, 1, 7) = "txtHagh" Then
                Tc.Text = ""
            End If
        Next
    End Sub

    Private Sub FillCoGrid()

        'Cmd.Connection = SqlCon.SqlCon
        'tbl.Clear()

        'Try
        '    If Me.txtCoNameFinder.Text <> String.Empty Then
        '        Cmd.CommandText = "Select CoName as 'نام سازمان',ID as 'کد شناسائی' from GharardadNo where Not CoName is null AND CoName Like N'" & Me.txtCoNameFinder.Text & "'  Group By CoName,ID"
        '    Else
        '        Cmd.CommandText = "Select CoName as 'نام سازمان',ID as 'کد شناسائی' from GharardadNo where Not CoName is null Group By CoName,ID"
        '    End If

        '    SqlCon.SqlCon.Open()
        '    Sdr = Cmd.ExecuteReader
        '    Dim fc As Integer
        '    While (Sdr.Read)

        '        'populating columns
        '        If Not b Then
        '            For fc = 0 To Sdr.FieldCount - 1
        '                tbl.Columns.Add(Sdr.GetName(fc))
        '            Next
        '            b = True
        '        End If
        '        'populating rows
        '        Dim row As DataRow = tbl.NewRow

        '        For fc = 0 To Sdr.FieldCount - 1
        '            row(fc) = Sdr(fc)
        '        Next
        '        tbl.Rows.Add(row)
        '    End While
        '    dvw = New DataView(tbl)
        '    Me.dbgCoFindder.DataSource = dvw

        '    '-------------------------

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message.ToString, "خطا در خواندن اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        'Finally
        '    SqlCon.SqlCon.Close()
        'End Try

        'Me.dbgCoFindder.Refresh()

    End Sub

    Private Sub txtCoNameFinder_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCoNameFinder.KeyPress
        If e.KeyChar = Chr(13) Then
            FillCoGrid()
        End If

    End Sub

    Private Sub CheckVaziyat()
        If Me.btnTaidiye.BackColor = Color.Red Then
            Me.TabNoeKharidar.TabPages(6).Text = "وضعیت = تایید نشده"
        Else
            Me.TabNoeKharidar.TabPages(6).Text = "وضعیت = تایید شده"
        End If
    End Sub

    Private Sub btnTaidiye_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaidiye.Click
        If Me.btnTaidiye.BackColor = Color.Red Then
            Me.btnTaidiye.BackColor = Color.Green
        End If
        UpdateTozihat()
    End Sub

    Private Function RbMobayeChecked()
        Dim Value As Integer = 0
        If Me.rbNoMobaye.Checked Then Value = 0
        If Me.rbMobayeSendtoSaller.Checked Then Value = 1
        If Me.rbMobayeInOffice.Checked Then Value = 2
        If Me.rbMobayeInAmlaak.Checked Then Value = 3
        Return Value
    End Function
    Private Sub RbMobayeLoad(ByVal Value As Integer)
        Select Case Value
            Case Is = 0
                Me.rbNoMobaye.Checked = True
            Case Is = 1
                Me.rbMobayeSendtoSaller.Checked = True
            Case Is = 2
                Me.rbMobayeInOffice.Checked = True
            Case Is = 3
                Me.rbMobayeInAmlaak.Checked = True
        End Select
    End Sub

    Private Function Taidiyeh()
        Dim Value As Boolean = False
        If Me.btnTaidiye.BackColor = Color.Red Then
            Value = False
        Else
            Value = True
        End If
        Return Value
    End Function

    Private Sub UpdateTozihat()
        If GharardadID <> "" Then
            Dim SqlCon As New SQL
            Dim Cmd As New SqlClient.SqlCommand
            Cmd = New SqlClient.SqlCommand
            Cmd.Connection = SqlCon.SqlCon
            Cmd.CommandText = "Update GharardadDel Set MobayeAmlaak='" & RbMobayeChecked() & "', MobayeDaftar='" & Me.chkMobayeDaftar.Checked & "', Shora='" & Me.chkMohrShora.Checked & "', Amlaak='" & Me.chkMohrAmlaak.Checked & "', Forooshande1='" & Me.chkForooshande1.Checked & "', Forooshande2='" & Me.chkForooshande2.Checked & "', Rahgiri='" & Me.chkRahgiri.Checked & "', EmzaKharidar='" & Me.chkEmzaKharidar.Checked & "',Taidiye='" & Taidiyeh() & "' where VahedNoID='" & GharardadID & "'"

            SqlCon.SqlCon.Open()
            Try
                Cmd.ExecuteNonQuery()
                'RefreshText()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "خطا:::... UpdateTozihat", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Finally
                SqlCon.SqlCon.Close()
            End Try
        End If
    End Sub

    Private Sub rbNoMobaye_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoMobaye.CheckedChanged, rbMobayeSendtoSaller.CheckedChanged, rbMobayeInOffice.CheckedChanged, rbMobayeInAmlaak.CheckedChanged, chkMobayeDaftar.CheckedChanged, chkMohrShora.CheckedChanged, chkMohrAmlaak.CheckedChanged, chkForooshande1.CheckedChanged, chkForooshande2.CheckedChanged, chkRahgiri.CheckedChanged, chkEmzaKharidar.CheckedChanged
        If Me.chkRahgiri.Checked = True Then
            Me.txtCodeRahgiri.Enabled = True
            Me.txtCodeRahgiri.BackColor = Color.Coral
        Else
            Me.txtCodeRahgiri.Enabled = False
            Me.txtCodeRahgiri.BackColor = Color.Red
        End If

        If Me.chkMobayeDaftar.Checked = True Then
            Me.chkEmzaKharidar.Enabled = True
            Me.chkMohrShora.Enabled = True
            Me.chkMohrAmlaak.Enabled = True
            Me.chkForooshande1.Enabled = True
            Me.chkForooshande2.Enabled = True
            Me.chkTahvilGharardad.Enabled = True
        Else
            Me.chkEmzaKharidar.Enabled = False
            Me.chkMohrShora.Enabled = False
            Me.chkMohrAmlaak.Enabled = False
            Me.chkForooshande1.Enabled = False
            Me.chkForooshande2.Enabled = False
            Me.chkTahvilGharardad.Enabled = False
        End If
        UpdateTozihat()
    End Sub

    Private Sub txtGharardadRegDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGharardadRegDate.GotFocus
        Dim DM As New DateMode
        Try
            Me.txtGharardadRegDate.Text = DM.DECodeDate(Me.txtGharardadRegDate.Text)
        Catch ex As Exception
            Me.txtGharardadRegDate.Focus()
        End Try
    End Sub

    Private Sub txtGharardadRegDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGharardadRegDate.LostFocus
        Dim DM As New DateMode
        Try
            Me.txtGharardadRegDate.Text = DM.CodeDate(Me.txtGharardadRegDate.Text)
        Catch ex As Exception
            Me.txtGharardadRegDate.Focus()
        End Try
    End Sub


    Private Sub FilldbgSayerPardakhtHa()


        Cu = New Currency
        Dim SqlCon As New SQL
        Dim Cmd As New SqlClient.SqlCommand
        Dim Sdr As SqlClient.SqlDataReader
        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean

        tbl.Clear()
        tbl.Columns.Clear()
        b = False

        tbl.TableName = "SayerePardakhtHa"


        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("Select Row as 'شماره سند',FormType as 'نحوه دریافت',Jahate as 'دریافت جهت',Price as 'مبلغ دریافت',Date as 'تاریخ سررسید',PardakhtDate as 'تاریخ دریافت',Passed as 'وضعیت دریافت' From GharardadDelBank Where ID='" & GharardadID & "' And Pardakhte=N'سایر پرداخت ها'", SQLCONection.SqlCon)
        Try
            SQLCONection.SqlCon.Open()
            Sdr = cmd2.ExecuteReader
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
                Dim row2 As DataRow = tbl.NewRow

                row2(0) = Sdr(0)
                row2(1) = Sdr(1)
                row2(2) = Sdr(2)
                row2(3) = Cu.CodeNumber(Sdr(3))
                row2(4) = Sdr(4)
                row2(5) = Sdr(5)
                Select Case Sdr(6)
                    Case Is = True
                        row2(6) = "پرداخت شده"
                    Case Is = False
                        row2(6) = "پرداخت نشده"
                End Select

                tbl.Rows.Add(row2)
            End While
            dvw = New DataView(tbl)
            Me.dbgSayerPardakhtHa.DataSource = dvw
            Sdr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا در خواندن اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SQLCONection.SqlCon.Close()
        End Try

        Me.dbgCoFindder.Refresh()

    End Sub

    Private Sub btnRegSayerSharayet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegSayerSharayet.Click
        CboSelector(Me.cboSayer, Cu.DeCodeNumber(0), "سایر پرداخت ها", False, True)
        FilldbgSayerPardakhtHa()
        BedehiSayer()
    End Sub

    Private Sub dbgSayerPardakhtHa_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgSayerPardakhtHa.CellMouseDoubleClick
        Dim CBO As New ComboBox
        CBO.Text = Me.dbgSayerPardakhtHa.CurrentRow.Cells.Item(1).Value.ToString()
        CboSelector(CBO, Cu.DeCodeNumber(0), "سایر پرداخت ها", False, True)
        FilldbgSayerPardakhtHa()
        BedehiSayer()
    End Sub


    Private Sub FilldbgAllPardakht()

        Cu = New Currency

        Dim SqlCon As New SQL
        Dim Cmd As New SqlClient.SqlCommand
        Dim Sdr As SqlClient.SqlDataReader
        Dim tbl As New DataTable
        Dim dvw As DataView
        Dim b As Boolean

        Cmd.Connection = SqlCon.SqlCon
        tbl.Clear()
        tbl.TableName = "AllPardakht"

        Try
            Cmd.CommandText = "Select Row as 'شماره سند',FormType as 'نحوه دریافت',Pardakhte as 'نوع پرداخت',Jahate as 'دریافت جهت',Price as 'مبلغ دریافت',Date as 'تاریخ سررسید',PardakhtDate as 'تاریخ دریافت',Passed as 'وضعیت دریافت' From GharardadDelBank Where ID='" & GharardadID & "' And Pardakhte!=N'سایر پرداخت ها' Order by Pardakhte,FormType,Date"
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
                Dim row2 As DataRow = tbl.NewRow
                row2(0) = Sdr(0)
                row2(1) = Sdr(1)
                row2(2) = Sdr(2)
                row2(3) = Sdr(3)
                row2(4) = Cu.CodeNumber(Sdr(4))
                row2(5) = Sdr(5)
                row2(6) = Sdr(6)
                Select Case Sdr(7)
                    Case Is = True
                        row2(7) = "پرداخت شده"
                    Case Is = False
                        row2(7) = "پرداخت نشده"
                End Select

                tbl.Rows.Add(row2)
            End While
            dvw = New DataView(tbl)
            Me.dbgAllPardakht.DataSource = dvw
            Sdr.Close()
            '-------------------------

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا در خواندن اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try
    End Sub


    Private Sub dbgAllPardakht_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dbgAllPardakht.CellMouseDoubleClick
        Dim CBO As New ComboBox
        Dim Pr As String = 0
        CBO.Text = Me.dbgAllPardakht.CurrentRow.Cells.Item(1).Value.ToString()
        Select Case Me.dbgAllPardakht.CurrentRow.Cells.Item(2).Value.ToString()
            Case Is = "پیش پرداخت"
                Pr = Me.txtPishpardakht.Text
            Case Is = "اقساط"
                Pr = Me.txtAghsat.Text
        End Select
        CboSelector(CBO, Pr, Me.dbgAllPardakht.CurrentRow.Cells.Item(2).Value.ToString(), False, True)
        FilldbgSayerPardakhtHa()
        BedehiSayer()
    End Sub

End Class

