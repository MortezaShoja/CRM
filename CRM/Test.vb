Public Class Test
    Dim TblXML As New DataTable
    Private SqlConnection As New SQL
    Private Cmd1, Cmd2 As SqlClient.SqlCommand
    Private Sdr1 As SqlClient.SqlDataReader
    Private DC As DateConvertor

    Private Sub Test_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TblXML.TableName = "GharardadText"
        TblXML.Columns.Add("Madeh")
        TblXML.Columns.Add("BandText")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim RowXML1 As DataRow = TblXML.NewRow
        Dim RowXML2 As DataRow = TblXML.NewRow

        RowXML1(0) = Me.TextBox1.Text.ToString
        RowXML2(1) = Me.TextBox2.Text.ToString
        TblXML.Rows.Add(RowXML1)
        TblXML.Rows.Add(RowXML2)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TblXML.WriteXml("xml\me.txt")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim SCG As New SanadCodeGenerator
        DC = New DateConvertor
        DC.Convertor()

        Cmd2 = New SqlClient.SqlCommand
        Cmd2.Connection = SqlConnection.SqlCon
        Dim Count As Integer = 0
        Cmd1 = New SqlClient.SqlCommand("select Count(*) from Bank", SqlConnection.SqlCon)
        SqlConnection.SqlCon.Open()
        Try
            Sdr1 = Cmd1.ExecuteReader
            While Sdr1.Read
                Count = Sdr1(0).ToString
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "خطا:::...GetCountOfBank", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        Finally
            SqlConnection.SqlCon.Close()
        End Try
        '----------------------
        For I As Integer = 1 To Count
            Cmd2 = New SqlClient.SqlCommand
            Cmd2.Connection = SqlConnection.SqlCon
            Cmd1 = New SqlClient.SqlCommand("UPDATE Bank SET SanadCode= '" & Mid(DC.Hyear, 3, 2) + DC.Hmonth.ToString + DC.Hday.ToString + Now.Hour.ToString + Now.Second.ToString + Now.Millisecond.ToString + I.ToString & "' WHERE Row='" & I & "'", SqlConnection.SqlCon)
            SqlConnection.SqlCon.Open()
            Try
                Cmd1.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString, "خطا:::...GetCountOfBank", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Finally
                SqlConnection.SqlCon.Close()
            End Try
        Next
        MessageBox.Show("Done")

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim NtoW As New NumberToWord
        Me.Label1.Text = NtoW.Convert(Me.TextBox2.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim RptRD As New RptResidDaryaftVajh
        RptRD.Generate(1704)

        Dim frm As New frmReporter
        'frm.MdiParent = Mehregan.Parent
        frm.CrystalReportViewer1.ReportSource = frm.rptResideDaryaft1
        frm.rptResideDaryaft1.PrintOptions.PaperOrientation = CrystalDecisions.Shared.PaperOrientation.DefaultPaperOrientation
        frm.rptResideDaryaft1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        frm.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim WTR As New WordTextReplacer
        'WTR.Replace()
    End Sub

    Public Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If System.IO.Directory.Exists("C:\Reports") = False Then
            System.IO.Directory.CreateDirectory("C:\Reports")
        End If

        Dim frm As New frmReporter
        'frm.MdiParent = Mehregan.Parent
        frm.CrystalReportViewer1.ReportSource = frm.rptPishGhrardad1
        frm.rptPishGhrardad1.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperA4
        frm.Show()
    End Sub
End Class