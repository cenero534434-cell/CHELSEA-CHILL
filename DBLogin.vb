
Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Module DBLogin
    Dim con As New MySqlConnection("Server=127.0.0.1; user=root; password=root; database=chelseachill")
    Public Function open() As MySqlConnection
        Try
            con.Open()
        Catch ex As exception
            MessageBox.Show(ex.Message)
        End Try
        Return con
    End Function
    Public Function Close() As MySqlConnection
        Try
            con.Close()
        Catch ex As exception
            MessageBox.Show(ex.Message)
        End Try
        Return con
    End Function
End Module
