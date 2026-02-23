Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Manager_Report

    Dim connectionString As String = "server=localhost;user id=root;password=;database=chelseachill"

    ' Method to add the sales record to DataGridView1
    Public Sub AddSalesRecordToReport(productName As String, totalAmount As Decimal)
        ' Get the current date and time for the transaction
        Dim transactionDate As String = DateTime.Now.ToString("g") ' Example format: 10/14/2024 3:45 PM

        ' Add the transaction details to the DataGridView (Date, Product Name, Total Amount)
        DataGridView1.Rows.Add(transactionDate, productName, totalAmount.ToString("C"))

        ' Optionally, refresh the DataGridView to ensure it displays the new data
        DataGridView1.Refresh()
    End Sub




    Private Sub Manager_Report_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure that the DataGridView1 has the correct columns
        If DataGridView1.Columns.Count = 0 Then
            ' Add Transaction Date Column
            DataGridView1.Columns.Add("TransactionDate", "Transaction Date")

            ' Add Product Name Column
            DataGridView1.Columns.Add("ProductName", "Product Name")

            ' Add Total Amount Column
            DataGridView1.Columns.Add("TotalAmount", "Total Sales")
        End If
    End Sub




    Private Sub LoadTotalExpenses(selectedDate As DateTime)
        ' Ensure you have the correct MySqlConnection type
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the connection if it's closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Query to get total expenses for the selected date
            Dim query As String = "SELECT DATE(ExpenseDate) AS ExpenseDate, TypeofTransaction, SUM(Amount) AS TotalAmount " &
                              "FROM tblexpenses " &
                              "WHERE DATE(ExpenseDate) = @SelectedDate " &
                              "GROUP BY DATE(ExpenseDate)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@SelectedDate", selectedDate.Date) ' Pass the selected date as a parameter

            ' Execute the query and read the data
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ' Clear existing rows in DataGridView4 before adding new data
            DataGridView2.Rows.Clear()

            ' Check if any records were returned
            If reader.HasRows Then
                While reader.Read()
                    Dim expenseDate As Date = reader.GetDateTime("ExpenseDate")
                    Dim typeofTransaction As String = reader.GetString("TypeofTransaction")
                    Dim totalAmount As Decimal = reader.GetDecimal("TotalAmount")
                    ' Add the date and total amount to DataGridView4
                    DataGridView2.Rows.Add(expenseDate.ToString("yyyy-MM-dd"), typeofTransaction, totalAmount.ToString("N2"))
                End While
            Else
                ' If no expenses exist for the selected date, add a row with 0 expenses
                DataGridView2.Rows.Add(selectedDate.ToString("yyyy-MM-dd"), "0.00")
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
        Dim Obj = New Login_form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub DataGridViewSales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView4_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub



    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        ' Call LoadTotalExpenses with the selected date from the DateTimePicker
        LoadTotalExpenses(DateTimePicker2.Value)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class