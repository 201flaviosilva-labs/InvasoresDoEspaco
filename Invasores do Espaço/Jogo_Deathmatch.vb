Public Class Jogo_Deathmatch
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
    Dim Pausa As Boolean = False 'Define se a pausa está ativa ou não

    'Pontoaçãos
    Dim PontosEquipa1 As Integer = 0 'Define os pontos do jogador 1 + Jogador 3
    Dim PontosEquipa2 As Integer = 0 'Define os pontos do jogador 2 + Jogador 4
    Dim ContadorNumeroInvasoresMortos As Integer ' Contador de número de Invasores mortos
    Dim TempoPartida As Integer = 0 ' Mostra o tempo da partida em millisegundos

    Private Sub TimerPrincipal_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPrincipal.Tick
        'Timer 1 temporalizador
        TemporalizadorDeJogo()
        MoverJogador()
        MoverTiro()
        MatarEquipa2()
        MatarEquipa1()
        GameOver()
    End Sub

    Private Sub Jogo_Deathmatch_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        'Tecla é precionada para baixo

        'Jogador 1 -----------------------------------
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

        'Jogador 2 -------------------------------------------------------------------------------------
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
            PictTiroJ2.Top = PicJogador2.Top + PicJogador2.Width 'A picterbox do tiro vai ter com o topo da nave do jogardor
            PictTiroJ2.Left = PicJogador2.Left + (PicJogador2.Width / 2) - (PictTiroJ2.Width / 2) 'A picterbox do tiro começa a subir no eixo do Y de onde foi lançada
        End If

        'Jogador 3-------------------------------------------------------------
        If JogoPontosNJogadores >= 3 Then 'Se estiver ativo um jogo para 4 jogadores ou mais
            'Ao clicar nas teclas (<- ou ->) permitir mover
            '-> - Direita
            If e.KeyValue = Keys.Right Then
                Jogador3Direita = True 'Permite a ida para Direita
                Jogador3Esquerda = False 'Bloqueia a ida para a Esquerda
            End If

            '<- - Esquerda
            If e.KeyValue = Keys.Left Then
                Jogador3Esquerda = True 'Permite a ida para Esquerda
                Jogador3Direita = False 'Bloqueia a ida para a Direita
            End If

            'up - Tiro
            'Se o espaço for permido e o tiro visiver então
            If ((e.KeyValue = Keys.Up) And (PictTiroJ3.Visible = False)) Then
                PictTiroJ3.Visible = True 'Torna o tiro visivel
                PictTiroJ3.Top = PicJogador3.Top 'A picterbox do tiro vai ter com o topo da nave do jogardor
                PictTiroJ3.Left = PicJogador3.Left + (PicJogador3.Width / 2) - (PictTiroJ3.Width / 2) 'A picterbox do tiro começa a subir no eixo do Y de onde foi lançada
            End If
        End If


        'Jogador 4--------------------------------------------------
        If JogoPontosNJogadores >= 4 Then 'Se estiver ativo um jogo para 4 jogadores ou mais
            'Ao clicar nas teclas (F ou H) permitir mover
            'H - Direita
            If e.KeyValue = Keys.H Then
                Jogador4Direita = True 'Permite a ida para Direita
                Jogador4Esquerda = False 'Bloqueia a ida para a Esquerda
            End If

            'F - Esquerda
            If e.KeyValue = Keys.F Then
                Jogador4Esquerda = True 'Permite a ida para Esquerda
                Jogador4Direita = False 'Bloqueia a ida para a Direita
            End If

            'T - Tiro
            'Se o espaço for permido e o tiro visiver então
            If ((e.KeyValue = Keys.T) And (PictTiroJ4.Visible = False)) Then
                PictTiroJ4.Visible = True 'Torna o tiro visivel
                PictTiroJ4.Top = PicJogador4.Top + PicJogador4.Width 'A picterbox do tiro vai ter com o topo da nave do jogardor
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

    Private Sub Jogo_Deathmatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loading Inicial
        OpcoesGeral()

        If JogoPontosNJogadores >= 3 Then 'Se 3 ou mais jogadores estiver ativos então ativa a visibilidade da pic do jogador e dos pontos
            PicJogador3.Visible = True 'Torna a pic do jogador visivel
        End If
        If JogoPontosNJogadores = 4 Then
            PicJogador4.Visible = True
        End If
    End Sub

    Private Sub OpcoesGeral()
        PictTiroJ1.Visible = False 'Tiro invisivel
        PictTiroJ2.Visible = False 'Tiro invisivel
        PictTiroJ3.Visible = False 'Tiro invisivel
        PictTiroJ4.Visible = False 'Tiro invisivel


        'Começar de novo
        PontosEquipa1 = 0
        PontosEquipa2 = 0
        TempoPartida = 0
        ContadorNumeroInvasoresMortos = 0

        Jogador1Direita = False
        Jogador1Esquerda = False
        Jogador2Direita = False
        Jogador2Esquerda = False

        TimerPrincipal.Enabled = True

        ' RotinaPontuacaoJ1()
        ' RotinaPontuacaoJ2()

        If JogoPontosNJogadores >= 3 Then
            'RotinaPontuacaoJ3()
            Jogador3Direita = False
            Jogador3Esquerda = False
        End If
        If JogoPontosNJogadores = 4 Then
            ' RotinaPontuacaoJ4()
            Jogador4Direita = False
            Jogador4Esquerda = False
        End If
        'TemporalizadorDeJogo()
    End Sub

    Private Sub MatarEquipa2()
        'Rotina da morte do jogador da equipa de cima
        'Tiro do jogador 1
        'Matar Jogador 2
        If (PictTiroJ1.Top + PictTiroJ1.Height >= PicJogador2.Top) And (PictTiroJ1.Top <= PicJogador2.Top + PicJogador2.Height) And (PictTiroJ1.Left + PictTiroJ1.Width >= PicJogador2.Left) And (PictTiroJ1.Left <= PicJogador2.Left + PicJogador2.Width) And (PictTiroJ1.Visible = True) And (PicJogador2.Visible = True) Then
            PictTiroJ1.Visible = False 'Torna o tiro invisivel
            RotinaPontuacaoEquipa1()
        End If

        'Matar Jogador 4
        If (PictTiroJ1.Top + PictTiroJ1.Height >= PicJogador4.Top) And (PictTiroJ1.Top <= PicJogador4.Top + PicJogador4.Height) And (PictTiroJ1.Left + PictTiroJ1.Width >= PicJogador4.Left) And (PictTiroJ1.Left <= PicJogador4.Left + PicJogador4.Width) And (PictTiroJ1.Visible = True) And (PicJogador4.Visible = True) Then
            PictTiroJ1.Visible = False 'Torna o tiro invisivel
            RotinaPontuacaoEquipa1()
        End If



        'Tiro do jogador 3
        'Matar Jogador 2
        If (PictTiroJ3.Top + PictTiroJ3.Height >= PicJogador2.Top) And (PictTiroJ3.Top <= PicJogador2.Top + PicJogador2.Height) And (PictTiroJ3.Left + PictTiroJ3.Width >= PicJogador2.Left) And (PictTiroJ3.Left <= PicJogador2.Left + PicJogador2.Width) And (PictTiroJ3.Visible = True) And (PicJogador2.Visible = True) Then
            PictTiroJ3.Visible = False 'Torna o tiro invisivel
            RotinaPontuacaoEquipa1()
        End If

        'Matar Jogador 4
        If (PictTiroJ3.Top + PictTiroJ3.Height >= PicJogador4.Top) And (PictTiroJ3.Top <= PicJogador4.Top + PicJogador4.Height) And (PictTiroJ3.Left + PictTiroJ3.Width >= PicJogador4.Left) And (PictTiroJ3.Left <= PicJogador4.Left + PicJogador4.Width) And (PictTiroJ3.Visible = True) And (PicJogador4.Visible = True) Then
            PictTiroJ3.Visible = False 'Torna o tiro invisivel
            RotinaPontuacaoEquipa1()
        End If
    End Sub

    Private Sub MatarEquipa1()
        'Rotina da morte do Invasor
        'Tiro do jogador 2
        'Matar Jogador 1
        If (PictTiroJ2.Top + PictTiroJ2.Height >= PicJogador1.Top) And (PictTiroJ2.Top <= PicJogador1.Top + PicJogador1.Height) And (PictTiroJ2.Left + PictTiroJ2.Width >= PicJogador1.Left) And (PictTiroJ2.Left <= PicJogador1.Left + PicJogador1.Width) And (PictTiroJ2.Visible = True) And (PicJogador1.Visible = True) Then
            PictTiroJ2.Visible = False 'Torna o tiro invisivel
            RotinaPontuacaoEquipa2()
        End If

        'Matar Jogador 3
        If (PictTiroJ2.Top + PictTiroJ2.Height >= PicJogador3.Top) And (PictTiroJ2.Top <= PicJogador3.Top + PicJogador3.Height) And (PictTiroJ2.Left + PictTiroJ2.Width >= PicJogador3.Left) And (PictTiroJ2.Left <= PicJogador3.Left + PicJogador3.Width) And (PictTiroJ2.Visible = True) And (PicJogador3.Visible = True) Then
            PictTiroJ2.Visible = False 'Torna o tiro invisivel
            RotinaPontuacaoEquipa2()
        End If


        'Tiro do jogador 4
        'Matar Jogador 1
        If (PictTiroJ4.Top + PictTiroJ4.Height >= PicJogador1.Top) And (PictTiroJ4.Top <= PicJogador1.Top + PicJogador1.Height) And (PictTiroJ4.Left + PictTiroJ4.Width >= PicJogador1.Left) And (PictTiroJ4.Left <= PicJogador1.Left + PicJogador1.Width) And (PictTiroJ4.Visible = True) And (PicJogador1.Visible = True) Then
            PictTiroJ4.Visible = False 'Torna o tiro invisivel
            RotinaPontuacaoEquipa2()
        End If

        'Matar Jogador 3
        If (PictTiroJ4.Top + PictTiroJ4.Height >= PicJogador3.Top) And (PictTiroJ4.Top <= PicJogador3.Top + PicJogador3.Height) And (PictTiroJ4.Left + PictTiroJ4.Width >= PicJogador3.Left) And (PictTiroJ4.Left <= PicJogador3.Left + PicJogador3.Width) And (PictTiroJ4.Visible = True) And (PicJogador3.Visible = True) Then
            PictTiroJ4.Visible = False 'Torna o tiro invisivel
            RotinaPontuacaoEquipa2()
        End If
    End Sub

    Private Sub MoverTiro()
        'Jogador 1
        If PictTiroJ1.Visible = True Then 'Se o tiro estiver visivel
            PictTiroJ1.Top -= VelocidadeTiro 'O tiro começa a andar para cima
        End If

        'Se da parte de cima da pictorbox até ao "cu" da mesma e for maior que a barra do topo da tela então
        If PictTiroJ1.Top + PictTiroJ1.Height <= Me.ClientRectangle.Top Then
            PictTiroJ1.Visible = False 'o tiro fica invisivel
        End If

        'Jogador 2
        If PictTiroJ2.Visible = True Then 'Se o tiro estiver visivel
            PictTiroJ2.Top += VelocidadeTiro 'O tiro começa a andar para cima
        End If

        'Se da parte de cima da pictorbox até ao "cu" da mesma e for maior que a barra do topo da tela então
        If PictTiroJ2.Top + PictTiroJ2.Height >= Me.ClientRectangle.Bottom Then
            PictTiroJ2.Visible = False 'o tiro fica invisivel
        End If


        If JogoPontosNJogadores >= 3 Then
            'Jogador 3
            If PictTiroJ3.Visible = True Then 'Se o tiro estiver visivel
                PictTiroJ3.Top -= VelocidadeTiro 'O tiro começa a andar para cima
            End If

            'Se da parte de cima da pictorbox até ao "cu" da mesma e for maior que a barra do topo da tela então
            If PictTiroJ3.Top + PictTiroJ3.Height <= Me.ClientRectangle.Top Then
                PictTiroJ3.Visible = False 'o tiro fica invisivel
            End If
        End If

        If JogoPontosNJogadores = 4 Then
            'Jogador 4
            If PictTiroJ4.Visible = True Then 'Se o tiro estiver visivel
                PictTiroJ4.Top += VelocidadeTiro 'O tiro começa a andar para cima
            End If

            'Se da parte de cima da pictorbox até ao "cu" da mesma e for maior que a barra do topo da tela então
            If PictTiroJ4.Top + PictTiroJ4.Height >= Me.ClientRectangle.Bottom Then
                PictTiroJ4.Visible = False 'o tiro fica invisivel
            End If
        End If
    End Sub

    Private Sub GameOver()
        'Derrota
       

        'Vitória
        If PontosEquipa1 = 10 Then 'Se o Numero de Invasores Mortos foi igual ao número de invasores "Vitória"
            TimerPrincipal.Enabled = False 'Parar o timer

            NovoJogo() 'Perguntar se quer começar de novo
        End If
    End Sub

    Sub RotinaPontuacaoEquipa1()
        'Pontuação
        PontosEquipa1 += 50 'Por Acertar em algum invasor (Mesmo que não o mate) tambem receberá 50 pontos
        Label1.Text = "Pontos Equipa 1: " & PontosEquipa1 'Escreve os pontos
    End Sub

    Sub RotinaPontuacaoEquipa2()
        'Pontuação
        PontosEquipa2 += 50 'Por Acertar em algum invasor (Mesmo que não o mate) tambem receberá 50 pontos
        Label3.Text = "Pontos Equipa 2: " & PontosEquipa2 'Escreve os pontos
    End Sub

    Sub TemporalizadorDeJogo()
        'contabiliza o tempo de jogo jogado
        TempoPartida += 1 'Aumenta o tempo jogado
        Label4.Text = "Tempo: " & TempoPartida & " Ms" 'Mostra o tempo jogado em milissegundos
    End Sub

    Private Sub NovoJogo()
        Dim jogarNovamente = MsgBox("Queres jogar de novo?", MsgBoxStyle.YesNo) 'Cria variabel que vai receber uma mensagagembox de sim ou não
        If jogarNovamente = MsgBoxResult.Yes Then 'se o resultado for "sim"
            OpcoesGeral() 'Começa de novo
        Else 'Se receber "não"
            Me.Close() 'Fecha o formulário
        End If
    End Sub

    Private Sub Jogo_Deathmatch_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        'Pausa
        If e.KeyChar = "p" Or e.KeyChar = "P" Then 'Ao clicar na letra "p"
            If Pausa = True Then 'Se pausa não estiver ativo
                TimerPrincipal.Enabled = True ' Otimer volta a funcionar
                Label6.Visible = False 'Label que diz "Pausa" fica invisivel"
                Pausa = False 'Pausa fica desativo
            Else
                TimerPrincipal.Enabled = False 'Parar o timer que manda para tudo, daí ser uma pausa
                Label6.Visible = True 'A laber que diz "Pausa" vai aparecer"
                Pausa = True 'Pausa fica ativo
            End If
        End If

        'Sair
        If e.KeyChar = "x" Or e.KeyChar = "X" Then 'Au clicar na letra "X"
            Me.Close() 'Fecha o formulário
        End If
    End Sub

End Class