Public Class frmConverArticulos
    Inherits Solmicro.Expertis.Engine.UI.FormBase

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
    Friend WithEvents TabArticulos As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents UITbMateriales As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UITbMOD As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UITbCentros As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents GridMateriales As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridMOD As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridCentros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents FrmDatosPresup As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FrmDatosArticulos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents PnlButtons2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents BtnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents LblNumPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LvlRevPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblDescPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TxtNumPresup As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents TxtRevision As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents TxtDescPresup As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents BtnSelTodos As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnDesSelTodos As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnSelPest As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents BtnDesSelPest As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents ImgList As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConverArticulos))
        Dim GridMateriales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMOD_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCentros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.FrmDatosPresup = New Solmicro.Expertis.Engine.UI.Frame
        Me.TxtDescPresup = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TxtRevision = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TxtNumPresup = New Solmicro.Expertis.Engine.UI.TextBox
        Me.LblDescPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.LvlRevPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.LblNumPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.FrmDatosArticulos = New Solmicro.Expertis.Engine.UI.Frame
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnSelTodos = New Solmicro.Expertis.Engine.UI.Button
        Me.ImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.BtnDesSelTodos = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnSelPest = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnDesSelPest = New Solmicro.Expertis.Engine.UI.Button
        Me.TabArticulos = New Solmicro.Expertis.Engine.UI.Tab
        Me.UITbMateriales = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMateriales = New Solmicro.Expertis.Engine.UI.Grid
        Me.UITbMOD = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMOD = New Solmicro.Expertis.Engine.UI.Grid
        Me.UITbCentros = New Janus.Windows.UI.Tab.UITabPage
        Me.GridCentros = New Solmicro.Expertis.Engine.UI.Grid
        Me.PnlButtons2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.BtnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.BtnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.FrmDatosPresup.SuspendLayout()
        Me.FrmDatosArticulos.SuspendLayout()
        Me.Panel1.suspendlayout()
        CType(Me.TabArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabArticulos.SuspendLayout()
        Me.UITbMateriales.SuspendLayout()
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UITbMOD.SuspendLayout()
        CType(Me.GridMOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UITbCentros.SuspendLayout()
        CType(Me.GridCentros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlButtons2.suspendlayout()
        Me.SuspendLayout()
        '
        'FrmDatosPresup
        '
        Me.FrmDatosPresup.Controls.Add(Me.TxtDescPresup)
        Me.FrmDatosPresup.Controls.Add(Me.TxtRevision)
        Me.FrmDatosPresup.Controls.Add(Me.TxtNumPresup)
        Me.FrmDatosPresup.Controls.Add(Me.LblDescPresup)
        Me.FrmDatosPresup.Controls.Add(Me.LvlRevPresup)
        Me.FrmDatosPresup.Controls.Add(Me.LblNumPresup)
        Me.FrmDatosPresup.Dock = System.Windows.Forms.DockStyle.Top
        Me.FrmDatosPresup.Location = New System.Drawing.Point(0, 0)
        Me.FrmDatosPresup.Name = "FrmDatosPresup"
        Me.FrmDatosPresup.Size = New System.Drawing.Size(674, 48)
        Me.FrmDatosPresup.TabIndex = 0
        Me.FrmDatosPresup.TabStop = False
        Me.FrmDatosPresup.Text = "Datos Presupuesto"
        '
        'TxtDescPresup
        '
        Me.TxtDescPresup.DisabledBackColor = System.Drawing.Color.White
        Me.TxtDescPresup.Enabled = False
        Me.TxtDescPresup.Location = New System.Drawing.Point(368, 16)
        Me.TxtDescPresup.Name = "TxtDescPresup"
        Me.TxtDescPresup.Size = New System.Drawing.Size(296, 21)
        Me.TxtDescPresup.TabIndex = 5
        '
        'TxtRevision
        '
        Me.TxtRevision.DisabledBackColor = System.Drawing.Color.White
        Me.TxtRevision.Enabled = False
        Me.TxtRevision.Location = New System.Drawing.Point(240, 16)
        Me.TxtRevision.Name = "TxtRevision"
        Me.TxtRevision.Size = New System.Drawing.Size(32, 21)
        Me.TxtRevision.TabIndex = 4
        '
        'TxtNumPresup
        '
        Me.TxtNumPresup.DisabledBackColor = System.Drawing.Color.White
        Me.TxtNumPresup.Enabled = False
        Me.TxtNumPresup.Location = New System.Drawing.Point(96, 16)
        Me.TxtNumPresup.Name = "TxtNumPresup"
        Me.TxtNumPresup.Size = New System.Drawing.Size(96, 21)
        Me.TxtNumPresup.TabIndex = 3
        '
        'LblDescPresup
        '
        Me.LblDescPresup.Location = New System.Drawing.Point(280, 16)
        Me.LblDescPresup.Name = "LblDescPresup"
        Me.LblDescPresup.Size = New System.Drawing.Size(82, 13)
        Me.LblDescPresup.TabIndex = 2
        Me.LblDescPresup.Text = "Desc. Presup"
        Me.LblDescPresup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LvlRevPresup
        '
        Me.LvlRevPresup.Location = New System.Drawing.Point(200, 16)
        Me.LvlRevPresup.Name = "LvlRevPresup"
        Me.LvlRevPresup.Size = New System.Drawing.Size(33, 13)
        Me.LvlRevPresup.TabIndex = 1
        Me.LvlRevPresup.Text = "Rev."
        Me.LvlRevPresup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNumPresup
        '
        Me.LblNumPresup.Location = New System.Drawing.Point(8, 16)
        Me.LblNumPresup.Name = "LblNumPresup"
        Me.LblNumPresup.Size = New System.Drawing.Size(80, 13)
        Me.LblNumPresup.TabIndex = 0
        Me.LblNumPresup.Text = "Num. Presup"
        Me.LblNumPresup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmDatosArticulos
        '
        Me.FrmDatosArticulos.Controls.Add(Me.Panel1)
        Me.FrmDatosArticulos.Controls.Add(Me.TabArticulos)
        Me.FrmDatosArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmDatosArticulos.Location = New System.Drawing.Point(0, 48)
        Me.FrmDatosArticulos.Name = "FrmDatosArticulos"
        Me.FrmDatosArticulos.Size = New System.Drawing.Size(674, 375)
        Me.FrmDatosArticulos.TabIndex = 1
        Me.FrmDatosArticulos.TabStop = False
        Me.FrmDatosArticulos.Text = "Seleccione los materiales no existentes que desea generar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSelTodos)
        Me.Panel1.Controls.Add(Me.BtnDesSelTodos)
        Me.Panel1.Controls.Add(Me.BtnSelPest)
        Me.Panel1.Controls.Add(Me.BtnDesSelPest)
        Me.Panel1.Location = New System.Drawing.Point(504, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(168, 24)
        Me.Panel1.TabIndex = 1
        '
        'BtnSelTodos
        '
        Me.BtnSelTodos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.BtnSelTodos.ImageIndex = 0
        Me.BtnSelTodos.ImageList = Me.ImgList
        Me.BtnSelTodos.Location = New System.Drawing.Point(7, 1)
        Me.BtnSelTodos.Name = "BtnSelTodos"
        Me.BtnSelTodos.Size = New System.Drawing.Size(25, 21)
        Me.BtnSelTodos.TabIndex = 2
        Me.BtnSelTodos.ToolTipText = "Marcar todos los registros de todas las pestañas"
        '
        'ImgList
        '
        Me.ImgList.ImageStream = CType(resources.GetObject("ImgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgList.Images.SetKeyName(0, "")
        Me.ImgList.Images.SetKeyName(1, "")
        Me.ImgList.Images.SetKeyName(2, "")
        Me.ImgList.Images.SetKeyName(3, "")
        Me.ImgList.Images.SetKeyName(4, "")
        Me.ImgList.Images.SetKeyName(5, "")
        '
        'BtnDesSelTodos
        '
        Me.BtnDesSelTodos.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.BtnDesSelTodos.ImageIndex = 1
        Me.BtnDesSelTodos.ImageList = Me.ImgList
        Me.BtnDesSelTodos.Location = New System.Drawing.Point(40, 1)
        Me.BtnDesSelTodos.Name = "BtnDesSelTodos"
        Me.BtnDesSelTodos.Size = New System.Drawing.Size(25, 21)
        Me.BtnDesSelTodos.TabIndex = 3
        Me.BtnDesSelTodos.ToolTipText = "Desmarcar todos los registros de todas las pestañas"
        '
        'BtnSelPest
        '
        Me.BtnSelPest.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.BtnSelPest.ImageIndex = 4
        Me.BtnSelPest.ImageList = Me.ImgList
        Me.BtnSelPest.Location = New System.Drawing.Point(103, 1)
        Me.BtnSelPest.Name = "BtnSelPest"
        Me.BtnSelPest.Size = New System.Drawing.Size(25, 21)
        Me.BtnSelPest.TabIndex = 0
        '
        'BtnDesSelPest
        '
        Me.BtnDesSelPest.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.BtnDesSelPest.ImageIndex = 5
        Me.BtnDesSelPest.ImageList = Me.ImgList
        Me.BtnDesSelPest.Location = New System.Drawing.Point(137, 1)
        Me.BtnDesSelPest.Name = "BtnDesSelPest"
        Me.BtnDesSelPest.Size = New System.Drawing.Size(25, 21)
        Me.BtnDesSelPest.TabIndex = 1
        '
        'TabArticulos
        '
        Me.TabArticulos.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabArticulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabArticulos.Location = New System.Drawing.Point(3, 17)
        Me.TabArticulos.Name = "TabArticulos"
        Me.TabArticulos.Size = New System.Drawing.Size(668, 355)
        Me.TabArticulos.TabIndex = 0
        Me.TabArticulos.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UITbMateriales, Me.UITbMOD, Me.UITbCentros})
        Me.TabArticulos.UseThemes = True
        '
        'UITbMateriales
        '
        Me.UITbMateriales.Controls.Add(Me.GridMateriales)
        Me.UITbMateriales.Key = "UITbMateriales"
        Me.UITbMateriales.Location = New System.Drawing.Point(1, 21)
        Me.UITbMateriales.Name = "UITbMateriales"
        Me.UITbMateriales.Size = New System.Drawing.Size(666, 333)
        Me.UITbMateriales.TabStop = True
        Me.UITbMateriales.Text = "Materiales"
        '
        'GridMateriales
        '
        Me.GridMateriales.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMateriales.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridMateriales_DesignTimeLayout.LayoutString = resources.GetString("GridMateriales_DesignTimeLayout.LayoutString")
        Me.GridMateriales.DesignTimeLayout = GridMateriales_DesignTimeLayout
        Me.GridMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMateriales.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMateriales.EntityName = "ObraPresupMaterial"
        Me.GridMateriales.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMateriales.KeyField = "IDLineaMaterial"
        Me.GridMateriales.Location = New System.Drawing.Point(0, 0)
        Me.GridMateriales.Name = "GridMateriales"
        Me.GridMateriales.PrimaryDataFields = Nothing
        Me.GridMateriales.RequeryManually = True
        Me.GridMateriales.SecondaryDataFields = Nothing
        Me.GridMateriales.Size = New System.Drawing.Size(666, 333)
        Me.GridMateriales.TabIndex = 0
        Me.GridMateriales.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridMateriales.UseCheck = True
        Me.GridMateriales.ViewName = "vFrmObraPresupMateriales"
        '
        'UITbMOD
        '
        Me.UITbMOD.Controls.Add(Me.GridMOD)
        Me.UITbMOD.Key = "UITbMOD"
        Me.UITbMOD.Location = New System.Drawing.Point(1, 21)
        Me.UITbMOD.Name = "UITbMOD"
        Me.UITbMOD.Size = New System.Drawing.Size(666, 333)
        Me.UITbMOD.TabStop = True
        Me.UITbMOD.Text = "M.O.D."
        '
        'GridMOD
        '
        Me.GridMOD.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridMOD.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridMOD_DesignTimeLayout.LayoutString = resources.GetString("GridMOD_DesignTimeLayout.LayoutString")
        Me.GridMOD.DesignTimeLayout = GridMOD_DesignTimeLayout
        Me.GridMOD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMOD.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridMOD.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMOD.EntityName = "ObraPresupMOD"
        Me.GridMOD.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridMOD.KeyField = "IDLineaMod"
        Me.GridMOD.Location = New System.Drawing.Point(0, 0)
        Me.GridMOD.Name = "GridMOD"
        Me.GridMOD.PrimaryDataFields = Nothing
        Me.GridMOD.RequeryManually = True
        Me.GridMOD.SecondaryDataFields = Nothing
        Me.GridMOD.Size = New System.Drawing.Size(666, 333)
        Me.GridMOD.TabIndex = 1
        Me.GridMOD.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridMOD.UseCheck = True
        Me.GridMOD.ViewName = "VFrmObraPresupMOD"
        '
        'UITbCentros
        '
        Me.UITbCentros.Controls.Add(Me.GridCentros)
        Me.UITbCentros.Key = "UITbCentros"
        Me.UITbCentros.Location = New System.Drawing.Point(1, 21)
        Me.UITbCentros.Name = "UITbCentros"
        Me.UITbCentros.Size = New System.Drawing.Size(666, 333)
        Me.UITbCentros.TabStop = True
        Me.UITbCentros.Text = "Centros"
        '
        'GridCentros
        '
        Me.GridCentros.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridCentros.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridCentros_DesignTimeLayout.LayoutString = resources.GetString("GridCentros_DesignTimeLayout.LayoutString")
        Me.GridCentros.DesignTimeLayout = GridCentros_DesignTimeLayout
        Me.GridCentros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCentros.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCentros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCentros.EntityName = "ObraPresupCentro"
        Me.GridCentros.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridCentros.KeyField = "IDLineaCentro"
        Me.GridCentros.Location = New System.Drawing.Point(0, 0)
        Me.GridCentros.Name = "GridCentros"
        Me.GridCentros.PrimaryDataFields = Nothing
        Me.GridCentros.RequeryManually = True
        Me.GridCentros.SecondaryDataFields = Nothing
        Me.GridCentros.Size = New System.Drawing.Size(666, 333)
        Me.GridCentros.TabIndex = 1
        Me.GridCentros.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.GridCentros.UseCheck = True
        Me.GridCentros.ViewName = "VFrmObraPresupCentro"
        '
        'PnlButtons2
        '
        Me.PnlButtons2.Controls.Add(Me.BtnCancelar)
        Me.PnlButtons2.Controls.Add(Me.BtnAceptar)
        Me.PnlButtons2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons2.Location = New System.Drawing.Point(0, 423)
        Me.PnlButtons2.Name = "PnlButtons2"
        Me.PnlButtons2.Size = New System.Drawing.Size(674, 48)
        Me.PnlButtons2.TabIndex = 2
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.BtnCancelar.Location = New System.Drawing.Point(345, 8)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(96, 32)
        Me.BtnCancelar.TabIndex = 1
        Me.BtnCancelar.Text = "&Cancelar"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Near
        Me.BtnAceptar.Location = New System.Drawing.Point(233, 8)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(96, 32)
        Me.BtnAceptar.TabIndex = 0
        Me.BtnAceptar.Text = "&Aceptar"
        '
        'frmConverArticulos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(674, 471)
        Me.Controls.Add(Me.FrmDatosArticulos)
        Me.Controls.Add(Me.PnlButtons2)
        Me.Controls.Add(Me.FrmDatosPresup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConverArticulos"
        Me.NavigationFields = ""
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convertir y Crear Conceptos Nuevos"
        Me.FrmDatosPresup.ResumeLayout(False)
        Me.FrmDatosPresup.PerformLayout()
        Me.FrmDatosArticulos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.TabArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabArticulos.ResumeLayout(False)
        Me.UITbMateriales.ResumeLayout(False)
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UITbMOD.ResumeLayout(False)
        CType(Me.GridMOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UITbCentros.ResumeLayout(False)
        CType(Me.GridCentros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlButtons2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Estructuras Públicas"

    Dim StConver As New ObraPresupCabecera.datosConceptosNoExistentes

#End Region

#Region "Funciones Publicas / Privadas"

    Public Function LoadConverArticulos(ByRef data As ObraPresupCabecera.datosConceptosNoExistentes) As DialogResult
        StConver = data
        TxtNumPresup.Text = StConver.NumPresup
        TxtRevision.Text = StConver.RevPresup
        TxtDescPresup.Text = StConver.DescPresup
        If Not data.MaterialesNoExistentes Is Nothing AndAlso data.MaterialesNoExistentes.Length > 0 Then
            Dim FilMat As New Filter
            FilMat.Add("IDPresup", FilterOperator.Equal, StConver.IDPresup, FilterType.Numeric)
            FilMat.Add(New InListFilterItem("IDLineaMaterial", StConver.MaterialesNoExistentes, FilterType.Numeric))
            FilMat.Add(New IsNullFilterItem("IDMaterial", False))
            FilMat.Add(New BooleanFilterItem("TipoIncremento", False))
            GridMateriales.ReQuery(FilMat)
        End If
        If Not data.ModNoExistentes Is Nothing AndAlso data.ModNoExistentes.Length > 0 Then
            Dim FilMOD As New Filter
            FilMOD.Add("IDPresup", FilterOperator.Equal, StConver.IDPresup, FilterType.Numeric)
            FilMOD.Add(New InListFilterItem("IDLineaMOD", StConver.ModNoExistentes, FilterType.Numeric))
            FilMOD.Add(New IsNullFilterItem("IDCategoria", False))
            FilMOD.Add(New BooleanFilterItem("TipoIncremento", False))
            GridMOD.ReQuery(FilMOD)
        End If
        If Not data.CentrosNoExistentes Is Nothing AndAlso data.CentrosNoExistentes.Length > 0 Then
            Dim FilCentro As New Filter
            FilCentro.Add("IDPresup", FilterOperator.Equal, StConver.IDPresup, FilterType.Numeric)
            FilCentro.Add(New InListFilterItem("IDLineaCentro", StConver.CentrosNoExistentes, FilterType.Numeric))
            FilCentro.Add(New IsNullFilterItem("IDCentro", False))
            FilCentro.Add(New BooleanFilterItem("TipoIncremento", False))
            GridCentros.ReQuery(FilCentro)
        End If
        Me.ShowDialog()
        data = StConver
        Return Me.DialogResult
    End Function

    Private Sub MarcarDesmarcarTodos(ByVal BlnMarcar As Boolean)
        If BlnMarcar Then
            If Not GridMateriales.DataSource Is Nothing Then GridMateriales.CheckAllRecords()
            If Not GridMOD.DataSource Is Nothing Then GridMOD.CheckAllRecords()
            If Not GridCentros.DataSource Is Nothing Then GridCentros.CheckAllRecords()
        Else
            If Not GridMateriales.DataSource Is Nothing Then GridMateriales.UnCheckAllRecords()
            If Not GridMOD.DataSource Is Nothing Then GridMOD.UnCheckAllRecords()
            If Not GridCentros.DataSource Is Nothing Then GridCentros.UnCheckAllRecords()
        End If
    End Sub

    Private Sub MarcarDesmarcarRegistros(ByVal BlnMarcar As Boolean)
        Select Case TabArticulos.SelectedTab.Key
            Case "UITbMateriales"
                If Not GridMateriales.DataSource Is Nothing AndAlso GridMateriales.RowCount > 0 Then
                    If BlnMarcar Then
                        GridMateriales.CheckAllRecords()
                    Else
                        GridMateriales.UnCheckAllRecords()
                    End If
                End If
            Case "UITbMOD"
                If Not GridMOD.DataSource Is Nothing AndAlso GridMOD.RowCount > 0 Then
                    If BlnMarcar Then
                        GridMOD.CheckAllRecords()
                    Else
                        GridMOD.UnCheckAllRecords()
                    End If
                End If
            Case "UITbCentros"
                If Not GridCentros.DataSource Is Nothing AndAlso GridCentros.RowCount > 0 Then
                    If BlnMarcar Then
                        GridCentros.CheckAllRecords()
                    Else
                        GridCentros.UnCheckAllRecords()
                    End If
                End If
        End Select
    End Sub

    Private Sub ComprobarDatosGrids()
        If Not GridMateriales.DataSource Is Nothing Then
            StConver.dtMateriales = GridMateriales.DataSource
            If GridMateriales.CheckedRecordsCount > 0 Then StConver.dtMaterialesSeleccionados = GridMateriales.CheckedRecords
        End If
        If Not GridMOD.DataSource Is Nothing Then
            StConver.dtMod = GridMOD.DataSource
            If GridMOD.CheckedRecordsCount > 0 Then StConver.dtModSeleccionados = GridMOD.CheckedRecords
        End If
        If Not GridCentros.DataSource Is Nothing Then
            StConver.dtCentros = GridCentros.DataSource
            If GridCentros.CheckedRecordsCount > 0 Then StConver.dtCentrosSeleccionados = GridCentros.CheckedRecords
        End If
    End Sub

#End Region

#Region "Eventos frmConverArticulos"

#Region "Eventos Buttons"

    Private Sub BtnSelTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelTodos.Click
        MarcarDesmarcarTodos(True)
    End Sub

    Private Sub BtnDesSelTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDesSelTodos.Click
        MarcarDesmarcarTodos(False)
    End Sub

    Private Sub BtnSelPest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSelPest.Click
        MarcarDesmarcarRegistros(True)
    End Sub

    Private Sub BtnDesSelPest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDesSelPest.Click
        MarcarDesmarcarRegistros(False)
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        ComprobarDatosGrids()
        If ExpertisApp.GenerateMessage("Se generarán los Materiales, M.O.D o Centros seleccionados.|Los que no estén seleccionados se crearán con los ID's predeterminados marcados en los parámetros.|¿Desea Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine, vbNewLine) = DialogResult.Yes Then
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

#End Region

#Region "Eventos Tab"

    Private Sub TabArticulos_SelectedTabChanged(ByVal sender As System.Object, ByVal e As Janus.Windows.UI.Tab.TabEventArgs) Handles TabArticulos.SelectedTabChanged
        Select Case e.Page.Key
            Case "UITbMateriales"
                BtnSelPest.ToolTipText = ExpertisApp.Traslate("Marcar todos los registros de Materiales")
                BtnDesSelPest.ToolTipText = ExpertisApp.Traslate("Desmarcar todos los registros de Materiales")
                FrmDatosArticulos.Text = ExpertisApp.Traslate("Seleccione los Materiales no existentes que desea generar")
            Case "UITbMOD"
                BtnSelPest.ToolTipText = ExpertisApp.Traslate("Marcar todos los registros de M.O.D.")
                BtnDesSelPest.ToolTipText = ExpertisApp.Traslate("Desmarcar todos los registros de M.O.D.")
                FrmDatosArticulos.Text = ExpertisApp.Traslate("Seleccione las Categorías no existentes que desea generar")
            Case "UITbCentros"
                BtnSelPest.ToolTipText = ExpertisApp.Traslate("Marcar todos los registros de Centros")
                BtnDesSelPest.ToolTipText = ExpertisApp.Traslate("Desmarcar todos los registros de Centros")
                FrmDatosArticulos.Text = ExpertisApp.Traslate("Seleccione los Centros no existentes que desea generar")
        End Select
    End Sub

#End Region

#End Region

End Class