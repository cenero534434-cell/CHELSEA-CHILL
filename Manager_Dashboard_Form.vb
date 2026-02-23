
Imports MySql.Data.MySqlClient

Public Class Manager_Dashboard_Form


    Private connectionString As String = "server=localhost;user id=root;password=;database=chelseachill"
        Private connection As MySqlConnection
        Private dataTable As DataTable

        ' Form Load Event
        Private Sub Manager_dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Initialize the connection with the actual connection string
            connection = New MySqlConnection(connectionString)
            LoadItems()

            connection = New MySqlConnection(connectionString)
            LoadTotalExpenses()
        End Sub

        ' Method to load items into the DataGridView
        Private Sub LoadItems()
            Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

            ' Query to get items from addinventory where quantity is between 0 and 80
            Dim query As String = "SELECT ProductName, Category, Quantity, DateAdded " &
                                  "FROM addinventory WHERE Quantity >= 0 AND Quantity <= 80 ORDER BY Quantity ASC"

            Dim cmd As New MySqlCommand(query, connection)
                Dim adapter As New MySqlDataAdapter(cmd)

                dataTable = New DataTable()
                adapter.Fill(dataTable)

                ' Ensure that StockStatus is correctly named and exists on your form
                StockStatus.DataSource = dataTable

            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Sub

        Private Sub LoadTotalExpenses()
            Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

            Dim query As String = "SELECT SUM(Amount) AS TotalAmount FROM tblexpenses"
                Dim cmd As New MySqlCommand(query, connection)


            Dim totalAmount As Object = cmd.ExecuteScalar()

            If totalAmount IsNot DBNull.Value Then

                Dim formattedAmount As Decimal = Convert.ToDecimal(totalAmount)
                    Expenses.Text = "" & formattedAmount.ToString("N2") ' Format as currency
                Else
                    Expenses.Text = "Total Expenses: 0"
                End If

            Catch ex As MySqlException
                MessageBox.Show("Database error: " & ex.Message)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the total sales data into the label when the form loads
        LoadTotalSales()
    End Sub

    Private Sub LoadTotalSales()
        Try
            ' Open the database connection
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' SQL query to fetch total sales from the relevant table, e.g., tblSales
            Dim query As String = "SELECT SUM(Amount) AS TotalSales FROM tblpayments" ' Adjust table and column names as needed
            Dim cmd As New MySqlCommand(query, connection)
            Dim totalSales As Object = cmd.ExecuteScalar() ' Execute the query and get the total

            ' Check if total sales is not null and update the label
            If totalSales IsNot DBNull.Value Then
                ' Convert totalSales to Decimal before formatting
                Dim totalSalesValue As Decimal = Convert.ToDecimal(totalSales)
                totalSalesLBL.Text = totalSalesValue.ToString("C2") ' Format as currency
            Else
                totalSalesLBL.Text = "$0.00" ' Default value if no sales exist
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading total sales data: " & ex.Message)
        Finally
            ' Ensure the connection is closed
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub Dashboard_BTN_Click(sender As Object, e As EventArgs) Handles Dashboard_BTN.Click
        Dim Obj = New Manager_Dashboard_Form
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

    Private Sub Financial_BTN_Click(sender As Object, e As EventArgs) Handles Financial_BTN.Click
        Dim Obj = New Manager_Expense_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Cashier_BTN_Click(sender As Object, e As EventArgs) Handles Cashier_BTN.Click
        Dim Obj = New Manager_Cashier_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Maintenance_BTN_Click(sender As Object, e As EventArgs) Handles Maintenance_BTN.Click
        Dim Obj = New Maintenance_EM_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_LOGOUT_Click(sender As Object, e As EventArgs) Handles BTN_LOGOUT.Click
        Dim Obj = New Login_form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub RoundCornerTextbox4_TextChanged(sender As Object, e As EventArgs) Handles RoundCornerTextbox4.TextChanged

    End Sub

    Private Sub Expenses_Click(sender As Object, e As EventArgs) Handles Expenses.Click

    End Sub

    Private Sub StockStatus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StockStatus.CellContentClick

    End Sub
End Class