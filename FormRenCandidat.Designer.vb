<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRensCandidat
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRensCandidat))
        Me.monTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimerClose = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxNomC = New System.Windows.Forms.TextBox()
        Me.TextBoxPrenomC = New System.Windows.Forms.TextBox()
        Me.TextBoxAdresseC = New System.Windows.Forms.TextBox()
        Me.TextBoxCpC = New System.Windows.Forms.TextBox()
        Me.TextBoxVilleC = New System.Windows.Forms.TextBox()
        Me.ScrollBarAge = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelAge = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonQuit = New System.Windows.Forms.Button()
        Me.ButtonPassageCM = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'monTimer
        '
        '
        'TimerClose
        '
        Me.TimerClose.Enabled = True
        Me.TimerClose.Interval = 60000
        '
        'TextBoxNomC
        '
        Me.TextBoxNomC.Location = New System.Drawing.Point(249, 85)
        Me.TextBoxNomC.MaxLength = 15
        Me.TextBoxNomC.Name = "TextBoxNomC"
        Me.TextBoxNomC.Size = New System.Drawing.Size(116, 22)
        Me.TextBoxNomC.TabIndex = 1
        '
        'TextBoxPrenomC
        '
        Me.TextBoxPrenomC.Location = New System.Drawing.Point(249, 132)
        Me.TextBoxPrenomC.MaxLength = 20
        Me.TextBoxPrenomC.Name = "TextBoxPrenomC"
        Me.TextBoxPrenomC.Size = New System.Drawing.Size(116, 22)
        Me.TextBoxPrenomC.TabIndex = 2
        '
        'TextBoxAdresseC
        '
        Me.TextBoxAdresseC.Location = New System.Drawing.Point(249, 189)
        Me.TextBoxAdresseC.MaxLength = 30
        Me.TextBoxAdresseC.Name = "TextBoxAdresseC"
        Me.TextBoxAdresseC.Size = New System.Drawing.Size(267, 22)
        Me.TextBoxAdresseC.TabIndex = 3
        '
        'TextBoxCpC
        '
        Me.TextBoxCpC.Location = New System.Drawing.Point(249, 249)
        Me.TextBoxCpC.MaxLength = 5
        Me.TextBoxCpC.Name = "TextBoxCpC"
        Me.TextBoxCpC.Size = New System.Drawing.Size(116, 22)
        Me.TextBoxCpC.TabIndex = 4
        '
        'TextBoxVilleC
        '
        Me.TextBoxVilleC.Location = New System.Drawing.Point(249, 310)
        Me.TextBoxVilleC.MaxLength = 15
        Me.TextBoxVilleC.Name = "TextBoxVilleC"
        Me.TextBoxVilleC.Size = New System.Drawing.Size(116, 22)
        Me.TextBoxVilleC.TabIndex = 5
        '
        'ScrollBarAge
        '
        Me.ScrollBarAge.Location = New System.Drawing.Point(288, 356)
        Me.ScrollBarAge.Name = "ScrollBarAge"
        Me.ScrollBarAge.Size = New System.Drawing.Size(303, 22)
        Me.ScrollBarAge.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Prénom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Adresse"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Code Postal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(158, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ville"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(158, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Age"
        '
        'LabelAge
        '
        Me.LabelAge.AutoSize = True
        Me.LabelAge.Location = New System.Drawing.Point(246, 356)
        Me.LabelAge.Name = "LabelAge"
        Me.LabelAge.Size = New System.Drawing.Size(0, 17)
        Me.LabelAge.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(192, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Renseignements du candidat"
        '
        'ButtonQuit
        '
        Me.ButtonQuit.Location = New System.Drawing.Point(99, 428)
        Me.ButtonQuit.Name = "ButtonQuit"
        Me.ButtonQuit.Size = New System.Drawing.Size(230, 47)
        Me.ButtonQuit.TabIndex = 6
        Me.ButtonQuit.Text = "Abondoner"
        Me.ButtonQuit.UseVisualStyleBackColor = True
        '
        'ButtonPassageCM
        '
        Me.ButtonPassageCM.Location = New System.Drawing.Point(379, 428)
        Me.ButtonPassageCM.Name = "ButtonPassageCM"
        Me.ButtonPassageCM.Size = New System.Drawing.Size(228, 47)
        Me.ButtonPassageCM.TabIndex = 7
        Me.ButtonPassageCM.Text = "Passer aux choix des matières"
        Me.ButtonPassageCM.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-14, -23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(752, 562)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(568, 51)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 112)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'FormRensCandidat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 518)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ButtonPassageCM)
        Me.Controls.Add(Me.ButtonQuit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelAge)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ScrollBarAge)
        Me.Controls.Add(Me.TextBoxVilleC)
        Me.Controls.Add(Me.TextBoxCpC)
        Me.Controls.Add(Me.TextBoxAdresseC)
        Me.Controls.Add(Me.TextBoxPrenomC)
        Me.Controls.Add(Me.TextBoxNomC)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormRensCandidat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents monTimer As Timer
    Friend WithEvents TimerClose As Timer
    Friend WithEvents TextBoxNomC As TextBox
    Friend WithEvents TextBoxPrenomC As TextBox
    Friend WithEvents TextBoxAdresseC As TextBox
    Friend WithEvents TextBoxCpC As TextBox
    Friend WithEvents TextBoxVilleC As TextBox
    Friend WithEvents ScrollBarAge As HScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelAge As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ButtonQuit As Button
    Friend WithEvents ButtonPassageCM As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
