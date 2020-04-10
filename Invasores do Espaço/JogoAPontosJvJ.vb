Public Class JogoAPontosJvJ
    'Exencial para o jogo
    Dim Jogador1Direita As Boolean 'Define o movimento do jogador 1 ir para a Direira
    Dim Jogador1Esquerda As Boolean 'Define o movimento do jogador 1 ir para a Esquerda
    Dim Jogador2Direita As Boolean 'Define o movimento do jogador 2 ir para a Direira
    Dim Jogador2Esquerda As Boolean 'Define o movimento do jogador 2 ir para a Esquerda
    Dim Jogador3Direita As Boolean 'Define o movimento do jogador 1 ir para a Direira
    Dim Jogador3Esquerda As Boolean 'Define o movimento do jogador 1 ir para a Esquerda
    Dim Jogador4Direita As Boolean 'Define o movimento do jogador 2 ir para a Direira
    Dim Jogador4Esquerda As Boolean 'Define o movimento do jogador 2 ir para a Esquerda
    Dim VelocidadeJogador As Integer = 3 'Define a velocidade do jogador
    Dim VelocidadeTiro As Integer = 20 'Define a velocidade do tiro do jogador
    Dim VelocidadeInvasor As Integer = 7 'Define a velocidade de deslocação dos invasores
    Dim IvasorCair As Integer = 50 'Define o degrau que os invasores vão cai em realação ao top
    Const NumDeInvasores As Integer = 150 ' Escreve quantos invasores pertendo que sejam aparecidos na tela
    Dim InvasorDireita(NumDeInvasores) As Boolean 'Define o movimento dos invasores neste caso para a direita
    Dim Invasores(NumDeInvasores) As PictureBox 'Cria uma PictureBox para cada um dos Invasores que serão criados
    Dim X As Integer 'X = Counter
    Dim Pausa As Boolean = False 'Define se a pausa está ativa ou não

    Dim RandomVidaInvasor(NumDeInvasores) As Integer ' Define o número de tiros que um invasor tem que levar para morrer
    Dim NumeroVidasInvasoresMortas As Integer = 0 'Diz quantas Vidas de invasores há que foram Eliminadas
    Dim SomaDasVidasInvasores As Integer ' Soma de todas as vidas dos invasores

    'Pontuações e temporalizador
    Dim AlturadaMorte As Double = 0 'Recebe a altura da morte do invasor
    Dim DegrauMorteInvasor As Byte = 0 'Recebe o degrau da morte do invasor
    Dim PontoPorMorte As Double 'Contabiliza o POnto da morte
    Dim PontosJogador1 As Integer = 0 'Define os pontos do jogador 1
    Dim PontosJogador2 As Integer = 0 'Define os pontos do jogador 2
    Dim PontosJogador3 As Integer = 0 'Define os pontos do jogador 3
    Dim PontosJogador4 As Integer = 0 'Define os pontos do jogador 4
    Dim ContadorNumeroInvasoresMortos As Integer ' Contador de número de Invasores mortos
    Dim TempoPartida As Integer = 0 ' Mostra o tempo da partida em millisegundos

    Private Sub TimerPrincipal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPrincipal.Tick
        'Timer 1 temporalizador
        TemporalizadorDeJogo()
        MoverJogador()
        MoverTiro()
        MatarInvasorJ1()
        MatarInvasorJ2()
        MatarInvasorJ3()
        MatarInvasorJ4()
        GameOver()
    End Sub

    Private Sub Invasores_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'Tecla é precionada para baixo

        'Jogador 1
        'Ao clicar nas teclas (A ou D) permitir mover
        'D - Direita
        If e.KeyValue = Keys.D Then
            Jogador1Direita = True 'Permite a ida para Direita
            Jogador1Esquerda = False 'Bloqueia a ida para a Esquerda
        End If

        'A - Esquerda
        If e.KeyValue = Keys.A Then
            Jogador1Esquerda = True 'Permite a ida para Esquerda
            Jogador1Direita = False 'Bloqueia a ida para a Direita
        End If

        'Espaço ou W - Tiro
        'Se o espaço for permido e o tiro visiver então
        If ((e.KeyValue = Keys.W) And (PictTiroJ1.Visible = False)) Then
            PictTiroJ1.Visible = True 'Torna o tiro visivel
            PictTiroJ1.Top = PicJogador1.Top 'A picterbox do tiro vai ter com o topo da nave do jogardor
            PictTiroJ1.Left = PicJogador1.Left + (PicJogador1.Width / 2) - (PictTiroJ1.Width / 2) 'A picterbox do tiro começa a subir no eixo do Y de onde foi lançada
        End If

        'Jogador 2
        'Ao clicar nas teclas (K ou L) permitir mover
        'L - Direita
        If e.KeyValue = Keys.L Then
            Jogador2Direita = True 'Permite a ida para Direita
            Jogador2Esquerda = False 'Bloqueia a ida para a Esquerda
        End If

        'J - Esquerda
        If e.KeyValue = Keys.J Then
            Jogador2Esquerda = True 'Permite a ida para Esquerda
            Jogador2Direita = False 'Bloqueia a ida para a Direita
        End If

        'I - Tiro
        'Se o espaço for permido e o tiro visiver então
        If ((e.KeyValue = Keys.I) And (PictTiroJ2.Visible = False)) Then
            PictTiroJ2.Visible = True 'Torna o tiro visivel
            PictTiroJ2.Top = PicJogador2.Top 'A picterbox do tiro vai ter com o topo da nave do jogardor
            PictTiroJ2.Left = PicJogador2.Left + (PicJogador2.Width / 2) - (PictTiroJ2.Width / 2) 'A picterbox do tiro começa a subir no eixo do Y de onde foi lançada
        End If

        If JogoPontosNJogadores >= 3 Then 'Se estiver ativo um jogo para 3 jogadores
            'Jogador 3
            'Ao clicar nas teclas (F ou H) permitir mover
            'H - Direita
            If e.KeyValue = Keys.H Then
                Jogador3Direita = True 'Permite a ida para Direita
                Jogador3Esquerda = False 'Bloqueia a ida para a Esquerda
            End If

            'F - Esquerda
            If e.KeyValue = Keys.F Then
                Jogador3Esquerda = True 'Permite a ida para Esquerda
                Jogador3Direita = False 'Bloqueia a ida para a Direita
            End If

            'T - Tiro
            'Se o espaço for permido e o tiro visiver então
            If ((e.KeyValue = Keys.T) And (PictTiroJ3.Visible = False)) Then
                PictTiroJ3.Visible = True 'Torna o tiro visivel
                PictTiroJ3.Top = PicJogador3.Top 'A picterbox do tiro vai ter com o topo da nave do jogardor
                PictTiroJ3.Left = PicJogador3.Left + (PicJogador3.Width / 2) - (PictTiroJ3.Width / 2) 'A picterbox do tiro começa a subir no eixo do Y de onde foi lançada
            End If
        End If

        If JogoPontosNJogadores = 4 Then 'Se estiver ativo um jogo para 4 jogadores
            'Jogador 4
            'Ao clicar nas teclas (<- ou ->) permitir mover
            '-> - Direita
            If e.KeyValue = Keys.Right Then
                Jogador4Direita = True 'Permite a ida para Direita
                Jogador4Esquerda = False 'Bloqueia a ida para a Esquerda
            End If

            '<- - Esquerda
            If e.KeyValue = Keys.Left Then
                Jogador4Esquerda = True 'Permite a ida para Esquerda
                Jogador4Direita = False 'Bloqueia a ida para a Direita
            End If

            'up - Tiro
            'Se o espaço for permido e o tiro visiver então
            If ((e.KeyValue = Keys.Up) And (PictTiroJ4.Visible = False)) Then
                PictTiroJ4.Visible = True 'Torna o tiro visivel
                PictTiroJ4.Top = PicJogador4.Top 'A picterbox do tiro vai ter com o topo da nave do jogardor
                PictTiroJ4.Left = PicJogador4.Left + (PicJogador4.Width / 2) - (PictTiroJ4.Width / 2) 'A picterbox do tiro começa a subir no eixo do Y de onde foi lançada
            End If
        End If
    End Sub

    Private Sub MoverJogador()
        'Se estiver permitido mover então anda mais ou mneos um consuante a sua posição
        'Não permite que o jogador passe a tela
        'Jogador 1
        If (Jogador1Direita = True) And (PicJogador1.Left + PicJogador1.Width < Me.ClientRectangle.Width) Then
            PicJogador1.Left += VelocidadeJogador
        End If
        If (Jogador1Esquerda = True) And (PicJogador1.Left > Me.ClientRectangle.Left) Then
            PicJogador1.Left -= VelocidadeJogador
        End If

        'Jogador 2
        If (Jogador2Direita = True) And (PicJogador2.Left + PicJogador2.Width < Me.ClientRectangle.Width) Then
            PicJogador2.Left += VelocidadeJogador
        End If
        If (Jogador2Esquerda = True) And (PicJogador2.Left > Me.ClientRectangle.Left) Then
            PicJogador2.Left -= VelocidadeJogador
        End If



        If JogoPontosNJogadores >= 3 Then 'Se estiver ativo um jogo para 3 jogadores
            'Jogador 3
            If (Jogador3Direita = True) And (PicJogador3.Left + PicJogador3.Width < Me.ClientRectangle.Width) Then
                PicJogador3.Left += VelocidadeJogador
            End If
            If (Jogador3Esquerda = True) And (PicJogador3.Left > Me.ClientRectangle.Left) Then
                PicJogador3.Left -= VelocidadeJogador
            End If
        End If

        If JogoPontosNJogadores = 4 Then 'Se estiver ativo um jogo para 4 jogadores
            'Jogador 4
            If (Jogador4Direita = True) And (PicJogador4.Left + PicJogador4.Width < Me.ClientRectangle.Width) Then
                PicJogador4.Left += VelocidadeJogador
            End If
            If (Jogador4Esquerda = True) And (PicJogador4.Left > Me.ClientRectangle.Left) Then
                PicJogador4.Left -= VelocidadeJogador
            End If
        End If
    End Sub

    Private Sub Invasores_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        'Tecla é levantada
        'Bloqueia a permiçao de mover
        'Jogador 1
        'D - Direita
        If e.KeyValue = Keys.D Then
            'Bloqueia o movimento para a esquerda e para a direita
            Jogador1Direita = False
            Jogador1Esquerda = False
        End If

        'A - Esquerda
        If e.KeyValue = Keys.A Then
            'Bloqueia o movimento para a esquerda e para a direita
            Jogador1Esquerda = False
            Jogador1Direita = False
        End If

        'Jogador 2
        'L - Direita
        If e.KeyValue = Keys.L Then
            'Bloqueia o movimento para a esquerda e para a direita
            Jogador2Direita = False
            Jogador2Esquerda = False
        End If

        'J - Esquerda
        If e.KeyValue = Keys.J Then
            'Bloqueia o movimento para a esquerda e para a direita
            Jogador2Esquerda = False
            Jogador2Direita = False
        End If



        If JogoPontosNJogadores >= 3 Then 'Se estiver ativo um jogo para 3 jogadores
            'Jogador 3
            'H - Direita
            If e.KeyValue = Keys.H Then
                'Bloqueia o movimento para a esquerda e para a direita
                Jogador3Direita = False
                Jogador3Esquerda = False
            End If

            'F - Esquerda
            If e.KeyValue = Keys.F Then
                'Bloqueia o movimento para a esquerda e para a direita
                Jogador3Esquerda = False
                Jogador3Direita = False
            End If
        End If

        If JogoPontosNJogadores = 4 Then 'Se estiver ativo um jogo para 4 jogadores
            'Jogador 4
            '-> - Direita
            If e.KeyValue = Keys.Right Then
                'Bloqueia o movimento para a esquerda e para a direita
                Jogador4Direita = False
                Jogador4Esquerda = False
            End If

            '<- - Esquerda
            If e.KeyValue = Keys.Left Then
                'Bloqueia o movimento para a esquerda e para a direita
                Jogador4Esquerda = False
                Jogador4Direita = False
            End If
        End If
    End Sub

    Private Sub Invasores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loading Inicial
        OpcoesGeral()

        If JogoPontosNJogadores >= 3 Then 'Se 3 ou mais jogadores estiver ativos então ativa a visibilidade da pic do jogador e dos pontos
            PicJogador3.Visible = True 'Torna a pic do jogador visivel
            Label5.Visible = True 'Torna a label dos pontos visivel
        End If
        If JogoPontosNJogadores = 4 Then
            PicJogador4.Visible = True
            Label6.Visible = True
        End If
    End Sub

    Private Sub OpcoesGeral()
        'Opções de tudo (Quase)
        SomaDasVidasInvasores = 0 'Leva a soma a 0 para poder recontar de novo

        OpcoesInvasores()

        'Para todos os invasores faz isto
        For Me.X = 1 To NumDeInvasores
            InvasorDireita(X) = True 'Permitir o invasor ir para a direita
            Invasores(X).Left = (-50 * X) - (X * 5) 'Invasores começarem todos na esquerda e fora da tela
            Invasores(X).Top = 0 'Manda os invasores comçar no topo da tela
            Invasores(X).Visible = True 'Torna os invasores visiveis
        Next

        PictTiroJ1.Visible = False 'Tiro invisivel
        PictTiroJ2.Visible = False 'Tiro invisivel
        PictTiroJ3.Visible = False 'Tiro invisivel
        PictTiroJ4.Visible = False 'Tiro invisivel


        'Começar de novo
        PontosJogador1 = -50 ' Porque logo ao iniciar ele já irá começar com 50 pontos, então para começar com 0 tenho que tirar 50 pontos inicalmente
        PontosJogador2 = -50 ' Porque logo ao iniciar ele já irá começar com 50 pontos, então para começar com 0 tenho que tirar 50 pontos inicalmente
        PontosJogador3 = -50 ' Porque logo ao iniciar ele já irá começar com 50 pontos, então para começar com 0 tenho que tirar 50 pontos inicalmente
        PontosJogador4 = -50 ' Porque logo ao iniciar ele já irá começar com 50 pontos, então para começar com 0 tenho que tirar 50 pontos inicalmente
        TempoPartida = 0
        PontoPorMorte = 0
        ContadorNumeroInvasoresMortos = 0
        NumeroVidasInvasoresMortas = 0

        Jogador1Direita = False
        Jogador1Esquerda = False
        Jogador2Direita = False
        Jogador2Esquerda = False

        TimerPrincipal.Enabled = True
        TimerInvasores.Enabled = True

        RotinaPontuacaoJ1()
        RotinaPontuacaoJ2()

        If JogoPontosNJogadores >= 3 Then
            RotinaPontuacaoJ3()
            Jogador3Direita = False
            Jogador3Esquerda = False
        End If
        If JogoPontosNJogadores = 4 Then
            RotinaPontuacaoJ4()
            Jogador4Direita = False
            Jogador4Esquerda = False
        End If
        TemporalizadorDeJogo()
    End Sub

    Private Sub MoverTiro()
        'Jogador 1
        If PictTiroJ1.Visible = True Then 'Se o tiro estiver visivel
            PictTiroJ1.Top -= VelocidadeTiro 'O tiro começa a andar para cima
        End If

        'Se da parte de cima da pictorbox até ao "cu" da mesma e for maior que a barra do topo da tela então
        If PictTiroJ1.Top + PictTiroJ1.Height < Me.ClientRectangle.Top Then
            PictTiroJ1.Visible = False 'o tiro fica invisivel
        End If

        'Jogador 2
        If PictTiroJ2.Visible = True Then 'Se o tiro estiver visivel
            PictTiroJ2.Top -= VelocidadeTiro 'O tiro começa a andar para cima
        End If

        'Se da parte de cima da pictorbox até ao "cu" da mesma e for maior que a barra do topo da tela então
        If PictTiroJ2.Top + PictTiroJ2.Height < Me.ClientRectangle.Top Then
            PictTiroJ2.Visible = False 'o tiro fica invisivel
        End If


        If JogoPontosNJogadores >= 3 Then
            If PictTiroJ3.Visible = True Then 'Se o tiro estiver visivel
                PictTiroJ3.Top -= VelocidadeTiro 'O tiro começa a andar para cima
            End If

            'Se da parte de cima da pictorbox até ao "cu" da mesma e for maior que a barra do topo da tela então
            If PictTiroJ3.Top + PictTiroJ3.Height < Me.ClientRectangle.Top Then
                PictTiroJ3.Visible = False 'o tiro fica invisivel
            End If
        End If
        If JogoPontosNJogadores = 4 Then
            If PictTiroJ4.Visible = True Then 'Se o tiro estiver visivel
                PictTiroJ4.Top -= VelocidadeTiro 'O tiro começa a andar para cima
            End If

            'Se da parte de cima da pictorbox até ao "cu" da mesma e for maior que a barra do topo da tela então
            If PictTiroJ4.Top + PictTiroJ4.Height < Me.ClientRectangle.Top Then
                PictTiroJ4.Visible = False 'o tiro fica invisivel
            End If
        End If
    End Sub

    Private Sub MoverInvasor()
        'Cria um ciclo para todos os invesores que foi ordenado existirem
        For Me.X = 1 To NumDeInvasores
            If InvasorDireita(X) = True Then 'Se o invasor estiver a ir para a direita ou seja a Direita esiver Ativa
                Invasores(X).Left += VelocidadeInvasor 'Manda os invasores delocarem para a Direita

            Else 'Se o invasor estiver a ir para a Esquerda ou seja a Dirita esiver ATIVADA
                Invasores(X).Left -= VelocidadeInvasor 'Manda os invasores delocarem para a Esquerda
            End If

            'Se de um lado ao outro do invasor, da direita para a esquerda, o tamanho do invasor estiver a tocar na direita da tela, e o invasor estiver direcionado para a direita, então
            If Invasores(X).Left + Invasores(X).Width > Me.ClientRectangle.Width And InvasorDireita(X) = True Then
                InvasorDireita(X) = False 'Andar para a dirita fica DESATIVADO
                Invasores(X).Top += IvasorCair 'Manda o invasor cair um degrau em relação ao topo
            End If

            'Se a Esquerda do invasor estiver  tocar na esqueda da tela, e o invasor estiver direcionado para a Esquerda, então
            If Invasores(X).Left < Me.ClientRectangle.Left And InvasorDireita(X) = False Then
                InvasorDireita(X) = True 'Andar para a dirita fica ATIVO
                Invasores(X).Top += IvasorCair 'Manda o invasor cair um degrau em relação ao topo
            End If
        Next
    End Sub

    Private Sub GameOver()
        'Derrota
        For Me.X = 1 To NumDeInvasores
            'Se algum invasor atingir o bico da nave, então o jogo acaba
            If Invasores(X).Top + Invasores(X).Height >= PicJogador1.Top And Invasores(X).Visible = True Then
                TimerPrincipal.Enabled = False 'Parar o timer
                TimerInvasores.Enabled = False 'parar os invasores de andar
                Me.X = NumDeInvasores 'Dizer para parar de fazer o ciclo
                MsgBox("Game Over - A terra foi Invadida") 'Informar que a terra foi invadida e que perdeu
                NovoJogo() 'Perguntar se quer começar de novo
            End If
        Next

        'Vitória
        If ContadorNumeroInvasoresMortos = NumDeInvasores Then 'Se o Numero de Invasores Mortos foi igual ao número de invasores "Vitória"
            TimerPrincipal.Enabled = False 'Parar o timer
            TimerInvasores.Enabled = False 'Parar o timer
            If (PontosJogador1 > PontosJogador2) And (PontosJogador1 > PontosJogador3) And (PontosJogador1 > PontosJogador4) Then 'Se  jogador 1 tiver menos pontos que o jogador 2 e jogador 1 tiver menos pontos que o jogador 3 e jogador 1 tiver menos pontos que o jogador 4
                MsgBox("Joador 1 venceu") 'jogador 2 venceu
            ElseIf (PontosJogador2 > PontosJogador1) And (PontosJogador2 > PontosJogador3) And (PontosJogador2 > PontosJogador4) Then
                MsgBox("Joador 2 venceu") 'jogador 1 venceu
            ElseIf (PontosJogador3 > PontosJogador1) And (PontosJogador3 > PontosJogador2) And (PontosJogador3 > PontosJogador4) Then
                MsgBox("Joador 3 venceu") 'jogador 3 venceu
            ElseIf (PontosJogador4 > PontosJogador1) And (PontosJogador4 > PontosJogador2) And (PontosJogador4 > PontosJogador3) Then
                MsgBox("Joador 4 venceu") 'jogador 4 venceu
            Else
                MsgBox("Empate") 'Empate
            End If
            NovoJogo() 'Perguntar se quer começar de novo
        End If
    End Sub

    Private Sub MatarInvasorJ1()
        'Rotina da morte do Invasor
        For Me.X = 1 To NumDeInvasores
            If (PictTiroJ1.Top + PictTiroJ1.Height >= Invasores(X).Top) And (PictTiroJ1.Top <= Invasores(X).Top + Invasores(X).Height) And (PictTiroJ1.Left + PictTiroJ1.Width >= Invasores(X).Left) And (PictTiroJ1.Left <= Invasores(X).Left + Invasores(X).Width) And (PictTiroJ1.Visible = True) And (Invasores(X).Visible = True) Then

                If RandomVidaInvasor(X) = 1 Then 'Se o invasor atingido tiver vida de 1 então
                    ContadorNumeroInvasoresMortos += 1 'COnta o número de invasores mortos serve apenas para aumentar a pontuação
                    PontuacaoPorDegrauJ1() 'Para apenas ganhar pontos quando matar o invasor
                    Invasores(X).Visible = False 'O invasor fica invisivel
                    NumeroVidasInvasoresMortas += 1 'Contador de Invasores Mortos
                    RotinaPontuacaoJ1() 'Chama a rotina da pontuação para mostrar os pontos
                ElseIf RandomVidaInvasor(X) >= 2 Then 'Senão se o invasor atingido tiver vida de 2 então
                    NumeroVidasInvasoresMortas += 1 'Contador de Invasores Mortos
                    RotinaPontuacaoJ1() 'Chama a rotina da pontuação para mostrar os pontos
                End If
                RandomVidaInvasor(X) -= 1 'Retira 1 á vida do invasor, ou para o fazer desaparcer ou para ele perder mais um ponto 

                PictTiroJ1.Visible = False 'Torna o tiro invisivel
            End If
        Next
    End Sub

    Private Sub MatarInvasorJ2()
        'Rotina da morte do Invasor
        For Me.X = 1 To NumDeInvasores
            If (PictTiroJ2.Top + PictTiroJ2.Height >= Invasores(X).Top) And (PictTiroJ2.Top <= Invasores(X).Top + Invasores(X).Height) And (PictTiroJ2.Left + PictTiroJ2.Width >= Invasores(X).Left) And (PictTiroJ2.Left <= Invasores(X).Left + Invasores(X).Width) And (PictTiroJ2.Visible = True) And (Invasores(X).Visible = True) Then

                If RandomVidaInvasor(X) = 1 Then 'Se o invasor atingido tiver vida de 1 então
                    ContadorNumeroInvasoresMortos += 1 'COnta o número de invasores mortos serve apenas para aumentar a pontuação
                    PontuacaoPorDegrauJ2() 'Para apenas ganhar pontos quando matar o invasor
                    Invasores(X).Visible = False 'O invasor fica invisivel
                    NumeroVidasInvasoresMortas += 1 'Contador de Invasores Mortos
                    RotinaPontuacaoJ2() 'Chama a rotina da pontuação para mostrar os pontos
                ElseIf RandomVidaInvasor(X) >= 2 Then 'Senão se o invasor atingido tiver vida de 2 então
                    NumeroVidasInvasoresMortas += 1 'Contador de Invasores Mortos
                    RotinaPontuacaoJ2() 'Chama a rotina da pontuação para mostrar os pontos
                End If
                RandomVidaInvasor(X) -= 1 'Retira 1 á vida do invasor, ou para o fazer desaparcer ou para ele perder mais um ponto 

                PictTiroJ2.Visible = False 'Torna o tiro invisivel
            End If
        Next
    End Sub

    Private Sub MatarInvasorJ3()
        'Rotina da morte do Invasor
        If JogoPontosNJogadores >= 3 Then
            For Me.X = 1 To NumDeInvasores
                If (PictTiroJ3.Top + PictTiroJ3.Height >= Invasores(X).Top) And (PictTiroJ3.Top <= Invasores(X).Top + Invasores(X).Height) And (PictTiroJ3.Left + PictTiroJ3.Width >= Invasores(X).Left) And (PictTiroJ3.Left <= Invasores(X).Left + Invasores(X).Width) And (PictTiroJ3.Visible = True) And (Invasores(X).Visible = True) Then

                    If RandomVidaInvasor(X) = 1 Then 'Se o invasor atingido tiver vida de 1 então
                        ContadorNumeroInvasoresMortos += 1 'COnta o número de invasores mortos serve apenas para aumentar a pontuação
                        PontuacaoPorDegrauJ3() 'Para apenas ganhar pontos quando matar o invasor
                        Invasores(X).Visible = False 'O invasor fica invisivel
                        NumeroVidasInvasoresMortas += 1 'Contador de Invasores Mortos
                        RotinaPontuacaoJ3() 'Chama a rotina da pontuação para mostrar os pontos
                    ElseIf RandomVidaInvasor(X) >= 2 Then 'Senão se o invasor atingido tiver vida de 2 então
                        NumeroVidasInvasoresMortas += 1 'Contador de Invasores Mortos
                        RotinaPontuacaoJ3() 'Chama a rotina da pontuação para mostrar os pontos
                    End If
                    RandomVidaInvasor(X) -= 1 'Retira 1 á vida do invasor, ou para o fazer desaparcer ou para ele perder mais um ponto 

                    PictTiroJ3.Visible = False 'Torna o tiro invisivel
                End If
            Next
        End If
    End Sub

    Private Sub MatarInvasorJ4()
        'Rotina da morte do Invasor
        If JogoPontosNJogadores = 4 Then
            For Me.X = 1 To NumDeInvasores
                If (PictTiroJ4.Top + PictTiroJ4.Height >= Invasores(X).Top) And (PictTiroJ4.Top <= Invasores(X).Top + Invasores(X).Height) And (PictTiroJ4.Left + PictTiroJ4.Width >= Invasores(X).Left) And (PictTiroJ4.Left <= Invasores(X).Left + Invasores(X).Width) And (PictTiroJ4.Visible = True) And (Invasores(X).Visible = True) Then

                    If RandomVidaInvasor(X) = 1 Then 'Se o invasor atingido tiver vida de 1 então
                        ContadorNumeroInvasoresMortos += 1 'COnta o número de invasores mortos serve apenas para aumentar a pontuação
                        PontuacaoPorDegrauJ4() 'Para apenas ganhar pontos quando matar o invasor
                        Invasores(X).Visible = False 'O invasor fica invisivel
                        NumeroVidasInvasoresMortas += 1 'Contador de Invasores Mortos
                        RotinaPontuacaoJ4() 'Chama a rotina da pontuação para mostrar os pontos
                    ElseIf RandomVidaInvasor(X) >= 2 Then 'Senão se o invasor atingido tiver vida de 2 então
                        NumeroVidasInvasoresMortas += 1 'Contador de Invasores Mortos
                        RotinaPontuacaoJ4() 'Chama a rotina da pontuação para mostrar os pontos
                    End If
                    RandomVidaInvasor(X) -= 1 'Retira 1 á vida do invasor, ou para o fazer desaparcer ou para ele perder mais um ponto 

                    PictTiroJ4.Visible = False 'Torna o tiro invisivel
                End If
            Next
        End If
    End Sub

    Sub PontuacaoPorDegrauJ1()
        If Invasores(X).Visible = True Then 'Se o invasor atingido ainda estiver viivel
            AlturadaMorte = Invasores(X).Top 'Recebe a altura da morte do invasor
            'Degrau = fila
            If AlturadaMorte <= 0 Then 'Primeira fila (onde os dudes nascem)
                DegrauMorteInvasor = 1 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 50 Then 'Segunda Fila
                DegrauMorteInvasor = 2 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 100 Then 'Terceira Fila
                DegrauMorteInvasor = 4 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 150 Then 'Quarta Fila
                DegrauMorteInvasor = 6 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 200 Then 'Quinta Fila
                DegrauMorteInvasor = 8 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 250 Then 'Sesta Fila
                DegrauMorteInvasor = 10 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 300 Then 'Setima Fila
                DegrauMorteInvasor = 12 'Diz quanto via dividir por ter morto neste degrau
            End If
            PontoPorMorte = 1200 / DegrauMorteInvasor 'Divide a pontuação por invasor morto na sua fila
            ' 1 - 1 200
            ' 2 - 600
            ' 3 - 300
            ' 4 - 200
            ' 5 - 150
            ' 6 - 120
            ' 7 - 100
            PontosJogador1 += PontoPorMorte 'Aumenta a Pontuação do jogador
            PontosJogador1 += ContadorNumeroInvasoresMortos * 100 'Aumenta os pontos em relação aos invasores mortos
            ' 1 - 100 - +100
            ' 2 - 300 - +200
            ' 3 - 600 - +300
            ' 4 - 1 000 - +400
            ' 5 - 1 500 - +500
            ' 6 - 2 100 - +600
            ' 7 - 2 800 - +700
            '...
        End If
    End Sub

    Sub PontuacaoPorDegrauJ2()
        If Invasores(X).Visible = True Then 'Se o invasor atingido ainda estiver viivel
            AlturadaMorte = Invasores(X).Top 'Recebe a altura da morte do invasor

            'Degrau = fila
            If AlturadaMorte <= 0 Then 'Primeira fila (onde os dudes nascem)
                DegrauMorteInvasor = 1 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 50 Then 'Segunda Fila
                DegrauMorteInvasor = 2 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 100 Then 'Terceira Fila
                DegrauMorteInvasor = 4 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 150 Then 'Quarta Fila
                DegrauMorteInvasor = 6 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 200 Then 'Quinta Fila
                DegrauMorteInvasor = 8 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 250 Then 'Sesta Fila
                DegrauMorteInvasor = 10 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 300 Then 'Setima Fila
                DegrauMorteInvasor = 12 'Diz quanto via dividir por ter morto neste degrau
            End If
            PontoPorMorte = 1200 / DegrauMorteInvasor 'Divide a pontuação por invasor morto na sua fila
            ' 1 - 1 200
            ' 2 - 600
            ' 3 - 300
            ' 4 - 200
            ' 5 - 150
            ' 6 - 120
            ' 7 - 100
            PontosJogador2 += PontoPorMorte 'Aumenta a Pontuação do jogador
            PontosJogador2 += ContadorNumeroInvasoresMortos * 100 'Aumenta os pontos em relação aos invasores mortos
            ' 1 - 100 - +100
            ' 2 - 300 - +200
            ' 3 - 600 - +300
            ' 4 - 1 000 - +400
            ' 5 - 1 500 - +500
            ' 6 - 2 100 - +600
            ' 7 - 2 800 - +700
            '...
        End If
    End Sub

    Sub PontuacaoPorDegrauJ3()
        If Invasores(X).Visible = True Then 'Se o invasor atingido ainda estiver viivel
            AlturadaMorte = Invasores(X).Top 'Recebe a altura da morte do invasor

            'Degrau = fila
            If AlturadaMorte <= 0 Then 'Primeira fila (onde os dudes nascem)
                DegrauMorteInvasor = 1 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 50 Then 'Segunda Fila
                DegrauMorteInvasor = 2 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 100 Then 'Terceira Fila
                DegrauMorteInvasor = 4 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 150 Then 'Quarta Fila
                DegrauMorteInvasor = 6 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 200 Then 'Quinta Fila
                DegrauMorteInvasor = 8 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 250 Then 'Sesta Fila
                DegrauMorteInvasor = 10 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 300 Then 'Setima Fila
                DegrauMorteInvasor = 12 'Diz quanto via dividir por ter morto neste degrau
            End If
            PontoPorMorte = 1200 / DegrauMorteInvasor 'Divide a pontuação por invasor morto na sua fila
            ' 1 - 1 200
            ' 2 - 600
            ' 3 - 300
            ' 4 - 200
            ' 5 - 150
            ' 6 - 120
            ' 7 - 100
            PontosJogador3 += PontoPorMorte 'Aumenta a Pontuação do jogador
            PontosJogador3 += ContadorNumeroInvasoresMortos * 100 'Aumenta os pontos em relação aos invasores mortos
            ' 1 - 100 - +100
            ' 2 - 300 - +200
            ' 3 - 600 - +300
            ' 4 - 1 000 - +400
            ' 5 - 1 500 - +500
            ' 6 - 2 100 - +600
            ' 7 - 2 800 - +700
            '...
        End If
    End Sub

    Sub PontuacaoPorDegrauJ4()
        If Invasores(X).Visible = True Then 'Se o invasor atingido ainda estiver viivel
            AlturadaMorte = Invasores(X).Top 'Recebe a altura da morte do invasor

            'Degrau = fila
            If AlturadaMorte <= 0 Then 'Primeira fila (onde os dudes nascem)
                DegrauMorteInvasor = 1 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 50 Then 'Segunda Fila
                DegrauMorteInvasor = 2 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 100 Then 'Terceira Fila
                DegrauMorteInvasor = 4 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 150 Then 'Quarta Fila
                DegrauMorteInvasor = 6 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 200 Then 'Quinta Fila
                DegrauMorteInvasor = 8 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 250 Then 'Sesta Fila
                DegrauMorteInvasor = 10 'Diz quanto via dividir por ter morto neste degrau
            ElseIf AlturadaMorte <= 300 Then 'Setima Fila
                DegrauMorteInvasor = 12 'Diz quanto via dividir por ter morto neste degrau
            End If
            PontoPorMorte = 1200 / DegrauMorteInvasor 'Divide a pontuação por invasor morto na sua fila
            ' 1 - 1 200
            ' 2 - 600
            ' 3 - 300
            ' 4 - 200
            ' 5 - 150
            ' 6 - 120
            ' 7 - 100
            PontosJogador4 += PontoPorMorte 'Aumenta a Pontuação do jogador
            PontosJogador4 += ContadorNumeroInvasoresMortos * 100 'Aumenta os pontos em relação aos invasores mortos
            ' 1 - 100 - +100
            ' 2 - 300 - +200
            ' 3 - 600 - +300
            ' 4 - 1 000 - +400
            ' 5 - 1 500 - +500
            ' 6 - 2 100 - +600
            ' 7 - 2 800 - +700
            '...
        End If
    End Sub

    Sub RotinaPontuacaoJ1()
        'Pontuação
        PontosJogador1 += 50 'Por Acertar em algum invasor (Mesmo que não o mate) tambem receberá 50 pontos
        Label2.Text = PontosJogador1 'Escreve os pontos
    End Sub

    Sub RotinaPontuacaoJ2()
        'Pontuação
        PontosJogador2 += 50 'Por Acertar em algum invasor (Mesmo que não o mate) tambem receberá 50 pontos
        Label4.Text = PontosJogador2 'Escreve os pontos
    End Sub

    Sub RotinaPontuacaoJ3()
        'Pontuação
        PontosJogador3 += 50 'Por Acertar em algum invasor (Mesmo que não o mate) tambem receberá 50 pontos
        Label5.Text = PontosJogador3 'Escreve os pontos
    End Sub

    Sub RotinaPontuacaoJ4()
        'Pontuação
        PontosJogador4 += 50 'Por Acertar em algum invasor (Mesmo que não o mate) tambem receberá 50 pontos
        Label6.Text = PontosJogador4 'Escreve os pontos
    End Sub

    Private Sub OpcoesInvasores()
        'Comçar todos os invasores do lado da tela
        Randomize()
        For Me.X = 1 To NumDeInvasores
            'Cria uma PictureBox para cada um dos invasores que foi ordenado aparecer
            Invasores(X) = New PictureBox

            RandomVidaInvasor(X) = Int(2 * Rnd() + 1) 'Cria um número random
            If RandomVidaInvasor(X) = 1 Then ' se A vida definida do invasor for de 1 então
                SomaDasVidasInvasores += 1 'Aumenta o número de Vida no total de todos os invasores
                Invasores(X).Image = My.Resources.Invasor1 'Vai buscar aos recursos a imagem do invasor
            ElseIf RandomVidaInvasor(X) = 2 Then ' Caso A vida definida do invasor for de 1 então
                SomaDasVidasInvasores += 2 'Aumenta o número de Vida no total de todos os invasores
                Invasores(X).Image = My.Resources.Invasor2 'Vai buscar aos recursos a imagem do invasor
            End If

            Invasores(X).Width = 50 'Diz quanto mede a PictureBox
            Invasores(X).Height = 50 'Diz quanto mede a PictureBox
            Invasores(X).BackColor = Color.Transparent 'A PictureBox de cor irá ser transparente
            Invasores(X).SizeMode = PictureBoxSizeMode.StretchImage 'A imagem irá se ajustar á PictureBox
            Controls.Add(Invasores(X)) 'Para fazer os comandos a cima ditos resultar
        Next
    End Sub

    Sub TemporalizadorDeJogo()
        'contabiliza o tempo de jogo jogado
        TempoPartida += 1 'Aumenta o tempo jogado
        Label3.Text = "Tempo: " & TempoPartida & " Ms" 'Mostra o tempo jogado em milissegundos
    End Sub

    Private Sub NovoJogo()
        Dim jogarNovamente = MsgBox("Queres jogar de novo?", MsgBoxStyle.YesNo) 'Cria variabel que vai receber uma mensagagembox de sim ou não
        If jogarNovamente = MsgBoxResult.Yes Then 'se o resultado for "sim"
            For Me.X = 1 To NumDeInvasores
                Invasores(X).Visible = False 'Esconder todas os invasores que dominaram a terra
            Next
            OpcoesGeral() 'Começa de novo
        Else 'Se receber "não"
            Me.Close() 'Fecha o formulário
        End If
    End Sub

    Private Sub Invasores_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        'Pausa
        If e.KeyChar = "p" Or e.KeyChar = "P" Then 'Ao clicar na letra "p"
            If Pausa = True Then 'Se pausa não estiver ativo
                TimerPrincipal.Enabled = True 'Parar o timer que manda para tudo, daí ser uma pausa
                TimerInvasores.Enabled = True ' Para os invasores de nadar
                Label1.Visible = False 'Label que diz "Pausa fica visivel"
                Pausa = False 'Pausa fica ativo
            Else
                TimerPrincipal.Enabled = False 'O timer volta a funcionar
                TimerInvasores.Enabled = False 'O timer volta a funcionar
                Label1.Visible = True 'A laber que diz "Pausa vai desaparecer"
                Pausa = True 'Pausa fica desativo e pronto para ser ativo quando voltar a clicar no "P"
            End If
        End If

        'Sair
        If e.KeyChar = "x" Or e.KeyChar = "X" Then 'Au clicar na letra "X"
            Me.Close() 'Fecha o formulário
        End If
    End Sub

    Private Sub TimerInvasores_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerInvasores.Tick
        'timer que move os invasores
        MoverInvasor()
    End Sub

End Class