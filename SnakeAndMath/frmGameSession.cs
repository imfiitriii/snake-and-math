using System;
using System.Collections.Generic;
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
        private List<Player> players;
        private int currentPlayerIndex = 0;

        private PlayerTimer questionTimer;

        private int currentDiceValue = 0;
        private bool waitingForAnswer = true;
        private bool waitingForDiceRoll = false;
        private bool lastAnswerCorrect = false;
        private bool isAnimating = false;

        private Control boardHost;
        private const int GridSize = 10;

        private const int HumanQuestionTime = 15;
        private const int BotThinkingTime = 3;

        private Label[] tokenLabels;
        private string[] tokenSymbols = { "★", "●", "▲", "■" };
        private Color[] tokenColors = { Color.Gold, Color.DeepSkyBlue, Color.LimeGreen, Color.OrangeRed };

        private string currentStatusMessage = "";

        private Player CurrentPlayer
        {
            get { return players[currentPlayerIndex]; }
        }

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

        private void UpdateStatus(string message)
        {
            currentStatusMessage = message;

            int timeLeft = 0;
            if (questionTimer != null)
                timeLeft = questionTimer.TimeLeft;

            label3.Text = currentStatusMessage + " | Time Left: " + timeLeft + "s";
        }

        private void StartTurnTimer(int seconds)
        {
            if (questionTimer == null)
                return;

            questionTimer.Stop();
            questionTimer.Start(seconds);
            UpdateStatus(currentStatusMessage);
        }

        private void StopTurnTimer()
        {
            if (questionTimer != null)
                questionTimer.Stop();
        }

        private void OnQuestionTimeChanged(int timeLeft)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<int>(OnQuestionTimeChanged), timeLeft);
                return;
            }

            label3.Text = currentStatusMessage + " | Time Left: " + timeLeft + "s";
        }

        private void OnQuestionTimeUp()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(OnQuestionTimeUp));
                return;
            }

            if (isAnimating)
                return;

            // human timeout
            if (!CurrentPlayer.IsBot)
            {
                if (!waitingForAnswer)
                    return;

                lastAnswerCorrect = false;
                waitingForAnswer = false;
                waitingForDiceRoll = true;

                btnSubmit.Enabled = false;
                btnDice.Enabled = true;
                txtAnswer.Enabled = false;

                UpdateStatus(CurrentPlayer.Name + " ran out of time. Roll the dice.");
                MessageBox.Show(CurrentPlayer.Name + " ran out of time. The answer is counted as wrong.");
                return;
            }

            // bot timeout fallback
            if (CurrentPlayer.IsBot && waitingForAnswer)
            {
                lastAnswerCorrect = false;
                waitingForAnswer = false;
                waitingForDiceRoll = true;
                UpdateStatus(CurrentPlayer.Name + " ran out of time. Rolling dice...");
                btnDice_Click(btnDice, EventArgs.Empty);
            }
        }

        private Control FindBoardHost()
        {
            var namedBoard = this.Controls
                .Cast<Control>()
                .FirstOrDefault(c =>
                    c.Name.ToLower().Contains("board") ||
                    c.Name.ToLower().Contains("map"));

            if (namedBoard != null)
                return namedBoard;

            var biggestPictureBox = this.Controls
                .OfType<PictureBox>()
                .Where(p => !p.Name.ToLower().Contains("title"))
                .OrderByDescending(p => p.Width * p.Height)
                .FirstOrDefault();

            if (biggestPictureBox != null)
                return biggestPictureBox;

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

            if (rowFromBottom % 2 == 1)
                col = GridSize - 1 - col;

            int cellWidth = boardHost.ClientSize.Width / GridSize;
            int cellHeight = boardHost.ClientSize.Height / GridSize;

            int x = (col * cellWidth) + (cellWidth / 2);
            int y = boardHost.ClientSize.Height - (rowFromBottom * cellHeight) - (cellHeight / 2);

            return new Point(x, y);
        }

        private void InitializePlayers()
        {
            players = new List<Player>();

            Player player1 = new Player(1, "Player 1");
            player1.SetPosition(1);
            players.Add(player1);

            Bot bot1 = new Bot(2, "Bot 1", Level);
            bot1.SetPosition(1);
            players.Add(bot1);

            Bot bot2 = new Bot(3, "Bot 2", Level);
            bot2.SetPosition(1);
            players.Add(bot2);

            Bot bot3 = new Bot(4, "Bot 3", Level);
            bot3.SetPosition(1);
            players.Add(bot3);
        }

        private void InitializeTokens()
        {
            tokenLabels = new Label[4];

            if (lblToken != null)
                tokenLabels[0] = lblToken;

            for (int i = 1; i < 4; i++)
            {
                Label newToken = new Label();
                newToken.AutoSize = true;
                newToken.BackColor = Color.Transparent;
                newToken.Name = "lblToken" + (i + 1);
                tokenLabels[i] = newToken;

                if (boardHost != null)
                    newToken.Parent = boardHost;
                else
                    this.Controls.Add(newToken);
            }

            for (int i = 0; i < 4; i++)
            {
                if (tokenLabels[i] != null)
                {
                    tokenLabels[i].Text = tokenSymbols[i];
                    tokenLabels[i].Font = new Font("Segoe UI Symbol", 14, FontStyle.Bold);
                    tokenLabels[i].ForeColor = tokenColors[i];
                    tokenLabels[i].AutoSize = true;

                    if (boardHost != null && tokenLabels[i].Parent != boardHost)
                    {
                        tokenLabels[i].Parent = boardHost;
                        tokenLabels[i].BackColor = Color.Transparent;
                    }

                    tokenLabels[i].BringToFront();
                }
            }
        }

        private void UpdateAllPlayerLabels()
        {
            if (boardHost == null || players == null || tokenLabels == null)
                return;

            var groupedPositions = players
                .Select((player, index) => new { player, index })
                .GroupBy(x => x.player.Position);

            foreach (var group in groupedPositions)
            {
                Point center = GetCellCenterInBoard(group.Key);
                int offsetIndex = 0;

                foreach (var item in group)
                {
                    Label token = tokenLabels[item.index];
                    if (token == null)
                        continue;

                    int offsetX = 0;
                    int offsetY = 0;

                    if (offsetIndex == 0) { offsetX = -10; offsetY = -10; }
                    else if (offsetIndex == 1) { offsetX = 10; offsetY = -10; }
                    else if (offsetIndex == 2) { offsetX = -10; offsetY = 10; }
                    else if (offsetIndex == 3) { offsetX = 10; offsetY = 10; }

                    token.Left = center.X - (token.Width / 2) + offsetX;
                    token.Top = center.Y - (token.Height / 2) + offsetY;
                    token.BringToFront();

                    offsetIndex++;
                }
            }
        }

        private async Task AnimatePlayerMovement(Player player, int fromPosition, int toPosition)
        {
            if (fromPosition == toPosition)
            {
                player.SetPosition(toPosition);
                UpdateAllPlayerLabels();
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
                player.SetPosition(pos);
                UpdateAllPlayerLabels();
                UpdateStatus("Position: " + player.Position);
                await Task.Delay(180);
            }

            isAnimating = false;
        }

        private void UpdateTurnUI()
        {
            lblPlayer.Text = "Player : " + CurrentPlayer.Name;
            diceLbl.Text = "";
            txtAnswer.Clear();

            waitingForAnswer = true;
            waitingForDiceRoll = false;

            if (CurrentPlayer.IsBot)
            {
                btnSubmit.Enabled = false;
                btnDice.Enabled = false;
                txtAnswer.Enabled = false;
                UpdateStatus(CurrentPlayer.Name + " is answering...");
                StartTurnTimer(BotThinkingTime);
            }
            else
            {
                btnSubmit.Enabled = true;
                btnDice.Enabled = false;
                txtAnswer.Enabled = true;
                UpdateStatus(CurrentPlayer.Name + ", answer the question first.");
                StartTurnTimer(HumanQuestionTime);
            }
        }

        private async void RunBotTurn()
        {
            if (!CurrentPlayer.IsBot)
                return;

            await Task.Delay(BotThinkingTime * 1000);

            if (!CurrentPlayer.IsBot || !waitingForAnswer)
                return;

            StopTurnTimer();

            lastAnswerCorrect = CurrentPlayer.SubmitAnswer("", currentQuestion.GetCorrectAnswer());

            waitingForAnswer = false;
            waitingForDiceRoll = true;

            if (lastAnswerCorrect)
                UpdateStatus(CurrentPlayer.Name + " answered correctly. Rolling dice...");
            else
                UpdateStatus(CurrentPlayer.Name + " answered wrongly. Rolling dice...");

            await Task.Delay(800);

            btnDice_Click(btnDice, EventArgs.Empty);
        }

        private void NextTurn()
        {
            StopTurnTimer();

            currentPlayerIndex++;
            if (currentPlayerIndex >= players.Count)
                currentPlayerIndex = 0;

            LoadRandomQuestion();
            UpdateTurnUI();
            UpdateAllPlayerLabels();

            if (CurrentPlayer.IsBot)
                RunBotTurn();
        }

        private void frmGameSession_Load(object sender, EventArgs e)
        {
            board = new GameBoard();
            boardHost = FindBoardHost();

            questionTimer = new PlayerTimer();
            questionTimer.TimeChanged += OnQuestionTimeChanged;
            questionTimer.TimeUp += OnQuestionTimeUp;

            InitializePlayers();
            InitializeTokens();

            lblLevel.Text = Level;
            LoadRandomQuestion();
            UpdateTurnUI();
            UpdateAllPlayerLabels();

            if (CurrentPlayer.IsBot)
                RunBotTurn();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isAnimating)
                return;

            if (CurrentPlayer.IsBot)
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

            StopTurnTimer();

            lastAnswerCorrect = currentQuestion.CheckAnswer(userAnswer);

            waitingForAnswer = false;
            waitingForDiceRoll = true;

            btnSubmit.Enabled = false;
            btnDice.Enabled = true;
            txtAnswer.Enabled = false;

            if (lastAnswerCorrect)
            {
                UpdateStatus("Correct answer! Now roll the dice.");
                MessageBox.Show("Correct! Press the Dice button to roll.");
            }
            else
            {
                UpdateStatus("Wrong answer! Now roll the dice.");
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

            StopTurnTimer();

            currentDiceValue = CurrentPlayer.RollDice();
            diceLbl.Text = currentDiceValue.ToString();

            int oldPosition = CurrentPlayer.Position;
            int newPosition;

            if (lastAnswerCorrect)
            {
                newPosition = oldPosition + currentDiceValue;
                if (newPosition > 100)
                    newPosition = 100;

                MessageBox.Show(CurrentPlayer.Name + " rolled " + currentDiceValue + ". Move forward " + currentDiceValue + " steps.");
            }
            else
            {
                newPosition = oldPosition - currentDiceValue;
                if (newPosition < 1)
                    newPosition = 1;

                MessageBox.Show(CurrentPlayer.Name + " rolled " + currentDiceValue + ". Move backward " + currentDiceValue + " steps.");
            }

            await AnimatePlayerMovement(CurrentPlayer, oldPosition, newPosition);

            int checkedPosition = board.CheckPosition(CurrentPlayer.Position);

            if (checkedPosition != CurrentPlayer.Position)
            {
                int beforeSnakeOrLadder = CurrentPlayer.Position;

                if (checkedPosition > beforeSnakeOrLadder)
                    UpdateStatus(CurrentPlayer.Name + " climbed a ladder!");
                else
                    UpdateStatus(CurrentPlayer.Name + " got eaten by a snake!");

                await AnimatePlayerMovement(CurrentPlayer, beforeSnakeOrLadder, checkedPosition);
            }

            UpdateStatus("Position: " + CurrentPlayer.Position);

            if (board.IsGameFinished(CurrentPlayer))
            {
                StopTurnTimer();
                MessageBox.Show(CurrentPlayer.Name + " wins the game!");
                btnSubmit.Enabled = false;
                btnDice.Enabled = false;
                txtAnswer.Enabled = false;
                return;
            }

            NextTurn();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (questionTimer != null)
            {
                questionTimer.Stop();
                questionTimer.TimeChanged -= OnQuestionTimeChanged;
                questionTimer.TimeUp -= OnQuestionTimeUp;
            }

            base.OnFormClosing(e);
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