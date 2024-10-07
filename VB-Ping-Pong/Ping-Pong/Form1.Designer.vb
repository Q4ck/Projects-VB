<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Paddle1 = New PictureBox()
        Paddle2 = New PictureBox()
        lblPlayer1Score = New Label()
        lblPlayer2Score = New Label()
        Ball = New PictureBox()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        lblTimeRemaining = New Label()
        btnPlayAgain = New Button()
        btnExit = New Button()
        PictureBox2 = New PictureBox()
        CType(Paddle1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Paddle2, ComponentModel.ISupportInitialize).BeginInit()
        CType(Ball, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Paddle1
        ' 
        Paddle1.BackColor = Color.Transparent
        Paddle1.BackgroundImage = CType(resources.GetObject("Paddle1.BackgroundImage"), Image)
        Paddle1.Location = New Point(26, 102)
        Paddle1.Name = "Paddle1"
        Paddle1.Size = New Size(101, 97)
        Paddle1.TabIndex = 0
        Paddle1.TabStop = False
        ' 
        ' Paddle2
        ' 
        Paddle2.BackColor = Color.Transparent
        Paddle2.BackgroundImage = CType(resources.GetObject("Paddle2.BackgroundImage"), Image)
        Paddle2.Location = New Point(691, 102)
        Paddle2.Name = "Paddle2"
        Paddle2.Size = New Size(104, 97)
        Paddle2.TabIndex = 1
        Paddle2.TabStop = False
        ' 
        ' lblPlayer1Score
        ' 
        lblPlayer1Score.AutoSize = True
        lblPlayer1Score.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlayer1Score.Location = New Point(85, 18)
        lblPlayer1Score.Name = "lblPlayer1Score"
        lblPlayer1Score.Size = New Size(27, 32)
        lblPlayer1Score.TabIndex = 4
        lblPlayer1Score.Text = "0"
        ' 
        ' lblPlayer2Score
        ' 
        lblPlayer2Score.AutoSize = True
        lblPlayer2Score.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlayer2Score.Location = New Point(652, 18)
        lblPlayer2Score.Name = "lblPlayer2Score"
        lblPlayer2Score.Size = New Size(27, 32)
        lblPlayer2Score.TabIndex = 5
        lblPlayer2Score.Text = "0"
        ' 
        ' Ball
        ' 
        Ball.BackColor = Color.Transparent
        Ball.BackgroundImage = CType(resources.GetObject("Ball.BackgroundImage"), Image)
        Ball.Location = New Point(368, 102)
        Ball.Name = "Ball"
        Ball.Size = New Size(109, 100)
        Ball.TabIndex = 6
        Ball.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 50
        ' 
        ' Timer2
        ' 
        Timer2.Interval = 1000
        ' 
        ' lblTimeRemaining
        ' 
        lblTimeRemaining.AutoSize = True
        lblTimeRemaining.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTimeRemaining.Location = New Point(393, 18)
        lblTimeRemaining.Name = "lblTimeRemaining"
        lblTimeRemaining.Size = New Size(0, 32)
        lblTimeRemaining.TabIndex = 7
        ' 
        ' btnPlayAgain
        ' 
        btnPlayAgain.Location = New Point(12, 406)
        btnPlayAgain.Name = "btnPlayAgain"
        btnPlayAgain.Size = New Size(171, 60)
        btnPlayAgain.TabIndex = 8
        btnPlayAgain.Text = "Jugar De Nuevo"
        btnPlayAgain.UseVisualStyleBackColor = True
        btnPlayAgain.Visible = False
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(638, 406)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(129, 60)
        btnExit.TabIndex = 9
        btnExit.Text = "Salir"
        btnExit.UseVisualStyleBackColor = True
        btnExit.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.Location = New Point(60, -187)
        PictureBox2.Margin = New Padding(4, 5, 4, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(843, 798)
        PictureBox2.TabIndex = 10
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(819, 598)
        Controls.Add(btnExit)
        Controls.Add(btnPlayAgain)
        Controls.Add(lblTimeRemaining)
        Controls.Add(Ball)
        Controls.Add(lblPlayer2Score)
        Controls.Add(lblPlayer1Score)
        Controls.Add(Paddle2)
        Controls.Add(Paddle1)
        Controls.Add(PictureBox2)
        KeyPreview = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(Paddle1, ComponentModel.ISupportInitialize).EndInit()
        CType(Paddle2, ComponentModel.ISupportInitialize).EndInit()
        CType(Ball, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Paddle1 As PictureBox
    Friend WithEvents Paddle2 As PictureBox
    Friend WithEvents Points1 As Label
    Friend WithEvents lblPlayer2Score As Label
    Friend WithEvents Ball As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblPlayer1Score As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblTimeRemaining As Label
    Friend WithEvents btnPlayAgain As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox

End Class
