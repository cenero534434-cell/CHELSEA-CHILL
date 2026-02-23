Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class Manager_Expense_Form

    Dim connectionString As String = "server=localhost;user id=root;password=;database=chelseachill"

    Dim connection As MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim adapter As MySqlDataAdapter
    Dim dt As DataTable


    Private Sub ExpensesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadExpensesData()
    End Sub

    Private Sub LoadExpensesData()
        Try
            connection = New MySqlConnection(connectionString)
            Dim query As String = "SELECT ExpenseDate, TypeofTransaction, Amount FROM tblexpenses"
            adapter = New MySqlDataAdapter(query, connection)
            dt = New DataTable()
            adapter.Fill(dt)
            DataGridExpenses.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    ' Method to add a new expense
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            connection = New MySqlConnection(connectionString)
            connection.Open()
            Dim query As String = "INSERT INTO tblexpenses (ExpenseDate, TypeofTransaction, Amount) VALUES (@ExpenseDate, @TypeofTransaction, @Amount)"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@ExpenseDate", dtpExpenseDate.Value.Date)
            command.Parameters.AddWithValue("@TypeofTransaction", txtTypeofTransaction.Text)
            command.Parameters.AddWithValue("@Amount", txtAmount.Text)

            If command.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Expense added successfully")
                LoadExpensesData()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Method to update an expense
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtExpenseID.Text) Then
            MessageBox.Show("Please select a data to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            connection = New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "UPDATE tblexpenses SET TypeofTransaction = @TypeofTransaction, ExpenseDate = @ExpenseDate, Amount = @Amount WHERE ExpenseID = @ExpenseID"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@ExpenseID", txtExpenseID.Text)
            cmd.Parameters.AddWithValue("@ExpenseDate", dtpExpenseDate.Value.Date) ' Ensure the correct date format
            cmd.Parameters.AddWithValue("@Amount", txtAmount.Text)
            cmd.Parameters.AddWithValue("@TypeofTransaction", txtTypeofTransaction.Text)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Expense updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadExpensesData()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub





    ' Method to delete an expense
    ' Method to delete an expense
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            ' Check if ExpenseID is provided
            If String.IsNullOrWhiteSpace(txtExpenseID.Text) Then
                MessageBox.Show("Please select an expense to delete.")
                Return
            End If

            ' Open connection if it's closed
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Archive the expense
            Dim archiveQuery As String = "INSERT INTO tblunarchiveexpenses (ExpenseID, TypeofTransaction, ExpenseDate, Amount) " &
                                  "SELECT ExpenseID, TypeofTransaction, ExpenseDate, Amount FROM tblexpenses WHERE ExpenseID = @ExpenseID"
            Dim archiveCmd As New MySqlCommand(archiveQuery, connection)
            archiveCmd.Parameters.AddWithValue("@ExpenseID", txtExpenseID.Text)

            ' Execute the archive command
            Dim archiveRowsAffected As Integer = archiveCmd.ExecuteNonQuery()
            If archiveRowsAffected = 0 Then
                MessageBox.Show("No records archived. Please check if the ExpenseID exists.")
                Return
            End If

            ' Delete the selected expense
            Dim deleteQuery As String = "DELETE FROM tblexpenses WHERE ExpenseID = @ExpenseID"
            Dim deleteCmd As New MySqlCommand(deleteQuery, connection)
            deleteCmd.Parameters.AddWithValue("@ExpenseID", txtExpenseID.Text)

            ' Execute the delete command
            Dim deleteRowsAffected As Integer = deleteCmd.ExecuteNonQuery()
            If deleteRowsAffected = 0 Then
                MessageBox.Show("No records deleted. Please check if the ExpenseID exists.")
                Return
            End If

            MessageBox.Show("Expense archived and deleted successfully.")
            ClearFields()

            ' Refresh the DataGridView to show updated data
            LoadData()  ' Assuming this method reloads the DataGridView data

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' Method to load data into the DataGridView
    Private Sub LoadData()
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT ExpenseDate, TypeofTransaction, Amount FROM tblexpenses"
            Dim cmd As New MySqlCommand(query, connection)
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Bind the DataGridView to the data
            DataGridExpenses.DataSource = table

        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub ClearFields()
        txtTypeofTransaction.Clear()
        txtAmount.Clear()
        dtpExpenseDate.Value = DateTime.Now
    End Sub


    Private Sub DataGridExpenses_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridExpenses.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridExpenses.Rows(e.RowIndex)

            ' Assuming the first column is ExpenseID, second is ExpenseDate, third is TypeofTransaction, fourth is Amount
            txtExpenseID.Text = selectedRow.Cells(0).Value.ToString() ' ExpenseID
            dtpExpenseDate.Value = Convert.ToDateTime(selectedRow.Cells(1).Value) ' ExpenseDate
            txtTypeofTransaction.Text = selectedRow.Cells(2).Value.ToString() ' TypeofTransaction
            txtAmount.Text = selectedRow.Cells(3).Value.ToString() ' Amount
        End If
    End Sub




    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        txtTypeofTransaction.Clear()
        txtAmount.Clear()
    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Dashboard_Form
        Obj.Show()
        Me.Hide()
    End Sub



    Private Sub Button10_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Expense_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Inventory_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Report_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Obj = New Maintenance_EM_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)
        Dim Obj = New Login_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        Dim Obj = New Login_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim Obj = New Login_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        Dim Obj = New Login_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        Dim Obj = New Manager_Cashier_Form
        Obj.Show()
        Me.Hide()
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
        Dim Obj = New Login_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_DASHBOARD_Click(sender As Object, e As EventArgs) Handles BTN_DASHBOARD.Click
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

    Private Sub txtTypeofTransaction_TextChanged(sender As Object, e As EventArgs) Handles txtTypeofTransaction.TextChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class