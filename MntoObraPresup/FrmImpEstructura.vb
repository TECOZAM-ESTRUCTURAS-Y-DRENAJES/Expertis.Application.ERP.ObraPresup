Public Class frmImpEstructura
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
    Friend WithEvents Frame1 As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblFwiArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblfwiIdEstructura As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents Grid As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents AdvIDEstructura As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtDescArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtIDArticulo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ulDescEstructura As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim GridEXLayout1 As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Frame1 = New Solmicro.Expertis.Engine.UI.Frame
        Me.AdvIDEstructura = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtDescArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFwiArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIDArticulo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblfwiIdEstructura = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescEstructura = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.Grid = New Solmicro.Expertis.Engine.UI.Grid
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.Frame1.SuspendLayout()
        Me.Panel1.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.AdvIDEstructura)
        Me.Frame1.Controls.Add(Me.txtDescArticulo)
        Me.Frame1.Controls.Add(Me.lblFwiArticulo)
        Me.Frame1.Controls.Add(Me.txtIDArticulo)
        Me.Frame1.Controls.Add(Me.lblfwiIdEstructura)
        Me.Frame1.Controls.Add(Me.ulDescEstructura)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(520, 72)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        '
        'AdvIDEstructura
        '
        Me.AdvIDEstructura.EntityName = "ArticuloEstructura"
        Me.AdvIDEstructura.Location = New System.Drawing.Point(75, 16)
        Me.AdvIDEstructura.Name = "AdvIDEstructura"
        Me.AdvIDEstructura.SecondaryDataFields = "IDEstructura"
        Me.AdvIDEstructura.Size = New System.Drawing.Size(118, 23)
        Me.AdvIDEstructura.TabIndex = 10
        Me.AdvIDEstructura.ViewName = "tbArticuloEstructura"
        '
        'txtDescArticulo
        '
        Me.txtDescArticulo.Enabled = False
        Me.txtDescArticulo.Location = New System.Drawing.Point(196, 43)
        Me.txtDescArticulo.Name = "txtDescArticulo"
        Me.txtDescArticulo.Size = New System.Drawing.Size(316, 21)
        Me.txtDescArticulo.TabIndex = 4
        '
        'lblFwiArticulo
        '
        Me.lblFwiArticulo.Location = New System.Drawing.Point(7, 43)
        Me.lblFwiArticulo.Name = "lblFwiArticulo"
        Me.lblFwiArticulo.Size = New System.Drawing.Size(47, 17)
        Me.lblFwiArticulo.TabIndex = 7
        Me.lblFwiArticulo.Text = "Artículo"
        '
        'txtIDArticulo
        '
        Me.txtIDArticulo.Enabled = False
        Me.txtIDArticulo.Location = New System.Drawing.Point(74, 43)
        Me.txtIDArticulo.Name = "txtIDArticulo"
        Me.txtIDArticulo.Size = New System.Drawing.Size(118, 21)
        Me.txtIDArticulo.TabIndex = 3
        '
        'lblfwiIdEstructura
        '
        Me.lblfwiIdEstructura.Location = New System.Drawing.Point(7, 15)
        Me.lblfwiIdEstructura.Name = "lblfwiIdEstructura"
        Me.lblfwiIdEstructura.Size = New System.Drawing.Size(63, 17)
        Me.lblfwiIdEstructura.TabIndex = 8
        Me.lblfwiIdEstructura.Text = "Estructura"
        '
        'ulDescEstructura
        '
        Me.ulDescEstructura.Location = New System.Drawing.Point(196, 19)
        Me.ulDescEstructura.Name = "ulDescEstructura"
        Me.ulDescEstructura.Size = New System.Drawing.Size(316, 17)
        Me.ulDescEstructura.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 293)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 48)
        Me.Panel1.TabIndex = 9
        '
        'Grid
        '
        GridEXLayout1.LayoutString = "<GridEXLayoutData><RootTable><Columns Collection=""true""><Column0 ID=""CantidadMarc" & _
        "a6""><ColumnType>CheckBox</ColumnType><DataMember>CantidadMarca6</DataMember><Edi" & _
        "tType>CheckBox</EditType><Key>CantidadMarca6</Key><Position>0</Position><TextAli" & _
        "gnment>Center</TextAlignment><Width>22</Width></Column0><Column1 ID=""IdComponent" & _
        "e""><Caption>Artículo</Caption><DataMember>IdComponente</DataMember><Key>IdCompon" & _
        "ente</Key><Position>1</Position><TextAlignment>Near</TextAlignment><Width>97</Wi" & _
        "dth></Column1><Column2 ID=""IDArticulo""><Caption>Artículo</Caption><DataMember>ID" & _
        "Articulo</DataMember><Key>IDArticulo</Key><Position>2</Position><TextAlignment>N" & _
        "ear</TextAlignment><Visible>False</Visible><Width>107</Width></Column2><Column3 " & _
        "ID=""DescArticulo""><Caption>Descripción</Caption><DataMember>DescArticulo</DataMe" & _
        "mber><EditType>NoEdit</EditType><Key>DescArticulo</Key><Position>3</Position><Te" & _
        "xtAlignment>Near</TextAlignment><Width>273</Width></Column3><Column4 ID=""Cantida" & _
        "d""><Caption>Cantidad</Caption><DataMember>Cantidad</DataMember><HeaderAlignment>" & _
        "Far</HeaderAlignment><Key>Cantidad</Key><Position>4</Position><TextAlignment>Nea" & _
        "r</TextAlignment><Width>84</Width></Column4></Columns><GroupCondition ID="""" /></" & _
        "RootTable></GridEXLayoutData>"
        Me.Grid.DesignTimeLayout = GridEXLayout1
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.Grid.EntityName = Nothing
        Me.Grid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grid.Location = New System.Drawing.Point(0, 72)
        Me.Grid.Name = "Grid"
        Me.Grid.PrimaryDataFields = Nothing
        Me.Grid.RelationMode = Solmicro.Expertis.Engine.RelationMode.NoRelation
        Me.Grid.RequeryManually = True
        Me.Grid.SecondaryDataFields = Nothing
        Me.Grid.Size = New System.Drawing.Size(520, 221)
        Me.Grid.TabIndex = 10
        Me.Grid.Tag = ""
        Me.Grid.ViewName = Nothing
        '
        'cmbCancelar
        '
        Me.cmbCancelar.Location = New System.Drawing.Point(264, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(120, 32)
        Me.cmbCancelar.TabIndex = 9
        Me.cmbCancelar.Text = "Cancelar"
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(136, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(120, 32)
        Me.cmbAceptar.TabIndex = 8
        Me.cmbAceptar.Text = "Aceptar"
        '
        'frmImpEstructura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(520, 341)
        Me.Controls.Add(Me.Grid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Frame1)
        Me.MaximizeBox = False
        Me.Name = "frmImpEstructura"
        Me.Text = "Importar Estructura"
        Me.Frame1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mIDArticulo, mDescArticulo, mIDCliente As String
    Private mIDPresup, mIDTrabajo, mIDLineaMaterial As Integer
    Private mQPresupTrabajo, mQUnidad As Double

#Region " Propertys "

    Public Property IDCliente() As String
        Get
            Return mIDCliente
        End Get
        Set(ByVal Value As String)
            mIDCliente = Value
        End Set
    End Property

    Public Property IDArticulo() As String
        Get
            Return mIDArticulo
        End Get
        Set(ByVal Value As String)
            mIDArticulo = Value
        End Set
    End Property

    Public Property DescArticulo() As String
        Get
            Return mDescArticulo
        End Get
        Set(ByVal Value As String)
            mDescArticulo = Value
        End Set
    End Property

    Public Property IDPresup() As Integer
        Get
            Return mIDPresup
        End Get
        Set(ByVal Value As Integer)
            mIDPresup = Value
        End Set
    End Property

    Public Property IDTrabajo() As Integer
        Get
            Return mIDTrabajo
        End Get
        Set(ByVal Value As Integer)
            mIDTrabajo = Value
        End Set
    End Property

    Public Property IDLineaMaterial() As Integer
        Get
            Return mIDLineaMaterial
        End Get
        Set(ByVal Value As Integer)
            mIDLineaMaterial = Value
        End Set
    End Property

    Public Property QPresupTrabajo() As Double
        Get
            Return mQPresupTrabajo
        End Get
        Set(ByVal Value As Double)
            mQPresupTrabajo = Value
        End Set
    End Property

    Public Property QUnidad() As Double
        Get
            Return mQUnidad
        End Get
        Set(ByVal Value As Double)
            mQUnidad = Value
        End Set
    End Property

#End Region

#Region " Load "

    Private Sub frmImpEstructura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtIDArticulo.Text = mIDArticulo
        txtDescArticulo.Text = mDescArticulo
        Dim strEstructuraPpal As String = ExpertisApp.ExecuteTask(Of String, String)(AddressOf ArticuloEstructura.EstructuraPpal, mIDArticulo)
        If AdvIDEstructura.Text <> strEstructurappal Then
            AdvIDEstructura.Text = strEstructurappal
        End If

        If length(AdvIDEstructura.Text) > 0 Then
            Dim f As New Filter
            f.Add(New StringFilterItem("IDArticulo", mIDArticulo))
            f.Add(New StringFilterItem("IDEstructura", AdvIDEstructura.Text))

            Dim dtt As DataTable = New BE.DataEngine().Filter("vfrmArticuloEstructuraDatos", f)
            If Not IsNothing(dtt) AndAlso dtt.Rows.Count > 0 Then
                For Each dr As DataRow In dtt.Select
                    dr("CantidadMarca6") = True
                Next
            End If
            Grid.EntityName = "Estructura"
            If Not IsNothing(dtt) AndAlso dtt.Rows.Count > 0 Then
                Grid.DataSource = dtt
            End If
        End If
    End Sub

#End Region

    Private Sub AdvIDEstructura_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDEstructura.SetPredefinedFilter
        If length(mIDArticulo) > 0 Then
            e.Filter.Add(New StringFilterItem("IDArticulo", mIDArticulo))
        End If
    End Sub

    Private Sub AdvIDEstructura_SelectionChanged(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDEstructura.SelectionChanged
        With Grid
            If (length(e.Selected.Rows(0)("IDEstructura")) > 0 And length(mIDArticulo) > 0) And (Not IsNothing(.DataSource) AndAlso .RowCount > 0) Then
                Dim f As New Filter
                f.Add(New StringFilterItem("IDArticulo", mIDArticulo))
                f.Add(New StringFilterItem("IDEstructura", e.Selected.Rows(0)("IDEstructura")))

                CType(.DataSource, DataTable).DefaultView.RowFilter = f.Compose(New AdoFilterComposer)
            End If
        End With
    End Sub

#Region " Grid "

    Private Sub Grid_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles Grid.UpdatingCell
        With Grid
            Select Case e.Column.Index
                Case .Columns("Cantidad").Index
                    If .Value(e.Column.Index) > 0 Then
                        .Value("CantidadMarca6") = True
                    End If
            End Select
        End With
    End Sub

#End Region

    Private Sub cmdCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        If Not Grid Is Nothing AndAlso Grid.RowCount > 0 Then
            If ExpertisApp.GenerateMessage("¿Desea Importar los componentes auxiliares asociados al material?.", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
                If mIDLineaMaterial > 0 Then
                    Dim dtImportacion As DataTable = Grid.DataSource
                   
                    Dim data As New datosImportacionEstructuraMaterial(mIDPresup, mIDTrabajo, mIDLineaMaterial, mQUnidad, mQPresupTrabajo, dtImportacion)
                    ExpertisApp.ExecuteTask(Of datosImportacionEstructuraMaterial)(AddressOf ImportacionEstructuraMaterial.ImportarEstructuraMateriales, data)

                    ExpertisApp.GenerateMessage("Importación finalizada correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                End If
            End If
        End If
    End Sub

End Class
