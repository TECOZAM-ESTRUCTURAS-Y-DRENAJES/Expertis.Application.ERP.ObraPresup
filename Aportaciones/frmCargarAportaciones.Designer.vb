<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargarAportaciones
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCargarAportaciones))
        Dim GridSTAport_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.btnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.btnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.GridSTAport = New Solmicro.Expertis.Engine.UI.Grid
        CType(Me.GridSTAport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(152, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Elija los Tipos de Aportaciones a Cargar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Icon = CType(resources.GetObject("btnAceptar.Icon"), System.Drawing.Icon)
        Me.btnAceptar.Location = New System.Drawing.Point(116, 276)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(132, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Icon = CType(resources.GetObject("btnCancelar.Icon"), System.Drawing.Icon)
        Me.btnCancelar.Location = New System.Drawing.Point(306, 276)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(125, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'GridSTAport
        '
        GridSTAport_DesignTimeLayout.LayoutString = resources.GetString("GridSTAport_DesignTimeLayout.LayoutString")
        Me.GridSTAport.DesignTimeLayout = GridSTAport_DesignTimeLayout
        Me.GridSTAport.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell
        Me.GridSTAport.EntityName = Nothing
        Me.GridSTAport.Location = New System.Drawing.Point(116, 67)
        Me.GridSTAport.Name = "GridSTAport"
        Me.GridSTAport.PrimaryDataFields = Nothing
        Me.GridSTAport.SecondaryDataFields = Nothing
        Me.GridSTAport.Size = New System.Drawing.Size(315, 180)
        Me.GridSTAport.TabIndex = 4
        Me.GridSTAport.ViewName = Nothing
        '
        'frmCargarAportaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 357)
        Me.Controls.Add(Me.GridSTAport)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmCargarAportaciones"
        Me.Text = "frmCargarAportaciones"
        CType(Me.GridSTAport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnAceptar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents btnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents GridSTAport As Solmicro.Expertis.Engine.UI.Grid
End Class
