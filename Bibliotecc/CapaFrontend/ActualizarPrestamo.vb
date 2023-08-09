Imports System.Security.Cryptography

Public Class ActualizarPrestamo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TBActualizarDNI.Text <> "" And TBactualizarCodigoIBSN.Text <> "" And TBactualizarDevuelto.Text <> "" And TBactualizarFechaLimite.Text <> "" And TbactualizarIDprestamo.Text <> "" And TBactualizarDevuelto.Text <> "" Then
                Dim cnp As New CNprestamo
                cnp.ActualizarDatos(Val(TBactualizarCodigoIBSN.Text), Val(TBActualizarDNI.Text), TBactualizarFechaPrestamo.Text, TBactualizarFechaLimite.Text, Val(TbactualizarIDprestamo.Text))
            Else
                MsgBox("hay datos sin rellenar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class