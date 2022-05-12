Public Class FrmDatosFax

    Public lIdPresup As String
    Public lNumPresup As String

#Region "Load"

#End Region
  
    Private Sub FrmDatosFax_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sFax = ""
        txtFecha.Value = dFecha
        cargarDatos()
    End Sub

#Region "Funciones"
    Function CargarDatos()
        'Dim sSQL As String
        Dim dt As DataTable
        Dim BE As New Expertis.Engine.BE.DataEngine
        Dim Filtro As New Filter

        Try
            Filtro.Add("IdPresup", lIdPresup)
            dt = BE.Filter("tbObraPresupFax", Filtro)


            'sSQL = "IdPresup='" & lIdPresup & "'"
            ''rs = AdminData.Filter("vPrespFax", , sSQL)
            'rs = AdminData.GetData("tbObraPresupFax", "*", sSQL)

            For Each dr As DataRow In dt.Rows

                txtPara.Text = dr("Para")
                txtEmpresaDestino.Text = dr("EmpresaDestino")
                txtTelefonoDestino.Text = dr("TelefonoDestino")
                txtFaxDestino.Text = dr("NFaxDestino")
                txtEmailDestino.Text = dr("EmailDestino")
                txtDE.Text = dr("DE")
                txtEmpresaOrigen.Text = dr("EmpresaOrigen")
                txtTelefonoOrigen.Text = dr("TelefonoOrigen")
                txtFaxOrigen.Text = dr("NFaxOrigen")
                txtEmailOrigen.Text = dr("EmailOrigen")
                txtFecha.Text = dr("Fecha")
                txtComentario.Text = dr("Comentario")
                txtFPago.Text = dr("FPago")
                txtValidez.Text = dr("Validez")

            Next

        Catch ex As Exception
            ExpertisApp.GenerateMessage(ex.Message)
        Finally
            dt = Nothing
        End Try
    End Function

    Function GuardarDatos()
        'Dim rs As New Recordset
        'Dim rt As New Recordset
        Dim sSQL As String
        Dim nSQL As String
        Dim opf As New Expertis.Business.ClasesTecozam.ObraPresupFax

        Try
            Para = Nz(txtPara.Text, " ")
            EmpresaDestino = Nz(txtEmpresaDestino.Text, " ")
            TelefonoDestino = Nz(txtTelefonoDestino.Text, " ")
            NFaxDestino = Nz(txtFaxDestino.Text, " ")
            EmailDestino = Nz(txtEmailDestino.Text, " ")
            DE = Nz(txtDE.Text, " ")
            EmpresaOrigen = Nz(txtEmpresaOrigen.Text, " ")
            TelefonoOrigen = Nz(txtTelefonoOrigen.Text, " ")
            NFaxOrigen = Nz(txtFaxOrigen.Text, " ")
            EmailOrigen = Nz(txtEmailOrigen.Text, " ")
            Fecha = IIf(IsDate(txtFecha.Text) = True, txtFecha.Text, dFecha)
            Comentario = Nz(txtComentario.Text, " ")
            FPago = Nz(txtFPago.Text, " ")
            Validez = Nz(txtValidez.Text, " ")

            'sFax = "Para=" & Para & "; EmpresaDestino =" & EmpresaDestino & "; TelefonoDestino=" & TelefonoDestino & _
            '    "; NFaxDestino=" & NFaxDestino & "; EmailDestino=" & EmailDestino & "; DE=" & DE & _
            '    "; EmpresaOrigen=" & EmpresaOrigen & "; TelefonoOrigen=" & TelefonoOrigen & "; NFaxOrigen=" & NFaxOrigen & _
            '    "; EmailOrigen=" & EmailOrigen & "; Fecha=" & Fecha & _
            '    "; FPago=" & FPago & "; Validez=" & Validez


            ' nSQL = "select idpresup from vPrespFax where numpresup= '" & lNumPresup & "'"
            ' rt = AdminData.Filter("vPrespFax", , nSQL)

            opf.borrarDatos(lIdPresup)

            'sSQL = "Delete tbObraPresupFax where IdPresup='" & lIdPresup & "'"
            'AdminData.Execute(sSQL, ExecuteCommand.ExecuteReader, False)



            'sSQL = "select * from vPrespFax where IdPresup='" & lNumPresup & "'"
            'sSQL = "select * from tbObraPresupFax where 1=2"

            ''rs = AdminData.GetData(sSQL)
            'Dim txtSQL As String
            opf.insertarDatos(lIdPresup, Para, EmpresaDestino, TelefonoDestino, NFaxDestino, EmailDestino, DE, EmpresaOrigen, TelefonoOrigen, NFaxOrigen, EmailOrigen, _
            Fecha, dFecha, Comentario, FPago, Validez)
            'txtSQL = "INSERT INTO tbObraPresupFax (IDPresup,Para,EmpresaDestino,TelefonoDestino,NFaxDestino," _
            '& "EmailDestino,DE,EmpresaOrigen,TelefonoOrigen,NFaxOrigen,EmailOrigen,Fecha,Comentario,FPago,Validez)" _
            '& " VALUES (" & lIdPresup & ",'" & Nz(Para, "-") & "','" & Nz(EmpresaDestino, "-") & "','" & Nz(TelefonoDestino, "-") & "','" & Nz(NFaxDestino, "-") & "','" & Nz(EmailDestino, "-") _
            '& "','" & Nz(DE, "-") & "','" & Nz(EmpresaOrigen, "-") & "','" & Nz(TelefonoOrigen, "-") & "','" & Nz(NFaxOrigen, "-") & "','" & Nz(EmailOrigen, "-") & "','" & IIf(IsDate(Fecha) = True, Fecha, dFecha) _
            '& "','" & Nz(Comentario, "-") & "','" & Nz(FPago, "-") & "','" & Nz(Validez, "-") & "')"
            'AdminData.Execute(txtSQL, ExecuteCommand.ExecuteReader, False)
            ''rs.Open(sSQL, clsAdmin.GetConnectionString, adOpenDynamic, adLockOptimistic)
            ''rs.Open(sSQL)
            ''rs.AddNew()


            'rs.Fields("IdPresup").Value = lIdPresup
            'rs.Fields("Para").Value = Para
            'rs.Fields("EmpresaDestino").Value = EmpresaDestino
            'rs.Fields("TelefonoDestino").Value = TelefonoDestino
            'rs.Fields("NFaxDestino").Value = NFaxDestino
            'rs.Fields("EmailDestino").Value = EmailDestino
            'rs.Fields("DE").Value = DE
            'rs.Fields("EmpresaOrigen").Value = EmpresaOrigen
            'rs.Fields("TelefonoOrigen").Value = TelefonoOrigen
            'rs.Fields("NFaxOrigen").Value = NFaxOrigen
            'rs.Fields("EmailOrigen").Value = EmailOrigen
            'rs.Fields("Fecha").Value = IIf(IsDate(Fecha) = True, Fecha, dFecha)
            'rs.Fields("Comentario").Value = Comentario
            'rs.Fields("FPago").Value = FPago
            'rs.Fields("Validez").Value = Validez
            'rs.Update()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function


#End Region


#Region " Botones "

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        'BOTON OK
        GuardarDatos()
        blnImprimirfax = True
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        'BOTON CERRAR
        GuardarDatos()
        blnImprimirfax = False
        Me.Close()
    End Sub

#End Region

End Class