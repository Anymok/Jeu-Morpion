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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Morpion))
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
        Me.Timer_Ordinateur = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GIFbaby = New System.Windows.Forms.PictureBox()
        Me.GIFartifice = New System.Windows.Forms.PictureBox()
        Me.GIFlicorne = New System.Windows.Forms.PictureBox()
        Me.GIFconfetti = New System.Windows.Forms.PictureBox()
        Me.GIFlicorne1 = New System.Windows.Forms.PictureBox()
        Me.GIFlicorne2 = New System.Windows.Forms.PictureBox()
        Me.GIFlicorne3 = New System.Windows.Forms.PictureBox()
        Me.GIFlicorne4 = New System.Windows.Forms.PictureBox()
        Me.cmdBack = New System.Windows.Forms.Button()
        Me.GIFfootball = New System.Windows.Forms.PictureBox()
        Me.GIFapple = New System.Windows.Forms.PictureBox()
        Me.GIFducoup = New System.Windows.Forms.PictureBox()
        Me.GIFducoup2 = New System.Windows.Forms.PictureBox()
        Me.GIFgameover = New System.Windows.Forms.PictureBox()
        Me.cmdContinue = New System.Windows.Forms.Button()
        Me.cmdtroll = New System.Windows.Forms.Button()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.cmdOption = New System.Windows.Forms.Button()
        Me.cmdBackOption = New System.Windows.Forms.Button()
        Me.Checkeffectvictoire = New System.Windows.Forms.CheckBox()
        Me.Checkeffectdefaite = New System.Windows.Forms.CheckBox()
        Me.Cadre = New System.Windows.Forms.Label()
        Me.Cadre2 = New System.Windows.Forms.Label()
        CType(Me.GIFbaby, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIFartifice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIFlicorne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIFconfetti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIFlicorne1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIFlicorne2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIFlicorne3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIFlicorne4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIFfootball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIFapple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIFducoup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIFducoup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GIFgameover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextCase1
        '
        Me.TextCase1.BackColor = System.Drawing.SystemColors.Control
        Me.TextCase1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextCase1.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.TextCase1.ForeColor = System.Drawing.Color.Black
        Me.TextCase1.Location = New System.Drawing.Point(187, 75)
        Me.TextCase1.Multiline = True
        Me.TextCase1.Name = "TextCase1"
        Me.TextCase1.ReadOnly = True
        Me.TextCase1.Size = New System.Drawing.Size(69, 65)
        Me.TextCase1.TabIndex = 1
        Me.TextCase1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase2
        '
        Me.TextCase2.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.TextCase2.Location = New System.Drawing.Point(262, 75)
        Me.TextCase2.Multiline = True
        Me.TextCase2.Name = "TextCase2"
        Me.TextCase2.ReadOnly = True
        Me.TextCase2.Size = New System.Drawing.Size(69, 65)
        Me.TextCase2.TabIndex = 2
        Me.TextCase2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase3
        '
        Me.TextCase3.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.TextCase3.Location = New System.Drawing.Point(337, 75)
        Me.TextCase3.Multiline = True
        Me.TextCase3.Name = "TextCase3"
        Me.TextCase3.ReadOnly = True
        Me.TextCase3.Size = New System.Drawing.Size(69, 65)
        Me.TextCase3.TabIndex = 3
        Me.TextCase3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase4
        '
        Me.TextCase4.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.TextCase4.Location = New System.Drawing.Point(187, 146)
        Me.TextCase4.Multiline = True
        Me.TextCase4.Name = "TextCase4"
        Me.TextCase4.ReadOnly = True
        Me.TextCase4.Size = New System.Drawing.Size(69, 65)
        Me.TextCase4.TabIndex = 4
        Me.TextCase4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase5
        '
        Me.TextCase5.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.TextCase5.Location = New System.Drawing.Point(262, 146)
        Me.TextCase5.Multiline = True
        Me.TextCase5.Name = "TextCase5"
        Me.TextCase5.ReadOnly = True
        Me.TextCase5.Size = New System.Drawing.Size(69, 65)
        Me.TextCase5.TabIndex = 5
        Me.TextCase5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase6
        '
        Me.TextCase6.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.TextCase6.Location = New System.Drawing.Point(337, 146)
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
        Me.TextCase9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextCase9.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.TextCase9.ForeColor = System.Drawing.SystemColors.Control
        Me.TextCase9.Location = New System.Drawing.Point(337, 217)
        Me.TextCase9.Multiline = True
        Me.TextCase9.Name = "TextCase9"
        Me.TextCase9.ReadOnly = True
        Me.TextCase9.Size = New System.Drawing.Size(69, 65)
        Me.TextCase9.TabIndex = 7
        Me.TextCase9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase8
        '
        Me.TextCase8.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.TextCase8.Location = New System.Drawing.Point(262, 217)
        Me.TextCase8.Multiline = True
        Me.TextCase8.Name = "TextCase8"
        Me.TextCase8.ReadOnly = True
        Me.TextCase8.Size = New System.Drawing.Size(69, 65)
        Me.TextCase8.TabIndex = 8
        Me.TextCase8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextCase7
        '
        Me.TextCase7.Font = New System.Drawing.Font("Comic Sans MS", 30.0!)
        Me.TextCase7.Location = New System.Drawing.Point(187, 217)
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
        Me.cmdQuit.BackColor = System.Drawing.Color.White
        Me.cmdQuit.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmdQuit.Location = New System.Drawing.Point(823, 366)
        Me.cmdQuit.Name = "cmdQuit"
        Me.cmdQuit.Size = New System.Drawing.Size(131, 59)
        Me.cmdQuit.TabIndex = 10
        Me.cmdQuit.Text = "Quitter"
        Me.cmdQuit.UseVisualStyleBackColor = False
        '
        'cmdAgain
        '
        Me.cmdAgain.Location = New System.Drawing.Point(226, 366)
        Me.cmdAgain.Name = "cmdAgain"
        Me.cmdAgain.Size = New System.Drawing.Size(131, 59)
        Me.cmdAgain.TabIndex = 11
        Me.cmdAgain.Text = "Nouvelle manche"
        Me.cmdAgain.UseVisualStyleBackColor = True
        '
        'TextJoueurO
        '
        Me.TextJoueurO.Enabled = False
        Me.TextJoueurO.Location = New System.Drawing.Point(704, 218)
        Me.TextJoueurO.Name = "TextJoueurO"
        Me.TextJoueurO.Size = New System.Drawing.Size(112, 20)
        Me.TextJoueurO.TabIndex = 12
        Me.TextJoueurO.Text = "0"
        Me.TextJoueurO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextJoueurX
        '
        Me.TextJoueurX.Enabled = False
        Me.TextJoueurX.Location = New System.Drawing.Point(704, 120)
        Me.TextJoueurX.Name = "TextJoueurX"
        Me.TextJoueurX.Size = New System.Drawing.Size(112, 20)
        Me.TextJoueurX.TabIndex = 13
        Me.TextJoueurX.Text = "0"
        Me.TextJoueurX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelJoueurX
        '
        Me.LabelJoueurX.AutoSize = True
        Me.LabelJoueurX.BackColor = System.Drawing.Color.Transparent
        Me.LabelJoueurX.ForeColor = System.Drawing.Color.White
        Me.LabelJoueurX.Location = New System.Drawing.Point(731, 104)
        Me.LabelJoueurX.Name = "LabelJoueurX"
        Me.LabelJoueurX.Size = New System.Drawing.Size(10, 13)
        Me.LabelJoueurX.TabIndex = 14
        Me.LabelJoueurX.Text = "!"
        '
        'LabelJoueurO
        '
        Me.LabelJoueurO.AutoSize = True
        Me.LabelJoueurO.BackColor = System.Drawing.Color.Transparent
        Me.LabelJoueurO.ForeColor = System.Drawing.Color.White
        Me.LabelJoueurO.Location = New System.Drawing.Point(731, 202)
        Me.LabelJoueurO.Name = "LabelJoueurO"
        Me.LabelJoueurO.Size = New System.Drawing.Size(10, 13)
        Me.LabelJoueurO.TabIndex = 15
        Me.LabelJoueurO.Text = "!"
        '
        'cmdScoreReset
        '
        Me.cmdScoreReset.Location = New System.Drawing.Point(12, 141)
        Me.cmdScoreReset.Name = "cmdScoreReset"
        Me.cmdScoreReset.Size = New System.Drawing.Size(131, 59)
        Me.cmdScoreReset.TabIndex = 16
        Me.cmdScoreReset.Text = "Remise à zéro"
        Me.cmdScoreReset.UseVisualStyleBackColor = True
        Me.cmdScoreReset.Visible = False
        '
        'cmdRestart
        '
        Me.cmdRestart.AccessibleName = ""
        Me.cmdRestart.Location = New System.Drawing.Point(685, 366)
        Me.cmdRestart.Name = "cmdRestart"
        Me.cmdRestart.Size = New System.Drawing.Size(131, 59)
        Me.cmdRestart.TabIndex = 17
        Me.cmdRestart.Text = "Redémarrer"
        Me.cmdRestart.UseVisualStyleBackColor = True
        '
        'Timer_Ordinateur
        '
        Me.Timer_Ordinateur.Interval = 10000
        '
        'GIFbaby
        '
        Me.GIFbaby.BackColor = System.Drawing.Color.Transparent
        Me.GIFbaby.ErrorImage = Nothing
        Me.GIFbaby.Image = CType(resources.GetObject("GIFbaby.Image"), System.Drawing.Image)
        Me.GIFbaby.InitialImage = Nothing
        Me.GIFbaby.Location = New System.Drawing.Point(65, 206)
        Me.GIFbaby.Name = "GIFbaby"
        Me.GIFbaby.Size = New System.Drawing.Size(169, 163)
        Me.GIFbaby.TabIndex = 18
        Me.GIFbaby.TabStop = False
        Me.GIFbaby.Visible = False
        '
        'GIFartifice
        '
        Me.GIFartifice.BackColor = System.Drawing.Color.Transparent
        Me.GIFartifice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GIFartifice.ErrorImage = Nothing
        Me.GIFartifice.Image = CType(resources.GetObject("GIFartifice.Image"), System.Drawing.Image)
        Me.GIFartifice.InitialImage = Nothing
        Me.GIFartifice.Location = New System.Drawing.Point(337, 1)
        Me.GIFartifice.Name = "GIFartifice"
        Me.GIFartifice.Size = New System.Drawing.Size(631, 368)
        Me.GIFartifice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GIFartifice.TabIndex = 19
        Me.GIFartifice.TabStop = False
        Me.GIFartifice.Visible = False
        '
        'GIFlicorne
        '
        Me.GIFlicorne.BackColor = System.Drawing.Color.Transparent
        Me.GIFlicorne.ErrorImage = Nothing
        Me.GIFlicorne.Image = CType(resources.GetObject("GIFlicorne.Image"), System.Drawing.Image)
        Me.GIFlicorne.InitialImage = Nothing
        Me.GIFlicorne.Location = New System.Drawing.Point(839, 366)
        Me.GIFlicorne.Name = "GIFlicorne"
        Me.GIFlicorne.Size = New System.Drawing.Size(129, 75)
        Me.GIFlicorne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GIFlicorne.TabIndex = 20
        Me.GIFlicorne.TabStop = False
        Me.GIFlicorne.Visible = False
        '
        'GIFconfetti
        '
        Me.GIFconfetti.BackColor = System.Drawing.Color.Transparent
        Me.GIFconfetti.ErrorImage = Nothing
        Me.GIFconfetti.Image = CType(resources.GetObject("GIFconfetti.Image"), System.Drawing.Image)
        Me.GIFconfetti.InitialImage = Nothing
        Me.GIFconfetti.Location = New System.Drawing.Point(-10, 1)
        Me.GIFconfetti.Name = "GIFconfetti"
        Me.GIFconfetti.Size = New System.Drawing.Size(341, 210)
        Me.GIFconfetti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GIFconfetti.TabIndex = 21
        Me.GIFconfetti.TabStop = False
        Me.GIFconfetti.Visible = False
        '
        'GIFlicorne1
        '
        Me.GIFlicorne1.BackColor = System.Drawing.Color.Transparent
        Me.GIFlicorne1.ErrorImage = Nothing
        Me.GIFlicorne1.Image = CType(resources.GetObject("GIFlicorne1.Image"), System.Drawing.Image)
        Me.GIFlicorne1.InitialImage = Nothing
        Me.GIFlicorne1.Location = New System.Drawing.Point(704, 366)
        Me.GIFlicorne1.Name = "GIFlicorne1"
        Me.GIFlicorne1.Size = New System.Drawing.Size(129, 75)
        Me.GIFlicorne1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GIFlicorne1.TabIndex = 22
        Me.GIFlicorne1.TabStop = False
        Me.GIFlicorne1.Visible = False
        '
        'GIFlicorne2
        '
        Me.GIFlicorne2.BackColor = System.Drawing.Color.Transparent
        Me.GIFlicorne2.ErrorImage = Nothing
        Me.GIFlicorne2.Image = CType(resources.GetObject("GIFlicorne2.Image"), System.Drawing.Image)
        Me.GIFlicorne2.InitialImage = Nothing
        Me.GIFlicorne2.Location = New System.Drawing.Point(569, 366)
        Me.GIFlicorne2.Name = "GIFlicorne2"
        Me.GIFlicorne2.Size = New System.Drawing.Size(129, 75)
        Me.GIFlicorne2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GIFlicorne2.TabIndex = 23
        Me.GIFlicorne2.TabStop = False
        Me.GIFlicorne2.Visible = False
        '
        'GIFlicorne3
        '
        Me.GIFlicorne3.BackColor = System.Drawing.Color.Transparent
        Me.GIFlicorne3.ErrorImage = Nothing
        Me.GIFlicorne3.Image = CType(resources.GetObject("GIFlicorne3.Image"), System.Drawing.Image)
        Me.GIFlicorne3.InitialImage = Nothing
        Me.GIFlicorne3.Location = New System.Drawing.Point(434, 366)
        Me.GIFlicorne3.Name = "GIFlicorne3"
        Me.GIFlicorne3.Size = New System.Drawing.Size(129, 75)
        Me.GIFlicorne3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GIFlicorne3.TabIndex = 24
        Me.GIFlicorne3.TabStop = False
        Me.GIFlicorne3.Visible = False
        '
        'GIFlicorne4
        '
        Me.GIFlicorne4.BackColor = System.Drawing.Color.Transparent
        Me.GIFlicorne4.ErrorImage = Nothing
        Me.GIFlicorne4.Image = CType(resources.GetObject("GIFlicorne4.Image"), System.Drawing.Image)
        Me.GIFlicorne4.InitialImage = Nothing
        Me.GIFlicorne4.Location = New System.Drawing.Point(299, 366)
        Me.GIFlicorne4.Name = "GIFlicorne4"
        Me.GIFlicorne4.Size = New System.Drawing.Size(129, 75)
        Me.GIFlicorne4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GIFlicorne4.TabIndex = 25
        Me.GIFlicorne4.TabStop = False
        Me.GIFlicorne4.Visible = False
        '
        'cmdBack
        '
        Me.cmdBack.AccessibleName = ""
        Me.cmdBack.BackColor = System.Drawing.Color.White
        Me.cmdBack.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmdBack.Location = New System.Drawing.Point(103, 366)
        Me.cmdBack.Name = "cmdBack"
        Me.cmdBack.Size = New System.Drawing.Size(131, 59)
        Me.cmdBack.TabIndex = 26
        Me.cmdBack.Text = "Retour"
        Me.cmdBack.UseVisualStyleBackColor = False
        Me.cmdBack.Visible = False
        '
        'GIFfootball
        '
        Me.GIFfootball.BackColor = System.Drawing.Color.Transparent
        Me.GIFfootball.ErrorImage = Nothing
        Me.GIFfootball.Image = CType(resources.GetObject("GIFfootball.Image"), System.Drawing.Image)
        Me.GIFfootball.InitialImage = Nothing
        Me.GIFfootball.Location = New System.Drawing.Point(744, 1)
        Me.GIFfootball.Name = "GIFfootball"
        Me.GIFfootball.Size = New System.Drawing.Size(224, 222)
        Me.GIFfootball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GIFfootball.TabIndex = 28
        Me.GIFfootball.TabStop = False
        Me.GIFfootball.Visible = False
        '
        'GIFapple
        '
        Me.GIFapple.BackColor = System.Drawing.Color.Transparent
        Me.GIFapple.ErrorImage = Nothing
        Me.GIFapple.Image = CType(resources.GetObject("GIFapple.Image"), System.Drawing.Image)
        Me.GIFapple.InitialImage = Nothing
        Me.GIFapple.Location = New System.Drawing.Point(-6, 184)
        Me.GIFapple.Name = "GIFapple"
        Me.GIFapple.Size = New System.Drawing.Size(256, 231)
        Me.GIFapple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GIFapple.TabIndex = 29
        Me.GIFapple.TabStop = False
        Me.GIFapple.Visible = False
        '
        'GIFducoup
        '
        Me.GIFducoup.BackColor = System.Drawing.Color.Transparent
        Me.GIFducoup.ErrorImage = Nothing
        Me.GIFducoup.Image = CType(resources.GetObject("GIFducoup.Image"), System.Drawing.Image)
        Me.GIFducoup.InitialImage = Nothing
        Me.GIFducoup.Location = New System.Drawing.Point(744, 225)
        Me.GIFducoup.Name = "GIFducoup"
        Me.GIFducoup.Size = New System.Drawing.Size(224, 223)
        Me.GIFducoup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GIFducoup.TabIndex = 30
        Me.GIFducoup.TabStop = False
        Me.GIFducoup.Visible = False
        '
        'GIFducoup2
        '
        Me.GIFducoup2.BackColor = System.Drawing.Color.Transparent
        Me.GIFducoup2.ErrorImage = Nothing
        Me.GIFducoup2.Image = CType(resources.GetObject("GIFducoup2.Image"), System.Drawing.Image)
        Me.GIFducoup2.InitialImage = Nothing
        Me.GIFducoup2.Location = New System.Drawing.Point(482, 210)
        Me.GIFducoup2.Name = "GIFducoup2"
        Me.GIFducoup2.Size = New System.Drawing.Size(256, 231)
        Me.GIFducoup2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GIFducoup2.TabIndex = 31
        Me.GIFducoup2.TabStop = False
        Me.GIFducoup2.Visible = False
        '
        'GIFgameover
        '
        Me.GIFgameover.BackColor = System.Drawing.Color.Transparent
        Me.GIFgameover.ErrorImage = Nothing
        Me.GIFgameover.Image = CType(resources.GetObject("GIFgameover.Image"), System.Drawing.Image)
        Me.GIFgameover.InitialImage = Nothing
        Me.GIFgameover.Location = New System.Drawing.Point(315, 173)
        Me.GIFgameover.Name = "GIFgameover"
        Me.GIFgameover.Size = New System.Drawing.Size(137, 50)
        Me.GIFgameover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.GIFgameover.TabIndex = 32
        Me.GIFgameover.TabStop = False
        Me.GIFgameover.Visible = False
        '
        'cmdContinue
        '
        Me.cmdContinue.Location = New System.Drawing.Point(315, 242)
        Me.cmdContinue.Name = "cmdContinue"
        Me.cmdContinue.Size = New System.Drawing.Size(122, 33)
        Me.cmdContinue.TabIndex = 33
        Me.cmdContinue.Text = "Continuer"
        Me.cmdContinue.UseVisualStyleBackColor = True
        Me.cmdContinue.Visible = False
        '
        'cmdtroll
        '
        Me.cmdtroll.Location = New System.Drawing.Point(315, 288)
        Me.cmdtroll.Name = "cmdtroll"
        Me.cmdtroll.Size = New System.Drawing.Size(122, 33)
        Me.cmdtroll.TabIndex = 34
        Me.cmdtroll.Text = "Quitter"
        Me.cmdtroll.UseVisualStyleBackColor = True
        Me.cmdtroll.Visible = False
        '
        'Background
        '
        Me.Background.ErrorImage = Nothing
        Me.Background.Image = CType(resources.GetObject("Background.Image"), System.Drawing.Image)
        Me.Background.InitialImage = Nothing
        Me.Background.Location = New System.Drawing.Point(-6, 1)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(974, 440)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Background.TabIndex = 35
        Me.Background.TabStop = False
        '
        'cmdOption
        '
        Me.cmdOption.AccessibleName = ""
        Me.cmdOption.BackColor = System.Drawing.Color.White
        Me.cmdOption.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmdOption.Location = New System.Drawing.Point(548, 366)
        Me.cmdOption.Name = "cmdOption"
        Me.cmdOption.Size = New System.Drawing.Size(131, 59)
        Me.cmdOption.TabIndex = 36
        Me.cmdOption.Text = "Option"
        Me.cmdOption.UseVisualStyleBackColor = False
        '
        'cmdBackOption
        '
        Me.cmdBackOption.AccessibleName = ""
        Me.cmdBackOption.BackColor = System.Drawing.Color.White
        Me.cmdBackOption.ForeColor = System.Drawing.SystemColors.MenuText
        Me.cmdBackOption.Location = New System.Drawing.Point(12, 12)
        Me.cmdBackOption.Name = "cmdBackOption"
        Me.cmdBackOption.Size = New System.Drawing.Size(131, 59)
        Me.cmdBackOption.TabIndex = 37
        Me.cmdBackOption.Text = "Retour"
        Me.cmdBackOption.UseVisualStyleBackColor = False
        Me.cmdBackOption.Visible = False
        '
        'Checkeffectvictoire
        '
        Me.Checkeffectvictoire.AutoSize = True
        Me.Checkeffectvictoire.Checked = True
        Me.Checkeffectvictoire.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Checkeffectvictoire.Location = New System.Drawing.Point(869, 34)
        Me.Checkeffectvictoire.Name = "Checkeffectvictoire"
        Me.Checkeffectvictoire.Size = New System.Drawing.Size(85, 17)
        Me.Checkeffectvictoire.TabIndex = 38
        Me.Checkeffectvictoire.Text = "Effet victoire"
        Me.Checkeffectvictoire.UseVisualStyleBackColor = True
        Me.Checkeffectvictoire.Visible = False
        '
        'Checkeffectdefaite
        '
        Me.Checkeffectdefaite.AutoSize = True
        Me.Checkeffectdefaite.Checked = True
        Me.Checkeffectdefaite.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Checkeffectdefaite.Location = New System.Drawing.Point(871, 75)
        Me.Checkeffectdefaite.Name = "Checkeffectdefaite"
        Me.Checkeffectdefaite.Size = New System.Drawing.Size(83, 17)
        Me.Checkeffectdefaite.TabIndex = 39
        Me.Checkeffectdefaite.Text = "Effet défaite"
        Me.Checkeffectdefaite.UseVisualStyleBackColor = True
        Me.Checkeffectdefaite.Visible = False
        '
        'Cadre
        '
        Me.Cadre.AutoSize = True
        Me.Cadre.BackColor = System.Drawing.Color.Transparent
        Me.Cadre.ForeColor = System.Drawing.Color.White
        Me.Cadre.Location = New System.Drawing.Point(968, 428)
        Me.Cadre.Name = "Cadre"
        Me.Cadre.Size = New System.Drawing.Size(0, 13)
        Me.Cadre.TabIndex = 40
        '
        'Cadre2
        '
        Me.Cadre2.AutoSize = True
        Me.Cadre2.BackColor = System.Drawing.Color.Transparent
        Me.Cadre2.ForeColor = System.Drawing.Color.White
        Me.Cadre2.Location = New System.Drawing.Point(6, 1)
        Me.Cadre2.Name = "Cadre2"
        Me.Cadre2.Size = New System.Drawing.Size(0, 16)
        Me.Cadre2.TabIndex = 41
        Me.Cadre2.UseCompatibleTextRendering = True
        '
        'Morpion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(966, 437)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cadre2)
        Me.Controls.Add(Me.Cadre)
        Me.Controls.Add(Me.cmdOption)
        Me.Controls.Add(Me.cmdRestart)
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
        Me.Controls.Add(Me.Background)
        Me.Controls.Add(Me.GIFbaby)
        Me.Controls.Add(Me.GIFapple)
        Me.Controls.Add(Me.GIFconfetti)
        Me.Controls.Add(Me.GIFartifice)
        Me.Controls.Add(Me.GIFfootball)
        Me.Controls.Add(Me.GIFducoup)
        Me.Controls.Add(Me.GIFlicorne1)
        Me.Controls.Add(Me.GIFlicorne)
        Me.Controls.Add(Me.GIFducoup2)
        Me.Controls.Add(Me.GIFgameover)
        Me.Controls.Add(Me.cmdContinue)
        Me.Controls.Add(Me.GIFlicorne4)
        Me.Controls.Add(Me.GIFlicorne3)
        Me.Controls.Add(Me.GIFlicorne2)
        Me.Controls.Add(Me.cmdtroll)
        Me.Controls.Add(Me.cmdBackOption)
        Me.Controls.Add(Me.cmdBack)
        Me.Controls.Add(Me.cmdScoreReset)
        Me.Controls.Add(Me.Checkeffectdefaite)
        Me.Controls.Add(Me.Checkeffectvictoire)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Morpion"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morpion"
        CType(Me.GIFbaby, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIFartifice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIFlicorne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIFconfetti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIFlicorne1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIFlicorne2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIFlicorne3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIFlicorne4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIFfootball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIFapple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIFducoup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIFducoup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GIFgameover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmdAgain As Button
    Friend WithEvents TextJoueurO As TextBox
    Friend WithEvents TextJoueurX As TextBox
    Friend WithEvents LabelJoueurX As Label
    Friend WithEvents LabelJoueurO As Label
    Friend WithEvents cmdScoreReset As Button
    Friend WithEvents cmdRestart As Button
    Friend WithEvents Timer_Ordinateur As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmdQuit As Button
    Friend WithEvents GIFbaby As PictureBox
    Friend WithEvents GIFartifice As PictureBox
    Friend WithEvents GIFlicorne As PictureBox
    Friend WithEvents GIFconfetti As PictureBox
    Friend WithEvents GIFlicorne1 As PictureBox
    Friend WithEvents GIFlicorne2 As PictureBox
    Friend WithEvents GIFlicorne3 As PictureBox
    Friend WithEvents GIFlicorne4 As PictureBox
    Friend WithEvents cmdBack As Button
    Friend WithEvents GIFfootball As PictureBox
    Friend WithEvents GIFapple As PictureBox
    Friend WithEvents GIFducoup As PictureBox
    Friend WithEvents GIFducoup2 As PictureBox
    Friend WithEvents GIFgameover As PictureBox
    Friend WithEvents cmdContinue As Button
    Friend WithEvents cmdtroll As Button
    Friend WithEvents Background As PictureBox
    Friend WithEvents cmdOption As Button
    Friend WithEvents cmdBackOption As Button
    Friend WithEvents Checkeffectvictoire As CheckBox
    Friend WithEvents Checkeffectdefaite As CheckBox
    Friend WithEvents Cadre As Label
    Friend WithEvents Cadre2 As Label
End Class
