Imports MySql.Data.MySqlClient


Public Class overdue
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim id As Integer


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub overdue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "SELECT `borrowerid`,`name`,`bookno`,`borrowdate`,`booktitle` FROM borrowedbook;"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt




    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If con.State = ConnectionState.Open Then
            con.Close()

        End If
        con.Open()
        id = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from borrowedbook where borrowerid = " & id & ""
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            TextBox1.Text = dr.GetString(1).ToString()
            TextBox2.Text = dr.GetString(9).ToString()
            TextBox3.Text = dr.GetString(7).ToString()
        End While


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim btime As Date = TimeValue(TextBox2.Text)
        Dim otime As TimeSpan = btime - TimeOfDay
        TextBox4.Text = (String.Format("{0}:{1}:{2}:{3}", otime.TotalDays, otime.Hours, otime.Minutes, otime.Seconds))
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub
End Class