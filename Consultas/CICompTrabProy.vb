Public Class CICompTrabProy

    Private Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Proyecto", AddressOf AbrirProyecto, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

    Private Sub AbrirProyecto()
        If Length(Grid.GetValue("IDObra")) > 0 Then
            ExpertisApp.OpenForm("MGEO", New FilterItem("IDObra", FilterOperator.Equal, Me.Grid.GetValue("IDObra")))
        End If
    End Sub

    Private Sub CICompTrabProy_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadGridActions()
    End Sub

    Private Sub CICompTrabProy_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles Me.QueryExecuting
        e.Filter.Add("IDObra", FilterOperator.GreaterThanOrEqual, Me.AdvObraDesde.Value)
        e.Filter.Add("IDObra", FilterOperator.LessThanOrEqual, Me.AdvObraHasta.Value)
        e.Filter.Add("IDTrabajo", FilterOperator.GreaterThanOrEqual, Me.AdvTrabajoDesde.Value)
        e.Filter.Add("IDTrabajo", FilterOperator.LessThanOrEqual, Me.AdvTrabajoHasta.Value)
    End Sub

End Class