<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Bienvenido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bienvenido))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.txtBienvenido = New System.Windows.Forms.Label()
        Me.txtIniciando = New System.Windows.Forms.Label()
        Me.txtSinager = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(36, 191)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(523, 23)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 7
        '
        'txtBienvenido
        '
        Me.txtBienvenido.AutoSize = True
        Me.txtBienvenido.BackColor = System.Drawing.Color.Transparent
        Me.txtBienvenido.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBienvenido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtBienvenido.Location = New System.Drawing.Point(31, 67)
        Me.txtBienvenido.Name = "txtBienvenido"
        Me.txtBienvenido.Size = New System.Drawing.Size(528, 26)
        Me.txtBienvenido.TabIndex = 6
        Me.txtBienvenido.Text = "SISTEMA NACIONAL DE GESTIÓN DE RIESGO"
        '
        'txtIniciando
        '
        Me.txtIniciando.AutoSize = True
        Me.txtIniciando.BackColor = System.Drawing.Color.Transparent
        Me.txtIniciando.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIniciando.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtIniciando.Location = New System.Drawing.Point(246, 168)
        Me.txtIniciando.Name = "txtIniciando"
        Me.txtIniciando.Size = New System.Drawing.Size(82, 20)
        Me.txtIniciando.TabIndex = 5
        Me.txtIniciando.Text = "Iniciando"
        '
        'txtSinager
        '
        Me.txtSinager.AutoSize = True
        Me.txtSinager.BackColor = System.Drawing.Color.Transparent
        Me.txtSinager.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSinager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSinager.Location = New System.Drawing.Point(232, 108)
        Me.txtSinager.Name = "txtSinager"
        Me.txtSinager.Size = New System.Drawing.Size(105, 20)
        Me.txtSinager.TabIndex = 8
        Me.txtSinager.Text = "(SINAGER)"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Bienvenido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(593, 259)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSinager)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtBienvenido)
        Me.Controls.Add(Me.txtIniciando)
        Me.Name = "Bienvenido"
        Me.Text = "Bienvenido"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents txtBienvenido As Label
    Friend WithEvents txtIniciando As Label
    Friend WithEvents txtSinager As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
End Class
