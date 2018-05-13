Public Class RptPishGharardad
    Private SqlConnection As SQL
    Private Cmd1 As SqlClient.SqlCommand
    Private Sdr1 As SqlClient.SqlDataReader
    Private tbl1 As DataTable
    Private CD As CurrentDate
    Private CU As Currency
    Private NtoW As NumberToWord
    Private GS As GetSum


    Public Function Generate(ByVal VahedNoID As String)
        Dim Takhfif As Integer = 0
        CU = New Currency
        NtoW = New NumberToWord
        GS = New GetSum

        Dim value As Boolean = False
        'If System.IO.Directory.Exists("C:\Reports") = False Then
        '    System.IO.Directory.CreateDirectory("C:\Reports")
        'End If
        tbl1 = New DataTable
        tbl1.TableName = "FullReport"
        Try
            SqlConnection = New SQL
            tbl1.Clear()
            Cmd1 = New SqlClient.SqlCommand("Select G.VahedNoID,M.Majmooe,M.Address,Z.Zone as 'فاز',G.VahedCode as 'Shomare Ghete',O.OfficeName,S.SallerName,G.GharardadNo,G.GharardadRegDate,G.CashType as 'Noe Kharid',G.[Name]+' '+LName as 'FullName',G.FName,G.ShSh,G.MelliCode,G.TT,G.MT,G.Job,G.WorkPhone,G.Email,G.Address,G.HomePhone,G.Mobile,V.MetrajZamin,(G.GHarardadPrice/V.MetrajZamin) as 'Each Meter',G.GHarardadPrice,G.Discription,G.Takhfif from GharardadNo G inner Join VahedName V on  V.ID=G.VahedNoID inner join Majmooe M On M.ID=G.MajmooeNameID inner Join OfficeName O On G.OfficeNameID=O.ID Inner Join SallerName S On S.ID=G.SallerNameID inner Join Zone Z On V.ZoneId = Z.ID Where VahedNoID='" & VahedNoID & "'", SqlConnection.SqlCon)
            SqlConnection.SqlCon.Open()

            Dim sdr As Data.SqlClient.SqlDataReader = Cmd1.ExecuteReader

            tbl1.Columns.Add("رمز سیستمی")
            tbl1.Columns.Add("محل پروژه")
            tbl1.Columns.Add("آدرس پروژه")
            tbl1.Columns.Add("فاز فروش")
            tbl1.Columns.Add("شماره قطعه")
            tbl1.Columns.Add("نام واحد فروش")
            tbl1.Columns.Add("نام مشاور")
            tbl1.Columns.Add("شماره قرارداد")
            tbl1.Columns.Add("تاریخ")
            tbl1.Columns.Add("نوع فروش")
            tbl1.Columns.Add("نام و نام خانوادگی")
            tbl1.Columns.Add("نام پدر")
            tbl1.Columns.Add("شماره شناسنامه")
            tbl1.Columns.Add("کد ملی")
            tbl1.Columns.Add("تاریخ تولد")
            tbl1.Columns.Add("محل تولد")
            tbl1.Columns.Add("شغل")
            tbl1.Columns.Add("تلفن محل کار")
            tbl1.Columns.Add("پست الکترونیکی")
            tbl1.Columns.Add("آدرس")
            tbl1.Columns.Add("تلفن منزل")
            tbl1.Columns.Add("تلفن همراه")

            tbl1.Columns.Add("متراژ قطعه")
            tbl1.Columns.Add("مبلغ هر متر مربع")
            tbl1.Columns.Add("مبلغ کل")
            tbl1.Columns.Add("توضیحات")

            tbl1.Columns.Add("پیش پرداخت") '-------
            tbl1.Columns.Add("اقساط") '-------
            tbl1.Columns.Add("مانده") '-------
            tbl1.Columns.Add("تعداد اقساط") '-------

            tbl1.Columns.Add("تخفیف")

            While (sdr.Read)

                Dim row As DataRow = tbl1.NewRow
                row(0) = sdr(0)
                row(1) = sdr(1)
                row(2) = sdr(2)
                row(3) = sdr(3)
                row(4) = sdr(4)
                row(5) = sdr(5)
                row(6) = sdr(6)
                row(7) = sdr(7)
                row(8) = sdr(8)
                row(9) = sdr(9)
                row(10) = sdr(10)
                row(11) = sdr(11)
                row(12) = sdr(12)
                row(13) = sdr(13)
                row(14) = sdr(14)
                row(15) = sdr(15)
                row(16) = sdr(16)
                row(17) = sdr(17)
                row(18) = sdr(18)
                row(19) = sdr(19)
                row(20) = sdr(20)
                row(21) = sdr(21)

                row(22) = " یک قطعه زمین به شماره :  " & sdr(4) & " به متراژ " & CU.CodeNumberNoRiyal(sdr(22)) & " متر مربع " & " واقع در " & sdr(3) & " پروژه  " & sdr(1) & " مطابق نقشه و کروکی پیوست. "
                row(23) = " مبلغ هر متر مربع : " & CU.CodeNumber(sdr(23)) & " معادل " & NtoW.Convert(sdr(23))
                row(24) = CU.CodeNumber(sdr(24)) & " معادل " & NtoW.Convert(sdr(24))
                row(25) = sdr(25)

                row(26) = CU.CodeNumber(GS.GetSum(VahedNoID, "پیش پرداخت")) & " معادل " & NtoW.Convert(GS.GetSum(VahedNoID, "پیش پرداخت"))
                row(27) = CU.CodeNumber(GS.GetSum(VahedNoID, "اقساط")) & " معادل " & NtoW.Convert(GS.GetSum(VahedNoID, "اقساط"))
                row(28) = ((GS.GetSum(VahedNoID, "اقساط")) + (GS.GetSum(VahedNoID, "پیش پرداخت"))) - sdr(23)
                row(29) = (GS.GetCount(VahedNoID, "اقساط"))

                row(30) = " مبلغ تخفیف : " & CU.CodeNumber(sdr(26)) & " معادل " & NtoW.Convert(sdr(26))
                Takhfif = sdr(26)


                tbl1.Rows.Add(row)
            End While
            value = True
            tbl1.WriteXml("C:\Reports\PishGharardadReport.XML")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Write Data1")
        Finally
            SqlConnection.SqlCon.Close()
        End Try

        GenPishpardakht(VahedNoID, Takhfif)
        Return value
    End Function

    Private Sub GenPishpardakht(ByVal VahedNoID As String, ByVal Takhfif As Integer)

        CU = New Currency
        NtoW = New NumberToWord
        GS = New GetSum

        'If System.IO.Directory.Exists("C:\Reports") = False Then
        '    System.IO.Directory.CreateDirectory("C:\Reports")
        'End If
        tbl1 = New DataTable
        tbl1.TableName = "Sharayete Pardakht"
        Try
            SqlConnection = New SQL
            tbl1.Clear()
            Cmd1 = New SqlClient.SqlCommand("Select Pardakhte,FormType,AccountOwner,Serial,OwnerBank,Price,Date,Tozihat + ' ' + Jahate,Passed,DestinationAccount,Jahate from bank Where ID='" & VahedNoID.ToString & "' order by Pardakhte,Date,FormType Desc", SqlConnection.SqlCon)
            SqlConnection.SqlCon.Open()

            Dim sdr As Data.SqlClient.SqlDataReader = Cmd1.ExecuteReader

            tbl1.Columns.Add("نوع پرداخت")
            tbl1.Columns.Add("نوع سند")
            tbl1.Columns.Add("نام صاحب حساب")
            tbl1.Columns.Add("شماره سند")
            tbl1.Columns.Add("عهده بانک")
            tbl1.Columns.Add("مبلغ )ریال(")
            tbl1.Columns.Add("تاریخ سررسید")
            tbl1.Columns.Add("توضیحات")
            tbl1.Columns.Add("وضعیت پرداخت")

            tbl1.Columns.Add("مبلغ قرارداد")
            tbl1.Columns.Add("پیش پرداخت")
            tbl1.Columns.Add("مغایرت پرداخت")

            While (sdr.Read)
                Dim row As DataRow = tbl1.NewRow

                row(0) = sdr(0).ToString
                row(1) = sdr(1).ToString
                row(2) = sdr(2).ToString
                row(3) = sdr(3).ToString
                row(4) = sdr(4).ToString
                row(5) = CU.CodeNumberNoRiyal(sdr(5).ToString)
                row(6) = sdr(6).ToString
                row(7) = sdr(7).ToString & " " & sdr(10).ToString
                If sdr(8) = False Then
                    row(8) = "پرداخت نشده"
                Else
                    row(8) = "پرداخت شده"
                End If
                Dim Par() As String = MablagheGharardad(VahedNoID)

                'Dim A1 As String = JameAghsat(VahedNoID)
                'Dim A2 As String = Par(0)
                'Dim A3 As String = Takhfif
                'Dim A4 As String = GS.GetSum(VahedNoID, "سایر پرداخت ها")
                'Dim A5 As String = JameSayerePardakhtHa(VahedNoID)

                'Dim MG As Integer = JameAghsat(VahedNoID) - Par(0) + Takhfif - GS.GetSum(VahedNoID, "سایر پرداخت ها")
                Dim MG As Integer = JameAghsat(VahedNoID) - Par(0) + Takhfif - JameSayerePardakhtHa(VahedNoID)
                row(9) = "مبلغ کل قرارداد : به عدد " & CU.CodeNumber(Par(0)) & " معادل به حروف " & NtoW.Convert(Par(0))
                row(10) = "مبلغ پیش پرداخت : به عدد " & CU.CodeNumber(Par(1)) & " معادل به حروف " & NtoW.Convert(Par(1))
                row(11) = "مبلغ مغایرت پرداخت: به عدد " & CU.CodeNumber(MG) & " معادل به حروف " & NtoW.Convert(MG)
                'End If
                tbl1.Rows.Add(row)
            End While
            tbl1.WriteXml("C:\Reports\PishGharardadPriceReport.XML")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Write Data2")
        Finally
            SqlConnection.SqlCon.Close()
        End Try

    End Sub

    Private Function JameSayerePardakhtHa(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("Select Sum(price) as 'Jame Ghest' from Bank  where Id='" & VahedID & "' And Pardakhte=N'سایر پرداخت ها'", SqlRpt.SqlCon)
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

    Private Function JameAghsat(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("Select Sum(price) as 'Jame Ghest' from Bank  where Id='" & VahedID & "'", SqlRpt.SqlCon)
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


    Private Function MablagheGharardad(ByVal VahedID As String)
        Dim Value(2) As String
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("Select GharardadPrice,Takhfif,pishpardakht from Gharardadno where VahedNoID='" & VahedID & "'", SqlRpt.SqlCon)
        SqlRpt.SqlCon.Open()
        Try
            SdrRpt = CmdRpt.ExecuteReader()
            If SdrRpt.Read Then
                'Value(0) = Integer.Parse(SdrRpt(0).ToString) - Integer.Parse(SdrRpt(1).ToString)
                Value(0) = Integer.Parse(SdrRpt(0).ToString)
                Value(1) = Integer.Parse(SdrRpt(2).ToString)
            End If
            SdrRpt.Close()
        Catch ex As Exception
            Value(0) = 0
            Value(1) = 0
        Finally
            SqlRpt.SqlCon.Close()
        End Try
        Return Value
    End Function


End Class
