<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicio
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
        Dim FinalizadoLabel As System.Windows.Forms.Label
        Dim TipoServicioLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim IdCategoriaLabel As System.Windows.Forms.Label
        Dim IdEmpresaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Me.ServiciosPrestadosDataSet = New vbDatos.ServiciosPrestadosDataSet()
        Me.EmpresaTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.empresaTableAdapter()
        Me.ServicioDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.ServicioTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.servicioTableAdapter()
        Me.TableAdapterManager = New vbDatos.ServiciosPrestadosDataSetTableAdapters.TableAdapterManager()
        Me.CategoriaTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.CategoriaTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdEmpresaComboBox = New System.Windows.Forms.ComboBox()
        Me.IdCategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.TipoServicioComboBox = New System.Windows.Forms.ComboBox()
        Me.FinalizadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        FinalizadoLabel = New System.Windows.Forms.Label()
        TipoServicioLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        IdCategoriaLabel = New System.Windows.Forms.Label()
        IdEmpresaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FinalizadoLabel
        '
        FinalizadoLabel.AutoSize = True
        FinalizadoLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FinalizadoLabel.ForeColor = System.Drawing.Color.Silver
        FinalizadoLabel.Location = New System.Drawing.Point(6, 306)
        FinalizadoLabel.Name = "FinalizadoLabel"
        FinalizadoLabel.Size = New System.Drawing.Size(95, 23)
        FinalizadoLabel.TabIndex = 14
        FinalizadoLabel.Text = "Finalizado:"
        '
        'TipoServicioLabel
        '
        TipoServicioLabel.AutoSize = True
        TipoServicioLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoServicioLabel.ForeColor = System.Drawing.Color.Silver
        TipoServicioLabel.Location = New System.Drawing.Point(6, 266)
        TipoServicioLabel.Name = "TipoServicioLabel"
        TipoServicioLabel.Size = New System.Drawing.Size(116, 23)
        TipoServicioLabel.TabIndex = 12
        TipoServicioLabel.Text = "Tipo Servicio:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioLabel.ForeColor = System.Drawing.Color.Silver
        PrecioLabel.Location = New System.Drawing.Point(6, 227)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(65, 23)
        PrecioLabel.TabIndex = 10
        PrecioLabel.Text = "Precio:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.ForeColor = System.Drawing.Color.Silver
        DescripcionLabel.Location = New System.Drawing.Point(6, 188)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(108, 23)
        DescripcionLabel.TabIndex = 8
        DescripcionLabel.Text = "Descripcion:"
        '
        'IdCategoriaLabel
        '
        IdCategoriaLabel.AutoSize = True
        IdCategoriaLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdCategoriaLabel.ForeColor = System.Drawing.Color.Silver
        IdCategoriaLabel.Location = New System.Drawing.Point(6, 149)
        IdCategoriaLabel.Name = "IdCategoriaLabel"
        IdCategoriaLabel.Size = New System.Drawing.Size(110, 23)
        IdCategoriaLabel.TabIndex = 6
        IdCategoriaLabel.Text = "Id Categoria:"
        '
        'IdEmpresaLabel
        '
        IdEmpresaLabel.AutoSize = True
        IdEmpresaLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdEmpresaLabel.ForeColor = System.Drawing.Color.Silver
        IdEmpresaLabel.Location = New System.Drawing.Point(6, 110)
        IdEmpresaLabel.Name = "IdEmpresaLabel"
        IdEmpresaLabel.Size = New System.Drawing.Size(102, 23)
        IdEmpresaLabel.TabIndex = 4
        IdEmpresaLabel.Text = "Id Empresa:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.ForeColor = System.Drawing.Color.Silver
        FechaLabel.Location = New System.Drawing.Point(6, 69)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(61, 23)
        FechaLabel.TabIndex = 2
        FechaLabel.Text = "Fecha:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdLabel.ForeColor = System.Drawing.Color.Silver
        IdLabel.Location = New System.Drawing.Point(6, 27)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(30, 23)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'ServiciosPrestadosDataSet
        '
        Me.ServiciosPrestadosDataSet.DataSetName = "ServiciosPrestadosDataSet"
        Me.ServiciosPrestadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'ServicioDataGridView
        '
        Me.ServicioDataGridView.AllowUserToAddRows = False
        Me.ServicioDataGridView.AllowUserToDeleteRows = False
        Me.ServicioDataGridView.AutoGenerateColumns = False
        Me.ServicioDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ServicioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServicioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.ServicioDataGridView.DataSource = Me.ServicioBindingSource
        Me.ServicioDataGridView.Location = New System.Drawing.Point(13, 46)
        Me.ServicioDataGridView.Name = "ServicioDataGridView"
        Me.ServicioDataGridView.ReadOnly = True
        Me.ServicioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ServicioDataGridView.Size = New System.Drawing.Size(696, 302)
        Me.ServicioDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 25
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdEmpresa"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.EmpresaBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Nombre"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre de la Empresa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Id"
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "empresa"
        Me.EmpresaBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdCategoria"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Categoría"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'ServicioBindingSource
        '
        Me.ServicioBindingSource.DataMember = "servicio"
        Me.ServicioBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        '
        'EmpresaBindingSource1
        '
        Me.EmpresaBindingSource1.DataMember = "empresa"
        Me.EmpresaBindingSource1.DataSource = Me.ServiciosPrestadosDataSet
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.White
        Me.btnLimpiar.Location = New System.Drawing.Point(632, 8)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(77, 31)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DataSource = Me.CategoriaBindingSource
        Me.cmbCategoria.DisplayMember = "Nombre"
        Me.cmbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategoria.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(459, 8)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(167, 31)
        Me.cmbCategoria.TabIndex = 17
        Me.cmbCategoria.ValueMember = "Id"
        '
        'ServicioTableAdapter
        '
        Me.ServicioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.empresaTableAdapter = Nothing
        Me.TableAdapterManager.servicioTableAdapter = Me.ServicioTableAdapter
        Me.TableAdapterManager.UpdateOrder = vbDatos.ServiciosPrestadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1207, 36)
        Me.Panel1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(16, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(245, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fórmulario para la gestión de servicios"
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
        Me.Panel3.Controls.Add(Me.btnLimpiar)
        Me.Panel3.Controls.Add(Me.cmbCategoria)
        Me.Panel3.Controls.Add(Me.ServicioDataGridView)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(-1, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(718, 417)
        Me.Panel3.TabIndex = 19
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(FechaLabel)
        Me.GroupBox1.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox1.Controls.Add(IdEmpresaLabel)
        Me.GroupBox1.Controls.Add(Me.IdEmpresaComboBox)
        Me.GroupBox1.Controls.Add(IdCategoriaLabel)
        Me.GroupBox1.Controls.Add(Me.IdCategoriaComboBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(PrecioLabel)
        Me.GroupBox1.Controls.Add(Me.PrecioTextBox)
        Me.GroupBox1.Controls.Add(TipoServicioLabel)
        Me.GroupBox1.Controls.Add(Me.TipoServicioComboBox)
        Me.GroupBox1.Controls.Add(FinalizadoLabel)
        Me.GroupBox1.Controls.Add(Me.FinalizadoCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(468, 370)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'IdTextBox
        '
        Me.IdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicioBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(131, 24)
        Me.IdTextBox.Multiline = True
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(301, 33)
        Me.IdTextBox.TabIndex = 1
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ServicioBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(131, 63)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(301, 31)
        Me.FechaDateTimePicker.TabIndex = 3
        '
        'IdEmpresaComboBox
        '
        Me.IdEmpresaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ServicioBindingSource, "IdEmpresa", True))
        Me.IdEmpresaComboBox.DataSource = Me.EmpresaBindingSource1
        Me.IdEmpresaComboBox.DisplayMember = "Nombre"
        Me.IdEmpresaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IdEmpresaComboBox.FormattingEnabled = True
        Me.IdEmpresaComboBox.Location = New System.Drawing.Point(131, 102)
        Me.IdEmpresaComboBox.Name = "IdEmpresaComboBox"
        Me.IdEmpresaComboBox.Size = New System.Drawing.Size(301, 31)
        Me.IdEmpresaComboBox.TabIndex = 5
        Me.IdEmpresaComboBox.ValueMember = "Id"
        '
        'IdCategoriaComboBox
        '
        Me.IdCategoriaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ServicioBindingSource, "Id", True))
        Me.IdCategoriaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IdCategoriaComboBox.FormattingEnabled = True
        Me.IdCategoriaComboBox.Location = New System.Drawing.Point(131, 141)
        Me.IdCategoriaComboBox.Name = "IdCategoriaComboBox"
        Me.IdCategoriaComboBox.Size = New System.Drawing.Size(301, 31)
        Me.IdCategoriaComboBox.TabIndex = 7
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicioBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(131, 180)
        Me.DescripcionTextBox.Multiline = True
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(301, 31)
        Me.DescripcionTextBox.TabIndex = 9
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicioBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(131, 219)
        Me.PrecioTextBox.Multiline = True
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(301, 31)
        Me.PrecioTextBox.TabIndex = 11
        '
        'TipoServicioComboBox
        '
        Me.TipoServicioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicioBindingSource, "TipoServicio", True))
        Me.TipoServicioComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TipoServicioComboBox.FormattingEnabled = True
        Me.TipoServicioComboBox.Location = New System.Drawing.Point(131, 258)
        Me.TipoServicioComboBox.Name = "TipoServicioComboBox"
        Me.TipoServicioComboBox.Size = New System.Drawing.Size(301, 31)
        Me.TipoServicioComboBox.TabIndex = 13
        '
        'FinalizadoCheckBox
        '
        Me.FinalizadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ServicioBindingSource, "Finalizado", True))
        Me.FinalizadoCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FinalizadoCheckBox.Location = New System.Drawing.Point(131, 302)
        Me.FinalizadoCheckBox.Name = "FinalizadoCheckBox"
        Me.FinalizadoCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.FinalizadoCheckBox.TabIndex = 15
        Me.FinalizadoCheckBox.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Registrar Nuevo Servicio:"
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(393, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(84, 28)
        Me.btnImprimir.TabIndex = 16
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnImprimir)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(714, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(489, 423)
        Me.Panel2.TabIndex = 4
        '
        'frmServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmServicio"
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ServiciosPrestadosDataSet As ServiciosPrestadosDataSet
    Friend WithEvents ServicioBindingSource As BindingSource
    Friend WithEvents ServicioTableAdapter As ServiciosPrestadosDataSetTableAdapters.servicioTableAdapter
    Friend WithEvents TableAdapterManager As ServiciosPrestadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ServicioDataGridView As DataGridView
    Friend WithEvents EmpresaTableAdapter As ServiciosPrestadosDataSetTableAdapters.empresaTableAdapter
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents EmpresaBindingSource1 As BindingSource
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As ServiciosPrestadosDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents IdEmpresaComboBox As ComboBox
    Friend WithEvents IdCategoriaComboBox As ComboBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents TipoServicioComboBox As ComboBox
    Friend WithEvents FinalizadoCheckBox As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnImprimir As Button
    Friend WithEvents Panel2 As Panel
End Class
