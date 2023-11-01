
Public Class Form3
    Private Sub btn_deslogar_Click(sender As Object, e As EventArgs) Handles btn_deslogar.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btn_clientes_Click(sender As Object, e As EventArgs) Handles btn_clientes.Click
        Me.Close()
        Form5.Show()
    End Sub
End Class