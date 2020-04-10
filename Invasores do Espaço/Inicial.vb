Public Class Inicial
    Dim JogoPontos As Boolean
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Jogo_Rapido.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Instrocoes.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button7.Visible = True
        Button8.Visible = True
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'Duplas
        If JogoPontos = True Then
            JogoAPontosJvJ.Show()
            JogoPontosNJogadores = 2
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'PvP
        JogoPontos = False
        Button9.Visible = True
        Button10.Visible = False
        Button11.Visible = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'Pontos
        JogoPontos = True
        Button9.Visible = True
        Button10.Visible = True
        Button11.Visible = True
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'triplas
        If JogoPontos = True Then
            JogoAPontosJvJ.Show()
            JogoPontosNJogadores = 3
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'quadras
        If JogoPontos = True Then
            JogoAPontosJvJ.Show()
            JogoPontosNJogadores = 4
        End If
    End Sub
End Class
