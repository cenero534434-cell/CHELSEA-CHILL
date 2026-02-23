Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class MainDishControl

    'Dim connection As New MySqlConnection("server=localhost; userid=root; password=; database=chelseachill")

    'Friend Function productCard_Click(sender As Object, e As EventArgs)
    '    Dim productCard As ProductCardControl = TryCast(sender, ProductCardControl)
    '    If productCard IsNot Nothing Then
    '        Return productCard
    '    End If

    '    Return ""
    'End Function

    Private Sub MainDishControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '    If connection.State = ConnectionState.Closed Then
        '        connection.Open()
        '    End If

        '    Dim query As String = "SELECT * FROM tblproducts"
        '    Dim cmd As New MySqlCommand(query, connection)
        '    Dim reader As MySqlDataReader = cmd.ExecuteReader()

        '    If reader.HasRows Then
        '        While reader.Read
        '            Using productCard As New ProductCardControl
        '                productCard.Tag = reader(0)
        '                productCard.lblTitle.Text = reader(1)
        '                productCard.lblPrice.Text = reader(3)

        '                AddHandler productCard.Click, AddressOf productCard_Click

        '                FlowLayoutPanel.Controls.Add(productCard)
        '            End Using
        '        End While
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'Finally
        '    If connection.State = ConnectionState.Open Then
        '        connection.Close()
        '    End If
        'End Try
    End Sub
End Class
