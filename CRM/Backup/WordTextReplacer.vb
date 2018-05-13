Imports System.Windows.Forms
Imports Microsoft.Office.Interop.Word

Public Class WordTextReplacer

    Public Sub Replace(ByVal Name As String, ByVal Fase As String, ByVal Ghete As String, ByVal Fname As String, ByVal ShSh As String, ByVal Sadere As String, ByVal Mt As String, ByVal Mc As String, ByVal Address As String, ByVal Hphone As String, ByVal Mobile As String, ByVal Metraj As String, ByVal Mprice As String, ByVal MpriceText As String, ByVal GPrice As String, ByVal GPriceText As String, ByVal Pish As String, ByVal Albaghi As String, ByVal AlbaghiText As String, ByVal TedadGhest As String, ByVal Gno As String, ByVal GDate As String)

        Dim Target As String
        Dim appWord As New Microsoft.Office.Interop.Word.Application
        Dim docWord As New Microsoft.Office.Interop.Word.Document
        docWord = appWord.Documents.Open(Target)
        Try
            Dim myStoryRange As Microsoft.Office.Interop.Word.Range
            For Each myStoryRange In docWord.StoryRanges
                With myStoryRange.Find
                    .Text = "<Name>"
                    .Replacement.Text = Name
                    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                    .Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)
                End With
                With myStoryRange.Find
                    .Text = "<Fase>"
                    .Replacement.Text = Fase
                    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                    .Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)
                End With
                With myStoryRange.Find
                    .Text = "<Ghete>"
                    .Replacement.Text = Ghete
                    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                    .Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)
                End With
                With myStoryRange.Find
                    .Text = "<Fname>"
                    .Replacement.Text = Fname
                    .Wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue
                    .Execute(Replace:=Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll)
                End With

            Next myStoryRange
            docWord.Save()
            appWord.Quit()
            docWord = Nothing
            appWord = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DoReplace(ByVal Text As String, ByVal ReplaceText As String, ByVal Target As String)

    End Sub
End Class
