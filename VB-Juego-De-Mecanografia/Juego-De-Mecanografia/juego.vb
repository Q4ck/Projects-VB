Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Public Class juego
    Private Sub juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub SetTimeLeftBasedOnDifficulty()
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Easy"



        End Select
    End Sub
End Class