Public Class menutercero
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles internewton.Click
        InterNewtonForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Rectangulo.Click
        intrec.Show()
        Me.Hide()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Trapecio.Click
        trape.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Simpson.Click
        simp.Show()
        Me.Hide()

    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        menufinal.Show()
    End Sub

    Private Sub internewton_MouseHover(sender As Object, e As EventArgs) Handles internewton.MouseHover
        internewton.BackColor = Color.PowderBlue
    End Sub

    Private Sub internewton_MouseLeave(sender As Object, e As EventArgs) Handles internewton.MouseLeave
        internewton.BackColor = Color.Transparent
    End Sub

    Private Sub Rectangulo_MouseHover(sender As Object, e As EventArgs) Handles Rectangulo.MouseHover
        Rectangulo.BackColor = Color.PowderBlue
    End Sub

    Private Sub Rectangulo_MouseLeave(sender As Object, e As EventArgs) Handles Rectangulo.MouseLeave
        Rectangulo.BackColor = Color.Transparent
    End Sub

    Private Sub Trapecio_MouseHover(sender As Object, e As EventArgs) Handles Trapecio.MouseHover
        Trapecio.BackColor = Color.PowderBlue
    End Sub

    Private Sub Trapecio_MouseLeave(sender As Object, e As EventArgs) Handles Trapecio.MouseLeave
        Trapecio.BackColor = Color.Transparent
    End Sub

    Private Sub Simpson_MouseHover(sender As Object, e As EventArgs) Handles Simpson.MouseHover
        Simpson.BackColor = Color.PowderBlue
    End Sub

    Private Sub Simpson_MouseLeave(sender As Object, e As EventArgs) Handles Simpson.MouseLeave
        Simpson.BackColor = Color.Transparent
    End Sub

    Private Sub Volver_MouseHover(sender As Object, e As EventArgs) Handles Volver.MouseHover
        Volver.BackColor = Color.Pink
    End Sub

    Private Sub Volver_MouseLeave(sender As Object, e As EventArgs) Handles Volver.MouseLeave
        Volver.BackColor = Color.Transparent
    End Sub

    Private Sub eulerb_Click(sender As Object, e As EventArgs) Handles eulerb.Click
        MetEuler.Show()
        Me.Hide()
    End Sub

    Private Sub eulerme_Click(sender As Object, e As EventArgs) Handles eulerme.Click
        Eulermej.Show()
        Me.Hide()
    End Sub

    Private Sub gauss_Click(sender As Object, e As EventArgs) Handles gauss.Click
        Cgauss.Show()
        Me.Hide()
    End Sub

    Private Sub Rungekutta_Click(sender As Object, e As EventArgs) Handles Rungekutta.Click
        runge1.Show()
        Me.Hide()
    End Sub
End Class