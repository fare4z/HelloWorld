Public Class Form1

    Enum colors
        red = 1
        orange = 2
        yellow = 3
        green = 4
    End Enum

    Private color As colors = 3
    'Private color As colors = colors.red
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MsgBox("Hello World!!")
        lblHello.Text = "Welcome to my first VB Application"
        lblHello2.Text = "Fareez"

        Const poliName As String = "Politeknik Seberang Perai"
        'Dim poliName As String = "psp"
        'poliName = "ss"
        lblPoli.Text = poliName
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
        Dim tarikh As Date = Today

        'MsgBox("Hi, my name is " + txtNama.Text + " and i'm from " + txtState.Text + ". I am " + txtAge.Text + " years old")
        Label2.Text = "Hi, my name is " + txtNama.Text + " and i'm from " + txtState.Text + ". I am " + txtAge.Text + " years old" + vbCrLf +
            " Date cstr :" + (CStr(tarikh)) + vbCrLf + " Date biasa :" + tarikh
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Single = Val(txt1.Text)
        Dim operator_math As Char = CmbOperator.Text
        Dim num2 As Single = Val(txt3.Text)

        If operator_math = "+" Then
            Label4.Text = num1 + num2
        ElseIf operator_math = "-" Then
            Label4.Text = num2 - num1
        ElseIf operator_math = "x" Then
            Label4.Text = num1 * num2
        ElseIf operator_math = "/" Then
            Label4.Text = num1 / num2
        Else
            Label4.Text = "Error"
        End If

    End Sub

    Private Sub btnEnum_Click(sender As Object, e As EventArgs) Handles btnEnum.Click
        MessageBox.Show(color.ToString)
    End Sub
End Class
