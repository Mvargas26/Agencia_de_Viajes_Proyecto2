Imports System.IO
Imports Negocios
Public Class frmConsultarReserva
    Private Sub btnConsultarReserva_Click(sender As Object, e As EventArgs) Handles btnConsultarReserva.Click
        Try
            Dim CedulaConsultar As String = String.Empty 'variable que almacena la cedula a consultar

            If String.IsNullOrEmpty(Me.txtCedulaAConsultar.Text.Trim) Then
                MessageBox.Show("Aun no Indica la cedula a consultar")
                Exit Sub
            End If

            If Not IsNumeric(txtCedulaAConsultar.Text.Trim) Then ' si no es numerica sale del proceso
                MessageBox.Show("La cedula debe ser numerica")
                Exit Sub
            Else
                CedulaConsultar = txtCedulaAConsultar.Text

                Me.dgvDatos.Rows.Clear()

                Dim URL As String = Application.StartupPath
                URL = My.Computer.FileSystem.CombinePath(URL, "ArchivosXML\ReservasRealizadas.XML".Trim)

                If File.Exists(URL) Then
                    Dim objNegocios As New OPERACIONES
                    Dim arrInfocargada As New ArrayList
                    arrInfocargada = objNegocios.LeerXML(URL)

                    For Each dato As String() In arrInfocargada
                        Try
                            If dato(0) = CedulaConsultar Then
                                Me.dgvDatos.Rows.Add(dato)
                            Else
                                Throw New Exception
                            End If
                        Catch ex As Exception
                            '´no hace nada para que no la agregue
                        End Try

                    Next
                    If Not dgvDatos.Rows.Count > 0 Then
                        MessageBox.Show("No hay reservas guardadas con este numero de Cedula")
                        txtCedulaAConsultar.Clear()
                    End If

                Else
                    MessageBox.Show("No existe la ruta del archivo")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error", "Interfaz", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class