<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        GroupBox2 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Button8 = New Button()
        Button7 = New Button()
        Label41 = New Label()
        Label32 = New Label()
        Textpass = New TextBox()
        Textuser = New TextBox()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.CornflowerBlue
        GroupBox2.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Controls.Add(Button8)
        GroupBox2.Controls.Add(Button7)
        GroupBox2.Controls.Add(Label41)
        GroupBox2.Controls.Add(Label32)
        GroupBox2.Controls.Add(Textpass)
        GroupBox2.Controls.Add(Textuser)
        GroupBox2.Font = New Font("Segoe UI Semibold", 15F, FontStyle.Bold)
        GroupBox2.Location = New Point(12, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1900, 1027)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 22F)
        Label2.Location = New Point(117, 587)
        Label2.Name = "Label2"
        Label2.Size = New Size(364, 50)
        Label2.TabIndex = 24
        Label2.Text = "CONECTEZ-VOUS ICI"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22F)
        Label1.Location = New Point(65, 746)
        Label1.Name = "Label1"
        Label1.Size = New Size(460, 50)
        Label1.TabIndex = 23
        Label1.Text = "QUITTER LA CONNECTION"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = SystemColors.ControlDarkDark
        PictureBox1.BackgroundImage = My.Resources.Resources.n_a_fidelisation_clientele
        PictureBox1.Location = New Point(577, 21)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1317, 992)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Segoe UI", 20F)
        Button8.Location = New Point(156, 670)
        Button8.Name = "Button8"
        Button8.Size = New Size(292, 56)
        Button8.TabIndex = 19
        Button8.Text = "CONNECTION"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Segoe UI", 20F)
        Button7.Location = New Point(156, 821)
        Button7.Name = "Button7"
        Button7.Size = New Size(292, 56)
        Button7.TabIndex = 18
        Button7.Text = "QUITTER"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Label41
        ' 
        Label41.AutoSize = True
        Label41.Font = New Font("Segoe UI", 22F)
        Label41.Location = New Point(117, 229)
        Label41.Name = "Label41"
        Label41.Size = New Size(363, 50)
        Label41.TabIndex = 5
        Label41.Text = "NOM D'UTILISATEUR"
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI", 22F)
        Label32.Location = New Point(165, 421)
        Label32.Name = "Label32"
        Label32.Size = New Size(266, 50)
        Label32.TabIndex = 4
        Label32.Text = "MOT DE PASSE"
        ' 
        ' Textpass
        ' 
        Textpass.BackColor = SystemColors.Info
        Textpass.Font = New Font("Segoe UI", 20F)
        Textpass.Location = New Point(65, 497)
        Textpass.Name = "Textpass"
        Textpass.PlaceholderText = "Tapez ici"
        Textpass.Size = New Size(462, 52)
        Textpass.TabIndex = 7
        Textpass.TextAlign = HorizontalAlignment.Center
        ' 
        ' Textuser
        ' 
        Textuser.AccessibleDescription = ""
        Textuser.BackColor = SystemColors.Info
        Textuser.Font = New Font("Segoe UI", 20F)
        Textuser.Location = New Point(65, 324)
        Textuser.Name = "Textuser"
        Textuser.PlaceholderText = "Tapez ici"
        Textuser.Size = New Size(462, 52)
        Textuser.TabIndex = 6
        Textuser.TextAlign = HorizontalAlignment.Center
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1037)
        Controls.Add(GroupBox2)
        Name = "Login"
        Text = "Login"
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label41 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Textpass As TextBox
    Friend WithEvents Textuser As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
