Imports System.Net.Configuration

Public Class InicioSesion

    Public Sub limpiar()
        TBid.Clear()
        TBcontraseña.Clear()
    End Sub

    Private Sub BTNconsultar_Click(sender As Object, e As EventArgs) Handles BTNconsultar.Click
        Try
            Dim CN As New CNusuario
            Dim DT As DataTable
            DT = CN.ConsultarUsuario(Val(TBid.Text), TBcontraseña.Text)
            Dim dr As DataRow
            dr = DT.Rows(0)
            If TBcontraseña.Text = dr.Item(1) And Val(TBid.Text) = dr.Item(0) Then
                limpiar()
                SistemaBiblioteca.ShowDialog()
            Else
                MsgBox("contraseña incorrecta")
                limpiar()
            End If
        Catch ex As Exception
            MsgBox("Usuario o contraseña Incorrectos", MsgBoxStyle.Information)
        End Try
    End Sub
End Class
