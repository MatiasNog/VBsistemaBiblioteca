Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class CDlibros
    Inherits Conexiones
    Private CodigoIBSN As Integer
    Private titulo As String
    Private autor As String
    Private cantidad As Integer
    Private CDl As New MySqlCommand

    Public Sub New()
        titulo = String.Empty
        autor = String.Empty
        cantidad = Nothing
    End Sub

    Public Sub New(ti As String, au As String, can As Integer)
        titulo = ti
        autor = au
        cantidad = can
    End Sub

    Public ReadOnly Property Stitulo
        Get
            Return titulo
        End Get
    End Property

    Public ReadOnly Property Sautor
        Get
            Return autor
        End Get
    End Property

    Public ReadOnly Property Scantidad
        Get
            Return cantidad
        End Get
    End Property

    Public Sub RestarCantidadLibros(codigo As Integer)
        Try
            Conectar()
            CDl = New MySqlCommand("update libros set cantidad = cantidad - 1  where codigo_IBSN = " & codigo)
            CDl.Connection = Conexion1
            If CDl.ExecuteNonQuery Then
                MsgBox("se resto correctamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub EliminarLibro(codigo As Integer)
        Try
            Conectar()
            CDl = New MySqlCommand("delete from libros where Codigo_ibsn = " & codigo)
            CDl.Connection = Conexion1
            If CDl.ExecuteNonQuery Then
                MsgBox("se ha eliminado el libro correctamente")
            Else
                MsgBox("no se puede eliminar este libro")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ActualizarLibro(libro As CDlibros, Codigo As Integer)
        Try
            Conectar()
            CDl = New MySqlCommand("update libros set Titulo = '" & libro.Stitulo & "', autor = '" & libro.Sautor & "', cantidad = " & libro.Scantidad & " where codigo_IBSN = " & Codigo)
            CDl.Connection = Conexion1
            If CDl.ExecuteNonQuery Then
                MsgBox("se ejecutaron los datos correctamente")
            Else
                MsgBox("no se pudo ejecutar el Query")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function ConsultarLibroPortCodigo(Codigo As Integer) As DataTable
        Try
            Conectar()
            CDl = New MySqlCommand("select * from libros where Codigo_IBSN = " & Codigo)
            CDl.Connection = Conexion1
            If CDl.ExecuteNonQuery Then
                Dim DT As New DataTable
                Dim DAD As New MySqlDataAdapter(CDl)
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

    Public Function ConsultarLibro(titulo As String) As DataTable
        Try
            Conectar()
            CDl = New MySqlCommand("select * from libros where titulo = '" & titulo & "'")
            CDl.Connection = Conexion1
            If CDl.ExecuteNonQuery Then
                Dim DT As New DataTable
                Dim DAD As New MySqlDataAdapter(CDl)
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

    Public Function ConsultarTodosLosLibros() As DataTable
        Try
            Conectar()
            CDl = New MySqlCommand("select * from libros")
            CDl.Connection = Conexion1
            If CDl.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim DAD As New MySqlDataAdapter(CDl)
                DAD.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Sub InsertarNuevoLibro(Libro As CDlibros)
        Try
            Conectar()
            CDl = New MySqlCommand("insert into libros (titulo,autor,cantidad) values ('" & Libro.Stitulo & "','" & Libro.Sautor & "'," & Libro.Scantidad & ")", Conexion1)

            If CDl.ExecuteNonQuery Then
                MsgBox("libro registrado correctamente")
            Else
                MsgBox("no se pudo registrar correctamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
