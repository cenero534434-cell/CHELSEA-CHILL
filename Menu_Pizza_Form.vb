Public Class Menu_Pizza_Form
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Cashier_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Dashboard_Form
        Obj.Show()
        Me.Hide()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Expense_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Inventory_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Report_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim Obj = New Maintenance_EM_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        Dim Obj = New Login_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Dim Obj = New Login_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Cashier_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim Obj = New Category_Beverages_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim Obj = New Category_Appetizer_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim Obj = New Category_Noodles_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Cashier_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        Dim Obj = New Category_Beverages_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        Dim Obj = New Category_Appetizer_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        Dim Obj = New Category_Noodles_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim Obj = New Manager_Cashier_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Beverages_BTN_Click(sender As Object, e As EventArgs) Handles Beverages_BTN.Click
        Dim Obj = New Category_Beverages_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Appetizer_BTN_Click(sender As Object, e As EventArgs) Handles Appetizer_BTN.Click
        Dim Obj = New Category_Appetizer_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Noodles_BTN_Click(sender As Object, e As EventArgs) Handles Noodles_BTN.Click
        Dim Obj = New Category_Noodles_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub show_panel1_Paint(sender As Object, e As PaintEventArgs) Handles show_panel1.Paint

    End Sub
End Class