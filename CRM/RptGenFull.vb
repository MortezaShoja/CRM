Public Class RptGenFull
    Private SqlConnection As SQL
    Private Cmd1 As SqlClient.SqlCommand
    Private Sdr1 As SqlClient.SqlDataReader
    Private tbl1 As DataTable
    Private B1 As Boolean
    Private CD As CurrentDate
    Private CU As Currency
    Private SUMS(11) As Double


    Public Function GenerateFullReport(ByVal Shart As String, ByVal Noekharid As String, ByVal NoeAghsat As String)
        CU = New Currency

        Dim value As Boolean = False
        'If System.IO.Directory.Exists("C:\Reports") = False Then
        '    System.IO.Directory.CreateDirectory("C:\Reports")
        'End If
        tbl1 = New DataTable
        tbl1.TableName = "FullReport"
        Try
            SqlConnection = New SQL
            tbl1.Clear()
            Cmd1 = New SqlClient.SqlCommand("Select G.VahedNoID,G.[Name]+' '+G.LName as 'FullName',G.CodeRahgiri,G.VahedCode as 'Shomare Ghete',G.CashType as 'Noe Kharid',G.shora,G.amlaak,G.Forooshande1,G.Forooshande2,G.EmzaKharidar,G.TahvilGHarardad,G.GHarardadPrice,G.Pishpardakht,G.Discription,M.Majmooe,O.OfficeName,S.SallerName,G.HomePhone,G.WorkPhone,G.Mobile,G.GharardadRegDate,G.Noeaghsat,G.Takhfif from GharardadNo G Inner Join VahedName V On G.VahedNoID=V.ID Inner Join Zone Z On Z.ID=V.ZoneID Inner join Majmooe M on M.ID=G.MajmooeNameID inner join OfficeName O on O.ID=G.OfficeNameid Inner Join SallerName S On S.ID=G.SallerNameID " & Shart & " Order By G.MajmooeNameID,Z.Zone,G.VahedCode", SqlConnection.SqlCon)
            SqlConnection.SqlCon.Open()

            Dim sdr As Data.SqlClient.SqlDataReader = Cmd1.ExecuteReader

            While (sdr.Read)
                'populating columns
                If Not B1 Then
                    tbl1.Columns.Add("نام و نام خانوادگی")
                    tbl1.Columns.Add("کد رهگیری")
                    tbl1.Columns.Add("شماره قطعه")
                    tbl1.Columns.Add("نوع خرید")

                    tbl1.Columns.Add("مهر شورا")
                    tbl1.Columns.Add("مهر املاک")
                    tbl1.Columns.Add("امضاء فروشنده اول")
                    tbl1.Columns.Add("امضاء فروشنده دوم")
                    tbl1.Columns.Add("امضاء خریدار")
                    tbl1.Columns.Add("تحویل قرارداد")

                    tbl1.Columns.Add("مبلغ قرارداد )ریال(")
                    tbl1.Columns.Add("پیش پرداخت )ریال(")
                    tbl1.Columns.Add("توضیحات")

                    tbl1.Columns.Add("فاز")
                    tbl1.Columns.Add("متراژ قطعه")
                    tbl1.Columns.Add("تعداد اقساط")
                    tbl1.Columns.Add("جمع مبلغ اقساط")
                    tbl1.Columns.Add("جمع مبلغ اقساط پرداخت شده")
                    tbl1.Columns.Add("جمع مبلغ اقساط مانده")
                    tbl1.Columns.Add("تعداد اقساط پرداخت شده")
                    tbl1.Columns.Add("تعداد اقساط پرداخت نشده")
                    tbl1.Columns.Add("تعداد اقساط سررسید شده و پرداخت نشده")
                    tbl1.Columns.Add("جمع مبلغ اقساط سررسید شده و پرداخت نشده")
                    tbl1.Columns.Add("محل پروژه")
                    tbl1.Columns.Add("نام واحد فروش")
                    tbl1.Columns.Add("نام مشاور")
                    tbl1.Columns.Add("تلفن منزل")
                    tbl1.Columns.Add("تلفن محل کار")
                    tbl1.Columns.Add("موبایل")
                    tbl1.Columns.Add("مبلغ هر متر مربع")
                    tbl1.Columns.Add("تاریخ قرارداد")
                    tbl1.Columns.Add("تاریخ گزارش")
                    tbl1.Columns.Add("نوع پرداخت")
                    tbl1.Columns.Add("تخفیف")

                    B1 = True
                End If
                'populating rows
                Dim row As DataRow = tbl1.NewRow

                row(0) = sdr(1)
                row(1) = sdr(2)
                row(2) = sdr(3)
                row(3) = sdr(4)

                If sdr(5) = True Then
                    row(4) += "دارد"
                Else
                    row(4) += "ندارد"
                End If

                If sdr(6) = True Then
                    row(5) += "دارد"
                Else
                    row(5) += "ندارد"
                End If

                If sdr(7) = True Then
                    row(6) += "دارد"
                Else
                    row(6) += "ندارد"
                End If

                If sdr(8) = True Then
                    row(7) += "دارد"
                Else
                    row(7) += "ندارد"
                End If

                If sdr(9) = True Then
                    row(8) += "دارد"
                Else
                    row(8) += "ندارد"
                End If

                If sdr(10) = True Then
                    row(9) += "بلی"
                Else
                    row(9) += "خیر"
                End If

                row(10) = CU.CodeNumberNoRiyal(Integer.Parse(sdr(11)))
                row(11) = CU.CodeNumberNoRiyal(GetSumMablaghePishPardakht(sdr(0).ToString))
                row(12) = sdr(13)

                row(13) = GetّFaz(sdr(0).ToString)
                row(14) = GetMetrajGhete(sdr(0).ToString)
                row(15) = GetTedadAghsat(sdr(0).ToString)
                row(16) = CU.CodeNumberNoRiyal(Integer.Parse(GetSumMablagheAghsat(sdr(0).ToString)))
                row(17) = CU.CodeNumberNoRiyal(Integer.Parse(PardakhtShodeAghsat(sdr(0).ToString)))
                row(18) = CU.CodeNumberNoRiyal(Integer.Parse(MandeAghsat(sdr(0).ToString)))
                row(19) = TedadeAghsatePardakhtShode(sdr(0).ToString)
                row(20) = TedadeAghsatePardakhtNaShode(sdr(0).ToString)
                row(21) = TedadeAghsateSarresidShodeVAPardakhtNaShode(sdr(0).ToString)
                row(22) = CU.CodeNumberNoRiyal(Integer.Parse(MablagheAghsateSarresidShodeVAPardakhtNaShode(sdr(0).ToString)))
                row(23) = sdr(14).ToString
                row(24) = sdr(15)
                row(25) = sdr(16)
                row(26) = sdr(17)
                row(27) = sdr(18)
                row(28) = sdr(19)
                row(29) = CU.CodeNumber(Integer.Parse(sdr(11)) \ GetMetrajGhete(sdr(0).ToString))
                row(30) = sdr(20)
                row(31) = CD.GetDate.ToString
                row(32) = sdr(21)
                row(33) = CU.CodeNumber(sdr(22))

                SUMS(0) += Integer.Parse(sdr(11)) - Integer.Parse(sdr(22))
                SUMS(1) += GetSumMablaghePishPardakht(sdr(0).ToString)
                SUMS(2) += Integer.Parse(GetSumMablagheAghsat(sdr(0).ToString))
                SUMS(3) += Integer.Parse(PardakhtShodeAghsat(sdr(0).ToString))
                SUMS(4) += Integer.Parse(MandeAghsat(sdr(0).ToString))
                SUMS(5) += Integer.Parse(MablagheAghsateSarresidShodeVAPardakhtNaShode(sdr(0).ToString))
                SUMS(6) += GetMetrajGhete(sdr(0).ToString)
                SUMS(7) += (Integer.Parse(sdr(11)) - Integer.Parse(sdr(22))) \ GetMetrajGhete(sdr(0).ToString)
                SUMS(8) += 1
                SUMS(9) += Integer.Parse(GetSumMablagheAghsatSayer(sdr(0).ToString))
                SUMS(10) += Integer.Parse(GetSumMablagheAghsatCheck(sdr(0).ToString))
                SUMS(11) += Integer.Parse(sdr(22))


                tbl1.Rows.Add(row)
            End While
            value = True
            tbl1.WriteXml("C:\Reports\FullReport.XML")
        Catch ex As Exception
            System.IO.File.Delete("C:\Reports\FullReport.XML")
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Read Data")
        Finally
            SqlConnection.SqlCon.Close()
        End Try
        GenSum(Noekharid, NoeAghsat)
        Return value
    End Function


    Public Function GenerateProjectReport(ByVal ProjectName As String, ByVal Shart As String, ByVal Noekharid As String, ByVal NoeAghsat As String)

        CU = New Currency
        CD = New CurrentDate

        Dim value As Boolean = False
        'If System.IO.Directory.Exists("C:\Reports") = False Then
        '    System.IO.Directory.CreateDirectory("C:\Reports")
        'End If
        tbl1 = New DataTable
        tbl1.TableName = "FullReport"
        Try
            SqlConnection = New SQL
            tbl1.Clear()
            Cmd1 = New SqlClient.SqlCommand("Select G.VahedNoID,G.[Name]+' '+G.LName as 'FullName',G.CodeRahgiri,G.VahedCode as 'Shomare Ghete',G.CashType as 'Noe Kharid',G.shora,G.amlaak,G.Forooshande1,G.Forooshande2,G.EmzaKharidar,G.TahvilGHarardad,G.GHarardadPrice,G.Pishpardakht,G.Discription,M.Majmooe,O.OfficeName,S.SallerName,G.HomePhone,G.WorkPhone,G.Mobile,G.GharardadRegDate,G.Noeaghsat,G.Takhfif from GharardadNo G Inner Join VahedName V On G.VahedNoID=V.ID Inner Join Zone Z On Z.ID=V.ZoneID Inner join Majmooe M on M.ID=G.MajmooeNameID inner join OfficeName O on O.ID=G.OfficeNameid Inner Join SallerName S On S.ID=G.SallerNameID Where MajmooeNameID='" & ProjectName & "' " & Shart & " Order By G.MajmooeNameID,Z.Zone,G.VahedCode ", SqlConnection.SqlCon)
            SqlConnection.SqlCon.Open()

            Dim sdr As Data.SqlClient.SqlDataReader = Cmd1.ExecuteReader

            While (sdr.Read)
                'populating columns
                If Not B1 Then
                    tbl1.Columns.Add("نام و نام خانوادگی")
                    tbl1.Columns.Add("کد رهگیری")
                    tbl1.Columns.Add("شماره قطعه")
                    tbl1.Columns.Add("نوع خرید")

                    tbl1.Columns.Add("مهر شورا")
                    tbl1.Columns.Add("مهر املاک")
                    tbl1.Columns.Add("امضاء فروشنده اول")
                    tbl1.Columns.Add("امضاء فروشنده دوم")
                    tbl1.Columns.Add("امضاء خریدار")
                    tbl1.Columns.Add("تحویل قرارداد")

                    tbl1.Columns.Add("مبلغ قرارداد )ریال(")
                    tbl1.Columns.Add("پیش پرداخت )ریال(")
                    tbl1.Columns.Add("توضیحات")

                    tbl1.Columns.Add("فاز")
                    tbl1.Columns.Add("متراژ قطعه")
                    tbl1.Columns.Add("تعداد اقساط")
                    tbl1.Columns.Add("جمع مبلغ اقساط")
                    tbl1.Columns.Add("جمع مبلغ اقساط پرداخت شده")
                    tbl1.Columns.Add("جمع مبلغ اقساط مانده")
                    tbl1.Columns.Add("تعداد اقساط پرداخت شده")
                    tbl1.Columns.Add("تعداد اقساط پرداخت نشده")
                    tbl1.Columns.Add("تعداد اقساط سررسید شده و پرداخت نشده")
                    tbl1.Columns.Add("جمع مبلغ اقساط سررسید شده و پرداخت نشده")
                    tbl1.Columns.Add("محل پروژه")
                    tbl1.Columns.Add("نام واحد فروش")
                    tbl1.Columns.Add("نام مشاور")
                    tbl1.Columns.Add("تلفن منزل")
                    tbl1.Columns.Add("تلفن محل کار")
                    tbl1.Columns.Add("موبایل")
                    tbl1.Columns.Add("مبلغ هر متر مربع")
                    tbl1.Columns.Add("تاریخ قرارداد")
                    tbl1.Columns.Add("تاریخ گزارش")
                    tbl1.Columns.Add("نوع پرداخت")
                    tbl1.Columns.Add("تخفیف")

                    B1 = True
                End If
                'populating rows
                Dim row As DataRow = tbl1.NewRow

                row(0) = sdr(1)
                row(1) = sdr(2)
                row(2) = sdr(3)
                row(3) = sdr(4)

                If sdr(5) = True Then
                    row(4) += "دارد"
                Else
                    row(4) += "ندارد"
                End If

                If sdr(6) = True Then
                    row(5) += "دارد"
                Else
                    row(5) += "ندارد"
                End If

                If sdr(7) = True Then
                    row(6) += "دارد"
                Else
                    row(6) += "ندارد"
                End If

                If sdr(8) = True Then
                    row(7) += "دارد"
                Else
                    row(7) += "ندارد"
                End If

                If sdr(9) = True Then
                    row(8) += "دارد"
                Else
                    row(8) += "ندارد"
                End If

                If sdr(10) = True Then
                    row(9) += "بلی"
                Else
                    row(9) += "خیر"
                End If

                row(10) = CU.CodeNumberNoRiyal(Integer.Parse(sdr(11)))
                row(11) = CU.CodeNumberNoRiyal(GetSumMablaghePishPardakht(sdr(0).ToString))
                row(12) = sdr(13)

                row(13) = GetّFaz(sdr(0).ToString)
                row(14) = GetMetrajGhete(sdr(0).ToString)
                row(15) = GetTedadAghsat(sdr(0).ToString)
                row(16) = CU.CodeNumberNoRiyal(Integer.Parse(GetSumMablagheAghsat(sdr(0).ToString)))
                row(17) = CU.CodeNumberNoRiyal(Integer.Parse(PardakhtShodeAghsat(sdr(0).ToString)))
                row(18) = CU.CodeNumberNoRiyal(Integer.Parse(MandeAghsat(sdr(0).ToString)))
                row(19) = TedadeAghsatePardakhtShode(sdr(0).ToString)
                row(20) = TedadeAghsatePardakhtNaShode(sdr(0).ToString)
                row(21) = TedadeAghsateSarresidShodeVAPardakhtNaShode(sdr(0).ToString)
                row(22) = CU.CodeNumberNoRiyal(Integer.Parse(MablagheAghsateSarresidShodeVAPardakhtNaShode(sdr(0).ToString)))
                row(23) = sdr(14).ToString
                row(24) = sdr(15)
                row(25) = sdr(16)
                row(26) = sdr(17)
                row(27) = sdr(18)
                row(28) = sdr(19)
                row(29) = CU.CodeNumber(Integer.Parse(sdr(11)) \ GetMetrajGhete(sdr(0).ToString))
                row(30) = sdr(20)
                row(31) = CD.GetDate.ToString
                row(32) = sdr(21)
                row(33) = CU.CodeNumber(sdr(22))

                SUMS(0) += Integer.Parse(sdr(11)) - Integer.Parse(sdr(22))
                SUMS(1) += GetSumMablaghePishPardakht(sdr(0).ToString)
                SUMS(2) += Integer.Parse(GetSumMablagheAghsat(sdr(0).ToString))
                SUMS(3) += Integer.Parse(PardakhtShodeAghsat(sdr(0).ToString))
                SUMS(4) += Integer.Parse(MandeAghsat(sdr(0).ToString))
                SUMS(5) += Integer.Parse(MablagheAghsateSarresidShodeVAPardakhtNaShode(sdr(0).ToString))
                SUMS(6) += GetMetrajGhete(sdr(0).ToString)
                SUMS(7) += (Integer.Parse(sdr(11)) - Integer.Parse(sdr(22))) \ GetMetrajGhete(sdr(0).ToString)
                SUMS(8) += 1
                SUMS(9) += Integer.Parse(GetSumMablagheAghsatSayer(sdr(0).ToString))
                SUMS(10) += Integer.Parse(GetSumMablagheAghsatCheck(sdr(0).ToString))
                SUMS(11) += Integer.Parse(sdr(22))

                tbl1.Rows.Add(row)
            End While
            value = True
            tbl1.WriteXml("C:\Reports\FullReport.XML")
        Catch ex As Exception
            System.IO.File.Delete("C:\Reports\FullReport.XML")
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Read Data")
        Finally
            SqlConnection.SqlCon.Close()
        End Try
        GenSum(Noekharid, NoeAghsat)
        Return value
    End Function

    Public Function GenerateVahedReport(ByVal ProjectName As String, ByVal VahedType As String, ByVal Shart As String, ByVal Noekharid As String, ByVal NoeAghsat As String)

        CU = New Currency

        Dim value As Boolean = False
        'If System.IO.Directory.Exists("C:\Reports") = False Then
        '    System.IO.Directory.CreateDirectory("C:\Reports")
        'End If
        tbl1 = New DataTable
        tbl1.TableName = "FullReport"
        Try
            SqlConnection = New SQL
            tbl1.Clear()
            Cmd1 = New SqlClient.SqlCommand("Select G.VahedNoID,G.[Name]+' '+G.LName as 'FullName',G.CodeRahgiri,G.VahedCode as 'Shomare Ghete',G.CashType as 'Noe Kharid',G.shora,G.amlaak,G.Forooshande1,G.Forooshande2,G.EmzaKharidar,G.TahvilGHarardad,G.GHarardadPrice,G.Pishpardakht,G.Discription,M.Majmooe,O.OfficeName,S.SallerName,G.HomePhone,G.WorkPhone,G.Mobile,G.GharardadRegDate,G.Noeaghsat,G.Takhfif from GharardadNo G Inner Join VahedName V On G.VahedNoID=V.ID Inner Join Zone Z On Z.ID=V.ZoneID Inner join Majmooe M on M.ID=G.MajmooeNameID inner join OfficeName O on O.ID=G.OfficeNameid Inner Join SallerName S On S.ID=G.SallerNameID Where G.MajmooeNameID='" & ProjectName & "' AND V.VahedTypeID='" & VahedType & "' " & Shart & " Order By G.MajmooeNameID,Z.Zone,G.VahedCode ", SqlConnection.SqlCon)
            SqlConnection.SqlCon.Open()

            Dim sdr As Data.SqlClient.SqlDataReader = Cmd1.ExecuteReader

            While (sdr.Read)
                'populating columns
                If Not B1 Then
                    tbl1.Columns.Add("نام و نام خانوادگی")
                    tbl1.Columns.Add("کد رهگیری")
                    tbl1.Columns.Add("شماره قطعه")
                    tbl1.Columns.Add("نوع خرید")

                    tbl1.Columns.Add("مهر شورا")
                    tbl1.Columns.Add("مهر املاک")
                    tbl1.Columns.Add("امضاء فروشنده اول")
                    tbl1.Columns.Add("امضاء فروشنده دوم")
                    tbl1.Columns.Add("امضاء خریدار")
                    tbl1.Columns.Add("تحویل قرارداد")

                    tbl1.Columns.Add("مبلغ قرارداد )ریال(")
                    tbl1.Columns.Add("پیش پرداخت )ریال(")
                    tbl1.Columns.Add("توضیحات")

                    tbl1.Columns.Add("فاز")
                    tbl1.Columns.Add("متراژ قطعه")
                    tbl1.Columns.Add("تعداد اقساط")
                    tbl1.Columns.Add("جمع مبلغ اقساط")
                    tbl1.Columns.Add("جمع مبلغ اقساط پرداخت شده")
                    tbl1.Columns.Add("جمع مبلغ اقساط مانده")
                    tbl1.Columns.Add("تعداد اقساط پرداخت شده")
                    tbl1.Columns.Add("تعداد اقساط پرداخت نشده")
                    tbl1.Columns.Add("تعداد اقساط سررسید شده و پرداخت نشده")
                    tbl1.Columns.Add("جمع مبلغ اقساط سررسید شده و پرداخت نشده")
                    tbl1.Columns.Add("محل پروژه")
                    tbl1.Columns.Add("نام واحد فروش")
                    tbl1.Columns.Add("نام مشاور")
                    tbl1.Columns.Add("تلفن منزل")
                    tbl1.Columns.Add("تلفن محل کار")
                    tbl1.Columns.Add("موبایل")
                    tbl1.Columns.Add("مبلغ هر متر مربع")
                    tbl1.Columns.Add("تاریخ قرارداد")
                    tbl1.Columns.Add("تاریخ گزارش")
                    tbl1.Columns.Add("نوع پرداخت")
                    tbl1.Columns.Add("تخفیف")

                    B1 = True
                End If
                'populating rows
                Dim row As DataRow = tbl1.NewRow

                row(0) = sdr(1)
                row(1) = sdr(2)
                row(2) = sdr(3)
                row(3) = sdr(4)

                If sdr(5) = True Then
                    row(4) += "دارد"
                Else
                    row(4) += "ندارد"
                End If

                If sdr(6) = True Then
                    row(5) += "دارد"
                Else
                    row(5) += "ندارد"
                End If

                If sdr(7) = True Then
                    row(6) += "دارد"
                Else
                    row(6) += "ندارد"
                End If

                If sdr(8) = True Then
                    row(7) += "دارد"
                Else
                    row(7) += "ندارد"
                End If

                If sdr(9) = True Then
                    row(8) += "دارد"
                Else
                    row(8) += "ندارد"
                End If

                If sdr(10) = True Then
                    row(9) += "بلی"
                Else
                    row(9) += "خیر"
                End If

                row(10) = CU.CodeNumberNoRiyal(Integer.Parse(sdr(11)))
                row(11) = CU.CodeNumberNoRiyal(GetSumMablaghePishPardakht(sdr(0).ToString))
                row(12) = sdr(13)

                row(13) = GetّFaz(sdr(0).ToString)
                row(14) = GetMetrajGhete(sdr(0).ToString)
                row(15) = GetTedadAghsat(sdr(0).ToString)
                row(16) = CU.CodeNumberNoRiyal(Integer.Parse(GetSumMablagheAghsat(sdr(0).ToString)))
                row(17) = CU.CodeNumberNoRiyal(Integer.Parse(PardakhtShodeAghsat(sdr(0).ToString)))
                row(18) = CU.CodeNumberNoRiyal(Integer.Parse(MandeAghsat(sdr(0).ToString)))
                row(19) = TedadeAghsatePardakhtShode(sdr(0).ToString)
                row(20) = TedadeAghsatePardakhtNaShode(sdr(0).ToString)
                row(21) = TedadeAghsateSarresidShodeVAPardakhtNaShode(sdr(0).ToString)
                row(22) = CU.CodeNumberNoRiyal(Integer.Parse(MablagheAghsateSarresidShodeVAPardakhtNaShode(sdr(0).ToString)))
                row(23) = sdr(14).ToString
                row(24) = sdr(15)
                row(25) = sdr(16)
                row(26) = sdr(17)
                row(27) = sdr(18)
                row(28) = sdr(19)
                row(29) = CU.CodeNumber(Integer.Parse(sdr(11)) \ GetMetrajGhete(sdr(0).ToString))
                row(30) = sdr(20)
                row(31) = CD.GetDate.ToString
                row(32) = sdr(21)
                row(33) = CU.CodeNumber(sdr(22))

                SUMS(0) += Integer.Parse(sdr(11)) - Integer.Parse(sdr(22))
                SUMS(1) += GetSumMablaghePishPardakht(sdr(0).ToString)
                SUMS(2) += Integer.Parse(GetSumMablagheAghsat(sdr(0).ToString))
                SUMS(3) += Integer.Parse(PardakhtShodeAghsat(sdr(0).ToString))
                SUMS(4) += Integer.Parse(MandeAghsat(sdr(0).ToString))
                SUMS(5) += Integer.Parse(MablagheAghsateSarresidShodeVAPardakhtNaShode(sdr(0).ToString))
                SUMS(6) += GetMetrajGhete(sdr(0).ToString)
                SUMS(7) += (Integer.Parse(sdr(11)) - Integer.Parse(sdr(22))) \ GetMetrajGhete(sdr(0).ToString)
                SUMS(8) += 1
                SUMS(9) += Integer.Parse(GetSumMablagheAghsatSayer(sdr(0).ToString))
                SUMS(10) += Integer.Parse(GetSumMablagheAghsatCheck(sdr(0).ToString))
                SUMS(11) += Integer.Parse(sdr(22))

                tbl1.Rows.Add(row)
            End While
            value = True
            tbl1.WriteXml("C:\Reports\FullReport.XML")
        Catch ex As Exception
            System.IO.File.Delete("C:\Reports\FullReport.XML")
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Read Data")
        Finally
            SqlConnection.SqlCon.Close()
        End Try
        GenSum(Noekharid, NoeAghsat)
        Return value
    End Function

    Public Function GenerateFaseReport(ByVal ProjectName As String, ByVal VahedType As String, ByVal Fase As String, ByVal Shart As String, ByVal Noekharid As String, ByVal NoeAghsat As String)

        CU = New Currency

        Dim value As Boolean = False
        'If System.IO.Directory.Exists("C:\Reports") = False Then
        '    System.IO.Directory.CreateDirectory("C:\Reports")
        'End If
        tbl1 = New DataTable
        tbl1.TableName = "FullReport"
        Try
            SqlConnection = New SQL
            tbl1.Clear()
            Cmd1 = New SqlClient.SqlCommand("Select G.VahedNoID,G.[Name]+' '+G.LName as 'FullName',G.CodeRahgiri,G.VahedCode as 'Shomare Ghete',G.CashType as 'Noe Kharid',G.shora,G.amlaak,G.Forooshande1,G.Forooshande2,G.EmzaKharidar,G.TahvilGHarardad,G.GHarardadPrice,G.Pishpardakht,G.Discription,M.Majmooe,O.OfficeName,S.SallerName,G.HomePhone,G.WorkPhone,G.Mobile,G.GharardadRegDate,G.Noeaghsat,G.Takhfif from GharardadNo G Inner Join VahedName V On G.VahedNoID=V.ID Inner Join Zone Z On Z.ID=V.ZoneID Inner join Majmooe M on M.ID=G.MajmooeNameID inner join OfficeName O on O.ID=G.OfficeNameid Inner Join SallerName S On S.ID=G.SallerNameID Where G.MajmooeNameID='" & ProjectName & "' AND V.VahedTypeID='" & VahedType & "' AND V.ZoneID='" & Fase & "' " & Shart & "  Order By G.MajmooeNameID,Z.Zone,G.VahedCode ", SqlConnection.SqlCon)
            SqlConnection.SqlCon.Open()

            Dim sdr As Data.SqlClient.SqlDataReader = Cmd1.ExecuteReader

            While (sdr.Read)
                'populating columns
                If Not B1 Then
                    tbl1.Columns.Add("نام و نام خانوادگی")
                    tbl1.Columns.Add("کد رهگیری")
                    tbl1.Columns.Add("شماره قطعه")
                    tbl1.Columns.Add("نوع خرید")

                    tbl1.Columns.Add("مهر شورا")
                    tbl1.Columns.Add("مهر املاک")
                    tbl1.Columns.Add("امضاء فروشنده اول")
                    tbl1.Columns.Add("امضاء فروشنده دوم")
                    tbl1.Columns.Add("امضاء خریدار")
                    tbl1.Columns.Add("تحویل قرارداد")

                    tbl1.Columns.Add("مبلغ قرارداد )ریال(")
                    tbl1.Columns.Add("پیش پرداخت )ریال(")
                    tbl1.Columns.Add("توضیحات")

                    tbl1.Columns.Add("فاز")
                    tbl1.Columns.Add("متراژ قطعه")
                    tbl1.Columns.Add("تعداد اقساط")
                    tbl1.Columns.Add("جمع مبلغ اقساط")
                    tbl1.Columns.Add("جمع مبلغ اقساط پرداخت شده")
                    tbl1.Columns.Add("جمع مبلغ اقساط مانده")
                    tbl1.Columns.Add("تعداد اقساط پرداخت شده")
                    tbl1.Columns.Add("تعداد اقساط پرداخت نشده")
                    tbl1.Columns.Add("تعداد اقساط سررسید شده و پرداخت نشده")
                    tbl1.Columns.Add("جمع مبلغ اقساط سررسید شده و پرداخت نشده")
                    tbl1.Columns.Add("محل پروژه")
                    tbl1.Columns.Add("نام واحد فروش")
                    tbl1.Columns.Add("نام مشاور")
                    tbl1.Columns.Add("تلفن منزل")
                    tbl1.Columns.Add("تلفن محل کار")
                    tbl1.Columns.Add("موبایل")
                    tbl1.Columns.Add("مبلغ هر متر مربع")
                    tbl1.Columns.Add("تاریخ قرارداد")
                    tbl1.Columns.Add("تاریخ گزارش")
                    tbl1.Columns.Add("نوع پرداخت")
                    tbl1.Columns.Add("تخفیف")

                    B1 = True
                End If
                'populating rows
                Dim row As DataRow = tbl1.NewRow

                row(0) = sdr(1)
                row(1) = sdr(2)
                row(2) = sdr(3)
                row(3) = sdr(4)

                If sdr(5) = True Then
                    row(4) += "دارد"
                Else
                    row(4) += "ندارد"
                End If

                If sdr(6) = True Then
                    row(5) += "دارد"
                Else
                    row(5) += "ندارد"
                End If

                If sdr(7) = True Then
                    row(6) += "دارد"
                Else
                    row(6) += "ندارد"
                End If

                If sdr(8) = True Then
                    row(7) += "دارد"
                Else
                    row(7) += "ندارد"
                End If

                If sdr(9) = True Then
                    row(8) += "دارد"
                Else
                    row(8) += "ندارد"
                End If

                If sdr(10) = True Then
                    row(9) += "بلی"
                Else
                    row(9) += "خیر"
                End If

                row(10) = CU.CodeNumberNoRiyal(Integer.Parse(sdr(11)))
                row(11) = CU.CodeNumberNoRiyal(GetSumMablaghePishPardakht(sdr(0).ToString))
                row(12) = sdr(13)

                row(13) = GetّFaz(sdr(0).ToString)
                row(14) = GetMetrajGhete(sdr(0).ToString)
                row(15) = GetTedadAghsat(sdr(0).ToString)
                row(16) = CU.CodeNumberNoRiyal(Integer.Parse(GetSumMablagheAghsat(sdr(0).ToString)))
                row(17) = CU.CodeNumberNoRiyal(Integer.Parse(PardakhtShodeAghsat(sdr(0).ToString)))
                row(18) = CU.CodeNumberNoRiyal(Integer.Parse(MandeAghsat(sdr(0).ToString)))
                row(19) = TedadeAghsatePardakhtShode(sdr(0).ToString)
                row(20) = TedadeAghsatePardakhtNaShode(sdr(0).ToString)
                row(21) = TedadeAghsateSarresidShodeVAPardakhtNaShode(sdr(0).ToString)
                row(22) = CU.CodeNumberNoRiyal(Integer.Parse(MablagheAghsateSarresidShodeVAPardakhtNaShode(sdr(0).ToString)))
                row(23) = sdr(14).ToString
                row(24) = sdr(15)
                row(25) = sdr(16)
                row(26) = sdr(17)
                row(27) = sdr(18)
                row(28) = sdr(19)
                row(29) = CU.CodeNumber(Integer.Parse(sdr(11)) \ GetMetrajGhete(sdr(0).ToString))
                row(30) = sdr(20)
                row(31) = CD.GetDate.ToString
                row(32) = sdr(21)
                row(33) = CU.CodeNumber(sdr(22))

                SUMS(0) += Integer.Parse(sdr(11)) - Integer.Parse(sdr(22))
                SUMS(1) += GetSumMablaghePishPardakht(sdr(0).ToString)
                SUMS(2) += Integer.Parse(GetSumMablagheAghsat(sdr(0).ToString))
                SUMS(3) += Integer.Parse(PardakhtShodeAghsatNoCheck(sdr(0).ToString))
                SUMS(4) += Integer.Parse(MandeAghsatNoCheck(sdr(0).ToString))
                SUMS(5) += Integer.Parse(MablagheAghsateSarresidShodeVAPardakhtNaShode(sdr(0).ToString))
                SUMS(6) += GetMetrajGhete(sdr(0).ToString)
                SUMS(7) += (Integer.Parse(sdr(11)) - Integer.Parse(sdr(22))) \ GetMetrajGhete(sdr(0).ToString)
                SUMS(8) += 1
                SUMS(9) += Integer.Parse(GetSumMablagheAghsatSayer(sdr(0).ToString))
                SUMS(10) += Integer.Parse(GetSumMablagheAghsatCheck(sdr(0).ToString))
                SUMS(11) += Integer.Parse(sdr(22))

                tbl1.Rows.Add(row)
            End While
            value = True
            tbl1.WriteXml("C:\Reports\FullReport.XML")
        Catch ex As Exception
            System.IO.File.Delete("C:\Reports\FullReport.XML")
            MessageBox.Show(ex.Message.ToString & vbCrLf & "Read Data")
        Finally
            SqlConnection.SqlCon.Close()
        End Try
        GenSum(Noekharid, NoeAghsat)
        Return value
    End Function

    Private Sub GenSum(ByVal Noekharid As String, ByVal NoeAghsat As String)
        If Noekharid = "" Then Noekharid = "همه موارد"
        If NoeAghsat = "" Then NoeAghsat = "همه موارد"


        System.IO.File.Delete("C:\Reports\FullReportSum.XML")
        Dim B2 As Boolean = False
        Try
            CU = New Currency
            Dim value As Boolean = False
            tbl1 = New DataTable
            tbl1.TableName = "FullReportSum"
            If Not B2 Then
                tbl1.Columns.Add("جمع مبالغ قراردادها")
                tbl1.Columns.Add("مجموع پیش پرداخت")
                tbl1.Columns.Add("مجموع میلغ اقساط")
                tbl1.Columns.Add("مجموع اقساط پرداخت شده")
                tbl1.Columns.Add("مجموع اقساط مانده")
                tbl1.Columns.Add("مجموع اقساط سررسید شده و پرداخت نشده")
                tbl1.Columns.Add("میانگین فروش هر متر مربع")
                tbl1.Columns.Add("مجموع متراژ فروخته شده")
                tbl1.Columns.Add("مجموع مغایرات")
                tbl1.Columns.Add("مجموع سایر اقساط")
                tbl1.Columns.Add("مجموع اقساط چکی")
                tbl1.Columns.Add("نوع خرید")
                tbl1.Columns.Add("نوع اقساط")
                tbl1.Columns.Add("مجموع تخفیف")

                B2 = True

                'populating rows
                Dim row As DataRow = tbl1.NewRow
                row(0) = CU.CodeNumber(SUMS(0))
                row(1) = CU.CodeNumber(SUMS(1))
                row(2) = CU.CodeNumber(SUMS(2))
                row(3) = CU.CodeNumber(SUMS(3))
                row(4) = CU.CodeNumber(SUMS(4))
                row(5) = CU.CodeNumber(SUMS(5))
                row(6) = CU.CodeNumber(SUMS(7) \ SUMS(8))
                row(7) = CU.CodeNumberNoRiyal(SUMS(6)) & " مترمربع "
                row(8) = CU.CodeNumber((SUMS(1) + SUMS(2)) - SUMS(0))
                row(9) = CU.CodeNumber(SUMS(9))
                row(10) = CU.CodeNumber(SUMS(10))
                row(11) = Noekharid
                row(12) = NoeAghsat
                row(13) = CU.CodeNumber(SUMS(11))
                tbl1.Rows.Add(row)
                tbl1.WriteXml("C:\Reports\FullReportSum.XML")

            End If
        Catch ex As Exception
            System.IO.File.Delete("C:\Reports\FullReportSum.XML")
        End Try

    End Sub
    Private Function GetّFaz(ByVal VahedID As String)
        Dim Value As String = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("Select Z.Zone from VahedName V inner join Zone Z On V.ZoneID=Z.ID where V.ID='" & VahedID & "'", SqlRpt.SqlCon)
        SqlRpt.SqlCon.Open()
        Try
            SdrRpt = CmdRpt.ExecuteReader()
            If SdrRpt.Read Then
                Value = SdrRpt(0).ToString
            End If
            SdrRpt.Close()
        Catch ex As Exception
            Value = 0
        Finally
            SqlRpt.SqlCon.Close()
        End Try
        Return Value
    End Function

    Private Function GetMetrajGhete(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("select MetrajZamin from VahedName where id='" & VahedID & "'", SqlRpt.SqlCon)
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

    Private Function GetTedadAghsat(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("select Count(price) as 'Tedad Ghest' from Bank  where Pardakhte=N'اقساط' AND id='" & VahedID & "'", SqlRpt.SqlCon)
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

    Private Function GetSumMablaghePishPardakht(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("select Sum(price) as 'Jame Ghest' from Bank  where (Pardakhte=N'پیش پرداخت' or Pardakhte=N'نقدی') AND id='" & VahedID & "'", SqlRpt.SqlCon)
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

    Private Function GetSumMablagheAghsat(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("select Sum(price) as 'Jame Ghest' from Bank  where Pardakhte=N'اقساط' AND id='" & VahedID & "'", SqlRpt.SqlCon)
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

    Private Function GetSumMablagheAghsatCheck(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("select  Sum(price) as 'Jame Ghest' from Bank  where Pardakhte=N'اقساط' And FormType=N'چکی' AND id='" & VahedID & "'", SqlRpt.SqlCon)
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

    Private Function GetSumMablagheAghsatSayer(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("select Sum(price) as 'Jame Ghest' from Bank  where Pardakhte=N'اقساط' And Not FormType=N'چکی' AND id='" & VahedID & "'", SqlRpt.SqlCon)
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

    Private Function TedadeAghsatePardakhtShode(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("select Count(price) as 'Jame Ghest' from Bank  where Pardakhte=N'اقساط' AND Passed='1' And id='" & VahedID & "'", SqlRpt.SqlCon)
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

    Private Function TedadeAghsatePardakhtNaShode(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("select Count(price) as 'Jame Ghest' from Bank  where Pardakhte=N'اقساط' AND Passed='0' And id='" & VahedID & "'", SqlRpt.SqlCon)
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

    Private Function TedadeAghsateSarresidShodeVAPardakhtNaShode(ByVal VahedID As String)
        CD = New CurrentDate
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("select Count(price) as 'Jame Ghest' from Bank  where Pardakhte=N'اقساط' AND Passed='0' AND Date < N'" & CD.GetDate.ToString & "' AND  id='" & VahedID & "'", SqlRpt.SqlCon)
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

    Private Function MablagheAghsateSarresidShodeVAPardakhtNaShode(ByVal VahedID As String)
        CD = New CurrentDate
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("select Sum(price) as 'Jame Ghest' from Bank  where Pardakhte=N'اقساط' AND Passed='0' AND Date < '" & CD.GetDate.ToString & "' AND  id='" & VahedID & "'", SqlRpt.SqlCon)
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

    Private Function MandeAghsat(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("Select Sum(price) as 'Jame Ghest' from Bank  where Pardakhte=N'اقساط' AND Passed='0' And id='" & VahedID & "'", SqlRpt.SqlCon)
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

    Private Function MandeAghsatNoCheck(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("Select Sum(price) as 'Jame Ghest' from Bank  where Pardakhte=N'اقساط' AND Passed='0' And id='" & VahedID & "' And Not FormType=N'چکی'", SqlRpt.SqlCon)
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

    Private Function PardakhtShodeAghsatNoCheck(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("Select Sum(price) as 'Jame Ghest' from Bank  where Pardakhte=N'اقساط' AND Passed='1' And id='" & VahedID & "' And Not FormType=N'چکی'", SqlRpt.SqlCon)
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

    Private Function PardakhtShodeAghsat(ByVal VahedID As String)
        Dim Value As Integer = 0
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("Select Sum(price) as 'Jame Ghest' from Bank  where Pardakhte=N'اقساط' AND Passed='1' And id='" & VahedID & "'", SqlRpt.SqlCon)
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
    Private Function GetMajmooeName(ByVal MajmooeNameID As String)
        Dim Value As String = "نا مشخص"
        Dim SqlRpt As New SQL
        Dim SdrRpt As SqlClient.SqlDataReader
        Dim CmdRpt = New SqlClient.SqlCommand("select Majmooe from Majmooe where id='" & MajmooeNameID & "'", SqlRpt.SqlCon)
        SqlRpt.SqlCon.Open()
        Try
            SdrRpt = CmdRpt.ExecuteReader()
            If SdrRpt.Read Then
                Value = SdrRpt(0).ToString
            End If
            SdrRpt.Close()
        Catch ex As Exception
            Value = "نا مشخص"
        Finally
            SqlRpt.SqlCon.Close()
        End Try
        Return Value
    End Function
End Class
