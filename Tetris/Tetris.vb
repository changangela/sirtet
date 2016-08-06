Public Class Tetris


    Private GRID_SIZE As Integer = 24
    Private GRID_X As Integer = 10
    Private GRID_Y As Integer = 24
    Private Const BLOCK_KIND As Integer = 8
    Private Const BLOCK_ROLL As Integer = 4
    Private Const BLOCK_WIDE As Integer = 4
    Private Shared blocks()()() As Boolean = getInitBlocks()

    Private numRows As Integer
    Private gameLines As Integer
    Private timerLines As Integer
    Private intScore As Integer
    Private canHold As Boolean = True

    Private showShadow As Boolean = False
    Private Shared Function getInitBlocks() As Boolean()()()
        'basically there are a total of eight possible block shapes and each one has four possible rotation ways
        'the below represents which grids inside a 4x4 grid is activated when this shape is present during its four rotations
        'if you don't understand, just draw a 4x4 grid and for each '1' color it in
        blocks = New Boolean(BLOCK_KIND)()() {}
        For index = 0 To blocks.GetUpperBound(0)
            blocks(index) = New Boolean(BLOCK_ROLL)() {}
        Next
        blocks(0)(3) = {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0}
        blocks(0)(2) = {0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0}
        blocks(0)(1) = {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0}
        blocks(0)(0) = {0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0}

        blocks(1)(3) = {0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0}
        blocks(1)(2) = {0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0}
        blocks(1)(1) = {0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0}
        blocks(1)(0) = {0, 0, 0, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0}

        blocks(2)(3) = {0, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0}
        blocks(2)(2) = {0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0}
        blocks(2)(1) = {0, 0, 1, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0}
        blocks(2)(0) = {0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0}

        blocks(3)(3) = {0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0}
        blocks(3)(2) = {0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0}
        blocks(3)(1) = {0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0}
        blocks(3)(0) = {0, 0, 0, 0, 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0}

        blocks(4)(3) = {0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0}
        blocks(4)(2) = {0, 0, 0, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0}
        blocks(4)(1) = {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0}
        blocks(4)(0) = {0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0}

        blocks(5)(3) = {0, 1, 1, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0}
        blocks(5)(2) = {0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0}
        blocks(5)(1) = {0, 0, 1, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 0, 0}
        blocks(5)(0) = {0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0}

        blocks(6)(3) = {1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        blocks(6)(2) = {0, 1, 0, 0, 0, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0}
        blocks(6)(1) = {0, 1, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        blocks(6)(0) = {0, 0, 1, 0, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0}

        blocks(7)(3) = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        blocks(7)(2) = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        blocks(7)(1) = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        blocks(7)(0) = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        Return blocks
    End Function
    Private Function isInsideBlock(ByVal blockShape As Rectangle) As Boolean
        'this is just to check whether the certain block is inside the form
        Return Not (blockShape.Left < 0 Or blockShape.Left + blockShape.Width > GRID_X Or blockShape.Top < 0 Or blockShape.Top + blockShape.Height > GRID_Y)
        Return True
    End Function
    Private Function isInsidePoint(ByVal point As Point) As Boolean
        'this is just to check whether the certain point is inside the form
        Return Not (point.X < 0 Or point.X >= GRID_X Or point.Y < 0 Or point.Y >= GRID_Y)
        Return True
    End Function
    Private Function isGameFailed() As Boolean
        For x = 0 To GRID_X - 1
            If gridBox(x)(BLOCK_WIDE - 1) Then
                Return True
            End If
        Next
        Return False
    End Function
    Structure Block
        'this is really unnecessary but I was learning to use structures
        'so basically I gave each block a 'point', 'block' and 'roll' control
        ''roll' tells us which rotation it is on
        ''block tells us which block we are using

        Public point As Point
        Public block As Integer
        Public roll As Integer
        ' constructor
        Public Sub New(ByVal point As Point, ByVal block As Integer, ByVal roll As Integer)
            'assigns each block with its properties
            Me.point = point
            Me.block = block
            Me.roll = roll
        End Sub
        Public Function getBlockShape() As Rectangle
            'we take in the topleft point and the bottomright point of that 4x4 grid explained in the first method in order to check for restrictions in the future
            Dim offsetLeftTop As Point = New Point(BLOCK_WIDE - 1, BLOCK_WIDE - 1)
            Dim offsetRightBottom As Point = New Point(0, 0)
            Dim num As Integer = 0
            For Each block As Boolean In blocks(Me.block)(Me.roll)
                Dim point As Point = New Point(num Mod BLOCK_WIDE, num \ BLOCK_WIDE)
                If block Then

                    If point.X < offsetLeftTop.X Then offsetLeftTop.X = point.X
                    If point.Y < offsetLeftTop.Y Then offsetLeftTop.Y = point.Y
                    If point.X > offsetRightBottom.X Then offsetRightBottom.X = point.X
                    If point.Y > offsetRightBottom.Y Then offsetRightBottom.Y = point.Y
                End If
                num = num + 1
            Next
            Return New Rectangle(offsetLeftTop, New Size(offsetRightBottom - offsetLeftTop + New Point(1, 1)))
        End Function
    End Structure
    Private Function getNewBlock() As Block
        'randomly selects a new block to appear out of the 8 possible block shapes
        Dim block As Block = New Block(New Point(0, 0), CInt(Int(((BLOCK_KIND - 1) * Rnd()) + 1)) - 1, 0)

        Dim blockShape = block.getBlockShape()
        block.point = New Point(GRID_X / 2 - blockShape.Left, blockShape.Top)
        Return (block)
    End Function
    Private Function getblockPoint(ByVal block As Block) As Integer
        For z = BLOCK_WIDE ^ 2 - 1 To 0 Step -1
            If blocks(block.block)(block.roll)(z) Then
                Return BLOCK_WIDE - z \ BLOCK_WIDE
            End If
        Next
    End Function
    Private Function addGridBlock(ByVal block As Block)
        'the appropriate buttons become visible to create the effects of this block appearing
        Dim blockShape As Rectangle = block.getBlockShape()
        blockShape.Offset(block.point)
        For x = blockShape.Left To blockShape.Left + blockShape.Width - 1
            For y = blockShape.Top To blockShape.Top + blockShape.Height - 1
                If isInsidePoint(New Point(x, y)) Then
                    If blocks(block.block)(block.roll)((y - block.point.Y) * BLOCK_WIDE + (x - block.point.X)) Then
                        gridBox(x)(y) = True
                    End If
                End If
            Next
        Next
    End Function
    Dim currentBlock As Block
    Dim nextBlock As Block
    Dim holdBlock As Block
    Dim shadowBlock As Block
    Private Function rollBlock(ByVal rollWay As Boolean)
        'tells us which rotation the block is on
        'ie: a stick may be vertical or horizontal
        If rollWay Then
            currentBlock.roll = (currentBlock.roll + 1) Mod BLOCK_ROLL
        Else
            currentBlock.roll = (currentBlock.roll + BLOCK_ROLL - 1) Mod BLOCK_ROLL
        End If

    End Function
    Private Function isShadowBlockMovable(ByVal offset As Point) As Boolean
        'checks to see if the block can still move and/or which ways it can still turn
        Dim block As Block = shadowBlock
        Dim blockShape As Rectangle = block.getBlockShape()
        Dim blockPoint As Point = block.point + offset
        blockShape.Offset(blockPoint)

        Dim blockMovable As Boolean = isInsideBlock(blockShape)
        If Not blockMovable Then Return blockMovable
        For x = blockShape.Left To blockShape.Left + blockShape.Width - 1
            For y = blockShape.Top To blockShape.Top + blockShape.Height - 1
                If isInsidePoint(New Point(x, y)) Then
                    If blocks(block.block)(block.roll)((y - blockPoint.Y) * BLOCK_WIDE + (x - blockPoint.X)) And gridBox(x)(y) Then
                        Return False
                    End If
                End If
            Next
        Next
        Return True
    End Function
    Private Function moveShadowBlock() As Boolean
        'events of a key press or timer tick; will check/move block accordingly
        Dim DOWN_WAY As Point = New Point(0, +1)
        Dim blockMovable As Boolean = isShadowBlockMovable(DOWN_WAY)
        If blockMovable Then
            shadowBlock.point.Offset(DOWN_WAY)
        Else
            Return False
        End If
        Return blockMovable
    End Function
    Private Function displayShadowBlock(ByVal showFlag As Boolean)
        If showShadow Then
            If showFlag Then showShadowBlock(shadowBlock, False)
            shadowBlock = currentBlock
            While moveShadowBlock()
            End While
            showShadowBlock(shadowBlock, True)
        End If
    End Function
    Private Function showShadowBlock(ByVal block As Block, ByVal showFlag As Boolean)
        'events after the moving of block that causes the display and changing of variables of button
        Dim num As Integer = 0
        For Each flag As Boolean In blocks(block.block)(block.roll)
            Dim point As Point = block.point + New Point(num Mod BLOCK_WIDE, num \ BLOCK_WIDE)
            If isInsidePoint(point) Then
                If flag Then
                    displayShadowButton(point, block.block, showFlag)
                End If
            End If
            num = num + 1
        Next
    End Function
    Private Function displayShadowButton(ByVal point As Point, ByVal block As Integer, ByVal showFlag As Boolean)
        'button.FlatStyle = FlatStyle.Flat
        'button.FlatAppearance.BorderColor = colors(block)
        Dim button As Button = gridButtons(point.X)(point.Y)
        button.Visible = showFlag
        If showFlag Then
            button.BackColor = Color.LightGray
            'button.FlatAppearance.BorderColor = colors(block)
        Else
            button.BackColor = Color.Black
            'button.FlatAppearance.BorderColor = Color.LightGray
        End If
    End Function
    Private Function isBlockMovable(ByVal offset As Point, ByVal rollFlag As Boolean, ByVal rollWay As Boolean) As Boolean
        'checks to see if the block can still move and/or which ways it can still turn
        Dim block As Block = currentBlock
        If rollFlag Then
            If rollWay Then
                block.roll = (block.roll + 1) Mod BLOCK_ROLL
            Else
                block.roll = (block.roll + BLOCK_ROLL - 1) Mod BLOCK_ROLL
            End If
        End If

        Dim blockShape As Rectangle = block.getBlockShape()
        Dim blockPoint As Point = block.point + offset
        blockShape.Offset(blockPoint)

        Dim blockMovable As Boolean = isInsideBlock(blockShape)
        If Not blockMovable Then Return blockMovable
        For x = blockShape.Left To blockShape.Left + blockShape.Width - 1
            For y = blockShape.Top To blockShape.Top + blockShape.Height - 1
                If isInsidePoint(New Point(x, y)) Then
                    If blocks(block.block)(block.roll)((y - blockPoint.Y) * BLOCK_WIDE + (x - blockPoint.X)) And gridBox(x)(y) Then
                        Return False
                    End If
                End If
            Next
        Next
        Return True
    End Function
    Private Function moveBlock(ByVal offset As Point, ByVal rollFlag As Boolean, ByVal rollWay As Boolean) As Boolean
        'events of a key press or timer tick; will check/move block accordingly
        Dim blockMovable As Boolean = isBlockMovable(offset, rollFlag, rollWay)
        numRows = 0
        If blockMovable Then
            eraseBlock()
            If rollFlag Then rollBlock(rollWay)
            currentBlock.point.Offset(offset)
            displayShadowBlock(True)
            displayBlock()
        Else
            Dim DOWN_WAY As Point = New Point(0, 1)
            If offset = DOWN_WAY Then
                addGridBlock(currentBlock)
                currentBlock = nextBlock
                displayShadowBlock(False)
                nextBlock = getNewBlock()
                displayNext()
                canHold = True
                intScore = intScore + 20
                numRows = 0
            End If
            moveGridRows()
            countScore()
            If isGameFailed() Then
                gameOver()
            End If
        End If
        Return blockMovable
    End Function
    Private Const LEVEL_UP As Integer = 10
    Private Const INT_CHANGE As Integer = 30
    Private gameLevel As Integer = 1
    Private Function countScore()
        If numRows = 1 Then
            intScore = intScore + 100
        ElseIf numRows = 2 Then
            intScore = intScore + 300
        ElseIf numRows = 3 Then
            intScore = intScore + 600
        ElseIf numRows = 4 Then
            intScore = intScore + 1000
        End If
        timerLines = timerLines + numRows
        If timerLines >= LEVEL_UP Then
            gameLevel = gameLevel + 1
            timerLines = 0
            If GameTimer.Interval - INT_CHANGE > 0 Then
                GameTimer.Interval = GameTimer.Interval - INT_CHANGE
            End If
        End If
        gameLines = gameLines + numRows
        lblScore.Text = "SCORE: " & intScore
        lblLines.Text = "LINES: " & gameLines
        lblLevel.Text = "LEVEL: " & gameLevel
    End Function
    Private gameEnd As Boolean = True
    Private Function gameOver()
        GameTimer.Stop()
        gameEnd = True
        pnlTetris.BackColor = Color.LightGray
        For x = 0 To GRID_X - 1
            For y = 0 To GRID_Y - 1
                gridButtons(x)(y).BackColor = Color.WhiteSmoke
                gridButtons(x)(y).FlatAppearance.BorderColor = Color.LightGray
            Next
        Next
        For x = 0 To NUM_GRID - 1
            holdButtons(x).BackColor = Color.WhiteSmoke
            holdButtons(x).FlatAppearance.BorderColor = Color.LightGray
            nextButtons(x).BackColor = Color.WhiteSmoke
            nextButtons(x).FlatAppearance.BorderColor = Color.LightGray
        Next
        lblGameOver.Visible = True
        lblGameOver.BringToFront()
        scoreRecorded = False
        pnlName.Visible = True
        pnlName.BringToFront()
        txtName.Text = "Anonymous"
    End Function
    Private Function copyButton(ByVal fromPoint As Point, ByVal toPoint As Point)
        'upon deletion of row, the rows on top must drop down, this allows the buttons that are currently visible to show up in the exact positions 'n' rows down
        gridButtons(toPoint.X)(toPoint.Y).Visible = gridButtons(fromPoint.X)(fromPoint.Y).Visible
        gridButtons(toPoint.X)(toPoint.Y).BackColor = gridButtons(fromPoint.X)(fromPoint.Y).BackColor
    End Function
    Private Function displayButton(ByVal point As Point, ByVal block As Integer, ByVal showFlag As Boolean)
        'allows the buttons to show up with the colors at the right locations according to shape of block
        Dim colors = New Color() {Color.Cyan, Color.Yellow, Color.Red, Color.Lime, Color.Orange, Color.Blue, Color.Purple, Color.DeepPink}

        'button.FlatStyle = FlatStyle.Flat
        'button.FlatAppearance.BorderColor = colors(block)
        Dim button As Button = gridButtons(point.X)(point.Y)
        button.Visible = showFlag
        If showFlag Then
            button.BackColor = colors(block)
            'button.FlatAppearance.BorderColor = colors(block)
        Else
            button.BackColor = Color.Black
            'button.FlatAppearance.BorderColor = Color.LightGray
        End If
    End Function
    Private Function displayNext()
        eraseNext()
        Dim colors = New Color() {Color.Cyan, Color.Yellow, Color.Red, Color.Lime, Color.Orange, Color.Blue, Color.Purple, Color.DeepPink}
        For x = 0 To NUM_GRID - 1
            If blocks(nextBlock.block)(nextBlock.roll)(x) Then
                nextButtons(x).BackColor = colors(nextBlock.block)
                nextButtons(x).Visible = True
            End If
        Next
    End Function
    Private Function eraseNext()
        For x = 0 To NUM_GRID - 1
            nextButtons(x).Visible = False
        Next
    End Function
    Private Function displayHold()
        eraseHold()
        Dim colors = New Color() {Color.Cyan, Color.Yellow, Color.Red, Color.Lime, Color.Orange, Color.Blue, Color.Purple, Color.DeepPink}
        For x = 0 To NUM_GRID - 1
            If blocks(holdBlock.block)(holdBlock.roll)(x) = True Then
                holdButtons(x).BackColor = colors(holdBlock.block)
                holdButtons(x).Visible = True
            End If
        Next
    End Function
    Private Function eraseHold()
        For x = 0 To NUM_GRID - 1
            holdButtons(x).Visible = False
        Next
    End Function
    Private Function showBlock(ByVal block As Block, ByVal showFlag As Boolean)
        'events after the moving of block that causes the display and changing of variables of button
        Dim num As Integer = 0
        For Each flag As Boolean In blocks(block.block)(block.roll)
            Dim point As Point = block.point + New Point(num Mod BLOCK_WIDE, num \ BLOCK_WIDE)
            If isInsidePoint(point) Then
                If flag Then
                    displayButton(point, block.block, showFlag)
                End If
            End If
            num = num + 1
        Next
    End Function
    Private Function displayBlock()
        'pretty useless but it is a function that brings us to another function
        showBlock(currentBlock, True)
    End Function
    Private Function eraseBlock()
        'another function that brings us to another function
        showBlock(currentBlock, False)
    End Function
    Private gridButtons()() As Button
    Private NUM_GRID As Integer = BLOCK_WIDE ^ 2
    Private nextButtons(NUM_GRID - 1) As Button
    Private holdButtons(NUM_GRID - 1) As Button
    Private Function createButtons() As Button()()
        'generates a whole form of invisible buttons
        gridButtons = New Button(GRID_X)() {}
        For x = 0 To GRID_X - 1
            gridButtons(x) = New Button(GRID_Y) {}
            For y = 0 To GRID_Y - 1
                gridButtons(x)(y) = New Button()
                gridButtons(x)(y).Width = GRID_SIZE - 1
                gridButtons(x)(y).Height = GRID_SIZE - 1
                gridButtons(x)(y).Location = New Point(x * (GRID_SIZE - 1), (y - BLOCK_WIDE) * (GRID_SIZE - 1))
                'gridButtons(x)(y).TabStop = False
                gridButtons(x)(y).Visible = False
                gridButtons(x)(y).FlatStyle = FlatStyle.Flat
                gridButtons(x)(y).Enabled = False
                'gridButtons(x)(y).FlatAppearance.BorderColor = Color.LightGray
                pnlTetris.Controls.Add(gridButtons(x)(y))
            Next
        Next
        Return gridButtons
    End Function
    Private Function createNextButtons() As Button()
        'generates a 4x4 grid of 16 buttons
        Dim LocationY As Integer
        For x = 0 To NUM_GRID - 1
            nextButtons(x) = New Button()
            nextButtons(x).Width = GRID_SIZE - 1
            nextButtons(x).Height = GRID_SIZE - 1
            If x Mod BLOCK_WIDE = 0 And x <> 0 Then
                LocationY = LocationY + 1
            End If
            nextButtons(x).Location = New Point((x Mod BLOCK_WIDE) * (GRID_SIZE - 1), LocationY * (GRID_SIZE - 1))
            nextButtons(x).TabStop = False
            nextButtons(x).Visible = False
            nextButtons(x).FlatStyle = FlatStyle.Flat
            pnlNext.Controls.Add(nextButtons(x))
        Next
        Return nextButtons
    End Function
    Private Function createHoldButtons() As Button()
        'generates a 4x4 grid of 16 buttons
        Dim LocationY As Integer
        For x = 0 To NUM_GRID - 1
            holdButtons(x) = New Button()
            holdButtons(x).Width = GRID_SIZE - 1
            holdButtons(x).Height = GRID_SIZE - 1
            If x Mod BLOCK_WIDE = 0 And x <> 0 Then
                LocationY = LocationY + 1
            End If
            holdButtons(x).Location = New Point((x Mod BLOCK_WIDE) * (GRID_SIZE - 1), LocationY * (GRID_SIZE - 1))
            holdButtons(x).TabStop = False
            holdButtons(x).Visible = False
            holdButtons(x).FlatStyle = FlatStyle.Flat
            pnlHold.Controls.Add(holdButtons(x))
        Next
        Return holdButtons
    End Function
    Private gridBox()() As Boolean
    Private Function getInitGrids() As Boolean()()
        'intitiates the variables
        gridBox = New Boolean(GRID_X - 1)() {}
        For x = 0 To GRID_X - 1
            gridBox(x) = New Boolean(GRID_Y) {}
            For y = 0 To GRID_Y - 1
                gridBox(x)(y) = False
            Next
        Next
        Return gridBox
    End Function
    Private Function moveGridRows()
        'clears a whole row if it is full
        Dim fullRowFlag As Boolean
        For row = 0 To GRID_Y - 1
            fullRowFlag = True
            For grid = 0 To GRID_X - 1
                If Not gridBox(grid)(row) Then
                    fullRowFlag = False
                    Exit For
                End If
            Next
            If fullRowFlag Then
                numRows = numRows + 1
                For y = row - 1 To 0 Step -1
                    For x = 0 To GRID_X - 1
                        gridBox(x)(y + 1) = gridBox(x)(y)
                        copyButton(New Point(x, y), New Point(x, y + 1))
                    Next
                Next
            End If
        Next
    End Function
    Private Const EMP_HOLD As Integer = 100
    Private Sub Tetris_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()
        gridButtons = createButtons()
        nextButtons = createNextButtons()
        holdButtons = createHoldButtons()
        playSound()
    End Sub
    Private gameStart As Boolean
    Private Function newGame()
        gridBox = getInitGrids()
        holdBlock.block = EMP_HOLD
        currentBlock = getNewBlock()
        nextBlock = getNewBlock()
        GameTimer.Interval = 400
        numRows = 0
        gameStart = True
        gameEnd = False
        gamePaused = False
        GameTimer.Start()
        pnlTetris.BackColor = Color.Pink
        lblGameOver.Visible = False
        lbl3.Visible = True
        pnlName.Visible = False

        intScore = 0
        gameLevel = 1
        gameLines = 0
        lblScore.Text = "SCORE: " & intScore
        lblLines.Text = "LINES: " & gameLines
        lblLevel.Text = "LEVEL: " & gameLevel
    End Function
    Private Sub GameTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GameTimer.Tick
        If lbl3.Visible = True Then
            lbl3.Visible = False
            lbl2.Visible = True
        ElseIf lbl2.Visible = True Then
            lbl2.Visible = False
            lbl1.Visible = True
        ElseIf lbl1.Visible = True Then
            lbl1.Visible = False
            lblGo.Visible = True
        ElseIf lblGo.Visible = True Then
            lblGo.Visible = False
            gameStart = False
            displayNext()
        Else
            Dim DOWN_WAY As Point = New Point(0, 1)
            moveBlock(DOWN_WAY, False, True)
        End If
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
        'handles the left, right, up, down, keys
        'copied and pasted from internet
        Dim DOWN_WAY As Point = New Point(0, +1)
        Dim LEFT_WAY As Point = New Point(-1, 0)
        Dim RIGHT_WAY As Point = New Point(+1, 0)
        Dim UP_WAY As Point = New Point(0, -1)
        Dim STAY_WAY As Point = New Point(0, 0)

        If scoreRecorded Then
            If Not leaderBoardOn Then
                If Not helpOn Then
                    If gamePaused Then
                        Select Case keyData
                            Case Keys.Space, Keys.P
                                unPauseGame()
                        End Select
                    Else
                        If My.Computer.Keyboard.ShiftKeyDown Then
                            If Not gameEnd Then holdFunction()
                        End If
                        Select Case keyData
                            'Case Keys.Up, Keys.NumPad8, Keys.I
                            '    moveBlock(UP_WAY, False)
                            '    Return True ' <-- If you want to suppress default handling of arrow keys
                            Case Keys.Right
                                If Not gameEnd Then moveBlock(RIGHT_WAY, False, False)
                                Return True ' <-- If you want to suppress default handling of arrow keys
                            Case Keys.Down
                                If Not gameEnd Then moveBlock(DOWN_WAY, False, False)
                                Return True ' <-- If you want to suppress default handling of arrow keys
                            Case Keys.Up, Keys.X
                                If Not gameEnd Then moveBlock(STAY_WAY, True, True)
                                Return True ' <-- If you want to suppress default handling of arrow keys
                            Case Keys.Z
                                If Not gameEnd Then moveBlock(STAY_WAY, True, False)
                            Case Keys.Left
                                If Not gameEnd Then moveBlock(LEFT_WAY, False, False)
                                Return True ' <-- If you want to suppress default handling of arrow keys
                            Case Keys.Back
                                If Not gameEnd Then gameCheat()
                            Case Keys.Space
                                If Not gameStart Then
                                    If gameEnd Then
                                        restartGame()
                                    Else
                                        While moveBlock(DOWN_WAY, False, False)
                                        End While
                                    End If
                                End If

                            Case Keys.P
                                pauseGame()
                        End Select
                    End If

                    Select Case keyData
                        Case Keys.R
                            If Not gameEnd And Not gameStart Then restartGame()
                        Case Keys.Escape, Keys.Q
                            Me.Close()
                        Case Keys.H
                            gameHelp(True)
                        Case Keys.L
                            leaderBoards(True)
                    End Select
                Else
                    Select Case keyData
                        Case Keys.H
                            gameHelp(False)
                    End Select
                End If
            Else
                Select Case keyData
                    Case Keys.L
                        leaderBoards(False)
                    Case Keys.F4
                        clearScore()
                End Select
            End If
            Select Case keyData
                Case Keys.S
                    playSound()
                Case Keys.Enter
                    If showShadow Then
                        showShadow = False

                        showShadowBlock(shadowBlock, False)
                    Else
                        showShadow = True
                        shadowBlock = currentBlock
                        showShadowBlock(shadowBlock, False)
                    End If
            End Select
        End If
    End Function
    Private leaderBoardOn As Boolean = False
    Private Function leaderBoards(ByVal openFlag As Boolean)
        If openFlag Then
            leaderBoardOn = True
            If Not gameEnd Then pauseGame()
            pnlHighScore.Visible = True
            displayHighScoreBL()
            displayHighScoreBS()
            pnlHighScore.BringToFront()
        Else
            pnlHighScore.Visible = False
            leaderBoardOn = False
            If Not gameEnd Then unPauseGame()
        End If
    End Function
    Private Function clearScore()
        If My.Computer.FileSystem.FileExists("Name.txt") = True Then
            My.Computer.FileSystem.DeleteFile("Name.txt")
            My.Computer.FileSystem.DeleteFile("Score.txt")
            My.Computer.FileSystem.DeleteFile("Lines.txt")
        End If

        lblHSScoreListBL.Text = ""
        lblHSLinesListBL.Text = ""
        lblHSNameListBL.Text = ""
        lblHSScoreListBS.Text = ""
        lblHSLinesListBS.Text = ""
        lblHSNameListBS.Text = ""

        For x = 0 To NUM_ON_HS - 1
            lblHSNameListBL.Text = lblHSNameListBL.Text & "--" & vbCrLf
            lblHSScoreListBL.Text = lblHSScoreListBL.Text & "--" & vbCrLf
            lblHSLinesListBL.Text = lblHSLinesListBL.Text & "--" & vbCrLf
            lblHSNameListBS.Text = lblHSNameListBS.Text & "--" & vbCrLf
            lblHSScoreListBS.Text = lblHSScoreListBS.Text & "--" & vbCrLf
            lblHSLinesListBS.Text = lblHSLinesListBS.Text & "--" & vbCrLf
        Next
    End Function
    Private soundOn As Boolean = False
    Private Function playSound()
        If soundOn Then
            My.Computer.Audio.Stop()
            soundOn = False
        Else

            My.Computer.Audio.Play("Tetris.wav")
            soundOn = True
        End If
    End Function
    Private Function holdFunction()
        If canHold Then
            canHold = False
            eraseBlock()
            If holdBlock.block = EMP_HOLD Then
                holdBlock = currentBlock
                currentBlock = nextBlock
                nextBlock = getNewBlock()
                displayHold()
                displayNext()
                holdBlock.point.Y = 0
            Else
                Dim tempBlock As Block
                tempBlock = currentBlock
                currentBlock = holdBlock
                holdBlock = tempBlock
                displayHold()
                displayNext()
                holdBlock.point.Y = 0
            End If
        End If
    End Function
    Private Function restartGame()
        For x = 0 To GRID_X - 1
            For y = 0 To GRID_Y - 1
                gridButtons(x)(y).Visible = False
                gridButtons(x)(y).FlatAppearance.BorderColor = Color.Black
            Next
        Next
        For x = 0 To NUM_GRID - 1
            holdButtons(x).FlatAppearance.BorderColor = Color.Black
            nextButtons(x).FlatAppearance.BorderColor = Color.Black
        Next
        If lblStart.Visible = True Then lblStart.Visible = False
        eraseHold()
        eraseNext()
        newGame()
    End Function
    Private pauseButtons()() As Button
    Private gamePaused As Boolean
    Private Function pauseGame()
        pauseButtons = createPauseButtons()
        GameTimer.Stop()
        pnlTetris.BackColor = Color.LightGray
        For x = 0 To GRID_X - 1
            For y = 0 To GRID_Y - 1
                If gridBox(x)(y) Then
                    pauseButtons(x)(y).Visible = True
                    pauseButtons(x)(y).BackColor = Color.WhiteSmoke
                    pauseButtons(x)(y).FlatAppearance.BorderColor = Color.LightGray
                End If
            Next
        Next
        showPausedBlock(currentBlock)
        lblPause.Visible = True
        lblPause.BringToFront()
        gamePaused = True
        showShadowBlock(shadowBlock, False)
    End Function
    Private Function unPauseGame()
        GameTimer.Start()
        gamePaused = False
        For x = 0 To GRID_X - 1
            For y = 0 To GRID_Y - 1
                pnlTetris.Controls.Remove(pauseButtons(x)(y))
            Next
        Next
        pnlTetris.BackColor = Color.Pink
        lblPause.Visible = False
    End Function
    Private Function createPauseButtons() As Button()()
        'generates a whole form of invisible buttons
        pauseButtons = New Button(GRID_X)() {}
        For x = 0 To GRID_X - 1
            pauseButtons(x) = New Button(GRID_Y) {}
            For y = 0 To GRID_Y - 1
                pauseButtons(x)(y) = New Button()
                pauseButtons(x)(y).Width = GRID_SIZE - 1
                pauseButtons(x)(y).Height = GRID_SIZE - 1
                pauseButtons(x)(y).Location = New Point(x * (GRID_SIZE - 1), (y - BLOCK_WIDE) * (GRID_SIZE - 1))
                pauseButtons(x)(y).Visible = False
                pauseButtons(x)(y).FlatStyle = FlatStyle.Flat
                pauseButtons(x)(y).Enabled = False
                'pausebuttons(x)(y).FlatAppearance.BorderColor = Color.LightGray
                pnlTetris.Controls.Add(pauseButtons(x)(y))
                pauseButtons(x)(y).BringToFront()
            Next
        Next
        Return pauseButtons
    End Function
    Private Function showPausedBlock(ByVal block As Block)
        'events after the moving of block that causes the display and changing of variables of button
        Dim num As Integer = 0
        For Each flag As Boolean In blocks(block.block)(block.roll)
            Dim point As Point = block.point + New Point(num Mod BLOCK_WIDE, num \ BLOCK_WIDE)
            If isInsidePoint(point) Then
                If flag Then
                    displayPausedButton(point, block.block)
                End If
            End If
            num = num + 1
        Next
    End Function
    Private Function displayPausedButton(ByVal point As Point, ByVal block As Integer)
        Dim button As Button = pauseButtons(point.X)(point.Y)
        button.Visible = True
        button.BackColor = Color.WhiteSmoke
        button.FlatAppearance.BorderColor = Color.LightGray
    End Function
    Private Function recordScore(ByVal intScore As Integer, ByVal intLines As Integer, ByVal intLevel As Integer, ByVal strName As String)
        Dim writerScore As System.IO.StreamWriter
        Dim writerName As System.IO.StreamWriter
        Dim writerLines As System.IO.StreamWriter
        writerScore = My.Computer.FileSystem.OpenTextFileWriter("Score.txt", True)
        writerName = My.Computer.FileSystem.OpenTextFileWriter("Name.txt", True)
        writerLines = My.Computer.FileSystem.OpenTextFileWriter("Lines.txt", True)
        writerScore.WriteLine(intScore)
        writerName.WriteLine(strName)
        writerLines.WriteLine(intLines)
        writerScore.Close()
        writerName.Close()
        writerLines.Close()
    End Function
    Private Const NUM_ON_HS As Integer = 10
    Private Function displayHighScoreBS()

        If My.Computer.FileSystem.FileExists("Score.txt") = True Then

            Dim readerScore As System.IO.StreamReader
            Dim readerName As System.IO.StreamReader
            Dim readerLines As System.IO.StreamReader

            lblHSScoreListBS.Text = ""
            lblHSLinesListBS.Text = ""
            lblHSNameListBS.Text = ""

            Dim numLines As Integer
            Dim numLinesReader As System.IO.StreamReader = New System.IO.StreamReader("Name.txt")
            Do Until numLinesReader.ReadLine Is Nothing
                numLines = numLines + 1
            Loop
            numLinesReader.Close()


            'if file exists, load it onto the textbox
            readerScore = My.Computer.FileSystem.OpenTextFileReader("Score.txt")
            readerName = My.Computer.FileSystem.OpenTextFileReader("Name.txt")
            readerLines = My.Computer.FileSystem.OpenTextFileReader("Lines.txt")

            Dim tempScore(numLines - 1) As Integer

            Dim HSScore(numLines - 1) As Integer
            Dim HSLines(numLines - 1) As Integer
            Dim HSNames(numLines - 1) As String

            For x = 0 To numLines - 1
                tempScore(x) = readerScore.ReadLine

                HSScore(x) = tempScore(x)
                HSLines(x) = readerLines.ReadLine
                HSNames(x) = readerName.ReadLine
            Next

            For x = 0 To numLines - 1
                If Len(HSNames(x)) > 8 Then
                    HSNames(x) = Mid(HSNames(x), 1, 7) & ".."
                End If
            Next

            Array.Sort(tempScore)
            Array.Reverse(tempScore)

            Dim numCheck As Integer = NUM_ON_HS
            If numLines < NUM_ON_HS Then
                numCheck = numLines
            End If

            For x = 0 To numCheck - 1
                Dim continueFlag As Boolean = True
                For y = 0 To numLines - 1
                    If tempScore(x) = HSScore(y) Then
                        If continueFlag Then
                            lblHSNameListBS.Text = lblHSNameListBS.Text & HSNames(y) & vbCrLf
                            lblHSScoreListBS.Text = lblHSScoreListBS.Text & HSScore(y) & vbCrLf
                            lblHSLinesListBS.Text = lblHSLinesListBS.Text & HSLines(y) & vbCrLf
                            HSScore(y) = -1
                            continueFlag = False
                        End If
                    End If
                Next
            Next
            If numLines < NUM_ON_HS Then
                For x = numLines To NUM_ON_HS - 1
                    lblHSNameListBS.Text = lblHSNameListBS.Text & "--" & vbCrLf
                    lblHSScoreListBS.Text = lblHSScoreListBS.Text & "--" & vbCrLf
                    lblHSLinesListBS.Text = lblHSLinesListBS.Text & "--" & vbCrLf
                Next
            End If
            readerScore.Close()
            readerName.Close()
            readerLines.Close()
        End If
    End Function
    Private Function displayHighScoreBL()

        If My.Computer.FileSystem.FileExists("Score.txt") = True Then

            Dim readerScore As System.IO.StreamReader
            Dim readerName As System.IO.StreamReader
            Dim readerLines As System.IO.StreamReader

            lblHSScoreListBL.Text = ""
            lblHSLinesListBL.Text = ""
            lblHSNameListBL.Text = ""

            Dim numLines As Integer
            Dim numLinesReader As System.IO.StreamReader = New System.IO.StreamReader("Name.txt")
            Do Until numLinesReader.ReadLine Is Nothing
                numLines = numLines + 1
            Loop
            numLinesReader.Close()

            'if file exists, load it onto the textbox
            readerScore = My.Computer.FileSystem.OpenTextFileReader("Score.txt")
            readerName = My.Computer.FileSystem.OpenTextFileReader("Name.txt")
            readerLines = My.Computer.FileSystem.OpenTextFileReader("Lines.txt")

            Dim tempLines(numLines - 1) As Integer

            Dim HSScore(numLines - 1) As Integer
            Dim HSLines(numLines - 1) As Integer
            Dim HSNames(numLines - 1) As String

            For x = 0 To numLines - 1
                tempLines(x) = readerLines.ReadLine

                HSScore(x) = readerScore.ReadLine
                HSLines(x) = tempLines(x)
                HSNames(x) = readerName.ReadLine
            Next

            For x = 0 To numLines - 1
                If Len(HSNames(x)) > 8 Then
                    HSNames(x) = Mid(HSNames(x), 1, 7) & ".."
                End If
            Next
            Array.Sort(tempLines)
            Array.Reverse(tempLines)

            Dim numCheck As Integer = NUM_ON_HS
            If numLines < NUM_ON_HS Then
                numCheck = numLines
            End If
            For x = 0 To numCheck - 1
                Dim continueFlag As Boolean = True
                For y = 0 To numLines - 1
                    If tempLines(x) = HSLines(y) Then
                        If continueFlag Then
                            lblHSNameListBL.Text = lblHSNameListBL.Text & HSNames(y) & vbCrLf
                            lblHSScoreListBL.Text = lblHSScoreListBL.Text & HSScore(y) & vbCrLf
                            lblHSLinesListBL.Text = lblHSLinesListBL.Text & HSLines(y) & vbCrLf
                            HSLines(y) = -1
                            continueFlag = False
                        End If
                    End If
                Next
            Next
            If numLines < NUM_ON_HS Then
                For x = numLines To NUM_ON_HS - 1
                    lblHSNameListBL.Text = lblHSNameListBL.Text & "--" & vbCrLf
                    lblHSScoreListBL.Text = lblHSScoreListBL.Text & "--" & vbCrLf
                    lblHSLinesListBL.Text = lblHSLinesListBL.Text & "--" & vbCrLf
                Next
            End If
            readerScore.Close()
            readerName.Close()
            readerLines.Close()
        End If
    End Function
    Private scoreRecorded As Boolean = True
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        recordScore(intScore, gameLines, gameLevel, txtName.Text)
        pnlName.Visible = False
        scoreRecorded = True
    End Sub
    Private helpOn As Boolean = False
    Private Function gameHelp(ByVal openFlag As Boolean)
        If openFlag Then
            helpOn = True
            If Not gameEnd Then pauseGame()
            pnlHelp.Visible = True
            pnlHelp.BringToFront()
        Else
            pnlHelp.Visible = False
            helpOn = False
            If Not gameEnd Then unPauseGame()
        End If
    End Function
    Private Function gameCheat()
        pauseGame()
        Dim cheatWord As String = InputBox("Enter cheat:")
        If cheatWord = "increase score" Then
            intScore = intScore + 1000
            lblScore.Text = "SCORE: " & intScore
        ElseIf cheatWord = "increase lines" Then
            gameLines = gameLines + 10
            lblLines.Text = "LINES: " & gameLines
        ElseIf cheatWord = "slow down" Then
            GameTimer.Interval = GameTimer.Interval + INT_CHANGE
        ElseIf cheatWord = "speed up" Then
            If GameTimer.Interval - INT_CHANGE > 0 Then GameTimer.Interval = GameTimer.Interval - INT_CHANGE
        End If
        unPauseGame()
    End Function
End Class

