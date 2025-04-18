Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Charger_cli()
        ConfigureDataGridView()
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
            DataGridView1.DataSource = table

            ' Ajuster automatiquement la taille des colonnes pour un affichage propre
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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
            cmd.Parameters.AddWithValue("@nom", TextBox1.Text)
            cmd.Parameters.AddWithValue("@prenom", TextBox2.Text)
            cmd.Parameters.AddWithValue("@adresse", TextBox3.Text)

            ' Convertir l'image en bytes
            Dim ms As New IO.MemoryStream()
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            cmd.Parameters.AddWithValue("@photo", ms.ToArray())

            cmd.ExecuteNonQuery()
            MessageBox.Show("Ajouté réussi")
            Charger_cli()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub Modifier_cli()
        Try
            connection.Open()
            Dim query As String = "UPDATE clients SET nom=@nom, prenom=@prenom, adresse=@adresse, photo=@photo WHERE id_client=@id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
            cmd.Parameters.AddWithValue("@nom", TextBox1.Text)
            cmd.Parameters.AddWithValue("@prenom", TextBox2.Text)
            cmd.Parameters.AddWithValue("@adresse", TextBox3.Text)

            ' Convertir l'image en bytes
            Dim ms As New IO.MemoryStream()
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
            cmd.Parameters.AddWithValue("@photo", ms.ToArray())

            cmd.ExecuteNonQuery()
            MessageBox.Show("Enregistrement mis à jour avec succès")
            Charger_cli()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub


    Private Sub Supprimer_cli()
        Try
            If DataGridView1.SelectedRows.Count = 0 Then
                MessageBox.Show("Veuillez sélectionner un produit à supprimer.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            connection.Open()
            Dim query As String = "DELETE FROM clients WHERE id_client=@id"
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@id", DataGridView1.CurrentRow.Cells(0).Value)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Enregistrement supprimé avec succès")
            Charger_cli()
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
            PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
        End If

    End Sub

    Private Sub ResetFields()
        ' Réinitialiser les TextBox
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        PictureBox1.Image = Nothing
    End Sub


    Private Sub RechercheAutomatique(texte As String)
        Dim dataTable As DataTable = CType(DataGridView1.DataSource, DataTable)
        If dataTable IsNot Nothing Then
            dataTable.DefaultView.RowFilter = $"nom LIKE '%{texte}%' OR prenom LIKE '%{texte}%'"
        End If
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Supprimer_cli()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Modifier_cli()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ajouter_cli()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Charger_Photo()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Charger_cli()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Donnée_sel()
    End Sub

    Private Sub Donnée_sel()
        Try
            ' Vérifiez si une ligne est sélectionnée
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Récupérez les données des colonnes correspondantes
                TextBox1.Text = selectedRow.Cells("nom").Value.ToString()
                TextBox2.Text = selectedRow.Cells("prenom").Value.ToString()
                TextBox3.Text = selectedRow.Cells("adresse").Value.ToString()

                ' Récupérez et affichez l'image
                Dim imageBytes As Byte() = CType(selectedRow.Cells("photo").Value, Byte())
                If imageBytes IsNot Nothing Then
                    Using ms As New IO.MemoryStream(imageBytes)
                        PictureBox1.Image = Image.FromStream(ms)
                    End Using
                Else
                    PictureBox1.Image = Nothing
                End If
                Charger_cli()
            End If
        Catch ex As Exception
            MessageBox.Show("Erreur lors de la sélection : " & ex.Message)
        End Try
    End Sub
    Private Sub ConfigureDataGridView()
        ' Activer la redimension automatique pour toutes les colonnes et lignes
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Ajuster la hauteur des lignes
        For Each row As DataGridViewRow In DataGridView1.Rows
            row.Height = 30 ' Ajustez cette valeur pour une meilleure visibilité des images
        Next

        ' Configurer la colonne d'images si elle existe
        If DataGridView1.Columns.Contains("ImageColumnName") Then
            Dim imageColumn As DataGridViewImageColumn = CType(DataGridView1.Columns("ImageColumnName"), DataGridViewImageColumn)
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch ' Zoom pour s'adapter à la cellule
        End If
    End Sub


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ' Supprimer l'image affichée dans la PictureBox
        PictureBox1.Image = Nothing

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        RechercheAutomatique(TextBox4.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Buttonpro.Click


        Dim form1 As New Form2()
        form1.ShowDialog() ' Optionnel : Bloque jusqu'à ce que Form1 soit fermé
        Me.Close()
    End Sub

    Private Sub Buttonven_Click(sender As Object, e As EventArgs) Handles Buttonven.Click
        Dim form3 As New Vente()
        form3.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ResetFields()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click

        Dim form As New Login()
        form.ShowDialog()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
