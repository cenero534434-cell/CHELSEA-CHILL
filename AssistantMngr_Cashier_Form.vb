Imports MySql.Data.MySqlClient
Imports System.Text

Public Class AssistantMngr_Cashier_Form
    ' Declare connection and other required variables
    Dim connection As New MySqlConnection("server=localhost; userid=root; password=; database=chelseachill")

    Private Sub fetchProductData(Optional ByVal category As String = "Main Dish")
        Try
            If MainDishControl.FlowLayoutPanel.Controls.Count > 0 Then
                MainDishControl.FlowLayoutPanel.Controls.Clear()
            End If

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT * FROM tblproducts WHERE `Category`=@cat"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@cat", category)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim productID As String = reader("ProductID").ToString() ' Use ProductID instead of ProductCode
                    Dim productName As String = reader("ProductName").ToString()
                    Dim price As Decimal = Decimal.Parse(reader("Price").ToString())
                    Dim imagePath As String = reader("ProductImage").ToString()

                    Dim productCard As New ProductCardControl With {
                        .Tag = productID ' Change to ProductID
                    }

                    productCard.lblTitle.Text = productName
                    productCard.lblPrice.Text = price.ToString("F2")

                    ' Load the product image
                    If System.IO.File.Exists(imagePath) Then
                        productCard.imgProduct.Image = System.Drawing.Image.FromFile(imagePath)
                    End If

                    ' Handle image click event to add to receipt
                    AddHandler productCard.imgProduct.Click, Sub(senderObj, eArgs)
                                                                 AddToReceipt(productID, productName, price) ' Change to ProductID
                                                             End Sub

                    MainDishControl.FlowLayoutPanel.Controls.Add(productCard)
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub Manager_Cashier_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the DataGrid if it's empty (ensure columns exist)
        InitializeReceiptGrid()
        fetchProductData()
    End Sub

    ' Add product to the receipt DataGridView and handle quantity

    Private Sub InitializeReceiptGrid()
        ' Clear existing columns if needed
        datagridReceipt.Columns.Clear()

        ' Create columns for the DataGridView (removed ProductID)
        datagridReceipt.Columns.Add("ProductName", "Product Name") ' Keep ProductName
        datagridReceipt.Columns.Add("Price", "Price")
        datagridReceipt.Columns.Add("Quantity", "Quantity")

        ' Format columns as needed
        datagridReceipt.Columns("Price").DefaultCellStyle.Format = "N2"
    End Sub


    ' Method to add product to receipt
    Private Sub AddToReceipt(productID As String, productName As String, price As Decimal)
        Dim found As Boolean = False

        ' Fetch ingredients for the selected product
        Dim ingredients As New Dictionary(Of String, Integer) ' Stores ingredient name and amount
        Using cmd As New MySqlCommand("SELECT Ingredient1, Ingredient2, Ingredient3, Ingredient4, Ingredient5, Ingredient6, Ingredient7, Ingredient8, Amount1, Amount2, Amount3, Amount4, Amount5, Amount6, Amount7, Amount8 FROM tblproducts WHERE ProductID = @productID", connection)
            cmd.Parameters.AddWithValue("@productID", productID)
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    ' Loop through each ingredient and amount, and add to the dictionary
                    For i As Integer = 1 To 8
                        Dim ingredientColumn As String = $"Ingredient{i}"
                        Dim amountColumn As String = $"Amount{i}"

                        If Not IsDBNull(reader(ingredientColumn)) AndAlso Not IsDBNull(reader(amountColumn)) Then
                            Dim ingredientName As String = reader(ingredientColumn).ToString()
                            Dim ingredientAmount As Integer = Integer.Parse(reader(amountColumn).ToString())

                            ' Check if the ingredient already exists in the dictionary
                            If ingredients.ContainsKey(ingredientName) Then
                                ' If it exists, you can sum the amounts or handle it as per your requirement
                                ingredients(ingredientName) += ingredientAmount
                            Else
                                ' If it does not exist, add it to the dictionary
                                ingredients.Add(ingredientName, ingredientAmount)
                            End If
                        End If
                    Next
                End If
            End Using
        End Using

        ' Check if the product already exists in the DataGrid
        For Each row As DataGridViewRow In datagridReceipt.Rows
            If Not row.IsNewRow AndAlso row.Cells("ProductName").Value IsNot Nothing AndAlso row.Cells("ProductName").Value.ToString() = productName Then
                Dim quantity As Integer = Integer.Parse(row.Cells("Quantity").Value.ToString()) + 1
                row.Cells("Quantity").Value = quantity
                row.Cells("Price").Value = (price * quantity).ToString("F2")
                found = True
                Exit For
            End If
        Next

        ' If the product doesn't exist, add a new row
        If Not found Then
            datagridReceipt.Rows.Add(productName, price.ToString("F2"), 1)
        End If

        ' Store ingredients and amounts in the Tag property
        For Each row As DataGridViewRow In datagridReceipt.Rows
            If row.Cells("ProductName").Value.ToString() = productName Then
                row.Tag = ingredients ' Store ingredients in Tag
                Exit For
            End If
        Next

        ' Recalculate the total amount
        Calculate()
    End Sub


    ' Method to handle payment
    ' Method to handle payment
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Dim totalAmount As Decimal = Decimal.Parse(txtTotalAmount.Text)

        ' Step 1: Create and show the receipt (existing functionality)
        Dim receiptText As New StringBuilder()
        receiptText.AppendLine("Chelsea Chill")
        receiptText.AppendLine("Purok 9, Nograles Ave., Brgy 76-A, Bucana Boulevard, Davao City., 8000")
        receiptText.AppendLine("=======================================")
        receiptText.AppendLine("Receipt")
        receiptText.AppendLine("=======================================")
        receiptText.AppendLine($"Date & Time: {DateTime.Now.ToString("g")}")
        receiptText.AppendLine()
        receiptText.AppendLine("Product Name      Unit Cost    Quantity    Total Cost")
        receiptText.AppendLine("-----------------------------------------------------------------")

        ' Loop through each product in the receipt
        For Each row As DataGridViewRow In datagridReceipt.Rows
            If Not row.IsNewRow Then
                Dim productName As String = row.Cells("ProductName").Value.ToString()
                Dim unitCost As Decimal = Decimal.Parse(row.Cells("Price").Value.ToString()) / Integer.Parse(row.Cells("Quantity").Value.ToString())
                Dim quantity As Integer = Integer.Parse(row.Cells("Quantity").Value.ToString())
                Dim rowTotalCost As Decimal = Decimal.Parse(row.Cells("Price").Value.ToString())
                receiptText.AppendLine($"{productName,-20} {unitCost,10:C} {quantity,10}  {rowTotalCost,12:C}")

                ' Record each product in the report with its corresponding total amount
                RecordSalesInReport(productName, rowTotalCost)
            End If
        Next

        receiptText.AppendLine("-----------------------------------------------------------------")
        receiptText.AppendLine($"Total Amount: {totalAmount:C}")
        receiptText.AppendLine("=======================================")

        Dim result As DialogResult = MessageBox.Show(receiptText.ToString() & vbCrLf & "Would you like to print this receipt?", "Transaction Completed", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            PrintReceipt(receiptText.ToString())

            ' Step 5: Deduct ingredients from inventory
            DeductIngredientsFromInventory()
        End If
    End Sub


    ' Method to deduct ingredients from inventory
    Private Sub DeductIngredientsFromInventory()
        For Each row As DataGridViewRow In datagridReceipt.Rows
            If Not row.IsNewRow Then
                Dim ingredients As Dictionary(Of String, Integer) = CType(row.Tag, Dictionary(Of String, Integer))
                For Each ingredient In ingredients
                    Dim ingredientName As String = ingredient.Key
                    Dim amountUsed As Integer = ingredient.Value * Integer.Parse(row.Cells("Quantity").Value.ToString())

                    ' Update the inventory
                    Using cmd As New MySqlCommand("UPDATE addinventory SET Quantity = Quantity - @amountUsed WHERE ProductName = @ingredientName", connection)
                        cmd.Parameters.AddWithValue("@amountUsed", amountUsed)
                        cmd.Parameters.AddWithValue("@ingredientName", ingredientName)

                        If connection.State = ConnectionState.Closed Then
                            connection.Open()
                        End If

                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End If
        Next
    End Sub

    Private Sub PrintReceipt(receipt As String)
        Dim printDialog As New PrintDialog()
        Dim printDocument As New Printing.PrintDocument()

        AddHandler printDocument.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                                                e.Graphics.DrawString(receipt, New System.Drawing.Font("Arial", 10), Brushes.Black, 100, 100)
                                            End Sub

        If printDialog.ShowDialog() = DialogResult.OK Then
            printDocument.Print()
        End If
    End Sub

    ' Method to record the sales data into the report form (existing functionality)
    Private Sub RecordSalesInReport(productName As String, totalAmount As Decimal)
        ' Create an instance of Manager_Report without showing it
        Dim reportForm As New Manager_Report_Form()
        reportForm.AddSalesRecordToReport(productName, totalAmount)
    End Sub



    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all rows in the DataGridView
        datagridReceipt.Rows.Clear()

        ' Clear the textboxes
        txtTotalAmount.Text = String.Empty
        txtPaymentAmount.Text = String.Empty
        txtChange.Text = String.Empty
        txtTotalAmount.Text = String.Empty

    End Sub

    ' Calculate and update the total amount in the textbox
    Private Sub Calculate()
        Dim amount As Decimal = 0
        Dim change As Decimal = 0

        ' Loop through each row to sum up the total price
        For Each row As DataGridViewRow In datagridReceipt.Rows
            If Not row.IsNewRow Then
                Dim price As Decimal = Decimal.Parse(row.Cells("Price").Value.ToString())
                amount += price
            End If
        Next

        ' Calculate change if payment amount is greater
        Dim paymentAmount As Decimal = 0
        If Decimal.TryParse(txtPaymentAmount.Text, paymentAmount) Then
            If paymentAmount > amount Then
                change = paymentAmount - amount
            End If
        End If

        ' Display the total amount and change
        txtTotalAmount.Text = amount.ToString("F2")
        txtChange.Text = change.ToString("F2")
    End Sub

    Private Sub Burger_Click(sender As Object, e As EventArgs)
        Dim Obj = New Menu_Burger_form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Burger_btn_Click(sender As Object, e As EventArgs)
        Dim Obj = New Menu_Burger_form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)
        Dim Obj = New Menu_Burger_form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        Dim Obj = New Menu_HotdogSandwich_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim Obj = New Menu_HotdogSandwich_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs)
        Dim Obj = New Menu_HotdogSandwich_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Dim Obj = New Menu_Pizza_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim Obj = New Menu_Pizza_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
        Dim Obj = New Menu_Pizza_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim Obj = New Category_Beverages_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Dim Obj = New Category_Beverages_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim Obj = New Category_Appetizer_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        Dim Obj = New Category_Appetizer_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        Dim Obj = New Category_Noodles_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim Obj = New Category_Noodles_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub AssistantMngr_Cashier_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        Dim Obj = New Login_form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Burger_btn_Click_1(sender As Object, e As EventArgs)
        Dim Obj = New Menu_Burger_form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        Dim Obj = New Menu_HotdogSandwich_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs)
        Dim Obj = New Menu_Pizza_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs)
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

    Private Sub BTN_DASHBOARD_Click(sender As Object, e As EventArgs) Handles BTN_DASHBOARD.Click
        Dim Obj = New AssistantMngr_Dashboard_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_INVENTORY_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY.Click
        Dim Obj = New AssistantMngr_Inventory_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_REPORT_Click(sender As Object, e As EventArgs) Handles BTN_REPORT.Click
        Dim Obj = New AssistantMngr_Report_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_EXPENSE_Click(sender As Object, e As EventArgs) Handles BTN_EXPENSE.Click
        Dim Obj = New AssistantMngr_Expense_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_SYSTEMMNGMNT_Click(sender As Object, e As EventArgs)
        Dim Obj = New AssistantMngr_Maintenance_UI_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_LOGOUT_Click(sender As Object, e As EventArgs) Handles BTN_LOGOUT.Click
        Dim Obj = New Login_form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub MainDishbtn_Click(sender As Object, e As EventArgs) Handles MainDishbtn.Click
        fetchProductData("Main Dish")
    End Sub

    Private Sub Beveragesbtn_Click(sender As Object, e As EventArgs) Handles Beveragesbtn.Click
        fetchProductData("Beverages")
    End Sub

    Private Sub Appetizerbtn_Click(sender As Object, e As EventArgs) Handles Appetizerbtn.Click
        fetchProductData("Appetizer")
    End Sub

    Private Sub Noodlesbtn_Click(sender As Object, e As EventArgs) Handles Noodlesbtn.Click
        fetchProductData("Noodles")
    End Sub

    Private Sub ProductListbtn_Click(sender As Object, e As EventArgs) Handles ProductListbtn.Click
        Dim Obj = New Product_List_Form
        Obj.Show()
    End Sub

    Private Sub MainDishControl_Load(sender As Object, e As EventArgs) Handles MainDishControl.Load

    End Sub
End Class