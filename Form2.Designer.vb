<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        Button8 = New Button()
        Button7 = New Button()
        Label5 = New Label()
        DataGridView2 = New DataGridView()
        Buttonsup = New Button()
        Buttonmod = New Button()
        Buttonact = New Button()
        Buttonaj = New Button()
        Textrech = New TextBox()
        Label41 = New Label()
        Label24 = New Label()
        Label32 = New Label()
        Textpr = New TextBox()
        Textlib = New TextBox()
        Label1 = New Label()
        VentBindingSource = New BindingSource(components)
        GroupBox2.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(VentBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.LightBlue
        GroupBox2.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(ComboBox1)
        GroupBox2.Controls.Add(Button8)
        GroupBox2.Controls.Add(Button7)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(DataGridView2)
        GroupBox2.Controls.Add(Buttonsup)
        GroupBox2.Controls.Add(Buttonmod)
        GroupBox2.Controls.Add(Buttonact)
        GroupBox2.Controls.Add(Buttonaj)
        GroupBox2.Controls.Add(Textrech)
        GroupBox2.Controls.Add(Label41)
        GroupBox2.Controls.Add(Label24)
        GroupBox2.Controls.Add(Label32)
        GroupBox2.Controls.Add(Textpr)
        GroupBox2.Controls.Add(Textlib)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        GroupBox2.Location = New Point(0, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1925, 1027)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "."
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 20F)
        Button1.Location = New Point(1538, 115)
        Button1.Name = "Button1"
        Button1.Size = New Size(51, 56)
        Button1.TabIndex = 23
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox1.BackColor = SystemColors.Info
        ComboBox1.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Fixations", "Câbles de tension", "Jointures", "Carreaux", "Tullauterie", "Métal"})
        ComboBox1.Location = New Point(42, 611)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(430, 53)
        ComboBox1.TabIndex = 22
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Segoe UI", 20F)
        Button8.Location = New Point(839, 27)
        Button8.Name = "Button8"
        Button8.Size = New Size(213, 56)
        Button8.TabIndex = 19
        Button8.Text = "CLIENTS"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Segoe UI", 20F)
        Button7.Location = New Point(1198, 27)
        Button7.Name = "Button7"
        Button7.Size = New Size(213, 56)
        Button7.TabIndex = 18
        Button7.Text = "VENTE"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 34F)
        Label5.Location = New Point(144, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(479, 76)
        Label5.TabIndex = 15
        Label5.Text = "PARTIE PRODUITS"
        ' 
        ' DataGridView2
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle1.SelectionBackColor = Color.Thistle
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.BackgroundColor = SystemColors.ControlDarkDark
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(515, 321)
        DataGridView2.MultiSelect = False
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(1166, 692)
        DataGridView2.TabIndex = 14
        ' 
        ' Buttonsup
        ' 
        Buttonsup.BackColor = Color.OrangeRed
        Buttonsup.Font = New Font("Segoe UI", 20F)
        Buttonsup.Location = New Point(276, 823)
        Buttonsup.Name = "Buttonsup"
        Buttonsup.Size = New Size(205, 56)
        Buttonsup.TabIndex = 13
        Buttonsup.Text = "SUPPRIMER"
        Buttonsup.UseVisualStyleBackColor = False
        ' 
        ' Buttonmod
        ' 
        Buttonmod.BackColor = Color.Goldenrod
        Buttonmod.Font = New Font("Segoe UI", 20F)
        Buttonmod.Location = New Point(276, 715)
        Buttonmod.Name = "Buttonmod"
        Buttonmod.Size = New Size(205, 56)
        Buttonmod.TabIndex = 12
        Buttonmod.Text = "MODIFIER"
        Buttonmod.UseVisualStyleBackColor = False
        ' 
        ' Buttonact
        ' 
        Buttonact.Font = New Font("Segoe UI", 20F)
        Buttonact.Location = New Point(33, 823)
        Buttonact.Name = "Buttonact"
        Buttonact.Size = New Size(213, 56)
        Buttonact.TabIndex = 11
        Buttonact.Text = "ACTUALISER"
        Buttonact.UseVisualStyleBackColor = True
        ' 
        ' Buttonaj
        ' 
        Buttonaj.BackColor = Color.LavenderBlush
        Buttonaj.Font = New Font("Segoe UI", 20F)
        Buttonaj.Location = New Point(33, 715)
        Buttonaj.Name = "Buttonaj"
        Buttonaj.Size = New Size(213, 56)
        Buttonaj.TabIndex = 10
        Buttonaj.Text = "AJOUTER"
        Buttonaj.UseVisualStyleBackColor = False
        ' 
        ' Textrech
        ' 
        Textrech.BackColor = Color.LightYellow
        Textrech.Font = New Font("Segoe UI", 20F)
        Textrech.Location = New Point(917, 217)
        Textrech.Name = "Textrech"
        Textrech.PlaceholderText = "Tapez ici"
        Textrech.Size = New Size(672, 52)
        Textrech.TabIndex = 9
        Textrech.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Segoe UI", 22F)
        Label41.Location = New Point(197, 244)
        Label41.Name = "Label41"
        Label41.Size = New Size(142, 50)
        Label41.TabIndex = 5
        Label41.Text = "LIBELLE"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 22F)
        Label24.Location = New Point(154, 542)
        Label24.Name = "Label24"
        Label24.Size = New Size(208, 50)
        Label24.TabIndex = 3
        Label24.Text = "CATEGORIE"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI", 22F)
        Label32.Location = New Point(207, 403)
        Label32.Name = "Label32"
        Label32.Size = New Size(97, 50)
        Label32.TabIndex = 4
        Label32.Text = "PRIX"
        ' 
        ' Textpr
        ' 
        Textpr.BackColor = SystemColors.Info
        Textpr.Font = New Font("Segoe UI", 20F)
        Textpr.Location = New Point(33, 456)
        Textpr.Name = "Textpr"
        Textpr.PlaceholderText = "Tapez ici"
        Textpr.Size = New Size(439, 52)
        Textpr.TabIndex = 7
        Textpr.TextAlign = HorizontalAlignment.Center
        ' 
        ' Textlib
        ' 
        Textlib.AccessibleDescription = ""
        Textlib.BackColor = SystemColors.Info
        Textlib.Font = New Font("Segoe UI", 20F)
        Textlib.Location = New Point(42, 310)
        Textlib.Name = "Textlib"
        Textlib.PlaceholderText = "Tapez ici"
        Textlib.Size = New Size(439, 52)
        Textlib.TabIndex = 6
        Textlib.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22F)
        Label1.Location = New Point(610, 216)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 50)
        Label1.TabIndex = 2
        Label1.Text = "RECHERCHE"
        ' 
        ' VentBindingSource
        ' 
        VentBindingSource.DataSource = GetType(Vent)
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1860, 1027)
        Controls.Add(GroupBox2)
        Name = "Form2"
        Text = "Form2"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(VentBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Buttonsup As Button
    Friend WithEvents Buttonmod As Button
    Friend WithEvents Buttonact As Button
    Friend WithEvents Buttonaj As Button
    Friend WithEvents Textrech As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Textpr As TextBox
    Friend WithEvents Textlib As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents VentBindingSource As BindingSource
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
End Class
