Public Class Original
    'Exencial para o jogo
    Dim JogadorDireita As Boolean 'Define o movimento do jogador ir para a Direira
    Dim JogadorEsquerda As Boolean 'Define o movimento do jogador ir para a Esquerda
    Dim VelocidadeJogador As Integer = 3 'Define a velocidade do jogador
    Dim VelocidadeTiro As Integer = 20 'Define a velocidade do tiro do jogador
    Dim VelocidadeInvasor As Integer = 2 'Define a velocidade de deslocação dos invasores
    Dim IvasorCair As Integer = 20 'Define o degrau que os invasores vão cai em realação ao top
    Const NumDeInvasores As Integer = 18 ' Escrever quantos invasores pertendo que sejam aparecidos na tela
    Dim InvasorDireita(NumDeInvasores) As Boolean 'Define o movimento dos invasores neste caso para a direita
    Dim X As Integer 'X = Counter
    Dim Pausa As Boolean = False 'Define se a pausa está ativa ou não

    Dim RandomVidaInvasor(NumDeInvasores) As Integer ' Define o número de tiros que um invasor tem que levar para morrer
    Dim NumeroVidasInvasoresMortas As Integer = 0 'Diz quantas Vidas de invasores há que foram Eliminadas
    Dim SomaDasVidasInvasores As Integer ' Soma de todas as vidas dos invasores

    Dim TempoPartida As Integer = 0 ' Mostra o tempo da partida em millisegundos
    Dim ContadorNumeroInvasoresMortos As Integer = 0 ' Contador de número de Invasores mortos


    '------------------------- Coisas do original -------------

    Dim alien(11) As PictureBox
    Dim localisacoes(11) As System.Drawing.Point

    Dim alvo As Integer
    Dim vencedor As Integer 'numero de invasores mortos
    Dim DisparoRealisado As Boolean = False

    Private Sub TimerPrincipal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPrincipal.Tick
        'Timer 1 temporalizador
        TemporalizadorDeJogo()
        MoverJogador()
        MoverTiro()
        DisparoRealizadoSub()
    End Sub

    Sub CriarInvasores()
        alien(0) = Alien1
        alien(1) = Alien2
        alien(2) = Alien3
        alien(3) = Alien4
        alien(4) = Alien5
        alien(5) = Alien6
        alien(6) = Alien7
        alien(7) = Alien8
        alien(8) = Alien9
        alien(9) = Alien10
        alien(10) = Alien11
        alien(11) = Alien12
        For i = 0 To 11
            localisacoes(i) = alien(i).Location
        Next
    End Sub

    Sub MoverInvasor()
        For i = 0 To 11
            alien(i).Left = alien(i).Left + VelocidadeInvasor
            If alien(i).Bounds.IntersectsWith(NaveJogador.Bounds) And alien(i).Visible = True Then
                TimerInvasor.Enabled = False
                TimerPrincipal.Enabled = False
                MsgBox("Perdeste!! Volta a tenatar")
                Me.Close()
            End If
        Next

        If Alien6.Left > Me.Width - Alien6.Width Then
            VelocidadeInvasor = VelocidadeInvasor * -1
            For i = 0 To 11
                alien(i).Top = alien(i).Top + IvasorCair
            Next
        End If

        If Alien1.Left < 0 Then
            VelocidadeInvasor = VelocidadeInvasor * -1
            For i = 0 To 11
                alien(i).Top = alien(i).Top + IvasorCair
            Next
        End If

        For i = 0 To 11
            If alien(i).Visible = False Then
                alien(i).Top = alien(i).Top - IvasorCair
            End If
        Next
    End Sub

    Private Sub Original_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'Tecla é precionada para baixo
        'Ao clicar nas teclas (A ou D) permitir mover
        'D - Direita
        If e.KeyValue = Keys.D Then
            JogadorDireita = True 'Permite a ida para Direita
            JogadorEsquerda = False 'Bloqueia a ida para a Esquerda
        End If

        'A - Esquerda
        If e.KeyValue = Keys.A Then
            JogadorEsquerda = True 'Permite a ida para Esquerda
            JogadorDireita = False 'Bloqueia a ida para a Direita
        End If

        'Espaço ou W - Tiro
        'Se o espaço for permido e o tiro visiver então
        If ((e.KeyValue = Keys.Space Or e.KeyValue = Keys.W) And (PictTiro.Visible = False)) Then
            DispararTiro()
        End If
    End Sub

    Private Sub DispararTiro()
        PictTiro.Visible = True 'Torna o tiro visivel
        PictTiro.Top = NaveJogador.Top 'A picterbox do tiro vai ter com o topo da nave do jogardor
        PictTiro.Left = NaveJogador.Left + (NaveJogador.Width / 2) - (PictTiro.Width / 2) 'A picterbox do tiro começa a subir no eixo do Y de onde foi lançada
    End Sub

    Private Sub DisparoRealizadoSub()
            For i = 0 To 11
                If PictTiro.Bounds.IntersectsWith(alien(i).Bounds) Then
                    alvo = i
                    Disparo()
                End If
        Next
    End Sub

    Private Sub Disparo()
        alien(alvo).Visible = False ' = alien(alvo).Top = 1000
        If Alien1.Visible = False And Alien2.Visible = False And Alien3.Visible = False And Alien4.Visible = False And Alien5.Visible = False And Alien6.Visible = False And Alien7.Visible = False And Alien8.Visible = False And Alien9.Visible = False And Alien10.Visible = False And Alien11.Visible = False And Alien12.Visible = False Then
            TimerInvasor.Enabled = False
            TimerPrincipal.Enabled = False
            MsgBox("Venceste!! Salvaste a terra!")
            Me.Close()
        End If
        PictTiro.Visible = False
        PictTiro.Top = 1000
    End Sub

    Private Sub MoverJogador()
        'Se estiver permitido mover então anda mais ou mneos um consuante a sua posição
        'Não permite que o jogador passe a tela
        If (JogadorDireita = True) And (NaveJogador.Left + NaveJogador.Width < Me.ClientRectangle.Width) Then
            NaveJogador.Left += VelocidadeJogador
        End If
        If (JogadorEsquerda = True) And (NaveJogador.Left > Me.ClientRectangle.Left) Then
            NaveJogador.Left -= VelocidadeJogador
        End If
    End Sub

    Private Sub Original_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        'Tecla é levantada
        'Bloqueia a permiçao de mover
        'D - Direita
        If e.KeyValue = Keys.D Then
            'Bloqueia o movimento para a esquerda e para a direita
            JogadorDireita = False
            JogadorEsquerda = False
        End If

        'A - Esquerda
        If e.KeyValue = Keys.A Then
            'Bloqueia o movimento para a esquerda e para a direita
            JogadorEsquerda = False
            JogadorDireita = False
        End If
    End Sub

    Private Sub Original_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loading Inicial
        OpcoesGeral()
    End Sub

    Private Sub OpcoesGeral()
        'Opções de tudo
        CriarInvasores() 'Chama os invasores para poder fazer as pontuações

        'Para todos os invasores faz isto

        PictTiro.Visible = False 'Tiro invisivel

        'Começar de novo
        TimerPrincipal.Enabled = True
        TimerInvasor.Enabled = True
        TempoPartida = 0
        JogadorDireita = False
        JogadorEsquerda = False
        TemporalizadorDeJogo()
    End Sub

    Private Sub MoverTiro()
        If PictTiro.Visible = True Then 'Se o tiro estiver visivel
            PictTiro.Top -= VelocidadeTiro 'O tiro começa a andar para cima
        End If

        'Se da parte de cima da pictorbox até ao "cu" da mesma e for maior que a barra do topo da tela então
        If PictTiro.Top + PictTiro.Height < Me.ClientRectangle.Top Then
            PictTiro.Visible = False 'o tiro fica invisivel
        End If
    End Sub

    Private Sub Original_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        'Pausa
        If e.KeyChar = "p" Or e.KeyChar = "P" Then 'Ao clicar na letra "p"
            If Pausa = True Then 'Se pausa não estiver ativo
                TimerPrincipal.Enabled = True ' Otimer volta a funcionar
                TimerInvasor.Enabled = True ' Otimer volta a funcionar
                Label1.Visible = False 'Label que diz "Pausa fica invisivel"
                Pausa = False 'Pausa fica desativo
            Else
                TimerPrincipal.Enabled = False 'Parar o timer que manda para tudo, daí ser uma pausa
                TimerInvasor.Enabled = False ' Para os invasores de nadar
                Label1.Visible = True 'A laber que diz "Pausa" vai aparecer"
                Pausa = True 'Pausa fica ativo
            End If
        End If

        'Sair
        If e.KeyChar = "x" Or e.KeyChar = "X" Then 'Au clicar na letra "X"
            Me.Close() 'Fecha o formulário
        End If
    End Sub

    Sub TemporalizadorDeJogo()
        'contabiliza o tempo de jogo jogado
        TempoPartida += 1 'Aumenta o tempo jogado
        Label3.Text = "Tempo: " & TempoPartida & " Ms" 'Mostra o tempo jogado em milissegundos
    End Sub

    Private Sub TimerInvasor_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerInvasor.Tick
        'timer do invasor
        MoverInvasor()
    End Sub
End Class