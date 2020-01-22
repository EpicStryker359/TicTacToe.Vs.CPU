<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tct = New System.Windows.Forms.Label()
        Me.Play = New System.Windows.Forms.Button()
        Me.quit = New System.Windows.Forms.Button()
        Me.Player = New System.Windows.Forms.Button()
        Me.CPU = New System.Windows.Forms.Button()
        Me.wgf = New System.Windows.Forms.Label()
        Me.ai = New System.Windows.Forms.Button()
        Me.Versus = New System.Windows.Forms.Button()
        Me.gm = New System.Windows.Forms.Label()
        Me.Player2 = New System.Windows.Forms.Button()
        Me.Player1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tct
        '
        Me.tct.AutoSize = True
        Me.tct.Font = New System.Drawing.Font("Gotham Bold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tct.Location = New System.Drawing.Point(2, 9)
        Me.tct.Name = "tct"
        Me.tct.Size = New System.Drawing.Size(274, 54)
        Me.tct.TabIndex = 0
        Me.tct.Text = "TicTacToe"
        '
        'Play
        '
        Me.Play.BackColor = System.Drawing.Color.LightCoral
        Me.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Play.Font = New System.Drawing.Font("Gotham", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play.Location = New System.Drawing.Point(52, 66)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(158, 53)
        Me.Play.TabIndex = 1
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = False
        '
        'quit
        '
        Me.quit.BackColor = System.Drawing.Color.LightCoral
        Me.quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.quit.Font = New System.Drawing.Font("Gotham", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quit.Location = New System.Drawing.Point(52, 125)
        Me.quit.Name = "quit"
        Me.quit.Size = New System.Drawing.Size(158, 53)
        Me.quit.TabIndex = 2
        Me.quit.Text = "Exit"
        Me.quit.UseVisualStyleBackColor = False
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.LightCoral
        Me.Player.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Player.Font = New System.Drawing.Font("Gotham", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player.Location = New System.Drawing.Point(52, 66)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(158, 53)
        Me.Player.TabIndex = 3
        Me.Player.Text = "Player"
        Me.Player.UseVisualStyleBackColor = False
        '
        'CPU
        '
        Me.CPU.BackColor = System.Drawing.Color.LightCoral
        Me.CPU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CPU.Font = New System.Drawing.Font("Gotham", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPU.Location = New System.Drawing.Point(52, 125)
        Me.CPU.Name = "CPU"
        Me.CPU.Size = New System.Drawing.Size(158, 53)
        Me.CPU.TabIndex = 4
        Me.CPU.Text = "CPU"
        Me.CPU.UseVisualStyleBackColor = False
        '
        'wgf
        '
        Me.wgf.AutoSize = True
        Me.wgf.Font = New System.Drawing.Font("Gotham Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wgf.Location = New System.Drawing.Point(9, 21)
        Me.wgf.Name = "wgf"
        Me.wgf.Size = New System.Drawing.Size(267, 36)
        Me.wgf.TabIndex = 5
        Me.wgf.Text = "Who Goes First"
        '
        'ai
        '
        Me.ai.BackColor = System.Drawing.Color.LightCoral
        Me.ai.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ai.Font = New System.Drawing.Font("Gotham", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ai.Location = New System.Drawing.Point(52, 125)
        Me.ai.Name = "ai"
        Me.ai.Size = New System.Drawing.Size(158, 53)
        Me.ai.TabIndex = 7
        Me.ai.Text = "AI"
        Me.ai.UseVisualStyleBackColor = False
        '
        'Versus
        '
        Me.Versus.BackColor = System.Drawing.Color.LightCoral
        Me.Versus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Versus.Font = New System.Drawing.Font("Gotham", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Versus.Location = New System.Drawing.Point(52, 66)
        Me.Versus.Name = "Versus"
        Me.Versus.Size = New System.Drawing.Size(158, 53)
        Me.Versus.TabIndex = 6
        Me.Versus.Text = "Versus"
        Me.Versus.UseVisualStyleBackColor = False
        '
        'gm
        '
        Me.gm.AutoSize = True
        Me.gm.Font = New System.Drawing.Font("Gotham Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gm.Location = New System.Drawing.Point(27, 21)
        Me.gm.Name = "gm"
        Me.gm.Size = New System.Drawing.Size(210, 36)
        Me.gm.TabIndex = 8
        Me.gm.Text = "Game Mode"
        '
        'Player2
        '
        Me.Player2.BackColor = System.Drawing.Color.LightCoral
        Me.Player2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Player2.Font = New System.Drawing.Font("Gotham", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2.Location = New System.Drawing.Point(52, 125)
        Me.Player2.Name = "Player2"
        Me.Player2.Size = New System.Drawing.Size(158, 53)
        Me.Player2.TabIndex = 10
        Me.Player2.Text = "Player2"
        Me.Player2.UseVisualStyleBackColor = False
        '
        'Player1
        '
        Me.Player1.BackColor = System.Drawing.Color.LightCoral
        Me.Player1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Player1.Font = New System.Drawing.Font("Gotham", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1.Location = New System.Drawing.Point(52, 66)
        Me.Player1.Name = "Player1"
        Me.Player1.Size = New System.Drawing.Size(158, 53)
        Me.Player1.TabIndex = 9
        Me.Player1.Text = "Player1"
        Me.Player1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(283, 196)
        Me.Controls.Add(Me.CPU)
        Me.Controls.Add(Me.gm)
        Me.Controls.Add(Me.wgf)
        Me.Controls.Add(Me.tct)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Versus)
        Me.Controls.Add(Me.Player1)
        Me.Controls.Add(Me.ai)
        Me.Controls.Add(Me.Player2)
        Me.Controls.Add(Me.quit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tct As Label
    Friend WithEvents Play As Button
    Friend WithEvents quit As Button
    Friend WithEvents Player As Button
    Friend WithEvents CPU As Button
    Friend WithEvents wgf As Label
    Friend WithEvents ai As Button
    Friend WithEvents Versus As Button
    Friend WithEvents gm As Label
    Friend WithEvents Player2 As Button
    Friend WithEvents Player1 As Button
End Class
