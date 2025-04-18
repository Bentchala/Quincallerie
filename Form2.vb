Imports Mysqlx
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports WinFormsApp1.Module1

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Charger_prod()
    End Sub

    Private Sub Charger_prod()

        Try
            ' Vérifier si la connexion est déjà ouverte avant de l'ouvrir
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Requête pour récupérer toutes les données de la table "ventes"
            Dim query As String = "SELECT * FROM produits"
            Dim cmd As New MySqlCommand(query, connection)

            ' Utiliser un DataAdapter pour remplir le DataTable
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            ' Remplir le DataTable et l'affecter au DataGridView
            adapter.Fill(table)
            DataGridView2.DataSource = table

            ' Ajuster automatiquement la taille des colonnes pour un affichage propre
            DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            ' Afficher un message d'erreur en cas de problème
            MessageBox.Show("Erreur lors du chargement des données : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Fermer la connexion si elle est toujours ouverte
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub



    Private Sub Ajouter_prod()
        Try
            connection.Open()
            Dim query As String = "INSERT INTO produits (libelle, prix, categorie) VALUES (@libelle, @prix, @categorie)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@libelle", Textlib.Text)
            cmd.Parameters.AddWithValue("@prix", Convert.ToInt32(Textpr.Text))
            cmd.Parameters.AddWithValue("@categorie", ComboBox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Enregistrement ajouté avec succès")
            Charger_prod()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Mod_prod()
        Try
            connection.Open()
            Dim query As String = " UPDATE produits SET libelle=@libelle, prix=@prix, categorie=@categorie  WHERE id_produit=@id_produit"
            Dim cmd As New MySqlCommand(query, connection)
            ' Ajouter les paramètres
            cmd.Parameters.AddWithValue("@id_produit", DataGridView2.CurrentRow.Cells("id_produit").Value)
            cmd.Parameters.AddWithValue("@libelle", Textlib.Text)
            cmd.Parameters.AddWithValue("@prix", Convert.ToInt32(Textpr.Text))
            cmd.Parameters.AddWithValue("@categorie", ComboBox1.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Enregistrement mis à jour avec succès.")
            Charger_prod()

        Catch ex As Exception
            MessageBox.Show("Erreur lors de la mise à jour : " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub RechercheAuto(texte As String)
        Dim dataTable As DataTable = CType(DataGridView2.DataSource, DataTable)
        If dataTable IsNot Nothing Then
            dataTable.DefaultView.RowFilter = $"libelle LIKE '%{texte}%' OR categorie LIKE '%{texte}%'"
        End If
    End Sub


    Private Sub Textrech_TextChanged(sender As Object, e As EventArgs) Handles Textrech.TextChanged
        RechercheAuto(Textrech.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim f As New Client()
        f.ShowDialog()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub Buttonaj_Click(sender As Object, e As EventArgs) Handles Buttonaj.Click
        Ajouter_prod()
    End Sub

    Private Sub Buttonmod_Click(sender As Object, e As EventArgs) Handles Buttonmod.Click
        Mod_prod()
    End Sub



    Private Sub DataGridView2_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView2.SelectionChanged
        Donnée_sel()
    End Sub

    Private Sub Donnée_sel()
        Try
            ' Vérifiez si une ligne est sélectionnée
            If DataGridView2.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView2.SelectedRows(0)

                ' Récupérez les données des colonnes correspondantes
                Textlib.Text = selectedRow.Cells("libelle").Value.ToString()
                Textpr.Text = selectedRow.Cells("prix").Value.ToString()
                ComboBox1.Text = selectedRow.Cells("categorie").Value.ToString()

                ' Récupérez et affichez l'image

            End If
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la sélection : " & ex.Message)
        End Try
    End Sub




    Private Sub Buttonsup_Click(sender As Object, e As EventArgs) Handles Buttonsup.Click
        Try
            ' Vérifier si une ligne est sélectionnée dans le DataGridView
            If DataGridView2.SelectedRows.Count = 0 Then
                MessageBox.Show("Veuillez sélectionner un produit à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Récupérer l'ID du produit à supprimer
            Dim productId As Integer = Convert.ToInt32(DataGridView2.SelectedRows(0).Cells("id").Value)

            ' Confirmation avant suppression
            Dim confirmation = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce produit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirmation = DialogResult.No Then Return

            ' Supprimer le produit dans la base de données
            connection.Open()
            Dim query As String = "DELETE FROM produits WHERE id = @id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id", productId)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Produit supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Rafraîchir les données dans le DataGridView
            Charger_prod()

        Catch ex As Exception
            MessageBox.Show("Erreur lors de la suppression : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim form1 As New Vente()
        form1.ShowDialog()
        Me.Close()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Charger_prod()
    End Sub

    Private Sub Buttonact_Click(sender As Object, e As EventArgs) Handles Buttonact.Click

    End Sub

    Private Sub Textlib_TextChanged(sender As Object, e As EventArgs) Handles Textlib.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j As New Client()
        j.ShowDialog()
        Me.Close()
    End Sub
End Class