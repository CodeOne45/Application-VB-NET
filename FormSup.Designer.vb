<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSup
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSup))
        Me.ComboBoxCandidatsInscrit = New System.Windows.Forms.ComboBox()
        Me.TextBoxCandRchr = New System.Windows.Forms.TextBox()
        Me.ButtonVoirCand = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBoxCandidatsInscrit
        '
        Me.ComboBoxCandidatsInscrit.FormattingEnabled = True
        Me.ComboBoxCandidatsInscrit.Location = New System.Drawing.Point(325, 173)
        Me.ComboBoxCandidatsInscrit.Name = "ComboBoxCandidatsInscrit"
        Me.ComboBoxCandidatsInscrit.Size = New System.Drawing.Size(233, 24)
        Me.ComboBoxCandidatsInscrit.TabIndex = 0
        '
        'TextBoxCandRchr
        '
        Me.TextBoxCandRchr.Location = New System.Drawing.Point(325, 300)
        Me.TextBoxCandRchr.Name = "TextBoxCandRchr"
        Me.TextBoxCandRchr.Size = New System.Drawing.Size(233, 22)
        Me.TextBoxCandRchr.TabIndex = 1
        '
        'ButtonVoirCand
        '
        Me.ButtonVoirCand.Location = New System.Drawing.Point(476, 376)
        Me.ButtonVoirCand.Name = "ButtonVoirCand"
        Me.ButtonVoirCand.Size = New System.Drawing.Size(171, 67)
        Me.ButtonVoirCand.TabIndex = 2
        Me.ButtonVoirCand.Text = "Supprimer Candidat"
        Me.ButtonVoirCand.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(122, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Supprimer avec numéro candidat:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(429, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ou"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(402, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Supprimer un candidat parmi la liste de candidats déja inscrits:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(191, 67)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Retour à l'accueil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-20, -9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(876, 596)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(350, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(106, 83)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'FormSup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 483)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonVoirCand)
        Me.Controls.Add(Me.TextBoxCandRchr)
        Me.Controls.Add(Me.ComboBoxCandidatsInscrit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormSup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSup"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxCandidatsInscrit As ComboBox
    Friend WithEvents TextBoxCandRchr As TextBox
    Friend WithEvents ButtonVoirCand As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
