Imports System.IO
Public Class frmCompra
    Dim cantAcompa As Integer = 0
    Private Sub txtCantidadAcompanantes_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadAcompanantes.TextChanged
        'validamos si cant de acompanantes es mas que 0, permite ingresar los datos del mismo
        Try

            If txtCantidadAcompanantes.Text = "" Or Not IsNumeric(txtCantidadAcompanantes.Text) Then
                cantAcompa = 0
                MessageBox.Show("Favor ingrese un valor numerico")
            Else
                cantAcompa = CInt(txtCantidadAcompanantes.Text)
            End If

            If cantAcompa <= 0 Then
                grpAcompanantes.Visible = False
            Else
                grpAcompanantes.Visible = True
            End If
        Catch ex As Exception
            'en blanco para que no haga nada
        End Try

    End Sub
End Class