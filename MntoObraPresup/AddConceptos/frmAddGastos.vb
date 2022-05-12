Public Class frmAddGastos
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
    Friend WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDGasto As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents txtDescGasto As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblIDGasto As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbMargenPresup As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblMargenPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbImpPresupGastoVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents ntbImpPresupGastoA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpPresupGastoA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblImpPresupGastoVentaA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents chbManual As Solmicro.Expertis.Engine.UI.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbNuevo = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.advIDGasto = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.txtDescGasto = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblIDGasto = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPresupGastoVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ntbMargenPresup = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.ntbImpPresupGastoA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPresupGastoA = New Solmicro.Expertis.Engine.UI.Label
        Me.lblMargenPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.lblImpPresupGastoVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.chbManual = New Solmicro.Expertis.Engine.UI.CheckBox
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
        Me.Panel1.Location = New System.Drawing.Point(0, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 42)
        Me.Panel1.TabIndex = 235
        '
        'CmbNuevo
        '
        Me.CmbNuevo.Location = New System.Drawing.Point(122, 7)
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(94, 29)
        Me.CmbNuevo.TabIndex = 6
        Me.CmbNuevo.Text = "Nuevo"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(322, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 8
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(222, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 7
        Me.CmbAceptar.Text = "Aceptar"
        '
        'advIDGasto
        '
        Me.TryDataBinding(advIDGasto, New System.Windows.Forms.Binding("Text", Me, "IDGasto", True))
        Me.advIDGasto.DisabledBackColor = System.Drawing.Color.White
        Me.advIDGasto.EntityName = "Gasto"
        Me.advIDGasto.Location = New System.Drawing.Point(71, 34)
        Me.advIDGasto.Name = "advIDGasto"
        Me.advIDGasto.PrimaryDataFields = "IDGasto"
        Me.advIDGasto.SecondaryDataFields = "IDGasto"
        Me.advIDGasto.Size = New System.Drawing.Size(119, 23)
        Me.advIDGasto.TabIndex = 0
        '
        'txtDescGasto
        '
        Me.TryDataBinding(txtDescGasto, New System.Windows.Forms.Binding("Text", Me, "DescGasto", True))
        Me.txtDescGasto.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescGasto.Location = New System.Drawing.Point(195, 34)
        Me.txtDescGasto.Name = "txtDescGasto"
        Me.txtDescGasto.Size = New System.Drawing.Size(342, 21)
        Me.txtDescGasto.TabIndex = 1
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(195, 8)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(342, 21)
        Me.txtDescTrabajo.TabIndex = 239
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
        Me.lblCodTrabajo.Location = New System.Drawing.Point(4, 8)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblCodTrabajo.TabIndex = 238
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'lblIDGasto
        '
        Me.lblIDGasto.Location = New System.Drawing.Point(4, 36)
        Me.lblIDGasto.Name = "lblIDGasto"
        Me.lblIDGasto.Size = New System.Drawing.Size(40, 13)
        Me.lblIDGasto.TabIndex = 243
        Me.lblIDGasto.Text = "Gasto"
        '
        'ntbImpPresupGastoVentaA
        '
        Me.TryDataBinding(ntbImpPresupGastoVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupGastoVentaA", True))
        Me.ntbImpPresupGastoVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbImpPresupGastoVentaA.Location = New System.Drawing.Point(416, 90)
        Me.ntbImpPresupGastoVentaA.Name = "ntbImpPresupGastoVentaA"
        Me.ntbImpPresupGastoVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPresupGastoVentaA.TabIndex = 5
        '
        'ntbMargenPresup
        '
        Me.TryDataBinding(ntbMargenPresup, New System.Windows.Forms.Binding("Value", Me, "MargenPresup", True))
        Me.ntbMargenPresup.DisabledBackColor = System.Drawing.Color.White
        Me.ntbMargenPresup.Location = New System.Drawing.Point(261, 90)
        Me.ntbMargenPresup.Name = "ntbMargenPresup"
        Me.ntbMargenPresup.Size = New System.Drawing.Size(61, 21)
        Me.ntbMargenPresup.TabIndex = 4
        '
        'ntbImpPresupGastoA
        '
        Me.TryDataBinding(ntbImpPresupGastoA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupGastoA", True))
        Me.ntbImpPresupGastoA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbImpPresupGastoA.Location = New System.Drawing.Point(91, 90)
        Me.ntbImpPresupGastoA.Name = "ntbImpPresupGastoA"
        Me.ntbImpPresupGastoA.Size = New System.Drawing.Size(109, 21)
        Me.ntbImpPresupGastoA.TabIndex = 3
        '
        'lblImpPresupGastoA
        '
        Me.lblImpPresupGastoA.Location = New System.Drawing.Point(4, 94)
        Me.lblImpPresupGastoA.Name = "lblImpPresupGastoA"
        Me.lblImpPresupGastoA.Size = New System.Drawing.Size(81, 13)
        Me.lblImpPresupGastoA.TabIndex = 245
        Me.lblImpPresupGastoA.Text = "Imp. Presup."
        '
        'lblMargenPresup
        '
        Me.lblMargenPresup.Location = New System.Drawing.Point(208, 94)
        Me.lblMargenPresup.Name = "lblMargenPresup"
        Me.lblMargenPresup.Size = New System.Drawing.Size(49, 13)
        Me.lblMargenPresup.TabIndex = 247
        Me.lblMargenPresup.Text = "Margen"
        '
        'lblImpPresupGastoVentaA
        '
        Me.lblImpPresupGastoVentaA.Location = New System.Drawing.Point(339, 94)
        Me.lblImpPresupGastoVentaA.Name = "lblImpPresupGastoVentaA"
        Me.lblImpPresupGastoVentaA.Size = New System.Drawing.Size(71, 13)
        Me.lblImpPresupGastoVentaA.TabIndex = 248
        Me.lblImpPresupGastoVentaA.Text = "Imp. Venta"
        '
        'chbManual
        '
        Me.TryDataBinding(chbManual, New System.Windows.Forms.Binding("BindableValue", Me, "AplicarQ", True))
        Me.chbManual.Location = New System.Drawing.Point(4, 60)
        Me.chbManual.Name = "chbManual"
        Me.chbManual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbManual.Size = New System.Drawing.Size(82, 27)
        Me.chbManual.TabIndex = 2
        Me.chbManual.Text = "Aplicar Cantidad"
        Me.chbManual.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far
        '
        'frmAddGastos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(541, 160)
        Me.Controls.Add(Me.chbManual)
        Me.Controls.Add(Me.ntbImpPresupGastoVentaA)
        Me.Controls.Add(Me.ntbMargenPresup)
        Me.Controls.Add(Me.ntbImpPresupGastoA)
        Me.Controls.Add(Me.lblImpPresupGastoA)
        Me.Controls.Add(Me.lblMargenPresup)
        Me.Controls.Add(Me.lblImpPresupGastoVentaA)
        Me.Controls.Add(Me.advIDGasto)
        Me.Controls.Add(Me.txtDescGasto)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.lblIDGasto)
        Me.Controls.Add(Me.Panel1)
        Me.EntityName = "ObraPresupGasto"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddGastos"
        Me.NavigationFields = "IDPresup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Gastos"
        Me.ViewName = "VFrmObraPresupGasto"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mdtGastos As DataTable
    Private mintIDPresup, mintIDTrabajo As Integer
    '  Private mblnCancel As Boolean

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaGastos(ByVal IDPresup As Integer, ByVal IDTrabajo As Integer, ByVal CodTrabajo As String, _
                                    ByVal DescTrabajo As String) As DataTable

        txtCodTrabajo.Text = CodTrabajo
        txtDescTrabajo.Text = DescTrabajo
        mintIDPresup = IDPresup
        mintIDTrabajo = IDTrabajo

        Dim frm As New Form
        frm = Me
        frm.ShowDialog() 'Para que no traiga todos los registros

        If Me.DialogResult = DialogResult.OK Then Return mdtGastos
        Return Nothing
    End Function

    Private Sub frmAddGastos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ADDNewGasto()
    End Sub

    Private Sub ADDNewGasto()
        Me.AddNew()

        Me.CurrentData.Rows(0)("IDPresup") = mintIDPresup
        Me.CurrentData.Rows(0)("IDTrabajoPresup") = mintIDTrabajo
        Me.CurrentData.Rows(0)("CodTrabajo") = txtCodTrabajo.Text
        Me.CurrentData.Rows(0)("AplicarQ") = False

        If IsNothing(mdtGastos) Then mdtGastos = CurrentData.Clone
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
            mdtGastos.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            ADDNewGasto()
        End If
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.DialogResult = DialogResult.None
        If Not ValidaDatosObligatorios() Then
            Me.DialogResult = DialogResult.OK
            mdtGastos.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            Me.RecordsState = UI.RecordsState.Saved
            Me.Close()
        End If
    End Sub

End Class
