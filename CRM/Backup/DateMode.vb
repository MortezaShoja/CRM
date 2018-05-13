Public Class DateMode
    Private YYYY, MM, DD, [Date] As String

    Public Function CodeDate(ByVal StringDate As Integer)

        YYYY = Mid(StringDate, 1, 4)
        MM = Mid(StringDate, 5, 2)
        DD = Mid(StringDate, 7, 2)

        If YYYY >= 1300 Then
            If MM = 0 Or MM <= 12 Then
                If DD = 0 Or DD <= 31 Then
                    [Date] = (YYYY & "/" & MM & "/" & DD)
                End If
            End If
        End If
        If [Date].ToString.Length = 10 Then
            Return [Date]
        Else
            Return " خطا در درج تاریخ"
        End If

    End Function

    Public Function DECodeDate(ByVal StringDate As String)
        Return StringDate.Replace("/", "")
    End Function

End Class
