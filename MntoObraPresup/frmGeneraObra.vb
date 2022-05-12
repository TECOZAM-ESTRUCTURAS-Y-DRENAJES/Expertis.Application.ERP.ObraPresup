Public Class frmGeneraObra
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
    Friend WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents lblClaseObra As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents cbxIDClase As Solmicro.Expertis.Engine.UI.ComboBox
    Public WithEvents AdvContador As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblContador As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents txtNObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblNObra As Solmicro.Expertis.Engine.UI.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim cbxIDClase_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneraObra))
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.lblClaseObra = New Solmicro.Expertis.Engine.UI.Label
        Me.cbxIDClase = New Solmicro.Expertis.Engine.UI.ComboBox
        Me.AdvContador = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblContador = New Solmicro.Expertis.Engine.UI.Label
        Me.txtNObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblNObra = New Solmicro.Expertis.Engine.UI.Label
        Me.Panel1.suspendlayout()
        CType(Me.cbxIDClase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmbAceptar)
        Me.Panel1.Controls.Add(Me.cmbCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(307, 48)
        Me.Panel1.TabIndex = 3
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(61, 7)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(89, 33)
        Me.cmbAceptar.TabIndex = 2
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(157, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(89, 33)
        Me.cmbCancelar.TabIndex = 3
        Me.cmbCancelar.Text = "Cancelar"
        '
        'lblClaseObra
        '
        Me.lblClaseObra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClaseObra.Location = New System.Drawing.Point(29, 63)
        Me.lblClaseObra.Name = "lblClaseObra"
        Me.lblClaseObra.Size = New System.Drawing.Size(39, 13)
        Me.lblClaseObra.TabIndex = 172
        Me.lblClaseObra.Tag = ""
        Me.lblClaseObra.Text = "Clase"
        '
        'cbxIDClase
        '
        Me.cbxIDClase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cbxIDClase_DesignTimeLayout.LayoutString = resources.GetString("cbxIDClase_DesignTimeLayout.LayoutString")
        Me.cbxIDClase.DesignTimeLayout = cbxIDClase_DesignTimeLayout
        Me.cbxIDClase.DisabledBackColor = System.Drawing.Color.White
        Me.cbxIDClase.DisplayMember = "Value"
        Me.cbxIDClase.Location = New System.Drawing.Point(111, 59)
        Me.cbxIDClase.Name = "cbxIDClase"
        Me.cbxIDClase.PrimaryDataFields = "Estado"
        Me.cbxIDClase.SecondaryDataFields = "Value"
        Me.cbxIDClase.SelectedIndex = -1
        Me.cbxIDClase.SelectedItem = Nothing
        Me.cbxIDClase.Size = New System.Drawing.Size(141, 21)
        Me.cbxIDClase.TabIndex = 1
        '
        'AdvContador
        '
        Me.AdvContador.DisabledBackColor = System.Drawing.Color.White
        Me.AdvContador.EntityName = "EntidadContador"
        Me.AdvContador.Location = New System.Drawing.Point(111, 9)
        Me.AdvContador.Name = "AdvContador"
        Me.AdvContador.PrimaryDataFields = "IDContador"
        Me.AdvContador.SecondaryDataFields = "IDContador"
        Me.AdvContador.Size = New System.Drawing.Size(141, 23)
        Me.AdvContador.TabIndex = 0
        Me.AdvContador.ViewName = "tbEntidadContador"
        '
        'lblContador
        '
        Me.lblContador.Location = New System.Drawing.Point(29, 14)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(60, 13)
        Me.lblContador.TabIndex = 179
        Me.lblContador.Tag = ""
        Me.lblContador.Text = "Contador"
        '
        'txtNObra
        '
        Me.txtNObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtNObra.Location = New System.Drawing.Point(111, 35)
        Me.txtNObra.Name = "txtNObra"
        Me.txtNObra.Size = New System.Drawing.Size(141, 21)
        Me.txtNObra.TabIndex = 180
        Me.txtNObra.TabStop = False
        '
        'lblNObra
        '
        Me.lblNObra.Location = New System.Drawing.Point(29, 39)
        Me.lblNObra.Name = "lblNObra"
        Me.lblNObra.Size = New System.Drawing.Size(79, 13)
        Me.lblNObra.TabIndex = 181
        Me.lblNObra.Tag = ""
        Me.lblNObra.Text = "Nº. Proyecto"
        '
        'frmGeneraObra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(307, 132)
        Me.Controls.Add(Me.txtNObra)
        Me.Controls.Add(Me.lblNObra)
        Me.Controls.Add(Me.AdvContador)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.lblClaseObra)
        Me.Controls.Add(Me.cbxIDClase)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "frmGeneraObra"
        Me.Text = "Generar Proyecto"
        Me.Panel1.ResumeLayout(False)
        CType(Me.cbxIDClase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmClaseObra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbxIDClase.DataSource = New EnumData("enumClaseObra")
        cbxIDClase.Value = enumClaseObra.FacturacionControl
    End Sub

    Private Sub AdvContador_SetPredefinedFilter(ByVal sender As System.Object, ByVal e As Solmicro.Expertis.Engine.UI.AdvSearchFilterEventArgs) Handles AdvContador.SetPredefinedFilter
        e.Filter.Add("Entidad", FilterOperator.Equal, GetType(ObraCabecera).Name)
    End Sub

    Private Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Dim blnCancel As Boolean = False
        If Length(cbxIDClase.Value) = 0 And Length(AdvContador.Value) = 0 Then
            If ExpertisApp.GenerateMessage("No ha seleccionado una Clase ni un Contador. Por defecto se cogerá 'Facturación y Control' y el contador predeterminado de Obras. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                blnCancel = True
            End If
        ElseIf Length(AdvContador.Value) = 0 Then
            If ExpertisApp.GenerateMessage("No ha seleccionado un Contador. Por defecto se cogerá el predeterminado de Proyectos. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                blnCancel = True
            End If
        ElseIf Length(cbxIDClase.Value) = 0 Then
            If ExpertisApp.GenerateMessage("No ha seleccionado una Clase. Por defecto se cogerá 'Facturación y Control'. ¿Desea continuar.?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                blnCancel = True
            Else
                cbxIDClase.Value = enumClaseObra.FacturacionControl
            End If
        End If
        If Not blnCancel Then
            Me.DialogResult = DialogResult.OK
        Else
            Me.DialogResult = Windows.Forms.DialogResult.None
        End If
    End Sub

End Class
