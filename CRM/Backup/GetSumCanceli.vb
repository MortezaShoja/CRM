Public Class GetSumCanceli


    Private SqlConGetSum As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader

    Public Function GetSum(ByVal OwnerID As String, ByVal Type As String)
        Dim Value As Integer = 0

        Dim cmd As New SqlClient.SqlCommand("Select sum(price) from GHarardadDelBank where ID=N'" & OwnerID & "' AND Pardakhte=N'" & Type & "' AND Pardakhte!=N'سایر پرداخت ها'", SqlConGetSum.SqlCon)
        Dim Sum As String = String.Empty
        SqlConGetSum.SqlCon.Close()
        SqlConGetSum.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            If sdr.Read Then
                Sum = (sdr(0).ToString)
            End If
        Catch ex As Exception
            Sum = 0
            'MessageBox.Show(ex.Message.ToString, " خطا در جمع مبالغ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally

            SqlConGetSum.SqlCon.Close()
        End Try
        If Sum <> String.Empty Then
            Return Integer.Parse(Sum)
        Else
            Return 0
        End If

        Return Value
    End Function

    Public Function GetSumPardakhtShode(ByVal OwnerID As String, ByVal Type As String)
        Dim Value As Integer = 0

        Dim cmd As New SqlClient.SqlCommand("Select sum(price) from GHarardadDelBank where ID=N'" & OwnerID & "' AND Pardakhte=N'" & Type & "' AND Passed='1'", SqlConGetSum.SqlCon)
        Dim Sum As String = String.Empty
        SqlConGetSum.SqlCon.Close()
        SqlConGetSum.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            If sdr.Read Then
                Sum = (sdr(0).ToString)
            End If
        Catch ex As Exception
            Sum = 0
            'MessageBox.Show(ex.Message.ToString, " خطا در جمع مبالغ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally

            SqlConGetSum.SqlCon.Close()
        End Try
        If Sum <> String.Empty Then
            Return Integer.Parse(Sum)
        Else
            Return 0
        End If

        Return Value
    End Function

    Public Function GetSumPardakhtNaShode(ByVal OwnerID As String, ByVal Type As String)
        Dim Value As Integer = 0

        Dim cmd As New SqlClient.SqlCommand("Select sum(price) from GHarardadDelBank where ID=N'" & OwnerID & "' AND Pardakhte=N'" & Type & "' AND Passed='0'", SqlConGetSum.SqlCon)
        Dim Sum As String = String.Empty
        SqlConGetSum.SqlCon.Close()
        SqlConGetSum.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            If sdr.Read Then
                Sum = (sdr(0).ToString)
            End If
        Catch ex As Exception
            Sum = 0
            'MessageBox.Show(ex.Message.ToString, " خطا در جمع مبالغ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally

            SqlConGetSum.SqlCon.Close()
        End Try
        If Sum <> String.Empty Then
            Return Integer.Parse(Sum)
        Else
            Return 0
        End If

        Return Value
    End Function

    Public Function GetCount(ByVal OwnerID As String, ByVal Type As String)
        Dim Value As Integer = 0

        Dim cmd As New SqlClient.SqlCommand("Select Count(price) from GHarardadDelBank where ID=N'" & OwnerID & "' AND Pardakhte=N'" & Type & "'", SqlConGetSum.SqlCon)
        Dim Sum As String = String.Empty
        SqlConGetSum.SqlCon.Close()
        SqlConGetSum.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = cmd.ExecuteReader
        Try
            If sdr.Read Then
                Sum = (sdr(0).ToString)
            End If
        Catch ex As Exception
            Sum = 0
            'MessageBox.Show(ex.Message.ToString, " خطا در جمع مبالغ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally

            SqlConGetSum.SqlCon.Close()
        End Try
        If Sum <> String.Empty Then
            Return Integer.Parse(Sum)
        Else
            Return 0
        End If

        Return Value
    End Function
End Class
