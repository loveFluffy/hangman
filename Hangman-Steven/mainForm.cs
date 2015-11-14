using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Media;
using System.Runtime.InteropServices;

namespace Hangman_Steven
{
    public partial class Hangman : Form
    {
        ///////////////////////
        //设置界面传回值变量
        //（其实这部分没必要赋初始值，
        //mainForm加载的时候会读ConfigureFile.txt）
        ///////////////////////
        
        //Distance-word
        public int wordDistance = 3;
        //Distance-letter
        public int letterDistance = 1;
        //Timer
        public int timerValue = 20;
        //Mode-speak letter mode
        public int speakLetterMode = 0;
        //Mode-teams mode
        public int teamsMode = 0;
        //Mode-letter display time
        public int displayTime = 0;
        //Perference-Music
        public string letterFailure="letterFailure.mp3";
        public string letterSuccess="letterSuccess.mp3";
        public string loseGame="loseGame.mp3";
        public string gameWon="gameWon.mp3";
        //Perference-Color定义3中键盘按键的背景色
        public Color unClickedColor = Color.FromArgb(255,255,255);//没有按-白色
        public Color usedColor = Color.FromArgb(100, 100, 100);//按对了-灰色
        public Color failedColor = Color.FromArgb(200, 0, 0);//按错了-红色
        //Perference-fontSize
        public static int fontSize = 30;  //该变量必须为static
        //frequent(1)-common(2)-rare(3) letters
        public int letterA = 1;
        public int letterB = 2;
        public int letterC = 2;
        public int letterD = 2;
        public int letterE = 1;
        public int letterF = 2;
        public int letterG = 2;
        public int letterH = 1;
        public int letterI = 1;
        public int letterJ = 3;
        public int letterK = 3;
        public int letterL = 2;
        public int letterM = 2;
        public int letterN = 1;
        public int letterO = 1;
        public int letterP = 2;
        public int letterQ = 3;
        public int letterR = 1;
        public int letterS = 1;
        public int letterT = 1;
        public int letterU = 2;
        public int letterV = 3;
        public int letterW = 2;
        public int letterX = 3;
        public int letterY = 2;
        public int letterZ = 3;
        //letter values
        public int frequentSuccess = 1;
        public int frequentFailure = -2;
        public int commonSuccess = 2;
        public int commonFailure = -4;
        public int rareSuccess = 4;
        public int rareFailure = -8;
        //Time out penalty(1 body part)
        public int timeOutPenalty = 1;
        //dataFilePath
        public string dataFilePath="";/////////////////////////////////////

        //根据fontSize重新生成字体样式，将屏幕字体全部设置成无下划线样式
        public void checkFontSize()
        {
            noUnderlineFont = new System.Drawing.Font("Consolas", fontSize,
                    System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,
                    ((System.Byte)(0)));
            withUnderlineFont = new System.Drawing.Font("Consolas", fontSize,
                    System.Drawing.FontStyle.Bold | FontStyle.Underline, System.Drawing.GraphicsUnit.Point,
                     ((System.Byte)(0)));
            mainScreen.Font = noUnderlineFont;
        }

        public void setWordWrap()
        {
            mainScreen.WordWrap = true;
        }

        public void checkTeamsMode()
        {
            //单队伍模式
            if (teamsMode == 0)
            {
                arrowLabel.Visible = false;
                pictureBox.Visible = true;
            }
            else//多队伍模式
            {
                arrowLabel.Visible = true;
                pictureBox.Visible = false;
            }
        }

        private void resetFocus()
        {
            buttonA.Focus();
        }

        ///////////////////////
        //宏观私有变量
        ///////////////////////

        //获取屏幕大小
        public Rectangle screenSize = System.Windows.Forms.SystemInformation.VirtualScreen;

        //无下划线字体样式
        private System.Drawing.Font noUnderlineFont = new System.Drawing.Font("Consolas", fontSize,
                    System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point,
                    ((System.Byte)(0)));
        //有下划线字体样式
        private System.Drawing.Font withUnderlineFont = new System.Drawing.Font("Consolas", fontSize,
                    System.Drawing.FontStyle.Bold | FontStyle.Underline, System.Drawing.GraphicsUnit.Point,
                     ((System.Byte)(0)));

        

        


        //当前显示的第几张图片
        private int pictureNum = 1;





        ///////////////////////
        //宏观私有函数
        ///////////////////////
        
        //清空各个队的分数(未用)
        private void clearScore()
        {
            TeamScore1.Text = "0";
            TeamScore2.Text = "0";
            TeamScore3.Text = "0";
            TeamScore4.Text = "0";
        }

        //使能键盘
        private void enableButtons()
        {
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;
            buttonG.Enabled = true;
            buttonH.Enabled = true;
            buttonI.Enabled = true;
            buttonJ.Enabled = true;
            buttonK.Enabled = true;
            buttonL.Enabled = true;
            buttonM.Enabled = true;
            buttonN.Enabled = true;
            buttonO.Enabled = true;
            buttonP.Enabled = true;
            buttonQ.Enabled = true;
            buttonR.Enabled = true;
            buttonS.Enabled = true;
            buttonT.Enabled = true;
            buttonU.Enabled = true;
            buttonV.Enabled = true;
            buttonW.Enabled = true;
            buttonX.Enabled = true;
            buttonY.Enabled = true;
            buttonZ.Enabled = true;
        }

        //全部初始化为unClicked状态
        public void unClickButtons()
        {
            buttonA.BackColor = unClickedColor;
            buttonB.BackColor = unClickedColor;
            buttonC.BackColor = unClickedColor;
            buttonD.BackColor = unClickedColor;
            buttonE.BackColor = unClickedColor;
            buttonF.BackColor = unClickedColor;
            buttonG.BackColor = unClickedColor;
            buttonH.BackColor = unClickedColor;
            buttonI.BackColor = unClickedColor;
            buttonJ.BackColor = unClickedColor;
            buttonK.BackColor = unClickedColor;
            buttonL.BackColor = unClickedColor;
            buttonM.BackColor = unClickedColor;
            buttonN.BackColor = unClickedColor;
            buttonO.BackColor = unClickedColor;
            buttonP.BackColor = unClickedColor;
            buttonQ.BackColor = unClickedColor;
            buttonR.BackColor = unClickedColor;
            buttonS.BackColor = unClickedColor;
            buttonT.BackColor = unClickedColor;
            buttonU.BackColor = unClickedColor;
            buttonV.BackColor = unClickedColor;
            buttonW.BackColor = unClickedColor;
            buttonX.BackColor = unClickedColor;
            buttonY.BackColor = unClickedColor;
            buttonZ.BackColor = unClickedColor;
        }

        //设置键盘不可用
        private void unableButtons()
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonE.Enabled = false;
            buttonF.Enabled = false;
            buttonG.Enabled = false;
            buttonH.Enabled = false;
            buttonI.Enabled = false;
            buttonJ.Enabled = false;
            buttonK.Enabled = false;
            buttonL.Enabled = false;
            buttonM.Enabled = false;
            buttonN.Enabled = false;
            buttonO.Enabled = false;
            buttonP.Enabled = false;
            buttonQ.Enabled = false;
            buttonR.Enabled = false;
            buttonS.Enabled = false;
            buttonT.Enabled = false;
            buttonU.Enabled = false;
            buttonV.Enabled = false;
            buttonW.Enabled = false;
            buttonX.Enabled = false;
            buttonY.Enabled = false;
            buttonZ.Enabled = false;
        }

        //主窗口控件布局（在Hangman_Load中只调用一次）
        private void setPosition()
        {
            //设置主窗口mainForm的位置和大小
            this.Location = new Point(0, 0);
            this.Width = screenSize.Width;
            this.Height = screenSize.Height;

            //设置主屏幕mainScreen的位置和大小
            mainScreen.Location = new Point(0, 0);
            mainScreen.Width = this.Width;
            mainScreen.Height = this.Height / 2;

            //设置timeBar的位置和大小
            timeBar.Location = new Point(0, mainScreen.Height);
            timeBar.Width = this.Width;
            timeBar.Height = 30;

            //键盘panel区
            buttonPanel.Location = new Point(0, mainScreen.Height + 30);
            buttonPanel.Width = this.Width * 4 / 5;
            buttonPanel.Height = this.Height - mainScreen.Height - timeBar.Height;

            int buttonHeigth = (buttonPanel.Height - 70) / 4; //键盘单个键的高度(间隔5)---这里的70很奇怪，本应该是25
            int buttonWidth = (this.Width * 11 / 20 - 40) / 7;  //键盘单个键的宽度（间隔5）
            buttonA.Location = new Point(5, 5);
            buttonB.Location = new Point(buttonWidth + 5 * 2, 5);
            buttonC.Location = new Point(buttonWidth * 2 + 5 * 3, 5);
            buttonD.Location = new Point(buttonWidth * 3 + 5 * 4, 5);
            buttonE.Location = new Point(buttonWidth * 4 + 5 * 5, 5);
            buttonF.Location = new Point(buttonWidth * 5 + 5 * 6, 5);
            buttonG.Location = new Point(buttonWidth * 6 + 5 * 7, 5);
            buttonH.Location = new Point(5, buttonHeigth + 5 * 2);
            buttonI.Location = new Point(buttonWidth + 5 * 2, buttonHeigth + 5 * 2);
            buttonJ.Location = new Point(buttonWidth * 2 + 5 * 3, buttonHeigth + 5 * 2);
            buttonK.Location = new Point(buttonWidth * 3 + 5 * 4, buttonHeigth + 5 * 2);
            buttonL.Location = new Point(buttonWidth * 4 + 5 * 5, buttonHeigth + 5 * 2);
            buttonM.Location = new Point(buttonWidth * 5 + 5 * 6, buttonHeigth + 5 * 2);
            buttonN.Location = new Point(buttonWidth * 6 + 5 * 7, buttonHeigth + 5 * 2);
            buttonO.Location = new Point(5, buttonHeigth * 2 + 5 * 3);
            buttonP.Location = new Point(buttonWidth + 5 * 2, buttonHeigth * 2 + 5 * 3);
            buttonQ.Location = new Point(buttonWidth * 2 + 5 * 3, buttonHeigth * 2 + 5 * 3);
            buttonR.Location = new Point(buttonWidth * 3 + 5 * 4, buttonHeigth * 2 + 5 * 3);
            buttonS.Location = new Point(buttonWidth * 4 + 5 * 5, buttonHeigth * 2 + 5 * 3);
            buttonT.Location = new Point(buttonWidth * 5 + 5 * 6, buttonHeigth * 2 + 5 * 3);
            buttonU.Location = new Point(buttonWidth * 6 + 5 * 7, buttonHeigth * 2 + 5 * 3);
            buttonV.Location = new Point(5, buttonHeigth * 3 + 5 * 4);
            buttonW.Location = new Point(buttonWidth + 5 * 2, buttonHeigth * 3 + 5 * 4);
            buttonX.Location = new Point(buttonWidth * 2 + 5 * 3, buttonHeigth * 3 + 5 * 4);
            buttonY.Location = new Point(buttonWidth * 3 + 5 * 4, buttonHeigth * 3 + 5 * 4);
            buttonZ.Location = new Point(buttonWidth * 4 + 5 * 5, buttonHeigth * 3 + 5 * 4);

            buttonA.Size = new Size(buttonWidth, buttonHeigth);
            buttonB.Size = new Size(buttonWidth, buttonHeigth);
            buttonC.Size = new Size(buttonWidth, buttonHeigth);
            buttonD.Size = new Size(buttonWidth, buttonHeigth);
            buttonE.Size = new Size(buttonWidth, buttonHeigth);
            buttonF.Size = new Size(buttonWidth, buttonHeigth);
            buttonG.Size = new Size(buttonWidth, buttonHeigth);
            buttonH.Size = new Size(buttonWidth, buttonHeigth);
            buttonI.Size = new Size(buttonWidth, buttonHeigth);
            buttonJ.Size = new Size(buttonWidth, buttonHeigth);
            buttonK.Size = new Size(buttonWidth, buttonHeigth);
            buttonL.Size = new Size(buttonWidth, buttonHeigth);
            buttonM.Size = new Size(buttonWidth, buttonHeigth);
            buttonN.Size = new Size(buttonWidth, buttonHeigth);
            buttonO.Size = new Size(buttonWidth, buttonHeigth);
            buttonP.Size = new Size(buttonWidth, buttonHeigth);
            buttonQ.Size = new Size(buttonWidth, buttonHeigth);
            buttonR.Size = new Size(buttonWidth, buttonHeigth);
            buttonS.Size = new Size(buttonWidth, buttonHeigth);
            buttonT.Size = new Size(buttonWidth, buttonHeigth);
            buttonU.Size = new Size(buttonWidth, buttonHeigth);
            buttonV.Size = new Size(buttonWidth, buttonHeigth);
            buttonW.Size = new Size(buttonWidth, buttonHeigth);
            buttonX.Size = new Size(buttonWidth, buttonHeigth);
            buttonY.Size = new Size(buttonWidth, buttonHeigth);
            buttonZ.Size = new Size(buttonWidth, buttonHeigth);

            verticalLine.Height = buttonPanel.Height;
            verticalLine.Location = new Point(this.Width * 11 / 20, 0);
            lineLabel1.Width = this.Width / 4;
            lineLabel1.Location = new Point(this.Width * 11 / 20, buttonPanel.Height / 4);
            lineLabel2.Width = this.Width / 4;
            lineLabel2.Location = new Point(this.Width * 11 / 20, buttonPanel.Height * 2 / 3);

            chooseLabel.Location = new Point(verticalLine.Location.X + 20, verticalLine.Location.Y + 20);
            chooseSentence.Location = new Point(buttonPanel.Width - chooseSentence.Width - 20 - arrowLabel.Width, chooseLabel.Location.Y);

            startGameButton.Location = new Point(lineLabel1.Location.X + lineLabel1.Width / 4, lineLabel1.Location.Y + (lineLabel2.Location.Y - lineLabel1.Location.Y) / 4);
            startGameButton.Width = lineLabel1.Width / 2;
            startGameButton.Height = (lineLabel2.Location.Y - lineLabel1.Location.Y) / 2;

            ConfigureButton.Location = new Point(lineLabel2.Location.X + lineLabel2.Width / 4, lineLabel2.Location.Y + (buttonPanel.Height - lineLabel2.Location.Y) / 4);
            ConfigureButton.Width = lineLabel2.Width / 2;
            ConfigureButton.Height = (buttonPanel.Height - lineLabel2.Location.Y) / 3;

            arrowLabel.Location = new Point(buttonPanel.Width - arrowLabel.Width, TeamLabel1.Location.Y);

            //配置picturePanel内的位置和大小
            picturePanel.Location = new Point(buttonPanel.Width + 1, mainScreen.Height + 30);//////
            picturePanel.Height = this.Height - mainScreen.Height - timeBar.Height;
            picturePanel.Width = this.Width - buttonPanel.Width;

            TeamLabel1.Location = new Point(0, (picturePanel.Width - 100) / 4 - 15);
            TeamLabel2.Location = new Point(0, (picturePanel.Width - 100) / 4 * 2 + 25 - 15);
            TeamLabel3.Location = new Point(0, (picturePanel.Width - 100) / 4 * 3 + 25 * 2 - 15);
            TeamLabel4.Location = new Point(0, (picturePanel.Width - 100) / 4 * 4 + 25 * 3 - 15);
            TeamScore1.Location = new Point(TeamLabel1.Location.X + TeamLabel1.Width, TeamLabel1.Location.Y);
            TeamScore2.Location = new Point(TeamLabel2.Location.X + TeamLabel2.Width, TeamLabel2.Location.Y);
            TeamScore3.Location = new Point(TeamLabel3.Location.X + TeamLabel3.Width, TeamLabel3.Location.Y);
            TeamScore4.Location = new Point(TeamLabel4.Location.X + TeamLabel4.Width, TeamLabel4.Location.Y);

            pictureBox.Location = new Point(0, 0);
            pictureBox.Height = this.Height - mainScreen.Height - timeBar.Height;
            pictureBox.Width = this.Width - buttonPanel.Width;
        }

        //读配置文件，更新配置变量
        private void readConfigureFile()
        {
            try
            {
                FileStream fs = new FileStream("configureFile.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string srLine = sr.ReadLine();
                wordDistance = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterDistance = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                timerValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                speakLetterMode = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                teamsMode = Int32.Parse(srLine);

                if (teamsMode == 0)
                {
                    arrowLabel.Visible = false;
                }

                srLine = sr.ReadLine();
                displayTime = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterFailure = srLine;
                srLine = sr.ReadLine();
                letterSuccess = srLine;
                srLine = sr.ReadLine();
                loseGame = srLine;
                srLine = sr.ReadLine();
                gameWon = srLine;
                srLine = sr.ReadLine();
                int rValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                int gValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                int bValue = Int32.Parse(srLine);
                unClickedColor = Color.FromArgb(rValue, gValue, bValue);
                srLine = sr.ReadLine();
                rValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                gValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                bValue = Int32.Parse(srLine);
                usedColor = Color.FromArgb(rValue, gValue, bValue);
                srLine = sr.ReadLine();
                rValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                gValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                bValue = Int32.Parse(srLine);
                failedColor = Color.FromArgb(rValue, gValue, bValue);
                srLine = sr.ReadLine();
                fontSize = Int32.Parse(srLine);
                //跳过接下来的9行（表示3个Freq-Comm-Rare背景色）
                srLine = sr.ReadLine();
                srLine = sr.ReadLine();
                srLine = sr.ReadLine();
                srLine = sr.ReadLine();
                srLine = sr.ReadLine();
                srLine = sr.ReadLine();
                srLine = sr.ReadLine();
                srLine = sr.ReadLine();
                srLine = sr.ReadLine();
                //读26个字母权值
                srLine = sr.ReadLine();
                letterA = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterB = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterC = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterD = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterE = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterF = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterG = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterH = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterI = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterJ = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterK = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterL = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterM = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterN = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterO = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterP = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterQ = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterR = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterS = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterT = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterU = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterV = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterW = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterX = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterY = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterZ = Int32.Parse(srLine);
                //读6个加分减分数值
                srLine = sr.ReadLine();
                frequentSuccess = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                frequentFailure = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                commonSuccess = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                commonFailure = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                rareSuccess = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                rareFailure = Int32.Parse(srLine);
                //读一个time out penalty数
                srLine = sr.ReadLine();
                timeOutPenalty = Int32.Parse(srLine);
                //读一个字符串，赋值给dataFilePath
                srLine = sr.ReadLine();
                dataFilePath = srLine;

                sr.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error! Check configureFile.txt");
                return;
            }
        }




        //每行能显示的字符数目
        private int letterNumEveryLine = 0;
        
        //计算每行能显示的字符数目
        //要想数对的前提：数之前FontSize确定了，并且根据这个变量重新生成了Font并且应用到了mainScreen上
        //并且mainScreen的Width确定了（即：必须在setPosition()函数执行之后）
        //如果FontSize/mainScreen.Width改变了，必须重新调用。
        public void getLetterNumEveryLine()
        {
            int tmp = 0;
            
            string remScreenString = mainScreen.Text;
            string tmpScreenString = "";//确保显示的内容足够多并且无换行符
            for (int i = 0; i < 300; i++)
            {
                tmpScreenString += "00";
            }
            mainScreen.WordWrap = true;
            mainScreen.Text = tmpScreenString;
            for (int i = 1; i < mainScreen.Text.Length; i++)
            {
                if (mainScreen.GetLineFromCharIndex(i) != 0)
                {
                    break;
                }
                tmp++;
            }
            mainScreen.WordWrap = false;
            mainScreen.Text = remScreenString;

            letterNumEveryLine = tmp;
        }




        public Hangman()
        {
            InitializeComponent();
        }



        ////////////////////////////////////////////////////////////////////////////////


        //键盘事件处理程序
        public void key_OnMouseActivity(object sender, KeyEventArgs e)
        {
            //test code
            //if (e.KeyCode.ToString().Equals("A")&&(this.ActiveControl))
            //{
            //    MessageBox.Show(e.KeyCode.ToString());
            //}
            

            Application.DoEvents();
        }

        //mainForm加载时的初始化工作（这里面函数的调用顺序是不可乱改的）
        private void Hangman_Load(object sender, EventArgs e)
        {
            //主窗口控件布局（在Hangman_Load中只调用一次）
            setPosition();

            //读配置文件，更新配置变量
            readConfigureFile();

            //落实配置文件内容：确保程序刚运行的初始界面是根据ConfigureFile的设定出现的
            //落实FontSize: 根据fontSize重新生成字体样式，将屏幕字体全部设置成无下划线样式
            checkFontSize();

            //计算每行能显示的字符数目
            //要想数对的前提：数之前FontSize确定了，并且根据这个变量重新生成了Font并且应用到了mainScreen上
            //并且mainScreen的Width确定了（即：必须在setPosition()函数执行之后）
            //如果FontSize/mainScreen.Width改变了，必须重新调用。
            getLetterNumEveryLine();


            //落实wordDistance 和 letterDistance(这部分可以留在后面写，只是为了提高界面的友好程度)
            


            //落实Timer

            //----------------这附近的代码不一定都需要写

            //落实队伍模式（决定显示图片还是分数）
            checkTeamsMode();
            //落实键盘背景色
            unClickButtons();

            







            //设置键盘不可用
            unableButtons();
            //时钟
            barTimer.Enabled = false;
            //StartGameButton
            startGameButton.Enabled = false;
            //？？？    

            mainScreen.WordWrap = true;

            //个性化配置（根据Hangman-QC-2015.08.25-c增添）
            this.mainScreen.BackColor = Color.LightBlue;


        }





        //无用方法（不用写具体的实现内容）
        private void mainScreen_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timeBar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        



        //选择一个句子（1-1000）
        private void chooseSentence_ValueChanged(object sender, EventArgs e)
        {
            unableButtons();

            if (chooseSentence.Value == 0)
            {
                startGameButton.Enabled = false;

                //设置键盘不可用
                unableButtons();
            }
            else
            {
                startGameButton.Enabled = true;
            }

            resetFocus();
        }

        private void verticalLine_Click(object sender, EventArgs e)
        {

        }

        //Configure键
        private void ConfigureButton_Click(object sender, EventArgs e)
        {
            Configure configureForm = new Configure();
            configureForm.mainForm = this;
            configureForm.ShowDialog();
        }

        //计分区-图像（单组模式下使用）
        private void picturePanel_Paint(object sender, PaintEventArgs e)
        {
            
        }



        //字符串文件操作相关
        private string mainPartDealed;//经过处理之后的正文部分（加空格、换行）
        private string authorPartDealed;//经过处理之后的作者部分（加空格、换行）

        //从fileName读取第lineNum行字符串并返回（出错的情况下，返回空串）
        private string readLineFormFile(string fileName,int lineNum)
        {
            int countLineNum=1;
            string tmpString;
            try
            {
                StreamReader sr = new StreamReader(dataFilePath, Encoding.Default);
                while ((tmpString=sr.ReadLine()) != null)
                {
                    if (countLineNum == lineNum)
                    {
                        sr.DiscardBufferedData();
                        sr.BaseStream.Seek(0, SeekOrigin.Begin);
                        sr.BaseStream.Position = 0;
                        
                        return tmpString;
                    }
                    countLineNum++;
                }
                MessageBox.Show("The number is too big, try a smaller one.");

                return "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data File Path is wrong!\n" + ex.Message);

                return "";
            }

        }

        //根据选的句子行号，从文件读取句子并且加工处理分成两部分mainPartDealed authorPartDealed
        //如果返回1则说明计算失败，要重新调用此函数！！！正常则返回0
        private int splitSentenceInto2Part(int tmpSentenceNum)
        {
            
            //int tmpSentenceNum = Int32.Parse(chooseSentence.Value.ToString());
            string primSentence = readLineFormFile(dataFilePath, tmpSentenceNum);
            if (primSentence == "")//这里判断的是原始句子为空
            {
                mainScreen.Text = "";
                //在这里还应该保证上次StartGame的效果都停止（比如Timer停止计时等）---------------------------
                return 1;
            }
            string mainPart;//正文部分
            string authorPart;//作者部分

            int tmp = primSentence.IndexOf(" ~ ");
            if (tmp > -1)//有作者信息
            {
                mainPart = primSentence.Substring(6, tmp - 6);
                authorPart = primSentence.Substring(tmp, primSentence.Length - tmp);
            }
            else//没有作者信息
            {
                mainPart = primSentence.Substring(6,primSentence.Length-6);
                authorPart = "";
            }

            //判断句子正文部分为空或全部都是空格（按理讲数据库不该有这样的句子，只是以防万一）--------代码后期再补充
            //MessageBox.Show("Please choose another sentence.");
            //return 1



            //关于screenPart变量的说明：本来这个函数打算继续往下写，可是后来发现太长了而且结构不合理
            //就让screenPart变量在函数结束的时候只是存储了mainPart（加空格、加\n）
            //原本计划用来存储：最终显示的样子（mainPart,空格,authorPart,\n都有了），所以起了这个名字。
            string screenPart = "";

            //处理mainPart，加空格
            for (int i = 0; i < mainPart.Length; i++)
            {
                string tmpString = mainPart.Substring(i, 1);
                if (i == mainPart.Length - 1)//要处理最后一个字符了
                {
                    if (tmpString.Equals(" "))//按理讲最后一个字符不该是空格，只是以防万一
                    { 
                        break;
                    }
                    else 
                    {
                        screenPart += tmpString;
                        break;
                    }
                }

                if (tmpString.Equals(" "))
                {
                    for (int j = 0; j < wordDistance - letterDistance; j++)
                    {
                        screenPart += ' ';
                    }
                }
                else
                {
                    screenPart += tmpString;
                    for (int k = 0; k < letterDistance; k++)
                    {
                        screenPart += ' ';
                    }
                }

            }

            //处理mainPart，加\n，防止wordwrap
            string tmpScreenString = screenPart;
            screenPart = "";

            string tmpSplitString="";
            for (int i = 0; i < wordDistance; i++)
            {
                tmpSplitString+=" ";
            }
            string[] tmpStringVector = Regex.Split(tmpScreenString, tmpSplitString);

            int tmpLength = 0;//存储当前行已有多少个letter
            for (int i = 0; i < tmpStringVector.Length; i++)
            {
                tmpLength += tmpStringVector[i].Length;
                if (tmpLength + wordDistance < letterNumEveryLine)//能放下，剩的空格数大于wordDistance
                {
                    screenPart = screenPart + tmpStringVector[i] + tmpSplitString;
                    tmpLength += 3;
                }
                else if ((tmpLength <= letterNumEveryLine) && (tmpLength + 3 >= letterNumEveryLine))//能放下，但剩余空格小于等于wordDistance
                {
                    screenPart = screenPart + tmpStringVector[i] + '\n';
                    tmpLength = 0;
                }
                else//放不下了
                {
                    screenPart = screenPart + '\n' + tmpStringVector[i] + tmpSplitString;
                    tmpLength = tmpStringVector[i].Length + wordDistance;
                }
            }

            mainPartDealed = screenPart;
            authorPartDealed = authorPart;

            return 0;
        }

        //计算格式（根据mainPartDealed变量和authorPartDealed变量对当前mainScreen显示的内容进行格式设置）
        //如果按了字母键，在改变了mainPartShowed变量之后记得调用此函数
        private void setScreenFont(string mainPartDealed, string authorPartDealed)
        {
            for (int i = 0; i < mainPartDealed.Length; i++)
            {
                //字母部分有下划线
                if (Regex.IsMatch(mainPartDealed.Substring(i, 1), "[a-zA-Z]"))
                {
                    mainScreen.SelectionStart = i;
                    mainScreen.SelectionLength = 1;
                    mainScreen.SelectionFont = withUnderlineFont;
                }
                else//非字母部分，无下划线
                {
                    mainScreen.SelectionStart = i;
                    mainScreen.SelectionLength = 1;
                    mainScreen.SelectionFont = noUnderlineFont;
                }

            }

            mainScreen.SelectionStart = mainPartDealed.Length;
            mainScreen.SelectionLength = authorPartDealed.Length+2;////
            mainScreen.SelectionFont = noUnderlineFont;

        }

        //记录当前mainScreen显示内容的mainPart（每次按对了字母键都需要更新）
        string mainPartShowed = "";

        //StartGame键
        private void startGameButton_Click(object sender, EventArgs e)
        {   
            //检查保险（没必要）
            //if (chooseSentence.Value == 0)
            //{
            //    MessageBox.Show("The Sentence Number must be grater than 0,\nchoose again!");
            //    startGameButton.Enabled = false;
            //    return;
            //}


            //确保游戏进行过程中不能进行配置
            ConfigureButton.Enabled = false;
            ConfigureButton.Visible = false;

            //word warp
            mainScreen.WordWrap = false;

            //根据选的句子行号，从文件读取句子并且加工处理分成两部分mainPartDealed authorPartDealed
            //如果返回1则说明计算失败，要重新调用此函数！！！正常则返回0
            int tmpNum=splitSentenceInto2Part(Int32.Parse(chooseSentence.Value.ToString()));
            if (tmpNum > 0)//出错了
            {
                startGameButton.Enabled = false;

                return;
            }
            else
            {

            }

            //1.更新mainPartShowed变量
            mainPartShowed="";
            for (int i = 0; i < mainPartDealed.Length; i++)
            {
                //字母（换成空格）
                if (Regex.IsMatch(mainPartDealed.Substring(i, 1), "[a-zA-Z]"))
                {
                    mainPartShowed += " ";
                }
                else//非字母（原样链接）
                {
                    mainPartShowed += mainPartDealed.Substring(i, 1);
                }
            }

            //2.显示在mainScreen上
            mainScreen.Text = mainPartShowed + "\n\n" + authorPartDealed;
            
            //3.设置格式（根据mainPartDealed变量和authorPartDealed变量对当前mainScreen显示的内容进行格式设置）
            //如果按了字母键，记得更新mainPartDealed变量
            setScreenFont(mainPartDealed, authorPartDealed);


            





            //使能键盘
            enableButtons();

            //设置初始色（按键状态：unclicked）
            unClickButtons();



            //时钟相关
            if (timerValue == 0)
            {
                timeBar.Enabled = false;
            }
            else
            {
                timeBar.Value = 0;
                timeBar.Maximum = timerValue;
                timeBar.Minimum = 0;
                barTimer.Enabled = true;
            }
            



            

            unclickedButtonNum = 25;

            resetFocus();
        }





        //显示第i张图片（同时更新全局变量）
        private void changePicture(int i)
        {
            Image image= (Image)Resource.ResourceManager.GetObject("fig" + i);
            pictureBox.Image = image;
            //更新全局变量
            pictureNum = i;
        }

        //计数时钟
        private void barTimer_Tick(object sender, EventArgs e)
        {
            if (timeBar.Value < timeBar.Maximum)
            {
                timeBar.Value++;
            }
            else
            {
                timeBar.Value = 0;

                if (teamsMode == 0)
                {
                    //更换图片（根据变量决定加几个body part）
                    if (pictureNum + timeOutPenalty >= 26)//输了
                    {
                        //播放loseGame.mp3
                        axWindowsMediaPlayer.settings.playCount = 1;
                        axWindowsMediaPlayer.URL = loseGame;
                        changePicture(26);
                        unableButtons();
                        //把timerBar停下！！--------------------------------------------------
                        //???
                        barTimer.Enabled = false;

                    }
                    else//还没输
                    {
                        //播放letterFailure.mp3
                        axWindowsMediaPlayer.settings.playCount = 1;
                        axWindowsMediaPlayer.URL = letterFailure;

                        changePicture(pictureNum + timeOutPenalty);
                    }
                }
                else 
                {
                    axWindowsMediaPlayer.settings.playCount = 1;
                    axWindowsMediaPlayer.URL = letterFailure;

                    //减分
                    decreaseScore(1,arrowPositonTeam);
                    //箭头移动
                    arrowMove(teamsMode, arrowPositonTeam);
                }


                
                
            }
        }




        //记录当前箭头指在第几个队伍上面
        private int arrowPositonTeam = 1;
        //控制箭头顺次移动(teamsMode=2/3/4的时候才能调用此函数)
        private void arrowMove(int teamsMode, int arrowTeam)//队伍数目，当前箭头指在第几个队伍上面
        {
            //安全监测代码
            if (teamsMode < 2)
            {
                MessageBox.Show("You don't need this funciton.");
                return;
            }

            int tmpNum=(picturePanel.Width - 100) / 4+25;
            int newY;
            if(arrowPositonTeam==teamsMode)
            {
                newY=(picturePanel.Width - 100) / 4 - 15;
                arrowPositonTeam=1;
            }
            else
            {
                newY=arrowLabel.Location.Y+tmpNum;
                arrowPositonTeam++;
            }

            Point newPoint = new Point(buttonPanel.Width - arrowLabel.Width, newY);
            arrowLabel.Location = newPoint;
        }

        //将箭头指到第一个队伍的位置上（这个有必要么？）
        private void setArrowBegin()
        {
            int newY = (picturePanel.Width - 100) / 4 - 15;
            arrowLabel.Location = new Point(buttonPanel.Width - arrowLabel.Width, newY);

            //更新相关变量
            arrowPositonTeam = 1;
        }


        //实时记录游戏当前的状态，有没有赢
        private int remWonOrNot=0;

        //letterClicked字母被单击之后，根据当前屏幕显示的mainPartShowed和已知的mainPartDealed变量
        //计算出应该显示的新内容，更新mainPartShowed变量，返回true
        //如果不需要更新（说明用户按错了键），返回false
        private bool changeStringAfterClick(string mainPartShowed_tmp, string mainPartDealed_tmp, string letterClicked_low)
        {
            bool flagValue = false;
            string tmpMainPartShowed="";

            //test code
            if (mainPartShowed_tmp.Length != mainPartDealed_tmp.Length)
            {
                MessageBox.Show("length!=length!");
            }

             
            for (int i = 0; i < mainPartDealed_tmp.Length; i++)
            {
                //与letterClicked_low或者其大写形式匹配
                if ((mainPartDealed_tmp.Substring(i, 1).Equals(letterClicked_low)) || (mainPartDealed_tmp.Substring(i, 1).Equals(letterClicked_low.ToUpper())))
                {
                    tmpMainPartShowed += mainPartDealed_tmp.Substring(i, 1);
                    flagValue = true;
                }
                else//没有匹配上
                {
                    tmpMainPartShowed += mainPartShowed_tmp.Substring(i, 1);
                }
            }

            if (flagValue)
            {
                mainPartShowed = tmpMainPartShowed;
                if (mainPartShowed.Equals(mainPartDealed))//当前这句填完了
                {
                    if (teamsMode == 0)
                    {
                        //test code
                        MessageBox.Show("hehe");
                        mainScreen.SelectionStart = 0;
                        mainScreen.SelectionLength = mainScreen.Text.Length;
                        mainScreen.SelectionFont = noUnderlineFont;

                        axWindowsMediaPlayer.settings.playCount = 1;
                        axWindowsMediaPlayer.URL = gameWon;
                        remWonOrNot = 1;
                    }
                    
                    unableButtons();
                    barTimer.Enabled = false;
                }
            }
            
            return flagValue;
        }

        //利用更新后的mainPartShowed变量更新mainScreen内容
        //只有changeStringAfterClick返回true的时候才有必要调用此函数
        private void updateMainScreen(string mainPartShowed_new)
        {
            mainScreen.Text = mainPartShowed_new + "\n\n" + authorPartDealed;
            setScreenFont(mainPartDealed, authorPartDealed);
        }

        //置零所有队伍的成绩
        private void clearAllScore()
        {
            TeamScore1.Text = "0";
            TeamScore2.Text = "0";
            TeamScore3.Text = "0";
            TeamScore4.Text = "0";
        }

        //按对了字母加分
        private void increaseScore(int freqCommRare, int teamNum)
        {
            int tmpNum = 0;
            switch (freqCommRare)
            {
                case 1: tmpNum += frequentSuccess;
                    break;
                case 2: tmpNum += commonSuccess;
                    break;
                case 3: tmpNum += rareSuccess;
                    break;
                default: MessageBox.Show("Very bad Error!");
                    break;
            }

            switch (teamNum)
            {
                case 1: tmpNum += Int32.Parse(TeamScore1.Text);
                    TeamScore1.Text = tmpNum.ToString();
                    break;
                case 2: tmpNum += Int32.Parse(TeamScore2.Text);
                    TeamScore2.Text = tmpNum.ToString();
                    break;
                case 3: tmpNum += Int32.Parse(TeamScore3.Text);
                    TeamScore3.Text = tmpNum.ToString();
                    break;
                case 4: tmpNum += Int32.Parse(TeamScore4.Text);
                    TeamScore4.Text = tmpNum.ToString();
                    break;
                default: MessageBox.Show("Very bad error!");
                    break;
            }

        }

        //按错了字母减分
        private void decreaseScore(int freqCommRare, int teamNum)
        {
            int tmpNum = 0;
            switch (freqCommRare)
            {
                case 1: tmpNum += frequentFailure;
                    break;
                case 2: tmpNum += commonFailure;
                    break;
                case 3: tmpNum += rareFailure;
                    break;
                default: MessageBox.Show("Very bad error!");
                    break;
            }

            switch (teamNum)
            {
                case 1: tmpNum += Int32.Parse(TeamScore1.Text);
                    TeamScore1.Text = tmpNum.ToString();
                    break;
                case 2: tmpNum += Int32.Parse(TeamScore2.Text);
                    TeamScore2.Text = tmpNum.ToString();
                    break;
                case 3: tmpNum += Int32.Parse(TeamScore3.Text);
                    TeamScore3.Text = tmpNum.ToString();
                    break;
                case 4: tmpNum += Int32.Parse(TeamScore4.Text);
                    TeamScore4.Text = tmpNum.ToString();
                    break;
                default: MessageBox.Show("Very bad error!");
                    break;
            }
        }

        //下面键盘区调用的函数-1
        private int buttonClick(string letterClicked,Button letterButton)
        {
            timeBar.Value = 0;
            if (changeStringAfterClick(mainPartShowed, mainPartDealed, letterClicked))
            {
                updateMainScreen(mainPartShowed);

                //改变键盘背景色
                letterButton.BackColor = usedColor;
                letterButton.Enabled = false;

                if (remWonOrNot == 1)
                {
                    remWonOrNot = 0;
                }
                else 
                {
                    //播放letter成功音乐
                    axWindowsMediaPlayer.settings.playCount = 1;
                    axWindowsMediaPlayer.URL = letterSuccess;
                }

                return 1;
            }
            else
            {
                //改变键盘背景色
                letterButton.BackColor = failedColor;
                letterButton.Enabled = false;
                
                //播放letter失败音乐
                axWindowsMediaPlayer.settings.playCount = 1;
                axWindowsMediaPlayer.URL = letterFailure;

                return 0;
            }
            
        }

        //下面键盘区调用的函数-2
        private void changePicturePanel(int freqCommRare, int oneOrZero)
        {
            //按对了
            if (oneOrZero == 1)
            {
                if (teamsMode == 0)
                {
                    //没有惩罚（图片保持原样）
                }
                else
                {
                    //加分
                    increaseScore(freqCommRare,arrowPositonTeam);
                    arrowMove(teamsMode, arrowPositonTeam);
                }
            }
            else //按错了
            {
                if (teamsMode == 0)
                {
                    //增加图片
                    if (pictureNum + timeOutPenalty >= 26)
                    {
                        changePicture(26);
                        axWindowsMediaPlayer.settings.playCount = 1;
                        axWindowsMediaPlayer.URL = loseGame;
                        unableButtons();
                        barTimer.Enabled = false;
                    }
                    else
                    {
                        changePicture(pictureNum + timeOutPenalty);
                    }

                }
                else
                {
                    //减分
                    decreaseScore(freqCommRare,arrowPositonTeam);
                    arrowMove(teamsMode, arrowPositonTeam);
                }
            }

            //检测键盘是否被按下的状态
            if (unclickedButtonNum > 0)
            {
                unclickedButtonNum--;
            }
            else 
            {
                if (teamsMode == 0)
                { 
                    //游戏成功-去掉下划线
                    

                    //test code
                    MessageBox.Show("test message.");
                    mainScreen.SelectionStart = 0;
                    mainScreen.SelectionLength = mainScreen.Text.Length;
                    mainScreen.SelectionFont = noUnderlineFont;


                    axWindowsMediaPlayer.settings.playCount = 1;
                    axWindowsMediaPlayer.URL = gameWon;
                    barTimer.Enabled = false;
                }
            }

        }

        private int unclickedButtonNum = 25;

        //键盘区
        //(Those codes[buttonA_Click(){} ~ buttonZ_Click(){}] have been covered by function buttonA2Z_Click())
        private void buttonA_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer.settings.playCount = 1;
            //axWindowsMediaPlayer.URL = Application.StartupPath + "\\a2z\\a.mp3";
            //int tmpNum = buttonClick("a", buttonA);
            //changePicturePanel(letterA, tmpNum);
        }
        
        private void buttonB_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("b", buttonB);
            //changePicturePanel(letterB, tmpNum);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("c", buttonC);
            //changePicturePanel(letterC, tmpNum);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("d", buttonD);
            //changePicturePanel(letterD, tmpNum);
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("e", buttonE);
            //changePicturePanel(letterE, tmpNum);
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("f", buttonF);
            //changePicturePanel(letterF, tmpNum);
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("g", buttonG);
            //changePicturePanel(letterG, tmpNum);
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("h", buttonH);
            //changePicturePanel(letterH, tmpNum);
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("i", buttonI);
            //changePicturePanel(letterI, tmpNum);
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("j", buttonJ);
            //changePicturePanel(letterJ, tmpNum);
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("k", buttonK);
            //changePicturePanel(letterK, tmpNum);
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("l", buttonL);
            //changePicturePanel(letterL, tmpNum);
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("m", buttonM);
            //changePicturePanel(letterM, tmpNum);
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("n", buttonN);
            //changePicturePanel(letterN, tmpNum);
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("o", buttonO);
            //changePicturePanel(letterO, tmpNum);
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("p", buttonP);
            //changePicturePanel(letterP, tmpNum);
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("q", buttonQ);
            //changePicturePanel(letterQ, tmpNum);
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("r", buttonR);
            //changePicturePanel(letterR, tmpNum);
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("s", buttonS);
            //changePicturePanel(letterS, tmpNum);
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("t", buttonT);
            //changePicturePanel(letterT, tmpNum);
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("u", buttonU);
            //changePicturePanel(letterU, tmpNum);
        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("v", buttonV);
            //changePicturePanel(letterV, tmpNum);
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("w", buttonW);
            //changePicturePanel(letterW, tmpNum);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("x", buttonX);
            //changePicturePanel(letterX, tmpNum);
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("y", buttonY);
            //changePicturePanel(letterY, tmpNum);
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            //int tmpNum = buttonClick("z", buttonZ);
            //changePicturePanel(letterZ, tmpNum);
        }

        //检测当前键盘是否有键是可以按的，有则返回true
        private bool checkButtonsEnable()
        {
            if (buttonA.Enabled == true)
            {
                return true;
            }

            if (buttonB.Enabled == true)
            {
                return true;
            }

            if (buttonC.Enabled == true)
            {
                return true;
            }

            if (buttonD.Enabled == true)
            {
                return true;
            }

            if (buttonE.Enabled == true)
            {
                return true;
            }

            if (buttonF.Enabled == true)
            {
                return true;
            }

            if (buttonG.Enabled == true)
            {
                return true;
            }

            if (buttonH.Enabled == true)
            {
                return true;
            }

            if (buttonI.Enabled == true)
            {
                return true;
            }

            if (buttonJ.Enabled == true)
            {
                return true;
            }

            if (buttonK.Enabled == true)
            {
                return true;
            }

            if (buttonL.Enabled == true)
            {
                return true;
            }

            if (buttonM.Enabled == true)
            {
                return true;
            }

            if (buttonN.Enabled == true)
            {
                return true;
            }

            if (buttonO.Enabled == true)
            {
                return true;
            }

            if (buttonP.Enabled == true)
            {
                return true;
            }

            if (buttonQ.Enabled == true)
            {
                return true;
            }

            if (buttonR.Enabled == true)
            {
                return true;
            }

            if (buttonS.Enabled == true)
            {
                return true;
            }

            if (buttonT.Enabled == true)
            {
                return true;
            }

            if (buttonU.Enabled == true)
            {
                return true;
            }

            if (buttonV.Enabled == true)
            {
                return true;
            }

            if (buttonW.Enabled == true)
            {
                return true;
            }

            if (buttonX.Enabled == true)
            {
                return true;
            }

            if (buttonY.Enabled == true)
            {
                return true;
            }

            if (buttonZ.Enabled == true)
            {
                return true;
            }

            return false;
        }

        //buttonA_Click(){} ~ buttonZ_Click(){}
        private void buttonA2Z_Click(object sender, EventArgs e)
        {
            Button tmpButton = (Button)sender;
            string tmpNamend=tmpButton.Name.Substring(tmpButton.Name.Length-1,1);

            int tmpNum = buttonClick(tmpNamend.ToLower(), tmpButton);
            if ((tmpNum==1)&&(speakLetterMode!=0))
            {
                tmpPlayer.settings.playCount = speakLetterMode;
                tmpPlayer.URL = Application.StartupPath + "\\a2z\\" + tmpNamend.ToLower() + ".mp3";
            }

            string letterSender = "letter" + tmpNamend;
            int LetterValue = (int)this.GetType().GetField(letterSender).GetValue(this);
            changePicturePanel(LetterValue, tmpNum);
        }

        //useless function
        private void axWindowsMediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void Hangman_KeyDown(object sender, KeyEventArgs e)
        {
            string tmpLetter=e.KeyCode.ToString();

            if (e.Modifiers==Keys.None)
            {
                if (tmpLetter.Equals("A") && buttonA.Enabled)
                {
                    buttonA2Z_Click(buttonA, e);
                }
                else if (tmpLetter.Equals("B") && buttonB.Enabled)
                {
                    buttonA2Z_Click(buttonB, e);
                }
                else if (tmpLetter.Equals("C") && buttonC.Enabled)
                {
                    buttonA2Z_Click(buttonC, e);
                }
                else if (tmpLetter.Equals("D") && buttonD.Enabled)
                {
                    buttonA2Z_Click(buttonD, e);
                }
                else if (tmpLetter.Equals("E") && buttonE.Enabled)
                {
                    buttonA2Z_Click(buttonE, e);
                }
                else if (tmpLetter.Equals("F") && buttonF.Enabled)
                {
                    buttonA2Z_Click(buttonF, e);
                }
                else if (tmpLetter.Equals("G") && buttonG.Enabled)
                {
                    buttonA2Z_Click(buttonG, e);
                }
                else if (tmpLetter.Equals("H") && buttonH.Enabled)
                {
                    buttonA2Z_Click(buttonH, e);
                }
                else if (tmpLetter.Equals("I") && buttonI.Enabled)
                {
                    buttonA2Z_Click(buttonI, e);
                }
                else if (tmpLetter.Equals("J") && buttonJ.Enabled)
                {
                    buttonA2Z_Click(buttonJ, e);
                }
                else if (tmpLetter.Equals("K") && buttonK.Enabled)
                {
                    buttonA2Z_Click(buttonK, e);
                }
                else if (tmpLetter.Equals("L") && buttonL.Enabled)
                {
                    buttonA2Z_Click(buttonL, e);
                }
                else if (tmpLetter.Equals("M") && buttonM.Enabled)
                {
                    buttonA2Z_Click(buttonM, e);
                }
                else if (tmpLetter.Equals("N") && buttonN.Enabled)
                {
                    buttonA2Z_Click(buttonN, e);
                }
                else if (tmpLetter.Equals("O") && buttonO.Enabled)
                {
                    buttonA2Z_Click(buttonO, e);
                }
                else if (tmpLetter.Equals("P") && buttonP.Enabled)
                {
                    buttonA2Z_Click(buttonP, e);
                }
                else if (tmpLetter.Equals("Q") && buttonQ.Enabled)
                {
                    buttonA2Z_Click(buttonQ, e);
                }
                else if (tmpLetter.Equals("R") && buttonR.Enabled)
                {
                    buttonA2Z_Click(buttonR, e);
                }
                else if (tmpLetter.Equals("S") && buttonS.Enabled)
                {
                    buttonA2Z_Click(buttonS, e);
                }
                else if (tmpLetter.Equals("T") && buttonT.Enabled)
                {
                    buttonA2Z_Click(buttonT, e);
                }
                else if (tmpLetter.Equals("U") && buttonU.Enabled)
                {
                    buttonA2Z_Click(buttonU, e);
                }
                else if (tmpLetter.Equals("V") && buttonV.Enabled)
                {
                    buttonA2Z_Click(buttonV, e);
                }
                else if (tmpLetter.Equals("W") && buttonW.Enabled)
                {
                    buttonA2Z_Click(buttonW, e);
                }
                else if (tmpLetter.Equals("X") && buttonX.Enabled)
                {
                    buttonA2Z_Click(buttonX, e);
                }
                else if (tmpLetter.Equals("Y") && buttonY.Enabled)
                {
                    buttonA2Z_Click(buttonY, e);
                }
                else if (tmpLetter.Equals("Z") && buttonZ.Enabled)
                {
                    buttonA2Z_Click(buttonZ, e);
                }
                else
                {

                }
            }
            else
            {
                if (e.Modifiers == Keys.Control)
                {

                }
            }
        }
        

        
        
    }
}
