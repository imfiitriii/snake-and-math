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
            this.pnlGameBoard.BackgroundImage = global::SnakeAndMath.Properties.Resources.Snake_and_Ladder_No_Background1;
            this.pnlGameBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlGameBoard.Location = new System.Drawing.Point(1, 3);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(850, 816);
            this.pnlGameBoard.TabIndex = 7;
            // 
            // frmGameSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1205, 859);
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

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbGameTitle;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Panel pnlGameBoard;
    }
}