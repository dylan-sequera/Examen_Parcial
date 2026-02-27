Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2 As Double
        Dim promedio As Double

        num1 = Val(numero1.Text)
        num2 = Val(numero2.Text)

        promedio = (num1 + num2) / 2
        resultado.Text = promedio.ToString()
    End Sub
End Class
