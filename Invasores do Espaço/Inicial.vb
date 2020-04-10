Public Class Inicial
    Dim JogoPontos As Boolean
    Dim DicaRandom As Byte = 1
    Dim DicaTexto As String = ""
    Dim tempo As Byte = 3
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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

    Private Sub Label4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.MouseEnter
        tempo = 3
        Label4.Text = tempo
        Label4.BackColor = Color.Green
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        tempo -= 1
        Label4.Text = tempo
        If tempo = 3 Then
            Label4.BackColor = Color.Green
        End If
        If tempo = 2 Then
            Label4.BackColor = Color.Yellow
        End If
        If tempo = 1 Then
            Label4.BackColor = Color.Red
        End If
        If tempo = 0 Then
            Timer1.Enabled = False
            Label4.Text = "Planeta Games"
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Campanha.Show()
    End Sub
End Class
