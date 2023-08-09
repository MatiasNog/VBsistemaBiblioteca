Imports MySql.Data.MySqlClient

Public Class CDprestamo
    Inherits Conexiones
    Private codigoIBSN As Integer
    Private DNI As Integer
    Private FechaPrestamo As String
    Private FechaDevuelta As String
    Private CDpre As MySqlCommand

    Public Sub New(c, d, fp, fd)
        codigoIBSN = c
        DNI = d
        FechaPrestamo = fp
        FechaDevuelta = fd
    End Sub

    Public Sub New()
        codigoIBSN = Nothing
        DNI = Nothing
        FechaPrestamo = String.Empty
        FechaDevuelta = String.Empty
    End Sub

    Public ReadOnly Property ScodigoIBSN
        Get
            Return codigoIBSN
        End Get
    End Property

    Public ReadOnly Property SDNI
        Get
            Return DNI
        End Get
    End Property

    Public ReadOnly Property SfechaPrestamo
        Get
            Return FechaPrestamo
        End Get
    End Property

    Public ReadOnly Property SfechaDevuelta
        Get
            Return FechaDevuelta
        End Get
    End Property

    Public Sub ActualizarDatos(cd As CDprestamo, id As Integer)
        Try
            Conectar()
            CDpre = New MySqlCommand("update prestamos set codigoIBSN = " & cd.ScodigoIBSN & " , solicitante_dni = " & cd.SDNI & " , fecha_prestamo = '" & cd.SfechaPrestamo & "' , fecha_devuelto = ' " & cd.SfechaDevuelta & "' where ID_prestamo = " & id)
            CDpre.Connection = Conexion1
            If CDpre.ExecuteNonQuery Then
                MsgBox("los datos se han actualizado correctamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub InsertarPrestamo(pret As CDprestamo, codigo As Integer)
        Try
            Conectar()
            CDpre = New MySqlCommand("insert into prestamos (codigoIBSN,solicitante_DNI,fecha_prestamo,fecha_devuelto) values (" & pret.ScodigoIBSN & "," & pret.SDNI & ",'" & pret.SfechaPrestamo & "','" & pret.SfechaDevuelta & "')")
            CDpre.Connection = Conexion1
            If CDpre.ExecuteNonQuery Then
                MsgBox("el prestamo se registro correctamente")
                Dim cnl As New CNlibro
                cnl.RestarCantidadLibros(codigo)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function VerPrestamoPorID_prestamo(Id As Integer) As DataTable
        Try
            Conectar()
            CDpre = New MySqlCommand("select * from prestamos where ID_prestamo = " & Id)
            CDpre.Connection = Conexion1
            If CDpre.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim dad As New MySqlDataAdapter(CDpre)
                dad.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function

    Public Function VerPrestamosPorDNIyCodigoIBSN(dni As Integer, CodigoIBSN As Integer) As DataTable
        Try
            Conectar()
            CDpre = New MySqlCommand("select * from prestamos where solicitante_DNI = " & dni & " and codigoIBSN = " & CodigoIBSN)
            CDpre.Connection = Conexion1
            If CDpre.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim DAD As New MySqlDataAdapter(CDpre)
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

    Public Function VerTodosLosPrestamos() As DataTable
        Try
            Conectar()
            CDpre = New MySqlCommand("select * from prestamos")
            CDpre.Connection = Conexion1

            If CDpre.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim DAD As New MySqlDataAdapter(CDpre)
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

    Public Sub EliminarPrestamo(id As Integer)
        Try
            Conectar()
            CDpre = New MySqlCommand("delete from prestamos where ID_prestamo = " & id)
            CDpre.Connection = Conexion1
            If CDpre.ExecuteNonQuery Then
                MsgBox("registro eliminado correctamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
