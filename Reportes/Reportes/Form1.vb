Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Form1
    Sub verReporte(ByVal t As DataTable, ByVal ds As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)

            FrmVistaPrevia.ReportViewer1.LocalReport.DataSources.Clear()
            FrmVistaPrevia.ReportViewer1.LocalReport.DataSources.Add(rpt)
            FrmVistaPrevia.ReportViewer1.LocalReport.ReportPath = nombreRpt
            FrmVistaPrevia.ReportViewer1.Refresh()
            FrmVistaPrevia.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar reporte")
        End Try
    End Sub

    Private Sub ReportesDeCargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesDeCargosToolStripMenuItem.Click
        Try
            Dim tsql As String = "Select * from jobs"
            Dim conex As New SqlConnection(My.Settings.StrConn)
            Dim da As New SqlDataAdapter(tsql, conex)
            Dim t As New DataTable
            da.Fill(t)
            verReporte(t, "dsRegistros", "diseñosRpt\rptCargo.rdlc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Sub verReporteProfesion(ByVal t As DataTable, ByVal ds As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)

            FrmVistaPreviaEP.ReportViewer1.LocalReport.DataSources.Clear()
            FrmVistaPreviaEP.ReportViewer1.LocalReport.DataSources.Add(rpt)
            FrmVistaPreviaEP.ReportViewer1.LocalReport.ReportPath = nombreRpt
            FrmVistaPreviaEP.ReportViewer1.Refresh()
            FrmVistaPreviaEP.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar reporte")
        End Try
    End Sub


    Private Sub ReportesDeEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesDeEmpleadosToolStripMenuItem.Click
        Try
            Dim tsql As String = "SELECT jobs.job_title, employees.first_name, employees.last_name, employees.email, employees.phone_number, employees.hire_date, employees.salary
                                    FROM     employees INNER JOIN
                                             jobs ON employees.job_id = jobs.job_id"
            Dim conex As New SqlConnection(My.Settings.StrConn)
            Dim da As New SqlDataAdapter(tsql, conex)
            Dim t As New DataTable
            da.Fill(t)
            verReporteProfesion(t, "DsReportes", "diseñosRpt\RptEmpleadoTrabajo.rdlc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        FrmEmpleado.Show()
    End Sub
End Class
