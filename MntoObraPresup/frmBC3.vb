Public Class frmBC3
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
    Public WithEvents Label11 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents Label10 As Solmicro.Expertis.Engine.UI.Label
    Public WithEvents pnlConfigImportacion As Solmicro.Expertis.Engine.UI.Panel

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Public WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents txtRuta As Solmicro.Expertis.Engine.UI.TextBox
    Public WithEvents CmbRuta As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents OpenDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents pnlGeneral As Solmicro.Expertis.Engine.UI.Panel
    Public WithEvents chkCentros As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkMod As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkMateriales As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkConceptosAll As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents chkMediciones As Solmicro.Expertis.Engine.UI.CheckBox
    Public WithEvents cmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Public WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBC3))
        Me.Label11 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label10 = New Solmicro.Expertis.Engine.UI.Label
        Me.pnlConfigImportacion = New Solmicro.Expertis.Engine.UI.Panel
        Me.cmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtRuta = New Solmicro.Expertis.Engine.UI.TextBox
        Me.CmbRuta = New Solmicro.Expertis.Engine.UI.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.OpenDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.pnlGeneral = New Solmicro.Expertis.Engine.UI.Panel
        Me.chkMediciones = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkCentros = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMod = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkMateriales = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.chkConceptosAll = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.pnlConfigImportacion.suspendlayout()
        Me.pnlGeneral.suspendlayout()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(50, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(5, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Ruta:"
        '
        'pnlConfigImportacion
        '
        Me.pnlConfigImportacion.Controls.Add(Me.cmbAceptar)
        Me.pnlConfigImportacion.Controls.Add(Me.cmbCancelar)
        Me.pnlConfigImportacion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlConfigImportacion.Location = New System.Drawing.Point(0, 149)
        Me.pnlConfigImportacion.Name = "pnlConfigImportacion"
        Me.pnlConfigImportacion.Size = New System.Drawing.Size(424, 40)
        Me.pnlConfigImportacion.TabIndex = 2
        '
        'cmbAceptar
        '
        Me.cmbAceptar.Location = New System.Drawing.Point(108, 6)
        Me.cmbAceptar.Name = "cmbAceptar"
        Me.cmbAceptar.Size = New System.Drawing.Size(100, 28)
        Me.cmbAceptar.TabIndex = 32
        Me.cmbAceptar.Text = "Aceptar"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(216, 6)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(100, 28)
        Me.cmbCancelar.TabIndex = 33
        Me.cmbCancelar.Text = "Cancelar"
        '
        'txtRuta
        '
        Me.txtRuta.DisabledBackColor = System.Drawing.Color.White
        Me.txtRuta.Location = New System.Drawing.Point(45, 8)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(351, 21)
        Me.txtRuta.TabIndex = 34
        '
        'CmbRuta
        '
        Me.CmbRuta.ImageIndex = 0
        Me.CmbRuta.ImageList = Me.ImageList1
        Me.CmbRuta.Location = New System.Drawing.Point(399, 8)
        Me.CmbRuta.Name = "CmbRuta"
        Me.CmbRuta.Size = New System.Drawing.Size(21, 21)
        Me.CmbRuta.TabIndex = 35
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        '
        'OpenDialog1
        '
        Me.OpenDialog1.DefaultExt = "*.doc"
        '
        'pnlGeneral
        '
        Me.pnlGeneral.Controls.Add(Me.chkMediciones)
        Me.pnlGeneral.Controls.Add(Me.chkCentros)
        Me.pnlGeneral.Controls.Add(Me.chkMod)
        Me.pnlGeneral.Controls.Add(Me.chkMateriales)
        Me.pnlGeneral.Controls.Add(Me.chkConceptosAll)
        Me.pnlGeneral.Location = New System.Drawing.Point(8, 35)
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(416, 109)
        Me.pnlGeneral.TabIndex = 36
        '
        'chkMediciones
        '
        Me.chkMediciones.Location = New System.Drawing.Point(40, 83)
        Me.chkMediciones.Name = "chkMediciones"
        Me.chkMediciones.Size = New System.Drawing.Size(244, 21)
        Me.chkMediciones.TabIndex = 5
        Me.chkMediciones.Text = "Importar el Concepto de Mediciones"
        '
        'chkCentros
        '
        Me.chkCentros.Location = New System.Drawing.Point(40, 64)
        Me.chkCentros.Name = "chkCentros"
        Me.chkCentros.Size = New System.Drawing.Size(244, 21)
        Me.chkCentros.TabIndex = 4
        Me.chkCentros.Text = "Importar el Concepto de Centros"
        '
        'chkMod
        '
        Me.chkMod.Location = New System.Drawing.Point(40, 45)
        Me.chkMod.Name = "chkMod"
        Me.chkMod.Size = New System.Drawing.Size(244, 21)
        Me.chkMod.TabIndex = 3
        Me.chkMod.Text = "Importar el Concepto de M.O.D."
        '
        'chkMateriales
        '
        Me.chkMateriales.Location = New System.Drawing.Point(40, 25)
        Me.chkMateriales.Name = "chkMateriales"
        Me.chkMateriales.Size = New System.Drawing.Size(244, 21)
        Me.chkMateriales.TabIndex = 2
        Me.chkMateriales.Text = "Importar el Concepto de Materiales"
        '
        'chkConceptosAll
        '
        Me.chkConceptosAll.Location = New System.Drawing.Point(18, 4)
        Me.chkConceptosAll.Name = "chkConceptosAll"
        Me.chkConceptosAll.Size = New System.Drawing.Size(222, 21)
        Me.chkConceptosAll.TabIndex = 1
        Me.chkConceptosAll.Text = "Importar todos los Conceptos"
        '
        'frmBC3
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(424, 189)
        Me.Controls.Add(Me.pnlGeneral)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.CmbRuta)
        Me.Controls.Add(Me.pnlConfigImportacion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.MaximizeBox = False
        Me.Name = "frmBC3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Importación BC3"
        Me.pnlConfigImportacion.ResumeLayout(False)
        Me.pnlGeneral.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Protected blnMarcoAll As Boolean

#Region " Load "

    Protected Overridable Sub FrmCopiaObra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkConceptosAll.Checked = True
    End Sub

#End Region

    Protected Overridable Overloads Sub CmbRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbRuta.Click
        OpenDialog1.InitialDirectory = ExpertisApp.Path
        OpenDialog1.ShowDialog()

        If OpenDialog1.FileName <> String.Empty Then
            txtRuta.Text = OpenDialog1.FileName
        End If
    End Sub

    Protected Overridable Sub TodosMarcados()
        If chkMateriales.Checked And chkMod.Checked And chkCentros.Checked And chkMediciones.Checked Then
            chkConceptosAll.Checked = True
        Else
            chkConceptosAll.Checked = False
        End If
    End Sub

    Protected Overridable Sub Conceptos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCentros.CheckedChanged
        If Not blnMarcoAll Then TodosMarcados()
    End Sub

    Protected Overridable Sub chkConceptosAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkConceptosAll.CheckedChanged
        blnMarcoAll = True
        If chkConceptosAll.Checked Then
            chkMateriales.Checked = chkConceptosAll.Checked
            chkMod.Checked = chkConceptosAll.Checked
            chkCentros.Checked = chkConceptosAll.Checked
            chkMediciones.Checked = chkConceptosAll.Checked
        End If
        chkConceptosAll.Enabled = Not chkConceptosAll.Checked
        blnMarcoAll = False
    End Sub

    Protected Overridable Sub cmbAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Length(txtRuta.Text) > 0 Then
            Me.DialogResult = DialogResult.OK
        Else
            ExpertisApp.GenerateMessage("Debe seleccionar el archivo desde el que se realizará la importación.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class