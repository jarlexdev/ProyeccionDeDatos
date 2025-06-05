Public Class Form1
    Private Sub EmpresaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpresaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ServiciosPrestadosDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmpresaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.empresa)
        With EmpresaDataGridView
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
            .DefaultCellStyle.Font = New Font("Calibri", 10, FontStyle.Regular)
        End With
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        EmpresaBindingSource.AddNew()
        NombreTextBox.Focus()
    End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        EmpresaBindingSource.CancelEdit()
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        EmpresaBindingSource.EndEdit()
        EmpresaTableAdapter.Update(ServiciosPrestadosDataSet)
        ServiciosPrestadosDataSet.AcceptChanges()
        Me.EmpresaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.empresa)
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        NombreTextBox.Focus()
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Confirme", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                EmpresaBindingSource.RemoveCurrent()
                EmpresaTableAdapter.Update(ServiciosPrestadosDataSet)
                ServiciosPrestadosDataSet.AcceptChanges()
                Me.EmpresaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.empresa)
            Catch ex As Exception
                MessageBox.Show("Lo siento. No es posible eliminar el registro.", "Atención")
                Me.EmpresaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.empresa)
            End Try
        End If
    End Sub

    Private Sub imprimir_Click(sender As Object, e As EventArgs) Handles imprimir.Click
        verEmpresas.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Close()
        End If
    End Sub
End Class
