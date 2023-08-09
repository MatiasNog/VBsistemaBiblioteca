Imports Microsoft.Reporting.WinForms

Public Class DevolucionesPrestamo
    Private Sub DevolucionesPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()

        GenerarReporte()
    End Sub

    Public Sub GenerarReporte()
        Try
            Dim cnp As New CNprestamo
            Dim dt As DataTable

            dt = cnp.VerTodosLosPrestamos

            ReportViewer1.LocalReport.DataSources.Clear()

            Dim DRP As New ReportDataSource("DSPrestamos", dt)

            ReportViewer1.LocalReport.DataSources.Add(DRP)

            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If TBcodigoIBNdevuelto.Text <> "" And TBdniDevuelto.Text <> "" Then
                Dim Gd As New GenerarDevolucion
                Dim cnp As New CNprestamo
                Dim dt As DataTable
                dt = cnp.VerPrestamosPorDNIyCodigoIBSN(Val(TBdniDevuelto.Text), Val(TBcodigoIBNdevuelto.Text))
                If dt.Rows.Count > 0 Then
                    Gd.DGWprestamosParaDevolver.DataSource = dt
                    Gd.ShowDialog()
                Else
                    MsgBox("no hay prestamos registrados con ese DNI o Codigo IBSN")
                End If
            Else
                MsgBox("falta insertar DNI o CodigoIBSN")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TBverDevoluciones.Text <> "" Then
                Dim cnd As New CNdevuelto
                Dim dt As DataTable
                dt = cnd.verDatos(Val(TBverDevoluciones.Text))
                If dt.Rows.Count <> Nothing Then
                    PrestamosDevueltos.DGWprestamosDevueltos.DataSource = dt
                    PrestamosDevueltos.ShowDialog()
                Else
                    MsgBox("no hay datos con ese id de prestamo")
                End If
            Else
                MsgBox("debe ingresar un id de prestamo")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim cnd As New CNdevuelto
            Dim dt As DataTable
            dt = cnd.verdatos
            If dt.Rows.Count <> Nothing Then
                PrestamosDevueltos.DGWprestamosDevueltos.DataSource = dt
                PrestamosDevueltos.ShowDialog()
            Else
                MsgBox("no hay datos para mostrar")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class