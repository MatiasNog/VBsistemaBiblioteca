Public Class AltaSocioPorPrestamo
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TBdni.Text <> "" Or Tbtelefono.Text <> "" Or TBcorreo.Text <> "" Or TBnombre.Text <> "" Or TBapellido.Text <> "" Then
                Dim CN As New CNsocio
                CN.InsertarNuevoSocio(Val(TBdni.Text), TBnombre.Text, TBapellido.Text, Tbtelefono.Text, TBcorreo.Text)
                Me.Close()
            Else
                MsgBox("asegurese de rellenar todos los campos")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub limpiar()
        TBdni.Clear()
        TBnombre.Clear()
        TBapellido.Clear()
        Tbtelefono.Clear()
        TBcorreo.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
