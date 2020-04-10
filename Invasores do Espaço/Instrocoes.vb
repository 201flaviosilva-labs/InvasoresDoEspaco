Public Class Instrocoes

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Voltar
        Opcoes.Show()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then ' se a escolha tiver sido ism então
            JogoRapridoRato = True 'Jogar com o rato fica disponivel
            MsgBox("Está abilidado jogar com o rato")
        Else
            JogoRapridoRato = False 'Jogar com o rato fica indisponivel
            MsgBox("Está Indisponivel jogar com o rato")
        End If
    End Sub
End Class