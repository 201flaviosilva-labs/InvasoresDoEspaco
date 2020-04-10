Public Class Campanha

    'Exencial para o jogo
    Dim JogadorDireita As Boolean 'Define o movimento do jogador ir para a Direira
    Dim JogadorEsquerda As Boolean 'Define o movimento do jogador ir para a Esquerda
    Dim RatoX As Integer 'Deteta a localização no eixo do X do Rato
    Dim VelocidadeJogador As Integer = 3 'Define a velocidade do jogador
    Dim VelocidadeTiro As Integer = 20 'Define a velocidade do tiro do jogador
    Dim VelocidadeInvasor As Integer = 3 'Define a velocidade de deslocação dos invasores
    Dim IvasorCair As Integer = 50 'Define o degrau que os invasores vão cai em realação ao top
    Dim NumDeInvasores As Integer = 30 ' Escrever quantos invasores pertendo que sejam aparecidos na tela
    Dim InvasorDireita(NumDeInvasores) As Boolean 'Define o movimento dos invasores neste caso para a direita
    Dim Invasores(NumDeInvasores) As PictureBox 'Cria uma PictureBox para cada um dos Invasores que serão criados
    Dim X As Integer 'X = Counter
    Dim Pausa As Boolean = False 'Define se a pausa está ativa ou não

    Dim RandomVidaInvasor(NumDeInvasores) As Integer ' Define o número de tiros que um invasor tem que levar para morrer
    Dim NumeroVidasInvasoresMortas As Integer = 0 'Diz quantas Vidas de invasores há que foram Eliminadas
    Dim SomaDasVidasInvasores As Integer ' Soma de todas as vidas dos invasores

    'Campanha
    Dim Nivel As Integer = 1 'Nivel do jogador
    Dim CriarInvasor1 As Integer = True

    'Pontuações e temporalizador
    Dim TempoPartida As Integer = 0 ' Mostra o tempo da partida em millisegundos
    Dim ContadorNumeroInvasoresMortos As Integer = 0 ' Contador de número de Invasores mortos

    Private Sub TimerPrincipal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPrincipal.Tick
        'Timer 1 temporalizador
        TemporalizadorDeJogo()
        MoverJogador()
        MoverTiro()
        MatarInavasor()
        GameOver()
    End Sub

    Private Sub Campanha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
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

    Private Sub Campanha_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
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

    Private Sub Campanha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loading Inicial
        NivelJogo()
        OpcoesGeral()
    End Sub

    Private Sub OpcoesGeral()
        'Opções de tudo
        SomaDasVidasInvasores = 0 'Leva a soma a 0 para poder recontar de novo

        CriarInvasores() 'Chama os invasores para poder fazer as pontuações

        'Para todos os invasores faz isto
        For Me.X = 1 To NumDeInvasores
            InvasorDireita(X) = True 'Permitir o invasor ir para a direita
            Invasores(X).Left = (-50 * X) - (X * 5) 'Invasores começarem todos na esquerda e fora da tela
            Invasores(X).Top = 0 'Manda os invasores comçar no topo da tela
            Invasores(X).Visible = True 'Torna os invasores visiveis
        Next

        PictTiro.Visible = False 'Tiro invisivel

        'Começar de novo
        TimerPrincipal.Enabled = True
        TimerInvasor.Enabled = True
        TempoPartida = 0
        ContadorNumeroInvasoresMortos = 0
        NumeroVidasInvasoresMortas = 0
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
            If Invasores(X).Top + Invasores(X).Height >= NaveJogador.Top And Invasores(X).Visible = True Then
                TimerPrincipal.Enabled = False 'Parar o timer
                TimerInvasor.Enabled = False 'Parar o timer dos invasores mexerem
                Me.X = NumDeInvasores 'Dizer para parar de fazer o ciclo
                MsgBox("Game Over - A terra foi Invadida") 'Informar que a terra foi invadida e que perdeu
                NovoJogo() 'Perguntar se quer começar de novo
            End If
        Next

        'Vitória
        If NumeroVidasInvasoresMortas = SomaDasVidasInvasores Then 'Se a pontuação foi igual ao número de invasores "Vitória"
            TimerPrincipal.Enabled = False 'Timer parar
            TimerInvasor.Enabled = False 'Parar o timer dos invasores mexerem
            MsgBox("A Terra está Salva") 'Informar que a terra foi salva e que venceu
            Nivel += 1
            MsgBox("Avanças-te para o nivel " & Nivel)
            NovoJogo() 'Perguntar se quer começar de novo
        End If
    End Sub

    Private Sub MatarInavasor()
        'Rotina da morte do Invasor
        For Me.X = 1 To NumDeInvasores
            If (PictTiro.Top + PictTiro.Height >= Invasores(X).Top) And (PictTiro.Top <= Invasores(X).Top + Invasores(X).Height) And (PictTiro.Left + PictTiro.Width >= Invasores(X).Left) And (PictTiro.Left <= Invasores(X).Left + Invasores(X).Width) And (PictTiro.Visible = True) And (Invasores(X).Visible = True) Then

                If RandomVidaInvasor(X) = 1 Then 'Se o invasor atingido tiver vida de 1 então
                    ContadorNumeroInvasoresMortos += 1 'COnta o número de invasores mortos serve apenas para aumentar a pontuação
                    Invasores(X).Visible = False 'O invasor fica invisivel
                    NumeroVidasInvasoresMortas += 1 'Contador de Invasores Mortos
                ElseIf RandomVidaInvasor(X) >= 2 Then 'Senão se o invasor atingido tiver vida de 2 então
                    NumeroVidasInvasoresMortas += 1 'Contador de Invasores Mortos
                End If
                RandomVidaInvasor(X) -= 1 'Retira 1 á vida do invasor, ou para o fazer desaparcer ou para ele perder mais um ponto 

                PictTiro.Visible = False 'Torna o tiro invisivel
            End If
        Next
    End Sub

    Private Sub CriarInvasores()
        'Comçar todos os invasores do lado da tela

        Randomize()
        For Me.X = 1 To NumDeInvasores
            'Cria uma PictureBox para cada um dos invasores que foi ordenado aparecer
            Invasores(X) = New PictureBox

            If CriarInvasor1 = True Then
                RandomVidaInvasor(X) = 1
            Else
                RandomVidaInvasor(X) = 2
            End If

            If CriarInvasor1 = True Then ' se A vida definida do invasor for de 1 então
                SomaDasVidasInvasores += 1 'Aumenta o número de Vida no total de todos os invasores
                Invasores(X).Image = My.Resources.Invasor1 'Vai buscar aos recursos a imagem do invasor
                CriarInvasor1 = False 'Proximo invasor será 2
            ElseIf CriarInvasor1 = False Then ' Caso A vida definida do invasor for de 1 então
                SomaDasVidasInvasores += 2 'Aumenta o número de Vida no total de todos os invasores
                Invasores(X).Image = My.Resources.Invasor2 'Vai buscar aos recursos a imagem do invasor
                CriarInvasor1 = True 'Proximo invasor será 1
            End If

            Invasores(X).Width = 50 'Diz quanto mede a PictureBox
            Invasores(X).Height = 50 'Diz quanto mede a PictureBox
            Invasores(X).BackColor = Color.Transparent 'A PictureBox de cor irá ser transparente
            Invasores(X).SizeMode = PictureBoxSizeMode.StretchImage 'A imagem irá se ajustar á PictureBox
            Controls.Add(Invasores(X)) 'Para fazer os comandos a cima ditos resultar?
        Next
    End Sub

    Private Sub Campanha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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

    Private Sub NovoJogo()
        Dim jogarNovamente = MsgBox("O jogo acabou. será que venceste?", MsgBoxStyle.YesNo) 'Cria variabel que vai receber uma mensagagembox de sim ou não
        If jogarNovamente = MsgBoxResult.Yes Then 'se o resultado for "sim"
            For Me.X = 1 To NumDeInvasores
                Invasores(X).Visible = False 'Esconder todas os invasores que dominaram a terra
            Next
            NivelJogo()
            OpcoesGeral() 'Começa de novo

        Else 'Se receber "não"
            Nivel -= 1
            For Me.X = 1 To NumDeInvasores
                Invasores(X).Visible = False 'Esconder todas os invasores que dominaram a terra
            Next
            NivelJogo()
            OpcoesGeral() 'Começa de novo
        End If

        If Nivel > 3 Then
            VelocidadeInvasor = Nivel
            VelocidadeJogador = Nivel
        End If

        If Nivel > 17 Then
            VelocidadeTiro = Nivel
            VelocidadeInvasor += 1
        End If

        Label2.Text = "Nivel: " & Nivel
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

    Sub NivelJogo()
        If Nivel = 1 Then
            NumDeInvasores = 4
        ElseIf Nivel = 2 Then
            NumDeInvasores = 6
        ElseIf Nivel = 3 Then
            NumDeInvasores = 8
        ElseIf Nivel = 4 Then
            NumDeInvasores = 10
        ElseIf Nivel = 5 Then
            NumDeInvasores = 12
        ElseIf Nivel = 6 Then
            NumDeInvasores = 14
        ElseIf Nivel = 7 Then
            NumDeInvasores = 16
        ElseIf Nivel = 8 Then
            NumDeInvasores = 18
        ElseIf Nivel = 9 Then
            NumDeInvasores = 20
        ElseIf Nivel = 10 Then
            NumDeInvasores = 22
        ElseIf Nivel = 11 Then
            NumDeInvasores = 26
        ElseIf Nivel = 12 Then
            NumDeInvasores = 30
        ElseIf Nivel = 13 Then
            NumDeInvasores = 34
        ElseIf Nivel = 14 Then
            NumDeInvasores = 38
        ElseIf Nivel = 15 Then
            NumDeInvasores = 45
        ElseIf Nivel = 16 Then
            NumDeInvasores = 55
        ElseIf Nivel = 17 Then
            NumDeInvasores = 67
        ElseIf Nivel = 18 Then
            NumDeInvasores = 77
        ElseIf Nivel = 19 Then
            NumDeInvasores = 88
        ElseIf Nivel = 20 Then
            NumDeInvasores = 99
        ElseIf Nivel = 21 Then
            NumDeInvasores = 111
        ElseIf Nivel = 22 Then
            NumDeInvasores = 150
        ElseIf Nivel = 23 Then
            NumDeInvasores = 200
        ElseIf Nivel = 24 Then
            NumDeInvasores = 300
        ElseIf Nivel = 25 Then
            NumDeInvasores = 500
        ElseIf Nivel = 26 Then
            MsgBox("Acabaste de vencer o jogo!")
            MsgBox("Se quiseres começar de novo clica em campanha!")
            Me.Close()
        End If
    End Sub
End Class