Module [Module]
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String
    Public compName = Environment.MachineName
    Public splashLoad As New Splash
    Public loginLoad As New Login
    Public menuLoad As New Menu
    Public registerLoad As New Register
    Public session As Boolean
    Public sessionUser As String
    Public sessionLevel As String

    Sub conBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source='" & Environment.MachineName & "';Initial Catalog=sgh;trusted_connection=yes;")
            MsgBox("Conectado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Conexão mal sucedida", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Sub testSession()
        If session = False Then
            loginLoad.Close()
        Else
            loginLoad.Hide()
        End If
    End Sub
End Module
