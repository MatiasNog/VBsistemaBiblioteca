Public Class Actualizacion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TBactualizarAutor.Text <> "" Or TBactualizarCantidad.Text <> "" Or TBactualizarTitulo.Text <> "" Then
                Dim CN As New CNlibro
                CN.ActualizarLibros(TBactualizarTitulo.Text, TBactualizarAutor.Text, Val(TBactualizarCantidad.Text), Val(TBactualizarCodigo.Text))
                Me.Close()
            Else
                MsgBox("faltan rellenar algunos datos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class