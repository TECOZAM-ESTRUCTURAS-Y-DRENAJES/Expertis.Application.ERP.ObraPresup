Public Class MntoEstadoPresup

    Private Sub Grid_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles Grid.EditingCell
        Select Case e.Column.Key
            Case "IDEstado"
                e.Cancel = (Grid.Row <> Grid.newTopRowPosition AndAlso Length(Grid.Value("IDEstado")) > 0)
        End Select
    End Sub

    Private Sub Grid_Deleting(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles Grid.DeletingRecord
        If e.Row.Cells("Sistema").Value Then
            ExpertisApp.GenerateMessage("No se permite la eliminación de un registro del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True
        End If
    End Sub

End Class
