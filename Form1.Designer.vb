<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        PictureBox1 = New PictureBox()
        Photo = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        GroupBox1 = New GroupBox()
        Button8 = New Button()
        Buttonpro = New Button()
        Buttonven = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Label5 = New Label()
        DataGridView1 = New DataGridView()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        TextBox4 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = SystemColors.ControlDarkDark
        PictureBox1.Location = New Point(148, 95)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(315, 307)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Photo
        ' 
        Photo.AutoSize = True
        Photo.Font = New Font("Segoe UI", 22.0F)
        Photo.Location = New Point(204, 42)
        Photo.Name = "Photo"
        Photo.Size = New Size(140, 50)
        Photo.TabIndex = 1
        Photo.Text = "PHOTO"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.0F)
        Label1.Location = New Point(808, 197)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 50)
        Label1.TabIndex = 2
        Label1.Text = "RECHERCHE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 22.0F)
        Label2.Location = New Point(219, 621)
        Label2.Name = "Label2"
        Label2.Size = New Size(172, 50)
        Label2.TabIndex = 3
        Label2.Text = "ADRESSE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 22.0F)
        Label3.Location = New Point(204, 517)
        Label3.Name = "Label3"
        Label3.Size = New Size(173, 50)
        Label3.TabIndex = 4
        Label3.Text = "PRENOM"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 22.0F)
        Label4.Location = New Point(247, 409)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 50)
        Label4.TabIndex = 5
        Label4.Text = "NOM"
        ' 
        ' TextBox1
        ' 
        TextBox1.AccessibleDescription = ""
        TextBox1.BackColor = SystemColors.Info
        TextBox1.Font = New Font("Segoe UI", 20.0F)
        TextBox1.Location = New Point(90, 462)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Tapez ici"
        TextBox1.Size = New Size(439, 52)
        TextBox1.TabIndex = 6
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.Info
        TextBox2.Font = New Font("Segoe UI", 20.0F)
        TextBox2.Location = New Point(90, 566)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Tapez ici"
        TextBox2.Size = New Size(439, 52)
        TextBox2.TabIndex = 7
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.Info
        TextBox3.Font = New Font("Segoe UI", 20.0F)
        TextBox3.Location = New Point(90, 674)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Tapez ici"
        TextBox3.Size = New Size(439, 52)
        TextBox3.TabIndex = 8
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(Button8)
        GroupBox1.Controls.Add(Buttonpro)
        GroupBox1.Controls.Add(Buttonven)
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(DataGridView1)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Photo)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI Semibold", 15.0F, FontStyle.Bold)
        GroupBox1.Location = New Point(1, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1885, 1039)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "."
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Segoe UI", 20.0F)
        Button8.Location = New Point(1740, 19)
        Button8.Name = "Button8"
        Button8.Size = New Size(60, 57)
        Button8.TabIndex = 21
        Button8.Text = "X"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Buttonpro
        ' 
        Buttonpro.Font = New Font("Segoe UI", 20.0F)
        Buttonpro.Location = New Point(1118, 21)
        Buttonpro.Name = "Buttonpro"
        Buttonpro.Size = New Size(213, 56)
        Buttonpro.TabIndex = 19
        Buttonpro.Text = "PRODUITS"
        Buttonpro.UseVisualStyleBackColor = True
        ' 
        ' Buttonven
        ' 
        Buttonven.Font = New Font("Segoe UI", 20.0F)
        Buttonven.Location = New Point(1424, 20)
        Buttonven.Name = "Buttonven"
        Buttonven.Size = New Size(213, 56)
        Buttonven.TabIndex = 18
        Buttonven.Text = "VENTES"
        Buttonven.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(544, 306)
        Button6.Name = "Button6"
        Button6.Size = New Size(67, 65)
        Button6.TabIndex = 17
        Button6.Text = "-"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(544, 143)
        Button5.Name = "Button5"
        Button5.Size = New Size(67, 65)
        Button5.TabIndex = 16
        Button5.Text = "+"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 34.0F)
        Label5.Location = New Point(602, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(426, 76)
        Label5.TabIndex = 15
        Label5.Text = "PARTIE CLIENTS"
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle1.SelectionBackColor = Color.Thistle
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.BackgroundColor = SystemColors.ControlDarkDark
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(753, 306)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1081, 694)
        DataGridView1.TabIndex = 14
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Red
        Button4.Font = New Font("Segoe UI", 20.0F)
        Button4.ForeColor = SystemColors.ActiveCaptionText
        Button4.Location = New Point(350, 853)
        Button4.Name = "Button4"
        Button4.Size = New Size(205, 56)
        Button4.TabIndex = 13
        Button4.Text = "SUPPRIMER"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Goldenrod
        Button3.Font = New Font("Segoe UI", 20.0F)
        Button3.Location = New Point(350, 758)
        Button3.Name = "Button3"
        Button3.Size = New Size(205, 56)
        Button3.TabIndex = 12
        Button3.Text = "MODIFIER"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 20.0F)
        Button2.Location = New Point(72, 853)
        Button2.Name = "Button2"
        Button2.Size = New Size(213, 56)
        Button2.TabIndex = 11
        Button2.Text = "ACTUALISER"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LavenderBlush
        Button1.Font = New Font("Segoe UI", 20.0F)
        Button1.Location = New Point(72, 758)
        Button1.Name = "Button1"
        Button1.Size = New Size(213, 56)
        Button1.TabIndex = 10
        Button1.Text = "AJOUTER"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.LightYellow
        TextBox4.Font = New Font("Segoe UI", 20F)
        TextBox4.Location = New Point(1077, 195)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Tapez ici"
        TextBox4.Size = New Size(633, 52)
        TextBox4.TabIndex = 9
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1888, 1040)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Photo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Buttonpro As Button
    Friend WithEvents Buttonven As Button
    Friend WithEvents Button8 As Button

End Class
