Option Strict On
Public Class Form1

    Dim intComputerGuess As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'fill computer guess with a random number
        'if correct make a new random number
        ' Initialize the random-number generator.
        Randomize()
        intComputerGuess = CInt(Rnd() * 101)
        MsgBox(intComputerGuess)

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        'check that the number user guess is correct or not
        'use 3 if statements to display corrrect label
        'if correct make a new random number
        Dim intUserGuess As Integer
        If Integer.TryParse(txtbxGuessNumber.Text, intUserGuess) Then
            MsgBox("you entered: " + intUserGuess.ToString)      'can change + with &
        Else
            MsgBox("please enter a valid number!!!")
        End If

        If intUserGuess = intComputerGuess Then
            lblResult.Text = "Congratulations! You got it"
        End If

        If intUserGuess > intComputerGuess Then
            lblResult.Text = "HIGH"
        End If

        If intUserGuess < intComputerGuess Then
            lblResult.Text = "LOW"
        End If

        If intUserGuess < 0 Or intUserGuess > 100 Then
            lblResult.Text = "Please enter 0 to 100"
        End If


    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click

        Controls.Clear()
        InitializeComponent()

    End Sub
End Class
