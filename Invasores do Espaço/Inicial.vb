Public Class Inicial
    Dim JogoPontos As Boolean
    Dim DicaRandom As Byte = 1
    Dim DicaTexto As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim JogadrComORato = MsgBox("Queres jogar como Rato?", MsgBoxStyle.YesNo) ' Pergunta se quer jogador com o rato ou não
        If JogadrComORato = MsgBoxResult.Yes Then ' se a escolha tiver sido ism então

            JogoRapridoRato = True 'JOgar com o rato fica disponivel
        Else
            JogoRapridoRato = False 'JOgar com o rato fica indisponivel
        End If
        Jogo_Rapido.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Opcoes.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Multijogaodr
        Multijogador.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Duplas
        If JogoPontos = True Then
            JogoNumJogadoresMultijogador = 2
            Jogo_PvE.Show()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'triplas
        If JogoPontos = True Then
            JogoNumJogadoresMultijogador = 3
            Jogo_PvE.Show()
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'quadras
        If JogoPontos = True Then
            JogoNumJogadoresMultijogador = 4
            Jogo_PvE.Show()
        End If
    End Sub

    Sub SubDicas()
        Randomize()
        DicaRandom = Int(30 * Rnd() + 1) 'Cria um número aleatório inteiro
        Select Case DicaRandom
            Case 1
                DicaTexto = "!"
            Case 2
                DicaTexto = "!!"
            Case 3
                DicaTexto = "!!!"
            Case Else
                DicaTexto = "Clica em 'ajuda' sempre que estiveres com alguma dúvida"
        End Select
        Label3.Text = DicaTexto
    End Sub

    Private Sub Inicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SubDicas()
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        SubDicas()
    End Sub
End Class
