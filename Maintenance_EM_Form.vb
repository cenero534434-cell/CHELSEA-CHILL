
Imports MySql.Data.MySqlClient

Public Class Maintenance_EM_Form

    Dim connection As New MySqlConnection("server=localhost; userid=root; password=; database=chelseachill")
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Maintainance_ManageEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        txtposition.Items.AddRange(New String() {"Manager", "Assistant Manager", "Staff"})
        AddHandler DataGridUser.CellClick, AddressOf DataGridUser_CellClick ' Add this line
    End Sub



    Private Sub LoadData()
        Try
            DataGridUser.DataSource = Nothing
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT * FROM tblemployee"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridUser.AutoGenerateColumns = True
            DataGridUser.DataSource = table
            connection.Close()
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
        txtusername.Clear()
        txtpassword.Clear()
        txtcnfrmpass.Clear()
        txtposition.SelectedIndex = -1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtname.Text) OrElse
           String.IsNullOrWhiteSpace(txtaddress.Text) OrElse
           String.IsNullOrWhiteSpace(txtcontact.Text) OrElse
           String.IsNullOrWhiteSpace(txtposition.Text) OrElse
           String.IsNullOrWhiteSpace(txtusername.Text) OrElse
           String.IsNullOrWhiteSpace(txtpassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtcnfrmpass.Text) Then

            MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "INSERT INTO tblemployee (Name, Address, Contact, Position, Username, Password, Cnfrmpass) VALUES (@name, @address, @contact, @position, @username, @password, @cnfrmpass)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@name", txtname.Text)
            cmd.Parameters.AddWithValue("@address", txtaddress.Text)
            cmd.Parameters.AddWithValue("@contact", txtcontact.Text)
            cmd.Parameters.AddWithValue("@position", txtposition.Text)
            cmd.Parameters.AddWithValue("@username", txtusername.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)
            cmd.Parameters.AddWithValue("@cnfrmpass", txtcnfrmpass.Text)

            cmd.ExecuteNonQuery()
            connection.Close()

            MessageBox.Show("Employee has been added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtname.Text) OrElse
        String.IsNullOrWhiteSpace(txtaddress.Text) OrElse
        String.IsNullOrWhiteSpace(txtcontact.Text) OrElse
        String.IsNullOrWhiteSpace(txtposition.Text) OrElse
        String.IsNullOrWhiteSpace(txtusername.Text) OrElse
        String.IsNullOrWhiteSpace(txtpassword.Text) OrElse
        String.IsNullOrWhiteSpace(txtcnfrmpass.Text) Then

            MessageBox.Show("Please fill in all the fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "UPDATE tblemployee SET Name = @name, Address = @address, Contact = @contact, Position = @position, Username = @username, Password = @password, Cnfrmpass = @cnfrmpass WHERE ID = @id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id", txtID.Text) ' Use ID for the update
            cmd.Parameters.AddWithValue("@name", txtname.Text)
            cmd.Parameters.AddWithValue("@address", txtaddress.Text)
            cmd.Parameters.AddWithValue("@contact", txtcontact.Text)
            cmd.Parameters.AddWithValue("@position", txtposition.Text)
            cmd.Parameters.AddWithValue("@username", txtusername.Text)
            cmd.Parameters.AddWithValue("@password", txtpassword.Text)
            cmd.Parameters.AddWithValue("@cnfrmpass", txtcnfrmpass.Text)

            cmd.ExecuteNonQuery()

            MessageBox.Show("Employee details have been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "DELETE FROM tblemployee WHERE Name = @name"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@name", txtname.Text)
            cmd.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Employee Deleted Successfully")
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


    Private Sub DataGridUser_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridUser.Rows(e.RowIndex)
            txtID.Text = row.Cells("ID").Value.ToString()
            txtname.Text = row.Cells("Name").Value.ToString()
            txtaddress.Text = row.Cells("Address").Value.ToString()
            txtcontact.Text = row.Cells("Contact").Value.ToString()
            txtposition.Text = row.Cells("Position").Value.ToString()
            txtusername.Text = row.Cells("Username").Value.ToString()
            txtpassword.Text = row.Cells("Password").Value.ToString()
            txtcnfrmpass.Text = row.Cells("Cnfrmpass").Value.ToString()
        End If
    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If txtpassword.UseSystemPasswordChar = True Then
            ' show password
            txtpassword.UseSystemPasswordChar = False

        Else

            ' hide password
            txtpassword.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If txtcnfrmpass.UseSystemPasswordChar = True Then
            ' show password
            txtcnfrmpass.UseSystemPasswordChar = False

        Else

            ' hide password
            txtcnfrmpass.UseSystemPasswordChar = True

        End If
    End Sub



    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim Obj = New Maintenance_Supplier_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim Obj = New Maintainance_SystemSettings_Form
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

    Private Sub txtaddress_TextChanged(sender As Object, e As EventArgs) Handles txtaddress.TextChanged

    End Sub

    Private Sub txtconfrmpass_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class