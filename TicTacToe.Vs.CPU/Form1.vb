Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles quit.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Play.Click
        tct.Hide()
        gm.Show()
        Play.Hide()
        quit.Hide()
        Versus.Show()
        ai.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tct.Show()
        wgf.Hide()
        gm.Hide()
        Play.Show()
        quit.Show()
        Player.Hide()
        CPU.Hide()
        ai.Hide()
        Versus.Hide()
        Player1.Hide()
        Player2.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Player.Click
        Form2.TurnText.Text = "Player1"
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles CPU.Click
        Form2.TurnText.Text = "CPU"
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Versus.Click
        gm.Hide()
        wgf.Show()
        Versus.Hide()
        ai.Hide()
        Player1.Show()
        Player2.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ai.Click
        gm.Hide()
        wgf.Show()
        Versus.Hide()
        ai.Hide()
        Player.Show()
        CPU.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Player1.Click
        Form4.TurnText.Text = "Player1"
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Player2.Click
        Form4.TurnText.Text = "Player2"
        Form4.Show()
        Me.Close()
    End Sub
End Class
