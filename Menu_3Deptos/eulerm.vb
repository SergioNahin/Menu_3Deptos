Imports info.lundin.math
Public Class Eulermej

    Dim x(1000), y(1000), h, j, xf, A As Single

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        menutercero.Show()
    End Sub

    Dim i, redon, c, n As Integer

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        x(i) = tx.Text
        y(i) = ty.Text
        xf = txf.Text
        h = th.Text
        c = tc.Text
        redon = c + 2
        Salida.Rows.Add(Math.Round(x(i), redon), Math.Round(y(i), redon))
        While x(i) <= xf - 0.01
            i = i + 1
            A = y(i - 1) + h * f(x(i - 1), y(i - 1))
            y(i) = y(i - 1) + (h / 2) * (f(x(i - 1), y(i - 1)) + f(x(i - 1) + h, A))
            x(i) = x(i - 1) + h
            Salida.Rows.Add(i, Math.Round(x(i), redon), Math.Round(y(i), redon))
        End While
        tvy.Text = Math.Round(y(i), redon)
    End Sub
    Private Sub Salir_Click_1(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        tx.Clear()
        ty.Clear()
        txf.Clear()
        th.Clear()
        tf.Clear()
        tc.Clear()
        tvy.Clear()
        Salida.Rows.Clear()
    End Sub


    Function f(x As Single, y As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("y", y)
        parser.Values.Add("pi", 3.1416)
        parser.Values.Add("e", 2.7183)
        Return parser.Parse(tf.Text)

    End Function

    Private Sub Volver_MouseHover(sender As Object, e As EventArgs) Handles Volver.MouseHover
        Volver.BackColor = Color.Pink
    End Sub

    Private Sub Volver_MouseLeave(sender As Object, e As EventArgs) Handles Volver.MouseLeave
        Volver.BackColor = Color.Transparent
    End Sub
End Class
