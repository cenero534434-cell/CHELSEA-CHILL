Imports MySql.Data.MySqlClient

Public Class AssistantMngr_Maintenance_UI_Form

    Dim connection As New MySqlConnection("server=localhost; userid=root; password=; database=chelseachill")
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Private Sub Maintainance_ManageEmp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
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
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtname.Text) OrElse
        String.IsNullOrWhiteSpace(txtaddress.Text) OrElse
        String.IsNullOrWhiteSpace(txtcontact.Text) OrElse
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


    Private Sub DataGridUser_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridUser.Rows(e.RowIndex)
            txtID.Text = row.Cells("ID").Value.ToString()
            txtname.Text = row.Cells("Name").Value.ToString()
            txtaddress.Text = row.Cells("Address").Value.ToString()
            txtcontact.Text = row.Cells("Contact").Value.ToString()
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

    Private Sub BTN_CASHIER_Click(sender As Object, e As EventArgs) Handles BTN_CASHIER.Click
        Dim Obj = New AssistantMngr_Cashier_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_LOGOUT_Click(sender As Object, e As EventArgs) Handles BTN_LOGOUT.Click
        Dim Obj = New Login_form
        Obj.Show()
        Me.Hide()
    End Sub
End Class