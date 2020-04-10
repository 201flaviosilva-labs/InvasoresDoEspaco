<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jogo_Deathmatch
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Jogo_Deathmatch))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PicJogador1 = New System.Windows.Forms.PictureBox()
        Me.PicJogador2 = New System.Windows.Forms.PictureBox()
        Me.PicJogador3 = New System.Windows.Forms.PictureBox()
        Me.PicJogador4 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictTiroJ4 = New System.Windows.Forms.PictureBox()
        Me.PictTiroJ2 = New System.Windows.Forms.PictureBox()
        Me.PictTiroJ1 = New System.Windows.Forms.PictureBox()
        Me.PictTiroJ3 = New System.Windows.Forms.PictureBox()
        Me.TimerPrincipal = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TempoPartidaTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicJogador1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiroJ4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiroJ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiroJ1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiroJ3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 524)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(732, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Equipa 1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(732, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Equipa 2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "0 Segundo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicJogador1
        '
        Me.PicJogador1.BackColor = System.Drawing.Color.White
        Me.PicJogador1.Image = CType(resources.GetObject("PicJogador1.Image"), System.Drawing.Image)
        Me.PicJogador1.Location = New System.Drawing.Point(21, 471)
        Me.PicJogador1.Name = "PicJogador1"
        Me.PicJogador1.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador1.TabIndex = 15
        Me.PicJogador1.TabStop = False
        '
        'PicJogador2
        '
        Me.PicJogador2.BackColor = System.Drawing.Color.White
        Me.PicJogador2.Image = CType(resources.GetObject("PicJogador2.Image"), System.Drawing.Image)
        Me.PicJogador2.Location = New System.Drawing.Point(694, 37)
        Me.PicJogador2.Name = "PicJogador2"
        Me.PicJogador2.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador2.TabIndex = 16
        Me.PicJogador2.TabStop = False
        '
        'PicJogador3
        '
        Me.PicJogador3.BackColor = System.Drawing.Color.White
        Me.PicJogador3.Image = CType(resources.GetObject("PicJogador3.Image"), System.Drawing.Image)
        Me.PicJogador3.Location = New System.Drawing.Point(381, 471)
        Me.PicJogador3.Name = "PicJogador3"
        Me.PicJogador3.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador3.TabIndex = 17
        Me.PicJogador3.TabStop = False
        Me.PicJogador3.Visible = False
        '
        'PicJogador4
        '
        Me.PicJogador4.BackColor = System.Drawing.Color.White
        Me.PicJogador4.Image = CType(resources.GetObject("PicJogador4.Image"), System.Drawing.Image)
        Me.PicJogador4.Location = New System.Drawing.Point(313, 37)
        Me.PicJogador4.Name = "PicJogador4"
        Me.PicJogador4.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador4.TabIndex = 18
        Me.PicJogador4.TabStop = False
        Me.PicJogador4.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gold
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(755, 10)
        Me.Label5.TabIndex = 19
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictTiroJ4
        '
        Me.PictTiroJ4.BackColor = System.Drawing.Color.Blue
        Me.PictTiroJ4.Location = New System.Drawing.Point(337, 93)
        Me.PictTiroJ4.Name = "PictTiroJ4"
        Me.PictTiroJ4.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ4.TabIndex = 21
        Me.PictTiroJ4.TabStop = False
        Me.PictTiroJ4.Visible = False
        '
        'PictTiroJ2
        '
        Me.PictTiroJ2.BackColor = System.Drawing.Color.Red
        Me.PictTiroJ2.Location = New System.Drawing.Point(714, 93)
        Me.PictTiroJ2.Name = "PictTiroJ2"
        Me.PictTiroJ2.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ2.TabIndex = 22
        Me.PictTiroJ2.TabStop = False
        Me.PictTiroJ2.Visible = False
        '
        'PictTiroJ1
        '
        Me.PictTiroJ1.BackColor = System.Drawing.Color.Green
        Me.PictTiroJ1.Location = New System.Drawing.Point(42, 445)
        Me.PictTiroJ1.Name = "PictTiroJ1"
        Me.PictTiroJ1.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ1.TabIndex = 23
        Me.PictTiroJ1.TabStop = False
        Me.PictTiroJ1.Visible = False
        '
        'PictTiroJ3
        '
        Me.PictTiroJ3.BackColor = System.Drawing.Color.Yellow
        Me.PictTiroJ3.Location = New System.Drawing.Point(399, 445)
        Me.PictTiroJ3.Name = "PictTiroJ3"
        Me.PictTiroJ3.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ3.TabIndex = 24
        Me.PictTiroJ3.TabStop = False
        Me.PictTiroJ3.Visible = False
        '
        'TimerPrincipal
        '
        Me.TimerPrincipal.Enabled = True
        Me.TimerPrincipal.Interval = 1
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Yellow
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(338, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 45)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Pausa"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 524)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Yellow
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(587, 524)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 25)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "0"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Blue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 25)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "0"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Red
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(587, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(157, 25)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "0"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label9.Visible = False
        '
        'TempoPartidaTimer
        '
        Me.TempoPartidaTimer.Enabled = True
        Me.TempoPartidaTimer.Interval = 1000
        '
        'Jogo_Deathmatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(756, 558)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictTiroJ3)
        Me.Controls.Add(Me.PictTiroJ1)
        Me.Controls.Add(Me.PictTiroJ2)
        Me.Controls.Add(Me.PictTiroJ4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PicJogador4)
        Me.Controls.Add(Me.PicJogador3)
        Me.Controls.Add(Me.PicJogador2)
        Me.Controls.Add(Me.PicJogador1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Jogo_Deathmatch"
        Me.Text = "Deathmatch"
        CType(Me.PicJogador1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiroJ4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiroJ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiroJ1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiroJ3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PicJogador1 As System.Windows.Forms.PictureBox
    Friend WithEvents PicJogador2 As System.Windows.Forms.PictureBox
    Friend WithEvents PicJogador3 As System.Windows.Forms.PictureBox
    Friend WithEvents PicJogador4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictTiroJ4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictTiroJ2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictTiroJ1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictTiroJ3 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerPrincipal As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TempoPartidaTimer As System.Windows.Forms.Timer
End Class
