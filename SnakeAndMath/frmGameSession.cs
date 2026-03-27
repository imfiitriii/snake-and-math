using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAndMath
{
    public partial class frmGameSession : Form
    {
        public string Level { get; set; }
        public int id = 0;
        public string answer;
        private Question currentQuestion;
        private Random rnd = new Random();

        private GameBoard board;
        private Player player1;

        private int currentDiceValue = 0;
        private bool waitingForAnswer = true;
        private bool waitingForDiceRoll = false;
        private bool lastAnswerCorrect = false;
        private bool isAnimating = false;

        private Control boardHost;
        private const int GridSize = 10;

        private SnakeShield snakeProtection;
        private int ConsecutiveCorrectAnswers = 0;

        public frmGameSession()
        {
            InitializeComponent();
        }

        private void LoadQuestion(int id)
        {
            currentQuestion = new Question(id, Level);
        }

        private void LoadRandomQuestion()
        {
            id = rnd.Next(1, 21);
            LoadQuestion(id);
            lblQuestion.Text = currentQuestion.DisplayQuestion();
        }

        public void ChangeLabelText(string message)
        {
            lblLevel.Text = message;
        }

        private Control FindBoardHost()
        {
            // Try likely names first
            var namedBoard = this.Controls
                .Cast<Control>()
                .FirstOrDefault(c =>
                    c.Name.ToLower().Contains("board") ||
                    c.Name.ToLower().Contains("map"));

            if (namedBoard != null)
                return namedBoard;

            // Otherwise pick the largest PictureBox that is NOT the title
            var biggestPictureBox = this.Controls
                .OfType<PictureBox>()
                .Where(p => !p.Name.ToLower().Contains("title"))
                .OrderByDescending(p => p.Width * p.Height)
                .FirstOrDefault();

            if (biggestPictureBox != null)
                return biggestPictureBox;

            // Fallback: use the form itself
            return this;
        }

        private Point GetCellCenterInBoard(int position)
        {
            if (position < 1)
                position = 1;
            if (position > 100)
                position = 100;

            int zeroBased = position - 1;
            int rowFromBottom = zeroBased / GridSize;
            int col = zeroBased % GridSize;

            // Zig-zag pattern
            if (rowFromBottom % 2 == 1)
                col = GridSize - 1 - col;

            int cellWidth = boardHost.ClientSize.Width / GridSize;
            int cellHeight = boardHost.ClientSize.Height / GridSize;

            int x = (col * cellWidth) + (cellWidth / 2);
            int y = boardHost.ClientSize.Height - (rowFromBottom * cellHeight) - (cellHeight / 2);

            return new Point(x, y);
        }

        private void EnsureTokenStyle()
        {
            lblToken.Text = "★";
            lblToken.Font = new Font("Segoe UI Symbol", 14, FontStyle.Bold);
            lblToken.ForeColor = Color.Gold;
            lblToken.AutoSize = true;

            if (boardHost != null && lblToken.Parent != boardHost)
            {
                lblToken.Parent = boardHost;
                lblToken.BackColor = Color.Transparent;
            }

            lblToken.BringToFront();
        }

        private void MovePlayerLabel()
        {
            if (boardHost == null)
                return;

            EnsureTokenStyle();

            Point center = GetCellCenterInBoard(player1.Position);

            lblToken.Left = center.X - (lblToken.Width / 2);
            lblToken.Top = center.Y - (lblToken.Height / 2);
            lblToken.BringToFront();
        }

        private async Task AnimatePlayerMovement(int fromPosition, int toPosition)
        {
            if (fromPosition == toPosition)
            {
                player1.SetPosition(toPosition);
                MovePlayerLabel();
                return;
            }

            isAnimating = true;
            btnSubmit.Enabled = false;
            btnDice.Enabled = false;

            int step = fromPosition < toPosition ? 1 : -1;

            for (int pos = fromPosition + step;
                 step > 0 ? pos <= toPosition : pos >= toPosition;
                 pos += step)
            {
                player1.SetPosition(pos);
                MovePlayerLabel();
                label3.Text = "Position: " + player1.Position;
                await Task.Delay(180);
            }

            isAnimating = false;
        }

        private void frmGameSession_Load(object sender, EventArgs e)
        {
            board = new GameBoard();
            player1 = new Player(1, "Player 1");
            player1.SetPosition(1);

            boardHost = FindBoardHost();

            lblLevel.Text = Level;
            lblPlayer.Text = "Player : " + player1.Name;
            diceLbl.Text = "";
            label3.Text = "Answer the question first.";
            txtAnswer.Clear();

            waitingForAnswer = true;
            waitingForDiceRoll = false;

            btnSubmit.Enabled = true;
            btnDice.Enabled = false;

            EnsureTokenStyle();
            LoadRandomQuestion();
            MovePlayerLabel();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isAnimating)
                return;

            if (!waitingForAnswer)
            {
                MessageBox.Show("You already answered. Please roll the dice.");
                return;
            }

            string userAnswer = txtAnswer.Text.Trim();

            if (string.IsNullOrWhiteSpace(userAnswer))
            {
                MessageBox.Show("Please enter your answer.");
                return;
            }

            lastAnswerCorrect = currentQuestion.CheckAnswer(userAnswer);

            waitingForAnswer = false;
            waitingForDiceRoll = true;

            btnSubmit.Enabled = false;
            btnDice.Enabled = true;

            if (lastAnswerCorrect)
            {
                ConsecutiveCorrectAnswers++;

                if (ConsecutiveCorrectAnswers == 5)
                {
                    snakeProtection = new SnakeShield();
                    snakeProtection.Activate(player1, board);
                    MessageBox.Show("Congratulations! You received a snake shield");
                }
                label3.Text = "Correct answer! Now roll the dice.";
                MessageBox.Show("Correct! Press the Dice button to roll.");
            }
            else
            {
                ConsecutiveCorrectAnswers = 0;
                label3.Text = "Wrong answer! Now roll the dice.";
                MessageBox.Show("Wrong! Press the Dice button to roll.");
            }
        }

        private async void btnDice_Click(object sender, EventArgs e)
        {
            if (isAnimating)
                return;

            if (!waitingForDiceRoll)
            {
                MessageBox.Show("Please answer the question first.");
                return;
            }

            currentDiceValue = rnd.Next(1, 7);
            diceLbl.Text = currentDiceValue.ToString();

            int oldPosition = player1.Position;
            int newPosition;

            if (lastAnswerCorrect)
            {
                newPosition = oldPosition + currentDiceValue;
                if (newPosition > 100)
                    newPosition = 100;

                MessageBox.Show("Dice rolled " + currentDiceValue + ". Move forward " + currentDiceValue + " steps.");
            }
            else
            {
                newPosition = oldPosition - currentDiceValue;
                if (newPosition < 1)
                    newPosition = 1;

                MessageBox.Show("Dice rolled " + currentDiceValue + ". Move backward " + currentDiceValue + " steps.");
            }

            await AnimatePlayerMovement(oldPosition, newPosition);

            int checkedPosition = board.CheckPosition(player1.Position);

            if (snakeProtection != null && snakeProtection.IsActive && checkedPosition < player1.Position)
            {
                MessageBox.Show("You are protected from the snake!");
                snakeProtection.Deactivate();
                checkedPosition = player1.Position;
            }

            if (checkedPosition != player1.Position)
            {
                int beforeSnakeOrLadder = player1.Position;
                await AnimatePlayerMovement(beforeSnakeOrLadder, checkedPosition);
            }

            label3.Text = "Position: " + player1.Position;

            
            if (board.IsGameFinished(player1))
            {
                MessageBox.Show(player1.Name + " wins the game!");
                btnSubmit.Enabled = false;
                btnDice.Enabled = false;
                return;
            }

            txtAnswer.Clear();
            LoadRandomQuestion();

            waitingForAnswer = true;
            waitingForDiceRoll = false;

            btnSubmit.Enabled = true;
            btnDice.Enabled = false;

            label3.Text = "Answer the next question.";
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {
        }

        private void lblLevel_Click(object sender, EventArgs e)
        {
        }

        private void pcbGameTitle_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {
        }

        private void lblLevel_Click_1(object sender, EventArgs e)
        {
        }

        private void lblToken_Click(object sender, EventArgs e)
        {
        }
    }
}