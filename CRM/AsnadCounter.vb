Public Class AsnadCounter
    Private SqlCon As New SQL
    Private Check, Naghdi, Safte, Havale, Tahator As Integer
    Private Out As String
    Dim cmdD As New SqlClient.SqlCommand

    Public Function Count(ByVal ID As String, ByVal Type As String)



        cmdD.CommandText = ("select count(*) from [check] Where Pardakhte=N'" & Type & "' And ID='" & ID & "'")
        cmdD.Connection = SqlCon.SqlCon
        SqlCon.SqlCon.Open()
        Dim sdrD As SqlClient.SqlDataReader
        sdrD = cmdD.ExecuteReader
        Try
            If sdrD.Read Then
                Check = sdrD(0)
            End If
            SqlCon.SqlCon.Close()

            SqlCon.SqlCon.Open()
            cmdD.CommandText = ("select count(*) from Naghdi Where Pardakhte=N'" & Type & "' And ID='" & ID & "'")
            sdrD = cmdD.ExecuteReader
            If sdrD.Read Then
                Naghdi = sdrD(0)
            End If
            SqlCon.SqlCon.Close()

            SqlCon.SqlCon.Open()
            cmdD.CommandText = ("select count(*) from Safte Where Pardakhte=N'" & Type & "' And ID='" & ID & "'")
            sdrD = cmdD.ExecuteReader
            If sdrD.Read Then
                Safte = sdrD(0)
            End If
            SqlCon.SqlCon.Close()

            SqlCon.SqlCon.Open()
            cmdD.CommandText = ("select count(*) from Havale Where Pardakhte=N'" & Type & "' And ID='" & ID & "'")
            sdrD = cmdD.ExecuteReader
            If sdrD.Read Then
                Havale = sdrD(0)
            End If
            SqlCon.SqlCon.Close()

            SqlCon.SqlCon.Open()
            cmdD.CommandText = ("select count(*) from Tahator Where Pardakhte=N'" & Type & "' And ID='" & ID & "'")
            sdrD = cmdD.ExecuteReader
            If sdrD.Read Then
                Tahator = sdrD(0)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا در شمارش تعداد " & Type & "", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlCon.SqlCon.Close()
        End Try


        If Check > 0 Then Out += "طی" & " " & Check & " " & "فقره چک" & " "
        If Safte > 0 Then Out += " و الباقی طی " & " " & Check & " " & "فقره سفته" & " "
        If Havale > 0 Then Out += " و الباقی طی " & " " & Check & " " & "فقره حواله" & " "
        Return (Out)
    End Function


End Class
