Public Class RptResidDaryaftVajh
    Private SqlConnection As SQL
    Private Cmd1 As SqlClient.SqlCommand
    Private Sdr1 As SqlClient.SqlDataReader
    Private tbl1 As DataTable
    Private CD As CurrentDate
    Private CU As Currency
    Private NtoW As NumberToWord
    Private GS As GetSum
    Private GC As GhestCount


    Public Function Generate(ByVal Row_Number As String)

        Dim NoePardakht As String = String.Empty
        GC = New GhestCount
        CU = New Currency
        NtoW = New NumberToWord
        GS = New GetSum

        Dim value As Boolean = False
        'If System.IO.Directory.Exists("C:\Reports") = False Then
        '    System.IO.Directory.CreateDirectory("C:\Reports")
        'End If
        tbl1 = New DataTable
        tbl1.TableName = "ResideDaryaftReport"
        Try
            SqlConnection = New SQL
            tbl1.Clear()
            '                                         0     1               2                           3           4           5               6           7           8            9           10              11         12        13          14        15      16
            Cmd1 = New SqlClient.SqlCommand("Select B.ID,G.GharardadNo,G.Gender,G.[Name]+' '+LName as 'FullName',B.FormType,B.Pardakhte,B.AccountOwner,B.AccountNo,B.Serial,B.CodePeygiri,B.OwnerBank,B.DestinationAccount,B.Price,B.Date,B.PardakhtDate,B.Tozihat,B.Row from GharardadNo G inner Join Bank B On B.ID=G.VahedNoID where B.Row='" & Row_Number & "'", SqlConnection.SqlCon)
            SqlConnection.SqlCon.Open()

            Dim sdr As Data.SqlClient.SqlDataReader = Cmd1.ExecuteReader

            tbl1.Columns.Add("شماره سند")
            tbl1.Columns.Add("شماره قرارداد")
            tbl1.Columns.Add("نام و نام خانوادگی")
            tbl1.Columns.Add("شرح پرداخت")
            tbl1.Columns.Add("نوع پرداخت")
            tbl1.Columns.Add("مبلغ")
            tbl1.Columns.Add("مبلغ به حروف")
            tbl1.Columns.Add("تاریخ سررسید")
            tbl1.Columns.Add("تاریخ پرداخت")
            tbl1.Columns.Add("توضیحات")

            tbl1.Columns.Add("مانده اقساط")

            While (sdr.Read)

                Dim row As DataRow = tbl1.NewRow
                row(0) = Row_Number
                row(1) = sdr(1)
                If sdr(2) = False Then
                    row(2) = "جناب آقای " & sdr(3).ToString
                Else
                    row(2) = "سرکار خانم " & sdr(3).ToString
                End If

                Select Case sdr(4)
                    Case Is = "چکی"
                        row(3) = "چک به شماره " & sdr(8).ToString & " عهده بانک " & sdr(10).ToString & " به نام " & sdr(6).ToString & "  " & sdr(7).ToString & " به تاریخ سررسید " & sdr(14).ToString
                        NoePardakht = "چک اقساط"
                    Case Is = "حواله"
                        row(3) = "واریز به حساب " & sdr(11).ToString & " از حساب " & sdr(6).ToString & "  " & sdr(7).ToString & " به شماره پیگیری " & sdr(8).ToString & "  " & sdr(9).ToString & " در تاریخ " & sdr(14).ToString
                        NoePardakht = "قسط"
                    Case Is = "سفته"
                        row(3) = "سفته به شماره " & sdr(8).ToString & " به تاریخ سررسید " & sdr(13).ToString
                        NoePardakht = "قسط"
                    Case Is = "تهاتر"
                        row(3) = "تهاتر به ارزش " & CU.CodeNumber(sdr(12)) & " معادل " & NtoW.Convert(sdr(12))
                        NoePardakht = "قسط"
                    Case Is = "نقدی"
                        row(3) = "پرداخت نقدی در تاریخ " & sdr(13).ToString
                        NoePardakht = "قسط"
                    Case Is = "واریز به حساب"
                        row(3) = "واریز به حساب " & sdr(11).ToString & " از حساب " & sdr(6).ToString & "  " & sdr(7).ToString & " به شماره پیگیری " & sdr(8).ToString & "  " & sdr(9).ToString & " در تاریخ " & sdr(14).ToString
                        NoePardakht = "قسط"
                End Select

                row(4) = NoePardakht & " شماره " & GC.GhestRow(sdr(0).ToString, sdr(5), sdr(16))
                row(5) = CU.CodeNumber(sdr(12))
                row(6) = NtoW.Convert(sdr(12))
                row(7) = sdr(13)
                row(8) = sdr(14)
                row(9) = sdr(15)
                row(10) = CU.CodeNumber(JameAghsat(sdr(0).ToString))

                tbl1.Rows.Add(row)
            End While
            value = True
            tbl1.WriteXml("C:\Reports\RptResideDaryaft.XML")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Write Data1")
        Finally
            SqlConnection.SqlCon.Close()
        End Try
        Return value
    End Function

    Private Function JameAghsat(ByVal VahedID As String)
        Dim Value As Integer
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("Select Sum(price)as 'Jame Aghsat' from Bank  where ID='" & VahedID & "' And Passed='0' group by ID", SqlRpt.SqlCon)
        SqlRpt.SqlCon.Open()
        Try
            SdrRpt = CmdRpt.ExecuteReader()
            If SdrRpt.Read Then
                Value = Integer.Parse(SdrRpt(0).ToString)
            End If
            SdrRpt.Close()
        Catch ex As Exception
            Value = 0
        Finally
            SqlRpt.SqlCon.Close()
        End Try
        Return Value
    End Function

End Class
