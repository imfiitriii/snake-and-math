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
            System.Windows.Forms.Button btnDice;
            this.lblLevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.pcbGameTitle = new System.Windows.Forms.PictureBox();
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.diceLbl = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            btnDice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbGameTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDice
            // 
            btnDice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnDice.BackgroundImage = global::SnakeAndMath.Properties.Resources.dice_canva_removebg_preview__1_;
            btnDice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnDice.FlatAppearance.BorderSize = 0;
            btnDice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            btnDice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDice.ForeColor = System.Drawing.Color.White;
            btnDice.Location = new System.Drawing.Point(974, 343);
            btnDice.Name = "btnDice";
            btnDice.Size = new System.Drawing.Size(93, 93);
            btnDice.TabIndex = 6;
            btnDice.UseVisualStyleBackColor = true;
            btnDice.Click += new System.EventHandler(this.btnDice_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLevel.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLevel.Location = new System.Drawing.Point(893, 158);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(281, 40);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Easy";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(917, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 41);
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
            this.lblPlayer.Location = new System.Drawing.Point(1073, 256);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(47, 40);
            this.lblPlayer.TabIndex = 5;
            this.lblPlayer.Text = "1";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayer.Click += new System.EventHandler(this.lblPlayer_Click);
            // 
            // pcbGameTitle
            // 
            this.pcbGameTitle.Image = global::SnakeAndMath.Properties.Resources.Snake_And_Math_Title;
            this.pcbGameTitle.Location = new System.Drawing.Point(893, 42);
            this.pcbGameTitle.Name = "pcbGameTitle";
            this.pcbGameTitle.Size = new System.Drawing.Size(260, 75);
            this.pcbGameTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbGameTitle.TabIndex = 1;
            this.pcbGameTitle.TabStop = false;
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.Location = new System.Drawing.Point(1, 3);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(850, 816);
            this.pnlGameBoard.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.diceLbl.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diceLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diceLbl.Location = new System.Drawing.Point(1096, 498);
            this.diceLbl.Name = "diceLbl";
            this.diceLbl.Size = new System.Drawing.Size(47, 40);
            this.diceLbl.TabIndex = 9;
            this.diceLbl.Text = "?";
            this.diceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.White;
            this.lblQuestion.Location = new System.Drawing.Point(885, 562);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(289, 84);
            this.lblQuestion.TabIndex = 10;
            this.lblQuestion.Text = "-";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(940, 683);
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
            this.btnSubmit.Location = new System.Drawing.Point(983, 730);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 35);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmGameSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1205, 859);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.diceLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlGameBoard);
            this.Controls.Add(btnDice);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.pcbGameTitle);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGameSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake and Math - {difficulty}";
            this.Load += new System.EventHandler(this.frmGameSession_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbGameTitle)).EndInit();
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
    }
}