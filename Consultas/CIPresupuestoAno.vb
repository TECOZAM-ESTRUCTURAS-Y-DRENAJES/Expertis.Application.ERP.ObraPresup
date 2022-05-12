Public Class CIPresupuestoAno
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
    Protected WithEvents PFiltros As Solmicro.Expertis.Engine.UI.Panel
    Protected WithEvents PFilter As Solmicro.Expertis.Engine.UI.Panel
    Protected WithEvents PTotales As Solmicro.Expertis.Engine.UI.Panel
    Protected WithEvents FFilter As Solmicro.Expertis.Engine.UI.Frame
    Protected WithEvents FTotales As Solmicro.Expertis.Engine.UI.Frame
    Protected WithEvents lblEmpresa As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents AdvIDEmpresa As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents lblPresupHasta As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents AdvIDPresupHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents lblPresupDesde As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents AdvIDPresupDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Protected WithEvents lblTotalLineas As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents txtTotalLineas As Solmicro.Expertis.Engine.UI.NumericTextBox
    Protected WithEvents lblAño As Solmicro.Expertis.Engine.UI.Label
    Protected WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Protected WithEvents cbxAños As Solmicro.Expertis.Engine.UI.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cbxAños_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIPresupuestoAno))
        Me.PFiltros = New Solmicro.Expertis.Engine.UI.Panel
        Me.PTotales = New Solmicro.Expertis.Engine.UI.Panel
        Me.FTotales = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtTotalLineas = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalLineas = New Solmicro.Expertis.Engine.UI.Label
        Me.PFilter = New Solmicro.Expertis.Engine.UI.Panel
        Me.FFilter = New Solmicro.Expertis.Engine.UI.Frame
        Me.cbxAños = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblAño = New Solmicro.Expertis.Engine.UI.Label
        Me.lblEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDEmpresa = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblPresupHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDPresupHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblPresupDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDPresupDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.PFiltros.suspendlayout()
        Me.PTotales.suspendlayout()
        Me.FTotales.SuspendLayout()
        Me.PFilter.suspendlayout()
        Me.FFilter.SuspendLayout()
        CType(Me.cbxAños, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MainPanel.Controls.Add(Me.PFiltros)
        Me.MainPanel.Size = New System.Drawing.Size(776, 341)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(776, 341)
        '
        'PFiltros
        '
        Me.PFiltros.Controls.Add(Me.PTotales)
        Me.PFiltros.Controls.Add(Me.PFilter)
        Me.PFiltros.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PFiltros.Location = New System.Drawing.Point(0, 269)
        Me.PFiltros.Name = "PFiltros"
        Me.PFiltros.Size = New System.Drawing.Size(776, 72)
        Me.PFiltros.TabIndex = 0
        '
        'PTotales
        '
        Me.PTotales.Controls.Add(Me.FTotales)
        Me.PTotales.Dock = System.Windows.Forms.DockStyle.Right
        Me.PTotales.Location = New System.Drawing.Point(576, 0)
        Me.PTotales.Name = "PTotales"
        Me.PTotales.Size = New System.Drawing.Size(200, 72)
        Me.PTotales.TabIndex = 1
        '
        'FTotales
        '
        Me.FTotales.Controls.Add(Me.txtTotalLineas)
        Me.FTotales.Controls.Add(Me.lblTotalLineas)
        Me.FTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FTotales.Location = New System.Drawing.Point(0, 0)
        Me.FTotales.Name = "FTotales"
        Me.FTotales.Size = New System.Drawing.Size(200, 72)
        Me.FTotales.TabIndex = 0
        Me.FTotales.TabStop = False
        '
        'txtTotalLineas
        '
        Me.txtTotalLineas.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalLineas.Location = New System.Drawing.Point(32, 40)
        Me.txtTotalLineas.Name = "txtTotalLineas"
        Me.txtTotalLineas.Size = New System.Drawing.Size(144, 21)
        Me.txtTotalLineas.TabIndex = 1
        '
        'lblTotalLineas
        '
        Me.lblTotalLineas.AutoSize = False
        Me.lblTotalLineas.Location = New System.Drawing.Point(32, 23)
        Me.lblTotalLineas.Name = "lblTotalLineas"
        Me.lblTotalLineas.Size = New System.Drawing.Size(144, 13)
        Me.lblTotalLineas.TabIndex = 0
        Me.lblTotalLineas.Text = "Imp. Total Presup."
        Me.lblTotalLineas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PFilter
        '
        Me.PFilter.Controls.Add(Me.FFilter)
        Me.PFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PFilter.Location = New System.Drawing.Point(0, 0)
        Me.PFilter.Name = "PFilter"
        Me.PFilter.Size = New System.Drawing.Size(776, 72)
        Me.PFilter.TabIndex = 0
        '
        'FFilter
        '
        Me.FFilter.Controls.Add(Me.cbxAños)
        Me.FFilter.Controls.Add(Me.lblAño)
        Me.FFilter.Controls.Add(Me.lblEmpresa)
        Me.FFilter.Controls.Add(Me.AdvIDEmpresa)
        Me.FFilter.Controls.Add(Me.lblPresupHasta)
        Me.FFilter.Controls.Add(Me.AdvIDPresupHasta)
        Me.FFilter.Controls.Add(Me.lblPresupDesde)
        Me.FFilter.Controls.Add(Me.AdvIDPresupDesde)
        Me.FFilter.Controls.Add(Me.lblCliente)
        Me.FFilter.Controls.Add(Me.AdvIDCliente)
        Me.FFilter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FFilter.Location = New System.Drawing.Point(0, 0)
        Me.FFilter.Name = "FFilter"
        Me.FFilter.Size = New System.Drawing.Size(776, 72)
        Me.FFilter.TabIndex = 0
        Me.FFilter.TabStop = False
        Me.FFilter.Text = " Criterios de Selección  "
        '
        'cbxAños
        '
        cbxAños_DesignTimeLayout.LayoutString = resources.GetString("cbxAños_DesignTimeLayout.LayoutString")
        Me.cbxAños.DesignTimeLayout = cbxAños_DesignTimeLayout
        Me.cbxAños.DisabledBackColor = System.Drawing.Color.White
        Me.cbxAños.Location = New System.Drawing.Point(464, 45)
        Me.cbxAños.Name = "cbxAños"
        Me.cbxAños.SelectedIndex = -1
        Me.cbxAños.SelectedItem = Nothing
        Me.cbxAños.Size = New System.Drawing.Size(96, 21)
        Me.cbxAños.TabIndex = 33
        '
        'lblAño
        '
        Me.lblAño.Location = New System.Drawing.Point(432, 45)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(29, 13)
        Me.lblAño.TabIndex = 32
        Me.lblAño.Text = "Año"
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Location = New System.Drawing.Point(8, 45)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(57, 13)
        Me.lblEmpresa.TabIndex = 16
        Me.lblEmpresa.Text = "Empresa"
        '
        'AdvIDEmpresa
        '
        Me.AdvIDEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDEmpresa.EntityName = "Empresa"
        Me.AdvIDEmpresa.Location = New System.Drawing.Point(72, 45)
        Me.AdvIDEmpresa.Name = "AdvIDEmpresa"
        Me.AdvIDEmpresa.SecondaryDataFields = "IDEmpresa"
        Me.AdvIDEmpresa.Size = New System.Drawing.Size(128, 23)
        Me.AdvIDEmpresa.TabIndex = 20
        '
        'lblPresupHasta
        '
        Me.lblPresupHasta.Location = New System.Drawing.Point(408, 20)
        Me.lblPresupHasta.Name = "lblPresupHasta"
        Me.lblPresupHasta.Size = New System.Drawing.Size(48, 13)
        Me.lblPresupHasta.TabIndex = 27
        Me.lblPresupHasta.Text = "- Hasta"
        '
        'AdvIDPresupHasta
        '
        Me.AdvIDPresupHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDPresupHasta.DisplayField = "NumPresup"
        Me.AdvIDPresupHasta.EntityName = "ObraPresupCabecera"
        Me.AdvIDPresupHasta.Location = New System.Drawing.Point(464, 20)
        Me.AdvIDPresupHasta.Name = "AdvIDPresupHasta"
        Me.AdvIDPresupHasta.SecondaryDataFields = "NumPresup"
        Me.AdvIDPresupHasta.Size = New System.Drawing.Size(96, 23)
        Me.AdvIDPresupHasta.TabIndex = 19
        '
        'lblPresupDesde
        '
        Me.lblPresupDesde.Location = New System.Drawing.Point(216, 20)
        Me.lblPresupDesde.Name = "lblPresupDesde"
        Me.lblPresupDesde.Size = New System.Drawing.Size(86, 13)
        Me.lblPresupDesde.TabIndex = 29
        Me.lblPresupDesde.Text = "Presup Desde"
        '
        'AdvIDPresupDesde
        '
        Me.AdvIDPresupDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDPresupDesde.DisplayField = "NumPresup"
        Me.AdvIDPresupDesde.EntityName = "ObraPresupCabecera"
        Me.AdvIDPresupDesde.Location = New System.Drawing.Point(304, 20)
        Me.AdvIDPresupDesde.Name = "AdvIDPresupDesde"
        Me.AdvIDPresupDesde.SecondaryDataFields = "NumPresup"
        Me.AdvIDPresupDesde.Size = New System.Drawing.Size(96, 23)
        Me.AdvIDPresupDesde.TabIndex = 17
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(8, 20)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 31
        Me.lblCliente.Tag = ""
        Me.lblCliente.Text = "Cliente"
        '
        'AdvIDCliente
        '
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(72, 20)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(128, 23)
        Me.AdvIDCliente.TabIndex = 15
        '
        'Grid
        '
        Me.Grid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.Grid.EntityName = "ObraPresupCabecera"
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 0)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(776, 269)
        Me.Grid.TabIndex = 1
        Me.Grid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.Grid.ViewName = "vCIObraPresupPorEjercicio"
        '
        'CIPresupuestoAno
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(784, 429)
        Me.Name = "CIPresupuestoAno"
        Me.Text = "CIPresupuestoAno"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.PFiltros.ResumeLayout(False)
        Me.PTotales.ResumeLayout(False)
        Me.FTotales.ResumeLayout(False)
        Me.FTotales.PerformLayout()
        Me.PFilter.ResumeLayout(False)
        Me.FFilter.ResumeLayout(False)
        Me.FFilter.PerformLayout()
        CType(Me.cbxAños, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Const cnABRIRCLIENTE As String = "Abrir Cliente"

#Region " Load "

    Protected Overridable Sub CIPresupuestoAño_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            RellenarComboAños(cbxAños)
            cbxAños.Text = Year(Date.Today)
            Me.CIPrimaryObject = Grid
            Me.Grid.Actions.Add("Abrir Presupuesto", AddressOf AccionAbrirPresupuesto, ExpertisApp.GetIcon("xPresupuestos.ico"))
            Me.Grid.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
        End If
    End Sub

    Protected Overridable Sub AccionAbrirPresupuesto()
        ExpertisApp.OpenForm("MGEPRE", New FilterItem("NumPresup", FilterOperator.Equal, Grid.GetValue("NumPresup")))
    End Sub

    Private Sub AccionAbrirCliente()
        ExpertisApp.OpenForm("MCLIENTE", New FilterItem("IDCliente", FilterOperator.Equal, Grid.GetValue("IDCliente")))
    End Sub

#End Region

    Protected Overridable Sub Grid_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Grid.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(Grid) AndAlso Grid.RowCount > 0 Then
                If length(Grid.Value("IDCliente")) > 0 Then
                    Grid.UiCommandManager1.Commands(cnABRIRCLIENTE).Visible = InheritableBoolean.True
                Else
                    Grid.UiCommandManager1.Commands(cnABRIRCLIENTE).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

    Protected Overridable Sub CIPresupuestoAño_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        e.Filter.Add("IDCliente", FilterOperator.Equal, AdvIDCliente.Text)
        e.Filter.Add("IDEmpresa", FilterOperator.Equal, AdvIDEmpresa.Text)
        e.Filter.Add("NumPresup", FilterOperator.GreaterThanOrEqual, AdvIDPresupDesde.Text)
        e.Filter.Add("NumPresup", FilterOperator.LessThanOrEqual, AdvIDPresupHasta.Text)
        e.Filter.Add("Año", FilterOperator.Equal, cbxAños.Text)
    End Sub

    Protected Overridable Sub CIPresupuestoAño_QueryExecuted(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutedEventArgs) Handles MyBase.QueryExecuted
        txtTotalLineas.Value = Grid.GetTotal(Grid.Columns("Saldo"), AggregateFunction.Sum)
    End Sub

End Class