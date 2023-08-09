<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizacion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBactualizarTitulo = New System.Windows.Forms.TextBox()
        Me.TBactualizarAutor = New System.Windows.Forms.TextBox()
        Me.TBactualizarCantidad = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TBactualizarCodigo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TBactualizarCodigo)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TBactualizarCantidad)
        Me.GroupBox1.Controls.Add(Me.TBactualizarAutor)
        Me.GroupBox1.Controls.Add(Me.TBactualizarTitulo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(302, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actualizacion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Titulo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Autor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cantidad"
        '
        'TBactualizarTitulo
        '
        Me.TBactualizarTitulo.Location = New System.Drawing.Point(20, 56)
        Me.TBactualizarTitulo.Name = "TBactualizarTitulo"
        Me.TBactualizarTitulo.Size = New System.Drawing.Size(100, 20)
        Me.TBactualizarTitulo.TabIndex = 3
        '
        'TBactualizarAutor
        '
        Me.TBactualizarAutor.Location = New System.Drawing.Point(20, 100)
        Me.TBactualizarAutor.Name = "TBactualizarAutor"
        Me.TBactualizarAutor.Size = New System.Drawing.Size(100, 20)
        Me.TBactualizarAutor.TabIndex = 4
        '
        'TBactualizarCantidad
        '
        Me.TBactualizarCantidad.Location = New System.Drawing.Point(20, 144)
        Me.TBactualizarCantidad.Name = "TBactualizarCantidad"
        Me.TBactualizarCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TBactualizarCantidad.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 21)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TBactualizarCodigo
        '
        Me.TBactualizarCodigo.Location = New System.Drawing.Point(142, 56)
        Me.TBactualizarCodigo.Name = "TBactualizarCodigo"
        Me.TBactualizarCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TBactualizarCodigo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Codigo"
        '
        'Actualizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 224)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Actualizacion"
        Me.Text = "Actualizacion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBactualizarCodigo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TBactualizarCantidad As TextBox
    Friend WithEvents TBactualizarAutor As TextBox
    Friend WithEvents TBactualizarTitulo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
