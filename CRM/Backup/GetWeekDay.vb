Public Class GetWeekDay
    Private WeekDay As String
    Private DTT() As String
    Private Year, Month, Day As Integer

    Public Function DayOfWeek(ByVal ShamsiDate As String)
        DTT = ShamsiDate.ToString.Split("/")
        Year = Integer.Parse(DTT(0))
        Month = Integer.Parse(DTT(1))
        Day = Integer.Parse(DTT(2))

        Dim yr As Integer, century As Integer
        Select Case Month
            Case 1, 11, 12 : Month = Month + 3
            Case 2, 3, 10 : Month = Month + 6
            Case 4, 5, 6, 8, 9 : Month = Month + 1
            Case 7 : Month = Month + 4
        End Select
        century = Year \ 100
        yr = Year Mod 100
        DayOfWeek = (((26 * Month - 2) \ 10) + Day + yr + (yr \ 4) + (century \ 4) - (2 * century)) Mod 7

        Select Case DayOfWeek
            Case 0
                WeekDay = "شنبه"
            Case 1
                WeekDay = "یک شنبه"
            Case 2
                WeekDay = "دو شنبه"
            Case 3
                WeekDay = "سه شنبه"
            Case 4
                WeekDay = "چهار شنبه"
            Case 5
                WeekDay = "پنج شنبه"
            Case 6
                WeekDay = "جمعه"
        End Select
        Return WeekDay
    End Function
End Class
