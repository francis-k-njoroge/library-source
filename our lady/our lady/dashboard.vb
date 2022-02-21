Public Class dashboard

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Form1.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = Date.Now.ToString("dd/MM/yyyy     hh:mm:ss")
    End Sub

    Private Sub btnbook_Click(sender As Object, e As EventArgs) Handles btnbook.Click
        books.Show()

    End Sub

    Private Sub btnborrower_Click(sender As Object, e As EventArgs) Handles btnborrower.Click
        frmborrower.Show()
    End Sub

    Private Sub btncategories_Click(sender As Object, e As EventArgs) Handles btncategories.Click
        category.Show()
    End Sub

    Private Sub btnudermgt_Click(sender As Object, e As EventArgs) Handles btnudermgt.Click
        usermgt.Show()
    End Sub

    Private Sub btnborrrow_Click(sender As Object, e As EventArgs) Handles btnborrrow.Click
        borrow.Show()
    End Sub

    Private Sub btnreturn_Click(sender As Object, e As EventArgs) Handles btnreturn.Click
        frmreturn.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        listofbook.Show()
    End Sub

    Private Sub btnoverdue_Click(sender As Object, e As EventArgs) Handles btnoverdue.Click
        overdue.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form1.Close()

    End Sub
End Class