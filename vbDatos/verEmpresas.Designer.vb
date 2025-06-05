<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verEmpresas
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosPrestadosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosPrestadosDataSet = New vbDatos.ServiciosPrestadosDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.EmpresaTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.empresaTableAdapter()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosPrestadosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "empresa"
        Me.EmpresaBindingSource.DataSource = Me.ServiciosPrestadosDataSetBindingSource
        '
        'ServiciosPrestadosDataSetBindingSource
        '
        Me.ServiciosPrestadosDataSetBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        Me.ServiciosPrestadosDataSetBindingSource.Position = 0
        '
        'ServiciosPrestadosDataSet
        '
        Me.ServiciosPrestadosDataSet.DataSetName = "ServiciosPrestadosDataSet"
        Me.ServiciosPrestadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(262, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe De Empresas Que Se Atiende"
        '
        'cerrar
        '
        Me.cerrar.FlatAppearance.BorderSize = 0
        Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.Color.Silver
        Me.cerrar.Location = New System.Drawing.Point(752, 3)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(52, 30)
        Me.cerrar.TabIndex = 1
        Me.cerrar.Text = "X"
        Me.cerrar.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None
        ReportDataSource1.Name = "BaseDatos"
        ReportDataSource1.Value = Me.EmpresaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "vbDatos.rptEmpresa.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-2, 100)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(804, 344)
        Me.ReportViewer1.TabIndex = 2
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'btnFiltrar
        '
        Me.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrar.ForeColor = System.Drawing.Color.Silver
        Me.btnFiltrar.Location = New System.Drawing.Point(715, 58)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 30)
        Me.btnFiltrar.TabIndex = 3
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'txtSaldo
        '
        Me.txtSaldo.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaldo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.ForeColor = System.Drawing.Color.White
        Me.txtSaldo.Location = New System.Drawing.Point(555, 58)
        Me.txtSaldo.Multiline = True
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(154, 30)
        Me.txtSaldo.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtSaldo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnFiltrar)
        Me.Panel1.Controls.Add(Me.cerrar)
        Me.Panel1.Location = New System.Drawing.Point(-2, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 110)
        Me.Panel1.TabIndex = 5
        '
        'verEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 443)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "verEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe de empresas que se atiende"
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosPrestadosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Label1 As Label
    Friend WithEvents cerrar As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ServiciosPrestadosDataSetBindingSource As BindingSource
    Friend WithEvents ServiciosPrestadosDataSet As ServiciosPrestadosDataSet
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents EmpresaTableAdapter As ServiciosPrestadosDataSetTableAdapters.empresaTableAdapter
    Friend WithEvents btnFiltrar As Button
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Panel1 As Panel
End Class
