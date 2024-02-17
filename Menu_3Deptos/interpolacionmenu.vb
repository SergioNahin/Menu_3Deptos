Public Class interpolacionmenu
    Dim i, c, redon, n, ib As Integer
    Dim x(), y(), Vx, Vy As Single

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        i = 0
        tc.Clear()
        tn.Clear()
        tvx.Clear()
        tib.Clear()
        tv.Clear()
        Graf.Series(0).Points.Clear()
        Graf.Series(1).Points.Clear()
        Salida.Rows.Clear()
    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        menusegundo.Show()
    End Sub

    Dim g As Graphics

    Private Sub Graficar_Click(sender As Object, e As EventArgs) Handles Graficar.Click
        g = Graf.CreateGraphics()
        For i = 0 To n - 1
            Graf.Series(0).Points.AddXY(Math.Round(x(i), 1), y(i))
        Next
        Graf.Series(1).Points.AddXY(Math.Round(Vx, 1), Vy)

    End Sub

    Private Sub Segundo_Click(sender As Object, e As EventArgs) Handles Segundo.Click
        redon = c + 2
        Vy = (((Vx - x(ib + 1)) * (Vx - x(ib + 2))) / ((x(ib) - x(ib + 1)) * (x(ib) - x(ib + 2)))) * y(ib) + (((Vx - x(ib)) * (Vx - x(ib + 2))) / ((x(ib + 1) - x(ib)) * (x(ib + 1) - x(ib + 2)))) * y(ib + 1) + (((Vx - x(ib)) * (Vx - x(ib + 1))) / ((x(ib + 2) - x(ib)) * (x(ib + 2) - x(ib + 1)))) * y(ib + 2)
        tv.Text = Math.Round(Vy, redon)
    End Sub

    Private Sub Primer_Click(sender As Object, e As EventArgs) Handles Primer.Click
        redon = c + 2
        Vy = ((Vx - x(ib + 1)) / (x(ib) - x(ib + 1))) * y(ib) + ((Vx - x(ib)) / (x(ib + 1) - x(ib))) * y(ib + 1)
        tv.Text = Math.Round(Vy, redon)
    End Sub



    Private Sub Parejas_Click(sender As Object, e As EventArgs) Handles Parejas.Click
        n = tn.Text
        c = tc.Text
        Vx = tvx.Text
        ReDim x(0 To n)
        ReDim y(0 To n)
        For i = 0 To n - 1
            x(i) = InputBox("x(" & i & ")=")
            y(i) = InputBox("y(" & i & ")=")
            Salida.Rows.Add(i, x(i), y(i))
        Next
        tib.Text = ib
        For i = 0 To n - 1
            If Vx > x(i) Then
                ib = i
            End If
        Next
        tib.Text = ib
    End Sub


    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
End Class
