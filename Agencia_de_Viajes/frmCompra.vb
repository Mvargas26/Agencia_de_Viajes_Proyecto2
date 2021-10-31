Public Class frmCompra
    Private Sub chkAcompanantes_CheckedChanged(sender As Object, e As EventArgs) Handles chkAcompanantes.CheckedChanged
        Try ' Permite agregar datos de los acopañantes
            If chkAcompanantes.Checked Then
                grpAcompanantes.Visible = True
            Else
                grpAcompanantes.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try

    End Sub

    Private Sub chkMaletasExtra_CheckedChanged(sender As Object, e As EventArgs) Handles chkMaletasExtra.CheckedChanged
        Try ' Permite agregar datos de Maletas Extra
            If chkMaletasExtra.Checked Then
                grpMaletas.Visible = True
            Else
                grpMaletas.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub chkServiciosExtra_CheckedChanged(sender As Object, e As EventArgs) Handles chkServiciosExtra.CheckedChanged
        Try ' Permite agregar datos de Servicios Extra
            If chkServiciosExtra.Checked Then
                grpServiciosExtra.Visible = True
            Else
                grpServiciosExtra.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub
End Class