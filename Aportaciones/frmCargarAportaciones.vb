Public Class frmCargarAportaciones

    Public blEstado As Boolean
    Public dtTipos As DataTable

    Public Sub cargarGrid()
        Dim DE As New Expertis.Engine.BE.DataEngine
        Try
            Dim dt As DataTable = DE.RetrieveData("tbSistPresSubTipoAportacion", "idSubtipoAportacion,idTipoAportacion, descSubTipoAportacion", , , False)
            'dt = AdminData.GetData("Select distinct idSubtipoAportacion,descSubTipoAportacion from tbSistPresSubTipoAportacion", False)

            'dt = DE.Filter(""tbSistPresSubTipoAportacion", "idSubtipoAportacion,descSubTipoAportacion", , , False", "*", , False)
            'dt = DE.RetrieveData("tbSistPresSubTipoAportacion", "idSubtipoAportacion, descSubTipoAportacion", , , False)
            'dt = DE.RetrieveData("tbSistPresSubTipoAportacion")
            MsgBox(dt.Rows.Count & " filas " & dt.Columns.Count & " columnas")
            If dt.Rows.Count > 0 Then
                Me.GridSTAport.DataSource = dt
            Else
                ExpertisApp.GenerateMessage("No existen SubTipos de aportaciones dentro del sistema")
            End If
        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        End Try

        'Grid1.UseCheck = True
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        generardtTiposAportaciones()
        blEstado = False
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blEstado = True
        Me.Close()
    End Sub
    Public Sub generardtTiposAportaciones()
        Dim dtTAP As New DataTable
        Dim dc As New DataColumn("idSubtipoAportacion")
        dtTAP.Columns.Add(dc)
        For Each row As GridEXRow In GridSTAport.GetCheckedRows
            Dim drG As DataRow = dtTAP.NewRow
            Dim subTipo As String = row.Cells.Item("idSubtipoAportacion").Value
            drG.Item("idSubtipoAportacion") = subTipo
            dtTAP.Rows.Add(drG)

        Next
        dtTipos = dtTAP
        'MsgBox(dtTipos.Rows.Count)


    End Sub

    Public Sub New()

        'Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()
        cargarGrid()


        'Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class