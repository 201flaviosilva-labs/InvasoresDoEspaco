Public Class Multijogador
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Multijogaodr
        Button7.Visible = True
        Button8.Visible = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        'Pontos
        Button5.Visible = True 'Sextas
        Button4.Visible = True 'Quintas
        Button9.Visible = True ' Quadras
        Button10.Visible = True 'Triplas
        Button11.Visible = True 'Duplas
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        'quadras
        JogoNumJogadoresMultijogador = 4
        Jogo_PvE.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        'triplas
        JogoNumJogadoresMultijogador = 3
        Jogo_PvE.Show()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        'Duplas
        JogoNumJogadoresMultijogador = 2
        Jogo_PvE.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Voltar
        Me.Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Team Deathmach
        Button5.Visible = False 'Sextas
        Button4.Visible = False 'Quintas
        Button9.Visible = False 'Quadras
        Button10.Visible = False 'Triplas
        Button11.Visible = False 'Duplas
        OpcoesDeathmatch.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Quintas
        JogoNumJogadoresMultijogador = 5
        Jogo_PvE.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Sextas
        JogoNumJogadoresMultijogador = 6
        Jogo_PvE.Show()
    End Sub
End Class