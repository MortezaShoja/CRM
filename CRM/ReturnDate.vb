Public Class ReturnDate
    Private NewD As String

    Public Function [Return](ByVal LTRDate As String)
        Dim D() As String = LTRDate.ToString.Split("/")
        Dim RTLD(2) As String
        Try
            RTLD(0) = D(2)
            RTLD(1) = D(1)
            RTLD(2) = D(0)
            NewD = RTLD(0) & "/" & RTLD(1) & "/" & RTLD(2)
        Catch ex As Exception
            Return (LTRDate)
            Exit Function
        End Try

        Return NewD
    End Function




End Class
