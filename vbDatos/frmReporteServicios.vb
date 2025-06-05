Imports Microsoft.Reporting.WinForms

Public Class frmReporteServicios
    Private Sub frmReporteServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CategoriaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.Categoria)
        Me.VistaServicioTableAdapter.Fill(Me.ServiciosPrestadosDataSet.vistaServicio)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Dim vServicio As New ServiciosPrestadosDataSetTableAdapters.vistaServicioTableAdapter()
        Dim ds As New ServiciosPrestadosDataSet()
        vServicio.Fill(ds.vistaServicio)
        ReportViewer1.LocalReport.DataSources.Clear()
        Dim reportDataSource As New ReportDataSource("DataSet1", ds.Tables("vistaServicio"))
        ReportViewer1.LocalReport.DataSources.Add(reportDataSource)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged

    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
    End Sub
End Class