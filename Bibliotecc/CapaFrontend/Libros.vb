Public Class Libros
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TBregistroAutor.Text <> "" Or TBregistroTitulo.Text <> "" Or TBregistroCantidad.Text <> "" Then
                Dim CN As New CNlibro
                CN.InsertarNuevoLibro(TBregistroTitulo.Text, TBregistroAutor.Text, Val(TBregistroCantidad.Text))
                limpiar()
            End If
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Public Sub limpiar()
        TBregistroAutor.Clear()
        TBregistroCantidad.Clear()
        TBregistroTitulo.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim DT As DataTable
        Dim CN As New CNlibro
        DT = CN.ConsultarTodosLosLibros
        DGWtodosloslibros.DataSource = DT
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If TBconsultarTitulo.Text <> "" Then
                Dim DT As DataTable
                Dim CN As New CNlibro
                DT = CN.ConsultarLibro(TBconsultarTitulo.Text)
                If DT.Rows.Count > 0 Then
                    DGWconsultalibro.DataSource = DT
                Else
                    MsgBox("no se encontro el autor del libro")
                End If
            End If
        Catch ex As Exception
            MsgBox("ocurrio un error")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If TBactualizarConsultaCodigo.Text <> "" Then
                Dim cn As New CNlibro
                Dim dt As New DataTable
                dt = cn.ConsultarLibroPortCodigo(Val(TBactualizarConsultaCodigo.Text))
                Dim dr As DataRow
                dr = dt.Rows(0)
                If dt.Rows.Count > 0 Then
                    Actualizacion.Show()
                    Actualizacion.TBactualizarCodigo.Text = dr.Item(0)
                    Actualizacion.TBactualizarTitulo.Text = dr.Item(1)
                    Actualizacion.TBactualizarAutor.Text = dr.Item(2)
                    Actualizacion.TBactualizarCantidad.Text = dr.Item(3)
                    Actualizacion.TBactualizarCodigo.Enabled = False
                Else
                    MsgBox("no existe un libro con ese codigo IBSN")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub TBconsultarCodigoEliminar_LostFocus(sender As Object, e As EventArgs) Handles TBconsultarCodigoEliminar.LostFocus
        Try
            Dim Cn As New CNlibro
            Dim dt As DataTable
            dt = Cn.ConsultarLibroPortCodigo(Val(TBconsultarCodigoEliminar.Text))
            Dim dr As DataRow
            dr = dt.Rows(0)
            If dt.Rows.Count > 0 Then
                TBEliminartitulo.Text = dr.Item(1)
                TBeliminarAutor.Text = dr.Item(2)
                TBeliminarCantidad.Text = dr.Item(3)
            Else
                MsgBox("ese libro no existe")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            If TBconsultarCodigoEliminar.Text <> "" Then
                Dim cn As New CNlibro
                cn.EliminarLibro(Val(TBconsultarCodigoEliminar.Text))
                TBeliminarAutor.Clear()
                TBeliminarCantidad.Clear()
                TBEliminartitulo.Clear()
                TBconsultarCodigoEliminar.Clear()
            Else
                MsgBox("codigo de libro inexistente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
