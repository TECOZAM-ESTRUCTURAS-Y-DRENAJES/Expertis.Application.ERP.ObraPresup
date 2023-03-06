<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFechas
    Inherits Solmicro.Expertis.Engine.UI.FormBase

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim cmbComercial_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFechas))
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.btnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.btnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.clbFIni = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.clbFFin = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.cmbComercial = New Solmicro.Expertis.Engine.UI.ComboBox
        CType(Me.cmbComercial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha Fin"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Comercial"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(45, 135)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(147, 135)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        '
        'clbFIni
        '
        Me.clbFIni.DisabledBackColor = System.Drawing.Color.White
        Me.clbFIni.Location = New System.Drawing.Point(137, 27)
        Me.clbFIni.Name = "clbFIni"
        Me.clbFIni.Size = New System.Drawing.Size(100, 21)
        Me.clbFIni.TabIndex = 5
        '
        'clbFFin
        '
        Me.clbFFin.DisabledBackColor = System.Drawing.Color.White
        Me.clbFFin.Location = New System.Drawing.Point(137, 61)
        Me.clbFFin.Name = "clbFFin"
        Me.clbFFin.Size = New System.Drawing.Size(100, 21)
        Me.clbFFin.TabIndex = 6
        '
        'cmbComercial
        '
        cmbComercial_DesignTimeLayout.LayoutString = resources.GetString("cmbComercial_DesignTimeLayout.LayoutString")
        Me.cmbComercial.DesignTimeLayout = cmbComercial_DesignTimeLayout
        Me.cmbComercial.DisabledBackColor = System.Drawing.Color.White
        Me.cmbComercial.EntityName = "ObraEstudioUsuario"
        Me.cmbComercial.Location = New System.Drawing.Point(137, 94)
        Me.cmbComercial.Name = "cmbComercial"
        Me.cmbComercial.SecondaryDataFields = "Usuario"
        Me.cmbComercial.SelectedIndex = -1
        Me.cmbComercial.SelectedItem = Nothing
        Me.cmbComercial.Size = New System.Drawing.Size(100, 21)
        Me.cmbComercial.TabIndex = 7
        Me.cmbComercial.ValueMember = "Usuario"
        '
        'FrmFechas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(266, 184)
        Me.Controls.Add(Me.cmbComercial)
        Me.Controls.Add(Me.clbFFin)
        Me.Controls.Add(Me.clbFIni)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmFechas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmFechas"
        CType(Me.cmbComercial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents btnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents clbFIni As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents clbFFin As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents cmbComercial As Solmicro.Expertis.Engine.UI.ComboBox
End Class
