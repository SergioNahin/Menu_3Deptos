Public Class menusegundo
    Private Sub Jacobit_Click(sender As Object, e As EventArgs) Handles Jacobit.Click
        jacobimenu.Show()
        Me.Close()
    End Sub

    Private Sub Gausse_Click(sender As Object, e As EventArgs) Handles Gausse.Click
        gaussmenu.Show()
        Me.Close()
    End Sub

    Private Sub interpo_Click(sender As Object, e As EventArgs) Handles interpo.Click
        interpolacionmenu.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles cuadrados.Click
        minimoc.Show()
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