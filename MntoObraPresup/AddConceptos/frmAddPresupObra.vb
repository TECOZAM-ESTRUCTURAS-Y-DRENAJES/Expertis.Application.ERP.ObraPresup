Public Class frmAddPresupObra
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
    Friend WithEvents lblNObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents AdvIDObra As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.lblNObra = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvIDObra = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(464, 40)
        Me.Panel1.TabIndex = 3
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(140, 8)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 25)
        Me.cmbAceptar.TabIndex = 8
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(236, 8)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 25)
        Me.cmbCancelar.TabIndex = 9
        Me.cmbCancelar.Text = "Cancelar"
        '
        'lblNObra
        '
        Me.lblNObra.Location = New System.Drawing.Point(33, 25)
        Me.lblNObra.Name = "lblNObra"
        Me.lblNObra.Size = New System.Drawing.Size(79, 13)
        Me.lblNObra.TabIndex = 181
        Me.lblNObra.Tag = ""
        Me.lblNObra.Text = "Nº. Proyecto"
        '
        'AdvIDObra
        '
        Me.AdvIDObra.DisabledBackColor = System.Drawing.Color.White
        Me.AdvIDObra.DisplayField = "NObra"
        Me.AdvIDObra.EntityName = "ObraCabecera"
        Me.AdvIDObra.Location = New System.Drawing.Point(117, 20)
        Me.AdvIDObra.Name = "AdvIDObra"
        Me.AdvIDObra.PrimaryDataFields = "IDObra"
        Me.AdvIDObra.SecondaryDataFields = "IDObra"
        Me.AdvIDObra.Size = New System.Drawing.Size(136, 23)
        Me.AdvIDObra.TabIndex = 182
        '
        'frmAddPresupObra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(464, 94)
        Me.Controls.Add(Me.AdvIDObra)
        Me.Controls.Add(Me.lblNObra)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmAddPresupObra"
        Me.Text = "Seleccione el Proyecto al que quiere agregar el Presupuesto"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mstrIDCliente, mstrIDTipoObra As String
    Public mIDClase As Integer

    Public WriteOnly Property IDCliente() As String
        Set(ByVal Value As String)
            mstrIDCliente = Value
        End Set
    End Property

    Public WriteOnly Property IDTipoObra() As String
        Set(ByVal Value As String)
            mstrIDTipoObra = Value
        End Set
    End Property

    Private Sub AdvIDObra_SetPredefinedFilter(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchFilterEventArgs) Handles AdvIDObra.SetPredefinedFilter
        e.Filter.Add(New StringFilterItem("IDCliente", mstrIDCliente))
        e.Filter.Add(New StringFilterItem("IDTipoObra", mstrIDTipoObra))
    End Sub

    Private Sub AdvIDObra_SelectionChanged(ByVal sender As Object, ByVal e As Engine.UI.AdvSearchSelectionChangedEventArgs) Handles AdvIDObra.SelectionChanged
        mIDClase = e.Selected.Rows(0)("IDClase")
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = DialogResult.None
        If Length(AdvIDObra.Value) = 0 Then
            ExpertisApp.GenerateMessage("No ha seleccionado una Obra.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        Else
            Me.DialogResult = DialogResult.OK
        End If
    End Sub

End Class
