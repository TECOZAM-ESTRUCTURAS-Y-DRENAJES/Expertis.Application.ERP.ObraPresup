Imports Solmicro.Expertis.Business.BC3
Public Class MntoObraPresup
    Inherits Solmicro.Expertis.Engine.UI.SimpleMnto

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
    Friend WithEvents pnlCabecera As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtDescPresup As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtRevPresup As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNumPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNumPresup As Solmicro.Expertis.Engine.UI.CounterTextBox
    Friend WithEvents lblEstado As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxEstado As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblBarra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents TabPresupuestos As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents TabPageCabeceraPresup As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageTrabajo As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageCaracteristicas As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageSeguimiento As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents lblTexto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents CmbUrlContrato As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtTexto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNumeroPedido As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNumeroPedido As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblURLContrato As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtURLContrato As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblFechaPeticion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaPeticion As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaEmision As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaEmision As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents GridCaracteristicas As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents OpenDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnlTrabajos As Solmicro.Expertis.Engine.UI.Panel
    Private WithEvents FraCriterios As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents rbtVerGrid As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtVerFicha As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents TabTrabajos As Solmicro.Expertis.Engine.UI.Tab
    Friend WithEvents GridMediciones As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents FraImportesMedicionesPresup As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblTotalMedicion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalMedicion As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FraTotalesMat As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents pnlConfigVerMaterial As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlVerMaterial As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlConfigVerMod As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlVerMOD As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlConfigVerCentros As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlVerCentros As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlConfigVerGastos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlVerGastos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlConfigVerVarios As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlVerVarios As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlConfigVerMediciones As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlVerMediciones As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraTotalesMOD As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraTotalesCentros As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraTotalesGastos As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraTotalesVarios As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblTotalMaterialVenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalMaterialVenta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalMaterial As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalMODVenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalMODVenta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalMOD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalMOD As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalCentrosVenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalCentrosVenta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalCentros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalCentros As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalGastosVenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalGastosVenta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalGastos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalGastos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalVariosVenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalVariosVenta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTotalVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotalVarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblVerPresupMat As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents rbtPresupMat As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents txtQPresupTrabajoMat As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtDescTrabajoMat As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajoMat As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoMat As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblVerPresupMod As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents rbtPresupMod As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents txtDescTrabajoMod As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajoMod As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoMod As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblVerPresupCentros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents rbtPresupCentros As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents txtDescTrabajoCentros As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajoCentro As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoCentros As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblVerPresupGastos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents rbtPresupGastos As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents txtDescTrabajoGastos As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajoGasto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoGastos As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblVerPresupVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents rbtPresupVarios As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents txtDescTrabajoVarios As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajoVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoVarios As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblVerPresupMedicion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents rbtPresupMedicion As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents txtDescTrabajoMediciones As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajoMedicion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoMedicion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents pnlFicha As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents GridGastos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridVarios As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents pnlGridTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraImportesTrabajoGrid As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents FraImportesTrabajoFicha As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents pnlFichaTrabajoTop As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents AdvSubTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FraSeguimiento As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents txtNivelTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNivelTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FraFechasTrabajo As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblFechaFinTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaFinTrabajo As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaInicioTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaInicioTrabajo As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblCentroGestionTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxIDCentroGestion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblNumPedido As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNumPedido As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblSolapeAnt As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtSolapeAnt As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblSecuencia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtSecuencia As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblIDArticulo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvIDArticulo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents chkNoAcumular As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblUDMedida As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxIDUDMedida As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblImpUnitario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpUnitario As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblSubTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents TabPageTrabajos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageMateriales As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageMOD As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageCentros As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageGastos As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageVarios As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents TabPageMediciones As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents txtPresupVentaTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtPresupTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblQPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtQPresup As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblQPresupMod As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQPresupCentros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPresupTrabajoFicha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDuracionPresup As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDuracionPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtQPresupTrabajoMod As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtQPresupTrabajoCentros As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPresupTrabajoVentaFicha As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPresupTrabajoVentaGrid As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPresupVentaTrabajoGrid As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPresupTrabajoGrid As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPresupTrabajoGrid As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblVerPresupTrabajos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtDescTrabajoGrid As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajoGrid As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoGrid As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblQPresupMat As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents pnlConfigVerGridTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlVerTrabajo As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlDatosGenerales As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents pnlDatosEconomicos As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents FraFechas As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblFechaPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaPresup As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaValidez As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaValidez As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents lblFechaCierre As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxFechaCierre As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents FraClienteEmpresa As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblPoblacion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblProvincia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCodPostal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblEmpresa As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPoblacion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtCodPostal As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtProvincia As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDireccion As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblDireccion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescEmpresa As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvIDEmpresa As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblCliente As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescCliente As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvIDCliente As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FraLinea As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtNObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTipoObra As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ulDescTipoObra As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvIDTipoObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents FraImportes As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents lblImpPresupVenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblPorcVenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMateriales As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Line1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblGastos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCentros As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMOD As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCostePresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTotalUnitario As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents FraCondEconomicas As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents AdvIDDiaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescMoneda As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvIDMoneda As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDCondicionPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvIDFormaPago As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents fra As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents AdvIDTipoIVA As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblBeneficioIndustrial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtBeneficioIndustrial As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblCoefBaja As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCoefBaja As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblGastosGenerales As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtGastosGenerales As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents lblCosteDirecto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCosteIndirecto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents UiGroupBox2 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtPresupDirecto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtPresupVentaDirecto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtPresupIndirecto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtPresupVentaIndirecto As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents cbxTipoCoste As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents txtMargenMat As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenMod As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenCentro As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenGastos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenVarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQTrabajoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQTrabajoVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQModVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQCentrosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQGastosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQVariosVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQMatVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQVariosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQGastosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQCentrosA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupQModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents pnlFichaTrabajoFill As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtTextoTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTextoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpPresupA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents FraArbol As Solmicro.Expertis.Engine.UI.Frame
    Friend WithEvents rbtMinimizarTree As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtMaximizarTree As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents TvwTrabajos As System.Windows.Forms.TreeView
    Friend WithEvents cbxTipoLinea As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblTipoLinea As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTotalPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTotal As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTotal As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtImpPresupVentaABis As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTOTALPresupVenta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImporteIva As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents UiGroupBox3 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtTotalIva As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents AdvSubSubTipoTrabajo As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblSubSubTipoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtMargenTrabajoFicha As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpUnitarioVtaA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtImpUnitarioVta As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtMargenTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtTotalBeneficioIndustrial As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtTotalCoefBaja As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents txtTotalGastosGenerales As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents rbtPresupTrabajos As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorNivelTrabajos As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorMultinivelTrabajos As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorNivelMat As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorNivelMod As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorNivelCentros As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorNivelGastos As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorNivelVarios As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorNivelMedicion As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorMultinivelMat As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorMultinivelMod As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorMultinivelCentros As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorMultinivelGastos As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorMultinivelVarios As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents rbtPorMultinivelMedicion As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents lblMargenPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTipoCoste As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQPresupGastos As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtQPresupTrabajoGastos As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblQPresupVarios As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtQPresupTrabajoVarios As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblQPresupMediciones As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtQPresupTrabajoMediciones As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents GridMateriales As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridCentros As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridMOD As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents GridTrabajos As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents lblIncremento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIncremento As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents chkVerPorcentajes As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents txtMargenPresupTrabajo As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblCentroGestion As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents cbxCentroGestion As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents MnuNuevoTrabajo As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuNuevoTrabajoIncremento As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuDeleteTrabajo As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuDeleteIncremento As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuADDIncremento As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuNuevoConcepto As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuDesgloseTrabajo As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuVerFichaTrabajo As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MenuPresupuestos As Janus.Windows.UI.CommandBars.UIContextMenu
    Friend WithEvents MnuNuevoTrabajo1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuNuevoTrabajoIncremento1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuDeleteTrabajo1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuDeleteIncremento1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuNuevoConcepto1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuDesgloseTrabajo1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuVerFichaTrabajo1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuGuion As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuGuion2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuGuion4 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents MnuADDIncremento1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents rbtVerPresupuestoCompleto As Solmicro.Expertis.Engine.UI.RadioButton
    Friend WithEvents pnlTrabajosCompleto As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents TvwObraCompleta As System.Windows.Forms.TreeView
    Friend WithEvents pnlVerTrabajosCompleto As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents txtDescTrabajoCompleto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblTrabajoCompleto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTrabajoCompleto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ImageListTrabajoCompleto As System.Windows.Forms.ImageList
    Friend WithEvents lblTipoIVA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblDiaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMoneda As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblCondicionPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblFormaPago As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents UlblDescResponsable As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents AdvResponsable As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblResponsable As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblQUnitaria As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntxQUnidad As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents TabPageAportaciones As Janus.Windows.UI.Tab.UITabPage
    Friend WithEvents Panel2 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents GridAportaciones As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents btnCargarAport As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents GridTrabEstr As Solmicro.Expertis.Engine.UI.Grid
    Friend WithEvents cmbComercial As Solmicro.Expertis.Engine.UI.ComboBox
    Friend WithEvents lblComercial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents MnuGuion3 As Janus.Windows.UI.CommandBars.UICommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim cmbComercial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxEstado_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoLinea_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxTipoCoste_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDCentroGestion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxIDUDMedida_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridTrabajos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridTrabajos_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridMateriales_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMateriales_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridMOD_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMOD_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridCentros_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCentros_DesignTimeLayout_Reference_0 As Janus.Windows.Common.Layouts.JanusLayoutReference = New Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.ImageList.ImageStream")
        Dim GridGastos_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridVarios_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridMediciones_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridCaracteristicas_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim cbxCentroGestion_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridAportaciones_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim GridTrabEstr_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MntoObraPresup))
        Me.pnlCabecera = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbComercial = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblComercial = New Solmicro.Expertis.Engine.UI.Label
        Me.txtDescPresup = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtRevPresup = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNumPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNumPresup = New Solmicro.Expertis.Engine.UI.CounterTextBox
        Me.lblEstado = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxEstado = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblBarra = New Solmicro.Expertis.Engine.UI.Label
        Me.TabPresupuestos = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageCabeceraPresup = New Janus.Windows.UI.Tab.UITabPage
        Me.pnlDatosEconomicos = New Solmicro.Expertis.Engine.UI.Panel
        Me.fra = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtTotalBeneficioIndustrial = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTotalCoefBaja = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtTotalGastosGenerales = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.UiGroupBox3 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblImporteIva = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalIva = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTOTALPresupVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupVentaABis = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotal = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotal = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblBeneficioIndustrial = New Solmicro.Expertis.Engine.UI.Label
        Me.txtBeneficioIndustrial = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCoefBaja = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCoefBaja = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblGastosGenerales = New Solmicro.Expertis.Engine.UI.Label
        Me.txtGastosGenerales = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraImportes = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtMargenPresupTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.UiGroupBox2 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblCosteIndirecto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPresupIndirecto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPresupVentaIndirecto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCosteDirecto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPresupDirecto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPresupVentaDirecto = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox
        Me.txtMargenTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupQTrabajoVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPresupVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupQModVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupQCentrosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupQGastosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupQVariosVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtImpPresupQMatVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPorcVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMargenMat = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenMod = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenCentro = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenGastos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtMargenVarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMateriales = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupQMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Line1 = New Janus.Windows.EditControls.UIGroupBox
        Me.lblVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupQVariosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblGastos = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupQGastosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCentros = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupQCentrosA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMOD = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupQModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCostePresup = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTotalUnitario = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpPresupQTrabajoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.FraCondEconomicas = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTipoIVA = New Solmicro.Expertis.Engine.UI.Label
        Me.lblDiaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblMoneda = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCondicionPago = New Solmicro.Expertis.Engine.UI.Label
        Me.lblFormaPago = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDTipoIVA = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDDiaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescMoneda = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDMoneda = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDCondicionPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvIDFormaPago = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.pnlDatosGenerales = New Solmicro.Expertis.Engine.UI.Panel
        Me.FraFechas = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFechaPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaPresup = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaValidez = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaValidez = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaCierre = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaCierre = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.FraClienteEmpresa = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblPoblacion = New Solmicro.Expertis.Engine.UI.Label
        Me.lblProvincia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCodPostal = New Solmicro.Expertis.Engine.UI.Label
        Me.lblEmpresa = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPoblacion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodPostal = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtProvincia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDireccion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDireccion = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescEmpresa = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDEmpresa = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblCliente = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescCliente = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDCliente = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FraLinea = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblObra = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTipoObra = New Solmicro.Expertis.Engine.UI.Label
        Me.ulDescTipoObra = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvIDTipoObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.TabPageTrabajo = New Janus.Windows.UI.Tab.UITabPage
        Me.TabTrabajos = New Solmicro.Expertis.Engine.UI.Tab
        Me.TabPageTrabajos = New Janus.Windows.UI.Tab.UITabPage
        Me.pnlFicha = New Solmicro.Expertis.Engine.UI.Panel
        Me.pnlFichaTrabajoFill = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtTextoTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTextoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.FraImportesTrabajoFicha = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtPresupVentaTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtPresupTrabajo = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPresupTrabajoFicha = New Solmicro.Expertis.Engine.UI.Label
        Me.lblPresupTrabajoVentaFicha = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlFichaTrabajoTop = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblQUnitaria = New Solmicro.Expertis.Engine.UI.Label
        Me.ntxQUnidad = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblIncremento = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIncremento = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMargenPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.txtMargenTrabajoFicha = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.AdvSubSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblSubSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTipoLinea = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoLinea = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTipoCoste = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxTipoCoste = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.AdvSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTipoTrabajo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.FraSeguimiento = New Solmicro.Expertis.Engine.UI.Frame
        Me.txtDuracionPresup = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtNivelTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNivelTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.FraFechasTrabajo = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblFechaFinTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaFinTrabajo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaInicioTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaInicioTrabajo = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblCentroGestionTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDCentroGestion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblNumPedido = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNumPedido = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSolapeAnt = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSolapeAnt = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSecuencia = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSecuencia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblDuracionPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDArticulo = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDArticulo = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.chkNoAcumular = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblUDMedida = New Solmicro.Expertis.Engine.UI.Label
        Me.lblQPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDUDMedida = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblImpUnitarioVtaA = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpUnitarioVta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpUnitario = New Solmicro.Expertis.Engine.UI.Label
        Me.txtImpUnitario = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtQPresup = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSubTipoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlGridTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridTrabajos = New Solmicro.Expertis.Engine.UI.Grid
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pnlVerTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajoGrid = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoGrid = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoGrid = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlConfigVerGridTrabajo = New Solmicro.Expertis.Engine.UI.Panel
        Me.rbtPorMultinivelTrabajos = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerPresupTrabajos = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtPorNivelTrabajos = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtPresupTrabajos = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.FraImportesTrabajoGrid = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblPresupTrabajoVentaGrid = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPresupVentaTrabajoGrid = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPresupTrabajoGrid = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPresupTrabajoGrid = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pnlTrabajosCompleto = New Solmicro.Expertis.Engine.UI.Panel
        Me.TvwObraCompleta = New System.Windows.Forms.TreeView
        Me.pnlVerTrabajosCompleto = New Solmicro.Expertis.Engine.UI.Panel
        Me.txtDescTrabajoCompleto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoCompleto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoCompleto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.TabPageMateriales = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMateriales = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraTotalesMat = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalMaterialVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalMaterialVenta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalMaterial = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pnlVerMaterial = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblQPresupMat = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQPresupTrabajoMat = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtDescTrabajoMat = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoMat = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoMat = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlConfigVerMaterial = New Solmicro.Expertis.Engine.UI.Panel
        Me.rbtPorMultinivelMat = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerPresupMat = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtPorNivelMat = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtPresupMat = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.TabPageMOD = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMOD = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraTotalesMOD = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalMODVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalMODVenta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalMOD = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalMOD = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pnlVerMOD = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblQPresupMod = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQPresupTrabajoMod = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtDescTrabajoMod = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoMod = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoMod = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlConfigVerMod = New Solmicro.Expertis.Engine.UI.Panel
        Me.rbtPorMultinivelMod = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerPresupMod = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtPorNivelMod = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtPresupMod = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.TabPageCentros = New Janus.Windows.UI.Tab.UITabPage
        Me.GridCentros = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraTotalesCentros = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalCentrosVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalCentrosVenta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalCentros = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalCentros = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pnlVerCentros = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblQPresupCentros = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQPresupTrabajoCentros = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtDescTrabajoCentros = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoCentro = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoCentros = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlConfigVerCentros = New Solmicro.Expertis.Engine.UI.Panel
        Me.rbtPorMultinivelCentros = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerPresupCentros = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtPorNivelCentros = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtPresupCentros = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.TabPageGastos = New Janus.Windows.UI.Tab.UITabPage
        Me.GridGastos = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraTotalesGastos = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalGastosVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalGastosVenta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalGastos = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalGastos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pnlVerGastos = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblQPresupGastos = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQPresupTrabajoGastos = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtDescTrabajoGastos = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoGasto = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoGastos = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlConfigVerGastos = New Solmicro.Expertis.Engine.UI.Panel
        Me.rbtPorMultinivelGastos = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerPresupGastos = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtPorNivelGastos = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtPresupGastos = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.TabPageVarios = New Janus.Windows.UI.Tab.UITabPage
        Me.GridVarios = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraTotalesVarios = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalVariosVenta = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalVariosVenta = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTotalVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalVarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pnlVerVarios = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblQPresupVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQPresupTrabajoVarios = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtDescTrabajoVarios = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoVarios = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlConfigVerVarios = New Solmicro.Expertis.Engine.UI.Panel
        Me.rbtPorMultinivelVarios = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerPresupVarios = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtPorNivelVarios = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtPresupVarios = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.TabPageMediciones = New Janus.Windows.UI.Tab.UITabPage
        Me.GridMediciones = New Solmicro.Expertis.Engine.UI.Grid
        Me.FraImportesMedicionesPresup = New Solmicro.Expertis.Engine.UI.Frame
        Me.lblTotalMedicion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTotalMedicion = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.pnlVerMediciones = New Solmicro.Expertis.Engine.UI.Panel
        Me.lblQPresupMediciones = New Solmicro.Expertis.Engine.UI.Label
        Me.txtQPresupTrabajoMediciones = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.txtDescTrabajoMediciones = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblTrabajoMedicion = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTrabajoMedicion = New Solmicro.Expertis.Engine.UI.TextBox
        Me.pnlConfigVerMediciones = New Solmicro.Expertis.Engine.UI.Panel
        Me.rbtPorMultinivelMedicion = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.lblVerPresupMedicion = New Solmicro.Expertis.Engine.UI.Label
        Me.rbtPorNivelMedicion = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtPresupMedicion = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.pnlTrabajos = New Solmicro.Expertis.Engine.UI.Panel
        Me.TvwTrabajos = New System.Windows.Forms.TreeView
        Me.FraArbol = New Solmicro.Expertis.Engine.UI.Frame
        Me.chkVerPorcentajes = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.rbtMinimizarTree = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtMaximizarTree = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.FraCriterios = New Solmicro.Expertis.Engine.UI.Frame
        Me.rbtVerPresupuestoCompleto = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtVerGrid = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.rbtVerFicha = New Solmicro.Expertis.Engine.UI.RadioButton
        Me.TabPageCaracteristicas = New Janus.Windows.UI.Tab.UITabPage
        Me.GridCaracteristicas = New Solmicro.Expertis.Engine.UI.Grid
        Me.TabPageSeguimiento = New Janus.Windows.UI.Tab.UITabPage
        Me.UlblDescResponsable = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.AdvResponsable = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblResponsable = New Solmicro.Expertis.Engine.UI.Label
        Me.lblCentroGestion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxCentroGestion = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.lblTexto = New Solmicro.Expertis.Engine.UI.Label
        Me.CmbUrlContrato = New Solmicro.Expertis.Engine.UI.Button
        Me.txtTexto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNumeroPedido = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNumeroPedido = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblURLContrato = New Solmicro.Expertis.Engine.UI.Label
        Me.txtURLContrato = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblFechaPeticion = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaPeticion = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.lblFechaEmision = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxFechaEmision = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.TabPageAportaciones = New Janus.Windows.UI.Tab.UITabPage
        Me.Panel2 = New Solmicro.Expertis.Engine.UI.Panel
        Me.GridAportaciones = New Solmicro.Expertis.Engine.UI.Grid
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.btnCargarAport = New Solmicro.Expertis.Engine.UI.Button
        Me.GridTrabEstr = New Solmicro.Expertis.Engine.UI.Grid
        Me.OpenDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.MnuNuevoTrabajo = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevoTrabajo")
        Me.MnuNuevoTrabajoIncremento = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevoTrabajoIncremento")
        Me.MnuDeleteTrabajo = New Janus.Windows.UI.CommandBars.UICommand("MnuDeleteTrabajo")
        Me.MnuDeleteIncremento = New Janus.Windows.UI.CommandBars.UICommand("MnuDeleteIncremento")
        Me.MnuADDIncremento = New Janus.Windows.UI.CommandBars.UICommand("MnuADDIncremento")
        Me.MnuNuevoConcepto = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevoConcepto")
        Me.MnuDesgloseTrabajo = New Janus.Windows.UI.CommandBars.UICommand("MnuDesgloseTrabajo")
        Me.MnuVerFichaTrabajo = New Janus.Windows.UI.CommandBars.UICommand("MnuVerFichaTrabajo")
        Me.MenuPresupuestos = New Janus.Windows.UI.CommandBars.UIContextMenu
        Me.MnuNuevoTrabajo1 = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevoTrabajo")
        Me.MnuNuevoTrabajoIncremento1 = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevoTrabajoIncremento")
        Me.MnuGuion = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion")
        Me.MnuDeleteTrabajo1 = New Janus.Windows.UI.CommandBars.UICommand("MnuDeleteTrabajo")
        Me.MnuDeleteIncremento1 = New Janus.Windows.UI.CommandBars.UICommand("MnuDeleteIncremento")
        Me.MnuGuion2 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion2")
        Me.MnuADDIncremento1 = New Janus.Windows.UI.CommandBars.UICommand("MnuADDIncremento")
        Me.MnuGuion3 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion3")
        Me.MnuNuevoConcepto1 = New Janus.Windows.UI.CommandBars.UICommand("MnuNuevoConcepto")
        Me.MnuGuion4 = New Janus.Windows.UI.CommandBars.UICommand("MnuGuion4")
        Me.MnuDesgloseTrabajo1 = New Janus.Windows.UI.CommandBars.UICommand("MnuDesgloseTrabajo")
        Me.MnuVerFichaTrabajo1 = New Janus.Windows.UI.CommandBars.UICommand("MnuVerFichaTrabajo")
        Me.ImageListTrabajoCompleto = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.suspendlayout()
        Me.pnlCabecera.suspendlayout()
        CType(Me.cmbComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPresupuestos.SuspendLayout()
        Me.TabPageCabeceraPresup.SuspendLayout()
        Me.pnlDatosEconomicos.suspendlayout()
        Me.fra.SuspendLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraImportes.SuspendLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraCondEconomicas.SuspendLayout()
        Me.pnlDatosGenerales.suspendlayout()
        Me.FraFechas.SuspendLayout()
        Me.FraClienteEmpresa.SuspendLayout()
        Me.TabPageTrabajo.SuspendLayout()
        CType(Me.TabTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTrabajos.SuspendLayout()
        Me.TabPageTrabajos.SuspendLayout()
        Me.pnlFicha.suspendlayout()
        Me.pnlFichaTrabajoFill.suspendlayout()
        Me.FraImportesTrabajoFicha.SuspendLayout()
        Me.pnlFichaTrabajoTop.suspendlayout()
        CType(Me.cbxTipoLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxTipoCoste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraSeguimiento.SuspendLayout()
        Me.FraFechasTrabajo.SuspendLayout()
        CType(Me.cbxIDCentroGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbxIDUDMedida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGridTrabajo.suspendlayout()
        CType(Me.GridTrabajos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlVerTrabajo.suspendlayout()
        Me.pnlConfigVerGridTrabajo.suspendlayout()
        Me.FraImportesTrabajoGrid.SuspendLayout()
        Me.pnlTrabajosCompleto.suspendlayout()
        Me.pnlVerTrabajosCompleto.suspendlayout()
        Me.TabPageMateriales.SuspendLayout()
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraTotalesMat.SuspendLayout()
        Me.pnlVerMaterial.suspendlayout()
        Me.pnlConfigVerMaterial.suspendlayout()
        Me.TabPageMOD.SuspendLayout()
        CType(Me.GridMOD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraTotalesMOD.SuspendLayout()
        Me.pnlVerMOD.suspendlayout()
        Me.pnlConfigVerMod.suspendlayout()
        Me.TabPageCentros.SuspendLayout()
        CType(Me.GridCentros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraTotalesCentros.SuspendLayout()
        Me.pnlVerCentros.suspendlayout()
        Me.pnlConfigVerCentros.suspendlayout()
        Me.TabPageGastos.SuspendLayout()
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraTotalesGastos.SuspendLayout()
        Me.pnlVerGastos.suspendlayout()
        Me.pnlConfigVerGastos.suspendlayout()
        Me.TabPageVarios.SuspendLayout()
        CType(Me.GridVarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraTotalesVarios.SuspendLayout()
        Me.pnlVerVarios.suspendlayout()
        Me.pnlConfigVerVarios.suspendlayout()
        Me.TabPageMediciones.SuspendLayout()
        CType(Me.GridMediciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraImportesMedicionesPresup.SuspendLayout()
        Me.pnlVerMediciones.suspendlayout()
        Me.pnlConfigVerMediciones.suspendlayout()
        Me.pnlTrabajos.suspendlayout()
        Me.FraArbol.SuspendLayout()
        Me.FraCriterios.SuspendLayout()
        Me.TabPageCaracteristicas.SuspendLayout()
        CType(Me.GridCaracteristicas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageSeguimiento.SuspendLayout()
        CType(Me.cbxCentroGestion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageAportaciones.SuspendLayout()
        Me.Panel2.suspendlayout()
        CType(Me.GridAportaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.suspendlayout()
        CType(Me.GridTrabEstr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuPresupuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Duplicate
        '
        Me.Duplicate.Enabled = Janus.Windows.UI.InheritableBoolean.[True]
        '
        'ToolBar
        '
        Me.ToolBar.Size = New System.Drawing.Size(721, 39)
        '
        'MenuBar
        '
        Me.MenuBar.Location = New System.Drawing.Point(0, 42)
        Me.MenuBar.Size = New System.Drawing.Size(504, 26)
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.MnuNuevoTrabajo, Me.MnuNuevoTrabajoIncremento, Me.MnuDeleteTrabajo, Me.MnuDeleteIncremento, Me.MnuADDIncremento, Me.MnuNuevoConcepto, Me.MnuDesgloseTrabajo, Me.MnuVerFichaTrabajo})
        Me.UiCommandManager1.ContextMenus.AddRange(New Janus.Windows.UI.CommandBars.UIContextMenu() {Me.MenuPresupuestos})
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.TabPresupuestos)
        Me.MainPanel.Controls.Add(Me.pnlCabecera)
        Me.MainPanel.Size = New System.Drawing.Size(784, 493)
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Controls.Add(Me.cmbComercial)
        Me.pnlCabecera.Controls.Add(Me.lblComercial)
        Me.pnlCabecera.Controls.Add(Me.txtDescPresup)
        Me.pnlCabecera.Controls.Add(Me.txtRevPresup)
        Me.pnlCabecera.Controls.Add(Me.lblNumPresup)
        Me.pnlCabecera.Controls.Add(Me.txtNumPresup)
        Me.pnlCabecera.Controls.Add(Me.lblEstado)
        Me.pnlCabecera.Controls.Add(Me.cbxEstado)
        Me.pnlCabecera.Controls.Add(Me.lblBarra)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(784, 29)
        Me.pnlCabecera.TabIndex = 42
        '
        'cmbComercial
        '
        Me.TryDataBinding(cmbComercial, New System.Windows.Forms.Binding("Value", Me, "Comercial", True))
        cmbComercial_DesignTimeLayout.LayoutString = resources.GetString("cmbComercial_DesignTimeLayout.LayoutString")
        Me.cmbComercial.DesignTimeLayout = cmbComercial_DesignTimeLayout
        Me.cmbComercial.DisabledBackColor = System.Drawing.Color.White
        Me.cmbComercial.DisplayMember = "Usuario"
        Me.cmbComercial.EntityName = "ObraEstudioUsuario"
        Me.cmbComercial.Location = New System.Drawing.Point(680, 5)
        Me.cmbComercial.Name = "cmbComercial"
        Me.cmbComercial.SecondaryDataFields = "Usuario"
        Me.cmbComercial.SelectedIndex = -1
        Me.cmbComercial.SelectedItem = Nothing
        Me.cmbComercial.Size = New System.Drawing.Size(96, 21)
        Me.cmbComercial.TabIndex = 6
        Me.cmbComercial.ValueMember = "Usuario"
        '
        'lblComercial
        '
        Me.lblComercial.Location = New System.Drawing.Point(633, 8)
        Me.lblComercial.Name = "lblComercial"
        Me.lblComercial.Size = New System.Drawing.Size(65, 13)
        Me.lblComercial.TabIndex = 7
        Me.lblComercial.Text = "Comercial"
        '
        'txtDescPresup
        '
        Me.TryDataBinding(txtDescPresup, New System.Windows.Forms.Binding("Text", Me, "DescPresup", True))
        Me.txtDescPresup.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescPresup.Location = New System.Drawing.Point(215, 4)
        Me.txtDescPresup.Name = "txtDescPresup"
        Me.txtDescPresup.Size = New System.Drawing.Size(271, 21)
        Me.txtDescPresup.TabIndex = 2
        '
        'txtRevPresup
        '
        Me.TryDataBinding(txtRevPresup, New System.Windows.Forms.Binding("Text", Me, "RevPresup", True))
        Me.txtRevPresup.DisabledBackColor = System.Drawing.Color.White
        Me.txtRevPresup.Enabled = False
        Me.txtRevPresup.Location = New System.Drawing.Point(182, 4)
        Me.txtRevPresup.Name = "txtRevPresup"
        Me.txtRevPresup.Size = New System.Drawing.Size(27, 21)
        Me.txtRevPresup.TabIndex = 1
        Me.txtRevPresup.TabStop = False
        '
        'lblNumPresup
        '
        Me.lblNumPresup.Location = New System.Drawing.Point(6, 8)
        Me.lblNumPresup.Name = "lblNumPresup"
        Me.lblNumPresup.Size = New System.Drawing.Size(77, 13)
        Me.lblNumPresup.TabIndex = 3
        Me.lblNumPresup.Tag = "IdRec=0;"
        Me.lblNumPresup.Text = "Presupuesto"
        '
        'txtNumPresup
        '
        Me.TryDataBinding(txtNumPresup, New System.Windows.Forms.Binding("Text", Me, "NumPresup", True))
        Me.txtNumPresup.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumPresup.Location = New System.Drawing.Point(85, 4)
        Me.txtNumPresup.Name = "txtNumPresup"
        Me.txtNumPresup.Size = New System.Drawing.Size(83, 23)
        Me.txtNumPresup.TabIndex = 0
        '
        'lblEstado
        '
        Me.lblEstado.Location = New System.Drawing.Point(492, 9)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(45, 13)
        Me.lblEstado.TabIndex = 4
        Me.lblEstado.Tag = "IdRec=4405;"
        Me.lblEstado.Text = "Estado"
        '
        'cbxEstado
        '
        Me.cbxEstado.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        Me.TryDataBinding(cbxEstado, New System.Windows.Forms.Binding("Value", Me, "Estado", True))
        cbxEstado_DesignTimeLayout.LayoutString = resources.GetString("cbxEstado_DesignTimeLayout.LayoutString")
        Me.cbxEstado.DesignTimeLayout = cbxEstado_DesignTimeLayout
        Me.cbxEstado.DisabledBackColor = System.Drawing.Color.White
        Me.cbxEstado.DisplayMember = "DescEstado"
        Me.cbxEstado.EntityName = "ObraEstadoPresupuesto"
        Me.cbxEstado.Location = New System.Drawing.Point(529, 4)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.SelectedIndex = -1
        Me.cbxEstado.SelectedItem = Nothing
        Me.cbxEstado.Size = New System.Drawing.Size(98, 21)
        Me.cbxEstado.TabIndex = 3
        Me.cbxEstado.ValueMember = "IDEstado"
        '
        'lblBarra
        '
        Me.lblBarra.Location = New System.Drawing.Point(169, 8)
        Me.lblBarra.Name = "lblBarra"
        Me.lblBarra.Size = New System.Drawing.Size(12, 13)
        Me.lblBarra.TabIndex = 5
        Me.lblBarra.Tag = "IdRec=5290;"
        Me.lblBarra.Text = "/"
        '
        'TabPresupuestos
        '
        Me.TabPresupuestos.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabPresupuestos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabPresupuestos.Location = New System.Drawing.Point(0, 29)
        Me.TabPresupuestos.Name = "TabPresupuestos"
        Me.TabPresupuestos.Size = New System.Drawing.Size(784, 464)
        Me.TabPresupuestos.TabIndex = 4
        Me.TabPresupuestos.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageCabeceraPresup, Me.TabPageTrabajo, Me.TabPageCaracteristicas, Me.TabPageSeguimiento, Me.TabPageAportaciones})
        Me.TabPresupuestos.Text = "Seguimiento"
        Me.TabPresupuestos.UseThemes = True
        '
        'TabPageCabeceraPresup
        '
        Me.TabPageCabeceraPresup.Controls.Add(Me.pnlDatosEconomicos)
        Me.TabPageCabeceraPresup.Controls.Add(Me.pnlDatosGenerales)
        Me.TabPageCabeceraPresup.Key = "Cabecera"
        Me.TabPageCabeceraPresup.Location = New System.Drawing.Point(1, 21)
        Me.TabPageCabeceraPresup.Name = "TabPageCabeceraPresup"
        Me.TabPageCabeceraPresup.Size = New System.Drawing.Size(782, 442)
        Me.TabPageCabeceraPresup.TabStop = True
        Me.TabPageCabeceraPresup.Text = "Cabecera Presupuesto"
        '
        'pnlDatosEconomicos
        '
        Me.pnlDatosEconomicos.Controls.Add(Me.fra)
        Me.pnlDatosEconomicos.Controls.Add(Me.FraImportes)
        Me.pnlDatosEconomicos.Controls.Add(Me.FraCondEconomicas)
        Me.pnlDatosEconomicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDatosEconomicos.Location = New System.Drawing.Point(0, 168)
        Me.pnlDatosEconomicos.Name = "pnlDatosEconomicos"
        Me.pnlDatosEconomicos.Size = New System.Drawing.Size(782, 274)
        Me.pnlDatosEconomicos.TabIndex = 108
        '
        'fra
        '
        Me.fra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.fra.Controls.Add(Me.txtTotalBeneficioIndustrial)
        Me.fra.Controls.Add(Me.txtTotalCoefBaja)
        Me.fra.Controls.Add(Me.txtTotalGastosGenerales)
        Me.fra.Controls.Add(Me.UiGroupBox3)
        Me.fra.Controls.Add(Me.lblImporteIva)
        Me.fra.Controls.Add(Me.txtTotalIva)
        Me.fra.Controls.Add(Me.lblTOTALPresupVenta)
        Me.fra.Controls.Add(Me.txtImpPresupVentaABis)
        Me.fra.Controls.Add(Me.lblTotal)
        Me.fra.Controls.Add(Me.txtTotal)
        Me.fra.Controls.Add(Me.lblBeneficioIndustrial)
        Me.fra.Controls.Add(Me.txtBeneficioIndustrial)
        Me.fra.Controls.Add(Me.lblCoefBaja)
        Me.fra.Controls.Add(Me.txtCoefBaja)
        Me.fra.Controls.Add(Me.lblGastosGenerales)
        Me.fra.Controls.Add(Me.txtGastosGenerales)
        Me.fra.Location = New System.Drawing.Point(441, 104)
        Me.fra.Name = "fra"
        Me.fra.Size = New System.Drawing.Size(338, 163)
        Me.fra.TabIndex = 75
        Me.fra.TabStop = False
        '
        'txtTotalBeneficioIndustrial
        '
        Me.txtTotalBeneficioIndustrial.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalBeneficioIndustrial.Enabled = False
        Me.txtTotalBeneficioIndustrial.Location = New System.Drawing.Point(212, 61)
        Me.txtTotalBeneficioIndustrial.Name = "txtTotalBeneficioIndustrial"
        Me.txtTotalBeneficioIndustrial.Size = New System.Drawing.Size(120, 21)
        Me.txtTotalBeneficioIndustrial.TabIndex = 124
        Me.txtTotalBeneficioIndustrial.TabStop = False
        '
        'txtTotalCoefBaja
        '
        Me.txtTotalCoefBaja.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalCoefBaja.Enabled = False
        Me.txtTotalCoefBaja.Location = New System.Drawing.Point(212, 85)
        Me.txtTotalCoefBaja.Name = "txtTotalCoefBaja"
        Me.txtTotalCoefBaja.Size = New System.Drawing.Size(120, 21)
        Me.txtTotalCoefBaja.TabIndex = 125
        Me.txtTotalCoefBaja.TabStop = False
        '
        'txtTotalGastosGenerales
        '
        Me.txtTotalGastosGenerales.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalGastosGenerales.Enabled = False
        Me.txtTotalGastosGenerales.Location = New System.Drawing.Point(212, 37)
        Me.txtTotalGastosGenerales.Name = "txtTotalGastosGenerales"
        Me.txtTotalGastosGenerales.Size = New System.Drawing.Size(120, 21)
        Me.txtTotalGastosGenerales.TabIndex = 123
        Me.txtTotalGastosGenerales.TabStop = False
        '
        'UiGroupBox3
        '
        Me.UiGroupBox3.Location = New System.Drawing.Point(7, 132)
        Me.UiGroupBox3.Name = "UiGroupBox3"
        Me.UiGroupBox3.Size = New System.Drawing.Size(327, 3)
        Me.UiGroupBox3.TabIndex = 122
        '
        'lblImporteIva
        '
        Me.lblImporteIva.Location = New System.Drawing.Point(6, 113)
        Me.lblImporteIva.Name = "lblImporteIva"
        Me.lblImporteIva.Size = New System.Drawing.Size(38, 13)
        Me.lblImporteIva.TabIndex = 121
        Me.lblImporteIva.Text = "I.V.A."
        '
        'txtTotalIva
        '
        Me.txtTotalIva.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalIva.Enabled = False
        Me.txtTotalIva.Location = New System.Drawing.Point(212, 109)
        Me.txtTotalIva.Name = "txtTotalIva"
        Me.txtTotalIva.Size = New System.Drawing.Size(120, 21)
        Me.txtTotalIva.TabIndex = 120
        Me.txtTotalIva.TabStop = False
        '
        'lblTOTALPresupVenta
        '
        Me.lblTOTALPresupVenta.Location = New System.Drawing.Point(6, 17)
        Me.lblTOTALPresupVenta.Name = "lblTOTALPresupVenta"
        Me.lblTOTALPresupVenta.Size = New System.Drawing.Size(126, 13)
        Me.lblTOTALPresupVenta.TabIndex = 119
        Me.lblTOTALPresupVenta.Text = "TOTAL Presup. Venta"
        '
        'txtImpPresupVentaABis
        '
        Me.TryDataBinding(txtImpPresupVentaABis, New System.Windows.Forms.Binding("Value", Me, "ImpPresupVentaA", True))
        Me.txtImpPresupVentaABis.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupVentaABis.Enabled = False
        Me.txtImpPresupVentaABis.Location = New System.Drawing.Point(212, 13)
        Me.txtImpPresupVentaABis.Name = "txtImpPresupVentaABis"
        Me.txtImpPresupVentaABis.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupVentaABis.TabIndex = 118
        Me.txtImpPresupVentaABis.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(6, 141)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(43, 13)
        Me.lblTotal.TabIndex = 117
        Me.lblTotal.Text = "TOTAL"
        '
        'txtTotal
        '
        Me.txtTotal.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(212, 137)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(120, 21)
        Me.txtTotal.TabIndex = 116
        Me.txtTotal.TabStop = False
        '
        'lblBeneficioIndustrial
        '
        Me.lblBeneficioIndustrial.Location = New System.Drawing.Point(6, 65)
        Me.lblBeneficioIndustrial.Name = "lblBeneficioIndustrial"
        Me.lblBeneficioIndustrial.Size = New System.Drawing.Size(143, 13)
        Me.lblBeneficioIndustrial.TabIndex = 113
        Me.lblBeneficioIndustrial.Text = "Beneficio Industrial (%)"
        '
        'txtBeneficioIndustrial
        '
        Me.TryDataBinding(txtBeneficioIndustrial, New System.Windows.Forms.Binding("Value", Me, "BeneficioIndustrial", True))
        Me.txtBeneficioIndustrial.DisabledBackColor = System.Drawing.Color.White
        Me.txtBeneficioIndustrial.Location = New System.Drawing.Point(146, 61)
        Me.txtBeneficioIndustrial.Name = "txtBeneficioIndustrial"
        Me.txtBeneficioIndustrial.Size = New System.Drawing.Size(63, 21)
        Me.txtBeneficioIndustrial.TabIndex = 17
        '
        'lblCoefBaja
        '
        Me.lblCoefBaja.Location = New System.Drawing.Point(6, 89)
        Me.lblCoefBaja.Name = "lblCoefBaja"
        Me.lblCoefBaja.Size = New System.Drawing.Size(127, 13)
        Me.lblCoefBaja.TabIndex = 114
        Me.lblCoefBaja.Text = "Coeficiente Baja (%)"
        '
        'txtCoefBaja
        '
        Me.TryDataBinding(txtCoefBaja, New System.Windows.Forms.Binding("Value", Me, "CoefBaja", True))
        Me.txtCoefBaja.DisabledBackColor = System.Drawing.Color.White
        Me.txtCoefBaja.Location = New System.Drawing.Point(146, 85)
        Me.txtCoefBaja.Name = "txtCoefBaja"
        Me.txtCoefBaja.Size = New System.Drawing.Size(63, 21)
        Me.txtCoefBaja.TabIndex = 18
        '
        'lblGastosGenerales
        '
        Me.lblGastosGenerales.Location = New System.Drawing.Point(6, 41)
        Me.lblGastosGenerales.Name = "lblGastosGenerales"
        Me.lblGastosGenerales.Size = New System.Drawing.Size(134, 13)
        Me.lblGastosGenerales.TabIndex = 115
        Me.lblGastosGenerales.Text = "Gastos Generales (%)"
        '
        'txtGastosGenerales
        '
        Me.TryDataBinding(txtGastosGenerales, New System.Windows.Forms.Binding("Value", Me, "GastosGenerales", True))
        Me.txtGastosGenerales.DisabledBackColor = System.Drawing.Color.White
        Me.txtGastosGenerales.Location = New System.Drawing.Point(146, 37)
        Me.txtGastosGenerales.Name = "txtGastosGenerales"
        Me.txtGastosGenerales.Size = New System.Drawing.Size(63, 21)
        Me.txtGastosGenerales.TabIndex = 16
        '
        'FraImportes
        '
        Me.FraImportes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FraImportes.Controls.Add(Me.txtMargenPresupTrabajo)
        Me.FraImportes.Controls.Add(Me.UiGroupBox2)
        Me.FraImportes.Controls.Add(Me.lblCosteIndirecto)
        Me.FraImportes.Controls.Add(Me.txtPresupIndirecto)
        Me.FraImportes.Controls.Add(Me.txtPresupVentaIndirecto)
        Me.FraImportes.Controls.Add(Me.lblCosteDirecto)
        Me.FraImportes.Controls.Add(Me.txtPresupDirecto)
        Me.FraImportes.Controls.Add(Me.txtPresupVentaDirecto)
        Me.FraImportes.Controls.Add(Me.UiGroupBox1)
        Me.FraImportes.Controls.Add(Me.txtMargenTrabajo)
        Me.FraImportes.Controls.Add(Me.lblTotalPresup)
        Me.FraImportes.Controls.Add(Me.txtImpPresupA)
        Me.FraImportes.Controls.Add(Me.txtImpPresupVentaA)
        Me.FraImportes.Controls.Add(Me.txtImpPresupQTrabajoVentaA)
        Me.FraImportes.Controls.Add(Me.lblImpPresupVenta)
        Me.FraImportes.Controls.Add(Me.txtImpPresupQModVentaA)
        Me.FraImportes.Controls.Add(Me.txtImpPresupQCentrosVentaA)
        Me.FraImportes.Controls.Add(Me.txtImpPresupQGastosVentaA)
        Me.FraImportes.Controls.Add(Me.txtImpPresupQVariosVentaA)
        Me.FraImportes.Controls.Add(Me.txtImpPresupQMatVentaA)
        Me.FraImportes.Controls.Add(Me.lblPorcVenta)
        Me.FraImportes.Controls.Add(Me.txtMargenMat)
        Me.FraImportes.Controls.Add(Me.txtMargenMod)
        Me.FraImportes.Controls.Add(Me.txtMargenCentro)
        Me.FraImportes.Controls.Add(Me.txtMargenGastos)
        Me.FraImportes.Controls.Add(Me.txtMargenVarios)
        Me.FraImportes.Controls.Add(Me.lblMateriales)
        Me.FraImportes.Controls.Add(Me.txtImpPresupQMatA)
        Me.FraImportes.Controls.Add(Me.Line1)
        Me.FraImportes.Controls.Add(Me.lblVarios)
        Me.FraImportes.Controls.Add(Me.txtImpPresupQVariosA)
        Me.FraImportes.Controls.Add(Me.lblGastos)
        Me.FraImportes.Controls.Add(Me.txtImpPresupQGastosA)
        Me.FraImportes.Controls.Add(Me.lblCentros)
        Me.FraImportes.Controls.Add(Me.txtImpPresupQCentrosA)
        Me.FraImportes.Controls.Add(Me.lblMOD)
        Me.FraImportes.Controls.Add(Me.txtImpPresupQModA)
        Me.FraImportes.Controls.Add(Me.lblCostePresup)
        Me.FraImportes.Controls.Add(Me.lblTotalUnitario)
        Me.FraImportes.Controls.Add(Me.txtImpPresupQTrabajoA)
        Me.FraImportes.Location = New System.Drawing.Point(3, 0)
        Me.FraImportes.Name = "FraImportes"
        Me.FraImportes.Size = New System.Drawing.Size(434, 272)
        Me.FraImportes.TabIndex = 74
        Me.FraImportes.TabStop = False
        Me.FraImportes.Text = "Importes por Conceptos imputados a trabajos (Importes Totales)"
        '
        'txtMargenPresupTrabajo
        '
        Me.txtMargenPresupTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenPresupTrabajo.Enabled = False
        Me.txtMargenPresupTrabajo.Location = New System.Drawing.Point(241, 241)
        Me.txtMargenPresupTrabajo.Name = "txtMargenPresupTrabajo"
        Me.txtMargenPresupTrabajo.Size = New System.Drawing.Size(63, 21)
        Me.txtMargenPresupTrabajo.TabIndex = 119
        '
        'UiGroupBox2
        '
        Me.UiGroupBox2.Location = New System.Drawing.Point(8, 237)
        Me.UiGroupBox2.Name = "UiGroupBox2"
        Me.UiGroupBox2.Size = New System.Drawing.Size(365, 2)
        Me.UiGroupBox2.TabIndex = 117
        '
        'lblCosteIndirecto
        '
        Me.lblCosteIndirecto.Location = New System.Drawing.Point(8, 217)
        Me.lblCosteIndirecto.Name = "lblCosteIndirecto"
        Me.lblCosteIndirecto.Size = New System.Drawing.Size(98, 13)
        Me.lblCosteIndirecto.TabIndex = 116
        Me.lblCosteIndirecto.Text = "TOTAL Indirecto"
        '
        'txtPresupIndirecto
        '
        Me.txtPresupIndirecto.DisabledBackColor = System.Drawing.Color.White
        Me.txtPresupIndirecto.Enabled = False
        Me.txtPresupIndirecto.Location = New System.Drawing.Point(118, 213)
        Me.txtPresupIndirecto.Name = "txtPresupIndirecto"
        Me.txtPresupIndirecto.Size = New System.Drawing.Size(120, 21)
        Me.txtPresupIndirecto.TabIndex = 115
        Me.txtPresupIndirecto.TabStop = False
        '
        'txtPresupVentaIndirecto
        '
        Me.txtPresupVentaIndirecto.DisabledBackColor = System.Drawing.Color.White
        Me.txtPresupVentaIndirecto.Enabled = False
        Me.txtPresupVentaIndirecto.Location = New System.Drawing.Point(307, 213)
        Me.txtPresupVentaIndirecto.Name = "txtPresupVentaIndirecto"
        Me.txtPresupVentaIndirecto.Size = New System.Drawing.Size(120, 21)
        Me.txtPresupVentaIndirecto.TabIndex = 114
        Me.txtPresupVentaIndirecto.TabStop = False
        '
        'lblCosteDirecto
        '
        Me.lblCosteDirecto.Location = New System.Drawing.Point(8, 193)
        Me.lblCosteDirecto.Name = "lblCosteDirecto"
        Me.lblCosteDirecto.Size = New System.Drawing.Size(88, 13)
        Me.lblCosteDirecto.TabIndex = 113
        Me.lblCosteDirecto.Text = "TOTAL Directo"
        '
        'txtPresupDirecto
        '
        Me.txtPresupDirecto.DisabledBackColor = System.Drawing.Color.White
        Me.txtPresupDirecto.Enabled = False
        Me.txtPresupDirecto.Location = New System.Drawing.Point(118, 189)
        Me.txtPresupDirecto.Name = "txtPresupDirecto"
        Me.txtPresupDirecto.Size = New System.Drawing.Size(120, 21)
        Me.txtPresupDirecto.TabIndex = 112
        Me.txtPresupDirecto.TabStop = False
        '
        'txtPresupVentaDirecto
        '
        Me.txtPresupVentaDirecto.DisabledBackColor = System.Drawing.Color.White
        Me.txtPresupVentaDirecto.Enabled = False
        Me.txtPresupVentaDirecto.Location = New System.Drawing.Point(307, 189)
        Me.txtPresupVentaDirecto.Name = "txtPresupVentaDirecto"
        Me.txtPresupVentaDirecto.Size = New System.Drawing.Size(120, 21)
        Me.txtPresupVentaDirecto.TabIndex = 111
        Me.txtPresupVentaDirecto.TabStop = False
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Location = New System.Drawing.Point(8, 185)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(365, 2)
        Me.UiGroupBox1.TabIndex = 110
        '
        'txtMargenTrabajo
        '
        Me.txtMargenTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenTrabajo.Enabled = False
        Me.txtMargenTrabajo.Location = New System.Drawing.Point(241, 161)
        Me.txtMargenTrabajo.Name = "txtMargenTrabajo"
        Me.txtMargenTrabajo.Size = New System.Drawing.Size(63, 21)
        Me.txtMargenTrabajo.TabIndex = 95
        Me.txtMargenTrabajo.TabStop = False
        '
        'lblTotalPresup
        '
        Me.lblTotalPresup.Location = New System.Drawing.Point(8, 245)
        Me.lblTotalPresup.Name = "lblTotalPresup"
        Me.lblTotalPresup.Size = New System.Drawing.Size(90, 13)
        Me.lblTotalPresup.TabIndex = 99
        Me.lblTotalPresup.Text = "TOTAL Presup."
        '
        'txtImpPresupA
        '
        Me.TryDataBinding(txtImpPresupA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupA", True))
        Me.txtImpPresupA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupA.Enabled = False
        Me.txtImpPresupA.Location = New System.Drawing.Point(118, 241)
        Me.txtImpPresupA.Name = "txtImpPresupA"
        Me.txtImpPresupA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupA.TabIndex = 94
        Me.txtImpPresupA.TabStop = False
        '
        'txtImpPresupVentaA
        '
        Me.TryDataBinding(txtImpPresupVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupVentaA", True))
        Me.txtImpPresupVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupVentaA.Enabled = False
        Me.txtImpPresupVentaA.Location = New System.Drawing.Point(307, 241)
        Me.txtImpPresupVentaA.Name = "txtImpPresupVentaA"
        Me.txtImpPresupVentaA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupVentaA.TabIndex = 93
        Me.txtImpPresupVentaA.TabStop = False
        '
        'txtImpPresupQTrabajoVentaA
        '
        Me.txtImpPresupQTrabajoVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQTrabajoVentaA.Enabled = False
        Me.txtImpPresupQTrabajoVentaA.Location = New System.Drawing.Point(307, 161)
        Me.txtImpPresupQTrabajoVentaA.Name = "txtImpPresupQTrabajoVentaA"
        Me.txtImpPresupQTrabajoVentaA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupQTrabajoVentaA.TabIndex = 92
        Me.txtImpPresupQTrabajoVentaA.TabStop = False
        '
        'lblImpPresupVenta
        '
        Me.lblImpPresupVenta.AutoSize = False
        Me.lblImpPresupVenta.Location = New System.Drawing.Point(307, 18)
        Me.lblImpPresupVenta.Name = "lblImpPresupVenta"
        Me.lblImpPresupVenta.Size = New System.Drawing.Size(120, 17)
        Me.lblImpPresupVenta.TabIndex = 100
        Me.lblImpPresupVenta.Tag = ""
        Me.lblImpPresupVenta.Text = "Previsto Venta"
        Me.lblImpPresupVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtImpPresupQModVentaA
        '
        Me.txtImpPresupQModVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQModVentaA.Enabled = False
        Me.txtImpPresupQModVentaA.Location = New System.Drawing.Point(307, 61)
        Me.txtImpPresupQModVentaA.Name = "txtImpPresupQModVentaA"
        Me.txtImpPresupQModVentaA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupQModVentaA.TabIndex = 90
        Me.txtImpPresupQModVentaA.TabStop = False
        '
        'txtImpPresupQCentrosVentaA
        '
        Me.txtImpPresupQCentrosVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQCentrosVentaA.Enabled = False
        Me.txtImpPresupQCentrosVentaA.Location = New System.Drawing.Point(307, 85)
        Me.txtImpPresupQCentrosVentaA.Name = "txtImpPresupQCentrosVentaA"
        Me.txtImpPresupQCentrosVentaA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupQCentrosVentaA.TabIndex = 89
        Me.txtImpPresupQCentrosVentaA.TabStop = False
        '
        'txtImpPresupQGastosVentaA
        '
        Me.txtImpPresupQGastosVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQGastosVentaA.Enabled = False
        Me.txtImpPresupQGastosVentaA.Location = New System.Drawing.Point(307, 109)
        Me.txtImpPresupQGastosVentaA.Name = "txtImpPresupQGastosVentaA"
        Me.txtImpPresupQGastosVentaA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupQGastosVentaA.TabIndex = 88
        Me.txtImpPresupQGastosVentaA.TabStop = False
        '
        'txtImpPresupQVariosVentaA
        '
        Me.txtImpPresupQVariosVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQVariosVentaA.Enabled = False
        Me.txtImpPresupQVariosVentaA.Location = New System.Drawing.Point(307, 133)
        Me.txtImpPresupQVariosVentaA.Name = "txtImpPresupQVariosVentaA"
        Me.txtImpPresupQVariosVentaA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupQVariosVentaA.TabIndex = 87
        Me.txtImpPresupQVariosVentaA.TabStop = False
        '
        'txtImpPresupQMatVentaA
        '
        Me.txtImpPresupQMatVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQMatVentaA.Enabled = False
        Me.txtImpPresupQMatVentaA.Location = New System.Drawing.Point(307, 37)
        Me.txtImpPresupQMatVentaA.Name = "txtImpPresupQMatVentaA"
        Me.txtImpPresupQMatVentaA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupQMatVentaA.TabIndex = 86
        Me.txtImpPresupQMatVentaA.TabStop = False
        '
        'lblPorcVenta
        '
        Me.lblPorcVenta.AutoSize = False
        Me.lblPorcVenta.Location = New System.Drawing.Point(241, 18)
        Me.lblPorcVenta.Name = "lblPorcVenta"
        Me.lblPorcVenta.Size = New System.Drawing.Size(63, 17)
        Me.lblPorcVenta.TabIndex = 101
        Me.lblPorcVenta.Tag = ""
        Me.lblPorcVenta.Text = "% "
        Me.lblPorcVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMargenMat
        '
        Me.txtMargenMat.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenMat.Enabled = False
        Me.txtMargenMat.Location = New System.Drawing.Point(241, 37)
        Me.txtMargenMat.Name = "txtMargenMat"
        Me.txtMargenMat.Size = New System.Drawing.Size(63, 21)
        Me.txtMargenMat.TabIndex = 84
        Me.txtMargenMat.TabStop = False
        '
        'txtMargenMod
        '
        Me.txtMargenMod.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenMod.Enabled = False
        Me.txtMargenMod.Location = New System.Drawing.Point(241, 61)
        Me.txtMargenMod.Name = "txtMargenMod"
        Me.txtMargenMod.Size = New System.Drawing.Size(63, 21)
        Me.txtMargenMod.TabIndex = 83
        Me.txtMargenMod.TabStop = False
        '
        'txtMargenCentro
        '
        Me.txtMargenCentro.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenCentro.Enabled = False
        Me.txtMargenCentro.Location = New System.Drawing.Point(241, 85)
        Me.txtMargenCentro.Name = "txtMargenCentro"
        Me.txtMargenCentro.Size = New System.Drawing.Size(63, 21)
        Me.txtMargenCentro.TabIndex = 82
        Me.txtMargenCentro.TabStop = False
        '
        'txtMargenGastos
        '
        Me.txtMargenGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenGastos.Enabled = False
        Me.txtMargenGastos.Location = New System.Drawing.Point(241, 109)
        Me.txtMargenGastos.Name = "txtMargenGastos"
        Me.txtMargenGastos.Size = New System.Drawing.Size(63, 21)
        Me.txtMargenGastos.TabIndex = 81
        Me.txtMargenGastos.TabStop = False
        '
        'txtMargenVarios
        '
        Me.txtMargenVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenVarios.Enabled = False
        Me.txtMargenVarios.Location = New System.Drawing.Point(241, 133)
        Me.txtMargenVarios.Name = "txtMargenVarios"
        Me.txtMargenVarios.Size = New System.Drawing.Size(63, 21)
        Me.txtMargenVarios.TabIndex = 80
        Me.txtMargenVarios.TabStop = False
        '
        'lblMateriales
        '
        Me.lblMateriales.Location = New System.Drawing.Point(8, 41)
        Me.lblMateriales.Name = "lblMateriales"
        Me.lblMateriales.Size = New System.Drawing.Size(65, 13)
        Me.lblMateriales.TabIndex = 102
        Me.lblMateriales.Tag = "IdRec=5750;"
        Me.lblMateriales.Text = "Materiales"
        '
        'txtImpPresupQMatA
        '
        Me.txtImpPresupQMatA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQMatA.Enabled = False
        Me.txtImpPresupQMatA.Location = New System.Drawing.Point(118, 37)
        Me.txtImpPresupQMatA.Name = "txtImpPresupQMatA"
        Me.txtImpPresupQMatA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupQMatA.TabIndex = 79
        Me.txtImpPresupQMatA.TabStop = False
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(8, 157)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(365, 2)
        Me.Line1.TabIndex = 103
        '
        'lblVarios
        '
        Me.lblVarios.Location = New System.Drawing.Point(8, 137)
        Me.lblVarios.Name = "lblVarios"
        Me.lblVarios.Size = New System.Drawing.Size(42, 13)
        Me.lblVarios.TabIndex = 104
        Me.lblVarios.Tag = "IdRec=5751;"
        Me.lblVarios.Text = "Varios"
        '
        'txtImpPresupQVariosA
        '
        Me.txtImpPresupQVariosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQVariosA.Enabled = False
        Me.txtImpPresupQVariosA.Location = New System.Drawing.Point(118, 133)
        Me.txtImpPresupQVariosA.Name = "txtImpPresupQVariosA"
        Me.txtImpPresupQVariosA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupQVariosA.TabIndex = 78
        Me.txtImpPresupQVariosA.TabStop = False
        '
        'lblGastos
        '
        Me.lblGastos.Location = New System.Drawing.Point(8, 113)
        Me.lblGastos.Name = "lblGastos"
        Me.lblGastos.Size = New System.Drawing.Size(46, 13)
        Me.lblGastos.TabIndex = 105
        Me.lblGastos.Tag = "IdRec=5747;"
        Me.lblGastos.Text = "Gastos"
        '
        'txtImpPresupQGastosA
        '
        Me.txtImpPresupQGastosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQGastosA.Enabled = False
        Me.txtImpPresupQGastosA.Location = New System.Drawing.Point(118, 109)
        Me.txtImpPresupQGastosA.Name = "txtImpPresupQGastosA"
        Me.txtImpPresupQGastosA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupQGastosA.TabIndex = 77
        Me.txtImpPresupQGastosA.TabStop = False
        '
        'lblCentros
        '
        Me.lblCentros.Location = New System.Drawing.Point(8, 89)
        Me.lblCentros.Name = "lblCentros"
        Me.lblCentros.Size = New System.Drawing.Size(52, 13)
        Me.lblCentros.TabIndex = 106
        Me.lblCentros.Tag = "IdRec=5748;"
        Me.lblCentros.Text = "Centros"
        '
        'txtImpPresupQCentrosA
        '
        Me.txtImpPresupQCentrosA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQCentrosA.Enabled = False
        Me.txtImpPresupQCentrosA.Location = New System.Drawing.Point(118, 85)
        Me.txtImpPresupQCentrosA.Name = "txtImpPresupQCentrosA"
        Me.txtImpPresupQCentrosA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupQCentrosA.TabIndex = 76
        Me.txtImpPresupQCentrosA.TabStop = False
        '
        'lblMOD
        '
        Me.lblMOD.Location = New System.Drawing.Point(8, 65)
        Me.lblMOD.Name = "lblMOD"
        Me.lblMOD.Size = New System.Drawing.Size(46, 13)
        Me.lblMOD.TabIndex = 107
        Me.lblMOD.Tag = "IdRec=5749;"
        Me.lblMOD.Text = "M.O.D."
        '
        'txtImpPresupQModA
        '
        Me.txtImpPresupQModA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQModA.Enabled = False
        Me.txtImpPresupQModA.Location = New System.Drawing.Point(118, 61)
        Me.txtImpPresupQModA.Name = "txtImpPresupQModA"
        Me.txtImpPresupQModA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupQModA.TabIndex = 75
        Me.txtImpPresupQModA.TabStop = False
        '
        'lblCostePresup
        '
        Me.lblCostePresup.AutoSize = False
        Me.lblCostePresup.Location = New System.Drawing.Point(118, 18)
        Me.lblCostePresup.Name = "lblCostePresup"
        Me.lblCostePresup.Size = New System.Drawing.Size(120, 21)
        Me.lblCostePresup.TabIndex = 108
        Me.lblCostePresup.Tag = ""
        Me.lblCostePresup.Text = "Previsto"
        Me.lblCostePresup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalUnitario
        '
        Me.lblTotalUnitario.Location = New System.Drawing.Point(8, 165)
        Me.lblTotalUnitario.Name = "lblTotalUnitario"
        Me.lblTotalUnitario.Size = New System.Drawing.Size(107, 13)
        Me.lblTotalUnitario.TabIndex = 109
        Me.lblTotalUnitario.Text = "TOTAL Conceptos"
        '
        'txtImpPresupQTrabajoA
        '
        Me.txtImpPresupQTrabajoA.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpPresupQTrabajoA.Enabled = False
        Me.txtImpPresupQTrabajoA.Location = New System.Drawing.Point(118, 161)
        Me.txtImpPresupQTrabajoA.Name = "txtImpPresupQTrabajoA"
        Me.txtImpPresupQTrabajoA.Size = New System.Drawing.Size(120, 21)
        Me.txtImpPresupQTrabajoA.TabIndex = 73
        Me.txtImpPresupQTrabajoA.TabStop = False
        '
        'FraCondEconomicas
        '
        Me.FraCondEconomicas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FraCondEconomicas.Controls.Add(Me.lblTipoIVA)
        Me.FraCondEconomicas.Controls.Add(Me.lblDiaPago)
        Me.FraCondEconomicas.Controls.Add(Me.lblMoneda)
        Me.FraCondEconomicas.Controls.Add(Me.lblCondicionPago)
        Me.FraCondEconomicas.Controls.Add(Me.lblFormaPago)
        Me.FraCondEconomicas.Controls.Add(Me.AdvIDTipoIVA)
        Me.FraCondEconomicas.Controls.Add(Me.AdvIDDiaPago)
        Me.FraCondEconomicas.Controls.Add(Me.ulDescMoneda)
        Me.FraCondEconomicas.Controls.Add(Me.AdvIDMoneda)
        Me.FraCondEconomicas.Controls.Add(Me.AdvIDCondicionPago)
        Me.FraCondEconomicas.Controls.Add(Me.AdvIDFormaPago)
        Me.FraCondEconomicas.Location = New System.Drawing.Point(441, 0)
        Me.FraCondEconomicas.Name = "FraCondEconomicas"
        Me.FraCondEconomicas.Size = New System.Drawing.Size(338, 104)
        Me.FraCondEconomicas.TabIndex = 73
        Me.FraCondEconomicas.TabStop = False
        Me.FraCondEconomicas.Text = "Condiciones Económicas"
        '
        'lblTipoIVA
        '
        Me.lblTipoIVA.Location = New System.Drawing.Point(168, 50)
        Me.lblTipoIVA.Name = "lblTipoIVA"
        Me.lblTipoIVA.Size = New System.Drawing.Size(66, 13)
        Me.lblTipoIVA.TabIndex = 209
        Me.lblTipoIVA.Text = "Tipo I.V.A."
        '
        'lblDiaPago
        '
        Me.lblDiaPago.Location = New System.Drawing.Point(6, 50)
        Me.lblDiaPago.Name = "lblDiaPago"
        Me.lblDiaPago.Size = New System.Drawing.Size(52, 13)
        Me.lblDiaPago.TabIndex = 205
        Me.lblDiaPago.Text = "D. Pago"
        '
        'lblMoneda
        '
        Me.lblMoneda.Location = New System.Drawing.Point(6, 76)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(51, 13)
        Me.lblMoneda.TabIndex = 206
        Me.lblMoneda.Tag = ""
        Me.lblMoneda.Text = "Moneda"
        '
        'lblCondicionPago
        '
        Me.lblCondicionPago.Location = New System.Drawing.Point(168, 24)
        Me.lblCondicionPago.Name = "lblCondicionPago"
        Me.lblCondicionPago.Size = New System.Drawing.Size(52, 13)
        Me.lblCondicionPago.TabIndex = 207
        Me.lblCondicionPago.Text = "C. Pago"
        '
        'lblFormaPago
        '
        Me.lblFormaPago.Location = New System.Drawing.Point(6, 24)
        Me.lblFormaPago.Name = "lblFormaPago"
        Me.lblFormaPago.Size = New System.Drawing.Size(47, 13)
        Me.lblFormaPago.TabIndex = 208
        Me.lblFormaPago.Text = "F. Pago"
        '
        'AdvIDTipoIVA
        '
        Me.TryDataBinding(AdvIDTipoIVA, New System.Windows.Forms.Binding("Text", Me, "IDTipoIVA", True))
        Me.AdvIDTipoIVA.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipoIVA.EntityName = "TipoIva"
        Me.AdvIDTipoIVA.Location = New System.Drawing.Point(239, 48)
        Me.AdvIDTipoIVA.Name = "AdvIDTipoIVA"
        Me.AdvIDTipoIVA.PrimaryDataFields = "IDTipoIVA"
        Me.AdvIDTipoIVA.SecondaryDataFields = "IDTipoIva"
        Me.AdvIDTipoIVA.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDTipoIVA.TabIndex = 14
        Me.AdvIDTipoIVA.ViewName = "tbMaestroTipoIva"
        '
        'AdvIDDiaPago
        '
        Me.TryDataBinding(AdvIDDiaPago, New System.Windows.Forms.Binding("Text", Me, "IDDiaPago", True))
        Me.AdvIDDiaPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDDiaPago.EntityName = "DiaPago"
        Me.AdvIDDiaPago.Location = New System.Drawing.Point(60, 48)
        Me.AdvIDDiaPago.Name = "AdvIDDiaPago"
        Me.AdvIDDiaPago.PrimaryDataFields = "IDDiaPago"
        Me.AdvIDDiaPago.SecondaryDataFields = "IDDiaPago"
        Me.AdvIDDiaPago.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDDiaPago.TabIndex = 13
        Me.AdvIDDiaPago.ViewName = "tbMaestroDiaPago"
        '
        'ulDescMoneda
        '
        Me.TryDataBinding(ulDescMoneda, New System.Windows.Forms.Binding("Text", Me.AdvIDMoneda, "DescMoneda", True))
        Me.ulDescMoneda.Location = New System.Drawing.Point(152, 74)
        Me.ulDescMoneda.Name = "ulDescMoneda"
        Me.ulDescMoneda.Size = New System.Drawing.Size(175, 23)
        Me.ulDescMoneda.TabIndex = 101
        '
        'AdvIDMoneda
        '
        Me.TryDataBinding(AdvIDMoneda, New System.Windows.Forms.Binding("Text", Me, "IDMoneda", True))
        Me.AdvIDMoneda.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDMoneda.EntityName = "Moneda"
        Me.AdvIDMoneda.Location = New System.Drawing.Point(60, 74)
        Me.AdvIDMoneda.Name = "AdvIDMoneda"
        Me.AdvIDMoneda.PrimaryDataFields = "IDMoneda"
        Me.AdvIDMoneda.SecondaryDataFields = "IDMoneda"
        Me.AdvIDMoneda.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDMoneda.TabIndex = 15
        Me.AdvIDMoneda.ViewName = "tbMaestroMoneda"
        '
        'AdvIDCondicionPago
        '
        Me.TryDataBinding(AdvIDCondicionPago, New System.Windows.Forms.Binding("Text", Me, "IDCondicionPago", True))
        Me.AdvIDCondicionPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCondicionPago.EntityName = "CondicionPago"
        Me.AdvIDCondicionPago.Location = New System.Drawing.Point(239, 22)
        Me.AdvIDCondicionPago.Name = "AdvIDCondicionPago"
        Me.AdvIDCondicionPago.PrimaryDataFields = "IDCondicionPago"
        Me.AdvIDCondicionPago.SecondaryDataFields = "IDCondicionPago"
        Me.AdvIDCondicionPago.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDCondicionPago.TabIndex = 12
        Me.AdvIDCondicionPago.ViewName = "tbMaestroCondicionPago"
        '
        'AdvIDFormaPago
        '
        Me.TryDataBinding(AdvIDFormaPago, New System.Windows.Forms.Binding("Text", Me, "IDFormaPago", True))
        Me.AdvIDFormaPago.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDFormaPago.EntityName = "FormaPago"
        Me.AdvIDFormaPago.Location = New System.Drawing.Point(60, 22)
        Me.AdvIDFormaPago.Name = "AdvIDFormaPago"
        Me.AdvIDFormaPago.PrimaryDataFields = "IDFormaPago"
        Me.AdvIDFormaPago.SecondaryDataFields = "IDFormaPago"
        Me.AdvIDFormaPago.Size = New System.Drawing.Size(88, 23)
        Me.AdvIDFormaPago.TabIndex = 11
        Me.AdvIDFormaPago.ViewName = "tbMaestroFormaPago"
        '
        'pnlDatosGenerales
        '
        Me.pnlDatosGenerales.Controls.Add(Me.FraFechas)
        Me.pnlDatosGenerales.Controls.Add(Me.FraClienteEmpresa)
        Me.pnlDatosGenerales.Controls.Add(Me.lblObra)
        Me.pnlDatosGenerales.Controls.Add(Me.txtNObra)
        Me.pnlDatosGenerales.Controls.Add(Me.lblTipoObra)
        Me.pnlDatosGenerales.Controls.Add(Me.ulDescTipoObra)
        Me.pnlDatosGenerales.Controls.Add(Me.AdvIDTipoObra)
        Me.pnlDatosGenerales.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDatosGenerales.Location = New System.Drawing.Point(0, 0)
        Me.pnlDatosGenerales.Name = "pnlDatosGenerales"
        Me.pnlDatosGenerales.Size = New System.Drawing.Size(782, 168)
        Me.pnlDatosGenerales.TabIndex = 107
        '
        'FraFechas
        '
        Me.FraFechas.Controls.Add(Me.lblFechaPresup)
        Me.FraFechas.Controls.Add(Me.cbxFechaPresup)
        Me.FraFechas.Controls.Add(Me.lblFechaValidez)
        Me.FraFechas.Controls.Add(Me.cbxFechaValidez)
        Me.FraFechas.Controls.Add(Me.lblFechaCierre)
        Me.FraFechas.Controls.Add(Me.cbxFechaCierre)
        Me.FraFechas.Location = New System.Drawing.Point(3, 6)
        Me.FraFechas.Name = "FraFechas"
        Me.FraFechas.Size = New System.Drawing.Size(107, 156)
        Me.FraFechas.TabIndex = 110
        Me.FraFechas.TabStop = False
        Me.FraFechas.Text = "Fechas"
        '
        'lblFechaPresup
        '
        Me.lblFechaPresup.Location = New System.Drawing.Point(4, 18)
        Me.lblFechaPresup.Name = "lblFechaPresup"
        Me.lblFechaPresup.Size = New System.Drawing.Size(87, 13)
        Me.lblFechaPresup.TabIndex = 0
        Me.lblFechaPresup.Text = "Fecha Presup."
        '
        'cbxFechaPresup
        '
        Me.TryDataBinding(cbxFechaPresup, New System.Windows.Forms.Binding("BindableValue", Me, "FechaPresup", True))
        Me.cbxFechaPresup.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPresup.Location = New System.Drawing.Point(4, 39)
        Me.cbxFechaPresup.Name = "cbxFechaPresup"
        Me.cbxFechaPresup.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaPresup.TabIndex = 5
        '
        'lblFechaValidez
        '
        Me.lblFechaValidez.Location = New System.Drawing.Point(4, 62)
        Me.lblFechaValidez.Name = "lblFechaValidez"
        Me.lblFechaValidez.Size = New System.Drawing.Size(84, 13)
        Me.lblFechaValidez.TabIndex = 6
        Me.lblFechaValidez.Tag = "IdRec=5745;"
        Me.lblFechaValidez.Text = "Fecha Validez"
        '
        'cbxFechaValidez
        '
        Me.TryDataBinding(cbxFechaValidez, New System.Windows.Forms.Binding("BindableValue", Me, "FechaValidez", True))
        Me.cbxFechaValidez.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaValidez.Location = New System.Drawing.Point(4, 83)
        Me.cbxFechaValidez.Name = "cbxFechaValidez"
        Me.cbxFechaValidez.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaValidez.TabIndex = 6
        '
        'lblFechaCierre
        '
        Me.lblFechaCierre.Location = New System.Drawing.Point(4, 106)
        Me.lblFechaCierre.Name = "lblFechaCierre"
        Me.lblFechaCierre.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaCierre.TabIndex = 7
        Me.lblFechaCierre.Tag = "IdRec=4907;"
        Me.lblFechaCierre.Text = "Fecha Cierre"
        '
        'cbxFechaCierre
        '
        Me.TryDataBinding(cbxFechaCierre, New System.Windows.Forms.Binding("BindableValue", Me, "FechaCierre", True))
        Me.cbxFechaCierre.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaCierre.Location = New System.Drawing.Point(4, 127)
        Me.cbxFechaCierre.Name = "cbxFechaCierre"
        Me.cbxFechaCierre.Size = New System.Drawing.Size(96, 21)
        Me.cbxFechaCierre.TabIndex = 7
        '
        'FraClienteEmpresa
        '
        Me.FraClienteEmpresa.Controls.Add(Me.lblPoblacion)
        Me.FraClienteEmpresa.Controls.Add(Me.lblProvincia)
        Me.FraClienteEmpresa.Controls.Add(Me.lblCodPostal)
        Me.FraClienteEmpresa.Controls.Add(Me.lblEmpresa)
        Me.FraClienteEmpresa.Controls.Add(Me.txtPoblacion)
        Me.FraClienteEmpresa.Controls.Add(Me.txtCodPostal)
        Me.FraClienteEmpresa.Controls.Add(Me.txtProvincia)
        Me.FraClienteEmpresa.Controls.Add(Me.txtDireccion)
        Me.FraClienteEmpresa.Controls.Add(Me.lblDireccion)
        Me.FraClienteEmpresa.Controls.Add(Me.ulDescEmpresa)
        Me.FraClienteEmpresa.Controls.Add(Me.AdvIDEmpresa)
        Me.FraClienteEmpresa.Controls.Add(Me.lblCliente)
        Me.FraClienteEmpresa.Controls.Add(Me.ulDescCliente)
        Me.FraClienteEmpresa.Controls.Add(Me.AdvIDCliente)
        Me.FraClienteEmpresa.Controls.Add(Me.FraLinea)
        Me.FraClienteEmpresa.Location = New System.Drawing.Point(113, 35)
        Me.FraClienteEmpresa.Name = "FraClienteEmpresa"
        Me.FraClienteEmpresa.Size = New System.Drawing.Size(667, 127)
        Me.FraClienteEmpresa.TabIndex = 109
        Me.FraClienteEmpresa.TabStop = False
        Me.FraClienteEmpresa.Text = "Datos Empresa/Cliente"
        '
        'lblPoblacion
        '
        Me.lblPoblacion.Location = New System.Drawing.Point(126, 104)
        Me.lblPoblacion.Name = "lblPoblacion"
        Me.lblPoblacion.Size = New System.Drawing.Size(61, 13)
        Me.lblPoblacion.TabIndex = 92
        Me.lblPoblacion.Tag = "IdRec=4413;"
        Me.lblPoblacion.Text = "Población"
        '
        'lblProvincia
        '
        Me.lblProvincia.Location = New System.Drawing.Point(435, 104)
        Me.lblProvincia.Name = "lblProvincia"
        Me.lblProvincia.Size = New System.Drawing.Size(59, 13)
        Me.lblProvincia.TabIndex = 91
        Me.lblProvincia.Tag = ""
        Me.lblProvincia.Text = "Provincia"
        '
        'lblCodPostal
        '
        Me.lblCodPostal.Location = New System.Drawing.Point(7, 104)
        Me.lblCodPostal.Name = "lblCodPostal"
        Me.lblCodPostal.Size = New System.Drawing.Size(29, 13)
        Me.lblCodPostal.TabIndex = 90
        Me.lblCodPostal.Tag = ""
        Me.lblCodPostal.Text = "C.P."
        '
        'lblEmpresa
        '
        Me.lblEmpresa.Location = New System.Drawing.Point(7, 25)
        Me.lblEmpresa.Name = "lblEmpresa"
        Me.lblEmpresa.Size = New System.Drawing.Size(57, 13)
        Me.lblEmpresa.TabIndex = 89
        Me.lblEmpresa.Text = "Empresa"
        '
        'txtPoblacion
        '
        Me.TryDataBinding(txtPoblacion, New System.Windows.Forms.Binding("Text", Me, "Poblacion", True))
        Me.txtPoblacion.DisabledBackColor = System.Drawing.Color.White
        Me.txtPoblacion.Enabled = False
        Me.txtPoblacion.Location = New System.Drawing.Point(189, 100)
        Me.txtPoblacion.Name = "txtPoblacion"
        Me.txtPoblacion.Size = New System.Drawing.Size(240, 21)
        Me.txtPoblacion.TabIndex = 13
        Me.txtPoblacion.TabStop = False
        '
        'txtCodPostal
        '
        Me.TryDataBinding(txtCodPostal, New System.Windows.Forms.Binding("Text", Me, "CodPostal", True))
        Me.txtCodPostal.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodPostal.Enabled = False
        Me.txtCodPostal.Location = New System.Drawing.Point(68, 100)
        Me.txtCodPostal.Name = "txtCodPostal"
        Me.txtCodPostal.Size = New System.Drawing.Size(55, 21)
        Me.txtCodPostal.TabIndex = 12
        Me.txtCodPostal.TabStop = False
        '
        'txtProvincia
        '
        Me.TryDataBinding(txtProvincia, New System.Windows.Forms.Binding("Text", Me, "Provincia", True))
        Me.txtProvincia.DisabledBackColor = System.Drawing.Color.White
        Me.txtProvincia.Enabled = False
        Me.txtProvincia.Location = New System.Drawing.Point(499, 100)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(166, 21)
        Me.txtProvincia.TabIndex = 14
        Me.txtProvincia.TabStop = False
        '
        'txtDireccion
        '
        Me.TryDataBinding(txtDireccion, New System.Windows.Forms.Binding("Text", Me, "Direccion", True))
        Me.txtDireccion.DisabledBackColor = System.Drawing.Color.White
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(68, 76)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(597, 21)
        Me.txtDireccion.TabIndex = 11
        Me.txtDireccion.TabStop = False
        '
        'lblDireccion
        '
        Me.lblDireccion.Location = New System.Drawing.Point(7, 80)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(60, 13)
        Me.lblDireccion.TabIndex = 85
        Me.lblDireccion.Tag = "IdRec=4410;"
        Me.lblDireccion.Text = "Dirección"
        '
        'ulDescEmpresa
        '
        Me.TryDataBinding(ulDescEmpresa, New System.Windows.Forms.Binding("Text", Me.AdvIDEmpresa, "DescEmpresa", True))
        Me.ulDescEmpresa.Location = New System.Drawing.Point(185, 20)
        Me.ulDescEmpresa.Name = "ulDescEmpresa"
        Me.ulDescEmpresa.Size = New System.Drawing.Size(479, 23)
        Me.ulDescEmpresa.TabIndex = 70
        '
        'AdvIDEmpresa
        '
        Me.TryDataBinding(AdvIDEmpresa, New System.Windows.Forms.Binding("Text", Me, "IDEmpresa", True))
        Me.AdvIDEmpresa.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDEmpresa.EntityName = "Empresa"
        Me.AdvIDEmpresa.Location = New System.Drawing.Point(68, 20)
        Me.AdvIDEmpresa.Name = "AdvIDEmpresa"
        Me.AdvIDEmpresa.PrimaryDataFields = "IDEmpresa"
        Me.AdvIDEmpresa.SecondaryDataFields = "IDEmpresa"
        Me.AdvIDEmpresa.Size = New System.Drawing.Size(114, 23)
        Me.AdvIDEmpresa.TabIndex = 9
        Me.AdvIDEmpresa.ViewName = "tbMaestroEmpresa"
        '
        'lblCliente
        '
        Me.lblCliente.Location = New System.Drawing.Point(7, 51)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 13)
        Me.lblCliente.TabIndex = 71
        Me.lblCliente.Tag = "IdRec=4365;"
        Me.lblCliente.Text = "Cliente"
        '
        'ulDescCliente
        '
        Me.TryDataBinding(ulDescCliente, New System.Windows.Forms.Binding("Text", Me.AdvIDCliente, "DescCliente", True))
        Me.ulDescCliente.Location = New System.Drawing.Point(185, 46)
        Me.ulDescCliente.Name = "ulDescCliente"
        Me.ulDescCliente.Size = New System.Drawing.Size(479, 23)
        Me.ulDescCliente.TabIndex = 72
        '
        'AdvIDCliente
        '
        Me.TryDataBinding(AdvIDCliente, New System.Windows.Forms.Binding("Text", Me, "IDCliente", True))
        Me.AdvIDCliente.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDCliente.EntityName = "Cliente"
        Me.AdvIDCliente.Location = New System.Drawing.Point(68, 46)
        Me.AdvIDCliente.Name = "AdvIDCliente"
        Me.AdvIDCliente.PrimaryDataFields = "IDCliente"
        Me.AdvIDCliente.SecondaryDataFields = "IDCliente"
        Me.AdvIDCliente.Size = New System.Drawing.Size(114, 23)
        Me.AdvIDCliente.TabIndex = 10
        Me.AdvIDCliente.ViewName = "tbMaestroCliente"
        '
        'FraLinea
        '
        Me.FraLinea.Location = New System.Drawing.Point(1, 71)
        Me.FraLinea.Name = "FraLinea"
        Me.FraLinea.Size = New System.Drawing.Size(667, 3)
        Me.FraLinea.TabIndex = 61
        Me.FraLinea.TabStop = False
        '
        'lblObra
        '
        Me.lblObra.Location = New System.Drawing.Point(560, 14)
        Me.lblObra.Name = "lblObra"
        Me.lblObra.Size = New System.Drawing.Size(57, 13)
        Me.lblObra.TabIndex = 111
        Me.lblObra.Tag = ""
        Me.lblObra.Text = "Proyecto"
        '
        'txtNObra
        '
        Me.TryDataBinding(txtNObra, New System.Windows.Forms.Binding("Text", Me, "NObra", True))
        Me.txtNObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtNObra.Enabled = False
        Me.txtNObra.Location = New System.Drawing.Point(621, 10)
        Me.txtNObra.Name = "txtNObra"
        Me.txtNObra.Size = New System.Drawing.Size(156, 21)
        Me.txtNObra.TabIndex = 108
        Me.txtNObra.TabStop = False
        Me.txtNObra.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
        '
        'lblTipoObra
        '
        Me.lblTipoObra.Location = New System.Drawing.Point(117, 12)
        Me.lblTipoObra.Name = "lblTipoObra"
        Me.lblTipoObra.Size = New System.Drawing.Size(31, 13)
        Me.lblTipoObra.TabIndex = 112
        Me.lblTipoObra.Tag = ""
        Me.lblTipoObra.Text = "Tipo"
        '
        'ulDescTipoObra
        '
        Me.TryDataBinding(ulDescTipoObra, New System.Windows.Forms.Binding("Text", Me.AdvIDTipoObra, "DescTipoObra", True))
        Me.ulDescTipoObra.Location = New System.Drawing.Point(297, 8)
        Me.ulDescTipoObra.Name = "ulDescTipoObra"
        Me.ulDescTipoObra.Size = New System.Drawing.Size(257, 23)
        Me.ulDescTipoObra.TabIndex = 113
        '
        'AdvIDTipoObra
        '
        Me.TryDataBinding(AdvIDTipoObra, New System.Windows.Forms.Binding("Value", Me, "IDTipoObra", True))
        Me.AdvIDTipoObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDTipoObra.EntityName = "ObraTipo"
        Me.AdvIDTipoObra.Location = New System.Drawing.Point(181, 8)
        Me.AdvIDTipoObra.Name = "AdvIDTipoObra"
        Me.AdvIDTipoObra.PrimaryDataFields = "IDTipoObra"
        Me.AdvIDTipoObra.SecondaryDataFields = "IDTipoObra"
        Me.AdvIDTipoObra.Size = New System.Drawing.Size(113, 23)
        Me.AdvIDTipoObra.TabIndex = 8
        Me.AdvIDTipoObra.ViewName = "tbObraTipo"
        '
        'TabPageTrabajo
        '
        Me.TabPageTrabajo.Controls.Add(Me.TabTrabajos)
        Me.TabPageTrabajo.Controls.Add(Me.Splitter1)
        Me.TabPageTrabajo.Controls.Add(Me.pnlTrabajos)
        Me.TabPageTrabajo.Key = "Trabajos"
        Me.TabPageTrabajo.Location = New System.Drawing.Point(1, 21)
        Me.TabPageTrabajo.Name = "TabPageTrabajo"
        Me.TabPageTrabajo.Size = New System.Drawing.Size(782, 442)
        Me.TabPageTrabajo.TabStop = True
        Me.TabPageTrabajo.Text = "Trabajos"
        Me.TabPageTrabajo.Visible = False
        '
        'TabTrabajos
        '
        Me.TabTrabajos.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.TabTrabajos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabTrabajos.Location = New System.Drawing.Point(275, 0)
        Me.TabTrabajos.Name = "TabTrabajos"
        Me.TabTrabajos.Size = New System.Drawing.Size(507, 442)
        Me.TabTrabajos.TabIndex = 17
        Me.TabTrabajos.TabPages.AddRange(New Janus.Windows.UI.Tab.UITabPage() {Me.TabPageTrabajos, Me.TabPageMateriales, Me.TabPageMOD, Me.TabPageCentros, Me.TabPageGastos, Me.TabPageVarios, Me.TabPageMediciones})
        Me.TabTrabajos.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right
        Me.TabTrabajos.UseThemes = True
        '
        'TabPageTrabajos
        '
        Me.TabPageTrabajos.Controls.Add(Me.pnlFicha)
        Me.TabPageTrabajos.Controls.Add(Me.pnlGridTrabajo)
        Me.TabPageTrabajos.Controls.Add(Me.pnlTrabajosCompleto)
        Me.TabPageTrabajos.Key = "Trabajos"
        Me.TabPageTrabajos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageTrabajos.Name = "TabPageTrabajos"
        Me.TabPageTrabajos.Size = New System.Drawing.Size(484, 440)
        Me.TabPageTrabajos.TabStop = True
        Me.TabPageTrabajos.Text = "Trabajos"
        '
        'pnlFicha
        '
        Me.pnlFicha.Controls.Add(Me.pnlFichaTrabajoFill)
        Me.pnlFicha.Controls.Add(Me.FraImportesTrabajoFicha)
        Me.pnlFicha.Controls.Add(Me.pnlFichaTrabajoTop)
        Me.pnlFicha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFicha.Location = New System.Drawing.Point(0, 0)
        Me.pnlFicha.Name = "pnlFicha"
        Me.pnlFicha.Size = New System.Drawing.Size(484, 440)
        Me.pnlFicha.TabIndex = 0
        '
        'pnlFichaTrabajoFill
        '
        Me.pnlFichaTrabajoFill.Controls.Add(Me.txtTextoTrabajo)
        Me.pnlFichaTrabajoFill.Controls.Add(Me.lblTextoTrabajo)
        Me.pnlFichaTrabajoFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFichaTrabajoFill.Location = New System.Drawing.Point(0, 296)
        Me.pnlFichaTrabajoFill.Name = "pnlFichaTrabajoFill"
        Me.pnlFichaTrabajoFill.Size = New System.Drawing.Size(484, 93)
        Me.pnlFichaTrabajoFill.TabIndex = 186
        '
        'txtTextoTrabajo
        '
        Me.txtTextoTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTextoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoTrabajo.Location = New System.Drawing.Point(90, 4)
        Me.txtTextoTrabajo.Multiline = True
        Me.txtTextoTrabajo.Name = "txtTextoTrabajo"
        Me.txtTextoTrabajo.Size = New System.Drawing.Size(387, 84)
        Me.txtTextoTrabajo.TabIndex = 42
        '
        'lblTextoTrabajo
        '
        Me.lblTextoTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTextoTrabajo.Location = New System.Drawing.Point(2, 5)
        Me.lblTextoTrabajo.Name = "lblTextoTrabajo"
        Me.lblTextoTrabajo.Size = New System.Drawing.Size(91, 13)
        Me.lblTextoTrabajo.TabIndex = 0
        Me.lblTextoTrabajo.Text = "Observaciones"
        '
        'FraImportesTrabajoFicha
        '
        Me.FraImportesTrabajoFicha.Controls.Add(Me.txtPresupVentaTrabajo)
        Me.FraImportesTrabajoFicha.Controls.Add(Me.txtPresupTrabajo)
        Me.FraImportesTrabajoFicha.Controls.Add(Me.lblPresupTrabajoFicha)
        Me.FraImportesTrabajoFicha.Controls.Add(Me.lblPresupTrabajoVentaFicha)
        Me.FraImportesTrabajoFicha.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraImportesTrabajoFicha.Location = New System.Drawing.Point(0, 389)
        Me.FraImportesTrabajoFicha.Name = "FraImportesTrabajoFicha"
        Me.FraImportesTrabajoFicha.Size = New System.Drawing.Size(484, 51)
        Me.FraImportesTrabajoFicha.TabIndex = 184
        Me.FraImportesTrabajoFicha.TabStop = False
        Me.FraImportesTrabajoFicha.Tag = ""
        Me.FraImportesTrabajoFicha.Text = "Importes Trabajo (Importes Totales)"
        '
        'txtPresupVentaTrabajo
        '
        Me.txtPresupVentaTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtPresupVentaTrabajo.Enabled = False
        Me.txtPresupVentaTrabajo.Location = New System.Drawing.Point(359, 21)
        Me.txtPresupVentaTrabajo.Name = "txtPresupVentaTrabajo"
        Me.txtPresupVentaTrabajo.Size = New System.Drawing.Size(113, 21)
        Me.txtPresupVentaTrabajo.TabIndex = 146
        Me.txtPresupVentaTrabajo.TabStop = False
        '
        'txtPresupTrabajo
        '
        Me.txtPresupTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtPresupTrabajo.Enabled = False
        Me.txtPresupTrabajo.Location = New System.Drawing.Point(114, 21)
        Me.txtPresupTrabajo.Name = "txtPresupTrabajo"
        Me.txtPresupTrabajo.Size = New System.Drawing.Size(113, 21)
        Me.txtPresupTrabajo.TabIndex = 145
        Me.txtPresupTrabajo.TabStop = False
        '
        'lblPresupTrabajoFicha
        '
        Me.lblPresupTrabajoFicha.Location = New System.Drawing.Point(28, 25)
        Me.lblPresupTrabajoFicha.Name = "lblPresupTrabajoFicha"
        Me.lblPresupTrabajoFicha.Size = New System.Drawing.Size(81, 13)
        Me.lblPresupTrabajoFicha.TabIndex = 139
        Me.lblPresupTrabajoFicha.Tag = ""
        Me.lblPresupTrabajoFicha.Text = "Total Presup."
        Me.lblPresupTrabajoFicha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPresupTrabajoVentaFicha
        '
        Me.lblPresupTrabajoVentaFicha.Location = New System.Drawing.Point(238, 25)
        Me.lblPresupTrabajoVentaFicha.Name = "lblPresupTrabajoVentaFicha"
        Me.lblPresupTrabajoVentaFicha.Size = New System.Drawing.Size(117, 13)
        Me.lblPresupTrabajoVentaFicha.TabIndex = 141
        Me.lblPresupTrabajoVentaFicha.Tag = ""
        Me.lblPresupTrabajoVentaFicha.Text = "Total Presup. Venta"
        Me.lblPresupTrabajoVentaFicha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlFichaTrabajoTop
        '
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblQUnitaria)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.ntxQUnidad)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblIncremento)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtIncremento)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblMargenPresup)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtMargenTrabajoFicha)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.AdvSubSubTipoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblSubSubTipoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblTipoLinea)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cbxTipoLinea)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblTipoCoste)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cbxTipoCoste)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.AdvSubTipoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.AdvTipoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.FraSeguimiento)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblIDArticulo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.AdvIDArticulo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.chkNoAcumular)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblUDMedida)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblQPresup)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblCodTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.cbxIDUDMedida)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblImpUnitarioVtaA)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtImpUnitarioVta)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblImpUnitario)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtImpUnitario)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtQPresup)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtDescTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblTipoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.lblSubTipoTrabajo)
        Me.pnlFichaTrabajoTop.Controls.Add(Me.txtCodTrabajo)
        Me.pnlFichaTrabajoTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFichaTrabajoTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlFichaTrabajoTop.Name = "pnlFichaTrabajoTop"
        Me.pnlFichaTrabajoTop.Size = New System.Drawing.Size(484, 296)
        Me.pnlFichaTrabajoTop.TabIndex = 183
        '
        'lblQUnitaria
        '
        Me.lblQUnitaria.Location = New System.Drawing.Point(2, 106)
        Me.lblQUnitaria.Name = "lblQUnitaria"
        Me.lblQUnitaria.Size = New System.Drawing.Size(68, 13)
        Me.lblQUnitaria.TabIndex = 344
        Me.lblQUnitaria.Tag = ""
        Me.lblQUnitaria.Text = "C. Unitaria"
        '
        'ntxQUnidad
        '
        Me.ntxQUnidad.DisabledBackColor = System.Drawing.Color.White
        Me.ntxQUnidad.Location = New System.Drawing.Point(90, 102)
        Me.ntxQUnidad.Name = "ntxQUnidad"
        Me.ntxQUnidad.Size = New System.Drawing.Size(87, 21)
        Me.ntxQUnidad.TabIndex = 25
        '
        'lblIncremento
        '
        Me.lblIncremento.Location = New System.Drawing.Point(240, 157)
        Me.lblIncremento.Name = "lblIncremento"
        Me.lblIncremento.Size = New System.Drawing.Size(73, 13)
        Me.lblIncremento.TabIndex = 342
        Me.lblIncremento.Tag = ""
        Me.lblIncremento.Text = "Incremento"
        '
        'txtIncremento
        '
        Me.txtIncremento.DisabledBackColor = System.Drawing.Color.White
        Me.txtIncremento.Location = New System.Drawing.Point(317, 153)
        Me.txtIncremento.Name = "txtIncremento"
        Me.txtIncremento.Size = New System.Drawing.Size(95, 21)
        Me.txtIncremento.TabIndex = 26
        '
        'lblMargenPresup
        '
        Me.lblMargenPresup.Location = New System.Drawing.Point(180, 131)
        Me.lblMargenPresup.Name = "lblMargenPresup"
        Me.lblMargenPresup.Size = New System.Drawing.Size(66, 13)
        Me.lblMargenPresup.TabIndex = 340
        Me.lblMargenPresup.Tag = ""
        Me.lblMargenPresup.Text = "% Presup."
        Me.lblMargenPresup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMargenTrabajoFicha
        '
        Me.txtMargenTrabajoFicha.DisabledBackColor = System.Drawing.Color.White
        Me.txtMargenTrabajoFicha.Enabled = False
        Me.txtMargenTrabajoFicha.Location = New System.Drawing.Point(236, 127)
        Me.txtMargenTrabajoFicha.Name = "txtMargenTrabajoFicha"
        Me.txtMargenTrabajoFicha.Size = New System.Drawing.Size(43, 21)
        Me.txtMargenTrabajoFicha.TabIndex = 29
        '
        'AdvSubSubTipoTrabajo
        '
        Me.AdvSubSubTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubSubTipoTrabajo.EntityName = "ObraSubSubtipoTrabajo"
        Me.AdvSubSubTipoTrabajo.Location = New System.Drawing.Point(402, 1)
        Me.AdvSubSubTipoTrabajo.Name = "AdvSubSubTipoTrabajo"
        Me.AdvSubSubTipoTrabajo.SecondaryDataFields = "IDSubSubtipoTrabajo"
        Me.AdvSubSubTipoTrabajo.Size = New System.Drawing.Size(76, 23)
        Me.AdvSubSubTipoTrabajo.TabIndex = 19
        '
        'lblSubSubTipoTrabajo
        '
        Me.lblSubSubTipoTrabajo.Location = New System.Drawing.Point(323, 6)
        Me.lblSubSubTipoTrabajo.Name = "lblSubSubTipoTrabajo"
        Me.lblSubSubTipoTrabajo.Size = New System.Drawing.Size(75, 13)
        Me.lblSubSubTipoTrabajo.TabIndex = 241
        Me.lblSubSubTipoTrabajo.Tag = ""
        Me.lblSubSubTipoTrabajo.Text = "SubSubTipo"
        '
        'lblTipoLinea
        '
        Me.lblTipoLinea.Location = New System.Drawing.Point(293, 81)
        Me.lblTipoLinea.Name = "lblTipoLinea"
        Me.lblTipoLinea.Size = New System.Drawing.Size(65, 13)
        Me.lblTipoLinea.TabIndex = 212
        Me.lblTipoLinea.Tag = ""
        Me.lblTipoLinea.Text = "Tipo Línea"
        Me.lblTipoLinea.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbxTipoLinea
        '
        Me.cbxTipoLinea.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxTipoLinea_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoLinea_DesignTimeLayout.LayoutString")
        Me.cbxTipoLinea.DesignTimeLayout = cbxTipoLinea_DesignTimeLayout
        Me.cbxTipoLinea.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoLinea.Location = New System.Drawing.Point(362, 77)
        Me.cbxTipoLinea.Name = "cbxTipoLinea"
        Me.cbxTipoLinea.SelectedIndex = -1
        Me.cbxTipoLinea.SelectedItem = Nothing
        Me.cbxTipoLinea.Size = New System.Drawing.Size(114, 21)
        Me.cbxTipoLinea.TabIndex = 24
        '
        'lblTipoCoste
        '
        Me.lblTipoCoste.Location = New System.Drawing.Point(2, 81)
        Me.lblTipoCoste.Name = "lblTipoCoste"
        Me.lblTipoCoste.Size = New System.Drawing.Size(68, 13)
        Me.lblTipoCoste.TabIndex = 210
        Me.lblTipoCoste.Tag = ""
        Me.lblTipoCoste.Text = "Tipo Coste"
        '
        'cbxTipoCoste
        '
        Me.cbxTipoCoste.ComboStyle = Janus.Windows.GridEX.ComboStyle.DropDownList
        cbxTipoCoste_DesignTimeLayout.LayoutString = resources.GetString("cbxTipoCoste_DesignTimeLayout.LayoutString")
        Me.cbxTipoCoste.DesignTimeLayout = cbxTipoCoste_DesignTimeLayout
        Me.cbxTipoCoste.DisabledBackColor = System.Drawing.Color.White
        Me.cbxTipoCoste.DisplayMember = "Value"
        Me.cbxTipoCoste.Location = New System.Drawing.Point(90, 77)
        Me.cbxTipoCoste.Name = "cbxTipoCoste"
        Me.cbxTipoCoste.PrimaryDataFields = "Estado"
        Me.cbxTipoCoste.SecondaryDataFields = "Value"
        Me.cbxTipoCoste.SelectedIndex = -1
        Me.cbxTipoCoste.SelectedItem = Nothing
        Me.cbxTipoCoste.Size = New System.Drawing.Size(124, 21)
        Me.cbxTipoCoste.TabIndex = 23
        '
        'AdvSubTipoTrabajo
        '
        Me.AdvSubTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvSubTipoTrabajo.EntityName = "ObraSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.Location = New System.Drawing.Point(235, 1)
        Me.AdvSubTipoTrabajo.Name = "AdvSubTipoTrabajo"
        Me.AdvSubTipoTrabajo.PrimaryDataFields = "IDSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.SecondaryDataFields = "IDSubtipoTrabajo"
        Me.AdvSubTipoTrabajo.Size = New System.Drawing.Size(77, 23)
        Me.AdvSubTipoTrabajo.TabIndex = 18
        '
        'AdvTipoTrabajo
        '
        Me.AdvTipoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTipoTrabajo.EntityName = "ObraTipoTrabajo"
        Me.AdvTipoTrabajo.Location = New System.Drawing.Point(90, 1)
        Me.AdvTipoTrabajo.Name = "AdvTipoTrabajo"
        Me.AdvTipoTrabajo.PrimaryDataFields = "IDTipoTrabajo"
        Me.AdvTipoTrabajo.SecondaryDataFields = "IDTipoTrabajo"
        Me.AdvTipoTrabajo.Size = New System.Drawing.Size(77, 23)
        Me.AdvTipoTrabajo.TabIndex = 17
        '
        'FraSeguimiento
        '
        Me.FraSeguimiento.Controls.Add(Me.txtDuracionPresup)
        Me.FraSeguimiento.Controls.Add(Me.txtNivelTrabajo)
        Me.FraSeguimiento.Controls.Add(Me.lblNivelTrabajo)
        Me.FraSeguimiento.Controls.Add(Me.FraFechasTrabajo)
        Me.FraSeguimiento.Controls.Add(Me.lblCentroGestionTrabajo)
        Me.FraSeguimiento.Controls.Add(Me.cbxIDCentroGestion)
        Me.FraSeguimiento.Controls.Add(Me.lblNumPedido)
        Me.FraSeguimiento.Controls.Add(Me.txtNumPedido)
        Me.FraSeguimiento.Controls.Add(Me.lblSolapeAnt)
        Me.FraSeguimiento.Controls.Add(Me.txtSolapeAnt)
        Me.FraSeguimiento.Controls.Add(Me.lblSecuencia)
        Me.FraSeguimiento.Controls.Add(Me.txtSecuencia)
        Me.FraSeguimiento.Controls.Add(Me.lblDuracionPresup)
        Me.FraSeguimiento.Location = New System.Drawing.Point(2, 175)
        Me.FraSeguimiento.Name = "FraSeguimiento"
        Me.FraSeguimiento.Size = New System.Drawing.Size(476, 119)
        Me.FraSeguimiento.TabIndex = 32
        Me.FraSeguimiento.TabStop = False
        Me.FraSeguimiento.Text = "Seguimiento"
        '
        'txtDuracionPresup
        '
        Me.txtDuracionPresup.DisabledBackColor = System.Drawing.Color.White
        Me.txtDuracionPresup.Location = New System.Drawing.Point(90, 41)
        Me.txtDuracionPresup.Name = "txtDuracionPresup"
        Me.txtDuracionPresup.Size = New System.Drawing.Size(68, 21)
        Me.txtDuracionPresup.TabIndex = 34
        '
        'txtNivelTrabajo
        '
        Me.txtNivelTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtNivelTrabajo.Enabled = False
        Me.txtNivelTrabajo.Location = New System.Drawing.Point(90, 91)
        Me.txtNivelTrabajo.Name = "txtNivelTrabajo"
        Me.txtNivelTrabajo.Size = New System.Drawing.Size(68, 21)
        Me.txtNivelTrabajo.TabIndex = 36
        Me.txtNivelTrabajo.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'lblNivelTrabajo
        '
        Me.lblNivelTrabajo.Location = New System.Drawing.Point(8, 95)
        Me.lblNivelTrabajo.Name = "lblNivelTrabajo"
        Me.lblNivelTrabajo.Size = New System.Drawing.Size(35, 13)
        Me.lblNivelTrabajo.TabIndex = 184
        Me.lblNivelTrabajo.Text = "Nivel"
        '
        'FraFechasTrabajo
        '
        Me.FraFechasTrabajo.Controls.Add(Me.lblFechaFinTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.cbxFechaFinTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.lblFechaInicioTrabajo)
        Me.FraFechasTrabajo.Controls.Add(Me.cbxFechaInicioTrabajo)
        Me.FraFechasTrabajo.Location = New System.Drawing.Point(319, 10)
        Me.FraFechasTrabajo.Name = "FraFechasTrabajo"
        Me.FraFechasTrabajo.Size = New System.Drawing.Size(153, 74)
        Me.FraFechasTrabajo.TabIndex = 38
        Me.FraFechasTrabajo.TabStop = False
        Me.FraFechasTrabajo.Text = "Fechas"
        '
        'lblFechaFinTrabajo
        '
        Me.lblFechaFinTrabajo.Location = New System.Drawing.Point(9, 49)
        Me.lblFechaFinTrabajo.Name = "lblFechaFinTrabajo"
        Me.lblFechaFinTrabajo.Size = New System.Drawing.Size(23, 13)
        Me.lblFechaFinTrabajo.TabIndex = 183
        Me.lblFechaFinTrabajo.Tag = ""
        Me.lblFechaFinTrabajo.Text = "Fin"
        '
        'cbxFechaFinTrabajo
        '
        Me.cbxFechaFinTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaFinTrabajo.Location = New System.Drawing.Point(49, 44)
        Me.cbxFechaFinTrabajo.Name = "cbxFechaFinTrabajo"
        Me.cbxFechaFinTrabajo.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaFinTrabajo.TabIndex = 40
        '
        'lblFechaInicioTrabajo
        '
        Me.lblFechaInicioTrabajo.Location = New System.Drawing.Point(9, 23)
        Me.lblFechaInicioTrabajo.Name = "lblFechaInicioTrabajo"
        Me.lblFechaInicioTrabajo.Size = New System.Drawing.Size(38, 13)
        Me.lblFechaInicioTrabajo.TabIndex = 184
        Me.lblFechaInicioTrabajo.Tag = ""
        Me.lblFechaInicioTrabajo.Text = "Inicio"
        '
        'cbxFechaInicioTrabajo
        '
        Me.cbxFechaInicioTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaInicioTrabajo.Location = New System.Drawing.Point(49, 19)
        Me.cbxFechaInicioTrabajo.Name = "cbxFechaInicioTrabajo"
        Me.cbxFechaInicioTrabajo.Size = New System.Drawing.Size(97, 21)
        Me.cbxFechaInicioTrabajo.TabIndex = 39
        '
        'lblCentroGestionTrabajo
        '
        Me.lblCentroGestionTrabajo.Location = New System.Drawing.Point(312, 95)
        Me.lblCentroGestionTrabajo.Name = "lblCentroGestionTrabajo"
        Me.lblCentroGestionTrabajo.Size = New System.Drawing.Size(67, 13)
        Me.lblCentroGestionTrabajo.TabIndex = 182
        Me.lblCentroGestionTrabajo.Tag = ""
        Me.lblCentroGestionTrabajo.Text = "C. Gestión"
        '
        'cbxIDCentroGestion
        '
        cbxIDCentroGestion_DesignTimeLayout.LayoutString = resources.GetString("cbxIDCentroGestion_DesignTimeLayout.LayoutString")
        Me.cbxIDCentroGestion.DesignTimeLayout = cbxIDCentroGestion_DesignTimeLayout
        Me.cbxIDCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDCentroGestion.DisplayMember = "IDCentroGestion"
        Me.cbxIDCentroGestion.EntityName = "CentroGestion"
        Me.cbxIDCentroGestion.Location = New System.Drawing.Point(379, 91)
        Me.cbxIDCentroGestion.Name = "cbxIDCentroGestion"
        Me.cbxIDCentroGestion.PrimaryDataFields = "IDCentroGestion"
        Me.cbxIDCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.cbxIDCentroGestion.SelectedIndex = -1
        Me.cbxIDCentroGestion.SelectedItem = Nothing
        Me.cbxIDCentroGestion.Size = New System.Drawing.Size(91, 21)
        Me.cbxIDCentroGestion.TabIndex = 41
        Me.cbxIDCentroGestion.ValueMember = "IDCentroGestion"
        Me.cbxIDCentroGestion.ViewName = "tbMaestroCentroGestion"
        '
        'lblNumPedido
        '
        Me.lblNumPedido.Location = New System.Drawing.Point(159, 95)
        Me.lblNumPedido.Name = "lblNumPedido"
        Me.lblNumPedido.Size = New System.Drawing.Size(45, 13)
        Me.lblNumPedido.TabIndex = 147
        Me.lblNumPedido.Tag = ""
        Me.lblNumPedido.Text = "Pedido"
        '
        'txtNumPedido
        '
        Me.txtNumPedido.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumPedido.Location = New System.Drawing.Point(206, 91)
        Me.txtNumPedido.Name = "txtNumPedido"
        Me.txtNumPedido.Size = New System.Drawing.Size(102, 21)
        Me.txtNumPedido.TabIndex = 37
        '
        'lblSolapeAnt
        '
        Me.lblSolapeAnt.Location = New System.Drawing.Point(8, 70)
        Me.lblSolapeAnt.Name = "lblSolapeAnt"
        Me.lblSolapeAnt.Size = New System.Drawing.Size(46, 13)
        Me.lblSolapeAnt.TabIndex = 143
        Me.lblSolapeAnt.Tag = ""
        Me.lblSolapeAnt.Text = "Solape"
        '
        'txtSolapeAnt
        '
        Me.txtSolapeAnt.DisabledBackColor = System.Drawing.Color.White
        Me.txtSolapeAnt.Location = New System.Drawing.Point(90, 66)
        Me.txtSolapeAnt.Name = "txtSolapeAnt"
        Me.txtSolapeAnt.Size = New System.Drawing.Size(68, 21)
        Me.txtSolapeAnt.TabIndex = 35
        Me.txtSolapeAnt.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'lblSecuencia
        '
        Me.lblSecuencia.Location = New System.Drawing.Point(8, 20)
        Me.lblSecuencia.Name = "lblSecuencia"
        Me.lblSecuencia.Size = New System.Drawing.Size(65, 13)
        Me.lblSecuencia.TabIndex = 144
        Me.lblSecuencia.Tag = ""
        Me.lblSecuencia.Text = "Secuencia"
        '
        'txtSecuencia
        '
        Me.txtSecuencia.DisabledBackColor = System.Drawing.Color.White
        Me.txtSecuencia.Location = New System.Drawing.Point(90, 16)
        Me.txtSecuencia.Name = "txtSecuencia"
        Me.txtSecuencia.Size = New System.Drawing.Size(68, 21)
        Me.txtSecuencia.TabIndex = 33
        Me.txtSecuencia.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        '
        'lblDuracionPresup
        '
        Me.lblDuracionPresup.Location = New System.Drawing.Point(8, 45)
        Me.lblDuracionPresup.Name = "lblDuracionPresup"
        Me.lblDuracionPresup.Size = New System.Drawing.Size(62, 13)
        Me.lblDuracionPresup.TabIndex = 145
        Me.lblDuracionPresup.Tag = ""
        Me.lblDuracionPresup.Text = "Duración "
        '
        'lblIDArticulo
        '
        Me.lblIDArticulo.Location = New System.Drawing.Point(2, 157)
        Me.lblIDArticulo.Name = "lblIDArticulo"
        Me.lblIDArticulo.Size = New System.Drawing.Size(50, 13)
        Me.lblIDArticulo.TabIndex = 206
        Me.lblIDArticulo.Tag = ""
        Me.lblIDArticulo.Text = "Artículo"
        '
        'AdvIDArticulo
        '
        Me.AdvIDArticulo.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDArticulo.EntityName = "Articulo"
        Me.AdvIDArticulo.Location = New System.Drawing.Point(90, 152)
        Me.AdvIDArticulo.Name = "AdvIDArticulo"
        Me.AdvIDArticulo.PrimaryDataFields = "IDArticulo"
        Me.AdvIDArticulo.SecondaryDataFields = "IDArticulo"
        Me.AdvIDArticulo.Size = New System.Drawing.Size(125, 23)
        Me.AdvIDArticulo.TabIndex = 31
        Me.AdvIDArticulo.ViewName = "tbMaestroArticulo"
        '
        'chkNoAcumular
        '
        Me.chkNoAcumular.Location = New System.Drawing.Point(376, 102)
        Me.chkNoAcumular.Name = "chkNoAcumular"
        Me.chkNoAcumular.Size = New System.Drawing.Size(97, 21)
        Me.chkNoAcumular.TabIndex = 27
        Me.chkNoAcumular.Text = "No Acumular"
        '
        'lblUDMedida
        '
        Me.lblUDMedida.Location = New System.Drawing.Point(2, 56)
        Me.lblUDMedida.Name = "lblUDMedida"
        Me.lblUDMedida.Size = New System.Drawing.Size(70, 13)
        Me.lblUDMedida.TabIndex = 195
        Me.lblUDMedida.Tag = ""
        Me.lblUDMedida.Text = "Ud. Medida"
        '
        'lblQPresup
        '
        Me.lblQPresup.Location = New System.Drawing.Point(185, 106)
        Me.lblQPresup.Name = "lblQPresup"
        Me.lblQPresup.Size = New System.Drawing.Size(67, 13)
        Me.lblQPresup.TabIndex = 196
        Me.lblQPresup.Tag = ""
        Me.lblQPresup.Text = "C. Presup."
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(2, 31)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(50, 13)
        Me.lblCodTrabajo.TabIndex = 198
        Me.lblCodTrabajo.Tag = ""
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'cbxIDUDMedida
        '
        cbxIDUDMedida_DesignTimeLayout.LayoutString = resources.GetString("cbxIDUDMedida_DesignTimeLayout.LayoutString")
        Me.cbxIDUDMedida.DesignTimeLayout = cbxIDUDMedida_DesignTimeLayout
        Me.cbxIDUDMedida.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDUDMedida.DisplayMember = "IDUdMedida"
        Me.cbxIDUDMedida.EntityName = "UdMedida"
        Me.cbxIDUDMedida.Location = New System.Drawing.Point(90, 52)
        Me.cbxIDUDMedida.Name = "cbxIDUDMedida"
        Me.cbxIDUDMedida.PrimaryDataFields = "IDUdMedida"
        Me.cbxIDUDMedida.SecondaryDataFields = "IDUdMedida"
        Me.cbxIDUDMedida.SelectedIndex = -1
        Me.cbxIDUDMedida.SelectedItem = Nothing
        Me.cbxIDUDMedida.Size = New System.Drawing.Size(124, 21)
        Me.cbxIDUDMedida.TabIndex = 22
        Me.cbxIDUDMedida.ValueMember = "IDUdMedida"
        Me.cbxIDUDMedida.ViewName = "tbMaestroUdMedida"
        '
        'lblImpUnitarioVtaA
        '
        Me.lblImpUnitarioVtaA.Location = New System.Drawing.Point(281, 131)
        Me.lblImpUnitarioVtaA.Name = "lblImpUnitarioVtaA"
        Me.lblImpUnitarioVtaA.Size = New System.Drawing.Size(109, 13)
        Me.lblImpUnitarioVtaA.TabIndex = 191
        Me.lblImpUnitarioVtaA.Tag = ""
        Me.lblImpUnitarioVtaA.Text = "Imp. Unitario Vta."
        Me.lblImpUnitarioVtaA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtImpUnitarioVta
        '
        Me.txtImpUnitarioVta.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpUnitarioVta.Enabled = False
        Me.txtImpUnitarioVta.Location = New System.Drawing.Point(388, 127)
        Me.txtImpUnitarioVta.Name = "txtImpUnitarioVta"
        Me.txtImpUnitarioVta.Size = New System.Drawing.Size(89, 21)
        Me.txtImpUnitarioVta.TabIndex = 30
        '
        'lblImpUnitario
        '
        Me.lblImpUnitario.Location = New System.Drawing.Point(2, 131)
        Me.lblImpUnitario.Name = "lblImpUnitario"
        Me.lblImpUnitario.Size = New System.Drawing.Size(82, 13)
        Me.lblImpUnitario.TabIndex = 192
        Me.lblImpUnitario.Tag = ""
        Me.lblImpUnitario.Text = "Imp. Unitario"
        '
        'txtImpUnitario
        '
        Me.txtImpUnitario.DisabledBackColor = System.Drawing.Color.White
        Me.txtImpUnitario.Location = New System.Drawing.Point(90, 127)
        Me.txtImpUnitario.Name = "txtImpUnitario"
        Me.txtImpUnitario.Size = New System.Drawing.Size(87, 21)
        Me.txtImpUnitario.TabIndex = 28
        '
        'txtQPresup
        '
        Me.txtQPresup.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPresup.Location = New System.Drawing.Point(273, 102)
        Me.txtQPresup.Name = "txtQPresup"
        Me.txtQPresup.Size = New System.Drawing.Size(87, 21)
        Me.txtQPresup.TabIndex = 26
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Location = New System.Drawing.Point(217, 27)
        Me.txtDescTrabajo.Multiline = True
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(261, 46)
        Me.txtDescTrabajo.TabIndex = 21
        '
        'lblTipoTrabajo
        '
        Me.lblTipoTrabajo.Location = New System.Drawing.Point(2, 6)
        Me.lblTipoTrabajo.Name = "lblTipoTrabajo"
        Me.lblTipoTrabajo.Size = New System.Drawing.Size(78, 13)
        Me.lblTipoTrabajo.TabIndex = 193
        Me.lblTipoTrabajo.Tag = ""
        Me.lblTipoTrabajo.Text = "Tipo Trabajo"
        '
        'lblSubTipoTrabajo
        '
        Me.lblSubTipoTrabajo.Location = New System.Drawing.Point(179, 6)
        Me.lblSubTipoTrabajo.Name = "lblSubTipoTrabajo"
        Me.lblSubTipoTrabajo.Size = New System.Drawing.Size(53, 13)
        Me.lblSubTipoTrabajo.TabIndex = 194
        Me.lblSubTipoTrabajo.Tag = ""
        Me.lblSubTipoTrabajo.Text = "SubTipo"
        '
        'txtCodTrabajo
        '
        Me.txtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajo.Enabled = False
        Me.txtCodTrabajo.Location = New System.Drawing.Point(90, 27)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(124, 21)
        Me.txtCodTrabajo.TabIndex = 20
        '
        'pnlGridTrabajo
        '
        Me.pnlGridTrabajo.Controls.Add(Me.GridTrabajos)
        Me.pnlGridTrabajo.Controls.Add(Me.pnlVerTrabajo)
        Me.pnlGridTrabajo.Controls.Add(Me.pnlConfigVerGridTrabajo)
        Me.pnlGridTrabajo.Controls.Add(Me.FraImportesTrabajoGrid)
        Me.pnlGridTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlGridTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.pnlGridTrabajo.Name = "pnlGridTrabajo"
        Me.pnlGridTrabajo.Size = New System.Drawing.Size(484, 440)
        Me.pnlGridTrabajo.TabIndex = 2
        '
        'GridTrabajos
        '
        Me.GridTrabajos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDTipoTrabajo", "ObraTipoTrabajo", "IDTipoTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDSubtipoTrabajo", "ObraSubtipoTrabajo", "IDSubtipoTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDUDMedida", "UdMedida", "IDUDMedida"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDArticulo", "Articulo", "IDArticulo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentroGestion", "CentroGestion", "IDCentroGestion"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("SubSubTipoTrabajo", "ObraSubSubtipoTrabajo", "IDSubSubtipoTrabajo"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajoPadre", "ObraTrabajoPresup", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajoPresup", "IDTrabajoPresupPadre")}))})
        Me.GridTrabajos.AllowDrop = True
        GridTrabajos_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridTrabajos_DesignTimeLayout_Reference_0.Instance"), Object)
        GridTrabajos_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridTrabajos_DesignTimeLayout_Reference_0})
        GridTrabajos_DesignTimeLayout.LayoutString = resources.GetString("GridTrabajos_DesignTimeLayout.LayoutString")
        Me.GridTrabajos.DesignTimeLayout = GridTrabajos_DesignTimeLayout
        Me.GridTrabajos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTrabajos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTrabajos.EntityName = ""
        Me.GridTrabajos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridTrabajos.FrozenColumns = 8
        Me.GridTrabajos.ImageList = Me.ImageList1
        Me.GridTrabajos.Location = New System.Drawing.Point(0, 56)
        Me.GridTrabajos.Name = "GridTrabajos"
        Me.GridTrabajos.PrimaryDataFields = ""
        Me.GridTrabajos.SecondaryDataFields = ""
        Me.GridTrabajos.Size = New System.Drawing.Size(484, 333)
        Me.GridTrabajos.TabIndex = 55
        Me.GridTrabajos.ViewName = ""
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "folder_edit.ico")
        Me.ImageList1.Images.SetKeyName(10, "branch_element.ico")
        '
        'pnlVerTrabajo
        '
        Me.pnlVerTrabajo.Controls.Add(Me.txtDescTrabajoGrid)
        Me.pnlVerTrabajo.Controls.Add(Me.lblTrabajoGrid)
        Me.pnlVerTrabajo.Controls.Add(Me.txtTrabajoGrid)
        Me.pnlVerTrabajo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerTrabajo.Location = New System.Drawing.Point(0, 26)
        Me.pnlVerTrabajo.Name = "pnlVerTrabajo"
        Me.pnlVerTrabajo.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerTrabajo.TabIndex = 51
        Me.pnlVerTrabajo.Visible = False
        '
        'txtDescTrabajoGrid
        '
        Me.txtDescTrabajoGrid.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoGrid.Enabled = False
        Me.txtDescTrabajoGrid.Location = New System.Drawing.Point(157, 6)
        Me.txtDescTrabajoGrid.Name = "txtDescTrabajoGrid"
        Me.txtDescTrabajoGrid.Size = New System.Drawing.Size(320, 21)
        Me.txtDescTrabajoGrid.TabIndex = 201
        Me.txtDescTrabajoGrid.TabStop = False
        '
        'lblTrabajoGrid
        '
        Me.lblTrabajoGrid.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoGrid.Name = "lblTrabajoGrid"
        Me.lblTrabajoGrid.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoGrid.TabIndex = 200
        Me.lblTrabajoGrid.Tag = ""
        Me.lblTrabajoGrid.Text = "Trabajo"
        '
        'txtTrabajoGrid
        '
        Me.txtTrabajoGrid.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoGrid.Enabled = False
        Me.txtTrabajoGrid.Location = New System.Drawing.Point(58, 6)
        Me.txtTrabajoGrid.Name = "txtTrabajoGrid"
        Me.txtTrabajoGrid.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoGrid.TabIndex = 199
        Me.txtTrabajoGrid.TabStop = False
        '
        'pnlConfigVerGridTrabajo
        '
        Me.pnlConfigVerGridTrabajo.Controls.Add(Me.rbtPorMultinivelTrabajos)
        Me.pnlConfigVerGridTrabajo.Controls.Add(Me.lblVerPresupTrabajos)
        Me.pnlConfigVerGridTrabajo.Controls.Add(Me.rbtPorNivelTrabajos)
        Me.pnlConfigVerGridTrabajo.Controls.Add(Me.rbtPresupTrabajos)
        Me.pnlConfigVerGridTrabajo.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerGridTrabajo.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerGridTrabajo.Name = "pnlConfigVerGridTrabajo"
        Me.pnlConfigVerGridTrabajo.Size = New System.Drawing.Size(484, 26)
        Me.pnlConfigVerGridTrabajo.TabIndex = 52
        '
        'rbtPorMultinivelTrabajos
        '
        Me.rbtPorMultinivelTrabajos.Location = New System.Drawing.Point(379, 6)
        Me.rbtPorMultinivelTrabajos.Name = "rbtPorMultinivelTrabajos"
        Me.rbtPorMultinivelTrabajos.Size = New System.Drawing.Size(98, 12)
        Me.rbtPorMultinivelTrabajos.TabIndex = 11
        Me.rbtPorMultinivelTrabajos.Text = "por multinivel"
        '
        'lblVerPresupTrabajos
        '
        Me.lblVerPresupTrabajos.Location = New System.Drawing.Point(5, 6)
        Me.lblVerPresupTrabajos.Name = "lblVerPresupTrabajos"
        Me.lblVerPresupTrabajos.Size = New System.Drawing.Size(161, 13)
        Me.lblVerPresupTrabajos.TabIndex = 10
        Me.lblVerPresupTrabajos.Tag = ""
        Me.lblVerPresupTrabajos.Text = "Ver los datos de las líneas:"
        '
        'rbtPorNivelTrabajos
        '
        Me.rbtPorNivelTrabajos.Location = New System.Drawing.Point(304, 6)
        Me.rbtPorNivelTrabajos.Name = "rbtPorNivelTrabajos"
        Me.rbtPorNivelTrabajos.Size = New System.Drawing.Size(69, 12)
        Me.rbtPorNivelTrabajos.TabIndex = 9
        Me.rbtPorNivelTrabajos.Text = "por nivel"
        '
        'rbtPresupTrabajos
        '
        Me.rbtPresupTrabajos.Location = New System.Drawing.Point(186, 6)
        Me.rbtPresupTrabajos.Name = "rbtPresupTrabajos"
        Me.rbtPresupTrabajos.Size = New System.Drawing.Size(112, 12)
        Me.rbtPresupTrabajos.TabIndex = 8
        Me.rbtPresupTrabajos.Text = "por Presupuesto"
        '
        'FraImportesTrabajoGrid
        '
        Me.FraImportesTrabajoGrid.Controls.Add(Me.lblPresupTrabajoVentaGrid)
        Me.FraImportesTrabajoGrid.Controls.Add(Me.txtPresupVentaTrabajoGrid)
        Me.FraImportesTrabajoGrid.Controls.Add(Me.lblPresupTrabajoGrid)
        Me.FraImportesTrabajoGrid.Controls.Add(Me.txtPresupTrabajoGrid)
        Me.FraImportesTrabajoGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraImportesTrabajoGrid.Location = New System.Drawing.Point(0, 389)
        Me.FraImportesTrabajoGrid.Name = "FraImportesTrabajoGrid"
        Me.FraImportesTrabajoGrid.Size = New System.Drawing.Size(484, 51)
        Me.FraImportesTrabajoGrid.TabIndex = 49
        Me.FraImportesTrabajoGrid.TabStop = False
        Me.FraImportesTrabajoGrid.Text = "Importes Trabajo (Importes Totales)"
        '
        'lblPresupTrabajoVentaGrid
        '
        Me.lblPresupTrabajoVentaGrid.Location = New System.Drawing.Point(238, 21)
        Me.lblPresupTrabajoVentaGrid.Name = "lblPresupTrabajoVentaGrid"
        Me.lblPresupTrabajoVentaGrid.Size = New System.Drawing.Size(117, 13)
        Me.lblPresupTrabajoVentaGrid.TabIndex = 50
        Me.lblPresupTrabajoVentaGrid.Tag = "IdRec=0;"
        Me.lblPresupTrabajoVentaGrid.Text = "Total Presup. Venta"
        '
        'txtPresupVentaTrabajoGrid
        '
        Me.txtPresupVentaTrabajoGrid.DisabledBackColor = System.Drawing.Color.White
        Me.txtPresupVentaTrabajoGrid.Enabled = False
        Me.txtPresupVentaTrabajoGrid.Location = New System.Drawing.Point(359, 21)
        Me.txtPresupVentaTrabajoGrid.Name = "txtPresupVentaTrabajoGrid"
        Me.txtPresupVentaTrabajoGrid.Size = New System.Drawing.Size(116, 21)
        Me.txtPresupVentaTrabajoGrid.TabIndex = 51
        Me.txtPresupVentaTrabajoGrid.TabStop = False
        '
        'lblPresupTrabajoGrid
        '
        Me.lblPresupTrabajoGrid.Location = New System.Drawing.Point(28, 21)
        Me.lblPresupTrabajoGrid.Name = "lblPresupTrabajoGrid"
        Me.lblPresupTrabajoGrid.Size = New System.Drawing.Size(81, 13)
        Me.lblPresupTrabajoGrid.TabIndex = 52
        Me.lblPresupTrabajoGrid.Tag = ""
        Me.lblPresupTrabajoGrid.Text = "Total Presup."
        '
        'txtPresupTrabajoGrid
        '
        Me.txtPresupTrabajoGrid.DisabledBackColor = System.Drawing.Color.White
        Me.txtPresupTrabajoGrid.Enabled = False
        Me.txtPresupTrabajoGrid.Location = New System.Drawing.Point(114, 21)
        Me.txtPresupTrabajoGrid.Name = "txtPresupTrabajoGrid"
        Me.txtPresupTrabajoGrid.Size = New System.Drawing.Size(116, 21)
        Me.txtPresupTrabajoGrid.TabIndex = 49
        Me.txtPresupTrabajoGrid.TabStop = False
        '
        'pnlTrabajosCompleto
        '
        Me.pnlTrabajosCompleto.Controls.Add(Me.TvwObraCompleta)
        Me.pnlTrabajosCompleto.Controls.Add(Me.pnlVerTrabajosCompleto)
        Me.pnlTrabajosCompleto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTrabajosCompleto.Location = New System.Drawing.Point(0, 0)
        Me.pnlTrabajosCompleto.Name = "pnlTrabajosCompleto"
        Me.pnlTrabajosCompleto.Size = New System.Drawing.Size(484, 440)
        Me.pnlTrabajosCompleto.TabIndex = 182
        '
        'TvwObraCompleta
        '
        Me.TvwObraCompleta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TvwObraCompleta.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TvwObraCompleta.Location = New System.Drawing.Point(0, 30)
        Me.TvwObraCompleta.Name = "TvwObraCompleta"
        Me.TvwObraCompleta.Size = New System.Drawing.Size(484, 410)
        Me.TvwObraCompleta.TabIndex = 241
        '
        'pnlVerTrabajosCompleto
        '
        Me.pnlVerTrabajosCompleto.Controls.Add(Me.txtDescTrabajoCompleto)
        Me.pnlVerTrabajosCompleto.Controls.Add(Me.lblTrabajoCompleto)
        Me.pnlVerTrabajosCompleto.Controls.Add(Me.txtTrabajoCompleto)
        Me.pnlVerTrabajosCompleto.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerTrabajosCompleto.Location = New System.Drawing.Point(0, 0)
        Me.pnlVerTrabajosCompleto.Name = "pnlVerTrabajosCompleto"
        Me.pnlVerTrabajosCompleto.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerTrabajosCompleto.TabIndex = 185
        '
        'txtDescTrabajoCompleto
        '
        Me.txtDescTrabajoCompleto.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoCompleto.Enabled = False
        Me.txtDescTrabajoCompleto.Location = New System.Drawing.Point(188, 6)
        Me.txtDescTrabajoCompleto.Name = "txtDescTrabajoCompleto"
        Me.txtDescTrabajoCompleto.Size = New System.Drawing.Size(288, 21)
        Me.txtDescTrabajoCompleto.TabIndex = 201
        Me.txtDescTrabajoCompleto.TabStop = False
        '
        'lblTrabajoCompleto
        '
        Me.lblTrabajoCompleto.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoCompleto.Name = "lblTrabajoCompleto"
        Me.lblTrabajoCompleto.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoCompleto.TabIndex = 200
        Me.lblTrabajoCompleto.Tag = ""
        Me.lblTrabajoCompleto.Text = "Trabajo"
        '
        'txtTrabajoCompleto
        '
        Me.txtTrabajoCompleto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoCompleto.Enabled = False
        Me.txtTrabajoCompleto.Location = New System.Drawing.Point(62, 6)
        Me.txtTrabajoCompleto.Name = "txtTrabajoCompleto"
        Me.txtTrabajoCompleto.Size = New System.Drawing.Size(124, 21)
        Me.txtTrabajoCompleto.TabIndex = 199
        Me.txtTrabajoCompleto.TabStop = False
        '
        'TabPageMateriales
        '
        Me.TabPageMateriales.Controls.Add(Me.GridMateriales)
        Me.TabPageMateriales.Controls.Add(Me.FraTotalesMat)
        Me.TabPageMateriales.Controls.Add(Me.pnlVerMaterial)
        Me.TabPageMateriales.Controls.Add(Me.pnlConfigVerMaterial)
        Me.TabPageMateriales.Key = "Materiales"
        Me.TabPageMateriales.Location = New System.Drawing.Point(1, 1)
        Me.TabPageMateriales.Name = "TabPageMateriales"
        Me.TabPageMateriales.Size = New System.Drawing.Size(484, 440)
        Me.TabPageMateriales.TabStop = True
        Me.TabPageMateriales.Text = "Materiales"
        Me.TabPageMateriales.Visible = False
        '
        'GridMateriales
        '
        Me.GridMateriales.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDProveedor", "Proveedor", "IDProveedor"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajoPresup", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajoPresup", "IDTrabajoPresup"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("QPresup", "QPresupTrabajo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMaterial", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDMaterial")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDMaterialImportado", "Articulo", "IDArticulo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDArticulo", "IDMaterialImportado")}))})
        GridMateriales_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridMateriales_DesignTimeLayout_Reference_0.Instance"), Object)
        GridMateriales_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridMateriales_DesignTimeLayout_Reference_0})
        GridMateriales_DesignTimeLayout.LayoutString = resources.GetString("GridMateriales_DesignTimeLayout.LayoutString")
        Me.GridMateriales.DesignTimeLayout = GridMateriales_DesignTimeLayout
        Me.GridMateriales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMateriales.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMateriales.EntityName = ""
        Me.GridMateriales.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMateriales.FrozenColumns = 4
        Me.GridMateriales.ImageList = Me.ImageList1
        Me.GridMateriales.Location = New System.Drawing.Point(0, 56)
        Me.GridMateriales.Name = "GridMateriales"
        Me.GridMateriales.PrimaryDataFields = ""
        Me.GridMateriales.SecondaryDataFields = ""
        Me.GridMateriales.Size = New System.Drawing.Size(484, 333)
        Me.GridMateriales.TabIndex = 12
        Me.GridMateriales.ViewName = ""
        '
        'FraTotalesMat
        '
        Me.FraTotalesMat.Controls.Add(Me.lblTotalMaterialVenta)
        Me.FraTotalesMat.Controls.Add(Me.txtTotalMaterialVenta)
        Me.FraTotalesMat.Controls.Add(Me.lblTotalMaterial)
        Me.FraTotalesMat.Controls.Add(Me.txtTotalMaterial)
        Me.FraTotalesMat.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotalesMat.Location = New System.Drawing.Point(0, 389)
        Me.FraTotalesMat.Name = "FraTotalesMat"
        Me.FraTotalesMat.Size = New System.Drawing.Size(484, 51)
        Me.FraTotalesMat.TabIndex = 48
        Me.FraTotalesMat.TabStop = False
        Me.FraTotalesMat.Text = "Importes Unitarios"
        '
        'lblTotalMaterialVenta
        '
        Me.lblTotalMaterialVenta.Location = New System.Drawing.Point(238, 25)
        Me.lblTotalMaterialVenta.Name = "lblTotalMaterialVenta"
        Me.lblTotalMaterialVenta.Size = New System.Drawing.Size(117, 13)
        Me.lblTotalMaterialVenta.TabIndex = 50
        Me.lblTotalMaterialVenta.Tag = ""
        Me.lblTotalMaterialVenta.Text = "Total Presup. Venta"
        '
        'txtTotalMaterialVenta
        '
        Me.txtTotalMaterialVenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalMaterialVenta.Enabled = False
        Me.txtTotalMaterialVenta.Location = New System.Drawing.Point(359, 21)
        Me.txtTotalMaterialVenta.Name = "txtTotalMaterialVenta"
        Me.txtTotalMaterialVenta.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalMaterialVenta.TabIndex = 51
        Me.txtTotalMaterialVenta.TabStop = False
        '
        'lblTotalMaterial
        '
        Me.lblTotalMaterial.Location = New System.Drawing.Point(28, 25)
        Me.lblTotalMaterial.Name = "lblTotalMaterial"
        Me.lblTotalMaterial.Size = New System.Drawing.Size(81, 13)
        Me.lblTotalMaterial.TabIndex = 52
        Me.lblTotalMaterial.Tag = ""
        Me.lblTotalMaterial.Text = "Total Presup."
        '
        'txtTotalMaterial
        '
        Me.txtTotalMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalMaterial.Enabled = False
        Me.txtTotalMaterial.Location = New System.Drawing.Point(114, 21)
        Me.txtTotalMaterial.Name = "txtTotalMaterial"
        Me.txtTotalMaterial.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalMaterial.TabIndex = 49
        Me.txtTotalMaterial.TabStop = False
        '
        'pnlVerMaterial
        '
        Me.pnlVerMaterial.Controls.Add(Me.lblQPresupMat)
        Me.pnlVerMaterial.Controls.Add(Me.txtQPresupTrabajoMat)
        Me.pnlVerMaterial.Controls.Add(Me.txtDescTrabajoMat)
        Me.pnlVerMaterial.Controls.Add(Me.lblTrabajoMat)
        Me.pnlVerMaterial.Controls.Add(Me.txtTrabajoMat)
        Me.pnlVerMaterial.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerMaterial.Location = New System.Drawing.Point(0, 26)
        Me.pnlVerMaterial.Name = "pnlVerMaterial"
        Me.pnlVerMaterial.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerMaterial.TabIndex = 15
        Me.pnlVerMaterial.Visible = False
        '
        'lblQPresupMat
        '
        Me.lblQPresupMat.Location = New System.Drawing.Point(342, 9)
        Me.lblQPresupMat.Name = "lblQPresupMat"
        Me.lblQPresupMat.Size = New System.Drawing.Size(63, 13)
        Me.lblQPresupMat.TabIndex = 203
        Me.lblQPresupMat.Tag = ""
        Me.lblQPresupMat.Text = "C. Presup"
        '
        'txtQPresupTrabajoMat
        '
        Me.txtQPresupTrabajoMat.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPresupTrabajoMat.Location = New System.Drawing.Point(403, 6)
        Me.txtQPresupTrabajoMat.Name = "txtQPresupTrabajoMat"
        Me.txtQPresupTrabajoMat.Size = New System.Drawing.Size(74, 21)
        Me.txtQPresupTrabajoMat.TabIndex = 202
        '
        'txtDescTrabajoMat
        '
        Me.txtDescTrabajoMat.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoMat.Enabled = False
        Me.txtDescTrabajoMat.Location = New System.Drawing.Point(157, 6)
        Me.txtDescTrabajoMat.Name = "txtDescTrabajoMat"
        Me.txtDescTrabajoMat.Size = New System.Drawing.Size(184, 21)
        Me.txtDescTrabajoMat.TabIndex = 201
        Me.txtDescTrabajoMat.TabStop = False
        '
        'lblTrabajoMat
        '
        Me.lblTrabajoMat.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoMat.Name = "lblTrabajoMat"
        Me.lblTrabajoMat.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoMat.TabIndex = 200
        Me.lblTrabajoMat.Tag = ""
        Me.lblTrabajoMat.Text = "Trabajo"
        '
        'txtTrabajoMat
        '
        Me.txtTrabajoMat.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoMat.Enabled = False
        Me.txtTrabajoMat.Location = New System.Drawing.Point(58, 6)
        Me.txtTrabajoMat.Name = "txtTrabajoMat"
        Me.txtTrabajoMat.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoMat.TabIndex = 199
        Me.txtTrabajoMat.TabStop = False
        '
        'pnlConfigVerMaterial
        '
        Me.pnlConfigVerMaterial.Controls.Add(Me.rbtPorMultinivelMat)
        Me.pnlConfigVerMaterial.Controls.Add(Me.lblVerPresupMat)
        Me.pnlConfigVerMaterial.Controls.Add(Me.rbtPorNivelMat)
        Me.pnlConfigVerMaterial.Controls.Add(Me.rbtPresupMat)
        Me.pnlConfigVerMaterial.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerMaterial.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerMaterial.Name = "pnlConfigVerMaterial"
        Me.pnlConfigVerMaterial.Size = New System.Drawing.Size(484, 26)
        Me.pnlConfigVerMaterial.TabIndex = 16
        '
        'rbtPorMultinivelMat
        '
        Me.rbtPorMultinivelMat.Location = New System.Drawing.Point(379, 6)
        Me.rbtPorMultinivelMat.Name = "rbtPorMultinivelMat"
        Me.rbtPorMultinivelMat.Size = New System.Drawing.Size(98, 17)
        Me.rbtPorMultinivelMat.TabIndex = 10
        Me.rbtPorMultinivelMat.Text = "por multinivel"
        '
        'lblVerPresupMat
        '
        Me.lblVerPresupMat.Location = New System.Drawing.Point(5, 6)
        Me.lblVerPresupMat.Name = "lblVerPresupMat"
        Me.lblVerPresupMat.Size = New System.Drawing.Size(161, 13)
        Me.lblVerPresupMat.TabIndex = 10
        Me.lblVerPresupMat.Tag = ""
        Me.lblVerPresupMat.Text = "Ver los datos de las líneas:"
        '
        'rbtPorNivelMat
        '
        Me.rbtPorNivelMat.Location = New System.Drawing.Point(304, 6)
        Me.rbtPorNivelMat.Name = "rbtPorNivelMat"
        Me.rbtPorNivelMat.Size = New System.Drawing.Size(69, 17)
        Me.rbtPorNivelMat.TabIndex = 9
        Me.rbtPorNivelMat.Text = "por nivel"
        '
        'rbtPresupMat
        '
        Me.rbtPresupMat.Location = New System.Drawing.Point(186, 6)
        Me.rbtPresupMat.Name = "rbtPresupMat"
        Me.rbtPresupMat.Size = New System.Drawing.Size(112, 17)
        Me.rbtPresupMat.TabIndex = 8
        Me.rbtPresupMat.Text = "por Presupuesto"
        '
        'TabPageMOD
        '
        Me.TabPageMOD.Controls.Add(Me.GridMOD)
        Me.TabPageMOD.Controls.Add(Me.FraTotalesMOD)
        Me.TabPageMOD.Controls.Add(Me.pnlVerMOD)
        Me.TabPageMOD.Controls.Add(Me.pnlConfigVerMod)
        Me.TabPageMOD.Key = "MOD"
        Me.TabPageMOD.Location = New System.Drawing.Point(1, 1)
        Me.TabPageMOD.Name = "TabPageMOD"
        Me.TabPageMOD.Size = New System.Drawing.Size(484, 440)
        Me.TabPageMOD.TabStop = True
        Me.TabPageMOD.Text = "M.O.D."
        Me.TabPageMOD.Visible = False
        '
        'GridMOD
        '
        Me.GridMOD.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajoPresup", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajoPresup", "IDTrabajoPresup"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("QPresup", "QPresupTrabajo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCategoria", "Categoria", "IDCategoria", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCategoria", "DescCategoria")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDHora", "Hora", "IDHora", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescHora", "DescHora")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCategoriaImportado", "Categoria", "IDCategoria", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCategoria", "DescCategoria")}))})
        GridMOD_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridMOD_DesignTimeLayout_Reference_0.Instance"), Object)
        GridMOD_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridMOD_DesignTimeLayout_Reference_0})
        GridMOD_DesignTimeLayout.LayoutString = resources.GetString("GridMOD_DesignTimeLayout.LayoutString")
        Me.GridMOD.DesignTimeLayout = GridMOD_DesignTimeLayout
        Me.GridMOD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMOD.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridMOD.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMOD.EntityName = ""
        Me.GridMOD.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMOD.FrozenColumns = 4
        Me.GridMOD.ImageList = Me.ImageList1
        Me.GridMOD.Location = New System.Drawing.Point(0, 56)
        Me.GridMOD.Name = "GridMOD"
        Me.GridMOD.PrimaryDataFields = ""
        Me.GridMOD.SecondaryDataFields = ""
        Me.GridMOD.Size = New System.Drawing.Size(484, 333)
        Me.GridMOD.TabIndex = 12
        Me.GridMOD.ViewName = ""
        '
        'FraTotalesMOD
        '
        Me.FraTotalesMOD.Controls.Add(Me.lblTotalMODVenta)
        Me.FraTotalesMOD.Controls.Add(Me.txtTotalMODVenta)
        Me.FraTotalesMOD.Controls.Add(Me.lblTotalMOD)
        Me.FraTotalesMOD.Controls.Add(Me.txtTotalMOD)
        Me.FraTotalesMOD.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotalesMOD.Location = New System.Drawing.Point(0, 389)
        Me.FraTotalesMOD.Name = "FraTotalesMOD"
        Me.FraTotalesMOD.Size = New System.Drawing.Size(484, 51)
        Me.FraTotalesMOD.TabIndex = 49
        Me.FraTotalesMOD.TabStop = False
        Me.FraTotalesMOD.Text = "Importes Unitarios"
        '
        'lblTotalMODVenta
        '
        Me.lblTotalMODVenta.Location = New System.Drawing.Point(238, 25)
        Me.lblTotalMODVenta.Name = "lblTotalMODVenta"
        Me.lblTotalMODVenta.Size = New System.Drawing.Size(117, 13)
        Me.lblTotalMODVenta.TabIndex = 51
        Me.lblTotalMODVenta.Tag = "IdRec=0;"
        Me.lblTotalMODVenta.Text = "Total Presup. Venta"
        '
        'txtTotalMODVenta
        '
        Me.txtTotalMODVenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalMODVenta.Enabled = False
        Me.txtTotalMODVenta.Location = New System.Drawing.Point(359, 21)
        Me.txtTotalMODVenta.Name = "txtTotalMODVenta"
        Me.txtTotalMODVenta.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalMODVenta.TabIndex = 52
        Me.txtTotalMODVenta.TabStop = False
        '
        'lblTotalMOD
        '
        Me.lblTotalMOD.Location = New System.Drawing.Point(28, 25)
        Me.lblTotalMOD.Name = "lblTotalMOD"
        Me.lblTotalMOD.Size = New System.Drawing.Size(81, 13)
        Me.lblTotalMOD.TabIndex = 53
        Me.lblTotalMOD.Tag = ""
        Me.lblTotalMOD.Text = "Total Presup."
        '
        'txtTotalMOD
        '
        Me.txtTotalMOD.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalMOD.Enabled = False
        Me.txtTotalMOD.Location = New System.Drawing.Point(114, 21)
        Me.txtTotalMOD.Name = "txtTotalMOD"
        Me.txtTotalMOD.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalMOD.TabIndex = 50
        Me.txtTotalMOD.TabStop = False
        '
        'pnlVerMOD
        '
        Me.pnlVerMOD.Controls.Add(Me.lblQPresupMod)
        Me.pnlVerMOD.Controls.Add(Me.txtQPresupTrabajoMod)
        Me.pnlVerMOD.Controls.Add(Me.txtDescTrabajoMod)
        Me.pnlVerMOD.Controls.Add(Me.lblTrabajoMod)
        Me.pnlVerMOD.Controls.Add(Me.txtTrabajoMod)
        Me.pnlVerMOD.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerMOD.Location = New System.Drawing.Point(0, 26)
        Me.pnlVerMOD.Name = "pnlVerMOD"
        Me.pnlVerMOD.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerMOD.TabIndex = 17
        Me.pnlVerMOD.Visible = False
        '
        'lblQPresupMod
        '
        Me.lblQPresupMod.Location = New System.Drawing.Point(342, 9)
        Me.lblQPresupMod.Name = "lblQPresupMod"
        Me.lblQPresupMod.Size = New System.Drawing.Size(63, 13)
        Me.lblQPresupMod.TabIndex = 203
        Me.lblQPresupMod.Tag = ""
        Me.lblQPresupMod.Text = "C. Presup"
        '
        'txtQPresupTrabajoMod
        '
        Me.txtQPresupTrabajoMod.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPresupTrabajoMod.Location = New System.Drawing.Point(403, 6)
        Me.txtQPresupTrabajoMod.Name = "txtQPresupTrabajoMod"
        Me.txtQPresupTrabajoMod.Size = New System.Drawing.Size(74, 21)
        Me.txtQPresupTrabajoMod.TabIndex = 202
        '
        'txtDescTrabajoMod
        '
        Me.txtDescTrabajoMod.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoMod.Enabled = False
        Me.txtDescTrabajoMod.Location = New System.Drawing.Point(157, 6)
        Me.txtDescTrabajoMod.Name = "txtDescTrabajoMod"
        Me.txtDescTrabajoMod.Size = New System.Drawing.Size(184, 21)
        Me.txtDescTrabajoMod.TabIndex = 201
        Me.txtDescTrabajoMod.TabStop = False
        '
        'lblTrabajoMod
        '
        Me.lblTrabajoMod.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoMod.Name = "lblTrabajoMod"
        Me.lblTrabajoMod.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoMod.TabIndex = 200
        Me.lblTrabajoMod.Tag = ""
        Me.lblTrabajoMod.Text = "Trabajo"
        '
        'txtTrabajoMod
        '
        Me.txtTrabajoMod.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoMod.Enabled = False
        Me.txtTrabajoMod.Location = New System.Drawing.Point(58, 6)
        Me.txtTrabajoMod.Name = "txtTrabajoMod"
        Me.txtTrabajoMod.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoMod.TabIndex = 199
        Me.txtTrabajoMod.TabStop = False
        '
        'pnlConfigVerMod
        '
        Me.pnlConfigVerMod.Controls.Add(Me.rbtPorMultinivelMod)
        Me.pnlConfigVerMod.Controls.Add(Me.lblVerPresupMod)
        Me.pnlConfigVerMod.Controls.Add(Me.rbtPorNivelMod)
        Me.pnlConfigVerMod.Controls.Add(Me.rbtPresupMod)
        Me.pnlConfigVerMod.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerMod.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerMod.Name = "pnlConfigVerMod"
        Me.pnlConfigVerMod.Size = New System.Drawing.Size(484, 26)
        Me.pnlConfigVerMod.TabIndex = 18
        '
        'rbtPorMultinivelMod
        '
        Me.rbtPorMultinivelMod.Location = New System.Drawing.Point(379, 6)
        Me.rbtPorMultinivelMod.Name = "rbtPorMultinivelMod"
        Me.rbtPorMultinivelMod.Size = New System.Drawing.Size(98, 17)
        Me.rbtPorMultinivelMod.TabIndex = 10
        Me.rbtPorMultinivelMod.Text = "por multinivel"
        '
        'lblVerPresupMod
        '
        Me.lblVerPresupMod.Location = New System.Drawing.Point(5, 6)
        Me.lblVerPresupMod.Name = "lblVerPresupMod"
        Me.lblVerPresupMod.Size = New System.Drawing.Size(161, 13)
        Me.lblVerPresupMod.TabIndex = 10
        Me.lblVerPresupMod.Text = "Ver los datos de las líneas:"
        '
        'rbtPorNivelMod
        '
        Me.rbtPorNivelMod.Location = New System.Drawing.Point(304, 6)
        Me.rbtPorNivelMod.Name = "rbtPorNivelMod"
        Me.rbtPorNivelMod.Size = New System.Drawing.Size(69, 17)
        Me.rbtPorNivelMod.TabIndex = 9
        Me.rbtPorNivelMod.Text = "por nivel"
        '
        'rbtPresupMod
        '
        Me.rbtPresupMod.Location = New System.Drawing.Point(186, 6)
        Me.rbtPresupMod.Name = "rbtPresupMod"
        Me.rbtPresupMod.Size = New System.Drawing.Size(112, 17)
        Me.rbtPresupMod.TabIndex = 8
        Me.rbtPresupMod.Text = "por Presupuesto"
        '
        'TabPageCentros
        '
        Me.TabPageCentros.Controls.Add(Me.GridCentros)
        Me.TabPageCentros.Controls.Add(Me.FraTotalesCentros)
        Me.TabPageCentros.Controls.Add(Me.pnlVerCentros)
        Me.TabPageCentros.Controls.Add(Me.pnlConfigVerCentros)
        Me.TabPageCentros.Key = "Centros"
        Me.TabPageCentros.Location = New System.Drawing.Point(1, 1)
        Me.TabPageCentros.Name = "TabPageCentros"
        Me.TabPageCentros.Size = New System.Drawing.Size(484, 440)
        Me.TabPageCentros.TabStop = True
        Me.TabPageCentros.Text = "Centros"
        Me.TabPageCentros.Visible = False
        '
        'GridCentros
        '
        Me.GridCentros.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajoPresup", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajoPresup", "IDTrabajoPresup"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("QPresup", "QPresupTrabajo")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentro", "Centro", "IDCentro", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCentro", "DescCentro")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDCentroImportado", "Centro", "IDCentro", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescCentro", "DescCentro")}))})
        GridCentros_DesignTimeLayout_Reference_0.Instance = CType(resources.GetObject("GridCentros_DesignTimeLayout_Reference_0.Instance"), Object)
        GridCentros_DesignTimeLayout.LayoutReferences.AddRange(New Janus.Windows.Common.Layouts.JanusLayoutReference() {GridCentros_DesignTimeLayout_Reference_0})
        GridCentros_DesignTimeLayout.LayoutString = resources.GetString("GridCentros_DesignTimeLayout.LayoutString")
        Me.GridCentros.DesignTimeLayout = GridCentros_DesignTimeLayout
        Me.GridCentros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCentros.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridCentros.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCentros.EntityName = ""
        Me.GridCentros.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridCentros.FrozenColumns = 4
        Me.GridCentros.ImageList = Me.ImageList1
        Me.GridCentros.Location = New System.Drawing.Point(0, 56)
        Me.GridCentros.Name = "GridCentros"
        Me.GridCentros.PrimaryDataFields = ""
        Me.GridCentros.SecondaryDataFields = ""
        Me.GridCentros.Size = New System.Drawing.Size(484, 333)
        Me.GridCentros.TabIndex = 12
        Me.GridCentros.ViewName = ""
        '
        'FraTotalesCentros
        '
        Me.FraTotalesCentros.Controls.Add(Me.lblTotalCentrosVenta)
        Me.FraTotalesCentros.Controls.Add(Me.txtTotalCentrosVenta)
        Me.FraTotalesCentros.Controls.Add(Me.lblTotalCentros)
        Me.FraTotalesCentros.Controls.Add(Me.txtTotalCentros)
        Me.FraTotalesCentros.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotalesCentros.Location = New System.Drawing.Point(0, 389)
        Me.FraTotalesCentros.Name = "FraTotalesCentros"
        Me.FraTotalesCentros.Size = New System.Drawing.Size(484, 51)
        Me.FraTotalesCentros.TabIndex = 49
        Me.FraTotalesCentros.TabStop = False
        Me.FraTotalesCentros.Text = "Importes Unitarios"
        '
        'lblTotalCentrosVenta
        '
        Me.lblTotalCentrosVenta.Location = New System.Drawing.Point(238, 25)
        Me.lblTotalCentrosVenta.Name = "lblTotalCentrosVenta"
        Me.lblTotalCentrosVenta.Size = New System.Drawing.Size(117, 13)
        Me.lblTotalCentrosVenta.TabIndex = 52
        Me.lblTotalCentrosVenta.Tag = "IdRec=0;"
        Me.lblTotalCentrosVenta.Text = "Total Presup. Venta"
        '
        'txtTotalCentrosVenta
        '
        Me.txtTotalCentrosVenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalCentrosVenta.Enabled = False
        Me.txtTotalCentrosVenta.Location = New System.Drawing.Point(359, 21)
        Me.txtTotalCentrosVenta.Name = "txtTotalCentrosVenta"
        Me.txtTotalCentrosVenta.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalCentrosVenta.TabIndex = 53
        Me.txtTotalCentrosVenta.TabStop = False
        '
        'lblTotalCentros
        '
        Me.lblTotalCentros.Location = New System.Drawing.Point(28, 25)
        Me.lblTotalCentros.Name = "lblTotalCentros"
        Me.lblTotalCentros.Size = New System.Drawing.Size(81, 13)
        Me.lblTotalCentros.TabIndex = 54
        Me.lblTotalCentros.Tag = ""
        Me.lblTotalCentros.Text = "Total Presup."
        '
        'txtTotalCentros
        '
        Me.txtTotalCentros.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalCentros.Enabled = False
        Me.txtTotalCentros.Location = New System.Drawing.Point(114, 21)
        Me.txtTotalCentros.Name = "txtTotalCentros"
        Me.txtTotalCentros.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalCentros.TabIndex = 51
        Me.txtTotalCentros.TabStop = False
        '
        'pnlVerCentros
        '
        Me.pnlVerCentros.Controls.Add(Me.lblQPresupCentros)
        Me.pnlVerCentros.Controls.Add(Me.txtQPresupTrabajoCentros)
        Me.pnlVerCentros.Controls.Add(Me.txtDescTrabajoCentros)
        Me.pnlVerCentros.Controls.Add(Me.lblTrabajoCentro)
        Me.pnlVerCentros.Controls.Add(Me.txtTrabajoCentros)
        Me.pnlVerCentros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerCentros.Location = New System.Drawing.Point(0, 26)
        Me.pnlVerCentros.Name = "pnlVerCentros"
        Me.pnlVerCentros.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerCentros.TabIndex = 17
        Me.pnlVerCentros.Visible = False
        '
        'lblQPresupCentros
        '
        Me.lblQPresupCentros.Location = New System.Drawing.Point(342, 9)
        Me.lblQPresupCentros.Name = "lblQPresupCentros"
        Me.lblQPresupCentros.Size = New System.Drawing.Size(63, 13)
        Me.lblQPresupCentros.TabIndex = 203
        Me.lblQPresupCentros.Tag = ""
        Me.lblQPresupCentros.Text = "C. Presup"
        '
        'txtQPresupTrabajoCentros
        '
        Me.txtQPresupTrabajoCentros.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPresupTrabajoCentros.Location = New System.Drawing.Point(403, 6)
        Me.txtQPresupTrabajoCentros.Name = "txtQPresupTrabajoCentros"
        Me.txtQPresupTrabajoCentros.Size = New System.Drawing.Size(74, 21)
        Me.txtQPresupTrabajoCentros.TabIndex = 202
        '
        'txtDescTrabajoCentros
        '
        Me.txtDescTrabajoCentros.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoCentros.Enabled = False
        Me.txtDescTrabajoCentros.Location = New System.Drawing.Point(157, 6)
        Me.txtDescTrabajoCentros.Name = "txtDescTrabajoCentros"
        Me.txtDescTrabajoCentros.Size = New System.Drawing.Size(184, 21)
        Me.txtDescTrabajoCentros.TabIndex = 201
        Me.txtDescTrabajoCentros.TabStop = False
        '
        'lblTrabajoCentro
        '
        Me.lblTrabajoCentro.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoCentro.Name = "lblTrabajoCentro"
        Me.lblTrabajoCentro.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoCentro.TabIndex = 200
        Me.lblTrabajoCentro.Tag = ""
        Me.lblTrabajoCentro.Text = "Trabajo"
        '
        'txtTrabajoCentros
        '
        Me.txtTrabajoCentros.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoCentros.Enabled = False
        Me.txtTrabajoCentros.Location = New System.Drawing.Point(58, 6)
        Me.txtTrabajoCentros.Name = "txtTrabajoCentros"
        Me.txtTrabajoCentros.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoCentros.TabIndex = 199
        Me.txtTrabajoCentros.TabStop = False
        '
        'pnlConfigVerCentros
        '
        Me.pnlConfigVerCentros.Controls.Add(Me.rbtPorMultinivelCentros)
        Me.pnlConfigVerCentros.Controls.Add(Me.lblVerPresupCentros)
        Me.pnlConfigVerCentros.Controls.Add(Me.rbtPorNivelCentros)
        Me.pnlConfigVerCentros.Controls.Add(Me.rbtPresupCentros)
        Me.pnlConfigVerCentros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerCentros.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerCentros.Name = "pnlConfigVerCentros"
        Me.pnlConfigVerCentros.Size = New System.Drawing.Size(484, 26)
        Me.pnlConfigVerCentros.TabIndex = 18
        '
        'rbtPorMultinivelCentros
        '
        Me.rbtPorMultinivelCentros.Location = New System.Drawing.Point(379, 6)
        Me.rbtPorMultinivelCentros.Name = "rbtPorMultinivelCentros"
        Me.rbtPorMultinivelCentros.Size = New System.Drawing.Size(98, 17)
        Me.rbtPorMultinivelCentros.TabIndex = 10
        Me.rbtPorMultinivelCentros.Text = "por multinivel"
        '
        'lblVerPresupCentros
        '
        Me.lblVerPresupCentros.Location = New System.Drawing.Point(5, 6)
        Me.lblVerPresupCentros.Name = "lblVerPresupCentros"
        Me.lblVerPresupCentros.Size = New System.Drawing.Size(161, 13)
        Me.lblVerPresupCentros.TabIndex = 10
        Me.lblVerPresupCentros.Text = "Ver los datos de las líneas:"
        '
        'rbtPorNivelCentros
        '
        Me.rbtPorNivelCentros.Location = New System.Drawing.Point(304, 6)
        Me.rbtPorNivelCentros.Name = "rbtPorNivelCentros"
        Me.rbtPorNivelCentros.Size = New System.Drawing.Size(69, 17)
        Me.rbtPorNivelCentros.TabIndex = 9
        Me.rbtPorNivelCentros.Text = "por nivel"
        '
        'rbtPresupCentros
        '
        Me.rbtPresupCentros.Location = New System.Drawing.Point(186, 6)
        Me.rbtPresupCentros.Name = "rbtPresupCentros"
        Me.rbtPresupCentros.Size = New System.Drawing.Size(112, 17)
        Me.rbtPresupCentros.TabIndex = 8
        Me.rbtPresupCentros.Text = "por Presupuesto"
        '
        'TabPageGastos
        '
        Me.TabPageGastos.Controls.Add(Me.GridGastos)
        Me.TabPageGastos.Controls.Add(Me.FraTotalesGastos)
        Me.TabPageGastos.Controls.Add(Me.pnlVerGastos)
        Me.TabPageGastos.Controls.Add(Me.pnlConfigVerGastos)
        Me.TabPageGastos.Key = "Gastos"
        Me.TabPageGastos.Location = New System.Drawing.Point(1, 1)
        Me.TabPageGastos.Name = "TabPageGastos"
        Me.TabPageGastos.Size = New System.Drawing.Size(484, 440)
        Me.TabPageGastos.TabStop = True
        Me.TabPageGastos.Text = "Gastos"
        Me.TabPageGastos.Visible = False
        '
        'GridGastos
        '
        Me.GridGastos.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajoPresup", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajoPresup", "IDTrabajoPresup")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDGasto", "Gasto", "IDGasto", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescGasto", "DescGasto")}))})
        GridGastos_DesignTimeLayout.LayoutString = resources.GetString("GridGastos_DesignTimeLayout.LayoutString")
        Me.GridGastos.DesignTimeLayout = GridGastos_DesignTimeLayout
        Me.GridGastos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridGastos.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridGastos.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridGastos.EntityName = ""
        Me.GridGastos.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridGastos.FrozenColumns = 4
        Me.GridGastos.Location = New System.Drawing.Point(0, 56)
        Me.GridGastos.Name = "GridGastos"
        Me.GridGastos.PrimaryDataFields = ""
        Me.GridGastos.SecondaryDataFields = ""
        Me.GridGastos.Size = New System.Drawing.Size(484, 333)
        Me.GridGastos.TabIndex = 50
        Me.GridGastos.ViewName = ""
        '
        'FraTotalesGastos
        '
        Me.FraTotalesGastos.Controls.Add(Me.lblTotalGastosVenta)
        Me.FraTotalesGastos.Controls.Add(Me.txtTotalGastosVenta)
        Me.FraTotalesGastos.Controls.Add(Me.lblTotalGastos)
        Me.FraTotalesGastos.Controls.Add(Me.txtTotalGastos)
        Me.FraTotalesGastos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotalesGastos.Location = New System.Drawing.Point(0, 389)
        Me.FraTotalesGastos.Name = "FraTotalesGastos"
        Me.FraTotalesGastos.Size = New System.Drawing.Size(484, 51)
        Me.FraTotalesGastos.TabIndex = 49
        Me.FraTotalesGastos.TabStop = False
        Me.FraTotalesGastos.Text = "Importes Unitarios"
        '
        'lblTotalGastosVenta
        '
        Me.lblTotalGastosVenta.Location = New System.Drawing.Point(238, 25)
        Me.lblTotalGastosVenta.Name = "lblTotalGastosVenta"
        Me.lblTotalGastosVenta.Size = New System.Drawing.Size(117, 13)
        Me.lblTotalGastosVenta.TabIndex = 53
        Me.lblTotalGastosVenta.Tag = "IdRec=0;"
        Me.lblTotalGastosVenta.Text = "Total Presup. Venta"
        '
        'txtTotalGastosVenta
        '
        Me.txtTotalGastosVenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalGastosVenta.Enabled = False
        Me.txtTotalGastosVenta.Location = New System.Drawing.Point(359, 21)
        Me.txtTotalGastosVenta.Name = "txtTotalGastosVenta"
        Me.txtTotalGastosVenta.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalGastosVenta.TabIndex = 54
        Me.txtTotalGastosVenta.TabStop = False
        '
        'lblTotalGastos
        '
        Me.lblTotalGastos.Location = New System.Drawing.Point(28, 25)
        Me.lblTotalGastos.Name = "lblTotalGastos"
        Me.lblTotalGastos.Size = New System.Drawing.Size(81, 13)
        Me.lblTotalGastos.TabIndex = 55
        Me.lblTotalGastos.Tag = ""
        Me.lblTotalGastos.Text = "Total Presup."
        '
        'txtTotalGastos
        '
        Me.txtTotalGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalGastos.Enabled = False
        Me.txtTotalGastos.Location = New System.Drawing.Point(114, 21)
        Me.txtTotalGastos.Name = "txtTotalGastos"
        Me.txtTotalGastos.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalGastos.TabIndex = 52
        Me.txtTotalGastos.TabStop = False
        '
        'pnlVerGastos
        '
        Me.pnlVerGastos.Controls.Add(Me.lblQPresupGastos)
        Me.pnlVerGastos.Controls.Add(Me.txtQPresupTrabajoGastos)
        Me.pnlVerGastos.Controls.Add(Me.txtDescTrabajoGastos)
        Me.pnlVerGastos.Controls.Add(Me.lblTrabajoGasto)
        Me.pnlVerGastos.Controls.Add(Me.txtTrabajoGastos)
        Me.pnlVerGastos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerGastos.Location = New System.Drawing.Point(0, 26)
        Me.pnlVerGastos.Name = "pnlVerGastos"
        Me.pnlVerGastos.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerGastos.TabIndex = 17
        Me.pnlVerGastos.Visible = False
        '
        'lblQPresupGastos
        '
        Me.lblQPresupGastos.Location = New System.Drawing.Point(342, 9)
        Me.lblQPresupGastos.Name = "lblQPresupGastos"
        Me.lblQPresupGastos.Size = New System.Drawing.Size(63, 13)
        Me.lblQPresupGastos.TabIndex = 205
        Me.lblQPresupGastos.Tag = ""
        Me.lblQPresupGastos.Text = "C. Presup"
        '
        'txtQPresupTrabajoGastos
        '
        Me.txtQPresupTrabajoGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPresupTrabajoGastos.Location = New System.Drawing.Point(403, 6)
        Me.txtQPresupTrabajoGastos.Name = "txtQPresupTrabajoGastos"
        Me.txtQPresupTrabajoGastos.Size = New System.Drawing.Size(74, 21)
        Me.txtQPresupTrabajoGastos.TabIndex = 204
        '
        'txtDescTrabajoGastos
        '
        Me.txtDescTrabajoGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoGastos.Enabled = False
        Me.txtDescTrabajoGastos.Location = New System.Drawing.Point(157, 6)
        Me.txtDescTrabajoGastos.Name = "txtDescTrabajoGastos"
        Me.txtDescTrabajoGastos.Size = New System.Drawing.Size(184, 21)
        Me.txtDescTrabajoGastos.TabIndex = 201
        Me.txtDescTrabajoGastos.TabStop = False
        '
        'lblTrabajoGasto
        '
        Me.lblTrabajoGasto.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoGasto.Name = "lblTrabajoGasto"
        Me.lblTrabajoGasto.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoGasto.TabIndex = 200
        Me.lblTrabajoGasto.Tag = ""
        Me.lblTrabajoGasto.Text = "Trabajo"
        '
        'txtTrabajoGastos
        '
        Me.txtTrabajoGastos.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoGastos.Enabled = False
        Me.txtTrabajoGastos.Location = New System.Drawing.Point(58, 6)
        Me.txtTrabajoGastos.Name = "txtTrabajoGastos"
        Me.txtTrabajoGastos.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoGastos.TabIndex = 199
        Me.txtTrabajoGastos.TabStop = False
        '
        'pnlConfigVerGastos
        '
        Me.pnlConfigVerGastos.Controls.Add(Me.rbtPorMultinivelGastos)
        Me.pnlConfigVerGastos.Controls.Add(Me.lblVerPresupGastos)
        Me.pnlConfigVerGastos.Controls.Add(Me.rbtPorNivelGastos)
        Me.pnlConfigVerGastos.Controls.Add(Me.rbtPresupGastos)
        Me.pnlConfigVerGastos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerGastos.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerGastos.Name = "pnlConfigVerGastos"
        Me.pnlConfigVerGastos.Size = New System.Drawing.Size(484, 26)
        Me.pnlConfigVerGastos.TabIndex = 18
        '
        'rbtPorMultinivelGastos
        '
        Me.rbtPorMultinivelGastos.Location = New System.Drawing.Point(379, 6)
        Me.rbtPorMultinivelGastos.Name = "rbtPorMultinivelGastos"
        Me.rbtPorMultinivelGastos.Size = New System.Drawing.Size(98, 17)
        Me.rbtPorMultinivelGastos.TabIndex = 13
        Me.rbtPorMultinivelGastos.Text = "por multinivel"
        '
        'lblVerPresupGastos
        '
        Me.lblVerPresupGastos.Location = New System.Drawing.Point(5, 6)
        Me.lblVerPresupGastos.Name = "lblVerPresupGastos"
        Me.lblVerPresupGastos.Size = New System.Drawing.Size(161, 13)
        Me.lblVerPresupGastos.TabIndex = 10
        Me.lblVerPresupGastos.Text = "Ver los datos de las líneas:"
        '
        'rbtPorNivelGastos
        '
        Me.rbtPorNivelGastos.Location = New System.Drawing.Point(304, 6)
        Me.rbtPorNivelGastos.Name = "rbtPorNivelGastos"
        Me.rbtPorNivelGastos.Size = New System.Drawing.Size(69, 17)
        Me.rbtPorNivelGastos.TabIndex = 9
        Me.rbtPorNivelGastos.Text = "por nivel"
        '
        'rbtPresupGastos
        '
        Me.rbtPresupGastos.Location = New System.Drawing.Point(186, 6)
        Me.rbtPresupGastos.Name = "rbtPresupGastos"
        Me.rbtPresupGastos.Size = New System.Drawing.Size(112, 17)
        Me.rbtPresupGastos.TabIndex = 8
        Me.rbtPresupGastos.Text = "por Presupuesto"
        '
        'TabPageVarios
        '
        Me.TabPageVarios.Controls.Add(Me.GridVarios)
        Me.TabPageVarios.Controls.Add(Me.FraTotalesVarios)
        Me.TabPageVarios.Controls.Add(Me.pnlVerVarios)
        Me.TabPageVarios.Controls.Add(Me.pnlConfigVerVarios)
        Me.TabPageVarios.Key = "Varios"
        Me.TabPageVarios.Location = New System.Drawing.Point(1, 1)
        Me.TabPageVarios.Name = "TabPageVarios"
        Me.TabPageVarios.Size = New System.Drawing.Size(484, 440)
        Me.TabPageVarios.TabStop = True
        Me.TabPageVarios.Text = "Varios"
        Me.TabPageVarios.Visible = False
        '
        'GridVarios
        '
        Me.GridVarios.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajoPresup", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajoPresup", "IDTrabajoPresup")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDVarios", "Varios", "IDVarios", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescVarios", "DescVarios")}))})
        GridVarios_DesignTimeLayout.LayoutString = resources.GetString("GridVarios_DesignTimeLayout.LayoutString")
        Me.GridVarios.DesignTimeLayout = GridVarios_DesignTimeLayout
        Me.GridVarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVarios.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridVarios.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridVarios.EntityName = ""
        Me.GridVarios.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridVarios.FrozenColumns = 4
        Me.GridVarios.Location = New System.Drawing.Point(0, 56)
        Me.GridVarios.Name = "GridVarios"
        Me.GridVarios.PrimaryDataFields = ""
        Me.GridVarios.SecondaryDataFields = ""
        Me.GridVarios.Size = New System.Drawing.Size(484, 333)
        Me.GridVarios.TabIndex = 50
        Me.GridVarios.ViewName = ""
        '
        'FraTotalesVarios
        '
        Me.FraTotalesVarios.Controls.Add(Me.lblTotalVariosVenta)
        Me.FraTotalesVarios.Controls.Add(Me.txtTotalVariosVenta)
        Me.FraTotalesVarios.Controls.Add(Me.lblTotalVarios)
        Me.FraTotalesVarios.Controls.Add(Me.txtTotalVarios)
        Me.FraTotalesVarios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraTotalesVarios.Location = New System.Drawing.Point(0, 389)
        Me.FraTotalesVarios.Name = "FraTotalesVarios"
        Me.FraTotalesVarios.Size = New System.Drawing.Size(484, 51)
        Me.FraTotalesVarios.TabIndex = 49
        Me.FraTotalesVarios.TabStop = False
        Me.FraTotalesVarios.Text = "Importes Unitarios"
        '
        'lblTotalVariosVenta
        '
        Me.lblTotalVariosVenta.Location = New System.Drawing.Point(238, 25)
        Me.lblTotalVariosVenta.Name = "lblTotalVariosVenta"
        Me.lblTotalVariosVenta.Size = New System.Drawing.Size(117, 13)
        Me.lblTotalVariosVenta.TabIndex = 54
        Me.lblTotalVariosVenta.Tag = "IdRec=0;"
        Me.lblTotalVariosVenta.Text = "Total Presup. Venta"
        '
        'txtTotalVariosVenta
        '
        Me.txtTotalVariosVenta.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalVariosVenta.Enabled = False
        Me.txtTotalVariosVenta.Location = New System.Drawing.Point(359, 21)
        Me.txtTotalVariosVenta.Name = "txtTotalVariosVenta"
        Me.txtTotalVariosVenta.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalVariosVenta.TabIndex = 55
        Me.txtTotalVariosVenta.TabStop = False
        '
        'lblTotalVarios
        '
        Me.lblTotalVarios.Location = New System.Drawing.Point(28, 25)
        Me.lblTotalVarios.Name = "lblTotalVarios"
        Me.lblTotalVarios.Size = New System.Drawing.Size(81, 13)
        Me.lblTotalVarios.TabIndex = 56
        Me.lblTotalVarios.Tag = ""
        Me.lblTotalVarios.Text = "Total Presup."
        '
        'txtTotalVarios
        '
        Me.txtTotalVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalVarios.Enabled = False
        Me.txtTotalVarios.Location = New System.Drawing.Point(114, 21)
        Me.txtTotalVarios.Name = "txtTotalVarios"
        Me.txtTotalVarios.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalVarios.TabIndex = 53
        Me.txtTotalVarios.TabStop = False
        '
        'pnlVerVarios
        '
        Me.pnlVerVarios.Controls.Add(Me.lblQPresupVarios)
        Me.pnlVerVarios.Controls.Add(Me.txtQPresupTrabajoVarios)
        Me.pnlVerVarios.Controls.Add(Me.txtDescTrabajoVarios)
        Me.pnlVerVarios.Controls.Add(Me.lblTrabajoVarios)
        Me.pnlVerVarios.Controls.Add(Me.txtTrabajoVarios)
        Me.pnlVerVarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerVarios.Location = New System.Drawing.Point(0, 26)
        Me.pnlVerVarios.Name = "pnlVerVarios"
        Me.pnlVerVarios.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerVarios.TabIndex = 17
        Me.pnlVerVarios.Visible = False
        '
        'lblQPresupVarios
        '
        Me.lblQPresupVarios.Location = New System.Drawing.Point(342, 9)
        Me.lblQPresupVarios.Name = "lblQPresupVarios"
        Me.lblQPresupVarios.Size = New System.Drawing.Size(63, 13)
        Me.lblQPresupVarios.TabIndex = 205
        Me.lblQPresupVarios.Tag = ""
        Me.lblQPresupVarios.Text = "C. Presup"
        '
        'txtQPresupTrabajoVarios
        '
        Me.txtQPresupTrabajoVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPresupTrabajoVarios.Location = New System.Drawing.Point(403, 6)
        Me.txtQPresupTrabajoVarios.Name = "txtQPresupTrabajoVarios"
        Me.txtQPresupTrabajoVarios.Size = New System.Drawing.Size(74, 21)
        Me.txtQPresupTrabajoVarios.TabIndex = 204
        '
        'txtDescTrabajoVarios
        '
        Me.txtDescTrabajoVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoVarios.Enabled = False
        Me.txtDescTrabajoVarios.Location = New System.Drawing.Point(157, 6)
        Me.txtDescTrabajoVarios.Name = "txtDescTrabajoVarios"
        Me.txtDescTrabajoVarios.Size = New System.Drawing.Size(184, 21)
        Me.txtDescTrabajoVarios.TabIndex = 201
        Me.txtDescTrabajoVarios.TabStop = False
        '
        'lblTrabajoVarios
        '
        Me.lblTrabajoVarios.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoVarios.Name = "lblTrabajoVarios"
        Me.lblTrabajoVarios.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoVarios.TabIndex = 200
        Me.lblTrabajoVarios.Tag = ""
        Me.lblTrabajoVarios.Text = "Trabajo"
        '
        'txtTrabajoVarios
        '
        Me.txtTrabajoVarios.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoVarios.Enabled = False
        Me.txtTrabajoVarios.Location = New System.Drawing.Point(58, 6)
        Me.txtTrabajoVarios.Name = "txtTrabajoVarios"
        Me.txtTrabajoVarios.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoVarios.TabIndex = 199
        Me.txtTrabajoVarios.TabStop = False
        '
        'pnlConfigVerVarios
        '
        Me.pnlConfigVerVarios.Controls.Add(Me.rbtPorMultinivelVarios)
        Me.pnlConfigVerVarios.Controls.Add(Me.lblVerPresupVarios)
        Me.pnlConfigVerVarios.Controls.Add(Me.rbtPorNivelVarios)
        Me.pnlConfigVerVarios.Controls.Add(Me.rbtPresupVarios)
        Me.pnlConfigVerVarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerVarios.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerVarios.Name = "pnlConfigVerVarios"
        Me.pnlConfigVerVarios.Size = New System.Drawing.Size(484, 26)
        Me.pnlConfigVerVarios.TabIndex = 18
        '
        'rbtPorMultinivelVarios
        '
        Me.rbtPorMultinivelVarios.Location = New System.Drawing.Point(379, 6)
        Me.rbtPorMultinivelVarios.Name = "rbtPorMultinivelVarios"
        Me.rbtPorMultinivelVarios.Size = New System.Drawing.Size(98, 17)
        Me.rbtPorMultinivelVarios.TabIndex = 13
        Me.rbtPorMultinivelVarios.Text = "por multinivel"
        '
        'lblVerPresupVarios
        '
        Me.lblVerPresupVarios.Location = New System.Drawing.Point(5, 6)
        Me.lblVerPresupVarios.Name = "lblVerPresupVarios"
        Me.lblVerPresupVarios.Size = New System.Drawing.Size(161, 13)
        Me.lblVerPresupVarios.TabIndex = 10
        Me.lblVerPresupVarios.Text = "Ver los datos de las líneas:"
        '
        'rbtPorNivelVarios
        '
        Me.rbtPorNivelVarios.Location = New System.Drawing.Point(304, 6)
        Me.rbtPorNivelVarios.Name = "rbtPorNivelVarios"
        Me.rbtPorNivelVarios.Size = New System.Drawing.Size(69, 17)
        Me.rbtPorNivelVarios.TabIndex = 9
        Me.rbtPorNivelVarios.Text = "por nivel"
        '
        'rbtPresupVarios
        '
        Me.rbtPresupVarios.Location = New System.Drawing.Point(186, 6)
        Me.rbtPresupVarios.Name = "rbtPresupVarios"
        Me.rbtPresupVarios.Size = New System.Drawing.Size(112, 17)
        Me.rbtPresupVarios.TabIndex = 8
        Me.rbtPresupVarios.Text = "por Presupuesto"
        '
        'TabPageMediciones
        '
        Me.TabPageMediciones.Controls.Add(Me.GridMediciones)
        Me.TabPageMediciones.Controls.Add(Me.FraImportesMedicionesPresup)
        Me.TabPageMediciones.Controls.Add(Me.pnlVerMediciones)
        Me.TabPageMediciones.Controls.Add(Me.pnlConfigVerMediciones)
        Me.TabPageMediciones.Key = "Mediciones"
        Me.TabPageMediciones.Location = New System.Drawing.Point(1, 1)
        Me.TabPageMediciones.Name = "TabPageMediciones"
        Me.TabPageMediciones.Size = New System.Drawing.Size(484, 440)
        Me.TabPageMediciones.TabStop = True
        Me.TabPageMediciones.Text = "Mediciones"
        Me.TabPageMediciones.Visible = False
        '
        'GridMediciones
        '
        Me.GridMediciones.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("CodTrabajo", "ObraTrabajoPresup", "CodTrabajo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDTrabajoPresup", "IDTrabajoPresup")}))})
        GridMediciones_DesignTimeLayout.LayoutString = resources.GetString("GridMediciones_DesignTimeLayout.LayoutString")
        Me.GridMediciones.DesignTimeLayout = GridMediciones_DesignTimeLayout
        Me.GridMediciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridMediciones.EditorsControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.Regular
        Me.GridMediciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridMediciones.EntityName = ""
        Me.GridMediciones.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GridMediciones.FrozenColumns = 4
        Me.GridMediciones.Location = New System.Drawing.Point(0, 56)
        Me.GridMediciones.Name = "GridMediciones"
        Me.GridMediciones.PrimaryDataFields = ""
        Me.GridMediciones.SecondaryDataFields = ""
        Me.GridMediciones.Size = New System.Drawing.Size(484, 333)
        Me.GridMediciones.TabIndex = 20
        Me.GridMediciones.ViewName = ""
        '
        'FraImportesMedicionesPresup
        '
        Me.FraImportesMedicionesPresup.Controls.Add(Me.lblTotalMedicion)
        Me.FraImportesMedicionesPresup.Controls.Add(Me.txtTotalMedicion)
        Me.FraImportesMedicionesPresup.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraImportesMedicionesPresup.Location = New System.Drawing.Point(0, 389)
        Me.FraImportesMedicionesPresup.Name = "FraImportesMedicionesPresup"
        Me.FraImportesMedicionesPresup.Size = New System.Drawing.Size(484, 51)
        Me.FraImportesMedicionesPresup.TabIndex = 19
        Me.FraImportesMedicionesPresup.TabStop = False
        Me.FraImportesMedicionesPresup.Tag = ""
        '
        'lblTotalMedicion
        '
        Me.lblTotalMedicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalMedicion.AutoSize = False
        Me.lblTotalMedicion.Location = New System.Drawing.Point(242, 23)
        Me.lblTotalMedicion.Name = "lblTotalMedicion"
        Me.lblTotalMedicion.Size = New System.Drawing.Size(113, 17)
        Me.lblTotalMedicion.TabIndex = 100
        Me.lblTotalMedicion.Tag = ""
        Me.lblTotalMedicion.Text = "Total Medición"
        Me.lblTotalMedicion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalMedicion
        '
        Me.txtTotalMedicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMedicion.DisabledBackColor = System.Drawing.Color.White
        Me.txtTotalMedicion.Enabled = False
        Me.txtTotalMedicion.Location = New System.Drawing.Point(359, 21)
        Me.txtTotalMedicion.Name = "txtTotalMedicion"
        Me.txtTotalMedicion.Size = New System.Drawing.Size(116, 21)
        Me.txtTotalMedicion.TabIndex = 99
        Me.txtTotalMedicion.TabStop = False
        '
        'pnlVerMediciones
        '
        Me.pnlVerMediciones.Controls.Add(Me.lblQPresupMediciones)
        Me.pnlVerMediciones.Controls.Add(Me.txtQPresupTrabajoMediciones)
        Me.pnlVerMediciones.Controls.Add(Me.txtDescTrabajoMediciones)
        Me.pnlVerMediciones.Controls.Add(Me.lblTrabajoMedicion)
        Me.pnlVerMediciones.Controls.Add(Me.txtTrabajoMedicion)
        Me.pnlVerMediciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlVerMediciones.Location = New System.Drawing.Point(0, 26)
        Me.pnlVerMediciones.Name = "pnlVerMediciones"
        Me.pnlVerMediciones.Size = New System.Drawing.Size(484, 30)
        Me.pnlVerMediciones.TabIndex = 17
        Me.pnlVerMediciones.Visible = False
        '
        'lblQPresupMediciones
        '
        Me.lblQPresupMediciones.Location = New System.Drawing.Point(342, 9)
        Me.lblQPresupMediciones.Name = "lblQPresupMediciones"
        Me.lblQPresupMediciones.Size = New System.Drawing.Size(63, 13)
        Me.lblQPresupMediciones.TabIndex = 205
        Me.lblQPresupMediciones.Tag = ""
        Me.lblQPresupMediciones.Text = "C. Presup"
        '
        'txtQPresupTrabajoMediciones
        '
        Me.txtQPresupTrabajoMediciones.DisabledBackColor = System.Drawing.Color.White
        Me.txtQPresupTrabajoMediciones.Location = New System.Drawing.Point(403, 6)
        Me.txtQPresupTrabajoMediciones.Name = "txtQPresupTrabajoMediciones"
        Me.txtQPresupTrabajoMediciones.Size = New System.Drawing.Size(74, 21)
        Me.txtQPresupTrabajoMediciones.TabIndex = 204
        '
        'txtDescTrabajoMediciones
        '
        Me.txtDescTrabajoMediciones.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajoMediciones.Enabled = False
        Me.txtDescTrabajoMediciones.Location = New System.Drawing.Point(157, 6)
        Me.txtDescTrabajoMediciones.Name = "txtDescTrabajoMediciones"
        Me.txtDescTrabajoMediciones.Size = New System.Drawing.Size(184, 21)
        Me.txtDescTrabajoMediciones.TabIndex = 201
        Me.txtDescTrabajoMediciones.TabStop = False
        '
        'lblTrabajoMedicion
        '
        Me.lblTrabajoMedicion.Location = New System.Drawing.Point(5, 9)
        Me.lblTrabajoMedicion.Name = "lblTrabajoMedicion"
        Me.lblTrabajoMedicion.Size = New System.Drawing.Size(50, 13)
        Me.lblTrabajoMedicion.TabIndex = 200
        Me.lblTrabajoMedicion.Tag = ""
        Me.lblTrabajoMedicion.Text = "Trabajo"
        '
        'txtTrabajoMedicion
        '
        Me.txtTrabajoMedicion.DisabledBackColor = System.Drawing.Color.White
        Me.txtTrabajoMedicion.Enabled = False
        Me.txtTrabajoMedicion.Location = New System.Drawing.Point(58, 6)
        Me.txtTrabajoMedicion.Name = "txtTrabajoMedicion"
        Me.txtTrabajoMedicion.Size = New System.Drawing.Size(96, 21)
        Me.txtTrabajoMedicion.TabIndex = 199
        Me.txtTrabajoMedicion.TabStop = False
        '
        'pnlConfigVerMediciones
        '
        Me.pnlConfigVerMediciones.Controls.Add(Me.rbtPorMultinivelMedicion)
        Me.pnlConfigVerMediciones.Controls.Add(Me.lblVerPresupMedicion)
        Me.pnlConfigVerMediciones.Controls.Add(Me.rbtPorNivelMedicion)
        Me.pnlConfigVerMediciones.Controls.Add(Me.rbtPresupMedicion)
        Me.pnlConfigVerMediciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConfigVerMediciones.Location = New System.Drawing.Point(0, 0)
        Me.pnlConfigVerMediciones.Name = "pnlConfigVerMediciones"
        Me.pnlConfigVerMediciones.Size = New System.Drawing.Size(484, 26)
        Me.pnlConfigVerMediciones.TabIndex = 18
        '
        'rbtPorMultinivelMedicion
        '
        Me.rbtPorMultinivelMedicion.Location = New System.Drawing.Point(379, 6)
        Me.rbtPorMultinivelMedicion.Name = "rbtPorMultinivelMedicion"
        Me.rbtPorMultinivelMedicion.Size = New System.Drawing.Size(98, 17)
        Me.rbtPorMultinivelMedicion.TabIndex = 13
        Me.rbtPorMultinivelMedicion.Text = "por multinivel"
        '
        'lblVerPresupMedicion
        '
        Me.lblVerPresupMedicion.Location = New System.Drawing.Point(5, 6)
        Me.lblVerPresupMedicion.Name = "lblVerPresupMedicion"
        Me.lblVerPresupMedicion.Size = New System.Drawing.Size(161, 13)
        Me.lblVerPresupMedicion.TabIndex = 10
        Me.lblVerPresupMedicion.Text = "Ver los datos de las líneas:"
        '
        'rbtPorNivelMedicion
        '
        Me.rbtPorNivelMedicion.Location = New System.Drawing.Point(304, 6)
        Me.rbtPorNivelMedicion.Name = "rbtPorNivelMedicion"
        Me.rbtPorNivelMedicion.Size = New System.Drawing.Size(69, 17)
        Me.rbtPorNivelMedicion.TabIndex = 9
        Me.rbtPorNivelMedicion.Text = "por nivel"
        '
        'rbtPresupMedicion
        '
        Me.rbtPresupMedicion.Location = New System.Drawing.Point(186, 6)
        Me.rbtPresupMedicion.Name = "rbtPresupMedicion"
        Me.rbtPresupMedicion.Size = New System.Drawing.Size(112, 17)
        Me.rbtPresupMedicion.TabIndex = 8
        Me.rbtPresupMedicion.Text = "por Presupuesto"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(270, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(5, 442)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'pnlTrabajos
        '
        Me.pnlTrabajos.Controls.Add(Me.TvwTrabajos)
        Me.pnlTrabajos.Controls.Add(Me.FraArbol)
        Me.pnlTrabajos.Controls.Add(Me.FraCriterios)
        Me.pnlTrabajos.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTrabajos.Location = New System.Drawing.Point(0, 0)
        Me.pnlTrabajos.Name = "pnlTrabajos"
        Me.pnlTrabajos.Size = New System.Drawing.Size(270, 442)
        Me.pnlTrabajos.TabIndex = 1
        '
        'TvwTrabajos
        '
        Me.TvwTrabajos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TvwTrabajos.Location = New System.Drawing.Point(0, 58)
        Me.TvwTrabajos.Name = "TvwTrabajos"
        Me.TvwTrabajos.Size = New System.Drawing.Size(270, 344)
        Me.TvwTrabajos.TabIndex = 224
        '
        'FraArbol
        '
        Me.FraArbol.Controls.Add(Me.chkVerPorcentajes)
        Me.FraArbol.Controls.Add(Me.rbtMinimizarTree)
        Me.FraArbol.Controls.Add(Me.rbtMaximizarTree)
        Me.FraArbol.Dock = System.Windows.Forms.DockStyle.Top
        Me.FraArbol.Location = New System.Drawing.Point(0, 0)
        Me.FraArbol.Name = "FraArbol"
        Me.FraArbol.Size = New System.Drawing.Size(270, 58)
        Me.FraArbol.TabIndex = 223
        Me.FraArbol.TabStop = False
        Me.FraArbol.Text = "Criterios árbol"
        '
        'chkVerPorcentajes
        '
        Me.chkVerPorcentajes.Location = New System.Drawing.Point(6, 34)
        Me.chkVerPorcentajes.Name = "chkVerPorcentajes"
        Me.chkVerPorcentajes.Size = New System.Drawing.Size(144, 20)
        Me.chkVerPorcentajes.TabIndex = 226
        Me.chkVerPorcentajes.Text = "Ver incrementos"
        '
        'rbtMinimizarTree
        '
        Me.rbtMinimizarTree.Location = New System.Drawing.Point(167, 16)
        Me.rbtMinimizarTree.Name = "rbtMinimizarTree"
        Me.rbtMinimizarTree.Size = New System.Drawing.Size(77, 15)
        Me.rbtMinimizarTree.TabIndex = 225
        Me.rbtMinimizarTree.Text = "Contraer"
        '
        'rbtMaximizarTree
        '
        Me.rbtMaximizarTree.Location = New System.Drawing.Point(8, 16)
        Me.rbtMaximizarTree.Name = "rbtMaximizarTree"
        Me.rbtMaximizarTree.Size = New System.Drawing.Size(84, 16)
        Me.rbtMaximizarTree.TabIndex = 224
        Me.rbtMaximizarTree.Text = "Expandir"
        '
        'FraCriterios
        '
        Me.FraCriterios.Controls.Add(Me.rbtVerPresupuestoCompleto)
        Me.FraCriterios.Controls.Add(Me.rbtVerGrid)
        Me.FraCriterios.Controls.Add(Me.rbtVerFicha)
        Me.FraCriterios.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FraCriterios.Location = New System.Drawing.Point(0, 402)
        Me.FraCriterios.Name = "FraCriterios"
        Me.FraCriterios.Size = New System.Drawing.Size(270, 40)
        Me.FraCriterios.TabIndex = 0
        Me.FraCriterios.TabStop = False
        Me.FraCriterios.Text = "Formato Trabajo"
        '
        'rbtVerPresupuestoCompleto
        '
        Me.rbtVerPresupuestoCompleto.Location = New System.Drawing.Point(167, 18)
        Me.rbtVerPresupuestoCompleto.Name = "rbtVerPresupuestoCompleto"
        Me.rbtVerPresupuestoCompleto.Size = New System.Drawing.Size(98, 16)
        Me.rbtVerPresupuestoCompleto.TabIndex = 2
        Me.rbtVerPresupuestoCompleto.Text = "Completo"
        '
        'rbtVerGrid
        '
        Me.rbtVerGrid.Location = New System.Drawing.Point(91, 18)
        Me.rbtVerGrid.Name = "rbtVerGrid"
        Me.rbtVerGrid.Size = New System.Drawing.Size(70, 16)
        Me.rbtVerGrid.TabIndex = 1
        Me.rbtVerGrid.Text = "Grid"
        '
        'rbtVerFicha
        '
        Me.rbtVerFicha.Location = New System.Drawing.Point(8, 16)
        Me.rbtVerFicha.Name = "rbtVerFicha"
        Me.rbtVerFicha.Size = New System.Drawing.Size(74, 18)
        Me.rbtVerFicha.TabIndex = 0
        Me.rbtVerFicha.Text = "Ficha"
        '
        'TabPageCaracteristicas
        '
        Me.TabPageCaracteristicas.Controls.Add(Me.GridCaracteristicas)
        Me.TabPageCaracteristicas.Key = "Caracteristicas"
        Me.TabPageCaracteristicas.Location = New System.Drawing.Point(1, 21)
        Me.TabPageCaracteristicas.Name = "TabPageCaracteristicas"
        Me.TabPageCaracteristicas.Size = New System.Drawing.Size(782, 442)
        Me.TabPageCaracteristicas.TabStop = True
        Me.TabPageCaracteristicas.Text = "Características"
        Me.TabPageCaracteristicas.Visible = False
        '
        'GridCaracteristicas
        '
        Me.GridCaracteristicas.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("IDGrupo", "ObraGrupoCaracteristica", "IDGrupo", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescGrupo", "DescGrupo")}))})
        GridCaracteristicas_DesignTimeLayout.LayoutString = resources.GetString("GridCaracteristicas_DesignTimeLayout.LayoutString")
        Me.GridCaracteristicas.DesignTimeLayout = GridCaracteristicas_DesignTimeLayout
        Me.GridCaracteristicas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridCaracteristicas.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridCaracteristicas.EntityName = "ObraPresupCaracteristica"
        Me.GridCaracteristicas.Location = New System.Drawing.Point(0, 0)
        Me.GridCaracteristicas.Name = "GridCaracteristicas"
        Me.GridCaracteristicas.PrimaryDataFields = "IDPresup"
        Me.GridCaracteristicas.SecondaryDataFields = "IDPresup"
        Me.GridCaracteristicas.Size = New System.Drawing.Size(782, 442)
        Me.GridCaracteristicas.TabIndex = 30
        Me.GridCaracteristicas.Tag = "IdRec=5338:5293:5339:55124:5885:5190:5292:5293:;"
        Me.GridCaracteristicas.ViewName = "vFrmObraPresupCaracteristica"
        '
        'TabPageSeguimiento
        '
        Me.TabPageSeguimiento.Controls.Add(Me.UlblDescResponsable)
        Me.TabPageSeguimiento.Controls.Add(Me.AdvResponsable)
        Me.TabPageSeguimiento.Controls.Add(Me.LblResponsable)
        Me.TabPageSeguimiento.Controls.Add(Me.lblCentroGestion)
        Me.TabPageSeguimiento.Controls.Add(Me.cbxCentroGestion)
        Me.TabPageSeguimiento.Controls.Add(Me.lblTexto)
        Me.TabPageSeguimiento.Controls.Add(Me.CmbUrlContrato)
        Me.TabPageSeguimiento.Controls.Add(Me.txtTexto)
        Me.TabPageSeguimiento.Controls.Add(Me.lblNumeroPedido)
        Me.TabPageSeguimiento.Controls.Add(Me.txtNumeroPedido)
        Me.TabPageSeguimiento.Controls.Add(Me.lblURLContrato)
        Me.TabPageSeguimiento.Controls.Add(Me.txtURLContrato)
        Me.TabPageSeguimiento.Controls.Add(Me.lblFechaPeticion)
        Me.TabPageSeguimiento.Controls.Add(Me.cbxFechaPeticion)
        Me.TabPageSeguimiento.Controls.Add(Me.lblFechaEmision)
        Me.TabPageSeguimiento.Controls.Add(Me.cbxFechaEmision)
        Me.TabPageSeguimiento.Key = "Seguimiento"
        Me.TabPageSeguimiento.Location = New System.Drawing.Point(1, 21)
        Me.TabPageSeguimiento.Name = "TabPageSeguimiento"
        Me.TabPageSeguimiento.Size = New System.Drawing.Size(782, 442)
        Me.TabPageSeguimiento.TabStop = True
        Me.TabPageSeguimiento.Text = "Seguimiento"
        Me.TabPageSeguimiento.Visible = False
        '
        'UlblDescResponsable
        '
        Me.TryDataBinding(UlblDescResponsable, New System.Windows.Forms.Binding("Text", Me, "DescOperario", True))
        Me.UlblDescResponsable.Location = New System.Drawing.Point(216, 63)
        Me.UlblDescResponsable.Name = "UlblDescResponsable"
        Me.UlblDescResponsable.Size = New System.Drawing.Size(336, 23)
        Me.UlblDescResponsable.TabIndex = 245
        '
        'AdvResponsable
        '
        Me.AdvResponsable.ASSelectedFields = New Solmicro.Expertis.Engine.UI.ASSelectedFields(New Solmicro.Expertis.Engine.UI.ASSelectedField() {New Solmicro.Expertis.Engine.UI.ASSelectedField("DescOperario", UlblDescResponsable)})
        Me.TryDataBinding(AdvResponsable, New System.Windows.Forms.Binding("Value", Me, "IDResponsableComer", True))
        Me.AdvResponsable.DisabledBackColor = System.Drawing.Color.White
        Me.AdvResponsable.EntityName = "Operario"
        Me.AdvResponsable.Location = New System.Drawing.Point(104, 63)
        Me.AdvResponsable.Name = "AdvResponsable"
        Me.AdvResponsable.PrimaryDataFields = "IDResponsableComer"
        Me.AdvResponsable.SecondaryDataFields = "IDOperario"
        Me.AdvResponsable.Size = New System.Drawing.Size(106, 23)
        Me.AdvResponsable.TabIndex = 28
        '
        'LblResponsable
        '
        Me.LblResponsable.Location = New System.Drawing.Point(8, 68)
        Me.LblResponsable.Name = "LblResponsable"
        Me.LblResponsable.Size = New System.Drawing.Size(79, 13)
        Me.LblResponsable.TabIndex = 243
        Me.LblResponsable.Text = "Responsable"
        '
        'lblCentroGestion
        '
        Me.lblCentroGestion.Location = New System.Drawing.Point(555, 12)
        Me.lblCentroGestion.Name = "lblCentroGestion"
        Me.lblCentroGestion.Size = New System.Drawing.Size(67, 13)
        Me.lblCentroGestion.TabIndex = 242
        Me.lblCentroGestion.Tag = ""
        Me.lblCentroGestion.Text = "C. Gestión"
        '
        'cbxCentroGestion
        '
        Me.TryDataBinding(cbxCentroGestion, New System.Windows.Forms.Binding("Value", Me, "IDCentroGestion", True))
        cbxCentroGestion_DesignTimeLayout.LayoutString = resources.GetString("cbxCentroGestion_DesignTimeLayout.LayoutString")
        Me.cbxCentroGestion.DesignTimeLayout = cbxCentroGestion_DesignTimeLayout
        Me.cbxCentroGestion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxCentroGestion.DisplayMember = "IDCentroGestion"
        Me.cbxCentroGestion.EntityName = "CentroGestion"
        Me.cbxCentroGestion.Location = New System.Drawing.Point(627, 8)
        Me.cbxCentroGestion.Name = "cbxCentroGestion"
        Me.cbxCentroGestion.PrimaryDataFields = "IDCentroGestion"
        Me.cbxCentroGestion.SecondaryDataFields = "IDCentroGestion"
        Me.cbxCentroGestion.SelectedIndex = -1
        Me.cbxCentroGestion.SelectedItem = Nothing
        Me.cbxCentroGestion.Size = New System.Drawing.Size(150, 21)
        Me.cbxCentroGestion.TabIndex = 26
        '
        'lblTexto
        '
        Me.lblTexto.Location = New System.Drawing.Point(8, 161)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(91, 13)
        Me.lblTexto.TabIndex = 103
        Me.lblTexto.Tag = ""
        Me.lblTexto.Text = "Observaciones"
        '
        'CmbUrlContrato
        '
        Me.CmbUrlContrato.ImageIndex = 0
        Me.CmbUrlContrato.ImageList = Me.ImageList1
        Me.CmbUrlContrato.Location = New System.Drawing.Point(756, 98)
        Me.CmbUrlContrato.Name = "CmbUrlContrato"
        Me.CmbUrlContrato.Size = New System.Drawing.Size(21, 21)
        Me.CmbUrlContrato.TabIndex = 30
        '
        'txtTexto
        '
        Me.TryDataBinding(txtTexto, New System.Windows.Forms.Binding("Text", Me, "Texto", True))
        Me.txtTexto.DisabledBackColor = System.Drawing.Color.White
        Me.txtTexto.Location = New System.Drawing.Point(104, 159)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(673, 276)
        Me.txtTexto.TabIndex = 32
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.Location = New System.Drawing.Point(8, 129)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(94, 13)
        Me.lblNumeroPedido.TabIndex = 49
        Me.lblNumeroPedido.Tag = ""
        Me.lblNumeroPedido.Text = "Número Pedido"
        '
        'txtNumeroPedido
        '
        Me.TryDataBinding(txtNumeroPedido, New System.Windows.Forms.Binding("Text", Me, "NumeroPedido", True))
        Me.txtNumeroPedido.DisabledBackColor = System.Drawing.Color.White
        Me.txtNumeroPedido.Location = New System.Drawing.Point(104, 125)
        Me.txtNumeroPedido.Name = "txtNumeroPedido"
        Me.txtNumeroPedido.Size = New System.Drawing.Size(106, 21)
        Me.txtNumeroPedido.TabIndex = 31
        '
        'lblURLContrato
        '
        Me.lblURLContrato.Location = New System.Drawing.Point(8, 102)
        Me.lblURLContrato.Name = "lblURLContrato"
        Me.lblURLContrato.Size = New System.Drawing.Size(83, 13)
        Me.lblURLContrato.TabIndex = 51
        Me.lblURLContrato.Tag = ""
        Me.lblURLContrato.Text = "URL Contrato"
        '
        'txtURLContrato
        '
        Me.TryDataBinding(txtURLContrato, New System.Windows.Forms.Binding("Text", Me, "URLPresupuesto", True))
        Me.txtURLContrato.DisabledBackColor = System.Drawing.Color.White
        Me.txtURLContrato.Location = New System.Drawing.Point(104, 98)
        Me.txtURLContrato.Name = "txtURLContrato"
        Me.txtURLContrato.Size = New System.Drawing.Size(649, 21)
        Me.txtURLContrato.TabIndex = 29
        '
        'lblFechaPeticion
        '
        Me.lblFechaPeticion.Location = New System.Drawing.Point(8, 12)
        Me.lblFechaPeticion.Name = "lblFechaPeticion"
        Me.lblFechaPeticion.Size = New System.Drawing.Size(88, 13)
        Me.lblFechaPeticion.TabIndex = 52
        Me.lblFechaPeticion.Tag = ""
        Me.lblFechaPeticion.Text = "Fecha Petición"
        '
        'cbxFechaPeticion
        '
        Me.TryDataBinding(cbxFechaPeticion, New System.Windows.Forms.Binding("BindableValue", Me, "FechaPeticion", True))
        Me.cbxFechaPeticion.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaPeticion.Location = New System.Drawing.Point(104, 8)
        Me.cbxFechaPeticion.Name = "cbxFechaPeticion"
        Me.cbxFechaPeticion.Size = New System.Drawing.Size(106, 21)
        Me.cbxFechaPeticion.TabIndex = 25
        '
        'lblFechaEmision
        '
        Me.lblFechaEmision.Location = New System.Drawing.Point(8, 36)
        Me.lblFechaEmision.Name = "lblFechaEmision"
        Me.lblFechaEmision.Size = New System.Drawing.Size(88, 13)
        Me.lblFechaEmision.TabIndex = 53
        Me.lblFechaEmision.Tag = ""
        Me.lblFechaEmision.Text = "Fecha Emisión"
        '
        'cbxFechaEmision
        '
        Me.TryDataBinding(cbxFechaEmision, New System.Windows.Forms.Binding("BindableValue", Me, "FechaEmision", True))
        Me.cbxFechaEmision.DisabledBackColor = System.Drawing.Color.White
        Me.cbxFechaEmision.Location = New System.Drawing.Point(104, 32)
        Me.cbxFechaEmision.Name = "cbxFechaEmision"
        Me.cbxFechaEmision.Size = New System.Drawing.Size(106, 21)
        Me.cbxFechaEmision.TabIndex = 27
        '
        'TabPageAportaciones
        '
        Me.TabPageAportaciones.Controls.Add(Me.Panel2)
        Me.TabPageAportaciones.Controls.Add(Me.Panel1)
        Me.TabPageAportaciones.Location = New System.Drawing.Point(1, 21)
        Me.TabPageAportaciones.Name = "TabPageAportaciones"
        Me.TabPageAportaciones.Size = New System.Drawing.Size(782, 442)
        Me.TabPageAportaciones.TabStop = True
        Me.TabPageAportaciones.Text = "Aportaciones"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GridAportaciones)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 404)
        Me.Panel2.TabIndex = 1
        '
        'GridAportaciones
        '
        Me.GridAportaciones.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("codAportacion", "ObraPresupCabeceraAportacion", "codAportacion", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("codAportacion", "codAportacion"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("descPresupAportacion", "descPresupAportacion")}), "vPresupAportacion")})
        GridAportaciones_DesignTimeLayout.LayoutString = resources.GetString("GridAportaciones_DesignTimeLayout.LayoutString")
        Me.GridAportaciones.DesignTimeLayout = GridAportaciones_DesignTimeLayout
        Me.GridAportaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridAportaciones.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridAportaciones.EntityName = "ObraPresupAportacion"
        Me.GridAportaciones.Location = New System.Drawing.Point(0, 0)
        Me.GridAportaciones.Name = "GridAportaciones"
        Me.GridAportaciones.PrimaryDataFields = "IDPresup"
        Me.GridAportaciones.SecondaryDataFields = "IDPresup"
        Me.GridAportaciones.Size = New System.Drawing.Size(782, 404)
        Me.GridAportaciones.TabIndex = 0
        Me.GridAportaciones.ViewName = "vObraPresupAportacion"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCargarAport)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 38)
        Me.Panel1.TabIndex = 0
        '
        'btnCargarAport
        '
        Me.btnCargarAport.Location = New System.Drawing.Point(29, 7)
        Me.btnCargarAport.Name = "btnCargarAport"
        Me.btnCargarAport.Size = New System.Drawing.Size(287, 25)
        Me.btnCargarAport.TabIndex = 0
        Me.btnCargarAport.Text = "Cargar Aportaciones"
        '
        'GridTrabEstr
        '
        Me.GridTrabEstr.AdvSearchColumns = New Solmicro.Expertis.Engine.UI.AdvSearchColumns(New Solmicro.Expertis.Engine.UI.AdvSearchColumn() {New Solmicro.Expertis.Engine.UI.AdvSearchColumn("codEstucturaSubElemento", "ObraEstrSubElemento", "codEstucturaSubElemento", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("idObraEstructuraSubElemento", "idObraEstructuraSubElemento"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("codEstucturaSubElemento", "codEstucturaSubElemento"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("descEstructuraSubElemento", "descEstructuraSubElemento")}), "vObraEstructuraSubElemento"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("codObraElementoEstructura", "ObraEstrElemento", "codObraElementoEstructura", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("idObraElementoEstructura", "idObraElementoEstructura"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("codObraElementoEstructura", "codObraElementoEstructura"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("descObraElementoEstructura", "descObraElementoEstructura")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("codObraEstructura", "ObraEstructura", "codObraEstructura", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("idObraEstructura", "idObraEstructura"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("codObraEstructura", "codObraEstructura"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("descObraEstructura", "descObraEstructura")})), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("codObraEstructuraFase", Nothing, "codObraEstructuraFase"), New Solmicro.Expertis.Engine.UI.AdvSearchColumn("DescObraEstrTarea", "ObraEstrTarea", "DescObraEstrTarea", New Solmicro.Expertis.Engine.UI.ASSelectedColumns(New Solmicro.Expertis.Engine.UI.ASSelectedColumn() {New Solmicro.Expertis.Engine.UI.ASSelectedColumn("IDObraEstrTarea", "IDObraEstrTarea"), New Solmicro.Expertis.Engine.UI.ASSelectedColumn("DescObraEstrTarea", "DescObraEstrTarea")}))})
        GridTrabEstr_DesignTimeLayout.LayoutString = resources.GetString("GridTrabEstr_DesignTimeLayout.LayoutString")
        Me.GridTrabEstr.DesignTimeLayout = GridTrabEstr_DesignTimeLayout
        Me.GridTrabEstr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridTrabEstr.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridTrabEstr.EntityName = "ObraPresEstrTrabajo"
        Me.GridTrabEstr.Location = New System.Drawing.Point(0, 0)
        Me.GridTrabEstr.Name = "GridTrabEstr"
        Me.GridTrabEstr.PrimaryDataFields = "IDPresup"
        Me.GridTrabEstr.SecondaryDataFields = "IdPresup"
        Me.GridTrabEstr.Size = New System.Drawing.Size(782, 442)
        Me.GridTrabEstr.TabIndex = 0
        Me.GridTrabEstr.ViewName = "vObraPresEstrTrabajo"
        '
        'OpenDialog1
        '
        Me.OpenDialog1.DefaultExt = "*.doc"
        '
        'MnuNuevoTrabajo
        '
        Me.MnuNuevoTrabajo.Icon = CType(resources.GetObject("MnuNuevoTrabajo.Icon"), System.Drawing.Icon)
        Me.MnuNuevoTrabajo.Key = "MnuNuevoTrabajo"
        Me.MnuNuevoTrabajo.Name = "MnuNuevoTrabajo"
        Me.MnuNuevoTrabajo.Text = "Nuevo Trabajo"
        '
        'MnuNuevoTrabajoIncremento
        '
        Me.MnuNuevoTrabajoIncremento.Icon = CType(resources.GetObject("MnuNuevoTrabajoIncremento.Icon"), System.Drawing.Icon)
        Me.MnuNuevoTrabajoIncremento.Key = "MnuNuevoTrabajoIncremento"
        Me.MnuNuevoTrabajoIncremento.Name = "MnuNuevoTrabajoIncremento"
        Me.MnuNuevoTrabajoIncremento.Text = "Nuevo Incremento"
        '
        'MnuDeleteTrabajo
        '
        Me.MnuDeleteTrabajo.Icon = CType(resources.GetObject("MnuDeleteTrabajo.Icon"), System.Drawing.Icon)
        Me.MnuDeleteTrabajo.Key = "MnuDeleteTrabajo"
        Me.MnuDeleteTrabajo.Name = "MnuDeleteTrabajo"
        Me.MnuDeleteTrabajo.Text = "Borrar Trabajo"
        '
        'MnuDeleteIncremento
        '
        Me.MnuDeleteIncremento.Icon = CType(resources.GetObject("MnuDeleteIncremento.Icon"), System.Drawing.Icon)
        Me.MnuDeleteIncremento.Key = "MnuDeleteIncremento"
        Me.MnuDeleteIncremento.Name = "MnuDeleteIncremento"
        Me.MnuDeleteIncremento.Text = "Borrar Incremento"
        '
        'MnuADDIncremento
        '
        Me.MnuADDIncremento.Icon = CType(resources.GetObject("MnuADDIncremento.Icon"), System.Drawing.Icon)
        Me.MnuADDIncremento.Key = "MnuADDIncremento"
        Me.MnuADDIncremento.Name = "MnuADDIncremento"
        Me.MnuADDIncremento.Text = "Añadir Incremento"
        '
        'MnuNuevoConcepto
        '
        Me.MnuNuevoConcepto.Key = "MnuNuevoConcepto"
        Me.MnuNuevoConcepto.Name = "MnuNuevoConcepto"
        Me.MnuNuevoConcepto.Text = "Nuevo Concepto"
        '
        'MnuDesgloseTrabajo
        '
        Me.MnuDesgloseTrabajo.Icon = CType(resources.GetObject("MnuDesgloseTrabajo.Icon"), System.Drawing.Icon)
        Me.MnuDesgloseTrabajo.Key = "MnuDesgloseTrabajo"
        Me.MnuDesgloseTrabajo.Name = "MnuDesgloseTrabajo"
        Me.MnuDesgloseTrabajo.Text = "Ver desglose trabajo"
        '
        'MnuVerFichaTrabajo
        '
        Me.MnuVerFichaTrabajo.Icon = CType(resources.GetObject("MnuVerFichaTrabajo.Icon"), System.Drawing.Icon)
        Me.MnuVerFichaTrabajo.Key = "MnuVerFichaTrabajo"
        Me.MnuVerFichaTrabajo.Name = "MnuVerFichaTrabajo"
        Me.MnuVerFichaTrabajo.Text = "Ver ficha trabajo"
        '
        'MenuPresupuestos
        '
        Me.MenuPresupuestos.CommandManager = Me.UiCommandManager1
        Me.MenuPresupuestos.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.MnuNuevoTrabajo1, Me.MnuNuevoTrabajoIncremento1, Me.MnuGuion, Me.MnuDeleteTrabajo1, Me.MnuDeleteIncremento1, Me.MnuGuion2, Me.MnuADDIncremento1, Me.MnuGuion3, Me.MnuNuevoConcepto1, Me.MnuGuion4, Me.MnuDesgloseTrabajo1, Me.MnuVerFichaTrabajo1})
        Me.MenuPresupuestos.Key = "MenuPresupuestos"
        '
        'MnuNuevoTrabajo1
        '
        Me.MnuNuevoTrabajo1.Key = "MnuNuevoTrabajo"
        Me.MnuNuevoTrabajo1.Name = "MnuNuevoTrabajo1"
        '
        'MnuNuevoTrabajoIncremento1
        '
        Me.MnuNuevoTrabajoIncremento1.Key = "MnuNuevoTrabajoIncremento"
        Me.MnuNuevoTrabajoIncremento1.Name = "MnuNuevoTrabajoIncremento1"
        '
        'MnuGuion
        '
        Me.MnuGuion.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion.Key = "MnuGuion"
        Me.MnuGuion.Name = "MnuGuion"
        '
        'MnuDeleteTrabajo1
        '
        Me.MnuDeleteTrabajo1.Key = "MnuDeleteTrabajo"
        Me.MnuDeleteTrabajo1.Name = "MnuDeleteTrabajo1"
        '
        'MnuDeleteIncremento1
        '
        Me.MnuDeleteIncremento1.Key = "MnuDeleteIncremento"
        Me.MnuDeleteIncremento1.Name = "MnuDeleteIncremento1"
        '
        'MnuGuion2
        '
        Me.MnuGuion2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion2.Key = "MnuGuion2"
        Me.MnuGuion2.Name = "MnuGuion2"
        '
        'MnuADDIncremento1
        '
        Me.MnuADDIncremento1.Key = "MnuADDIncremento"
        Me.MnuADDIncremento1.Name = "MnuADDIncremento1"
        '
        'MnuGuion3
        '
        Me.MnuGuion3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion3.Key = "MnuGuion3"
        Me.MnuGuion3.Name = "MnuGuion3"
        '
        'MnuNuevoConcepto1
        '
        Me.MnuNuevoConcepto1.Key = "MnuNuevoConcepto"
        Me.MnuNuevoConcepto1.Name = "MnuNuevoConcepto1"
        '
        'MnuGuion4
        '
        Me.MnuGuion4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.MnuGuion4.Key = "MnuGuion4"
        Me.MnuGuion4.Name = "MnuGuion4"
        '
        'MnuDesgloseTrabajo1
        '
        Me.MnuDesgloseTrabajo1.Key = "MnuDesgloseTrabajo"
        Me.MnuDesgloseTrabajo1.Name = "MnuDesgloseTrabajo1"
        '
        'MnuVerFichaTrabajo1
        '
        Me.MnuVerFichaTrabajo1.Key = "MnuVerFichaTrabajo"
        Me.MnuVerFichaTrabajo1.Name = "MnuVerFichaTrabajo1"
        '
        'ImageListTrabajoCompleto
        '
        Me.ImageListTrabajoCompleto.ImageStream = CType(resources.GetObject("ImageListTrabajoCompleto.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListTrabajoCompleto.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListTrabajoCompleto.Images.SetKeyName(0, "xProyectos.ico")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(1, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(2, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(3, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(4, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(5, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(6, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(7, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(8, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(9, "")
        Me.ImageListTrabajoCompleto.Images.SetKeyName(10, "")
        '
        'MntoObraPresup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.CreateTransaction = True
        Me.EntityName = "ObraPresupCabecera"
        Me.FindTextField = "NumPresup"
        Me.LastUsedDescFields = "NumPresup"
        Me.Name = "MntoObraPresup"
        Me.NavigationFields = "NumPresup;RevPresup"
        Me.NoEditableControls = New Solmicro.Expertis.Engine.UI.NoEditableControls(New System.Windows.Forms.Control() {Me.txtNumPresup})
        Me.ViewName = "frmMntoObraPresup"
        CType(Me.ToolBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        CType(Me.cmbComercial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPresupuestos.ResumeLayout(False)
        Me.TabPageCabeceraPresup.ResumeLayout(False)
        Me.pnlDatosEconomicos.ResumeLayout(False)
        Me.fra.ResumeLayout(False)
        Me.fra.PerformLayout()
        CType(Me.UiGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraImportes.ResumeLayout(False)
        Me.FraImportes.PerformLayout()
        CType(Me.UiGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraCondEconomicas.ResumeLayout(False)
        Me.FraCondEconomicas.PerformLayout()
        Me.pnlDatosGenerales.ResumeLayout(False)
        Me.pnlDatosGenerales.PerformLayout()
        Me.FraFechas.ResumeLayout(False)
        Me.FraFechas.PerformLayout()
        Me.FraClienteEmpresa.ResumeLayout(False)
        Me.FraClienteEmpresa.PerformLayout()
        Me.TabPageTrabajo.ResumeLayout(False)
        CType(Me.TabTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTrabajos.ResumeLayout(False)
        Me.TabPageTrabajos.ResumeLayout(False)
        Me.pnlFicha.ResumeLayout(False)
        Me.pnlFichaTrabajoFill.ResumeLayout(False)
        Me.pnlFichaTrabajoFill.PerformLayout()
        Me.FraImportesTrabajoFicha.ResumeLayout(False)
        Me.FraImportesTrabajoFicha.PerformLayout()
        Me.pnlFichaTrabajoTop.ResumeLayout(False)
        Me.pnlFichaTrabajoTop.PerformLayout()
        CType(Me.cbxTipoLinea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxTipoCoste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraSeguimiento.ResumeLayout(False)
        Me.FraSeguimiento.PerformLayout()
        Me.FraFechasTrabajo.ResumeLayout(False)
        Me.FraFechasTrabajo.PerformLayout()
        CType(Me.cbxIDCentroGestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbxIDUDMedida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGridTrabajo.ResumeLayout(False)
        CType(Me.GridTrabajos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlVerTrabajo.ResumeLayout(False)
        Me.pnlVerTrabajo.PerformLayout()
        Me.pnlConfigVerGridTrabajo.ResumeLayout(False)
        Me.pnlConfigVerGridTrabajo.PerformLayout()
        Me.FraImportesTrabajoGrid.ResumeLayout(False)
        Me.FraImportesTrabajoGrid.PerformLayout()
        Me.pnlTrabajosCompleto.ResumeLayout(False)
        Me.pnlVerTrabajosCompleto.ResumeLayout(False)
        Me.pnlVerTrabajosCompleto.PerformLayout()
        Me.TabPageMateriales.ResumeLayout(False)
        CType(Me.GridMateriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraTotalesMat.ResumeLayout(False)
        Me.FraTotalesMat.PerformLayout()
        Me.pnlVerMaterial.ResumeLayout(False)
        Me.pnlVerMaterial.PerformLayout()
        Me.pnlConfigVerMaterial.ResumeLayout(False)
        Me.pnlConfigVerMaterial.PerformLayout()
        Me.TabPageMOD.ResumeLayout(False)
        CType(Me.GridMOD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraTotalesMOD.ResumeLayout(False)
        Me.FraTotalesMOD.PerformLayout()
        Me.pnlVerMOD.ResumeLayout(False)
        Me.pnlVerMOD.PerformLayout()
        Me.pnlConfigVerMod.ResumeLayout(False)
        Me.pnlConfigVerMod.PerformLayout()
        Me.TabPageCentros.ResumeLayout(False)
        CType(Me.GridCentros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraTotalesCentros.ResumeLayout(False)
        Me.FraTotalesCentros.PerformLayout()
        Me.pnlVerCentros.ResumeLayout(False)
        Me.pnlVerCentros.PerformLayout()
        Me.pnlConfigVerCentros.ResumeLayout(False)
        Me.pnlConfigVerCentros.PerformLayout()
        Me.TabPageGastos.ResumeLayout(False)
        CType(Me.GridGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraTotalesGastos.ResumeLayout(False)
        Me.FraTotalesGastos.PerformLayout()
        Me.pnlVerGastos.ResumeLayout(False)
        Me.pnlVerGastos.PerformLayout()
        Me.pnlConfigVerGastos.ResumeLayout(False)
        Me.pnlConfigVerGastos.PerformLayout()
        Me.TabPageVarios.ResumeLayout(False)
        CType(Me.GridVarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraTotalesVarios.ResumeLayout(False)
        Me.FraTotalesVarios.PerformLayout()
        Me.pnlVerVarios.ResumeLayout(False)
        Me.pnlVerVarios.PerformLayout()
        Me.pnlConfigVerVarios.ResumeLayout(False)
        Me.pnlConfigVerVarios.PerformLayout()
        Me.TabPageMediciones.ResumeLayout(False)
        CType(Me.GridMediciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraImportesMedicionesPresup.ResumeLayout(False)
        Me.FraImportesMedicionesPresup.PerformLayout()
        Me.pnlVerMediciones.ResumeLayout(False)
        Me.pnlVerMediciones.PerformLayout()
        Me.pnlConfigVerMediciones.ResumeLayout(False)
        Me.pnlConfigVerMediciones.PerformLayout()
        Me.pnlTrabajos.ResumeLayout(False)
        Me.FraArbol.ResumeLayout(False)
        Me.FraCriterios.ResumeLayout(False)
        Me.TabPageCaracteristicas.ResumeLayout(False)
        CType(Me.GridCaracteristicas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageSeguimiento.ResumeLayout(False)
        Me.TabPageSeguimiento.PerformLayout()
        CType(Me.cbxCentroGestion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageAportaciones.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GridAportaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.GridTrabEstr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuPresupuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Delegate Sub LecturaFichero(ByVal ArrayTexto() As String, ByVal NumPresup As Integer, ByVal blnImportarMateriales As Boolean, ByVal blnCrearMateriales As Boolean, _
                                        ByVal blnImportarMOD As Boolean, ByVal blnImportarCentros As Boolean, ByVal blnImportarMediciones As Boolean)

    Private Const cnPRESUPENOBRA As String = "Convertir Presupuesto en Proyecto"
    Private Const cnADDPRESUPENOBRA As String = "Añadir Presupuesto en Proyecto"
    Private Const cnBC3 As String = "Importar de fichero BC3"
    Private Const cnABRIRPROYECTO As String = "Abrir Proyecto"
    Private Const cnABRIRMATERIAL As String = "Abrir Material"
    Private Const cnIMPORTARESTRUCTURA As String = "Importar Estructura"
    Private Const cnNUEVOTRABAJO As String = "Nuevo Trabajo"

    Private dtTrabajos As DataTable
    Private drTrabajos As DataRow
    Private mblnGestionConstructoras, blnNoAcumular, blnChecked, blnPintarTrabajos, mblnAplicarMultinivel As Boolean
    Private ndTrabajos, ndMateriales, ndMOD, ndCentros, ndGastos, ndVarios, ndMediciones As ProviderNeededData
    Private mstrIDHora, mstrDescHora, mstrIDCGestion, mstrIDUDMedida As String
    Private blnRefreshArbol, blnRecordStateChanged, mSeleccionarNodoTrabajoDesdeGrid As Boolean
    Private intTrabajoActual As Integer

    '//Variables para los artículos configurables
    Private mIDArticuloConfig As String
    Private mblnAbrirEvaluador As Boolean
    Private mOriginalValueArticulo As String : Private mOriginalValueQPresup As Integer
    Private mOriginalCodTrabajo As String : Private mOriginalIDTrabajoPresup As String
    Private mintRow As Integer

    Private mDenyReadTrabajos As Boolean = False
    Private mDenyInsertTrabajos As Boolean = False
    Private mDenyUpdateTrabajos As Boolean = False
    Private mDenyDeleteTrabajos As Boolean = False

    Private WithEvents sctTipoIncremento As AdvancedSearch
    Private WithEvents AdvDireccionEnvio As AdvancedSearch

#Region " Binding "

    Private Sub GetDatosTrabajo(ByVal row As DataRow)
        ndTrabajos.Row = row
    End Sub

    Private MakeBinding As Boolean
    Private Sub BindingDetalleTrabajo()
        If Not MakeBinding Then
            Me.AddBinding(Me.AdvTipoTrabajo, "Text", "IDTipoTrabajo")
            Me.AddBinding(Me.AdvSubTipoTrabajo, "Text", "IDSubTipoTrabajo")
            Me.AddBinding(Me.AdvSubSubTipoTrabajo, "Text", "SubSubTipoTrabajo")
            Me.AddBinding(Me.txtCodTrabajo, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajo, "Text", "DescTrabajo")
            Me.AddBinding(Me.cbxIDUDMedida, "Text", "IDUdMedida")
            Me.AddBinding(Me.txtQPresup, "Value", "QPresup")
            Me.AddBinding(Me.ntxQUnidad, "Value", "QUnidad")
            Me.AddBinding(Me.txtImpUnitario, "Value", "ImpPresupTrabajoA")
            Me.AddBinding(Me.txtMargenTrabajoFicha, "Value", "MargenTrabajo")
            Me.AddBinding(Me.txtImpUnitarioVta, "Value", "ImpPresupTrabajoVentaA")
            Me.AddBinding(Me.cbxTipoCoste, "Value", "TipoCosteDI")
            Me.AddBinding(Me.cbxTipoLinea, "Value", "TipoLinea")
            Me.AddBinding(Me.chkNoAcumular, "BindableValue", "NoAcumular")
            Me.AddBinding(Me.AdvIDArticulo, "Text", "IDArticulo")
            Me.AddBinding(Me.txtSecuencia, "Text", "Secuencia")
            Me.AddBinding(Me.txtDuracionPresup, "Value", "DuracionPresup")
            Me.AddBinding(Me.txtSolapeAnt, "Text", "Solape")
            Me.AddBinding(Me.txtNivelTrabajo, "Text", "Nivel")
            Me.AddBinding(Me.cbxFechaInicioTrabajo, "BindableValue", "FechaInicio")
            Me.AddBinding(Me.cbxFechaFinTrabajo, "BindableValue", "FechaFin")
            Me.AddBinding(Me.txtNumPedido, "Text", "NumeroPedido")
            Me.AddBinding(Me.cbxIDCentroGestion, "Value", "IDCentroGestion")
            Me.AddBinding(Me.txtTextoTrabajo, "Text", "Texto")
            Me.AddBinding(Me.txtIncremento, "Value", "Incremento")

            '''''''''''''
            Me.AddBinding(Me.txtTrabajoGrid, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoGrid, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoCompleto, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoCompleto, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoMat, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoMat, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoMod, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoMod, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoCentros, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoCentros, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoGastos, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoGastos, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoVarios, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoVarios, "Text", "DescTrabajo")
            Me.AddBinding(Me.txtTrabajoMedicion, "Text", "CodTrabajo")
            Me.AddBinding(Me.txtDescTrabajoMediciones, "Text", "DescTrabajo")
            '''''''''''''
            Me.AddBinding(Me.txtPresupTrabajo, "Value", "ImpPresupQTrabajoA")
            Me.AddBinding(Me.txtPresupVentaTrabajo, "Value", "ImpPresupQTrabajoVentaA")

            Me.AddBinding(Me.txtQPresupTrabajoMat, "Value", "QPresup")
            Me.AddBinding(Me.txtQPresupTrabajoMod, "Value", "QPresup")
            Me.AddBinding(Me.txtQPresupTrabajoCentros, "Value", "QPresup")
            Me.AddBinding(Me.txtQPresupTrabajoGastos, "Value", "QPresup")
            Me.AddBinding(Me.txtQPresupTrabajoVarios, "Value", "QPresup")
            Me.AddBinding(Me.txtQPresupTrabajoMediciones, "Value", "QPresup")
            MakeBinding = True
        End If
    End Sub

    Private Sub AddBinding(ByVal control As Control, ByVal propertyName As String, ByVal dataMember As String)
        control.Enabled = True
        control.DataBindings.Add(propertyName, ndTrabajos, dataMember)
    End Sub

#End Region

#Region " Load "

    Private Sub MntoObraPresup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not Me.DesignMode Then
            LoadERPData()
            LoadNedeedData()
            LoadToolBarActions()
            LoadGridActions()
            LoadEnums()
            LoadMonedasInternas()
            Configure()
            LoadPermisos()
        End If
    End Sub

    Private Sub LoadERPData()
        Dim cgu As New UsuarioCentroGestion.UsuarioCentroGestionInfo
        cgu = ExpertisApp.ExecuteTask(Of UsuarioCentroGestion.UsuarioCentroGestionInfo, UsuarioCentroGestion.UsuarioCentroGestionInfo)(AddressOf UsuarioCentroGestion.ObtenerUsuarioCentroGestion, cgu)
        mstrIDCGestion = cgu.IDCentroGestion

        Dim p As New Parametro
        mstrIDHora = p.HoraPred
        mstrIDUDMedida = p.UdMedidaPred
        mblnGestionConstructoras = p.GestionConstructoras
        blnNoAcumular = p.NoAcumularEnTrabajo
        mblnAplicarMultinivel = p.AplicarMultinivelEnObras
        If Length(mstrIDHora) > 0 Then
            Dim dtHora As DataTable = New Hora().SelOnPrimaryKey(mstrIDHora)
            If Not dtHora Is Nothing AndAlso dtHora.Rows.Count > 0 Then
                mstrDescHora = dtHora.Rows(0)("DescHora")
            End If
        End If
    End Sub

#Region " NedeedData "

    Private Sub LoadNedeedData()
        LoadNedeedDataTrabajos()
        LoadNedeedDataMateriales()
        LoadNedeedDataMOD()
        LoadNedeedDataCentros()
        LoadNedeedDataGastos()
        LoadNedeedDataVarios()
        LoadNedeedDataMediciones()
    End Sub

    Private Sub LoadNedeedDataTrabajos()
        ndTrabajos = New ProviderNeededData
        ndTrabajos.Name = "Trabajos"
        ndTrabajos.EntityName = "ObraTrabajoPresup"
        GridTrabajos.EntityName = ndTrabajos.EntityName
        Dim s(0) As String
        s(0) = "IDPresup"
        ndTrabajos.PrimaryDataFields = s
        ndTrabajos.SecondaryDataFields = s
        ndTrabajos.RelationMode = RelationMode.ChildMode
        If mblnAplicarMultinivel Then
            ndTrabajos.ViewName = "VFrmObraPresupTrabajosMultinivel"
        Else
            ndTrabajos.ViewName = "vFrmObraPresupTrabajos"
        End If
        GridTrabajos.ViewName = ndTrabajos.ViewName

        ndTrabajos.UpdateOrder = -1
        Me.AddDataItem(ndTrabajos)
    End Sub

    Private Sub LoadNedeedDataMateriales()
        ndMateriales = New ProviderNeededData
        ndMateriales.Name = "Materiales"
        ndMateriales.EntityName = "ObraPresupMaterial"
        GridMateriales.EntityName = ndMateriales.EntityName
        Dim s(0) As String
        s(0) = "IDPresup"
        ndMateriales.PrimaryDataFields = s
        ndMateriales.SecondaryDataFields = s
        ndMateriales.RelationMode = RelationMode.ChildMode
        ndMateriales.ViewName = "vFrmObraPresupMateriales"
        GridMateriales.ViewName = ndMateriales.ViewName

        Me.AddDataItem(ndMateriales)
    End Sub

    Private Sub LoadNedeedDataMOD()
        ndMOD = New ProviderNeededData
        ndMOD.Name = "MOD"
        ndMOD.EntityName = "ObraPresupMOD"
        GridMOD.EntityName = ndMOD.EntityName
        Dim s(0) As String
        s(0) = "IDPresup"
        ndMOD.PrimaryDataFields = s
        ndMOD.SecondaryDataFields = s
        ndMOD.RelationMode = RelationMode.ChildMode
        ndMOD.ViewName = "vFrmObraPresupMOD"
        GridMOD.ViewName = ndMOD.ViewName

        Me.AddDataItem(ndMOD)
    End Sub

    Private Sub LoadNedeedDataCentros()
        ndCentros = New ProviderNeededData
        ndCentros.Name = "Centros"
        ndCentros.EntityName = "ObraPresupCentro"
        GridCentros.EntityName = ndCentros.EntityName
        Dim s(0) As String
        s(0) = "IDPresup"
        ndCentros.PrimaryDataFields = s
        ndCentros.SecondaryDataFields = s
        ndCentros.RelationMode = RelationMode.ChildMode
        ndCentros.ViewName = "vFrmObraPresupCentro"
        GridCentros.ViewName = ndCentros.ViewName

        Me.AddDataItem(ndCentros)
    End Sub

    Private Sub LoadNedeedDataGastos()
        ndGastos = New ProviderNeededData
        ndGastos.Name = "Gastos"
        ndGastos.EntityName = "ObraPresupGasto"
        GridGastos.EntityName = ndGastos.EntityName
        Dim s(0) As String
        s(0) = "IDPresup"
        ndGastos.PrimaryDataFields = s
        ndGastos.SecondaryDataFields = s
        ndGastos.RelationMode = RelationMode.ChildMode
        ndGastos.ViewName = "vFrmObraPresupGasto"
        GridGastos.ViewName = ndGastos.ViewName

        Me.AddDataItem(ndGastos)
    End Sub

    Private Sub LoadNedeedDataVarios()
        ndVarios = New ProviderNeededData
        ndVarios.Name = "Varios"
        ndVarios.EntityName = "ObraPresupVarios"
        GridVarios.EntityName = ndVarios.EntityName
        Dim s(0) As String
        s(0) = "IDPresup"
        ndVarios.PrimaryDataFields = s
        ndVarios.SecondaryDataFields = s
        ndVarios.RelationMode = RelationMode.ChildMode
        ndVarios.ViewName = "vFrmObraPresupVarios"
        GridVarios.ViewName = ndVarios.ViewName

        Me.AddDataItem(ndVarios)
    End Sub

    Private Sub LoadNedeedDataMediciones()
        ndMediciones = New ProviderNeededData
        ndMediciones.Name = "Mediciones"
        ndMediciones.EntityName = "ObraPresupMedicion"
        GridMediciones.EntityName = ndMediciones.EntityName
        Dim s(0) As String
        s(0) = "IDPresup"
        ndMediciones.PrimaryDataFields = s
        ndMediciones.SecondaryDataFields = s
        ndMediciones.RelationMode = RelationMode.ChildMode
        ndMediciones.ViewName = "vFrmObraPresupMedicion"
        GridMediciones.ViewName = ndMediciones.ViewName

        Me.AddDataItem(ndMediciones)
    End Sub

#End Region

    Private Sub LoadToolBarActions()
        Me.FormActions.Add("Nueva Revisión Presupuesto", AddressOf AccionNuevaRevision, ExpertisApp.GetIcon("xPresupuestos.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Estructura Presupuesto", AddressOf AccionEstructuraPresupuesto, ExpertisApp.GetIcon("xEstructuras1.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Enviar a Microsoft Project", AddressOf CargarMsProject)
        Me.AddSeparator()
        Me.FormActions.Add("Copiar Presupuesto", AddressOf AccionCopiarPresupuesto, ExpertisApp.GetIcon("address_bookAdd.ico"))
        Me.FormActions.Add(cnPRESUPENOBRA, AddressOf AccionGenerarObra, ExpertisApp.GetIcon("cube_molecule_preferences.ico"))
        Me.FormActions.Add(cnADDPRESUPENOBRA, AddressOf AccionAddPresupuestoEnObra, ExpertisApp.GetIcon("cube_molecule_add.ico"))
        Me.FormActions.Add("Recalcular Presupuesto", AddressOf AccionRecalcularPresupuesto, ExpertisApp.GetIcon("calculator.ico"))
        Me.AddSeparator()
        Me.FormActions.Add("Direcciones de Envío", AddressOf AccionAbrirDireccionesEnvio, ExpertisApp.GetIcon("find_again.ico"))
        Me.AddSeparator()
        Me.FormActions.Add(cnBC3, AddressOf AccionImportarBC3, ExpertisApp.GetIcon("text_ok.ico"))
        Me.AddSeparator()
        Me.FormActions.Add(cnABRIRPROYECTO, AddressOf AccionAbrirObra, ExpertisApp.GetIcon("xProyectos.ico"))
    End Sub

#Region " LoadGridActions "

    Private Sub LoadGridActions()
        LoadGridTrabajos()
        LoadGridMateriales()
    End Sub

    Private Sub LoadGridTrabajos()
        GridTrabajos.Actions.Add(cnNUEVOTRABAJO, AddressOf AccionNuevoTrabajo, ExpertisApp.GetIcon("xPrepExpediciones.ico"))
        GridTrabajos.AddSeparator()
        GridTrabajos.Actions.Add("Ver Desglose Trabajo", AddressOf AccionDesgloseTrabajo, ExpertisApp.GetIcon("xTesoreria.ico"))
        GridTrabajos.Actions.Add("Ver Ficha Trabajo", AddressOf AccionVerFicha, ExpertisApp.GetIcon("window.ico"))
    End Sub

    Private Sub LoadGridMateriales()
        GridMateriales.Actions.Add(cnABRIRMATERIAL, AddressOf AccionAbrirMaterial, ExpertisApp.GetIcon("xArticulos.ico"))
        GridMateriales.Actions.Add(cnIMPORTARESTRUCTURA, AddressOf AccionImportarEstructura, ExpertisApp.GetIcon("xEstructuras1.ico"))
    End Sub

#End Region

    Private Sub LoadEnums()
        EnumData.PopulateValueList("enumtcdiTipoCoste", GridTrabajos.Columns("TipoCosteDI"))
        EnumData.PopulateValueList("enumTipoLineaTrabajo", GridTrabajos.Columns("TipoLinea"))
        EnumData.PopulateValueList("enumSiNo", GridMateriales.Columns("TipoIncremento"))
        EnumData.PopulateValueList("enumSiNo", GridMOD.Columns("TipoIncremento"))
        EnumData.PopulateValueList("enumSiNo", GridCentros.Columns("TipoIncremento"))
        cbxTipoCoste.DataSource = New EnumData("enumtcdiTipoCoste")
        cbxTipoLinea.DataSource = New EnumData("enumTipoLineaTrabajo")
    End Sub

    Private Sub LoadMonedasInternas()
        Dim MonedaA As MonedaInfo = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaA, Today.Date)
        Dim MonedaB As MonedaInfo = ExpertisApp.ExecuteTask(Of Date, MonedaInfo)(AddressOf Moneda.MonedaB, Today.Date)

        mintRedondeoPrecA = MonedaA.NDecimalesPrecio
        mintRedondeoA = MonedaA.NDecimalesImporte
    End Sub

    Private Sub Configure()
        rbtPresupTrabajos.Checked = True
        rbtPresupMat.Checked = True
        rbtPresupMod.Checked = True
        rbtPresupCentros.Checked = True
        rbtPresupGastos.Checked = True
        rbtPresupVarios.Checked = True
        rbtPresupMedicion.Checked = True

        rbtVerGrid.Checked = True
        rbtMinimizarTree.Checked = True
        chkVerPorcentajes.Checked = True

        ControlesConstructoras()
    End Sub

    Private Sub ControlesConstructoras()
        TabPageMediciones.TabVisible = mblnGestionConstructoras
        GridMateriales.Columns("Secuencia").Visible = mblnGestionConstructoras
        GridMateriales.Columns("TipoIncremento").Visible = mblnGestionConstructoras
        GridMOD.Columns("Secuencia").Visible = mblnGestionConstructoras
        GridMOD.Columns("TipoIncremento").Visible = mblnGestionConstructoras
        GridCentros.Columns("Secuencia").Visible = mblnGestionConstructoras
        GridCentros.Columns("TipoIncremento").Visible = mblnGestionConstructoras
    End Sub

    Private Sub CamposNoEditables()
        txtNObra.Enabled = False
        txtDireccion.Enabled = False : txtCodPostal.Enabled = False : txtPoblacion.Enabled = False : txtProvincia.Enabled = False
        txtImpPresupQMatA.Enabled = False : txtMargenMat.Enabled = False : txtImpPresupQMatVentaA.Enabled = False
        txtImpPresupQModA.Enabled = False : txtMargenMod.Enabled = False : txtImpPresupQModVentaA.Enabled = False
        txtImpPresupQCentrosA.Enabled = False : txtMargenCentro.Enabled = False : txtImpPresupQCentrosVentaA.Enabled = False
        txtImpPresupQGastosA.Enabled = False : txtMargenGastos.Enabled = False : txtImpPresupQGastosVentaA.Enabled = False
        txtImpPresupQVariosA.Enabled = False : txtMargenVarios.Enabled = False : txtImpPresupQVariosVentaA.Enabled = False
        txtImpPresupQTrabajoA.Enabled = False : txtMargenTrabajo.Enabled = False : txtImpPresupQTrabajoVentaA.Enabled = False
        txtPresupDirecto.Enabled = False : txtPresupVentaDirecto.Enabled = False
        txtPresupIndirecto.Enabled = False : txtPresupVentaIndirecto.Enabled = False
        txtImpPresupVentaABis.Enabled = False
        txtTotalGastosGenerales.Enabled = False : txtTotalBeneficioIndustrial.Enabled = False : txtTotalCoefBaja.Enabled = False
        txtTotalIva.Enabled = False
        txtTotal.Enabled = False

        txtPresupTrabajoGrid.Enabled = False : txtPresupVentaTrabajoGrid.Enabled = False
        txtImpPresupA.Enabled = False : txtMargenTrabajo.Enabled = False : txtImpPresupVentaA.Enabled = False
        txtPresupTrabajo.Enabled = False : txtPresupVentaTrabajo.Enabled = False
        txtTotalMaterial.Enabled = False : txtTotalMaterialVenta.Enabled = False
        txtTotalMOD.Enabled = False : txtTotalMODVenta.Enabled = False
        txtTotalCentros.Enabled = False : txtTotalCentrosVenta.Enabled = False
        txtTotalGastos.Enabled = False : txtTotalGastosVenta.Enabled = False
        txtTotalVarios.Enabled = False : txtTotalVariosVenta.Enabled = False
        txtTotalMedicion.Enabled = False
        AdvIDTipoObra.Enabled = ndTrabajos.Data Is Nothing OrElse ndTrabajos.Data.Rows.Count = 0

        txtTrabajoGrid.Enabled = False : txtDescTrabajoGrid.Enabled = False
        txtTrabajoCompleto.Enabled = False : txtDescTrabajoCompleto.Enabled = False
        txtTrabajoMat.Enabled = False : txtDescTrabajoMat.Enabled = False : txtQPresupTrabajoMat.Enabled = False
        txtTrabajoMod.Enabled = False : txtDescTrabajoMod.Enabled = False : txtTrabajoCentros.Enabled = False
        txtDescTrabajoCentros.Enabled = False : txtQPresupTrabajoCentros.Enabled = False : txtTrabajoGastos.Enabled = False
        txtDescTrabajoGastos.Enabled = False : txtQPresupTrabajoGastos.Enabled = False : txtTrabajoVarios.Enabled = False
        txtDescTrabajoVarios.Enabled = False : txtQPresupTrabajoVarios.Enabled = False : txtTrabajoMedicion.Enabled = False
        txtDescTrabajoMediciones.Enabled = False : txtQPresupTrabajoMediciones.Enabled = False
    End Sub

    Private Sub RefreshPresup(Optional ByVal IDPresup As Integer = -1)
        If IDPresup = -1 Then IDPresup = Me.CurrentRow("IDPresup")
        Me.GotoRecord(DataProviderActions.GoFirst, New NumberFilterItem("IDPresup", IDPresup))
    End Sub

    Private Sub LoadPermisos()
        Dim ES As EntitySecurity = ExpertisApp.SessionDescriptor.Security(ndTrabajos.EntityName)
        If Not ES Is Nothing Then
            Select Case ES.Restriction
                Case EntityRestriction.DenyRead
                    mDenyReadTrabajos = True
                Case EntityRestriction.DenyInsert
                    mDenyInsertTrabajos = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyInsert
                    mDenyReadTrabajos = True : mDenyInsertTrabajos = True
                Case EntityRestriction.DenyUpdate
                    mDenyUpdateTrabajos = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyUpdate
                    mDenyReadTrabajos = True : mDenyUpdateTrabajos = True
                Case EntityRestriction.DenyInsert + EntityRestriction.DenyUpdate
                    mDenyInsertTrabajos = True : mDenyUpdateTrabajos = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyInsert + EntityRestriction.DenyUpdate
                    mDenyReadTrabajos = True : mDenyInsertTrabajos = True : mDenyUpdateTrabajos = True
                Case EntityRestriction.DenyDelete
                    mDenyDeleteTrabajos = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyDelete
                    mDenyReadTrabajos = True : mDenyDeleteTrabajos = True
                Case EntityRestriction.DenyInsert + EntityRestriction.DenyDelete
                    mDenyInsertTrabajos = True : mDenyDeleteTrabajos = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyInsert + EntityRestriction.DenyDelete
                    mDenyReadTrabajos = True : mDenyInsertTrabajos = True : mDenyDeleteTrabajos = True
                Case EntityRestriction.DenyUpdate + EntityRestriction.DenyDelete
                    mDenyUpdateTrabajos = True : mDenyDeleteTrabajos = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyUpdate + EntityRestriction.DenyDelete
                    mDenyReadTrabajos = True : mDenyUpdateTrabajos = True : mDenyDeleteTrabajos = True
                Case EntityRestriction.DenyInsert + EntityRestriction.DenyUpdate + EntityRestriction.DenyDelete
                    mDenyInsertTrabajos = True : mDenyUpdateTrabajos = True : mDenyDeleteTrabajos = True
                Case EntityRestriction.DenyRead + EntityRestriction.DenyInsert + EntityRestriction.DenyUpdate + EntityRestriction.DenyDelete
                    mDenyReadTrabajos = True : mDenyInsertTrabajos = True : mDenyUpdateTrabajos = True : mDenyDeleteTrabajos = True
            End Select

            If mDenyDeleteTrabajos Then
                GridTrabajos.AllowDelete = InheritableBoolean.False
            End If
            If mDenyInsertTrabajos Then
                GridTrabajos.AllowAddNew = InheritableBoolean.False
            End If
            If mDenyReadTrabajos Then
                GridTrabajos.Visible = False
            End If
            If mDenyUpdateTrabajos Then
                GridTrabajos.AllowEdit = InheritableBoolean.False
            End If
        End If
    End Sub

#End Region

#Region " Acciones ToolBar "

    Private Sub AccionNuevaRevision()
        If ExpertisApp.GenerateMessage("Se va a proceder a la generación una nueva revisión de este Presupuesto. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Dim dt As DataTable = ExpertisApp.ExecuteTask(Of Integer, DataTable)(AddressOf ObraPresupCabecera.NuevaRevision, CInt(Me.CurrentRow("IDPresup")))
            Me.Cursor = Cursors.Default
            If ExpertisApp.GenerateMessage("Se ha generado la revisión | del Presupuesto '|'. ¿Desea abrirlo.?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, dt.Rows(0)("RevPresup"), dt.Rows(0)("NumPresup")) = DialogResult.Yes Then
                blnRefreshArbol = True
                RefreshPresup(dt.Rows(0)("IDPresup"))
            End If
        End If
    End Sub

    Private Sub AccionEstructuraPresupuesto()
        If Length(Me.CurrentRow("IDPresup")) > 0 Then
            Dim frm As New FrmEstructuraPresup
            frm.AbrirEstructuraPresupuesto(Me.CurrentRow("IDPresup"), Me.CurrentRow("NumPresup"), _
                                           Me.CurrentRow("RevPresup"), Me.CurrentRow("DescPresup") & String.Empty)
        End If
    End Sub

    Private Sub AccionCopiarPresupuesto()
        Dim frm As New frmCopiaObraPresup
        frm.VerContador = True
        frm.VerMediciones = mblnGestionConstructoras

        If frm.ShowDialog = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor

            Dim infoCopia As New dataCopia(Me.CurrentRow("IDPresup"))
            infoCopia.ConfiguracionCopia = frm.ConfiguracionCopia
            If Length(infoCopia.ConfiguracionCopia.IDContador) = 0 Then
                infoCopia.ConfiguracionCopia.IDContador = Me.CurrentRow("IDContador") & String.Empty
            End If
            Dim r As ResultadoCopia = ExpertisApp.ExecuteTask(Of dataCopia, ResultadoCopia)(AddressOf ObraPresupCabecera.CopiarPresupuesto, infoCopia)

            Me.Cursor = Cursors.Default
            If r.IDPresup <> -1 Then
                If ExpertisApp.GenerateMessage("Se ha generado el Presupuesto '|'. ¿Desea abrirlo.?", MessageBoxButtons.YesNo, MessageBoxIcon.Information, r.NumPresup) = DialogResult.Yes Then
                    RefreshPresup(r.IDPresup)
                End If
            End If
        End If
    End Sub

#Region " Generar Obra "

    Private Sub AccionGenerarObra()
        If Length(Me.CurrentRow("IDCliente")) > 0 Or Length(Me.CurrentRow("IDEmpresa")) > 0 Then
            If ExpertisApp.GenerateMessage("Se va a proceder a la generación de un nuevo Proyecto a partir de este Presupuesto. ¿Desea continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                If Length(AdvIDCliente.Value) = 0 Then
                    AccionConvertirEmpresaACliente()
                End If
                If Length(AdvIDCliente.Value) > 0 Then
                    Dim r As ResultadoRevisionPresupuesto = RevisionDatosPresupuesto()
                    If Not r.Cancel Then
                        Me.Cursor = Cursors.Default
                        Dim frm As New frmGeneraObra
                        If frm.ShowDialog = DialogResult.OK Then
                            Me.Cursor = Cursors.WaitCursor

                            Dim info As New ObraCabecera.DatosGenerarObraDesdePresupuesto(Me.CurrentRow("IDPresup"), frm.AdvContador.Value & String.Empty, frm.cbxIDClase.Value, frm.txtNObra.Text & String.Empty)
                            info.StDatos = ExpertisApp.ExecuteTask(Of ObraPresupCabecera.datosConceptosNoExistentes, ObraPresupCabecera.datosConceptosNoExistentes)(AddressOf ObraPresupCabecera.TratarConceptosNoExistentes, r.StConver)

                            Dim o As ObraCabecera.ResultObraCabecera = ExpertisApp.ExecuteTask(Of ObraCabecera.DatosGenerarObraDesdePresupuesto, ObraCabecera.ResultObraCabecera)(AddressOf ObraCabecera.GenerarObraDesdePresupuesto, info)

                            Me.Cursor = Cursors.Default
                            If ExpertisApp.GenerateMessage("Se ha generado el Proyecto nº |. ¿Desea abrir el mantenimiento?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information, o.NObra) = DialogResult.Yes Then
                                ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", o.IDObra))
                            End If

                            Me.Requery.InvokeOnClick()
                            ActiveExecuteActions()
                        End If
                    End If
                End If
            End If
        Else
            ExpertisApp.GenerateMessage("Para poder convertir el Presupuesto en Proyecto es necesario que Cliente tenga valor.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

#Region " ConvertirEmpresaACliente "

    Private Sub AccionConvertirEmpresaACliente()
        If Length(AdvIDEmpresa.Value) > 0 Then
            Dim StDatos As New EmpresaCategoria.DataEmpresaCategoria(AdvIDEmpresa.Value, "Cliente")
            Dim strIDCliente As String = ExpertisApp.ExecuteTask(Of EmpresaCategoria.DataEmpresaCategoria, String)(AddressOf EmpresaCategoria.GetValorEntidad, StDatos)
            If Length(strIDCliente) = 0 Then
                If Length(txtDireccion.Text) = 0 OrElse Length(txtCodPostal.Text) = 0 Then
                    Dim strMensaje As String = "Los campos Dirección y Código Postal son obligatorios en el Mantenimiento de Clientes. Debe rellenarlos antes de lanzar el proceso de conversión de Empresa en Cliente."
                    ExpertisApp.GenerateMessage(strMensaje, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf ExpertisApp.GenerateMessage("Se va a proceder a la conversión de la Empresa en Cliente. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then 'Se va a proceder a la conversión de la Empresa en Cliente. ¿Desea continuar?.
                    Dim info As Empresa.infoConvertirEmpresaEnCliente
                    Dim frm As New frmConvertirEmpresaEnCliente
                    info = frm.AbrirForm(Nz(Me.CurrentRow("TipoDocIdentidad"), 0), Me.CurrentRow("CifCliente") & String.Empty)
                    If Not info Is Nothing Then
                        info.dtOrigen = Me.CurrentData.Copy
                        info.dtOrigen.TableName = Me.EntityName
                        info.IDEmpresa = AdvIDEmpresa.Value
                        Dim dtCliente As DataTable = ExpertisApp.ExecuteTask(Of Empresa.infoConvertirEmpresaEnCliente, DataTable)(AddressOf Empresa.ConvertirEmpresaEnCliente, info)
                        If Not IsNothing(dtCliente) AndAlso dtCliente.Rows.Count > 0 Then
                            CrearCuentasEnPlanContable(dtCliente)
                            Me.RetrieveData(DataProviderActions.Refresh)
                        End If
                    End If
                Else
                    ExpertisApp.GenerateMessage("Proceso cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                AdvIDCliente.Value = strIDCliente
                Me.UpdateData()
            End If
        End If
    End Sub

    Private Sub CrearCuentasEnPlanContable(ByVal dt As DataTable)
        Dim StrEjercicio As String = ExpertisApp.ExecuteTask(Of Date, String)(AddressOf EjercicioContable.Predeterminado, Today.Date)
        Dim ClsApp As New ERP.CommonClasses.AltaPlanContable

        ClsApp.ValidaCuentaContable(dt.Rows(0)("CCCliente"), StrEjercicio, ulDescEmpresa.Text & String.Empty)
        If Length(dt.Rows(0)("CCEfectosCliente")) > 0 Then
            ClsApp.ValidaCuentaContable(dt.Rows(0)("CCEfectosCliente"), StrEjercicio, ulDescEmpresa.Text & String.Empty)
        End If
        If Length(dt.Rows(0)("CCEfectosGestionCobros")) > 0 Then
            ClsApp.ValidaCuentaContable(dt.Rows(0)("CCEfectosGestionCobros"), StrEjercicio, ulDescEmpresa.Text & String.Empty)
        End If
    End Sub

#End Region

#Region " RevisionDatosPresupuesto "

    Private Structure ResultadoRevisionPresupuesto
        Dim StConver As ObraPresupCabecera.datosConceptosNoExistentes
        Dim Cancel As Boolean
    End Structure
    Private Function RevisionDatosPresupuesto() As ResultadoRevisionPresupuesto
        Dim r As ResultadoRevisionPresupuesto

        Dim StConver As New ObraPresupCabecera.datosConceptosNoExistentes
        Me.Cursor = Cursors.WaitCursor
        StConver.IDPresup = Me.CurrentRow("IDPresup")
        StConver = ExpertisApp.ExecuteTask(Of ObraPresupCabecera.datosConceptosNoExistentes, ObraPresupCabecera.datosConceptosNoExistentes)(AddressOf ObraPresupCabecera.ObtenerConceptosNoExistentes, StConver)
        If StConver.ConvertirDatos Then
            Me.Cursor = Cursors.Default
            If ExpertisApp.GenerateMessage("Se han detectado Materiales o MOD o Centros sin crear en la Base de Datos.|Si no los genera pasarán al Proyecto con los códigos establecidos en los parámetros correspondientes. ¿Desea generar dichos elementos?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, vbNewLine) = DialogResult.Yes Then
                StConver.NumPresup = Me.CurrentRow("NumPresup") & String.Empty
                StConver.DescPresup = Me.CurrentRow("DescPresup") & String.Empty
                StConver.RevPresup = Me.CurrentRow("RevPresup") & String.Empty
                Dim FrmConver As New frmConverArticulos
                If FrmConver.LoadConverArticulos(StConver) = DialogResult.Cancel Then
                    r.Cancel = True
                End If
                StConver.CrearPredeterminado = False
            Else
                StConver.CrearPredeterminado = True
            End If
        End If
        r.StConver = StConver

        Return r
    End Function

#End Region

#End Region

    Private Sub AccionAddPresupuestoEnObra()
        If Length(AdvIDCliente.Text) > 0 AndAlso Length(AdvIDTipoObra.Text) > 0 AndAlso Not ndTrabajos Is Nothing AndAlso ndTrabajos.Data.Rows.Count > 0 Then
            Dim r As ResultadoRevisionPresupuesto = RevisionDatosPresupuesto()
            If Not r.Cancel Then
                Dim frm As New frmAddPresupObra
                frm.IDCliente = AdvIDCliente.Text
                frm.IDTipoObra = AdvIDTipoObra.Text
                If frm.ShowDialog = DialogResult.OK Then
                    If ExpertisApp.GenerateMessage("Se agregará el Presupuesto '| / |' al Proyecto '|'. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, Me.CurrentRow("NumPresup"), Me.CurrentRow("RevPresup"), frm.AdvIDObra.Text) = DialogResult.Yes Then
                        Me.Cursor = Cursors.WaitCursor

                        Dim datosAddPresupEnObra As New ObraCabecera.DatosGenerarObraDesdePresupuesto(Me.CurrentRow("IDPresup"), frm.AdvIDObra.Value, frm.mIDClase, r.StConver)
                        datosAddPresupEnObra.StDatos = ExpertisApp.ExecuteTask(Of ObraPresupCabecera.datosConceptosNoExistentes, ObraPresupCabecera.datosConceptosNoExistentes)(AddressOf ObraPresupCabecera.TratarConceptosNoExistentes, r.StConver)

                        ExpertisApp.ExecuteTask(Of ObraCabecera.DatosGenerarObraDesdePresupuesto)(AddressOf ObraCabecera.AddPresupEnObra, datosAddPresupEnObra)

                        Me.Cursor = Cursors.Default
                        RefreshPresup()
                        ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub AccionRecalcularPresupuesto()
        If Length(Me.CurrentRow("IDPresup")) > 0 Then
            If ExpertisApp.GenerateMessage("Se va a proceder al recálculo del Presupuesto '| / |'. Este proceso puede tardar varios minutos. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, Me.CurrentRow("NumPresup"), Me.CurrentRow("RevPresup")) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                ExpertisApp.ExecuteTask(Of Integer)(AddressOf ObraPresupCabecera.RecalcularPresupuesto, Me.CurrentRow("IDPresup"))
                RefreshPresup(Me.CurrentRow("IDPresup"))

                Me.Cursor = Cursors.Default
                ExpertisApp.GenerateMessage("Proceso finalizado correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ExpertisApp.GenerateMessage("Proceso cancelado.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    'Private Sub AccionImprimirMediciones()
    '    'Dim FwCriterio As clsFilterCriteria
    '    'Dim strCriteria As String
    '    'Dim rs As New Recordset

    '    'FwCriterio = New clsFilterCriteria
    '    'With FwCriterio
    '    '    .WhereFormat = wfCrystal
    '    '    .Alias = "vcrystalPresupuestos"
    '    '    .AddFilterItem("IdPresup", dtNumeric, opEqual, fwiNumPresup.Value)
    '    '    strCriteria = .GenerateFilterCriterias
    '    'End With

    '    'Dim fwnAplicacion As New DataEngine
    '    'rs = fwnAplicacion.Filter("vcrystalPresupuestos")
    '    ''Abro el informe
    '    'ExpertisApp.OpenReport("rptPresupuestos.rpt", , , rptCustom, strCriteria) 'Libero memoria

    'End Sub

#Region " BC3 "

    Private Sub AccionImportarBC3()
        Dim frm As New frmBC3
        If frm.ShowDialog = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            Dim texto As String()
            texto = PrepararFichero(frm.txtRuta.Text)
            Dim p As New Local_C
            Dim StrMsg As String = "La Importación del Fichero BC3 se está realizando, el proceso tardará unos minutos."
            Dim StrNomForm As String = "Importando Fichero BC3"
            Dim StartDelegate As New LecturaFichero(AddressOf p.LecturaFichero)
            Dim oFrmProc As New FrmProgresoProceso
            oFrmProc.Start(StartDelegate, New Object() {texto, Me.CurrentRow("IdPresup"), frm.chkMateriales.Checked, frm.chkMateriales.Checked, frm.chkMod.Checked, frm.chkCentros.Checked, frm.chkMediciones.Checked}, StrMsg, StrNomForm)
            RefreshPresup(Me.CurrentRow("IDPresup"))
            ExpertisApp.GenerateMessage("Importación finalizada.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ActiveExecuteActions()
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Public Function PrepararFichero(ByVal Ruta As String) As String()

        Dim texto As String()
        ReDim texto(-1)

        Dim Fs As Object
        Dim a As Object

        Fs = CreateObject("Scripting.FileSystemObject")

        a = Fs.OpenTextFile(Ruta, 1)
        Dim str As String
        While Not a.AtEndOfStreaM
            If Len(str) = 0 Then
                str = str & a.Readline()
            Else
                str = str & Chr(13) & a.Readline()
            End If
            If Len(str) > 0 AndAlso Mid(str, Len(str)) = "|" Then
                ReDim Preserve texto(UBound(texto) + 1)
                texto(UBound(texto)) = str
                str = String.Empty
            End If
        End While
        Return texto
    End Function

#End Region

    Private Sub AccionAbrirObra()
        ExpertisApp.OpenForm("MGEO", New NumberFilterItem("IDObra", Me.CurrentRow("IDObra")), , Me)
    End Sub

    Private Sub CargarMsProject()
        Dim objProject As Object
        Try
            objProject = CreateObject("MSProject.Application")
        Catch ex As Exception
            ExpertisApp.GenerateMessage("No tiene instalado Microsoft Project.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        If Not IsNothing(ndTrabajos.Data) AndAlso ndTrabajos.Data.Rows.Count > 0 Then
            If ExpertisApp.GenerateMessage("No se agregarán aquellas trabajos que no tengan datos en Fecha Inicio y Fecha Fin. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor
                Dim prj As Object = objProject.Projects.Add
                Dim oTask As Object
                'Insercion de Tareas
                For Each dr As DataRow In ndTrabajos.Data.Rows
                    If Length(dr("FechaInicio")) > 0 AndAlso Length(dr("FechaFin")) > 0 AndAlso dr("FechaInicio") <> cnMinDate AndAlso dr("FechaFin") <> cnMinDate Then
                        oTask = prj.Tasks.Add(CInt(dr("Secuencia")))
                        oTask.Name = dr("DescTrabajo")
                        If Length(dr("FechaInicio")) > 0 AndAlso IsDate(dr("FechaInicio")) Then oTask.Start = CDate(dr("FechaInicio"))
                        If Length(dr("FechaFin")) > 0 AndAlso IsDate(dr("FechaFin")) Then oTask.Finish = CDate(dr("FechaFin"))
                        oTask.Cost = CDbl(Nz(dr("ImpPresupTrabajoA"), 0))
                        oTask.Cost1 = CDbl(Nz(dr("ImpPresupMatA"), 0))
                        oTask.Cost2 = CDbl(Nz(dr("ImpPresupModA"), 0))
                        oTask = Nothing
                    End If
                Next
                Dim strPath As String = ExpertisApp.Path & "\Presupuesto" & txtNumPresup.Text & "_" & txtRevPresup.Text
                prj.SaveAs(strPath)
                ExpertisApp.GenerateMessage("Enviado a Project correctamente.", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            ExpertisApp.GenerateMessage("No hay trabajos en este Presupuesto.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        Me.Cursor = Cursors.Default
    End Sub

#Region " AccionAbrirDireccionesEnvio "

    Private Sub AccionAbrirDireccionesEnvio()
        If AdvDireccionEnvio Is Nothing Then AdvDireccionEnvio = New AdvancedSearch
        AdvDireccionEnvio.EntityName = "ClienteDireccion"
        AdvDireccionEnvio.ViewName = "tbClienteDireccion"
        AdvDireccionEnvio.Open()
    End Sub

    Private Sub BusquedaDireccion_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvDireccionEnvio.SetPredefinedFilter
        If Length(Me.CurrentRow("IDCliente")) > 0 Then
            e.Filter.Add("IDCliente", FilterOperator.Equal, Me.CurrentRow("IDCliente"))
            e.Filter.Add("Envio", FilterOperator.Equal, True)
        Else
            e.Filter.Add(New NoRowsFilterItem)
        End If
    End Sub

    Private Sub BusquedaDireccion_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvDireccionEnvio.SelectionChanged
        Me.CurrentRow("IDDireccion") = e.Selected.Rows(0)("IDDireccion")
        txtDireccion.Text = e.Selected.Rows(0)("Direccion") & String.Empty
        txtCodPostal.Text = e.Selected.Rows(0)("CodPostal") & String.Empty
        txtPoblacion.Text = e.Selected.Rows(0)("Poblacion") & String.Empty
        txtProvincia.Text = e.Selected.Rows(0)("Provincia") & String.Empty
    End Sub

#End Region

#End Region

#Region " Acciones Grid "

    Private Sub AccionDesgloseTrabajo()
        Dim frm As New frmDesgloseImportesTrabajo

        Dim ImpAcumulado, ImpAcumuladoVenta As Double
        If GridTrabajos.Value("TipoLinea") = enumTipoLineaTrabajo.tltTrabajoConcepto Then
            ImpAcumulado = Nz(GridTrabajos.Value("ImpPresupQTrabajoA"), 0)
            ImpAcumuladoVenta = Nz(GridTrabajos.Value("ImpPresupQTrabajoVentaA"), 0)
        Else
            ImpAcumulado = Nz(GridTrabajos.Value("ImpAcumulado"), 0)
            ImpAcumuladoVenta = Nz(GridTrabajos.Value("ImpAcumuladoVenta"), 0)
        End If
        frm.AbrirDesgloseTrabajo(GridTrabajos.Value("IDTrabajoPresup"), _
                                ImpAcumulado, _
                                 ImpAcumuladoVenta)
    End Sub

    Private Sub AccionVerFicha()
        drTrabajos = GetdrTrabajos(GridTrabajos.GetValue("IDTrabajoPresup"))
        Me.GetDatosTrabajo(drTrabajos)
        rbtVerFicha.Checked = True
    End Sub

    Private Sub AccionNuevoTrabajo()
        NuevoTrabajo(GridTrabajos.Value("IDTrabajoPresup"), GridTrabajos.Value("IDTipoTrabajo") & String.Empty, _
                     GridTrabajos.Value("IDSubTipoTrabajo") & String.Empty, _
                     GridTrabajos.Value("SubSubTipoTrabajo") & String.Empty)
    End Sub

    Private Sub AccionAbrirMaterial()
        ExpertisApp.OpenForm("MARTICULO", New StringFilterItem("IDArticulo", GridMateriales.Value("IDMaterial")))
    End Sub

    Private Sub AccionImportarEstructura()
        With GridMateriales
            If Length(.Value("IDLineaMaterialPadre")) = 0 AndAlso Length(.Value("IDMaterial")) > 0 Then
                Dim frm As New frmImpEstructura
                frm.IDCliente = AdvIDCliente.Text & String.Empty
                frm.IDPresup = .Value("IDPresup")
                frm.IDTrabajo = .Value("IDTrabajoPresup")
                frm.IDArticulo = .Value("IDMaterial")
                frm.DescArticulo = .Value("DescMaterial")
                frm.IDLineaMaterial = .Value("IDlineaMaterial")
                frm.QPresupTrabajo = .Value("QPresupTrabajo")
                frm.QUnidad = .Value("QUnidad")

                frm.ShowDialog(Me)
                Me.Requery.InvokeOnClick()
            End If
        End With
    End Sub

#End Region

    Private Sub GetTrabajos()
        dtTrabajos = ndTrabajos.Data
        If ndTrabajos.Data Is Nothing OrElse ndTrabajos.Data.Rows.Count = 0 Then
            Me.pnlFicha.Enabled = False
            drTrabajos = Nothing
        Else
            Me.pnlFicha.Enabled = True
            Dim dv As New DataView(ndTrabajos.Data)
            dv.Sort = "Secuencia"
            drTrabajos = dv(0).Row
        End If
        BindingDetalleTrabajo()
    End Sub

    Private Function GetdrTrabajos(ByVal IDTrabajoPresup As Integer) As DataRow
        Dim dv As DataView = dtTrabajos.DefaultView
        dv.RowFilter = "IDTrabajoPresup=" & IDTrabajoPresup
        If dv.Count > 0 Then
            Return dv(0).Row
        Else
            Return Nothing
        End If
    End Function

    Private Sub MntoObraPresup_RecordStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordStateChanged
        blnRecordStateChanged = True
    End Sub

    Private Sub MntoObraPresup_Navigating(ByVal sender As Object, ByVal e As Engine.UI.NavigatingEventArgs) Handles MyBase.Navigating
        Select Case e.Action
            Case DataProviderActions.GoFirst
                blnPintarTrabajos = IIf(blnRecordStateChanged, blnRefreshArbol, True)
            Case DataProviderActions.GoRecord, DataProviderActions.Refresh, DataProviderActions.GoLast, DataProviderActions.GoNext, DataProviderActions.GoPrevious
                blnPintarTrabajos = True
            Case Else
                blnPintarTrabajos = False
        End Select
        blnRecordStateChanged = False
    End Sub

    Private Sub MntoObraPresup_Navigated(ByVal sender As Object, ByVal e As Solmicro.Expertis.Engine.UI.NavigatedEventArgs) Handles MyBase.Navigated
        If Not Me.CurrentRow Is Nothing Then
            GetTrabajos()
            Dim blnBloqueado As Boolean = cbxEstado.Value = enumopcEstado.opcAceptado Or cbxEstado.Value = enumopcEstado.opcRechazado
            BloquearInformacion(Me.MainPanel, blnBloqueado, txtNumPresup, rbtMaximizarTree, rbtMinimizarTree, rbtVerFicha, rbtVerGrid, rbtVerPresupuestoCompleto, rbtPorNivelTrabajos, rbtPorMultinivelTrabajos, rbtPresupTrabajos, rbtPorNivelMat, rbtPresupMat, rbtPorNivelMod, rbtPresupMod, rbtPorNivelCentros, rbtPresupCentros, rbtPorNivelGastos, rbtPresupGastos, rbtPorNivelVarios, rbtPresupVarios, rbtPorNivelMedicion, rbtPresupMedicion, rbtPorMultinivelMat, rbtPorMultinivelMod, rbtPorMultinivelCentros, rbtPorMultinivelGastos, rbtPorMultinivelVarios, rbtPorMultinivelMedicion, txtMargenPresupTrabajo, chkVerPorcentajes, cbxEstado)
            CmbUrlContrato.Enabled = Not blnBloqueado
            CamposNoEditables()
            ActiveExecuteActions()
            chkNoAcumular_CheckedChanged(chkNoAcumular, New EventArgs)
            ArbolTrabajos()
            TabPresupuestos_Click(TabPresupuestos, New EventArgs)
        End If
    End Sub

    Private Sub MntoObraPresup_RecordAddingUpdating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordAdding, MyBase.RecordUpdating
        GridTrabajos.EntityName = "" : GridMateriales.EntityName = "" : GridMOD.EntityName = "" : GridCentros.EntityName = "" : GridGastos.EntityName = "" : GridVarios.EntityName = "" : GridMediciones.EntityName = ""
    End Sub

    Private Sub MntoObraPresup_Deleting(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordDeleting
        GridTrabajos.EntityName = "" : GridMateriales.EntityName = "" : GridMOD.EntityName = "" : GridCentros.EntityName = "" : GridGastos.EntityName = "" : GridVarios.EntityName = "" : GridMediciones.EntityName = ""
        blnRecordStateChanged = True
        blnRefreshArbol = True
    End Sub

    Private Sub MntoObraPresup_RecordCanceling(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.RecordCanceling
        blnRecordStateChanged = True
        blnRefreshArbol = True
    End Sub

    Private Sub InicializeNeededData()
        GridTrabajos.EntityName = ndTrabajos.EntityName
        GridMateriales.EntityName = ndMateriales.EntityName
        GridMOD.EntityName = ndMOD.EntityName
        GridCentros.EntityName = ndCentros.EntityName
        GridGastos.EntityName = ndGastos.EntityName
        GridVarios.EntityName = ndVarios.EntityName
        GridMediciones.EntityName = ndMediciones.EntityName
    End Sub

    Private Sub Added(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordAdded
        TvwTrabajos.Nodes.Clear()
        drTrabajos = Nothing
        Me.GetDatosTrabajo(drTrabajos)
        InicializeNeededData()

        TabPresupuestos_Click(TabPresupuestos, New System.EventArgs)
        blnRefreshArbol = False
    End Sub

    Private Sub UpdatedDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.RecordUpdated, MyBase.RecordDeleted
        InicializeNeededData()
        RefreshPresup()
        TabPresupuestos_Click(TabPresupuestos, New System.EventArgs)
        AdvIDEmpresa.Enabled = (GridTrabajos.RowCount = 0)
        AdvIDTipoObra.Enabled = (GridTrabajos.RowCount = 0)
        blnRefreshArbol = False
    End Sub

    Private Sub TabPresupuestos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPresupuestos.Click
        If Me.RecordsState <> RecordsState.Initialize Then
            Select Case TabPresupuestos.SelectedTab.Key
                Case "Cabecera"
                    CalculoDesgloseEconomico()
                Case "Trabajos"
                    TabTrabajos_Click(TabTrabajos, New System.EventArgs)
            End Select
        End If
    End Sub

    Private Sub ActiveExecuteActions()
        Dim blnEnabled As InheritableBoolean = InheritableBoolean.False

        If Me.CurrentRow("Estado") <> enumopcEstado.opcAceptado AndAlso Me.CurrentRow("Estado") <> enumopcEstado.opcRechazado Then
            blnEnabled = InheritableBoolean.True
        Else
            blnEnabled = InheritableBoolean.False
        End If

        Me.ExecuteActions.Commands(cnBC3).Enabled = blnEnabled

        If Length(Me.CurrentRow("IDObra")) = 0 Then
            Me.ExecuteActions.Commands(cnPRESUPENOBRA).Enabled = InheritableBoolean.True
            Me.ExecuteActions.Commands(cnABRIRPROYECTO).Enabled = InheritableBoolean.False
        Else
            Me.ExecuteActions.Commands(cnPRESUPENOBRA).Enabled = InheritableBoolean.False
            Me.ExecuteActions.Commands(cnABRIRPROYECTO).Enabled = InheritableBoolean.True
        End If
        If ndTrabajos Is Nothing OrElse ndTrabajos.Data Is Nothing OrElse ndTrabajos.Data.Rows.Count = 0 Then
            Me.ExecuteActions.Commands(cnBC3).Enabled = InheritableBoolean.True
        Else
            Me.ExecuteActions.Commands(cnBC3).Enabled = InheritableBoolean.False
        End If
        If Length(AdvIDCliente.Text) > 0 AndAlso Length(AdvIDTipoObra.Text) > 0 AndAlso Not ndTrabajos Is Nothing AndAlso Not ndTrabajos.Data Is Nothing AndAlso ndTrabajos.Data.Rows.Count > 0 AndAlso Length(Me.CurrentRow("IDObra")) = 0 Then
            Me.ExecuteActions.Commands(cnADDPRESUPENOBRA).Enabled = InheritableBoolean.True
        Else
            Me.ExecuteActions.Commands(cnADDPRESUPENOBRA).Enabled = InheritableBoolean.False
        End If
    End Sub

#Region " Pestaña Cabecera "

    'Private Sub cbxEstado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbxEstado.Validating
    '    If Length(cbxEstado.Value) > 0 Then
    '        Dim dv As DataView = cbxEstado.DataSource
    '        dv.RowFilter = New StringFilterItem("IDEstado", FilterOperator.Equal, cbxEstado.Value).Compose(New AdoFilterComposer)
    '        If dv.Count = 0 Then
    '            e.Cancel = True
    '            ExpertisApp.GenerateMessage("El Estado no existe.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        End If
    '        dv.RowFilter = String.Empty
    '    End If
    'End Sub

    Private Sub AdvIDCliente_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDCliente.SetPredefinedFilter
        If Length(AdvIDEmpresa.Value) > 0 Then
            e.Filter.Add(New StringFilterItem("IDEmpresa", AdvIDEmpresa.Value))
        End If
    End Sub

    Private Sub txtGastosGenerales_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGastosGenerales.LostFocus
        txtTotalGastosGenerales.Value = txtImpPresupVentaA.Value * txtGastosGenerales.Value / 100
    End Sub

    Private Sub txtBeneficioIndustrial_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBeneficioIndustrial.LostFocus
        txtTotalBeneficioIndustrial.Value = txtImpPresupVentaA.Value * txtBeneficioIndustrial.Value / 100
    End Sub

    Private Sub txtCoefBaja_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCoefBaja.LostFocus
        txtTotalCoefBaja.Value = -(txtImpPresupVentaA.Value * Math.Abs(txtCoefBaja.Value) / 100)
    End Sub

    Private Sub CalculoDesgloseEconomico()
        Dim blnInicializar As Boolean

        If Length(Me.CurrentRow("IDPresup")) > 0 Then
            Dim dblImporte, dblPresupMAT, dblPresupMOD, dblPresupCEN, dblPresupGAS, dblPresupVAR, dblDirecto, dblIndirecto As Double
            Dim dblPresupVentaMAT, dblPresupVentaMOD, dblPresupVentaCEN, dblPresupVentaGAS, dblPresupVentaVAR, dblDirectoVenta, dblIndirectoVenta As Double
            Dim dt As DataTable = New BE.DataEngine().Filter("VFrmMntoObraPresupDesgloseImporte", New FilterItem("IDPresup", FilterOperator.Equal, Me.CurrentRow("IDPresup")))
            If Not IsNothing(dt) AndAlso dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    'Importes Previstos
                    dblPresupMAT = dblPresupMAT + dr("ImpPresupQMatA")
                    dblPresupMOD = dblPresupMOD + dr("ImpPresupQModA")
                    dblPresupCEN = dblPresupCEN + dr("ImpPresupQCentrosA")
                    dblPresupGAS = dblPresupGAS + dr("ImpPresupQGastosA")
                    dblPresupVAR = dblPresupVAR + dr("ImpPresupQVariosA")
                    'Importes Venta
                    dblPresupVentaMAT = dblPresupVentaMAT + dr("ImpPresupQMatVentaA")
                    dblPresupVentaMOD = dblPresupVentaMOD + dr("ImpPresupQModVentaA")
                    dblPresupVentaCEN = dblPresupVentaCEN + dr("ImpPresupQCentrosVentaA")
                    dblPresupVentaGAS = dblPresupVentaGAS + dr("ImpPresupQGastosVentaA")
                    dblPresupVentaVAR = dblPresupVentaVAR + dr("ImpPresupQVariosVentaA")

                    If dr("TipoCosteDI") = enumtcdiTipoCoste.tcdiDirecto Then
                        dblDirecto = dblDirecto + xRound(dr("ImpPresupQTrabajoA"), mintRedondeoA)
                        dblDirectoVenta = dblDirectoVenta + xRound(dr("ImpPresupQTrabajoVentaA"), mintRedondeoA)
                    Else
                        dblIndirecto = dblIndirecto + xRound(dr("ImpPresupQTrabajoA"), mintRedondeoA)
                        dblIndirectoVenta = dblIndirectoVenta + xRound(dr("ImpPresupQTrabajoVentaA"), mintRedondeoA)
                    End If
                Next
                'Importes Previstos
                txtImpPresupQMatA.Value = xRound(dblPresupMAT, mintRedondeoA)
                txtImpPresupQModA.Value = xRound(dblPresupMOD, mintRedondeoA)
                txtImpPresupQCentrosA.Value = xRound(dblPresupCEN, mintRedondeoA)
                txtImpPresupQGastosA.Value = xRound(dblPresupGAS, mintRedondeoA)
                txtImpPresupQVariosA.Value = xRound(dblPresupVAR, mintRedondeoA)
                dblImporte = dblPresupMAT + dblPresupMOD + dblPresupCEN + dblPresupGAS + dblPresupVAR
                If txtImpPresupQTrabajoA.Value <> dblImporte Then txtImpPresupQTrabajoA.Value = dblImporte
                txtPresupDirecto.Value = dblDirecto
                txtPresupIndirecto.Value = dblIndirecto

                'Importes Venta
                txtImpPresupQMatVentaA.Value = xRound(dblPresupVentaMAT, mintRedondeoA)
                txtImpPresupQModVentaA.Value = xRound(dblPresupVentaMOD, mintRedondeoA)
                txtImpPresupQCentrosVentaA.Value = xRound(dblPresupVentaCEN, mintRedondeoA)
                txtImpPresupQGastosVentaA.Value = xRound(dblPresupVentaGAS, mintRedondeoA)
                txtImpPresupQVariosVentaA.Value = xRound(dblPresupVentaVAR, mintRedondeoA)
                dblImporte = dblPresupVentaMAT + dblPresupVentaMOD + dblPresupVentaCEN + dblPresupVentaGAS + dblPresupVentaVAR
                If txtImpPresupQTrabajoVentaA.Value <> dblImporte Then txtImpPresupQTrabajoVentaA.Value = dblImporte
                txtPresupVentaDirecto.Value = dblDirectoVenta
                txtPresupVentaIndirecto.Value = dblIndirectoVenta

                'Margenes Prev
                txtMargenMat.Value = CalcularMargen(txtImpPresupQMatVentaA.Value, txtImpPresupQMatA.Value)
                txtMargenMod.Value = CalcularMargen(txtImpPresupQModVentaA.Value, txtImpPresupQModA.Value)
                txtMargenCentro.Value = CalcularMargen(txtImpPresupQCentrosVentaA.Value, txtImpPresupQCentrosA.Value)
                txtMargenGastos.Value = CalcularMargen(txtImpPresupQGastosVentaA.Value, txtImpPresupQGastosA.Value)
                txtMargenVarios.Value = CalcularMargen(txtImpPresupQVariosVentaA.Value, txtImpPresupQVariosA.Value)
                txtMargenTrabajo.Value = CalcularMargen(txtImpPresupQTrabajoVentaA.Value, txtImpPresupQTrabajoA.Value)
                txtMargenPresupTrabajo.Value = CalcularMargen(txtImpPresupVentaA.Value, txtImpPresupA.Value)
            Else
                blnInicializar = True
            End If
        Else
            blnInicializar = True
        End If
        If blnInicializar Then
            For Each c As Control In Me.FraImportes.Controls
                If c.GetType.FullName = "Solmicro.Expertis.Engine.UI.NumericTextBox" Then
                    CType(c, Solmicro.Expertis.Engine.UI.NumericTextBox).Value = 0
                End If
            Next
        End If
        txtTotalGastosGenerales.Value = txtImpPresupVentaA.Value * txtGastosGenerales.Value / 100
        txtTotalBeneficioIndustrial.Value = txtImpPresupVentaA.Value * txtBeneficioIndustrial.Value / 100
        txtTotalCoefBaja.Value = -(txtImpPresupVentaA.Value * Math.Abs(txtCoefBaja.Value) / 100)

        Dim dblTotalSinIva As Double = txtImpPresupVentaA.Value + txtTotalGastosGenerales.Value + txtTotalBeneficioIndustrial.Value + txtTotalCoefBaja.Value
        Dim dblFactor As Double = Nz(Me.CurrentRow("Factor"), 0)
        If dblFactor <> 0 Then dblFactor = dblFactor / 100
        txtTotalIva.Value = dblTotalSinIva * dblFactor
        txtTotal.Value = dblTotalSinIva + txtTotalIva.Value
    End Sub

#End Region

#Region " Pestaña Trabajos "

    Private Sub CheckedAll()
        blnChecked = True
        Select Case TabTrabajos.SelectedTab.Key
            Case "Trabajos"
                Dim blnPorTrabajo As Boolean = (rbtPorNivelTrabajos.Checked Or rbtPorMultinivelTrabajos.Checked)
                rbtPorNivelMat.Checked = rbtPorNivelTrabajos.Checked : rbtPresupMat.Checked = Not blnPorTrabajo
                rbtPorNivelMod.Checked = rbtPorNivelTrabajos.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorNivelCentros.Checked = rbtPorNivelTrabajos.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorNivelGastos.Checked = rbtPorNivelTrabajos.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorNivelVarios.Checked = rbtPorNivelTrabajos.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                rbtPorNivelMedicion.Checked = rbtPorNivelTrabajos.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
                '''''''''''''''''''''
                rbtPorMultinivelMat.Checked = rbtPorMultinivelTrabajos.Checked : rbtPresupMat.Checked = Not blnPorTrabajo
                rbtPorMultinivelMod.Checked = rbtPorMultinivelTrabajos.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorMultinivelCentros.Checked = rbtPorMultinivelTrabajos.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorMultinivelGastos.Checked = rbtPorMultinivelTrabajos.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorMultinivelVarios.Checked = rbtPorMultinivelTrabajos.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                rbtPorMultinivelMedicion.Checked = rbtPorMultinivelTrabajos.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
            Case "Materiales"
                Dim blnPorTrabajo As Boolean = (rbtPorNivelMat.Checked Or rbtPorMultinivelMat.Checked)
                rbtPorNivelTrabajos.Checked = rbtPorNivelMat.Checked : rbtPresupTrabajos.Checked = Not blnPorTrabajo
                rbtPorNivelMod.Checked = rbtPorNivelMat.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorNivelCentros.Checked = rbtPorNivelMat.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorNivelGastos.Checked = rbtPorNivelMat.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorNivelVarios.Checked = rbtPorNivelMat.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                rbtPorNivelMedicion.Checked = rbtPorNivelMat.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
                '''''''''''''''''''''
                rbtPorMultinivelTrabajos.Checked = rbtPorMultinivelMat.Checked : rbtPresupTrabajos.Checked = Not blnPorTrabajo
                rbtPorMultinivelMod.Checked = rbtPorMultinivelMat.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorMultinivelCentros.Checked = rbtPorMultinivelMat.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorMultinivelGastos.Checked = rbtPorMultinivelMat.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorMultinivelVarios.Checked = rbtPorMultinivelMat.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                rbtPorMultinivelMedicion.Checked = rbtPorMultinivelMat.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
            Case "Mod"
                Dim blnPorTrabajo As Boolean = (rbtPorNivelMod.Checked Or rbtPorMultinivelMod.Checked)
                rbtPorNivelTrabajos.Checked = rbtPorNivelMod.Checked : rbtPresupTrabajos.Checked = Not blnPorTrabajo
                rbtPorNivelMat.Checked = rbtPorNivelMod.Checked : rbtPresupMat.Checked = Not blnPorTrabajo
                rbtPorNivelCentros.Checked = rbtPorNivelMod.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorNivelGastos.Checked = rbtPorNivelMod.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorNivelVarios.Checked = rbtPorNivelMod.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                rbtPorNivelMedicion.Checked = rbtPorNivelMod.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
                '''''''''''''''''''''
                rbtPorMultinivelTrabajos.Checked = rbtPorMultinivelMod.Checked : rbtPresupTrabajos.Checked = Not blnPorTrabajo
                rbtPorMultinivelMat.Checked = rbtPorMultinivelMod.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorMultinivelCentros.Checked = rbtPorMultinivelMod.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorMultinivelGastos.Checked = rbtPorMultinivelMod.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorMultinivelVarios.Checked = rbtPorMultinivelMod.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                rbtPorMultinivelMedicion.Checked = rbtPorMultinivelMod.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
            Case "Centros"
                Dim blnPorTrabajo As Boolean = (rbtPorNivelCentros.Checked Or rbtPorMultinivelCentros.Checked)
                rbtPorNivelTrabajos.Checked = rbtPorNivelCentros.Checked : rbtPresupTrabajos.Checked = Not blnPorTrabajo
                rbtPorNivelMat.Checked = rbtPorNivelCentros.Checked : rbtPresupMat.Checked = Not blnPorTrabajo
                rbtPorNivelMod.Checked = rbtPorNivelCentros.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorNivelGastos.Checked = rbtPorNivelCentros.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorNivelVarios.Checked = rbtPorNivelCentros.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                rbtPorNivelMedicion.Checked = rbtPorNivelCentros.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
                '''''''''''''''''''''
                rbtPorMultinivelTrabajos.Checked = rbtPorMultinivelCentros.Checked : rbtPresupTrabajos.Checked = Not blnPorTrabajo
                rbtPorMultinivelMat.Checked = rbtPorMultinivelCentros.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorMultinivelMod.Checked = rbtPorMultinivelCentros.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorMultinivelGastos.Checked = rbtPorMultinivelCentros.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorMultinivelVarios.Checked = rbtPorMultinivelCentros.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                rbtPorMultinivelMedicion.Checked = rbtPorMultinivelCentros.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
            Case "Gastos"
                Dim blnPorTrabajo As Boolean = (rbtPorNivelGastos.Checked Or rbtPorMultinivelGastos.Checked)
                rbtPorNivelTrabajos.Checked = rbtPorNivelGastos.Checked : rbtPresupTrabajos.Checked = Not blnPorTrabajo
                rbtPorNivelMat.Checked = rbtPorNivelGastos.Checked : rbtPresupMat.Checked = Not blnPorTrabajo
                rbtPorNivelMod.Checked = rbtPorNivelGastos.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorNivelCentros.Checked = rbtPorNivelGastos.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorNivelVarios.Checked = rbtPorNivelGastos.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                rbtPorNivelMedicion.Checked = rbtPorNivelGastos.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
                '''''''''''''''''''''
                rbtPorMultinivelTrabajos.Checked = rbtPorMultinivelGastos.Checked : rbtPresupTrabajos.Checked = Not blnPorTrabajo
                rbtPorMultinivelMat.Checked = rbtPorMultinivelGastos.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorMultinivelMod.Checked = rbtPorMultinivelGastos.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorMultinivelCentros.Checked = rbtPorMultinivelGastos.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorMultinivelVarios.Checked = rbtPorMultinivelGastos.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                rbtPorMultinivelMedicion.Checked = rbtPorMultinivelGastos.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
            Case "Varios"
                Dim blnPorTrabajo As Boolean = (rbtPorNivelVarios.Checked Or rbtPorMultinivelVarios.Checked)
                rbtPorNivelTrabajos.Checked = rbtPorNivelVarios.Checked : rbtPresupTrabajos.Checked = Not blnPorTrabajo
                rbtPorNivelMat.Checked = rbtPorNivelVarios.Checked : rbtPresupMat.Checked = Not blnPorTrabajo
                rbtPorNivelMod.Checked = rbtPorNivelVarios.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorNivelCentros.Checked = rbtPorNivelVarios.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorNivelGastos.Checked = rbtPorNivelVarios.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorNivelMedicion.Checked = rbtPorNivelVarios.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
                '''''''''''''''''''''
                rbtPorMultinivelTrabajos.Checked = rbtPorMultinivelVarios.Checked : rbtPresupTrabajos.Checked = Not blnPorTrabajo
                rbtPorMultinivelMat.Checked = rbtPorMultinivelVarios.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorMultinivelMod.Checked = rbtPorMultinivelVarios.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorMultinivelCentros.Checked = rbtPorMultinivelVarios.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorMultinivelGastos.Checked = rbtPorMultinivelVarios.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                rbtPorMultinivelMedicion.Checked = rbtPorMultinivelVarios.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
            Case "Mediciones"
                Dim blnPorTrabajo As Boolean = (rbtPorNivelMedicion.Checked Or rbtPorMultinivelMedicion.Checked)
                rbtPorNivelTrabajos.Checked = rbtPorNivelMedicion.Checked : rbtPresupTrabajos.Checked = Not blnPorTrabajo
                rbtPorNivelMat.Checked = rbtPorNivelMedicion.Checked : rbtPresupMat.Checked = Not blnPorTrabajo
                rbtPorNivelMod.Checked = rbtPorNivelMedicion.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorNivelCentros.Checked = rbtPorNivelMedicion.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorNivelGastos.Checked = rbtPorNivelMedicion.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorNivelVarios.Checked = rbtPorNivelMedicion.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                '''''''''''''''''''''
                rbtPorMultinivelTrabajos.Checked = rbtPorMultinivelMedicion.Checked : rbtPresupTrabajos.Checked = Not blnPorTrabajo
                rbtPorMultinivelMat.Checked = rbtPorMultinivelMedicion.Checked : rbtPresupMod.Checked = Not blnPorTrabajo
                rbtPorMultinivelMod.Checked = rbtPorMultinivelMedicion.Checked : rbtPresupCentros.Checked = Not blnPorTrabajo
                rbtPorMultinivelCentros.Checked = rbtPorMultinivelMedicion.Checked : rbtPresupGastos.Checked = Not blnPorTrabajo
                rbtPorMultinivelGastos.Checked = rbtPorMultinivelMedicion.Checked : rbtPresupVarios.Checked = Not blnPorTrabajo
                rbtPorMultinivelVarios.Checked = rbtPorMultinivelMedicion.Checked : rbtPresupMedicion.Checked = Not blnPorTrabajo
        End Select
        blnChecked = False
    End Sub

    Private Sub TrabajosObraChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPresupTrabajos.CheckedChanged, rbtPorNivelTrabajos.CheckedChanged, rbtPorMultinivelTrabajos.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            pnlVerTrabajo.Visible = (rbtPorNivelTrabajos.Checked Or rbtPorMultinivelTrabajos.Checked)
            If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                CheckedAll()
                TabTrabajos_Click(TabTrabajos, New System.EventArgs)
            End If
        End If
    End Sub

#Region " Grid Trabajo "

    Private Function GeneraCodTrabajo(Optional ByVal blnPorNivel As Boolean = False) As String
        Dim dvTrabajos As New DataView(ndTrabajos.Data.Copy)
        If Not dvTrabajos Is Nothing Then
            Dim i As Integer = 1
            Dim strCodTrabajoAux As String = drTrabajos("CodTrabajo")
            Dim strCodTrabajo As String = strCodTrabajoAux & "." & dvTrabajos.Count + i

            Dim f As New Filter
            If rbtPorNivelTrabajos.Checked OrElse blnPorNivel Then
                If blnPorNivel Then
                    f.Add(New NumberFilterItem("IDTrabajoPresupPadre", drTrabajos("IDTrabajoPresup")))
                Else
                    f.Add(New StringFilterItem("CodTrabajoPadre", strCodTrabajoAux))
                End If
                strCodTrabajo = strCodTrabajoAux
            Else
                f.Add(New IsNullFilterItem("IDTrabajoPresupPadre", True))
            End If

            dvTrabajos.RowFilter = f.Compose(New AdoFilterComposer)
            If dvTrabajos.Count <> 0 Then
                Dim blnNotExist As Boolean
                i = dvTrabajos.Count
                Do
                    i = i + 1
                    f.Clear()
                    f.Add(New StringFilterItem("CodTrabajo", strCodTrabajoAux & "." & i))
                    dvTrabajos.RowFilter = f.Compose(New AdoFilterComposer)
                    If dvTrabajos.Count = 0 Then
                        blnNotExist = True
                    End If
                Loop Until blnNotExist
            End If
            strCodTrabajo = strCodTrabajo & "." & i

            Return strCodTrabajo
        End If
        Return Nothing
    End Function

    Private Sub GridTrabajos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridTrabajos.GotFocus
        With GridTrabajos
            .Columns("TipoLinea").DefaultValue = CInt(enumTipoLineaTrabajo.tltTrabajo)
            .Columns("IDPresup").DefaultValue = Me.CurrentRow("IDPresup")
            .Columns("IDTipoObra").DefaultValue = Me.CurrentRow("IDTipoObra")
            .Columns("IDTipoTrabajo").DefaultValue = System.DBNull.Value
            .Columns("IDSubTipoTrabajo").DefaultValue = System.DBNull.Value
            .Columns("CodTrabajo").DefaultValue = System.DBNull.Value
            .Columns("DescTrabajo").DefaultValue = System.DBNull.Value
            .Columns("CodTrabajoPadre").DefaultValue = System.DBNull.Value
            .Columns("IDTrabajoPresupPadre").DefaultValue = System.DBNull.Value
            If rbtPorNivelTrabajos.Checked AndAlso Not drTrabajos Is Nothing Then
                If Length(drTrabajos("IDTipoTrabajo")) > 0 Then .Columns("IDTipoTrabajo").DefaultValue = drTrabajos("IDTipoTrabajo")
                If Length(drTrabajos("IDSubTipoTrabajo")) > 0 Then .Columns("IDSubTipoTrabajo").DefaultValue = drTrabajos("IDSubTipoTrabajo")
                If Length(drTrabajos("CodTrabajo")) > 0 Then
                    .Columns("CodTrabajo").DefaultValue = GeneraCodTrabajo()
                    .Columns("CodTrabajoPadre").DefaultValue = drTrabajos("CodTrabajo")
                End If
                If Length(drTrabajos("DescTrabajo")) > 0 Then .Columns("DescTrabajo").DefaultValue = drTrabajos("DescTrabajo")
                If Length(drTrabajos("IDTrabajoPresup")) > 0 Then .Columns("IDTrabajoPresupPadre").DefaultValue = drTrabajos("IDTrabajoPresup")
                .Columns("Nivel").DefaultValue = Nz(drTrabajos("Nivel"), 0) + 1
            End If
            .Columns("TipoCosteDI").DefaultValue = CInt(enumtcdiTipoCoste.tcdiDirecto)
            If Length(txtNumeroPedido.Text) > 0 Then .Columns("NumeroPedido").DefaultValue = txtNumeroPedido.Text
            .Columns("NoAcumular").DefaultValue = blnNoAcumular
            .Columns("IDUDMedida").DefaultValue = mstrIDUDMedida
            .Columns("IDCentroGestion").DefaultValue = Nz(Me.CurrentRow("IDCentroGestion"), mstrIDCGestion)
        End With
    End Sub

    Private Sub GridTrabajos_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridTrabajos.EditingCell
        With GridTrabajos
            If cbxEstado.Value <> enumopcEstado.opcAceptado AndAlso cbxEstado.Value <> enumopcEstado.opcRechazado Then
                Dim blnEnabled As Boolean = .Value("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Or .Value("TipoLinea") = enumTipoLineaTrabajo.tltPorcentajeConcepto
                Select Case e.Column.Key
                    Case "Incremento"
                        e.Cancel = .Value("TipoLinea") <> enumTipoLineaTrabajo.tltPorcentajeConcepto
                    Case "ImpPresupTrabajoA", "MargenTrabajo", "ImpPresupTrabajoVentaA"
                        If .Value("NoAcumular") = 0 Or .Value("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then
                            e.Cancel = True
                        Else
                            .Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.TextBox
                        End If
                    Case "QPresup", "TipoCosteDI", "FechaInicio", "FechaFin", "DuracionPresup", "NumeroPedido", "CodTrabajoPadre", "Nivel"
                        e.Cancel = blnEnabled
                    Case "NoAcumular"
                        e.Cancel = .Value("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo
                    Case "IDUDMedida", "IDArticulo", "IDCentroGestion"
                        If blnEnabled Then
                            .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                            e.Cancel = True
                        Else
                            .Columns(e.Column.Key).ButtonStyle = ButtonStyle.Image
                        End If
                End Select
            Else
                e.Cancel = True
                .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            End If
        End With
    End Sub

    Private Sub GridTrabajos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridTrabajos.Click
        With GridTrabajos
            If Length(.GetValue("IDTrabajoPresup")) > 0 Then
                mSeleccionarNodoTrabajoDesdeGrid = True
                SeleccionarNodoTrabajo(.Value("IDTrabajoPresup"))
                mSeleccionarNodoTrabajoDesdeGrid = False
            End If
            Dim hit As GridArea = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "Texto"
                            Dim frm As New FormularioTexto
                            frm.Texto = .Value("Texto") & String.Empty
                            frm.ShowDialog()
                            If .Value("Texto") & String.Empty <> frm.Texto Then
                                .SetValue("Texto", frm.Texto)
                            End If
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub GridTrabajos_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridTrabajos.RecordUpdated
        TotalTrabajos()

        If TypeOf GridTrabajos.DataSource Is DataView Then
            dtTrabajos = CType(GridTrabajos.DataSource, DataView).Table
        Else
            dtTrabajos = CType(GridTrabajos.DataSource, DataTable)
        End If

        If rbtPorNivelTrabajos.Checked Then GridTrabajos_GotFocus(GridTrabajos, New EventArgs)
    End Sub

    Private Sub GridTrabajos_RecordAdded_Deleted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridTrabajos.RecordAdded, GridTrabajos.RecordsDeleted
        GridTrabajos_RecordUpdated(GridTrabajos, New EventArgs)
    End Sub

    Private Sub TotalTrabajos()
        If Not rbtPorNivelTrabajos.Checked Then
            With GridTrabajos
                '   Dim Fil As New Janus.Windows.GridEX.GridEXFilterCondition(.Columns("Concepto"), ConditionOperator.Equal, 0)
                Dim Fil As New Janus.Windows.GridEX.GridEXFilterCondition(.Columns("TipoLinea"), ConditionOperator.Equal, 0)
                txtPresupTrabajoGrid.Value = xRound(.GetTotal(.Columns("ImpPresupQTrabajoA"), Janus.Windows.GridEX.AggregateFunction.Sum, Fil), mintRedondeoA)
                txtPresupVentaTrabajoGrid.Value = xRound(.GetTotal(.Columns("ImpPresupQTrabajoVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum, Fil), mintRedondeoA)
            End With
        ElseIf Not IsNothing(drTrabajos) Then
            txtPresupTrabajoGrid.Value = drTrabajos("ImpAcumulado")
            txtPresupVentaTrabajoGrid.Value = drTrabajos("ImpAcumuladoVenta")
        Else
            txtPresupTrabajoGrid.Value = 0 : txtPresupVentaTrabajoGrid.Text = 0
        End If
    End Sub

    Private Sub GridTrabajos_UpdatingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.UpdatingCellEventArgs) Handles GridTrabajos.UpdatingCell
        With GridTrabajos
            Select Case e.Column.Key
                Case "CodTrabajo"
                    If Length(e.Value) > 0 Then
                        Dim dvTrabajos As New DataView(CType(GridTrabajos.DataSource, DataView).Table.Copy)
                        Dim f As New Filter
                        f.Add(New StringFilterItem("CodTrabajo", e.Value))
                        If Me.rbtPorNivelTrabajos.Checked Then
                            f.Add(New NumberFilterItem("IDTrabajoPresupPadre", drTrabajos("IDTrabajoPresup")))
                        Else
                            f.Add(New IsNullFilterItem("IDTrabajoPresupPadre", True))
                        End If
                        dvTrabajos.RowFilter = f.Compose(New AdoFilterComposer)
                        If dvTrabajos.Count <> 0 Then
                            e.Cancel = True
                            ExpertisApp.GenerateMessage("Este Trabajo ya existe a ese nivel.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        End If
                    End If
                Case "NoAcumular"
                    If .Row <> -1 Then
                        If e.Value Then
                            If ExpertisApp.GenerateMessage("Si marca esta opción, el Importe Unitario será editable pero no irá acumulando los importes que vaya insertando en las diferentes Conceptos. ", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                                e.Cancel = True
                            End If
                        ElseIf ExpertisApp.GenerateMessage("Al insertar la línea se recalculará el Importe Unitario sumando los totales de los diferentes conceptos.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
                            e.Cancel = True
                        End If
                    End If
            End Select
        End With
    End Sub

    Private Sub GridTrabajos_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridTrabajos.AdvSearchSetPredefinedFilter
        With GridTrabajos
            Select Case e.Key
                Case "CodTrabajoPadre"
                    e.Filter.Add("IDPresup", FilterOperator.Equal, Me.CurrentRow("IDPresup"), FilterType.Numeric)
                    If Length(.Value("IDTrabajoPresup")) > 0 Then e.Filter.Add("IDTrabajoPresup", FilterOperator.NotEqual, .Value("IDTrabajoPresup"), FilterType.Numeric)
                Case "IDTipoTrabajo"
                    e.Filter.Add("IdTipoObra", FilterOperator.Equal, AdvIDTipoObra.Text, FilterType.String)
                Case "IDSubTipoTrabajo"
                    e.Filter.Add("IdTipoObra", FilterOperator.Equal, AdvIDTipoObra.Text, FilterType.String)
                    e.Filter.Add("IDTipoTrabajo", FilterOperator.Equal, GridTrabajos.Value("IDTipoTrabajo") & String.Empty, FilterType.String)
                Case "SubSubTipoTrabajo"
                    e.Filter.Add("IdTipoObra", FilterOperator.Equal, AdvIDTipoObra.Text, FilterType.String)
                    e.Filter.Add("IDTipoTrabajo", FilterOperator.Equal, GridTrabajos.Value("IDTipoTrabajo") & String.Empty, FilterType.String)
                    e.Filter.Add("IDSubTipoTrabajo", FilterOperator.Equal, GridTrabajos.Value("IDSubTipoTrabajo") & String.Empty, FilterType.String)
                Case "IDArticulo"
                    e.Filter.Add(New NumberFilterItem("Activo", FilterOperator.Equal, "1"))
            End Select
        End With
    End Sub

    Private Sub GridTrabajos_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridTrabajos.FormattingRow
        With GridTrabajos
            If e.Row.RowType = RowType.Record Then
                If e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltCapitulo OrElse _
                 e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltPorcentajeConcepto Then
                    'Los trabajos que sean de tipo Capitulo o Porcentaje sólo mostrarán algunos de los valores
                    'del registro. El resto se ocultan. 
                    'Para ello haremos: e.Row.Cells(dc.ColumnName).Text = String.Empty
                    If e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltCapitulo Then
                        e.Row.RowStyle = .FormatStyles("CapituloFormatStyle")
                    ElseIf e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltPorcentajeConcepto Then
                        e.Row.RowStyle = .FormatStyles("IncrementoFormatStyle")
                    End If

                    For Each dc As DataColumn In dtTrabajos.Columns
                        If dc.ColumnName <> "Secuencia" And dc.ColumnName <> "IDTipoTrabajo" And _
                           dc.ColumnName <> "IDSubtipoTrabajo" And dc.ColumnName <> "SubSubTipoTrabajo" And _
                           dc.ColumnName <> "CodTrabajo" And dc.ColumnName <> "DescTrabajo" And _
                           dc.ColumnName <> "TipoLinea" And dc.ColumnName <> "ImpAcumulado" And _
                           dc.ColumnName <> "ImpAcumuladoVenta" And dc.ColumnName <> "Incremento" Then
                            If e.Row.Table.Columns.Contains(dc.ColumnName) Then
                                e.Row.Cells(dc.ColumnName).Text = String.Empty
                            End If
                        ElseIf dc.ColumnName = "Incremento" Then
                            If e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltCapitulo Or Nz(e.Row.Cells(dc.ColumnName).Value, 0) = 0 Then
                                e.Row.Cells(dc.ColumnName).Text = String.Empty
                            End If
                        End If
                    Next
                Else
                    e.Row.Cells("ImpAcumulado").FormatStyle = .FormatStyles("ImpAcumuladoFormatStyle")
                    e.Row.Cells("ImpAcumuladoVenta").FormatStyle = .FormatStyles("ImpAcumuladoFormatStyle")
                    e.Row.Cells("Incremento").Text = String.Empty

                    If e.Row.Cells("TipoLinea").Value = enumTipoLineaTrabajo.tltTrabajoConcepto Then
                        e.Row.RowStyle = .FormatStyles("ConceptoFormatStyle")
                    End If
                End If
            End If
        End With
    End Sub

    Private Sub GridTrabajos_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridTrabajos.MouseUp
        If e.Button = MouseButtons.Right Then
            If cbxEstado.Value <> enumopcEstado.opcAceptado Then
                GridTrabajos.UiCommandManager1.Commands(cnNUEVOTRABAJO).Visible = InheritableBoolean.True
            Else
                GridTrabajos.UiCommandManager1.Commands(cnNUEVOTRABAJO).Visible = InheritableBoolean.False
            End If
        End If
    End Sub

#End Region

    Private Sub chkVerPorcentajes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVerPorcentajes.CheckedChanged
        If Me.RecordsState <> RecordsState.Initialize Then
            RefreshArbolTrabajos()
            If TabTrabajos.SelectedTab.Key = "Trabajos" Then FiltrarGridTrabajos()
        End If
    End Sub

#Region " Arbol Trabajos "

    Private Sub SeleccionarNodoTrabajo(ByVal IDTrabajo As Integer)
        For Each Nd As TreeNode In Me.TvwTrabajos.Nodes
            If CType(Nd.Tag, TagTrabajo).IDTrabajo = IDTrabajo Then
                Me.TvwTrabajos.SelectedNode = Nd
                Exit For
            ElseIf Nd.Nodes.Count > 0 Then
                If GetNode(Nd, IDTrabajo) Then Exit For
            End If
        Next
    End Sub

    Private Function GetNode(ByVal NdGet As TreeNode, ByVal IDTrabajo As Integer) As Boolean
        GetNode = False
        For Each Nd As TreeNode In NdGet.Nodes
            If CType(Nd.Tag, TagTrabajo).IDTrabajo = IDTrabajo Then
                Me.TvwTrabajos.SelectedNode = Nd
                Return True
            ElseIf Nd.Nodes.Count > 0 Then
                GetNode(Nd, IDTrabajo)
            End If
        Next
    End Function

    Private Sub rbtMaximizarTree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMaximizarTree.CheckedChanged
        TvwTrabajos.ExpandAll()
    End Sub

    Private Sub rbtMinimizarTree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtMinimizarTree.CheckedChanged
        TvwTrabajos.CollapseAll()
    End Sub

    Private Sub RefreshArbolTrabajos()
        blnPintarTrabajos = True
        ArbolTrabajos()
    End Sub

    Private Sub ArbolTrabajos()
        If blnPintarTrabajos Then
            If Not ndTrabajos.Data Is Nothing Then
                Dim f As New Filter
                Dim dv As New DataView(dtTrabajos)
                If Not chkVerPorcentajes.Checked Then
                    f.Add(New NumberFilterItem("TipoLinea", FilterOperator.NotEqual, enumTipoLineaTrabajo.tltPorcentajeConcepto))

                    dv.RowFilter = f.Compose(New AdoFilterComposer)
                End If
                dv.Sort = "Secuencia"
                If Not IsNothing(TvwTrabajos) Then
                    TvwTrabajos.Nodes.Clear()
                    TvwTrabajos.Visible = False
                End If
                PintarTrabajos(dv)
                blnPintarTrabajos = False
                TvwTrabajos.Visible = True
                If dv.Count = 0 Then
                    Me.GetDatosTrabajo(Nothing)
                Else
                    Me.GetDatosTrabajo(dv(0).Row)
                End If
            End If
        Else
            drTrabajos = GetdrTrabajos(intTrabajoActual)
            Me.GetDatosTrabajo(drTrabajos)
        End If
    End Sub

    Private Sub PintarTrabajos(ByVal dvTrabajos As DataView, Optional ByVal oNode As TreeNode = Nothing)
        If Not dvTrabajos Is Nothing AndAlso dvTrabajos.Count > 0 Then
            If Not TvwTrabajos.Enabled Then TvwTrabajos.Enabled = True
            TvwTrabajos.ImageList = ImageList1
            For Each drvTrabajo As DataRowView In dvTrabajos
                If IsDBNull(drvTrabajo.Row("IDTrabajoPresupPadre")) Then
                    PintarNodoTrabajo(drvTrabajo.Row, dvTrabajos.Table, oNode)
                End If
            Next
        End If

        If rbtMaximizarTree.Checked Then TvwTrabajos.ExpandAll()
        TvwTrabajos.SelectedNode = TvwTrabajos.TopNode

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PintarNodoTrabajo(ByVal drTrabajo As DataRow, ByVal dtTrabajos As DataTable, _
                                  Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = drTrabajo("CodTrabajo") & String.Empty & " -> " & drTrabajo("DescTrabajo") & String.Empty
        If oNode Is Nothing Then
            oNode = TvwTrabajos.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.Tag = New TagTrabajo(Nz(drTrabajo("IDTrabajoPresup"), 0))
        If Length(drTrabajo("IDTrabajoPresupPadre")) > 0 Then oNode.ForeColor = Color.DarkBlue
        If Length(drTrabajo("TipoLinea")) = 0 Then drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo

        If drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo Then
            If Nz(drTrabajo("ImpPresupQTrabajoA"), 0) = 0 Then
                oNode.ImageIndex = 0
            Else
                oNode.ImageIndex = 3
            End If
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajoConcepto Then
            oNode.ImageIndex = 0
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then
            oNode.ImageIndex = 7
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltPorcentajeConcepto Then
            oNode.ImageIndex = 8
        End If

        oNode.SelectedImageIndex = 6
        oNode.Expand()

        If Length(drTrabajo("IDTrabajoPresup")) > 0 Then
            'pintar sus subtrabajos
            Dim dv As DataView = dtTrabajos.DefaultView
            dv.RowFilter = "IDTrabajoPresupPadre = " & drTrabajo("IDTrabajoPresup")
            dv.Sort = "Secuencia"
            For Each drv As DataRowView In dv
                PintarNodoTrabajo(drv.Row, dtTrabajos, oNode)
            Next
        End If
        oNode = Nothing
    End Sub

    Private Sub TvwTrabajos_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TvwTrabajos.AfterSelect
        e.Node.EnsureVisible()
        If TypeOf e.Node.Tag Is TagTrabajo Then
            drTrabajos = GetdrTrabajos(CType(e.Node.Tag, TagTrabajo).IDTrabajo)
            GetDatosTrabajo(drTrabajos)
            If Not mSeleccionarNodoTrabajoDesdeGrid Then TabTrabajos_Click(TabTrabajos, New EventArgs)
        End If
        intTrabajoActual = 0
        If Not drTrabajos Is Nothing Then
            intTrabajoActual = drTrabajos("IDTrabajoPresup")
        End If
    End Sub

    Private Sub TvwTrabajos_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TvwTrabajos.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim n As TreeNode = TvwTrabajos.GetNodeAt(e.X, e.Y)
            Dim PORCENTAJES As InheritableBoolean = InheritableBoolean.False
            Dim ADDCONCEPTOS As InheritableBoolean = InheritableBoolean.False
            If Not IsNothing(n) Then
                If Not n.IsSelected Then TvwTrabajos.SelectedNode = n
                drTrabajos = GetdrTrabajos(CType(n.Tag, TagTrabajo).IDTrabajo)
                If Not drTrabajos Is Nothing Then
                    If Length(drTrabajos("IDTrabajoPresup")) = 0 Then PORCENTAJES = InheritableBoolean.False

                    If drTrabajos("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo Or drTrabajos("TipoLinea") = enumTipoLineaTrabajo.tltTrabajoConcepto Then
                        Select Case TabTrabajos.SelectedTab.Key
                            Case "Materiales", "Mod", "Centros", "Gastos", "Varios", "Mediciones"
                                ADDCONCEPTOS = InheritableBoolean.True
                        End Select
                    End If
                    If drTrabajos("TipoLinea") = enumTipoLineaTrabajo.tltPorcentajeConcepto Then
                        PORCENTAJES = InheritableBoolean.True
                    End If
                End If
            Else
                TvwTrabajos.SelectedNode = Nothing
                drTrabajos = Nothing
            End If

            If (Length(AdvIDTipoObra.Value) <> 0) AndAlso cbxEstado.Value <> enumopcEstado.opcAceptado AndAlso PORCENTAJES = InheritableBoolean.False AndAlso Not mDenyInsertTrabajos Then
                MnuNuevoTrabajo.Visible = Janus.Windows.UI.InheritableBoolean.True
            Else
                MnuNuevoTrabajo.Visible = Janus.Windows.UI.InheritableBoolean.False
            End If
            If IsNothing(n) AndAlso MnuNuevoTrabajo.Visible = Janus.Windows.UI.InheritableBoolean.True Then
                MnuNuevoTrabajoIncremento.Visible = Janus.Windows.UI.InheritableBoolean.True
            Else
                MnuNuevoTrabajoIncremento.Visible = Janus.Windows.UI.InheritableBoolean.False
            End If
            MnuDeleteIncremento.Visible = PORCENTAJES
            If Me.RecordsState <> RecordsState.Modified Then
                MnuDeleteIncremento.Enabled = Janus.Windows.UI.InheritableBoolean.True
            Else
                MnuDeleteIncremento.Enabled = Janus.Windows.UI.InheritableBoolean.False
            End If
            If Not IsNothing(n) And Length(AdvIDTipoObra.Value) <> 0 And PORCENTAJES = InheritableBoolean.False Then
                MnuGuion.Visible = Janus.Windows.UI.InheritableBoolean.True
            Else
                MnuGuion.Visible = Janus.Windows.UI.InheritableBoolean.False
            End If

            MnuGuion2.Visible = MnuGuion.Visible
            If Not IsNothing(n) Then
                MnuVerFichaTrabajo.Visible = Janus.Windows.UI.InheritableBoolean.True
            Else
                MnuVerFichaTrabajo.Visible = Janus.Windows.UI.InheritableBoolean.False
            End If
            If PORCENTAJES = InheritableBoolean.True Then
                MnuVerFichaTrabajo.Text = ExpertisApp.Traslate("Ver ficha incremento")
            Else
                MnuVerFichaTrabajo.Text = ExpertisApp.Traslate("Ver ficha trabajo")
            End If
            If mDenyDeleteTrabajos Then
                MnuDeleteTrabajo.Visible = Janus.Windows.UI.InheritableBoolean.False
            Else
                MnuDeleteTrabajo.Visible = MnuGuion.Visible
            End If
            MnuDesgloseTrabajo.Visible = MnuGuion.Visible

            If Not IsNothing(n) Then
                MnuADDIncremento.Visible = Janus.Windows.UI.InheritableBoolean.True
            Else
                MnuADDIncremento.Visible = Janus.Windows.UI.InheritableBoolean.False
            End If
            MnuADDIncremento.Enabled = MnuDeleteIncremento.Enabled

            MnuNuevoConcepto.Visible = ADDCONCEPTOS
            If ADDCONCEPTOS = InheritableBoolean.True Then
                MnuNuevoConcepto.Text = ExpertisApp.Traslate("Nuevo Concepto ") & TabTrabajos.SelectedTab.Text
            End If
            MnuGuion4.Visible = MnuADDIncremento.Visible
            MnuGuion3.Visible = MnuNuevoConcepto.Visible

            MenuPresupuestos.Show()
        End If
    End Sub

#Region " Acciones Arbol Trabajos "

    Private Sub NuevoTrabajo(ByVal intIDTrabajo As Integer, ByVal strIDTipoTrabajo As String, _
                                ByVal strIDSubTipoTrabajo As String, ByVal strIDSubSubTipoTrabajo As String, _
                                Optional ByVal blnIncremento As Boolean = False)

        Dim Context As New BusinessData
        Context("FechaIniCab") = Me.CurrentRow("FechaPresup")
        Context("FechaFinCab") = Me.CurrentRow("FechaCierre")

        FiltrarGridTrabajos()
        Dim dv As DataView
        If TypeOf GridTrabajos.DataSource Is DataView Then
            dv = GridTrabajos.DataSource
        Else
            dv = CType(GridTrabajos.DataSource, DataTable).DefaultView
        End If

        Dim dtTrabajosContext As New DataTable
        dtTrabajosContext.Columns.Add("CodTrabajo", GetType(String))
        dtTrabajosContext.Columns.Add("IDTrabajoPresupPadre", GetType(Integer))

        Dim strFiltro As String = String.Empty
        If intIDTrabajo > 0 Then
            Context("PorNivel") = True
            Context("CodTrabajo") = GeneraCodTrabajo(True)
            Context("Filtrar") = True
            Context("IDTrabajoPadre") = intIDTrabajo
            Context("CodTrabajoPadre") = drTrabajos("CodTrabajo")
            Context("QPresupPadre") = drTrabajos("QPresup")
            strFiltro = "IDTrabajoPresupPadre=" & intIDTrabajo
        End If

        Dim dvT As New DataView(dv.Table.Copy)
        dvT.RowFilter = strFiltro
        For Each drv As DataRowView In dvT
            Dim drContext As DataRow = dtTrabajosContext.NewRow
            drContext("CodTrabajo") = drv("CodTrabajo")
            drContext("IDTrabajoPresupPadre") = drv("IDTrabajoPresupPadre")

            dtTrabajosContext.Rows.Add(drContext.ItemArray)
        Next

        Context("dtTrabajos") = dtTrabajosContext
        Context("ViewName") = ndTrabajos.ViewName

        Dim dr As DataRow
        If blnIncremento Then
            Dim frm As New frmAddTrabajosIncremento
            dr = frm.AbrirAltaTrabajos(CurrentRow("IDPresup"), CurrentRow("IDTipoObra"), mstrIDUDMedida, _
                                       txtNumeroPedido.Text, strIDTipoTrabajo, _
                                       strIDSubTipoTrabajo, strIDSubSubTipoTrabajo, intIDTrabajo, _
                                       blnNoAcumular, AdvIDCliente.Text, Context, Me)
        Else
            Dim frm As New FrmAddTrabajos
            dr = frm.AbrirAltaTrabajos(CurrentRow("IDPresup"), CurrentRow("IDTipoObra"), mstrIDUDMedida, _
                                       txtNumeroPedido.Text, strIDTipoTrabajo, _
                                       strIDSubTipoTrabajo, strIDSubSubTipoTrabajo, intIDTrabajo, _
                                       blnNoAcumular, AdvIDCliente.Text, Context, Me.AdvIDMoneda.Text, Me)
        End If
        strIDTipoTrabajo = String.Empty
        strIDSubTipoTrabajo = String.Empty
        intIDTrabajo = 0

        If Not IsNothing(dr) Then
            dr("Secuencia") = (ndTrabajos.Data.Rows.Count + 1) * 10
            ndTrabajos.Data.Rows.Add(dr.ItemArray)
            Me.RecordsState = RecordsState.Modified
            dtTrabajos = ndTrabajos.Data
            Me.pnlFicha.Enabled = True
            RefreshArbolTrabajos()
            FiltrarGridTrabajos()
            TotalTrabajos()
            blnPintarTrabajos = True
        End If
    End Sub
    Private Sub MnuNuevoTrabajo_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuNuevoTrabajo.Click
        If IsNothing(drTrabajos) Then
            NuevoTrabajo(0, String.Empty, String.Empty, String.Empty)
        ElseIf Length(drTrabajos("IDTrabajoPresup")) > 0 Then
            NuevoTrabajo(drTrabajos("IDTrabajoPresup"), drTrabajos("IDTipoTrabajo") & String.Empty, _
                         drTrabajos("IDSubTipoTrabajo") & String.Empty, drTrabajos("SubSubTipoTrabajo") & String.Empty)
        End If
    End Sub

    Private Sub MnuNuevoTrabajoIncremento_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuNuevoTrabajoIncremento.Click
        If IsNothing(drTrabajos) Then
            NuevoTrabajo(0, String.Empty, String.Empty, String.Empty, True)
        ElseIf Length(drTrabajos("IDTrabajoPresup")) > 0 Then
            NuevoTrabajo(drTrabajos("IDTrabajoPresup"), drTrabajos("IDTipoTrabajo") & String.Empty, _
                         drTrabajos("IDSubTipoTrabajo") & String.Empty, drTrabajos("SubSubTipoTrabajo") & String.Empty, True)
        End If
        blnRefreshArbol = True
    End Sub

    Private Sub MnuDeleteTrabajo_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuDeleteTrabajo.Click
        If Not IsNothing(drTrabajos) Then
            If ExpertisApp.GenerateMessage("Se va a borrar el trabajo seleccionado. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                ExpertisApp.ExecuteTask(Of Integer)(AddressOf ObraTrabajoPresup.BorrarTrabajo, drTrabajos("IDTrabajoPresup"))

                Me.Cursor = Cursors.Default
                blnRefreshArbol = True
                RefreshPresup()
            End If
        End If
    End Sub

    Private Sub MnuDeleteIncremento_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuDeleteIncremento.Click
        If Not IsNothing(drTrabajos) Then
            If ExpertisApp.GenerateMessage("Se va a borrar el incremento seleccionado. ¿Desea continuar?.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                ExpertisApp.ExecuteTask(Of Integer)(AddressOf Incrementos.DeletePorcentajesPresupuestos, drTrabajos("IDTrabajoPresup"))

                Me.Cursor = Cursors.Default
                blnRefreshArbol = True
                RefreshPresup()
            End If
        End If
    End Sub

    Private Sub MnuVerFichaTrabajo_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuVerFichaTrabajo.Click
        rbtVerFicha.Checked = True
        TabTrabajos.TabPages("Trabajos").Selected = True
    End Sub

    Private Sub MnuDesgloseTrabajo_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuDesgloseTrabajo.Click
        If Not IsNothing(drTrabajos) Then
            Dim frm As New frmDesgloseImportesTrabajo
            Dim ImpAcumulado, ImpAcumuladoVenta As Double
            If drTrabajos("TipoLinea") = enumTipoLineaTrabajo.tltTrabajoConcepto Then
                ImpAcumulado = Nz(drTrabajos("ImpPresupQTrabajoA"), 0)
                ImpAcumuladoVenta = Nz(drTrabajos("ImpPresupQTrabajoVentaA"), 0)
            Else
                ImpAcumulado = Nz(drTrabajos("ImpAcumulado"), 0)
                ImpAcumuladoVenta = Nz(drTrabajos("ImpAcumuladoVenta"), 0)
            End If
            frm.AbrirDesgloseTrabajo(drTrabajos("IDTrabajoPresup"), ImpAcumulado, ImpAcumuladoVenta)
        End If
    End Sub

    Private Sub MnuADDIncremento_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuADDIncremento.Click
        If Not IsNothing(drTrabajos) Then
            'If Me.RecordsState = RecordsState.Modified Then
            '    SendKeys.Send("{F9}")
            'End If
            Dim frm As New frmAddIncremento
            Dim tipo As frmAddIncremento.AplicarPorcentajeA
            Select Case TabTrabajos.SelectedTab.Key
                Case "Materiales"
                    tipo = frmAddIncremento.AplicarPorcentajeA.apMaterial
                Case "Mod"
                    tipo = frmAddIncremento.AplicarPorcentajeA.apMod
                Case "Centros"
                    tipo = frmAddIncremento.AplicarPorcentajeA.apCentro
                Case Else
                    tipo = frmAddIncremento.AplicarPorcentajeA.apTodos
            End Select
            frm.AbrirADDIncrementos(tipo, drTrabajos)
            blnPintarTrabajos = True
            RefreshPresup()
        End If
    End Sub

#Region " ADD Conceptos "

    Private Sub MnuNuevoConcepto_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles MnuNuevoConcepto.Click
        Select Case TabTrabajos.SelectedTab.Key
            Case "Materiales"
                NuevoMaterial()
            Case "Mod"
                NuevoMOD()
            Case "Centros"
                NuevoCentro()
            Case "Gastos"
                NuevoGasto()
            Case "Varios"
                NuevoVarios()
            Case "Mediciones"
                NuevaMedicion()
        End Select
    End Sub

    Private Sub NuevoMaterial()
        Dim frm As New frmAddMateriales
        Dim dt As DataTable = frm.AbrirAltaMateriales(CurrentRow("IDPresup"), drTrabajos("IDTrabajoPresup"), _
                                                      drTrabajos("CodTrabajo") & String.Empty, drTrabajos("DescTrabajo") & String.Empty, _
                                                      drTrabajos("QPresup"), Nz(Me.CurrentRow("FechaPresup"), cnMinDate), _
                                                      Me.CurrentRow("IDCliente") & String.Empty)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndMateriales.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtPorNivelMat.Checked, GridMateriales, ndMateriales.Data, rbtPorMultinivelMat.Checked)
            TotalesMaterial(GridMateriales, New EventArgs)
        End If
    End Sub

    Private Sub NuevoMOD()
        Dim frm As New frmAddMOD
        Dim dt As DataTable = frm.AbrirAltaMOD(CurrentRow("IDPresup"), drTrabajos("IDTrabajoPresup"), _
                                               drTrabajos("CodTrabajo") & String.Empty, drTrabajos("DescTrabajo") & String.Empty, _
                                               drTrabajos("QPresup"), mstrIDHora, mstrDescHora)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndMOD.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtPorNivelMod.Checked, GridMOD, ndMOD.Data, rbtPorMultinivelMod.Checked)
            TotalesMod(GridMOD, New EventArgs)
        End If
    End Sub

    Private Sub NuevoCentro()
        Dim frm As New frmAddCentros
        Dim dt As DataTable = frm.AbrirAltaCentros(CurrentRow("IDPresup"), drTrabajos("IDTrabajoPresup"), _
                                                   drTrabajos("CodTrabajo") & String.Empty, drTrabajos("DescTrabajo") & String.Empty, _
                                                   drTrabajos("QPresup"))
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndCentros.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtPorNivelCentros.Checked, GridCentros, ndCentros.Data, rbtPorMultinivelCentros.Checked)
            TotalesCentros(GridCentros, New EventArgs)
        End If
    End Sub

    Private Sub NuevoGasto()
        Dim frm As New frmAddGastos
        Dim dt As DataTable = frm.AbrirAltaGastos(CurrentRow("IDPresup"), drTrabajos("IDTrabajoPresup"), _
                                                  drTrabajos("CodTrabajo") & String.Empty, drTrabajos("DescTrabajo") & String.Empty)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndGastos.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtPorNivelGastos.Checked, GridGastos, ndGastos.Data, rbtPorMultinivelGastos.Checked)
            TotalesGastos(GridGastos, New EventArgs)
        End If
    End Sub

    Private Sub NuevoVarios()
        Dim frm As New frmAddVarios
        Dim dt As DataTable = frm.AbrirAltaVarios(CurrentRow("IDPresup"), drTrabajos("IDTrabajoPresup"), _
                                                  drTrabajos("CodTrabajo") & String.Empty, drTrabajos("DescTrabajo") & String.Empty)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndVarios.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtPorNivelVarios.Checked, GridVarios, ndVarios.Data, rbtPorMultinivelVarios.Checked)
            TotalesVarios(GridVarios, New EventArgs)
        End If
    End Sub

    Private Sub NuevaMedicion()
        Dim frm As New frmAddMediciones
        Dim dt As DataTable = frm.AbrirAltaMediciones(CurrentRow("IDPresup"), drTrabajos("IDTrabajoPresup"), _
                                                      drTrabajos("CodTrabajo") & String.Empty, drTrabajos("DescTrabajo") & String.Empty)
        If Not IsNothing(dt) Then
            For Each dr As DataRow In dt.Rows
                ndMediciones.Data.Rows.Add(dr.ItemArray)
            Next
            Me.RecordsState = RecordsState.Modified
            FiltrarGrid(rbtPorNivelMedicion.Checked, GridMediciones, ndMediciones.Data, rbtPorMultinivelMedicion.Checked)
            TotalesMediciones(GridMediciones, New EventArgs)
        End If
    End Sub

#End Region

#End Region

#End Region

#Region " Ficha Trabajo "

    Private Sub chkNoAcumular_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNoAcumular.CheckedChanged
        txtImpUnitario.Enabled = chkNoAcumular.Checked
        txtMargenTrabajoFicha.Enabled = chkNoAcumular.Checked
        txtImpUnitarioVta.Enabled = chkNoAcumular.Checked
    End Sub

    Private Sub AdvTipoTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvTipoTrabajo.SetPredefinedFilter
        If Length(AdvIDTipoObra.Value) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoObra", AdvIDTipoObra.Value))
        End If
    End Sub

    Private Sub AdvTipoTrabajo_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvTipoTrabajo.SelectionChanged
        If Length(AdvTipoTrabajo.Text) > 0 Then
            AdvSubTipoTrabajo.Text = String.Empty
            txtDescTrabajo.Text = e.Selected.Rows(0)("DescTipoTrabajo") & String.Empty
        End If
        txtCodTrabajo.Text = AdvTipoTrabajo.Text & AdvSubTipoTrabajo.Text
    End Sub

    Private Sub AdvSubTipoTrabajo_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvSubTipoTrabajo.SetPredefinedFilter
        If Length(AdvIDTipoObra.Value) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoObra", AdvIDTipoObra.Value))
        End If
        If Length(AdvTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoTrabajo", AdvTipoTrabajo.Text))
        End If
    End Sub

    Private Sub AdvSubTipoTrabajo_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvSubTipoTrabajo.SelectionChanged
        If Length(AdvSubTipoTrabajo.Text) > 0 Then
            AdvSubSubTipoTrabajo.Text = String.Empty
            Dim intPos As Integer = InStr(txtDescTrabajo.Text, "-")
            If intPos > 0 Then txtDescTrabajo.Text = Mid$(txtDescTrabajo.Text, 1, intPos - 1)
            txtDescTrabajo.Text = txtDescTrabajo.Text & "-" & e.Selected.Rows(0)("DescSubTipoTrabajo") & String.Empty
            txtCodTrabajo.Text = AdvTipoTrabajo.Text & AdvSubTipoTrabajo.Text
        End If
    End Sub

    Private Sub AdvSubSubTipoTrabajo_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvSubSubTipoTrabajo.SetPredefinedFilter
        If Length(AdvIDTipoObra.Value) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoObra", AdvIDTipoObra.Value))
        End If
        If Length(AdvTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDTipoTrabajo", AdvTipoTrabajo.Text))
        End If
        If Length(AdvSubTipoTrabajo.Text) > 0 Then
            e.Filter.Add(New StringFilterItem("IDSubTipoTrabajo", AdvSubTipoTrabajo.Text))
        End If
    End Sub

    Private Sub txtImpUnitario_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImpUnitario.Validated
        Dim t As New ObraTrabajoPresup
        Dim d As New BusinessData(drTrabajos)
        d = t.ApplyBusinessRule("ImpPresupTrabajoA", txtImpUnitario.Value, d)
        txtMargenTrabajoFicha.Value = d("MargenTrabajo")
        txtImpUnitarioVta.Value = d("ImpPresupTrabajoVentaA")
    End Sub

    Private Sub txtImpUnitarioVta_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImpUnitarioVta.Validated
        Dim t As New ObraTrabajoPresup
        Dim d As New BusinessData(drTrabajos)
        d = t.ApplyBusinessRule("ImpPresupTrabajoVentaA", txtImpUnitarioVta.Value, d)
        txtImpUnitario.Value = d("ImpPresupTrabajoA")
        txtMargenTrabajoFicha.Value = d("MargenTrabajo")
    End Sub

    Private Sub txtMargenTrabajoFicha_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMargenTrabajoFicha.Validated
        Dim t As New ObraTrabajoPresup
        Dim d As New BusinessData(drTrabajos)
        d = t.ApplyBusinessRule("MargenTrabajo", txtMargenTrabajoFicha.Value, d)
        txtImpUnitario.Value = d("ImpPresupTrabajoA")
        txtImpUnitarioVta.Value = d("ImpPresupTrabajoVentaA")
    End Sub

#End Region

    Private Sub rbtVerFicha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtVerFicha.CheckedChanged
        pnlFicha.Visible = rbtVerFicha.Checked
        pnlTrabajosCompleto.Visible = rbtVerPresupuestoCompleto.Checked
        pnlGridTrabajo.Visible = rbtVerGrid.Checked

        If rbtVerFicha.Checked Then VerFormatoFicha()
        TabTrabajos.TabPages("Trabajos").Selected = True
        CamposNoEditables()
    End Sub

    Private Sub rbtVerGrid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtVerGrid.CheckedChanged
        pnlFicha.Visible = rbtVerFicha.Checked
        pnlTrabajosCompleto.Visible = rbtVerPresupuestoCompleto.Checked
        pnlGridTrabajo.Visible = rbtVerGrid.Checked

        If rbtVerGrid.Checked Then VerFormatoGrid()
        TabTrabajos.TabPages("Trabajos").Selected = True
    End Sub

    Private Sub rbtVerProyectoCompleto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtVerPresupuestoCompleto.CheckedChanged
        pnlFicha.Visible = rbtVerFicha.Checked
        pnlTrabajosCompleto.Visible = rbtVerPresupuestoCompleto.Checked
        pnlGridTrabajo.Visible = rbtVerGrid.Checked

        If rbtVerPresupuestoCompleto.Checked Then VerDatosTrabajoCompleto()
        TabTrabajos.TabPages("Trabajos").Selected = True
    End Sub

    Private Sub cbxTipoLinea_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxTipoLinea.ValueChanged
        txtIncremento.Visible = Length(cbxTipoLinea.Value) > 0 AndAlso cbxTipoLinea.Value = enumTipoLineaTrabajo.tltPorcentajeConcepto
        lblIncremento.Visible = txtIncremento.Visible
    End Sub

#Region " Arbol trabajo completo "

    Private Enum IconIndex
        oObra = 0
        oTrabajos = 1
        oMateriales = 2
        oMod = 3
        oCentros = 4
        oGastos = 5
        oVarios = 6
        oMediciones = 7
        oCapitulos = 8
        oPorcentajes = 9
        oSubcapitulo = 10
    End Enum

    Private Sub VerDatosTrabajoCompleto()
        If Not drTrabajos Is Nothing AndAlso Length(drTrabajos("IDTrabajoPresup")) > 0 Then
            'Dim Cancel As Boolean = False
            'If TvwObraCompleta.Nodes.Count > 0 Then
            '    If ExpertisApp.GenerateMessage("¿Desea refrescar el árbol de la estructura completa del trabajo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            '        Cancel = True
            '    End If
            'End If
            'If Not Cancel Then
            TvwObraCompleta.Nodes.Clear()
            Me.Cursor = Cursors.WaitCursor
            TvwObraCompleta.ImageList = ImageListTrabajoCompleto
            PintarTrabajoCompleto(drTrabajos, Nothing)
            TvwObraCompleta.SelectedNode = TvwObraCompleta.TopNode
            Me.Cursor = Cursors.Default
            'End If
        End If
    End Sub

#Region " Trabajos "

    Private Sub PintarTrabajoCompleto(ByVal drTrabajos As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtTrabajos Is Nothing AndAlso dtTrabajos.Rows.Count > 0 Then
            If Not TvwObraCompleta.Enabled Then TvwObraCompleta.Enabled = True
            PintarNodoTrabajoCompleto(drTrabajos, dtTrabajos, oNode)
        End If

        TvwObraCompleta.ExpandAll()
        TvwObraCompleta.Refresh()

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PintarNodoTrabajoCompleto(ByVal drTrabajo As DataRow, ByVal dtTrabajos As DataTable, _
                                          Optional ByVal oNode As TreeNode = Nothing)

        Const cnTRUNCATE As Integer = 75

        Dim strText As String = drTrabajo("CodTrabajo") & " -> " & drTrabajo("DescTrabajo")
        If Len(strText) > cnTRUNCATE Then
            strText = Strings.Left(strText, cnTRUNCATE)
        Else
            strText = strText + Space(cnTRUNCATE - Len(strText))
        End If
        Dim ImpTotal As Double

        If drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo Or drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then

            ImpTotal = drTrabajo("ImpAcumuladoVenta")
        Else
            ImpTotal = drTrabajo("ImpPresupQTrabajoVentaA")

        End If

        'Dim strImportes As String = Format(drTrabajo("ImpAcumulado"), "#,##0.00") & Space(5) & Format(drTrabajo("ImpAcumuladoVenta"), "#,##0.00")
        Dim strImportes As String
        If drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then
            strImportes = "  Importe: " & Format(ImpTotal, "#,##0.00")
        Else
            strImportes = "Precio: " & Format(drTrabajo("ImpPresupTrabajoVentaA"), "#,##0.00") & " Ctd: " & Format(drTrabajo("QPresup"), "#,##0.00") & " Importe: " & Format(drTrabajo("ImpPresupQTrabajoVentaA"), "#,##0.00") & Space(5)
        End If
        strText = strText & Space(5) & strImportes
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If

        If drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajo Then
            oNode.ImageIndex = IconIndex.oTrabajos
            If Nz(drTrabajo("ImpPresupQTrabajoA"), 0) = 0 Then
                oNode.ImageIndex = IconIndex.oSubcapitulo
                'Else
                '    If drTrabajo("Concepto") = 0 Then
                '        oNode.ImageIndex = IconIndex.oTrabajos
                '    Else
                '        oNode.ImageIndex = 10
                '    End If
            End If
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltTrabajoConcepto Then
            oNode.ImageIndex = 10
            ' oNode.BackColor = Color.FromArgb(255, 100, 128) 'Color.Yellow 
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltCapitulo Then
            oNode.ImageIndex = IconIndex.oCapitulos
            oNode.BackColor = Color.FromArgb(255, 255, 128) 'Color.Yellow 
        ElseIf drTrabajo("TipoLinea") = enumTipoLineaTrabajo.tltPorcentajeConcepto Then
            oNode.ImageIndex = IconIndex.oPorcentajes
            oNode.BackColor = Color.FromArgb(255, 192, 128) 'Color.Orange
        End If
        oNode.SelectedImageIndex = oNode.ImageIndex

        Dim Where As String = New NumberFilterItem("IDTrabajoPresup", drTrabajo("IDTrabajoPresup")).Compose(New AdoFilterComposer)
        PintarMateriales(ndMateriales.Data.Copy.Select(Where), oNode)
        PintarMOD(ndMOD.Data.Copy.Select(Where), oNode)
        PintarCentros(ndCentros.Data.Copy.Select(Where), oNode)
        PintarGastos(ndGastos.Data.Copy.Select(Where), oNode)
        PintarVarios(ndVarios.Data.Copy.Select(Where), oNode)
        PintarMediciones(ndMediciones.Data.Copy.Select(Where), oNode)

        'pintar sus subtrabajos
        Where = New NumberFilterItem("IDTrabajoPresupPadre", drTrabajo("IDTrabajoPresup")).Compose(New AdoFilterComposer)
        For Each drHijos As DataRow In ndTrabajos.Data.Copy.Select(Where, "secuencia")
            PintarNodoTrabajoCompleto(drHijos, dtTrabajos, oNode)
        Next

        oNode = Nothing
    End Sub

#End Region

#Region " Materiales "
    Private Sub PintarMateriales(ByVal drMateriales() As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not drMateriales Is Nothing AndAlso drMateriales.Length > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("MATERIALES"))
            oNode.ImageIndex = IconIndex.oMateriales
            oNode.SelectedImageIndex = IconIndex.oMateriales
            For Each drMaterial As DataRow In drMateriales
                Dim strText As String = "Artículo: " & drMaterial("IDMaterial") & " - " & drMaterial("DescMaterial") _
                & String.Empty & " Precio: " & Format(drMaterial("PrecioVentaA"), "#,##0.00") _
                & String.Empty & " Ctd.UD: " & Format(drMaterial("QUnidad"), "#,##0.00") _
                & String.Empty & " Importe UD: " & Format(drMaterial("QUnidad") * drMaterial("PrecioVentaA"), "#,##0.00") _
                & String.Empty & " Ctd.: " & Format(drMaterial("QPresup"), "#,##0.00") _
                & String.Empty & " Importe: " & Format(drMaterial("QPresup") * drMaterial("PrecioVentaA"), "#,##0.00")

                PintarNodoMaterial(strText, oNode)
            Next
        End If

    End Sub

    Private Sub PintarNodoMaterial(ByVal strIDMaterial As String, ByVal strDescMaterial As String, ByVal dblQPresup As Double, _
                                   Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Artículo: " & strIDMaterial & " - " & strDescMaterial & "  Cantidad Total: " & dblQPresup
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMateriales
        oNode.SelectedImageIndex = IconIndex.oMateriales

        oNode = Nothing
    End Sub
    Private Sub PintarNodoMaterial(ByVal strText As String, Optional ByVal oNode As TreeNode = Nothing)

        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMateriales
        oNode.SelectedImageIndex = IconIndex.oMateriales

        oNode = Nothing
    End Sub
#End Region

#Region " MOD "
    Private Sub PintarMOD(ByVal dtMOD() As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtMOD Is Nothing AndAlso dtMOD.Length > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("MOD"))
            oNode.ImageIndex = IconIndex.oMod
            oNode.SelectedImageIndex = IconIndex.oMod
            For Each drMOD As DataRow In dtMOD
                Dim strText As String = "Categoría: " & drMOD("IDCategoria") & " - " & drMOD("DescCategoria") & "  Tipo Hora: " & drMOD("DescHora") _
                & String.Empty & " Precio: " & Format(drMOD("PrecioVentaA"), "#,##0.00") _
                & String.Empty & " Ctd.UD: " & Format(drMOD("HorasUnidad"), "#,##0.00") _
                & String.Empty & " Importe UD: " & Format(drMOD("HorasUnidad") * drMOD("PrecioVentaA"), "#,##0.00") _
                & String.Empty & " Ctd.: " & Format(drMOD("HorasPresupMod"), "#,##0.00") _
                & String.Empty & " Importe: " & Format(drMOD("HorasPresupMod") * drMOD("PrecioVentaA"), "#,##0.00")
                PintarNodoMOD(strText, oNode)
            Next
            oNode = Nothing
        End If

    End Sub
    Private Sub PintarNodoMOD(ByVal strText As String, Optional ByVal oNode As TreeNode = Nothing)


        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMod
        oNode.SelectedImageIndex = IconIndex.oMod

        oNode = Nothing
    End Sub
    Private Sub PintarNodoMOD(ByVal strIDCategoria As String, _
                              ByVal strDescCategoria As String, ByVal strDescHora As String, _
                              Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Categoría: " & strIDCategoria & " - " & strDescCategoria & "  Tipo Hora: " & strDescHora
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMod
        oNode.SelectedImageIndex = IconIndex.oMod

        oNode = Nothing
    End Sub
#End Region

#Region " Centros "
    Private Sub PintarCentros(ByVal dtCentros() As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtCentros Is Nothing AndAlso dtCentros.Length > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("CENTROS"))
            oNode.ImageIndex = IconIndex.oCentros
            oNode.SelectedImageIndex = IconIndex.oCentros
            For Each drCentros As DataRow In dtCentros
                Dim strText As String = "Centro: " & drCentros("IDCentro") & " - " & drCentros("DescCentro") _
                   & String.Empty & " Ctd.UD: " & Format(drCentros("HorasUnidad"), "#,##0.00") _
                & String.Empty & " Precio: " & Format(drCentros("PrecioVentaA"), "#,##0.00") _
                & String.Empty & " Ctd.: " & Format(drCentros("HorasPresupCentro"), "#,##0.00") _
                & String.Empty & " Importe: " & Format(drCentros("HorasPresupCentro") * drCentros("PrecioVentaA"), "#,##0.00")
                PintarNodoCentros(strText, oNode)
            Next
            oNode = Nothing
        End If
    End Sub
    Private Sub PintarNodoCentros(ByVal strText As String, _
                                Optional ByVal oNode As TreeNode = Nothing)


        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oCentros
        oNode.SelectedImageIndex = IconIndex.oCentros

        oNode = Nothing
    End Sub
    Private Sub PintarNodoCentros(ByVal strIDCentro As String, ByVal strDescCentro As String, _
                                  Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Centro: " & strIDCentro & " - " & strDescCentro
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oCentros
        oNode.SelectedImageIndex = IconIndex.oCentros

        oNode = Nothing
    End Sub
#End Region

#Region " Gastos "
    Private Sub PintarGastos(ByVal dtGastos() As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtGastos Is Nothing AndAlso dtGastos.Length > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("GASTOS"))
            oNode.ImageIndex = IconIndex.oGastos
            oNode.SelectedImageIndex = IconIndex.oGastos
            For Each drGastos As DataRow In dtGastos
                Dim strText As String = "Gasto: " & drGastos("IDGasto") & " - " & drGastos("DescGasto") _
                & String.Empty & " Importe: " & Format(drGastos("ImpPresupGastoVentaA"), "#,##0.00")
                If drGastos("AplicarQ") Then
                    strText = strText & "  Aplicar cantidad"
                End If
                PintarNodoGastos(strText, oNode)
            Next
            oNode = Nothing
        End If
    End Sub
    Private Sub PintarNodoGastos(ByVal strText As String, Optional ByVal oNode As TreeNode = Nothing)


        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oGastos
        oNode.SelectedImageIndex = IconIndex.oGastos

        oNode = Nothing
    End Sub
    Private Sub PintarNodoGastos(ByVal strIDGasto As String, ByVal strDescGasto As String, _
                                 Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Gasto: " & strIDGasto & " - " & strDescGasto
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oGastos
        oNode.SelectedImageIndex = IconIndex.oGastos

        oNode = Nothing
    End Sub
#End Region

#Region " Varios "
    Private Sub PintarVarios(ByVal dtVarios() As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtVarios Is Nothing AndAlso dtVarios.Length > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("VARIOS"))
            oNode.ImageIndex = IconIndex.oVarios
            oNode.SelectedImageIndex = IconIndex.oVarios
            For Each drVarios As DataRow In dtVarios
                Dim strText As String = "Varios: " & drVarios("IDVarios") & " - " & drVarios("DescVarios") _
                & String.Empty & " Importe: " & Format(drVarios("ImpPresupVariosVentaA"), "#,##0.00")
                If drVarios("AplicarQ") Then
                    strText = strText & "  Aplicar cantidad"
                End If

                PintarNodoVarios(strText, oNode)
            Next
            oNode = Nothing
        End If
    End Sub
    Private Sub PintarNodoVarios(ByVal strText As String, Optional ByVal oNode As TreeNode = Nothing)


        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oVarios
        oNode.SelectedImageIndex = IconIndex.oVarios

        oNode = Nothing
    End Sub
    Private Sub PintarNodoVarios(ByVal strIDVarios As String, ByVal strDescVarios As String, _
                                 Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Varios: " & strIDVarios & " - " & strDescVarios
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oVarios
        oNode.SelectedImageIndex = IconIndex.oVarios

        oNode = Nothing
    End Sub
#End Region

#Region " Mediciones "
    Private Sub PintarMediciones(ByVal dtMedicion() As DataRow, Optional ByVal oNode As TreeNode = Nothing)
        If Not dtMedicion Is Nothing AndAlso dtMedicion.Length > 0 Then
            oNode = oNode.Nodes.Add(ExpertisApp.Traslate("MEDICIONES"))
            oNode.ImageIndex = IconIndex.oMediciones
            oNode.SelectedImageIndex = IconIndex.oMediciones
            For Each drMedicion As DataRow In dtMedicion
                PintarNodoMediciones(drMedicion("DescMedicion") & String.Empty, Nz(drMedicion("QPI"), 0), Nz(drMedicion("Largo"), 0), _
                                     Nz(drMedicion("Ancho"), 0), Nz(drMedicion("Alto"), 0), Nz(drMedicion("Total"), 0), oNode)
            Next
            oNode = Nothing
        End If
    End Sub

    Private Sub PintarNodoMediciones(ByVal strDescMedicion As String, ByVal dblQPI As Double, ByVal dblLargo As Double, ByVal dblAncho As Double, _
                                     ByVal dblAlto As Double, ByVal dblTotal As Double, Optional ByVal oNode As TreeNode = Nothing)

        Dim strText As String = "Descripción: " & strDescMedicion & " PI: " & dblQPI & " LARGO: " & dblLargo & " ANCHO: " & dblAncho & " ALTO: " & dblAlto & " TOTAL: " & dblTotal
        If oNode Is Nothing Then
            oNode = TvwObraCompleta.Nodes.Add(strText)
        Else
            oNode = oNode.Nodes.Add(strText)
        End If
        oNode.ImageIndex = IconIndex.oMediciones
        oNode.SelectedImageIndex = IconIndex.oMediciones

        oNode = Nothing
    End Sub
#End Region

#End Region

    Private Sub TabTrabajos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabTrabajos.Click
        Dim blnVerTrabajoChecked As Boolean

        Select Case TabTrabajos.SelectedTab.Key
            Case "Trabajos"
                If rbtVerGrid.Checked Then
                    VerFormatoGrid()
                ElseIf rbtVerFicha.Checked Then
                    VerFormatoFicha()
                Else
                    VerFormatoTrabajoCompleto()
                End If
            Case "Materiales"
                blnVerTrabajoChecked = rbtPorNivelMat.Checked
                FiltrarGrid(blnVerTrabajoChecked, GridMateriales, ndMateriales.Data, rbtPorMultinivelMat.Checked)
                TotalesMaterial(GridMateriales, New EventArgs)
            Case "Mod"
                blnVerTrabajoChecked = rbtPorNivelMod.Checked
                FiltrarGrid(blnVerTrabajoChecked, GridMOD, ndMOD.Data, rbtPorMultinivelMod.Checked)
                TotalesMod(GridMOD, New EventArgs)
            Case "Centros"
                blnVerTrabajoChecked = rbtPorNivelCentros.Checked
                FiltrarGrid(blnVerTrabajoChecked, GridCentros, ndCentros.Data, rbtPorMultinivelCentros.Checked)
                TotalesCentros(GridCentros, New EventArgs)
            Case "Gastos"
                blnVerTrabajoChecked = rbtPorNivelGastos.Checked
                FiltrarGrid(blnVerTrabajoChecked, GridGastos, ndGastos.Data, rbtPorMultinivelGastos.Checked)
                TotalesGastos(GridGastos, New EventArgs)
            Case "Varios"
                blnVerTrabajoChecked = rbtPorNivelVarios.Checked
                FiltrarGrid(blnVerTrabajoChecked, GridVarios, ndVarios.Data, rbtPorMultinivelVarios.Checked)
                TotalesVarios(GridVarios, New EventArgs)
            Case "Mediciones"
                blnVerTrabajoChecked = rbtPorNivelMedicion.Checked
                FiltrarGrid(blnVerTrabajoChecked, GridMediciones, ndMediciones.Data, rbtPorMultinivelMedicion.Checked)
                TotalesMediciones(GridMediciones, New EventArgs)
        End Select
    End Sub

    Private Sub VerFormatoGrid()
        BloquearGridTrabajo()
        FiltrarGridTrabajos()
        TotalTrabajos()
    End Sub

    Private Sub VerFormatoFicha()
        cbxTipoLinea_ValueChanged(cbxTipoLinea, New EventArgs)
        BloquearFichaTrabajo()
    End Sub

    Private Sub VerFormatoTrabajoCompleto()
        Dim Cancel As Boolean = False
        If TvwObraCompleta.Nodes.Count > 0 Then
            If ExpertisApp.GenerateMessage("¿Desea refrescar el árbol de la estructura completa del trabajo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Cancel = True
            End If
        End If
        If Not Cancel Then VerDatosTrabajoCompleto()
    End Sub

    Private Sub ChangeDefaultViewGrid(ByVal blnPorTrabajo As Boolean, ByVal GridAux As Solmicro.Expertis.Engine.UI.Grid)
        Dim blnQPresup As Boolean
        Select Case TabTrabajos.SelectedTab.Key()
            Case "Materiales", "Mod", "Centros"
                blnQPresup = True
        End Select
        If blnPorTrabajo AndAlso Not IsNothing(drTrabajos) AndAlso Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Then
            If Length(drTrabajos("IDTrabajoPresup")) > 0 Then GridAux.Columns("IDTrabajoPresup").DefaultValue = drTrabajos("IDTrabajoPresup")
            If Length(drTrabajos("CodTrabajo")) > 0 Then GridAux.Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            If blnQPresup AndAlso Length(drTrabajos("QPresup")) > 0 Then GridAux.Columns("QPresupTrabajo").DefaultValue = drTrabajos("QPresup")
        Else
            GridAux.Columns("IDTrabajoPresup").DefaultValue = DBNull.Value
            GridAux.Columns("CodTrabajo").DefaultValue = DBNull.Value
            If blnQPresup Then GridAux.Columns("QPresupTrabajo").DefaultValue = DBNull.Value
        End If
    End Sub

    Private Sub BloquearFichaTrabajo()
        If rbtVerFicha.Checked Then
            Dim blnBloqueado As Boolean = cbxEstado.Value = (enumopcEstado.opcAceptado Or cbxEstado.Value = enumopcEstado.opcRechazado)
            BloquearInformacion(TabPageTrabajos, blnBloqueado, rbtPorNivelTrabajos, rbtPorMultinivelTrabajos, rbtPresupTrabajos)
            chkNoAcumular_CheckedChanged(chkNoAcumular, New EventArgs)
            txtPresupTrabajo.Enabled = False
            txtPresupVentaTrabajo.Enabled = False
        End If
    End Sub

    Private Sub BloquearGridTrabajo()
        If mDenyInsertTrabajos OrElse Length(AdvIDTipoObra.Value) = 0 OrElse cbxEstado.Value = enumopcEstado.opcAceptado OrElse cbxEstado.Value = enumopcEstado.opcRechazado Then
            GridTrabajos.AllowAddNew = InheritableBoolean.False
        Else
            GridTrabajos.AllowAddNew = InheritableBoolean.True
        End If
        GridTrabajos.AllowDelete = InheritableBoolean.False
    End Sub

#Region " Filtrar Grid "

    Private Sub FiltrarGridTrabajos()
        If Me.RecordsState <> RecordsState.Initialize Then
            Dim dv As New DataView(dtTrabajos)
            Dim f As New Filter
            If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
                If Not IsNothing(drTrabajos) Then
                    If Not chkVerPorcentajes.Checked Then
                        f.Add(New NumberFilterItem("TipoLinea", FilterOperator.NotEqual, enumTipoLineaTrabajo.tltPorcentajeConcepto))
                    End If
                    If rbtPorNivelTrabajos.Checked AndAlso Length(drTrabajos("IDTrabajoPresup")) > 0 Then
                        f.Add(New NumberFilterItem("IDTrabajoPresupPadre", drTrabajos("IDTrabajoPresup")))
                    ElseIf rbtPorMultinivelTrabajos.Checked Then
                        If mblnAplicarMultinivel Then
                            If Length(drTrabajos("Hijos")) > 0 Then
                                f.Add(New InListFilterItem("IDTrabajoPresup", Split(drTrabajos("Hijos"), ",", ), FilterType.Numeric))
                            Else
                                f.Add("1", FilterOperator.Equal, "2")
                            End If
                        Else
                            If Length(drTrabajos("IDTrabajoPresup")) > 0 Then f.Add(New NumberFilterItem("IDTrabajoPresup", FilterOperator.NotEqual, drTrabajos("IDTrabajoPresup")))
                            If Length(drTrabajos("IDTipoTrabajo")) > 0 Then f.Add(New StringFilterItem("IDTipoTrabajo", drTrabajos("IDTipoTrabajo")))
                            If Length(drTrabajos("IDSubTipoTrabajo")) > 0 Then f.Add(New StringFilterItem("IDSubTipoTrabajo", drTrabajos("IDSubTipoTrabajo")))
                            If Length(drTrabajos("SubSubTipoTrabajo")) > 0 Then f.Add(New StringFilterItem("SubsubTipoTrabajo", drTrabajos("SUbSubTipoTrabajo")))
                        End If
                    End If
                End If
                Dim strWhere As String = f.Compose(New AdoFilterComposer)
                dv.RowFilter = strWhere
                dv.Sort = "Secuencia, CodTrabajo"
                GridTrabajos.DataSource = dv
            Else
                f.Add(New NumberFilterItem("IDPresup", Me.CurrentRow("IDPresup")))
                dv.RowFilter = f.Compose(New AdoFilterComposer)
                GridTrabajos.DataSource = dv
            End If
            If rbtPorNivelTrabajos.Checked Then GridTrabajos_GotFocus(GridTrabajos, New EventArgs)
        End If
    End Sub

    Private Sub FiltrarGrid(ByVal blnPorTrabajo As Boolean, _
                            ByVal GridAux As Solmicro.Expertis.Engine.UI.Grid, _
                            ByVal dtConcepto As DataTable, _
                            Optional ByVal blnPorMultiNivelTrabajo As Boolean = False)

        If Me.RecordsState <> RecordsState.Initialize Then
            Dim dv As New DataView(dtConcepto)
            Dim f As New Filter
            If Not IsNothing(dtConcepto) AndAlso dtConcepto.Rows.Count > 0 Then
                Dim blnIncrementos As Boolean = False
                Select Case TabTrabajos.SelectedTab.Key
                    Case "Materiales", "Mod", "Centros"
                        blnIncrementos = True
                End Select

                If Not chkVerPorcentajes.Checked And blnIncrementos Then
                    f.Add(New NumberFilterItem("TipoIncremento", FilterOperator.NotEqual, enumSiNo.Si))
                End If
                If Not drTrabajos Is Nothing Then
                    If blnPorTrabajo AndAlso Length(drTrabajos("IDTrabajoPresup")) > 0 Then
                        f.Add(New NumberFilterItem("IDTrabajoPresup", drTrabajos("IDTrabajoPresup")))
                    ElseIf blnPorMultiNivelTrabajo Then
                        If mblnAplicarMultinivel Then
                            If Length(drTrabajos("Hijos")) > 0 Then
                                f.UnionOperator = FilterUnionOperator.Or
                                f.Add(New NumberFilterItem("IDTrabajoPresup", drTrabajos("IDTrabajoPresup")))
                                f.Add(New InListFilterItem("IDTrabajoPresup", Split(drTrabajos("Hijos"), ",", ), FilterType.Numeric))
                            Else
                                f.Add(New NumberFilterItem("IDTrabajoPresup", drTrabajos("IDTrabajoPresup")))
                            End If
                        Else
                            If Length(drTrabajos("IDTrabajoPresup")) > 0 Then f.Add(New NumberFilterItem("IDTrabajoPresup", FilterOperator.NotEqual, drTrabajos("IDTrabajoPresup")))
                            If Length(drTrabajos("IDTipoTrabajo")) > 0 Then f.Add(New StringFilterItem("IDTipoTrabajo", drTrabajos("IDTipoTrabajo")))
                            If Length(drTrabajos("IDSubTipoTrabajo")) > 0 Then f.Add(New StringFilterItem("IDSubTipoTrabajo", drTrabajos("IDSubTipoTrabajo")))
                            If Length(drTrabajos("SubSubTipoTrabajo")) > 0 Then f.Add(New StringFilterItem("SubsubTipoTrabajo", drTrabajos("SUbSubTipoTrabajo")))
                        End If
                    End If
                End If

                Dim strWhere As String = f.Compose(New AdoFilterComposer)
                dv.RowFilter = strWhere
                If blnIncrementos Then
                    dv.Sort = "Secuencia, CodTrabajo"
                Else
                    dv.Sort = "CodTrabajo"
                End If

                GridAux.DataSource = dv
            Else
                f.Add(New NumberFilterItem("IDPresup", Me.CurrentRow("IDPresup")))
                dv.RowFilter = f.Compose(New AdoFilterComposer)
                GridAux.DataSource = dv

                Dim blnEnabled As Boolean = IsNothing(dtTrabajos) OrElse dtTrabajos.Rows.Count = 0
                GridAux.AllowAddNew = IIf(blnEnabled, InheritableBoolean.False, InheritableBoolean.True)
            End If
            ChangeDefaultViewGrid(blnPorTrabajo, GridAux)
        End If
    End Sub

#End Region

#Region " Search TipoIncremento "

    Private Sub OpenSearchTipoIncremento()
        If IsNothing(sctTipoIncremento) Then
            sctTipoIncremento = New AdvancedSearch
            sctTipoIncremento.EntityName = "ObraTrabajoPresup"
        End If
        sctTipoIncremento.Open()
    End Sub

    Private Sub sctTipoIncremento_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles sctTipoIncremento.SetPredefinedFilter
        If Length(Me.CurrentRow("IDPresup")) > 0 Then
            e.Filter.Add(New NumberFilterItem("IDPresup", Me.CurrentRow("IDPresup")))
        Else
            e.Filter.Add(New StringFilterItem("1", 2))
        End If
        e.Filter.Add(New NumberFilterItem("TipoLinea", enumTipoLineaTrabajo.tltPorcentajeConcepto))
    End Sub

    Private Sub sctTipoIncremento_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles sctTipoIncremento.SelectionChanged
        Dim grid As Expertis.Engine.UI.Grid
        Select Case TabTrabajos.SelectedTab.Key
            Case "Materiales"
                grid = GridMateriales
                grid.SetValue("DescMaterial", e.Selected.Rows(0)("DescTrabajo"))
                grid.SetValue("QUnidad", 1)
                grid.SetValue("QPresup", 1)
            Case "Mod"
                grid = GridMOD
                grid.SetValue("DescCategoria", e.Selected.Rows(0)("DescTrabajo"))
                grid.SetValue("HorasUnidad", 1)
                grid.SetValue("HorasPresupMod", 1)
            Case "Centros"
                grid = GridCentros
                grid.SetValue("DescCentro", e.Selected.Rows(0)("DescTrabajo"))
                grid.SetValue("HorasUnidad", 1)
                grid.SetValue("HorasPresupCentro", 1)
        End Select
        grid.SetValue("IDTrabajoIncremento", e.Selected.Rows(0)("IDTrabajoPresup"))
        grid.SetValue("Incremento", e.Selected.Rows(0)("ImpPresupTrabajoA") * 100)
        grid.SetValue("TipoIncremento", enumSiNo.Si)
    End Sub

#End Region

    Private Function ValidaADDIncrementos(ByVal Grid As Solmicro.Expertis.Engine.UI.Grid) As Boolean
        Dim blnCancel As Boolean
        Dim dv As DataView
        Select Case Grid.EntityName
            Case ndMateriales.EntityName
                dv = (ndMateriales.Data.Copy.DefaultView)
            Case ndMOD.EntityName
                dv = (ndMOD.Data.Copy.DefaultView)
            Case ndCentros.EntityName
                dv = (ndCentros.Data.Copy.DefaultView)
        End Select

        Dim f As New Filter
        f.Add(New NumberFilterItem("IDTrabajoPresup", Grid.Value("IDTrabajoPresup")))
        f.Add(New BooleanFilterItem("TipoIncremento", True))
        f.Add(New NumberFilterItem("IDTrabajoIncremento", Grid.Value("IDTrabajoIncremento")))

        dv.RowFilter = f.Compose(New AdoFilterComposer)
        If dv.Count > 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("Ya existe este incremento para este trabajo.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Return blnCancel
    End Function

#Region " Pestaña Material "

    Private Sub MaterialChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPresupMat.CheckedChanged, rbtPorNivelMat.CheckedChanged, rbtPorMultinivelMat.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            pnlVerMaterial.Visible = (rbtPorNivelMat.Checked Or rbtPorMultinivelMat.Checked)
            If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                CheckedAll()
                TabTrabajos_Click(TabTrabajos, New System.EventArgs)
            End If
        End If
    End Sub

    Private Sub GridMateriales_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMateriales.GotFocus
        With GridMateriales
            .Columns("IDPresup").DefaultValue = Me.CurrentRow("IDPresup")
            .Columns("QUnidad").DefaultValue = 0
            .Columns("QPresup").DefaultValue = 0
            .Columns("PrecioPresupMatA").DefaultValue = 0
            .Columns("PrecioVentaA").DefaultValue = 0
            .Columns("ImpPresupMatA").DefaultValue = 0
            .Columns("ImpPresupMatVentaA").DefaultValue = 0
            .Columns("Dto1").DefaultValue = 0
            .Columns("Dto2").DefaultValue = 0
            .Columns("Dto3").DefaultValue = 0
            .Columns("DtoVenta1").DefaultValue = 0
            .Columns("DtoVenta2").DefaultValue = 0
            .Columns("DtoVenta3").DefaultValue = 0
            .Columns("UdValoracion").DefaultValue = 1
            .Columns("Manual").DefaultValue = False
            If rbtPorNivelMat.Checked AndAlso Not drTrabajos Is Nothing AndAlso (Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Or Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajoConcepto) Then
                If Length(drTrabajos("IDTrabajoPresup")) > 0 Then .Columns("IDTrabajoPresup").DefaultValue = drTrabajos("IDTrabajoPresup")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                If Length(drTrabajos("QPresup")) > 0 Then .Columns("QPresupTrabajo").DefaultValue = drTrabajos("QPresup")
            Else
                .Columns("IDTrabajoPresup").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
                .Columns("QPresupTrabajo").DefaultValue = DBNull.Value
            End If
            .Columns("TipoIncremento").DefaultValue = CInt(enumSiNo.No)
        End With
    End Sub

    Private Sub GridMateriales_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMateriales.UpdatingRecord
        If GridMateriales.RowCount > 0 Then
            If Length(GridMateriales.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub GridMateriales_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMateriales.AddingRecord
        If Length(GridMateriales.Value("CodTrabajo")) = 0 Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf Nz(GridMateriales.Value("TipoIncremento")) Then
            e.Cancel = ValidaADDIncrementos(GridMateriales)
        End If
    End Sub

    Private Sub GridMateriales_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridMateriales.EditingCell
        With GridMateriales
            If cbxEstado.Value <> enumopcEstado.opcAceptado AndAlso cbxEstado.Value <> enumopcEstado.opcRechazado Then
                If Nz(.Value("TipoIncremento")) = enumSiNo.Si Then
                    If e.Column.Key <> "Secuencia" And e.Column.Key <> "IDTrabajoIncremento" Then
                        e.Cancel = True
                        .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    End If
                Else
                    Select Case e.Column.Key
                        Case "TipoIncremento"
                            If .Row <> Grid.newTopRowPosition Then e.Cancel = True
                        Case "CodTrabajo"
                            If .Row <> Grid.newTopRowPosition Then
                                e.Cancel = True
                                .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                            Else
                                .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                            End If
                        Case "QPresup"
                            If Not .Value("Manual") Then e.Cancel = True
                        Case "MargenPresup"
                            If Nz(.Value("DtoVenta1"), 0) > 0 OrElse Nz(.Value("DtoVenta2"), 0) > 0 OrElse Nz(.Value("DtoVenta3"), 0) > 0 Then e.Cancel = True
                    End Select
                End If
            Else
                e.Cancel = True
                .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            End If
        End With
    End Sub

    Private Sub GridMateriales_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridMateriales.AdvSearchSetPredefinedFilter
        With GridMateriales
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IDPresup", FilterOperator.Equal, Me.CurrentRow("IdPresup"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
                Case "IDMaterial"
                    e.Filter.Add(New BooleanFilterItem("Activo", FilterOperator.Equal, True))
            End Select
        End With
    End Sub

    Private Sub GridMateriales_AdvSearchNotInList(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchNotInListEventArgs) Handles GridMateriales.AdvSearchNotInList
        With GridMateriales
            Select Case e.Key
                Case "IDMaterial"
                    e.Handled = True
                    e.Cancel = False
            End Select
        End With
    End Sub

    Private Sub GridMateriales_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridMateriales.MouseUp
        If e.Button = MouseButtons.Right Then
            If Not IsNothing(GridMateriales) AndAlso GridMateriales.RowCount > 0 Then
                If Length(GridMateriales.Value("IDMaterial")) > 0 Then
                    GridMateriales.UiCommandManager1.Commands(cnABRIRMATERIAL).Visible = InheritableBoolean.True
                Else
                    GridMateriales.UiCommandManager1.Commands(cnABRIRMATERIAL).Visible = InheritableBoolean.False
                End If
                If Length(GridMateriales.Value("IDLineaMaterialPadre")) = 0 Then
                    GridMateriales.UiCommandManager1.Commands(cnIMPORTARESTRUCTURA).Visible = InheritableBoolean.True
                Else
                    GridMateriales.UiCommandManager1.Commands(cnIMPORTARESTRUCTURA).Visible = InheritableBoolean.False
                End If
            End If
        End If
    End Sub

    Private Sub TotalesMaterial(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMateriales.RecordAdded, GridMateriales.RecordUpdated, GridMateriales.RecordsDeleted
        With GridMateriales
            txtTotalMaterial.Text = xRound(.GetTotal(.Columns("ImpPresupMatA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalMaterialVenta.Text = xRound(.GetTotal(.Columns("ImpPresupMatVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

    Private Sub GridMateriales_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridMateriales.FormattingRow
        With GridMateriales
            If e.Row.RowType = RowType.Record Then
                If Nz(e.Row.Cells("TipoIncremento").Value) Then
                    e.Row.RowStyle = .FormatStyles("IncrementoFormatStyle")
                    e.Row.Cells("IDTrabajoIncremento").ImageIndex = 8
                    For Each dc As DataColumn In ndMateriales.Data.Columns
                        If dc.ColumnName <> "Secuencia" And dc.ColumnName <> "CodTrabajo" And _
                           dc.ColumnName <> "DescMaterial" And dc.ColumnName <> "TipoIncremento" And _
                           dc.ColumnName <> "IDTrabajoIncremento" And dc.ColumnName <> "ImpPresupMatVentaA" Then
                            If e.Row.Table.Columns.Contains(dc.ColumnName) Then
                                e.Row.Cells(dc.ColumnName).Text = String.Empty
                            End If
                        End If
                    Next
                End If
            End If
        End With
    End Sub

    Private Sub GridMateriales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMateriales.Click
        With GridMateriales
            Dim hit As GridArea = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "IDTrabajoIncremento"
                            If .Value("TipoIncremento") Then
                                OpenSearchTipoIncremento()
                            End If
                    End Select
                End If
            End If
        End With
    End Sub

    Private Sub GridMateriales_CellUpdated(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridMateriales.CellUpdated
        Select Case e.Column.Key
            Case GridMateriales.Columns("IDMaterial").Key
                If mblnAbrirEvaluador Then
                    If ExpertisApp.GenerateMessage("Este Material es configurable. ¿Desea realizar su configuración.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        mintRow = GridMateriales.Row
                        mOriginalIDTrabajoPresup = Nz(GridMateriales.Value("IDTrabajoPresup"), -1)
                        mOriginalCodTrabajo = GridMateriales.Value("CodTrabajo") & String.Empty
                        mOriginalValueArticulo = GridMateriales.Value("IDMaterial") & String.Empty
                        mOriginalValueQPresup = Nz(GridMateriales.Value("QPresup"), 0)
                        mIDArticuloConfig = GridMateriales.Value("IDMaterial") & String.Empty
                        GridMateriales.UpdateOnLeave = False
                        Dim HT As New Hashtable
                        HT("IDArticulo") = GridMateriales.Value("IDMaterial") & String.Empty
                        Dim oFrm As Object = ExpertisApp.OpenForm("EVALUADOR", , HT)
                        AddHandler CType(oFrm, Form).Disposed, AddressOf FrmActionDisposed
                    End If
                    mblnAbrirEvaluador = False
                End If
        End Select
    End Sub

    Private Sub FrmActionDisposed(ByVal sender As Object, ByVal e As System.EventArgs)
        RemoveHandler CType(sender, Form).Disposed, AddressOf FrmActionDisposed

        If Length(sender.IDArticuloConfigurado) > 0 Then
            mIDArticuloConfig = sender.IDArticuloConfigurado
        End If
        GridMateriales.Row = mintRow
        If mOriginalIDTrabajoPresup <> -1 Then
            GridMateriales.InvokeBusinessRules("IDTrabajoPresup", mOriginalIDTrabajoPresup, GridMateriales.Value("IDTrabajoPresup"))
            GridMateriales.InvokeBusinessRules("CodTrabajo", mOriginalCodTrabajo, GridMateriales.Value("CodTrabajo"))
        End If
        'GridMateriales.SetValue("IDMaterial", mIDArticuloConfig)
        GridMateriales.InvokeBusinessRules("IDMaterial", mIDArticuloConfig, mOriginalValueArticulo)
        'GridMateriales.SetValue("QPresup", 1)
        GridMateriales.InvokeBusinessRules("QPresup", 1, mOriginalValueQPresup)
        Dim blnCancel As Boolean
        If Length(GridMateriales.Value("CodTrabajo")) = 0 Then
            blnCancel = True
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf GridMateriales.Value("TipoIncremento") Then
            blnCancel = True
            ValidaADDIncrementos(GridMateriales)
        End If
        If Not blnCancel Then
            GridMateriales.UpdateOnLeave = True
            GridMateriales.UpdateData()
            mOriginalValueArticulo = String.Empty
            mOriginalValueQPresup = 0
        End If
    End Sub

#End Region

#Region " Pestaña MOD "

    Private Sub ModChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPresupMod.CheckedChanged, rbtPorNivelMod.CheckedChanged, rbtPorMultinivelMod.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            pnlVerMOD.Visible = (rbtPorNivelMod.Checked Or rbtPorMultinivelMod.Checked)
            If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                CheckedAll()
                TabTrabajos_Click(TabTrabajos, New System.EventArgs)
            End If
        End If
    End Sub

    Private Sub GridMOD_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridMOD.GotFocus
        With GridMOD
            .Columns("IDPresup").DefaultValue = Me.CurrentRow("IDPresup")
            .Columns("IDHora").DefaultValue = mstrIDHora
            .Columns("DescHora").DefaultValue = mstrDescHora
            .Columns("Manual").DefaultValue = False
            If rbtPorNivelMod.Checked AndAlso Not drTrabajos Is Nothing AndAlso (Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Or Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajoConcepto) Then
                If Length(drTrabajos("IDTrabajoPresup")) > 0 Then .Columns("IDTrabajoPresup").DefaultValue = drTrabajos("IDTrabajoPresup")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                If Length(drTrabajos("QPresup")) > 0 Then .Columns("QPresupTrabajo").DefaultValue = drTrabajos("QPresup")
            Else
                .Columns("IDTrabajoPresup").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
                .Columns("QPresupTrabajo").DefaultValue = DBNull.Value
            End If
            .Columns("TipoIncremento").DefaultValue = CInt(enumSiNo.No)
        End With
    End Sub

    Private Sub GridMOD_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMOD.UpdatingRecord
        If GridMOD.RowCount > 0 Then
            If Length(GridMOD.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub GridMOD_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMOD.AddingRecord
        If Length(GridMOD.Value("CodTrabajo")) = 0 Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf GridMOD.Value("TipoIncremento") Then
            e.Cancel = ValidaADDIncrementos(GridMOD)
        End If
    End Sub

    Private Sub GridMOD_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridMOD.EditingCell
        With GridMOD
            If cbxEstado.Value <> enumopcEstado.opcAceptado AndAlso cbxEstado.Value <> enumopcEstado.opcRechazado Then
                If Nz(.Value("TipoIncremento")) = enumSiNo.Si Then
                    If e.Column.Key <> "Secuencia" And e.Column.Key <> "IDTrabajoIncremento" Then
                        e.Cancel = True
                        .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    End If
                Else
                    Select Case e.Column.Key
                        Case "TipoIncremento"
                            If .Row <> Grid.newTopRowPosition Then e.Cancel = True
                        Case "CodTrabajo"
                            If .Row <> Grid.newTopRowPosition Then
                                e.Cancel = True
                                .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                            Else
                                .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                            End If
                        Case "HorasPresupMOD"
                            If Not .Value("Manual") Then e.Cancel = True
                    End Select
                End If
            Else
                e.Cancel = True
                .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            End If
        End With
    End Sub

    Private Sub GridMOD_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridMOD.AdvSearchSetPredefinedFilter
        With GridMOD
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IDPresup", FilterOperator.Equal, Me.CurrentRow("IdPresup"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
            End Select
        End With
    End Sub

    Private Sub GridMOD_AdvSearchNotInList(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchNotInListEventArgs) Handles GridMOD.AdvSearchNotInList
        With GridMOD
            Select Case e.Key
                Case "IDCategoria"
                    e.Handled = True
                    e.Cancel = False
            End Select
        End With
    End Sub

    Private Sub TotalesMod(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMOD.RecordAdded, GridMOD.RecordUpdated, GridMOD.RecordsDeleted
        With GridMOD
            txtTotalMOD.Text = xRound(.GetTotal(.Columns("ImpPresupModA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalMODVenta.Text = xRound(.GetTotal(.Columns("ImpPresupModVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

    Private Sub GridMOD_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridMOD.FormattingRow
        With GridMOD
            If e.Row.RowType = RowType.Record Then
                If Nz(e.Row.Cells("TipoIncremento").Value) Then
                    e.Row.RowStyle = .FormatStyles("IncrementoFormatStyle")
                    e.Row.Cells("IDTrabajoIncremento").ImageIndex = 8
                    For Each dc As DataColumn In ndMOD.Data.Columns
                        If dc.ColumnName <> "Secuencia" And dc.ColumnName <> "CodTrabajo" And _
                           dc.ColumnName <> "DescCategoria" And dc.ColumnName <> "DesHora" And _
                           dc.ColumnName <> "TipoIncremento" And dc.ColumnName <> "IDTrabajoIncremento" And _
                           dc.ColumnName <> "ImpPresupModVentaA" Then
                            If e.Row.Table.Columns.Contains(dc.ColumnName) Then
                                e.Row.Cells(dc.ColumnName).Text = String.Empty
                            End If
                        End If
                    Next
                End If
            End If
        End With
    End Sub

    Private Sub GridMOD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMOD.Click
        With GridMOD
            Dim hit As GridArea = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "IDTrabajoIncremento"
                            If .Value("TipoIncremento") Then
                                OpenSearchTipoIncremento()
                            End If
                    End Select
                End If
            End If
        End With
    End Sub

#End Region

#Region " Pestaña Centros "

    Private Sub CentrosChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPresupCentros.CheckedChanged, rbtPorNivelCentros.CheckedChanged, rbtPorMultinivelCentros.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            pnlVerCentros.Visible = (rbtPorNivelCentros.Checked Or rbtPorMultinivelCentros.Checked)
            If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                CheckedAll()
                TabTrabajos_Click(TabTrabajos, New System.EventArgs)
            End If
        End If
    End Sub

    Private Sub GridCentros_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridCentros.GotFocus
        With GridCentros
            .Columns("IDPresup").DefaultValue = Me.CurrentRow("IDPresup")
            If rbtPorNivelCentros.Checked AndAlso Not drTrabajos Is Nothing AndAlso (Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Or Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajoConcepto) Then
                If Length(drTrabajos("IDTrabajoPresup")) > 0 Then .Columns("IDTrabajoPresup").DefaultValue = drTrabajos("IDTrabajoPresup")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
                If Length(drTrabajos("QPresup")) > 0 Then .Columns("QPresupTrabajo").DefaultValue = drTrabajos("QPresup")
            Else
                .Columns("IDTrabajoPresup").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
                .Columns("QPresupTrabajo").DefaultValue = DBNull.Value
            End If
            .Columns("Manual").DefaultValue = False
            .Columns("TipoIncremento").DefaultValue = CInt(enumSiNo.No)
        End With
    End Sub

    Private Sub GridCentros_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridCentros.UpdatingRecord
        If GridCentros.RowCount > 0 Then
            If Length(GridCentros.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub GridCentros_AddingRecord(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridCentros.AddingRecord
        If Length(GridCentros.Value("CodTrabajo")) = 0 Then
            e.Cancel = True
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf GridCentros.Value("TipoIncremento") Then
            e.Cancel = ValidaADDIncrementos(GridCentros)
        End If
    End Sub

    Private Sub GridCentros_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridCentros.EditingCell
        With GridCentros
            If cbxEstado.Value <> enumopcEstado.opcAceptado AndAlso cbxEstado.Value <> enumopcEstado.opcRechazado Then
                If Nz(.Value("TipoIncremento")) = enumSiNo.Si Then
                    If e.Column.Key <> "Secuencia" And e.Column.Key <> "IDTrabajoIncremento" Then
                        e.Cancel = True
                        .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
                    End If
                Else
                    Select Case e.Column.Key
                        Case "TipoIncremento"
                            If .Row <> Grid.newTopRowPosition Then e.Cancel = True
                        Case "CodTrabajo"
                            If .Row <> Grid.newTopRowPosition Then
                                e.Cancel = True
                                .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                            Else
                                .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                            End If
                        Case "HorasPresupCentro"
                            If Not .Value("Manual") Then e.Cancel = True
                    End Select
                End If
            Else
                e.Cancel = True
                .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            End If
        End With
    End Sub

    Private Sub GridCentros_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridCentros.AdvSearchSetPredefinedFilter
        With GridCentros
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IDPresup", FilterOperator.Equal, Me.CurrentRow("IdPresup"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
            End Select
        End With
    End Sub

    Private Sub GridCentros_AdvSearchNotInList(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchNotInListEventArgs) Handles GridCentros.AdvSearchNotInList
        With GridCentros
            Select Case e.Key
                Case "IDCentro"
                    e.Handled = True
                    e.Cancel = False
            End Select
        End With
    End Sub

    Private Sub TotalesCentros(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridCentros.RecordAdded, GridCentros.RecordUpdated, GridCentros.RecordsDeleted
        With GridCentros
            txtTotalCentros.Text = xRound(.GetTotal(.Columns("ImpPresupCentroA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalCentrosVenta.Text = xRound(.GetTotal(.Columns("ImpPresupCentroVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

    Private Sub GridCentros_FormattingRow(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowLoadEventArgs) Handles GridCentros.FormattingRow
        With GridCentros
            If e.Row.RowType = RowType.Record Then
                If Nz(e.Row.Cells("TipoIncremento").Value) Then
                    e.Row.RowStyle = .FormatStyles("IncrementoFormatStyle")
                    e.Row.Cells("IDTrabajoIncremento").ImageIndex = 8
                    For Each dc As DataColumn In ndCentros.Data.Columns
                        If dc.ColumnName <> "Secuencia" And dc.ColumnName <> "CodTrabajo" And _
                           dc.ColumnName <> "DescCentro" And dc.ColumnName <> "TipoIncremento" And _
                           dc.ColumnName <> "IDTrabajoIncremento" And dc.ColumnName <> "ImpPresupCentroVentaA" Then
                            If e.Row.Table.Columns.Contains(dc.ColumnName) Then
                                e.Row.Cells(dc.ColumnName).Text = String.Empty
                            End If
                        End If
                    Next
                End If
            End If
        End With
    End Sub

    Private Sub GridCentros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridCentros.Click
        With GridCentros
            Dim hit As GridArea = .HitTest()
            If hit = GridArea.Cell Or hit = GridArea.NewRowCell Then
                Dim c As GridEXColumn = .ColumnFromPoint()
                If Not IsNothing(c) Then
                    Select Case c.Key
                        Case "IDTrabajoIncremento"
                            If .Value("TipoIncremento") Then
                                OpenSearchTipoIncremento()
                            End If
                    End Select
                End If
            End If
        End With
    End Sub

#End Region

#Region " Pestaña Gastos "

    Private Sub GastosChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPresupGastos.CheckedChanged, rbtPorNivelGastos.CheckedChanged, rbtPorMultinivelGastos.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            pnlVerGastos.Visible = (rbtPorNivelGastos.Checked Or rbtPorMultinivelGastos.Checked)
            If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                CheckedAll()
                TabTrabajos_Click(TabTrabajos, New System.EventArgs)
            End If
        End If
    End Sub

    Private Sub GridGastos_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridGastos.GotFocus
        With GridGastos
            .Columns("IDPresup").DefaultValue = Me.CurrentRow("IDPresup")
            If rbtPorNivelGastos.Checked AndAlso Not drTrabajos Is Nothing AndAlso (Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Or Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajoConcepto) Then
                If Length(drTrabajos("IDTrabajoPresup")) > 0 Then .Columns("IDTrabajoPresup").DefaultValue = drTrabajos("IDTrabajoPresup")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            Else
                .Columns("IDTrabajoPresup").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
        End With
    End Sub

    Private Sub GridGastos_Update(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridGastos.AddingRecord, GridGastos.UpdatingRecord
        If GridGastos.RowCount > 0 Then
            If Length(GridGastos.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub GridGastos_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridGastos.EditingCell
        With GridGastos
            If cbxEstado.Value <> enumopcEstado.opcAceptado AndAlso cbxEstado.Value <> enumopcEstado.opcRechazado Then
                Select Case e.Column.Key
                    Case "CodTrabajo"
                        If .Row <> Grid.newTopRowPosition Then
                            e.Cancel = True
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                        Else
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                        End If
                End Select
            Else
                e.Cancel = True
                .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            End If
        End With
    End Sub

    Private Sub GridGastos_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridGastos.AdvSearchSetPredefinedFilter
        With GridGastos
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IDPresup", FilterOperator.Equal, Me.CurrentRow("IdPresup"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
            End Select
        End With
    End Sub

    Private Sub TotalesGastos(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridGastos.RecordAdded, GridGastos.RecordUpdated, GridGastos.RecordsDeleted
        With GridGastos
            txtTotalGastos.Text = xRound(.GetTotal(.Columns("ImpPresupGastoA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalGastosVenta.Text = xRound(.GetTotal(.Columns("ImpPresupGastoVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

#End Region

#Region " Pestaña Varios "

    Private Sub VariosChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPresupVarios.CheckedChanged, rbtPorNivelVarios.CheckedChanged, rbtPorMultinivelVarios.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            pnlVerVarios.Visible = (rbtPorNivelVarios.Checked Or rbtPorMultinivelVarios.Checked)
            If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                CheckedAll()
                TabTrabajos_Click(TabTrabajos, New System.EventArgs)
            End If
        End If
    End Sub

    Private Sub GridVarios_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVarios.GotFocus
        With GridVarios
            .Columns("IDPresup").DefaultValue = Me.CurrentRow("IDPresup")
            If rbtPorNivelVarios.Checked AndAlso Not drTrabajos Is Nothing AndAlso (Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajo Or Nz(drTrabajos("TipoLinea"), 0) = enumTipoLineaTrabajo.tltTrabajoConcepto) Then
                If Length(drTrabajos("IDTrabajoPresup")) > 0 Then .Columns("IDTrabajoPresup").DefaultValue = drTrabajos("IDTrabajoPresup")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            Else
                .Columns("IDTrabajoPresup").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
        End With
    End Sub

    Private Sub GridVarios_Update(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridVarios.AddingRecord, GridVarios.UpdatingRecord
        If GridVarios.RowCount > 0 Then
            If Length(GridVarios.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub GridVarios_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridVarios.EditingCell
        With GridVarios
            If cbxEstado.Value <> enumopcEstado.opcAceptado AndAlso cbxEstado.Value <> enumopcEstado.opcRechazado Then
                Select Case e.Column.Key
                    Case "CodTrabajo"
                        If .Row <> Grid.newTopRowPosition Then
                            e.Cancel = True
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                        Else
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                        End If
                End Select
            Else
                e.Cancel = True
                .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            End If
        End With
    End Sub

    Private Sub GridVarios_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridVarios.AdvSearchSetPredefinedFilter
        With GridVarios
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IDPresup", FilterOperator.Equal, Me.CurrentRow("IdPresup"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
            End Select
        End With
    End Sub

    Private Sub TotalesVarios(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridVarios.RecordAdded, GridVarios.RecordUpdated, GridVarios.RecordsDeleted
        With GridVarios
            txtTotalVarios.Text = xRound(.GetTotal(.Columns("ImpPresupVariosA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
            txtTotalVariosVenta.Text = xRound(.GetTotal(.Columns("ImpPresupVariosVentaA"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub

#End Region

#Region " Pestaña Mediciones "

    Private Sub MedicionesChecked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtPresupMedicion.CheckedChanged, rbtPorNivelMedicion.CheckedChanged, rbtPorMultinivelMedicion.CheckedChanged
        If Not IsNothing(dtTrabajos) AndAlso dtTrabajos.Rows.Count > 0 Then
            pnlVerMediciones.Visible = (rbtPorNivelMedicion.Checked Or rbtPorMultinivelMedicion.Checked)
            If Not IsNothing(Me.CurrentData) AndAlso Not blnChecked Then
                CheckedAll()
                TabTrabajos_Click(TabTrabajos, New System.EventArgs)
            End If
        End If
    End Sub

    Private Sub GridMediciones_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMediciones.Click
        With GridMediciones
            .Columns("IDPresup").DefaultValue = Me.CurrentRow("IDPresup")
            If rbtPorNivelMedicion.Checked AndAlso Not drTrabajos Is Nothing Then
                If Length(drTrabajos("IDTrabajoPresup")) > 0 Then .Columns("IDTrabajoPresup").DefaultValue = drTrabajos("IDTrabajoPresup")
                If Length(drTrabajos("CodTrabajo")) > 0 Then .Columns("CodTrabajo").DefaultValue = drTrabajos("CodTrabajo")
            Else
                .Columns("IDTrabajoPresup").DefaultValue = DBNull.Value
                .Columns("CodTrabajo").DefaultValue = DBNull.Value
            End If
        End With
    End Sub

    Private Sub GridMediciones_UpdatingRecord(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GridMediciones.AddingRecord, GridMediciones.UpdatingRecord
        If GridMediciones.RowCount > 0 Then
            If Length(GridMediciones.Value("CodTrabajo")) = 0 Then
                e.Cancel = True
                ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub GridMediciones_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridMediciones.EditingCell
        With GridMediciones
            If cbxEstado.Value <> enumopcEstado.opcAceptado AndAlso cbxEstado.Value <> enumopcEstado.opcRechazado Then
                Select Case e.Column.Key
                    Case "CodTrabajo"
                        If .Row <> Grid.newTopRowPosition Then
                            e.Cancel = True
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.NoButton
                        Else
                            .Columns("CodTrabajo").ButtonStyle = ButtonStyle.Image
                        End If
                End Select
            Else
                e.Cancel = True
                .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            End If
        End With
    End Sub

    Private Sub GridMediciones_AdvSearchSetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.GridAdvSearchFilterEventArgs) Handles GridMediciones.AdvSearchSetPredefinedFilter
        With GridMediciones
            Select Case e.Key
                Case "CodTrabajo"
                    e.Filter.Add("IDPresup", FilterOperator.Equal, Me.CurrentRow("IdPresup"), FilterType.Numeric)
                    Dim eor As New Filter(FilterUnionOperator.Or)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajo, FilterType.Numeric)
                    eor.Add("TipoLinea", FilterOperator.Equal, enumTipoLineaTrabajo.tltTrabajoConcepto, FilterType.Numeric)
                    e.Filter.Add(eor)
            End Select
        End With
    End Sub

    Private Sub TotalesMediciones(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridMediciones.RecordAdded, GridMediciones.RecordUpdated, GridMediciones.RecordsDeleted
        With GridMediciones
            txtTotalMedicion.Text = xRound(.GetTotal(.Columns("Total"), Janus.Windows.GridEX.AggregateFunction.Sum), mintRedondeoA)
        End With
    End Sub
#End Region

#End Region

#Region " Pestaña Caracteristica "

    Private Sub GridCaracteristicas_EditingCell(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles GridCaracteristicas.EditingCell
        With GridCaracteristicas
            If cbxEstado.Value <> enumopcEstado.opcAceptado AndAlso cbxEstado.Value <> enumopcEstado.opcRechazado Then
                .Columns(e.Column.Key).EditType = Janus.Windows.GridEX.EditType.TextBox
            Else
                e.Cancel = True
                .Columns(e.Column.Key).ButtonStyle = Janus.Windows.GridEX.ButtonStyle.NoButton
            End If
        End With
    End Sub

#End Region

#Region " Pestaña Seguimiento "

    Private Overloads Sub CmbUrlContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbUrlContrato.Click
        OpenDialog1.InitialDirectory = ExpertisApp.Path
        OpenDialog1.ShowDialog()

        If OpenDialog1.FileName <> String.Empty Then
            txtURLContrato.Text = OpenDialog1.FileName
        End If
    End Sub

    Private Sub AdvResponsable_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvResponsable.SetPredefinedFilter
        e.Filter.Add("Vendedor", FilterOperator.Equal, 1)
    End Sub

#End Region

#Region "Pestaña Aportaciones"


#End Region

#Region "Pestaña Trabajos Estructura"

    Private Sub GridTrabEstr_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridTrabEstr.GotFocus
        With GridTrabEstr
            If .Row = Grid.newTopRowPosition Then
                .Columns("IDPresup").DefaultValue = Me.CurrentRow.Item("IDPresup")
                '.Columns("NumPresup").DefaultValue = Me.CurrentRow.Item("NObra")

            End If
        End With

    End Sub
    Private Sub GridTrabEstr_AdvSearchSetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.GridAdvSearchFilterEventArgs) Handles GridTrabEstr.AdvSearchSetPredefinedFilter
        Select Case e.Key
            Case "codObraElementoEstructura"
                'MsgBox("el codigo de la estructura es " & GridTrabEstr.GetValue("IdObraEstructura"))
                e.Filter.Add("IdObraEstructura", FilterOperator.Equal, GridTrabEstr.GetValue("IdObraEstructura"))
            Case "codEstucturaSubElemento"
                'MsgBox("el codigo de la estructura es " & GridTrEstr.GetValue("IdObraEstructura"))
                e.Filter.Add("IdObraEstructura", FilterOperator.Equal, GridTrabEstr.GetValue("IdObraEstructura"))
                e.Filter.Add("idObraElementoEstructura", FilterOperator.Equal, GridTrabEstr.GetValue("idObraElementoEstructura"))

        End Select
    End Sub



#End Region

#Region " BusinessCalling "

    Private Sub MntoObraPresup_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context.Clear()
        Select Case e.EntityName
            Case GridTrabajos.EntityName
                e.Data.Context("FechaIniCab") = Me.CurrentRow("FechaPresup")
                e.Data.Context("FechaFinCab") = Me.CurrentRow("FechaCierre")
                If TypeOf GridTrabajos.DataSource Is DataView Then
                    e.Data.Context("dtTrabajos") = CType(GridTrabajos.DataSource, DataView).Table
                Else
                    e.Data.Context("dtTrabajos") = GridTrabajos.DataSource
                End If
                e.Data.Context("CodTrabajo") = GridTrabajos.Value("CodTrabajo") & String.Empty
                If Not drTrabajos Is Nothing Then
                    If rbtPorNivelTrabajos.Checked Then
                        e.Data.Context("PorNivel") = rbtPorNivelTrabajos.Checked
                        e.Data.Context("IDTrabajoPadre") = drTrabajos("IDTrabajoPresup")
                        e.Data.Context("CodTrabajoPadre") = drTrabajos("CodTrabajo")
                        e.Data.Context("QPresupPadre") = drTrabajos("QPresup")
                    End If
                    If Length(drTrabajos("IDTrabajoPresupPadre")) > 0 Then
                        Dim dr() As DataRow = dtTrabajos.Select(New NumberFilterItem("IDtrabajoPresup", drTrabajos("IDTrabajoPresupPadre")).Compose(New AdoFilterComposer))
                        If dr.Length > 0 Then e.Data.Context("QPresupPadre") = dr(0)("QPresup")
                    End If
                End If
            Case GridMateriales.EntityName
                e.Data.Context("Fecha") = Me.CurrentRow("FechaPresup")
                e.Data.Context("IDCliente") = Me.CurrentRow("IDCliente")
                e.Data.Context("QPresupTrabajo") = Nz(GridMateriales.Value("QPresupTrabajo"), 0)
            Case GridMOD.EntityName
                e.Data.Context("QPresupTrabajo") = Nz(GridMOD.Value("QPresupTrabajo"), 0)
            Case GridCentros.EntityName
                e.Data.Context("QPresupTrabajo") = Nz(GridCentros.Value("QPresupTrabajo"), 0)
        End Select
    End Sub

    Private Sub MntoObraPresup_BusinessCalled(ByVal sender As Object, ByVal e As Engine.UI.BusinessCalledEventArgs) Handles MyBase.BusinessCalled
        If Not IsNothing(e.Data) Then
            If e.Data.ContainsKey("Iva") Then txtTotalIva.Value = Nz(e.Data("Iva"), 0)
            If e.Data.ContainsKey("Total") Then txtTotal.Value = Nz(e.Data("Total"), 0)
            '    If e.Data.ContainsKey("QPresup") AndAlso txtQPresup.Value <> Nz(e.Data("QPresup"), 1) Then txtQPresup.Value = Nz(e.Data("QPresup"), 1)

            'If e.EntityName = ndTrabajos.EntityName Then
            '    blnRefreshArbol = True
            'End If
        End If
        Select Case e.EntityName
            Case GridMateriales.EntityName
                If e.Data.ContainsKey("Configurable") Then
                    mblnAbrirEvaluador = Nz(e.Data.Item("Configurable"), False)
                End If
        End Select
    End Sub

#End Region

#Region " TAGs "

    Private Class TagTrabajo
        Public IDTrabajo As Integer

        Public Sub New(ByVal IDTrabajoPresup As Integer)
            IDTrabajo = IDTrabajoPresup
        End Sub
    End Class

#End Region

#Region " Informes "

    Private Sub MntoObraPresup_SetReportExportOptions(ByVal sender As Object, ByVal e As Engine.UI.ReportExportOptionsEventArgs) Handles MyBase.SetReportExportOptions
        e.Options.PromptUser = True
    End Sub

    Private Sub MntoObraPresup_SetReportDesignObjects(ByVal sender As Object, ByVal e As Engine.UI.ReportDesignObjectsEventArgs) Handles MyBase.SetReportDesignObjects
        Select Case e.Alias
            Case "PRESPARSINVAL", "PRESPARVAL"
                Dim HtParam As New Hashtable
                HtParam.Add("IDPresup", Me.CurrentRow.Item("IDPresup"))
                ExpertisApp.OpenForm("CISELCAP", , HtParam)
                e.Cancel = True
            Case "PRESNUEVO"
                ImprimirMediciones("presupuestoNuevo.rpt", e)
            Case "PRESNUEVODCZ"
                ImprimirMediciones("presupuestoNuevodcz.rpt", e)
            Case "CARCOMPRO"
                ImprimirMediciones("PresCartaCompromiso.rpt", e)
            Case "PRESNUEVOMED"
                ImprimirMediciones("PresCartaCompromiso.rpt", e)
            Case "PRESNUEVOSV"
                ImprimirMediciones("PresupuestoNuevoSinVal.rpt", e)


        End Select
    End Sub

    Private Sub ImprimirMediciones(ByVal strInforme As String, ByVal e As Engine.UI.ReportDesignObjectsEventArgs)
        Dim strCriteria As String
        Dim frm As New FrmDatosFax
        Dim dt As New DataTable

        Try
            dFecha = cbxFechaPresup.Text
            Me.Cursor = Cursors.Default

            frm.lNumPresup = txtNumPresup.Text
            'Para que guarde el idpresup en vez del numeropresup porque si hacemos una revision no guarda los datos de fax
            frm.lIdPresup = Me.CurrentRow("IDpresup")
            frm.ShowDialog()

            If blnImprimirfax = False Then
                e.Cancel = True
            Else
                e.Formulas("Para").Text = Para
                e.Formulas("empresadestino").Text = EmpresaDestino
                e.Formulas("telefonodestino").Text = TelefonoDestino
                e.Formulas("NFaxDestino").Text = NFaxDestino
                e.Formulas("EmailDestino").Text = EmailDestino
                e.Formulas("DE").Text = DE
                e.Formulas("EmpresaOrigen").Text = EmpresaOrigen
                e.Formulas("TelefonoOrigen").Text = TelefonoOrigen
                e.Formulas("NFaxOrigen").Text = NFaxOrigen
                e.Formulas("EmailOrigen").Text = EmailOrigen
                e.Formulas("Fecha").Text = Fecha
                e.Formulas("Fpago").Text = FPago
                e.Formulas("Validez").Text = Validez
                e.Formulas("Comentario").Text = Comentario
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dt = Nothing
        End Try
    End Sub

    Private Sub ImprimirCarta(ByVal strInforme As String, ByVal e As Engine.UI.ReportDesignObjectsEventArgs)
        Dim strCriteria As String
        Dim frm As New FrmDatosFax
        Dim dt As New DataTable

        Try
            dFecha = cbxFechaPresup.Text
            Me.Cursor = Cursors.Default

            frm.lNumPresup = txtNumPresup.Text
            'Para que guarde el idpresup en vez del numeropresup porque si hacemos una revision no guarda los datos de fax
            frm.lIdPresup = Me.CurrentRow("IDpresup")
            frm.ShowDialog()

            If blnImprimirfax = False Then
                e.Cancel = True
            Else
                e.Formulas("Para").Text = Para
                'e.Formulas("empresadestino").Text = EmpresaDestino
                'e.Formulas("telefonodestino").Text = TelefonoDestino
                'e.Formulas("NFaxDestino").Text = NFaxDestino
                'e.Formulas("EmailDestino").Text = EmailDestino
                e.Formulas("DE").Text = DE
                'e.Formulas("EmpresaOrigen").Text = EmpresaOrigen
                'e.Formulas("TelefonoOrigen").Text = TelefonoOrigen
                'e.Formulas("NFaxOrigen").Text = NFaxOrigen
                'e.Formulas("EmailOrigen").Text = EmailOrigen
                'e.Formulas("Fecha").Text = Fecha
                'e.Formulas("Fpago").Text = FPago
                'e.Formulas("Validez").Text = Validez
                'e.Formulas("Comentario").Text = Comentario
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dt = Nothing
        End Try
    End Sub

#End Region

#Region "Aportaciones"

    Private Sub GridAportaciones_CellValueChanged(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles GridAportaciones.CellValueChanged
        With GridAportaciones
            Select Case e.Column.Index
                Case .Columns("tecozam").Index
                    If .GetValue("tecozam") Then
                        .Value("contrata") = False
                    Else
                        .Value("contrata") = True
                    End If
                Case .Columns("contrata").Index
                    If .GetValue("contrata") Then
                        .Value("tecozam") = False
                    Else
                        .Value("tecozam") = True
                    End If
                Case .Columns("codAportacion").Index
                    Try
                        Dim dtApor As DataTable
                        Dim strSeleApor As String = "select * from vPresupAportacion where codAportacion ='" & .GetValue("codAportacion") & "'"
                        'dtApor = AdminData.GetData(strSeleApor, False)
                        Dim BE As Expertis.Engine.BE.DataEngine
                        Dim f As Filter
                        f.Add("CodAportacion", .GetValue("codAportacion"))
                        dtApor = BE.Filter("vPresupAportacion", f)

                        For Each drApor As DataRow In dtApor.Rows
                            .SetValue("descTipoAportacion", drApor("descTipoAportacion"))
                            .SetValue("descsubTipoAportacion", drApor("descsubTipoAportacion"))
                        Next
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    End Try

            End Select
        End With
    End Sub

    Private Sub btnCargarAport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarAport.Click
        Dim frm As New frmCargarAportaciones
        'Dim strWhere As String = "select *from vPresupAportacion where predeterminada = 'true' "
        Dim strWhere As String = "predeterminada = 'true' "
        'Dim BE As Expertis.Engine.BE.DataEngine
        Dim filter As New Filter
        filter.Add("predeterminada", "true")
        frm.ShowDialog()
        Dim dtSelectAport As DataTable = frm.dtTipos
        Dim nfilas As Integer = dtSelectAport.Rows.Count
        Dim i As Integer = 0
        Dim strSTA() As String
        If dtSelectAport.Rows.Count > 0 Then
            'strWhere &= "and dbo.vPresupAportacion.idSubtipoAportacion in ("
            'ExpertisApp.GenerateMessage("Se han seleccionado " & nfilas & " tipos de aportaciones")
            If dtSelectAport.Rows.Count = 1 Then
                For Each row As DataRow In dtSelectAport.Rows
                    Dim stapor As String = row("idSubtipoAportacion").ToString
                    filter.Add("idSubtipoAportacion", stapor)
                Next
            Else
                ReDim strSTA(dtSelectAport.Rows.Count - 1)
                For Each row As DataRow In dtSelectAport.Rows
                    'ReDim strSTA(i)

                    Dim ST As String = row("idSubtipoAportacion").ToString
                    'If i = nfilas Then
                    'strWhere &= "'" & row("idSubtipoAportacion").ToString & "'"
                    'strSTA(i) = row("idSubtipoAportacion").ToString
                    strSTA(i) = ST
                    'Else
                    'strWhere &= "'" & row("idSubtipoAportacion").ToString & "',"

                    'End If
                    i = i + 1
                Next
                filter.Add(New InListFilterItem("idSubtipoAportacion", strSTA, FilterType.String))
            End If
            'strWhere &= " ) order by Orden "

            'BE.Filter("vPresupAportacion", "*", strWhere)

        End If
        cargarAportaciones(filter)

    End Sub
    Private Sub cargarAportaciones(ByVal filter As Filter)
        Dim BE As New Expertis.Engine.BE.DataEngine
        'Dim dtAport As DataTable = AdminData.GetData(strSelect, False)
        Dim dtAport As DataTable = BE.Filter("vPresupAportacion", filter)
        'MsgBox("Se han cargado " & dtAport.Rows.Count & " aportaciones")
        If dtAport.Rows.Count > 0 Then
            Dim i As Integer = 0

            For Each dr As DataRow In dtAport.Rows

                With GridAportaciones
                    Dim idPres As Integer = Me.CurrentRow("IDPresup")
                    Dim strRep As String = "select codaportacion from tbObraPresupAportacion where IDPresup =" & idPres & " and codAportacion='" & dr("codAportacion") & "'"
                    'Dim dtfilas As DataTable = AdminData.GetData(strRep, False)
                    Dim faport As New Filter
                    faport.Add("IDPresup", idPres)
                    faport.Add("codAportacion", dr("codAportacion"))
                    Dim dtfilas As DataTable = BE.Filter("tbObraPresupAportacion", faport)
                    Dim nfilas As Integer = dtfilas.Rows.Count
                    'ExpertisApp.GenerateMessage(
                    If nfilas = 0 Then
                        i = i + 1
                        .Row = .newTopRowPosition
                        Dim fdat As New Filter
                        fdat.Add("codAportacion", dr("codAportacion"))
                        Dim dtDatos As DataTable = BE.Filter("vPresupAportacion", fdat)
                        'Dim dtDatos As DataTable = AdminData.GetData("select * from vPresupAportacion where codAportacion ='" & dr("codAportacion") & "'")
                        'Dim nDatos

                        For Each drdat As DataRow In dtDatos.Rows

                            .SetValue("sec", i * 10)
                            .SetValue("codAportacion", dr("codAportacion"))
                            .SetValue("descPresupAportacion", dr("descPresupAportacion"))
                            .SetValue("descTipoAportacion", drdat("descTipoAportacion"))
                            .SetValue("descsubTipoAportacion", drdat("descsubTipoAportacion"))
                            .UpdateData()

                        Next
                        '.SetValue("codAportacion", dr("codAportacion"))
                        '.SetValue("descPresupAportacion", dr("descPresupAportacion"))
                        '.UpdateData()

                    End If
                End With
            Next

        End If

    End Sub
#End Region


End Class