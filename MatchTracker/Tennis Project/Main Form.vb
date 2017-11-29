

Public Class frmMain

    Private Sub btnMatch_Click(sender As Object, e As EventArgs) Handles btnMatch.Click

        'clear out previous names
        lblPlayer1.Text = String.Empty
        lblPlayer2.Text = String.Empty
        lblP1Stat.Text = String.Empty
        lblP2Stat.Text = String.Empty

        'get player 1 name
        strPlayer1 = InputBox("Player 1 name:")
        lblPlayer1.Text = strPlayer1
        lblP1Stat.Text = strPlayer1

        'get player 2 name
        strPlayer2 = InputBox("Player 2 name:")
        lblPlayer2.Text = strPlayer2
        lblP2Stat.Text = strPlayer2

        'reset score to 0-0 in first set
        lblP1S1.Text = "0"
        lblP2S1.Text = "0"
        intCurrentSet = 1
        intP1TotalPoints = 0
        intP2TotalPoints = 0
        lblP1Stat1.Text = "0"
        lblP2Stat1.Text = "0"
        'clear out previous scores
        lblP1S2.Text = String.Empty
        lblP1S3.Text = String.Empty

        lblP2S2.Text = String.Empty
        lblP2S3.Text = String.Empty

        'reset score tracker
        intP1S1Score = 0
        intP1S2Score = 0
        intP1S3Score = 0

        intP2S1Score = 0
        intP2S2Score = 0
        intP2S3Score = 0

        'reset stats trackers
        intP1Winners = 0
        lblP1Stat2.Text = "0"

        intP2Winners = 0
        lblP2Stat2.Text = "0"

        intP1Errors = 0
        lblP1Stat3.Text = "0"

        intP2Errors = 0
        lblP2Stat3.Text = "0"

        intP1Aces = 0
        intP2Aces = 0

        intP1Double = 0
        intP2Double = 0

        intP1FirstServe = 0
        intP1SecondServe = 0

        intP2FirstServe = 0
        intP2SecondServe = 0

        intP1Serves = 0
        intP2Serves = 0

    End Sub

    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        frmGame.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        intCurrentSet = 1
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        intCurrentSet = intCurrentSet + 1
        If lblP1S2.Text = String.Empty Then
            intP1S2Score = 0
            intP2S2Score = 0

            lblP1S2.Text = intP1S2Score.ToString()
            lblP2S2.Text = intP2S2Score.ToString()
        ElseIf lblP1S3.Text = String.Empty Then
            intP1S3Score = 0
            intP2S3Score = 0

            lblP1S3.Text = intP1S3Score.ToString()
            lblP2S3.Text = intP2S3Score.ToString()
        End If
    End Sub

    Private Sub lblP2Stat_Click(sender As Object, e As EventArgs) Handles lblP2Stat.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmStat.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class
