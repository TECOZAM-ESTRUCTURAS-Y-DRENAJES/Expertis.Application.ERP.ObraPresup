Public Class CIPresupuesto
    Inherits Solmicro.Expertis.Engine.UI.CIMntoBase

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
    Protected WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Protected WithEvents lblTotalLineasVenta As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents txtTotalLineasVenta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Protected WithEvents lblTotalLineas As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents txtTotalLineas As Solmicro.Expertis.Engine.UI.NumericTextBox
    Protected WithEvents fraFiltros As Solmicro.Expertis.Engine.UI.Frame
    Protected WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Protected WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents lblFechaHasta As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents cbxFechaHasta As Solmicro.Expertis.Engine.UI.CalendarBox
    Protected WithEvents lblFechaDesde As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents cbxFechaDesde As Solmicro.Expertis.Engine.UI.CalendarBox
    Protected WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents lblPresupDesde As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents AdvIDPresupDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents lblPresupHasta As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents AdvIDPresupHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents lblEmpresa As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents AdvIDEmpresa As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents pnlImportes As Solmicro.Expertis.Engine.UI.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIPresupuesto))
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.lblTotalLineasVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalLineasVenta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalLineas = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalLineas = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.pnlImportes = New Solmicro.Expertis.Engine.UI.Panel
        Me.fraFiltros = New Solmicro.Expertis.Engine.UI.Frame
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFechaHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaHasta = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaDesde = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblPresupDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDPresupDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblPresupHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDPresupHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDEmpresa = New Solmicro.Expertis.Engine.UI.AdvSearch
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlImportes.suspendlayout()
        Me.fraFiltros.SuspendLayout()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(298, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.Grid)
        Me.MainPanel.Controls.Add(Me.pnlImportes)
        Me.MainPanel.Controls.Add(Me.fraFiltros)
        Me.MainPanel.Size = New System.Drawing.Size(776, 384)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(776, 384)
        '
        'lblTotalLineasVenta
        '
        Me.lblTotalLineasVenta.Location = New System.Drawing.Point(452, 12)
        Me.lblTotalLineasVenta.Name = "lblTotalLineasVenta"
        Me.lblTotalLineasVenta.Size = New System.Drawing.Size(169, 13)
        Me.lblTotalLineasVenta.TabIndex = 20
        Me.lblTotalLineasVenta.Text = "Importe Total Presup. Venta"
        Me.lblTotalLineasVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalLineasVenta
        '
        Me.txtTotalLineasVenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalLineasVenta.Enabled = False
        Me.txtTotalLineasVenta.Location = New System.Drawing.Point(626, 8)
        Me.txtTotalLineasVenta.Name = "txtTotalLineasVenta"
        Me.txtTotalLineasVenta.Size = New System.Drawing.Size(144, 21)
        Me.txtTotalLineasVenta.TabIndex = 19
        '
        'lblTotalLineas
        '
        Me.lblTotalLineas.Location = New System.Drawing.Point(165, 12)
        Me.lblTotalLineas.Name = "lblTotalLineas"
        Me.lblTotalLineas.Size = New System.Drawing.Size(132, 13)
        Me.lblTotalLineas.TabIndex = 21
        Me.lblTotalLineas.Text = "Importe Total Presup."
        Me.lblTotalLineas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalLineas
        '
        Me.txtTotalLineas.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalLineas.Enabled = False
        Me.txtTotalLineas.Location = New System.Drawing.Point(302, 8)
        Me.txtTotalLineas.Name = "txtTotalLineas"
        Me.txtTotalLineas.Size = New System.Drawing.Size(144, 21)
        Me.txtTotalLineas.TabIndex = 18
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = "ObraPresupCabecera"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.FrozenColumns = 2
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(776, 262)
        Me.Grid.TabIndex = 1
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vCIConsultaObraPresup"
        '
        'pnlImportes
        '
        Me.pnlImportes.Controls.Add(Me.lblTotalLineasVenta)
        Me.pnlImportes.Controls.Add(Me.lblTotalLineas)
        Me.pnlImportes.Controls.Add(Me.txtTotalLineasVenta)
        Me.pnlImportes.Controls.Add(Me.txtTotalLineas)
        Me.pnlImportes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlImportes.Location = New System.Drawing.Point(0, 262)
        Me.pnlImportes.Name = "pnlImportes"
        Me.pnlImportes.Size = New System.Drawing.Size(776, 35)
        Me.pnlImportes.TabIndex = 2
        '
        'fraFiltros
        '
        Me.fraFiltros.Controls.Add(Me.cbxEstado)
        Me.fraFiltros.Controls.Add(Me.lblEstado)
        Me.fraFiltros.Controls.Add(Me.lblFechaHasta)
        Me.fraFiltros.Controls.Add(Me.cbxFechaHasta)
        Me.fraFiltros.Controls.Add(Me.lblFechaDesde)
        Me.fraFiltros.Controls.Add(Me.cbxFechaDesde)
        Me.fraFiltros.Controls.Add(Me.lblCliente)
        Me.fraFiltros.Controls.Add(Me.AdvIDCliente)
        Me.fraFiltros.Controls.Add(Me.lblPresupDesde)
        Me.fraFiltros.Controls.Add(Me.AdvIDPresupDesde)
        Me.fraFiltros.Controls.Add(Me.lblPresupHasta)
        Me.fraFiltros.Controls.Add(Me.AdvIDPresupHasta)
        Me.fraFiltros.Controls.Add(Me.lblEmpresa)
        Me.fraFiltros.Controls.Add(Me.AdvIDEmpresa)
        Me.fraFiltros.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.fraFiltros.Location = New System.Drawing.Point(0, 297)
        Me.fraFiltros.Name = "fraFiltros"
        Me.fraFiltros.Size = New System.Drawing.Size(776, 87)
        Me.fraFiltros.TabIndex = 3
        Me.fraFiltros.TabStop = False
        Me.fraFiltros.Text = "Criterios de Selección"
        '
        'cbxEstado
        '
        Me.cbxEstado.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.DisplayMember = "DescEstado"
        Me.cbxEstado.EntityName = "ObraEstadoPresupuesto"
        Me.cbxEstado.Location = New System.Drawing.Point(653, 28)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(115, 21)
        Me.cbxEstado.TabIndex = 6
        Me.cbxEstado.ValueMember = "IDEstado"
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(604, 31)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 25
        Me.lblEstado.Text = "Estado"
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.Location = New System.Drawing.Point(413, 57)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(76, 13)
        Me.lblFechaHasta.TabIndex = 17
        Me.lblFechaHasta.Text = "Fecha Hasta"
        '
        'cbxFechaHasta
        '
        Me.cbxFechaHasta.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaHasta.Location = New System.Drawing.Point(501, 52)
        Me.cbxFechaHasta.Name = "cbxFechaHasta"
        Me.cbxFechaHasta.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaHasta.TabIndex = 5
        '
        'lblFechaDesde
        '
        Me.lblFechaDesde.Location = New System.Drawing.Point(413, 32)
        Me.lblFechaDesde.Name = "lblFechaDesde"
        Me.lblFechaDesde.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaDesde.TabIndex = 23
        Me.lblFechaDesde.Text = "Fecha Desde"
        '
        'cbxFechaDesde
        '
        Me.cbxFechaDesde.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaDesde.Location = New System.Drawing.Point(501, 28)
        Me.cbxFechaDesde.Name = "cbxFechaDesde"
        Me.cbxFechaDesde.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaDesde.TabIndex = 4
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(231, 31)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 26
        Me.lblCliente.Text = "Cliente"
        '
        'AdvIDCliente
        '
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(295, 26)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(112, 23)
        Me.AdvIDCliente.TabIndex = 2
        '
        'lblPresupDesde
        '
        Me.lblPresupDesde.Location = New System.Drawing.Point(9, 32)
        Me.lblPresupDesde.Name = "lblPresupDesde"
        Me.lblPresupDesde.Size = New System.Drawing.Size(117, 13)
        Me.lblPresupDesde.TabIndex = 28
        Me.lblPresupDesde.Text = "Presupuesto Desde"
        '
        'AdvIDPresupDesde
        '
        Me.AdvIDPresupDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDPresupDesde.DisplayField = "NumPresup"
        Me.AdvIDPresupDesde.EntityName = "ObraPresupCabecera"
        Me.AdvIDPresupDesde.Location = New System.Drawing.Point(130, 26)
        Me.AdvIDPresupDesde.Name = "AdvIDPresupDesde"
        Me.AdvIDPresupDesde.SecondaryDataFields = "IDPresup"
        Me.AdvIDPresupDesde.Size = New System.Drawing.Size(96, 23)
        Me.AdvIDPresupDesde.TabIndex = 0
        '
        'lblPresupHasta
        '
        Me.lblPresupHasta.Location = New System.Drawing.Point(9, 57)
        Me.lblPresupHasta.Name = "lblPresupHasta"
        Me.lblPresupHasta.Size = New System.Drawing.Size(113, 13)
        Me.lblPresupHasta.TabIndex = 30
        Me.lblPresupHasta.Text = "Presupuesto Hasta"
        '
        'AdvIDPresupHasta
        '
        Me.AdvIDPresupHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDPresupHasta.DisplayField = "NumPresup"
        Me.AdvIDPresupHasta.EntityName = "ObraPresupCabecera"
        Me.AdvIDPresupHasta.Location = New System.Drawing.Point(130, 52)
        Me.AdvIDPresupHasta.Name = "AdvIDPresupHasta"
        Me.AdvIDPresupHasta.SecondaryDataFields = "IDPresup"
        Me.AdvIDPresupHasta.Size = New System.Drawing.Size(96, 23)
        Me.AdvIDPresupHasta.TabIndex = 1
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Location = New System.Drawing.Point(231, 57)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(57, 13)
        Me.lblEmpresa.TabIndex = 32
        Me.lblEmpresa.Text = "Empresa"
        '
        'AdvIDEmpresa
        '
        Me.AdvIDEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDEmpresa.EntityName = "Empresa"
        Me.AdvIDEmpresa.Location = New System.Drawing.Point(295, 52)
        Me.AdvIDEmpresa.Name = "AdvIDEmpresa"
        Me.AdvIDEmpresa.SecondaryDataFields = "IDEmpresa"
        Me.AdvIDEmpresa.Size = New System.Drawing.Size(112, 23)
        Me.AdvIDEmpresa.TabIndex = 3
        '
        'CIPresupuesto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(784, 472)
        Me.Name = "CIPresupuesto"
        Me.Text = "CIPresupuesto"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlImportes.ResumeLayout(False)
        Me.pnlImportes.PerformLayout()
        Me.fraFiltros.ResumeLayout(False)
        Me.fraFiltros.PerformLayout()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const cnABRIRCLIENTE As String = "Abrir Cliente"

#Region " Load "

    Protected Overridable Sub CIPresupuesto_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SetCIPrimaryObject(Me.Grid, False)
        LoadGridActions()
        cbxEstado.DataSource = New ObraEstadoPresupuesto().Filter(New Filter)
    End Sub

    Protected Overridable Sub LoadGridActions()
        Me.Grid.Actions.Add("Abrir Presupuesto", AddressOf AccionAbrirPresupuesto, ExpertisApp.GetIcon("xPresupuestos.ico"))
        Me.Grid.Actions.Add(cnABRIRCLIENTE, AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
    End Sub

    Protected Overridable Sub AccionAbrirPresupuesto()
        Dim FilPresup As New Filter
        FilPresup.Add("NumPresup", FilterOperator.Equal, Grid.GetValue("NumPresup"))
        FilPresup.Add("RevPresup", FilterOperator.Equal, Grid.GetValue("RevPresup"))
        ExpertisApp.OpenForm("MGEPRE", FilPresup)
    End Sub

    Protected Overridable Sub AccionAbrirCliente()
        ExpertisApp.OpenForm("MCLIENTE", New FilterItem("IDCliente", FilterOperator.Equal, Grid.GetValue("IDCliente")))
    End Sub

#End Region

#Region " QueryExecute "

    Protected Overridable Sub CIPresupuesto_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        With Grid
            txtTotalLineas.Value = .GetTotal(.Columns("ImpPresupA"), Janus.Windows.GridEX.AggregateFunction.Sum)
            txtTotalLineasVenta.Value = .GetTotal(.Columns("ImpPresupVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum)
        End With
    End Sub

    Protected Overridable Sub CIPresupuesto_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDCliente", FilterOperator.Equal, AdvIDCliente.Value, FilterType.String)
        e.Filter.Add("IDEmpresa", FilterOperator.Equal, AdvIDEmpresa.Value, FilterType.String)
        e.Filter.Add("NumPresup", FilterOperator.GreaterThanOrEqual, AdvIDPresupDesde.Text, FilterType.String)
        e.Filter.Add("NumPresup", FilterOperator.LessThanOrEqual, AdvIDPresupHasta.Text, FilterType.String)
        e.Filter.Add("FechaPresup", FilterOperator.GreaterThanOrEqual, cbxFechaDesde.Value, FilterType.DateTime)
        e.Filter.Add("FechaPresup", FilterOperator.LessThanOrEqual, cbxFechaHasta.Value, FilterType.DateTime)
        e.Filter.Add("Estado", FilterOperator.Equal, cbxEstado.Value, FilterType.Numeric)
    End Sub

    Protected Overridable Sub CIPresupuesto_FilterCleared(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterCleared
        Me.cbxFechaDesde.TextBox.Clear()
        Me.cbxFechaHasta.TextBox.Clear()
        cbxEstado.Value = DBNull.Value
    End Sub

#End Region

    Protected Overridable Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
                If Length(Grid.Value("IDCliente")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRCLIENTE).Visible = InheritableBoolean.True
                Else
                    Grid.UiCommandManager1.Commands(cnABRIRCLIENTE).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

End Class