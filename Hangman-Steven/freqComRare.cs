using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman_Steven
{
    public partial class freqComRare : Form
    {
        public Configure configure;

        public freqComRare()
        {
            InitializeComponent();
        }

        

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        //根据选择，修改configure中的public值（告知configure，客户选了什么）
        private void okButton_Click(object sender, EventArgs e)
        {
            if (frequentLetter.Checked == true)
            {
                configure.chooseFreqCommRare = 1;
            }
            else if (commonLetter.Checked == true)
            {
                configure.chooseFreqCommRare = 2;
            }
            else if (rareLetter.Checked == true)
            {
                configure.chooseFreqCommRare = 3;
            }
            else 
            {
                MessageBox.Show("Error! this message should not be showed, if do, the code is wrong!");
            }

            this.Close();
        }




















        //无用方法-不必写任何内容
        private void frequentLetter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void commonLetter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rareLetter_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frequencyPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
