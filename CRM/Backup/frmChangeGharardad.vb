Public Class frmChangeGharardad

    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private Cu As New Currency

    Private Sub FillCboVahedtype()
        Me.cboVahedtype.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT VahedType from VahedType", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboVahedtype.Items.Add(sdr2(0).ToString)
            Me.cboVahedtype2.Items.Add(sdr2(0).ToString)
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
            Me.cboMajmooeName2.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub cboMajmooeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajmooeName.SelectedIndexChanged
        Me.cboZone.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Zone from Zone where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboZone.Items.Add(sdr2(0).ToString)
            Me.cboZone2.Items.Add(sdr2(0).ToString)
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

    Private Sub cboGhateNo2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboGhateNo2.SelectedIndexChanged
        GetGharardadNo2()
    End Sub
    Private Sub GetGharardadNo2()
        Me.txtMoshtariName2.Text = ""
        Me.txtGharardadNo2.Text = ""
        Me.lblID2.Text = ""
        Me.txtMoshtariName2.BackColor = Color.Red
        Dim SQLCONection As New SQL
        Dim cmd2 As New SqlClient.SqlCommand("Select G.Name + ' ' + G.Lname as 'FullName',V.ID,V.CodeVahed from VahedName V Left join Gharardadno G On V.ID=G.VahedNoID Where V.MajmooeID='" & GetMajmooeID(Me.cboMajmooeName2.Text) & "' And V.VahedTypeID='" & GetVahedTypeID(Me.cboVahedtype2.Text) & "' And V.ZoneID='" & GetZoneID(GetMajmooeID(Me.cboMajmooeName2.Text), Me.cboZone2.Text) & "' And V.VahedNo='" & Me.cboGhateNo2.Text & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.txtMoshtariName2.Text = sdr2(0).ToString
            Me.lblID2.Text = sdr2(1).ToString
            Me.txtGharardadNo2.Text = sdr2(2).ToString
            Me.txtMoshtariName2.BackColor = Color.White
        End While
        SQLCONection.SqlCon.Close()
    End Sub

    Private Sub cboVahedtype2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboVahedtype2.SelectedIndexChanged
        Me.cboZone2.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Zone from Zone where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName2.Text) & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboZone2.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub


    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        Dim Temp1(4), Temp2(4) As String

        Temp1(0) = GetMajmooeID(Me.cboMajmooeName.Text)
        Temp1(1) = Me.txtGharardadNo1.Text
        Temp1(2) = Me.lblID1.Text
        Temp1(3) = Me.cboGhateNo1.Text

        Temp2(0) = GetMajmooeID(Me.cboMajmooeName2.Text)
        Temp2(1) = Me.txtGharardadNo2.Text
        Temp2(2) = Me.lblID2.Text
        Temp2(3) = Me.cboGhateNo2.Text


        Dim SQLCONection As New SQL
        Dim cmd2 As New SqlClient.SqlCommand
        cmd2.Connection = SQLCONection.SqlCon
        cmd2.CommandText = "Update gharardadNo Set VahedNoID='" & Me.lblTmpID.Text & "' Where VahedNoID='" & Me.lblID2.Text & "'  Update Bank Set ID='" & Me.lblTmpID.Text & "' Where ID='" & Me.lblID2.Text & "'"
        SQLCONection.SqlCon.Open()
        cmd2.ExecuteNonQuery()
        SQLCONection.SqlCon.Close()


        cmd2.CommandText = "Update gharardadNo Set MajmooeNameID='" & Temp2(0) & "',GharardadNo=N'" & Temp2(1) & "',VahedNoID='" & Temp2(2) & "',VahedCode='" & Temp2(3) & "' Where VahedNoID='" & Me.lblID1.Text & "'  Update Bank Set ID='" & Temp2(2) & "' Where ID='" & Me.lblID1.Text & "'"
        SQLCONection.SqlCon.Open()
        cmd2.ExecuteNonQuery()
        SQLCONection.SqlCon.Close()


        cmd2.CommandText = "Update gharardadNo Set MajmooeNameID='" & Temp1(0) & "',GharardadNo=N'" & Temp1(1) & "',VahedNoID='" & Temp1(2) & "',VahedCode='" & Temp1(3) & "' Where VahedNoID='" & Me.lblTmpID.Text & "'  Update Bank Set ID='" & Temp1(2) & "' Where ID='" & Me.lblTmpID.Text & "'"
        SQLCONection.SqlCon.Open()
        cmd2.ExecuteNonQuery()
        SQLCONection.SqlCon.Close()

        GetGharardadNo1()
        GetGharardadNo2()
        MessageBox.Show("انتقال با موفقیت انجام شد", "جابجائی قطعات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False)

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


    Private Sub cboZone2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboZone2.SelectedIndexChanged
        Dim SQLCONection As New SQL
        Dim cmd2 As New SqlClient.SqlCommand("Select VahedNo from VahedName Where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName2.Text) & "' And VahedTypeID='" & GetVahedTypeID(Me.cboVahedtype2.Text) & "' And ZoneID='" & GetZoneID(GetMajmooeID(Me.cboMajmooeName2.Text), Me.cboZone2.Text) & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboGhateNo2.Items.Add(sdr2(0).ToString)
        End While
        SQLCONection.SqlCon.Close()
    End Sub

 
End Class