Public Class frmDesgloseImportesTrabajo
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
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents cmbCerrar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtDescTrabajoPresup As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoPresup As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNoAcumula As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TabImportes As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents UiTabPageTotales As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents UiTabPageUnitarios As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblTotalUnitario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMOD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCentros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblGastos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMateriales As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPresupTrabajoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblCostePresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPresupModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupCentrosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupGastosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupVariosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Linea As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtImpPresupMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenVarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenGastos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenCentros As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenMod As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenMat As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPorcPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPresupMatVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupVariosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupGastosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupCentrosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupModVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpVentaPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPresupTrabajoVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtQPresup As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FraTotalTrabajo As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPresupQTrabajoVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQTrabajoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPresupQVarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPresupQGastos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPresupQCentro As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPresupQMod As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblQMOD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQCentros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQGastos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lbQlMateriales As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCosteQPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPresupQModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQCentrosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQGastosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQVariosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPorcQPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPresupQMatVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupVariosQVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupGastosQVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupCentrosQVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQModVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpVentaQPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NumericTextBox1 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NumericTextBox2 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NumericTextBox3 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NumericTextBox4 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents NumericTextBox5 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents NumericTextBox6 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenPresupQMat As Solmicro.Expertis.Engine.UI.NumericTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCerrar = New Solmicro.Expertis.Engine.UI.Button
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblNoAcumula = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescTrabajoPresup = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoPresup = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TabImportes = New Solmicro.Expertis.Engine.UI.Tab
        Me.UiTabPageTotales = New Janus.Windows.UI.Tab.UITabPage
        Me.NumericTextBox1 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.NumericTextBox2 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NumericTextBox3 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblQMOD = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQCentros = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQGastos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.lbQlMateriales = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCosteQPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupQModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupQCentrosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupQGastosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupQVariosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupQMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPresupQVarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPresupQGastos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPresupQCentro = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPresupQMod = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenPresupQMat = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorcQPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupQMatVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupVariosQVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupGastosQVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupCentrosQVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupQModVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpVentaQPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.UiTabPageUnitarios = New Janus.Windows.UI.Tab.UITabPage
        Me.NumericTextBox4 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.NumericTextBox5 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.NumericTextBox6 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalUnitario = New Solmicro.Expertis.Engine.UI.Label
        Me.lblMOD = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCentros = New Solmicro.Expertis.Engine.UI.Label
        Me.lblGastos = New Solmicro.Expertis.Engine.UI.Label
        Me.lblVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.lblMateriales = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupTrabajoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCostePresup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupCentrosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupGastosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupVariosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Linea = New Janus.Windows.EditControls.UIGroupBox
        Me.txtImpPresupMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenVarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenGastos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenCentros = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenMod = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenMat = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorcPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupMatVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupVariosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupGastosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupCentrosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupModVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpVentaPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupTrabajoVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtQPresup = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraTotalTrabajo = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtMargenTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupQTrabajoVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupQTrabajoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Panel1.suspendlayout()
        Me.Panel2.suspendlayout()
        CType(Me.TabImportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabImportes.SuspendLayout()
        Me.UiTabPageTotales.SuspendLayout()
        Me.UiTabPageUnitarios.SuspendLayout()
        CType(Me.Linea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraTotalTrabajo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 381)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 42)
        Me.Panel1.TabIndex = 231
        '
        'cmbCerrar
        '
        Me.cmbCerrar.Location = New System.Drawing.Point(157, 7)
        Me.cmbCerrar.Name = "cmbCerrar"
        Me.cmbCerrar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCerrar.TabIndex = 21
        Me.cmbCerrar.Text = "Cerrar"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblNoAcumula)
        Me.Panel2.Controls.Add(Me.txtDescTrabajoPresup)
        Me.Panel2.Controls.Add(Me.lblTrabajo)
        Me.Panel2.Controls.Add(Me.txtTrabajoPresup)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(402, 53)
        Me.Panel2.TabIndex = 309
        '
        'lblNoAcumula
        '
        Me.lblNoAcumula.Location = New System.Drawing.Point(6, 31)
        Me.lblNoAcumula.Name = "lblNoAcumula"
        Me.lblNoAcumula.Size = New System.Drawing.Size(164, 13)
        Me.lblNoAcumula.TabIndex = 305
        Me.lblNoAcumula.Text = "NO ACUMULA EN TRABAJO "
        Me.lblNoAcumula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescTrabajoPresup
        '
        Me.TryDataBinding(txtDescTrabajoPresup, New System.Windows.Forms.Binding("Text", Me, "DescTrabajo", True))
        Me.txtDescTrabajoPresup.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoPresup.Enabled = False
        Me.txtDescTrabajoPresup.Location = New System.Drawing.Point(179, 4)
        Me.txtDescTrabajoPresup.Name = "txtDescTrabajoPresup"
        Me.txtDescTrabajoPresup.Size = New System.Drawing.Size(216, 21)
        Me.txtDescTrabajoPresup.TabIndex = 303
        Me.txtDescTrabajoPresup.TabStop = False
        '
        'lblTrabajo
        '
        Me.lblTrabajo.Location = New System.Drawing.Point(6, 7)
        Me.lblTrabajo.Name = "lblTrabajo"
        Me.lblTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblTrabajo.TabIndex = 302
        Me.lblTrabajo.Tag = ""
        Me.lblTrabajo.Text = "Trabajo"
        '
        'txtTrabajoPresup
        '
        Me.TryDataBinding(txtTrabajoPresup, New System.Windows.Forms.Binding("Text", Me, "CodTrabajo", True))
        Me.txtTrabajoPresup.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoPresup.Enabled = False
        Me.txtTrabajoPresup.Location = New System.Drawing.Point(63, 4)
        Me.txtTrabajoPresup.Name = "txtTrabajoPresup"
        Me.txtTrabajoPresup.Size = New System.Drawing.Size(112, 21)
        Me.txtTrabajoPresup.TabIndex = 301
        Me.txtTrabajoPresup.TabStop = False
        '
        'TabImportes
        '
        Me.TabImportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabImportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabImportes.Location = New System.Drawing.Point(0, 53)
        Me.TabImportes.Name = "TabImportes"
        Me.TabImportes.Size = New System.Drawing.Size(402, 328)
        Me.TabImportes.TabIndex = 311
        Me.TabImportes.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.UiTabPageTotales, Me.UiTabPageUnitarios})
        Me.TabImportes.UseThemes = True
        '
        'UiTabPageTotales
        '
        Me.UiTabPageTotales.Controls.Add(Me.NumericTextBox1)
        Me.UiTabPageTotales.Controls.Add(Me.Label1)
        Me.UiTabPageTotales.Controls.Add(Me.NumericTextBox2)
        Me.UiTabPageTotales.Controls.Add(Me.NumericTextBox3)
        Me.UiTabPageTotales.Controls.Add(Me.lblQMOD)
        Me.UiTabPageTotales.Controls.Add(Me.lblQCentros)
        Me.UiTabPageTotales.Controls.Add(Me.lblQGastos)
        Me.UiTabPageTotales.Controls.Add(Me.lblQVarios)
        Me.UiTabPageTotales.Controls.Add(Me.lbQlMateriales)
        Me.UiTabPageTotales.Controls.Add(Me.lblCosteQPresup)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPresupQModA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPresupQCentrosA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPresupQGastosA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPresupQVariosA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPresupQMatA)
        Me.UiTabPageTotales.Controls.Add(Me.txtMargenPresupQVarios)
        Me.UiTabPageTotales.Controls.Add(Me.txtMargenPresupQGastos)
        Me.UiTabPageTotales.Controls.Add(Me.txtMargenPresupQCentro)
        Me.UiTabPageTotales.Controls.Add(Me.txtMargenPresupQMod)
        Me.UiTabPageTotales.Controls.Add(Me.txtMargenPresupQMat)
        Me.UiTabPageTotales.Controls.Add(Me.lblPorcQPresup)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPresupQMatVentaA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPresupVariosQVentaA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPresupGastosQVentaA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPresupCentrosQVentaA)
        Me.UiTabPageTotales.Controls.Add(Me.txtImpPresupQModVentaA)
        Me.UiTabPageTotales.Controls.Add(Me.lblImpVentaQPresup)
        Me.UiTabPageTotales.Key = "Totales"
        Me.UiTabPageTotales.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPageTotales.Name = "UiTabPageTotales"
        Me.UiTabPageTotales.Size = New System.Drawing.Size(400, 306)
        Me.UiTabPageTotales.TabStop = True
        Me.UiTabPageTotales.Text = "Importes totales"
        '
        'NumericTextBox1
        '
        Me.NumericTextBox1.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox1.Enabled = False
        Me.NumericTextBox1.Location = New System.Drawing.Point(222, 182)
        Me.NumericTextBox1.Name = "NumericTextBox1"
        Me.NumericTextBox1.Size = New System.Drawing.Size(51, 21)
        Me.NumericTextBox1.TabIndex = 342
        Me.NumericTextBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 341
        Me.Label1.Tag = ""
        Me.Label1.Text = "Tr. Concepto"
        '
        'NumericTextBox2
        '
        Me.TryDataBinding(NumericTextBox2, New System.Windows.Forms.Binding("Value", Me, "ImpPresupQTrabajoVentaConceptoA", True))
        Me.NumericTextBox2.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox2.Enabled = False
        Me.NumericTextBox2.Location = New System.Drawing.Point(278, 182)
        Me.NumericTextBox2.Name = "NumericTextBox2"
        Me.NumericTextBox2.Size = New System.Drawing.Size(100, 21)
        Me.NumericTextBox2.TabIndex = 340
        Me.NumericTextBox2.TabStop = False
        '
        'NumericTextBox3
        '
        Me.TryDataBinding(NumericTextBox3, New System.Windows.Forms.Binding("Value", Me, "ImpPresupQTrabajoConceptoA", True))
        Me.NumericTextBox3.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox3.Enabled = False
        Me.NumericTextBox3.Location = New System.Drawing.Point(116, 182)
        Me.NumericTextBox3.Name = "NumericTextBox3"
        Me.NumericTextBox3.Size = New System.Drawing.Size(100, 21)
        Me.NumericTextBox3.TabIndex = 339
        Me.NumericTextBox3.TabStop = False
        '
        'lblQMOD
        '
        Me.lblQMOD.Location = New System.Drawing.Point(18, 83)
        Me.lblQMOD.Name = "lblQMOD"
        Me.lblQMOD.Size = New System.Drawing.Size(46, 13)
        Me.lblQMOD.TabIndex = 332
        Me.lblQMOD.Tag = "IdRec=5749;"
        Me.lblQMOD.Text = "M.O.D."
        '
        'lblQCentros
        '
        Me.lblQCentros.Location = New System.Drawing.Point(18, 107)
        Me.lblQCentros.Name = "lblQCentros"
        Me.lblQCentros.Size = New System.Drawing.Size(52, 13)
        Me.lblQCentros.TabIndex = 333
        Me.lblQCentros.Tag = "IdRec=5748;"
        Me.lblQCentros.Text = "Centros"
        '
        'lblQGastos
        '
        Me.lblQGastos.Location = New System.Drawing.Point(18, 131)
        Me.lblQGastos.Name = "lblQGastos"
        Me.lblQGastos.Size = New System.Drawing.Size(46, 13)
        Me.lblQGastos.TabIndex = 334
        Me.lblQGastos.Tag = "IdRec=5747;"
        Me.lblQGastos.Text = "Gastos"
        '
        'lblQVarios
        '
        Me.lblQVarios.Location = New System.Drawing.Point(18, 155)
        Me.lblQVarios.Name = "lblQVarios"
        Me.lblQVarios.Size = New System.Drawing.Size(43, 13)
        Me.lblQVarios.TabIndex = 335
        Me.lblQVarios.Tag = "IdRec=5333;"
        Me.lblQVarios.Text = "Varios"
        '
        'lbQlMateriales
        '
        Me.lbQlMateriales.Location = New System.Drawing.Point(18, 59)
        Me.lbQlMateriales.Name = "lbQlMateriales"
        Me.lbQlMateriales.Size = New System.Drawing.Size(65, 13)
        Me.lbQlMateriales.TabIndex = 336
        Me.lbQlMateriales.Tag = "IdRec=5750;"
        Me.lbQlMateriales.Text = "Materiales"
        '
        'lblCosteQPresup
        '
        Me.lblCosteQPresup.AutoSize = False
        Me.lblCosteQPresup.Location = New System.Drawing.Point(116, 38)
        Me.lblCosteQPresup.Name = "lblCosteQPresup"
        Me.lblCosteQPresup.Size = New System.Drawing.Size(100, 18)
        Me.lblCosteQPresup.TabIndex = 331
        Me.lblCosteQPresup.Tag = ""
        Me.lblCosteQPresup.Text = "Coste Presup."
        Me.lblCosteQPresup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpPresupQModA
        '
        Me.TryDataBinding(txtImpPresupQModA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupQModA", True))
        Me.txtImpPresupQModA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQModA.Enabled = False
        Me.txtImpPresupQModA.Location = New System.Drawing.Point(116, 83)
        Me.txtImpPresupQModA.Name = "txtImpPresupQModA"
        Me.txtImpPresupQModA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupQModA.TabIndex = 330
        Me.txtImpPresupQModA.TabStop = False
        '
        'txtImpPresupQCentrosA
        '
        Me.TryDataBinding(txtImpPresupQCentrosA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupQCentrosA", True))
        Me.txtImpPresupQCentrosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQCentrosA.Enabled = False
        Me.txtImpPresupQCentrosA.Location = New System.Drawing.Point(116, 107)
        Me.txtImpPresupQCentrosA.Name = "txtImpPresupQCentrosA"
        Me.txtImpPresupQCentrosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupQCentrosA.TabIndex = 329
        Me.txtImpPresupQCentrosA.TabStop = False
        '
        'txtImpPresupQGastosA
        '
        Me.TryDataBinding(txtImpPresupQGastosA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupQGastosA", True))
        Me.txtImpPresupQGastosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQGastosA.Enabled = False
        Me.txtImpPresupQGastosA.Location = New System.Drawing.Point(116, 131)
        Me.txtImpPresupQGastosA.Name = "txtImpPresupQGastosA"
        Me.txtImpPresupQGastosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupQGastosA.TabIndex = 328
        Me.txtImpPresupQGastosA.TabStop = False
        '
        'txtImpPresupQVariosA
        '
        Me.TryDataBinding(txtImpPresupQVariosA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupQVariosA", True))
        Me.txtImpPresupQVariosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQVariosA.Enabled = False
        Me.txtImpPresupQVariosA.Location = New System.Drawing.Point(116, 155)
        Me.txtImpPresupQVariosA.Name = "txtImpPresupQVariosA"
        Me.txtImpPresupQVariosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupQVariosA.TabIndex = 327
        Me.txtImpPresupQVariosA.TabStop = False
        '
        'txtImpPresupQMatA
        '
        Me.TryDataBinding(txtImpPresupQMatA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupQMatA", True))
        Me.txtImpPresupQMatA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQMatA.Enabled = False
        Me.txtImpPresupQMatA.Location = New System.Drawing.Point(116, 59)
        Me.txtImpPresupQMatA.Name = "txtImpPresupQMatA"
        Me.txtImpPresupQMatA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupQMatA.TabIndex = 326
        Me.txtImpPresupQMatA.TabStop = False
        '
        'txtMargenPresupQVarios
        '
        Me.TryDataBinding(txtMargenPresupQVarios, New System.Windows.Forms.Binding("Value", Me, "MargenVarios", True))
        Me.txtMargenPresupQVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPresupQVarios.Enabled = False
        Me.txtMargenPresupQVarios.Location = New System.Drawing.Point(222, 155)
        Me.txtMargenPresupQVarios.Name = "txtMargenPresupQVarios"
        Me.txtMargenPresupQVarios.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPresupQVarios.TabIndex = 325
        Me.txtMargenPresupQVarios.TabStop = False
        '
        'txtMargenPresupQGastos
        '
        Me.TryDataBinding(txtMargenPresupQGastos, New System.Windows.Forms.Binding("Value", Me, "MargenGastos", True))
        Me.txtMargenPresupQGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPresupQGastos.Enabled = False
        Me.txtMargenPresupQGastos.Location = New System.Drawing.Point(222, 131)
        Me.txtMargenPresupQGastos.Name = "txtMargenPresupQGastos"
        Me.txtMargenPresupQGastos.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPresupQGastos.TabIndex = 324
        Me.txtMargenPresupQGastos.TabStop = False
        '
        'txtMargenPresupQCentro
        '
        Me.TryDataBinding(txtMargenPresupQCentro, New System.Windows.Forms.Binding("Value", Me, "MargenCentros", True))
        Me.txtMargenPresupQCentro.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPresupQCentro.Enabled = False
        Me.txtMargenPresupQCentro.Location = New System.Drawing.Point(222, 107)
        Me.txtMargenPresupQCentro.Name = "txtMargenPresupQCentro"
        Me.txtMargenPresupQCentro.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPresupQCentro.TabIndex = 323
        Me.txtMargenPresupQCentro.TabStop = False
        '
        'txtMargenPresupQMod
        '
        Me.TryDataBinding(txtMargenPresupQMod, New System.Windows.Forms.Binding("Value", Me, "MargenMod", True))
        Me.txtMargenPresupQMod.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPresupQMod.Enabled = False
        Me.txtMargenPresupQMod.Location = New System.Drawing.Point(222, 83)
        Me.txtMargenPresupQMod.Name = "txtMargenPresupQMod"
        Me.txtMargenPresupQMod.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPresupQMod.TabIndex = 322
        Me.txtMargenPresupQMod.TabStop = False
        '
        'txtMargenPresupQMat
        '
        Me.TryDataBinding(txtMargenPresupQMat, New System.Windows.Forms.Binding("Value", Me, "MargenMat", True))
        Me.txtMargenPresupQMat.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPresupQMat.Enabled = False
        Me.txtMargenPresupQMat.Location = New System.Drawing.Point(222, 59)
        Me.txtMargenPresupQMat.Name = "txtMargenPresupQMat"
        Me.txtMargenPresupQMat.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenPresupQMat.TabIndex = 321
        Me.txtMargenPresupQMat.TabStop = False
        '
        'lblPorcQPresup
        '
        Me.lblPorcQPresup.AutoSize = False
        Me.lblPorcQPresup.Location = New System.Drawing.Point(222, 38)
        Me.lblPorcQPresup.Name = "lblPorcQPresup"
        Me.lblPorcQPresup.Size = New System.Drawing.Size(51, 18)
        Me.lblPorcQPresup.TabIndex = 337
        Me.lblPorcQPresup.Tag = "IdRec=7118;"
        Me.lblPorcQPresup.Text = "% Presup."
        Me.lblPorcQPresup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpPresupQMatVentaA
        '
        Me.TryDataBinding(txtImpPresupQMatVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupQMatVentaA", True))
        Me.txtImpPresupQMatVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQMatVentaA.Enabled = False
        Me.txtImpPresupQMatVentaA.Location = New System.Drawing.Point(279, 59)
        Me.txtImpPresupQMatVentaA.Name = "txtImpPresupQMatVentaA"
        Me.txtImpPresupQMatVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupQMatVentaA.TabIndex = 320
        Me.txtImpPresupQMatVentaA.TabStop = False
        '
        'txtImpPresupVariosQVentaA
        '
        Me.TryDataBinding(txtImpPresupVariosQVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupQVariosVentaA", True))
        Me.txtImpPresupVariosQVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupVariosQVentaA.Enabled = False
        Me.txtImpPresupVariosQVentaA.Location = New System.Drawing.Point(279, 155)
        Me.txtImpPresupVariosQVentaA.Name = "txtImpPresupVariosQVentaA"
        Me.txtImpPresupVariosQVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupVariosQVentaA.TabIndex = 319
        Me.txtImpPresupVariosQVentaA.TabStop = False
        '
        'txtImpPresupGastosQVentaA
        '
        Me.TryDataBinding(txtImpPresupGastosQVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupQGastosVentaA", True))
        Me.txtImpPresupGastosQVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupGastosQVentaA.Enabled = False
        Me.txtImpPresupGastosQVentaA.Location = New System.Drawing.Point(279, 131)
        Me.txtImpPresupGastosQVentaA.Name = "txtImpPresupGastosQVentaA"
        Me.txtImpPresupGastosQVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupGastosQVentaA.TabIndex = 318
        Me.txtImpPresupGastosQVentaA.TabStop = False
        '
        'txtImpPresupCentrosQVentaA
        '
        Me.TryDataBinding(txtImpPresupCentrosQVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupQCentrosVentaA", True))
        Me.txtImpPresupCentrosQVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupCentrosQVentaA.Enabled = False
        Me.txtImpPresupCentrosQVentaA.Location = New System.Drawing.Point(279, 107)
        Me.txtImpPresupCentrosQVentaA.Name = "txtImpPresupCentrosQVentaA"
        Me.txtImpPresupCentrosQVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupCentrosQVentaA.TabIndex = 317
        Me.txtImpPresupCentrosQVentaA.TabStop = False
        '
        'txtImpPresupQModVentaA
        '
        Me.TryDataBinding(txtImpPresupQModVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupQModVentaA", True))
        Me.txtImpPresupQModVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQModVentaA.Enabled = False
        Me.txtImpPresupQModVentaA.Location = New System.Drawing.Point(279, 83)
        Me.txtImpPresupQModVentaA.Name = "txtImpPresupQModVentaA"
        Me.txtImpPresupQModVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupQModVentaA.TabIndex = 316
        Me.txtImpPresupQModVentaA.TabStop = False
        '
        'lblImpVentaQPresup
        '
        Me.lblImpVentaQPresup.AutoSize = False
        Me.lblImpVentaQPresup.Location = New System.Drawing.Point(279, 38)
        Me.lblImpVentaQPresup.Name = "lblImpVentaQPresup"
        Me.lblImpVentaQPresup.Size = New System.Drawing.Size(100, 18)
        Me.lblImpVentaQPresup.TabIndex = 338
        Me.lblImpVentaQPresup.Tag = "IdRec=6718;"
        Me.lblImpVentaQPresup.Text = "Imp. Venta Presup."
        Me.lblImpVentaQPresup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UiTabPageUnitarios
        '
        Me.UiTabPageUnitarios.Controls.Add(Me.NumericTextBox4)
        Me.UiTabPageUnitarios.Controls.Add(Me.Label2)
        Me.UiTabPageUnitarios.Controls.Add(Me.NumericTextBox5)
        Me.UiTabPageUnitarios.Controls.Add(Me.NumericTextBox6)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblTotalUnitario)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblMOD)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblCentros)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblGastos)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblVarios)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblMateriales)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblQPresup)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPresupTrabajoA)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblCostePresup)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPresupModA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPresupCentrosA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPresupGastosA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPresupVariosA)
        Me.UiTabPageUnitarios.Controls.Add(Me.Linea)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPresupMatA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtMargenVarios)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtMargenGastos)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtMargenCentros)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtMargenMod)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtMargenMat)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblPorcPresup)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPresupMatVentaA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPresupVariosVentaA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPresupGastosVentaA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPresupCentrosVentaA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPresupModVentaA)
        Me.UiTabPageUnitarios.Controls.Add(Me.lblImpVentaPresup)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtImpPresupTrabajoVentaA)
        Me.UiTabPageUnitarios.Controls.Add(Me.txtQPresup)
        Me.UiTabPageUnitarios.Key = "Unitarios"
        Me.UiTabPageUnitarios.Location = New System.Drawing.Point(1, 21)
        Me.UiTabPageUnitarios.Name = "UiTabPageUnitarios"
        Me.UiTabPageUnitarios.Size = New System.Drawing.Size(400, 265)
        Me.UiTabPageUnitarios.TabStop = True
        Me.UiTabPageUnitarios.Text = "Importes unitarios"
        Me.UiTabPageUnitarios.Visible = False
        '
        'NumericTextBox4
        '
        Me.NumericTextBox4.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox4.Enabled = False
        Me.NumericTextBox4.Location = New System.Drawing.Point(222, 157)
        Me.NumericTextBox4.Name = "NumericTextBox4"
        Me.NumericTextBox4.Size = New System.Drawing.Size(51, 21)
        Me.NumericTextBox4.TabIndex = 346
        Me.NumericTextBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(19, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 345
        Me.Label2.Tag = ""
        Me.Label2.Text = "Tr. Concepto"
        '
        'NumericTextBox5
        '
        Me.TryDataBinding(NumericTextBox5, New System.Windows.Forms.Binding("Value", Me, "ImpPresupTrabajoVentaConceptoA", True))
        Me.NumericTextBox5.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox5.Enabled = False
        Me.NumericTextBox5.Location = New System.Drawing.Point(278, 157)
        Me.NumericTextBox5.Name = "NumericTextBox5"
        Me.NumericTextBox5.Size = New System.Drawing.Size(100, 21)
        Me.NumericTextBox5.TabIndex = 344
        Me.NumericTextBox5.TabStop = False
        '
        'NumericTextBox6
        '
        Me.TryDataBinding(NumericTextBox6, New System.Windows.Forms.Binding("Value", Me, "ImpPresupTrabajoConceptoA", True))
        Me.NumericTextBox6.DisabledBackColor = System.Drawing.Color.White
        Me.NumericTextBox6.Enabled = False
        Me.NumericTextBox6.Location = New System.Drawing.Point(116, 157)
        Me.NumericTextBox6.Name = "NumericTextBox6"
        Me.NumericTextBox6.Size = New System.Drawing.Size(100, 21)
        Me.NumericTextBox6.TabIndex = 343
        Me.NumericTextBox6.TabStop = False
        '
        'lblTotalUnitario
        '
        Me.lblTotalUnitario.Location = New System.Drawing.Point(19, 204)
        Me.lblTotalUnitario.Name = "lblTotalUnitario"
        Me.lblTotalUnitario.Size = New System.Drawing.Size(92, 13)
        Me.lblTotalUnitario.TabIndex = 306
        Me.lblTotalUnitario.Tag = ""
        Me.lblTotalUnitario.Text = "TOTAL Unitario"
        '
        'lblMOD
        '
        Me.lblMOD.Location = New System.Drawing.Point(19, 58)
        Me.lblMOD.Name = "lblMOD"
        Me.lblMOD.Size = New System.Drawing.Size(46, 13)
        Me.lblMOD.TabIndex = 308
        Me.lblMOD.Tag = "IdRec=5749;"
        Me.lblMOD.Text = "M.O.D."
        '
        'lblCentros
        '
        Me.lblCentros.Location = New System.Drawing.Point(19, 82)
        Me.lblCentros.Name = "lblCentros"
        Me.lblCentros.Size = New System.Drawing.Size(52, 13)
        Me.lblCentros.TabIndex = 309
        Me.lblCentros.Tag = "IdRec=5748;"
        Me.lblCentros.Text = "Centros"
        '
        'lblGastos
        '
        Me.lblGastos.Location = New System.Drawing.Point(19, 106)
        Me.lblGastos.Name = "lblGastos"
        Me.lblGastos.Size = New System.Drawing.Size(46, 13)
        Me.lblGastos.TabIndex = 310
        Me.lblGastos.Tag = "IdRec=5747;"
        Me.lblGastos.Text = "Gastos"
        '
        'lblVarios
        '
        Me.lblVarios.Location = New System.Drawing.Point(19, 130)
        Me.lblVarios.Name = "lblVarios"
        Me.lblVarios.Size = New System.Drawing.Size(43, 13)
        Me.lblVarios.TabIndex = 311
        Me.lblVarios.Tag = "IdRec=5333;"
        Me.lblVarios.Text = "Varios"
        '
        'lblMateriales
        '
        Me.lblMateriales.Location = New System.Drawing.Point(19, 34)
        Me.lblMateriales.Name = "lblMateriales"
        Me.lblMateriales.Size = New System.Drawing.Size(65, 13)
        Me.lblMateriales.TabIndex = 313
        Me.lblMateriales.Tag = "IdRec=5750;"
        Me.lblMateriales.Text = "Materiales"
        '
        'lblQPresup
        '
        Me.lblQPresup.Location = New System.Drawing.Point(19, 228)
        Me.lblQPresup.Name = "lblQPresup"
        Me.lblQPresup.Size = New System.Drawing.Size(67, 13)
        Me.lblQPresup.TabIndex = 316
        Me.lblQPresup.Tag = ""
        Me.lblQPresup.Text = "C. Presup."
        '
        'txtImpPresupTrabajoA
        '
        Me.TryDataBinding(txtImpPresupTrabajoA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupTrabajoA", True))
        Me.txtImpPresupTrabajoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupTrabajoA.Enabled = False
        Me.txtImpPresupTrabajoA.Location = New System.Drawing.Point(116, 204)
        Me.txtImpPresupTrabajoA.Name = "txtImpPresupTrabajoA"
        Me.txtImpPresupTrabajoA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupTrabajoA.TabIndex = 305
        Me.txtImpPresupTrabajoA.TabStop = False
        '
        'lblCostePresup
        '
        Me.lblCostePresup.AutoSize = False
        Me.lblCostePresup.Location = New System.Drawing.Point(116, 12)
        Me.lblCostePresup.Name = "lblCostePresup"
        Me.lblCostePresup.Size = New System.Drawing.Size(100, 18)
        Me.lblCostePresup.TabIndex = 307
        Me.lblCostePresup.Tag = ""
        Me.lblCostePresup.Text = "Coste Presup."
        Me.lblCostePresup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpPresupModA
        '
        Me.TryDataBinding(txtImpPresupModA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupModA", True))
        Me.txtImpPresupModA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupModA.Enabled = False
        Me.txtImpPresupModA.Location = New System.Drawing.Point(116, 58)
        Me.txtImpPresupModA.Name = "txtImpPresupModA"
        Me.txtImpPresupModA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupModA.TabIndex = 303
        Me.txtImpPresupModA.TabStop = False
        '
        'txtImpPresupCentrosA
        '
        Me.TryDataBinding(txtImpPresupCentrosA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupCentrosA", True))
        Me.txtImpPresupCentrosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupCentrosA.Enabled = False
        Me.txtImpPresupCentrosA.Location = New System.Drawing.Point(116, 82)
        Me.txtImpPresupCentrosA.Name = "txtImpPresupCentrosA"
        Me.txtImpPresupCentrosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupCentrosA.TabIndex = 302
        Me.txtImpPresupCentrosA.TabStop = False
        '
        'txtImpPresupGastosA
        '
        Me.TryDataBinding(txtImpPresupGastosA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupGastosA", True))
        Me.txtImpPresupGastosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupGastosA.Enabled = False
        Me.txtImpPresupGastosA.Location = New System.Drawing.Point(116, 106)
        Me.txtImpPresupGastosA.Name = "txtImpPresupGastosA"
        Me.txtImpPresupGastosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupGastosA.TabIndex = 301
        Me.txtImpPresupGastosA.TabStop = False
        '
        'txtImpPresupVariosA
        '
        Me.TryDataBinding(txtImpPresupVariosA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupVariosA", True))
        Me.txtImpPresupVariosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupVariosA.Enabled = False
        Me.txtImpPresupVariosA.Location = New System.Drawing.Point(116, 130)
        Me.txtImpPresupVariosA.Name = "txtImpPresupVariosA"
        Me.txtImpPresupVariosA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupVariosA.TabIndex = 300
        Me.txtImpPresupVariosA.TabStop = False
        '
        'Linea
        '
        Me.Linea.Location = New System.Drawing.Point(19, 197)
        Me.Linea.Name = "Linea"
        Me.Linea.Size = New System.Drawing.Size(370, 3)
        Me.Linea.TabIndex = 312
        '
        'txtImpPresupMatA
        '
        Me.TryDataBinding(txtImpPresupMatA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupMatA", True))
        Me.txtImpPresupMatA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupMatA.Enabled = False
        Me.txtImpPresupMatA.Location = New System.Drawing.Point(116, 34)
        Me.txtImpPresupMatA.Name = "txtImpPresupMatA"
        Me.txtImpPresupMatA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupMatA.TabIndex = 299
        Me.txtImpPresupMatA.TabStop = False
        '
        'txtMargenVarios
        '
        Me.TryDataBinding(txtMargenVarios, New System.Windows.Forms.Binding("Value", Me, "MargenVarios", True))
        Me.txtMargenVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenVarios.Enabled = False
        Me.txtMargenVarios.Location = New System.Drawing.Point(222, 130)
        Me.txtMargenVarios.Name = "txtMargenVarios"
        Me.txtMargenVarios.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenVarios.TabIndex = 298
        Me.txtMargenVarios.TabStop = False
        '
        'txtMargenGastos
        '
        Me.TryDataBinding(txtMargenGastos, New System.Windows.Forms.Binding("Value", Me, "MargenGastos", True))
        Me.txtMargenGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenGastos.Enabled = False
        Me.txtMargenGastos.Location = New System.Drawing.Point(222, 106)
        Me.txtMargenGastos.Name = "txtMargenGastos"
        Me.txtMargenGastos.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenGastos.TabIndex = 297
        Me.txtMargenGastos.TabStop = False
        '
        'txtMargenCentros
        '
        Me.TryDataBinding(txtMargenCentros, New System.Windows.Forms.Binding("Value", Me, "MargenCentros", True))
        Me.txtMargenCentros.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenCentros.Enabled = False
        Me.txtMargenCentros.Location = New System.Drawing.Point(222, 82)
        Me.txtMargenCentros.Name = "txtMargenCentros"
        Me.txtMargenCentros.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenCentros.TabIndex = 296
        Me.txtMargenCentros.TabStop = False
        '
        'txtMargenMod
        '
        Me.TryDataBinding(txtMargenMod, New System.Windows.Forms.Binding("Value", Me, "MargenMod", True))
        Me.txtMargenMod.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenMod.Enabled = False
        Me.txtMargenMod.Location = New System.Drawing.Point(222, 58)
        Me.txtMargenMod.Name = "txtMargenMod"
        Me.txtMargenMod.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenMod.TabIndex = 295
        Me.txtMargenMod.TabStop = False
        '
        'txtMargenMat
        '
        Me.TryDataBinding(txtMargenMat, New System.Windows.Forms.Binding("Value", Me, "MargenMat", True))
        Me.txtMargenMat.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenMat.Enabled = False
        Me.txtMargenMat.Location = New System.Drawing.Point(222, 34)
        Me.txtMargenMat.Name = "txtMargenMat"
        Me.txtMargenMat.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenMat.TabIndex = 294
        Me.txtMargenMat.TabStop = False
        '
        'lblPorcPresup
        '
        Me.lblPorcPresup.AutoSize = False
        Me.lblPorcPresup.Location = New System.Drawing.Point(222, 12)
        Me.lblPorcPresup.Name = "lblPorcPresup"
        Me.lblPorcPresup.Size = New System.Drawing.Size(51, 18)
        Me.lblPorcPresup.TabIndex = 314
        Me.lblPorcPresup.Tag = "IdRec=7118;"
        Me.lblPorcPresup.Text = "% Presup."
        Me.lblPorcPresup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpPresupMatVentaA
        '
        Me.TryDataBinding(txtImpPresupMatVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupMatVentaA", True))
        Me.txtImpPresupMatVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupMatVentaA.Enabled = False
        Me.txtImpPresupMatVentaA.Location = New System.Drawing.Point(279, 34)
        Me.txtImpPresupMatVentaA.Name = "txtImpPresupMatVentaA"
        Me.txtImpPresupMatVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupMatVentaA.TabIndex = 293
        Me.txtImpPresupMatVentaA.TabStop = False
        '
        'txtImpPresupVariosVentaA
        '
        Me.TryDataBinding(txtImpPresupVariosVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupVariosVentaA", True))
        Me.txtImpPresupVariosVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupVariosVentaA.Enabled = False
        Me.txtImpPresupVariosVentaA.Location = New System.Drawing.Point(279, 130)
        Me.txtImpPresupVariosVentaA.Name = "txtImpPresupVariosVentaA"
        Me.txtImpPresupVariosVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupVariosVentaA.TabIndex = 292
        Me.txtImpPresupVariosVentaA.TabStop = False
        '
        'txtImpPresupGastosVentaA
        '
        Me.TryDataBinding(txtImpPresupGastosVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupGastosVentaA", True))
        Me.txtImpPresupGastosVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupGastosVentaA.Enabled = False
        Me.txtImpPresupGastosVentaA.Location = New System.Drawing.Point(279, 106)
        Me.txtImpPresupGastosVentaA.Name = "txtImpPresupGastosVentaA"
        Me.txtImpPresupGastosVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupGastosVentaA.TabIndex = 291
        Me.txtImpPresupGastosVentaA.TabStop = False
        '
        'txtImpPresupCentrosVentaA
        '
        Me.TryDataBinding(txtImpPresupCentrosVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupCentrosVentaA", True))
        Me.txtImpPresupCentrosVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupCentrosVentaA.Enabled = False
        Me.txtImpPresupCentrosVentaA.Location = New System.Drawing.Point(279, 82)
        Me.txtImpPresupCentrosVentaA.Name = "txtImpPresupCentrosVentaA"
        Me.txtImpPresupCentrosVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupCentrosVentaA.TabIndex = 290
        Me.txtImpPresupCentrosVentaA.TabStop = False
        '
        'txtImpPresupModVentaA
        '
        Me.TryDataBinding(txtImpPresupModVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupModVentaA", True))
        Me.txtImpPresupModVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupModVentaA.Enabled = False
        Me.txtImpPresupModVentaA.Location = New System.Drawing.Point(279, 58)
        Me.txtImpPresupModVentaA.Name = "txtImpPresupModVentaA"
        Me.txtImpPresupModVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupModVentaA.TabIndex = 289
        Me.txtImpPresupModVentaA.TabStop = False
        '
        'lblImpVentaPresup
        '
        Me.lblImpVentaPresup.AutoSize = False
        Me.lblImpVentaPresup.Location = New System.Drawing.Point(279, 12)
        Me.lblImpVentaPresup.Name = "lblImpVentaPresup"
        Me.lblImpVentaPresup.Size = New System.Drawing.Size(100, 18)
        Me.lblImpVentaPresup.TabIndex = 315
        Me.lblImpVentaPresup.Tag = "IdRec=6718;"
        Me.lblImpVentaPresup.Text = "Imp. Venta Presup."
        Me.lblImpVentaPresup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpPresupTrabajoVentaA
        '
        Me.TryDataBinding(txtImpPresupTrabajoVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupTrabajoVentaA", True))
        Me.txtImpPresupTrabajoVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupTrabajoVentaA.Enabled = False
        Me.txtImpPresupTrabajoVentaA.Location = New System.Drawing.Point(279, 204)
        Me.txtImpPresupTrabajoVentaA.Name = "txtImpPresupTrabajoVentaA"
        Me.txtImpPresupTrabajoVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupTrabajoVentaA.TabIndex = 288
        Me.txtImpPresupTrabajoVentaA.TabStop = False
        '
        'txtQPresup
        '
        Me.TryDataBinding(txtQPresup, New System.Windows.Forms.Binding("Value", Me, "QPresup", True))
        Me.txtQPresup.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPresup.Enabled = False
        Me.txtQPresup.Location = New System.Drawing.Point(116, 228)
        Me.txtQPresup.Name = "txtQPresup"
        Me.txtQPresup.Size = New System.Drawing.Size(100, 21)
        Me.txtQPresup.TabIndex = 287
        Me.txtQPresup.TabStop = False
        '
        'FraTotalTrabajo
        '
        Me.FraTotalTrabajo.Controls.Add(Me.txtMargenTrabajo)
        Me.FraTotalTrabajo.Controls.Add(Me.lblTotal)
        Me.FraTotalTrabajo.Controls.Add(Me.txtImpPresupQTrabajoVentaA)
        Me.FraTotalTrabajo.Controls.Add(Me.txtImpPresupQTrabajoA)
        Me.FraTotalTrabajo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotalTrabajo.Location = New System.Drawing.Point(0, 340)
        Me.FraTotalTrabajo.Name = "FraTotalTrabajo"
        Me.FraTotalTrabajo.Size = New System.Drawing.Size(402, 41)
        Me.FraTotalTrabajo.TabIndex = 312
        Me.FraTotalTrabajo.TabStop = False
        '
        'txtMargenTrabajo
        '
        Me.TryDataBinding(txtMargenTrabajo, New System.Windows.Forms.Binding("Value", Me, "MargenTrabajo", True))
        Me.txtMargenTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenTrabajo.Enabled = False
        Me.txtMargenTrabajo.Location = New System.Drawing.Point(223, 13)
        Me.txtMargenTrabajo.Name = "txtMargenTrabajo"
        Me.txtMargenTrabajo.Size = New System.Drawing.Size(51, 21)
        Me.txtMargenTrabajo.TabIndex = 305
        Me.txtMargenTrabajo.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(20, 13)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(92, 13)
        Me.lblTotal.TabIndex = 293
        Me.lblTotal.Tag = ""
        Me.lblTotal.Text = "TOTAL Trabajo"
        '
        'txtImpPresupQTrabajoVentaA
        '
        Me.txtImpPresupQTrabajoVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQTrabajoVentaA.Enabled = False
        Me.txtImpPresupQTrabajoVentaA.Location = New System.Drawing.Point(279, 13)
        Me.txtImpPresupQTrabajoVentaA.Name = "txtImpPresupQTrabajoVentaA"
        Me.txtImpPresupQTrabajoVentaA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupQTrabajoVentaA.TabIndex = 292
        Me.txtImpPresupQTrabajoVentaA.TabStop = False
        '
        'txtImpPresupQTrabajoA
        '
        Me.txtImpPresupQTrabajoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQTrabajoA.Enabled = False
        Me.txtImpPresupQTrabajoA.Location = New System.Drawing.Point(117, 13)
        Me.txtImpPresupQTrabajoA.Name = "txtImpPresupQTrabajoA"
        Me.txtImpPresupQTrabajoA.Size = New System.Drawing.Size(100, 21)
        Me.txtImpPresupQTrabajoA.TabIndex = 291
        Me.txtImpPresupQTrabajoA.TabStop = False
        '
        'frmDesgloseImportesTrabajo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(402, 423)
        Me.Controls.Add(Me.FraTotalTrabajo)
        Me.Controls.Add(Me.TabImportes)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.EntityName = "ObraTrabajoPresup"
        Me.MaximizeBox = False
        Me.Name = "frmDesgloseImportesTrabajo"
        Me.NavigationFields = "IDTrabajoPresup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Desglose importes trabajo"
        Me.ViewName = "tbObratrabajoPresup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TabImportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabImportes.ResumeLayout(False)
        Me.UiTabPageTotales.ResumeLayout(False)
        Me.UiTabPageTotales.PerformLayout()
        Me.UiTabPageUnitarios.ResumeLayout(False)
        Me.UiTabPageUnitarios.PerformLayout()
        CType(Me.Linea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraTotalTrabajo.ResumeLayout(False)
        Me.FraTotalTrabajo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

    Private mIDTrabajoPresup As Integer
    Private mImpCapitulo, mImpCapituloVenta As Double

    Public Sub AbrirDesgloseTrabajo(ByVal IDTrabajoPresup As Integer, ByVal ImpCapitulo As Double, ByVal ImpCapituloVenta As Double)
        mIDTrabajoPresup = IDTrabajoPresup
        mImpCapitulo = ImpCapitulo
        mImpCapituloVenta = ImpCapituloVenta

        Dim frm As Form = Me
        frm.ShowDialog()  'Para que no traiga todos los registros
    End Sub

    Private Sub frmDesgloseImportesTrabajo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim f As New Filter
        f.Add(New NumberFilterItem("IDTrabajoPresup", mIDTrabajoPresup))
        Me.RetrieveData(DataProviderActions.GoFirst, f)

        txtMargenPresupQMat.Value = CalcularMargen(txtImpPresupQMatVentaA.Value, txtImpPresupQMatA.Value)
        txtMargenPresupQMod.Value = CalcularMargen(txtImpPresupQModVentaA.Value, txtImpPresupQModA.Value)
        txtMargenPresupQCentro.Value = CalcularMargen(txtImpPresupCentrosQVentaA.Value, txtImpPresupQCentrosA.Value)
        txtMargenPresupQGastos.Value = CalcularMargen(txtImpPresupGastosQVentaA.Value, txtImpPresupQGastosA.Value)
        txtMargenPresupQVarios.Value = CalcularMargen(txtImpPresupVariosQVentaA.Value, txtImpPresupQVariosA.Value)

        txtMargenMat.Value = txtMargenPresupQMat.Value
        txtMargenMod.Value = txtMargenPresupQMod.Value
        txtMargenCentros.Value = txtMargenPresupQCentro.Value
        txtMargenGastos.Value = txtMargenPresupQGastos.Value
        txtMargenVarios.Value = txtMargenPresupQVarios.Value

        txtImpPresupQTrabajoA.Value = mImpCapitulo
        txtImpPresupQTrabajoVentaA.Value = mImpCapituloVenta
        txtMargenTrabajo.Value = CalcularMargen(mImpCapituloVenta, mImpCapitulo)

        If Not IsNothing(Me.CurrentData) AndAlso Me.CurrentData.Rows.Count > 0 Then
            If Not Nz(Me.CurrentData.Rows(0)("NoAcumular"), False) Then
                lblNoAcumula.Text = ExpertisApp.Traslate("ACUMULA EN TRABAJO")
            End If
        Else
            lblNoAcumula.Text = String.Empty
        End If
    End Sub

    Private Sub Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCerrar.Click
        Me.Close()
    End Sub

End Class
