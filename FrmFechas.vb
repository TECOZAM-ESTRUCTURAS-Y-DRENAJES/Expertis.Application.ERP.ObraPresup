Public Class FrmFechas
    Inherits Solmicro.Expertis.Engine.UI.FormBase


    Public blnImprimir As Boolean
    Public fini As Date
    Public ffin As Date
    Public comercial As String


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        blnImprimir = False
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        blnImprimir = True
        fini = clbFIni.Value
        ffin = clbFFin.Value
        comercial = cmbComercial.Value


        If Trim(fini).Length = 0 And Trim(ffin).Length = 0 Then
            MsgBox("Debe de seleccionar las fechas")
        Else
            'MsgBox("Ha elegido mes " & mes & " año " & anio)
            Me.Close()
        End If
    End Sub
End Class