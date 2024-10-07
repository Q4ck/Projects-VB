Public Class sistemas
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = "Incorrecto"
        PictureBox2.Visible = True
        Button2.Visible = False
        Button3.Visible = False


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label5.Text = "Correcto"
        PictureBox1.Visible = True
        Button1.Visible = False
        Button3.Visible = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label5.Text = "Incorrecto"
        PictureBox2.Visible = True
        Button1.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label6.Text = "Incorrecto"
        PictureBox4.Visible = True
        Button5.Visible = False
        Button6.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label6.Text = "Correcto"
        PictureBox3.Visible = True
        Button4.Visible = False
        Button6.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label6.Text = "Incorrecta"
        PictureBox4.Visible = True
        Button4.Visible = False
        Button5.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label7.Text = "Incorrecta"
        PictureBox6.Visible = True
        Button8.Visible = False
        Button9.Visible = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Label7.Text = "Correcta"
        PictureBox5.Visible = True
        Button7.Visible = False
        Button9.Visible = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Label7.Text = "Incorrecta"
        PictureBox6.Visible = True
        Button7.Visible = False
        Button8.Visible = False
    End Sub


End Class