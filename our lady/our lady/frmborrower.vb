Imports MySql.Data.MySqlClient
Public Class frmborrower
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim id As Integer

    Private Sub frmborrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText(vbTab + vbTab + vbTab & "OUR LADY HIGH SCHOOL" + vbTab + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText(vbTab + vbTab + vbTab + vbTab & "MOTTO" + vbTab + vbNewLine)
        TextBox1.AppendText(vbTab + vbTab + "PRAYER DISPLINE AND HARDWORKING FOR EXCLENCE " + vbNewLine)

        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText(vbTab + vbTab & "STUDENT NAME " + TextBox2.Text + vbTab + TextBox3.Text + vbTab + TextBox4.Text + vbNewLine)
        TextBox1.AppendText(vbTab + vbTab & "ADMISSION NO" + vbTab + TextBox6.Text + vbTab + vbTab + vbNewLine)
        TextBox1.AppendText(vbTab + vbTab & "LIBRARY ID  " + vbTab + TextBox9.Text + vbNewLine)
        TextBox1.AppendText(vbTab + vbTab & "FORM  " + vbTab + TextBox5.Text + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText(vbTab + vbTab & " = = = = = = = = = = = = = = = = = = = = =" + vbNewLine)
        TextBox1.AppendText(vbTab + vbTab & "Need Help?-------Contact Us:--------0111446888 " + vbNewLine)
        TextBox1.AppendText(vbTab + vbTab & "  = = = = = = = = = = = = = = = = = = = = =" + vbNewLine)
        TextBox1.AppendText(vbTab + vbTab & "POWERED BY AMOH TECHNOLOGY------- " + vbNewLine)
        TextBox1.AppendText(vbTab + vbTab & " = = = = = = = = = = = = = = = = = = = = = = = " + vbNewLine)
        PrintPreviewDialog1.ShowDialog()
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(TextBox1.Text, Font, Brushes.Black, 140, 140)
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
        MessageBox.Show("recorded")
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try



            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()
        id = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from  borrowers  where  borrowerID = " & id & ""
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New MySqlDataAdapter(cmd)
        da.Fill(dt)

        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
        While dr.Read

            TextBox2.Text = dr.GetString(1).ToString()
            TextBox9.Text = dr.GetString(0).ToString()


            TextBox3.Text = dr.GetString(2).ToString()
            TextBox4.Text = dr.GetString(3).ToString()
            TextBox5.Text = dr.GetString(4).ToString()
            TextBox6.Text = dr.GetString(5).ToString()

        End While
        Catch ex As Exception
            MsgBox(ex.Message)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox6.Text = ""

            TextBox5.Text = ""
        End Try
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If (e.KeyChar.ToString >= "1" And e.KeyChar.ToString <= "4") Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If (e.KeyChar.ToString >= "0" And e.KeyChar.ToString <= "9") Then
            Else
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If con.State = ConnectionState.Open Then
                con.Close()

            End If
            con.Open()

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "DELETE FROM `borrowers` WHERE `borrowerid`=" & id & ""
            cmd.ExecuteNonQuery()
            disp_data()


            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox6.Text = ""

            TextBox5.Text = ""






        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class