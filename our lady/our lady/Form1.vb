Imports MySql.Data.MySqlClient
Public Class Form1
    Dim f2 As New dashboard
    Dim con As New MySqlConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con.ConnectionString = "server=localhost;database=librarysystem;uid=root;pwd=''"
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            con.Open()
            Dim command As New MySqlCommand("SELECT `firstname`, `password` FROM `user` WHERE `firstname` = @username AND `password`= @password", con)
            command.Parameters.Add("@username", MySqlDbType.VarChar).Value = TextBox1.Text
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = TextBox2.Text
            Dim adapter As New MySqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            If table.Rows.Count = 0 Then

                MessageBox.Show("Invalid Username Or Password")
                TextBox1.Text = ""
                TextBox2.Text = ""
            Else
                f2.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        listofbook.Show()
    End Sub
End Class
