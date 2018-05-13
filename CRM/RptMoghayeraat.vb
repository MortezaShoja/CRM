Public Class RptMoghayeraat
    Private SqlConnection As SQL
    Private Cmd1 As SqlClient.SqlCommand
    Private Sdr1 As SqlClient.SqlDataReader
    Private tbl1 As DataTable
    Private CD As CurrentDate
    Private CU As Currency
    Private NtoW As NumberToWord
    Private GS As GetSum


    Public Function Generate()

        CU = New Currency
        NtoW = New NumberToWord
        GS = New GetSum

        Dim value As Boolean = False
        'If System.IO.Directory.Exists("C:\Reports") = False Then
        '    System.IO.Directory.CreateDirectory("C:\Reports")
        'End If
        tbl1 = New DataTable
        tbl1.TableName = "Moghayerat"
        Try
            SqlConnection = New SQL
            tbl1.Clear()
            Cmd1 = New SqlClient.SqlCommand("Select G.VahedNoID,M.Majmooe,Z.Zone as 'فاز',G.VahedCode as 'Shomare Ghete',[Name]+' '+LName as 'FullName',G.GHarardadPrice from GharardadNo G inner Join VahedName V on  V.ID=G.VahedNoID inner join Majmooe M On M.ID=G.MajmooeNameID inner Join Zone Z On V.ZoneId = Z.ID Order by M.Majmooe,Z.Zone,G.VahedCode", SqlConnection.SqlCon)
            SqlConnection.SqlCon.Open()

            Dim sdr As Data.SqlClient.SqlDataReader = Cmd1.ExecuteReader

            tbl1.Columns.Add("محل پروژه")
            tbl1.Columns.Add("فاز فروش")
            tbl1.Columns.Add("شماره قطعه")
            tbl1.Columns.Add("نام و نام خانوادگی")
            tbl1.Columns.Add("مبلغ کل")
            tbl1.Columns.Add("پیش پرداخت") '-------
            tbl1.Columns.Add("اقساط") '-------
            tbl1.Columns.Add("مغایرت") '-------

            While (sdr.Read)
                If (GS.GetSum(sdr(0).ToString, "اقساط")) + (GS.GetSum(sdr(0).ToString, "پیش پرداخت")) - sdr(5) <> 0 Then
                    Dim row As DataRow = tbl1.NewRow
                    row(0) = sdr(1)
                    row(1) = sdr(2)
                    row(2) = sdr(3)
                    row(3) = sdr(4)
                    row(4) = CU.CodeNumber(sdr(5))
                    row(5) = CU.CodeNumber(GS.GetSum(sdr(0).ToString, "پیش پرداخت"))
                    row(6) = CU.CodeNumber(GS.GetSum(sdr(0).ToString, "اقساط"))
                    row(7) = CU.CodeNumber((GS.GetSum(sdr(0).ToString, "اقساط")) + (GS.GetSum(sdr(0).ToString, "پیش پرداخت")) - sdr(5))

                    tbl1.Rows.Add(row)
                End If
            End While
            value = True
            tbl1.WriteXml("C:\Reports\Moghayerat.XML")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Write Data1")
        Finally
            SqlConnection.SqlCon.Close()
        End Try

        Return value
    End Function




End Class
