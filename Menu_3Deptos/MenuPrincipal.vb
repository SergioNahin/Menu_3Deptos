Public Class menufinal
    Private Sub menu1_Click(sender As Object, e As EventArgs) Handles menu1.Click
        menuprimero.Show()
        Me.Hide()

    End Sub

    Private Sub menu2_Click(sender As Object, e As EventArgs) Handles menu2.Click
        menusegundo.Show()
        Me.Hide()
    End Sub

    Private Sub menu3_Click(sender As Object, e As EventArgs) Handles menu3.Click
        menutercero.Show()
        Me.Hide()
    End Sub

    Private Sub integrantes_Click(sender As Object, e As EventArgs) Handles integrantes.Click
        integrap.Text() = (" M A N C O x P L A Y E R S

Chavez Xolalpa Juan Antonio

Domínguez Navarrete Eduardo

Pacheco García Víctor Alejandro

Trinidad Ramirez Sergio Nahin

Valencia Neri Norma Angélica")
    End Sub

    Private Sub menu1_MouseHover(sender As Object, e As EventArgs) Handles menu1.MouseHover
        menu1.BackColor = Color.PowderBlue
    End Sub

    Private Sub menu1_MouseLeave(sender As Object, e As EventArgs) Handles menu1.MouseLeave
        menu1.BackColor = Color.CadetBlue
    End Sub

    Private Sub menu2_MouseHover(sender As Object, e As EventArgs) Handles menu2.MouseHover
        menu2.BackColor = Color.PowderBlue
    End Sub

    Private Sub menu2_MouseLeave(sender As Object, e As EventArgs) Handles menu2.MouseLeave
        menu2.BackColor = Color.CadetBlue
    End Sub

    Private Sub menu3_MouseHover(sender As Object, e As EventArgs) Handles menu3.MouseHover
        menu3.BackColor = Color.PowderBlue
    End Sub

    Private Sub menu3_MouseLeave(sender As Object, e As EventArgs) Handles menu3.MouseLeave
        menu3.BackColor = Color.CadetBlue
    End Sub

    Private Sub integrantes_MouseHover(sender As Object, e As EventArgs) Handles integrantes.MouseHover
        integrantes.BackColor = Color.PowderBlue
    End Sub

    Private Sub integrantes_MouseLeave(sender As Object, e As EventArgs) Handles integrantes.MouseLeave
        integrantes.BackColor = Color.CadetBlue
    End Sub
End Class
