Public Class minimoc
    Dim c, i, redon, n As Integer
    Dim x(50), y(50), sx, sy, scx, sxy, a, b, vx, vy, xmedia, ymedia As Single

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        menusegundo.Show()
    End Sub


    Dim g As Graphics

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        i = 0
        xmedia = 0
        ymedia = 0
        tn.Clear()
        tx.Clear()
        tc.Clear()
        Salida.Rows.Clear()
        ta.Clear()
        tb.Clear()
        Graf.Series(0).Points.Clear()
        Graf.Series(1).Points.Clear()
        Graf.Series(2).Points.Clear()
    End Sub



    Private Sub Graficar_Click(sender As Object, e As EventArgs) Handles Graficar.Click
        g = CreateGraphics()
        For i = 1 To n
            Graf.Series(0).Points.AddXY(Math.Round(x(i), 2), y(i))
        Next
        Graf.Series(2).Points.AddXY(Math.Round(vx, 2), vy)
        Graf.Series(1).Points.AddXY(x(1), a + b * x(1))
        Graf.Series(1).Points.AddXY(x(n), a + b * x(n))
    End Sub



    Private Sub Parejas_Click(sender As Object, e As EventArgs) Handles Parejas.Click
        n = tn.Text
        c = tc.Text
        vx = tx.Text
        redon = c + 2
        For i = 1 To n
            x(i) = InputBox("x(" & i & ")=")
            y(i) = InputBox("y(" & i & ")=")

            Salida.Rows.Add(i, x(i), y(i))

            sx = sx + x(i)
            sy = sy + y(i)
            scx = scx + x(i) ^ 2
            sxy = sxy + x(i) * y(i)

        Next
        xmedia = sx / n
        ymedia = sy / n

        b = (sxy - n * xmedia * ymedia) / (scx - n * xmedia ^ 2)
        a = (ymedia - b * xmedia)
        vy = a + b * vx



    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        ta.Text = "y(x)=" & a & "+" & b & "x"
        tb.Text = "y(" & vx & ")=" & vy
    End Sub


    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
End Class
