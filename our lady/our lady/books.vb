Imports MySql.Data.MySqlClient

Public Class books
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim id As Integer
    Dim str As String
    Private Sub books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "server=localhost;database=librarysystem;uid=root;pwd=''"
        If con.State = ConnectionState.Open Then
            con.Close()
        End If


        Try
            str = "SELECT `categoryname`FROM category GROUP BY categoryname"
            Dim da As New MySqlDataAdapter(str, con)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                ComboBox1.DataSource = dt
                ComboBox1.DisplayMember = "categoryname"
                ComboBox1.ValueMember = ""

            End If

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
        con.Open()
        disp_data()


    End Sub
    Public Sub disp_data()
        Try




            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from book"
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New MySqlDataAdapter(cmd)
            da.Fill(dt)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("INVALID OPERATION ")
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into book value (NULL, '" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "' ,'" + TextBox5.Text + "','" + ComboBox1.Text + "','" + TextBox7.Text + "' )"
            cmd.ExecuteNonQuery()
            disp_data()
            MessageBox.Show("recorded")
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into listofbook value (NULL, '" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "' ,'" + TextBox5.Text + "','" + ComboBox1.Text + "','" + TextBox7.Text + "' )"
            cmd.ExecuteNonQuery()
            TextBox1.Text = ""
        Catch ex As Exception
            MsgBox("invalid operation")

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        Try
            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from   books  where bookid=" & id & ""
            cmd.ExecuteNonQuery()






            disp_data()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from   listofbook  where bookid=" & id & ""
            cmd.ExecuteNonQuery()


            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox5.Text = ""
            TextBox7.Text = ""





        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from book where boookid = '" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        disp_data()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        id = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from book where bookid = " & id & ""
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            TextBox1.Text = dr.GetString(1).ToString()
            TextBox2.Text = dr.GetString(2).ToString()
            TextBox3.Text = dr.GetString(3).ToString()
            TextBox5.Text = dr.GetString(4).ToString()
            TextBox7.Text = dr.GetString(5).ToString()
        End While
    End Sub
End Class