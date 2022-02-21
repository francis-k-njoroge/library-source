
Imports MySql.Data.MySqlClient
    Public Class frmreturn
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim id As Integer

    Private Sub frmreturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button4.Enabled = False
        con.ConnectionString = "server=localhost;database=librarysystem;uid=root;pwd=''"
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        disp_data()
        disp1_data()


    End Sub

    Public Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM `returntable`"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView2.DataSource = dt




    End Sub
    Public Sub disp1_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * from borrowedbook;"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim con As New MySqlConnection("server=localhost;database=librarysystem;uid=root;pwd=''")
        con.Open()
        Dim cmd As New MySqlCommand("SELECT `borrowid`, `bookid`, `bookno`, `booktitle`, `categoryname`, `borrowerid`, `adminno`, `name`, `form`, `borrowdate`, `bookauthor`, `publisher`, `description` FROM `borrowedbook` WHERE `borrowid`=@parm1", con)
        cmd.Parameters.AddWithValue("@parm1", TextBox1.Text)
        Dim myread As MySqlDataReader = cmd.ExecuteReader
        If (myread.Read()) Then
            TextBox2.Text = myread("borrowerid")
            TextBox3.Text = myread("name")
            TextBox4.Text = myread("booktitle")
            TextBox5.Text = myread("categoryname")
            TextBox6.Text = myread("bookno")
            TextBox8.Text = myread("bookauthor")

            TextBox9.Text = myread("publisher")
            TextBox10.Text = myread("description")


        Else
            MessageBox.Show("no record found")
        End If
        con.Close()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from   borrowedbook  where borrowid=" & TextBox1.Text & ""
            cmd.ExecuteNonQuery()


            TextBox1.Text = ""
            TextBox2.Text = ""

            TextBox3.Text = ""

            TextBox4.Text = ""

            TextBox5.Text = ""





            disp1_data()
            Button4.Enabled = False


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into returntable value (NULL, '" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "' ,'" + TextBox5.Text + "',NULL )"
        cmd.ExecuteNonQuery()
        disp_data()
        MessageBox.Show("BOOK VERIFYED PROCESSED TO RETURN")
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into listofbook value (NULL, '" + TextBox6.Text + "','" + TextBox4.Text + "','" + TextBox8.Text + "' ,'" + TextBox9.Text + "','" + TextBox5.Text + "','" + TextBox10.Text + "' )"
        cmd.ExecuteNonQuery()
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from   borrowedbook  where borrowid=" & TextBox1.Text & ""
            cmd.ExecuteNonQuery()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            disp1_data()
            Button4.Enabled = False
        Catch ex As Exception


        End Try
    End Sub
End Class

