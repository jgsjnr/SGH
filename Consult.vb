Public Class Consult
    Dim consultValues(5) As String
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If rdFebreYes.Checked = True Then
            consultValues(0) = "Sim"
        Else
            If rdFebreNo.Checked = True Then
                consultValues(0) = "Não"
            End If
        End If
        If rdFadigaYes.Checked = True Then
            consultValues(1) = "Sim"
        Else
            If rdFadigaNo.Checked = True Then
                consultValues(1) = "Não"
            End If
        End If
        If rdArYes.Checked = True Then
            consultValues(2) = "Sim"
        Else
            If rdArNo.Checked = True Then
                consultValues(2) = "Não"
            End If
        End If
        If rdDoresYes.Checked = True Then
            consultValues(3) = "Sim"
        Else
            If rdDoresNo.Checked = True Then
                consultValues(3) = "Não"
            End If
        End If
        If rdCoronaYes.Checked = True Then
            consultValues(4) = "Sim"
        Else
            If rdCoronaNo.Checked = True Then
                consultValues(4) = "Não"
            End If
        End If
        Try
            sql = "insert into relat values('" & txtCpf.Text & "'" _
                                            & ",'" & txtCbo.Text & "'" _
                                            & ",'" & consultValues(0) & "'" _
                                            & ",'" & consultValues(1) & "'" _
                                            & ",'" & consultValues(2) & "'" _
                                            & ",'" & consultValues(3) & "'" _
                                            & ",'" & consultValues(4) & "'" _
                                            & ",'" & cmbReceita.Text & "'" _
                                            & ",'" & cmbIntern.Text & "'" _
                                            & ",'" & txtObs.Text & "')"
            rs = db.Execute(sql)
            MsgBox("Adicionado laudo com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Não foi possivel adicionar o laudo", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim mainLoad As New Main
        Close()
        mainLoad.Show()
    End Sub
End Class