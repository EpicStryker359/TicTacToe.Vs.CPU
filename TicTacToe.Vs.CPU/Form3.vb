Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Label1.Text = "Player1 Win" Then

        End If
        If Label1.Text = "Player2 Win" Then

        End If
        If Label1.Text = "CPU Win" Then
            My.Computer.Audio.Play("C:\Users\Chavez\Downloads\MUSICS FOR PROGRAMMING\WAV\You lose! Demonic voice - Sound FX.wav")
        End If
        If Label1.Text = "You Win" Then
            My.Computer.Audio.Play("C:\Users\Chavez\Downloads\MUSICS FOR PROGRAMMING\WAV\You win! Demonic Voice - Sound FX.wav")
        End If
    End Sub
End Class