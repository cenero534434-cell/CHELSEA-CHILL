Imports MySql.Data.MySqlClient

Public Class AssistantMngr_Report_Form

    Dim connectionString As String = "server=localhost;user id=root;password=;database=chelseachill"


    Public Sub AddSalesRecordToReport(productName As String, totalAmount As Decimal)
        ' Get the current date and time for the transaction
        Dim transactionDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

        ' Insert the sales record into the database
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
            Dim query As String = "INSERT INTO payments (ProductName, Date, Amount) VALUES (@ProductName, @Date, @Amount)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@ProductName", productName)
            cmd.Parameters.AddWithValue("@Date", transactionDate)
            cmd.Parameters.AddWithValue("@Amount", totalAmount)

            ' Execute the query to save the data
            cmd.ExecuteNonQuery()

            ' After inserting, update the DataGridView1 to reflect the new record
            UpdateDataGridView1(transactionDate, productName, totalAmount)

            ' Update the total sales after adding a new record
            UpdateTotalSales()

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


    Private Sub UpdateDataGridView1(transactionDate As String, productName As String, totalAmount As Decimal)
        ' Add the transaction directly to DataGridView1, including the Product Name
        DataGridView1.Rows.Add(transactionDate, productName, totalAmount.ToString("C"))

        ' Refresh the DataGridView to display the new data
        DataGridView1.Refresh()
    End Sub


    ' Example setup for DataGridView columns in Manager_Report_Form
    Private Sub Manager_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure that the DataGridView1 has the correct columns for sales records
        If DataGridView1.Columns.Count = 0 Then
            ' Add Transaction Date Column
            DataGridView1.Columns.Add("TransactionDate", "Transaction Date")

            ' Add Product Name Column
            DataGridView1.Columns.Add("ProductName", "Product Name")

            ' Add Total Amount Column
            DataGridView1.Columns.Add("TotalAmount", "Total Sales")
        End If

        ' Load the sales records from the database when the form is loaded
        LoadSalesRecords()

        ' Load the expense records into DataGridView2 when the form is loaded
        LoadExpenseRecords()
    End Sub


    ' Method to load the sales records from the database into DataGridView1
    Private Sub LoadSalesRecords()
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
            Dim query As String = "SELECT ProductName, DATE(Date) AS Date, Amount FROM payments"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing rows in DataGridView1 before adding new data
            DataGridView1.Rows.Clear()

            Dim totalSales As Decimal = 0  ' Variable to hold total sales amount

            ' Read the data and add each record to DataGridView1
            While reader.Read()
                Dim productName As String = reader("ProductName").ToString()
                Dim salesDate As DateTime = reader.GetDateTime("Date")
                Dim amount As Decimal = reader.GetDecimal("Amount")
                DataGridView1.Rows.Add(salesDate.ToString("yyyy-MM-dd"), productName, amount.ToString("N2"))
                totalSales += amount  ' Add amount to totalSales
            End While

            ' Update the total sales label
            lbltotalsales.Text = totalSales.ToString("C")  ' Format as currency

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


    Private Sub LoadExpenseRecords()
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
            Dim query As String = "SELECT ExpenseDate, TypeofTransaction, Amount FROM tblexpenses"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing rows in DataGridView2 before adding new data
            DataGridView2.Rows.Clear()

            ' Read the data and add each record to DataGridView2
            While reader.Read()
                Dim expenseDate As DateTime = reader.GetDateTime("ExpenseDate")
                Dim typeOfTransaction As String = reader.GetString("TypeofTransaction")
                Dim amount As Decimal = reader.GetDecimal("Amount")
                DataGridView2.Rows.Add(expenseDate.ToString("yyyy-MM-dd"), typeOfTransaction, amount.ToString("N2"))
            End While

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


    Private Sub LoadTotalExpenses(selectedDate As DateTime)
        Dim connection As New MySqlConnection(connectionString)

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Query to get total expenses for the selected date
            Dim query As String = "SELECT SUM(Amount) AS TotalAmount " &
                              "FROM tblexpenses " &
                              "WHERE DATE(ExpenseDate) = @SelectedDate"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Date)

            ' Execute the query and get the total amount
            Dim total As Object = cmd.ExecuteScalar()

            ' Check if total is not DBNull
            If total IsNot DBNull.Value Then
                lbltotalexpenses.Text = "₱" & Convert.ToDecimal(total).ToString("N2") ' Format as pesos
            Else
                lbltotalexpenses.Text = "₱0.00" ' Default if no expenses exist for the selected date
            End If

            ' Optionally, load the individual expense records for the selected date
            LoadExpenseRecordsForDate(selectedDate)

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

    Private Sub LoadExpenseRecordsForDate(selectedDate As DateTime)
        Dim connection As New MySqlConnection(connectionString)

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Query to get expense records for the selected date
            Dim query As String = "SELECT ExpenseDate, TypeofTransaction, Amount " &
                              "FROM tblexpenses " &
                              "WHERE DATE(ExpenseDate) = @SelectedDate"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Date)

            ' Execute the query and read the data
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing rows in DataGridView2 before adding new data
            DataGridView2.Rows.Clear()

            ' Check if any records were returned
            If reader.HasRows Then
                While reader.Read()
                    Dim expenseDate As DateTime = reader.GetDateTime("ExpenseDate")
                    Dim typeOfTransaction As String = reader.GetString("TypeofTransaction")
                    Dim amount As Decimal = reader.GetDecimal("Amount")
                    ' Add the date, type, and amount to DataGridView2
                    DataGridView2.Rows.Add(expenseDate.ToString("yyyy-MM-dd"), typeOfTransaction, amount.ToString("N2"))
                End While
            Else
                lbltotalexpenses.Text = "₱0.00" ' Reset total expenses if no records found
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




    Private Sub UpdateTotalSales()
        Dim connection As New MySqlConnection(connectionString)
        Try
            connection.Open()
            Dim query As String = "SELECT SUM(Amount) FROM tblpayments"
            Dim cmd As New MySqlCommand(query, connection)
            Dim total As Object = cmd.ExecuteScalar()  ' Get the total sales amount

            ' Check if total is not DBNull
            If total IsNot DBNull.Value Then
                lbltotalsales.Text = Convert.ToDecimal(total).ToString("C")  ' Format as currency
            Else
                lbltotalsales.Text = "₱0.00"  ' Default if no sales exist
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



    Private Sub LoadTotalSales(selectedDate As DateTime)
        ' Ensure you have the correct MySqlConnection type
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the connection if it's closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Query to get total sales for the selected date
            Dim query As String = "SELECT SUM(Amount) AS TotalAmount " &
                              "FROM tblpayments " &
                              "WHERE DATE(Date) = @SelectedDate"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Date) ' Pass the selected date as a parameter

            ' Execute the query and get the total amount
            Dim total As Object = cmd.ExecuteScalar()

            ' Check if total is not DBNull
            If total IsNot DBNull.Value Then
                lbltotalsales.Text = Convert.ToDecimal(total).ToString("C") ' Format as currency
            Else
                lbltotalsales.Text = "₱0.00" ' Default if no sales exist for the selected date
            End If

            ' Optionally, you can also load the sales records for the selected date into DataGridView1
            LoadSalesRecordsForDate(selectedDate)

        Catch ex As MySqlException
            ' Handle database-specific errors
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            ' Handle any other errors
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Ensure the connection is closed after the operation
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub LoadSalesRecordsForDate(selectedDate As DateTime)
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the connection if it's closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Query to get sales records for the selected date
            Dim query As String = "SELECT DATE(Date) AS Date, Amount " &
                              "FROM tblpayments " &
                              "WHERE DATE(Date) = @SelectedDate"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Date) ' Pass the selected date as a parameter

            ' Execute the query and read the data
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing rows in DataGridView1 before adding new data
            DataGridView1.Rows.Clear()

            ' Check if any records were returned
            If reader.HasRows Then
                While reader.Read()
                    Dim salesDate As Date = reader.GetDateTime("Date")
                    Dim amount As Decimal = reader.GetDecimal("Amount")
                    ' Add the date and total amount to DataGridView1
                    DataGridView1.Rows.Add(salesDate.ToString("yyyy-MM-dd"), amount.ToString("N2"))
                End While
            Else
                ' Optionally handle case for no records
                lbltotalsales.Text = "₱0.00" ' Reset total sales if no records found
            End If

        Catch ex As MySqlException
            ' Handle database-specific errors
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            ' Handle any other errors
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Ensure the connection is closed after the operation
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub


    Private Sub Dashboard_BTN_Click_1(sender As Object, e As EventArgs) Handles Dashboard_BTN.Click
        Dim Obj = New AssistantMngr_Dashboard_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Inventory_BTN_Click(sender As Object, e As EventArgs) Handles Inventory_BTN.Click
        Dim Obj = New AssistantMngr_Inventory_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Report_BTN_Click(sender As Object, e As EventArgs) Handles Report_BTN.Click
        Dim Obj = New AssistantMngr_Report_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Financial_BTN_Click(sender As Object, e As EventArgs) Handles Financial_BTN.Click
        Dim Obj = New AssistantMngr_Expense_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Cashier_BTN_Click(sender As Object, e As EventArgs) Handles Cashier_BTN.Click
        Dim Obj = New AssistantMngr_Cashier_Form
        Obj.Show()
        Me.Hide()
    End Sub



    Private Sub Maintenance_BTN_Click(sender As Object, e As EventArgs)
        Dim Obj = New AssistantMngr_Maintenance_UI_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles BTN_LOGOUT.Click
        Dim Obj = New Login_form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub AssistantMngr_Report_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateTimePicker4_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        '   Call LoadTotalExpenses() With the selected Date from the DateTimePicker
        LoadTotalExpenses(DateTimePicker2.Value)


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoadTotalSales(DateTimePicker1.Value)
    End Sub
End Class