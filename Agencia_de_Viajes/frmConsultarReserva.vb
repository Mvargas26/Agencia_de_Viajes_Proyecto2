Imports System.IO
Imports Negocios
Public Class frmConsultarReserva
    Private Sub btnConsultarReserva_Click(sender As Object, e As EventArgs) Handles btnConsultarReserva.Click
        Try
            Me.dgvDatos.Rows.Clear()



            Dim URL As String = Application.StartupPath
            URL = My.Computer.FileSystem.CombinePath(URL, "ArchivosXML\BoletosComprados.XML".Trim)

            If File.Exists(URL) Then
                Dim objNegocios As New OPERACIONES
                Dim arrInfocargada As New ArrayList
                arrInfocargada = objNegocios.LeerXML(URL)

                For Each dato As String() In arrInfocargada

                    Me.dgvDatos.Rows.Add(dato)

                Next
            Else
                MessageBox.Show("No existe la ruta del archivo")
            End If
        Catch ex As Exception
            MessageBox.Show("Se ha producido un error", "Lab", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class