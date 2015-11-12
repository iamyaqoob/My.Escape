Public Class game
    Dim score As Integer = 1000
    Private Sub game_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Up Then
            car.Top = car.Top - 3
        End If
        If e.KeyCode = Keys.Down Then
            car.Top = car.Top + 4
        End If
        If e.KeyCode = Keys.Right Then
            car.Left = car.Left + 6
        End If
        If e.KeyCode = Keys.Left Then
            car.Left = car.Left - 6
        End If
        If car.Bounds.IntersectsWith(finish.Bounds) Then
            MsgBox("Your Score is " & " " & score)
            Timer2.Stop()
            Close()
        End If
        If car.Bounds.IntersectsWith(Label1.Bounds) Then
            car.Top = 216
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label2.Bounds) Then
            car.Top = 216
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label3.Bounds) Then
            car.Top = 216
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label4.Bounds) Then
            car.Top = 216
            car.Left = 12
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label5.Top = Label5.Top + 1.5
        Label16.Top = Label16.Top + 1.5
        Label9.Top = Label9.Top + 1.5
        Label14.Top = Label14.Top + 1.5
        Label6.Top = Label6.Top + 1.5
        Label7.Top = Label7.Top + 1.5
        Label15.Top = Label15.Top + 1.5
        Label12.Top = Label12.Top + 1.5

        Label21.Top = Label21.Top - 1.5
        Label24.Top = Label24.Top - 1.5
        Label23.Top = Label23.Top - 1.5
        Label17.Top = Label17.Top - 1.5
        Label22.Top = Label22.Top - 1.5
        Label19.Top = Label19.Top - 1.5
        Label10.Top = Label10.Top - 1.5

        If Label5.Bounds.IntersectsWith(Label2.Bounds) Then

            Label5.Top = 48
            Label5.Left = 65
        End If
        If Label7.Bounds.IntersectsWith(Label2.Bounds) Then

            Label7.Top = 48
            Label7.Left = 188
        End If
        If Label16.Bounds.IntersectsWith(Label2.Bounds) Then

            Label16.Top = 48
            Label16.Left = 988
        End If
        If Label9.Bounds.IntersectsWith(Label2.Bounds) Then

            Label9.Top = 48
            Label9.Left = 453
        End If
        If Label14.Bounds.IntersectsWith(Label2.Bounds) Then

            Label14.Top = 48
            Label14.Left = 586
        End If
        If Label6.Bounds.IntersectsWith(Label2.Bounds) Then

            Label6.Top = 48
            Label6.Left = 722
        End If
        If Label15.Bounds.IntersectsWith(Label2.Bounds) Then

            Label15.Top = 48
            Label15.Left = 853
        End If

        If Label12.Bounds.IntersectsWith(Label2.Bounds) Then

            Label12.Top = 48
            Label12.Left = 319
        End If
       
        If Label21.Bounds.IntersectsWith(Label1.Bounds) Then

            Label21.Top = 391
            Label21.Left = 131
        End If
        If Label24.Bounds.IntersectsWith(Label1.Bounds) Then

            Label24.Top = 391
            Label24.Left = 256
        End If
        If Label23.Bounds.IntersectsWith(Label1.Bounds) Then

            Label23.Top = 391
            Label23.Left = 394
        End If
        If Label17.Bounds.IntersectsWith(Label1.Bounds) Then

            Label17.Top = 391
            Label17.Left = 525
        End If
        If Label22.Bounds.IntersectsWith(Label1.Bounds) Then

            Label22.Top = 391
            Label22.Left = 662
        End If
        If Label19.Bounds.IntersectsWith(Label1.Bounds) Then

            Label19.Top = 391
            Label19.Left = 799
        End If
        If Label10.Bounds.IntersectsWith(Label1.Bounds) Then

            Label10.Top = 391
            Label10.Left = 926
        End If

        If car.Bounds.IntersectsWith(Label5.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label16.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label9.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label14.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label6.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If

        If car.Bounds.IntersectsWith(Label7.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label15.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label12.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label21.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label24.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label23.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If

        If car.Bounds.IntersectsWith(Label17.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label22.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label19.Bounds) Then

            car.Top = 273
            car.Left = 12
        End If
        If car.Bounds.IntersectsWith(Label10.Bounds) Then
            
            car.Top = 273
            car.Left = 12
        End If
   
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        score = score - 10
        score1.Text = CStr(score)

        If score = 0 Then
            Timer2.Stop()
            MsgBox("Game Over. Play again. :)")
            Close()
        End If
    End Sub

    Private Sub game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer2.Start()
    End Sub
  
    Private Sub game_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class