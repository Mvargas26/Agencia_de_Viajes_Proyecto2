Imports System.IO
Public Class frmReservaVuelo
    'Private Sub btnDestino_Click(sender As Object, e As EventArgs) Handles btnReserva.Click
    '    Dim contadorTiquetes As Integer = 50

    '    Try
    '        Dim Validado As Boolean = False

    '        If cmbPaisDestino.SelectedValue = "" Then
    '            Validado = True
    '        End If

    '        If Validado Then


    '            Dim URL As String = Application.StartupPath
    '            URL = My.Computer.FileSystem.CombinePath(URL, "ArchivosXML\Destinos.XML".Trim)

    '            If File.Exists(URL) Then



    '                Dim ListaDestinos As New List(Of Negocios.Destinos)

    '                ListaDestinos.Add(New Negocios.Destinos With {
    '                 .Vueloidentificador = Me.txtIdentifVuelo.Text,
    '                 .PaisDestino = Me.cmbPaisDestino.Text,
    '                 .FechaSalida = dtpikFechaSalida.Text,
    '                 .HoraSalida = dtpikHoraSalida.Text,
    '                 .PrecioTiquete = CInt(txtPrecioTiquete.Text),
    '                 .CantidadEspaciosDispo = CInt(txtEspaciosDisponibles.Text)
    '                 })

    '                Dim iGuardarDestino As New Negocios.OPERACIONES
    '                iGuardarDestino.AlmacenaXMLDestinos(URL, ListaDestinos)
    '                MessageBox.Show("Almacenado el Destino correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            End If

    '        Else
    '            MessageBox.Show("No existe la ruta para guardar el archivo")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, Me.Text)
    '    End Try



    'End Sub

    Private Sub cmbPaisDestino_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaisDestino.SelectedIndexChanged
        Try
            Dim contadorTiquetes As Integer = 50

            If cmbPaisDestino.SelectedIndex = 0 Then
                txtIdentifVuelo.Text = "01"
                txtPrecioTiquete.Text = "500"
                txtEspaciosdisponibles.Text = contadorTiquetes.ToString
            End If

            If cmbPaisDestino.SelectedIndex = 1 Then
                txtIdentifVuelo.Text = "55"
                txtPrecioTiquete.Text = "450"
                txtEspaciosdisponibles.Text = contadorTiquetes.ToString
            End If


            If cmbPaisDestino.SelectedIndex = 2 Then
                txtIdentifVuelo.Text = "55"
                txtPrecioTiquete.Text = "450"
                txtEspaciosdisponibles.Text = contadorTiquetes.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error al gaurdar informacion de destino en Interfaz")
        End Try
    End Sub

    Private Sub btnReserva_Click(sender As Object, e As EventArgs) Handles btnReserva.Click

    End Sub
End Class