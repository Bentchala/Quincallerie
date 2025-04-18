<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vente
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
        GroupBox1 = New GroupBox()
        Label6 = New Label()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Label5 = New Label()
        Label3 = New Label()
        Label41 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        DataGridView3 = New DataGridView()
        TextBox4 = New TextBox()
        Buttonpro = New Button()
        Button7 = New Button()
        ComboBoxprix = New ComboBox()
        Textnbr = New TextBox()
        ComboBoxlib = New ComboBox()
        ComboBoxnom = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        VentBindingSource = New BindingSource(components)
        PrintDocument1 = New Printing.PrintDocument()
        GroupBox1.SuspendLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(VentBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.GradientInactiveCaption
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Button6)
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label41)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(DataGridView3)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Buttonpro)
        GroupBox1.Controls.Add(Button7)
        GroupBox1.Controls.Add(ComboBoxprix)
        GroupBox1.Controls.Add(Textnbr)
        GroupBox1.Controls.Add(ComboBoxlib)
        GroupBox1.Controls.Add(ComboBoxnom)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Font = New Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(3, 1)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1924, 1052)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 32F)
        Label6.Location = New Point(393, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(361, 72)
        Label6.TabIndex = 37
        Label6.Text = "PARTIE VENTE"
        ' 
        ' Button6
        ' 
        Button6.BackColor = SystemColors.ActiveCaption
        Button6.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(1362, 164)
        Button6.Name = "Button6"
        Button6.Size = New Size(242, 79)
        Button6.TabIndex = 36
        Button6.Text = "IMPRIMER"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Red
        Button5.Font = New Font("Segoe UI", 20F)
        Button5.ForeColor = SystemColors.ActiveCaptionText
        Button5.Location = New Point(281, 899)
        Button5.Name = "Button5"
        Button5.Size = New Size(205, 56)
        Button5.TabIndex = 35
        Button5.Text = "SUPPRIMER"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 20F)
        Button4.Location = New Point(24, 899)
        Button4.Name = "Button4"
        Button4.Size = New Size(213, 56)
        Button4.TabIndex = 34
        Button4.Text = "ACTUALISER"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Goldenrod
        Button3.Font = New Font("Segoe UI", 20F)
        Button3.Location = New Point(910, 1014)
        Button3.Name = "Button3"
        Button3.Size = New Size(16, 12)
        Button3.TabIndex = 33
        Button3.Text = "MODIFIER"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LavenderBlush
        Button2.Font = New Font("Segoe UI", 20F)
        Button2.Location = New Point(139, 814)
        Button2.Name = "Button2"
        Button2.Size = New Size(213, 56)
        Button2.TabIndex = 32
        Button2.Text = "AJOUTER"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 22F)
        Label5.Location = New Point(91, 672)
        Label5.Name = "Label5"
        Label5.Size = New Size(389, 50)
        Label5.TabIndex = 31
        Label5.Text = "NOMBRE DE PRODUIT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 22F)
        Label3.Location = New Point(111, 535)
        Label3.Name = "Label3"
        Label3.Size = New Size(319, 50)
        Label3.TabIndex = 30
        Label3.Text = "PRIX DU PRODUIT"
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Segoe UI", 22F)
        Label41.Location = New Point(91, 411)
        Label41.Name = "Label41"
        Label41.Size = New Size(364, 50)
        Label41.TabIndex = 29
        Label41.Text = "LIBELLE DU PRODUIT"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 22F)
        Label2.Location = New Point(111, 271)
        Label2.Name = "Label2"
        Label2.Size = New Size(279, 50)
        Label2.TabIndex = 28
        Label2.Text = "DATE DE VENTE"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 19F)
        Label4.Location = New Point(92, 126)
        Label4.Name = "Label4"
        Label4.Size = New Size(260, 45)
        Label4.TabIndex = 27
        Label4.Text = "NOM DU CLIENT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22F)
        Label1.Location = New Point(572, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(220, 50)
        Label1.TabIndex = 26
        Label1.Text = "RECHERCHE"
        ' 
        ' DataGridView3
        ' 
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        DataGridViewCellStyle1.SelectionBackColor = Color.Thistle
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridView3.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridView3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView3.BackgroundColor = SystemColors.ControlDarkDark
        DataGridView3.BorderStyle = BorderStyle.None
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(612, 271)
        DataGridView3.MultiSelect = False
        DataGridView3.Name = "DataGridView3"
        DataGridView3.RowHeadersWidth = 51
        DataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView3.Size = New Size(1127, 714)
        DataGridView3.TabIndex = 25
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.LightYellow
        TextBox4.Font = New Font("Segoe UI", 20F)
        TextBox4.Location = New Point(813, 179)
        TextBox4.Name = "TextBox4"
        TextBox4.PlaceholderText = "Tapez ici"
        TextBox4.Size = New Size(482, 52)
        TextBox4.TabIndex = 24
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Buttonpro
        ' 
        Buttonpro.Font = New Font("Segoe UI", 20F)
        Buttonpro.Location = New Point(1082, 34)
        Buttonpro.Name = "Buttonpro"
        Buttonpro.Size = New Size(213, 56)
        Buttonpro.TabIndex = 22
        Buttonpro.Text = "PRODUITS"
        Buttonpro.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Segoe UI", 20F)
        Button7.Location = New Point(823, 34)
        Button7.Name = "Button7"
        Button7.Size = New Size(213, 56)
        Button7.TabIndex = 21
        Button7.Text = "CLIENTS"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxprix
        ' 
        ComboBoxprix.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBoxprix.BackColor = Color.WhiteSmoke
        ComboBoxprix.Font = New Font("Segoe UI", 20F)
        ComboBoxprix.FormattingEnabled = True
        ComboBoxprix.Location = New Point(18, 588)
        ComboBoxprix.Name = "ComboBoxprix"
        ComboBoxprix.Size = New Size(462, 53)
        ComboBoxprix.TabIndex = 8
        ' 
        ' Textnbr
        ' 
        Textnbr.AccessibleDescription = ""
        Textnbr.BackColor = SystemColors.Info
        Textnbr.Font = New Font("Segoe UI", 20F)
        Textnbr.Location = New Point(18, 725)
        Textnbr.Name = "Textnbr"
        Textnbr.PlaceholderText = "Tapez ici"
        Textnbr.Size = New Size(462, 52)
        Textnbr.TabIndex = 7
        Textnbr.TextAlign = HorizontalAlignment.Center
        ' 
        ' ComboBoxlib
        ' 
        ComboBoxlib.BackColor = SystemColors.MenuBar
        ComboBoxlib.Font = New Font("Segoe UI", 20F)
        ComboBoxlib.FormattingEnabled = True
        ComboBoxlib.Location = New Point(18, 479)
        ComboBoxlib.Name = "ComboBoxlib"
        ComboBoxlib.Size = New Size(462, 53)
        ComboBoxlib.TabIndex = 2
        ' 
        ' ComboBoxnom
        ' 
        ComboBoxnom.BackColor = SystemColors.MenuBar
        ComboBoxnom.Font = New Font("Segoe UI", 20F)
        ComboBoxnom.FormattingEnabled = True
        ComboBoxnom.Location = New Point(24, 190)
        ComboBoxnom.Name = "ComboBoxnom"
        ComboBoxnom.Size = New Size(462, 53)
        ComboBoxnom.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 20F)
        DateTimePicker1.Location = New Point(24, 324)
        DateTimePicker1.MaxDate = New Date(3998, 12, 31, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(462, 52)
        DateTimePicker1.TabIndex = 0
        ' 
        ' VentBindingSource
        ' 
        VentBindingSource.DataSource = GetType(Vent)
        ' 
        ' Vente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1055)
        Controls.Add(GroupBox1)
        Name = "Vente"
        Text = "Vente"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(VentBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxlib As ComboBox
    Friend WithEvents ComboBoxnom As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents VentBindingSource As BindingSource
    Friend WithEvents Textnbr As TextBox
    Friend WithEvents ComboBoxprix As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Buttonpro As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
End Class
