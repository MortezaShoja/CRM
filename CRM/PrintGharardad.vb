Imports System.Windows.Forms

Public Class PrintGharardad
    Private SqlCon As New SQL
    Private Cmd As New SqlClient.SqlCommand
    Private Sdr As SqlClient.SqlDataReader
    Private RD As New ReplaceData
    Private nTow As New NumberToWord
    Private Cu As New Currency
    Private Place, GharardadName, FileID As String
    Private DC As New DateConvertor
    Private sh As New SharayetPishPardakht
    Private ShAghsat As New SharayetAghsat
    Private RDate As New ReturnDate


    Public Sub PrintData(ByVal ID As String)

        Dim Rpt(4) As String
        Rpt(0) = "GharardadNo"
        Rpt(1) = "[Check]"
        Rpt(2) = "Havale"
        Rpt(3) = "Naghdi"
        Rpt(4) = "Safte"

        For i As Integer = 0 To 4
            If System.IO.File.Exists("c:\" & Rpt(i) & ".xml") Then
                System.IO.File.Delete("c:\" & Rpt(i) & ".xml")
            End If
        Next

        For i As Integer = 0 To 4

            Dim DataAdapter As New SqlClient.SqlDataAdapter("select * from " & Rpt(i) & " where ID=N'" & ID & "' order by formtype desc", SqlCon.SqlCon)
            Dim DataSet As New DataSet
            DataAdapter.Fill(DataSet)
            DataSet.WriteXml("c:\" & Rpt(i) & ".xml")
            SqlCon.SqlCon.Close()
            '-------------------------------------

            'If i >= 1 Then
            '    Cmd.CommandText = "select * from " & Rpt(i) & " where ID=N'" & ID & "'"
            '    Cmd.Connection = SqlCon.SqlCon

            '    SqlCon.SqlCon.Open()
            'Try
            ' Sdr = Cmd.ExecuteReader()
            'If Sdr.HasRows = True Then
            '    Dim frm As New frmRptViewer
            '    Select Case Rpt(i)
            '        Case Is = "[Check]"
            '            frm.CrystalReportViewer1.ReportSource = frm.rptCheck1
            '            frm.rptCheck1.PrintToPrinter(1, True, 0, 0)
            '        Case Is = "Havale"
            '            frm.CrystalReportViewer1.ReportSource = frm.rptHavale1
            '            frm.rptHavale1.PrintToPrinter(1, True, 0, 0)
            '        Case Is = "Naghdi"
            '            frm.CrystalReportViewer1.ReportSource = frm.rptNaghdi1
            '            frm.rptNaghdi1.PrintToPrinter(1, True, 0, 0)
            '        Case Is = "Safte"
            '            frm.CrystalReportViewer1.ReportSource = frm.rptSafte1
            '            frm.rptSafte1.PrintToPrinter(1, True, 0, 0)
            '    End Select
            'End If
            'Sdr.Close()
            '    Catch ex As Exception
            '    MessageBox.Show(ex.Message.ToString, "خطا:::...", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            'Finally
            '    SqlCon.SqlCon.Close()
            'End Try
            'End If

        Next
    End Sub

End Class
