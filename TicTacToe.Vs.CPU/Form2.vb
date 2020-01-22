Public Class Form2
    Dim generator As New Random
    Dim p1 As Boolean
    Dim cpu As Boolean
    Dim AI As Integer

    Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
        If TurnText.Text = "Player1" Then
            A1.Text = "X"
            TurnText.Text = "CPU"
            A1.Enabled = False
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TicMechancis.Enabled = True
        TacMechanics.Enabled = True
        ToeMech.Enabled = True
        My.Computer.Audio.Play("C:\Users\Chavez\Downloads\MUSICS FOR PROGRAMMING\WAV\Elevator Music - Vanoss Gaming Background Music (HD).wav")
    End Sub

    Private Sub TicMechancis_Tick(sender As Object, e As EventArgs) Handles TicMechancis.Tick
        If A1.Text = String.Empty And AI = 1 Then
            A1.Text = "O"
            TurnText.Text = "Player1"
            A1.Enabled = False
        End If
        If A2.Text = String.Empty And AI = 2 Then
            A2.Text = "O"
            TurnText.Text = "Player1"
            A2.Enabled = False
        End If
        If A3.Text = String.Empty And AI = 3 Then
            A3.Text = "O"
            TurnText.Text = "Player1"
            A3.Enabled = False
        End If
        If B1.Text = String.Empty And AI = 4 Then
            B1.Text = "O"
            TurnText.Text = "Player1"
            B1.Enabled = False
        End If
        If B2.Text = String.Empty And AI = 5 Then
            B2.Text = "O"
            TurnText.Text = "Player1"
            B2.Enabled = False
        End If
        If B3.Text = String.Empty And AI = 6 Then
            B3.Text = "O"
            TurnText.Text = "Player1"
            B3.Enabled = False
        End If
        If C1.Text = String.Empty And AI = 7 Then
            C1.Text = "O"
            TurnText.Text = "Player1"
            C1.Enabled = False
        End If
        If C2.Text = String.Empty And AI = 8 Then
            C2.Text = "O"
            TurnText.Text = "Player1"
            C2.Enabled = False
        End If
        If C3.Text = String.Empty And AI = 9 Then
            C3.Text = "O"
            TurnText.Text = "Player1"
            C3.Enabled = False
        End If
    End Sub

    Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
        If TurnText.Text = "Player1" Then
            A2.Text = "X"
            TurnText.Text = "CPU"
            A2.Enabled = False
        End If
    End Sub

    Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
        If TurnText.Text = "Player1" Then
            A3.Text = "X"
            TurnText.Text = "CPU"
            A3.Enabled = False
        End If
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        If TurnText.Text = "Player1" Then
            B1.Text = "X"
            TurnText.Text = "CPU"
            B1.Enabled = False
        End If
    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
        If TurnText.Text = "Player1" Then
            B2.Text = "X"
            TurnText.Text = "CPU"
            B2.Enabled = False
        End If
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
        If TurnText.Text = "Player1" Then
            B3.Text = "X"
            TurnText.Text = "CPU"
            B3.Enabled = False
        End If
    End Sub

    Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
        If TurnText.Text = "Player1" Then
            C1.Text = "X"
            TurnText.Text = "CPU"
            C1.Enabled = False
        End If
    End Sub

    Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
        If TurnText.Text = "Player1" Then
            C2.Text = "X"
            TurnText.Text = "CPU"
            C2.Enabled = False
        End If
    End Sub

    Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
        If TurnText.Text = "Player1" Then
            C3.Text = "X"
            TurnText.Text = "CPU"
            C3.Enabled = False
        End If
    End Sub

    Private Sub TacMechanics_Tick(sender As Object, e As EventArgs) Handles TacMechanics.Tick
        If A1.Text = "X" And A2.Text = "X" And A3.Text = "X" Then
            Form3.Label1.Text = "You Win"
            Form3.Show()
            Me.Close()
        ElseIf A1.Text = "O" And A2.Text = "O" And A3.Text = "O" Then
            Form3.Label1.Text = "CPU Win"
            Form3.Show()
            Me.Close()
        End If
        If B1.Text = "X" And B2.Text = "X" And B3.Text = "X" Then
            Form3.Label1.Text = "You Win"
            Form3.Show()
            Me.Close()
        ElseIf B1.Text = "O" And B2.Text = "O" And B3.Text = "O" Then
            Form3.Label1.Text = "CPU Win"
            Form3.Show()
            Me.Close()
        End If
        If C1.Text = "X" And C2.Text = "X" And C3.Text = "X" Then
            Form3.Label1.Text = "You Win"
            Form3.Show()
            Me.Close()
        ElseIf C1.Text = "O" And C2.Text = "O" And C3.Text = "O" Then
            Form3.Label1.Text = "CPU Win"
            Form3.Show()
            Me.Close()
        End If
        If A1.Text = "X" And B1.Text = "X" And C1.Text = "X" Then
            Form3.Label1.Text = "You Win"
            Form3.Show()
            Me.Close()
        ElseIf A1.Text = "O" And B1.Text = "O" And C1.Text = "O" Then
            Form3.Label1.Text = "CPU Win"
            Form3.Show()
            Me.Close()
        End If
        If A2.Text = "X" And B2.Text = "X" And C2.Text = "X" Then
            Form3.Label1.Text = "You Win"
            Form3.Show()
            Me.Close()
        ElseIf A2.Text = "O" And B2.Text = "O" And C2.Text = "O" Then
            Form3.Label1.Text = "CPU Win"
            Form3.Show()
            Me.Close()
        End If
        If A3.Text = "X" And B3.Text = "X" And C3.Text = "X" Then
            Form3.Label1.Text = "You Win"
            Form3.Show()
            Me.Close()
        ElseIf A3.Text = "O" And B3.Text = "O" And C3.Text = "O" Then
            Form3.Label1.Text = "CPU Win"
            Form3.Show()
            Me.Close()
        End If
        If A1.Text = "X" And B2.Text = "X" And C3.Text = "X" Then
            Form3.Label1.Text = "You Win"
            Form3.Show()
            Me.Close()
        ElseIf A1.Text = "O" And B2.Text = "O" And C3.Text = "O" Then
            Form3.Label1.Text = "CPU Win"
            Form3.Show()
            Me.Close()
        End If
        If A3.Text = "X" And B2.Text = "X" And C1.Text = "X" Then
            Form3.Label1.Text = "You Win"
            Form3.Show()
            Me.Close()
        ElseIf A3.Text = "O" And B2.Text = "O" And C1.Text = "O" Then
            Form3.Label1.Text = "CPU Win"
            Form3.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ToeMech_Tick(sender As Object, e As EventArgs) Handles ToeMech.Tick
        If TurnText.Text = "CPU" Then
            AI = generator.Next(1, 9)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class