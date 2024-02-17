Public Class raizmenu
    Dim i, c, redon As Integer

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        x(i) = Ti.Text
        c = Tc.Text
        ec = 0.5 * 10 ^ (-c)
        err(i) = 1
        redon = c + 2
        Do While err(i) > ec
            i = i + 1
            x(i) = 0.5 * (x(i - 1) + 2 / x(i - 1))
            err(i) = Math.Abs((x(i) - x(i - 1)) / x(i))
            Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(err(i), redon))
        Loop
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Ti.Clear()
        Tc.Clear()
        Salida.Rows.Clear()
    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        menuprimero.Show()
    End Sub

    Dim x(50), ec, err(50) As Single
    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
End Class
