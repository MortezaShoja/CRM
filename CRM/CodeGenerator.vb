Public Class CodeGenerator

    Private SqlCon As New SQL

    Private Cmd As New SqlClient.SqlCommand
    Private DC As New DateConvertor
    Private Year As String = String.Empty
    Private Month As String = String.Empty

    Public Function GenerateGharadadNo(ByVal Place As String, ByVal Zone As String)
        If Place = "" Or Zone = "" Then
            Return "خطا"
        Else
            DC.Convertor()
            Year = Mid(DC.Hyear, 3, 2)
            Month = DC.Hmonth

            ' get Number Count
            Dim ID As String = GetMajmooeCount(Place)
            Dim M As String = (GetPlaceCode(Place) & Year & Month & Zone & Generate(ID))
            Return (GetPlaceCode(Place) & Year & Month & Zone & Generate(ID))
        End If
    End Function

    Public Function GenerateParvandeNo(ByVal Place As String, ByVal Zone As String)
        If Place = "" Or Zone = "" Then
            Return "خطا"
        Else
            DC.Convertor()
            Year = Mid(DC.Hyear, 3, 2)

            ' get Number Count
            Dim ID As String = GetMajmooeCount(Place)
            Dim M As String = (GetPlaceCode(Place) & Year & Month & Zone & Generate(ID))
            Return ("پ" & Year & GetPlaceCode(Place) & Zone & Generate(ID))
        End If

    End Function
    Private Function GetPlaceCode(ByVal Place As String)
        Cmd.Connection = SqlCon.SqlCon
        Cmd.CommandText = "SELECT CodingCodeFA from Majmooe where Majmooe=N'" & Place & "'"
        Dim C As String = String.Empty
        SqlCon.SqlCon.Open()
        Dim sdr As SqlClient.SqlDataReader = Cmd.ExecuteReader
        While sdr.Read
            C = (sdr(0).ToString)
        End While
        SqlCon.SqlCon.Close()
        Return C
        sdr.Close()
    End Function

    Private Function GetMajmooeCount(ByVal Place As String)
        Dim SqlCon1 As New SQL
        If Place <> String.Empty Then
            Dim V As String = String.Empty

            Cmd.Connection = SqlCon1.SqlCon
            Cmd.CommandText = "SELECT ID from Majmooe where Majmooe=N'" & Place & "'"
            SqlCon1.SqlCon.Open()
            Dim sdr2 As SqlClient.SqlDataReader = Cmd.ExecuteReader
            While sdr2.Read
                V = (sdr2(0).ToString)
            End While
            sdr2.Close()
            SqlCon1.SqlCon.Close()
            Return V
        Else
            Return ""
        End If
    End Function

    Private Function Generate(ByVal ID As String)
        Dim V2 As String = String.Empty
        Dim V3 As String = String.Empty
        Dim SqlCon2 As New SQL
        SqlCon2.SqlCon.Open()
        '--------------------- Get Count 
        Dim Cmdd As New SqlClient.SqlCommand
        Cmdd.Connection = SqlCon2.SqlCon
        Cmdd.CommandText = "SELECT count(*) from GharardadNo where MajmooeNameID='" & ID & "'"
        Dim sdrd As SqlClient.SqlDataReader = Cmdd.ExecuteReader
        While sdrd.Read
            V2 = (sdrd(0).ToString)
        End While
        SqlCon2.SqlCon.Close()

        If V2 <> String.Empty Then
            If V2.Length = 1 Then
                V3 = "00" & (Integer.Parse(V2) + 1).ToString
            ElseIf V2.Length = 2 Then
                V3 = "0" & (Integer.Parse(V2) + 1).ToString
            ElseIf V2.Length = 3 Then
                V3 = (Integer.Parse(V2) + 1).ToString
            ElseIf V2.Length > 3 Then
                V3 = "Out Of Range"
            End If
            Return V3
        Else
            Return ("1")
        End If


    End Function

End Class
