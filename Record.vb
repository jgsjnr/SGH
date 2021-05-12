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
                                                    & ",'" & txtObs.Text & "', 'ativo')"
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
        Dim recordLoad As New Record
        With recordLoad
            .txtName.Clear()
            .txtCpf.Clear()
            .txtBirthday.Clear()
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

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        cleanRecord()
        MsgBox("Formulario pronto para inserir novo cadastro", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
    End Sub

    Private Sub Record_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If updateLevel = True Then
            btnUpdate.Visible = True
            btnNew.Visible = False
        End If
    End Sub

    Private Sub Record_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        If updateLevel = True Then
            Close()
        Else
            Close()
            Dim menuLoad As New Menu
            menuLoad.Show()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            sql = "select * from info where cpf='" & txtCpf.Text & "'"
            rs = db.Execute(sql)
            Dim id As Integer
            id = rs.Fields(0).Value
            If rs.EOF = False Then
                Try
                    sql = "update info set id='" & id & "'" _
                                                    & ",name='" & txtName.Text & "'" _
                                                    & ",cpf='" & txtCpf.Text & "'" _
                                                    & ",birthday='" & txtBirthday.Text & "'" _
                                                    & ",civil='" & cmbCivil.Text & "'" _
                                                    & ",color='" & cmbColor.Text & "'" _
                                                    & ",blood='" & cmbBlood.Text & "'" _
                                                    & ",alergy='" & cmbAlergy.Text & "'" _
                                                    & ",obs_alergy='" & txtAlergy.Text & "'" _
                                                    & ",resp='" & cmbResp.Text & "'" _
                                                    & ",name_resp='" & txtNameResp.Text & "'" _
                                                    & ",cpf_resp='" & txtCpfResp.Text & "'" _
                                                    & ",address='" & txtAddress.Text & "'" _
                                                    & ",comp='" & txtComp.Text & "'" _
                                                    & ",city='" & txtCity.Text & "'" _
                                                    & ",uf='" & txtUf.Text & "'" _
                                                    & ",cep='" & txtCep.Text & "'" _
                                                    & ",tel='" & txtTel.Text & "'" _
                                                    & ",cel='" & txtCel.Text & "'" _
                                                    & ",email='" & txtMail.Text & "'" _
                                                    & ",obs='" & txtObs.Text & "', ativo='ativo' where cpf='" & txtCpf.Text & "'"
                    rs = db.Execute(sql)
                    MsgBox("Cadastro atualizado com sucesso", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
                Catch ex As Exception
                    MsgBox("Não foi possível adicionar um usuário", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
                End Try
            Else
            End If
        Catch ex As Exception
            MsgBox("Não foi possível acessar o banco de dados", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
End Class