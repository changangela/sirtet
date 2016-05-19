<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tetris
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tetris))
        Me.GameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlTetris = New System.Windows.Forms.Panel()
        Me.lblPause = New System.Windows.Forms.Label()
        Me.pnlName = New System.Windows.Forms.Panel()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.lblEnterName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.lblStart = New System.Windows.Forms.Label()
        Me.lblGo = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pnlScore = New System.Windows.Forms.Panel()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblLines = New System.Windows.Forms.Label()
        Me.lblHelp = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.pnlBigNext = New System.Windows.Forms.Panel()
        Me.lblNext = New System.Windows.Forms.Label()
        Me.pnlNext = New System.Windows.Forms.Panel()
        Me.pnlBigHold = New System.Windows.Forms.Panel()
        Me.lblHold = New System.Windows.Forms.Label()
        Me.pnlHold = New System.Windows.Forms.Panel()
        Me.pnlHelp = New System.Windows.Forms.Panel()
        Me.lblHelpInstructions = New System.Windows.Forms.Label()
        Me.lblControlUses = New System.Windows.Forms.Label()
        Me.lblControlList = New System.Windows.Forms.Label()
        Me.lblKeyControl = New System.Windows.Forms.Label()
        Me.pnlHighScore = New System.Windows.Forms.Panel()
        Me.lblClear = New System.Windows.Forms.Label()
        Me.lblHSBL = New System.Windows.Forms.Label()
        Me.lblHSBS = New System.Windows.Forms.Label()
        Me.lblHSScoreListBL = New System.Windows.Forms.Label()
        Me.lblHSLinesListBL = New System.Windows.Forms.Label()
        Me.lblHSRankListBL = New System.Windows.Forms.Label()
        Me.lblHSRankBL = New System.Windows.Forms.Label()
        Me.lblHSNameListBL = New System.Windows.Forms.Label()
        Me.lblHSLinesBL = New System.Windows.Forms.Label()
        Me.lblHSScoreBL = New System.Windows.Forms.Label()
        Me.lblHSNameBL = New System.Windows.Forms.Label()
        Me.lblHSScoreListBS = New System.Windows.Forms.Label()
        Me.lblHSLinesListBS = New System.Windows.Forms.Label()
        Me.lblHS = New System.Windows.Forms.Label()
        Me.lblHSRankListBS = New System.Windows.Forms.Label()
        Me.lblHSRankBS = New System.Windows.Forms.Label()
        Me.lblHSNameListBS = New System.Windows.Forms.Label()
        Me.lblHSLinesBS = New System.Windows.Forms.Label()
        Me.lblHSScoreBS = New System.Windows.Forms.Label()
        Me.lblHSNameBS = New System.Windows.Forms.Label()
        Me.lblLeaderboards = New System.Windows.Forms.Label()
        Me.pnlTetris.SuspendLayout()
        Me.pnlName.SuspendLayout()
        Me.pnlScore.SuspendLayout()
        Me.pnlBigNext.SuspendLayout()
        Me.pnlBigHold.SuspendLayout()
        Me.pnlHelp.SuspendLayout()
        Me.pnlHighScore.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameTimer
        '
        Me.GameTimer.Interval = 500
        '
        'pnlTetris
        '
        Me.pnlTetris.BackColor = System.Drawing.Color.Pink
        Me.pnlTetris.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTetris.Controls.Add(Me.lblPause)
        Me.pnlTetris.Controls.Add(Me.pnlName)
        Me.pnlTetris.Controls.Add(Me.lblGameOver)
        Me.pnlTetris.Controls.Add(Me.lblStart)
        Me.pnlTetris.Controls.Add(Me.lblGo)
        Me.pnlTetris.Controls.Add(Me.lbl2)
        Me.pnlTetris.Controls.Add(Me.lbl3)
        Me.pnlTetris.Controls.Add(Me.lbl1)
        Me.pnlTetris.Location = New System.Drawing.Point(169, 0)
        Me.pnlTetris.Name = "pnlTetris"
        Me.pnlTetris.Size = New System.Drawing.Size(232, 462)
        Me.pnlTetris.TabIndex = 0
        '
        'lblPause
        '
        Me.lblPause.AutoSize = True
        Me.lblPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPause.Location = New System.Drawing.Point(14, 162)
        Me.lblPause.Name = "lblPause"
        Me.lblPause.Size = New System.Drawing.Size(198, 36)
        Me.lblPause.TabIndex = 1
        Me.lblPause.Text = "GAME PAUSED" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press 'space' to unpause"
        Me.lblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPause.Visible = False
        '
        'pnlName
        '
        Me.pnlName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlName.Controls.Add(Me.btnSubmit)
        Me.pnlName.Controls.Add(Me.lblEnterName)
        Me.pnlName.Controls.Add(Me.txtName)
        Me.pnlName.Location = New System.Drawing.Point(-1, 182)
        Me.pnlName.Name = "pnlName"
        Me.pnlName.Size = New System.Drawing.Size(232, 90)
        Me.pnlName.TabIndex = 5
        Me.pnlName.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(55, 46)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(123, 36)
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "Submit Score"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblEnterName
        '
        Me.lblEnterName.AutoSize = True
        Me.lblEnterName.Location = New System.Drawing.Point(80, 4)
        Me.lblEnterName.Name = "lblEnterName"
        Me.lblEnterName.Size = New System.Drawing.Size(66, 13)
        Me.lblEnterName.TabIndex = 4
        Me.lblEnterName.Text = "Enter Name:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(55, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(123, 18)
        Me.txtName.TabIndex = 3
        Me.txtName.Text = "Anonymous"
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.Location = New System.Drawing.Point(24, 162)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(184, 36)
        Me.lblGameOver.TabIndex = 0
        Me.lblGameOver.Text = "GAME OVER" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press 'space' to restart"
        Me.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGameOver.Visible = False
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(27, 160)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(169, 36)
        Me.lblStart.TabIndex = 2
        Me.lblStart.Text = "TETRIS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press 'space' to start"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGo
        '
        Me.lblGo.AutoSize = True
        Me.lblGo.Font = New System.Drawing.Font("Lucida Console", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGo.Location = New System.Drawing.Point(37, 146)
        Me.lblGo.Name = "lblGo"
        Me.lblGo.Size = New System.Drawing.Size(171, 37)
        Me.lblGo.TabIndex = 6
        Me.lblGo.Text = "Tetris!"
        Me.lblGo.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Lucida Console", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(96, 148)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(39, 37)
        Me.lbl2.TabIndex = 5
        Me.lbl2.Text = "2"
        Me.lbl2.Visible = False
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Lucida Console", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(96, 148)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(39, 37)
        Me.lbl3.TabIndex = 4
        Me.lbl3.Text = "3"
        Me.lbl3.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Lucida Console", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(96, 148)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(39, 37)
        Me.lbl1.TabIndex = 3
        Me.lbl1.Text = "1"
        Me.lbl1.Visible = False
        '
        'pnlScore
        '
        Me.pnlScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlScore.Controls.Add(Me.lblLevel)
        Me.pnlScore.Controls.Add(Me.lblLines)
        Me.pnlScore.Controls.Add(Me.lblHelp)
        Me.pnlScore.Controls.Add(Me.lblScore)
        Me.pnlScore.Location = New System.Drawing.Point(400, 146)
        Me.pnlScore.Name = "pnlScore"
        Me.pnlScore.Size = New System.Drawing.Size(170, 316)
        Me.pnlScore.TabIndex = 3
        '
        'lblLevel
        '
        Me.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLevel.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(-1, 60)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(170, 30)
        Me.lblLevel.TabIndex = 2
        Me.lblLevel.Text = "LEVEL: 1"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLines
        '
        Me.lblLines.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLines.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLines.Location = New System.Drawing.Point(-1, 29)
        Me.lblLines.Name = "lblLines"
        Me.lblLines.Size = New System.Drawing.Size(170, 32)
        Me.lblLines.TabIndex = 1
        Me.lblLines.Text = "LINES: 0"
        Me.lblLines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHelp
        '
        Me.lblHelp.AutoSize = True
        Me.lblHelp.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelp.Location = New System.Drawing.Point(35, 290)
        Me.lblHelp.Name = "lblHelp"
        Me.lblHelp.Size = New System.Drawing.Size(98, 16)
        Me.lblHelp.TabIndex = 4
        Me.lblHelp.Text = "Press 'H' for help"
        '
        'lblScore
        '
        Me.lblScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblScore.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(-1, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(170, 30)
        Me.lblScore.TabIndex = 0
        Me.lblScore.Text = "SCORE: 0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlBigNext
        '
        Me.pnlBigNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlBigNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBigNext.Controls.Add(Me.lblNext)
        Me.pnlBigNext.Controls.Add(Me.pnlNext)
        Me.pnlBigNext.Location = New System.Drawing.Point(400, 0)
        Me.pnlBigNext.Name = "pnlBigNext"
        Me.pnlBigNext.Size = New System.Drawing.Size(170, 149)
        Me.pnlBigNext.TabIndex = 5
        '
        'lblNext
        '
        Me.lblNext.AutoSize = True
        Me.lblNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNext.Location = New System.Drawing.Point(35, 0)
        Me.lblNext.Name = "lblNext"
        Me.lblNext.Size = New System.Drawing.Size(90, 18)
        Me.lblNext.TabIndex = 2
        Me.lblNext.Text = "Next Block"
        '
        'pnlNext
        '
        Me.pnlNext.BackColor = System.Drawing.Color.Transparent
        Me.pnlNext.Location = New System.Drawing.Point(37, 34)
        Me.pnlNext.Name = "pnlNext"
        Me.pnlNext.Size = New System.Drawing.Size(92, 92)
        Me.pnlNext.TabIndex = 1
        '
        'pnlBigHold
        '
        Me.pnlBigHold.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.pnlBigHold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBigHold.Controls.Add(Me.lblHold)
        Me.pnlBigHold.Controls.Add(Me.pnlHold)
        Me.pnlBigHold.Location = New System.Drawing.Point(0, 0)
        Me.pnlBigHold.Name = "pnlBigHold"
        Me.pnlBigHold.Size = New System.Drawing.Size(170, 149)
        Me.pnlBigHold.TabIndex = 6
        '
        'lblHold
        '
        Me.lblHold.AutoSize = True
        Me.lblHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHold.Location = New System.Drawing.Point(35, 0)
        Me.lblHold.Name = "lblHold"
        Me.lblHold.Size = New System.Drawing.Size(95, 20)
        Me.lblHold.TabIndex = 2
        Me.lblHold.Text = "Hold Block"
        '
        'pnlHold
        '
        Me.pnlHold.BackColor = System.Drawing.Color.Transparent
        Me.pnlHold.Location = New System.Drawing.Point(37, 34)
        Me.pnlHold.Name = "pnlHold"
        Me.pnlHold.Size = New System.Drawing.Size(92, 92)
        Me.pnlHold.TabIndex = 1
        '
        'pnlHelp
        '
        Me.pnlHelp.BackColor = System.Drawing.SystemColors.Control
        Me.pnlHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHelp.Controls.Add(Me.lblHelpInstructions)
        Me.pnlHelp.Controls.Add(Me.lblControlUses)
        Me.pnlHelp.Controls.Add(Me.lblControlList)
        Me.pnlHelp.Controls.Add(Me.lblKeyControl)
        Me.pnlHelp.Location = New System.Drawing.Point(169, 85)
        Me.pnlHelp.Name = "pnlHelp"
        Me.pnlHelp.Size = New System.Drawing.Size(232, 257)
        Me.pnlHelp.TabIndex = 8
        Me.pnlHelp.Visible = False
        '
        'lblHelpInstructions
        '
        Me.lblHelpInstructions.AutoSize = True
        Me.lblHelpInstructions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHelpInstructions.ForeColor = System.Drawing.Color.SlateGray
        Me.lblHelpInstructions.Location = New System.Drawing.Point(51, 234)
        Me.lblHelpInstructions.Name = "lblHelpInstructions"
        Me.lblHelpInstructions.Size = New System.Drawing.Size(119, 15)
        Me.lblHelpInstructions.TabIndex = 3
        Me.lblHelpInstructions.Text = "Press 'H' to close"
        '
        'lblControlUses
        '
        Me.lblControlUses.AutoSize = True
        Me.lblControlUses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlUses.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblControlUses.Location = New System.Drawing.Point(112, 37)
        Me.lblControlUses.Name = "lblControlUses"
        Me.lblControlUses.Size = New System.Drawing.Size(103, 192)
        Me.lblControlUses.TabIndex = 2
        Me.lblControlUses.Text = "Move left" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Move right" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Move down" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rotate right" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hold piece" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hard drop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Rotate lef" & _
            "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pause/unpause" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Toggle sound" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Toggle shadow" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Restart" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exit Game" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblControlUses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblControlList
        '
        Me.lblControlList.AutoSize = True
        Me.lblControlList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblControlList.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblControlList.Location = New System.Drawing.Point(6, 37)
        Me.lblControlList.Name = "lblControlList"
        Me.lblControlList.Size = New System.Drawing.Size(106, 192)
        Me.lblControlList.TabIndex = 1
        Me.lblControlList.Text = "Left Arrow:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right Arrow:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Down Arrow:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "X or Up Arrow:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shift:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Space:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Z:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & _
            ":" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Q or Escape:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblControlList.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblKeyControl
        '
        Me.lblKeyControl.AutoSize = True
        Me.lblKeyControl.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKeyControl.ForeColor = System.Drawing.Color.SlateGray
        Me.lblKeyControl.Location = New System.Drawing.Point(51, 15)
        Me.lblKeyControl.Name = "lblKeyControl"
        Me.lblKeyControl.Size = New System.Drawing.Size(127, 15)
        Me.lblKeyControl.TabIndex = 0
        Me.lblKeyControl.Text = "Control Keys"
        '
        'pnlHighScore
        '
        Me.pnlHighScore.BackColor = System.Drawing.Color.Black
        Me.pnlHighScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHighScore.Controls.Add(Me.lblClear)
        Me.pnlHighScore.Controls.Add(Me.lblHSBL)
        Me.pnlHighScore.Controls.Add(Me.lblHSBS)
        Me.pnlHighScore.Controls.Add(Me.lblHSScoreListBL)
        Me.pnlHighScore.Controls.Add(Me.lblHSLinesListBL)
        Me.pnlHighScore.Controls.Add(Me.lblHSRankListBL)
        Me.pnlHighScore.Controls.Add(Me.lblHSRankBL)
        Me.pnlHighScore.Controls.Add(Me.lblHSNameListBL)
        Me.pnlHighScore.Controls.Add(Me.lblHSLinesBL)
        Me.pnlHighScore.Controls.Add(Me.lblHSScoreBL)
        Me.pnlHighScore.Controls.Add(Me.lblHSNameBL)
        Me.pnlHighScore.Controls.Add(Me.lblHSScoreListBS)
        Me.pnlHighScore.Controls.Add(Me.lblHSLinesListBS)
        Me.pnlHighScore.Controls.Add(Me.lblHS)
        Me.pnlHighScore.Controls.Add(Me.lblHSRankListBS)
        Me.pnlHighScore.Controls.Add(Me.lblHSRankBS)
        Me.pnlHighScore.Controls.Add(Me.lblHSNameListBS)
        Me.pnlHighScore.Controls.Add(Me.lblHSLinesBS)
        Me.pnlHighScore.Controls.Add(Me.lblHSScoreBS)
        Me.pnlHighScore.Controls.Add(Me.lblHSNameBS)
        Me.pnlHighScore.ForeColor = System.Drawing.Color.Black
        Me.pnlHighScore.Location = New System.Drawing.Point(169, 0)
        Me.pnlHighScore.Name = "pnlHighScore"
        Me.pnlHighScore.Size = New System.Drawing.Size(232, 462)
        Me.pnlHighScore.TabIndex = 7
        Me.pnlHighScore.Visible = False
        '
        'lblClear
        '
        Me.lblClear.AutoSize = True
        Me.lblClear.BackColor = System.Drawing.Color.Black
        Me.lblClear.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClear.ForeColor = System.Drawing.Color.White
        Me.lblClear.Location = New System.Drawing.Point(6, 438)
        Me.lblClear.Name = "lblClear"
        Me.lblClear.Size = New System.Drawing.Size(185, 16)
        Me.lblClear.TabIndex = 10
        Me.lblClear.Text = "Press 'F4' to clear and 'L' to close"
        '
        'lblHSBL
        '
        Me.lblHSBL.AutoSize = True
        Me.lblHSBL.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSBL.ForeColor = System.Drawing.Color.White
        Me.lblHSBL.Location = New System.Drawing.Point(6, 242)
        Me.lblHSBL.Name = "lblHSBL"
        Me.lblHSBL.Size = New System.Drawing.Size(87, 15)
        Me.lblHSBL.TabIndex = 23
        Me.lblHSBL.Text = "By Lines"
        '
        'lblHSBS
        '
        Me.lblHSBS.AutoSize = True
        Me.lblHSBS.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSBS.ForeColor = System.Drawing.Color.White
        Me.lblHSBS.Location = New System.Drawing.Point(3, 41)
        Me.lblHSBS.Name = "lblHSBS"
        Me.lblHSBS.Size = New System.Drawing.Size(87, 15)
        Me.lblHSBS.TabIndex = 22
        Me.lblHSBS.Text = "By Score" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblHSScoreListBL
        '
        Me.lblHSScoreListBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSScoreListBL.ForeColor = System.Drawing.Color.White
        Me.lblHSScoreListBL.Location = New System.Drawing.Point(171, 281)
        Me.lblHSScoreListBL.Name = "lblHSScoreListBL"
        Me.lblHSScoreListBL.Size = New System.Drawing.Size(60, 153)
        Me.lblHSScoreListBL.TabIndex = 21
        Me.lblHSScoreListBL.Text = "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--"
        Me.lblHSScoreListBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSLinesListBL
        '
        Me.lblHSLinesListBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSLinesListBL.ForeColor = System.Drawing.Color.White
        Me.lblHSLinesListBL.Location = New System.Drawing.Point(111, 281)
        Me.lblHSLinesListBL.Name = "lblHSLinesListBL"
        Me.lblHSLinesListBL.Size = New System.Drawing.Size(61, 153)
        Me.lblHSLinesListBL.TabIndex = 20
        Me.lblHSLinesListBL.Text = "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--"
        Me.lblHSLinesListBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSRankListBL
        '
        Me.lblHSRankListBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSRankListBL.ForeColor = System.Drawing.Color.White
        Me.lblHSRankListBL.Location = New System.Drawing.Point(-1, 281)
        Me.lblHSRankListBL.Name = "lblHSRankListBL"
        Me.lblHSRankListBL.Size = New System.Drawing.Size(48, 153)
        Me.lblHSRankListBL.TabIndex = 19
        Me.lblHSRankListBL.Text = "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10"
        Me.lblHSRankListBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSRankBL
        '
        Me.lblHSRankBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSRankBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSRankBL.ForeColor = System.Drawing.Color.White
        Me.lblHSRankBL.Location = New System.Drawing.Point(-1, 261)
        Me.lblHSRankBL.Name = "lblHSRankBL"
        Me.lblHSRankBL.Size = New System.Drawing.Size(48, 21)
        Me.lblHSRankBL.TabIndex = 18
        Me.lblHSRankBL.Text = "Rank"
        Me.lblHSRankBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSNameListBL
        '
        Me.lblHSNameListBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSNameListBL.ForeColor = System.Drawing.Color.White
        Me.lblHSNameListBL.Location = New System.Drawing.Point(46, 281)
        Me.lblHSNameListBL.Name = "lblHSNameListBL"
        Me.lblHSNameListBL.Size = New System.Drawing.Size(66, 153)
        Me.lblHSNameListBL.TabIndex = 17
        Me.lblHSNameListBL.Text = "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--"
        Me.lblHSNameListBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSLinesBL
        '
        Me.lblHSLinesBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSLinesBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSLinesBL.ForeColor = System.Drawing.Color.White
        Me.lblHSLinesBL.Location = New System.Drawing.Point(111, 261)
        Me.lblHSLinesBL.Name = "lblHSLinesBL"
        Me.lblHSLinesBL.Size = New System.Drawing.Size(61, 21)
        Me.lblHSLinesBL.TabIndex = 16
        Me.lblHSLinesBL.Text = "Lines"
        Me.lblHSLinesBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSScoreBL
        '
        Me.lblHSScoreBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSScoreBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSScoreBL.ForeColor = System.Drawing.Color.White
        Me.lblHSScoreBL.Location = New System.Drawing.Point(171, 261)
        Me.lblHSScoreBL.Name = "lblHSScoreBL"
        Me.lblHSScoreBL.Size = New System.Drawing.Size(60, 21)
        Me.lblHSScoreBL.TabIndex = 15
        Me.lblHSScoreBL.Text = "Score"
        Me.lblHSScoreBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSNameBL
        '
        Me.lblHSNameBL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSNameBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSNameBL.ForeColor = System.Drawing.Color.White
        Me.lblHSNameBL.Location = New System.Drawing.Point(46, 261)
        Me.lblHSNameBL.Name = "lblHSNameBL"
        Me.lblHSNameBL.Size = New System.Drawing.Size(66, 21)
        Me.lblHSNameBL.TabIndex = 14
        Me.lblHSNameBL.Text = "Name"
        Me.lblHSNameBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSScoreListBS
        '
        Me.lblHSScoreListBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSScoreListBS.ForeColor = System.Drawing.Color.White
        Me.lblHSScoreListBS.Location = New System.Drawing.Point(110, 81)
        Me.lblHSScoreListBS.Name = "lblHSScoreListBS"
        Me.lblHSScoreListBS.Size = New System.Drawing.Size(60, 150)
        Me.lblHSScoreListBS.TabIndex = 13
        Me.lblHSScoreListBS.Text = "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--"
        Me.lblHSScoreListBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSLinesListBS
        '
        Me.lblHSLinesListBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSLinesListBS.ForeColor = System.Drawing.Color.White
        Me.lblHSLinesListBS.Location = New System.Drawing.Point(169, 81)
        Me.lblHSLinesListBS.Name = "lblHSLinesListBS"
        Me.lblHSLinesListBS.Size = New System.Drawing.Size(61, 150)
        Me.lblHSLinesListBS.TabIndex = 12
        Me.lblHSLinesListBS.Text = "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--"
        Me.lblHSLinesListBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHS
        '
        Me.lblHS.AutoSize = True
        Me.lblHS.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHS.ForeColor = System.Drawing.Color.White
        Me.lblHS.Location = New System.Drawing.Point(12, 8)
        Me.lblHS.Name = "lblHS"
        Me.lblHS.Size = New System.Drawing.Size(207, 32)
        Me.lblHS.TabIndex = 11
        Me.lblHS.Text = "HIGH SCORES"
        '
        'lblHSRankListBS
        '
        Me.lblHSRankListBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSRankListBS.ForeColor = System.Drawing.Color.White
        Me.lblHSRankListBS.Location = New System.Drawing.Point(-1, 81)
        Me.lblHSRankListBS.Name = "lblHSRankListBS"
        Me.lblHSRankListBS.Size = New System.Drawing.Size(48, 150)
        Me.lblHSRankListBS.TabIndex = 10
        Me.lblHSRankListBS.Text = "1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "6" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "8" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "9" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "10"
        Me.lblHSRankListBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSRankBS
        '
        Me.lblHSRankBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSRankBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSRankBS.ForeColor = System.Drawing.Color.White
        Me.lblHSRankBS.Location = New System.Drawing.Point(-1, 60)
        Me.lblHSRankBS.Name = "lblHSRankBS"
        Me.lblHSRankBS.Size = New System.Drawing.Size(48, 22)
        Me.lblHSRankBS.TabIndex = 9
        Me.lblHSRankBS.Text = "Rank"
        Me.lblHSRankBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSNameListBS
        '
        Me.lblHSNameListBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSNameListBS.ForeColor = System.Drawing.Color.White
        Me.lblHSNameListBS.Location = New System.Drawing.Point(46, 81)
        Me.lblHSNameListBS.Name = "lblHSNameListBS"
        Me.lblHSNameListBS.Size = New System.Drawing.Size(66, 150)
        Me.lblHSNameListBS.TabIndex = 8
        Me.lblHSNameListBS.Text = "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "--"
        Me.lblHSNameListBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSLinesBS
        '
        Me.lblHSLinesBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSLinesBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSLinesBS.ForeColor = System.Drawing.Color.White
        Me.lblHSLinesBS.Location = New System.Drawing.Point(169, 60)
        Me.lblHSLinesBS.Name = "lblHSLinesBS"
        Me.lblHSLinesBS.Size = New System.Drawing.Size(61, 22)
        Me.lblHSLinesBS.TabIndex = 7
        Me.lblHSLinesBS.Text = "Lines"
        Me.lblHSLinesBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSScoreBS
        '
        Me.lblHSScoreBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSScoreBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSScoreBS.ForeColor = System.Drawing.Color.White
        Me.lblHSScoreBS.Location = New System.Drawing.Point(110, 60)
        Me.lblHSScoreBS.Name = "lblHSScoreBS"
        Me.lblHSScoreBS.Size = New System.Drawing.Size(60, 22)
        Me.lblHSScoreBS.TabIndex = 6
        Me.lblHSScoreBS.Text = "Score"
        Me.lblHSScoreBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHSNameBS
        '
        Me.lblHSNameBS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHSNameBS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHSNameBS.ForeColor = System.Drawing.Color.White
        Me.lblHSNameBS.Location = New System.Drawing.Point(46, 60)
        Me.lblHSNameBS.Name = "lblHSNameBS"
        Me.lblHSNameBS.Size = New System.Drawing.Size(66, 22)
        Me.lblHSNameBS.TabIndex = 5
        Me.lblHSNameBS.Text = "Name"
        Me.lblHSNameBS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLeaderboards
        '
        Me.lblLeaderboards.AutoSize = True
        Me.lblLeaderboards.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeaderboards.Location = New System.Drawing.Point(12, 437)
        Me.lblLeaderboards.Name = "lblLeaderboards"
        Me.lblLeaderboards.Size = New System.Drawing.Size(141, 16)
        Me.lblLeaderboards.TabIndex = 9
        Me.lblLeaderboards.Text = "Press 'L' for Leaderboard"
        '
        'Tetris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(570, 462)
        Me.Controls.Add(Me.lblLeaderboards)
        Me.Controls.Add(Me.pnlBigHold)
        Me.Controls.Add(Me.pnlBigNext)
        Me.Controls.Add(Me.pnlScore)
        Me.Controls.Add(Me.pnlHelp)
        Me.Controls.Add(Me.pnlTetris)
        Me.Controls.Add(Me.pnlHighScore)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tetris"
        Me.Text = "Tetris"
        Me.pnlTetris.ResumeLayout(False)
        Me.pnlTetris.PerformLayout()
        Me.pnlName.ResumeLayout(False)
        Me.pnlName.PerformLayout()
        Me.pnlScore.ResumeLayout(False)
        Me.pnlScore.PerformLayout()
        Me.pnlBigNext.ResumeLayout(False)
        Me.pnlBigNext.PerformLayout()
        Me.pnlBigHold.ResumeLayout(False)
        Me.pnlBigHold.PerformLayout()
        Me.pnlHelp.ResumeLayout(False)
        Me.pnlHelp.PerformLayout()
        Me.pnlHighScore.ResumeLayout(False)
        Me.pnlHighScore.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GameTimer As System.Windows.Forms.Timer
    Friend WithEvents pnlTetris As System.Windows.Forms.Panel
    Friend WithEvents pnlScore As System.Windows.Forms.Panel
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents pnlBigNext As System.Windows.Forms.Panel
    Friend WithEvents lblNext As System.Windows.Forms.Label
    Friend WithEvents pnlNext As System.Windows.Forms.Panel
    Friend WithEvents pnlBigHold As System.Windows.Forms.Panel
    Friend WithEvents lblHold As System.Windows.Forms.Label
    Friend WithEvents pnlHold As System.Windows.Forms.Panel
    Friend WithEvents lblGameOver As System.Windows.Forms.Label
    Friend WithEvents lblPause As System.Windows.Forms.Label
    Friend WithEvents lblLines As System.Windows.Forms.Label
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents lblGo As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents pnlName As System.Windows.Forms.Panel
    Friend WithEvents lblEnterName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents pnlHelp As System.Windows.Forms.Panel
    Friend WithEvents lblHelp As System.Windows.Forms.Label
    Friend WithEvents lblControlUses As System.Windows.Forms.Label
    Friend WithEvents lblControlList As System.Windows.Forms.Label
    Friend WithEvents lblKeyControl As System.Windows.Forms.Label
    Friend WithEvents lblHelpInstructions As System.Windows.Forms.Label
    Friend WithEvents pnlHighScore As System.Windows.Forms.Panel
    Friend WithEvents lblHSBS As System.Windows.Forms.Label
    Friend WithEvents lblHSScoreListBL As System.Windows.Forms.Label
    Friend WithEvents lblHSLinesListBL As System.Windows.Forms.Label
    Friend WithEvents lblHSRankListBL As System.Windows.Forms.Label
    Friend WithEvents lblHSRankBL As System.Windows.Forms.Label
    Friend WithEvents lblHSNameListBL As System.Windows.Forms.Label
    Friend WithEvents lblHSLinesBL As System.Windows.Forms.Label
    Friend WithEvents lblHSScoreBL As System.Windows.Forms.Label
    Friend WithEvents lblHSNameBL As System.Windows.Forms.Label
    Friend WithEvents lblHSScoreListBS As System.Windows.Forms.Label
    Friend WithEvents lblHSLinesListBS As System.Windows.Forms.Label
    Friend WithEvents lblHS As System.Windows.Forms.Label
    Friend WithEvents lblHSRankListBS As System.Windows.Forms.Label
    Friend WithEvents lblHSRankBS As System.Windows.Forms.Label
    Friend WithEvents lblHSNameListBS As System.Windows.Forms.Label
    Friend WithEvents lblHSLinesBS As System.Windows.Forms.Label
    Friend WithEvents lblHSScoreBS As System.Windows.Forms.Label
    Friend WithEvents lblHSNameBS As System.Windows.Forms.Label
    Friend WithEvents lblHSBL As System.Windows.Forms.Label
    Friend WithEvents lblLeaderboards As System.Windows.Forms.Label
    Friend WithEvents lblClear As System.Windows.Forms.Label

End Class
