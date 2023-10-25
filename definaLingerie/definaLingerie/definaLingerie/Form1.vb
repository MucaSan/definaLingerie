Imports System.Data.SQLite

Public Class Form1
    Private dbCommand As String = ""
    Private bindingSrc As BindingSource

    Private dbName As String = "banco.db"
    Private dbPath As String = Application.StartupPath & "\banco\" & dbName
    Private conString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(conString)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim sql As String = "SELECT * FROM tb_funcionarios WHERE usuario='" & txt_user.Text & "' AND senha= '" & txt_senha.Text & "'"
        Dim command As New SQLiteCommand(sql, connection)
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                If txt_user.Text = reader("usuario").ToString() And txt_senha.Text = reader("senha").ToString() And reader("cargo") = "1" Then
                    MsgBox("Logado com sucesso!")
                    txt_senha.Clear()
                    txt_user.Clear()
                    Form2.Show()
                    Me.Hide()
                Else
                    txt_senha.Clear()
                    txt_user.Clear()
                    MsgBox("Erro no log! Tente novamente!")
                End If
            End If
        End Using
        connection.Close()
    End Sub
End Class
