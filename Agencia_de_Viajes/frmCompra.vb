Imports System.IO
Imports Negocios

Public Class frmCompra
#Region "Variables"
    'variables usadas para calculos antes de almacenar informacion 
    Dim objOperaciones As New OPERACIONES

#End Region

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

    Private Sub chk14k_CheckedChanged(sender As Object, e As EventArgs) Handles chk14k.CheckedChanged
        Try
            If chk10a14.Checked Then
                chk20k.Checked = False
                chk25k.Checked = False

            End If
            objOperaciones.ValorMaletasExtra = 50
            objOperaciones.PesoMaleta = 14

        Catch ex As Exception
            MessageBox.Show("Error al calcular valor maleta de 14 K")
        End Try
    End Sub

    Private Sub chk20k_CheckedChanged(sender As Object, e As EventArgs) Handles chk20k.CheckedChanged
        Try
            If chk20k.Checked Then
                chk10a14.Checked = False
                chk25k.Checked = False

            End If
            objOperaciones.ValorMaletasExtra = 60
            objOperaciones.PesoMaleta = 20

        Catch ex As Exception
            MessageBox.Show("Error al calcular valor maleta de 20 K")
        End Try
    End Sub

    Private Sub chk25k_CheckedChanged(sender As Object, e As EventArgs) Handles chk25k.CheckedChanged
        Try
            If chk25k.Checked Then
                chk10a14.Checked = False
                chk20k.Checked = False

            End If
            objOperaciones.ValorMaletasExtra = 75
            objOperaciones.PesoMaleta = 25

        Catch ex As Exception
            MessageBox.Show("Error al calcular valor maleta de 20 K")
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

    Private Sub dtpFechaSalida_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaSalida.ValueChanged
        Try
            Dim strfechaSalida As Date = dtpFechaSalida.Value
            Dim strFechaRegreso As Date = dtpFechaRegreso.Value

            objOperaciones.Cantidaddias = DateDiff("d", strfechaSalida, strFechaRegreso)

            If objOperaciones.Cantidaddias > 1 Then
                MessageBox.Show(" La fecha de salida debe ser menor a la fecha de regreso")
                txtCantidadDias.Text = ""
                Exit Sub
            Else
                txtCantidadDias.Text = objOperaciones.Cantidaddias.ToString

                If objOperaciones.Cantidaddias > 0 And objOperaciones.Cantidaddias < 5 Then
                    chk0a5.Checked = True
                ElseIf objOperaciones.Cantidaddias > 5 And objOperaciones.Cantidaddias < 9 Then
                    chk0a9.Checked = True
                ElseIf objOperaciones.Cantidaddias > 10 And objOperaciones.Cantidaddias < 14 Then
                    chk10a14.Checked = True
                ElseIf objOperaciones.Cantidaddias > 14 And objOperaciones.Cantidaddias < 19 Then
                    chk15a19.Checked = True
                ElseIf objOperaciones.Cantidaddias > 19 Then
                    chkmas20.Checked = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al calcular Cantidad de Dias")
        End Try
    End Sub

    Private Sub dtpFechaRegreso_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaRegreso.ValueChanged
        Try
            Dim strfechaSalida As Date = dtpFechaSalida.Value
            Dim strFechaRegreso As Date = dtpFechaRegreso.Value

            objOperaciones.Cantidaddias = DateDiff("d", strfechaSalida, strFechaRegreso)
            txtCantidadDias.Text = objOperaciones.Cantidaddias.ToString

            If objOperaciones.Cantidaddias > 1 Then
                MessageBox.Show(" La fecha de salida debe ser menor a la fecha de regreso")
                txtCantidadDias.Text = ""
                Exit Sub
            Else

                If objOperaciones.Cantidaddias > 0 And objOperaciones.Cantidaddias < 5 Then
                    chk0a5.Checked = True
                ElseIf objOperaciones.Cantidaddias > 5 And objOperaciones.Cantidaddias < 9 Then
                    chk0a9.Checked = True
                ElseIf objOperaciones.Cantidaddias > 10 And objOperaciones.Cantidaddias < 14 Then
                    chk10a14.Checked = True
                ElseIf objOperaciones.Cantidaddias > 14 And objOperaciones.Cantidaddias < 19 Then
                    chk15a19.Checked = True
                ElseIf objOperaciones.Cantidaddias > 19 Then
                    chkmas20.Checked = True
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error al calcular Cantidad de Dias")
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
            Dim boletoCalculado As Boolean = False


            If boletoCalculado = False Then


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

            Dim preci As String = objOperaciones.calculoPrecioBoleto.ToString
            txtPrecioTiquete.Text = "$" + preci






        Catch ex As Exception

        End Try
    End Sub




End Class '//// FIN CLASSSSSSSSS //////////////////////////////////////
