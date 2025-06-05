Public Class frmServicio
    Private Sub ServicioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ServicioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ServiciosPrestadosDataSet)
    End Sub

    Private Sub frmServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CategoriaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.Categoria)
        Me.EmpresaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.empresa)
        Me.ServicioTableAdapter.Fill(Me.ServiciosPrestadosDataSet.servicio)
        With ServicioDataGridView
            .BorderStyle = BorderStyle.None
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .ColumnHeadersDefaultCellStyle.Font = New Font("Calibri", 10, FontStyle.Bold)
            .DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue
            .DefaultCellStyle.SelectionForeColor = Color.White
            .DefaultCellStyle.Font = New Font("Calibri", 10, FontStyle.Regular)
            .AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 230)
            .DefaultCellStyle.Font = New Font("Calibri", 10, FontStyle.Regular)
        End With
    End Sub
    Private Sub CargarServicios(Optional ByVal idCategoria As Integer = -1)
        If idCategoria = -1 Then
            Me.ServicioTableAdapter.Fill(Me.ServiciosPrestadosDataSet.servicio)
        Else
            Me.ServicioTableAdapter.FillByCategoria(Me.ServiciosPrestadosDataSet.servicio, idCategoria)
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        frmReporteServicios.ShowDialog()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        CargarServicios()
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged
        If cmbCategoria.SelectedValue IsNot Nothing Then
            Dim CategoriaId As Integer = Convert.ToInt32(cmbCategoria.SelectedValue)
            CargarServicios(CategoriaId)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Close()
        End If
    End Sub
End Class