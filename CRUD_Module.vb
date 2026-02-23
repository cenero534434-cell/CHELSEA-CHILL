Imports MySql.Data.MySqlClient
Module CRUD_Module
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=localhost;user id=root;password=;database=chelseachill")
    End Function
    Public strcon As MySqlConnection = strconnection()

    Public results As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable

    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                results = cmd.ExecuteNonQuery
                If results = 0 Then
                    MessageBox.Show("FAILED TO SAVE THE DATA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA HAS BEEN SAVE", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub


    Public Sub updates(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                results = cmd.ExecuteNonQuery
                If results = 0 Then
                    MessageBox.Show("DATA FAILED UPDATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("DATA HAS BEEN UPDATED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
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



End Module
