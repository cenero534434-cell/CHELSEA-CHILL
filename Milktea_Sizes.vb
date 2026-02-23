Public Class Milktea_Sizes
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Pnl_MT_Solo.Visible = True
        Pnl_MT_2for.Visible = False
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Pnl_MT_Solo.Visible = False
        Pnl_MT_2for.Visible = True
    End Sub

    Private Sub Pnl_MT_2for_Paint(sender As Object, e As PaintEventArgs) Handles Pnl_MT_2for.Paint

    End Sub
End Class