Public Class Form3
    Dim num1 As Integer
    Dim num2 As Integer
    Dim sum As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num1 = txt1.Text
        num2 = txt2.Text
        sum = num1 * num2
        txt3.Text = sum
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = txt1.Text
        num2 = txt2.Text
        sum = num1 + num2
        txt3.Text = sum
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num1 = txt1.Text
        num2 = txt2.Text
        sum = num1 - num2
        txt3.Text = sum
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num1 = txt1.Text
        num2 = txt2.Text
        sum = num1 / num2
        txt3.Text = sum
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim f1 As New Form1()
        f1.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For Each Form In My.Application.OpenForms
            Form.Close()
        Next
    End Sub
End Class