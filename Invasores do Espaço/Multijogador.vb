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
        Button5.Visible = True 'Sextas
        Button4.Visible = True 'Quintas
        Button9.Visible = True ' Quadras
        Button10.Visible = True 'Triplas
        Button11.Visible = True 'Duplas
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
        Button5.Visible = False 'Sextas
        Button4.Visible = False 'Quintas
        Button9.Visible = True 'Quadras
        Button10.Visible = False 'Triplas
        Button11.Visible = True 'Duplas
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Quintas
        JogoPontosNJogadores = 5
        If JogoPontos = True Then
            JogoAPontosJvJ.Show()
        Else
            Jogo_Deathmatch.Show()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Sextas
        JogoPontosNJogadores = 6
        If JogoPontos = True Then
            JogoAPontosJvJ.Show()
        Else
            Jogo_Deathmatch.Show()
        End If
    End Sub
End Class