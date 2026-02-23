Imports MySql.Data.MySqlClient

Public Class Maintenance_Supplier_Form



        Dim connection As New MySqlConnection("server=localhost; userid=root; password=; database=chelseachill")


    Private Sub LoadData()
        Try
            DataGridSupplier.DataSource = Nothing
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT * FROM tblsupplier"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridSupplier.AutoGenerateColumns = True
            DataGridSupplier.DataSource = table
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridSupplier.SelectedRows.Count > 0 Then
            Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

                Dim row As DataGridViewRow = DataGridSupplier.SelectedRows(0)
                Dim query As String = "INSERT INTO tblunarchivesupplier (ID, Name, Address, Contact) VALUES (@ID, @Name, @Address, @Contact)"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@ID", row.Cells("ID").Value.ToString())
                cmd.Parameters.AddWithValue("@Name", row.Cells("Name").Value.ToString())
                cmd.Parameters.AddWithValue("@Address", row.Cells("Address").Value.ToString())
                cmd.Parameters.AddWithValue("@Contact", row.Cells("Contact").Value.ToString())

                cmd.ExecuteNonQuery()
                Dim deleteQuery As String = "DELETE FROM tblsupplier WHERE ID = @ID"
                Dim deleteCmd As New MySqlCommand(deleteQuery, connection)
                deleteCmd.Parameters.AddWithValue("@ID", row.Cells("ID").Value.ToString())
                deleteCmd.ExecuteNonQuery()

                connection.Close()
                MessageBox.Show("Supplier archived successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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



    Private Sub DataGridSupplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSupplier.CellContentClick
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow = DataGridSupplier.Rows(e.RowIndex)
                txtname.Text = row.Cells("Name").Value.ToString()
                txtaddress.Text = row.Cells("Address").Value.ToString()
            txtcontact.Text = row.Cells("Contact").Value.ToString()
        End If
        End Sub


        Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtname.Text) OrElse
           String.IsNullOrWhiteSpace(txtaddress.Text) OrElse
           String.IsNullOrWhiteSpace(txtcontact.Text) Then

            MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

            Dim query As String = "UPDATE tblsupplier SET Address = @address, Contact = @contact WHERE Name = @name"
            Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@name", txtname.Text)
                cmd.Parameters.AddWithValue("@address", txtaddress.Text)
            cmd.Parameters.AddWithValue("@contact", txtcontact.Text)
            cmd.ExecuteNonQuery()

                MessageBox.Show("Supplier details have been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Sub

        Private Sub ClearFields()
            txtname.Clear()
            txtaddress.Clear()
        txtcontact.Clear()
    End Sub


        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtname.Text) OrElse
           String.IsNullOrWhiteSpace(txtaddress.Text) OrElse
           String.IsNullOrWhiteSpace(txtcontact.Text) Then

            MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
                If connection.State = ConnectionState.Closed Then
                    connection.Open()
                End If

            Dim query As String = "INSERT INTO tblsupplier (Name, Address, Contact) VALUES (@name, @address, @contact)"
            Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@name", txtname.Text)
                cmd.Parameters.AddWithValue("@address", txtaddress.Text)
            cmd.Parameters.AddWithValue("@contact", txtcontact.Text)

            cmd.ExecuteNonQuery()
                connection.Close()

                MessageBox.Show("Supplier has been added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                If connection.State = ConnectionState.Open Then
                    connection.Close()
                End If
            End Try
        End Sub

        Private Sub Maintainance_Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            LoadData()
        End Sub

    Private Sub txtaddress_TextChanged(sender As Object, e As EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim Obj = New Maintainance_SystemSettings_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim Obj = New Maintenance_EM_Form
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



    Private Sub BTN_LOGOUT_Click(sender As Object, e As EventArgs) Handles BTN_LOGOUT.Click
        Dim Obj = New Login_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub
End Class
