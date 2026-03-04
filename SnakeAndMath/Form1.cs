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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent(); //DO NOT TOUCH
        }

        private void btnPlay_Click(object sender, EventArgs e) //play button
        {
            frmSelectLevel selectLevelForm = new frmSelectLevel();
            selectLevelForm.ShowDialog(); //opening selectLevelform
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //Close app
        }
    }
}
