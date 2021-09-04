Imports MySql.Data.MySqlClient

Public Class Form1
    Private conexao As MySqlConnection
    Private comando As MySqlCommand
    Private da As MySqlDataAdapter
    Private dr As MySqlDataReader
    Private strSQL As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Save.Click
        Try

            conexao = New MySqlConnection("Server=localhost;Database=crudrpg;Uid=root;Pwd=meuteste;")
            strSQL = "INSERT INTO players (Jogador,Personagem,Classe) VALUES (@Jogador, @Personagem, @Classe)"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@Jogador", txtJogador.Text)
            comando.Parameters.AddWithValue("@Personagem", txtPersonagem.Text)
            comando.Parameters.AddWithValue("@Classe", txtClasse.Text)

            conexao.Open()
            comando.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Edit.Click
        Try

            conexao = New MySqlConnection("Server=localhost;Database=crudrpg;Uid=root;Pwd=meuteste;")
            strSQL = "UPDATE players SET Jogador=@Jogador, Personagem=@Personagem, Classe=@Classe WHERE IDJogador=@IDJogador"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@IDJogador", txtIDJogador.Text)
            comando.Parameters.AddWithValue("@Jogador", txtJogador.Text)
            comando.Parameters.AddWithValue("@Personagem", txtPersonagem.Text)
            comando.Parameters.AddWithValue("@Classe", txtClasse.Text)

            conexao.Open()
            comando.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Exibir.Click
        Try

            conexao = New MySqlConnection("Server=localhost;Database=crudrpg;Uid=root;Pwd=meuteste;")
            strSQL = "SELECT * FROM Players"

            Dim dt As New DataTable

            da = New MySqlDataAdapter(strSQL, conexao)

            da.Fill(dt)

            dGrid.DataSource = dt


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        Try

            conexao = New MySqlConnection("Server=localhost;Database=crudrpg;Uid=root;Pwd=meuteste;")
            strSQL = "DELETE FROM players WHERE IDJogador=@IDJogador"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@IDJogador", txtIDJogador.Text)

            conexao.Open()
            comando.ExecuteNonQuery()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing

        End Try
    End Sub

    Private Sub txtPesquisar_Click(sender As Object, e As EventArgs) Handles txtPesquisar.Click
        Try

            conexao = New MySqlConnection("Server=localhost;Database=crudrpg;Uid=root;Pwd=meuteste;")
            strSQL = "SELECT * FROM Players WHERE IDJogador=@IDJogador"

            comando = New MySqlCommand(strSQL, conexao)
            comando.Parameters.AddWithValue("@IDJogador", txtIDJogador.Text)
            comando.Parameters.AddWithValue("@Jogador", txtJogador.Text)
            comando.Parameters.AddWithValue("@Personagem", txtPersonagem.Text)
            comando.Parameters.AddWithValue("@Classe", txtClasse.Text)

            conexao.Open()
            dr = comando.ExecuteReader()

            Do While dr.Read
                txtJogador.Text = dr("Jogador")
                txtPersonagem.Text = dr("Personagem")
                txtClasse.Text = dr("Classe")

            Loop

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexao.Close()
            conexao = Nothing
            comando = Nothing

        End Try
    End Sub
End Class
