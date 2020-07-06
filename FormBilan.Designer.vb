<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBilan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBilan))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNbIns = New System.Windows.Forms.Label()
        Me.ButtonBI = New System.Windows.Forms.Button()
        Me.ButtonBM = New System.Windows.Forms.Button()
        Me.ComboBoxNPC = New System.Windows.Forms.ComboBox()
        Me.ComboBoxM = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(237, 43)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Revenir à l'accueil"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre d’inscriptions enregistrées : "
        '
        'LabelNbIns
        '
        Me.LabelNbIns.AutoSize = True
        Me.LabelNbIns.Location = New System.Drawing.Point(535, 68)
        Me.LabelNbIns.Name = "LabelNbIns"
        Me.LabelNbIns.Size = New System.Drawing.Size(0, 17)
        Me.LabelNbIns.TabIndex = 2
        '
        'ButtonBI
        '
        Me.ButtonBI.Location = New System.Drawing.Point(66, 220)
        Me.ButtonBI.Name = "ButtonBI"
        Me.ButtonBI.Size = New System.Drawing.Size(248, 45)
        Me.ButtonBI.TabIndex = 3
        Me.ButtonBI.Text = "Bilan individuel d’une candidature"
        Me.ButtonBI.UseVisualStyleBackColor = True
        '
        'ButtonBM
        '
        Me.ButtonBM.Location = New System.Drawing.Point(540, 220)
        Me.ButtonBM.Name = "ButtonBM"
        Me.ButtonBM.Size = New System.Drawing.Size(162, 45)
        Me.ButtonBM.TabIndex = 3
        Me.ButtonBM.Text = "Bilan des inscriptions dans une matière"
        Me.ButtonBM.UseVisualStyleBackColor = True
        '
        'ComboBoxNPC
        '
        Me.ComboBoxNPC.FormattingEnabled = True
        Me.ComboBoxNPC.Location = New System.Drawing.Point(66, 189)
        Me.ComboBoxNPC.Name = "ComboBoxNPC"
        Me.ComboBoxNPC.Size = New System.Drawing.Size(247, 24)
        Me.ComboBoxNPC.Sorted = True
        Me.ComboBoxNPC.TabIndex = 4
        '
        'ComboBoxM
        '
        Me.ComboBoxM.FormattingEnabled = True
        Me.ComboBoxM.Location = New System.Drawing.Point(540, 189)
        Me.ComboBoxM.Name = "ComboBoxM"
        Me.ComboBoxM.Size = New System.Drawing.Size(160, 24)
        Me.ComboBoxM.Sorted = True
        Me.ComboBoxM.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bilan individuel des candidats inscrits :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(537, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Bilan par matière :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-140, -64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1004, 534)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FormBilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 413)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBoxM)
        Me.Controls.Add(Me.ComboBoxNPC)
        Me.Controls.Add(Me.ButtonBM)
        Me.Controls.Add(Me.ButtonBI)
        Me.Controls.Add(Me.LabelNbIns)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FormBilan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBilan"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNbIns As Label
    Friend WithEvents ButtonBI As Button
    Friend WithEvents ButtonBM As Button
    Friend WithEvents ComboBoxNPC As ComboBox
    Friend WithEvents ComboBoxM As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
