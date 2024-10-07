Public Class Inicio
    Private Sub btnStartGame_Click(sender As Object, e As EventArgs) Handles btnStartGame.Click
        ' Obtener los nombres de los jugadores
        Dim player1Name As String = txtPlayer1Name.Text.Trim()
        Dim player2Name As String = txtPlayer2Name.Text.Trim()

        ' Validar que los nombres no estén en blanco
        If player1Name = "" Then
            MessageBox.Show("Porfavor Ingrese Un Nombre A Player 1.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPlayer1Name.Focus()
            Exit Sub
        End If

        If player2Name = "" Then
            MessageBox.Show("Porfavor Ingrese Un Nombre A Player 2.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPlayer2Name.Focus()
            Exit Sub
        End If

        ' Crear una instancia del formulario del juego y pasar los nombres de los jugadores
        Dim gameForm As New Form1
        gameForm.Player1Name = player1Name
        gameForm.Player2Name = player2Name

        ' Mostrar el formulario del juego y ocultar el formulario de inicio
        gameForm.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class

