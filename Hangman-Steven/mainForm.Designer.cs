namespace Hangman_Steven
{
    partial class Hangman
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hangman));
            this.mainScreen = new System.Windows.Forms.RichTextBox();
            this.timeBar = new System.Windows.Forms.ProgressBar();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.tmpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.arrowLabel = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.ConfigureButton = new System.Windows.Forms.Button();
            this.lineLabel2 = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            this.lineLabel1 = new System.Windows.Forms.Label();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.verticalLine = new System.Windows.Forms.Label();
            this.chooseSentence = new System.Windows.Forms.NumericUpDown();
            this.buttonZ = new System.Windows.Forms.Button();
            this.buttonY = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonW = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonU = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.buttonQ = new System.Windows.Forms.Button();
            this.buttonP = new System.Windows.Forms.Button();
            this.buttonO = new System.Windows.Forms.Button();
            this.buttonN = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonK = new System.Windows.Forms.Button();
            this.buttonJ = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonF = new System.Windows.Forms.Button();
            this.buttonE = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonB = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.TeamScore4 = new System.Windows.Forms.Label();
            this.TeamScore3 = new System.Windows.Forms.Label();
            this.TeamScore2 = new System.Windows.Forms.Label();
            this.TeamScore1 = new System.Windows.Forms.Label();
            this.TeamLabel4 = new System.Windows.Forms.Label();
            this.TeamLabel3 = new System.Windows.Forms.Label();
            this.TeamLabel2 = new System.Windows.Forms.Label();
            this.TeamLabel1 = new System.Windows.Forms.Label();
            this.barTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmpPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseSentence)).BeginInit();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainScreen
            // 
            this.mainScreen.Font = new System.Drawing.Font("Consolas", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mainScreen.Location = new System.Drawing.Point(21, 12);
            this.mainScreen.Name = "mainScreen";
            this.mainScreen.ReadOnly = true;
            this.mainScreen.Size = new System.Drawing.Size(600, 96);
            this.mainScreen.TabIndex = 0;
            this.mainScreen.Tag = "";
            this.mainScreen.Text = resources.GetString("mainScreen.Text");
            this.mainScreen.TextChanged += new System.EventHandler(this.mainScreen_TextChanged);
            this.mainScreen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // timeBar
            // 
            this.timeBar.Location = new System.Drawing.Point(21, 114);
            this.timeBar.Name = "timeBar";
            this.timeBar.Size = new System.Drawing.Size(311, 23);
            this.timeBar.TabIndex = 1;
            this.timeBar.Click += new System.EventHandler(this.timeBar_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.tmpPlayer);
            this.buttonPanel.Controls.Add(this.arrowLabel);
            this.buttonPanel.Controls.Add(this.axWindowsMediaPlayer);
            this.buttonPanel.Controls.Add(this.ConfigureButton);
            this.buttonPanel.Controls.Add(this.lineLabel2);
            this.buttonPanel.Controls.Add(this.startGameButton);
            this.buttonPanel.Controls.Add(this.lineLabel1);
            this.buttonPanel.Controls.Add(this.chooseLabel);
            this.buttonPanel.Controls.Add(this.verticalLine);
            this.buttonPanel.Controls.Add(this.chooseSentence);
            this.buttonPanel.Controls.Add(this.buttonZ);
            this.buttonPanel.Controls.Add(this.buttonY);
            this.buttonPanel.Controls.Add(this.buttonX);
            this.buttonPanel.Controls.Add(this.buttonW);
            this.buttonPanel.Controls.Add(this.buttonV);
            this.buttonPanel.Controls.Add(this.buttonU);
            this.buttonPanel.Controls.Add(this.buttonT);
            this.buttonPanel.Controls.Add(this.buttonS);
            this.buttonPanel.Controls.Add(this.buttonR);
            this.buttonPanel.Controls.Add(this.buttonQ);
            this.buttonPanel.Controls.Add(this.buttonP);
            this.buttonPanel.Controls.Add(this.buttonO);
            this.buttonPanel.Controls.Add(this.buttonN);
            this.buttonPanel.Controls.Add(this.buttonM);
            this.buttonPanel.Controls.Add(this.buttonL);
            this.buttonPanel.Controls.Add(this.buttonK);
            this.buttonPanel.Controls.Add(this.buttonJ);
            this.buttonPanel.Controls.Add(this.buttonI);
            this.buttonPanel.Controls.Add(this.buttonH);
            this.buttonPanel.Controls.Add(this.buttonG);
            this.buttonPanel.Controls.Add(this.buttonF);
            this.buttonPanel.Controls.Add(this.buttonE);
            this.buttonPanel.Controls.Add(this.buttonD);
            this.buttonPanel.Controls.Add(this.buttonC);
            this.buttonPanel.Controls.Add(this.buttonB);
            this.buttonPanel.Controls.Add(this.buttonA);
            this.buttonPanel.Font = new System.Drawing.Font("Consolas", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPanel.Location = new System.Drawing.Point(12, 143);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(743, 318);
            this.buttonPanel.TabIndex = 2;
            this.buttonPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonPanel_Paint);
            // 
            // tmpPlayer
            // 
            this.tmpPlayer.Enabled = true;
            this.tmpPlayer.Location = new System.Drawing.Point(422, 193);
            this.tmpPlayer.Name = "tmpPlayer";
            this.tmpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tmpPlayer.OcxState")));
            this.tmpPlayer.Size = new System.Drawing.Size(75, 23);
            this.tmpPlayer.TabIndex = 46;
            this.tmpPlayer.Visible = false;
            // 
            // arrowLabel
            // 
            this.arrowLabel.AutoSize = true;
            this.arrowLabel.BackColor = System.Drawing.SystemColors.Control;
            this.arrowLabel.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.arrowLabel.ForeColor = System.Drawing.Color.Red;
            this.arrowLabel.Location = new System.Drawing.Point(684, 40);
            this.arrowLabel.Name = "arrowLabel";
            this.arrowLabel.Size = new System.Drawing.Size(42, 27);
            this.arrowLabel.TabIndex = 43;
            this.arrowLabel.Text = "->";
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(565, 158);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(148, 102);
            this.axWindowsMediaPlayer.TabIndex = 45;
            this.axWindowsMediaPlayer.Visible = false;
            this.axWindowsMediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer_Enter);
            // 
            // ConfigureButton
            // 
            this.ConfigureButton.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfigureButton.Location = new System.Drawing.Point(430, 244);
            this.ConfigureButton.Name = "ConfigureButton";
            this.ConfigureButton.Size = new System.Drawing.Size(129, 37);
            this.ConfigureButton.TabIndex = 44;
            this.ConfigureButton.Text = "Configure";
            this.ConfigureButton.UseVisualStyleBackColor = true;
            this.ConfigureButton.Click += new System.EventHandler(this.ConfigureButton_Click);
            // 
            // lineLabel2
            // 
            this.lineLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineLabel2.Location = new System.Drawing.Point(378, 216);
            this.lineLabel2.Name = "lineLabel2";
            this.lineLabel2.Size = new System.Drawing.Size(348, 2);
            this.lineLabel2.TabIndex = 41;
            this.lineLabel2.Text = "label4";
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startGameButton.Location = new System.Drawing.Point(444, 111);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(187, 44);
            this.startGameButton.TabIndex = 43;
            this.startGameButton.Text = "StartGame";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // lineLabel1
            // 
            this.lineLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineLabel1.Location = new System.Drawing.Point(197, 158);
            this.lineLabel1.Name = "lineLabel1";
            this.lineLabel1.Size = new System.Drawing.Size(348, 2);
            this.lineLabel1.TabIndex = 42;
            this.lineLabel1.Text = "label2";
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseLabel.Location = new System.Drawing.Point(439, 19);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(147, 27);
            this.chooseLabel.TabIndex = 41;
            this.chooseLabel.Text = "Sentence:";
            // 
            // verticalLine
            // 
            this.verticalLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.verticalLine.Location = new System.Drawing.Point(370, 5);
            this.verticalLine.Name = "verticalLine";
            this.verticalLine.Size = new System.Drawing.Size(2, 308);
            this.verticalLine.TabIndex = 40;
            this.verticalLine.Text = "label3";
            this.verticalLine.Click += new System.EventHandler(this.verticalLine_Click);
            // 
            // chooseSentence
            // 
            this.chooseSentence.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chooseSentence.Location = new System.Drawing.Point(522, 38);
            this.chooseSentence.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.chooseSentence.Name = "chooseSentence";
            this.chooseSentence.Size = new System.Drawing.Size(87, 39);
            this.chooseSentence.TabIndex = 26;
            this.chooseSentence.ValueChanged += new System.EventHandler(this.chooseSentence_ValueChanged);
            // 
            // buttonZ
            // 
            this.buttonZ.Location = new System.Drawing.Point(306, 201);
            this.buttonZ.Name = "buttonZ";
            this.buttonZ.Size = new System.Drawing.Size(36, 19);
            this.buttonZ.TabIndex = 25;
            this.buttonZ.Text = "Z";
            this.buttonZ.UseVisualStyleBackColor = true;
            this.buttonZ.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonZ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonY
            // 
            this.buttonY.Location = new System.Drawing.Point(245, 201);
            this.buttonY.Name = "buttonY";
            this.buttonY.Size = new System.Drawing.Size(36, 19);
            this.buttonY.TabIndex = 24;
            this.buttonY.Text = "Y";
            this.buttonY.UseVisualStyleBackColor = true;
            this.buttonY.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(180, 201);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(36, 19);
            this.buttonX.TabIndex = 23;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonW
            // 
            this.buttonW.Location = new System.Drawing.Point(109, 201);
            this.buttonW.Name = "buttonW";
            this.buttonW.Size = new System.Drawing.Size(36, 19);
            this.buttonW.TabIndex = 22;
            this.buttonW.Text = "W";
            this.buttonW.UseVisualStyleBackColor = true;
            this.buttonW.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonW.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonV
            // 
            this.buttonV.Location = new System.Drawing.Point(38, 201);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(36, 19);
            this.buttonV.TabIndex = 21;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonU
            // 
            this.buttonU.Location = new System.Drawing.Point(412, 138);
            this.buttonU.Name = "buttonU";
            this.buttonU.Size = new System.Drawing.Size(36, 19);
            this.buttonU.TabIndex = 20;
            this.buttonU.Text = "U";
            this.buttonU.UseVisualStyleBackColor = true;
            this.buttonU.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonU.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonT
            // 
            this.buttonT.Location = new System.Drawing.Point(353, 150);
            this.buttonT.Name = "buttonT";
            this.buttonT.Size = new System.Drawing.Size(36, 19);
            this.buttonT.TabIndex = 19;
            this.buttonT.Text = "T";
            this.buttonT.UseVisualStyleBackColor = true;
            this.buttonT.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonS
            // 
            this.buttonS.Location = new System.Drawing.Point(294, 138);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(36, 19);
            this.buttonS.TabIndex = 18;
            this.buttonS.Text = "S";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(227, 143);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(36, 19);
            this.buttonR.TabIndex = 17;
            this.buttonR.Text = "R";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonQ
            // 
            this.buttonQ.Location = new System.Drawing.Point(166, 138);
            this.buttonQ.Name = "buttonQ";
            this.buttonQ.Size = new System.Drawing.Size(36, 24);
            this.buttonQ.TabIndex = 16;
            this.buttonQ.Text = "Q";
            this.buttonQ.UseVisualStyleBackColor = true;
            this.buttonQ.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonQ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonP
            // 
            this.buttonP.Location = new System.Drawing.Point(109, 143);
            this.buttonP.Name = "buttonP";
            this.buttonP.Size = new System.Drawing.Size(36, 19);
            this.buttonP.TabIndex = 15;
            this.buttonP.Text = "P";
            this.buttonP.UseVisualStyleBackColor = true;
            this.buttonP.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonO
            // 
            this.buttonO.Location = new System.Drawing.Point(38, 143);
            this.buttonO.Name = "buttonO";
            this.buttonO.Size = new System.Drawing.Size(36, 19);
            this.buttonO.TabIndex = 14;
            this.buttonO.Text = "O";
            this.buttonO.UseVisualStyleBackColor = true;
            this.buttonO.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonN
            // 
            this.buttonN.Location = new System.Drawing.Point(412, 102);
            this.buttonN.Name = "buttonN";
            this.buttonN.Size = new System.Drawing.Size(36, 19);
            this.buttonN.TabIndex = 13;
            this.buttonN.Text = "N";
            this.buttonN.UseVisualStyleBackColor = true;
            this.buttonN.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(344, 89);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(36, 19);
            this.buttonM.TabIndex = 12;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonM.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(294, 89);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(36, 19);
            this.buttonL.TabIndex = 11;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonK
            // 
            this.buttonK.Location = new System.Drawing.Point(215, 89);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(36, 19);
            this.buttonK.TabIndex = 10;
            this.buttonK.Text = "K";
            this.buttonK.UseVisualStyleBackColor = true;
            this.buttonK.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonJ
            // 
            this.buttonJ.Location = new System.Drawing.Point(145, 89);
            this.buttonJ.Name = "buttonJ";
            this.buttonJ.Size = new System.Drawing.Size(36, 19);
            this.buttonJ.TabIndex = 9;
            this.buttonJ.Text = "J";
            this.buttonJ.UseVisualStyleBackColor = true;
            this.buttonJ.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonJ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonI
            // 
            this.buttonI.Location = new System.Drawing.Point(98, 89);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(36, 19);
            this.buttonI.TabIndex = 8;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonH
            // 
            this.buttonH.Location = new System.Drawing.Point(38, 89);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(36, 19);
            this.buttonH.TabIndex = 7;
            this.buttonH.Text = "H";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(412, 44);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(36, 19);
            this.buttonG.TabIndex = 6;
            this.buttonG.Text = "G";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonF
            // 
            this.buttonF.Location = new System.Drawing.Point(344, 38);
            this.buttonF.Name = "buttonF";
            this.buttonF.Size = new System.Drawing.Size(36, 30);
            this.buttonF.TabIndex = 5;
            this.buttonF.Text = "F";
            this.buttonF.UseVisualStyleBackColor = true;
            this.buttonF.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonE
            // 
            this.buttonE.Location = new System.Drawing.Point(284, 38);
            this.buttonE.Name = "buttonE";
            this.buttonE.Size = new System.Drawing.Size(36, 19);
            this.buttonE.TabIndex = 4;
            this.buttonE.Text = "E";
            this.buttonE.UseVisualStyleBackColor = true;
            this.buttonE.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonE.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonD
            // 
            this.buttonD.Location = new System.Drawing.Point(215, 38);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(36, 19);
            this.buttonD.TabIndex = 3;
            this.buttonD.Text = "D";
            this.buttonD.UseVisualStyleBackColor = true;
            this.buttonD.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(145, 38);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(36, 19);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonB
            // 
            this.buttonB.Location = new System.Drawing.Point(89, 38);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(36, 19);
            this.buttonB.TabIndex = 1;
            this.buttonB.Text = "B";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // buttonA
            // 
            this.buttonA.Location = new System.Drawing.Point(38, 38);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(36, 19);
            this.buttonA.TabIndex = 0;
            this.buttonA.Text = "A";
            this.buttonA.UseVisualStyleBackColor = true;
            this.buttonA.Click += new System.EventHandler(this.buttonA2Z_Click);
            this.buttonA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            // 
            // picturePanel
            // 
            this.picturePanel.BackColor = System.Drawing.Color.White;
            this.picturePanel.Controls.Add(this.pictureBox);
            this.picturePanel.Controls.Add(this.TeamScore4);
            this.picturePanel.Controls.Add(this.TeamScore3);
            this.picturePanel.Controls.Add(this.TeamScore2);
            this.picturePanel.Controls.Add(this.TeamScore1);
            this.picturePanel.Controls.Add(this.TeamLabel4);
            this.picturePanel.Controls.Add(this.TeamLabel3);
            this.picturePanel.Controls.Add(this.TeamLabel2);
            this.picturePanel.Controls.Add(this.TeamLabel1);
            this.picturePanel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.picturePanel.Location = new System.Drawing.Point(797, 143);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(244, 295);
            this.picturePanel.TabIndex = 42;
            this.picturePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.picturePanel_Paint);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Hangman_Steven.Resource.fig1;
            this.pictureBox.Location = new System.Drawing.Point(29, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(190, 241);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 43;
            this.pictureBox.TabStop = false;
            // 
            // TeamScore4
            // 
            this.TeamScore4.AutoSize = true;
            this.TeamScore4.Location = new System.Drawing.Point(130, 247);
            this.TeamScore4.Name = "TeamScore4";
            this.TeamScore4.Size = new System.Drawing.Size(27, 27);
            this.TeamScore4.TabIndex = 7;
            this.TeamScore4.Text = "0";
            // 
            // TeamScore3
            // 
            this.TeamScore3.AutoSize = true;
            this.TeamScore3.Location = new System.Drawing.Point(130, 177);
            this.TeamScore3.Name = "TeamScore3";
            this.TeamScore3.Size = new System.Drawing.Size(27, 27);
            this.TeamScore3.TabIndex = 6;
            this.TeamScore3.Text = "0";
            // 
            // TeamScore2
            // 
            this.TeamScore2.AutoSize = true;
            this.TeamScore2.Location = new System.Drawing.Point(130, 105);
            this.TeamScore2.Name = "TeamScore2";
            this.TeamScore2.Size = new System.Drawing.Size(27, 27);
            this.TeamScore2.TabIndex = 5;
            this.TeamScore2.Text = "0";
            // 
            // TeamScore1
            // 
            this.TeamScore1.AutoSize = true;
            this.TeamScore1.Location = new System.Drawing.Point(130, 32);
            this.TeamScore1.Name = "TeamScore1";
            this.TeamScore1.Size = new System.Drawing.Size(27, 27);
            this.TeamScore1.TabIndex = 4;
            this.TeamScore1.Text = "0";
            // 
            // TeamLabel4
            // 
            this.TeamLabel4.AutoSize = true;
            this.TeamLabel4.Location = new System.Drawing.Point(13, 247);
            this.TeamLabel4.Name = "TeamLabel4";
            this.TeamLabel4.Size = new System.Drawing.Size(102, 27);
            this.TeamLabel4.TabIndex = 3;
            this.TeamLabel4.Text = "Team4:";
            // 
            // TeamLabel3
            // 
            this.TeamLabel3.AutoSize = true;
            this.TeamLabel3.Location = new System.Drawing.Point(13, 177);
            this.TeamLabel3.Name = "TeamLabel3";
            this.TeamLabel3.Size = new System.Drawing.Size(102, 27);
            this.TeamLabel3.TabIndex = 2;
            this.TeamLabel3.Text = "Team3:";
            // 
            // TeamLabel2
            // 
            this.TeamLabel2.AutoSize = true;
            this.TeamLabel2.Location = new System.Drawing.Point(13, 102);
            this.TeamLabel2.Name = "TeamLabel2";
            this.TeamLabel2.Size = new System.Drawing.Size(102, 27);
            this.TeamLabel2.TabIndex = 1;
            this.TeamLabel2.Text = "Team2:";
            // 
            // TeamLabel1
            // 
            this.TeamLabel1.AutoSize = true;
            this.TeamLabel1.Location = new System.Drawing.Point(13, 32);
            this.TeamLabel1.Name = "TeamLabel1";
            this.TeamLabel1.Size = new System.Drawing.Size(102, 27);
            this.TeamLabel1.TabIndex = 0;
            this.TeamLabel1.Text = "Team1:";
            // 
            // barTimer
            // 
            this.barTimer.Interval = 1;
            this.barTimer.Tick += new System.EventHandler(this.barTimer_Tick);
            // 
            // Hangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 473);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.timeBar);
            this.Controls.Add(this.mainScreen);
            this.Name = "Hangman";
            this.Text = "Hangman";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Hangman_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hangman_KeyDown);
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tmpPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseSentence)).EndInit();
            this.picturePanel.ResumeLayout(false);
            this.picturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox mainScreen;
        private System.Windows.Forms.ProgressBar timeBar;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button buttonZ;
        private System.Windows.Forms.Button buttonY;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonW;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonU;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonQ;
        private System.Windows.Forms.Button buttonP;
        private System.Windows.Forms.Button buttonO;
        private System.Windows.Forms.Button buttonN;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonK;
        private System.Windows.Forms.Button buttonJ;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonF;
        private System.Windows.Forms.Button buttonE;
        private System.Windows.Forms.Button buttonD;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.NumericUpDown chooseSentence;
        private System.Windows.Forms.Label verticalLine;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Label lineLabel1;
        private System.Windows.Forms.Label lineLabel2;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button ConfigureButton;
        private System.Windows.Forms.Label TeamLabel4;
        private System.Windows.Forms.Label TeamLabel3;
        private System.Windows.Forms.Label TeamLabel2;
        private System.Windows.Forms.Label TeamLabel1;
        private System.Windows.Forms.Label TeamScore4;
        private System.Windows.Forms.Label TeamScore3;
        private System.Windows.Forms.Label TeamScore2;
        private System.Windows.Forms.Label TeamScore1;
        private System.Windows.Forms.Timer barTimer;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Label arrowLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private AxWMPLib.AxWindowsMediaPlayer tmpPlayer;
    }
}

