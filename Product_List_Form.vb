Imports MySql.Data.MySqlClient

Public Class Product_List_Form

    Dim connection As New MySqlConnection("server=localhost; userid=root; password=; database=chelseachill")

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Update this line if ProductCode is not the correct column name
            Dim query As String = "SELECT ProductName, Category, Price FROM tblproducts WHERE ProductID LIKE @search OR ProductName LIKE @search OR Category LIKE @search OR Price LIKE @search"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@search", "%" & txtSearch.Text & "%")

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridProductList.DataSource = table

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
            DataGridProductList.DataSource = Nothing
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            Dim query As String
            If String.IsNullOrEmpty(categoryFilter) Or categoryFilter = "All Categories" Then
                query = "SELECT ProductName, Category, Price FROM tblproducts"
            Else
                query = "SELECT ProductName, Category, Price FROM tblproducts WHERE Category = @Category"
            End If

            Dim cmd As New MySqlCommand(query, connection)

            If Not String.IsNullOrEmpty(categoryFilter) And categoryFilter <> "All Categories" Then
                cmd.Parameters.AddWithValue("@Category", categoryFilter)
            End If

            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridProductList.AutoGenerateColumns = True
            DataGridProductList.DataSource = table
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
            DataGridProductList.DataSource = Nothing
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Make sure to use the correct column names from your database
            Dim query As String = "SELECT ProductName, Category, Price FROM tblproducts"
            Dim adapter As New MySqlDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridProductList.AutoGenerateColumns = True
            DataGridProductList.DataSource = table
            connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub



    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        LoadData(cmbCategory.SelectedItem.ToString())
    End Sub

    Private Sub Product_List_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData() ' Load the data when the form loads
    End Sub

    Private Sub DataGridProductList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProductList.CellContentClick

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
