Public Class Socios

    Public Sub clear()
        TBcorreoRegistrar.Clear()
        TBdniRegistrar.Clear()
        TBapellidoRegistrar.Clear()
        TBtelefonoRegistrar.Clear()
        TBnombreRegistrar.Clear()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TBapellidoRegistrar.Text <> "" Or TBdniRegistrar.Text <> "" Or TBnombreRegistrar.Text <> "" Or TBtelefonoRegistrar.Text <> "" Or TBcorreoRegistrar.Text <> "" Then
            Try
                Dim CDS As New CDsocios(TBdniRegistrar.Text, TBnombreRegistrar.Text, TBapellidoRegistrar.Text, TBtelefonoRegistrar.Text, TBcorreoRegistrar.Text)
                CDS.InsertarNuevoSocio(CDS)
                clear()
            Catch ex As Exception
                MsgBox("ha ocurrido un error", MsgBoxStyle.Information)
            End Try
        Else
            MsgBox("asegurese de llenar todos los espacios")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TBdniConsultar.Text <> "" Then
                Dim CN As New CNsocio
                Dim dt As DataTable
                dt = CN.ConsultaSocio(TBdniConsultar.Text)
                DGWconsultaSocio.DataSource = dt
            Else
                MsgBox("no se encontraron resultados")
            End If
        Catch ex As Exception
            MsgBox("no se encontraron result")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim CN As New CNsocio
            Dim dt As DataTable
            dt = CN.ConsultarTodosLosDatosSocio
            DGWtodosLosSocios.DataSource = dt
        Catch ex As Exception
            MsgBox("no existen datos de socios registrados")
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim cns As New CNsocio
            Dim dt As DataTable
            dt = cns.ConsultaSocio(TBConsultaActualizarDNI.Text)
            If dt.Rows.Count > 0 Then
                Dim dr As DataRow
                dr = dt.Rows(0)
                ActualizarSocio.Show()
                ActualizarSocio.TBactualizarDNI.Text = dr.Item(0)
                ActualizarSocio.TBactualizarNombre.Text = dr.Item(1)
                ActualizarSocio.TBactualizarApellido.Text = dr.Item(2)
                ActualizarSocio.TBactualizarTelefono.Text = dr.Item(3)
                ActualizarSocio.TBactualizarCorreo.Text = dr.Item(4)
            Else
                MsgBox("no existe un socio con ese DNI")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TBbajaDNI_LostFocus(sender As Object, e As EventArgs) Handles TBbajaDNI.LostFocus
        Try
            If TBbajaDNI.Text <> "" Then
                Dim cd As New CDsocios
                Dim dt As DataTable
                dt = cd.ConsultarSocio(TBbajaDNI.Text)
                If dt.Rows.Count > 0 Then
                    Dim dr As DataRow
                    dr = dt.Rows(0)
                    TBbajaNombre.Text = dr.Item(1)
                    TBbajaApellido.Text = dr.Item(2)
                Else
                    MsgBox("el socio no esta dado de alta")
                End If
            Else
                MsgBox("debe indicar el DNI del socio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim cn As New CNsocio
            cn.EliminarSocio(TBbajaDNI.Text)
            TBbajaDNI.Clear()
            TBbajaNombre.Clear()
            TBbajaApellido.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
