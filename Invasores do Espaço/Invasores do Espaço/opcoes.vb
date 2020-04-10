Public Class opcoes

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'v.jogador
        VelocidadeJogadorAlteravel = InputBox("Diz a velociade do Jogador:")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'v.Tiro
        VelociadeTiroAlteravel = InputBox("Diz a velociade do Tiro:")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'v.Invasores
        VelocidadeInvasoresAlteravel = InputBox("Diz a velociade do Invasores:")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'v.N. Invasores
        VelocidadeNumeroInvasoresAlteravel = InputBox("Diz a velociade do Invasores:")
    End Sub
End Class