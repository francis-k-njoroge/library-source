
Imports MySql.Data.MySqlClient


    Public Class borrow

        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim id As Integer
        Private Sub borrow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "select * from borrowedbook"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt




    End Sub

        Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

        End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New MySqlConnection("server=localhost;database=librarysystem;uid=root;pwd=''")
        con.Open()
        Dim cmd As New MySqlCommand("SELECT `listid`,`bookno`,`booktitle`,`bookauthor`,`publisher`,`categoryname`,`description` FROM listofbook WHERE`listid`= @parm1", con)
        cmd.Parameters.AddWithValue("@parm1", TextBox1.Text)
        Dim myread As MySqlDataReader = cmd.ExecuteReader
        If (myread.Read()) Then
            TextBox2.Text = myread("bookno")
            TextBox3.Text = myread("booktitle")
            TextBox4.Text = myread("categoryname")
            TextBox9.Text = myread("bookauthor")
            TextBox10.Text = myread("publisher")
            TextBox11.Text = myread("description")


        Else

            MessageBox.Show("no record found")

        End If
        con.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As New MySqlConnection("server=localhost;database=librarysystem;uid=root;pwd=''")
        con.Open()
        Dim cmd As New MySqlCommand("SELECT `borrowerid`,`adminno`,`firstname`,`form` FROM borrowers where borrowerid= @parm1", con)
        cmd.Parameters.AddWithValue("@parm1", TextBox5.Text)
        Dim myread As MySqlDataReader = cmd.ExecuteReader
        If (myread.Read()) Then
            TextBox6.Text = myread("adminno")
            TextBox7.Text = myread("firstname")
            TextBox8.Text = myread("form")
        Else
            MessageBox.Show("no record found")
        End If
        con.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into borrowedbook value (NULL, '" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "' ,'" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "',NULL,'" + TextBox9.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "' )"
        cmd.ExecuteNonQuery()
            disp_data()
        MessageBox.Show("recorded")
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from   listofbook  where listid=" & TextBox1.Text & ""
            cmd.ExecuteNonQuery()
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            TextBox8.Text = ""

        Catch ex As Exception
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        id = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from borrowedbook where borrowid = " & id & ""
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            TextBox99.Text = dr.GetString(1).ToString()
        End While
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from borrowedbook where borrowerid = '" + TextBox99.Text + "' "
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("arleady search")

        End Try

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class