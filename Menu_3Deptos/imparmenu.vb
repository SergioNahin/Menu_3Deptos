Public Class Fimpares
    Dim fin, k, impar As Integer

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Tn.Clear()
        Salida.Rows.Clear()
    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles Volver.Click
        Me.Close()
        menuprimero.Show()
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        fin = Tn.Text()
        For k = 1 To fin
            impar = 2 * k - 1
            Salida.Rows.Add(k, impar)
        Next
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub
End Class
