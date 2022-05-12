Public Class frmAddMOD
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
    Friend WithEvents CmbNuevo As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtSecuencia As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblSecuencia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblIDCategoria As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCategoria As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDHora As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDHora As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents chbManual As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblHorasUnidad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbHorasUnidad As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblHorasPresupMod As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbHorasPresupMod As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTasaPresupModA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbTasaPresupModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpPresupModA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbImpPresupModA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblMargenPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbMargenPresup As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpPresupModVentaA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbImpPresupModVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPrecioVentaA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbPrecioVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ulDescCategoria As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ulDescHora As Solmicro.Expertis.Engine.UI.UnderLineLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbNuevo = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtSecuencia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblSecuencia = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDCategoria = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCategoria = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDHora = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDHora = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescCategoria = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.ulDescHora = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.chbManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblHorasUnidad = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbHorasUnidad = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblHorasPresupMod = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbHorasPresupMod = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTasaPresupModA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbTasaPresupModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPresupModA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPresupModA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMargenPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbMargenPresup = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPresupModVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPresupModVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPrecioVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbPrecioVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CmbNuevo)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 209)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 42)
        Me.Panel1.TabIndex = 234
        '
        'CmbNuevo
        '
        Me.CmbNuevo.Location = New System.Drawing.Point(123, 7)
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(94, 29)
        Me.CmbNuevo.TabIndex = 9
        Me.CmbNuevo.Text = "Nuevo"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(323, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 11
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(223, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 10
        Me.CmbAceptar.Text = "Aceptar"
        '
        'txtSecuencia
        '
        Me.TryDataBinding(txtSecuencia, New System.Windows.Forms.Binding("Text", Me, "Secuencia", True))
        Me.txtSecuencia.DisabledBackColor = System.Drawing.Color.White
        Me.txtSecuencia.Location = New System.Drawing.Point(472, 8)
        Me.txtSecuencia.Name = "txtSecuencia"
        Me.txtSecuencia.Size = New System.Drawing.Size(64, 21)
        Me.txtSecuencia.TabIndex = 0
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(195, 8)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(210, 21)
        Me.txtDescTrabajo.TabIndex = 238
        Me.txtDescTrabajo.TabStop = False
        '
        'txtCodTrabajo
        '
        Me.txtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajo.Enabled = False
        Me.txtCodTrabajo.Location = New System.Drawing.Point(71, 8)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(119, 21)
        Me.txtCodTrabajo.TabIndex = 237
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(4, 10)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblCodTrabajo.TabIndex = 235
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'lblSecuencia
        '
        Me.lblSecuencia.Location = New System.Drawing.Point(409, 10)
        Me.lblSecuencia.Name = "lblSecuencia"
        Me.lblSecuencia.Size = New System.Drawing.Size(65, 13)
        Me.lblSecuencia.TabIndex = 239
        Me.lblSecuencia.Text = "Secuencia"
        '
        'lblIDCategoria
        '
        Me.lblIDCategoria.Location = New System.Drawing.Point(4, 34)
        Me.lblIDCategoria.Name = "lblIDCategoria"
        Me.lblIDCategoria.Size = New System.Drawing.Size(63, 13)
        Me.lblIDCategoria.TabIndex = 240
        Me.lblIDCategoria.Text = "Categoría"
        '
        'advIDCategoria
        '
        Me.TryDataBinding(advIDCategoria, New System.Windows.Forms.Binding("Text", Me, "IDCategoria", True))
        Me.advIDCategoria.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCategoria.EntityName = "Categoria"
        Me.advIDCategoria.Location = New System.Drawing.Point(71, 34)
        Me.advIDCategoria.Name = "advIDCategoria"
        Me.advIDCategoria.PrimaryDataFields = "IDCategoria"
        Me.advIDCategoria.SecondaryDataFields = "IDCategoria"
        Me.advIDCategoria.Size = New System.Drawing.Size(119, 23)
        Me.advIDCategoria.TabIndex = 1
        '
        'lblIDHora
        '
        Me.lblIDHora.Location = New System.Drawing.Point(4, 60)
        Me.lblIDHora.Name = "lblIDHora"
        Me.lblIDHora.Size = New System.Drawing.Size(34, 13)
        Me.lblIDHora.TabIndex = 242
        Me.lblIDHora.Text = "Hora"
        '
        'advIDHora
        '
        Me.TryDataBinding(advIDHora, New System.Windows.Forms.Binding("Text", Me, "IDHora", True))
        Me.advIDHora.DisabledBackColor = System.Drawing.Color.White
        Me.advIDHora.EntityName = "Hora"
        Me.advIDHora.Location = New System.Drawing.Point(71, 60)
        Me.advIDHora.Name = "advIDHora"
        Me.advIDHora.PrimaryDataFields = "IDHora"
        Me.advIDHora.SecondaryDataFields = "IDHora"
        Me.advIDHora.Size = New System.Drawing.Size(119, 23)
        Me.advIDHora.TabIndex = 2
        '
        'ulDescCategoria
        '
        Me.TryDataBinding(ulDescCategoria, New System.Windows.Forms.Binding("Text", Me, "DescCategoria", True))
        Me.ulDescCategoria.Location = New System.Drawing.Point(195, 34)
        Me.ulDescCategoria.Name = "ulDescCategoria"
        Me.ulDescCategoria.Size = New System.Drawing.Size(337, 21)
        Me.ulDescCategoria.TabIndex = 245
        '
        'ulDescHora
        '
        Me.TryDataBinding(ulDescHora, New System.Windows.Forms.Binding("Text", Me.advIDHora, "DescHora", True))
        Me.ulDescHora.Location = New System.Drawing.Point(195, 60)
        Me.ulDescHora.Name = "ulDescHora"
        Me.ulDescHora.Size = New System.Drawing.Size(337, 21)
        Me.ulDescHora.TabIndex = 246
        '
        'chbManual
        '
        Me.TryDataBinding(chbManual, New System.Windows.Forms.Binding("BindableValue", Me, "Manual", True))
        Me.chbManual.Location = New System.Drawing.Point(5, 89)
        Me.chbManual.Name = "chbManual"
        Me.chbManual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbManual.Size = New System.Drawing.Size(80, 23)
        Me.chbManual.TabIndex = 3
        Me.chbManual.Text = "Manual"
        Me.chbManual.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far
        '
        'lblHorasUnidad
        '
        Me.lblHorasUnidad.Location = New System.Drawing.Point(111, 92)
        Me.lblHorasUnidad.Name = "lblHorasUnidad"
        Me.lblHorasUnidad.Size = New System.Drawing.Size(83, 13)
        Me.lblHorasUnidad.TabIndex = 249
        Me.lblHorasUnidad.Text = "Horas Unidad"
        '
        'ntbHorasUnidad
        '
        Me.TryDataBinding(ntbHorasUnidad, New System.Windows.Forms.Binding("Value", Me, "HorasUnidad", True))
        Me.ntbHorasUnidad.DisabledBackColor = System.Drawing.Color.White
        Me.ntbHorasUnidad.Location = New System.Drawing.Point(199, 90)
        Me.ntbHorasUnidad.Name = "ntbHorasUnidad"
        Me.ntbHorasUnidad.Size = New System.Drawing.Size(79, 21)
        Me.ntbHorasUnidad.TabIndex = 4
        '
        'lblHorasPresupMod
        '
        Me.lblHorasPresupMod.Location = New System.Drawing.Point(289, 92)
        Me.lblHorasPresupMod.Name = "lblHorasPresupMod"
        Me.lblHorasPresupMod.Size = New System.Drawing.Size(87, 13)
        Me.lblHorasPresupMod.TabIndex = 251
        Me.lblHorasPresupMod.Text = "Horas Presup."
        '
        'ntbHorasPresupMod
        '
        Me.TryDataBinding(ntbHorasPresupMod, New System.Windows.Forms.Binding("Value", Me, "HorasPresupMod", True))
        Me.ntbHorasPresupMod.DisabledBackColor = System.Drawing.Color.White
        Me.ntbHorasPresupMod.Location = New System.Drawing.Point(381, 90)
        Me.ntbHorasPresupMod.Name = "ntbHorasPresupMod"
        Me.ntbHorasPresupMod.Size = New System.Drawing.Size(79, 21)
        Me.ntbHorasPresupMod.TabIndex = 5
        '
        'lblTasaPresupModA
        '
        Me.lblTasaPresupModA.Location = New System.Drawing.Point(4, 134)
        Me.lblTasaPresupModA.Name = "lblTasaPresupModA"
        Me.lblTasaPresupModA.Size = New System.Drawing.Size(81, 13)
        Me.lblTasaPresupModA.TabIndex = 253
        Me.lblTasaPresupModA.Text = "Tasa Presup."
        '
        'ntbTasaPresupModA
        '
        Me.TryDataBinding(ntbTasaPresupModA, New System.Windows.Forms.Binding("Value", Me, "TasaPresupModA", True))
        Me.ntbTasaPresupModA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbTasaPresupModA.Location = New System.Drawing.Point(98, 134)
        Me.ntbTasaPresupModA.Name = "ntbTasaPresupModA"
        Me.ntbTasaPresupModA.Size = New System.Drawing.Size(121, 21)
        Me.ntbTasaPresupModA.TabIndex = 6
        '
        'lblImpPresupModA
        '
        Me.lblImpPresupModA.Location = New System.Drawing.Point(330, 127)
        Me.lblImpPresupModA.Name = "lblImpPresupModA"
        Me.lblImpPresupModA.Size = New System.Drawing.Size(81, 13)
        Me.lblImpPresupModA.TabIndex = 255
        Me.lblImpPresupModA.Text = "Imp. Presup."
        '
        'ntbImpPresupModA
        '
        Me.TryDataBinding(ntbImpPresupModA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupModA", True))
        Me.ntbImpPresupModA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbImpPresupModA.Enabled = False
        Me.ntbImpPresupModA.Location = New System.Drawing.Point(415, 127)
        Me.ntbImpPresupModA.Name = "ntbImpPresupModA"
        Me.ntbImpPresupModA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPresupModA.TabIndex = 256
        '
        'lblMargenPresup
        '
        Me.lblMargenPresup.Location = New System.Drawing.Point(330, 153)
        Me.lblMargenPresup.Name = "lblMargenPresup"
        Me.lblMargenPresup.Size = New System.Drawing.Size(49, 13)
        Me.lblMargenPresup.TabIndex = 257
        Me.lblMargenPresup.Text = "Margen"
        '
        'ntbMargenPresup
        '
        Me.TryDataBinding(ntbMargenPresup, New System.Windows.Forms.Binding("Value", Me, "MargenPresup", True))
        Me.ntbMargenPresup.DisabledBackColor = System.Drawing.Color.White
        Me.ntbMargenPresup.Location = New System.Drawing.Point(415, 153)
        Me.ntbMargenPresup.Name = "ntbMargenPresup"
        Me.ntbMargenPresup.Size = New System.Drawing.Size(121, 21)
        Me.ntbMargenPresup.TabIndex = 8
        '
        'lblImpPresupModVentaA
        '
        Me.lblImpPresupModVentaA.Location = New System.Drawing.Point(330, 181)
        Me.lblImpPresupModVentaA.Name = "lblImpPresupModVentaA"
        Me.lblImpPresupModVentaA.Size = New System.Drawing.Size(71, 13)
        Me.lblImpPresupModVentaA.TabIndex = 259
        Me.lblImpPresupModVentaA.Text = "Imp. Venta"
        '
        'ntbImpPresupModVentaA
        '
        Me.TryDataBinding(ntbImpPresupModVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupModVentaA", True))
        Me.ntbImpPresupModVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbImpPresupModVentaA.Enabled = False
        Me.ntbImpPresupModVentaA.Location = New System.Drawing.Point(415, 180)
        Me.ntbImpPresupModVentaA.Name = "ntbImpPresupModVentaA"
        Me.ntbImpPresupModVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPresupModVentaA.TabIndex = 260
        '
        'lblPrecioVentaA
        '
        Me.lblPrecioVentaA.Location = New System.Drawing.Point(4, 160)
        Me.lblPrecioVentaA.Name = "lblPrecioVentaA"
        Me.lblPrecioVentaA.Size = New System.Drawing.Size(79, 13)
        Me.lblPrecioVentaA.TabIndex = 261
        Me.lblPrecioVentaA.Text = "Precio Venta"
        '
        'ntbPrecioVentaA
        '
        Me.TryDataBinding(ntbPrecioVentaA, New System.Windows.Forms.Binding("Value", Me, "PrecioVentaA", True))
        Me.ntbPrecioVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbPrecioVentaA.Location = New System.Drawing.Point(98, 160)
        Me.ntbPrecioVentaA.Name = "ntbPrecioVentaA"
        Me.ntbPrecioVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbPrecioVentaA.TabIndex = 7
        '
        'frmAddMOD
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(541, 251)
        Me.Controls.Add(Me.ntbPrecioVentaA)
        Me.Controls.Add(Me.ntbImpPresupModVentaA)
        Me.Controls.Add(Me.ntbMargenPresup)
        Me.Controls.Add(Me.ntbImpPresupModA)
        Me.Controls.Add(Me.ntbTasaPresupModA)
        Me.Controls.Add(Me.ntbHorasPresupMod)
        Me.Controls.Add(Me.ntbHorasUnidad)
        Me.Controls.Add(Me.chbManual)
        Me.Controls.Add(Me.ulDescHora)
        Me.Controls.Add(Me.ulDescCategoria)
        Me.Controls.Add(Me.advIDHora)
        Me.Controls.Add(Me.advIDCategoria)
        Me.Controls.Add(Me.txtSecuencia)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.lblSecuencia)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblIDCategoria)
        Me.Controls.Add(Me.lblIDHora)
        Me.Controls.Add(Me.lblHorasUnidad)
        Me.Controls.Add(Me.lblHorasPresupMod)
        Me.Controls.Add(Me.lblTasaPresupModA)
        Me.Controls.Add(Me.lblImpPresupModA)
        Me.Controls.Add(Me.lblMargenPresup)
        Me.Controls.Add(Me.lblImpPresupModVentaA)
        Me.Controls.Add(Me.lblPrecioVentaA)
        Me.EntityName = "ObraPresupMOD"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddMOD"
        Me.NavigationFields = "IDPresup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de M.O.D."
        Me.ViewName = "VFrmObraPresupMOD"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mdtMod As DataTable
    Private mintIDPresup, mintIDTrabajo As Integer
    Private mdblQPresupTrabajo As Double
    Private mstrIDHora, mstrDescHora As String

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaMOD(ByVal IDPresup As Integer, ByVal IDTrabajo As Integer, ByVal CodTrabajo As String, _
                                 ByVal DescTrabajo As String, ByVal QPresupTrabajo As Double, ByVal IDHora As String, _
                                 ByVal DescHora As String) As DataTable

        txtCodTrabajo.Text = CodTrabajo
        txtDescTrabajo.Text = DescTrabajo
        mintIDPresup = IDPresup
        mintIDTrabajo = IDTrabajo
        mdblQPresupTrabajo = QPresupTrabajo
        mstrIDHora = IDHora
        mstrDescHora = DescHora

        Dim frm As New Form
        frm = Me
        frm.ShowDialog() 'Para que no traiga todos los registros

        If Me.DialogResult = DialogResult.OK Then Return mdtMod
        Return Nothing
    End Function

    Private Sub frmAddMOD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ADDNewMOD()
    End Sub

    Private Sub ADDNewMOD()
        Me.AddNew()

        advIDHora.Text = mstrIDHora
        ulDescHora.Text = mstrDescHora
        Me.CurrentData.Rows(0)("IDPresup") = mintIDPresup
        Me.CurrentData.Rows(0)("IDTrabajoPresup") = mintIDTrabajo
        Me.CurrentData.Rows(0)("CodTrabajo") = txtCodTrabajo.Text
        Me.CurrentData.Rows(0)("IDHora") = advIDHora.Text
        Me.CurrentData.Rows(0)("DescHora") = ulDescHora.Text
        Me.CurrentData.Rows(0)("Manual") = False

        If IsNothing(mdtMod) Then mdtMod = CurrentData.Clone
    End Sub

#End Region

    Private Function ValidaDatosObligatorios() As Boolean
        If length(txtCodTrabajo.Text) = 0 Then
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return True
        End If
        Return False
    End Function

    Private Sub CmbNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbNuevo.Click
        If Not ValidaDatosObligatorios() Then
            mdtMod.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            ADDNewMOD()
        End If
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Not ValidaDatosObligatorios() Then
            Me.DialogResult = DialogResult.OK
            mdtMod.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            Me.RecordsState = UI.RecordsState.Saved
            Me.Close()
        End If
    End Sub

    Private Sub frmAddMOD_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context("QPresupTrabajo") = mdblQPresupTrabajo
    End Sub

End Class