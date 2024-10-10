<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CIConsultasUnidadesObra
    Inherits Solmicro.Expertis.Engine.UI.CIMnto

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
        Dim Grid_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CIConsultasUnidadesObra))
        Me.bBuscar = New Solmicro.Expertis.Engine.UI.Button
        Me.txtUnidadObra = New Solmicro.Expertis.Engine.UI.TextBox
        Me.lblUnidad = New Solmicro.Expertis.Engine.UI.Label
        Me.FilterPanel.SuspendLayout()
        Me.CIMntoGridPanel.suspendlayout()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainPanel.SuspendLayout()
        Me.MainPanelCIMntoContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'FilterPanel
        '
        Me.FilterPanel.Controls.Add(Me.bBuscar)
        Me.FilterPanel.Controls.Add(Me.txtUnidadObra)
        Me.FilterPanel.Controls.Add(Me.lblUnidad)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 315)
        Me.FilterPanel.Size = New System.Drawing.Size(779, 80)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(779, 315)
        '
        'Grid
        '
        Me.Grid.ColumnAutoResize = True
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.Size = New System.Drawing.Size(779, 315)
        Me.Grid.ViewName = "vFrmObraPresupTrabajosMultinivel"
        '
        'Toolbar
        '
        Me.Toolbar.Size = New System.Drawing.Size(245, 28)
        '
        'Menubar
        '
        Me.Menubar.Location = New System.Drawing.Point(0, 28)
        '
        'MainPanel
        '
        Me.MainPanel.Size = New System.Drawing.Size(779, 395)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(779, 395)
        '
        'bBuscar
        '
        Me.bBuscar.Location = New System.Drawing.Point(380, 28)
        Me.bBuscar.Name = "bBuscar"
        Me.bBuscar.Size = New System.Drawing.Size(94, 24)
        Me.bBuscar.TabIndex = 5
        Me.bBuscar.Text = "Buscar"
        '
        'txtUnidadObra
        '
        Me.txtUnidadObra.DisabledBackColor = System.Drawing.Color.White
        Me.txtUnidadObra.Location = New System.Drawing.Point(143, 31)
        Me.txtUnidadObra.Name = "txtUnidadObra"
        Me.txtUnidadObra.Size = New System.Drawing.Size(227, 21)
        Me.txtUnidadObra.TabIndex = 4
        '
        'lblUnidad
        '
        Me.lblUnidad.Location = New System.Drawing.Point(38, 35)
        Me.lblUnidad.Name = "lblUnidad"
        Me.lblUnidad.Size = New System.Drawing.Size(99, 13)
        Me.lblUnidad.TabIndex = 3
        Me.lblUnidad.Text = "Unidad de obra:"
        '
        'CIConsultasUnidadesObra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 483)
        Me.Name = "CIConsultasUnidadesObra"
        Me.Text = "CIConsultasUnidadesObra"
        Me.ViewName = "vFrmObraPresupTrabajosMultinivel"
        Me.FilterPanel.ResumeLayout(False)
        Me.FilterPanel.PerformLayout()
        Me.CIMntoGridPanel.ResumeLayout(False)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Toolbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menubar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanelCIMntoContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bBuscar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents txtUnidadObra As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents lblUnidad As Solmicro.Expertis.Engine.UI.Label
End Class
