<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIndexar_socios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBNombre = New System.Windows.Forms.TextBox()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.TBDni = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBAcceso = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBSexo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblID = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(186, 33)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(100, 20)
        Me.TBNombre.TabIndex = 1
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(186, 59)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(100, 20)
        Me.TBApellido.TabIndex = 3
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(136, 62)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(44, 13)
        Me.LblApellido.TabIndex = 2
        Me.LblApellido.Text = "Apellido"
        '
        'TBDni
        '
        Me.TBDni.Location = New System.Drawing.Point(186, 85)
        Me.TBDni.Name = "TBDni"
        Me.TBDni.Size = New System.Drawing.Size(100, 20)
        Me.TBDni.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Dni"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Acceso"
        '
        'CBAcceso
        '
        Me.CBAcceso.FormattingEnabled = True
        Me.CBAcceso.Location = New System.Drawing.Point(341, 62)
        Me.CBAcceso.Name = "CBAcceso"
        Me.CBAcceso.Size = New System.Drawing.Size(121, 21)
        Me.CBAcceso.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(292, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sexo"
        '
        'CBSexo
        '
        Me.CBSexo.FormattingEnabled = True
        Me.CBSexo.Location = New System.Drawing.Point(341, 36)
        Me.CBSexo.Name = "CBSexo"
        Me.CBSexo.Size = New System.Drawing.Size(73, 21)
        Me.CBSexo.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(292, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Monto"
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(338, 92)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(13, 13)
        Me.LblPrecio.TabIndex = 11
        Me.LblPrecio.Text = "$"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(212, 120)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 12
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'Grilla
        '
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column7, Me.Column5, Me.Column6})
        Me.Grilla.Location = New System.Drawing.Point(27, 162)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Grilla.Size = New System.Drawing.Size(544, 150)
        Me.Grilla.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(136, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ID"
        '
        'LblID
        '
        Me.LblID.AutoSize = True
        Me.LblID.Location = New System.Drawing.Point(183, 9)
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(0, 13)
        Me.LblID.TabIndex = 15
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(395, 120)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 16
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(305, 120)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEditar.TabIndex = 17
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Apellido"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "DNI"
        Me.Column4.Name = "Column4"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Sexo"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 80
        '
        'Column5
        '
        Me.Column5.HeaderText = "Acceso"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Precio"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 50
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(117, 120)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 18
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'FrmIndexar_socios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 335)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.LblID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CBSexo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBAcceso)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBDni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBApellido)
        Me.Controls.Add(Me.LblApellido)
        Me.Controls.Add(Me.TBNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmIndexar_socios"
        Me.Text = "Indexar socios"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBNombre As System.Windows.Forms.TextBox
    Friend WithEvents TBApellido As System.Windows.Forms.TextBox
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents TBDni As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBAcceso As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CBSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblPrecio As System.Windows.Forms.Label
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents Grilla As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblID As System.Windows.Forms.Label
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents BtnEditar As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BtnNuevo As System.Windows.Forms.Button
End Class
