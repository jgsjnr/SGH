Public Class Record

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim id As Integer
            id = numGen()
            sql = "select * from info where cpf='" & txtCpf.Text & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                MsgBox("Usuário já existe", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            Else
                Try
                    sql = "insert into info values('" & id & "'" _
                                                    & ",'" & txtName.Text & "'" _
                                                    & ",'" & txtCpf.Text & "'" _
                                                    & ",'" & txtBirthday.Text & "'" _
                                                    & ",'" & cmbCivil.Text & "'" _
                                                    & ",'" & cmbColor.Text & "'" _
                                                    & ",'" & cmbBlood.Text & "'" _
                                                    & ",'" & cmbAlergy.Text & "'" _
                                                    & ",'" & txtAlergy.Text & "'" _
                                                    & ",'" & cmbResp.Text & "'" _
                                                    & ",'" & txtNameResp.Text & "'" _
                                                    & ",'" & txtCpfResp.Text & "'" _
                                                    & ",'" & txtAddress.Text & "'" _
                                                    & ",'" & txtComp.Text & "'" _
                                                    & ",'" & txtCity.Text & "'" _
                                                    & ",'" & txtUf.Text & "'" _
                                                    & ",'" & txtCep.Text & "'" _
                                                    & ",'" & txtTel.Text & "'" _
                                                    & ",'" & txtCel.Text & "'" _
                                                    & ",'" & txtMail.Text & "'" _
                                                    & ",'" & txtObs.Text & "')"
                    rs = db.Execute(sql)
                    MsgBox("Usuário adicionado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Catch ex As Exception
                    MsgBox("Não foi possível adicionar um usuário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                End Try
            End If
        Catch ex As Exception
            MsgBox("Não foi possível acessar o banco de dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub cleanRecord()
        With recordLoad
            .txtName.Clear
            .txtCpf.Clear
            .txtBirthday.Clear
            .cmbCivil.SelectedIndex = -1
            .cmbColor.SelectedIndex = -1
            .cmbBlood.SelectedIndex = -1
            .cmbAlergy.SelectedIndex = -1
            .cmbResp.SelectedIndex = -1
            .txtNameResp.Clear()
            .txtCpfResp.Clear()
            .txtAddress.Clear()
            .txtComp.Clear()
            .txtCity.Clear()
            .txtUf.Clear()
            .txtCep.Clear()
            .txtTel.Clear()
            .txtCel.Clear()
            .txtMail.Clear()
            .txtObs.Clear()
        End With
    End Sub
End Class