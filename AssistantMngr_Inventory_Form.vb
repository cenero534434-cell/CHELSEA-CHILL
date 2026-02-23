Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class AssistantMngr_Inventory_Form

    Dim connection As New MySqlConnection("server=localhost; userid=root; password=; database=chelseachill")


    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root; password=;database=chelseachill")
    End Function
    Public strcon As MySqlConnection = strconnection()

    Public results As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql

            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub


    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        Try
            reload("SELECT * FROM addinventory", DataGridInventory)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridInventory.CellContentClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridInventory.Rows(e.RowIndex)
        End If
    End Sub

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

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged
        LoadData(cmbCategory.SelectedItem.ToString())
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


    Private Sub BTN_SYSTEMMNGMNT_Click(sender As Object, e As EventArgs) 
        Dim Obj = New AssistantMngr_Maintenance_UI_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub BTN_LOGOUT_Click(sender As Object, e As EventArgs) Handles BTN_LOGOUT.Click
        Dim Obj = New Login_Form
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub AssistantMngr_Inventory_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class