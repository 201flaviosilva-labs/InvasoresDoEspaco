<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Original
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Original))
        Me.TimerInvasor = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPrincipal = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictTiro = New System.Windows.Forms.PictureBox()
        Me.NaveJogador = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Alien12 = New System.Windows.Forms.PictureBox()
        Me.Alien11 = New System.Windows.Forms.PictureBox()
        Me.Alien10 = New System.Windows.Forms.PictureBox()
        Me.Alien9 = New System.Windows.Forms.PictureBox()
        Me.Alien8 = New System.Windows.Forms.PictureBox()
        Me.Alien7 = New System.Windows.Forms.PictureBox()
        Me.Alien6 = New System.Windows.Forms.PictureBox()
        Me.Alien5 = New System.Windows.Forms.PictureBox()
        Me.Alien4 = New System.Windows.Forms.PictureBox()
        Me.Alien3 = New System.Windows.Forms.PictureBox()
        Me.Alien2 = New System.Windows.Forms.PictureBox()
        Me.Alien1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictTiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NaveJogador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alien1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerInvasor
        '
        Me.TimerInvasor.Enabled = True
        Me.TimerInvasor.Interval = 1
        '
        'TimerPrincipal
        '
        Me.TimerPrincipal.Interval = 1
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 26)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tempo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictTiro
        '
        Me.PictTiro.BackColor = System.Drawing.Color.Red
        Me.PictTiro.Location = New System.Drawing.Point(28, 327)
        Me.PictTiro.Name = "PictTiro"
        Me.PictTiro.Size = New System.Drawing.Size(10, 20)
        Me.PictTiro.TabIndex = 6
        Me.PictTiro.TabStop = False
        '
        'NaveJogador
        '
        Me.NaveJogador.Image = Global.Invasores_do_Espaço.My.Resources.Resources.Nave2
        Me.NaveJogador.Location = New System.Drawing.Point(12, 353)
        Me.NaveJogador.Name = "NaveJogador"
        Me.NaveJogador.Size = New System.Drawing.Size(50, 50)
        Me.NaveJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NaveJogador.TabIndex = 5
        Me.NaveJogador.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 45)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Pausa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'Alien12
        '
        Me.Alien12.Image = CType(resources.GetObject("Alien12.Image"), System.Drawing.Image)
        Me.Alien12.Location = New System.Drawing.Point(409, 90)
        Me.Alien12.Name = "Alien12"
        Me.Alien12.Size = New System.Drawing.Size(63, 55)
        Me.Alien12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien12.TabIndex = 52
        Me.Alien12.TabStop = False
        '
        'Alien11
        '
        Me.Alien11.Image = CType(resources.GetObject("Alien11.Image"), System.Drawing.Image)
        Me.Alien11.Location = New System.Drawing.Point(330, 90)
        Me.Alien11.Name = "Alien11"
        Me.Alien11.Size = New System.Drawing.Size(63, 55)
        Me.Alien11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien11.TabIndex = 51
        Me.Alien11.TabStop = False
        '
        'Alien10
        '
        Me.Alien10.Image = CType(resources.GetObject("Alien10.Image"), System.Drawing.Image)
        Me.Alien10.Location = New System.Drawing.Point(255, 90)
        Me.Alien10.Name = "Alien10"
        Me.Alien10.Size = New System.Drawing.Size(63, 55)
        Me.Alien10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien10.TabIndex = 50
        Me.Alien10.TabStop = False
        '
        'Alien9
        '
        Me.Alien9.Image = CType(resources.GetObject("Alien9.Image"), System.Drawing.Image)
        Me.Alien9.Location = New System.Drawing.Point(180, 90)
        Me.Alien9.Name = "Alien9"
        Me.Alien9.Size = New System.Drawing.Size(63, 55)
        Me.Alien9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien9.TabIndex = 49
        Me.Alien9.TabStop = False
        '
        'Alien8
        '
        Me.Alien8.Image = CType(resources.GetObject("Alien8.Image"), System.Drawing.Image)
        Me.Alien8.Location = New System.Drawing.Point(107, 90)
        Me.Alien8.Name = "Alien8"
        Me.Alien8.Size = New System.Drawing.Size(63, 55)
        Me.Alien8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien8.TabIndex = 48
        Me.Alien8.TabStop = False
        '
        'Alien7
        '
        Me.Alien7.Image = CType(resources.GetObject("Alien7.Image"), System.Drawing.Image)
        Me.Alien7.Location = New System.Drawing.Point(28, 90)
        Me.Alien7.Name = "Alien7"
        Me.Alien7.Size = New System.Drawing.Size(63, 55)
        Me.Alien7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien7.TabIndex = 47
        Me.Alien7.TabStop = False
        '
        'Alien6
        '
        Me.Alien6.Image = CType(resources.GetObject("Alien6.Image"), System.Drawing.Image)
        Me.Alien6.Location = New System.Drawing.Point(409, 28)
        Me.Alien6.Name = "Alien6"
        Me.Alien6.Size = New System.Drawing.Size(63, 55)
        Me.Alien6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien6.TabIndex = 46
        Me.Alien6.TabStop = False
        '
        'Alien5
        '
        Me.Alien5.Image = CType(resources.GetObject("Alien5.Image"), System.Drawing.Image)
        Me.Alien5.Location = New System.Drawing.Point(330, 28)
        Me.Alien5.Name = "Alien5"
        Me.Alien5.Size = New System.Drawing.Size(63, 55)
        Me.Alien5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien5.TabIndex = 45
        Me.Alien5.TabStop = False
        '
        'Alien4
        '
        Me.Alien4.Image = CType(resources.GetObject("Alien4.Image"), System.Drawing.Image)
        Me.Alien4.Location = New System.Drawing.Point(255, 28)
        Me.Alien4.Name = "Alien4"
        Me.Alien4.Size = New System.Drawing.Size(63, 55)
        Me.Alien4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien4.TabIndex = 44
        Me.Alien4.TabStop = False
        '
        'Alien3
        '
        Me.Alien3.Image = CType(resources.GetObject("Alien3.Image"), System.Drawing.Image)
        Me.Alien3.Location = New System.Drawing.Point(180, 28)
        Me.Alien3.Name = "Alien3"
        Me.Alien3.Size = New System.Drawing.Size(63, 55)
        Me.Alien3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien3.TabIndex = 43
        Me.Alien3.TabStop = False
        '
        'Alien2
        '
        Me.Alien2.Image = CType(resources.GetObject("Alien2.Image"), System.Drawing.Image)
        Me.Alien2.Location = New System.Drawing.Point(105, 28)
        Me.Alien2.Name = "Alien2"
        Me.Alien2.Size = New System.Drawing.Size(63, 55)
        Me.Alien2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien2.TabIndex = 42
        Me.Alien2.TabStop = False
        '
        'Alien1
        '
        Me.Alien1.Image = CType(resources.GetObject("Alien1.Image"), System.Drawing.Image)
        Me.Alien1.Location = New System.Drawing.Point(28, 28)
        Me.Alien1.Name = "Alien1"
        Me.Alien1.Size = New System.Drawing.Size(63, 55)
        Me.Alien1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Alien1.TabIndex = 41
        Me.Alien1.TabStop = False
        '
        'Original
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.Alien12)
        Me.Controls.Add(Me.Alien11)
        Me.Controls.Add(Me.Alien10)
        Me.Controls.Add(Me.Alien9)
        Me.Controls.Add(Me.Alien8)
        Me.Controls.Add(Me.Alien7)
        Me.Controls.Add(Me.Alien6)
        Me.Controls.Add(Me.Alien5)
        Me.Controls.Add(Me.Alien4)
        Me.Controls.Add(Me.Alien3)
        Me.Controls.Add(Me.Alien2)
        Me.Controls.Add(Me.Alien1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictTiro)
        Me.Controls.Add(Me.NaveJogador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Original"
        Me.Text = "Original"
        CType(Me.PictTiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NaveJogador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alien1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TimerInvasor As System.Windows.Forms.Timer
    Friend WithEvents TimerPrincipal As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictTiro As System.Windows.Forms.PictureBox
    Friend WithEvents NaveJogador As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Alien12 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien11 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien10 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien9 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien8 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien7 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien6 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien5 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien4 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien3 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien2 As System.Windows.Forms.PictureBox
    Friend WithEvents Alien1 As System.Windows.Forms.PictureBox
End Class
