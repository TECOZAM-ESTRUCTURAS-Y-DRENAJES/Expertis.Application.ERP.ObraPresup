Public Class frmAddCentros
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
    Friend WithEvents chbManual As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblHorasUnidad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbHorasUnidad As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblHorasPresupMod As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblMargenPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbMargenPresup As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPrecioVentaA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbPrecioVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblIDCentro As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDCentro As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents ulDescCentro As Solmicro.Expertis.Engine.UI.UnderLineLabel
    Friend WithEvents ntbHorasPresupCentro As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ntbTasaPresupCentroA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ntbImpPresupCentroA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ntbImpPresupCentroVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblTasaPresupCentroA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpPresupCentroA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpPresupCentroVentaA As Solmicro.Expertis.Engine.UI.Label
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
        Me.lblIDCentro = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDCentro = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.ulDescCentro = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.chbManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblHorasUnidad = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbHorasUnidad = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblHorasPresupMod = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbHorasPresupCentro = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblTasaPresupCentroA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbTasaPresupCentroA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPresupCentroA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPresupCentroA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMargenPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbMargenPresup = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPresupCentroVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPresupCentroVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
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
        Me.Panel1.Location = New System.Drawing.Point(0, 182)
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
        Me.lblCodTrabajo.Size = New System.Drawing.Size(50, 13)
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
        'lblIDCentro
        '
        Me.lblIDCentro.Location = New System.Drawing.Point(4, 34)
        Me.lblIDCentro.Name = "lblIDCentro"
        Me.lblIDCentro.Size = New System.Drawing.Size(46, 13)
        Me.lblIDCentro.TabIndex = 240
        Me.lblIDCentro.Text = "Centro"
        '
        'advIDCentro
        '
        Me.TryDataBinding(advIDCentro, New System.Windows.Forms.Binding("Text", Me, "IDCentro", True))
        Me.advIDCentro.DisabledBackColor = System.Drawing.Color.White
        Me.advIDCentro.EntityName = "Centro"
        Me.advIDCentro.Location = New System.Drawing.Point(71, 34)
        Me.advIDCentro.Name = "advIDCentro"
        Me.advIDCentro.PrimaryDataFields = "IDCentro"
        Me.advIDCentro.SecondaryDataFields = "IDCentro"
        Me.advIDCentro.Size = New System.Drawing.Size(119, 23)
        Me.advIDCentro.TabIndex = 1
        '
        'ulDescCentro
        '
        Me.TryDataBinding(ulDescCentro, New System.Windows.Forms.Binding("Text", Me, "DescCentro", True))
        Me.ulDescCentro.Location = New System.Drawing.Point(195, 34)
        Me.ulDescCentro.Name = "ulDescCentro"
        Me.ulDescCentro.Size = New System.Drawing.Size(337, 21)
        Me.ulDescCentro.TabIndex = 245
        '
        'chbManual
        '
        Me.TryDataBinding(chbManual, New System.Windows.Forms.Binding("BindableValue", Me, "Manual", True))
        Me.chbManual.Location = New System.Drawing.Point(5, 63)
        Me.chbManual.Name = "chbManual"
        Me.chbManual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbManual.Size = New System.Drawing.Size(80, 23)
        Me.chbManual.TabIndex = 3
        Me.chbManual.Text = "Manual"
        Me.chbManual.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far
        '
        'lblHorasUnidad
        '
        Me.lblHorasUnidad.Location = New System.Drawing.Point(111, 66)
        Me.lblHorasUnidad.Name = "lblHorasUnidad"
        Me.lblHorasUnidad.Size = New System.Drawing.Size(83, 13)
        Me.lblHorasUnidad.TabIndex = 249
        Me.lblHorasUnidad.Text = "Horas Unidad"
        '
        'ntbHorasUnidad
        '
        Me.TryDataBinding(ntbHorasUnidad, New System.Windows.Forms.Binding("Value", Me, "HorasUnidad", True))
        Me.ntbHorasUnidad.DisabledBackColor = System.Drawing.Color.White
        Me.ntbHorasUnidad.Location = New System.Drawing.Point(199, 64)
        Me.ntbHorasUnidad.Name = "ntbHorasUnidad"
        Me.ntbHorasUnidad.Size = New System.Drawing.Size(79, 21)
        Me.ntbHorasUnidad.TabIndex = 4
        '
        'lblHorasPresupMod
        '
        Me.lblHorasPresupMod.Location = New System.Drawing.Point(289, 66)
        Me.lblHorasPresupMod.Name = "lblHorasPresupMod"
        Me.lblHorasPresupMod.Size = New System.Drawing.Size(87, 13)
        Me.lblHorasPresupMod.TabIndex = 251
        Me.lblHorasPresupMod.Text = "Horas Presup."
        '
        'ntbHorasPresupCentro
        '
        Me.TryDataBinding(ntbHorasPresupCentro, New System.Windows.Forms.Binding("Value", Me, "HorasPresupCentro", True))
        Me.ntbHorasPresupCentro.DisabledBackColor = System.Drawing.Color.White
        Me.ntbHorasPresupCentro.Location = New System.Drawing.Point(381, 64)
        Me.ntbHorasPresupCentro.Name = "ntbHorasPresupCentro"
        Me.ntbHorasPresupCentro.Size = New System.Drawing.Size(79, 21)
        Me.ntbHorasPresupCentro.TabIndex = 5
        '
        'lblTasaPresupCentroA
        '
        Me.lblTasaPresupCentroA.Location = New System.Drawing.Point(4, 108)
        Me.lblTasaPresupCentroA.Name = "lblTasaPresupCentroA"
        Me.lblTasaPresupCentroA.Size = New System.Drawing.Size(80, 13)
        Me.lblTasaPresupCentroA.TabIndex = 253
        Me.lblTasaPresupCentroA.Text = "Tasa Presup."
        '
        'ntbTasaPresupCentroA
        '
        Me.TryDataBinding(ntbTasaPresupCentroA, New System.Windows.Forms.Binding("Value", Me, "TasaPresupCentroA", True))
        Me.ntbTasaPresupCentroA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbTasaPresupCentroA.Location = New System.Drawing.Point(98, 108)
        Me.ntbTasaPresupCentroA.Name = "ntbTasaPresupCentroA"
        Me.ntbTasaPresupCentroA.Size = New System.Drawing.Size(121, 21)
        Me.ntbTasaPresupCentroA.TabIndex = 6
        '
        'lblImpPresupCentroA
        '
        Me.lblImpPresupCentroA.Location = New System.Drawing.Point(330, 101)
        Me.lblImpPresupCentroA.Name = "lblImpPresupCentroA"
        Me.lblImpPresupCentroA.Size = New System.Drawing.Size(81, 13)
        Me.lblImpPresupCentroA.TabIndex = 255
        Me.lblImpPresupCentroA.Text = "Imp. Presup."
        '
        'ntbImpPresupCentroA
        '
        Me.TryDataBinding(ntbImpPresupCentroA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupCentroA", True))
        Me.ntbImpPresupCentroA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbImpPresupCentroA.Enabled = False
        Me.ntbImpPresupCentroA.Location = New System.Drawing.Point(415, 101)
        Me.ntbImpPresupCentroA.Name = "ntbImpPresupCentroA"
        Me.ntbImpPresupCentroA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPresupCentroA.TabIndex = 256
        '
        'lblMargenPresup
        '
        Me.lblMargenPresup.Location = New System.Drawing.Point(330, 127)
        Me.lblMargenPresup.Name = "lblMargenPresup"
        Me.lblMargenPresup.Size = New System.Drawing.Size(49, 13)
        Me.lblMargenPresup.TabIndex = 257
        Me.lblMargenPresup.Text = "Margen"
        '
        'ntbMargenPresup
        '
        Me.TryDataBinding(ntbMargenPresup, New System.Windows.Forms.Binding("Value", Me, "MargenPresup", True))
        Me.ntbMargenPresup.DisabledBackColor = System.Drawing.Color.White
        Me.ntbMargenPresup.Location = New System.Drawing.Point(415, 127)
        Me.ntbMargenPresup.Name = "ntbMargenPresup"
        Me.ntbMargenPresup.Size = New System.Drawing.Size(121, 21)
        Me.ntbMargenPresup.TabIndex = 8
        '
        'lblImpPresupCentroVentaA
        '
        Me.lblImpPresupCentroVentaA.Location = New System.Drawing.Point(330, 155)
        Me.lblImpPresupCentroVentaA.Name = "lblImpPresupCentroVentaA"
        Me.lblImpPresupCentroVentaA.Size = New System.Drawing.Size(70, 13)
        Me.lblImpPresupCentroVentaA.TabIndex = 259
        Me.lblImpPresupCentroVentaA.Text = "Imp. Venta"
        '
        'ntbImpPresupCentroVentaA
        '
        Me.TryDataBinding(ntbImpPresupCentroVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupCentroVentaA", True))
        Me.ntbImpPresupCentroVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbImpPresupCentroVentaA.Enabled = False
        Me.ntbImpPresupCentroVentaA.Location = New System.Drawing.Point(415, 154)
        Me.ntbImpPresupCentroVentaA.Name = "ntbImpPresupCentroVentaA"
        Me.ntbImpPresupCentroVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPresupCentroVentaA.TabIndex = 260
        '
        'lblPrecioVentaA
        '
        Me.lblPrecioVentaA.Location = New System.Drawing.Point(4, 134)
        Me.lblPrecioVentaA.Name = "lblPrecioVentaA"
        Me.lblPrecioVentaA.Size = New System.Drawing.Size(78, 13)
        Me.lblPrecioVentaA.TabIndex = 261
        Me.lblPrecioVentaA.Text = "Precio Venta"
        '
        'ntbPrecioVentaA
        '
        Me.TryDataBinding(ntbPrecioVentaA, New System.Windows.Forms.Binding("Value", Me, "PrecioVentaA", True))
        Me.ntbPrecioVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbPrecioVentaA.Location = New System.Drawing.Point(98, 134)
        Me.ntbPrecioVentaA.Name = "ntbPrecioVentaA"
        Me.ntbPrecioVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbPrecioVentaA.TabIndex = 7
        '
        'frmAddCentros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(541, 224)
        Me.Controls.Add(Me.ntbPrecioVentaA)
        Me.Controls.Add(Me.ntbImpPresupCentroVentaA)
        Me.Controls.Add(Me.ntbMargenPresup)
        Me.Controls.Add(Me.ntbImpPresupCentroA)
        Me.Controls.Add(Me.ntbTasaPresupCentroA)
        Me.Controls.Add(Me.ntbHorasPresupCentro)
        Me.Controls.Add(Me.ntbHorasUnidad)
        Me.Controls.Add(Me.chbManual)
        Me.Controls.Add(Me.ulDescCentro)
        Me.Controls.Add(Me.advIDCentro)
        Me.Controls.Add(Me.txtSecuencia)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.lblSecuencia)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblIDCentro)
        Me.Controls.Add(Me.lblHorasUnidad)
        Me.Controls.Add(Me.lblHorasPresupMod)
        Me.Controls.Add(Me.lblTasaPresupCentroA)
        Me.Controls.Add(Me.lblImpPresupCentroA)
        Me.Controls.Add(Me.lblMargenPresup)
        Me.Controls.Add(Me.lblImpPresupCentroVentaA)
        Me.Controls.Add(Me.lblPrecioVentaA)
        Me.EntityName = "ObraPresupCentro"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddCentros"
        Me.NavigationFields = "IDPresup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Centros"
        Me.ViewName = "vFrmObraPresupCentro"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mdtCentros As DataTable
    Private mintIDPresup, mintIDTrabajo As Integer
    Private mdblQPresupTrabajo As Double

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaCentros(ByVal IDPresup As Integer, ByVal IDTrabajo As Integer, ByVal CodTrabajo As String, _
                                     ByVal DescTrabajo As String, ByVal QPresupTrabajo As Double) As DataTable

        txtCodTrabajo.Text = CodTrabajo
        txtDescTrabajo.Text = DescTrabajo
        mintIDPresup = IDPresup
        mintIDTrabajo = IDTrabajo
        mdblQPresupTrabajo = QPresupTrabajo

        Dim frm As New Form
        frm = Me
        frm.ShowDialog() 'Para que no traiga todos los registros
        If Me.DialogResult = DialogResult.OK Then Return mdtCentros
        Return Nothing
    End Function

    Private Sub frmAddMOD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ADDNewMOD()
    End Sub

    Private Sub ADDNewMOD()
        Me.AddNew()

        Me.CurrentData.Rows(0)("IDPresup") = mintIDPresup
        Me.CurrentData.Rows(0)("IDTrabajoPresup") = mintIDTrabajo
        Me.CurrentData.Rows(0)("CodTrabajo") = txtCodTrabajo.Text
        Me.CurrentData.Rows(0)("Manual") = False

        If IsNothing(mdtCentros) Then mdtCentros = CurrentData.Clone
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
            mdtCentros.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            ADDNewMOD()
        End If
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.DialogResult = DialogResult.None
        If Not ValidaDatosObligatorios() Then
            mdtCentros.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            Me.DialogResult = DialogResult.OK
        End If
        Me.RecordsState = UI.RecordsState.Saved
    End Sub

    Private Sub frmAddCentros_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context("QPresupTrabajo") = mdblQPresupTrabajo
    End Sub

End Class