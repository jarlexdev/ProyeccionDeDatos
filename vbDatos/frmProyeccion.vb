Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data

Public Class frmProyeccion

    Private Sub frmProyeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ServiciosPrestadosDataSet.Consulta1' Puede moverla o quitarla según sea necesario.
        Me.Consulta1TableAdapter.Fill(Me.ServiciosPrestadosDataSet.Consulta1)
    End Sub

    Private Function ObtenerDataTableDesdeDataGridView(dgv As DataGridView) As DataTable
        Dim dt As New DataTable()

        ' Añadir las columnas del DataGridView al DataTable
        For Each column As DataGridViewColumn In dgv.Columns
            dt.Columns.Add(column.HeaderText, column.ValueType)
        Next

        ' Añadir los datos del DataGridView al DataTable
        For Each row As DataGridViewRow In dgv.Rows
            If Not row.IsNewRow Then
                Dim dr As DataRow = dt.NewRow()
                For i As Integer = 0 To row.Cells.Count - 1
                    dr(i) = row.Cells(i).Value
                Next
                dt.Rows.Add(dr)
            End If
        Next

        Return dt
    End Function

    Private Function ProyectarCobroMesSiguiente(dtCobros As DataTable) As Double
        Dim n As Integer = dtCobros.Rows.Count
        If n < 2 Then
            MessageBox.Show("Se necesitan al menos dos meses de datos para la proyección.")
            Return -1
        End If

        Dim sumX As Double = 0
        Dim sumY As Double = 0
        Dim sumXY As Double = 0
        Dim sumX2 As Double = 0

        For i As Integer = 0 To n - 1
            Dim mes As Integer = Convert.ToInt32(dtCobros.Rows(i)(0))
            Dim totalCobrado As Double = Convert.ToDouble(dtCobros.Rows(i)(1))

            sumX += mes
            sumY += totalCobrado
            sumXY += mes * totalCobrado
            sumX2 += mes * mes
        Next

        Dim denominador As Double = (n * sumX2 - sumX * sumX)
        If denominador = 0 Then
            MessageBox.Show("No se puede realizar la proyección (división por cero).")
            Return -1
        End If

        Dim a As Double = (n * sumXY - sumX * sumY) / denominador
        Dim b As Double = (sumY - a * sumX) / n

        Dim ultimoMes As Integer = Convert.ToInt32(dtCobros.Rows(n - 1)(0))
        Dim proximoMes As Integer = ultimoMes + 1

        Dim proyeccion As Double = a * proximoMes + b
        Return proyeccion
    End Function

    Private Sub GraficarCobrosPorMes(dtCobros As DataTable, proyeccion As Double)
        Chart1.Series.Clear()
        Dim serieHistorica As New Series()
        serieHistorica.ChartType = SeriesChartType.Line
        serieHistorica.Name = "Cobros Mensuales"
        serieHistorica.XValueMember = 0
        serieHistorica.YValueMembers = 1
        serieHistorica.IsValueShownAsLabel = True
        Chart1.DataSource = dtCobros
        Chart1.Series.Add(serieHistorica)

        Dim serieProyeccion As New Series()
        serieProyeccion.ChartType = SeriesChartType.Point
        serieProyeccion.Name = "Proyección"
        serieProyeccion.Points.AddXY(Convert.ToInt32(dtCobros.Rows(dtCobros.Rows.Count - 1)(0)) + 1, proyeccion)
        serieProyeccion.MarkerSize = 10
        serieProyeccion.MarkerStyle = MarkerStyle.Circle
        serieProyeccion.IsValueShownAsLabel = True
        Chart1.Series.Add(serieProyeccion)

        If Chart1.ChartAreas.Count = 0 Then
            Chart1.ChartAreas.Add(New ChartArea())
        End If
        Chart1.ChartAreas(0).AxisX.Title = "Mes"
        Chart1.ChartAreas(0).AxisY.Title = "Total Cobrado"

        Chart1.ChartAreas(0).AxisX.Maximum = Convert.ToInt32(dtCobros.Rows(dtCobros.Rows.Count - 1)(0)) + 2
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim dtCobros As DataTable = ObtenerDataTableDesdeDataGridView(Consulta1DataGridView)

        If dtCobros.Rows.Count > 0 Then
            Dim proyeccion As Double = ProyectarCobroMesSiguiente(dtCobros)
            GraficarCobrosPorMes(dtCobros, proyeccion)

            If proyeccion <> -1 Then
                Dim ultimoMes As Integer = Convert.ToInt32(dtCobros.Rows(dtCobros.Rows.Count - 1)(0))
                MessageBox.Show("Proyección para el mes " & (ultimoMes + 1) & ": $" & Math.Round(proyeccion, 2))
            End If
        Else
            MessageBox.Show("No hay datos en la tabla para proyectar o graficar.")
        End If
    End Sub
End Class