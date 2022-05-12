<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatosFax
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatosFax))
        Me.txtFecha = New Solmicro.Expertis.Engine.UI.CalendarBox
        Me.Label1 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtPara = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtDE = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtEmpresaOrigen = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtEmpresaDestino = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtTelefonoOrigen = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtTelefonoDestino = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtFaxOrigen = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtFaxDestino = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtEmailOrigen = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtEmailDestino = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label2 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label3 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label4 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label7 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label8 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label10 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label12 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label13 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label14 = New Solmicro.Expertis.Engine.UI.Label
        Me.txtValidez = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtFPago = New Solmicro.Expertis.Engine.UI.TextBox
        Me.txtComentario = New Solmicro.Expertis.Engine.UI.TextBox
        Me.Label5 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label6 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label9 = New Solmicro.Expertis.Engine.UI.Label
        Me.Label11 = New Solmicro.Expertis.Engine.UI.Label
        Me.btnCancelar = New Solmicro.Expertis.Engine.UI.Button
        Me.btnAceptar = New Solmicro.Expertis.Engine.UI.Button
        Me.SuspendLayout()
        '
        'txtFecha
        '
        Me.txtFecha.DisabledBackColor = System.Drawing.Color.White
        Me.txtFecha.Location = New System.Drawing.Point(450, 12)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(230, 21)
        Me.txtFecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(358, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fecha"
        '
        'txtPara
        '
        Me.txtPara.DisabledBackColor = System.Drawing.Color.White
        Me.txtPara.Location = New System.Drawing.Point(105, 51)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(230, 21)
        Me.txtPara.TabIndex = 2
        '
        'txtDE
        '
        Me.txtDE.DisabledBackColor = System.Drawing.Color.White
        Me.txtDE.Location = New System.Drawing.Point(450, 51)
        Me.txtDE.Name = "txtDE"
        Me.txtDE.Size = New System.Drawing.Size(230, 21)
        Me.txtDE.TabIndex = 3
        '
        'txtEmpresaOrigen
        '
        Me.txtEmpresaOrigen.DisabledBackColor = System.Drawing.Color.White
        Me.txtEmpresaOrigen.Location = New System.Drawing.Point(450, 78)
        Me.txtEmpresaOrigen.Name = "txtEmpresaOrigen"
        Me.txtEmpresaOrigen.Size = New System.Drawing.Size(230, 21)
        Me.txtEmpresaOrigen.TabIndex = 5
        '
        'txtEmpresaDestino
        '
        Me.txtEmpresaDestino.DisabledBackColor = System.Drawing.Color.White
        Me.txtEmpresaDestino.Location = New System.Drawing.Point(105, 78)
        Me.txtEmpresaDestino.Name = "txtEmpresaDestino"
        Me.txtEmpresaDestino.Size = New System.Drawing.Size(230, 21)
        Me.txtEmpresaDestino.TabIndex = 4
        '
        'txtTelefonoOrigen
        '
        Me.txtTelefonoOrigen.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefonoOrigen.Location = New System.Drawing.Point(450, 105)
        Me.txtTelefonoOrigen.Name = "txtTelefonoOrigen"
        Me.txtTelefonoOrigen.Size = New System.Drawing.Size(230, 21)
        Me.txtTelefonoOrigen.TabIndex = 7
        '
        'txtTelefonoDestino
        '
        Me.txtTelefonoDestino.DisabledBackColor = System.Drawing.Color.White
        Me.txtTelefonoDestino.Location = New System.Drawing.Point(105, 105)
        Me.txtTelefonoDestino.Name = "txtTelefonoDestino"
        Me.txtTelefonoDestino.Size = New System.Drawing.Size(230, 21)
        Me.txtTelefonoDestino.TabIndex = 6
        '
        'txtFaxOrigen
        '
        Me.txtFaxOrigen.DisabledBackColor = System.Drawing.Color.White
        Me.txtFaxOrigen.Location = New System.Drawing.Point(450, 132)
        Me.txtFaxOrigen.Name = "txtFaxOrigen"
        Me.txtFaxOrigen.Size = New System.Drawing.Size(230, 21)
        Me.txtFaxOrigen.TabIndex = 9
        '
        'txtFaxDestino
        '
        Me.txtFaxDestino.DisabledBackColor = System.Drawing.Color.White
        Me.txtFaxDestino.Location = New System.Drawing.Point(105, 132)
        Me.txtFaxDestino.Name = "txtFaxDestino"
        Me.txtFaxDestino.Size = New System.Drawing.Size(230, 21)
        Me.txtFaxDestino.TabIndex = 8
        '
        'txtEmailOrigen
        '
        Me.txtEmailOrigen.DisabledBackColor = System.Drawing.Color.White
        Me.txtEmailOrigen.Location = New System.Drawing.Point(450, 159)
        Me.txtEmailOrigen.Name = "txtEmailOrigen"
        Me.txtEmailOrigen.Size = New System.Drawing.Size(230, 21)
        Me.txtEmailOrigen.TabIndex = 11
        '
        'txtEmailDestino
        '
        Me.txtEmailDestino.DisabledBackColor = System.Drawing.Color.White
        Me.txtEmailDestino.Location = New System.Drawing.Point(105, 159)
        Me.txtEmailDestino.Name = "txtEmailDestino"
        Me.txtEmailDestino.Size = New System.Drawing.Size(230, 21)
        Me.txtEmailDestino.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "PARA Sr./Sra."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(358, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "DE:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Empresa:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Teléfono:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(13, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Nº Fax:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(13, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "E-Mail:"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(359, 334)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Validez:"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(13, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Comentario"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(13, 334)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Vencimiento"
        '
        'txtValidez
        '
        Me.txtValidez.DisabledBackColor = System.Drawing.Color.White
        Me.txtValidez.Location = New System.Drawing.Point(451, 330)
        Me.txtValidez.Name = "txtValidez"
        Me.txtValidez.Size = New System.Drawing.Size(230, 21)
        Me.txtValidez.TabIndex = 26
        '
        'txtFPago
        '
        Me.txtFPago.DisabledBackColor = System.Drawing.Color.White
        Me.txtFPago.Location = New System.Drawing.Point(106, 330)
        Me.txtFPago.Name = "txtFPago"
        Me.txtFPago.Size = New System.Drawing.Size(230, 21)
        Me.txtFPago.TabIndex = 25
        '
        'txtComentario
        '
        Me.txtComentario.DisabledBackColor = System.Drawing.Color.White
        Me.txtComentario.Location = New System.Drawing.Point(16, 206)
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.Size = New System.Drawing.Size(665, 109)
        Me.txtComentario.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(360, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "E-Mail:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(360, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Nº Fax:"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(359, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Teléfono:"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(359, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Empresa:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Icon = CType(resources.GetObject("btnCancelar.Icon"), System.Drawing.Icon)
        Me.btnCancelar.Location = New System.Drawing.Point(520, 385)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(160, 23)
        Me.btnCancelar.TabIndex = 33
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Icon = CType(resources.GetObject("btnAceptar.Icon"), System.Drawing.Icon)
        Me.btnAceptar.Location = New System.Drawing.Point(333, 385)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(162, 23)
        Me.btnAceptar.TabIndex = 32
        Me.btnAceptar.Text = "Aceptar"
        '
        'FrmDatosFax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 425)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.txtValidez)
        Me.Controls.Add(Me.txtFPago)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEmailOrigen)
        Me.Controls.Add(Me.txtEmailDestino)
        Me.Controls.Add(Me.txtFaxOrigen)
        Me.Controls.Add(Me.txtFaxDestino)
        Me.Controls.Add(Me.txtTelefonoOrigen)
        Me.Controls.Add(Me.txtTelefonoDestino)
        Me.Controls.Add(Me.txtEmpresaOrigen)
        Me.Controls.Add(Me.txtEmpresaDestino)
        Me.Controls.Add(Me.txtDE)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFecha)
        Me.Name = "FrmDatosFax"
        Me.Text = "Datos Fax"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFecha As Solmicro.Expertis.Engine.UI.CalendarBox
    Friend WithEvents Label1 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtPara As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtDE As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtEmpresaOrigen As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtEmpresaDestino As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtTelefonoOrigen As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtTelefonoDestino As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtFaxOrigen As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtFaxDestino As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtEmailOrigen As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtEmailDestino As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label2 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label3 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label4 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label7 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label8 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label10 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label12 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label13 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label14 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents txtValidez As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtFPago As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents txtComentario As Solmicro.Expertis.Engine.UI.TextBox
    Friend WithEvents Label5 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label6 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label9 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents Label11 As Solmicro.Expertis.Engine.UI.Label
    Friend WithEvents btnCancelar As Solmicro.Expertis.Engine.UI.Button
    Friend WithEvents btnAceptar As Solmicro.Expertis.Engine.UI.Button
End Class
