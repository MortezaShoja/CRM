Public Class frmRegMostahdisat
    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private CD As CurrentDate
    Private CU As Currency


    Private Sub frmRegMostahdisat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FillCboMajmooe()
        CD = New CurrentDate
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

    Private Sub FillCboSayerePardakhtHa(ByVal MajmooeID As String)
        CU = New Currency
        Me.cboSayerJahate.Items.Clear()
        Me.cboSayerJahate.Items.Add("")
        Dim SQLCONection As New SQL
        Dim cmd2 As New SqlClient.SqlCommand("SELECT Jahate,Price from SayerePardakhtHa Where MajmooeID='" & MajmooeID & "'", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        If sdr2.Read Then
            Me.cboSayerJahate.Items.Add(sdr2(0).ToString)
            Me.txtPrice.Text = CU.CodeNumber(sdr2(1).ToString)
        End If
        SQLCONection.SqlCon.Close()
    End Sub

    Private Sub btnCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheck.Click
        Dim CC() As String = CountUnPaidSayer(CountPaidSayer).ToString.Split(",")
        MessageBox.Show("تعداد قراردادهای نیازمند بروزرسانی " & CC.Length - 1 & " می باشد ", "تعداد قراردادها", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False)
    End Sub

    Private Function CountPaidSayer()
        Dim Value As String = String.Empty
        Dim SQLCONection As New SQL
        Dim cmd2 As New SqlClient.SqlCommand("select B.ID From GharardadNo G inner Join Bank B On G.VahedNoID=B.ID Where B.Jahate=N'" & Me.cboSayerJahate.Text & "' AND G.MajmooeNameID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "' group by B.ID,G.gharardadno order by G.gharardadno", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Value += "B.ID !='" & sdr2(0).ToString & "' AND "
        End While
        SQLCONection.SqlCon.Close()
        'If Value.Length > 0 Then
        '    Value = Mid(Value, 1, Value.Length - 4)
        'End If
        Return Value
    End Function

    Private Function CountUnPaidSayer(ByVal ShartList As String)
        Dim Value As String = String.Empty
        Dim SQLCONection As New SQL
        Dim cmd2 As New SqlClient.SqlCommand("select B.ID From GharardadNo G inner Join Bank B On G.VahedNoID=B.ID Where " & ShartList & " G.MajmooeNameID='" & GetMajmooeID(Me.cboMajmooeName.Text) & "' group by B.ID,G.gharardadno order by G.gharardadno", SQLCONection.SqlCon)
        SQLCONection.SqlCon.Open()
        Dim sdr2 As SqlClient.SqlDataReader = cmd2.ExecuteReader
        While sdr2.Read
            Value += sdr2(0).ToString & ","
        End While
        SQLCONection.SqlCon.Close()
        If Value.Length > 0 Then
            Value = Mid(Value, 1, Value.Length - 1)
        End If
        Return Value
    End Function

    Private Sub cboMajmooeName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMajmooeName.SelectedIndexChanged
        Me.txtDate.Text = ""
        Me.txtPrice.Text = ""
        FillCboSayerePardakhtHa(GetMajmooeID(Me.cboMajmooeName.Text))
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Dim IDS() As String = CountUnPaidSayer(CountPaidSayer).ToString.Split(",")
        CU = New Currency
        CD = New CurrentDate

        For I As Integer = 0 To IDS.Length - 1
            Dim SQLCONection As New SQL
            Dim cmd2 As New SqlClient.SqlCommand("insert into Bank (ID,price,AccountNo,accountOwner,Serial,CodePeygiri,date,VarizTime,destinationAccount,Tozihat,Passed,RegDate,RegDay,Pardakhte,FormType,Jahate) values ('" & IDS(I) & "',N'" & CU.DeCodeNumber(Me.txtPrice.Text) & "',N'',N'',N'',N'',N'" & Me.txtDate.Text & "',N'',N'',N'','False',N'" & CD.GetDate & "',N'" & CD.GetDay & "',N'سایر پرداخت ها',N'واریز به حساب',N'" & Me.cboSayerJahate.Text & "')", SQLCONection.SqlCon)
            SQLCONection.SqlCon.Open()
            cmd2.ExecuteNonQuery()
            SQLCONection.SqlCon.Close()
        Next
        MessageBox.Show("ثبت اطلاعات با موفقیت انجام شد" & vbCrLf & "تعداد " & IDS.Length - 1 & " رکورد ثبت گردید ", "ثبت هزینه های مستحدیثات", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, False)
    End Sub

    Private Sub txtDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.GotFocus
        Try
            Dim DM As New DateMode
            Me.txtDate.Text = DM.DECodeDate(Me.txtDate.Text)
        Catch ex As Exception
            Me.txtDate.Focus()
        End Try
    End Sub

    Private Sub txtDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDate.LostFocus
        Try
            Dim DM As New DateMode
            Me.txtDate.Text = DM.CodeDate(Me.txtDate.Text)
        Catch ex As Exception
            Me.txtDate.Focus()
        End Try
    End Sub

    Private Sub txtPrice_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.GotFocus

        Try
            Dim TmpPrice As String = Me.txtPrice.Text.Replace(",", "")
            TmpPrice = TmpPrice.Replace("ریال", "")
            If IsNumeric(TmpPrice) = True Then
                Me.txtPrice.Text = CU.DeCodeNumber(Me.txtPrice.Text)
            End If
        Catch ex As Exception
            Me.txtPrice.Focus()
        End Try
    End Sub

    Private Sub txtPrice_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrice.LostFocus

        Try
            Me.txtPrice.Text = CU.CodeNumber(Me.txtPrice.Text)
        Catch ex As Exception
            Me.txtPrice.Focus()
        End Try

    End Sub

    Private Sub cboSayerJahate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSayerJahate.SelectedIndexChanged
        CD = New CurrentDate
        Me.txtDate.Text = CD.GetDate
    End Sub
End Class