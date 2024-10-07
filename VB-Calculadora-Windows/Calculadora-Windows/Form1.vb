Public Class Form1
    Dim a As Boolean = False


    Dim num1 As Integer
    Dim num2 As Integer


    Dim operacion As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If operacion = "+" Then
            num2 = CInt(TextBox1.Text)
            TextBox1.Clear()
            TextBox1.Text = (num1 + num2).ToString()
        ElseIf operacion = "-" Then
            num2 = CInt(TextBox1.Text)
            TextBox1.Clear()
            TextBox1.Text = (num1 - num2).ToString()
        ElseIf operacion = "x" Then
            num2 = CInt(TextBox1.Text)
            TextBox1.Clear()
            TextBox1.Text = (num1 * num2).ToString()
        ElseIf operacion = "÷" Then

            num2 = CInt(TextBox1.Text)
            TextBox1.Clear()
            If num2 = 0 Then TextBox1.Text = "Systaxis Error"

            Return ' Salir de la función sin hacer más cálculos
        Else
            TextBox1.Text = (num1 / num2).ToString()
            num1 = Integer.Parse(TextBox1.Text)
            If num2 <> 0 Then
                TextBox1.Text = (num1 / num2).ToString()
                num1 = CInt(TextBox1.Text)

            End If
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        a = False
        operacion = "+"
        num1 = CInt(TextBox1.Text)
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = False
        operacion = "-"
        num1 = CInt(TextBox1.Text)
        TextBox1.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        a = False
        operacion = "x"


        num1 = CInt(TextBox1.Text)
        TextBox1.Clear()

        End
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        a = False
        operacion = "÷"
        If TextBox1.Text = "Systaxis Error" Then
            Return
        End If
        num1 = CInt(TextBox1.Text)
        TextBox1.Clear()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If a = False Then TextBox1.Text = "" Else TextBox1.Text = TextBox1.Text & ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If a = True Then TextBox1.Text = "0" Else TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If a = True Then TextBox1.Text = "1" Else TextBox1.Text = TextBox1.Text & "1"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If a = True Then TextBox1.Text = "2" Else TextBox1.Text = TextBox1.Text & "2"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If a = True Then TextBox1.Text = "3" Else TextBox1.Text = TextBox1.Text & "3"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If a = True Then TextBox1.Text = "4" Else TextBox1.Text = TextBox1.Text & "4"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If a = True Then TextBox1.Text = "5" Else TextBox1.Text = TextBox1.Text & "5"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If a = True Then TextBox1.Text = "6" Else TextBox1.Text = TextBox1.Text & "6"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If a = True Then TextBox1.Text = "7" Else TextBox1.Text = TextBox1.Text & "7"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If a = True Then TextBox1.Text = "8" Else TextBox1.Text = TextBox1.Text & "8"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If a = True Then TextBox1.Text = "9" Else TextBox1.Text = TextBox1.Text & "9"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        End
    End Sub
End Class
