
Imports System.IO
Imports MySql.Data.MySqlClient


Public Class Client

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView.RowTemplate.Height = 70 ' Ajuste cette valeur selon tes besoins

        ' Supprime les marges et ajustements inutiles
        DataGridView.AllowUserToResizeRows = False
        DataGridView.AllowUserToResizeColumns = False

        Charger_cli()
        'ConfigureDataGridView()

    End Sub

    Private Sub DataGridView_membre_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        Try
            If DataGridView.CurrentRow IsNot Nothing AndAlso DataGridView.CurrentRow.Index <> -1 Then
                TextBox11.Text = DataGridView.CurrentRow.Cells(1).Value.ToString() ' Nom
                TextBox22.Text = DataGridView.CurrentRow.Cells(2).Value.ToString() ' Prénom
                TextBox33.Text = DataGridView.CurrentRow.Cells(3).Value.ToString() ' Téléphone
                For Each row As DataGridViewRow In DataGridView.Rows
                    row.DefaultCellStyle.BackColor = Color.White
                Next
                DataGridView.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow
                ' Charger l'image si elle existe
                If Not IsDBNull(DataGridView.CurrentRow.Cells(4).Value) Then
                    Dim photoBytes As Byte() = CType(DataGridView.CurrentRow.Cells(4).Value, Byte())
                    Dim stream As New MemoryStream(photoBytes)
                    PictureBox11.Image = Image.FromStream(stream)
                Else
                    PictureBox11.Image = Nothing
                End If
            Else

                ' Effacer les champs si aucune ligne n'est sélectionnée
                TextBox11.Text = ""
                TextBox22.Text = ""
                TextBox33.Text = ""
                PictureBox11.Image = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Charger_cli()

        Try
            ' Vérifier si la connexion est déjà ouverte avant de l'ouvrir
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Requête pour récupérer toutes les données de la table "ventes"
            Dim query As String = "SELECT * FROM clients"
            Dim cmd As New MySqlCommand(query, connection)

            ' Utiliser un DataAdapter pour remplir le DataTable
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()

            ' Remplir le DataTable et l'affecter au DataGridView
            adapter.Fill(table)
            DataGridView.DataSource = table

            ' Ajuster automatiquement la taille des colonnes pour un affichage propre
            DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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


    Private Sub Ajouter_cli()
        'AddData
        Try
            connection.Open()
            Dim query As String = "INSERT INTO clients (nom, prenom, adresse, photo) VALUES (@nom, @prenom, @adresse, @photo)"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@nom", TextBox11.Text)
            cmd.Parameters.AddWithValue("@prenom", TextBox22.Text)
            cmd.Parameters.AddWithValue("@adresse", TextBox33.Text)

            ' Convertir l'image en bytes
            Dim ms As New IO.MemoryStream()
            PictureBox11.Image.Save(ms, PictureBox11.Image.RawFormat)
            cmd.Parameters.AddWithValue("@photo", ms.ToArray())

            cmd.ExecuteNonQuery()
            MessageBox.Show("Ajouté réussi")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub Modifier_cli()
        Try
            connection.Open()
            Dim query As String = "UPDATE clients SET nom=@nom, prenom=@prenom, adresse=@adresse, photo=@photo WHERE id_clients=@id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id", DataGridView.CurrentRow.Cells(0).Value)
            cmd.Parameters.AddWithValue("@nom", TextBox11.Text)
            cmd.Parameters.AddWithValue("@prenom", TextBox22.Text)
            cmd.Parameters.AddWithValue("@adresse", TextBox33.Text)

            ' Convertir l'image en bytes
            Dim ms As New IO.MemoryStream()
            PictureBox11.Image.Save(ms, PictureBox11.Image.RawFormat)
            cmd.Parameters.AddWithValue("@photo", ms.ToArray())

            cmd.ExecuteNonQuery()
            MessageBox.Show("Enregistrement mis à jour avec succès")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub Supprimer_cli()
        Try
            If DataGridView.SelectedRows.Count = 0 Then
                MessageBox.Show("Veuillez sélectionner un produit à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            connection.Open()
            Dim query As String = "DELETE FROM clients WHERE id_clients=@id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id", DataGridView.CurrentRow.Cells(0).Value)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Enregistrement supprimé avec succès")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Charger_Photo()
        Dim openFileDialog As New OpenFileDialog()

        With openFileDialog
            .Filter = "Fichier Image (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg"
            .FilterIndex = 1
            .Title = "Sélectionnez une image"
        End With

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Afficher l'image sélectionnée dans la PictureBox
            PictureBox11.Image = Image.FromFile(openFileDialog.FileName)
        End If

    End Sub

    Private Sub ResetFields()
        ' Réinitialiser les TextBox
        TextBox11.Clear()
        TextBox22.Clear()
        TextBox33.Clear()
        PictureBox11.Image = Nothing
    End Sub

    Private Sub RechercheAutomatique(texte As String)
        Dim dataTable As DataTable = CType(DataGridView.DataSource, DataTable)
        If dataTable IsNot Nothing Then
            dataTable.DefaultView.RowFilter = $"nom LIKE '%{texte}%' OR prenom LIKE '%{texte}%'"
        End If
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Supprimer_cli()

        ' Effacer les champs si aucune ligne n'est sélectionnée
        TextBox11.Text = ""
        TextBox22.Text = ""
        TextBox33.Text = ""
        PictureBox11.Image = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Modifier_cli()

        ' Effacer les champs si aucune ligne n'est sélectionnée
        TextBox11.Text = ""
        TextBox22.Text = ""
        TextBox33.Text = ""
        PictureBox11.Image = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Ajouter_cli()

        ' Effacer les champs si aucune ligne n'est sélectionnée
        TextBox11.Text = ""
        TextBox22.Text = ""
        TextBox33.Text = ""
        PictureBox11.Image = Nothing
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Charger_Photo()
    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellContentClick
    End Sub

    Private Sub DataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView.SelectionChanged
        Donnée_sel()
    End Sub
    Private Sub LoadClientData()
        DataGridView.DataSource = Nothing
        DataGridView.DataSource = getAllClients()
    End Sub
    Public Function getAllClients() As DataTable
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM `clients`"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.ExecuteNonQuery()
            'Dim tableClients As DataTable = connection.getData(query, Nothing)
            'Return tableClients
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Function
    Private Sub Donnée_sel()
        Try
            ' Vérifiez si une ligne est sélectionnée
            If DataGridView.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView.SelectedRows(0)

                ' Récupérez les données des colonnes correspondantes
                TextBox11.Text = selectedRow.Cells("nom").Value.ToString()
                TextBox22.Text = selectedRow.Cells("prenom").Value.ToString()
                TextBox33.Text = selectedRow.Cells("adresse").Value.ToString()

                ' Récupérez et affichez l'image
                Dim imageBytes As Byte() = CType(selectedRow.Cells("photo").Value, Byte())
                If imageBytes IsNot Nothing Then
                    Using ms As New IO.MemoryStream(imageBytes)
                        PictureBox11.Image = Image.FromStream(ms)
                    End Using
                Else
                    PictureBox11.Image = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la sélection : " & ex.Message)
        End Try
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Supprimer l'image affichée dans la PictureBox
        PictureBox11.Image = Nothing

    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox44.TextChanged
        RechercheAutomatique(TextBox44.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Buttonproo.Click

        Dim form1 As New Form2()
        form1.ShowDialog() ' Optionnel : Bloque jusqu'à ce que Form1 soit fermé
        Me.Close()
    End Sub

    Private Sub Buttonven_Click(sender As Object, e As EventArgs) Handles Buttonvenn.Click

        Dim form3 As New Vente()
        form3.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Charger_cli()

        ResetFields()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button88.Click
        Dim form As New Login()
        form.ShowDialog()
        Me.Close()
    End Sub


End Class