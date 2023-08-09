Public Class CNdevuelto
    Public Sub InsertarDatos(id As Integer, d As Integer, c As Integer, fp As String, fl As String, de As String)
        Try
            Dim cdd As New CDDevoluciones(id, d, c, fp, fl, de)
            cdd.InsertarDatos(cdd)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function verDatos(id As Integer) As DataTable
        Try
            Dim cdd As New CDDevoluciones
            Dim dt As DataTable
            dt = cdd.VertDatos(id)
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function verdatos() As DataTable
        Try
            Dim cdd As New CDDevoluciones
            Dim dt As DataTable
            dt = cdd.verdatos
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function
End Class
