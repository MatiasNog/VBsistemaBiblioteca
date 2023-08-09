<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libros
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DGWconsultalibro = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBconsultarTitulo = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGWtodosloslibros = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBeliminarCantidad = New System.Windows.Forms.TextBox()
        Me.TBeliminarAutor = New System.Windows.Forms.TextBox()
        Me.TBEliminartitulo = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBconsultarCodigoEliminar = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TBactualizarConsultaCodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TBregistroCantidad = New System.Windows.Forms.TextBox()
        Me.TBregistroAutor = New System.Windows.Forms.TextBox()
        Me.TBregistroTitulo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGWconsultalibro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGWtodosloslibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 450)
        Me.Panel2.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.DGWconsultalibro)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TBconsultarTitulo)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(775, 112)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consultar libro"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(54, 60)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Consultar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DGWconsultalibro
        '
        Me.DGWconsultalibro.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DGWconsultalibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGWconsultalibro.Location = New System.Drawing.Point(160, 18)
        Me.DGWconsultalibro.Name = "DGWconsultalibro"
        Me.DGWconsultalibro.Size = New System.Drawing.Size(609, 75)
        Me.DGWconsultalibro.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Titulo"
        '
        'TBconsultarTitulo
        '
        Me.TBconsultarTitulo.Location = New System.Drawing.Point(54, 34)
        Me.TBconsultarTitulo.Name = "TBconsultarTitulo"
        Me.TBconsultarTitulo.Size = New System.Drawing.Size(100, 20)
        Me.TBconsultarTitulo.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 226)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGWtodosloslibros)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(775, 211)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ver libros"
        '
        'DGWtodosloslibros
        '
        Me.DGWtodosloslibros.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGWtodosloslibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGWtodosloslibros.Location = New System.Drawing.Point(160, 19)
        Me.DGWtodosloslibros.Name = "DGWtodosloslibros"
        Me.DGWtodosloslibros.Size = New System.Drawing.Size(609, 186)
        Me.DGWtodosloslibros.TabIndex = 12
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Ver todos los libros"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.GroupBox5)
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(796, 100)
        Me.Panel3.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.TBeliminarCantidad)
        Me.GroupBox5.Controls.Add(Me.TBeliminarAutor)
        Me.GroupBox5.Controls.Add(Me.TBEliminartitulo)
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.TBconsultarCodigoEliminar)
        Me.GroupBox5.Location = New System.Drawing.Point(504, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(284, 89)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Baja de un libro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(122, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Cantidad:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(139, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Autor:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(139, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Titulo:"
        '
        'TBeliminarCantidad
        '
        Me.TBeliminarCantidad.Enabled = False
        Me.TBeliminarCantidad.Location = New System.Drawing.Point(178, 60)
        Me.TBeliminarCantidad.Name = "TBeliminarCantidad"
        Me.TBeliminarCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TBeliminarCantidad.TabIndex = 12
        '
        'TBeliminarAutor
        '
        Me.TBeliminarAutor.Enabled = False
        Me.TBeliminarAutor.Location = New System.Drawing.Point(178, 37)
        Me.TBeliminarAutor.Name = "TBeliminarAutor"
        Me.TBeliminarAutor.Size = New System.Drawing.Size(100, 20)
        Me.TBeliminarAutor.TabIndex = 11
        '
        'TBEliminartitulo
        '
        Me.TBEliminartitulo.Enabled = False
        Me.TBEliminartitulo.Location = New System.Drawing.Point(178, 14)
        Me.TBEliminartitulo.Name = "TBEliminartitulo"
        Me.TBEliminartitulo.Size = New System.Drawing.Size(100, 20)
        Me.TBEliminartitulo.TabIndex = 10
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 60)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 23)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Eliminar libro"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Codigo Del Libro"
        '
        'TBconsultarCodigoEliminar
        '
        Me.TBconsultarCodigoEliminar.Location = New System.Drawing.Point(6, 34)
        Me.TBconsultarCodigoEliminar.Name = "TBconsultarCodigoEliminar"
        Me.TBconsultarCodigoEliminar.Size = New System.Drawing.Size(100, 20)
        Me.TBconsultarCodigoEliminar.TabIndex = 4
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Controls.Add(Me.TBactualizarConsultaCodigo)
        Me.GroupBox4.Location = New System.Drawing.Point(349, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(148, 90)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Actualizar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Codigo Del Libro"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(16, 61)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 23)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Iniciar Actualizacion"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TBactualizarConsultaCodigo
        '
        Me.TBactualizarConsultaCodigo.Location = New System.Drawing.Point(16, 35)
        Me.TBactualizarConsultaCodigo.Name = "TBactualizarConsultaCodigo"
        Me.TBactualizarConsultaCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TBactualizarConsultaCodigo.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TBregistroCantidad)
        Me.GroupBox1.Controls.Add(Me.TBregistroAutor)
        Me.GroupBox1.Controls.Add(Me.TBregistroTitulo)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 90)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registrar nuevo libro"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Autor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Titulo"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(112, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Nuevo"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TBregistroCantidad
        '
        Me.TBregistroCantidad.Location = New System.Drawing.Point(218, 35)
        Me.TBregistroCantidad.Name = "TBregistroCantidad"
        Me.TBregistroCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TBregistroCantidad.TabIndex = 4
        '
        'TBregistroAutor
        '
        Me.TBregistroAutor.Location = New System.Drawing.Point(112, 35)
        Me.TBregistroAutor.Name = "TBregistroAutor"
        Me.TBregistroAutor.Size = New System.Drawing.Size(100, 20)
        Me.TBregistroAutor.TabIndex = 3
        '
        'TBregistroTitulo
        '
        Me.TBregistroTitulo.Location = New System.Drawing.Point(6, 35)
        Me.TBregistroTitulo.Name = "TBregistroTitulo"
        Me.TBregistroTitulo.Size = New System.Drawing.Size(100, 20)
        Me.TBregistroTitulo.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Libros"
        Me.Text = "Libros"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGWconsultalibro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGWtodosloslibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TBregistroCantidad As TextBox
    Friend WithEvents TBregistroAutor As TextBox
    Friend WithEvents TBregistroTitulo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DGWconsultalibro As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents TBconsultarTitulo As TextBox
    Friend WithEvents DGWtodosloslibros As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents TBactualizarConsultaCodigo As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBeliminarCantidad As TextBox
    Friend WithEvents TBeliminarAutor As TextBox
    Friend WithEvents TBEliminartitulo As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TBconsultarCodigoEliminar As TextBox
End Class
