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

        GameBoard gameBoard = new GameBoard();
        private void frmGameSession_Load(object sender, EventArgs e)
        {
            pnlGameBoard.Controls.Clear();     // optional: remove previous form
            gameBoard.TopLevel = false;         // make it behave like a control
            gameBoard.Dock = DockStyle.Fill;    // fill the panel
            pnlGameBoard.Controls.Add(gameBoard);     // add form to panel
            gameBoard.Show();                   // display the form

            //set label text to the level selected in the previous form
            lblLevel.Text = Level;
        }
    }
}
