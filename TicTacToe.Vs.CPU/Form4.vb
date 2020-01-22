Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        If TurnText.Text = "Player1" Then
            A1.Text = "X"
            TurnText.Text = "Player2"
            A1.Enabled = False
        ElseIf TurnText.Text = "Player2" Then
            A1.Text = "O"
            TurnText.Text = "Player1"
            A1.Enabled = False
        End If
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        If TurnText.Text = "Player1" Then
            A2.Text = "X"
            TurnText.Text = "Player2"
            A2.Enabled = False
        ElseIf TurnText.Text = "Player2" Then
            A2.Text = "O"
            TurnText.Text = "Player1"
            A2.Enabled = False
        End If
    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
        If TurnText.Text = "Player1" Then
            A3.Text = "X"
            TurnText.Text = "Player2"
            A3.Enabled = False
        ElseIf TurnText.Text = "Player2" Then
            A3.Text = "O"
            TurnText.Text = "Player1"
            A3.Enabled = False
        End If
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        If TurnText.Text = "Player1" Then
            B1.Text = "X"
            TurnText.Text = "Player2"
            B1.Enabled = False
        ElseIf TurnText.Text = "Player2" Then
            B1.Text = "O"
            TurnText.Text = "Player1"
            B1.Enabled = False
        End If
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        If TurnText.Text = "Player1" Then
            B2.Text = "X"
            TurnText.Text = "Player2"
            B2.Enabled = False
        ElseIf TurnText.Text = "Player2" Then
            B2.Text = "O"
            TurnText.Text = "Player1"
            B2.Enabled = False
        End If
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If TurnText.Text = "Player1" Then
            B3.Text = "X"
            TurnText.Text = "Player2"
            B3.Enabled = False
        ElseIf TurnText.Text = "Player2" Then
            B3.Text = "O"
            TurnText.Text = "Player1"
            B3.Enabled = False
        End If
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        If TurnText.Text = "Player1" Then
            C1.Text = "X"
            TurnText.Text = "Player2"
            C1.Enabled = False
        ElseIf TurnText.Text = "Player2" Then
            C1.Text = "O"
            TurnText.Text = "Player1"
            C1.Enabled = False
        End If
    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        If TurnText.Text = "Player1" Then
            C2.Text = "X"
            TurnText.Text = "Player2"
            C2.Enabled = False
        ElseIf TurnText.Text = "Player2" Then
            C2.Text = "O"
            TurnText.Text = "Player1"
            C2.Enabled = False
        End If
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        If TurnText.Text = "Player1" Then
            C3.Text = "X"
            TurnText.Text = "Player2"
            C3.Enabled = False
        ElseIf TurnText.Text = "Player2" Then
            C3.Text = "O"
            TurnText.Text = "Player1"
            C3.Enabled = False
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TICTACTOEMECHANICS.Enabled = True
        My.Computer.Audio.Play("C:\Users\Chavez\Downloads\MUSICS FOR PROGRAMMING\WAV\Elevator Music - Vanoss Gaming Background Music (HD).wav")
    End Sub

    Private Sub TICTACTOEMECHANICS_Tick(sender As Object, e As EventArgs) Handles TICTACTOEMECHANICS.Tick
        If A1.Text = "X" And A2.Text = "X" And A3.Text = "X" Then
            Form3.Label1.Text = "Player1 Win"
            Form3.Show()
            Me.Close()
        ElseIf A1.Text = "O" And A2.Text = "O" And A3.Text = "O" Then
            Form3.Label1.Text = "Player2 Win"
            Form3.Show()
            Me.Close()
        End If
        If B1.Text = "X" And B2.Text = "X" And B3.Text = "X" Then
            Form3.Label1.Text = "Player1 Win"
            Form3.Show()
            Me.Close()
        ElseIf B1.Text = "O" And B2.Text = "O" And B3.Text = "O" Then
            Form3.Label1.Text = "Player2 Win"
            Form3.Show()
            Me.Close()
        End If
        If C1.Text = "X" And C2.Text = "X" And C3.Text = "X" Then
            Form3.Label1.Text = "Player1 Win"
            Form3.Show()
            Me.Close()
        ElseIf C1.Text = "O" And C2.Text = "O" And C3.Text = "O" Then
            Form3.Label1.Text = "Player2 Win"
            Form3.Show()
            Me.Close()
        End If
        If A1.Text = "X" And B1.Text = "X" And C1.Text = "X" Then
            Form3.Label1.Text = "Player1 Win"
            Form3.Show()
            Me.Close()
        ElseIf A1.Text = "O" And B1.Text = "O" And C1.Text = "O" Then
            Form3.Label1.Text = "Player2 Win"
            Form3.Show()
            Me.Close()
        End If
        If A2.Text = "X" And B2.Text = "X" And C2.Text = "X" Then
            Form3.Label1.Text = "Player1 Win"
            Form3.Show()
            Me.Close()
        ElseIf A2.Text = "O" And B2.Text = "O" And C2.Text = "O" Then
            Form3.Label1.Text = "Player2 Win"
            Form3.Show()
            Me.Close()
        End If
        If A1.Text = "X" And B1.Text = "X" And C1.Text = "X" Then
            Form3.Label1.Text = "Player1 Win"
            Form3.Show()
            Me.Close()
        ElseIf A3.Text = "O" And B3.Text = "O" And C3.Text = "O" Then
            Form3.Label1.Text = "Player2 Win"
            Form3.Show()
            Me.Close()
        End If
        If A1.Text = "X" And B2.Text = "X" And C3.Text = "X" Then
            Form3.Label1.Text = "Player1 Win"
            Form3.Show()
            Me.Close()
        ElseIf A1.Text = "O" And B2.Text = "O" And C3.Text = "O" Then
            Form3.Label1.Text = "Player2 Win"
            Form3.Show()
            Me.Close()
        End If
        If A3.Text = "X" And B2.Text = "X" And C1.Text = "X" Then
            Form3.Label1.Text = "Player1 Win"
            Form3.Show()
            Me.Close()
        ElseIf A3.Text = "O" And B2.Text = "O" And C1.Text = "O" Then
            Form3.Label1.Text = "Player2 Win"
            Form3.Show()
            Me.Close()
        End If
    End Sub
End Class