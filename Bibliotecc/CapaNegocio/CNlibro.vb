Public Class CNlibro
    Public Sub ActualizarLibros(t As String, a As String, c As Integer, codigo As Integer)
        Try
            Dim CD As New CDlibros(t, a, c)
            CD.ActualizarLibro(CD, codigo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InsertarNuevoLibro(t As String, a As String, c As Integer)
        Try
            Dim cd As New CDlibros(t, a, c)
            cd.InsertarNuevoLibro(cd)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ConsultarTodosLosLibros() As DataTable
        Try
            Dim CD As New CDlibros
            Dim DT As DataTable
            DT = CD.ConsultarTodosLosLibros
            Return DT
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function ConsultarLibro(titulo As String) As DataTable
        Try
            Dim CD As New CDlibros
            Dim DT As DataTable
            DT = CD.ConsultarLibro(titulo)
            Return DT
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function ConsultarLibroPortCodigo(codigo As Integer) As DataTable
        Try
            Dim CD As New CDlibros
            Dim dt As DataTable
            dt = CD.ConsultarLibroPortCodigo(codigo)
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub EliminarLibro(codigo As Integer)
        Try
            Dim CD As New CDlibros
            CD.EliminarLibro(codigo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub RestarCantidadLibros(codigo As Integer)
        Try
            Dim CDl As New CDlibros
            CDl.RestarCantidadLibros(codigo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
