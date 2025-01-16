Public Class Form1

    Private elapsedTime As Integer = 0  ' Track elapsed time
    Private currentColorName As String
    Private score As Integer = 0  ' Initialize score
    Private lives As Integer = 3  ' Initialize lives
    Private attemptCount As Integer = 0  ' Track the number of attempts

    ' List to store all final scores
    Private finalScores As New List(Of Integer)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowStartPage()  ' Show the Start Page when the form loads
        InitializeLives()  ' Initialize lives at the start

        ' Add columns to the DataGridView if they aren't already there
        If DataGridView1.Columns.Count = 0 Then
            DataGridView1.Columns.Add("Attempt", "Attempt")
            DataGridView1.Columns.Add("Score", "Score")
        End If
    End Sub

    ' Declare the color dictionary at the class level
    Private ReadOnly colors As New Dictionary(Of String, Color) From {
        {"white", Color.White}, {"yellow", Color.Yellow}, {"green", Color.Green},
        {"purple", Color.Purple}, {"blue", Color.Blue}, {"red", Color.Red},
        {"gray", Color.Gray}, {"black", Color.Black}, {"orange", Color.Orange},
        {"brown", Color.Brown}
    }

    ' Initialize lives - Show all lives at the start
    Private Sub InitializeLives()
        life1.Visible = True
        life2.Visible = True
        life3.Visible = True
        lives = 3  ' Reset lives to 3 at the start of the game
    End Sub

    ' Generates a random color and updates the panel
    Private Sub GenerateRandomColor()
        Dim rand As New Random()
        Dim colorNames = colors.Keys.ToList()
        currentColorName = colorNames(rand.Next(colorNames.Count))
        color_panel.BackColor = colors(currentColorName)
        color_panel.Refresh() ' Ensure the panel updates visually
    End Sub

    ' Updates the score display
    Private Sub UpdateScore(points As Integer)
        score += points
        score_label.Text = $"{score}"  ' Update the score label inside the score_panel
    End Sub

    ' Show the Start Page
    Private Sub ShowStartPage()
        startPanel.Visible = True  ' Show the start panel
    End Sub

    ' Start Button Click Event
    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        startPanel.Visible = False  ' Hide the start page
        StartGame()
    End Sub

    ' Start the Game Logic
    Private Sub StartGame()
        elapsedTime = 0  ' Reset the timer
        gameTimer.Start()  ' Start the timer
        GenerateRandomColor() ' Start with a random color
    End Sub

    ' Button Click Event for All Color Buttons
    Private Sub ColorButton_Click(sender As Object, e As EventArgs) _
    Handles white_btn.Click, yellow_btn.Click, green_btn.Click, purple_btn.Click, blue_btn.Click, red_btn.Click, gray_btn.Click, black_btn.Click, orange_btn.Click, brown_btn.Click

        Dim clickedButton = CType(sender, Button)

        ' Compare the button's text with the generated color name
        If clickedButton.Text = currentColorName Then
            MessageBox.Show("Correct!")
            GenerateRandomColor() ' Show next color
            UpdateScore(1) ' Increase score
        Else
            MessageBox.Show("Wrong! Try Again.")
            UpdateScore(-1) ' Optionally decrease score
            DecreaseLife()  ' Decrease a life on mistake
        End If
    End Sub

    ' Decrease a life and update the UI
    Private Sub DecreaseLife()
        lives -= 1

        ' Hide the appropriate PictureBox for the lost life
        Select Case lives
            Case 2
                life3.Visible = False
            Case 1
                life2.Visible = False
            Case 0
                life1.Visible = False
                EndGame() ' End game if no lives left
        End Select
    End Sub

    ' End the Game
    Private Sub EndGame()
        gameTimer.Stop()  ' Stop the timer
        finalScores.Add(score)  ' Add current score to the finalScores list
        attemptCount += 1  ' Increment the attempt count after each game
        MessageBox.Show($"Game Over! Final Score: {score}")
        score_label.Text = $"{score}"  ' Display final score inside the score panel
        DisplayAllScores()  ' Display all previous scores in the DataGridView

        ' Disable the color buttons after the game ends
        DisableColorButtons()
    End Sub

    ' Disable all color buttons
    Private Sub DisableColorButtons()
        white_btn.Enabled = False
        yellow_btn.Enabled = False
        green_btn.Enabled = False
        purple_btn.Enabled = False
        blue_btn.Enabled = False
        red_btn.Enabled = False
        gray_btn.Enabled = False
        black_btn.Enabled = False
        orange_btn.Enabled = False
        brown_btn.Enabled = False
    End Sub
    ' Timer Tick Event
    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        elapsedTime += 1  ' Increment elapsed time by 1 second

        ' Format time as MM:SS
        Dim minutes As Integer = elapsedTime \ 60
        Dim seconds As Integer = elapsedTime Mod 60
        timer_label.Text = $"{minutes:D2}:{seconds:D2}"
    End Sub

    ' Restart Button Click Event
    Private Sub restart_btn_Click(sender As Object, e As EventArgs) Handles restart_btn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to restart?", "Confirm Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Reset score and lives
            score = 0
            lives = 3
            attemptCount += 1  ' Increment attempt count on restart

            ' Reset the score label
            score_label.Text = $"Score: {score}"

            ' Reset the timer
            elapsedTime = 0
            timer_label.Text = "00:00"  ' Set the timer label to "00:00"

            ' Re-initialize the lives (show all lives again)
            InitializeLives()

            ' Restart the timer
            gameTimer.Start()

            ' Start the game with a new random color
            GenerateRandomColor()
            ' Enable the color buttons again when restarting the game
            EnableColorButtons()
        End If
    End Sub
    ' Enable all color buttons
    Private Sub EnableColorButtons()
        white_btn.Enabled = True
        yellow_btn.Enabled = True
        green_btn.Enabled = True
        purple_btn.Enabled = True
        blue_btn.Enabled = True
        red_btn.Enabled = True
        gray_btn.Enabled = True
        black_btn.Enabled = True
        orange_btn.Enabled = True
        brown_btn.Enabled = True
    End Sub

    ' Exit Button Click Event
    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        ' Display a confirmation dialog to the user
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' If the user clicks "Yes", close the application
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' Display All Final Scores in DataGridView
    Private Sub DisplayAllScores()
        ' Clear any existing rows in the DataGridView
        DataGridView1.Rows.Clear()

        ' Display each score from finalScores list in the DataGridView
        For i As Integer = 0 To finalScores.Count - 1
            DataGridView1.Rows.Add(i + 1, finalScores(i))  ' Add a new row with Attempt number and Score
        Next
    End Sub
End Class
