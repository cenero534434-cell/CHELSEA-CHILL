Imports MySql.Data.MySqlClient

Public Class Manager_Inventory_Form

    Dim connection As New MySqlConnection("server=localhost; userid=root; password=; database=chelseachill")

        Private Sub Inventory_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadData()
        End Sub

        Public Sub LoadInventoryData()
            Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                Dim query As String = "SELECT * FROM addinventory"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)

                DataGridInventory.AutoGenerateColumns = True
                DataGridInventory.DataSource = table
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Sub

        Public Sub LoadData(Optional ByVal categoryFilter As String = "")
            Try
                DataGridInventory.DataSource = Nothing
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                Dim query As String
                If String.IsNullOrEmpty(categoryFilter) Or categoryFilter = "All Categories" Then
                    query = "SELECT * FROM addinventory"
                Else
                    query = "SELECT * FROM addinventory WHERE Category = @Category"
                End If

                Dim cmd As New MySqlCommand(query, connection)

                If Not String.IsNullOrEmpty(categoryFilter) And categoryFilter <> "All Categories" Then
                    cmd.Parameters.AddWithValue("@Category", categoryFilter)
                End If

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                DataGridInventory.AutoGenerateColumns = True
                DataGridInventory.DataSource = table
                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Sub



        Private Sub LoadData()
            Try
                DataGridInventory.DataSource = Nothing
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                Dim query As String = "SELECT * FROM addinventory"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim table As New DataTable()
                adapter.Fill(table)

                DataGridInventory.AutoGenerateColumns = True
                DataGridInventory.DataSource = table
                connection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Sub

        ' Add button functionality
        Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(ProductID.Text) OrElse String.IsNullOrEmpty(txtProductName.Text) OrElse
      String.IsNullOrEmpty(Description.Text) OrElse String.IsNullOrEmpty(Category.Text) OrElse
      String.IsNullOrEmpty(Unit.Text) OrElse String.IsNullOrEmpty(Quantity.Text) OrElse
      String.IsNullOrEmpty(ExpirationDate.Text) OrElse String.IsNullOrEmpty(DateAdded.Text) Then

            MessageBox.Show("Please fill in all the fields before adding the product.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                Dim query As String = "INSERT INTO addinventory (ProductID, ProductName, Description, Category, Unit, Quantity, ExpirationDate, DateAdded) VALUES (@ProductID, @ProductName, @Description, @Category, @Unit, @Quantity, @ExpirationDate, @DateAdded)"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@ProductID", ProductID.Text)
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
            cmd.Parameters.AddWithValue("@Description", Description.Text)
                cmd.Parameters.AddWithValue("@Category", Category.Text)
                cmd.Parameters.AddWithValue("@Unit", Unit.Text)
                cmd.Parameters.AddWithValue("@Quantity", Quantity.Text)
                cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate.Text)
                cmd.Parameters.AddWithValue("@DateAdded", DateAdded.Text)

                cmd.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Sub

        ' Archive button functionality
        Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnarchive.Click
            If DataGridInventory.SelectedRows.Count > 0 Then
                Try
                    If connection.State = ConnectionState.Closed Then
                        connection.Open()
                    End If

                    Dim row As DataGridViewRow = DataGridInventory.SelectedRows(0)
                    Dim query As String = "INSERT INTO tblunarchive (ProductID, ProductName, Description, Category, Unit, Quantity, ExpirationDate, DateAdded) VALUES (@ProductID, @ProductName, @Description, @Category, @Unit, @Quantity, @ExpirationDate, @DateAdded)"
                    Dim cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ProductID", row.Cells("ProductID").Value.ToString())
                    cmd.Parameters.AddWithValue("@ProductName", row.Cells("ProductName").Value.ToString())
                    cmd.Parameters.AddWithValue("@Description", row.Cells("Description").Value.ToString())
                    cmd.Parameters.AddWithValue("@Category", row.Cells("Category").Value.ToString())
                    cmd.Parameters.AddWithValue("@Unit", row.Cells("Unit").Value.ToString())
                    cmd.Parameters.AddWithValue("@Quantity", row.Cells("Quantity").Value.ToString())
                    cmd.Parameters.AddWithValue("@ExpirationDate", row.Cells("ExpirationDate").Value.ToString())
                    cmd.Parameters.AddWithValue("@DateAdded", row.Cells("DateAdded").Value.ToString())

                    cmd.ExecuteNonQuery()
                    Dim deleteQuery As String = "DELETE FROM addinventory WHERE ProductID = @ProductID"
                    Dim deleteCmd As New MySqlCommand(deleteQuery, connection)
                    deleteCmd.Parameters.AddWithValue("@ProductID", row.Cells("ProductID").Value.ToString())
                    deleteCmd.ExecuteNonQuery()

                    connection.Close()
                    MessageBox.Show("Product archived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadData()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    If connection.State = ConnectionState.Open Then
                        connection.Close()
                    End If
                End Try
            Else
                MessageBox.Show("Please select a row to archive.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End Sub



        Private Sub DataGridInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridInventory.CellContentClick
            If e.RowIndex >= 0 Then
                Dim selectedRow As DataGridViewRow = DataGridInventory.Rows(e.RowIndex)

                ProductID.Text = selectedRow.Cells("ProductID").Value.ToString()
            txtProductName.Text = selectedRow.Cells("ProductName").Value.ToString()
            Description.Text = selectedRow.Cells("Description").Value.ToString()
            Category.Text = selectedRow.Cells("Category").Value.ToString()
            Unit.Text = selectedRow.Cells("Unit").Value.ToString()
            Quantity.Text = selectedRow.Cells("Quantity").Value.ToString()
            ExpirationDate.Text = selectedRow.Cells("ExpirationDate").Value.ToString()
            DateAdded.Text = selectedRow.Cells("DateAdded").Value.ToString()
        End If
    End Sub


    ' Update button functionality
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(ProductID.Text) Then
            MessageBox.Show("Please select a product to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "UPDATE addinventory SET ProductName = @ProductName, Description = @Description, Category = @Category, Unit = @Unit, Quantity = @Quantity, ExpirationDate = @ExpirationDate, DateAdded = @DateAdded WHERE ProductID = @ProductID"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@ProductID", ProductID.Text)
            cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text)
            cmd.Parameters.AddWithValue("@Description", Description.Text)
            cmd.Parameters.AddWithValue("@Category", Category.Text)
            cmd.Parameters.AddWithValue("@Unit", Unit.Text)
            cmd.Parameters.AddWithValue("@Quantity", Quantity.Text)
            cmd.Parameters.AddWithValue("@ExpirationDate", ExpirationDate.Text)
            cmd.Parameters.AddWithValue("@DateAdded", DateAdded.Text)

            cmd.ExecuteNonQuery()
            connection.Close()

            MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try


    End Sub

    ' Search Bar Functionality
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim query As String = "SELECT * FROM addinventory WHERE ProductID LIKE @search OR ProductName LIKE @search OR Description LIKE @search OR Category LIKE @search OR Unit LIKE @search OR Quantity LIKE @search OR ExpirationDate LIKE @search OR DateAdded LIKE @search"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridInventory.DataSource = table

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        'Try
        '    dt = New DataTable
        '    strcon.Open()
        '    With cmd
        '        .Connection = strcon
        '        .CommandText = sql

        '    End With
        '    da.SelectCommand = cmd
        '    da.Fill(dt)
        '    DTG.datasource = dt
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    strcon.Close()
        '    da.Dispose()
        'End Try
    End Sub

    'Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
    '    Try
    '        reload("SELECT * FROM addinventory", DataGridInventory)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        LoadData(cmbCategory.SelectedItem.ToString())
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Dashboard_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Cashier_Form
        Obj.Show()
        Me.Hide()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Expense_Form
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



    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Dim Obj = New Login_form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Dim Obj = New Login_form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Dashboard_BTN_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Dashboard_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Cashier_BTN_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Cashier_Form
        Obj.Show()
        Me.Hide()
    End Sub


    Private Sub Financial_BTN_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Expense_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Inventory_BTN_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Inventory_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Report_BTN_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Report_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Maintenance_BTN_Click(sender As Object, e As EventArgs)
        Dim Obj = New Maintenance_EM_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)
        Dim Obj = New Login_form
        Obj.Show()
        Me.Hide()
    End Sub


    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles BTN_DASHBOARD.Click
        Dim Obj = New Manager_Dashboard_Form
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub BTN_INVENTORY_Click(sender As Object, e As EventArgs) Handles BTN_INVENTORY.Click
        Dim Obj = New Manager_Inventory_Form
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


    Private Sub BTN_SYSTEMMNGMNT_Click(sender As Object, e As EventArgs) Handles BTN_SYSTEMMNGMNT.Click
        Dim Obj = New Maintenance_EM_Form
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub BTN_LOGOUT_Click(sender As Object, e As EventArgs) Handles BTN_LOGOUT.Click
        Dim Obj = New Login_form
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs)
        ProductID.Clear()
        txtProductName.Clear()
        Category.Items.Clear()
        Unit.Items.Clear()
        Quantity.Clear()


    End Sub

    Private Sub Description_TextChanged(sender As Object, e As EventArgs) Handles Description.TextChanged

    End Sub
End Class