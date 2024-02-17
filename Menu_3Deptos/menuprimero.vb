Public Class menuprimero
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles impare.Click
        Fimpares.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles raiz.Click
        raizmenu.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles reglaf.Click
        reglamenu.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles newton.Click
        newtonmenu.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bisecci.Click
        biseccionmenu.Show()
        Me.Close()
    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        menufinal.Show()
    End Sub
    Private Sub Volver_MouseHover(sender As Object, e As EventArgs) Handles Volver.MouseHover
        Volver.BackColor = Color.Pink
    End Sub

    Private Sub Volver_MouseLeave(sender As Object, e As EventArgs) Handles Volver.MouseLeave
        Volver.BackColor = Color.Transparent
    End Sub
End Class