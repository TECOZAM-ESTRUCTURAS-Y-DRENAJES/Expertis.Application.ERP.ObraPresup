<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CICompTrabProy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CICompTrabProy))
        Me.AdvObraDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.LblObraDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.LblObraHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTrabajoDesde = New Solmicro.Expertis.Engine.UI.Label
        Me.LblTrabajoHasta = New Solmicro.Expertis.Engine.UI.Label
        Me.AdvTrabajoDesde = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvObraHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
        Me.AdvTrabajoHasta = New Solmicro.Expertis.Engine.UI.AdvSearch
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
        Me.FilterPanel.Controls.Add(Me.AdvTrabajoHasta)
        Me.FilterPanel.Controls.Add(Me.AdvObraHasta)
        Me.FilterPanel.Controls.Add(Me.AdvTrabajoDesde)
        Me.FilterPanel.Controls.Add(Me.LblTrabajoHasta)
        Me.FilterPanel.Controls.Add(Me.LblTrabajoDesde)
        Me.FilterPanel.Controls.Add(Me.LblObraHasta)
        Me.FilterPanel.Controls.Add(Me.LblObraDesde)
        Me.FilterPanel.Controls.Add(Me.AdvObraDesde)
        Me.FilterPanel.Location = New System.Drawing.Point(0, 355)
        Me.FilterPanel.Size = New System.Drawing.Size(777, 94)
        '
        'CIMntoGridPanel
        '
        Me.CIMntoGridPanel.Size = New System.Drawing.Size(777, 355)
        '
        'Grid
        '
        Grid_DesignTimeLayout.LayoutString = resources.GetString("Grid_DesignTimeLayout.LayoutString")
        Me.Grid.DesignTimeLayout = Grid_DesignTimeLayout
        Me.Grid.EntityName = "ObraTrabajo"
        Me.Grid.KeyField = "IDTrabajo"
        Me.Grid.Size = New System.Drawing.Size(777, 355)
        Me.Grid.ViewName = "vCTlCIObraTrabajoPresupuestoPrevistoReal"
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
        Me.MainPanel.Size = New System.Drawing.Size(777, 449)
        '
        'MainPanelCIMntoContainer
        '
        Me.MainPanelCIMntoContainer.Size = New System.Drawing.Size(777, 449)
        '
        'AdvObraDesde
        '
        Me.AdvObraDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraDesde.DisplayField = "NObra"
        Me.AdvObraDesde.EntityName = "ObraCabecera"
        Me.AdvObraDesde.Location = New System.Drawing.Point(105, 28)
        Me.AdvObraDesde.Name = "AdvObraDesde"
        Me.AdvObraDesde.SecondaryDataFields = "IDObra"
        Me.AdvObraDesde.Size = New System.Drawing.Size(100, 23)
        Me.AdvObraDesde.TabIndex = 0
        '
        'LblObraDesde
        '
        Me.LblObraDesde.Location = New System.Drawing.Point(8, 33)
        Me.LblObraDesde.Name = "LblObraDesde"
        Me.LblObraDesde.Size = New System.Drawing.Size(75, 13)
        Me.LblObraDesde.TabIndex = 1
        Me.LblObraDesde.Text = "Obra Desde"
        '
        'LblObraHasta
        '
        Me.LblObraHasta.Location = New System.Drawing.Point(211, 33)
        Me.LblObraHasta.Name = "LblObraHasta"
        Me.LblObraHasta.Size = New System.Drawing.Size(39, 13)
        Me.LblObraHasta.TabIndex = 2
        Me.LblObraHasta.Text = "Hasta"
        '
        'LblTrabajoDesde
        '
        Me.LblTrabajoDesde.Location = New System.Drawing.Point(8, 62)
        Me.LblTrabajoDesde.Name = "LblTrabajoDesde"
        Me.LblTrabajoDesde.Size = New System.Drawing.Size(91, 13)
        Me.LblTrabajoDesde.TabIndex = 3
        Me.LblTrabajoDesde.Text = "Trabajo Desde"
        '
        'LblTrabajoHasta
        '
        Me.LblTrabajoHasta.Location = New System.Drawing.Point(211, 62)
        Me.LblTrabajoHasta.Name = "LblTrabajoHasta"
        Me.LblTrabajoHasta.Size = New System.Drawing.Size(39, 13)
        Me.LblTrabajoHasta.TabIndex = 4
        Me.LblTrabajoHasta.Text = "Hasta"
        '
        'AdvTrabajoDesde
        '
        Me.AdvTrabajoDesde.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajoDesde.EntityName = "ObraTrabajo"
        Me.AdvTrabajoDesde.Location = New System.Drawing.Point(105, 57)
        Me.AdvTrabajoDesde.Name = "AdvTrabajoDesde"
        Me.AdvTrabajoDesde.SecondaryDataFields = "IDTrabajo"
        Me.AdvTrabajoDesde.Size = New System.Drawing.Size(100, 23)
        Me.AdvTrabajoDesde.TabIndex = 5
        '
        'AdvObraHasta
        '
        Me.AdvObraHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvObraHasta.DisplayField = "NObra"
        Me.AdvObraHasta.EntityName = "ObraCabecera"
        Me.AdvObraHasta.Location = New System.Drawing.Point(256, 28)
        Me.AdvObraHasta.Name = "AdvObraHasta"
        Me.AdvObraHasta.SecondaryDataFields = "IDObra"
        Me.AdvObraHasta.Size = New System.Drawing.Size(100, 23)
        Me.AdvObraHasta.TabIndex = 6
        '
        'AdvTrabajoHasta
        '
        Me.AdvTrabajoHasta.DisabledBackColor = System.Drawing.Color.White
        Me.AdvTrabajoHasta.EntityName = "ObraTrabajo"
        Me.AdvTrabajoHasta.Location = New System.Drawing.Point(256, 57)
        Me.AdvTrabajoHasta.Name = "AdvTrabajoHasta"
        Me.AdvTrabajoHasta.SecondaryDataFields = "IDTrabajo"
        Me.AdvTrabajoHasta.Size = New System.Drawing.Size(100, 23)
        Me.AdvTrabajoHasta.TabIndex = 7
        '
        'CICompTrabProy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 537)
        Me.EntityName = "ObraTrabajo"
        Me.KeyField = "IDTrabajo"
        Me.Name = "CICompTrabProy"
        Me.Text = "CICompTrabProy"
        Me.ViewName = "vCTlCIObraTrabajoPresupuestoPrevistoReal"
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
    Friend WithEvents AdvTrabajoHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvObraHasta As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents AdvTrabajoDesde As Solmicro.Expertis.Engine.UI.AdvSearch
    Friend WithEvents LblTrabajoHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblTrabajoDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblObraHasta As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents LblObraDesde As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents AdvObraDesde As Solmicro.Expertis.Engine.UI.AdvSearch
End Class
