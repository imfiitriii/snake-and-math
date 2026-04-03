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
        private bool formClosed = false;
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
        private string currentQuestionLevel = "";

        private Player CurrentPlayer
        {
            get { return players[currentPlayerIndex]; }
        }

        private bool IsFourPlayerMode
        {
            get { return Level == "4 Player"; }
        }

        private Dictionary<Player, TimeBoost> playerTimeBoosts = new Dictionary<Player, TimeBoost>();
        private Dictionary<Player, SnakeShield> playerShields = new Dictionary<Player, SnakeShield>();
        private Dictionary<Player, int> playerStreaks = new Dictionary<Player, int>();

        public frmGameSession()
        {
            InitializeComponent();
        }

        private string GetQuestionLevelForCurrentMode()
        {
            if (IsFourPlayerMode)
            {
                string[] levels = { "Easy", "Medium", "Hard" };
                return levels[rnd.Next(0, levels.Length)];
            }

            return Level;
        }

        private void LoadQuestion(int id)
        {
            currentQuestionLevel = GetQuestionLevelForCurrentMode();
            currentQuestion = new Question(id, currentQuestionLevel);
        }

        private void LoadRandomQuestion()
        {
            id = rnd.Next(1, 21);
            LoadQuestion(id);
            lblQuestion.Text = currentQuestion.DisplayQuestion();

            if (IsFourPlayerMode)
                lblLevel.Text = "Mode: 4 Player | Question: " + currentQuestionLevel;
            else
                lblLevel.Text = Level;
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

            if (IsFourPlayerMode)
            {
                for (int i = 1; i <= 4; i++)
                {
                    Player player = new Player(i, "Player " + i);
                    player.SetPosition(1);
                    players.Add(player);
                }
            }
            else
            {
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
            lblPlayer.Text = CurrentPlayer.Name + "'s Turn :";
            if (playerStreaks.TryGetValue(CurrentPlayer, out int streak) && streak > 0)
                lblStreak.Text = "Current streak: " + streak;
            else
                lblStreak.Text = "Current streak: 0";
            if (playerShields.ContainsKey(CurrentPlayer) && playerShields[CurrentPlayer].IsActive)
                lblPowerUps.Text = "Power Up: Snake Shield";
            else if (playerTimeBoosts.ContainsKey(CurrentPlayer) && playerTimeBoosts[CurrentPlayer].IsActive)
                lblPowerUps.Text = "Power Up: Time Boost";
            else
                lblPowerUps.Text = "Power Up: None";
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
                int time = BotThinkingTime;

                if (playerTimeBoosts.ContainsKey(CurrentPlayer) && playerTimeBoosts[CurrentPlayer].IsActive)
                {
                    time *= 2;
                    playerTimeBoosts[CurrentPlayer].Deactivate();
                }

                StartTurnTimer(time);
            }
            else
            {
                btnSubmit.Enabled = true;
                btnDice.Enabled = false;
                txtAnswer.Enabled = true;
                UpdateStatus(CurrentPlayer.Name + ", answer the question first.");
                int time = HumanQuestionTime;

                if (playerTimeBoosts.ContainsKey(CurrentPlayer) && playerTimeBoosts[CurrentPlayer].IsActive)
                {
                    time *= 2;
                    playerTimeBoosts[CurrentPlayer].Deactivate();
                }

                StartTurnTimer(time);
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

            if (lastAnswerCorrect)
            {
                if (!playerStreaks.ContainsKey(CurrentPlayer))
                    playerStreaks[CurrentPlayer] = 0;

                playerStreaks[CurrentPlayer]++;

                if (playerStreaks[CurrentPlayer] == 5)
                {
                    playerStreaks[CurrentPlayer] = 0;

                    // remove existing power ups first
                    playerShields.Remove(CurrentPlayer);
                    playerTimeBoosts.Remove(CurrentPlayer);

                    int reward = rnd.Next(0, 5);

                    if (reward >= 0)
                    {
                        playerShields[CurrentPlayer] = new SnakeShield();
                        playerShields[CurrentPlayer].Activate(CurrentPlayer, board);
                        MessageBox.Show(CurrentPlayer.Name + " received a snake shield!");
                    }
                    else
                    {
                        playerTimeBoosts[CurrentPlayer] = new TimeBoost();
                        playerTimeBoosts[CurrentPlayer].Activate(CurrentPlayer, board);
                        MessageBox.Show(CurrentPlayer.Name + " received a time boost!");
                    }
                }
            }
            else
            {
                playerStreaks[CurrentPlayer] = 0;
            }

            waitingForAnswer = false;
            waitingForDiceRoll = true;

            if (formClosed == true)
                return;
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
                if (!playerStreaks.ContainsKey(CurrentPlayer))
                    playerStreaks[CurrentPlayer] = 0;

                playerStreaks[CurrentPlayer]++;

                if ((playerStreaks[CurrentPlayer] == 5))
                {
                    playerStreaks[CurrentPlayer] = 0; // reset streak after reward

                    // remove existing power ups first
                    playerShields.Remove(CurrentPlayer);
                    playerTimeBoosts.Remove(CurrentPlayer);

                    int reward = rnd.Next(0, 5); // 0 or 5 (25% for snake shield)

                    if (reward >= 0)
                    {
                        playerShields[CurrentPlayer] = new SnakeShield();
                        playerShields[CurrentPlayer].Activate(CurrentPlayer, board);
                        MessageBox.Show("Congratulations! You received a snake shield.");
                    }
                    else
                    {
                        playerTimeBoosts[CurrentPlayer] = new TimeBoost();
                        playerTimeBoosts[CurrentPlayer].Activate(CurrentPlayer, board);
                        MessageBox.Show("Congratulations! You received a time boost for the next turn!");
                    }
                    
                }
                label3.Text = "Correct answer! Now roll the dice.";
                UpdateStatus("Correct answer! Now roll the dice.");
                MessageBox.Show("Correct! Press the Dice button to roll.");
            }
            else
            {
                UpdateStatus("Wrong answer! Now roll the dice.");
                playerStreaks[CurrentPlayer] = 0;
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

            if (playerShields.ContainsKey(CurrentPlayer) && playerShields[CurrentPlayer].IsActive && checkedPosition < CurrentPlayer.Position)
            {
                MessageBox.Show("You are protected from the snake!");
                playerShields[CurrentPlayer].Deactivate();
                checkedPosition = CurrentPlayer.Position;
            }

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

       
        private void frmGameSession_FormClosing(object sender, FormClosingEventArgs e)
        {
            formClosed = true;
        }

        private void lblStreak_Click(object sender, EventArgs e)
        {

        }
    }
}