<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteServicios
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
        Me.components = New System.ComponentModel.Container()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VistaServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosPrestadosDataSet = New vbDatos.ServiciosPrestadosDataSet()
        Me.VistaServicioTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.vistaServicioTableAdapter()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaServicioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.CategoriaTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cerrar = New System.Windows.Forms.Button()
        CType(Me.VistaServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaServicioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "vbDatos.rptServicios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 113)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 337)
        Me.ReportViewer1.TabIndex = 0
        '
        'VistaServicioBindingSource
        '
        Me.VistaServicioBindingSource.DataMember = "vistaServicio"
        Me.VistaServicioBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        '
        'ServiciosPrestadosDataSet
        '
        Me.ServiciosPrestadosDataSet.DataSetName = "ServiciosPrestadosDataSet"
        Me.ServiciosPrestadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaServicioTableAdapter
        '
        Me.VistaServicioTableAdapter.ClearBeforeFill = True
        '
        'cmbCategoria
        '
        Me.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.cmbCategoria.DataSource = Me.CategoriaBindingSource
        Me.cmbCategoria.DisplayMember = "Nombre"
        Me.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategoria.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoria.ForeColor = System.Drawing.Color.Silver
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(597, 58)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(182, 31)
        Me.cmbCategoria.TabIndex = 1
        Me.cmbCategoria.ValueMember = "Id"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        '
        'VistaServicioBindingSource1
        '
        Me.VistaServicioBindingSource1.DataMember = "vistaServicio"
        Me.VistaServicioBindingSource1.DataSource = Me.ServiciosPrestadosDataSet
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmbCategoria)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cerrar)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 107)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(262, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe De Servicios Ofrecidos"
        '
        'cerrar
        '
        Me.cerrar.FlatAppearance.BorderSize = 0
        Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.Color.Silver
        Me.cerrar.Location = New System.Drawing.Point(748, 3)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(52, 30)
        Me.cerrar.TabIndex = 1
        Me.cerrar.Text = "X"
        Me.cerrar.UseVisualStyleBackColor = True
        '
        'frmReporteServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmReporteServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReporteServicios"
        CType(Me.VistaServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaServicioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ServiciosPrestadosDataSet As ServiciosPrestadosDataSet
    Friend WithEvents VistaServicioBindingSource As BindingSource
    Friend WithEvents VistaServicioTableAdapter As ServiciosPrestadosDataSetTableAdapters.vistaServicioTableAdapter
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents VistaServicioBindingSource1 As BindingSource
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As ServiciosPrestadosDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents Panel1 As Panel
    Private WithEvents Label1 As Label
    Friend WithEvents cerrar As Button
End Class
