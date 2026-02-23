Public Class Menu_Burger_form

    Private Sub Dashboard_BTN_Click(sender As Object, e As EventArgs) Handles Dashboard_BTN.Click
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

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim Obj = New Login_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
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

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class