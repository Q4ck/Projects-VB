Public Class Form1
    ' Variables para el movimiento de la pelota y las paletas
    Dim ballXSpeed As Integer = 5
    Dim ballYSpeed As Integer = 5
    Dim playerSpeed As Integer = 10

    ' Variables de puntaje
    Dim player1Score As Integer = 0
    Dim player2Score As Integer = 0

    ' Variables para el temporizador del juego
    Dim gameDuration As Integer = 8 * 60 ' 8 minutos en segundos
    Dim elapsedTime As Integer = 0

    ' Propiedades para los nombres de los jugadores
    Public Property Player1Name As String
    Public Property Player2Name As String

    ' Inicializar el juego
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Timer1.Interval = 50
        Timer1.Start()
        Timer2.Interval = 1000 ' 1 segundo
        Timer2.Start()
        UpdateScoreLabels()
        UpdateTimeLabel()
        btnPlayAgain.Visible = False
        btnExit.Visible = False

        ' Mostrar los nombres de los jugadores en las etiquetas de puntaje
        lblPlayer1Score.Text = Player1Name & ": 0"
        lblPlayer2Score.Text = Player2Name & ": 0"
    End Sub

    ' Controlar el movimiento de la pelota
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Mover la pelota
        Ball.Left += ballXSpeed
        Ball.Top += ballYSpeed

        ' Rebotar en los bordes superior e inferior
        If Ball.Top <= 0 Or Ball.Bottom >= ClientSize.Height Then
            ballYSpeed = -ballYSpeed
        End If

        ' Rebotar en las paletas
        If Ball.Bounds.IntersectsWith(Paddle1.Bounds) Or Ball.Bounds.IntersectsWith(Paddle2.Bounds) Then
            ballXSpeed = -ballXSpeed
        End If

        ' Actualizar puntaje y reiniciar la pelota si sale del área de juego
        If Ball.Left <= 0 Then
            player2Score += 1
            UpdateScoreLabels()
            ResetBall()
            CheckForWinner()
        ElseIf Ball.Right >= ClientSize.Width Then
            player1Score += 1
            UpdateScoreLabels()
            ResetBall()
            CheckForWinner()
        End If
    End Sub

    ' Controlar el temporizador del juego
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        elapsedTime += 1
        UpdateTimeLabel()
        If elapsedTime >= gameDuration Then
            EndGame("Time's up!")
        End If
    End Sub

    ' Controlar el movimiento de las paletas
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Mover la paleta 1 con W y S
        If e.KeyCode = Keys.W And Paddle1.Top > 0 Then
            Paddle1.Top -= playerSpeed
        ElseIf e.KeyCode = Keys.S And Paddle1.Bottom < ClientSize.Height Then
            Paddle1.Top += playerSpeed
        End If

        ' Mover la paleta 2 con las flechas arriba y abajo
        If e.KeyCode = Keys.Up And Paddle2.Top > 0 Then
            Paddle2.Top -= playerSpeed
        ElseIf e.KeyCode = Keys.Down And Paddle2.Bottom < ClientSize.Height Then
            Paddle2.Top += playerSpeed
        End If
    End Sub

    ' Actualizar etiquetas de puntaje
    Private Sub UpdateScoreLabels()
        lblPlayer1Score.Text = Player1Name & ": " & player1Score.ToString()
        lblPlayer2Score.Text = Player2Name & ": " & player2Score.ToString()
    End Sub

    ' Actualizar etiqueta de tiempo
    Private Sub UpdateTimeLabel()
        Dim remainingTime As Integer = gameDuration - elapsedTime
        Dim minutes As Integer = remainingTime \ 60
        Dim seconds As Integer = remainingTime Mod 60
        lblTimeRemaining.Text = String.Format("Tiempo: {0:D2}:{1:D2}", minutes, seconds)
    End Sub

    ' Reiniciar la posición de la pelota
    Private Sub ResetBall()
        Ball.Left = ClientSize.Width / 2
        Ball.Top = ClientSize.Height / 2
        ' Cambiar la dirección de la pelota al reiniciarla
        ballXSpeed = -ballXSpeed
    End Sub

    ' Comprobar si hay un ganador
    Private Sub CheckForWinner()
        If player1Score >= 10 Then
            EndGame(Player1Name & " Gano!")
        ElseIf player2Score >= 10 Then
            EndGame(Player2Name & " Gano!")
        End If
    End Sub

    ' Terminar el juego
    Private Sub EndGame(message As String)
        Timer1.Stop()
        Timer2.Stop()
        MessageBox.Show(message)
        btnPlayAgain.Visible = True
        btnExit.Visible = True
    End Sub

    ' Reiniciar el juego
    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        player1Score = 0
        player2Score = 0
        elapsedTime = 0
        UpdateScoreLabels()
        UpdateTimeLabel()
        btnPlayAgain.Visible = False
        btnExit.Visible = False
        Timer1.Start()
        Timer2.Start()
    End Sub

    ' Salir del juego
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

End Class





