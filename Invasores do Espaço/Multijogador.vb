Public Class Multijogador
    Dim JogoPontos As Boolean
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Multijogaodr
        Button7.Visible = True
        Button8.Visible = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'Pontos
        JogoPontos = True
        Button9.Visible = True
        Button10.Visible = True
        Button11.Visible = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'quadras
        JogoPontosNJogadores = 4
        If JogoPontos = True Then
            JogoAPontosJvJ.Show()
        Else
            Jogo_Deathmatch.Show()
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'triplas
        JogoPontosNJogadores = 3
        If JogoPontos = True Then
            JogoAPontosJvJ.Show()
        Else
            Jogo_Deathmatch.Show()
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'Duplas
        JogoPontosNJogadores = 2
        If JogoPontos = True Then
            JogoAPontosJvJ.Show()
        Else
            Jogo_Deathmatch.Show()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Voltar
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Pontos
        JogoPontos = False
        Button9.Visible = True
        Button10.Visible = False
        Button11.Visible = True
    End Sub
End Class