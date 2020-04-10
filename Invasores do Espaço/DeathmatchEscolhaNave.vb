Public Class DeathmatchEscolhaNave
    Dim NaveJogador(4) As Byte
    Private Sub DeathmatchEscolhaNave_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        'Jogador 1
        If e.KeyValue = Keys.D Then 'Se a Tecla d For permida
            NaveJogador(1) += 1 'Aumenta um na Seleçã da Nave do jogador
            If NaveJogador(1) >= 4 Then 'A nave do jogador não pode ser maior que 4
                NaveJogador(1) = 4
            End If
            If NaveJogador(1) = 1 Then 'Mostra qual é a nve do jogador selecionada
                PicJogador1.Image = My.Resources.Nave1
            ElseIf NaveJogador(1) = 2 Then
                PicJogador1.Image = My.Resources.Nave2
            ElseIf NaveJogador(1) = 3 Then
                PicJogador1.Image = My.Resources.Nave3
            ElseIf NaveJogador(1) = 4 Then
                PicJogador1.Image = My.Resources.Nave4
            End If
        End If

        If e.KeyValue = Keys.A Then
            NaveJogador(1) -= 1
            If NaveJogador(1) <= 1 Then
                NaveJogador(1) = 1
            End If
            If NaveJogador(1) = 1 Then
                PicJogador1.Image = My.Resources.Nave1
            ElseIf NaveJogador(1) = 2 Then
                PicJogador1.Image = My.Resources.Nave2
            ElseIf NaveJogador(1) = 3 Then
                PicJogador1.Image = My.Resources.Nave3
            ElseIf NaveJogador(1) = 4 Then
                PicJogador1.Image = My.Resources.Nave4
            End If
        End If


        'Jogador 2
        If e.KeyValue = Keys.L Then
            NaveJogador(2) += 1
            If NaveJogador(2) >= 4 Then
                NaveJogador(2) = 4
            End If
            If NaveJogador(2) = 1 Then
                PicJogador2.Image = My.Resources.Nave1
            ElseIf NaveJogador(2) = 2 Then
                PicJogador2.Image = My.Resources.Nave2
            ElseIf NaveJogador(2) = 3 Then
                PicJogador2.Image = My.Resources.Nave3
            ElseIf NaveJogador(2) = 4 Then
                PicJogador2.Image = My.Resources.Nave4
            End If
        End If

        If e.KeyValue = Keys.J Then
            NaveJogador(2) -= 1
            If NaveJogador(2) <= 1 Then
                NaveJogador(2) = 1
            End If
            If NaveJogador(2) = 1 Then
                PicJogador2.Image = My.Resources.Nave1
            ElseIf NaveJogador(2) = 2 Then
                PicJogador2.Image = My.Resources.Nave2
            ElseIf NaveJogador(2) = 3 Then
                PicJogador2.Image = My.Resources.Nave3
            ElseIf NaveJogador(2) = 4 Then
                PicJogador2.Image = My.Resources.Nave4
            End If
        End If

        'Jogador 3
        If e.KeyValue = Keys.H Then
            NaveJogador(3) += 1
            If NaveJogador(3) >= 4 Then
                NaveJogador(3) = 4
            End If
            If NaveJogador(3) = 1 Then
                PicJogador3.Image = My.Resources.Nave1
            ElseIf NaveJogador(3) = 2 Then
                PicJogador3.Image = My.Resources.Nave2
            ElseIf NaveJogador(3) = 3 Then
                PicJogador3.Image = My.Resources.Nave3
            ElseIf NaveJogador(3) = 4 Then
                PicJogador3.Image = My.Resources.Nave4
            End If
        End If

        If e.KeyValue = Keys.F Then
            NaveJogador(3) -= 1
            If NaveJogador(3) <= 1 Then
                NaveJogador(3) = 1
            End If
            If NaveJogador(3) = 1 Then
                PicJogador3.Image = My.Resources.Nave1
            ElseIf NaveJogador(3) = 2 Then
                PicJogador3.Image = My.Resources.Nave2
            ElseIf NaveJogador(3) = 3 Then
                PicJogador3.Image = My.Resources.Nave3
            ElseIf NaveJogador(3) = 4 Then
                PicJogador3.Image = My.Resources.Nave4
            End If
        End If

        'Jogador 4
        If e.KeyValue = Keys.Right Then
            NaveJogador(4) += 1
            If NaveJogador(4) >= 4 Then
                NaveJogador(4) = 4
            End If
            If NaveJogador(4) = 1 Then
                PicJogador4.Image = My.Resources.Nave1
            ElseIf NaveJogador(4) = 2 Then
                PicJogador4.Image = My.Resources.Nave2
            ElseIf NaveJogador(4) = 3 Then
                PicJogador4.Image = My.Resources.Nave3
            ElseIf NaveJogador(4) = 4 Then
                PicJogador4.Image = My.Resources.Nave4
            End If
        End If

        If e.KeyValue = Keys.Left Then
            NaveJogador(4) -= 1
            If NaveJogador(4) <= 1 Then
                NaveJogador(4) = 1
            End If
            If NaveJogador(4) = 1 Then
                PicJogador4.Image = My.Resources.Nave1
            ElseIf NaveJogador(4) = 2 Then
                PicJogador4.Image = My.Resources.Nave2
            ElseIf NaveJogador(4) = 3 Then
                PicJogador4.Image = My.Resources.Nave3
            ElseIf NaveJogador(4) = 4 Then
                PicJogador4.Image = My.Resources.Nave4
            End If
        End If
    End Sub

    Private Sub DeathmatchEscolhaNave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For x As Integer = 1 To 4
            NaveJogador(x) = 1
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Continuar
        Jogo_Deathmatch.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Voltar
        OpcoesDeathmatch.Show()
        Me.Close()
    End Sub
End Class