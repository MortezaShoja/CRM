Imports Word = Microsoft.Office.Interop.Word

Public Class FillGharardadTextXML
    Private R As String = String.Empty
    Private S As String = String.Empty
    Private SR As System.IO.StreamReader
    Private SW As System.IO.StreamWriter
    Private NW As NumberToWord
    Private CU As Currency

    Private Sub FillXML(ByVal FullName As String, ByVal Father As String, ByVal ShomareShenasnameh As String, ByVal MahalleTavallod As String, ByVal TarikheTavallod As String, ByVal MelliCode As String, ByVal Address As String, ByVal TelephoneSabet As String, ByVal Mobile As String, ByVal MetrajeZamin As String, ByVal ShomareGhete As String, ByVal GheymateHarMetr As String, ByVal MablagheKol As String, ByVal MablaghekPishPardakht As String, ByVal ShomareCheckPishPardakht As String, ByVal BankCheckPish As String, ByVal TarikheCheckPish As String, ByVal MablaghAghsat As String, ByVal TedadCheck As String)
        Dim objWordApp As New Word.Application
        objWordApp.Visible = True

        'Open an existing document.  
        Dim objDoc As Word.Document = objWordApp.Documents.Open("C:\Gharardad\Sample.doc")
        objDoc = objWordApp.ActiveDocument

        'Find and replace some text  
        'Replace 'VB' with 'Visual Basic'  
        objDoc.Content.Find.Execute(FindText:="VB", ReplaceWith:="Visual Basic Express", Replace:=Word.WdReplace.wdReplaceAll)
        'While objDoc.Content.Find.Execute(FindText:="  ", Wrap:=Word.WdFindWrap.wdFindContinue)
        objDoc.Content.Find.Execute(FindText:="p110", ReplaceWith:=FullName, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        objDoc.Content.Find.Execute(FindText:="p111", ReplaceWith:=Father, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        objDoc.Content.Find.Execute(FindText:="p112", ReplaceWith:=ShomareShenasnameh, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        objDoc.Content.Find.Execute(FindText:="p113", ReplaceWith:=MahalleTavallod, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        objDoc.Content.Find.Execute(FindText:="p114", ReplaceWith:=TarikheTavallod, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        objDoc.Content.Find.Execute(FindText:="p115", ReplaceWith:=MelliCode, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        objDoc.Content.Find.Execute(FindText:="p116", ReplaceWith:=Address, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        objDoc.Content.Find.Execute(FindText:="p117", ReplaceWith:=TelephoneSabet, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        objDoc.Content.Find.Execute(FindText:="p118", ReplaceWith:=Mobile, Replace:=Word.WdReplace.wdReplaceAll, Wrap:=Word.WdFindWrap.wdFindContinue)
        'End While
        '    R = R.Replace("", )
        '    R = R.Replace("P111", )
        '    R = R.Replace("P112", )
        '    R = R.Replace("P113", )
        '    R = R.Replace("P114", MasahateZamin)
        '    R = R.Replace("P115", ShomareGhate)
        '    R = R.Replace("P116", NameShahrak)
        '    R = R.Replace("P117", AddreseShahrak)
        '    R = R.Replace("P118", TedadKhab)
        '    R = R.Replace("P119", MetrajeBana)
        '    R = R.Replace("P120", MetrajeTeras)
        '    R = R.Replace("P121", CU.CodeNumberRTL(CU.DeCodeNumber(MablagheKol)))
        '    R = R.Replace("P122", NW.Convert(CU.DeCodeNumber(MablagheKol)))
        '    R = R.Replace("P123", CU.CodeNumberRTL(CU.DeCodeNumber(PishPardakht)))
        '    R = R.Replace("P124", NW.Convert(CU.DeCodeNumber(PishPardakht)))
        '    R = R.Replace("P125", CU.CodeNumberRTL(CU.DeCodeNumber(Aghsat)))
        '    R = R.Replace("P126", NW.Convert(CU.DeCodeNumber(Aghsat)))
        '    R = R.Replace("P127", TedadCheck)
        '    R = R.Replace("P128", CU.CodeNumberRTL(CU.DeCodeNumber(MablagheEnteghaleSanad)))
        '    R = R.Replace("P129", NW.Convert(CU.DeCodeNumber(MablagheEnteghaleSanad)))
        '    R = R.Replace("P130", ZamaneTahvil)
        '    R = R.Replace("P131", AddresseKharidar)
        '    R = R.Replace("P132", Tedademadeh)
        '    R = R.Replace("P133", TedadeBand)
        '    R = R.Replace("P134", TedadeTabsareh)
        '    R = R.Replace("P135", TedadeSafheh)

        'Save and close the document  
        objDoc.Save()
        objDoc.Close()
        objDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing

    End Sub

    'Public Sub FillXML(ByVal FullName As String, ByVal Father As String, ByVal ShomareShenasnameh As String, ByVal MelliCode As String, ByVal MasahateZamin As String, ByVal ShomareGhate As String, ByVal NameShahrak As String, ByVal AddreseShahrak As String, ByVal TedadKhab As String, ByVal MetrajeBana As String, ByVal MetrajeTeras As String, ByVal MablagheKol As String, ByVal PishPardakht As String, ByVal Aghsat As String, ByVal TedadCheck As String, ByVal MablagheEnteghaleSanad As String, ByVal ZamaneTahvil As String, ByVal AddresseKharidar As String, ByVal Tedademadeh As String, ByVal TedadeBand As String, ByVal TedadeTabsareh As String, ByVal TedadeSafheh As String)
    '    If System.IO.Directory.Exists("c:\XML") = False Then
    '        System.IO.Directory.CreateDirectory("c:\XML")
    '    End If
    '    NW = New NumberToWord
    '    CU = New Currency
    '    SR = New System.IO.StreamReader("c:\XML\GharardadText.XML")
    '    R = SR.ReadToEnd.ToString
    '    SR.Close()

    '    SW = New System.IO.StreamWriter("c:\XML\GharardadText.XML")
    '    R = R.Replace("P110", FullName)
    '    R = R.Replace("P111", Father)
    '    R = R.Replace("P112", ShomareShenasnameh)
    '    R = R.Replace("P113", MelliCode)
    '    R = R.Replace("P114", MasahateZamin)
    '    R = R.Replace("P115", ShomareGhate)
    '    R = R.Replace("P116", NameShahrak)
    '    R = R.Replace("P117", AddreseShahrak)
    '    R = R.Replace("P118", TedadKhab)
    '    R = R.Replace("P119", MetrajeBana)
    '    R = R.Replace("P120", MetrajeTeras)
    '    R = R.Replace("P121", CU.CodeNumberRTL(CU.DeCodeNumber(MablagheKol)))
    '    R = R.Replace("P122", NW.Convert(CU.DeCodeNumber(MablagheKol)))
    '    R = R.Replace("P123", CU.CodeNumberRTL(CU.DeCodeNumber(PishPardakht)))
    '    R = R.Replace("P124", NW.Convert(CU.DeCodeNumber(PishPardakht)))
    '    R = R.Replace("P125", CU.CodeNumberRTL(CU.DeCodeNumber(Aghsat)))
    '    R = R.Replace("P126", NW.Convert(CU.DeCodeNumber(Aghsat)))
    '    R = R.Replace("P127", TedadCheck)
    '    R = R.Replace("P128", CU.CodeNumberRTL(CU.DeCodeNumber(MablagheEnteghaleSanad)))
    '    R = R.Replace("P129", NW.Convert(CU.DeCodeNumber(MablagheEnteghaleSanad)))
    '    R = R.Replace("P130", ZamaneTahvil)
    '    R = R.Replace("P131", AddresseKharidar)
    '    R = R.Replace("P132", Tedademadeh)
    '    R = R.Replace("P133", TedadeBand)
    '    R = R.Replace("P134", TedadeTabsareh)
    '    R = R.Replace("P135", TedadeSafheh)

    '    SW.Write(R)
    '    SW.Close()

    'End Sub

    'Public Function FillText(ByVal FullName As String, ByVal Father As String, ByVal ShomareShenasnameh As String, ByVal MelliCode As String, ByVal MasahateZamin As String, ByVal ShomareGhate As String, ByVal NameShahrak As String, ByVal AddreseShahrak As String, ByVal TedadKhab As String, ByVal MetrajeBana As String, ByVal MetrajeTeras As String, ByVal MablagheKol As String, ByVal PishPardakht As String, ByVal Aghsat As String, ByVal TedadCheck As String, ByVal MablagheEnteghaleSanad As String, ByVal ZamaneTahvil As String, ByVal AddresseKharidar As String, ByVal Tedademadeh As String, ByVal TedadeBand As String, ByVal TedadeTabsareh As String, ByVal TedadeSafheh As String, ByVal AllText As String)

    '    R = AllText
    '    R = R.Replace("P110", FullName)
    '    R = R.Replace("P111", Father)
    '    R = R.Replace("P112", ShomareShenasnameh)
    '    R = R.Replace("P113", MelliCode)
    '    R = R.Replace("P114", MasahateZamin)
    '    R = R.Replace("P115", ShomareGhate)
    '    R = R.Replace("P116", NameShahrak)
    '    R = R.Replace("P117", AddreseShahrak)
    '    R = R.Replace("P118", TedadKhab)
    '    R = R.Replace("P119", MetrajeBana)
    '    R = R.Replace("P120", MetrajeTeras)
    '    R = R.Replace("P121", MablagheKol)
    '    R = R.Replace("P122", NW.Convert(CU.DeCodeNumber(MablagheKol)))
    '    R = R.Replace("P123", PishPardakht)
    '    R = R.Replace("P124", NW.Convert(CU.DeCodeNumber(PishPardakht)))
    '    R = R.Replace("P125", Aghsat)
    '    R = R.Replace("P126", NW.Convert(CU.DeCodeNumber(Aghsat)))
    '    R = R.Replace("P127", TedadCheck)
    '    R = R.Replace("P128", MablagheEnteghaleSanad)
    '    R = R.Replace("P129", NW.Convert(CU.DeCodeNumber(MablagheEnteghaleSanad)))
    '    R = R.Replace("P130", ZamaneTahvil)
    '    R = R.Replace("P131", AddresseKharidar)
    '    R = R.Replace("P132", Tedademadeh)
    '    R = R.Replace("P133", TedadeBand)
    '    R = R.Replace("P134", TedadeTabsareh)
    '    R = R.Replace("P135", TedadeSafheh)

    '    Return R

    'End Function
End Class
