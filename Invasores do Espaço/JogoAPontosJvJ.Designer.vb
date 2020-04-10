<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JogoAPontosJvJ
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
        Me.PictTiroJ1 = New System.Windows.Forms.PictureBox()
        Me.PicJogador1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PicJogador2 = New System.Windows.Forms.PictureBox()
        Me.PictTiroJ2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictTiroJ3 = New System.Windows.Forms.PictureBox()
        Me.PicJogador3 = New System.Windows.Forms.PictureBox()
        Me.PictTiroJ4 = New System.Windows.Forms.PictureBox()
        Me.PicJogador4 = New System.Windows.Forms.PictureBox()
        Me.TimerInvasores = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictTiroJ1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiroJ2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiroJ3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictTiroJ4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicJogador4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TimerPrincipal
        '
        Me.TimerPrincipal.Interval = 1
        '
        'PictTiroJ1
        '
        Me.PictTiroJ1.BackColor = System.Drawing.Color.Green
        Me.PictTiroJ1.Location = New System.Drawing.Point(77, 335)
        Me.PictTiroJ1.Name = "PictTiroJ1"
        Me.PictTiroJ1.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ1.TabIndex = 1
        Me.PictTiroJ1.TabStop = False
        '
        'PicJogador1
        '
        Me.PicJogador1.Image = Global.Invasores_do_Espaço.My.Resources.Resources.SpaceInvadersShip
        Me.PicJogador1.Location = New System.Drawing.Point(61, 361)
        Me.PicJogador1.Name = "PicJogador1"
        Me.PicJogador1.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicJogador1.TabIndex = 0
        Me.PicJogador1.TabStop = False
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
        Me.Label2.BackColor = System.Drawing.Color.Green
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 414)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 26)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(439, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 26)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tempo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicJogador2
        '
        Me.PicJogador2.Image = Global.Invasores_do_Espaço.My.Resources.Resources.SpaceInvadersShip
        Me.PicJogador2.Location = New System.Drawing.Point(209, 361)
        Me.PicJogador2.Name = "PicJogador2"
        Me.PicJogador2.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicJogador2.TabIndex = 5
        Me.PicJogador2.TabStop = False
        '
        'PictTiroJ2
        '
        Me.PictTiroJ2.BackColor = System.Drawing.Color.Red
        Me.PictTiroJ2.Location = New System.Drawing.Point(227, 335)
        Me.PictTiroJ2.Name = "PictTiroJ2"
        Me.PictTiroJ2.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ2.TabIndex = 6
        Me.PictTiroJ2.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(166, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "0"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Yellow
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 414)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 26)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "0"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Blue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(474, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 26)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "0"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'PictTiroJ3
        '
        Me.PictTiroJ3.BackColor = System.Drawing.Color.Yellow
        Me.PictTiroJ3.Location = New System.Drawing.Point(386, 335)
        Me.PictTiroJ3.Name = "PictTiroJ3"
        Me.PictTiroJ3.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ3.TabIndex = 11
        Me.PictTiroJ3.TabStop = False
        Me.PictTiroJ3.Visible = False
        '
        'PicJogador3
        '
        Me.PicJogador3.Image = Global.Invasores_do_Espaço.My.Resources.Resources.SpaceInvadersShip
        Me.PicJogador3.Location = New System.Drawing.Point(368, 361)
        Me.PicJogador3.Name = "PicJogador3"
        Me.PicJogador3.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicJogador3.TabIndex = 10
        Me.PicJogador3.TabStop = False
        Me.PicJogador3.Visible = False
        '
        'PictTiroJ4
        '
        Me.PictTiroJ4.BackColor = System.Drawing.Color.Blue
        Me.PictTiroJ4.Location = New System.Drawing.Point(548, 335)
        Me.PictTiroJ4.Name = "PictTiroJ4"
        Me.PictTiroJ4.Size = New System.Drawing.Size(10, 20)
        Me.PictTiroJ4.TabIndex = 13
        Me.PictTiroJ4.TabStop = False
        Me.PictTiroJ4.Visible = False
        '
        'PicJogador4
        '
        Me.PicJogador4.Image = Global.Invasores_do_Espaço.My.Resources.Resources.SpaceInvadersShip
        Me.PicJogador4.Location = New System.Drawing.Point(530, 361)
        Me.PicJogador4.Name = "PicJogador4"
        Me.PicJogador4.Size = New System.Drawing.Size(50, 50)
        Me.PicJogador4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicJogador4.TabIndex = 12
        Me.PicJogador4.TabStop = False
        Me.PicJogador4.Visible = False
        '
        'TimerInvasores
        '
        Me.TimerInvasores.Enabled = True
        Me.TimerInvasores.Interval = 1
        '
        'JogoAPontosJvJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(624, 441)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "JogoAPontosJvJ"
        Me.Text = "Invasores"
        CType(Me.PictTiroJ1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiroJ2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiroJ3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictTiroJ4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicJogador4, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
