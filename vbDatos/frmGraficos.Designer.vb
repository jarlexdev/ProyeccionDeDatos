<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGraficos
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.notas = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.ServiciosPrestadosDataSet = New vbDatos.ServiciosPrestadosDataSet()
        Me.VistaServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VistaServicioTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.vistaServicioTableAdapter()
        Me.TableAdapterManager = New vbDatos.ServiciosPrestadosDataSetTableAdapters.TableAdapterManager()
        Me.VistaServicioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bntPrimero = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.notas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaServicioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Muestra de Gráfico:"
        '
        'notas
        '
        ChartArea3.Name = "ChartArea1"
        Me.notas.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.notas.Legends.Add(Legend3)
        Me.notas.Location = New System.Drawing.Point(30, 56)
        Me.notas.Name = "notas"
        Me.notas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.notas.Series.Add(Series3)
        Me.notas.Size = New System.Drawing.Size(448, 338)
        Me.notas.TabIndex = 1
        Me.notas.Text = "Chart1"
        '
        'btnMostrar
        '
        Me.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.Color.White
        Me.btnMostrar.Location = New System.Drawing.Point(618, 359)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(97, 35)
        Me.btnMostrar.TabIndex = 3
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'ServiciosPrestadosDataSet
        '
        Me.ServiciosPrestadosDataSet.DataSetName = "ServiciosPrestadosDataSet"
        Me.ServiciosPrestadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaServicioBindingSource
        '
        Me.VistaServicioBindingSource.DataMember = "vistaServicio"
        Me.VistaServicioBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        '
        'VistaServicioTableAdapter
        '
        Me.VistaServicioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.empresaTableAdapter = Nothing
        Me.TableAdapterManager.servicioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = vbDatos.ServiciosPrestadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VistaServicioDataGridView
        '
        Me.VistaServicioDataGridView.AllowUserToAddRows = False
        Me.VistaServicioDataGridView.AllowUserToDeleteRows = False
        Me.VistaServicioDataGridView.AutoGenerateColumns = False
        Me.VistaServicioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VistaServicioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.VistaServicioDataGridView.DataSource = Me.VistaServicioBindingSource
        Me.VistaServicioDataGridView.Location = New System.Drawing.Point(26, 45)
        Me.VistaServicioDataGridView.Name = "VistaServicioDataGridView"
        Me.VistaServicioDataGridView.ReadOnly = True
        Me.VistaServicioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VistaServicioDataGridView.Size = New System.Drawing.Size(672, 224)
        Me.VistaServicioDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Finalizado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Finalizado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Empresa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Empresa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Categoria"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'bntPrimero
        '
        Me.bntPrimero.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.bntPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bntPrimero.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntPrimero.ForeColor = System.Drawing.Color.White
        Me.bntPrimero.Location = New System.Drawing.Point(183, 291)
        Me.bntPrimero.Name = "bntPrimero"
        Me.bntPrimero.Size = New System.Drawing.Size(80, 50)
        Me.bntPrimero.TabIndex = 6
        Me.bntPrimero.Text = "<<"
        Me.bntPrimero.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnterior.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.ForeColor = System.Drawing.Color.White
        Me.btnAnterior.Location = New System.Drawing.Point(271, 291)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(80, 50)
        Me.btnAnterior.TabIndex = 7
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSiguiente.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.ForeColor = System.Drawing.Color.White
        Me.btnSiguiente.Location = New System.Drawing.Point(359, 291)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(80, 50)
        Me.btnSiguiente.TabIndex = 8
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUltimo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.ForeColor = System.Drawing.Color.White
        Me.btnUltimo.Location = New System.Drawing.Point(447, 291)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(80, 50)
        Me.btnUltimo.TabIndex = 9
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 39)
        Me.Panel1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(16, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fórmulario para la gestión de gráficos"
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(1161, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(43, 28)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "X"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btnUltimo)
        Me.Panel3.Controls.Add(Me.VistaServicioDataGridView)
        Me.Panel3.Controls.Add(Me.btnSiguiente)
        Me.Panel3.Controls.Add(Me.btnMostrar)
        Me.Panel3.Controls.Add(Me.btnAnterior)
        Me.Panel3.Controls.Add(Me.bntPrimero)
        Me.Panel3.Location = New System.Drawing.Point(0, 35)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(718, 417)
        Me.Panel3.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(22, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Servicios registrados"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.Controls.Add(Me.notas)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(704, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 417)
        Me.Panel2.TabIndex = 21
        '
        'frmGraficos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGraficos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.notas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaServicioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents notas As DataVisualization.Charting.Chart
    Friend WithEvents btnMostrar As Button
    Friend WithEvents ServiciosPrestadosDataSet As ServiciosPrestadosDataSet
    Friend WithEvents VistaServicioBindingSource As BindingSource
    Friend WithEvents VistaServicioTableAdapter As ServiciosPrestadosDataSetTableAdapters.vistaServicioTableAdapter
    Friend WithEvents TableAdapterManager As ServiciosPrestadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VistaServicioDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents bntPrimero As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
End Class
