Public Class CIActualizarPreciosPresup
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
    Friend WithEvents FilterPanel As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents pnlArticulo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblFamilia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvTipo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvFamilia As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlObra As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblIDPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDPresup As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents pnlTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents lblIDTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents TabActualizacionPrecios As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents TabPageTrabajos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridTrabajos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageMateriales As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridMateriales As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageMOD As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridMod As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageCentros As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridCentros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageGastos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridGastos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents TabPageVarios As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridVarios As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents ShowFilterCriteria As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ShowFilterCriteria1 As Janus.Windows.UI.CommandBars.UICommand

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim GridTrabajos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMateriales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMod_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCentros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridGastos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVarios_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIActualizarPreciosPresup))
        Me.FilterPanel = New Solmicro.Expertis.Engine.UI.Frame
        Me.pnlArticulo = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblFamilia = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTipo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvFamilia = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipo = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlObra = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblIDPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDPresup = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblIDTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TabActualizacionPrecios = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageTrabajos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridTrabajos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageMateriales = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMateriales = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageMOD = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMod = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageCentros = New Janus.Windows.UI.Tab.UITabPage
        Me.GridCentros = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageGastos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridGastos = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageVarios = New Janus.Windows.UI.Tab.UITabPage
        Me.GridVarios = New Solmicro.Expertis.Engine.UI.Grid
        Me.ShowFilterCriteria = New Janus.Windows.UI.CommandBars.UICommand("ShowFilterCriteria")
        Me.ShowFilterCriteria1 = New Janus.Windows.UI.CommandBars.UICommand("ShowFilterCriteria")
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.FilterPanel.SuspendLayout()
        Me.pnlArticulo.suspendlayout()
        Me.pnlObra.suspendlayout()
        Me.pnlTrabajo.suspendlayout()
        CType(Me.TabActualizacionPrecios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabActualizacionPrecios.SuspendLayout()
        Me.TabPageTrabajos.SuspendLayout()
        CType(Me.GridTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMateriales.SuspendLayout()
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageMOD.SuspendLayout()
        CType(Me.GridMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCentros.SuspendLayout()
        CType(Me.GridCentros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageGastos.SuspendLayout()
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageVarios.SuspendLayout()
        CType(Me.GridVarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ShowFilterCriteria})
        '
        'Toolbar
        '
        Me.Toolbar.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.ShowFilterCriteria1})
        Me.Toolbar.Size = New System.Drawing.Size(321, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabActualizacionPrecios)
        Me.MainPanel.Controls.Add(Me.FilterPanel)
        Me.MainPanel.Size = New System.Drawing.Size(764, 418)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(764, 418)
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.pnlArticulo)
        Me.FilterPanel.Controls.Add(Me.pnlObra)
        Me.FilterPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FilterPanel.Location = New System.Drawing.Point(0, 297)
        Me.FilterPanel.Name = "FilterPanel"
        Me.FilterPanel.Size = New System.Drawing.Size(764, 121)
        Me.FilterPanel.TabIndex = 22
        Me.FilterPanel.TabStop = False
        Me.FilterPanel.Text = " Criterios de Selección  "
        '
        'pnlArticulo
        '
        Me.pnlArticulo.Controls.Add(Me.lblFamilia)
        Me.pnlArticulo.Controls.Add(Me.AdvTipo)
        Me.pnlArticulo.Controls.Add(Me.AdvFamilia)
        Me.pnlArticulo.Controls.Add(Me.AdvArticulo)
        Me.pnlArticulo.Controls.Add(Me.lblArticulo)
        Me.pnlArticulo.Controls.Add(Me.lblTipo)
        Me.pnlArticulo.Location = New System.Drawing.Point(336, 16)
        Me.pnlArticulo.Name = "pnlArticulo"
        Me.pnlArticulo.Size = New System.Drawing.Size(216, 95)
        Me.pnlArticulo.TabIndex = 12
        '
        'lblFamilia
        '
        Me.lblFamilia.Location = New System.Drawing.Point(16, 70)
        Me.lblFamilia.Name = "lblFamilia"
        Me.lblFamilia.Size = New System.Drawing.Size(95, 13)
        Me.lblFamilia.TabIndex = 9
        Me.lblFamilia.Text = "Familia Material"
        '
        'AdvTipo
        '
        Me.AdvTipo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipo.EntityName = "TipoArticulo"
        Me.AdvTipo.Location = New System.Drawing.Point(120, 35)
        Me.AdvTipo.Name = "AdvTipo"
        Me.AdvTipo.SecondaryDataFields = "IDTipo"
        Me.AdvTipo.Size = New System.Drawing.Size(90, 23)
        Me.AdvTipo.TabIndex = 3
        '
        'AdvFamilia
        '
        Me.AdvFamilia.DisabledBackColor = System.Drawing.Color.White
        Me.AdvFamilia.EntityName = "Familia"
        Me.AdvFamilia.Location = New System.Drawing.Point(120, 65)
        Me.AdvFamilia.Name = "AdvFamilia"
        Me.AdvFamilia.SecondaryDataFields = "IDFamilia"
        Me.AdvFamilia.Size = New System.Drawing.Size(90, 23)
        Me.AdvFamilia.TabIndex = 4
        '
        'AdvArticulo
        '
        Me.AdvArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvArticulo.EntityName = "Articulo"
        Me.AdvArticulo.Location = New System.Drawing.Point(120, 4)
        Me.AdvArticulo.Name = "AdvArticulo"
        Me.AdvArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvArticulo.Size = New System.Drawing.Size(90, 23)
        Me.AdvArticulo.TabIndex = 2
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(16, 9)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(52, 13)
        Me.lblArticulo.TabIndex = 7
        Me.lblArticulo.Text = "Material"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(16, 40)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(80, 13)
        Me.lblTipo.TabIndex = 8
        Me.lblTipo.Text = "Tipo Material"
        '
        'pnlObra
        '
        Me.pnlObra.Controls.Add(Me.lblCliente)
        Me.pnlObra.Controls.Add(Me.AdvIDCliente)
        Me.pnlObra.Controls.Add(Me.lblIDPresup)
        Me.pnlObra.Controls.Add(Me.AdvIDPresup)
        Me.pnlObra.Controls.Add(Me.pnlTrabajo)
        Me.pnlObra.Location = New System.Drawing.Point(32, 16)
        Me.pnlObra.Name = "pnlObra"
        Me.pnlObra.Size = New System.Drawing.Size(208, 95)
        Me.pnlObra.TabIndex = 11
        '
        'lblIDPresup
        '
        Me.lblIDPresup.Location = New System.Drawing.Point(8, 9)
        Me.lblIDPresup.Name = "lblIDPresup"
        Me.lblIDPresup.Size = New System.Drawing.Size(77, 13)
        Me.lblIDPresup.TabIndex = 0
        Me.lblIDPresup.Text = "Presupuesto"
        '
        'AdvIDPresup
        '
        Me.AdvIDPresup.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDPresup.DisplayField = "NumPresup"
        Me.AdvIDPresup.EntityName = "ObraPresupCabecera"
        Me.AdvIDPresup.Location = New System.Drawing.Point(96, 4)
        Me.AdvIDPresup.Name = "AdvIDPresup"
        Me.AdvIDPresup.SecondaryDataFields = "IDPresup"
        Me.AdvIDPresup.Size = New System.Drawing.Size(90, 23)
        Me.AdvIDPresup.TabIndex = 0
        '
        'pnlTrabajo
        '
        Me.pnlTrabajo.Controls.Add(Me.lblIDTrabajo)
        Me.pnlTrabajo.Controls.Add(Me.AdvTrabajo)
        Me.pnlTrabajo.Location = New System.Drawing.Point(0, 30)
        Me.pnlTrabajo.Name = "pnlTrabajo"
        Me.pnlTrabajo.Size = New System.Drawing.Size(208, 32)
        Me.pnlTrabajo.TabIndex = 18
        '
        'lblIDTrabajo
        '
        Me.lblIDTrabajo.Location = New System.Drawing.Point(8, 9)
        Me.lblIDTrabajo.Name = "lblIDTrabajo"
        Me.lblIDTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblIDTrabajo.TabIndex = 3
        Me.lblIDTrabajo.Text = "Trabajo"
        '
        'AdvTrabajo
        '
        Me.AdvTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajo.DisplayField = "CodTrabajo"
        Me.AdvTrabajo.EntityName = "ObraTrabajoPresup"
        Me.AdvTrabajo.Location = New System.Drawing.Point(96, 4)
        Me.AdvTrabajo.Name = "AdvTrabajo"
        Me.AdvTrabajo.SecondaryDataFields = "IDTrabajoPresup"
        Me.AdvTrabajo.Size = New System.Drawing.Size(90, 23)
        Me.AdvTrabajo.TabIndex = 1
        '
        'TabActualizacionPrecios
        '
        Me.TabActualizacionPrecios.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabActualizacionPrecios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabActualizacionPrecios.Location = New System.Drawing.Point(0, 0)
        Me.TabActualizacionPrecios.Name = "TabActualizacionPrecios"
        Me.TabActualizacionPrecios.Size = New System.Drawing.Size(764, 297)
        Me.TabActualizacionPrecios.TabIndex = 23
        Me.TabActualizacionPrecios.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageTrabajos, Me.TabPageMateriales, Me.TabPageMOD, Me.TabPageCentros, Me.TabPageGastos, Me.TabPageVarios})
        Me.TabActualizacionPrecios.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right
        Me.TabActualizacionPrecios.Text = "Varios"
        Me.TabActualizacionPrecios.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical
        Me.TabActualizacionPrecios.UseThemes = True
        '
        'TabPageTrabajos
        '
        Me.TabPageTrabajos.Controls.Add(Me.GridTrabajos)
        Me.TabPageTrabajos.Key = "Trabajos"
        Me.TabPageTrabajos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageTrabajos.Name = "TabPageTrabajos"
        Me.TabPageTrabajos.Size = New System.Drawing.Size(741, 295)
        Me.TabPageTrabajos.TabStop = True
        Me.TabPageTrabajos.Text = "Trabajos"
        '
        'GridTrabajos
        '
        Me.GridTrabajos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridTrabajos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridTrabajos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridTrabajos_DesignTimeLayout.LayoutString = resources.GetString("GridTrabajos_DesignTimeLayout.LayoutString")
        Me.GridTrabajos.DesignTimeLayout = GridTrabajos_DesignTimeLayout
        Me.GridTrabajos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTrabajos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridTrabajos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTrabajos.EntityName = "ObraTrabajoPresup"
        Me.GridTrabajos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridTrabajos.FrozenColumns = 2
        Me.GridTrabajos.KeyField = "IDTrabajoPresup"
        Me.GridTrabajos.Location = New System.Drawing.Point(0, 0)
        Me.GridTrabajos.Name = "GridTrabajos"
        Me.GridTrabajos.PrimaryDataFields = Nothing
        Me.GridTrabajos.SecondaryDataFields = Nothing
        Me.GridTrabajos.Size = New System.Drawing.Size(741, 295)
        Me.GridTrabajos.TabIndex = 1
        Me.GridTrabajos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridTrabajos.UseCheck = True
        Me.GridTrabajos.ViewName = "vCTLCIActualizarPreciosPresupTrabajos"
        '
        'TabPageMateriales
        '
        Me.TabPageMateriales.Controls.Add(Me.GridMateriales)
        Me.TabPageMateriales.Key = "Materiales"
        Me.TabPageMateriales.Location = New System.Drawing.Point(1, 1)
        Me.TabPageMateriales.Name = "TabPageMateriales"
        Me.TabPageMateriales.Size = New System.Drawing.Size(741, 295)
        Me.TabPageMateriales.TabStop = True
        Me.TabPageMateriales.Text = "Materiales"
        Me.TabPageMateriales.Visible = False
        '
        'GridMateriales
        '
        Me.GridMateriales.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMateriales.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMateriales.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridMateriales_DesignTimeLayout.LayoutString = resources.GetString("GridMateriales_DesignTimeLayout.LayoutString")
        Me.GridMateriales.DesignTimeLayout = GridMateriales_DesignTimeLayout
        Me.GridMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMateriales.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMateriales.EntityName = "ObraPresupMaterial"
        Me.GridMateriales.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMateriales.FrozenColumns = 2
        Me.GridMateriales.KeyField = "IDLineaMaterial"
        Me.GridMateriales.Location = New System.Drawing.Point(0, 0)
        Me.GridMateriales.Name = "GridMateriales"
        Me.GridMateriales.PrimaryDataFields = Nothing
        Me.GridMateriales.SecondaryDataFields = Nothing
        Me.GridMateriales.Size = New System.Drawing.Size(741, 295)
        Me.GridMateriales.TabIndex = 0
        Me.GridMateriales.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridMateriales.UseCheck = True
        Me.GridMateriales.ViewName = "vCTLCIActualizarPreciosPresupMateriales"
        '
        'TabPageMOD
        '
        Me.TabPageMOD.Controls.Add(Me.GridMod)
        Me.TabPageMOD.Key = "MOD"
        Me.TabPageMOD.Location = New System.Drawing.Point(1, 1)
        Me.TabPageMOD.Name = "TabPageMOD"
        Me.TabPageMOD.Size = New System.Drawing.Size(741, 295)
        Me.TabPageMOD.TabStop = True
        Me.TabPageMOD.Text = "MOD"
        Me.TabPageMOD.Visible = False
        '
        'GridMod
        '
        Me.GridMod.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMod.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMod.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridMod_DesignTimeLayout.LayoutString = resources.GetString("GridMod_DesignTimeLayout.LayoutString")
        Me.GridMod.DesignTimeLayout = GridMod_DesignTimeLayout
        Me.GridMod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMod.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridMod.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMod.EntityName = "ObraPresupMOD"
        Me.GridMod.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMod.FrozenColumns = 2
        Me.GridMod.KeyField = "IDLineaMOD"
        Me.GridMod.Location = New System.Drawing.Point(0, 0)
        Me.GridMod.Name = "GridMod"
        Me.GridMod.PrimaryDataFields = Nothing
        Me.GridMod.SecondaryDataFields = Nothing
        Me.GridMod.Size = New System.Drawing.Size(741, 295)
        Me.GridMod.TabIndex = 31
        Me.GridMod.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridMod.UseCheck = True
        Me.GridMod.ViewName = "vCTLCIActualizarPreciosPresupMOD"
        '
        'TabPageCentros
        '
        Me.TabPageCentros.Controls.Add(Me.GridCentros)
        Me.TabPageCentros.Key = "Centros"
        Me.TabPageCentros.Location = New System.Drawing.Point(1, 1)
        Me.TabPageCentros.Name = "TabPageCentros"
        Me.TabPageCentros.Size = New System.Drawing.Size(741, 259)
        Me.TabPageCentros.TabStop = True
        Me.TabPageCentros.Text = "Centros"
        Me.TabPageCentros.Visible = False
        '
        'GridCentros
        '
        Me.GridCentros.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCentros.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCentros.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridCentros_DesignTimeLayout.LayoutString = resources.GetString("GridCentros_DesignTimeLayout.LayoutString")
        Me.GridCentros.DesignTimeLayout = GridCentros_DesignTimeLayout
        Me.GridCentros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCentros.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCentros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCentros.EntityName = "ObraPresupCentro"
        Me.GridCentros.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCentros.FrozenColumns = 2
        Me.GridCentros.KeyField = "IDLineaCentro"
        Me.GridCentros.Location = New System.Drawing.Point(0, 0)
        Me.GridCentros.Name = "GridCentros"
        Me.GridCentros.PrimaryDataFields = Nothing
        Me.GridCentros.SecondaryDataFields = Nothing
        Me.GridCentros.Size = New System.Drawing.Size(741, 259)
        Me.GridCentros.TabIndex = 32
        Me.GridCentros.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCentros.UseCheck = True
        Me.GridCentros.ViewName = "vCTLCIActualizarPreciosPresupCentros"
        '
        'TabPageGastos
        '
        Me.TabPageGastos.Controls.Add(Me.GridGastos)
        Me.TabPageGastos.Key = "Gastos"
        Me.TabPageGastos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageGastos.Name = "TabPageGastos"
        Me.TabPageGastos.Size = New System.Drawing.Size(741, 259)
        Me.TabPageGastos.TabStop = True
        Me.TabPageGastos.Text = "Gastos"
        Me.TabPageGastos.Visible = False
        '
        'GridGastos
        '
        Me.GridGastos.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridGastos.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridGastos.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridGastos_DesignTimeLayout.LayoutString = resources.GetString("GridGastos_DesignTimeLayout.LayoutString")
        Me.GridGastos.DesignTimeLayout = GridGastos_DesignTimeLayout
        Me.GridGastos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGastos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridGastos.EntityName = "ObraPresupGasto"
        Me.GridGastos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridGastos.FrozenColumns = 2
        Me.GridGastos.KeyField = "IDLineaGasto"
        Me.GridGastos.Location = New System.Drawing.Point(0, 0)
        Me.GridGastos.Name = "GridGastos"
        Me.GridGastos.PrimaryDataFields = Nothing
        Me.GridGastos.SecondaryDataFields = Nothing
        Me.GridGastos.Size = New System.Drawing.Size(741, 259)
        Me.GridGastos.TabIndex = 2
        Me.GridGastos.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridGastos.UseCheck = True
        Me.GridGastos.ViewName = "vCTLCIActualizarPreciosPresupGastos"
        '
        'TabPageVarios
        '
        Me.TabPageVarios.Controls.Add(Me.GridVarios)
        Me.TabPageVarios.Key = "Varios"
        Me.TabPageVarios.Location = New System.Drawing.Point(1, 1)
        Me.TabPageVarios.Name = "TabPageVarios"
        Me.TabPageVarios.Size = New System.Drawing.Size(741, 295)
        Me.TabPageVarios.TabStop = True
        Me.TabPageVarios.Text = "Varios"
        Me.TabPageVarios.Visible = False
        '
        'GridVarios
        '
        Me.GridVarios.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridVarios.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridVarios.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridVarios_DesignTimeLayout.LayoutString = resources.GetString("GridVarios_DesignTimeLayout.LayoutString")
        Me.GridVarios.DesignTimeLayout = GridVarios_DesignTimeLayout
        Me.GridVarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVarios.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridVarios.EntityName = "ObraPresupVarios"
        Me.GridVarios.FrozenColumns = 2
        Me.GridVarios.KeyField = "IDLineaVarios"
        Me.GridVarios.Location = New System.Drawing.Point(0, 0)
        Me.GridVarios.Name = "GridVarios"
        Me.GridVarios.PrimaryDataFields = Nothing
        Me.GridVarios.SecondaryDataFields = Nothing
        Me.GridVarios.Size = New System.Drawing.Size(741, 295)
        Me.GridVarios.TabIndex = 34
        Me.GridVarios.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridVarios.UseCheck = True
        Me.GridVarios.ViewName = "vCTLCIActualizarPreciosPresupVarios"
        '
        'ShowFilterCriteria
        '
        Me.ShowFilterCriteria.Icon = CType(resources.GetObject("ShowFilterCriteria.Icon"), System.Drawing.Icon)
        Me.ShowFilterCriteria.Key = "ShowFilterCriteria"
        Me.ShowFilterCriteria.Name = "ShowFilterCriteria"
        Me.ShowFilterCriteria.Text = "Ver Criterios"
        '
        'ShowFilterCriteria1
        '
        Me.ShowFilterCriteria1.Key = "ShowFilterCriteria"
        Me.ShowFilterCriteria1.Name = "ShowFilterCriteria1"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(8, 70)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 20
        Me.lblCliente.Text = "Cliente"
        '
        'AdvIDCliente
        '
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.DisplayField = "IDCliente"
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(96, 65)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(90, 23)
        Me.AdvIDCliente.TabIndex = 19
        '
        'CIActualizarPreciosPresup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(772, 506)
        Me.EntityName = "ObraTrabajoPresup"
        Me.Name = "CIActualizarPreciosPresup"
        Me.ViewName = "tbObraTrabajoPresup"
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.FilterPanel.ResumeLayout(False)
        Me.pnlArticulo.ResumeLayout(False)
        Me.pnlArticulo.PerformLayout()
        Me.pnlObra.ResumeLayout(False)
        Me.pnlObra.PerformLayout()
        Me.pnlTrabajo.ResumeLayout(False)
        Me.pnlTrabajo.PerformLayout()
        CType(Me.TabActualizacionPrecios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabActualizacionPrecios.ResumeLayout(False)
        Me.TabPageTrabajos.ResumeLayout(False)
        CType(Me.GridTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMateriales.ResumeLayout(False)
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageMOD.ResumeLayout(False)
        CType(Me.GridMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCentros.ResumeLayout(False)
        CType(Me.GridCentros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageGastos.ResumeLayout(False)
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageVarios.ResumeLayout(False)
        CType(Me.GridVarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region " Load "

    Private Sub CIActualizarPreciosPresup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadToolbarActions()
            LoadGridActions()
        End If
    End Sub

    Private Sub LoadToolbarActions()
        Me.FormActions.Add("Actualizar Precios", AddressOf AccionActualizarPrecios, ExpertisApp.GetIcon("calculator.ico"))
        Me.FormActions.Add("Crear Conceptos no existentes", AddressOf AccionCrearElementos, ExpertisApp.GetIcon("gear_add.ico"))
    End Sub

    Private Sub LoadGridActions()
        Me.GridTrabajos.Actions.Add("Abrir Presupuesto", AddressOf LoadPresupuesto, ExpertisApp.GetIcon("xPresupuestos.ico"))
        Me.GridTrabajos.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))

        Me.GridMateriales.Actions.Add("Abrir Presupuesto", AddressOf LoadPresupuesto, ExpertisApp.GetIcon("xPresupuestos.ico"))
        Me.GridMateriales.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))

        Me.GridMod.Actions.Add("Abrir Presupuesto", AddressOf LoadPresupuesto, ExpertisApp.GetIcon("xPresupuestos.ico"))
        Me.GridMod.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))

        Me.GridCentros.Actions.Add("Abrir Presupuesto", AddressOf LoadPresupuesto, ExpertisApp.GetIcon("xPresupuestos.ico"))
        Me.GridCentros.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))

        Me.GridGastos.Actions.Add("Abrir Presupuesto", AddressOf LoadPresupuesto, ExpertisApp.GetIcon("xPresupuestos.ico"))
        Me.GridGastos.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))

        Me.GridVarios.Actions.Add("Abrir Presupuesto", AddressOf LoadPresupuesto, ExpertisApp.GetIcon("xPresupuestos.ico"))
        Me.GridVarios.Actions.Add("Abrir Cliente", AddressOf AccionAbrirCliente, ExpertisApp.GetIcon("xClientes.ico"))
    End Sub

#End Region

#Region " Acciones Toolbar "

    Private Sub AccionActualizarPrecios()
        Dim dtMarcados As DataTable = Me.CheckedRecords
        If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
            Dim infoActualizacionPrecios As ActualizarPrecios.datosActualizacionPrecios
            Dim Campo As String = String.Empty
            Select Case TabActualizacionPrecios.SelectedTab.Key
                Case "Materiales"
                    Campo = "IDLineaMaterial"
                    Dim frm As New frmActualizarPreciosEspecifico
                    infoActualizacionPrecios = frm.AbrirActualizarPrecios()
                Case Else
                    If TabActualizacionPrecios.SelectedTab.Key = "Trabajos" Then
                        Campo = "IDTrabajoPresup"
                    ElseIf TabActualizacionPrecios.SelectedTab.Key = "MOD" Then
                        Campo = "IDLineaMOD"
                    ElseIf TabActualizacionPrecios.SelectedTab.Key = "Centros" Then
                        Campo = "IDLineaCentro"
                    ElseIf TabActualizacionPrecios.SelectedTab.Key = "Gastos" Then
                        Campo = "IDLineaGasto"
                    ElseIf TabActualizacionPrecios.SelectedTab.Key = "Varios" Then
                        Campo = "IDLineaVarios"
                    End If

                    Dim frm As New frmActualizarPreciosGeneral
                    infoActualizacionPrecios = frm.AbrirActualizarPrecios()
            End Select
            If Length(Campo) > 0 Then
                If Not infoActualizacionPrecios Is Nothing Then
                    Dim ID(-1) As Object
                    For Each dr As DataRow In dtMarcados.Rows
                        ReDim Preserve ID(UBound(ID) + 1)
                        ID(UBound(ID)) = dr(Campo)
                    Next
                    infoActualizacionPrecios.IDRegistrosActualizacion = ID
                    infoActualizacionPrecios.EntityName = dtMarcados.TableName
                    ExpertisApp.ExecuteTask(Of ActualizarPrecios.datosActualizacionPrecios)(AddressOf ActualizarPrecios.ActualizaPrecios, infoActualizacionPrecios)

                    ExpertisApp.GenerateMessage("Proceso finalizado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.UnCheckAllRecords()
                    Me.Execute()
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overridable Sub AccionCrearElementos()
        If TabActualizacionPrecios.SelectedTab.Key = "Materiales" Or TabActualizacionPrecios.SelectedTab.Key = "MOD" Or TabActualizacionPrecios.SelectedTab.Key = "Centros" Then
            Dim dtMarcados As DataTable = Me.CheckedRecords
            If Not dtMarcados Is Nothing AndAlso dtMarcados.Rows.Count > 0 Then
                If ExpertisApp.GenerateMessage("Se generarán los {0} seleccionados que no existan.{1}¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, TabActualizacionPrecios.SelectedTab.Key, vbNewLine) = DialogResult.Yes Then
                    Select Case TabActualizacionPrecios.SelectedTab.Key
                        Case "Materiales"
                            ExpertisApp.ExecuteTask(Of DataTable)(AddressOf ObraMaterial.GenerarMaterialesNoExistentes, dtMarcados)
                        Case "MOD"
                            ExpertisApp.ExecuteTask(Of DataTable)(AddressOf ObraMOD.GenerarCategoriasNoExistentes, dtMarcados)
                        Case "Centros"
                            ExpertisApp.ExecuteTask(Of DataTable)(AddressOf ObraCentro.GenerarCentrosNoExistentes, dtMarcados)
                    End Select

                    Me.UnCheckAllRecords()
                    Me.Execute()
                End If
            Else
                ExpertisApp.GenerateMessage("Debe seleccionar alguna fila.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

#End Region

#Region " Grid Actions "

    Private Sub LoadPresupuesto()
        If ExpertisApp.IsFormOpen("MGEPRE") Then ExpertisApp.CloseForm("MGEPRE")
        ExpertisApp.OpenForm("MGEPRE", New NumberFilterItem("IDPresup", GridActivo().GetValue("IDPresup")))
    End Sub
    Private Sub AccionAbrirCliente()
        If ExpertisApp.IsFormOpen("MCLIENTE") Then ExpertisApp.CloseForm("MCLIENTE")
        ExpertisApp.OpenForm("MCLIENTE", New FilterItem("IDCliente", GridActivo().GetValue("IDCliente")))
    End Sub
#End Region

#Region " QueryExecuting "

    Private Sub CIActualizarPreciosPresup_QueryExecuting(ByVal sender As Object, ByRef e As Engine.UI.QueryExecutingEventArgs) Handles MyBase.QueryExecuting
        If IsNothing(Me.CIPrimaryObject) Then
            Me.SetCIPrimaryObject(GridActivo(), False)
        End If
        e.Filter.Add("IDPresup", FilterOperator.Equal, AdvIDPresup.Value, FilterType.Numeric)
        e.Filter.Add("IDCliente", FilterOperator.Equal, AdvIDCliente.Value, FilterType.String)
        Select Case TabActualizacionPrecios.SelectedTab.Key
            Case "Trabajos", "Mod", "Centros", "Gastos", "Varios"
                e.Filter.Add("IDTrabajoPresup", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
            Case "Materiales"
                e.Filter.Add("IDTrabajoPresup", FilterOperator.Equal, AdvTrabajo.Value, FilterType.Numeric)
                e.Filter.Add("IDMaterial", FilterOperator.Equal, AdvArticulo.Text, FilterType.String)
                e.Filter.Add("IDTipo", FilterOperator.Equal, AdvTipo.Text, FilterType.String)
                e.Filter.Add("IDFamilia", FilterOperator.Equal, AdvFamilia.Text, FilterType.String)
        End Select
    End Sub

    Private Sub CIActualizarPreciosPresup_FilterClearing(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.FilterClearing
        If pnlObra.Visible Then
            AdvIDPresup.TextBox.Clear() : AdvIDPresup.Value = Nothing
            If pnlTrabajo.Visible Then
                AdvTrabajo.TextBox.Clear() : AdvTrabajo.Value = Nothing
            End If
            AdvIDCliente.TextBox.Clear() : AdvIDCliente.Value = Nothing
        End If
        If pnlArticulo.Visible Then
            AdvArticulo.TextBox.Clear() : AdvArticulo.Value = Nothing
            AdvTipo.TextBox.Clear() : AdvTipo.Value = Nothing
            AdvFamilia.TextBox.Clear() : AdvFamilia.Value = Nothing
        End If
    End Sub

#End Region

    Private Sub AdvTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvTrabajo.SetPredefinedFilter
        If Length(AdvIDPresup.Value) > 0 Then
            e.Filter.Add("IDPresup", FilterOperator.Equal, AdvIDPresup.Value, FilterType.Numeric)
        End If
    End Sub

    Private Sub AdvFamilia_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvFamilia.SetPredefinedFilter
        If Length(AdvTipo.Text) > 0 Then
            e.Filter.Add("IDTipo", FilterOperator.Equal, AdvTipo.Text, FilterType.String)
        End If
    End Sub

#Region " Tab "

    Private Sub TabActualizacionPrecios_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles TabActualizacionPrecios.SelectedTabChanged
        pnlObra.Visible = True
        pnlTrabajo.Visible = True
        Dim TextoExecuteAction As String = String.Empty
        Select Case e.Page.Key
            Case "Materiales"
                pnlArticulo.Visible = True
                TextoExecuteAction = "Crear Materiales no existentes"
            Case "MOD", "Centros"
                pnlArticulo.Visible = False
                If e.Page.Key = "MOD" Then
                    TextoExecuteAction = "Crear Categorías no existentes"
                Else
                    TextoExecuteAction = "Crear Centros no existentes"
                End If
            Case Else
                pnlArticulo.Visible = False
        End Select
        If Me.ExecuteActions.Commands.Count > 0 Then
            If Length(TextoExecuteAction) > 0 Then
                Me.ExecuteActions.Commands(1).Visible = Janus.Windows.UI.InheritableBoolean.True
                Me.ExecuteActions.Commands(1).Text = TextoExecuteAction
            Else
                Me.ExecuteActions.Commands(1).Visible = Janus.Windows.UI.InheritableBoolean.False
            End If
        End If
    End Sub

    Private Sub TabActualizacionPrecios_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabActualizacionPrecios.Click
        If Not Me.CIPrimaryObject Is Nothing Then Me.UnCheckAllRecords()
        Me.SetCIPrimaryObject(GridActivo(), True)
    End Sub

#End Region

    Private Function GridActivo() As Solmicro.Expertis.Engine.UI.Grid
        Select Case TabActualizacionPrecios.SelectedTab.Key
            Case "Trabajos"
                Return GridTrabajos
            Case "Materiales"
                Return GridMateriales
            Case "MOD"
                Return GridMod
            Case "Centros"
                Return GridCentros
            Case "Gastos"
                Return GridGastos
            Case "Varios"
                Return GridVarios
        End Select
    End Function

    Private Sub ShowFilterCriteria1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles ShowFilterCriteria1.Click
        FilterPanel.Visible = Not FilterPanel.Visible
    End Sub

End Class
