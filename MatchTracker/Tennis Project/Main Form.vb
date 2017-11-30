

Public Class frmMain

    Private Sub btnMatch_Click(sender As Object, e As EventArgs) Handles mnuNewMatch.Click

        Start_Screen.Show()
        Me.Hide()

    End Sub

    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        frmGame.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles mnuStats.Click
        frmStat.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub frmMain_Closed(sender As Object, e As EventArgs) Handles Me.Closing
        Start_Screen.Close()
    End Sub
End Class
