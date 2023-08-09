Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class CDusuario
    Inherits Conexiones

    Private ID_usuario As Integer
    Private nombre As String
    Private apellido As String
    Private password As String
    Private CDC As MySqlCommand

    Public Sub New()
        nombre = String.Empty
        apellido = String.Empty
        password = String.Empty
    End Sub

    Public Sub New(no, ap, pas)
        nombre = no
        apellido = ap
        password = pas
    End Sub

    Public ReadOnly Property Snombre
        Get
            Return nombre
        End Get
    End Property

    Public ReadOnly Property Sapellido
        Get
            Return apellido
        End Get
    End Property

    Public ReadOnly Property Spassword
        Get
            Return password
        End Get
    End Property



    Public Function ConsultarUsuario(ID As Integer, Pass As String) As DataTable
        Try
            Conectar()
            CDC = New MySqlCommand("select ID_usuario,passw from usuarios where ID_usuario = " & ID & " and passw = '" & Pass & "'")
            CDC.Connection = Conexion1
            If CDC.ExecuteNonQuery Then
                Dim DT As New DataTable
                Dim DA As New MySqlDataAdapter(CDC)
                DA.Fill(DT)
                Return DT
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function
End Class
