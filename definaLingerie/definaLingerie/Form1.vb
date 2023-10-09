Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Usuário.Click

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_senha.Text = "func" And txt_user.Text = "func" Then
            MsgBox("Logado com sucesso!")
            txt_senha.Clear()
            txt_user.Clear()

            Me.Close()
        Else
            txt_senha.Clear()
            txt_user.Clear()
            MsgBox("Erro no log! Tente novamente!")

        End If
    End Sub
End Class
