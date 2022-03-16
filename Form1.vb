Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MsgBox("Hello World!!")
        lblHello.Text = "Welcome to my first VB Application"
        lblHello2.Text = "Fareez"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        MsgBox("You have selected " + ListBox1.SelectedItem.ToString() + " color")

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnKira.Click
        MsgBox("50" & "+" & "1" & "=" & 50 + 1)
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        'MsgBox("Hi, my name is " + txtNama.Text + " and i'm from " + txtState.Text + ". I am " + txtAge.Text + " years old")
        Label2.Text = "Hi, my name is " + txtNama.Text + " and i'm from " + txtState.Text + ". I am " + txtAge.Text + " years old"
    End Sub
End Class
