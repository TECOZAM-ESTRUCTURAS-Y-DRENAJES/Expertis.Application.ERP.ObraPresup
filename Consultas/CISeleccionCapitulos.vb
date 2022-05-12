Public Class CISeleccionCapitulos
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CISeleccionCapitulos))
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Grid
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""IDTrabajoPre" & _
        "sup""><Caption>IDTrabajoPresup</Caption><DataMember>IDTrabajoPresup</DataMember><" & _
        "Key>IDTrabajoPresup</Key><Position>0</Position><Visible>False</Visible></Column0" & _
        "><Column1 ID=""IDPresup""><Caption>IDPresup</Caption><DataMember>IDPresup</DataMem" & _
        "ber><Key>IDPresup</Key><Position>1</Position><Visible>False</Visible></Column1><" & _
        "Column2 ID=""IDTipoTrabajo""><Caption>IDTipoTrabajo</Caption><DataMember>IDTipoTra" & _
        "bajo</DataMember><Key>IDTipoTrabajo</Key><Position>2</Position><Visible>False</V" & _
        "isible></Column2><Column3 ID=""CodTrabajo""><Caption>Capítulo</Caption><DataMember" & _
        ">CodTrabajo</DataMember><Key>CodTrabajo</Key><Position>3</Position><Width>90</Wi" & _
        "dth></Column3><Column4 ID=""DescTrabajo""><Caption>Desc. Capítulo</Caption><DataMe" & _
        "mber>DescTrabajo</DataMember><Key>DescTrabajo</Key><Position>4</Position><Width>" & _
        "245</Width></Column4><Column5 ID=""IdProcess""><Caption>IdProcess</Caption><DataMe" & _
        "mber>IdProcess</DataMember><Key>IdProcess</Key><Position>5</Position><Visible>Fa" & _
        "lse</Visible></Column5><Column6 ID=""CantidadMarca1""><Caption>CantidadMarca1</Cap" & _
        "tion><DataMember>CantidadMarca1</DataMember><Key>CantidadMarca1</Key><Position>6" & _
        "</Position><TextAlignment>Far</TextAlignment><Visible>False</Visible></Column6><" & _
        "Column7 ID=""TipoLinea""><Caption>TipoLinea</Caption><DataMember>TipoLinea</DataMe" & _
        "mber><Key>TipoLinea</Key><Position>7</Position><Visible>False</Visible></Column7" & _
        "></Columns><GroupCondition ID="""" /></RootTable></GridEXLayoutData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = "ObraTrabajoPresup"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.KeyField = "IDTipoTrabajo"
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(536, 193)
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.UseCheck = True
        Me.Grid.ViewName = "vFrmCISeleccionCapitulosInformeParcialPresupuesto"
        '
        'FilterPanel
        '
        Me.FilterPanel.Location = New System.Drawing.Point(0, 193)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Visible = False
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Name = "CIMntoGridPanel"
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(536, 193)
        '
        'ClearFilter
        '
        Me.ClearFilter.Icon = CType(resources.GetObject("ClearFilter.Icon"), System.Drawing.Icon)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Name = "MainPanelCIMntoContainer"
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(536, 273)
        '
        'ExecuteActions
        '
        Me.ExecuteActions.Icon = CType(resources.GetObject("ExecuteActions.Icon"), System.Drawing.Icon)
        '
        'ShowAllCheckedItems
        '
        Me.ShowAllCheckedItems.Icon = CType(resources.GetObject("ShowAllCheckedItems.Icon"), System.Drawing.Icon)
        Me.ShowAllCheckedItems.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'Export
        '
        Me.Export.Icon = CType(resources.GetObject("Export.Icon"), System.Drawing.Icon)
        '
        'UncheckAll
        '
        Me.UncheckAll.Icon = CType(resources.GetObject("UncheckAll.Icon"), System.Drawing.Icon)
        Me.UncheckAll.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'CheckAll
        '
        Me.CheckAll.Icon = CType(resources.GetObject("CheckAll.Icon"), System.Drawing.Icon)
        Me.CheckAll.Visible = Janus.Windows.UI.InheritableBoolean.True
        '
        'Toolbar
        '
        Me.Toolbar.Name = "Toolbar"
        Me.Toolbar.Size = New System.Drawing.Size(256, 26)
        '
        'MainPanel
        '
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(536, 273)
        '
        'Menubar
        '
        Me.Menubar.Name = "Menubar"
        '
        'ExecuteQuery
        '
        Me.ExecuteQuery.Icon = CType(resources.GetObject("ExecuteQuery.Icon"), System.Drawing.Icon)
        '
        'CISeleccionCapitulos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(544, 357)
        Me.EntityName = "ObraTrabajoPresup"
        Me.KeyField = "IDTipoTrabajo"
        Me.Name = "CISeleccionCapitulos"
        Me.Text = "CISeleccionCapitulos"
        Me.UseCheck = True
        Me.ViewName = "vFrmCISeleccionCapitulosInformeParcialPresupuesto"
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

#End Region

    Dim MIntIDPresup As Integer

    Private Sub LoadParams()
        Me.UiCommandManager1.CommandBars(0).Commands("ShowFilterPanel").Visible = Janus.Windows.UI.InheritableBoolean.False
        Me.UiCommandManager1.CommandBars(0).Commands("ShowFilterPanel").Enabled = Janus.Windows.UI.InheritableBoolean.False
        Me.FilterPanel.Visible = False
        If Not Me.Params Is Nothing Then
            Dim HtParam As New Hashtable
            HtParam = Me.Params
            MIntIDPresup = HtParam("IDPresup")
            Me.Execute()
        End If
    End Sub

    Private Sub CISeleccionCapitulos_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If length(MIntIDPresup) > 0 Then
            e.Filter.Add("IDPresup", FilterOperator.Equal, MIntIDPresup)
            e.Filter.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltCapitulo)
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub CISeleccionCapitulos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadParams()
    End Sub

    Private Sub CISeleccionCapitulos_SetReportExportOptions(ByVal sender As Object, ByVal e As Engine.UI.ReportExportOptionsEventArgs) Handles MyBase.SetReportExportOptions
        e.Options.PromptUser = True
        Me.Close()
    End Sub

    Private Sub CISeleccionCapitulos_SetReportSelectionCriteria(ByVal sender As Object, ByVal e As Engine.UI.ReportSelectionCriteriaEventArgs) Handles MyBase.SetReportSelectionCriteria
        Dim DtGrid As DataTable = Grid.CheckedRecords
        Dim StrListTipo(DtGrid.Rows.Count - 1) As String
        Dim i As Integer = 0
        For Each Dr As DataRow In DtGrid.Select
            StrListTipo(i) = Dr("IDTipoTrabajo")
            i += 1
        Next
        e.Filter.Add("IDPresup", FilterOperator.Equal, MIntIDPresup, FilterType.Numeric)
        e.Filter.Add(New InListFilterItem("IDTipoTrabajo", StrListTipo, FilterType.String))
    End Sub
End Class