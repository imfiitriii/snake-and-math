using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAndMath
{
    public partial class frmSelectLevel : Form
    {
        
        public frmSelectLevel()
        {
            InitializeComponent(); //DO NOT TOUCH
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            frmGameSession gameSession = new frmGameSession(); //create instance of a game window
            gameSession.Level = "Hard"; //change level label in game window to hard
            gameSession.ShowDialog(); //open game window
            this.Close();
            
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            frmGameSession gameSession = new frmGameSession(); //create instance of a game window
            gameSession.Level = "Medium"; ;
            gameSession.ShowDialog(); //open game window
            this.Close();
            
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            frmGameSession gameSession = new frmGameSession(); //create instance of a game window
            gameSession.Level = "Easy"; 
            gameSession.ShowDialog(); //open game window
            this.Close();
            
        }

        private void btn4Player_Click(object sender, EventArgs e)
        {
            frmGameSession gameSession = new frmGameSession(); //create instance of a game window
            gameSession.Level = "4 Player";
            gameSession.ShowDialog(); //open game window
            this.Close();
        }
    }
}
