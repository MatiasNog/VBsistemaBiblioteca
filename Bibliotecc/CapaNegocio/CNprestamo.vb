Public Class CNprestamo
    Public Sub InsertarPrestamo(c, d, fp, fd, codigo)
        Try
            Dim CNpr As New CDprestamo(c, d, fp, fd)
            CNpr.InsertarPrestamo(CNpr, codigo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function VerTodosLosPrestamos() As DataTable
        Try
            Dim cdp As New CDprestamo
            Dim dt As DataTable
            dt = cdp.VerTodosLosPrestamos
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function VerPrestamoPorID_prestamo(Id As Integer) As DataTable
        Try
            Dim CDp As New CDprestamo
            Dim dt As DataTable
            dt = CDp.VerPrestamoPorID_prestamo(Id)
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub ActualizarDatos(c, d, fp, fd, id)
        Try
            Dim CD As New CDprestamo(c, d, fp, fd)
            CD.ActualizarDatos(CD, id)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub EliminarPrestamo(id As Integer)
        Try
            Dim cdp As New CDprestamo
            cdp.EliminarPrestamo(id)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function VerPrestamosPorDNIyCodigoIBSN(dni As Integer, CodigoIBSN As Integer) As DataTable
        Try
            Dim cdpre As New CDprestamo
            Dim dt As DataTable
            dt = cdpre.VerPrestamosPorDNIyCodigoIBSN(dni, CodigoIBSN)
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function
End Class
