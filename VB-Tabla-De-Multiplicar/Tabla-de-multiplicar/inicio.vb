Imports System.Net.Security

Public Class inicio
    Dim tabla As String

    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        tabla = TextBox1.Text
        'Labels'
        Label2.Text = tabla & "X1"
        Label3.Text = tabla & "X2"
        Label4.Text = tabla & "X3"
        Label5.Text = tabla & "X4"
        Label6.Text = tabla & "X5"
        Label7.Text = tabla & "X6"
        Label8.Text = tabla & "X7"
        Label9.Text = tabla & "X8"
        Label10.Text = tabla & "X9"
        Label11.Text = tabla & "X10"
        'Textboxes'
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = True
        TextBox8.Visible = True
        TextBox9.Visible = True
        TextBox10.Visible = True
        TextBox11.Visible = True
        'Buttons'
        Button1.Visible = True
        If TextBox1.Text = "" Then TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        'Visible'
        Button2.Visible = True
        Button1.Visible = True


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Location Label'
        Label1.Location = New Point(1113, 307)
        Label2.Location = New Point(1113, 307)
        Label3.Location = New Point(1113, 307)
        Label4.Location = New Point(1113, 307)
        Label5.Location = New Point(1113, 307)
        Label6.Location = New Point(1113, 307)
        Label7.Location = New Point(1113, 307)
        Label8.Location = New Point(1113, 307)
        Label9.Location = New Point(1113, 307)
        Label10.Location = New Point(1113, 307)
        Label11.Location = New Point(1113, 307)
        Label12.Location = New Point(1113, 307)
        Label13.Location = New Point(1113, 307)
        Label14.Location = New Point(1113, 307)
        Label15.Location = New Point(1113, 307)
        Label16.Location = New Point(1113, 307)
        Label17.Location = New Point(1113, 307)
        Label18.Location = New Point(1113, 307)
        Label19.Location = New Point(1113, 307)
        Label20.Location = New Point(1113, 307)
        Label21.Location = New Point(1113, 307)
        Label22.Location = New Point(1113, 307)
        'Textboxes'
        TextBox1.Location = New Point(1113, 307)
        TextBox2.Location = New Point(1113, 307)
        TextBox3.Location = New Point(1113, 307)
        TextBox4.Location = New Point(1113, 307)
        TextBox5.Location = New Point(1113, 307)
        TextBox6.Location = New Point(1113, 307)
        TextBox7.Location = New Point(1113, 307)
        TextBox8.Location = New Point(1113, 307)
        TextBox9.Location = New Point(1113, 307)
        TextBox10.Location = New Point(1113, 307)
        TextBox11.Location = New Point(1113, 307)
        'Buttons'
        Button2.Location = New Point(1113, 307)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then TextBox2.Text = "0"
        If TextBox2.Text = tabla * 1 Then Label13.Text = "Correcto" Else Label13.Text = "Incorrecto"
        If TextBox2.Text = tabla * 1 Then Label13.ForeColor = Color.Green Else Label13.ForeColor = Color.Red
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then TextBox3.Text = "0"
        If TextBox3.Text = tabla * 2 Then Label14.Text = "Correcto" Else Label14.Text = "Incorrecto"
        If TextBox3.Text = tabla * 2 Then Label14.ForeColor = Color.Green Else Label14.ForeColor = Color.Red
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then TextBox4.Text = "0"
        If TextBox4.Text = tabla * 3 Then Label15.Text = "Correcto" Else Label15.Text = "Incorrecto"
        If TextBox4.Text = tabla * 3 Then Label15.ForeColor = Color.Green Else Label15.ForeColor = Color.Red
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "" Then TextBox5.Text = "0"
        If TextBox5.Text = tabla * 4 Then Label16.Text = "Correcto" Else Label16.Text = "Incorrecto"
        If TextBox5.Text = tabla * 4 Then Label16.ForeColor = Color.Green Else Label16.ForeColor = Color.Red
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "" Then TextBox6.Text = "0"
        If TextBox6.Text = tabla * 5 Then Label17.Text = "Correcto" Else Label17.Text = "Incorrecto"
        If TextBox6.Text = tabla * 5 Then Label17.ForeColor = Color.Green Else Label17.ForeColor = Color.Red
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "" Then TextBox7.Text = "0"
        If TextBox7.Text = tabla * 6 Then Label18.Text = "Correcto" Else Label18.Text = "Incorrecto"
        If TextBox7.Text = tabla * 6 Then Label18.ForeColor = Color.Green Else Label18.ForeColor = Color.Red
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "" Then TextBox8.Text = "0"
        If TextBox8.Text = tabla * 7 Then Label19.Text = "Correcto" Else Label19.Text = "Incorrecto"
        If TextBox8.Text = tabla * 7 Then Label19.ForeColor = Color.Green Else Label19.ForeColor = Color.Red
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text = "" Then TextBox9.Text = "0"
        If TextBox9.Text = tabla * 8 Then Label20.Text = "Correcto" Else Label20.Text = "Incorrecto"
        If TextBox9.Text = tabla * 8 Then Label20.ForeColor = Color.Green Else Label20.ForeColor = Color.Red
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        If TextBox10.Text = "" Then TextBox3.Text = "0"
        If TextBox10.Text = tabla * 9 Then Label21.Text = "Correcto" Else Label21.Text = "Incorrecto"
        If TextBox10.Text = tabla * 9 Then Label21.ForeColor = Color.Green Else Label21.ForeColor = Color.Red
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        If TextBox11.Text = "" Then TextBox11.Text = "0"
        If TextBox11.Text = tabla * 10 Then Label22.Text = "Correcto" Else Label22.Text = "Incorrecto"
        If TextBox11.Text = tabla * 10 Then Label22.ForeColor = Color.Green Else Label22.ForeColor = Color.Red
    End Sub
End Class