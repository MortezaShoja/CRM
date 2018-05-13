Public Class SanadCodeGenerator
    Private SqlConnection As New SQL
    Private Cmd1 As SqlClient.SqlCommand
    Private Sdr1 As SqlClient.SqlDataReader
    Private tbl1 As DataTable
    Private dvw1 As DataView
    Private DC As DateConvertor

    Public Function Generate()
        Dim Value As String = 0
        DC = New DateConvertor
        DC.Convertor()
        Value = Mid(DC.Hyear, 3, 2) + DC.Hmonth.ToString & DC.Hday.ToString & Now.Hour.ToString & Now.Second.ToString & Now.Millisecond.ToString & GetCountOfBank().ToString
        Return Value
    End Function

    Private Function GetCountOfBank()
        Dim Value As Integer
        Cmd1 = New SqlClient.SqlCommand("select Count(*) from Bank", SqlConnection.SqlCon)
        SqlConnection.SqlCon.Open()
        Try
            Sdr1 = Cmd1.ExecuteReader
            If Sdr1.Read Then
                Value = Sdr1(0)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...GetCountOfBank", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlConnection.SqlCon.Close()
        End Try
        Return Value
    End Function

End Class
