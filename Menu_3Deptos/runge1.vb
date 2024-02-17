Imports info.lundin.math
Public Class runge1
    Dim x, y, xf, h, k1, k2, k3, k4 As Single

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        menutercero.Show()
    End Sub

    Dim c, i, redon As Integer

    Dim flag As Boolean
    Function f(x As Single, y As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("y", y)
        parser.Values.Add("e", 2.7183)
        parser.Values.Add("pi", 3.1416)
        parser.Values.Add("xy", x * y)
        parser.Values.Add("yx", y * x)
        Return parser.Parse(tf.Text)
    End Function
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        c = tc.Text
        x = tx.Text
        xf = txf.Text
        y = ty.Text
        h = th.Text
        i = 0
        redon = c + 2
        Salida.Rows.Add(i, x, y)
        While flag = False
            If xf - Math.Round(x, 2) > 0 Then
                i = i + 1
                k1 = f(x, y)
                k2 = f(x + (h / 2), y + (h / 2) * k1)
                k3 = f(x + (h / 2), y + (h / 2) * k2)
                k4 = f(x + h, y + h * k3)
                y = y + (h / 6) * (k1 + (2 * k2) + (2 * k3) + k4)
                x = x + h
                Salida.Rows.Add(i, x, Math.Round(y, redon))
            Else
                flag = True
            End If
        End While
        tvy.Text = Math.Round(y, redon)
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        flag = False
        tx.Clear()
        ty.Clear()
        txf.Clear()
        tvy.Clear()
        tf.Clear()
        th.Clear()
        tc.Clear()
        Salida.Rows.Clear()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub Volver_MouseHover(sender As Object, e As EventArgs) Handles Volver.MouseHover
        Volver.BackColor = Color.Pink
    End Sub

    Private Sub Volver_MouseLeave(sender As Object, e As EventArgs) Handles Volver.MouseLeave
        Volver.BackColor = Color.Transparent
    End Sub
End Class
