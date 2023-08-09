<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarSocio
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBactualizarNombre = New System.Windows.Forms.TextBox()
        Me.TBactualizarApellido = New System.Windows.Forms.TextBox()
        Me.TBactualizarTelefono = New System.Windows.Forms.TextBox()
        Me.TBactualizarCorreo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBactualizarDNI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TBactualizarDNI)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TBactualizarCorreo)
        Me.GroupBox1.Controls.Add(Me.TBactualizarTelefono)
        Me.GroupBox1.Controls.Add(Me.TBactualizarApellido)
        Me.GroupBox1.Controls.Add(Me.TBactualizarNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Socio"
        '
        'TBactualizarNombre
        '
        Me.TBactualizarNombre.Location = New System.Drawing.Point(31, 49)
        Me.TBactualizarNombre.Name = "TBactualizarNombre"
        Me.TBactualizarNombre.Size = New System.Drawing.Size(100, 20)
        Me.TBactualizarNombre.TabIndex = 0
        '
        'TBactualizarApellido
        '
        Me.TBactualizarApellido.Location = New System.Drawing.Point(31, 88)
        Me.TBactualizarApellido.Name = "TBactualizarApellido"
        Me.TBactualizarApellido.Size = New System.Drawing.Size(100, 20)
        Me.TBactualizarApellido.TabIndex = 1
        '
        'TBactualizarTelefono
        '
        Me.TBactualizarTelefono.Location = New System.Drawing.Point(31, 127)
        Me.TBactualizarTelefono.Name = "TBactualizarTelefono"
        Me.TBactualizarTelefono.Size = New System.Drawing.Size(100, 20)
        Me.TBactualizarTelefono.TabIndex = 2
        '
        'TBactualizarCorreo
        '
        Me.TBactualizarCorreo.Location = New System.Drawing.Point(31, 171)
        Me.TBactualizarCorreo.Name = "TBactualizarCorreo"
        Me.TBactualizarCorreo.Size = New System.Drawing.Size(136, 20)
        Me.TBactualizarCorreo.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Telefono"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Correo"
        '
        'TBactualizarDNI
        '
        Me.TBactualizarDNI.Enabled = False
        Me.TBactualizarDNI.Location = New System.Drawing.Point(187, 49)
        Me.TBactualizarDNI.Name = "TBactualizarDNI"
        Me.TBactualizarDNI.Size = New System.Drawing.Size(100, 20)
        Me.TBactualizarDNI.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DNI"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ActualizarSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 253)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ActualizarSocio"
        Me.Text = "ActualizarSocio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBactualizarCorreo As TextBox
    Friend WithEvents TBactualizarTelefono As TextBox
    Friend WithEvents TBactualizarApellido As TextBox
    Friend WithEvents TBactualizarNombre As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TBactualizarDNI As TextBox
End Class
