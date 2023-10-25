Imports System.Data.SQLite

Public Class Form4
    Private dbCommand As String = ""
    Private bindingSrc As BindingSource

    Private dbName As String = "banco.db"
    Private dbPath As String = Application.StartupPath & "\banco\" & dbName
    Private conString As String = "Data Source=" & dbPath & ";Version=3"

    Private connection As New SQLiteConnection(conString)

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection.Open()
    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        Dim sql As String = "SELECT * FROM tb_funcionarios WHERE usuario='" & txt_user.Text & "';"


        Dim command As New SQLiteCommand(sql, connection)
        Using reader As SQLiteDataReader = command.ExecuteReader()
            If reader.Read() Then
                If reader("usuario") = txt_user.Text Or reader("nome") = txt_nome.Text Then
                    MsgBox("Há um registro com esse usuário ou nome, insira outro nome ou usuário!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical)
                    txt_user.Clear()
                    txt_nome.Clear()
                End If
            Else

                MsgBox("CRIAÇÃO EFETUADA COM SUCESSO!")
                sql = "INSERT INTO tb_funcionarios VALUES ('" & txt_cpf.Text & "','" & txt_nome.Text & "','" & txt_user.Text & "','" & txt_senha.Text & "','" & cmb_data.Text & "','" & txt_email.Text & "','" & txt_telefone.Text & "',2);"
                Dim command2 As New SQLiteCommand(sql, connection)
                command2.ExecuteNonQuery()
            End If
        End Using
        connection.Close()
    End Sub
End Class