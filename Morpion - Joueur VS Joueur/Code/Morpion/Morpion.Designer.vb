<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Morpion
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
        Me.TextCase1 = New System.Windows.Forms.TextBox()
        Me.TextCase2 = New System.Windows.Forms.TextBox()
        Me.TextCase3 = New System.Windows.Forms.TextBox()
        Me.TextCase4 = New System.Windows.Forms.TextBox()
        Me.TextCase5 = New System.Windows.Forms.TextBox()
        Me.TextCase6 = New System.Windows.Forms.TextBox()
        Me.TextCase9 = New System.Windows.Forms.TextBox()
        Me.TextCase8 = New System.Windows.Forms.TextBox()
        Me.TextCase7 = New System.Windows.Forms.TextBox()
        Me.cmdQuit = New System.Windows.Forms.Button()
        Me.cmdAgain = New System.Windows.Forms.Button()
        Me.TextJoueurO = New System.Windows.Forms.TextBox()
        Me.TextJoueurX = New System.Windows.Forms.TextBox()
        Me.LabelJoueurX = New System.Windows.Forms.Label()
        Me.LabelJoueurO = New System.Windows.Forms.Label()
        Me.cmdScoreReset = New System.Windows.Forms.Button()
        Me.cmdRestart = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextCase1
        '
        Me.TextCase1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.TextCase1.Location = New System.Drawing.Point(127, 22)
        Me.TextCase1.Multiline = True
        Me.TextCase1.Name = "TextCase1"
        Me.TextCase1.ReadOnly = True
        Me.TextCase1.Size = New System.Drawing.Size(69, 65)
        Me.TextCase1.TabIndex = 1
        Me.TextCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase2
        '
        Me.TextCase2.Location = New System.Drawing.Point(202, 22)
        Me.TextCase2.Multiline = True
        Me.TextCase2.Name = "TextCase2"
        Me.TextCase2.ReadOnly = True
        Me.TextCase2.Size = New System.Drawing.Size(69, 65)
        Me.TextCase2.TabIndex = 2
        Me.TextCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase3
        '
        Me.TextCase3.Location = New System.Drawing.Point(277, 22)
        Me.TextCase3.Multiline = True
        Me.TextCase3.Name = "TextCase3"
        Me.TextCase3.ReadOnly = True
        Me.TextCase3.Size = New System.Drawing.Size(69, 65)
        Me.TextCase3.TabIndex = 3
        Me.TextCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase4
        '
        Me.TextCase4.Location = New System.Drawing.Point(127, 93)
        Me.TextCase4.Multiline = True
        Me.TextCase4.Name = "TextCase4"
        Me.TextCase4.ReadOnly = True
        Me.TextCase4.Size = New System.Drawing.Size(69, 65)
        Me.TextCase4.TabIndex = 4
        Me.TextCase4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase5
        '
        Me.TextCase5.Location = New System.Drawing.Point(202, 93)
        Me.TextCase5.Multiline = True
        Me.TextCase5.Name = "TextCase5"
        Me.TextCase5.ReadOnly = True
        Me.TextCase5.Size = New System.Drawing.Size(69, 65)
        Me.TextCase5.TabIndex = 5
        Me.TextCase5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase6
        '
        Me.TextCase6.Location = New System.Drawing.Point(277, 93)
        Me.TextCase6.Multiline = True
        Me.TextCase6.Name = "TextCase6"
        Me.TextCase6.ReadOnly = True
        Me.TextCase6.Size = New System.Drawing.Size(69, 65)
        Me.TextCase6.TabIndex = 6
        Me.TextCase6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase9
        '
        Me.TextCase9.BackColor = System.Drawing.SystemColors.Control
        Me.TextCase9.ForeColor = System.Drawing.SystemColors.Control
        Me.TextCase9.Location = New System.Drawing.Point(277, 164)
        Me.TextCase9.Multiline = True
        Me.TextCase9.Name = "TextCase9"
        Me.TextCase9.ReadOnly = True
        Me.TextCase9.Size = New System.Drawing.Size(69, 65)
        Me.TextCase9.TabIndex = 7
        Me.TextCase9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase8
        '
        Me.TextCase8.Location = New System.Drawing.Point(202, 164)
        Me.TextCase8.Multiline = True
        Me.TextCase8.Name = "TextCase8"
        Me.TextCase8.ReadOnly = True
        Me.TextCase8.Size = New System.Drawing.Size(69, 65)
        Me.TextCase8.TabIndex = 8
        Me.TextCase8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase7
        '
        Me.TextCase7.Location = New System.Drawing.Point(127, 164)
        Me.TextCase7.Multiline = True
        Me.TextCase7.Name = "TextCase7"
        Me.TextCase7.ReadOnly = True
        Me.TextCase7.Size = New System.Drawing.Size(69, 65)
        Me.TextCase7.TabIndex = 9
        Me.TextCase7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdQuit
        '
        Me.cmdQuit.AccessibleName = ""
        Me.cmdQuit.Location = New System.Drawing.Point(461, 288)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(131, 59)
        Me.cmdQuit.TabIndex = 10
        Me.cmdQuit.Text = "Quitter"
        Me.cmdQuit.UseVisualStyleBackColor = True
        '
        'cmdAgain
        '
        Me.cmdAgain.Location = New System.Drawing.Point(50, 288)
        Me.cmdAgain.Name = "cmdAgain"
        Me.cmdAgain.Size = New System.Drawing.Size(131, 59)
        Me.cmdAgain.TabIndex = 11
        Me.cmdAgain.Text = "Nouvelle manche"
        Me.cmdAgain.UseVisualStyleBackColor = True
        '
        'TextJoueurO
        '
        Me.TextJoueurO.Enabled = False
        Me.TextJoueurO.Location = New System.Drawing.Point(511, 176)
        Me.TextJoueurO.Name = "TextJoueurO"
        Me.TextJoueurO.Size = New System.Drawing.Size(112, 20)
        Me.TextJoueurO.TabIndex = 12
        Me.TextJoueurO.Text = "0"
        Me.TextJoueurO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextJoueurX
        '
        Me.TextJoueurX.Enabled = False
        Me.TextJoueurX.Location = New System.Drawing.Point(511, 78)
        Me.TextJoueurX.Name = "TextJoueurX"
        Me.TextJoueurX.Size = New System.Drawing.Size(112, 20)
        Me.TextJoueurX.TabIndex = 13
        Me.TextJoueurX.Text = "0"
        Me.TextJoueurX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelJoueurX
        '
        Me.LabelJoueurX.AutoSize = True
        Me.LabelJoueurX.Location = New System.Drawing.Point(534, 62)
        Me.LabelJoueurX.Name = "LabelJoueurX"
        Me.LabelJoueurX.Size = New System.Drawing.Size(10, 13)
        Me.LabelJoueurX.TabIndex = 14
        Me.LabelJoueurX.Text = "!"
        '
        'LabelJoueurO
        '
        Me.LabelJoueurO.AutoSize = True
        Me.LabelJoueurO.Location = New System.Drawing.Point(534, 160)
        Me.LabelJoueurO.Name = "LabelJoueurO"
        Me.LabelJoueurO.Size = New System.Drawing.Size(10, 13)
        Me.LabelJoueurO.TabIndex = 15
        Me.LabelJoueurO.Text = "!"
        '
        'cmdScoreReset
        '
        Me.cmdScoreReset.Location = New System.Drawing.Point(187, 288)
        Me.cmdScoreReset.Name = "cmdScoreReset"
        Me.cmdScoreReset.Size = New System.Drawing.Size(131, 59)
        Me.cmdScoreReset.TabIndex = 16
        Me.cmdScoreReset.Text = "Remise à zéro"
        Me.cmdScoreReset.UseVisualStyleBackColor = True
        '
        'cmdRestart
        '
        Me.cmdRestart.AccessibleName = ""
        Me.cmdRestart.Location = New System.Drawing.Point(324, 288)
        Me.cmdRestart.Name = "cmdRestart"
        Me.cmdRestart.Size = New System.Drawing.Size(131, 59)
        Me.cmdRestart.TabIndex = 17
        Me.cmdRestart.Text = "Redémarrer"
        Me.cmdRestart.UseVisualStyleBackColor = True
        '
        'Morpion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(659, 359)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdRestart)
        Me.Controls.Add(Me.cmdScoreReset)
        Me.Controls.Add(Me.LabelJoueurO)
        Me.Controls.Add(Me.LabelJoueurX)
        Me.Controls.Add(Me.TextJoueurX)
        Me.Controls.Add(Me.TextJoueurO)
        Me.Controls.Add(Me.cmdAgain)
        Me.Controls.Add(Me.cmdQuit)
        Me.Controls.Add(Me.TextCase7)
        Me.Controls.Add(Me.TextCase8)
        Me.Controls.Add(Me.TextCase9)
        Me.Controls.Add(Me.TextCase6)
        Me.Controls.Add(Me.TextCase5)
        Me.Controls.Add(Me.TextCase4)
        Me.Controls.Add(Me.TextCase3)
        Me.Controls.Add(Me.TextCase2)
        Me.Controls.Add(Me.TextCase1)
        Me.Name = "Morpion"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Morpion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextCase1 As TextBox
    Friend WithEvents TextCase2 As TextBox
    Friend WithEvents TextCase3 As TextBox
    Friend WithEvents TextCase4 As TextBox
    Friend WithEvents TextCase5 As TextBox
    Friend WithEvents TextCase6 As TextBox
    Friend WithEvents TextCase9 As TextBox
    Friend WithEvents TextCase8 As TextBox
    Friend WithEvents TextCase7 As TextBox
    Friend WithEvents cmdQuit As Button
    Friend WithEvents cmdAgain As Button
    Friend WithEvents TextJoueurO As TextBox
    Friend WithEvents TextJoueurX As TextBox
    Friend WithEvents LabelJoueurX As Label
    Friend WithEvents LabelJoueurO As Label
    Friend WithEvents cmdScoreReset As Button
    Friend WithEvents cmdRestart As Button
End Class
