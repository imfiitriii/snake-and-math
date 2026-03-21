using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAndMath
{
    public partial class frmGameSession : Form
    {
        public string Level { get; set; } // property to hold the level information
        public int id = 0; // field to hold the ID of the question selected based on the random number generated (new)
        public string answer; // field to hold the user's answer to the question (new)
        private Question currentQuestion; // field to hold the current question object (new)
        private Random rnd = new Random();// used to generate a random number for the dice roll and question selection (new)
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
            diceLbl.Text = (rnd.Next(1, 7)).ToString();// generate a random number between 1 and 6 for dice rolling (new)
        }

        private void LoadQuestion(int id)
        {
            currentQuestion = new Question(id, Level); // create a new instance of the Question class(new)
            lblQuestion.Text = currentQuestion.DisplayQUestion(id, Level); // set the question label text to the question retrieved from the Question class based on the random ID and level(new)
        }

        private void frmGameSession_Load(object sender, EventArgs e)
        {
            pnlGameBoard.Controls.Clear();     // optional: remove previous form
            gameBoard.TopLevel = false;         // make it behave like a control
            gameBoard.Dock = DockStyle.Fill;    // fill the panel
            pnlGameBoard.Controls.Add(gameBoard);     // add form to panel
            gameBoard.Show();                   // display the form
            id = rnd.Next(1, 21);              // select a random question ID between 1 and 20 (new)

            //set label text to the level selected in the previous form
            lblLevel.Text = Level;

            LoadQuestion(id);
         
        }

        private void btnSubmit_Click(object sender, EventArgs e)// event handler for the submit button click event(new)
        {
            answer = txtAnswer.Text;
            if (currentQuestion.CheckAnswer(answer))// check if the user's answer is correct using the CheckAnswer method of the Question class
            {
                MessageBox.Show("Correct!");

            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
        }
    }
}
