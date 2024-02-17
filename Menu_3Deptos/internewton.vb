Public Class InterNewtonForm
    Dim i, c, n, redon, ib, k, j, a As Integer

    Private Sub Volver_Click(sender As Object, e As EventArgs)
        Me.Close()
        menutercero.Show()
    End Sub

    Private Sub Volver_Click_1(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        menutercero.Show()
    End Sub

    Private Sub InterNewtonForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim x(), y(), vx, s, cs(), dy(), m, fac, sumdel, sumainter, vy As Single
    Dim g As Graphics

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        n = tn.Text
        c = tc.Text
        vx = tvx.Text
        redon = c + 2
        ReDim x(0 To n), y(0 To n)
        For i = 0 To n - 1
            x(i) = InputBox("x(" & i & ")= ")
            y(i) = InputBox("y(" & i & ")= ")

            Salida1.Rows.Add(i, x(i), y(i))
            Salida1.Rows.Add(" ", " ", " ")
        Next
        i = 0
        Do While vx > x(i)
            i = i + 1
        Loop
        ib = i - 1
        tib.Text = ib

        s = (vx - x(ib)) / (x(ib + 1) - x(ib))
        ts.Text = s

        m = n - (ib + 1)
        tm.Text = m

        ReDim cs(0 To m)
        cs(0) = 1
        ReDim dy(0 To m)
        dy(0) = y(ib)

        Salida2.Rows.Add(cs(0), dy(0))

        sumainter = cs(0) * dy(0)
        a = 1

        For k = 1 To m
            fac = 1
            For i = 1 To k
                fac = fac * (s - (i - 1)) / i
            Next
            cs(k) = fac

            sumdel = 0
            For j = 0 To k
                fac = 1
                For i = 1 To j
                    fac = fac * (k - (i - 1)) / i
                Next
                sumdel = sumdel + (-1) ^ j * fac * y(ib + k - j)
            Next
            dy(k) = sumdel
            Salida1.Rows(2 * ib + a).Cells(2 + a).Value = Math.Round(dy(k), redon)
            a = a + 1

            sumainter = sumainter + cs(k) * dy(k)
            Salida2.Rows.Add(cs(k), Math.Round(dy(k), redon))
        Next
        vy = Math.Round(sumainter, redon)
        tin.Text = vy

    End Sub

    Private Sub Graficar_Click(sender As Object, e As EventArgs) Handles Graficar.Click
        g = CreateGraphics()
        For i = 0 To n - 1
            Grafica.Series(0).Points.AddXY(Math.Round(x(i), redon), y(i))
        Next
        Grafica.Series(1).Points.AddXY(Math.Round(vx, redon), vy)
    End Sub

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        tn.Clear()
        tvx.Clear()
        tc.Clear()
        tib.Clear()
        tin.Clear()
        ts.Clear()
        tm.Clear()
        Grafica.Series(0).Points.Clear()
        Grafica.Series(1).Points.Clear()
        Salida1.Rows.Clear()
        Salida2.Rows.Clear()
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
