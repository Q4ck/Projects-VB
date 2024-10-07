<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        txtPlayer1Name = New TextBox()
        txtPlayer2Name = New TextBox()
        btnStartGame = New Button()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtPlayer1Name
        ' 
        txtPlayer1Name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPlayer1Name.Location = New Point(31, 369)
        txtPlayer1Name.Name = "txtPlayer1Name"
        txtPlayer1Name.Size = New Size(193, 39)
        txtPlayer1Name.TabIndex = 0
        ' 
        ' txtPlayer2Name
        ' 
        txtPlayer2Name.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPlayer2Name.Location = New Point(546, 369)
        txtPlayer2Name.Name = "txtPlayer2Name"
        txtPlayer2Name.Size = New Size(193, 39)
        txtPlayer2Name.TabIndex = 1
        ' 
        ' btnStartGame
        ' 
        btnStartGame.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnStartGame.Location = New Point(315, 456)
        btnStartGame.Name = "btnStartGame"
        btnStartGame.Size = New Size(169, 81)
        btnStartGame.TabIndex = 2
        btnStartGame.Text = "Play"
        btnStartGame.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(546, 311)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 32)
        Label1.TabIndex = 3
        Label1.Text = "Nombre Player 2"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(31, 311)
        Label2.Name = "Label2"
        Label2.Size = New Size(193, 32)
        Label2.TabIndex = 4
        Label2.Text = "Nombre Player 1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(-371, -355)
        PictureBox1.Margin = New Padding(4, 5, 4, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(2346, 1142)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(31, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(964, 96)
        Label3.TabIndex = 6
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(833, 620)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnStartGame)
        Controls.Add(txtPlayer2Name)
        Controls.Add(txtPlayer1Name)
        Controls.Add(PictureBox1)
        Name = "Inicio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inicio"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPlayer1Name As TextBox
    Friend WithEvents txtPlayer2Name As TextBox
    Friend WithEvents btnStartGame As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
End Class
