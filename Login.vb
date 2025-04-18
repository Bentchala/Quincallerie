Imports MySql.Data.MySqlClient
Imports WinFormsApp1.Module1

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private correctUsername As String = "admin"
    Private correctPassword As String = "password123"

    Private Function AuthentifierUtilisateur(username As String, password As String) As Boolean
        Try
            ' Ouvrir la connexion à la base de données
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Requête SQL pour vérifier les informations de connexion
            Dim query As String = "SELECT COUNT(*) FROM utilisateur WHERE user = @user AND pass = @pass"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@pass", password) ' Assurez-vous que les mots de passe sont hashés en production

            ' Exécuter la commande et vérifier le résultat
            Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
            Return count > 0 ' Retourne True si un utilisateur correspond
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la connexion : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click


        MessageBox.Show("Connexion réussie. Bienvenue,  !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Hide()
        Dim form1 As New Form2()
        form1.ShowDialog()
        Me.Close()

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        Dim form1 As New Form1()
        form1.ShowDialog()
        Me.Close()
    End Sub


End Class