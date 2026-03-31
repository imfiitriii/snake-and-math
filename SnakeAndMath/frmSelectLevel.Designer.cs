namespace SnakeAndMath
{
    partial class frmSelectLevel
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
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btn4Player = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEasy
            // 
            this.btnEasy.BackColor = System.Drawing.Color.Transparent;
            this.btnEasy.BackgroundImage = global::SnakeAndMath.Properties.Resources.button_easy_2;
            this.btnEasy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEasy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEasy.FlatAppearance.BorderSize = 0;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Font = new System.Drawing.Font("Wanted M54", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEasy.Location = new System.Drawing.Point(69, 175);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(175, 296);
            this.btnEasy.TabIndex = 1;
            this.btnEasy.UseVisualStyleBackColor = false;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.Color.Transparent;
            this.btnMedium.BackgroundImage = global::SnakeAndMath.Properties.Resources.button_medium1;
            this.btnMedium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedium.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMedium.FlatAppearance.BorderSize = 0;
            this.btnMedium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedium.Font = new System.Drawing.Font("Wanted M54", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedium.Location = new System.Drawing.Point(284, 175);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(175, 296);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHard
            // 
            this.btnHard.BackColor = System.Drawing.Color.Transparent;
            this.btnHard.BackgroundImage = global::SnakeAndMath.Properties.Resources.button_hard;
            this.btnHard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHard.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHard.FlatAppearance.BorderSize = 0;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Font = new System.Drawing.Font("Wanted M54", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHard.Location = new System.Drawing.Point(499, 175);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(175, 296);
            this.btnHard.TabIndex = 3;
            this.btnHard.UseVisualStyleBackColor = false;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);
            // 
            // btn4Player
            // 
            this.btn4Player.BackColor = System.Drawing.Color.Transparent;
            this.btn4Player.BackgroundImage = global::SnakeAndMath.Properties.Resources._4_player_mode_button;
            this.btn4Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4Player.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn4Player.FlatAppearance.BorderSize = 0;
            this.btn4Player.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4Player.Font = new System.Drawing.Font("Wanted M54", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Player.Location = new System.Drawing.Point(714, 175);
            this.btn4Player.Name = "btn4Player";
            this.btn4Player.Size = new System.Drawing.Size(175, 296);
            this.btn4Player.TabIndex = 4;
            this.btn4Player.UseVisualStyleBackColor = false;
            this.btn4Player.Click += new System.EventHandler(this.btn4Player_Click);
            // 
            // frmSelectLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakeAndMath.Properties.Resources.background_select_level;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 531);
            this.Controls.Add(this.btn4Player);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnEasy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSelectLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Level";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btn4Player;
    }
}