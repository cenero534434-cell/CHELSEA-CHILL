Imports MySql.Data.MySqlClient
Module Mlogin
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root; password=;database=chelseachill")
    End Function

    Public stron As MySqlConnection = strconnection()
    Public results As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

End Module
