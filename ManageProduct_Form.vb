Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ManageProduct_Form

    Dim connection As New MySqlConnection("server=localhost;userid=root;password=;database=chelseachill;")

    Public Delegate Sub ProductAddedHandler(productID As String, productName As String, price As Decimal, category As String, imagePath As String)
    Public Event ProductAdded As ProductAddedHandler

    Public DashboardForm As Manager_Cashier_Form

    Private Sub ManageProduct_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearFields()
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                txtImagePath.Text = openFileDialog.FileName
                PictureBox2.Image = Image.FromFile(openFileDialog.FileName)
            End If
        End Using
    End Sub

    Private Sub ClearFields()
        txtProductName.Clear()
        txtCategory.SelectedIndex = -1
        txtPrice.Clear()
        txtSearch.Clear()
        PictureBox2.Image = Nothing
    End Sub

    Private ingredientIndex As Integer = 1

    Private ProductID As String

    ' Handling selection from the DataGridView to populate ingredients
    Private Sub InventoryDT_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles InventoryDT.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = InventoryDT.Rows(e.RowIndex)
            Dim ProductName As String = row.Cells("Product Name").Value.ToString()

            Select Case ingredientIndex
                Case 1 : Ingredient1.Text = ProductName
                Case 2 : Ingredient2.Text = ProductName
                Case 3 : Ingredient3.Text = ProductName
                Case 4 : Ingredient4.Text = ProductName
                Case 5 : Ingredient5.Text = ProductName
                Case 6 : Ingredient6.Text = ProductName
                Case 7 : Ingredient7.Text = ProductName
                Case 8 : Ingredient8.Text = ProductName
                Case Else
                    MessageBox.Show("You can only add up to 8 ingredients.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
            End Select

            ingredientIndex += 1

            If ingredientIndex > 8 Then
                ingredientIndex = 1 ' Reset counter
            End If
        End If
    End Sub

    ' Search functionality with data population
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchQuery As String = txtSearch.Text
        Dim query As String = "SELECT ProductID, ProductName, Category, Price, ProductImage FROM tblproducts " &
                              "WHERE ProductName LIKE @search OR Category LIKE @search OR Price LIKE @search"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@search", "%" & searchQuery & "%")

        Try
            If connection.State = ConnectionState.Closed Then connection.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            lstSearchResults.Items.Clear()

            While reader.Read()
                Dim item As String = reader("ProductID").ToString() & " - " &
                                     reader("ProductName").ToString() & " - " &
                                     reader("Category").ToString() & " - " &
                                     reader("Price").ToString()
                lstSearchResults.Items.Add(item)
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub

    ' Handling product selection from search results
    Private Sub lstSearchResults_Click(sender As Object, e As EventArgs) Handles lstSearchResults.Click
        If lstSearchResults.SelectedItem Is Nothing Then Return

        Dim selectedItem As String = lstSearchResults.SelectedItem.ToString()
        Dim selectedProductID As String = selectedItem.Split("-"c)(0).Trim()

        Dim query As String = "SELECT ProductID, ProductName, Category, Price, ProductImage, " &
                          "Ingredient1, Amount1, Ingredient2, Amount2, Ingredient3, Amount3, " &
                          "Ingredient4, Amount4, Ingredient5, Amount5, Ingredient6, Amount6, " &
                          "Ingredient7, Amount7, Ingredient8, Amount8 " &
                          "FROM tblproducts WHERE ProductID = @ProductID"
        Dim cmd As New MySqlCommand(query, connection)
        cmd.Parameters.AddWithValue("@ProductID", selectedProductID)

        Try
            If connection.State = ConnectionState.Closed Then connection.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                txtProductID.Text = reader("ProductID").ToString()
                txtProductName.Text = reader("ProductName").ToString()
                txtCategory.Text = reader("Category").ToString()
                txtPrice.Text = reader("Price").ToString()

                Dim imagePath As String = reader("ProductImage").ToString()
                If Not String.IsNullOrEmpty(imagePath) AndAlso File.Exists(imagePath) Then
                    PictureBox2.Image = Image.FromFile(imagePath)
                Else
                    PictureBox2.Image = Nothing
                    MessageBox.Show("Image not found at the specified path: " & imagePath, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                ' Populate ingredient textboxes
                Ingredient1.Text = reader("Ingredient1").ToString()
                Amount1.Text = reader("Amount1").ToString()
                Ingredient2.Text = reader("Ingredient2").ToString()
                Amount2.Text = reader("Amount2").ToString()
                Ingredient3.Text = reader("Ingredient3").ToString()
                Amount3.Text = reader("Amount3").ToString()
                Ingredient4.Text = reader("Ingredient4").ToString()
                Amount4.Text = reader("Amount4").ToString()
                Ingredient5.Text = reader("Ingredient5").ToString()
                Amount5.Text = reader("Amount5").ToString()
                Ingredient6.Text = reader("Ingredient6").ToString()
                Amount6.Text = reader("Amount6").ToString()
                Ingredient7.Text = reader("Ingredient7").ToString()
                Amount7.Text = reader("Amount7").ToString()
                Ingredient8.Text = reader("Ingredient8").ToString()
                Amount8.Text = reader("Amount8").ToString()

            Else
                MessageBox.Show("No product found with the selected ProductID.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then connection.Close()
        End Try
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtProductName.Text) OrElse
           String.IsNullOrWhiteSpace(txtCategory.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrice.Text) OrElse
           String.IsNullOrWhiteSpace(txtImagePath.Text) Then
            MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim price As Decimal
            If Not Decimal.TryParse(txtPrice.Text, price) Then
                MessageBox.Show("Please enter a valid price.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If connection.State = ConnectionState.Closed Then connection.Open()


            ' Prepare the SQL query to insert a new product with ingredients
            Dim query As String = "INSERT INTO tblproducts (ProductName, Category, Price, ProductImage, Ingredient1, Amount1, Ingredient2, Amount2, Ingredient3, Amount3, Ingredient4, Amount4, Ingredient5, Amount5, Ingredient6, Amount6, Ingredient7, Amount7, Ingredient8, Amount8) " &
                              "VALUES (@ProductName, @Category, @Price, @ProductImage, @Ingredient1, @Amount1, @Ingredient2, @Amount2, @Ingredient3, @Amount3, @Ingredient4, @Amount4, @Ingredient5, @Amount5, @Ingredient6, @Amount6, @Ingredient7, @Amount7, @Ingredient8, @Amount8)"
            Dim cmd As New MySqlCommand(query, connection)

            ' Assign parameters for the product
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text)
            cmd.Parameters.AddWithValue("@Price", price)
            cmd.Parameters.AddWithValue("@ProductImage", txtImagePath.Text)

            ' Assign parameters for ingredients and their amounts
            cmd.Parameters.AddWithValue("@Ingredient1", Ingredient1.Text)
            cmd.Parameters.AddWithValue("@Amount1", Amount1.Text)
            cmd.Parameters.AddWithValue("@Ingredient2", Ingredient2.Text)
            cmd.Parameters.AddWithValue("@Amount2", Amount2.Text)
            cmd.Parameters.AddWithValue("@Ingredient3", Ingredient3.Text)
            cmd.Parameters.AddWithValue("@Amount3", Amount3.Text)
            cmd.Parameters.AddWithValue("@Ingredient4", Ingredient4.Text)
            cmd.Parameters.AddWithValue("@Amount4", Amount4.Text)
            cmd.Parameters.AddWithValue("@Ingredient5", Ingredient5.Text)
            cmd.Parameters.AddWithValue("@Amount5", Amount5.Text)
            cmd.Parameters.AddWithValue("@Ingredient6", Ingredient6.Text)
            cmd.Parameters.AddWithValue("@Amount6", Amount6.Text)
            cmd.Parameters.AddWithValue("@Ingredient7", Ingredient7.Text)
            cmd.Parameters.AddWithValue("@Amount7", Amount7.Text)
            cmd.Parameters.AddWithValue("@Ingredient8", Ingredient8.Text)
            cmd.Parameters.AddWithValue("@Amount8", Amount8.Text)

            ' Execute the query
            cmd.ExecuteNonQuery()

            ' Notify the user that the product was successfully added
            MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear all fields after successful addition
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure that the connection is closed after the operation
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtProductName.Text) OrElse
       String.IsNullOrWhiteSpace(txtCategory.Text) OrElse
       String.IsNullOrWhiteSpace(txtPrice.Text) Then

            MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim price As Decimal
            If Not Decimal.TryParse(txtPrice.Text, price) Then
                MessageBox.Show("Please enter a valid price.")
                Return
            End If

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Update query including Ingredient and Amount columns
            Dim query As String = "UPDATE tblproducts SET ProductName = @ProductName, Category = @Category, Price = @Price, ProductImage = @ProductImage, " &
                                  "Ingredient1 = @Ingredient1, Amount1 = @Amount1, Ingredient2 = @Ingredient2, Amount2 = @Amount2, Ingredient3 = @Ingredient3, Amount3 = @Amount3, " &
                                  "Ingredient4 = @Ingredient4, Amount4 = @Amount4, Ingredient5 = @Ingredient5, Amount5 = @Amount5, Ingredient6 = @Ingredient6, Amount6 = @Amount6, " &
                                  "Ingredient7 = @Ingredient7, Amount7 = @Amount7, Ingredient8 = @Ingredient8, Amount8 = @Amount8 WHERE ProductID = @ProductID"

            Dim cmd As New MySqlCommand(query, connection)

            ' Assign parameters
            cmd.Parameters.AddWithValue("@ProductID", txtProductID.Text)
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
            cmd.Parameters.AddWithValue("@Category", txtCategory.Text)
            cmd.Parameters.AddWithValue("@Price", price)
            cmd.Parameters.AddWithValue("@ProductImage", txtImagePath.Text)

            ' Assign ingredients and amounts
            cmd.Parameters.AddWithValue("@Ingredient1", Ingredient1.Text)
            cmd.Parameters.AddWithValue("@Amount1", Amount1.Text)
            cmd.Parameters.AddWithValue("@Ingredient2", Ingredient2.Text)
            cmd.Parameters.AddWithValue("@Amount2", Amount2.Text)
            cmd.Parameters.AddWithValue("@Ingredient3", Ingredient3.Text)
            cmd.Parameters.AddWithValue("@Amount3", Amount3.Text)
            cmd.Parameters.AddWithValue("@Ingredient4", Ingredient4.Text)
            cmd.Parameters.AddWithValue("@Amount4", Amount4.Text)
            cmd.Parameters.AddWithValue("@Ingredient5", Ingredient5.Text)
            cmd.Parameters.AddWithValue("@Amount5", Amount5.Text)
            cmd.Parameters.AddWithValue("@Ingredient6", Ingredient6.Text)
            cmd.Parameters.AddWithValue("@Amount6", Amount6.Text)
            cmd.Parameters.AddWithValue("@Ingredient7", Ingredient7.Text)
            cmd.Parameters.AddWithValue("@Amount7", Amount7.Text)
            cmd.Parameters.AddWithValue("@Ingredient8", Ingredient8.Text)
            cmd.Parameters.AddWithValue("@Amount8", Amount8.Text)

            ' Execute update query
            cmd.ExecuteNonQuery()

            ' Notify user of success
            MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear fields after successful update
            ClearFields()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Ensure the Product ID is provided and valid.
            Dim ProductID As Integer
            If String.IsNullOrWhiteSpace(txtProductID.Text) OrElse Not Integer.TryParse(txtProductID.Text, ProductID) Then
                MessageBox.Show("Please enter a valid Product ID.")
                Return
            End If

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Insert into archive table including Ingredient and Amount fields
            Dim archiveQuery As String = "INSERT INTO tblarcheiveproduct (ProductID, ProductName, Category, Price, ProductImage, Ingredient1, Amount1, Ingredient2, Amount2, " &
                                     "Ingredient3, Amount3, Ingredient4, Amount4, Ingredient5, Amount5, Ingredient6, Amount6, Ingredient7, Amount7, Ingredient8, Amount8) " &
                                     "SELECT ProductID, ProductName, Category, Price, ProductImage, Ingredient1, Amount1, Ingredient2, Amount2, Ingredient3, Amount3, Ingredient4, " &
                                     "Amount4, Ingredient5, Amount5, Ingredient6, Amount6, Ingredient7, Amount7, Ingredient8, Amount8 FROM tblproducts WHERE ProductID = @ProductID"
            Dim archiveCmd As New MySqlCommand(archiveQuery, connection)
            archiveCmd.Parameters.AddWithValue("@ProductID", ProductID)
            archiveCmd.ExecuteNonQuery()

            ' Delete from the main products table.
            Dim deleteQuery As String = "DELETE FROM tblproducts WHERE ProductID = @ProductID"
            Dim deleteCmd As New MySqlCommand(deleteQuery, connection)
            deleteCmd.Parameters.AddWithValue("@ProductID", ProductID)
            deleteCmd.ExecuteNonQuery()

            MessageBox.Show("Product archived successfully.")
            ClearFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub Ingredients_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData() ' Load the inventory data into the DataGridView
    End Sub

    Private Sub LoadData()
        Try
            InventoryDT.DataSource = Nothing
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT ProductName, Description, Category, Unit, Quantity FROM addinventory"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            InventoryDT.AutoGenerateColumns = True
            InventoryDT.DataSource = table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        Ingredient1.Clear()
        Ingredient2.Clear()
        Ingredient3.Clear()
        Ingredient4.Clear()
        Ingredient5.Clear()
        Ingredient6.Clear()
        Ingredient7.Clear()
        Ingredient8.Clear()

        Amount1.Clear()
        Amount2.Clear()
        Amount3.Clear()
        Amount4.Clear()
        Amount5.Clear()
        Amount6.Clear()
        Amount7.Clear()
        Amount8.Clear()
    End Sub
End Class