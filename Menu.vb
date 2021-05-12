Public Class Menu
    Private Sub btnQuit_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Menu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Dispose()
        session = False
    End Sub

    Private Sub bntRegister_Click(sender As Object, e As EventArgs) Handles bntRegister.Click
        Dim registerLoad As New Register
        Close()
        registerLoad.Show()
    End Sub

    Private Sub Menu_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAuth.Text = sessionUser
    End Sub

    Private Sub btnQuit_Click_1(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim loginLoad As New Login
        Dispose()
        loginLoad.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        updateLevel = False
        Dim recordLoad As New Record
        Close()
        recordLoad.Show()
    End Sub

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        Dim mainLoad As New Main
        Close()
        mainLoad.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim consultLoad As New Consult
        Close()
        consultLoad.Show()
    End Sub
End Class