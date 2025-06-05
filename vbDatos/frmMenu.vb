Public Class frmMenu
    Private Sub CerrarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicaciónToolStripMenuItem.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resultado = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Dim acercade As String = "Sistema de Gestión de Servicios" & vbCrLf &
            "Versión 1.0" & vbCrLf &
            "Desarrollado por jarlex" & vbCrLf &
            "Fecha: " & DateTime.Now.ToString("dd/MM/yyyy")
        MessageBox.Show(acercade, "Acerca de...", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GestiónEmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónEmpresasToolStripMenuItem.Click
        Form1.ShowDialog()
    End Sub

    Private Sub GestiónDeServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeServiciosToolStripMenuItem.Click
        frmServicio.ShowDialog()
    End Sub

    Private Sub GráficosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GráficosToolStripMenuItem.Click
        frmGraficos.ShowDialog()
    End Sub

    Private Sub FórmulariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FórmulariosToolStripMenuItem.Click

    End Sub

    Private Sub ProyecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProyecciónToolStripMenuItem.Click
        frmProyeccion.ShowDialog()
    End Sub
End Class