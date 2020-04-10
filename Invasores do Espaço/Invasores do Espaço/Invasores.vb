Public Class Invasores
    Dim JogadorDireita As Boolean
    Dim JogadorEsquerda As Boolean
    Dim VelocidadeJogador As Integer
    Dim VelocidadeTiro As Integer
    Dim dificuldade As Integer
    Dim VelocidadeInvasor As Integer
    Dim IvasorCair As Integer
    Dim InvasorDireita As Boolean
    Dim Tempo As Integer = 0

    Private Sub TimerPrincipal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPrincipal.Tick
        'Timer 1 temporalizador
        MoverJogador()
        MoverTiro()
        MoverInvasor()
        VerTiro()
        GameOver()
        Tempo += 1
        Label1.Text = Tempo
    End Sub

    Private Sub Invasores_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'Ao clicar nas teclas (A ou D) permitir mover
        If e.KeyValue = Keys.D Then
            JogadorDireita = True
            JogadorEsquerda = False
        End If
        If e.KeyValue = Keys.A Then
            JogadorEsquerda = True
            JogadorDireita = False
        End If

        If e.KeyValue = Keys.Space And PictTiro.Visible = False Then
            PictTiro.Visible = True
            PictTiro.Top = NaveJogador.Top
            PictTiro.Left = NaveJogador.Left + (NaveJogador.Width / 2) - (PictTiro.Width / 2)
        End If

        If e.KeyValue = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub MoverJogador()
        'Se estiver permitido mover então anda mais ou mneos um consuante a sua posição
        'não permite que passe a tela
        If (JogadorDireita = True) And (NaveJogador.Left + NaveJogador.Width < Me.ClientRectangle.Width) Then
            NaveJogador.Left += VelocidadeJogador
        End If
        If JogadorEsquerda = True And (NaveJogador.Left > Me.ClientRectangle.Left) Then
            NaveJogador.Left -= VelocidadeJogador
        End If
    End Sub

    Private Sub Invasores_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        'Bloqueia a permiçao de mover
        If e.KeyValue = Keys.D Then
            JogadorDireita = False
            JogadorEsquerda = False
        End If
        If e.KeyValue = Keys.A Then
            JogadorEsquerda = False
            JogadorDireita = False
        End If
    End Sub

    Private Sub Invasores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Opcoes()
    End Sub
    Private Sub opcoes()
        'Permitir o invasor ir para a direita
        InvasorDireita = True

        'Escolha da dificuldde do jogo
        dificuldade = InputBox("Diz o numero do nivel da dificuldade de nivel de 1 - 9: " & vbCrLf & "1 - FACIL Fácil" & vbCrLf & "2 - FACIL Normal" & vbCrLf & "3 - FACIL Dificil" & vbCrLf & "4 - NORMAL Fácil" & vbCrLf & "5 - NORMAL Normal" & vbCrLf & "6 - NORMAL Dificil" & vbCrLf & "7 - DIFICIL Fácil" & vbCrLf & "8 - DIFICIL Normal" & vbCrLf & "9 - DIFICIL Dificil" & vbCrLf & "10 - IMPOSSÍVEL!!")
        If dificuldade = 1 Then
            MsgBox("Nivel de dificulade 1 - FACIL Fácil")
            VelocidadeInvasor = 3
        ElseIf dificuldade = 2 Then
            MsgBox("Nivel de dificulade 2 - FACIL Normal")
            VelocidadeInvasor = 4
        ElseIf dificuldade = 3 Then
            MsgBox("Nivel de dificulade 3 - FACIL Dificil")
            VelocidadeInvasor = 5
        ElseIf dificuldade = 4 Then
            MsgBox("Nivel de dificulade 4 - NORMAL Facil")
            VelocidadeInvasor = 8
        ElseIf dificuldade = 5 Then
            MsgBox("Nivel de dificulade 5 - NORMAL Normal")
            VelocidadeInvasor = 10
        ElseIf dificuldade = 6 Then
            MsgBox("Nivel de dificulade 6 - NORMAL Dificil")
            VelocidadeInvasor = 13
        ElseIf dificuldade = 7 Then
            MsgBox("Nivel de dificulade 7 - DIFICIL Facil")
            VelocidadeInvasor = 15
        ElseIf dificuldade = 8 Then
            MsgBox("Nivel de dificulade 8 - DIFICIL Normal")
            VelocidadeInvasor = 17
        ElseIf dificuldade = 9 Then
            MsgBox("Nivel de dificulade 9 - DIFICIL Dificil")
            VelocidadeInvasor = 20
        ElseIf dificuldade = 10 Then
            MsgBox("Nivel de dificulade 10 - IMPOSSÍVEL")
            VelocidadeInvasor = 25
        Else
            MsgBox("Nivel de dificulade errada")
        End If

        VelocidadeJogador = 3
        VelocidadeTiro = 6

        'Tiro invisivel
        PictTiro.Visible = False

        IvasorCair = 50
    End Sub

    Private Sub MoverTiro()
        If PictTiro.Visible = True Then
            PictTiro.Top -= VelocidadeTiro
        End If

        If PictTiro.Top + PictTiro.Height < Me.ClientRectangle.Top Then
            PictTiro.Visible = False
        End If
    End Sub

    Private Sub MoverInvasor()
        If InvasorDireita = True Then
            PictureBox1.Left += VelocidadeInvasor
        Else
            PictureBox1.Left -= VelocidadeInvasor
        End If

        If PictureBox1.Left + PictureBox1.Width > Me.ClientRectangle.Width Then
            InvasorDireita = False
            PictureBox1.Top += IvasorCair
        End If

        If PictureBox1.Left < Me.ClientRectangle.Left Then
            InvasorDireita = True
            PictureBox1.Top += IvasorCair
        End If
    End Sub

    Private Sub GameOver()
        If PictureBox1.Top + PictureBox1.Height >= NaveJogador.Top And PictureBox1.Visible = True Then
            TimerPrincipal.Enabled = False
            MsgBox("Game Over - A terra foi Invadida")
        End If
    End Sub

    Private Sub VerTiro()
        If (PictTiro.Top + PictTiro.Height >= PictureBox1.Top) And (PictTiro.Top <= PictureBox1.Top + PictureBox1.Height) And (PictTiro.Left + PictTiro.Width >= PictureBox1.Left) And (PictTiro.Left <= PictureBox1.Left + PictureBox1.Width) And (PictTiro.Visible = True) Then
            PictureBox1.Visible = False
            TimerPrincipal.Enabled = False
            PictTiro.Visible = False
            MsgBox("A Terra está Salva")

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class