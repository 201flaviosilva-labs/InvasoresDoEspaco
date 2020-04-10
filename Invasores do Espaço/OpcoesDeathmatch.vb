Public Class OpcoesDeathmatch

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        'Chek Buton
        If CheckBox1.Checked = True Then 'Se a checkBox 1 estiver ativa
            JogosComExpeciais = True 'Tiro Expecial ativo
        Else
            JogosComExpeciais = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        'Radio Pontos
        ModoDeJogoDeathmatchPontos = True
        ModoDeJogoDeathmatchTempo = False
        ModoDeJogoDeathmatchMorteSubita = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        'Radio Tempo
        ModoDeJogoDeathmatchPontos = False
        ModoDeJogoDeathmatchTempo = True
        ModoDeJogoDeathmatchMorteSubita = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        'Radio Primeira Morte
        ModoDeJogoDeathmatchPontos = False
        ModoDeJogoDeathmatchTempo = False
        ModoDeJogoDeathmatchMorteSubita = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Continuar
        If JogoNumJogadoresMultijogador = 4 Then 'Se 4 jogadores for 4 então
            If ModoDeJogoDeathmatchPontos = True Then 'Pontos
                MsgBox("2 000 Pontos") 'Avisa que o jogo acaba aos 5 000 pontos
            ElseIf ModoDeJogoDeathmatchTempo = True Then 'Tempo
                MsgBox("3 Minutos de jogo") 'Avisa que o jogo acaba aos 3 Minutos
                TempoDeJogoDefinidoTvT = 180  'Jogo acaba aos 180 000 = 3 minutos 
            End If
        Else
            If ModoDeJogoDeathmatchPontos = True Then 'pontos
                MsgBox("1 000 Pontos") 'Avisa que o jogo acaba aos 2 000 pontos
            ElseIf ModoDeJogoDeathmatchTempo = True Then 'Tempo
                MsgBox("2 Minutos de jogo") 'Avisa que o jogo acaba aos 2 minutos
                TempoDeJogoDefinidoTvT = 120  'Jogo acaba aos 120 000 Milisegundos = 2 Minutos
            End If
        End If
        Jogo_Deathmatch.Show()
        ' Jogo_Deathmatch.Show()
    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged
        'Radio 2 Jogadores
        JogoNumJogadoresMultijogador = 2 'Diz que vão jogar 2 jogadores
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        'Radio 4 Jogadores
        JogoNumJogadoresMultijogador = 4
    End Sub

    Private Sub OpcoesDeathmatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Loading Inicial
        RadioButton1.Checked = True
        RadioButton8.Checked = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Multijogador.Show()
        Me.Close()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        'Vs Bots
        ModoDeJogoDeathmatchPontos = False
        ModoDeJogoDeathmatchTempo = False
        ModoDeJogoDeathmatchMorteSubita = False

    End Sub
End Class