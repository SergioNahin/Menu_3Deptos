Imports info.lundin.math
Public Class Cgauss
    Dim a, b, h, ec, err(500), integral(500), sum_intgrl, j As Single
    Dim k, n, redon, i, c As Integer

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        menutercero.Show()
    End Sub

    Dim g As Graphics
    Dim Exceltab = New Microsoft.Office.Interop.Excel.Application
    Dim path As String = Environment.CurrentDirectory + "\" + "Tabla Cuadratura de Gauss"
    Dim Libro = Exceltab.Workbooks.Open(Filename:=path)
    Dim ck, xk As Single 'Variables
    Dim fila As Integer

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
        n = 1
        'h = (b - a) / (2 * n)

        i = 0
        For Each celda In Libro.Sheets(1).Range("a2:a56")
            If celda.value = n Then
                fila = celda.row
            End If
        Next
        sum_intgrl = 0
        For k = 1 To n
            ck = Libro.sheets(1).cells(fila + (k - 1), 4).value
            xk = Libro.sheets(1).cells(fila + (k - 1), 3).value
            sum_intgrl = sum_intgrl + ck * f((b + a) / 2 + (b - a) / 2 * xk)
        Next
        'integral(i) = h / 3 * (f(a) - f(b) + sum_intgrl + sum_intgrl2)
        integral(i) = (b - a) / 2 * sum_intgrl
        Salida.Rows.Add(n, Math.Round(integral(i), redon), "-----")
        err(i) = 1
        Do While err(i) > ec
            n = n + 1
            i = i + 1

            For Each celda In Libro.Sheets(1).Range("a2:a56")
                If celda.value = n Then
                    fila = celda.row
                End If
            Next
            sum_intgrl = 0
            For k = 1 To n
                ck = Libro.sheets(1).cells(fila + (k - 1), 4).value
                xk = Libro.sheets(1).cells(fila + (k - 1), 3).value
                sum_intgrl = sum_intgrl + ck * f((b + a) / 2 + (b - a) / 2 * xk)
            Next
            integral(i) = (b - a) / 2 * sum_intgrl
            err(i) = Math.Abs((integral(i) - integral(i - 1)) / integral(i))
            Salida.Rows.Add(n, Math.Round(integral(i), redon), Math.Round(err(i), redon))
        Loop


    End Sub

    Private Sub Graficar_Click(sender As Object, e As EventArgs) Handles Graficar.Click
        g = Graf.CreateGraphics()
        j = a - 1
        Do While j <= b + 1
            Graf.Series(0).Points.AddXY(Math.Round(j, 1), f(j))
            j = j + 0.1
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

    Private Sub Volver_MouseHover(sender As Object, e As EventArgs) Handles Volver.MouseHover
        Volver.BackColor = Color.Pink
    End Sub

    Private Sub Volver_MouseLeave(sender As Object, e As EventArgs) Handles Volver.MouseLeave
        Volver.BackColor = Color.Transparent
    End Sub
End Class