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



namespace Hangman_Steven
{
    


    public partial class Configure : Form
    {
        public Hangman mainForm;

        public Configure()
        {
            InitializeComponent();
        }

        //
        public int chooseFreqCommRare = 1;


        //根据1-3的值改变button的背景色
        public void num2BackColor(Button bt,int chooseFreqCommRare) 
        {
            if (chooseFreqCommRare == 1)
            {
                bt.BackColor = frequentButton.BackColor;
            }
            else if (chooseFreqCommRare == 2) 
            {
                bt.BackColor = commonButton.BackColor;
            }
            else if (chooseFreqCommRare == 3)
            {
                bt.BackColor = rareButton.BackColor;
            }
            else
            {
                MessageBox.Show("Error! this message should not be showed, if do, the code is wrong!");
            }
        }



        //读配置文件，初始化配置窗口
        private void readConfigureFile()
        {
            try
            {
                FileStream fs = new FileStream("configureFile.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string srLine = sr.ReadLine();
                wordTrackBar.Value = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterTrackBar.Value = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                timerLength.Value = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                chooseSpeakLetter.Value = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                chooseTeamMode.Value = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                chooseLetterDisplay.Value = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                letterFailureText.Text = srLine;
                srLine = sr.ReadLine();
                letterSuccessText.Text = srLine;
                srLine = sr.ReadLine();
                loseGameText.Text = srLine;
                srLine = sr.ReadLine();
                gameWonText.Text = srLine;
                srLine = sr.ReadLine();
                int rValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                int gValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                int bValue = Int32.Parse(srLine);
                unclickedButton.BackColor = Color.FromArgb(rValue, gValue, bValue);
                srLine = sr.ReadLine();
                rValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                gValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                bValue = Int32.Parse(srLine);
                usedButton.BackColor = Color.FromArgb(rValue, gValue, bValue);
                srLine = sr.ReadLine();
                rValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                gValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                bValue = Int32.Parse(srLine);
                failedButton.BackColor = Color.FromArgb(rValue, gValue, bValue);
                srLine = sr.ReadLine();
                chooseFontSize.Value = Int32.Parse(srLine);
                //读9个数字，组合出3个Freq-Comm-Rare背景色
                srLine = sr.ReadLine();
                rValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                gValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                bValue = Int32.Parse(srLine);
                frequentButton.BackColor = Color.FromArgb(rValue, gValue, bValue);
                srLine = sr.ReadLine();
                rValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                gValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                bValue = Int32.Parse(srLine);
                commonButton.BackColor = Color.FromArgb(rValue, gValue, bValue);
                srLine = sr.ReadLine();
                rValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                gValue = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                bValue = Int32.Parse(srLine);
                rareButton.BackColor = Color.FromArgb(rValue, gValue, bValue);
                //读26个数字，据此设置键盘26键的背景色
                srLine = sr.ReadLine();
                num2BackColor(buttonA, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonB, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonC, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonD, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonE, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonF, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonG, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonH, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonI, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonJ, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonK, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonL, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonM, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonN, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonO, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonP, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonQ, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonR, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonS, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonT, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonU, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonV, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonW, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonX, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonY, Int32.Parse(srLine));
                srLine = sr.ReadLine();
                num2BackColor(buttonZ, Int32.Parse(srLine));
                //读6个数字，初始化加分减分权值
                srLine = sr.ReadLine();
                chooseFrequentSuccess.Value = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                chooseFrequentFailure.Value = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                chooseCommonSuccess.Value = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                chooseCommonFailure.Value = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                chooseRareSuccess.Value = Int32.Parse(srLine);
                srLine = sr.ReadLine();
                chooseRareFailure.Value = Int32.Parse(srLine);
                //读一个数字，初始化每次失败出现的身体部分数目
                srLine = sr.ReadLine();
                choosePenalty.Value = Int32.Parse(srLine);
                //读一个字符串，数据文件存储路径
                srLine = sr.ReadLine();
                dataFileText.Text = srLine;

                sr.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error! Check configureFile.txt");
                return;
            }
        }

        //配置窗口控件布局
        private void setPosition()
        {
            //configure窗口位置和大小
            this.Location = new Point(0, 0);
            this.Width = 1100;
            this.Height = 620;
            

            //其他控件布局
            int widthDiv3 = this.Width / 3;
            int disMove = 10;//控件缩进距离
            int disBetweenLine = 5;//控件纵向的间距大小
            int disBetweenColum = 5;//同行控件的横向间距大小
            verticalLine1.Location = new Point(widthDiv3, 0);
            verticalLine1.Height = this.Height;
            verticalLine2.Location = new Point(widthDiv3 * 2, 0);
            verticalLine2.Height = this.Height;

            distanceLabel.Location = new Point(0, 0);
            wordLabel.Location = new Point(disMove, distanceLabel.Height + disBetweenLine);
            //wordTrackBar.Location = new Point(wordLabel.Location.X + wordLabel.Width+disBetweenColum, wordLabel.Location.Y);
            letterLabel.Location = new Point(disMove, wordLabel.Location.Y + wordLabel.Height + disBetweenLine);
            letterTrackBar.Location = new Point(letterLabel.Location.X + letterLabel.Width + disBetweenColum, letterLabel.Location.Y);
            wordTrackBar.Location = new Point(letterTrackBar.Location.X, wordLabel.Location.Y);
            wordTrackBar.Width = letterTrackBar.Width;
            wordTrackBar.Height = letterTrackBar.Height;
            numberLabel1.Location = new Point(letterTrackBar.Location.X, letterLabel.Location.Y + letterLabel.Height + disBetweenLine);
            
            TimerLabel.Location = new Point(0, numberLabel1.Location.Y + numberLabel1.Height + disBetweenLine * 5);
            timerLength.Location = new Point(TimerLabel.Location.X + TimerLabel.Width + disBetweenColum, TimerLabel.Location.Y);
            secondsLabel.Location = new Point(timerLength.Location.X + timerLength.Width + disBetweenColum, timerLength.Location.Y);

            dataFileLabel.Location = new Point(0, TimerLabel.Location.Y + TimerLabel.Height +disBetweenLine * 5);
            dataFileText.Location = new Point(disMove, dataFileLabel.Location.Y + dataFileLabel.Height +disBetweenLine);
            chooseDataFilebutton.Location = new Point(verticalLine1.Location.X - chooseDataFilebutton.Width - disBetweenColum,dataFileText.Location.Y);
            dataFileText.Width = chooseDataFilebutton.Location.X - disBetweenColum * 3;

            modeLabel.Location = new Point(0, dataFileText.Location.Y + dataFileText.Height + disBetweenLine * 5);
            speakLetterLabel.Location = new Point(disMove, modeLabel.Location.Y + modeLabel.Height + disBetweenLine);
            teamModeLabel.Location = new Point(disMove, speakLetterLabel.Location.Y + speakLetterLabel.Height + disBetweenLine * 3);
            letterDisplayLabel.Location = new Point(disMove, teamModeLabel.Location.Y + teamModeLabel.Height + disBetweenLine * 3);
            chooseLetterDisplay.Location = new Point(letterDisplayLabel.Location.X+letterDisplayLabel.Width+disBetweenColum, letterDisplayLabel.Location.Y);
            chooseSpeakLetter.Location = new Point(chooseLetterDisplay.Location.X, speakLetterLabel.Location.Y);
            chooseTeamMode.Location = new Point(chooseLetterDisplay.Location.X, teamModeLabel.Location.Y);

            //键盘布局
            buttonPanel.Location = new Point(0, letterDisplayLabel.Location.Y + letterDisplayLabel.Height + disBetweenLine * 10);

            //第二栏
            int startX1=verticalLine1.Location.X+verticalLine1.Width;
            perferenceLabel.Location = new Point(startX1, 0);

            musicLabel.Location = new Point(startX1 + disMove, perferenceLabel.Height + disBetweenLine);
            
            letterFailureLabel.Location = new Point(musicLabel.Location.X , musicLabel.Location.Y + musicLabel.Height + disBetweenLine);
            letterFailureText.Location = new Point(letterFailureLabel.Location.X, letterFailureLabel.Location.Y + letterFailureLabel.Height + disBetweenLine);
            chooseFailureButton.Location = new Point(verticalLine2.Location.X - chooseFailureButton.Width - disBetweenColum * 3, letterFailureText.Location.Y);
            letterFailureText.Width = chooseFailureButton.Location.X - letterFailureText.Location.X - disBetweenColum;

            letterSuccessLabel.Location = new Point(startX1 + disMove, chooseFailureButton.Location.Y + chooseFailureButton.Height + disBetweenLine);
            letterSuccessText.Location = new Point(letterSuccessLabel.Location.X, letterSuccessLabel.Location.Y + letterSuccessLabel.Height + disBetweenLine);
            chooseSuccessButton.Location = new Point(verticalLine2.Location.X - chooseSuccessButton.Width - disBetweenColum * 3, letterSuccessText.Location.Y);
            letterSuccessText.Width = letterFailureText.Width;

            loseLabel.Location=new Point(startX1+disMove,chooseSuccessButton.Location.Y+chooseSuccessButton.Height+disBetweenLine);
            loseGameText.Location=new Point(loseLabel.Location.X,loseLabel.Location.Y+loseLabel.Height+disBetweenLine);
            chooseLoseButton.Location=new Point(verticalLine2.Location.X-chooseLoseButton.Width-disBetweenColum*3,loseGameText.Location.Y);
            loseGameText.Width = letterFailureText.Width;

            wonLabel.Location = new Point(startX1 + disMove, chooseLoseButton.Location.Y + chooseLoseButton.Height + disBetweenLine);
            gameWonText.Location = new Point(wonLabel.Location.X, wonLabel.Location.Y + wonLabel.Height + disBetweenLine);
            chooseWonButton.Location = new Point(verticalLine2.Location.X - chooseWonButton.Width - disBetweenColum * 3, gameWonText.Location.Y);
            gameWonText.Width = letterFailureText.Width;

            colorLabel.Location = new Point(musicLabel.Location.X, gameWonText.Location.Y + gameWonText.Height + disBetweenLine * 5);
            unclickedButton.Location = new Point(colorLabel.Location.X, colorLabel.Location.Y + colorLabel.Height + disBetweenLine);
            usedButton.Location = new Point(unclickedButton.Location.X + unclickedButton.Width + disBetweenColum*2, unclickedButton.Location.Y);
            failedButton.Location = new Point(usedButton.Location.X + usedButton.Width + disBetweenColum*2, usedButton.Location.Y);

            fontSizeLabel.Location = new Point(colorLabel.Location.X, unclickedButton.Location.Y + unclickedButton.Height + disBetweenLine * 5);
            chooseFontSize.Location = new Point(fontSizeLabel.Location.X + fontSizeLabel.Width + disBetweenColum, fontSizeLabel.Location.Y);

            //第三栏
            int startX2 = verticalLine2.Location.X + verticalLine2.Width;
            scorePanel.Location = new Point(startX2, 0);
            scorePanel.Width = 360;
            scorePanel.Height = 400;//test code
            penaltyLabel.Location = new Point(0, 0);
            int start2 = scorePanel.Width / 3;
            int start3 = scorePanel.Width * 2 / 3;
            successLabel.Location = new Point(start2, penaltyLabel.Height + disBetweenLine);
            failureLabel.Location = new Point(start3, successLabel.Location.Y);
            frequentLabel.Location = new Point(disMove, successLabel.Location.Y + successLabel.Height + disBetweenLine * 5);
            chooseFrequentSuccess.Location = new Point(start2 + disBetweenColum * 3, frequentLabel.Location.Y);
            chooseFrequentFailure.Location = new Point(start3 + disBetweenColum * 3, frequentLabel.Location.Y);
            commonLabel.Location = new Point(disMove, frequentLabel.Location.Y + frequentLabel.Height + disBetweenLine * 5);
            chooseCommonSuccess.Location = new Point(start2 + disBetweenColum * 3, commonLabel.Location.Y);
            chooseCommonFailure.Location = new Point(start3 + disBetweenColum * 3, commonLabel.Location.Y);
            rareLabel.Location = new Point(disMove, commonLabel.Location.Y + commonLabel.Height + disBetweenLine * 5);
            chooseRareSuccess.Location = new Point(start2 + disBetweenColum * 3, rareLabel.Location.Y);
            chooseRareFailure.Location = new Point(start3 + disBetweenColum * 3, rareLabel.Location.Y);

            timeOutPenaltyLabel.Location = new Point(0, rareLabel.Location.Y + rareLabel.Height + disBetweenLine * 10);
            choosePenalty.Location = new Point(disMove*5, timeOutPenaltyLabel.Location.Y + timeOutPenaltyLabel.Height + disBetweenLine * 5);
            bodyPartLabel.Location = new Point(choosePenalty.Location.X + choosePenalty.Width + disBetweenColum, choosePenalty.Location.Y);

            //Cancle OK 布局
            cancleButton.Location = new Point(startX2 + disBetweenColum * 5, this.Height - cancleButton.Height - disBetweenLine * 10);
            okButton.Location = new Point(cancleButton.Location.X + cancleButton.Width + disBetweenColum * 10, cancleButton.Location.Y);
        }

        //写配置文件
        private void writeConfigureFile()
        {
            try
            {
                FileStream filestream = new FileStream("configureFile.txt", FileMode.Open);
                StreamWriter sw = new StreamWriter(filestream);
                sw.WriteLine(mainForm.wordDistance.ToString());
                sw.WriteLine(mainForm.letterDistance.ToString());
                sw.WriteLine(mainForm.timerValue.ToString());
                sw.WriteLine(mainForm.speakLetterMode.ToString());
                sw.WriteLine(mainForm.teamsMode.ToString());
                sw.WriteLine(mainForm.displayTime.ToString());
                sw.WriteLine(mainForm.letterFailure);
                sw.WriteLine(mainForm.letterSuccess);
                sw.WriteLine(mainForm.loseGame);
                sw.WriteLine(mainForm.gameWon);
                sw.WriteLine(mainForm.unClickedColor.R.ToString());
                sw.WriteLine(mainForm.unClickedColor.G.ToString());
                sw.WriteLine(mainForm.unClickedColor.B.ToString());
                sw.WriteLine(mainForm.usedColor.R.ToString());
                sw.WriteLine(mainForm.usedColor.G.ToString());
                sw.WriteLine(mainForm.usedColor.B.ToString());
                sw.WriteLine(mainForm.failedColor.R.ToString());
                sw.WriteLine(mainForm.failedColor.G.ToString());
                sw.WriteLine(mainForm.failedColor.B.ToString());
                sw.WriteLine(Hangman.fontSize.ToString());

                sw.WriteLine(frequentButton.BackColor.R.ToString());
                sw.WriteLine(frequentButton.BackColor.G.ToString());
                sw.WriteLine(frequentButton.BackColor.B.ToString());
                sw.WriteLine(commonButton.BackColor.R.ToString());
                sw.WriteLine(commonButton.BackColor.G.ToString());
                sw.WriteLine(commonButton.BackColor.B.ToString());
                sw.WriteLine(rareButton.BackColor.R.ToString());
                sw.WriteLine(rareButton.BackColor.G.ToString());
                sw.WriteLine(rareButton.BackColor.B.ToString());

                sw.WriteLine(BackColor2Num(buttonA));
                sw.WriteLine(BackColor2Num(buttonB));
                sw.WriteLine(BackColor2Num(buttonC));
                sw.WriteLine(BackColor2Num(buttonD));
                sw.WriteLine(BackColor2Num(buttonE));
                sw.WriteLine(BackColor2Num(buttonF));
                sw.WriteLine(BackColor2Num(buttonG));
                sw.WriteLine(BackColor2Num(buttonH));
                sw.WriteLine(BackColor2Num(buttonI));
                sw.WriteLine(BackColor2Num(buttonJ));
                sw.WriteLine(BackColor2Num(buttonK));
                sw.WriteLine(BackColor2Num(buttonL));
                sw.WriteLine(BackColor2Num(buttonM));
                sw.WriteLine(BackColor2Num(buttonN));
                sw.WriteLine(BackColor2Num(buttonO));
                sw.WriteLine(BackColor2Num(buttonP));
                sw.WriteLine(BackColor2Num(buttonQ));
                sw.WriteLine(BackColor2Num(buttonR));
                sw.WriteLine(BackColor2Num(buttonS));
                sw.WriteLine(BackColor2Num(buttonT));
                sw.WriteLine(BackColor2Num(buttonU));
                sw.WriteLine(BackColor2Num(buttonV));
                sw.WriteLine(BackColor2Num(buttonW));
                sw.WriteLine(BackColor2Num(buttonX));
                sw.WriteLine(BackColor2Num(buttonY));
                sw.WriteLine(BackColor2Num(buttonZ));

                sw.WriteLine(chooseFrequentSuccess.Value);
                sw.WriteLine(chooseFrequentFailure.Value);
                sw.WriteLine(chooseCommonSuccess.Value);
                sw.WriteLine(chooseCommonFailure.Value);
                sw.WriteLine(chooseRareSuccess.Value);
                sw.WriteLine(chooseRareFailure.Value);

                sw.WriteLine(choosePenalty.Value);

                sw.WriteLine(dataFileText.Text);

                sw.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex+"\nError! Check configureFile.txt");
                return;
            }

            //
            this.Close();
        }

        //读键的背景色，与Freq-Comm-Rare键的背景色做对比，返回1-3值（出错的情况下返回4）
        private int BackColor2Num(Button bt) 
        {
            if (bt.BackColor == frequentButton.BackColor)
            {
                return 1;
            }
            else if(bt.BackColor==commonButton.BackColor)
            {
                return 2;
            }
            else if (bt.BackColor == rareButton.BackColor)
            {
                return 3;
            }
            else 
            {
                MessageBox.Show("Error! this message should not be showed, if do, the code is wrong!");
                return 4;
            }
        }

        //向主界面提交表单信息
        private void updateMainForm()
        {
            //Distance+Timer+Mode
            mainForm.wordDistance = wordTrackBar.Value; //在StartGame_Click落实
            mainForm.letterDistance = letterTrackBar.Value; //在StartGame_Click落实
            mainForm.timerValue = Int32.Parse(timerLength.Value.ToString());
            mainForm.speakLetterMode = Int32.Parse(chooseSpeakLetter.Value.ToString());
            mainForm.teamsMode = Int32.Parse(chooseTeamMode.Value.ToString());
            mainForm.displayTime = Int32.Parse(chooseLetterDisplay.Value.ToString());
            //Perference-Voice
            mainForm.letterFailure = letterFailureText.Text;
            mainForm.letterSuccess = letterSuccessText.Text;
            mainForm.loseGame = loseGameText.Text;
            mainForm.gameWon = gameWonText.Text;
            //Perference-Color
            mainForm.unClickedColor = unclickedButton.BackColor;
            mainForm.usedColor = usedButton.BackColor;
            mainForm.failedColor = failedButton.BackColor;
            //Perference-Fontsize
            Hangman.fontSize = Int32.Parse(chooseFontSize.Value.ToString());
            //frequent(1)-common(2)-rare(3) letters
            mainForm.letterA = BackColor2Num(buttonA);
            mainForm.letterB = BackColor2Num(buttonB);
            mainForm.letterC = BackColor2Num(buttonC);
            mainForm.letterD = BackColor2Num(buttonD);
            mainForm.letterE = BackColor2Num(buttonE);
            mainForm.letterF = BackColor2Num(buttonF);
            mainForm.letterG = BackColor2Num(buttonG);
            mainForm.letterH = BackColor2Num(buttonH);
            mainForm.letterI = BackColor2Num(buttonI);
            mainForm.letterJ = BackColor2Num(buttonJ);
            mainForm.letterK = BackColor2Num(buttonK);
            mainForm.letterL = BackColor2Num(buttonL);
            mainForm.letterM = BackColor2Num(buttonM);
            mainForm.letterN = BackColor2Num(buttonN);
            mainForm.letterO = BackColor2Num(buttonO);
            mainForm.letterP = BackColor2Num(buttonP);
            mainForm.letterQ = BackColor2Num(buttonQ);
            mainForm.letterR = BackColor2Num(buttonR);
            mainForm.letterS = BackColor2Num(buttonS);
            mainForm.letterT = BackColor2Num(buttonT);
            mainForm.letterU = BackColor2Num(buttonU); 
            mainForm.letterV = BackColor2Num(buttonV);
            mainForm.letterW = BackColor2Num(buttonW);
            mainForm.letterX = BackColor2Num(buttonX);
            mainForm.letterY = BackColor2Num(buttonY);
            mainForm.letterZ = BackColor2Num(buttonZ);

            //Hangman.letterZ = BackColor2Num(buttonZ);

            //letter values
            mainForm.frequentSuccess = Int32.Parse(chooseFrequentSuccess.Value.ToString());
            mainForm.frequentFailure = Int32.Parse(chooseFrequentFailure.Value.ToString());
            mainForm.commonSuccess = Int32.Parse(chooseCommonSuccess.Value.ToString());
            mainForm.commonFailure = Int32.Parse(chooseCommonFailure.Value.ToString());
            mainForm.rareSuccess = Int32.Parse(chooseRareSuccess.Value.ToString());
            mainForm.rareFailure = Int32.Parse(chooseRareFailure.Value.ToString());
            //Time out penalty(body parts)
            mainForm.timeOutPenalty = Int32.Parse(choosePenalty.Value.ToString());
            //dataFilePath
            mainForm.dataFilePath = dataFileText.Text;
            
        }

        //弹出选择文件窗口
        private string chooseFileDiag(string primaryString)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    return openFileDialog.FileName;
                }
                else
                {
                    return primaryString;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return primaryString;
            }
        }

        //弹出Frequency选择窗口
        private void chooseFrequency()
        {
            freqComRare fcr = new freqComRare();
            fcr.configure = this;
            fcr.ShowDialog();//限制用户只能操作当前Frequency窗口，以免同时产生两个Frequency窗口
        }


        //配置窗口出现时的初始化程序
        private void configureForm_Load(object sender, EventArgs e)
        {
            //读配置文件，初始化配置窗口
            readConfigureFile();

            //配置窗口控件布局
            setPosition();
            
        }

        
        //Perference-Music
        private void chooseFailureButton_Click(object sender, EventArgs e)
        {
            //弹出选择文件窗口
            letterFailureText.Text = chooseFileDiag(letterFailureText.Text);
        }

        private void chooseSuccessButton_Click(object sender, EventArgs e)
        {
            //弹出选择文件窗口
            letterSuccessText.Text = chooseFileDiag(letterSuccessText.Text);
        }

        private void chooseLoseButton_Click(object sender, EventArgs e)
        {
            //弹出选择文件窗口
            loseGameText.Text = chooseFileDiag(loseGameText.Text);
        }

        private void chooseWonButton_Click(object sender, EventArgs e)
        {
            //弹出选择文件窗口
            gameWonText.Text = chooseFileDiag(gameWonText.Text);
        } 


        //Perference-Color
        private void unclickedButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            unclickedButton.BackColor = colorDialog.Color;
        }

        private void usedButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            usedButton.BackColor = colorDialog.Color;
        }

        private void failedButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            failedButton.BackColor = colorDialog.Color;
        }




        //Cancle
        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ok
        private void okButton_Click(object sender, EventArgs e)
        {
            //检查合理性(可能还需要继续补充其他代码，检查其他变量的合理性)
            if (letterTrackBar.Value >= wordTrackBar.Value)
            {
                MessageBox.Show("letter distance >= word distance is unresonable.\nMake sure letter distance < word distance.\nPlease set again.");
                return;
            }

            if (Int32.Parse(chooseTeamMode.Value.ToString()) == 1)
            {
                chooseTeamMode.Value = 0;
            }
            
            
            //向主界面提交表单信息
            updateMainForm();
            

            
            ///////////////////////
            //调用主界面public函数，落实表单内容
            //（并非所有内容都需要调用函数，注意！）
            //只要没有在StartGame_Click以及此后落实的，都要在这里落实
            ///////////////////////

            mainForm.checkTeamsMode();
            mainForm.unClickButtons();
            mainForm.checkFontSize();//更新字号
            //计算每行能显示的字符数目
            //要想数对的前提：数之前FontSize确定了，并且根据这个变量重新生成了Font并且应用到了mainScreen上
            //并且mainScreen的Width确定了（即：必须在setPosition()函数执行之后）
            //如果FontSize/mainScreen.Width改变了，必须重新调用。
            mainForm.getLetterNumEveryLine();

            mainForm.setWordWrap();


            //写配置文件
            writeConfigureFile();
        }






        





        //无用方法-不必写任何内容
        private void timerLength_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chooseSpeakLetter_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chooseTeamMode_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chooseLetterDisplay_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lineLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lineLabel2_Click(object sender, EventArgs e)
        {

        }

        private void verticalLine1_Click(object sender, EventArgs e)
        {

        }

        private void wordTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void letterTrackBar_Scroll(object sender, EventArgs e)
        {

        }









        

        
        //显示各个字母被配置成Frequent-Common-Rare的状态
        private void buttonA_Click(object sender, EventArgs e)
        {
            chooseFrequency();
            num2BackColor(buttonA, chooseFreqCommRare);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {

        }

        private void buttonC_Click(object sender, EventArgs e)
        {

        }

        private void buttonD_Click(object sender, EventArgs e)
        {

        }

        private void buttonE_Click(object sender, EventArgs e)
        {

        }

        private void buttonF_Click(object sender, EventArgs e)
        {

        }

        private void buttonG_Click(object sender, EventArgs e)
        {

        }

        private void buttonH_Click(object sender, EventArgs e)
        {

        }

        private void buttonI_Click(object sender, EventArgs e)
        {

        }

        private void buttonJ_Click(object sender, EventArgs e)
        {

        }

        private void buttonK_Click(object sender, EventArgs e)
        {

        }

        private void buttonL_Click(object sender, EventArgs e)
        {

        }

        private void buttonM_Click(object sender, EventArgs e)
        {

        }

        private void buttonN_Click(object sender, EventArgs e)
        {

        }

        private void buttonO_Click(object sender, EventArgs e)
        {

        }

        private void buttonP_Click(object sender, EventArgs e)
        {

        }

        private void buttonQ_Click(object sender, EventArgs e)
        {

        }

        private void buttonR_Click(object sender, EventArgs e)
        {

        }

        private void buttonS_Click(object sender, EventArgs e)
        {

        }

        private void buttonT_Click(object sender, EventArgs e)
        {

        }

        private void buttonU_Click(object sender, EventArgs e)
        {

        }

        private void buttonV_Click(object sender, EventArgs e)
        {

        }

        private void buttonW_Click(object sender, EventArgs e)
        {

        }

        private void buttonX_Click(object sender, EventArgs e)
        {

        }

        private void buttonY_Click(object sender, EventArgs e)
        {

        }

        private void buttonZ_Click(object sender, EventArgs e)
        {

        }



        //检查buttonA-buttonZ，如果背景色与bckColor一样，就将其背景色改成newColor
        private void checkBackColor(Color bckColor,Color newColor)
        {
            if (buttonA.BackColor == bckColor)
                buttonA.BackColor = newColor;
            if (buttonB.BackColor == bckColor)
                buttonB.BackColor = newColor;
            if (buttonC.BackColor == bckColor)
                buttonC.BackColor = newColor;
            if (buttonD.BackColor == bckColor)
                buttonD.BackColor = newColor;
            if (buttonE.BackColor == bckColor)
                buttonE.BackColor = newColor;
            if (buttonF.BackColor == bckColor)
                buttonF.BackColor = newColor;
            if (buttonG.BackColor == bckColor)
                buttonG.BackColor = newColor;
            if (buttonH.BackColor == bckColor)
                buttonH.BackColor = newColor;
            if (buttonI.BackColor == bckColor)
                buttonI.BackColor = newColor;
            if (buttonJ.BackColor == bckColor)
                buttonJ.BackColor = newColor;
            if (buttonK.BackColor == bckColor)
                buttonK.BackColor = newColor;
            if (buttonL.BackColor == bckColor)
                buttonL.BackColor = newColor;
            if (buttonM.BackColor == bckColor)
                buttonM.BackColor = newColor;
            if (buttonN.BackColor == bckColor)
                buttonN.BackColor = newColor;
            if (buttonO.BackColor == bckColor)
                buttonO.BackColor = newColor;
            if (buttonP.BackColor == bckColor)
                buttonP.BackColor = newColor;
            if (buttonQ.BackColor == bckColor)
                buttonQ.BackColor = newColor;
            if (buttonR.BackColor == bckColor)
                buttonR.BackColor = newColor;
            if (buttonS.BackColor == bckColor)
                buttonS.BackColor = newColor;
            if (buttonT.BackColor == bckColor)
                buttonT.BackColor = newColor;
            if (buttonU.BackColor == bckColor)
                buttonU.BackColor = newColor;
            if (buttonV.BackColor == bckColor)
                buttonV.BackColor = newColor;
            if (buttonW.BackColor == bckColor)
                buttonW.BackColor = newColor;
            if (buttonX.BackColor == bckColor)
                buttonX.BackColor = newColor;
            if (buttonY.BackColor == bckColor)
                buttonY.BackColor = newColor;
            if (buttonZ.BackColor == bckColor)
                buttonZ.BackColor = newColor;
        }

        //个性化配置Freq-Comm-Rare的背景色
        private void frequentButton_Click(object sender, EventArgs e)
        {
            Color tmpColor = frequentButton.BackColor;

            colorDialog.ShowDialog();
            frequentButton.BackColor = colorDialog.Color;

            //检查buttonA-buttonZ，如果背景色与bckColor一样，就将其背景色改成newColor
            checkBackColor(tmpColor, frequentButton.BackColor);

        }

        private void commonButton_Click(object sender, EventArgs e)
        {
            Color tmpColor = commonButton.BackColor;

            colorDialog.ShowDialog();
            commonButton.BackColor = colorDialog.Color;

            //检查buttonA-buttonZ，如果背景色与bckColor一样，就将其背景色改成newColor
            checkBackColor(tmpColor, commonButton.BackColor);

        }

        private void rareButton_Click(object sender, EventArgs e)
        {
            Color tmpColor = rareButton.BackColor;

            colorDialog.ShowDialog();
            rareButton.BackColor = colorDialog.Color;

            //检查buttonA-buttonZ，如果背景色与bckColor一样，就将其背景色改成newColor
            checkBackColor(tmpColor, rareButton.BackColor);

        }













        private void choosePenalty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }






        //选择默认数据库文件路径
        private void chooseDataFilebutton_Click(object sender, EventArgs e)
        {
            dataFileText.Text = chooseFileDiag(dataFileText.Text);
        }






        private void dataFileText_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPanel_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
