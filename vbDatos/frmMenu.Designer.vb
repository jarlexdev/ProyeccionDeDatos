<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FórmulariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónEmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónDeServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GráficosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MásOpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlContenedor = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProyecciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlContenedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FórmulariosToolStripMenuItem, Me.MásOpcionesToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 12, 0, 12)
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1064, 47)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FórmulariosToolStripMenuItem
        '
        Me.FórmulariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestiónEmpresasToolStripMenuItem, Me.GestiónDeServiciosToolStripMenuItem, Me.GráficosToolStripMenuItem, Me.ProyecciónToolStripMenuItem})
        Me.FórmulariosToolStripMenuItem.ForeColor = System.Drawing.Color.Gray
        Me.FórmulariosToolStripMenuItem.Name = "FórmulariosToolStripMenuItem"
        Me.FórmulariosToolStripMenuItem.Size = New System.Drawing.Size(102, 23)
        Me.FórmulariosToolStripMenuItem.Text = "Fórmularios"
        '
        'GestiónEmpresasToolStripMenuItem
        '
        Me.GestiónEmpresasToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GestiónEmpresasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.GestiónEmpresasToolStripMenuItem.Name = "GestiónEmpresasToolStripMenuItem"
        Me.GestiónEmpresasToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.GestiónEmpresasToolStripMenuItem.Text = "Gestión de Empresas"
        '
        'GestiónDeServiciosToolStripMenuItem
        '
        Me.GestiónDeServiciosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GestiónDeServiciosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GestiónDeServiciosToolStripMenuItem.Name = "GestiónDeServiciosToolStripMenuItem"
        Me.GestiónDeServiciosToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.GestiónDeServiciosToolStripMenuItem.Text = "Gestión de Servicios"
        '
        'GráficosToolStripMenuItem
        '
        Me.GráficosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GráficosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GráficosToolStripMenuItem.Name = "GráficosToolStripMenuItem"
        Me.GráficosToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.GráficosToolStripMenuItem.Text = "Gráficos"
        '
        'MásOpcionesToolStripMenuItem
        '
        Me.MásOpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.MásOpcionesToolStripMenuItem.ForeColor = System.Drawing.Color.Gray
        Me.MásOpcionesToolStripMenuItem.Name = "MásOpcionesToolStripMenuItem"
        Me.MásOpcionesToolStripMenuItem.Size = New System.Drawing.Size(116, 23)
        Me.MásOpcionesToolStripMenuItem.Text = "Más Opciones"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AcercaDeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(157, 24)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarAplicaciónToolStripMenuItem})
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.Gray
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(51, 23)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CerrarAplicaciónToolStripMenuItem
        '
        Me.CerrarAplicaciónToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CerrarAplicaciónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarAplicaciónToolStripMenuItem.Name = "CerrarAplicaciónToolStripMenuItem"
        Me.CerrarAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.CerrarAplicaciónToolStripMenuItem.Text = "Cerrar Aplicación"
        '
        'pnlContenedor
        '
        Me.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pnlContenedor.Controls.Add(Me.Label2)
        Me.pnlContenedor.Controls.Add(Me.Label1)
        Me.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenedor.Location = New System.Drawing.Point(0, 47)
        Me.pnlContenedor.Name = "pnlContenedor"
        Me.pnlContenedor.Size = New System.Drawing.Size(1064, 634)
        Me.pnlContenedor.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(309, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(430, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SISTEMA PARA EL CONTROL DE SERVICIOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(382, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENÚ PRINCIPAL "
        '
        'ProyecciónToolStripMenuItem
        '
        Me.ProyecciónToolStripMenuItem.Name = "ProyecciónToolStripMenuItem"
        Me.ProyecciónToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.ProyecciónToolStripMenuItem.Text = "Proyección"
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 681)
        Me.Controls.Add(Me.pnlContenedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlContenedor.ResumeLayout(False)
        Me.pnlContenedor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FórmulariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MásOpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónEmpresasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónDeServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlContenedor As Panel
    Friend WithEvents GráficosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProyecciónToolStripMenuItem As ToolStripMenuItem
End Class
