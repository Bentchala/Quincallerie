Imports System.Drawing.Printing
Imports MySql.Data.MySqlClient


Public Class Vente
    Dim WithEvents PDF As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PDF.PrintPage
        ' Définir les polices (augmenter la taille de 3 points supplémentaires)
        Dim f17 As New Font("Calibri", 17, FontStyle.Regular) ' Anciennement f14
        Dim f19 As New Font("Calibri", 19, FontStyle.Regular) ' Anciennement f16
        Dim f19b As New Font("Calibri", 19, FontStyle.Bold)   ' Anciennement f16b
        Dim f23 As New Font("Calibri", 23, FontStyle.Bold)    ' Anciennement f20

        ' Définir les marges
        Dim leftmargin As Integer = PDF.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PDF.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PDF.DefaultPageSettings.PaperSize.Width

        ' Définir les formats d'alignement
        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        ' Charger le logo de la boutique
        Dim logoPath As String = "C:\Users\tchal\Documents\quinque.png" ' Remplacez par le chemin de votre logo
        Dim logo As Image = Nothing

        If System.IO.File.Exists(logoPath) Then
            logo = Image.FromFile(logoPath)
        Else
            MessageBox.Show("Le logo n'a pas été trouvé à l'emplacement spécifié.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' Dessiner le logo en haut du reçu
        If logo IsNot Nothing Then
            e.Graphics.DrawImage(logo, leftmargin, 5, 100, 100) ' Ajuster la taille du logo (100x100)
        End If

        ' Dessiner l'en-tête du reçu
        Dim line As String = "-----------------------------------------------------------------------------------------------------------------------------------------------------------------"
        e.Graphics.DrawString("TCHALA STORE", f23, Brushes.Black, centermargin, 110, center) ' Ajuster la position verticale
        e.Graphics.DrawString("LOME ZANGUERA", f19, Brushes.Black, centermargin, 140, center)
        e.Graphics.DrawString("TEL : +228 91003409", f17, Brushes.Black, centermargin, 165, center)

        ' Dessiner les informations de la vente
        e.Graphics.DrawString("CHEF :", f17, Brushes.Black, 0, 200)
        e.Graphics.DrawString("TCHALARE Gnandi Benjamin", f17, Brushes.Black, 90, 200)

        e.Graphics.DrawString("Nôtre devise : Le client est roi ", f17, Brushes.Black, 90, 230)

        e.Graphics.DrawString(line, f17, Brushes.Black, 0, 250)

        ' Dessiner les données du DataGridView3
        Dim height As Integer = 0 ' Position verticale pour les données
        DataGridView3.AllowUserToAddRows = False

        ' Vérifier qu'une seule ligne est sélectionnée
        If DataGridView3.SelectedRows.Count = 1 Then
            Dim selectedRow As DataGridViewRow = DataGridView3.SelectedRows(0)

            ' Afficher les informations générales de la vente
            e.Graphics.DrawString("Date : " & selectedRow.Cells(5).Value.ToString, f19, Brushes.Black, 0, 280 + height)
            e.Graphics.DrawString("Id vente : " & selectedRow.Cells(0).Value.ToString, f19, Brushes.Black, 0, 310 + height)
            e.Graphics.DrawString("Nom du client : " & selectedRow.Cells(1).Value.ToString, f19, Brushes.Black, 0, 340 + height)

            ' Créer un dictionnaire pour regrouper les produits par libellé et calculer le total des prix
            Dim produits As New Dictionary(Of String, (PrixTotal As Decimal, NombreTotal As Integer))

            ' Parcourir toutes les lignes du DataGridView3 pour le même client et la même date
            For Each row As DataGridViewRow In DataGridView3.Rows
                ' Vérifier si la ligne correspond au même client et à la même date
                If Not row.IsNewRow AndAlso
               row.Cells(1).Value.ToString() = selectedRow.Cells(1).Value.ToString() AndAlso
               row.Cells(5).Value.ToString() = selectedRow.Cells(5).Value.ToString() Then

                    Dim libelle As String = row.Cells(2).Value.ToString() ' Libellé du produit
                    Dim prix As Decimal = Convert.ToDecimal(row.Cells(3).Value) ' Prix du produit
                    Dim nombre As Integer = Convert.ToInt32(row.Cells(4).Value) ' Nombre de produits

                    ' Si le produit existe déjà dans le dictionnaire, mettre à jour le total
                    If produits.ContainsKey(libelle) Then
                        produits(libelle) = (produits(libelle).PrixTotal + prix * nombre, produits(libelle).NombreTotal + nombre)
                    Else
                        ' Sinon, ajouter le produit au dictionnaire
                        produits(libelle) = (prix * nombre, nombre)
                    End If
                End If
            Next

            ' Afficher les produits regroupés
            height += 370 ' Décaler la position verticale pour les produits
            For Each kvp In produits
                Dim libelle As String = kvp.Key
                Dim prixTotal As Decimal = kvp.Value.PrixTotal
                Dim nombreTotal As Integer = kvp.Value.NombreTotal

                ' Centrer les valeurs du DataGridView
                e.Graphics.DrawString("Libellé : " & libelle, f19, Brushes.Black, centermargin, height, center)
                e.Graphics.DrawString("Prix unitaire : " & (prixTotal / nombreTotal).ToString("N0") & " FCFA", f19, Brushes.Black, centermargin, height + 30, center)
                e.Graphics.DrawString("Nombre : " & nombreTotal.ToString(), f19, Brushes.Black, centermargin, height + 60, center)
                e.Graphics.DrawString("Prix total : " & prixTotal.ToString("N0") & " FCFA", f19, Brushes.Black, centermargin, height + 90, center)

                height += 120 ' Décaler la position verticale pour le prochain produit
            Next

            ' Afficher le total général
            Dim totalGeneral As Decimal = produits.Values.Sum(Function(p) p.PrixTotal)
            e.Graphics.DrawString("Total général : " & totalGeneral.ToString("N0") & " FCFA", f19, Brushes.Black, centermargin, height + 30, center)
        Else
            ' Afficher un message si aucune ligne ou plusieurs lignes sont sélectionnées
            e.Graphics.DrawString("Veuillez sélectionner une seule ligne.", f19, Brushes.Black, centermargin, 280 + height, center)
        End If

        ' Dessiner une ligne de séparation à la fin
        e.Graphics.DrawString(line, f17, Brushes.Black, 0, height + 60)
    End Sub

    Private Sub Vente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        ChargerVente()
        ChargerComboBoxNom()
        ChargerComboBoxLibelle()
        ChargerComboBoxPrix()
    End Sub

    Private Sub ChargerVente()
        Try
            ' Vérifier si la connexion est déjà ouverte avant de l'ouvrir
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Requête pour récupérer toutes les données de la table "ventes"
            Dim query As String = "SELECT * FROM ventes"
            Dim cmd As New MySqlCommand(query, connection)

            ' Utiliser un DataAdapter pour remplir le DataTable
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            ' Remplir le DataTable et l'affecter au DataGridView
            adapter.Fill(table)
            DataGridView3.DataSource = table

            ' Ajuster automatiquement la taille des colonnes pour un affichage propre
            DataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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


    Private Sub AjoutVente()
        Try
            connection.Open()
            Dim query As String = "INSERT INTO ventes (nom, libelle, prix, nombre, date) VALUES (@nom, @libelle, @prix, @nombre,  @date)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@nom", ComboBoxnom.Text)
            cmd.Parameters.AddWithValue("@libelle", ComboBoxlib.Text)
            cmd.Parameters.AddWithValue("@prix", Convert.ToInt32(ComboBoxprix.Text))
            cmd.Parameters.AddWithValue("@nombre", Convert.ToInt32(Textnbr.Text))
            cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Vente ajouté avec succès")
            ChargerVente()
        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'ajout : " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub ModifVente()
        Try
            connection.Open()
            ' Requête SQL corrigée
            Dim query As String = "UPDATE ventes SET nom=@nom, libelle=@libelle, prix=@prix, nombre=@nombre, date=@date, total=@total WHERE id_ventes=@id_vente"
            Dim cmd As New MySqlCommand(query, connection)

            ' Ajouter les paramètres
            cmd.Parameters.AddWithValue("@id_vente", DataGridView3.CurrentRow.Cells(0).Value)
            cmd.Parameters.AddWithValue("@nom", ComboBoxnom.Text)
            cmd.Parameters.AddWithValue("@libelle", ComboBoxlib.Text)
            cmd.Parameters.AddWithValue("@prix", Convert.ToInt32(ComboBoxprix.Text))
            cmd.Parameters.AddWithValue("@nombre", Convert.ToInt32(Textnbr.Text))
            cmd.Parameters.AddWithValue("@date", DateTimePicker1.Value)

            ' Calculer le total (prix * nombre)
            Dim total As Decimal = Convert.ToInt32(ComboBoxprix.Text) * Convert.ToInt32(Textnbr.Text)
            cmd.Parameters.AddWithValue("@total", total)

            ' Exécuter la requête
            cmd.ExecuteNonQuery()
            MessageBox.Show("Vente mise à jour avec succès !")

            ' Recharger les données dans le DataGridView
            ChargerVente()
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la mise à jour : " & ex.Message)
        Finally
            ' Fermer la connexion
            If connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    Private Sub SupprVente()
        Try
            ' Vérifier si une ligne est sélectionnée dans le DataGridView
            If DataGridView3.SelectedRows.Count = 0 Then
                MessageBox.Show("Veuillez sélectionner une vente à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Récupérer l'ID du produit à supprimer

            ' Confirmation avant suppression


            ' Supprimer le produit dans la base de données
            connection.Open()
            Dim query As String = "DELETE FROM ventes WHERE id_ventes = @id_ventes"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id_ventes", DataGridView3.CurrentRow.Cells(0).Value)

            cmd.ExecuteNonQuery()
            MessageBox.Show("Vente supprimée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ChargerVente()

        Catch ex As Exception
            MessageBox.Show("Erreur lors de la suppression : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try

    End Sub
    Private Sub Actualiser()
        ' Réinitialiser les TextBox

        Textnbr.Clear()

        ' Réinitialiser les ComboBox (premier élément ou vide)
        If ComboBoxnom.Items.Count > 0 Then ComboBoxnom.SelectedIndex = -1
        If ComboBoxlib.Items.Count > 0 Then ComboBoxlib.SelectedIndex = -1
        If ComboBoxprix.Items.Count > 0 Then ComboBoxprix.SelectedIndex = -1

        ' Réinitialiser le DateTimePicker à la date actuelle
        DateTimePicker1.Value = DateTime.Now
    End Sub
    Private Sub Donnée_sel()
        Try
            If DataGridView3.SelectedRows.Count > 0 Then
                Dim row As DataGridViewRow = DataGridView3.SelectedRows(0)


                ' Remplir les ComboBox avec les valeurs de la ligne sélectionnée
                ComboBoxnom.Text = row.Cells("nom").Value.ToString()
                ComboBoxlib.Text = row.Cells("libelle").Value.ToString()

                ' Remplir les champs numériques (Prix et Nombr)
                ComboBoxprix.Text = row.Cells("prix").Value.ToString()
                Textnbr.Text = row.Cells("nombre").Value.ToString()

                ' Remplir le DateTimePicker
                DateTimePicker1.Value = Convert.ToDateTime(row.Cells("date").Value)
            End If
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la sélection : " & ex.Message)

        End Try
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView3.SelectionChanged
        Donnée_sel()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        RechercheAuto(TextBox4.Text)
    End Sub

    Private Sub RechercheAuto(texte As String)
        Dim dataTable As DataTable = CType(DataGridView3.DataSource, DataTable)
        If dataTable IsNot Nothing Then
            dataTable.DefaultView.RowFilter = $"nom LIKE '%{texte}%' OR libelle LIKE '%{texte}%'"
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim cl As New Client()
        cl.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Buttonpro_Click(sender As Object, e As EventArgs) Handles Buttonpro.Click
        Dim form2 As New Form2()
        form2.ShowDialog()
        Me.Close()
    End Sub
    Private Sub ChargerComboBoxNom()
        Try
            connection.Open()
            Dim query As String = "SELECT DISTINCT nom FROM clients"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ComboBoxnom.Items.Clear()
            While reader.Read()
                ComboBoxnom.Items.Add(reader("nom").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement des noms : " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub ChargerComboBoxLibelle()
        Try
            connection.Open()
            Dim query As String = "SELECT DISTINCT libelle FROM produits"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ComboBoxlib.Items.Clear()
            While reader.Read()
                ComboBoxlib.Items.Add(reader("libelle").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement des libellés : " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub ChargerComboBoxPrix()
        Try
            connection.Open()
            Dim query As String = "SELECT DISTINCT prix FROM produits"
            Dim cmd As New MySqlCommand(query, connection)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            ComboBoxprix.Items.Clear()
            While reader.Read()
                ComboBoxprix.Items.Add(reader("prix").ToString())
            End While

            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement des prix : " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Actualiser()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AjoutVente()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SupprVente()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ModifVente()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PPD.Document = PDF
        PPD.ShowDialog()
    End Sub

End Class