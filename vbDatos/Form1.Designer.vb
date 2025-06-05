<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim ContactoLabel As System.Windows.Forms.Label
        Dim SaldoLabel As System.Windows.Forms.Label
        Me.ServiciosPrestadosDataSet = New vbDatos.ServiciosPrestadosDataSet()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.empresaTableAdapter()
        Me.TableAdapterManager = New vbDatos.ServiciosPrestadosDataSetTableAdapters.TableAdapterManager()
        Me.EmpresaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.ContactoTextBox = New System.Windows.Forms.TextBox()
        Me.SaldoTextBox = New System.Windows.Forms.TextBox()
        Me.nuevo = New System.Windows.Forms.Button()
        Me.guardar = New System.Windows.Forms.Button()
        Me.modificar = New System.Windows.Forms.Button()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.imprimir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        ContactoLabel = New System.Windows.Forms.Label()
        SaldoLabel = New System.Windows.Forms.Label()
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(101, 52)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(30, 23)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(54, 107)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(80, 23)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(51, 162)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(83, 23)
        TelefonoLabel.TabIndex = 4
        TelefonoLabel.Text = "Telefono:"
        '
        'ContactoLabel
        '
        ContactoLabel.AutoSize = True
        ContactoLabel.Location = New System.Drawing.Point(48, 217)
        ContactoLabel.Name = "ContactoLabel"
        ContactoLabel.Size = New System.Drawing.Size(86, 23)
        ContactoLabel.TabIndex = 6
        ContactoLabel.Text = "Contacto:"
        '
        'SaldoLabel
        '
        SaldoLabel.AutoSize = True
        SaldoLabel.Location = New System.Drawing.Point(76, 272)
        SaldoLabel.Name = "SaldoLabel"
        SaldoLabel.Size = New System.Drawing.Size(58, 23)
        SaldoLabel.TabIndex = 8
        SaldoLabel.Text = "Saldo:"
        '
        'ServiciosPrestadosDataSet
        '
        Me.ServiciosPrestadosDataSet.DataSetName = "ServiciosPrestadosDataSet"
        Me.ServiciosPrestadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "empresa"
        Me.EmpresaBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.empresaTableAdapter = Me.EmpresaTableAdapter
        Me.TableAdapterManager.servicioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = vbDatos.ServiciosPrestadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpresaDataGridView
        '
        Me.EmpresaDataGridView.AllowUserToAddRows = False
        Me.EmpresaDataGridView.AllowUserToDeleteRows = False
        Me.EmpresaDataGridView.AutoGenerateColumns = False
        Me.EmpresaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpresaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Saldo})
        Me.EmpresaDataGridView.DataSource = Me.EmpresaBindingSource
        Me.EmpresaDataGridView.Location = New System.Drawing.Point(19, 51)
        Me.EmpresaDataGridView.Name = "EmpresaDataGridView"
        Me.EmpresaDataGridView.ReadOnly = True
        Me.EmpresaDataGridView.RowHeadersVisible = False
        Me.EmpresaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmpresaDataGridView.Size = New System.Drawing.Size(678, 284)
        Me.EmpresaDataGridView.TabIndex = 1
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Contacto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contacto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'Saldo
        '
        Me.Saldo.DataPropertyName = "Saldo"
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(ContactoLabel)
        Me.GroupBox1.Controls.Add(Me.ContactoTextBox)
        Me.GroupBox1.Controls.Add(SaldoLabel)
        Me.GroupBox1.Controls.Add(Me.SaldoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 360)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(148, 44)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(248, 31)
        Me.IdTextBox.TabIndex = 1
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(148, 99)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(248, 31)
        Me.NombreTextBox.TabIndex = 3
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(148, 154)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(248, 31)
        Me.TelefonoTextBox.TabIndex = 5
        '
        'ContactoTextBox
        '
        Me.ContactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Contacto", True))
        Me.ContactoTextBox.Location = New System.Drawing.Point(148, 209)
        Me.ContactoTextBox.Name = "ContactoTextBox"
        Me.ContactoTextBox.Size = New System.Drawing.Size(248, 31)
        Me.ContactoTextBox.TabIndex = 7
        '
        'SaldoTextBox
        '
        Me.SaldoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "Saldo", True))
        Me.SaldoTextBox.Location = New System.Drawing.Point(148, 264)
        Me.SaldoTextBox.Name = "SaldoTextBox"
        Me.SaldoTextBox.Size = New System.Drawing.Size(248, 31)
        Me.SaldoTextBox.TabIndex = 9
        '
        'nuevo
        '
        Me.nuevo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nuevo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuevo.ForeColor = System.Drawing.Color.Silver
        Me.nuevo.Location = New System.Drawing.Point(19, 350)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(95, 35)
        Me.nuevo.TabIndex = 4
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'guardar
        '
        Me.guardar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.guardar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.ForeColor = System.Drawing.Color.Silver
        Me.guardar.Location = New System.Drawing.Point(135, 350)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(95, 35)
        Me.guardar.TabIndex = 5
        Me.guardar.Text = "Guardar"
        Me.guardar.UseVisualStyleBackColor = True
        '
        'modificar
        '
        Me.modificar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modificar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.ForeColor = System.Drawing.Color.Silver
        Me.modificar.Location = New System.Drawing.Point(251, 350)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(95, 35)
        Me.modificar.TabIndex = 6
        Me.modificar.Text = "Modificar"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'eliminar
        '
        Me.eliminar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar.ForeColor = System.Drawing.Color.Silver
        Me.eliminar.Location = New System.Drawing.Point(367, 350)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(95, 35)
        Me.eliminar.TabIndex = 7
        Me.eliminar.Text = "Eliminar"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelar.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelar.ForeColor = System.Drawing.Color.Silver
        Me.cancelar.Location = New System.Drawing.Point(483, 350)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(95, 35)
        Me.cancelar.TabIndex = 8
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.salir.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.ForeColor = System.Drawing.Color.Silver
        Me.salir.Location = New System.Drawing.Point(599, 350)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(95, 35)
        Me.salir.TabIndex = 9
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'imprimir
        '
        Me.imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.imprimir.Location = New System.Drawing.Point(387, 6)
        Me.imprimir.Name = "imprimir"
        Me.imprimir.Size = New System.Drawing.Size(89, 32)
        Me.imprimir.TabIndex = 10
        Me.imprimir.Text = "Imprimir"
        Me.imprimir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1205, 39)
        Me.Panel1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(16, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fórmulario para la gestión de empleados"
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(1159, 5)
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
        Me.Panel3.Controls.Add(Me.nuevo)
        Me.Panel3.Controls.Add(Me.guardar)
        Me.Panel3.Controls.Add(Me.salir)
        Me.Panel3.Controls.Add(Me.EmpresaDataGridView)
        Me.Panel3.Controls.Add(Me.modificar)
        Me.Panel3.Controls.Add(Me.cancelar)
        Me.Panel3.Controls.Add(Me.eliminar)
        Me.Panel3.Location = New System.Drawing.Point(-1, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(718, 416)
        Me.Panel3.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(15, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Empresas registradas"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.imprimir)
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.ForeColor = System.Drawing.Color.Silver
        Me.Panel2.Location = New System.Drawing.Point(715, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(489, 413)
        Me.Panel2.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Registrar Nueva Empresa:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1203, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Registro de Empresas"
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ServiciosPrestadosDataSet As ServiciosPrestadosDataSet
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents EmpresaTableAdapter As ServiciosPrestadosDataSetTableAdapters.empresaTableAdapter
    Friend WithEvents TableAdapterManager As ServiciosPrestadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpresaDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents ContactoTextBox As TextBox
    Friend WithEvents SaldoTextBox As TextBox
    Friend WithEvents nuevo As Button
    Friend WithEvents guardar As Button
    Friend WithEvents modificar As Button
    Friend WithEvents eliminar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents salir As Button
    Friend WithEvents imprimir As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
