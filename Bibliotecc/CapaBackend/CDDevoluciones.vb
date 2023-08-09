Imports MySql.Data.MySqlClient

Public Class CDDevoluciones
    Inherits Conexiones
    Private IDprestamo As Integer
    Private DNI As Integer
    Private CodigoIBSN As Integer
    Private fechaPrestamo As String
    Private FechaLimite As String
    Private Devuelto As String
    Private CDd As MySqlCommand

    Public Sub New(id As Integer, d As Integer, c As Integer, fp As String, fl As String, de As String)
        IDprestamo = id
        DNI = d
        CodigoIBSN = c
        fechaPrestamo = fp
        FechaLimite = fl
        Devuelto = de
    End Sub

    Public Sub New()
        IDprestamo = Nothing
        DNI = Nothing
        CodigoIBSN = Nothing
        fechaPrestamo = String.Empty
        FechaLimite = String.Empty
        Devuelto = String.Empty
    End Sub

    Public ReadOnly Property SIDprestamo()
        Get
            Return IDprestamo
        End Get
    End Property

    Public ReadOnly Property SDNI()
        Get
            Return dni
        End Get
    End Property

    Public ReadOnly Property ScodigoIBSN()
        Get
            Return CodigoIBSN
        End Get
    End Property

    Public ReadOnly Property SfechaPrestamo()
        Get
            Return fechaPrestamo
        End Get
    End Property

    Public ReadOnly Property SfechaLimite()
        Get
            Return FechaLimite
        End Get
    End Property

    Public ReadOnly Property Sdevuelto()
        Get
            Return Devuelto
        End Get
    End Property

    Public Sub InsertarDatos(datos As CDDevoluciones)
        Try
            Conectar()
            CDd = New MySqlCommand("insert into devoluciones (idprestamo,dni,codigo_ibsn,fechaprestamo,fechalimite,devuelto) values (" & datos.SIDprestamo & " , " & datos.SDNI & " , " & datos.ScodigoIBSN & " , '" & datos.SfechaPrestamo & "','" & datos.SfechaLimite & "','" & datos.Sdevuelto & "')")
            CDd.Connection = Conexion1
            If CDd.ExecuteNonQuery Then
                MsgBox("datos insertados correctamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function VertDatos(id As Integer) As DataTable
        Try
            Conectar()
            CDd = New MySqlCommand("select * from devoluciones where IDprestamo = " & id)
            CDd.Connection = Conexion1
            If CDd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim dad As New MySqlDataAdapter(CDd)
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

    Public Function verdatos() As DataTable
        Try
            Conectar()
            CDd = New MySqlCommand("select * from devoluciones ")
            CDd.Connection = Conexion1
            If CDd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim dad As New MySqlDataAdapter(CDd)
                dad.fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MsgBox(ex.Message)
        End Try
    End Function
End Class
