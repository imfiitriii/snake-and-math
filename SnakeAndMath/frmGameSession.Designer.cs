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
            this.label2 = new System.Windows.Forms.Label();
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
            this.btnDice.Location = new System.Drawing.Point(730, 279);
            this.btnDice.Margin = new System.Windows.Forms.Padding(2);
            this.btnDice.Name = "btnDice";
            this.btnDice.Size = new System.Drawing.Size(70, 76);
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
            this.lblLevel.Location = new System.Drawing.Point(670, 128);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(211, 33);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Easy";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLevel.Click += new System.EventHandler(this.lblLevel_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(688, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Player : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayer.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlayer.Location = new System.Drawing.Point(805, 208);
            this.lblPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(35, 32);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "1";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayer.Click += new System.EventHandler(this.lblPlayer_Click);
            // 
            // pcbGameTitle
            // 
            this.pcbGameTitle.Image = global::SnakeAndMath.Properties.Resources.Snake_And_Math_Title;
            this.pcbGameTitle.Location = new System.Drawing.Point(670, 34);
            this.pcbGameTitle.Margin = new System.Windows.Forms.Padding(2);
            this.pcbGameTitle.Name = "pcbGameTitle";
            this.pcbGameTitle.Size = new System.Drawing.Size(195, 61);
            this.pcbGameTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGameTitle.TabIndex = 1;
            this.pcbGameTitle.TabStop = false;
            this.pcbGameTitle.Click += new System.EventHandler(this.pcbGameTitle_Click);
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.BackgroundImage = global::SnakeAndMath.Properties.Resources.Snake_and_Ladder_No_Background1;
            this.pnlGameBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGameBoard.Controls.Add(this.lblToken);
            this.pnlGameBoard.Controls.Add(this.label3);
            this.pnlGameBoard.Location = new System.Drawing.Point(1, 2);
            this.pnlGameBoard.Margin = new System.Windows.Forms.Padding(2);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(638, 663);
            this.pnlGameBoard.TabIndex = 7;
            // 
            // lblToken
            // 
            this.lblToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblToken.Location = new System.Drawing.Point(22, 610);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(22, 23);
            this.lblToken.TabIndex = 1;
            this.lblToken.Text = "★";
            this.lblToken.Click += new System.EventHandler(this.lblToken_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Instruction";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(665, 404);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dice Rolled :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diceLbl
            // 
            this.diceLbl.BackColor = System.Drawing.Color.Transparent;
            this.diceLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.diceLbl.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diceLbl.Location = new System.Drawing.Point(821, 404);
            this.diceLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diceLbl.Name = "diceLbl";
            this.diceLbl.Size = new System.Drawing.Size(35, 32);
            this.diceLbl.TabIndex = 9;
            this.diceLbl.Text = "?";
            this.diceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Arial Narrow", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(664, 457);
            this.lblQuestion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(217, 68);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "  a";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(705, 555);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(136, 26);
            this.txtAnswer.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Aqua;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Location = new System.Drawing.Point(737, 593);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(74, 28);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmGameSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(904, 698);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.diceLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGameBoard);
            this.Controls.Add(this.btnDice);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.pcbGameTitle);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmGameSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake and Math - {difficulty}";
            this.Load += new System.EventHandler(this.frmGameSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGameTitle)).EndInit();
            this.pnlGameBoard.ResumeLayout(false);
            this.pnlGameBoard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbGameTitle;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label2;
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
    }
}