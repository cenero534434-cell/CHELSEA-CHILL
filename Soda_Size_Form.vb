Public Class Soda_Size_Form
    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Panel3.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub Soda_Size_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Panel3.Visible = False
        Panel2.Visible = True
    End Sub
End Class