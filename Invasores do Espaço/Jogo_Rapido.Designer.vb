<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Jogo_Rapido
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
        Me.TimerInvasor = New System.Windows.Forms.Timer(Me.components)
        Me.PictTiro = New System.Windows.Forms.PictureBox()
        Me.NaveJogador = New System.Windows.Forms.PictureBox()
        Me.TimerJogadorRato = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictTiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NaveJogador, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(245, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Pausa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(412, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pontos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 414)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tempo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerInvasor
        '
        Me.TimerInvasor.Enabled = True
        Me.TimerInvasor.Interval = 1
        '
        'PictTiro
        '
        Me.PictTiro.BackColor = System.Drawing.Color.Red
        Me.PictTiro.Location = New System.Drawing.Point(28, 335)
        Me.PictTiro.Name = "PictTiro"
        Me.PictTiro.Size = New System.Drawing.Size(10, 20)
        Me.PictTiro.TabIndex = 1
        Me.PictTiro.TabStop = False
        '
        'NaveJogador
        '
        Me.NaveJogador.Image = Global.Invasores_do_Espaço.My.Resources.Resources.Nave2
        Me.NaveJogador.Location = New System.Drawing.Point(12, 361)
        Me.NaveJogador.Name = "NaveJogador"
        Me.NaveJogador.Size = New System.Drawing.Size(50, 50)
        Me.NaveJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NaveJogador.TabIndex = 0
        Me.NaveJogador.TabStop = False
        '
        'TimerJogadorRato
        '
        Me.TimerJogadorRato.Interval = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(412, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Pontos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Jogo_Rapido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictTiro)
        Me.Controls.Add(Me.NaveJogador)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Jogo_Rapido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invasores"
        CType(Me.PictTiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NaveJogador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NaveJogador As System.Windows.Forms.PictureBox
    Friend WithEvents TimerPrincipal As System.Windows.Forms.Timer
    Friend WithEvents PictTiro As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TimerInvasor As System.Windows.Forms.Timer
    Friend WithEvents TimerJogadorRato As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
