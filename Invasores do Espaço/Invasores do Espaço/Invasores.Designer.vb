<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invasores
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictTiro = New System.Windows.Forms.PictureBox()
        Me.NaveJogador = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NaveJogador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerPrincipal
        '
        Me.TimerPrincipal.Enabled = True
        Me.TimerPrincipal.Interval = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Invasores_do_Espaço.My.Resources.Resources.invader
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
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
        Me.NaveJogador.Image = Global.Invasores_do_Espaço.My.Resources.Resources.SpaceInvadersShip
        Me.NaveJogador.Location = New System.Drawing.Point(12, 361)
        Me.NaveJogador.Name = "NaveJogador"
        Me.NaveJogador.Size = New System.Drawing.Size(50, 50)
        Me.NaveJogador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NaveJogador.TabIndex = 0
        Me.NaveJogador.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(542, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tempo"
        '
        'Invasores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictTiro)
        Me.Controls.Add(Me.NaveJogador)
        Me.Cursor = System.Windows.Forms.Cursors.No
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Invasores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invasores"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NaveJogador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NaveJogador As System.Windows.Forms.PictureBox
    Friend WithEvents TimerPrincipal As System.Windows.Forms.Timer
    Friend WithEvents PictTiro As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
