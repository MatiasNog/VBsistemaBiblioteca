Imports MySql.Data.MySqlClient

Public Class Conexiones
    Protected Conexion1 As New MySqlConnection

    Public Sub Conectar()
        Try
            Conexion1.ConnectionString = "server=localhost;user=root;password=1593574682;database=sistema_biblioteca"
            If Conexion1.State = ConnectionState.Closed Then
                Conexion1.Open()
            Else
                Conexion1.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub desconectar()
        Try
            Conexion1.ConnectionString = "server=localhost;user=root;password=1593574682;database=sistema_biblioteca"
            If Conexion1.State = ConnectionState.Open Then
                Conexion1.Close()
            Else
                Conexion1.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
