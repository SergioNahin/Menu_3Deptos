Public Class MenuPrincipal
    Private Sub btnImpares_Click(sender As Object, e As EventArgs) Handles btnImpares.Click
        Fimpares.Show()


    End Sub

    Private Sub btnInterpolacion_Click(sender As Object, e As EventArgs) Handles btnInterpolacion.Click
        interpolacionmenu.Show()


    End Sub

    Private Sub btngaussen_Click(sender As Object, e As EventArgs) Handles btngaussen.Click
        gaussmenu.Show()


    End Sub

    Private Sub btnjacobi_Click(sender As Object, e As EventArgs) Handles btnjacobi.Click
        jacobimenu.Show()
    End Sub

    Private Sub btnnewton_Click(sender As Object, e As EventArgs) Handles btnnewton.Click
        newtonmenu.Show()

    End Sub

    Private Sub btnraiz_Click(sender As Object, e As EventArgs) Handles btnraiz.Click
        raizmenu.Show()
    End Sub

    Private Sub btnregla_Click(sender As Object, e As EventArgs) Handles btnregla.Click
        reglamenu.Show()

    End Sub

    Private Sub btnbiseccion_Click(sender As Object, e As EventArgs) Handles btnbiseccion.Click
        biseccionmenu.Show()
    End Sub
End Class
