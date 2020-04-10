<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jogo_PvE
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
        Me.TimerPrincipal = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TimerInvasores = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TimerMoverJogadorRato = New System.Windows.Forms.Timer(Me.components)
        Me.PictTiroJ6 = New System.Windows.Forms.PictureBox()
        Me.PictTiroJ5 = New System.Windows.Forms.PictureBox()
        Me.PicJogador6 = New System.Windows.Forms.PictureBox()
        Me.PicJogador5 = New System.Windows.Forms.PictureBox()
        Me.PictTiroJ4 = New System.Windows.Forms.PictureBox()
        Me.PicJogador4 = New System.Windows.Forms.PictureBox()
        Me.PictTiroJ3 = New System.Windows.Forms.PictureBox()
        Me.PicJogador3 = New System.Windows.Forms.PictureBox()
        Me.PictTiroJ2 = New System.Windows.Forms.PictureBox()
        Me.PicJogador2 = New System.Windows.Forms.PictureBox()
        Me.PictTiroJ1 = New System.Windows.Forms.PictureBox()
        Me.PicJogador1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictTiroJ6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiroJ5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiroJ4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiroJ3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiroJ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiroJ1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerPrincipal
        '
        Me.TimerPrincipal.Interval = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pausa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Jogador 1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(537, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tempo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(121, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jogador 2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(240, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Jogador 3"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(359, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Jogador 4"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'TimerInvasores
        '
        Me.TimerInvasores.Enabled = True
        Me.TimerInvasores.Interval = 1
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Magenta
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(478, 414)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 26)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Jogador 5"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Chocolate
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(597, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 26)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Jogador 6"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label8.Visible = False
        '
        'TimerMoverJogadorRato
        '
        Me.TimerMoverJogadorRato.Interval = 1
        '
        'PictTiroJ6
        '
        Me.PictTiroJ6.BackColor = System.Drawing.Color.Chocolate
        Me.PictTiroJ6.Location = New System.Drawing.Point(654, 335)
        Me.PictTiroJ6.Name = "PictTiroJ6"
        Me.PictTiroJ6.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ6.TabIndex = 19
        Me.PictTiroJ6.TabStop = False
        Me.PictTiroJ6.Visible = False
        '
        'PictTiroJ5
        '
        Me.PictTiroJ5.BackColor = System.Drawing.Color.Magenta
        Me.PictTiroJ5.Location = New System.Drawing.Point(526, 335)
        Me.PictTiroJ5.Name = "PictTiroJ5"
        Me.PictTiroJ5.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ5.TabIndex = 18
        Me.PictTiroJ5.TabStop = False
        Me.PictTiroJ5.Visible = False
        '
        'PicJogador6
        '
        Me.PicJogador6.Image = Global.Invasores_do_Espaço.My.Resources.Resources.Nave6
        Me.PicJogador6.Location = New System.Drawing.Point(634, 361)
        Me.PicJogador6.Name = "PicJogador6"
        Me.PicJogador6.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicJogador6.TabIndex = 17
        Me.PicJogador6.TabStop = False
        Me.PicJogador6.Visible = False
        '
        'PicJogador5
        '
        Me.PicJogador5.Image = Global.Invasores_do_Espaço.My.Resources.Resources.Nave5
        Me.PicJogador5.Location = New System.Drawing.Point(506, 361)
        Me.PicJogador5.Name = "PicJogador5"
        Me.PicJogador5.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicJogador5.TabIndex = 16
        Me.PicJogador5.TabStop = False
        Me.PicJogador5.Visible = False
        '
        'PictTiroJ4
        '
        Me.PictTiroJ4.BackColor = System.Drawing.Color.Blue
        Me.PictTiroJ4.Location = New System.Drawing.Point(415, 335)
        Me.PictTiroJ4.Name = "PictTiroJ4"
        Me.PictTiroJ4.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ4.TabIndex = 13
        Me.PictTiroJ4.TabStop = False
        Me.PictTiroJ4.Visible = False
        '
        'PicJogador4
        '
        Me.PicJogador4.Image = Global.Invasores_do_Espaço.My.Resources.Resources.Nave4
        Me.PicJogador4.Location = New System.Drawing.Point(395, 361)
        Me.PicJogador4.Name = "PicJogador4"
        Me.PicJogador4.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicJogador4.TabIndex = 12
        Me.PicJogador4.TabStop = False
        Me.PicJogador4.Visible = False
        '
        'PictTiroJ3
        '
        Me.PictTiroJ3.BackColor = System.Drawing.Color.Yellow
        Me.PictTiroJ3.Location = New System.Drawing.Point(298, 335)
        Me.PictTiroJ3.Name = "PictTiroJ3"
        Me.PictTiroJ3.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ3.TabIndex = 11
        Me.PictTiroJ3.TabStop = False
        Me.PictTiroJ3.Visible = False
        '
        'PicJogador3
        '
        Me.PicJogador3.Image = Global.Invasores_do_Espaço.My.Resources.Resources.Nave3
        Me.PicJogador3.Location = New System.Drawing.Point(274, 361)
        Me.PicJogador3.Name = "PicJogador3"
        Me.PicJogador3.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicJogador3.TabIndex = 10
        Me.PicJogador3.TabStop = False
        Me.PicJogador3.Visible = False
        '
        'PictTiroJ2
        '
        Me.PictTiroJ2.BackColor = System.Drawing.Color.Red
        Me.PictTiroJ2.Location = New System.Drawing.Point(169, 335)
        Me.PictTiroJ2.Name = "PictTiroJ2"
        Me.PictTiroJ2.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ2.TabIndex = 6
        Me.PictTiroJ2.TabStop = False
        '
        'PicJogador2
        '
        Me.PicJogador2.Image = Global.Invasores_do_Espaço.My.Resources.Resources.Nave2
        Me.PicJogador2.Location = New System.Drawing.Point(150, 361)
        Me.PicJogador2.Name = "PicJogador2"
        Me.PicJogador2.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicJogador2.TabIndex = 5
        Me.PicJogador2.TabStop = False
        '
        'PictTiroJ1
        '
        Me.PictTiroJ1.BackColor = System.Drawing.Color.Green
        Me.PictTiroJ1.Location = New System.Drawing.Point(43, 335)
        Me.PictTiroJ1.Name = "PictTiroJ1"
        Me.PictTiroJ1.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ1.TabIndex = 1
        Me.PictTiroJ1.TabStop = False
        '
        'PicJogador1
        '
        Me.PicJogador1.Image = Global.Invasores_do_Espaço.My.Resources.Resources.Nave1
        Me.PicJogador1.Location = New System.Drawing.Point(27, 361)
        Me.PicJogador1.Name = "PicJogador1"
        Me.PicJogador1.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicJogador1.TabIndex = 0
        Me.PicJogador1.TabStop = False
        '
        'Jogo_PvE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(721, 441)
        Me.Controls.Add(Me.PictTiroJ6)
        Me.Controls.Add(Me.PictTiroJ5)
        Me.Controls.Add(Me.PicJogador6)
        Me.Controls.Add(Me.PicJogador5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictTiroJ4)
        Me.Controls.Add(Me.PicJogador4)
        Me.Controls.Add(Me.PictTiroJ3)
        Me.Controls.Add(Me.PicJogador3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictTiroJ2)
        Me.Controls.Add(Me.PicJogador2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictTiroJ1)
        Me.Controls.Add(Me.PicJogador1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Jogo_PvE"
        Me.Text = "Invasores"
        CType(Me.PictTiroJ6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiroJ5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiroJ4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiroJ3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiroJ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiroJ1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicJogador1 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerPrincipal As System.Windows.Forms.Timer
    Friend WithEvents PictTiroJ1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PicJogador2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictTiroJ2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictTiroJ3 As System.Windows.Forms.PictureBox
    Friend WithEvents PicJogador3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictTiroJ4 As System.Windows.Forms.PictureBox
    Friend WithEvents PicJogador4 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerInvasores As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PicJogador5 As System.Windows.Forms.PictureBox
    Friend WithEvents PicJogador6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictTiroJ5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictTiroJ6 As System.Windows.Forms.PictureBox
    Friend WithEvents TimerMoverJogadorRato As System.Windows.Forms.Timer
End Class
