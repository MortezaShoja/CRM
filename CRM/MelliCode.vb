Public Class MelliCode

    Public Function CodeMelliCode(ByVal MelliCode As String)
        If MelliCode.Length = 10 And IsNumeric(MelliCode) Then
            Dim MelliNo As String = MelliCode
            MelliCode = Mid(MelliNo, 1, 3) & "-"
            MelliCode += Mid(MelliNo, 4, 6) & "-"
            MelliCode += Mid(MelliNo, 10, 1)
        Else
            Return "خطا در درج کد ملی"
        End If
        Return MelliCode
    End Function

    Public Function DeCodeMelliCode(ByVal MelliCode As String)
        If IsNumeric(Mid(MelliCode, 1, 3)) = True And Mid(MelliCode, 4, 1) = "-" And IsNumeric(Mid(MelliCode, 5, 6)) = True And Mid(MelliCode, 11, 1) = "-" And IsNumeric(Mid(MelliCode, 12, 1)) = True Then
            Return MelliCode.Replace("-", "")
        Else
            Return "خطا در درج کد ملی"
        End If
    End Function

End Class
