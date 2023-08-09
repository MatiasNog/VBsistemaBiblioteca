Public Class ActualizarSocio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim CN As New CNsocio
            CN.ActualizarSocio(TBactualizarDNI.Text, TBactualizarNombre.Text, TBactualizarApellido.Text, TBactualizarTelefono.Text, TBactualizarCorreo.Text)
        Catch ex As Exception
            MsgBox("asegurese de que los datos sean correctos")
        End Try
    End Sub
End Class