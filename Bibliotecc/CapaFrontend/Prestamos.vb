Public Class Prestamos
    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TBprestamoCodigoLibro.LostFocus
        Try
            Dim cnl As New CNlibro
            Dim dt As DataTable
            dt = cnl.ConsultarLibroPortCodigo(TBprestamoCodigoLibro.Text)
            Dim dr As DataRow
            dr = dt.Rows.Item(0)
            If dt.Rows.Count = 0 Then
                MsgBox("el codigo del libro no existe")
            ElseIf dr.Item(3) = 0 Then
                MsgBox("todas las unidades del libro se encuentran en prestamo")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TBprestamoDNI_LostFocus(sender As Object, e As EventArgs) Handles TBprestamoDNI.LostFocus
        Try
            Dim cns As New CNsocio
            Dim dt As DataTable
            dt = cns.ConsultaSocio(Val(TBprestamoDNI.Text))
            If dt.Rows.Count = 0 Then
                PreguntaSocio.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Limpiar()
        TBprestamoDNI.Clear()
        TBprestamoCodigoLibro.Clear()
        TBfechaPrestamo.ResetText()
        TBfechaDeovlucion.ResetText()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim Cnp As New CNprestamo
            Cnp.InsertarPrestamo(Val(TBprestamoCodigoLibro.Text), Val(TBprestamoDNI.Text), TBfechaPrestamo.Value.ToString, TBfechaDeovlucion.Value.ToString, Val(TBprestamoCodigoLibro.Text))
            Limpiar()
        Catch ex As Exception
            MsgBox("no se pudo ingresar los datos")
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim cnp As New CNprestamo
            Dim dt As DataTable
            dt = cnp.VerTodosLosPrestamos
            DTGWdatos.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BuscarporID_Click(sender As Object, e As EventArgs) Handles BuscarporID.Click
        Try
            Dim cnp As New CNprestamo
            Dim dt As DataTable
            dt = cnp.VerPrestamoPorID_prestamo(Val(TBconsultaIDprestamo.Text))
            If dt.Rows.Count > 0 Then
                DTGWdatosporID.DataSource = dt
            Else
                MsgBox("no existen prestamos con ese ID")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BTNactualizar_Click(sender As Object, e As EventArgs) Handles BTNactualizar.Click
        Try
            Dim cn As New CNprestamo
            Dim dt As DataTable
            dt = cn.VerPrestamoPorID_prestamo(Val(TBidPrestamoActualizar.Text))
            Dim dr As DataRow
            dr = dt.Rows.Item(0)

            If dt.Rows.Count > 0 Then
                ActualizarPrestamo.TbactualizarIDprestamo.Text = dr.Item(0)
                ActualizarPrestamo.TbactualizarIDprestamo.Enabled = False
                ActualizarPrestamo.TBactualizarCodigoIBSN.Text = dr.Item(1)
                ActualizarPrestamo.TBActualizarDNI.Text = dr.Item(2)
                ActualizarPrestamo.TBactualizarFechaPrestamo.Text = dr.Item(3)
                ActualizarPrestamo.TBactualizarFechaLimite.Text = dr.Item(4)
                ActualizarPrestamo.TBactualizarDevuelto.Text = dr.Item(5)
                ActualizarPrestamo.TBactualizarDevuelto.Enabled = False
                ActualizarPrestamo.ShowDialog()
            Else
                MsgBox("no se encontro un prestamo con ID = " & TBidPrestamoActualizar.Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim cnp As New CNprestamo
            Dim dt As DataTable
            dt = cnp.VerPrestamoPorID_prestamo(Val(TBeliminarPrestamo.Text))
            If dt.Rows.Count > 0 Then
                EliminacionPrestamo.DTGWeliminacion.DataSource = dt
                EliminacionPrestamo.ShowDialog()
            Else
                MsgBox("el ID del prestamo ingresado no existe")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
