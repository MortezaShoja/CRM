Imports System.Windows.Forms
Public Class ReplaceData

    Private RichTextBox1 As New RichTextBox
    Private Tbl As New DataTable

    Private Sub Find(ByVal SearchTrem As String, ByVal MatchCase As Boolean)

        Dim StartPosition As Integer
        Dim SearchType As CompareMethod

        If MatchCase = True Then
            SearchType = CompareMethod.Binary
        Else
            SearchType = CompareMethod.Text
        End If

        
        StartPosition = InStr(1, RichTextBox1.Text, SearchTrem, SearchType)

        If StartPosition = 0 Then
            'MessageBox.Show("String: '" & SearchTrem.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        RichTextBox1.Select(StartPosition - 1, SearchTrem.Length)
        RichTextBox1.ScrollToCaret()
        RichTextBox1.Focus()

    End Sub


    Private Sub Replace(ByVal SearchTrem As String, ByVal ReplacementText As String, ByVal MatchCase As Boolean)

        If RichTextBox1.SelectedText.Length <> 0 Then
            RichTextBox1.SelectedText = ReplacementText
        End If

        Dim StartPosition As Integer = RichTextBox1.SelectionStart + 2
        Dim SearchType As CompareMethod

        If MatchCase = True Then
            SearchType = CompareMethod.Binary
        Else
            SearchType = CompareMethod.Text
        End If

        StartPosition = InStr(StartPosition, RichTextBox1.Text, SearchTrem, SearchType)

        If StartPosition = 0 Then
            'MessageBox.Show("String: '" & SearchTrem.ToString() & "' not found", "No Matches", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            Exit Sub
        End If

        RichTextBox1.Select(StartPosition - 1, SearchTrem.Length)
        RichTextBox1.ScrollToCaret()
        RichTextBox1.Focus()

    End Sub

    Private Sub XML(ByVal Text As String, ByVal GharardadNo As String, ByVal RegDate As String, ByVal Attatchment As String)

        Tbl.TableName = "Rich"
        Tbl.Columns.Add("Text")
        Tbl.Columns.Add("GharardadNo")
        Tbl.Columns.Add("RegDate")
        Tbl.Columns.Add("Attatchment")

        Dim row As DataRow = Tbl.NewRow


        row(0) = Text
        row(1) = GharardadNo
        row(2) = RegDate
        row(3) = Attatchment

        Tbl.Rows.Add(row)
        Tbl.WriteXml("C:\Rich.XML")
        Tbl.Columns.Clear()
        Tbl.Rows.Clear()

    End Sub

    Public Sub GenerateRtf(ByVal NoeGharardad As String, ByVal FullName As String, ByVal FotherName As String, ByVal ShenasnameNo As String, ByVal MelliCode As String, ByVal BornDate As String, ByVal BornPlace As String, ByVal Address As String, ByVal Phone As String, ByVal MobilePhone As String, ByVal Fax As String, ByVal AllPriceNumeric As String, ByVal AllPriceWord As String, ByVal PishPriceNumeric As String, ByVal PishPriceWord As String, ByVal SharayetePishPrice As String, ByVal AlbaghiPriceNumeric As String, ByVal AlbaghiPriceWord As String, ByVal AlbaghiPriceSharayet As String, ByVal MahCount As String, ByVal GharardadNo As String, ByVal RegDate As String, ByVal Attatchment As String, ByVal MatchCase As Boolean)

        RichTextBox1.LoadFile("c:\IranBaharestan_Temp\" & NoeGharardad & ".Mory")
        Dim Tmp(18) As String
        Tmp(0) = FullName + " "
        Tmp(1) = FotherName + " "
        Tmp(2) = ShenasnameNo + " "
        Tmp(3) = MelliCode + " "
        Tmp(4) = BornDate + " "
        Tmp(5) = BornPlace + " "
        Tmp(6) = Address + " "
        Tmp(7) = Phone + " "
        Tmp(8) = MobilePhone + " "
        Tmp(9) = Fax + " "
        Tmp(10) = AllPriceNumeric + " "
        Tmp(11) = AllPriceWord + " "
        Tmp(12) = PishPriceNumeric + " "
        Tmp(13) = PishPriceWord + " "
        Tmp(14) = SharayetePishPrice + " "
        Tmp(15) = AlbaghiPriceNumeric + " "
        Tmp(16) = AlbaghiPriceWord + " "
        Tmp(17) = AlbaghiPriceSharayet + " "
        Tmp(18) = MahCount + " "

        For I As Integer = 0 To 18
            Find((13620 + I + 1).ToString, MatchCase)
            Dim N As Integer = 13620 + I + 1
            Replace((13620 + I + 1).ToString, Tmp(I), MatchCase)
        Next
        RichTextBox1.SaveFile("c:\RichTxt.Rtf")
        Dim Sr As New System.IO.StreamReader("c:\RichTxt.rtf")

        XML(Sr.ReadToEnd, GharardadNo, RegDate, Attatchment)
    End Sub

End Class
