Public Module ObraPresupGeneral
    Public mintRedondeoA, mintRedondeoPrecA As Integer
    Private MargenBruto As Boolean?

    Public mstrIDUDMedida As String
    Public mstrIDCGestion As String
    Public mstrIDHora As String
    Public mstrDescHora As String

    Public dFecha As Date
    Public sFax As String

    Public Para As String
    Public EmpresaDestino As String
    Public TelefonoDestino As String
    Public NFaxDestino As String
    Public EmailDestino As String
    Public DE As String
    Public EmpresaOrigen As String
    Public TelefonoOrigen As String
    Public NFaxOrigen As String
    Public EmailOrigen As String
    Public Fecha As String
    Public FPago As String
    Public Validez As String
    Public Comentario As String

    Public blnImprimirfax As Boolean

    Public Function CalcularMargen(ByVal Venta As Double, ByVal Coste As Double) As Double
        Dim Margen As Double = 0
        If MargenBruto Is Nothing Then MargenBruto = New Parametro().MargenBruto

        If MargenBruto Then
            If Venta <> 0 Then
                Margen = ((Venta - Coste) / Venta) * 100
            End If
        ElseIf Coste <> 0 Then
            Margen = ((Venta - Coste) / Coste) * 100
        End If

        'If Margen = -100 Then
        '    Return 0
        'Else
        Return xRound(Margen, 2)
        'End If
    End Function

End Module
