Public Class CNsocio

    Public Sub EliminarSocio(dni As String)
        Try
            Dim CD As New CDsocios
            CD.EliminarSocio(dni)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ConsultarTodosLosDatosSocio() As DataTable
        Try
            Dim CD As New CDsocios
            Dim dt As DataTable
            dt = CD.ConsultarTodosLosDatosSocio
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub InsertarNuevoSocio(d, no, ap, te, co)
        Try
            Dim CDs As New CDsocios(d, no, ap, te, co)
            CDs.InsertarNuevoSocio(CDs)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ConsultaSocio(dni As String) As DataTable
        Try
            Dim CD As New CDsocios
            Dim dt As DataTable
            dt = CD.ConsultarSocio(dni)
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub ActualizarSocio(d, no, ap, tel, co)
        Try
            Dim CD As New CDsocios(d, no, ap, tel, co)
            CD.ActualizarSocio(CD)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
