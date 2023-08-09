Public Class PreguntaSocio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AltaSocioPorPrestamo.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class