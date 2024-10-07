<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class temas
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
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(208, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 74)
        Label1.TabIndex = 0
        Label1.Text = "Elige Temas"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(169, 169)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 64)
        Button1.TabIndex = 1
        Button1.Text = "Sistemas"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(407, 169)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 64)
        Button2.TabIndex = 2
        Button2.Text = "Biologia"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(169, 287)
        Button3.Name = "Button3"
        Button3.Size = New Size(139, 64)
        Button3.TabIndex = 3
        Button3.Text = "Castellano "
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(407, 287)
        Button4.Name = "Button4"
        Button4.Size = New Size(139, 64)
        Button4.TabIndex = 4
        Button4.Text = "Matematicas"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' temas
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "temas"
        StartPosition = FormStartPosition.CenterScreen
        Text = "temas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
