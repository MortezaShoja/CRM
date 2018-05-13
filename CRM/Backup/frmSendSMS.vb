Public Class frmSendSMS


    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private tbl As New DataTable
    Private dvw As DataView
    Private b As Boolean
    Private GharardadID As String
    Private Where As String = String.Empty
    Private DC As New DateConvertor
    Public FillTextBoxID As String
    Public Dialog As Boolean
    Private CC As Integer
    Private SMC As SendSMSConnection
    Private CD As CurrentDate

    Private Sub FillGrid()

        CC = 0

        '------------
        If Me.cboMajmooeName.Text <> String.Empty Then
            Where += " G.MajmooeNameID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "' AND "
        End If
        '------------
        If Me.cboZone.Text <> String.Empty Then
            Where += " V.ZoneID='" & GetZoneID(Me.cboZone.Text) & "' AND "
        End If
        '------------
        If Me.txtName.Text <> String.Empty Then
            Where = " G.Name Like N'%" & Me.txtName.Text & "%' AND "
        End If
        '------------
        If Me.txtLname.Text <> String.Empty Then
            Where += " G.LName Like N'%" & Me.txtLname.Text & "%' AND "
        End If
        '------------
        If Me.txtPhone.Text <> String.Empty Then
            Where += " (G.HomePhone Like N'%" & Me.txtPhone.Text & "%' Or G.WorkPhone Like N'%" & Me.txtPhone.Text & "%' OR G.Mobile Like N'%" & Me.txtPhone.Text & "%') AND "
        End If



        If Where <> String.Empty Then
            Where = Mid(Where, 1, Where.Length - 4)
            Where = " Where " + Where
        Else
            Where = ""
        End If


        Me.chkSallerList.Items.Clear()
        Cmd.CommandText = "Select G.[Name]+' '+G.LName + '_' + G.Gharardadno from GharardadNo G Inner Join VahedName V On G.VahedNoID=V.ID " & Where & " Order By G.GharardadNo"
        Cmd.Connection = SqlCon.SqlCon
        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = Cmd.ExecuteReader
        While sdr.Read
            Me.chkSallerList.Items.Add(sdr(0).ToString)
        End While
        SqlCon.SqlCon.Close()

        Where = String.Empty
        Me.CheckBox1.Text = "انتخاب کل مشترکین" & " -- " & Me.chkSallerList.Items.Count.ToString
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        FillGrid()
        RefreshText()
        MessageBox.Show("تعداد " & CC.ToString & " عدد قرارداد یافته شد", "جستجو", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    End Sub

    Private Sub RefreshText()
        Dim Tc As Control
        For Each Tc In Me.Controls
            If TypeOf Tc Is TextBox AndAlso Tc.Text <> "" Then
                Tc.Text = String.Empty
            End If
        Next
        Me.txtSampleNumber.Text = "09193091961"
    End Sub

    Private Sub frmCallGharardad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillGrid()
        FillCboMajmooe()
    End Sub

    Private Sub FillCboMajmooe()
        Me.cboMajmooeName.Items.Clear()
        Me.cboMajmooeName.Items.Add("")
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Majmooe from Majmooe", SqlCon.SqlCon)
        SqlCon.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Me.cboMajmooeName.Items.Add(sdr2(0).ToString)
        End While
        SqlCon.SqlCon.Close()
    End Sub

    Private Sub cboMajmooeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajmooeName.SelectedIndexChanged
        If Me.cboMajmooeName.Text <> "" Then
            Me.cboZone.Items.Clear()
            Me.cboZone.Items.Add("")
            Dim cmd2 As New SqlClient.SqlCommand("SELECT Zone from Zone where MajmooeID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "'", SqlCon.SqlCon)
            SqlCon.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
            While sdr2.Read
                Me.cboZone.Items.Add(sdr2(0).ToString)
            End While
            SqlCon.SqlCon.Close()
        Else
            Me.cboZone.Items.Clear()
            Me.cboZone.Text = ""
        End If
    End Sub

    Private Sub cboVahedtype_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            For I As Integer = 0 To Me.chkSallerList.Items.Count - 1
                Me.chkSallerList.SetItemCheckState(I, CheckState.Checked)
            Next
        Else
            For I As Integer = 0 To Me.chkSallerList.Items.Count - 1
                Me.chkSallerList.SetItemCheckState(I, CheckState.Unchecked)
            Next
        End If

    End Sub
    Private Function GetSelectedCount()
        Dim C As Integer = 0
        For i As Integer = 0 To Me.chkSallerList.Items.Count - 1
            If Me.chkSallerList.GetItemChecked(i) = True Then
                C += 1
            End If
        Next
        Return C
    End Function

    Private Sub btnSendMessages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendMessages.Click
        Dim MobileNu As String = String.Empty
        Dim VahedNameID As String = String.Empty
        If Me.txtMessageText.Text.Length > 3 Then
            If GetSelectedCount() > 0 Then
                If MessageBox.Show("تعداد مشترکین انتخاب شده جهت ارسال پیامک " & GetSelectedCount.ToString & " نفر می باشد " & vbCrLf & "آیا مایل به ارسال پیامک هستید؟", "ارسال پیامک", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False) = Windows.Forms.DialogResult.Yes Then
                    Try

                        For I As Integer = 0 To Me.chkSallerList.Items.Count - 1
                            If Me.chkSallerList.GetItemChecked(I) = True Then
                                Dim GN() As String = Me.chkSallerList.Items.Item(I).ToString.Split("_")
                                Dim SQLCONection As New SQL
                                Dim cmd2 As New SqlClient.SqlCommand("SELECT VahedNoID,Mobile from GharardadNo where GharardadNo=N'" & GN(1).ToString & "'", SQLCONection.SqlCon)
                                SQLCONection.SqlCon.Open()
                                Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
                                If sdr2.Read Then
                                    If sdr2(0).ToString <> "" Then
                                        VahedNameID = Sdr(0).ToString
                                        MobileNu = sdr2(1).ToString
                                    End If
                                End If
                                SQLCONection.SqlCon.Close()
                            End If

                            '-------------- Send SMS ----------------
                            Dim GSCI As New GetSmsCenterInfo
                            Dim FD As New FillData
                            SMC = New SendSMSConnection
                            Dim IDD As String = Guid.NewGuid.ToString
                            CD = New CurrentDate
                            '------------------------------------------------------------------
                            FD.SaveData(IDD, GSCI.GetSMSAghsatInfo(3), Me.txtMessageText.Text, MobileNu, CD.GetDay, Now.TimeOfDay.ToString, VahedNameID, "اطلاع رسانی")
                            '------------------------------------------------------------------
                            SMC.Send(IDD, MobileNu, GSCI.GetSMSAghsatInfo(3), Me.txtMessageText.Text, "Normal")
                        Next
                        'MobileNu = Mid(MobileNu, 1, MobileNu.Length - 1)
                        'MessageBox.Show(MobileNu)
                        MessageBox.Show("کل پیامک ها با موفقیت ارسال گردید", "ارسال پیامک", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                    Catch ex As Exception
                        'MessageBox.Show(MobileNu)
                    End Try
                End If
                'If Me.txtSampleNumber.Text.Length = 11 Then
                '    MobileNu = MobileNu & "," & Me.txtSampleNumber.Text
                'End If
                
            Else
                MessageBox.Show("هیچ مشترکی جهت ارسال انتخاب نشده است" & vbCrLf & "ابتدا اشخاص مورد نظر خود را انتخاب کنید")
            End If
        Else
            MessageBox.Show("هیچ متنی جهت ارسال انتخاب نشده است" & vbCrLf & "ابتدا متن پیامک مورد نظر خود را انتخاب کنید")
        End If
    End Sub

    Private Sub txtMessageText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMessageText.TextChanged
        Me.btnSendMessages.Text = " ارسال پیامک " & Me.txtMessageText.Text.Length.ToString
    End Sub

End Class