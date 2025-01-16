<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        white_btn = New Button()
        PictureBox1 = New PictureBox()
        timer_label = New Label()
        color_panel = New Panel()
        startPanel = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        startButton = New Button()
        instructionsLabel = New Label()
        red_btn = New Button()
        black_btn = New Button()
        blue_btn = New Button()
        brown_btn = New Button()
        purple_btn = New Button()
        orange_btn = New Button()
        green_btn = New Button()
        yellow_btn = New Button()
        gray_btn = New Button()
        gameTimer = New Timer(components)
        score_label = New Label()
        life1 = New PictureBox()
        life2 = New PictureBox()
        life3 = New PictureBox()
        restart_btn = New Button()
        exit_btn = New Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        startPanel.SuspendLayout()
        CType(life1, ComponentModel.ISupportInitialize).BeginInit()
        CType(life2, ComponentModel.ISupportInitialize).BeginInit()
        CType(life3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' white_btn
        ' 
        white_btn.BackColor = Color.Blue
        white_btn.FlatStyle = FlatStyle.Flat
        white_btn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        white_btn.ForeColor = SystemColors.Control
        white_btn.Location = New Point(28, 313)
        white_btn.Name = "white_btn"
        white_btn.Size = New Size(95, 46)
        white_btn.TabIndex = 0
        white_btn.Text = "white"
        white_btn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources._3671881_timer_icon
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(5, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 40)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' timer_label
        ' 
        timer_label.AutoSize = True
        timer_label.BackColor = Color.Transparent
        timer_label.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        timer_label.Location = New Point(46, 12)
        timer_label.Name = "timer_label"
        timer_label.Size = New Size(65, 25)
        timer_label.TabIndex = 2
        timer_label.Text = "0:00"
        ' 
        ' color_panel
        ' 
        color_panel.BackColor = Color.White
        color_panel.Location = New Point(28, 53)
        color_panel.Name = "color_panel"
        color_panel.Size = New Size(534, 241)
        color_panel.TabIndex = 5
        ' 
        ' startPanel
        ' 
        startPanel.BackColor = Color.White
        startPanel.BackgroundImage = My.Resources.Resources.Pastel_Watercolor_Texture_Background_edit_online_21
        startPanel.Controls.Add(Label5)
        startPanel.Controls.Add(Label4)
        startPanel.Controls.Add(Label3)
        startPanel.Controls.Add(Label2)
        startPanel.Controls.Add(startButton)
        startPanel.Controls.Add(instructionsLabel)
        startPanel.Dock = DockStyle.Fill
        startPanel.Location = New Point(0, 0)
        startPanel.Name = "startPanel"
        startPanel.Size = New Size(767, 452)
        startPanel.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(211, 378)
        Label5.Name = "Label5"
        Label5.Size = New Size(333, 23)
        Label5.TabIndex = 6
        Label5.Text = "4. Time is limited, so act fast!"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(180, 313)
        Label4.Name = "Label4"
        Label4.Size = New Size(396, 23)
        Label4.TabIndex = 5
        Label4.Text = "3. Score points for correct answers!"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(126, 163)
        Label3.Name = "Label3"
        Label3.Size = New Size(495, 23)
        Label3.TabIndex = 4
        Label3.Text = "2. Choose the correct name from the options"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(158, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(433, 23)
        Label2.TabIndex = 3
        Label2.Text = "1. A color will be shown on the screen."
        ' 
        ' startButton
        ' 
        startButton.Location = New Point(305, 219)
        startButton.Name = "startButton"
        startButton.Size = New Size(137, 45)
        startButton.TabIndex = 2
        startButton.Text = "Start Game"
        startButton.UseVisualStyleBackColor = True
        ' 
        ' instructionsLabel
        ' 
        instructionsLabel.AutoSize = True
        instructionsLabel.BackColor = Color.Transparent
        instructionsLabel.Font = New Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        instructionsLabel.ForeColor = Color.Black
        instructionsLabel.Location = New Point(90, 32)
        instructionsLabel.Name = "instructionsLabel"
        instructionsLabel.Size = New Size(594, 32)
        instructionsLabel.TabIndex = 1
        instructionsLabel.Text = "Welcome to the Color Matching Game!"
        ' 
        ' red_btn
        ' 
        red_btn.BackColor = SystemColors.Control
        red_btn.FlatStyle = FlatStyle.Flat
        red_btn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        red_btn.ForeColor = Color.Black
        red_btn.Location = New Point(28, 378)
        red_btn.Name = "red_btn"
        red_btn.Size = New Size(95, 46)
        red_btn.TabIndex = 6
        red_btn.Text = "red"
        red_btn.UseVisualStyleBackColor = False
        ' 
        ' black_btn
        ' 
        black_btn.BackColor = Color.Brown
        black_btn.FlatStyle = FlatStyle.Flat
        black_btn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        black_btn.ForeColor = SystemColors.Control
        black_btn.Location = New Point(250, 378)
        black_btn.Name = "black_btn"
        black_btn.Size = New Size(95, 46)
        black_btn.TabIndex = 10
        black_btn.Text = "black"
        black_btn.UseVisualStyleBackColor = False
        ' 
        ' blue_btn
        ' 
        blue_btn.BackColor = Color.Green
        blue_btn.FlatStyle = FlatStyle.Flat
        blue_btn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        blue_btn.ForeColor = SystemColors.Control
        blue_btn.Location = New Point(467, 313)
        blue_btn.Name = "blue_btn"
        blue_btn.Size = New Size(95, 46)
        blue_btn.TabIndex = 13
        blue_btn.Text = "blue"
        blue_btn.UseVisualStyleBackColor = False
        ' 
        ' brown_btn
        ' 
        brown_btn.BackColor = Color.Gray
        brown_btn.FlatStyle = FlatStyle.Flat
        brown_btn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        brown_btn.ForeColor = SystemColors.Control
        brown_btn.Location = New Point(467, 378)
        brown_btn.Name = "brown_btn"
        brown_btn.Size = New Size(95, 46)
        brown_btn.TabIndex = 14
        brown_btn.Text = "brown"
        brown_btn.UseVisualStyleBackColor = False
        ' 
        ' purple_btn
        ' 
        purple_btn.BackColor = Color.Purple
        purple_btn.FlatStyle = FlatStyle.Flat
        purple_btn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        purple_btn.ForeColor = SystemColors.Control
        purple_btn.Location = New Point(359, 313)
        purple_btn.Name = "purple_btn"
        purple_btn.Size = New Size(95, 46)
        purple_btn.TabIndex = 11
        purple_btn.Text = "purple"
        purple_btn.UseVisualStyleBackColor = False
        ' 
        ' orange_btn
        ' 
        orange_btn.BackColor = Color.Red
        orange_btn.FlatStyle = FlatStyle.Flat
        orange_btn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        orange_btn.ForeColor = SystemColors.Control
        orange_btn.Location = New Point(359, 378)
        orange_btn.Name = "orange_btn"
        orange_btn.Size = New Size(95, 46)
        orange_btn.TabIndex = 12
        orange_btn.Text = "orange"
        orange_btn.UseVisualStyleBackColor = False
        ' 
        ' green_btn
        ' 
        green_btn.BackColor = Color.Yellow
        green_btn.FlatStyle = FlatStyle.Flat
        green_btn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        green_btn.ForeColor = Color.Black
        green_btn.Location = New Point(250, 313)
        green_btn.Name = "green_btn"
        green_btn.Size = New Size(95, 46)
        green_btn.TabIndex = 9
        green_btn.Text = "green"
        green_btn.UseVisualStyleBackColor = False
        ' 
        ' yellow_btn
        ' 
        yellow_btn.BackColor = Color.Black
        yellow_btn.FlatStyle = FlatStyle.Flat
        yellow_btn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        yellow_btn.ForeColor = SystemColors.Control
        yellow_btn.Location = New Point(139, 313)
        yellow_btn.Name = "yellow_btn"
        yellow_btn.Size = New Size(95, 46)
        yellow_btn.TabIndex = 8
        yellow_btn.Text = "yellow"
        yellow_btn.UseVisualStyleBackColor = False
        ' 
        ' gray_btn
        ' 
        gray_btn.BackColor = Color.Orange
        gray_btn.FlatStyle = FlatStyle.Flat
        gray_btn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        gray_btn.ForeColor = SystemColors.Control
        gray_btn.Location = New Point(139, 378)
        gray_btn.Name = "gray_btn"
        gray_btn.Size = New Size(95, 46)
        gray_btn.TabIndex = 7
        gray_btn.Text = "gray"
        gray_btn.UseVisualStyleBackColor = False
        ' 
        ' gameTimer
        ' 
        gameTimer.Interval = 1000
        ' 
        ' score_label
        ' 
        score_label.AutoSize = True
        score_label.BackColor = Color.Transparent
        score_label.Font = New Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        score_label.Location = New Point(733, 6)
        score_label.Name = "score_label"
        score_label.Size = New Size(27, 25)
        score_label.TabIndex = 17
        score_label.Text = "0"
        ' 
        ' life1
        ' 
        life1.BackColor = Color.Transparent
        life1.BackgroundImage = My.Resources.Resources.heart__1_
        life1.BackgroundImageLayout = ImageLayout.Zoom
        life1.Location = New Point(307, 12)
        life1.Name = "life1"
        life1.Size = New Size(38, 32)
        life1.TabIndex = 18
        life1.TabStop = False
        ' 
        ' life2
        ' 
        life2.BackColor = Color.Transparent
        life2.BackgroundImage = My.Resources.Resources.heart__1_
        life2.BackgroundImageLayout = ImageLayout.Zoom
        life2.Location = New Point(351, 12)
        life2.Name = "life2"
        life2.Size = New Size(38, 32)
        life2.TabIndex = 19
        life2.TabStop = False
        ' 
        ' life3
        ' 
        life3.BackColor = Color.Transparent
        life3.BackgroundImage = My.Resources.Resources.heart__1_
        life3.BackgroundImageLayout = ImageLayout.Zoom
        life3.Location = New Point(395, 12)
        life3.Name = "life3"
        life3.Size = New Size(38, 32)
        life3.TabIndex = 20
        life3.TabStop = False
        ' 
        ' restart_btn
        ' 
        restart_btn.BackColor = SystemColors.Control
        restart_btn.FlatStyle = FlatStyle.Flat
        restart_btn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        restart_btn.ForeColor = Color.Black
        restart_btn.Location = New Point(582, 335)
        restart_btn.Name = "restart_btn"
        restart_btn.Size = New Size(157, 35)
        restart_btn.TabIndex = 21
        restart_btn.Text = "Restart"
        restart_btn.UseVisualStyleBackColor = False
        ' 
        ' exit_btn
        ' 
        exit_btn.BackColor = SystemColors.Control
        exit_btn.FlatStyle = FlatStyle.Flat
        exit_btn.Font = New Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        exit_btn.ForeColor = Color.Black
        exit_btn.Location = New Point(582, 389)
        exit_btn.Name = "exit_btn"
        exit_btn.Size = New Size(157, 35)
        exit_btn.TabIndex = 22
        exit_btn.Text = "Exit"
        exit_btn.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(579, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 16)
        Label1.TabIndex = 23
        Label1.Text = "Scores:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2})
        DataGridView1.Location = New Point(582, 75)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.Size = New Size(177, 242)
        DataGridView1.TabIndex = 24
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "Attempt No."
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 107
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "Score"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 67
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLight
        BackgroundImage = My.Resources.Resources.Pastel_Watercolor_Texture_Background_edit_online_22
        ClientSize = New Size(767, 452)
        Controls.Add(startPanel)
        Controls.Add(Label1)
        Controls.Add(life3)
        Controls.Add(life2)
        Controls.Add(life1)
        Controls.Add(blue_btn)
        Controls.Add(yellow_btn)
        Controls.Add(brown_btn)
        Controls.Add(orange_btn)
        Controls.Add(purple_btn)
        Controls.Add(black_btn)
        Controls.Add(green_btn)
        Controls.Add(gray_btn)
        Controls.Add(red_btn)
        Controls.Add(color_panel)
        Controls.Add(timer_label)
        Controls.Add(PictureBox1)
        Controls.Add(white_btn)
        Controls.Add(score_label)
        Controls.Add(exit_btn)
        Controls.Add(restart_btn)
        Controls.Add(DataGridView1)
        Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "COLOR MATCHING GAME"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        startPanel.ResumeLayout(False)
        startPanel.PerformLayout()
        CType(life1, ComponentModel.ISupportInitialize).EndInit()
        CType(life2, ComponentModel.ISupportInitialize).EndInit()
        CType(life3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents white_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents timer_label As Label
    Friend WithEvents color_panel As Panel
    Friend WithEvents red_btn As Button
    Friend WithEvents black_btn As Button
    Friend WithEvents blue_btn As Button
    Friend WithEvents brown_btn As Button
    Friend WithEvents purple_btn As Button
    Friend WithEvents orange_btn As Button
    Friend WithEvents green_btn As Button
    Friend WithEvents yellow_btn As Button
    Friend WithEvents gray_btn As Button
    Friend WithEvents startPanel As Panel
    Friend WithEvents instructionsLabel As Label
    Friend WithEvents startButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents gameTimer As Timer
    Friend WithEvents score_label As Label
    Friend WithEvents life1 As PictureBox
    Friend WithEvents life2 As PictureBox
    Friend WithEvents life3 As PictureBox
    Friend WithEvents restart_btn As Button
    Friend WithEvents exit_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn

End Class
