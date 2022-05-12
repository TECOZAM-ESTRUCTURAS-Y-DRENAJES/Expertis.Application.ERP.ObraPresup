Public Class frmAddTrabajosIncremento
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
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblIncremento As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtIncremento As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents lblTextoTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtTextoTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.lblIncremento = New Solmicro.Expertis.Engine.UI.Label
        Me.txtIncremento = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.lblTextoTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtTextoTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Controls.Add(Me.CmbAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(488, 42)
        Me.Panel1.TabIndex = 231
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(251, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 9
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(151, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 8
        Me.CmbAceptar.Text = "Aceptar"
        '
        'lblIncremento
        '
        Me.lblIncremento.Location = New System.Drawing.Point(6, 29)
        Me.lblIncremento.Name = "lblIncremento"
        Me.lblIncremento.Size = New System.Drawing.Size(73, 13)
        Me.lblIncremento.TabIndex = 267
        Me.lblIncremento.Tag = ""
        Me.lblIncremento.Text = "Incremento"
        '
        'txtIncremento
        '
        Me.TryDataBinding(txtIncremento, New System.Windows.Forms.Binding("Value", Me, "Incremento", True))
        Me.txtIncremento.DisabledBackColor = System.Drawing.Color.White
        Me.txtIncremento.Location = New System.Drawing.Point(98, 29)
        Me.txtIncremento.Name = "txtIncremento"
        Me.txtIncremento.Size = New System.Drawing.Size(124, 21)
        Me.txtIncremento.TabIndex = 6
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(6, 4)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(82, 13)
        Me.lblCodTrabajo.TabIndex = 264
        Me.lblCodTrabajo.Tag = "IdRec=5280;"
        Me.lblCodTrabajo.Text = "Cód. Trabajo"
        '
        'lblTextoTrabajo
        '
        Me.lblTextoTrabajo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTextoTrabajo.Location = New System.Drawing.Point(4, 55)
        Me.lblTextoTrabajo.Name = "lblTextoTrabajo"
        Me.lblTextoTrabajo.Size = New System.Drawing.Size(91, 13)
        Me.lblTextoTrabajo.TabIndex = 261
        Me.lblTextoTrabajo.Text = "Observaciones"
        '
        'txtTextoTrabajo
        '
        Me.TryDataBinding(txtTextoTrabajo, New System.Windows.Forms.Binding("Text", Me, "Texto", True))
        Me.txtTextoTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtTextoTrabajo.Location = New System.Drawing.Point(98, 54)
        Me.txtTextoTrabajo.Multiline = True
        Me.txtTextoTrabajo.Name = "txtTextoTrabajo"
        Me.txtTextoTrabajo.Size = New System.Drawing.Size(387, 61)
        Me.txtTextoTrabajo.TabIndex = 7
        '
        'txtDescTrabajo
        '
        Me.TryDataBinding(txtDescTrabajo, New System.Windows.Forms.Binding("Text", Me, "DescTrabajo", True))
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Location = New System.Drawing.Point(225, 4)
        Me.txtDescTrabajo.Multiline = True
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(261, 46)
        Me.txtDescTrabajo.TabIndex = 4
        '
        'txtCodTrabajo
        '
        Me.TryDataBinding(txtCodTrabajo, New System.Windows.Forms.Binding("Text", Me, "CodTrabajo", True))
        Me.txtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajo.Location = New System.Drawing.Point(98, 4)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(124, 21)
        Me.txtCodTrabajo.TabIndex = 3
        '
        'frmAddTrabajosIncremento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(488, 158)
        Me.Controls.Add(Me.lblIncremento)
        Me.Controls.Add(Me.txtIncremento)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.lblTextoTrabajo)
        Me.Controls.Add(Me.txtTextoTrabajo)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.Panel1)
        Me.EntityName = "ObraTrabajoPresup"
        Me.MaximizeBox = False
        Me.Name = "frmAddTrabajosIncremento"
        Me.NavigationFields = "IDTrabajoPresup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de trabajos (de tipo incremento)"
        Me.ViewName = "tbObraTrabajoPresup"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim mintIDPresup, mintIDTrabajoPadre As Integer
    Dim mstrNumeroPedido, mstrIDTipoObra, mstrIDTipoTrabajo, mstrIDSubTipoTrabajo, mstrIDSubSubTipoTrabajo, mstrIDCliente, mstrIDUDMedida As String
    Dim mblnNoAcumular As Boolean
    Dim mContext As BusinessData
    Dim mstrCodTrabajo As String

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaTrabajos(ByVal intIDPresup As Integer, ByVal strIDTipoObra As String, _
                                      ByVal strIDUDMedida As String, ByVal strNumPedido As String, _
                                      ByVal strIDTipoTrabajo As String, ByVal strIDSubTipoTrabajo As String, _
                                      ByVal strIDSubSubTipoTrabajo As String, ByVal intIDTrabajoPadre As Integer, _
                                      ByVal blnNoAcumular As Boolean, ByVal strIDCliente As String, _
                                      ByVal Context As BusinessData, ByVal OwnerForm As FormBase) As DataRow

        mintIDPresup = intIDPresup
        mstrNumeroPedido = strNumPedido
        mintIDTrabajoPadre = intIDTrabajoPadre
        mstrIDTipoObra = strIDTipoObra
        mstrIDUDMedida = strIDUDMedida
        mstrIDTipoTrabajo = strIDTipoTrabajo
        mstrIDSubTipoTrabajo = strIDSubTipoTrabajo
        mstrIDSubSubTipoTrabajo = strIDSubSubTipoTrabajo
        mblnNoAcumular = blnNoAcumular
        mstrIDCliente = strIDCliente
        mContext = Context

        Dim frm As New Form
        frm = Me
        frm.ShowDialog(OwnerForm) 'Para que no traiga todos los registros

        If Me.DialogResult = DialogResult.OK Then Return SetTrabajo()
        Return Nothing
    End Function

    Private Function SetTrabajo() As DataRow
        Dim dtTrabajo As DataTable = New BE.DataEngine().Filter(mContext("ViewName"), New NoRowsFilterItem())
        Dim dr As DataRow = dtTrabajo.NewRow
        Dim bd As New BusinessData(dr)
        For Each dc As DataColumn In Me.CurrentData.Columns
            If bd.ContainsKey(dc.ColumnName) Then
                dr(dc.ColumnName) = Me.CurrentData.Rows(0)(dc.ColumnName)
            End If
        Next
        Return dr
    End Function

    Private Sub FrmAddTrabajos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AddNew()

        Me.CurrentData.Rows(0)("IDPresup") = mintIDPresup
        Me.CurrentData.Rows(0)("IDTipoObra") = mstrIDTipoObra
        If length(mstrIDTipoTrabajo) > 0 Then Me.CurrentData.Rows(0)("IDTipoTrabajo") = mstrIDTipoTrabajo
        If length(mstrIDSubTipoTrabajo) > 0 Then Me.CurrentData.Rows(0)("IDSubTipoTrabajo") = mstrIDSubTipoTrabajo
        If length(mstrIDSubSubTipoTrabajo) > 0 Then Me.CurrentData.Rows(0)("SubSubTipoTrabajo") = mstrIDSubSubTipoTrabajo
        If mContext.Contains("CodTrabajo") Then Me.CurrentData.Rows(0)("CodTrabajo") = mContext("CodTrabajo")

        Me.CurrentData.Rows(0)("NoAcumular") = mblnNoAcumular
        Me.CurrentData.Rows(0)("QPresup") = 1
        Me.CurrentData.Rows(0)("IDUDMedida") = mstrIDUDMedida
        Me.CurrentData.Rows(0)("Estado") = CInt(enumotEstado.otPendiente)
        Me.CurrentData.Rows(0)("TipoLinea") = CInt(enumTipoLineaTrabajoSoloPorcentajes.tltPorcentajeConcepto)
        If mintIDTrabajoPadre > 0 Then Me.CurrentData.Rows(0)("IDTrabajoPresupPadre") = mintIDTrabajoPadre
        If length(mstrNumeroPedido) > 0 Then Me.CurrentData.Rows(0)("NumeroPedido") = mstrNumeroPedido
        mstrCodTrabajo = Me.CurrentData.Rows(0)("CodTrabajo") & String.Empty
    End Sub

#End Region

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Length(txtCodTrabajo.Text) > 0 Then
            Me.DialogResult = DialogResult.OK
        Else
            ExpertisApp.GenerateMessage("El Trabajo es un dato obligatorio.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtCodTrabajo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodTrabajo.Validating
        If length(txtCodTrabajo.Text) > 0 Then
            Dim dvTrabajos As New DataView(mContext("dtTrabajos"))
            Dim f As New Filter
            f.Add(New StringFilterItem("CodTrabajo", txtCodTrabajo.Text))
            If mContext("PorNivel") Then
                f.Add(New NumberFilterItem("IDTrabajoPresupPadre", mContext("IDTrabajoPadre")))
            Else
                f.Add(New IsNullFilterItem("IDTrabajoPresupPadre", True))
            End If
            dvTrabajos.RowFilter = f.Compose(New AdoFilterComposer)
            If dvTrabajos.Count <> 0 Then
                e.Cancel = True
                txtCodTrabajo.Text = mstrCodTrabajo
                ExpertisApp.GenerateMessage("Este Trabajo ya existe a ese nivel.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                mstrCodTrabajo = txtCodTrabajo.Text
            End If
        End If
    End Sub

    Private Sub FrmAddTrabajos_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context = mContext
    End Sub

End Class
