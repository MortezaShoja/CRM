Public Class frmCancelingContract

    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private Cu As New Currency
    Private CD As CurrentDate

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
    Private Sub FillCboMajmooe()
        Me.cboMajmooeName.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Majmooe from Majmooe", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboMajmooeName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub cboVahedtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVahedtype.SelectedIndexChanged
        Me.cboZone.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Zone from Zone where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboZone.Items.Add(sdr2(0).ToString)
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

    Private Function GetZoneID(ByVal MajmooeID As String, ByVal Zone As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Zone where MajmooeID='" & MajmooeID & "' And Zone=N'" & Zone & "'", SQLCONection.SqlCon)
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

    Private Sub frmSelectPlace_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblTmpID.Text = Guid.NewGuid.ToString
        FillCboVahedtype()
        FillCboMajmooe()
    End Sub


    Private Sub cboZone_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboZone.SelectedIndexChanged
        Dim SQLCONection As New SQL
        Dim cmd2 As New SqlClient.SqlCommand("Select VahedNo from VahedName Where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "' And VahedTypeID='" & GetVahedTypeID(Me.cboVahedtype.Text) & "' And ZoneID='" & GetZoneID(GetMajmooeID(Me.cboMajmooeName.Text), Me.cboZone.Text) & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboGhateNo1.Items.Add(sdr2(0).ToString)
        End While
        SQLCONection.SqlCon.Close()
    End Sub

    Private Sub cboGhateNo1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGhateNo1.SelectedIndexChanged
        GetGharardadNo1()
    End Sub
    Private Sub GetGharardadNo1()
        Me.txtMoshtariName1.Text = ""
        Me.txtGharardadNo1.Text = ""
        Me.lblID1.Text = ""
        Me.txtMoshtariName1.BackColor = Color.Red
        Dim SQLCONection As New SQL
        Dim cmd2 As New SqlClient.SqlCommand("Select G.Name + ' ' + G.Lname as 'FullName',V.ID,V.CodeVahed from VahedName V Left join Gharardadno G On V.ID=G.VahedNoID Where V.MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "' And V.VahedTypeID='" & GetVahedTypeID(Me.cboVahedtype.Text) & "' And V.ZoneID='" & GetZoneID(GetMajmooeID(Me.cboMajmooeName.Text), Me.cboZone.Text) & "' And V.VahedNo='" & Me.cboGhateNo1.Text & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read

            Me.txtMoshtariName1.Text = sdr2(0).ToString
            Me.lblID1.Text = sdr2(1).ToString
            Me.txtGharardadNo1.Text = sdr2(2).ToString
            Me.txtMoshtariName1.BackColor = Color.White
        End While
        SQLCONection.SqlCon.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        CD = New CurrentDate
        Dim SQLCONection As New SQL
        Try
            Dim NID As String = Guid.NewGuid.ToString
            Dim cmd2 As New SqlClient.SqlCommand("SET IDENTITY_INSERT GHarardadDel ON  Insert Into GHarardadDel(Counter,ID,MajmooeName,GharardadNo,VahedNoID,VahedCode,Metraj,OfficeNameID,SallerNameID,Gender,Name,LName,FName,ShSh,MelliCode,TT,MT,Job,HomePhone,WorkPhone,Mobile,Email,Address,GharardadRegDate,PostalCode,RegDate,RegDay,CancelDate,CancelDay,CashType,GharardadPrice,Pishpardakht,NoePishPardakht,Aghsat,NoeAghsat,Discription,TahvilDate,GenderID,TabIndex,CoName,CoRegNo,CoManager,CoValidators,CoConnector,CoPhone,CoFax,CoEmail,CoAddress,Takhfif,VakilNoeVekalatID,VakilGender,VakilGenderID,VakilName,VakilLname,VakilFName,VakilShSh,VakilMelliCode,VakilBemojebe,VakilVekalatNo,VakilVekalatDate,MobayeAmlaak,MobayeDaftar,Shora,Amlaak,Forooshande1,Forooshande2,Rahgiri,EmzaKharidar,Taidiye,CodeRahgiri,TahvilGharardad,FAX,Ellat) Select G.Counter,G.ID,G.MajmooeNameID,G.GharardadNo + ' C',G.VahedNoID,G.VahedCode,V.MetrajZamin,G.OfficeNameID,G.SallerNameID,G.Gender,G.Name,G.LName,G.FName,G.ShSh,G.MelliCode,G.TT,G.MT,G.Job,G.HomePhone,G.WorkPhone,G.Mobile,G.Email,G.Address,G.GharardadRegDate,G.PostalCode,G.RegDate,G.RegDay,N'" & CD.GetDate & "',N'" & CD.GetDay & "',G.CashType,G.GharardadPrice,G.Pishpardakht,G.NoePishPardakht,G.Aghsat,G.NoeAghsat,G.Discription,G.TahvilDate,G.GenderID,G.TabIndex,G.CoName,G.CoRegNo,G.CoManager,G.CoValidators,G.CoConnector,G.CoPhone,G.CoFax,G.CoEmail,G.CoAddress,G.Takhfif,G.VakilNoeVekalatID,G.VakilGender,G.VakilGenderID,G.VakilName,G.VakilLname,G.VakilFName,G.VakilShSh,G.VakilMelliCode,G.VakilBemojebe,G.VakilVekalatNo,G.VakilVekalatDate,G.MobayeAmlaak,G.MobayeDaftar,G.Shora,G.Amlaak,G.Forooshande1,G.Forooshande2,G.Rahgiri,G.EmzaKharidar,G.Taidiye,G.CodeRahgiri,G.TahvilGharardad,G.FAX,N'" & Me.txtCancelCuse.Text & "' From GharardadNo G Inner Join VahedName V On V.ID=G.VahedNoID Where G.VahedNoID='" & Me.lblID1.Text & "'" & _
            "Insert Into GharardadDelBank (ID,Row,Price,AccountOwner,AccountNo,Serial,OwnerBank,BankShobe,BankCode,CodePeygiri,VarizTime,DestinationAccount,Address,Phone,MoteahedName,Havalekard,Date,Pardakhte,FormType,RegDate,RegDay,UpdateDate,UpdateDay,Passed,Tozihat,Jahate,PardakhtDate) select ID,Row,Price,AccountOwner,AccountNo,Serial,OwnerBank,BankShobe,BankCode,CodePeygiri,VarizTime,DestinationAccount,Address,Phone,MoteahedName,Havalekard,Date,Pardakhte,FormType,RegDate,RegDay,UpdateDate,UpdateDay,Passed,Tozihat,Jahate,PardakhtDate from bank Where ID='" & Me.lblID1.Text & "'" & _
            "UPdate GHarardadDel Set VahedNoID='" & NID & "' where VahedNoID='" & Me.lblID1.Text & "'" & _
            "UPdate GharardadDelBank Set ID='" & NID & "' where ID='" & Me.lblID1.Text & "'" & _
            "Delete GharardadNo where VahedNoID='" & Me.lblID1.Text & "'" & _
            "Delete Bank where ID='" & Me.lblID1.Text & "'" & _
            "UPdate VahedName Set Sold='0' where ID='" & Me.lblID1.Text & "'", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            cmd2.ExecuteNonQuery()
            MessageBox.Show("عملیات کنسل کردن قرارداد با موفقیت انجام شد", "کنسل کردن قرارداد", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False)
        Catch ex As Exception
            MessageBox.Show("عملیات کنسل کردن قرارداد با خطا مواجه شد" & vbCrLf & ex.Message.ToString, "کنسل کردن قرارداد", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False)
        Finally
            SQLCONection.SqlCon.Close()
        End Try

    End Sub
End Class