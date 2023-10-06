Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer

        n = TextBox2.Text

        TextBox3.Text = Math.Round(Val(TextBox1.Text), n)
    End Sub
End Class
