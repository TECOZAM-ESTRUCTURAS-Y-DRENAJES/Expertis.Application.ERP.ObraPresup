Public Class frmAddMateriales
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
    Friend WithEvents lblCodTrabajo As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtCodTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblSecuencia As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtSecuencia As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDescMaterial As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblIDMaterial As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDMaterial As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents lblIDProveedor As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents advIDProveedor As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents chbManual As Solmicro.Expertis.Engine.UI.CheckBox
    Friend WithEvents lblQUnidad As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbQUnidad As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblQPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbQPresup As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPrecioPresupMatA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbPrecioPresupMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDto1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbDto1 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDto2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbDto2 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblDto3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbDto3 As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpPresupMatA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbImpPresupMatA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblMargenPresup As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbMargenPresup As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblImpPresupMatVentaA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbImpPresupMatVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents lblPrecioVentaA As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents ntbPrecioVentaA As Solmicro.Expertis.Engine.UI.NumericTextBox
    Friend WithEvents Panel1 As Solmicro.Expertis.Engine.UI.Panel
    Friend WithEvents CmbNuevo As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents cmbCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents CmbAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtDescTrabajo As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents ulDescProveedor As Solmicro.Expertis.Engine.UI.UnderLineLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblCodTrabajo = New Solmicro.Expertis.Engine.UI.Label
        Me.txtCodTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescTrabajo = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblSecuencia = New Solmicro.Expertis.Engine.UI.Label
        Me.txtSecuencia = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDescMaterial = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblIDMaterial = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDMaterial = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.lblIDProveedor = New Solmicro.Expertis.Engine.UI.Label
        Me.advIDProveedor = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.chbManual = New Solmicro.Expertis.Engine.UI.CheckBox
        Me.lblQUnidad = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbQUnidad = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblQPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbQPresup = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPrecioPresupMatA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbPrecioPresupMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDto1 = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbDto1 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDto2 = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbDto2 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblDto3 = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbDto3 = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPresupMatA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPresupMatA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblMargenPresup = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbMargenPresup = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblImpPresupMatVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbImpPresupMatVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.lblPrecioVentaA = New Solmicro.Expertis.Engine.UI.Label
        Me.ntbPrecioVentaA = New Solmicro.Expertis.Engine.UI.NumericTextBox
        Me.Panel1 = New Solmicro.Expertis.Engine.UI.Panel
        Me.CmbNuevo = New Solmicro.Expertis.Engine.UI.Button
        Me.cmbCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.CmbAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.ulDescProveedor = New Solmicro.Expertis.Engine.UI.UnderLineLabel
        Me.Panel1.suspendlayout()
        Me.SuspendLayout()
        '
        'lblCodTrabajo
        '
        Me.lblCodTrabajo.Location = New System.Drawing.Point(4, 10)
        Me.lblCodTrabajo.Name = "lblCodTrabajo"
        Me.lblCodTrabajo.Size = New System.Drawing.Size(51, 13)
        Me.lblCodTrabajo.TabIndex = 0
        Me.lblCodTrabajo.Text = "Trabajo"
        '
        'txtCodTrabajo
        '
        Me.txtCodTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtCodTrabajo.Enabled = False
        Me.txtCodTrabajo.Location = New System.Drawing.Point(71, 8)
        Me.txtCodTrabajo.Name = "txtCodTrabajo"
        Me.txtCodTrabajo.Size = New System.Drawing.Size(119, 21)
        Me.txtCodTrabajo.TabIndex = 0
        '
        'txtDescTrabajo
        '
        Me.txtDescTrabajo.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescTrabajo.Enabled = False
        Me.txtDescTrabajo.Location = New System.Drawing.Point(195, 8)
        Me.txtDescTrabajo.Name = "txtDescTrabajo"
        Me.txtDescTrabajo.Size = New System.Drawing.Size(210, 21)
        Me.txtDescTrabajo.TabIndex = 1
        Me.txtDescTrabajo.TabStop = False
        '
        'lblSecuencia
        '
        Me.lblSecuencia.Location = New System.Drawing.Point(409, 10)
        Me.lblSecuencia.Name = "lblSecuencia"
        Me.lblSecuencia.Size = New System.Drawing.Size(65, 13)
        Me.lblSecuencia.TabIndex = 203
        Me.lblSecuencia.Text = "Secuencia"
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
        'txtDescMaterial
        '
        Me.TryDataBinding(txtDescMaterial, New System.Windows.Forms.Binding("Text", Me, "DescMaterial", True))
        Me.txtDescMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.txtDescMaterial.Location = New System.Drawing.Point(195, 34)
        Me.txtDescMaterial.Name = "txtDescMaterial"
        Me.txtDescMaterial.Size = New System.Drawing.Size(342, 21)
        Me.txtDescMaterial.TabIndex = 2
        '
        'lblIDMaterial
        '
        Me.lblIDMaterial.Location = New System.Drawing.Point(4, 36)
        Me.lblIDMaterial.Name = "lblIDMaterial"
        Me.lblIDMaterial.Size = New System.Drawing.Size(52, 13)
        Me.lblIDMaterial.TabIndex = 207
        Me.lblIDMaterial.Text = "Material"
        '
        'advIDMaterial
        '
        Me.TryDataBinding(advIDMaterial, New System.Windows.Forms.Binding("Text", Me, "IDMaterial", True))
        Me.advIDMaterial.DisabledBackColor = System.Drawing.Color.White
        Me.advIDMaterial.EntityName = "Articulo"
        Me.advIDMaterial.Location = New System.Drawing.Point(71, 34)
        Me.advIDMaterial.Name = "advIDMaterial"
        Me.advIDMaterial.PrimaryDataFields = "IDMaterial"
        Me.advIDMaterial.SecondaryDataFields = "IDArticulo"
        Me.advIDMaterial.Size = New System.Drawing.Size(119, 23)
        Me.advIDMaterial.TabIndex = 1
        '
        'lblIDProveedor
        '
        Me.lblIDProveedor.Location = New System.Drawing.Point(4, 62)
        Me.lblIDProveedor.Name = "lblIDProveedor"
        Me.lblIDProveedor.Size = New System.Drawing.Size(66, 13)
        Me.lblIDProveedor.TabIndex = 209
        Me.lblIDProveedor.Text = "Proveedor"
        '
        'advIDProveedor
        '
        Me.TryDataBinding(advIDProveedor, New System.Windows.Forms.Binding("Text", Me, "IDProveedor", True))
        Me.advIDProveedor.DisabledBackColor = System.Drawing.Color.White
        Me.advIDProveedor.EntityName = "Proveedor"
        Me.advIDProveedor.Location = New System.Drawing.Point(71, 60)
        Me.advIDProveedor.Name = "advIDProveedor"
        Me.advIDProveedor.PrimaryDataFields = "IDProveedor"
        Me.advIDProveedor.SecondaryDataFields = "IDProveedor"
        Me.advIDProveedor.Size = New System.Drawing.Size(119, 23)
        Me.advIDProveedor.TabIndex = 3
        '
        'chbManual
        '
        Me.TryDataBinding(chbManual, New System.Windows.Forms.Binding("BindableValue", Me, "Manual", True))
        Me.chbManual.Location = New System.Drawing.Point(5, 89)
        Me.chbManual.Name = "chbManual"
        Me.chbManual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chbManual.Size = New System.Drawing.Size(80, 23)
        Me.chbManual.TabIndex = 4
        Me.chbManual.Text = "Manual"
        Me.chbManual.TextAlignment = Janus.Windows.EditControls.TextAlignment.Far
        '
        'lblQUnidad
        '
        Me.lblQUnidad.Location = New System.Drawing.Point(111, 92)
        Me.lblQUnidad.Name = "lblQUnidad"
        Me.lblQUnidad.Size = New System.Drawing.Size(63, 13)
        Me.lblQUnidad.TabIndex = 213
        Me.lblQUnidad.Text = "C. Unidad"
        '
        'ntbQUnidad
        '
        Me.TryDataBinding(ntbQUnidad, New System.Windows.Forms.Binding("Value", Me, "QUnidad", True))
        Me.ntbQUnidad.DisabledBackColor = System.Drawing.Color.White
        Me.ntbQUnidad.Location = New System.Drawing.Point(178, 90)
        Me.ntbQUnidad.Name = "ntbQUnidad"
        Me.ntbQUnidad.Size = New System.Drawing.Size(79, 21)
        Me.ntbQUnidad.TabIndex = 5
        '
        'lblQPresup
        '
        Me.lblQPresup.Location = New System.Drawing.Point(281, 92)
        Me.lblQPresup.Name = "lblQPresup"
        Me.lblQPresup.Size = New System.Drawing.Size(67, 13)
        Me.lblQPresup.TabIndex = 215
        Me.lblQPresup.Text = "C. Presup."
        '
        'ntbQPresup
        '
        Me.TryDataBinding(ntbQPresup, New System.Windows.Forms.Binding("Value", Me, "QPresup", True))
        Me.ntbQPresup.DisabledBackColor = System.Drawing.Color.White
        Me.ntbQPresup.Location = New System.Drawing.Point(351, 90)
        Me.ntbQPresup.Name = "ntbQPresup"
        Me.ntbQPresup.Size = New System.Drawing.Size(81, 21)
        Me.ntbQPresup.TabIndex = 6
        '
        'lblPrecioPresupMatA
        '
        Me.lblPrecioPresupMatA.Location = New System.Drawing.Point(4, 134)
        Me.lblPrecioPresupMatA.Name = "lblPrecioPresupMatA"
        Me.lblPrecioPresupMatA.Size = New System.Drawing.Size(89, 13)
        Me.lblPrecioPresupMatA.TabIndex = 217
        Me.lblPrecioPresupMatA.Text = "Precio Presup."
        '
        'ntbPrecioPresupMatA
        '
        Me.TryDataBinding(ntbPrecioPresupMatA, New System.Windows.Forms.Binding("Value", Me, "PrecioPresupMatA", True))
        Me.ntbPrecioPresupMatA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbPrecioPresupMatA.Location = New System.Drawing.Point(92, 134)
        Me.ntbPrecioPresupMatA.Name = "ntbPrecioPresupMatA"
        Me.ntbPrecioPresupMatA.Size = New System.Drawing.Size(112, 21)
        Me.ntbPrecioPresupMatA.TabIndex = 7
        '
        'lblDto1
        '
        Me.lblDto1.Location = New System.Drawing.Point(220, 127)
        Me.lblDto1.Name = "lblDto1"
        Me.lblDto1.Size = New System.Drawing.Size(42, 13)
        Me.lblDto1.TabIndex = 219
        Me.lblDto1.Text = "Dto. 1"
        '
        'ntbDto1
        '
        Me.TryDataBinding(ntbDto1, New System.Windows.Forms.Binding("Value", Me, "Dto1", True))
        Me.ntbDto1.DisabledBackColor = System.Drawing.Color.White
        Me.ntbDto1.Location = New System.Drawing.Point(268, 127)
        Me.ntbDto1.Name = "ntbDto1"
        Me.ntbDto1.Size = New System.Drawing.Size(49, 21)
        Me.ntbDto1.TabIndex = 9
        '
        'lblDto2
        '
        Me.lblDto2.Location = New System.Drawing.Point(220, 153)
        Me.lblDto2.Name = "lblDto2"
        Me.lblDto2.Size = New System.Drawing.Size(42, 13)
        Me.lblDto2.TabIndex = 221
        Me.lblDto2.Text = "Dto. 2"
        '
        'ntbDto2
        '
        Me.TryDataBinding(ntbDto2, New System.Windows.Forms.Binding("Value", Me, "Dto2", True))
        Me.ntbDto2.DisabledBackColor = System.Drawing.Color.White
        Me.ntbDto2.Location = New System.Drawing.Point(268, 153)
        Me.ntbDto2.Name = "ntbDto2"
        Me.ntbDto2.Size = New System.Drawing.Size(49, 21)
        Me.ntbDto2.TabIndex = 10
        '
        'lblDto3
        '
        Me.lblDto3.Location = New System.Drawing.Point(220, 179)
        Me.lblDto3.Name = "lblDto3"
        Me.lblDto3.Size = New System.Drawing.Size(42, 13)
        Me.lblDto3.TabIndex = 223
        Me.lblDto3.Text = "Dto. 3"
        '
        'ntbDto3
        '
        Me.TryDataBinding(ntbDto3, New System.Windows.Forms.Binding("Value", Me, "Dto3", True))
        Me.ntbDto3.DisabledBackColor = System.Drawing.Color.White
        Me.ntbDto3.Location = New System.Drawing.Point(268, 179)
        Me.ntbDto3.Name = "ntbDto3"
        Me.ntbDto3.Size = New System.Drawing.Size(49, 21)
        Me.ntbDto3.TabIndex = 11
        '
        'lblImpPresupMatA
        '
        Me.lblImpPresupMatA.Location = New System.Drawing.Point(330, 127)
        Me.lblImpPresupMatA.Name = "lblImpPresupMatA"
        Me.lblImpPresupMatA.Size = New System.Drawing.Size(81, 13)
        Me.lblImpPresupMatA.TabIndex = 225
        Me.lblImpPresupMatA.Text = "Imp. Presup."
        '
        'ntbImpPresupMatA
        '
        Me.TryDataBinding(ntbImpPresupMatA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupMatA", True))
        Me.ntbImpPresupMatA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbImpPresupMatA.Enabled = False
        Me.ntbImpPresupMatA.Location = New System.Drawing.Point(415, 127)
        Me.ntbImpPresupMatA.Name = "ntbImpPresupMatA"
        Me.ntbImpPresupMatA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPresupMatA.TabIndex = 226
        '
        'lblMargenPresup
        '
        Me.lblMargenPresup.Location = New System.Drawing.Point(330, 153)
        Me.lblMargenPresup.Name = "lblMargenPresup"
        Me.lblMargenPresup.Size = New System.Drawing.Size(49, 13)
        Me.lblMargenPresup.TabIndex = 227
        Me.lblMargenPresup.Text = "Margen"
        '
        'ntbMargenPresup
        '
        Me.TryDataBinding(ntbMargenPresup, New System.Windows.Forms.Binding("Value", Me, "MargenPresup", True))
        Me.ntbMargenPresup.DisabledBackColor = System.Drawing.Color.White
        Me.ntbMargenPresup.Location = New System.Drawing.Point(415, 153)
        Me.ntbMargenPresup.Name = "ntbMargenPresup"
        Me.ntbMargenPresup.Size = New System.Drawing.Size(121, 21)
        Me.ntbMargenPresup.TabIndex = 12
        '
        'lblImpPresupMatVentaA
        '
        Me.lblImpPresupMatVentaA.Location = New System.Drawing.Point(330, 181)
        Me.lblImpPresupMatVentaA.Name = "lblImpPresupMatVentaA"
        Me.lblImpPresupMatVentaA.Size = New System.Drawing.Size(71, 13)
        Me.lblImpPresupMatVentaA.TabIndex = 229
        Me.lblImpPresupMatVentaA.Text = "Imp. Venta"
        '
        'ntbImpPresupMatVentaA
        '
        Me.TryDataBinding(ntbImpPresupMatVentaA, New System.Windows.Forms.Binding("Value", Me, "ImpPresupMatVentaA", True))
        Me.ntbImpPresupMatVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbImpPresupMatVentaA.Enabled = False
        Me.ntbImpPresupMatVentaA.Location = New System.Drawing.Point(415, 180)
        Me.ntbImpPresupMatVentaA.Name = "ntbImpPresupMatVentaA"
        Me.ntbImpPresupMatVentaA.Size = New System.Drawing.Size(121, 21)
        Me.ntbImpPresupMatVentaA.TabIndex = 230
        '
        'lblPrecioVentaA
        '
        Me.lblPrecioVentaA.Location = New System.Drawing.Point(4, 160)
        Me.lblPrecioVentaA.Name = "lblPrecioVentaA"
        Me.lblPrecioVentaA.Size = New System.Drawing.Size(79, 13)
        Me.lblPrecioVentaA.TabIndex = 231
        Me.lblPrecioVentaA.Text = "Precio Venta"
        '
        'ntbPrecioVentaA
        '
        Me.TryDataBinding(ntbPrecioVentaA, New System.Windows.Forms.Binding("Value", Me, "PrecioVentaA", True))
        Me.ntbPrecioVentaA.DisabledBackColor = System.Drawing.Color.White
        Me.ntbPrecioVentaA.Location = New System.Drawing.Point(92, 160)
        Me.ntbPrecioVentaA.Name = "ntbPrecioVentaA"
        Me.ntbPrecioVentaA.Size = New System.Drawing.Size(112, 21)
        Me.ntbPrecioVentaA.TabIndex = 8
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
        Me.Panel1.TabIndex = 233
        '
        'CmbNuevo
        '
        Me.CmbNuevo.Location = New System.Drawing.Point(123, 7)
        Me.CmbNuevo.Name = "CmbNuevo"
        Me.CmbNuevo.Size = New System.Drawing.Size(94, 29)
        Me.CmbNuevo.TabIndex = 13
        Me.CmbNuevo.Text = "Nuevo"
        '
        'cmbCancelar
        '
        Me.cmbCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmbCancelar.Location = New System.Drawing.Point(323, 7)
        Me.cmbCancelar.Name = "cmbCancelar"
        Me.cmbCancelar.Size = New System.Drawing.Size(94, 29)
        Me.cmbCancelar.TabIndex = 15
        Me.cmbCancelar.Text = "Cancelar"
        '
        'CmbAceptar
        '
        Me.CmbAceptar.Location = New System.Drawing.Point(223, 7)
        Me.CmbAceptar.Name = "CmbAceptar"
        Me.CmbAceptar.Size = New System.Drawing.Size(94, 29)
        Me.CmbAceptar.TabIndex = 14
        Me.CmbAceptar.Text = "Aceptar"
        '
        'ulDescProveedor
        '
        Me.TryDataBinding(ulDescProveedor, New System.Windows.Forms.Binding("Text", Me.advIDProveedor, "DescProveedor", True))
        Me.ulDescProveedor.Location = New System.Drawing.Point(195, 60)
        Me.ulDescProveedor.Name = "ulDescProveedor"
        Me.ulDescProveedor.Size = New System.Drawing.Size(342, 21)
        Me.ulDescProveedor.TabIndex = 234
        '
        'frmAddMateriales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(541, 251)
        Me.Controls.Add(Me.ulDescProveedor)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ntbPrecioVentaA)
        Me.Controls.Add(Me.ntbImpPresupMatVentaA)
        Me.Controls.Add(Me.ntbMargenPresup)
        Me.Controls.Add(Me.ntbImpPresupMatA)
        Me.Controls.Add(Me.ntbDto3)
        Me.Controls.Add(Me.ntbDto2)
        Me.Controls.Add(Me.ntbDto1)
        Me.Controls.Add(Me.ntbPrecioPresupMatA)
        Me.Controls.Add(Me.ntbQPresup)
        Me.Controls.Add(Me.ntbQUnidad)
        Me.Controls.Add(Me.chbManual)
        Me.Controls.Add(Me.advIDProveedor)
        Me.Controls.Add(Me.advIDMaterial)
        Me.Controls.Add(Me.txtDescMaterial)
        Me.Controls.Add(Me.txtSecuencia)
        Me.Controls.Add(Me.txtDescTrabajo)
        Me.Controls.Add(Me.txtCodTrabajo)
        Me.Controls.Add(Me.lblCodTrabajo)
        Me.Controls.Add(Me.lblSecuencia)
        Me.Controls.Add(Me.lblIDMaterial)
        Me.Controls.Add(Me.lblIDProveedor)
        Me.Controls.Add(Me.lblQUnidad)
        Me.Controls.Add(Me.lblQPresup)
        Me.Controls.Add(Me.lblPrecioPresupMatA)
        Me.Controls.Add(Me.lblDto1)
        Me.Controls.Add(Me.lblDto2)
        Me.Controls.Add(Me.lblDto3)
        Me.Controls.Add(Me.lblImpPresupMatA)
        Me.Controls.Add(Me.lblMargenPresup)
        Me.Controls.Add(Me.lblImpPresupMatVentaA)
        Me.Controls.Add(Me.lblPrecioVentaA)
        Me.EntityName = "ObraPresupMaterial"
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmAddMateriales"
        Me.NavigationFields = "IDPresup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta de Materiales"
        Me.ViewName = "vFrmObraPresupMateriales"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mdtMateriales As DataTable
    Private mintIDPresup, mintIDTrabajo As Integer
    Private mdblQPresupTrabajo As Double
    'Private mblnCancel As Boolean
    Private mFechaPresup As Date
    Private mIDCliente As String

    Public Overrides ReadOnly Property RequeryRecords() As Engine.RequeryMode
        Get
            Return RequeryMode.ActiveRecord
        End Get
    End Property

#Region " Load "

    Public Function AbrirAltaMateriales(ByVal IDPresup As Integer, ByVal IDTrabajo As Integer, ByVal CodTrabajo As String, _
                                        ByVal DescTrabajo As String, ByVal QPresupTrabajo As Double, _
                                        ByVal FechaPresup As Date, ByVal IDCliente As String) As DataTable

        txtCodTrabajo.Text = CodTrabajo
        txtDescTrabajo.Text = DescTrabajo
        mintIDPresup = IDPresup
        mintIDTrabajo = IDTrabajo
        mdblQPresupTrabajo = QPresupTrabajo
        mFechaPresup = FechaPresup
        mIDCliente = IDCliente

        Dim frm As New Form
        frm = Me
        frm.ShowDialog() 'Para que no traiga todos los registros

        If Me.DialogResult = DialogResult.OK Then Return mdtMateriales
        Return Nothing
    End Function

    Private Sub frmAddMateriales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ADDNewMaterial()
    End Sub

    Private Sub ADDNewMaterial()
        Me.AddNew()

        Me.CurrentData.Rows(0)("IDPresup") = mintIDPresup
        Me.CurrentData.Rows(0)("IDTrabajoPresup") = mintIDTrabajo
        Me.CurrentData.Rows(0)("CodTrabajo") = txtCodTrabajo.Text
        Me.CurrentData.Rows(0)("Manual") = False

        If IsNothing(mdtMateriales) Then mdtMateriales = CurrentData.Clone
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
            mdtMateriales.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            ADDNewMaterial()
        End If
    End Sub

    Private Sub CmbAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.None
        If Not ValidaDatosObligatorios() Then
            Me.DialogResult = DialogResult.OK
            mdtMateriales.Rows.Add(Me.CurrentData.Rows(0).ItemArray)
            Me.RecordsState = UI.RecordsState.Saved
            Me.Close()
        End If
    End Sub

    Private Sub frmAddMateriales_BusinessCalling(ByVal sender As Object, ByVal e As Engine.UI.BusinessCallingEventArgs) Handles MyBase.BusinessCalling
        e.Data.Context("Fecha") = mFechaPresup
        e.Data.Context("IDCliente") = mIDCliente
        e.Data.Context("QPresupTrabajo") = mdblQPresupTrabajo
    End Sub

End Class