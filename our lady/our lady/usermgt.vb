
Imports MySql.Data.MySqlClient


    Public Class usermgt
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim id As Integer
    Private Sub usermgt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "select * from user"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into user value (NULL, '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "'  )"
        cmd.ExecuteNonQuery()

        TextBox1.Text = ""
        TextBox2.Text = ""

        TextBox3.Text = ""

        TextBox4.Text = ""





        disp_data()
        MessageBox.Show("recorded")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from   user  where userid=" & id & ""
            cmd.ExecuteNonQuery()


            TextBox1.Text = ""




            disp_data()


        Catch ex As Exception


        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class