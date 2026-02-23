
Imports MySql.Data.MySqlClient

Public Class Maintainance_SystemSettings_Form


    Dim connection As New MySqlConnection("server=localhost; userid=root; password=; database=chelseachill")

    Private Sub Unarchive_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUnarchiveData()
        LoadUnarchive2Data()
        LoadUnarchive3Data()
        LoadUnarchive4Data()
    End Sub

    Private Sub LoadUnarchiveData()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT ProductID, ProductName, Description, Category, Unit, Quantity, ExpirationDate, DateAdded FROM tblunarchive"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridUnarchive.Columns.Clear()

            DataGridUnarchive.AutoGenerateColumns = True
            DataGridUnarchive.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub LoadUnarchive2Data()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT ProductID, ProductName, Category, Price FROM tblarcheiveproduct"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.Columns.Clear()

            DataGridView1.AutoGenerateColumns = True
            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub LoadUnarchive3Data()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT ExpenseID, TypeofTransaction, ExpenseDate, Amount FROM tblunarchiveexpenses"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            DTExpenses.Columns.Clear()

            DTExpenses.AutoGenerateColumns = True
            DTExpenses.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub LoadUnarchive4Data()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT ID, Name, Address, Contact, Remarks FROM tblunarchivesupplier"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView3.Columns.Clear()

            DataGridView3.AutoGenerateColumns = True
            DataGridView3.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub btnUnarchive_Click(sender As Object, e As EventArgs) Handles btnUnarchive.Click
        Try

            If DataGridUnarchive.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a product to unarchive.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim selectedRow As DataGridViewRow = DataGridUnarchive.SelectedRows(0)

            Dim productID As String = selectedRow.Cells("ProductID").Value.ToString()
            Dim productName As String = selectedRow.Cells("ProductName").Value.ToString()
            Dim description As String = selectedRow.Cells("Description").Value.ToString()
            Dim category As String = selectedRow.Cells("Category").Value.ToString()
            Dim unit As String = selectedRow.Cells("Unit").Value.ToString()
            Dim quantity As Integer = Convert.ToInt32(selectedRow.Cells("Quantity").Value)
            Dim expirationDate As DateTime = Convert.ToDateTime(selectedRow.Cells("ExpirationDate").Value)
            Dim dateAdded As DateTime = DateTime.Now
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If


            Dim insertQuery As String = "INSERT INTO addinventory (ProductID, ProductName, Description, Category, Unit, Quantity, ExpirationDate, DateAdded) VALUES (@ProductID, @ProductName, @Description, @Category, @Unit, @Quantity, @ExpirationDate, @DateAdded)"
            Using insertCmd As New MySqlCommand(insertQuery, connection)
                insertCmd.Parameters.AddWithValue("@ProductID", productID)
                insertCmd.Parameters.AddWithValue("@ProductName", productName)
                insertCmd.Parameters.AddWithValue("@Description", description)
                insertCmd.Parameters.AddWithValue("@Category", category)
                insertCmd.Parameters.AddWithValue("@Unit", unit)
                insertCmd.Parameters.AddWithValue("@Quantity", quantity)
                insertCmd.Parameters.AddWithValue("@ExpirationDate", expirationDate)
                insertCmd.Parameters.AddWithValue("@DateAdded", dateAdded)

                insertCmd.ExecuteNonQuery()
            End Using


            Dim deleteQuery As String = "DELETE FROM tblunarchive WHERE ProductID = @ProductID"
            Using deleteCmd As New MySqlCommand(deleteQuery, connection)
                deleteCmd.Parameters.AddWithValue("@ProductID", productID)
                deleteCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data successfully restored to Inventory!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            LoadUnarchiveData()


            Manager_Inventory_Form.LoadInventoryData()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try

            If DataGridView1.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a product to unarchive.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)


            Dim ProductID As String = selectedRow.Cells("ProductID").Value.ToString()
            Dim productName As String = selectedRow.Cells("ProductName").Value.ToString()
            Dim category As String = selectedRow.Cells("Category").Value.ToString()
            Dim price As Decimal = Convert.ToDecimal(selectedRow.Cells("Price").Value)

            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim insertQuery As String = "INSERT INTO tblproducts (ProductID, ProductName, Category, Price) VALUES (@ProductID, @ProductName, @Category, @Price)"
            Using insertCmd As New MySqlCommand(insertQuery, connection)
                insertCmd.Parameters.AddWithValue("@ProductID", ProductID)
                insertCmd.Parameters.AddWithValue("@ProductName", productName)
                insertCmd.Parameters.AddWithValue("@Category", category)
                insertCmd.Parameters.AddWithValue("@Price", price)

                insertCmd.ExecuteNonQuery()
            End Using


            Dim deleteQuery As String = "DELETE FROM tblarcheiveproduct WHERE ProductID = @ProductID"
            Using deleteCmd As New MySqlCommand(deleteQuery, connection)
                deleteCmd.Parameters.AddWithValue("@ProductID", ProductID)
                deleteCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data successfully restored to Products!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            LoadUnarchive2Data()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim query As String = "SELECT * FROM tblunarchive WHERE ProductID LIKE @search OR ProductName LIKE @search OR Description LIKE @search OR Category LIKE @search OR Unit LIKE @search OR Quantity LIKE @search OR ExpirationDate LIKE @search OR DateAdded LIKE @search"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@search", "%" & txtsearch.Text & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridUnarchive.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub RoundCornerTextbox1_TextChanged(sender As Object, e As EventArgs) Handles RoundCornerTextbox1.TextChanged
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If


            Dim query As String = "SELECT ProductID, ProductName, Category, Price FROM tblarcheiveproduct WHERE ProductID LIKE @search OR ProductName LIKE @search OR Category LIKE @search OR Price LIKE @search "
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@search", "%" & RoundCornerTextbox1.Text & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            If DataGridUnarchive.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a product to unarchive.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim selectedRow As DataGridViewRow = DTExpenses.SelectedRows(0)

            Dim ExpenseID As String = selectedRow.Cells("ExpenseID").Value.ToString()
            Dim TypeofTransaction As String = selectedRow.Cells("TypeofTransaction").Value.ToString()
            Dim ExpenseDate As String = selectedRow.Cells("ExpenseDate").Value.ToString()
            Dim Amount As String = selectedRow.Cells("Amount").Value.ToString()
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If


            Dim insertQuery As String = "INSERT INTO tblexpenses (ExpenseID, TypeofTransaction, ExpenseDate, Amount) VALUES (@ExpenseID, @TypeofTransaction, @ExpenseDate, @Amount)"
            Using insertCmd As New MySqlCommand(insertQuery, connection)
                insertCmd.Parameters.AddWithValue("@ExpenseID", ExpenseID)
                insertCmd.Parameters.AddWithValue("@TypeofTransaction", TypeofTransaction)
                insertCmd.Parameters.AddWithValue("@ExpenseDate", ExpenseDate)
                insertCmd.Parameters.AddWithValue("@Amount", Amount)

                insertCmd.ExecuteNonQuery()
            End Using


            Dim deleteQuery As String = "DELETE FROM tblunarchiveexpenses WHERE ExpenseID = @ExpenseID"
            Using deleteCmd As New MySqlCommand(deleteQuery, connection)
                deleteCmd.Parameters.AddWithValue("@ExpenseID", ExpenseID)
                deleteCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data successfully restored to Expenses!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            LoadUnarchiveData()


            Manager_Inventory_Form.LoadInventoryData()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub ExpenseSearch_TextChanged(sender As Object, e As EventArgs) Handles ExpenseSearch.TextChanged
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim query As String = "SELECT * FROM tblunarchiveexpenses WHERE ExpenseID LIKE @search OR TypeofTransaction LIKE @search OR ExpenseDate LIKE @search OR Amount LIKE @search"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@search", "%" & txtsearch.Text & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DTExpenses.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        Try

            If DataGridView3.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select a product to unarchive.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim selectedRow As DataGridViewRow = DataGridView3.SelectedRows(0)

            Dim ID As String = selectedRow.Cells("ID").Value.ToString()
            Dim Name As String = selectedRow.Cells("Name").Value.ToString()
            Dim Address As String = selectedRow.Cells("Address").Value.ToString()
            Dim Contact As String = selectedRow.Cells("Contact").Value.ToString()
            Dim Remarks As String = selectedRow.Cells("Remarks").Value.ToString()
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If


            Dim insertQuery As String = "INSERT INTO tblsupplier (ID, Name, Address, Contact, Remarks) VALUES (@ID, @Name, @Address, @Contact, @Remarks)"
            Using insertCmd As New MySqlCommand(insertQuery, connection)
                insertCmd.Parameters.AddWithValue("@ID", ID)
                insertCmd.Parameters.AddWithValue("@Name", Name)
                insertCmd.Parameters.AddWithValue("@Address", Address)
                insertCmd.Parameters.AddWithValue("@Contact", Contact)
                insertCmd.Parameters.AddWithValue("@Remarks", Remarks)

                insertCmd.ExecuteNonQuery()
            End Using


            Dim deleteQuery As String = "DELETE FROM tblunarchivesupplier WHERE ID = @ID"
            Using deleteCmd As New MySqlCommand(deleteQuery, connection)
                deleteCmd.Parameters.AddWithValue("@ID", ID)
                deleteCmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data successfully restored to Supplier!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)


            LoadUnarchiveData()


            Manager_Inventory_Form.LoadInventoryData()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub SearchSupplier_TextChanged(sender As Object, e As EventArgs) Handles SearchSupplier.TextChanged
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim query As String = "SELECT * FROM tblunarchivesupplier WHERE ID LIKE @search OR Name LIKE @search OR Address LIKE @search OR Contact LIKE @search OR Remarks LIKE @search"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@search", "%" & txtsearch.Text & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView3.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim Obj = New Maintenance_Supplier_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim Obj = New Maintenance_EM_Form
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub BTN_INVENTORY_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY.Click
        Dim Obj = New Manager_Inventory_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_DASHBOARD_Click(sender As Object, e As EventArgs) Handles BTN_DASHBOARD.Click
        Dim Obj = New Manager_Dashboard_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_REPORT_Click(sender As Object, e As EventArgs) Handles BTN_REPORT.Click
        Dim Obj = New Manager_Report_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_EXPENSE_Click(sender As Object, e As EventArgs) Handles BTN_EXPENSE.Click
        Dim Obj = New Manager_Expense_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_CASHIER_Click(sender As Object, e As EventArgs) Handles BTN_CASHIER.Click
        Dim Obj = New Manager_Cashier_Form
        Obj.Show()
        Me.Hide()
    End Sub


    Private Sub BTN_LOGOUT_Click(sender As Object, e As EventArgs) Handles BTN_LOGOUT.Click
        Dim Obj = New Login_form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridUnarchive_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridUnarchive.CellContentClick

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
