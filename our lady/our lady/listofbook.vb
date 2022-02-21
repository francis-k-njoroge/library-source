Imports MySql.Data.MySqlClient

Public Class listofbook
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim id As Integer
    Private Sub listofbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "server=localhost;database=librarysystem;uid=root;pwd=''"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        disp_data()

    End Sub

    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from listofbook"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt






    End Sub
End Class