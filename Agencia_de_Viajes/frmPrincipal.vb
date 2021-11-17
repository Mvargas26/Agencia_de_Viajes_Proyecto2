Public Class frmPrincipal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub DestinoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DestinoToolStripMenuItem.Click
        Try 'Muestra pantalla Destino
            Dim frmPantalla As New frmReservaVuelo
            With frmPantalla
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub ReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem.Click
        Try 'Muestra pantalla Reservas
            Dim frmPantalla As New frmConsultarReserva
            With frmPantalla
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Try 'Muestra pantalla Compras
            Dim frmPantalla As New frmCompra
            With frmPantalla
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        Try 'Muestra pantalla Compras
            Dim frmPantalla As New frmAcercaDe
            With frmPantalla
                .MdiParent = Me
                .Show()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text)
        End Try
    End Sub
End Class
