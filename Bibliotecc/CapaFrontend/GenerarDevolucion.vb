Imports System.Net

Public Class GenerarDevolucion
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dt As DataTable
            Dim cnp As New CNprestamo
            dt = cnp.VerPrestamoPorID_prestamo(Val(TBidPrestamo.Text))
            Dim dr As DataRow
            If dt.Rows.Count > 0 Then
                dr = dt.Rows.Item(0)
                Dim cdd As New CNdevuelto
                cdd.InsertarDatos(Val(dr.Item(0)), Val(dr.Item(2)), Val(dr.Item(1)), dr.Item(3), dr.Item(4), "si")
                cnp.EliminarPrestamo(Val(TBidPrestamo.Text))
            Else
                MsgBox("no hay datos con ese registro")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class