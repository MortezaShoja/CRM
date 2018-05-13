Imports Microsoft.VisualBasic

Public Class CurrentDate
    Private DC As New DateConvertor
    Public Function GetDate()
        DC.Convertor()
        Return (DC.Hyear & "/" & DC.Hmonth & "/" & DC.Hday)
    End Function
    Public Function GetDay()
        DC.Convertor()
        Return DC.HweekDay
    End Function
    Public Function GetDateAndDay()
        DC.Convertor()
        Return (DC.HweekDay & "  " & DC.Hday & "/" & DC.Hmonth & "/" & DC.Hyear)
    End Function
End Class
