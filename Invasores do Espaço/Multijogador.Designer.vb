<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multijogador
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
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button8.Location = New System.Drawing.Point(136, 140)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(118, 37)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Pontos"
        Me.Button8.UseVisualStyleBackColor = True
        Me.Button8.Visible = False
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(136, 97)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(118, 37)
        Me.Button7.TabIndex = 17
        Me.Button7.Text = "Deathmatch"
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(12, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 37)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Voltar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 82)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 37)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Online"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(12, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 37)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "Local"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(260, 69)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(118, 37)
        Me.Button9.TabIndex = 24
        Me.Button9.Text = "Quadras"
        Me.Button9.UseVisualStyleBackColor = True
        Me.Button9.Visible = False
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(260, 112)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(118, 37)
        Me.Button10.TabIndex = 23
        Me.Button10.Text = "Triplas"
        Me.Button10.UseVisualStyleBackColor = True
        Me.Button10.Visible = False
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(260, 155)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(118, 37)
        Me.Button11.TabIndex = 22
        Me.Button11.Text = "Duplas"
        Me.Button11.UseVisualStyleBackColor = True
        Me.Button11.Visible = False
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button12.Location = New System.Drawing.Point(12, 211)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(362, 37)
        Me.Button12.TabIndex = 25
        Me.Button12.Text = "Ajuda?"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Multijogador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 299)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Name = "Multijogador"
        Me.Text = "Multijogador"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
End Class
