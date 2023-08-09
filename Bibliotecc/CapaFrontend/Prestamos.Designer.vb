<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prestamos
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBeliminarPrestamo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBidPrestamoActualizar = New System.Windows.Forms.TextBox()
        Me.BTNactualizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBfechaDeovlucion = New System.Windows.Forms.DateTimePicker()
        Me.TBfechaPrestamo = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TBprestamoCodigoLibro = New System.Windows.Forms.TextBox()
        Me.TBprestamoDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DTGWdatosporID = New System.Windows.Forms.DataGridView()
        Me.BuscarporID = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBconsultaIDprestamo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DTGWdatos = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DTGWdatosporID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DTGWdatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 128)
        Me.Panel3.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.TBeliminarPrestamo)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(627, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(166, 116)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ID del prestamo"
        '
        'TBeliminarPrestamo
        '
        Me.TBeliminarPrestamo.Location = New System.Drawing.Point(42, 40)
        Me.TBeliminarPrestamo.Name = "TBeliminarPrestamo"
        Me.TBeliminarPrestamo.Size = New System.Drawing.Size(85, 20)
        Me.TBeliminarPrestamo.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Eliminar Prestamo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TBidPrestamoActualizar)
        Me.GroupBox3.Controls.Add(Me.BTNactualizar)
        Me.GroupBox3.Location = New System.Drawing.Point(448, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(173, 116)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Actualizar Prestamo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ID del prestamo"
        '
        'TBidPrestamoActualizar
        '
        Me.TBidPrestamoActualizar.Location = New System.Drawing.Point(43, 40)
        Me.TBidPrestamoActualizar.Name = "TBidPrestamoActualizar"
        Me.TBidPrestamoActualizar.Size = New System.Drawing.Size(85, 20)
        Me.TBidPrestamoActualizar.TabIndex = 13
        '
        'BTNactualizar
        '
        Me.BTNactualizar.Location = New System.Drawing.Point(43, 69)
        Me.BTNactualizar.Name = "BTNactualizar"
        Me.BTNactualizar.Size = New System.Drawing.Size(85, 23)
        Me.BTNactualizar.TabIndex = 12
        Me.BTNactualizar.Text = "Actualizar"
        Me.BTNactualizar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TBfechaDeovlucion)
        Me.GroupBox1.Controls.Add(Me.TBfechaPrestamo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.TBprestamoCodigoLibro)
        Me.GroupBox1.Controls.Add(Me.TBprestamoDNI)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Generar Nuevo Prestamo"
        '
        'TBfechaDeovlucion
        '
        Me.TBfechaDeovlucion.Location = New System.Drawing.Point(122, 81)
        Me.TBfechaDeovlucion.Name = "TBfechaDeovlucion"
        Me.TBfechaDeovlucion.Size = New System.Drawing.Size(200, 20)
        Me.TBfechaDeovlucion.TabIndex = 11
        '
        'TBfechaPrestamo
        '
        Me.TBfechaPrestamo.Location = New System.Drawing.Point(122, 33)
        Me.TBfechaPrestamo.Name = "TBfechaPrestamo"
        Me.TBfechaPrestamo.Size = New System.Drawing.Size(200, 20)
        Me.TBfechaPrestamo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(119, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha de devolucion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha de prestamo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Codigo IBSN del libro"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(328, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 70)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Generar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TBprestamoCodigoLibro
        '
        Me.TBprestamoCodigoLibro.Location = New System.Drawing.Point(9, 33)
        Me.TBprestamoCodigoLibro.Name = "TBprestamoCodigoLibro"
        Me.TBprestamoCodigoLibro.Size = New System.Drawing.Size(100, 20)
        Me.TBprestamoCodigoLibro.TabIndex = 3
        '
        'TBprestamoDNI
        '
        Me.TBprestamoDNI.Location = New System.Drawing.Point(9, 81)
        Me.TBprestamoDNI.Name = "TBprestamoDNI"
        Me.TBprestamoDNI.Size = New System.Drawing.Size(100, 20)
        Me.TBprestamoDNI.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DNI del solicitante"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 128)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 264)
        Me.Panel1.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DTGWdatosporID)
        Me.GroupBox2.Controls.Add(Me.BuscarporID)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TBconsultaIDprestamo)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(782, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consultar Prestamo"
        '
        'DTGWdatosporID
        '
        Me.DTGWdatosporID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGWdatosporID.Location = New System.Drawing.Point(121, 10)
        Me.DTGWdatosporID.Name = "DTGWdatosporID"
        Me.DTGWdatosporID.Size = New System.Drawing.Size(633, 84)
        Me.DTGWdatosporID.TabIndex = 14
        '
        'BuscarporID
        '
        Me.BuscarporID.Location = New System.Drawing.Point(12, 71)
        Me.BuscarporID.Name = "BuscarporID"
        Me.BuscarporID.Size = New System.Drawing.Size(100, 23)
        Me.BuscarporID.TabIndex = 13
        Me.BuscarporID.Text = "Buscar"
        Me.BuscarporID.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ID del prestamo"
        '
        'TBconsultaIDprestamo
        '
        Me.TBconsultaIDprestamo.Location = New System.Drawing.Point(12, 45)
        Me.TBconsultaIDprestamo.Name = "TBconsultaIDprestamo"
        Me.TBconsultaIDprestamo.Size = New System.Drawing.Size(100, 20)
        Me.TBconsultaIDprestamo.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.DTGWdatos)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 106)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(796, 154)
        Me.Panel2.TabIndex = 0
        '
        'DTGWdatos
        '
        Me.DTGWdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTGWdatos.Location = New System.Drawing.Point(130, 14)
        Me.DTGWdatos.Name = "DTGWdatos"
        Me.DTGWdatos.Size = New System.Drawing.Size(633, 128)
        Me.DTGWdatos.TabIndex = 13
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(24, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Buscar todos"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Prestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 392)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Prestamos"
        Me.Text = "Prestamos"
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DTGWdatosporID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DTGWdatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TBprestamoCodigoLibro As TextBox
    Friend WithEvents TBprestamoDNI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DTGWdatos As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TBconsultaIDprestamo As TextBox
    Friend WithEvents TBfechaDeovlucion As DateTimePicker
    Friend WithEvents TBfechaPrestamo As DateTimePicker
    Friend WithEvents DTGWdatosporID As DataGridView
    Friend WithEvents BuscarporID As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBeliminarPrestamo As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBidPrestamoActualizar As TextBox
    Friend WithEvents BTNactualizar As Button
End Class
