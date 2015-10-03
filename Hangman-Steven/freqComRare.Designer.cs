namespace Hangman_Steven
{
    partial class freqComRare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frequentLetter = new System.Windows.Forms.RadioButton();
            this.commonLetter = new System.Windows.Forms.RadioButton();
            this.frequencyPanel = new System.Windows.Forms.Panel();
            this.rareLetter = new System.Windows.Forms.RadioButton();
            this.cancleButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.frequencyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // frequentLetter
            // 
            this.frequentLetter.AutoSize = true;
            this.frequentLetter.Location = new System.Drawing.Point(45, 23);
            this.frequentLetter.Name = "frequentLetter";
            this.frequentLetter.Size = new System.Drawing.Size(150, 31);
            this.frequentLetter.TabIndex = 1;
            this.frequentLetter.TabStop = true;
            this.frequentLetter.Text = "Frequent";
            this.frequentLetter.UseVisualStyleBackColor = true;
            this.frequentLetter.CheckedChanged += new System.EventHandler(this.frequentLetter_CheckedChanged);
            // 
            // commonLetter
            // 
            this.commonLetter.AutoSize = true;
            this.commonLetter.Location = new System.Drawing.Point(45, 82);
            this.commonLetter.Name = "commonLetter";
            this.commonLetter.Size = new System.Drawing.Size(120, 31);
            this.commonLetter.TabIndex = 2;
            this.commonLetter.TabStop = true;
            this.commonLetter.Text = "Common";
            this.commonLetter.UseVisualStyleBackColor = true;
            this.commonLetter.CheckedChanged += new System.EventHandler(this.commonLetter_CheckedChanged);
            // 
            // frequencyPanel
            // 
            this.frequencyPanel.Controls.Add(this.rareLetter);
            this.frequencyPanel.Controls.Add(this.frequentLetter);
            this.frequencyPanel.Controls.Add(this.commonLetter);
            this.frequencyPanel.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.frequencyPanel.Location = new System.Drawing.Point(4, 1);
            this.frequencyPanel.Name = "frequencyPanel";
            this.frequencyPanel.Size = new System.Drawing.Size(248, 201);
            this.frequencyPanel.TabIndex = 3;
            this.frequencyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.frequencyPanel_Paint);
            // 
            // rareLetter
            // 
            this.rareLetter.AutoSize = true;
            this.rareLetter.Location = new System.Drawing.Point(45, 137);
            this.rareLetter.Name = "rareLetter";
            this.rareLetter.Size = new System.Drawing.Size(90, 31);
            this.rareLetter.TabIndex = 3;
            this.rareLetter.TabStop = true;
            this.rareLetter.Text = "Rare";
            this.rareLetter.UseVisualStyleBackColor = true;
            this.rareLetter.CheckedChanged += new System.EventHandler(this.rareLetter_CheckedChanged);
            // 
            // cancleButton
            // 
            this.cancleButton.Location = new System.Drawing.Point(99, 221);
            this.cancleButton.Name = "cancleButton";
            this.cancleButton.Size = new System.Drawing.Size(85, 31);
            this.cancleButton.TabIndex = 4;
            this.cancleButton.Text = "Cancle";
            this.cancleButton.UseVisualStyleBackColor = true;
            this.cancleButton.Click += new System.EventHandler(this.cancleButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(202, 221);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(86, 31);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // freqComRare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 259);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancleButton);
            this.Controls.Add(this.frequencyPanel);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "freqComRare";
            this.Text = "Frequency";
            this.frequencyPanel.ResumeLayout(false);
            this.frequencyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton frequentLetter;
        private System.Windows.Forms.RadioButton commonLetter;
        private System.Windows.Forms.Panel frequencyPanel;
        private System.Windows.Forms.RadioButton rareLetter;
        private System.Windows.Forms.Button cancleButton;
        private System.Windows.Forms.Button okButton;
    }
}