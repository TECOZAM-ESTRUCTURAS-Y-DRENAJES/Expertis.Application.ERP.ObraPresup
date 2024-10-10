Public Class CINombresContacto

    Dim auxiliares As New Business.ClasesTecozam.MetodosAuxiliares

    Public Sub ejecutaConsulta()
        If Len(txtNombre.Text) > 0 Then
            Dim dt As New DataTable
            Dim sql As String = "SELECT * FROM tbObraPresupFax WHERE LOWER(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(Para, 'á', 'a'), 'é', 'e'), 'í', 'i'), 'ó', 'o'), 'ú', 'u'), 'Á', 'A'), 'É', 'E')) LIKE LOWER('%" & txtNombre.Text & "%')"
            dt = auxiliares.EjecutarSqlSelect(sql)
            Grid.DataSource = dt
        End If
    End Sub

    Private Sub bBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bBuscar.Click
        ejecutaConsulta()
    End Sub

    Private Sub LoadGridActions()
        With Grid
            .Actions.Add("Abrir presupuesto.", AddressOf AbrirPresupuesto, ExpertisApp.GetIcon("address_bookAdd.ico"))
        End With
    End Sub

    Private Sub AbrirPresupuesto()
        With Grid
            ExpertisApp.OpenForm("MGEPRE", New StringFilterItem("IdPresup", .Value("IdPresup")))
        End With
    End Sub

    Private Sub CINombresContacto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadGridActions()
    End Sub
End Class