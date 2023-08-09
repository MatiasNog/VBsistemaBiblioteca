Imports System.ComponentModel
Imports MySql.Data.MySqlClient

Public Class CDsocios
    Inherits Conexiones
    Private DNI As String
    Private nombre As String
    Private apellido As String
    Private telefono As String
    Private correo As String
    Private CDs As MySqlCommand

    Public Sub New()
        DNI = String.Empty
        nombre = String.Empty
        apellido = String.Empty
        telefono = String.Empty
        correo = String.Empty
    End Sub

    Public Sub New(d, no, ap, tel, co)
        DNI = d
        nombre = no
        apellido = ap
        telefono = tel
        correo = co
    End Sub

    Public ReadOnly Property Sdni
        Get
            Return DNI
        End Get
    End Property

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

    Public ReadOnly Property Stelefono
        Get
            Return telefono
        End Get
    End Property

    Public ReadOnly Property Scorreo
        Get
            Return correo
        End Get
    End Property

    Public Sub EliminarSocio(dni As String)
        Try
            Conectar()
            CDs = New MySqlCommand("delete from socios where DNI = '" & dni & "'")
            CDs.Connection = Conexion1
            If CDs.ExecuteNonQuery Then
                MsgBox("baja finalizada")
            Else
                MsgBox("no se pudo realizar la baja")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ActualizarSocio(Socio As CDsocios)
        Try
            Conectar()
            CDs = New MySqlCommand("update socios set nombre = '" & Socio.Snombre & "', apellido = '" & Socio.Sapellido & "', telefono = '" & Socio.Stelefono & "' , email = ' " & Socio.Scorreo & "' where dni = '" & Socio.Sdni & "'")
            CDs.Connection = Conexion1
            If CDs.ExecuteNonQuery Then
                MsgBox("se han modificiado los datos con exito")
            Else
                MsgBox("ocurrio un error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ConsultarSocio(dni As String) As DataTable
        Try
            Conectar()
            CDs = New MySqlCommand("select * from socios where dni = '" & dni & "'")
            CDs.Connection = Conexion1
            If CDs.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New MySqlDataAdapter(CDs)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub InsertarNuevoSocio(Socio As CDsocios)
        Try
            Conectar()
            CDs = New MySqlCommand("insert into socios (dni,nombre,apellido,telefono,email) values ('" & Socio.Sdni & "','" & Socio.Snombre & "','" & Socio.Sapellido & "','" & Socio.Stelefono & "','" & Socio.Scorreo & "')", Conexion1)
            If CDs.ExecuteNonQuery Then
                MsgBox("Socio Insertado correctamente")
            Else
                MsgBox("ocurrio un error")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ConsultarTodosLosDatosSocio() As DataTable
        Try
            Conectar()
            CDs = New MySqlCommand("select * from socios")
            CDs.Connection = Conexion1
            If CDs.ExecuteNonQuery Then
                Dim DT As New DataTable
                Dim DAD As New MySqlDataAdapter(CDs)
                DAD.Fill(DT)
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
