Imports CrystalDecisions.CrystalReports.Engine
Public Class Form_Rekap_Gaji

    Private Sub Form_Rekap_Gaji_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrint.Click
        Dim report_detail As New ReportDocument
        report_detail.Load("..\..\CrystalReportRekapGaji.rpt")

        report_detail.SetParameterValue("dari", dtdari.Text)
        report_detail.SetParameterValue("sampai", dtsampai.Text)

        Form_Cetak_Rekap_Gaji.CrystalReportViewer1.ReportSource = report_detail
        Form_Cetak_Rekap_Gaji.CrystalReportViewer1.Refresh()
        Form_Cetak_Rekap_Gaji.Show()

    End Sub
End Class