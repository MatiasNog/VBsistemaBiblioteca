Public Class SistemaBiblioteca
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Socios.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Libros.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Prestamos.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DevolucionesPrestamo.ShowDialog()
    End Sub
End Class