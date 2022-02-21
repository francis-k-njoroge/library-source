Imports MySql.Data.MySqlClient
Public Class borrower
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim id As Integer

    Private Sub borrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "select * from borrowers"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into borrowers value (NULL,  '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "' )"
        cmd.ExecuteNonQuery()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        disp_data()
        MessageBox.Show("succussful add, procced to print card")

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class