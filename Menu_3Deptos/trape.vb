Imports info.lundin.math
Public Class trape
    Dim a, b, h, ec, err(500), integral(500), sum_intgrl, j As Single

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        i = 0
        tf.Clear()
        ta.Clear()
        tb.Clear()
        tc.Clear()
        Salida.Rows.Clear()
        Graf.Series(0).Points.Clear()
        Graf.Series(1).Points.Clear()
    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        menutercero.Show()
    End Sub

    Dim k, n, redon, i, c As Integer
    Dim g As Graphics
    Function f(x As Single) As Single
        Dim parser As ExpressionParser
        parser = New ExpressionParser
        parser.Values.Clear()
        parser.Values.Add("x", x)
        parser.Values.Add("e", 2.7183)
        parser.Values.Add("pi", 3.1416)
        Return parser.Parse(tf.Text)
    End Function
    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        a = ta.Text
        b = tb.Text
        c = tc.Text
        redon = c + 2
        ec = 0.5 * 10 ^ (-c)
        'n = 100
        n = 10
        h = (b - a) / n
        sum_intgrl = 0
        For k = 1 To n - 1
            'sum_intgrl = sum_intgrl + h * f(a + k * h)
            sum_intgrl = sum_intgrl + 2 * f(a + k * h)
        Next
        'integral(i) = sum_intgrl
        integral(i) = h / 2 * (f(a) + f(b) + sum_intgrl)
        Salida.Rows.Add(n, Math.Round(integral(i), redon), "-----")
        err(i) = 1

        Do While err(i) > ec
            'n = n + 100
            n = n + 10
            i = i + 1
            h = (b - a) / n
            sum_intgrl = 0
            For k = 1 To n - 1
                'sum_intgrl = sum_intgrl + h * f(a + k * h)
                sum_intgrl = sum_intgrl + 2 * f(a + k * h)
            Next
            'integral(i) = sum_intgrl
            integral(i) = h / 2 * (f(a) + f(b) + sum_intgrl)
            err(i) = Math.Abs((integral(i) - integral(i - 1)) / integral(i))
            Salida.Rows.Add(n, Math.Round(integral(i), redon), Math.Round(err(i), redon))
        Loop


    End Sub

    Private Sub Graficar_Click(sender As Object, e As EventArgs) Handles Graficar.Click
        g = Graf.CreateGraphics()
        j = a - 1
        Do While j <= b + 1
            For i = 1 To n - 1
                Graf.Series(0).Points.AddXY(Math.Round(j, 1), f(j))
                j = j + 0.1
            Next
        Loop
        j = a
        Do While j <= b
            Graf.Series(1).Points.AddXY(Math.Round(j, 1), f(j))
            j = j + 0.1
        Loop


    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
End Class
