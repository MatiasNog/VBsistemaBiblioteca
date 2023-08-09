Public Class CNusuario
    Public Function ConsultarUsuario(ID As Integer, pass As String) As DataTable
        Try
            Dim CDC As New CDusuario
            Dim dt As DataTable
            dt = CDC.ConsultarUsuario(ID, pass)
            Return dt
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function



End Class
