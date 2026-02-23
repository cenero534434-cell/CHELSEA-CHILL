Public Class Category_Beverages_Form
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim Obj = New Login_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim Obj = New Manager_Dashboard_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Cashier_BTN_Click(sender As Object, e As EventArgs) Handles Cashier_BTN.Click
        Dim Obj = New Manager_Cashier_Form
        Obj.Show()
        Me.Hide()
    End Sub


    Private Sub Financial_BTN_Click(sender As Object, e As EventArgs) Handles Financial_BTN.Click
        Dim Obj = New Manager_Expense_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Inventory_BTN_Click(sender As Object, e As EventArgs) Handles Inventory_BTN.Click
        Dim Obj = New Manager_Inventory_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Report_BTN_Click(sender As Object, e As EventArgs) Handles Report_BTN.Click
        Dim Obj = New Manager_Report_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Maintenance_BTN_Click(sender As Object, e As EventArgs) Handles Maintenance_BTN.Click
        Dim Obj = New Maintenance_EM_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Obj = New Manager_Cashier_Form
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

    Private Sub Burger_btn_Click(sender As Object, e As EventArgs) Handles Burger_btn.Click
        Dim Obj = New Menu_FruitSoda_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim Obj = New Menu_IceScramble_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim Obj = New Menu_IcedCoffee_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim Obj = New Menu_IcedMatcha_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Obj = New Menu_NonCoffeeForm
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim Obj = New Menu_Milktea_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub show_panel1_Paint(sender As Object, e As PaintEventArgs) Handles show_panel1.Paint

    End Sub
End Class