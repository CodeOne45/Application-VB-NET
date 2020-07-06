<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModif
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormModif))
        Me.ButtonModifInfCand = New System.Windows.Forms.Button()
        Me.ComboBoxCandidatsInscrit = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxModifC = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonModifInfCand
        '
        Me.ButtonModifInfCand.Location = New System.Drawing.Point(455, 347)
        Me.ButtonModifInfCand.Name = "ButtonModifInfCand"
        Me.ButtonModifInfCand.Size = New System.Drawing.Size(182, 67)
        Me.ButtonModifInfCand.TabIndex = 0
        Me.ButtonModifInfCand.Text = "Modifier"
        Me.ButtonModifInfCand.UseVisualStyleBackColor = True
        '
        'ComboBoxCandidatsInscrit
        '
        Me.ComboBoxCandidatsInscrit.FormattingEnabled = True
        Me.ComboBoxCandidatsInscrit.Location = New System.Drawing.Point(292, 146)
        Me.ComboBoxCandidatsInscrit.Name = "ComboBoxCandidatsInscrit"
        Me.ComboBoxCandidatsInscrit.Size = New System.Drawing.Size(220, 24)
        Me.ComboBoxCandidatsInscrit.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ou"
        '
        'TextBoxModifC
        '
        Me.TextBoxModifC.Location = New System.Drawing.Point(292, 271)
        Me.TextBoxModifC.Name = "TextBoxModifC"
        Me.TextBoxModifC.Size = New System.Drawing.Size(228, 22)
        Me.TextBoxModifC.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(389, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Midifier un candidat parmis la liste de candidats déja inscrits:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Modifier avec numéro candidat:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(122, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(188, 67)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Revenir à l'accueil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-57, -67)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(876, 596)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(350, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(82, 73)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'FormModif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 463)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxModifC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxCandidatsInscrit)
        Me.Controls.Add(Me.ButtonModifInfCand)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormModif"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormModif"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonModifInfCand As Button
    Friend WithEvents ComboBoxCandidatsInscrit As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxModifC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
