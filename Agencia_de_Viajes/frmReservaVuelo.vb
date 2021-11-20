Imports System.IO
Imports Negocios

Public Class frmReservaVuelo
    Dim objOperaciones As New OPERACIONES
    Dim boletoCalculado As Boolean = False
    Dim precioTiquete As Integer = 0

    Private Sub txtCantidadAcompanantes_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadAcompanantes.TextChanged
        'validamos si cant de acompanantes es mas que 0, permite ingresar los datos del mismo
        Try

            If txtCantidadAcompanantes.Text = "" Or Not IsNumeric(txtCantidadAcompanantes.Text) Then

                MessageBox.Show("Favor ingrese un valor numerico")
            Else
                objOperaciones.CantAcompanantes = CInt(txtCantidadAcompanantes.Text)
            End If

            If objOperaciones.CantAcompanantes <= 0 Then
                grpAcompanantes.Visible = False
            Else
                grpAcompanantes.Visible = True
            End If
        Catch ex As Exception
            'en blanco para que no haga nada
        End Try
    End Sub

    Private Sub chk0a5_CheckedChanged(sender As Object, e As EventArgs) Handles chk0a5.CheckedChanged
        Try
            If chk0a5.Checked Then 'validamos que solo este check este marcado
                chk0a9.Checked = False
                chk10a14.Checked = False
                chk15a19.Checked = False
                chkmas20.Checked = False

                objOperaciones.descuento = 0 ' no tiene descuento

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chk0a9_CheckedChanged(sender As Object, e As EventArgs) Handles chk0a9.CheckedChanged
        Try
            If chk0a9.Checked Then 'validamos que solo este check este marcado
                chk0a5.Checked = False
                chk10a14.Checked = False
                chk15a19.Checked = False
                chkmas20.Checked = False

                objOperaciones.descuento = 0.03 ' descuento toma valor de un 3%

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chk10a14_CheckedChanged(sender As Object, e As EventArgs) Handles chk10a14.CheckedChanged
        Try
            If chk10a14.Checked Then 'validamos que solo este check este marcado
                chk0a9.Checked = False
                chk0a5.Checked = False
                chk15a19.Checked = False
                chkmas20.Checked = False

                objOperaciones.descuento = 0.05 'descuento toma valor de 5%
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chk15a19_CheckedChanged(sender As Object, e As EventArgs) Handles chk15a19.CheckedChanged
        Try
            If chk15a19.Checked Then 'validamos que solo este check este marcado
                chk0a9.Checked = False
                chk10a14.Checked = False
                chk0a5.Checked = False
                chkmas20.Checked = False

                objOperaciones.descuento = 0.08 'descueento es de 8%

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkmas20_CheckedChanged(sender As Object, e As EventArgs) Handles chkmas20.CheckedChanged
        Try
            If chkmas20.Checked Then 'validamos que solo este check este marcado
                chk0a9.Checked = False
                chk10a14.Checked = False
                chk15a19.Checked = False
                chk0a5.Checked = False

                objOperaciones.descuento = 0.1

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chkZonaPrefe_CheckedChanged(sender As Object, e As EventArgs) Handles chkZonaPrefe.CheckedChanged
        Try
            If chkZonaPrefe.Checked Then
                chkZonaExLegrom.Checked = False
            End If

            objOperaciones.extrasZonaPrefe = 0.07

        Catch ex As Exception
            MessageBox.Show("Error al calcular impuesto Zona Preferencial")
        End Try
    End Sub

    Private Sub chkZonaExLegrom_CheckedChanged(sender As Object, e As EventArgs) Handles chkZonaExLegrom.CheckedChanged
        Try
            If chkZonaExLegrom.Checked Then
                chkZonaPrefe.Checked = False
            End If

            objOperaciones.extraZonaLegrom = 10

        Catch ex As Exception
            MessageBox.Show("Error al calcular impuesto Zona Legroom")
        End Try
    End Sub

    Private Sub chkInternetIlim_CheckedChanged(sender As Object, e As EventArgs) Handles chkInternetIlim.CheckedChanged
        Try
            If chkInternetIlim.Checked Then
                objOperaciones.extraInternet = 0.04
            End If

        Catch ex As Exception
            MessageBox.Show("Error al calcular impuesto Internet Ilimitado")
        End Try
    End Sub

    Private Sub chkFastTrack_CheckedChanged(sender As Object, e As EventArgs) Handles chkFastTrack.CheckedChanged
        Try
            If chkFastTrack.Checked Then
                objOperaciones.extrafasttrack = 0.05
            End If
        Catch ex As Exception
            MessageBox.Show("Error al calcular impuesto FAst Track")
        End Try
    End Sub

    Private Sub txtIdentifVuelo_TextChanged(sender As Object, e As EventArgs) Handles txtIdentifVuelo.TextChanged
        Try
            objOperaciones.Vueloidentificador = txtIdentifVuelo.Text
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCalcularMonto_Click(sender As Object, e As EventArgs) Handles btnCalcularMonto.Click
        Try
            If boletoCalculado = False Then

                'Calculamos cantidad de dias
                Dim strfechaSalida As Date = dtpFechaSalida.Value
                Dim strFechaRegreso As Date = dtpFechaRegreso.Value
                Dim resultadoDias As Long = 0

                resultadoDias = DateDiff(DateInterval.Day, strfechaSalida, strFechaRegreso)
                objOperaciones.Cantidaddias = 1 + CInt(resultadoDias)

                If objOperaciones.Cantidaddias < 1 Then
                    MessageBox.Show("La fecha de regreso debe ser mayor a la de salida")
                    txtCantidadDias.Text = "0"
                    Exit Sub
                Else
                    txtCantidadDias.Text = objOperaciones.Cantidaddias.ToString

                    If objOperaciones.Cantidaddias > 0 And objOperaciones.Cantidaddias < 6 Then
                        chk0a5.Checked = True
                    ElseIf objOperaciones.Cantidaddias > 4 And objOperaciones.Cantidaddias < 10 Then
                        chk0a9.Checked = True
                    ElseIf objOperaciones.Cantidaddias > 9 And objOperaciones.Cantidaddias < 15 Then
                        chk10a14.Checked = True
                    ElseIf objOperaciones.Cantidaddias > 14 And objOperaciones.Cantidaddias < 20 Then
                        chk15a19.Checked = True
                    ElseIf objOperaciones.Cantidaddias > 19 Then
                        chkmas20.Checked = True
                    End If
                End If

                If objOperaciones.Cantidaddias < 1 Then
                    MessageBox.Show("La fecha de salida debe ser menor a la fecha de regreso")
                    Exit Sub
                ElseIf cmbPaisDestino.Text = "" Then 'Validaciones obligatorias
                    MessageBox.Show("primero seleccione el pais de Destino")
                    Exit Sub
                ElseIf txtNombre.Text = "" Then
                    MessageBox.Show("Aun no ingresa su nombre")
                    Exit Sub
                ElseIf txtApellidos.Text = "" Then
                    MessageBox.Show("Su apellido es obligatorio")
                    Exit Sub
                ElseIf txtCedula.Text = "" Then
                    MessageBox.Show("Su Cedula es obligatoria")
                    Exit Sub
                ElseIf Not IsNumeric(txtCedula.Text) Then
                    MessageBox.Show("Su Cedula Debe ser Numerica")
                End If

                If IsNumeric(txtCantidadAcompanantes.Text) Then
                    If CInt(txtCantidadAcompanantes.Text) > 0 Then 'validacion para datos del acompanante
                        If txtNombreAcompanante.Text = "" Then
                            MessageBox.Show("Falta nombre del acompañante")
                            Exit Sub
                        ElseIf txtApellidoAcompanante.Text = "" Then
                            MessageBox.Show("Falta Apellido del acompañante")
                            Exit Sub
                        ElseIf txtCedulaAcompanante.Text = "" Then
                            MessageBox.Show("Falta Cedula del acompañante")
                            Exit Sub
                        End If
                    Else
                        'si lleva 0 acompanantes le damos valor 0 a estos txt
                        txtCedulaAcompanante.Text = "0"
                        txtCantidadAcompanantes.Text = "0"
                    End If
                End If

            End If 'fin Validaciones

            'Damos valor al precio del boleto dependdiendo del pasi  destino
            If cmbPaisDestino.SelectedIndex = 0 Then 'seleciono USA
                txtIdentifVuelo.Text = "+1"
                objOperaciones.PrecioTiquete = 500
            ElseIf cmbPaisDestino.SelectedIndex = 1 Then 'selecciono Brazil
                txtIdentifVuelo.Text = "+55"
                objOperaciones.PrecioTiquete = 450
            ElseIf cmbPaisDestino.SelectedIndex = 2 Then 'Selecciono mexico
                txtIdentifVuelo.Text = "+52"
                objOperaciones.PrecioTiquete = 300
            End If

            'almacenamos el costo del tiquete como entero y como string ya que lo usaremos de las 2 formas
            Dim preci As String = objOperaciones.calculoPrecioBoleto.ToString
            txtPrecioTiquete.Text = "$" + preci
            precioTiquete = CInt(preci)

            boletoCalculado = True



        Catch ex As Exception
            MessageBox.Show("Error al calcular la Reserva")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If boletoCalculado = False Then
                MessageBox.Show(" Por favor Calcule primero el Valor de su boleto")
                Exit Sub
            Else
                Dim URL As String = Application.StartupPath
                URL = My.Computer.FileSystem.CombinePath(URL, "ArchivosXML\ReservasRealizadas.XML".Trim)

                If Not File.Exists(URL) Then
                    Dim ListaBoletosComprados As New List(Of Negocios.OPERACIONES)
                    'estas validaciones son necesarias en el caso que no lleve acompañantes, por la conversion mas delante
                    If Not IsNumeric(txtCantidadAcompanantes.Text) Then
                        txtCantidadAcompanantes.Text = 0
                    End If
                    If Not IsNumeric(txtCedulaAcompanante.Text) Then
                        txtCedulaAcompanante.Text = 0
                    End If

                    ListaBoletosComprados.Add(New Negocios.OPERACIONES With {
                .IdentificacionCliente = CInt(Me.txtCedula.Text),
                 .Vueloidentificador = Me.txtIdentifVuelo.Text,
                 .NombreCliente = Me.txtNombre.Text,
                 .ApellidosCliente = Me.txtApellidos.Text,
                 .NacionalidadCliente = Me.txtNacionalidad.Text,
                 .PaisDestino = Me.cmbPaisDestino.Text,
                 .FechaSalida = dtpFechaSalida.Text,
                 .FechaRegreso = dtpFechaRegreso.Text,
                 .HoraSalida = dtpHoraSalida.Text,
                 .Cantidaddias = CInt(txtCantidadDias.Text),
                 .CantAcompanantes = CInt(txtCantidadAcompanantes.Text),
                 .NombreAcompanante = txtNombreAcompanante.Text,
                 .ApellidosAcompanante = txtApellidoAcompanante.Text,
                 .IdentificacionAcompanante = CInt(txtCedulaAcompanante.Text),
                .NacionalidadAcompanante = txtNAcionalidadAcompanante.Text,
                .PrecioTiquete = precioTiquete})


                    Dim guardarCompra As New OPERACIONES
                    guardarCompra.AlmacenaXML(URL, ListaBoletosComprados)
                    MessageBox.Show("Almacenada su compra correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim ListaBoletosComprados As New List(Of Negocios.OPERACIONES)

                    If Not IsNumeric(txtCantidadAcompanantes.Text) Then
                        txtCantidadAcompanantes.Text = 0
                    End If
                    If Not IsNumeric(txtCedulaAcompanante.Text) Then
                        txtCedulaAcompanante.Text = 0
                    End If

                    ListaBoletosComprados.Add(New Negocios.OPERACIONES With {
                .IdentificacionCliente = CInt(Me.txtCedula.Text),
                 .Vueloidentificador = Me.txtIdentifVuelo.Text,
                 .NombreCliente = Me.txtNombre.Text,
                 .ApellidosCliente = Me.txtApellidos.Text,
                 .NacionalidadCliente = Me.txtNacionalidad.Text,
                 .PaisDestino = Me.cmbPaisDestino.Text,
                 .FechaSalida = dtpFechaSalida.Text,
                 .FechaRegreso = dtpFechaRegreso.Text,
                 .HoraSalida = dtpHoraSalida.Text,
                 .Cantidaddias = CInt(txtCantidadDias.Text),
                 .CantAcompanantes = CInt(txtCantidadAcompanantes.Text),
                 .NombreAcompanante = txtNombreAcompanante.Text,
                 .ApellidosAcompanante = txtApellidoAcompanante.Text,
                 .IdentificacionAcompanante = CInt(txtCedulaAcompanante.Text),
                .NacionalidadAcompanante = txtNAcionalidadAcompanante.Text,
                .PrecioTiquete = precioTiquete})

                    Dim guardarCompra As New OPERACIONES
                    guardarCompra.insertarNodo(URL)

                    MessageBox.Show("Almacenada su compra correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub
End Class