Public Class Menu
    Private Sub btnQuit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        session = False
    End Sub

    Private Sub bntRegister_Click(sender As Object, e As EventArgs) Handles bntRegister.Click
        Hide()
        registerLoad.Show()
    End Sub

    Private Sub Menu_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        With menuLoad
            .lblAuth.Text = sessionUser
        End With
    End Sub

    Private Sub btnQuit_Click_1(sender As Object, e As EventArgs) Handles btnQuit.Click
        Hide()
        loginLoad.Show()
        session = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        recordLoad.Show()
    End Sub
End Class