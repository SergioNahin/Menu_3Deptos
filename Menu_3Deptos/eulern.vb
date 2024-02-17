Imports info.lundin.math
Public Class MetEuler
    Dim x, y, h, j, xf As Single
    Dim i, redon, c, n As Integer

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        menufinal.Show()
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        x = tx.Text
        y = ty.Text
        xf = txf.Text
        h = th.Text
        c = tc.Text
        redon = c + 2
        i = 0
        Salida.Rows.Add(Math.Round(x, redon), Math.Round(y, redon))
        While x <= xf - 0.01
            i = i + 1
            y = y + h * f(x, y)
            x = x + h
            Salida.Rows.Add(i, Math.Round(x, redon), Math.Round(y, redon))
        End While
        tvy.Text = Math.Round(y, redon)
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

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
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
