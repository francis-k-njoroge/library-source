
Imports MySql.Data.MySqlClient

    Public Class category
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim id As Integer
    Private Sub category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "select * from category"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt





    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into category value (NULL, '" + TextBox1.Text + "'  )"
        cmd.ExecuteNonQuery()

        TextBox1.Text = ""



        disp_data()
        MessageBox.Show("recorded")

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from   category  where categoryid=" & id & ""
            cmd.ExecuteNonQuery()


            TextBox1.Text = ""




            disp_data()


        Catch ex As Exception


        End Try
    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from category where categoryname = '" + TextBox1.Text + "' "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText =
            cmd.ExecuteNonQuery()


            TextBox1.Text = ""



            disp_data()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        id = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from category where categoryid = " & id & ""
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            TextBox1.Text = dr.GetString(1).ToString()


        End While
    End Sub
End Class