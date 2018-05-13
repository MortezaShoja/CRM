Public Class frmDeleteGharadad

    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private Cu As New Currency

    Private Sub frmDeleteGharadad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCboVahedtype()
        FillCboMajmooe()
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

    Private Sub cboMajmooeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajmooeName.SelectedIndexChanged
        Me.cboZone.Items.Clear()
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Zone from Zone where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "'", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboZone.Items.Add(sdr2(0).ToString)
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
    Private Function GetZoneID(ByVal Zone As String)
        Dim SQLCONection As New SQL
        Dim V As String = String.Empty
        Dim cmd2 As New SqlClient.SqlCommand("SELECT ID from Zone where Zone=N'" & Zone & "'", SQLCONection.SqlCon)
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


    Private Sub cboZone_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboZone.SelectedIndexChanged
        Dim SQLCONection As New SQL
        Dim cmd2 As New SqlClient.SqlCommand("Select VahedNo from VahedName Where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "' And VahedTypeID='" & GetVahedTypeID(Me.cboVahedtype.Text) & "' And ZoneID='" & GetZoneID(Me.cboZone.Text) & "'", SQLCONection.SqlCon)
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
        Me.lblVahedNoID.Text = ""
        Me.txtMoshtariName1.Text = ""
        Me.txtGharardadNo1.Text = ""
        Me.txtMoshtariName1.BackColor = Color.Red
        Dim SQLCONection As New SQL
        Dim cmd2 As New SqlClient.SqlCommand("Select G.Name + ' ' + G.Lname as 'FullName',V.ID,V.CodeVahed from VahedName V Left join Gharardadno G On V.ID=G.VahedNoID Where V.MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "' And V.VahedTypeID='" & GetVahedTypeID(Me.cboVahedtype.Text) & "' And V.ZoneID='" & GetZoneID(Me.cboZone.Text) & "' And V.VahedNo='" & Me.cboGhateNo1.Text & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.txtMoshtariName1.Text = sdr2(0).ToString
            Me.lblVahedNoID.Text = sdr2(1).ToString
            Me.txtGharardadNo1.Text = sdr2(2).ToString
            Me.txtMoshtariName1.BackColor = Color.White
        End While
        SQLCONection.SqlCon.Close()
    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If MessageBox.Show("آیا مایلید اطلاعات فوق حذف گردد؟", "حذف اطلاعات", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign) = Windows.Forms.DialogResult.Yes = True Then
            Try
                Dim cmd As New SqlClient.SqlCommand("Delete Bank where ID='" & Me.lblVahedNoID.Text & "'         Delete GharardadNo Where VahedNoID='" & Me.lblVahedNoID.Text & "'    Update VahedName Set Sold='0' Where ID='" & Me.lblVahedNoID.Text & "'", SqlCon.SqlCon)
                SqlCon.SqlCon.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("حذف اطلاعات با موفقیت انجام شد", "حذف اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Catch ex As Exception
                MessageBox.Show("حذف اطلاعات با خطا مواجه شد" & ex.ToString, "حذف اطلاعات", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Finally
                SqlCon.SqlCon.Close()
            End Try
        End If
        GetGharardadNo1()
    End Sub
End Class