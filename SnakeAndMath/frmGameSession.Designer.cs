namespace SnakeAndMath
{
    partial class frmGameSession
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
            this.btnDice = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pcbGameTitle = new System.Windows.Forms.PictureBox();
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.lblToken = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diceLbl = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblStreak = new System.Windows.Forms.Label();
            this.lblPowerUps = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGameTitle)).BeginInit();
            this.pnlGameBoard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDice
            // 
            this.btnDice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDice.BackgroundImage = global::SnakeAndMath.Properties.Resources.dice_canva_removebg_preview__1_;
            this.btnDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDice.FlatAppearance.BorderSize = 0;
            this.btnDice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDice.ForeColor = System.Drawing.Color.White;
            this.btnDice.Location = new System.Drawing.Point(989, 381);
            this.btnDice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(93, 94);
            this.btnDice.TabIndex = 6;
            this.btnDice.UseVisualStyleBackColor = true;
            this.btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLevel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLevel.Location = new System.Drawing.Point(891, 132);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(281, 40);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Easy";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayer
            // 
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayer.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer.Location = new System.Drawing.Point(873, 199);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(320, 39);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "Player\'s Turn";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbGameTitle
            // 
            this.pcbGameTitle.Image = global::SnakeAndMath.Properties.Resources.Snake_And_Math_Title;
            this.pcbGameTitle.Location = new System.Drawing.Point(899, 43);
            this.pcbGameTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcbGameTitle.Name = "pcbGameTitle";
            this.pcbGameTitle.Size = new System.Drawing.Size(260, 75);
            this.pcbGameTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGameTitle.TabIndex = 1;
            this.pcbGameTitle.TabStop = false;
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.BackgroundImage = global::SnakeAndMath.Properties.Resources.Snake_and_Ladder_No_Background1;
            this.pnlGameBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGameBoard.Controls.Add(this.lblToken);
            this.pnlGameBoard.Location = new System.Drawing.Point(1, 2);
            this.pnlGameBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(851, 816);
            this.pnlGameBoard.TabIndex = 7;
            // 
            // lblToken
            // 
            this.lblToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblToken.Location = new System.Drawing.Point(29, 751);
            this.lblToken.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(29, 28);
            this.lblToken.TabIndex = 1;
            this.lblToken.Text = "★";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(859, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Instruction";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(887, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 41);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dice Rolled :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diceLbl
            // 
            this.diceLbl.BackColor = System.Drawing.Color.Transparent;
            this.diceLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diceLbl.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diceLbl.Location = new System.Drawing.Point(1095, 497);
            this.diceLbl.Name = "diceLbl";
            this.diceLbl.Size = new System.Drawing.Size(47, 39);
            this.diceLbl.TabIndex = 9;
            this.diceLbl.Text = "?";
            this.diceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Arial Narrow", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(886, 597);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(289, 84);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "  a";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(940, 701);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(180, 30);
            this.txtAnswer.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Aqua;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(983, 753);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 34);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblStreak
            // 
            this.lblStreak.BackColor = System.Drawing.Color.Transparent;
            this.lblStreak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStreak.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreak.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStreak.Location = new System.Drawing.Point(960, 238);
            this.lblStreak.Name = "lblStreak";
            this.lblStreak.Size = new System.Drawing.Size(150, 39);
            this.lblStreak.TabIndex = 13;
            this.lblStreak.Text = "Correct Streak : 0";
            this.lblStreak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStreak.Click += new System.EventHandler(this.lblStreak_Click);
            // 
            // lblPowerUps
            // 
            this.lblPowerUps.BackColor = System.Drawing.Color.Transparent;
            this.lblPowerUps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPowerUps.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerUps.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPowerUps.Location = new System.Drawing.Point(949, 268);
            this.lblPowerUps.Name = "lblPowerUps";
            this.lblPowerUps.Size = new System.Drawing.Size(171, 39);
            this.lblPowerUps.TabIndex = 14;
            this.lblPowerUps.Text = "Power Up : None";
            this.lblPowerUps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(850, 355);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 3);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Fuchsia;
            this.panel2.Location = new System.Drawing.Point(851, 571);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 2);
            this.panel2.TabIndex = 16;
            // 
            // frmGameSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1205, 859);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblPowerUps);
            this.Controls.Add(this.lblStreak);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.diceLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGameBoard);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.pcbGameTitle);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmGameSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake and Math";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGameSession_FormClosing);
            this.Load += new System.EventHandler(this.frmGameSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGameTitle)).EndInit();
            this.pnlGameBoard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbGameTitle;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label diceLbl;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDice;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label lblStreak;
        private System.Windows.Forms.Label lblPowerUps;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}