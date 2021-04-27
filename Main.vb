Public Class Main
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        sql = "SELECT MAX(id) from info"
        rs = db.Execute(sql)
        Dim max As Integer = CInt(rs.Fields(0).Value)
        For number As Integer = 1 To max Step 1
            sql = "select * from info where id = '" & number & "'"
            rs = db.Execute(sql)
            DataGridView1.Rows.Add(rs.Fields(2).Value)
            If rs.EOF = True Then
                Exit For
            End If
        Next
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class