using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAndMath
{
    public partial class frmGameSession : Form
    {
        public string Level { get; set; } // property to hold the level information
        public frmGameSession()
        {
            InitializeComponent();
        }

        public void ChangeLabelText(string message)
        {
            lblLevel.Text = message;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {

        }

        private void btnDice_Click(object sender, EventArgs e)
        {

        }

        GameBoardUI gameBoard = new GameBoardUI();
        private void frmGameSession_Load(object sender, EventArgs e)
        {
            lblLevel.Text = Level;
        }
    }
}
