Public Class Icecramble_SIze

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        pnlicecrambletoppings.Visible = True
        pnlicecramblesize.Visible = False
        pnlicecrambleminnies.Visible = False
    End Sub


    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        pnlicecrambleminnies.Visible = True
        pnlicecramblesize.Visible = False
        pnlicecrambletoppings.Visible = False
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        pnlicecramblesize.Visible = True
        pnlicecrambletoppings.Visible = False
        pnlicecrambleminnies.Visible = False
    End Sub

    Private Sub Icecramble_SIze_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlicecramblesize.Visible = True
        pnlicecrambletoppings.Visible = False
        pnlicecrambleminnies.Visible = False
    End Sub
End Class