<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtatInscription
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EtatInscription))
        Me.ListBoxNumC = New System.Windows.Forms.ListBox()
        Me.ListBoxNomC = New System.Windows.Forms.ListBox()
        Me.ListBoxPrenomC = New System.Windows.Forms.ListBox()
        Me.ListBoxMEC = New System.Windows.Forms.ListBox()
        Me.ListBoxMOC = New System.Windows.Forms.ListBox()
        Me.ListBoxMFC = New System.Windows.Forms.ListBox()
        Me.ButtonBackMenu = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxNumC
        '
        Me.ListBoxNumC.FormattingEnabled = True
        Me.ListBoxNumC.ItemHeight = 16
        Me.ListBoxNumC.Location = New System.Drawing.Point(12, 107)
        Me.ListBoxNumC.Name = "ListBoxNumC"
        Me.ListBoxNumC.Size = New System.Drawing.Size(142, 180)
        Me.ListBoxNumC.TabIndex = 0
        '
        'ListBoxNomC
        '
        Me.ListBoxNomC.FormattingEnabled = True
        Me.ListBoxNomC.ItemHeight = 16
        Me.ListBoxNomC.Location = New System.Drawing.Point(176, 107)
        Me.ListBoxNomC.Name = "ListBoxNomC"
        Me.ListBoxNomC.Size = New System.Drawing.Size(147, 180)
        Me.ListBoxNomC.TabIndex = 0
        '
        'ListBoxPrenomC
        '
        Me.ListBoxPrenomC.FormattingEnabled = True
        Me.ListBoxPrenomC.ItemHeight = 16
        Me.ListBoxPrenomC.Location = New System.Drawing.Point(342, 107)
        Me.ListBoxPrenomC.Name = "ListBoxPrenomC"
        Me.ListBoxPrenomC.Size = New System.Drawing.Size(147, 180)
        Me.ListBoxPrenomC.TabIndex = 0
        '
        'ListBoxMEC
        '
        Me.ListBoxMEC.FormattingEnabled = True
        Me.ListBoxMEC.HorizontalScrollbar = True
        Me.ListBoxMEC.ItemHeight = 16
        Me.ListBoxMEC.Location = New System.Drawing.Point(509, 107)
        Me.ListBoxMEC.Name = "ListBoxMEC"
        Me.ListBoxMEC.Size = New System.Drawing.Size(147, 180)
        Me.ListBoxMEC.TabIndex = 0
        '
        'ListBoxMOC
        '
        Me.ListBoxMOC.FormattingEnabled = True
        Me.ListBoxMOC.HorizontalScrollbar = True
        Me.ListBoxMOC.ItemHeight = 16
        Me.ListBoxMOC.Location = New System.Drawing.Point(681, 107)
        Me.ListBoxMOC.Name = "ListBoxMOC"
        Me.ListBoxMOC.Size = New System.Drawing.Size(147, 180)
        Me.ListBoxMOC.TabIndex = 0
        '
        'ListBoxMFC
        '
        Me.ListBoxMFC.FormattingEnabled = True
        Me.ListBoxMFC.ItemHeight = 16
        Me.ListBoxMFC.Location = New System.Drawing.Point(851, 107)
        Me.ListBoxMFC.Name = "ListBoxMFC"
        Me.ListBoxMFC.Size = New System.Drawing.Size(147, 180)
        Me.ListBoxMFC.TabIndex = 0
        '
        'ButtonBackMenu
        '
        Me.ButtonBackMenu.Location = New System.Drawing.Point(358, 327)
        Me.ButtonBackMenu.Name = "ButtonBackMenu"
        Me.ButtonBackMenu.Size = New System.Drawing.Size(283, 50)
        Me.ButtonBackMenu.TabIndex = 1
        Me.ButtonBackMenu.Text = "Revenir à l'accueil"
        Me.ButtonBackMenu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numéro Candidat :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom Candidat :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(339, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prénom Candidat :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(502, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Les matières à l’ ́ecrit : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(667, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Les matières à l’ ́oral : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(848, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "la matière facultative :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-17, -15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1040, 431)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(479, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'EtatInscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 402)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonBackMenu)
        Me.Controls.Add(Me.ListBoxMFC)
        Me.Controls.Add(Me.ListBoxMOC)
        Me.Controls.Add(Me.ListBoxMEC)
        Me.Controls.Add(Me.ListBoxPrenomC)
        Me.Controls.Add(Me.ListBoxNomC)
        Me.Controls.Add(Me.ListBoxNumC)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "EtatInscription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EtatInscription"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxNumC As ListBox
    Friend WithEvents ListBoxNomC As ListBox
    Friend WithEvents ListBoxPrenomC As ListBox
    Friend WithEvents ListBoxMEC As ListBox
    Friend WithEvents ListBoxMOC As ListBox
    Friend WithEvents ListBoxMFC As ListBox
    Friend WithEvents ButtonBackMenu As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
