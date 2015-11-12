Public Class face1

    Private Sub face1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Parent = PictureBox1
        My.Computer.Audio.Play(My.Resources.james, AudioPlayMode.BackgroundLoop)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MsgBox("Thank you for playing My.Escape developed by Mohammad Yaqoob")
        Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        game.Show()
    End Sub
End Class