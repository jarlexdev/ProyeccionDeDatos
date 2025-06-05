Public Class frmGraficos
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim fila As DataGridViewRow
        Dim Categoria As String
        Dim Precio As Double
        VistaServicioBindingSource.MoveFirst()
        For i = 1 To VistaServicioBindingSource.Count
            fila = VistaServicioDataGridView.CurrentRow()
            Categoria = fila.Cells(4).Value
            Precio = fila.Cells(1).Value
            notas.Series("Series1").Points.AddXY(Categoria, Precio)
            VistaServicioBindingSource.MoveNext()
        Next
    End Sub
    Private Sub frmGraficos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VistaServicioTableAdapter.Fill(Me.ServiciosPrestadosDataSet.vistaServicio)
        With VistaServicioDataGridView
            .BorderStyle = BorderStyle.None
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 10, FontStyle.Bold)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230)
            .DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue
            .DefaultCellStyle.SelectionForeColor = Color.White
            ' Fuente de las filas normales
            .DefaultCellStyle.Font = New Font("Calibri", 10, FontStyle.Regular)
        End With
    End Sub

    Private Sub bntPrimero_Click(sender As Object, e As EventArgs) Handles bntPrimero.Click
        VistaServicioBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        VistaServicioBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        VistaServicioBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        VistaServicioBindingSource.MoveLast()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Close()
        End If
    End Sub
End Class