<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formulario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulario))
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControlPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtlimpiar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chMue = New System.Windows.Forms.CheckBox()
        Me.rbNega = New System.Windows.Forms.RadioButton()
        Me.chRe = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chAC = New System.Windows.Forms.CheckBox()
        Me.rbPosi = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmDepartamento = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnlimpiar2 = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtPosi = New System.Windows.Forms.TextBox()
        Me.txtNega = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRe = New System.Windows.Forms.TextBox()
        Me.txtMue = New System.Windows.Forms.TextBox()
        Me.txtAct = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmDepa = New System.Windows.Forms.ComboBox()
        Me.historial = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rdSalir = New System.Windows.Forms.RadioButton()
        Me.rdReporte = New System.Windows.Forms.RadioButton()
        Me.rdDatos = New System.Windows.Forms.RadioButton()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPrincipal.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'TabControlPrincipal
        '
        Me.TabControlPrincipal.Controls.Add(Me.TabPage1)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage2)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage3)
        Me.TabControlPrincipal.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControlPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TabControlPrincipal.Name = "TabControlPrincipal"
        Me.TabControlPrincipal.SelectedIndex = 0
        Me.TabControlPrincipal.Size = New System.Drawing.Size(633, 350)
        Me.TabControlPrincipal.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackgroundImage = CType(resources.GetObject("TabPage1.BackgroundImage"), System.Drawing.Image)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.txtlimpiar)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(625, 322)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Datos personales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(495, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 30)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtlimpiar
        '
        Me.txtlimpiar.BackColor = System.Drawing.Color.Aqua
        Me.txtlimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlimpiar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtlimpiar.Location = New System.Drawing.Point(495, 226)
        Me.txtlimpiar.Name = "txtlimpiar"
        Me.txtlimpiar.Size = New System.Drawing.Size(89, 30)
        Me.txtlimpiar.TabIndex = 52
        Me.txtlimpiar.Text = "Limpiar"
        Me.txtlimpiar.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDescripcion)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(451, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(148, 191)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(16, 45)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(117, 112)
        Me.txtDescripcion.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Descripción"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.chMue)
        Me.GroupBox2.Controls.Add(Me.rbNega)
        Me.GroupBox2.Controls.Add(Me.chRe)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.chAC)
        Me.GroupBox2.Controls.Add(Me.rbPosi)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 214)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(419, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'chMue
        '
        Me.chMue.AutoSize = True
        Me.chMue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chMue.Location = New System.Drawing.Point(301, 78)
        Me.chMue.Name = "chMue"
        Me.chMue.Size = New System.Drawing.Size(65, 19)
        Me.chMue.TabIndex = 52
        Me.chMue.Text = "Muerto"
        Me.chMue.UseVisualStyleBackColor = True
        '
        'rbNega
        '
        Me.rbNega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNega.Location = New System.Drawing.Point(137, 25)
        Me.rbNega.Name = "rbNega"
        Me.rbNega.Size = New System.Drawing.Size(90, 19)
        Me.rbNega.TabIndex = 47
        Me.rbNega.TabStop = True
        Me.rbNega.Text = "Negativo"
        Me.rbNega.UseVisualStyleBackColor = True
        '
        'chRe
        '
        Me.chRe.AutoSize = True
        Me.chRe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRe.Location = New System.Drawing.Point(301, 44)
        Me.chRe.Name = "chRe"
        Me.chRe.Size = New System.Drawing.Size(94, 19)
        Me.chRe.TabIndex = 51
        Me.chRe.Text = "Recuperado"
        Me.chRe.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 13)
        Me.Label7.TabIndex = 46
        Me.Label7.Text = "Resultado de Prueba"
        '
        'chAC
        '
        Me.chAC.AutoSize = True
        Me.chAC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chAC.Location = New System.Drawing.Point(301, 12)
        Me.chAC.Name = "chAC"
        Me.chAC.Size = New System.Drawing.Size(57, 19)
        Me.chAC.TabIndex = 50
        Me.chAC.Text = "Activo"
        Me.chAC.UseVisualStyleBackColor = True
        '
        'rbPosi
        '
        Me.rbPosi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPosi.Location = New System.Drawing.Point(137, 63)
        Me.rbPosi.Name = "rbPosi"
        Me.rbPosi.Size = New System.Drawing.Size(90, 17)
        Me.rbPosi.TabIndex = 44
        Me.rbPosi.TabStop = True
        Me.rbPosi.Text = "Positivo"
        Me.rbPosi.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(243, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Estado"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 15)
        Me.Label6.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtEdad)
        Me.GroupBox1.Controls.Add(Me.txtMunicipio)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmDepartamento)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(419, 191)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos personales"
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(87, 73)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(45, 20)
        Me.txtEdad.TabIndex = 58
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(87, 156)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(230, 20)
        Me.txtMunicipio.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Municipio"
        '
        'cmDepartamento
        '
        Me.cmDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmDepartamento.FormattingEnabled = True
        Me.cmDepartamento.Items.AddRange(New Object() {"Comayagua", "Francisco Morazán", "Colón", "Intibucá", "Cortés", "El Paraíso", "Atlántida", "Choluteca", "Copán", "Gracias a Dios", "Islas de la Bahía ", "La Paz", "Lempira", "Ocotepeque", "Olancho ", "Santa Bárbara", "Yoro ", "Valle"})
        Me.cmDepartamento.Location = New System.Drawing.Point(20, 111)
        Me.cmDepartamento.Name = "cmDepartamento"
        Me.cmDepartamento.Size = New System.Drawing.Size(172, 21)
        Me.cmDepartamento.TabIndex = 55
        Me.cmDepartamento.Text = "Seleccione un Departamento"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(87, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(230, 20)
        Me.txtNombre.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Edad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Nombre "
        '
        'TabPage2
        '
        Me.TabPage2.BackgroundImage = CType(resources.GetObject("TabPage2.BackgroundImage"), System.Drawing.Image)
        Me.TabPage2.Controls.Add(Me.btnlimpiar2)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(625, 322)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnlimpiar2
        '
        Me.btnlimpiar2.BackColor = System.Drawing.Color.Aqua
        Me.btnlimpiar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnlimpiar2.Location = New System.Drawing.Point(500, 286)
        Me.btnlimpiar2.Name = "btnlimpiar2"
        Me.btnlimpiar2.Size = New System.Drawing.Size(89, 30)
        Me.btnlimpiar2.TabIndex = 53
        Me.btnlimpiar2.Text = "Limpiar"
        Me.btnlimpiar2.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtPosi)
        Me.GroupBox5.Controls.Add(Me.txtNega)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.txtRe)
        Me.GroupBox5.Controls.Add(Me.txtMue)
        Me.GroupBox5.Controls.Add(Me.txtAct)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(456, 6)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(161, 257)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Reportes"
        '
        'txtPosi
        '
        Me.txtPosi.Location = New System.Drawing.Point(70, 174)
        Me.txtPosi.Name = "txtPosi"
        Me.txtPosi.Size = New System.Drawing.Size(61, 21)
        Me.txtPosi.TabIndex = 71
        Me.txtPosi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNega
        '
        Me.txtNega.Location = New System.Drawing.Point(72, 219)
        Me.txtNega.Name = "txtNega"
        Me.txtNega.Size = New System.Drawing.Size(61, 21)
        Me.txtNega.TabIndex = 70
        Me.txtNega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 222)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 15)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Negativo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Positivo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 15)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Muertos"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 15)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Recuperados"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 15)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Activos"
        '
        'txtRe
        '
        Me.txtRe.Location = New System.Drawing.Point(97, 76)
        Me.txtRe.Name = "txtRe"
        Me.txtRe.Size = New System.Drawing.Size(61, 21)
        Me.txtRe.TabIndex = 64
        Me.txtRe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMue
        '
        Me.txtMue.Location = New System.Drawing.Point(71, 125)
        Me.txtMue.Name = "txtMue"
        Me.txtMue.Size = New System.Drawing.Size(61, 21)
        Me.txtMue.TabIndex = 63
        Me.txtMue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAct
        '
        Me.txtAct.Location = New System.Drawing.Point(63, 26)
        Me.txtAct.Name = "txtAct"
        Me.txtAct.Size = New System.Drawing.Size(61, 21)
        Me.txtAct.TabIndex = 62
        Me.txtAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmDepa)
        Me.GroupBox4.Controls.Add(Me.historial)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(442, 305)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Historial"
        '
        'cmDepa
        '
        Me.cmDepa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmDepa.FormattingEnabled = True
        Me.cmDepa.Items.AddRange(New Object() {"Comayagua", "Francisco Morazán", "Colón", "Intibucá", "Cortés", "El Paraíso", "Atlántida", "Choluteca", "Copán", "Gracias a Dios", "Islas de la Bahía ", "La Paz", "Lempira", "Ocotepeque", "Olancho ", "Santa Bárbara", "Yoro ", "Valle"})
        Me.cmDepa.Location = New System.Drawing.Point(128, 20)
        Me.cmDepa.Name = "cmDepa"
        Me.cmDepa.Size = New System.Drawing.Size(172, 21)
        Me.cmDepa.TabIndex = 56
        Me.cmDepa.Text = "Seleccione un Departamento"
        '
        'historial
        '
        Me.historial.FormattingEnabled = True
        Me.historial.ItemHeight = 15
        Me.historial.Location = New System.Drawing.Point(6, 49)
        Me.historial.Name = "historial"
        Me.historial.Size = New System.Drawing.Size(417, 244)
        Me.historial.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackgroundImage = CType(resources.GetObject("TabPage3.BackgroundImage"), System.Drawing.Image)
        Me.TabPage3.Controls.Add(Me.btnSalir)
        Me.TabPage3.Controls.Add(Me.PictureBox2)
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(625, 322)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Red
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(501, 257)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(95, 38)
        Me.btnSalir.TabIndex = 45
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(400, 49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(194, 140)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(373, 276)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.rdSalir)
        Me.Panel1.Controls.Add(Me.rdReporte)
        Me.Panel1.Controls.Add(Me.rdDatos)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 28)
        Me.Panel1.TabIndex = 2
        '
        'rdSalir
        '
        Me.rdSalir.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdSalir.AutoSize = True
        Me.rdSalir.FlatAppearance.BorderSize = 0
        Me.rdSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.rdSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdSalir.Location = New System.Drawing.Point(294, 2)
        Me.rdSalir.Name = "rdSalir"
        Me.rdSalir.Size = New System.Drawing.Size(81, 23)
        Me.rdSalir.TabIndex = 2
        Me.rdSalir.Text = "FINALIZAR"
        Me.rdSalir.UseVisualStyleBackColor = True
        '
        'rdReporte
        '
        Me.rdReporte.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdReporte.AutoSize = True
        Me.rdReporte.FlatAppearance.BorderSize = 0
        Me.rdReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.rdReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rdReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdReporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdReporte.Location = New System.Drawing.Point(212, 2)
        Me.rdReporte.Name = "rdReporte"
        Me.rdReporte.Size = New System.Drawing.Size(76, 23)
        Me.rdReporte.TabIndex = 1
        Me.rdReporte.Text = "REPORTE"
        Me.rdReporte.UseVisualStyleBackColor = True
        '
        'rdDatos
        '
        Me.rdDatos.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdDatos.AutoSize = True
        Me.rdDatos.Checked = True
        Me.rdDatos.FlatAppearance.BorderSize = 0
        Me.rdDatos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.rdDatos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.rdDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdDatos.Location = New System.Drawing.Point(33, 3)
        Me.rdDatos.Name = "rdDatos"
        Me.rdDatos.Size = New System.Drawing.Size(173, 23)
        Me.rdDatos.TabIndex = 0
        Me.rdDatos.TabStop = True
        Me.rdDatos.Text = "INFORMACIÓN PERSONAL"
        Me.rdDatos.UseVisualStyleBackColor = True
        '
        'Formulario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 348)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControlPrincipal)
        Me.Name = "Formulario"
        Me.Text = "Formulario"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPrincipal.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents TabControlPrincipal As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents txtlimpiar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chMue As CheckBox
    Friend WithEvents rbNega As RadioButton
    Friend WithEvents chRe As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chAC As CheckBox
    Friend WithEvents rbPosi As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmDepartamento As ComboBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRe As TextBox
    Friend WithEvents txtMue As TextBox
    Friend WithEvents txtAct As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents historial As ListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rdSalir As RadioButton
    Friend WithEvents rdReporte As RadioButton
    Friend WithEvents rdDatos As RadioButton
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnlimpiar2 As Button
    Friend WithEvents txtPosi As TextBox
    Friend WithEvents txtNega As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmDepa As ComboBox
End Class
