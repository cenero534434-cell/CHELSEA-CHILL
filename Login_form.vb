
Imports MySql.Data.MySqlClient


Public Class Login_form
    Dim connection As New MySqlConnection("server=localhost; userid=root; password=; database=chelseachill")
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String = "SELECT * FROM tblemployee WHERE Username = @username AND Password = @password"
            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@username", txtUsername.Text)
            command.Parameters.AddWithValue("@password", txtpassword.Text)
            reader = command.ExecuteReader()

            If reader.HasRows Then
                reader.Read()
                Dim position As String = reader("Position").ToString()

                Select Case position
                    Case "Manager"
                        Me.Hide()
                        Dim managerForm As New Manager_Dashboard_Form
                        managerForm.Show()
                    Case "Assistant Manager"
                        Me.Hide()
                        Dim assistantManagerForm As New AssistantMngr_Dashboard_Form
                        assistantManagerForm.Show()
                    Case "Staff"
                        Me.Hide()
                        Dim staffForm As New Staff_Cashier_Form
                        staffForm.Show()
                    Case Else
                        MessageBox.Show("Invalid user position detected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Select
            Else
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If reader IsNot Nothing Then
                reader.Close()
            End If
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
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

    Private Sub Login_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub
End Class