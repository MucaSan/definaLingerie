Public Class Form2
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    End Sub

    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Form4.Show()
        Me.Hide()
    End Sub
End Class