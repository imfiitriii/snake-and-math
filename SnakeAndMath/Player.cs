using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndMath
{
    public class Player
    {
        // CHANGED:
        // use one shared Random object for all players
        // instead of creating new Random() every time RollDice() is called
        // this avoids repeated same dice values when called too quickly
        protected static Random rnd = new Random();

        public int Id { get; }
        public string Name { get; }
        public int Position { get; private set; }

        // CHANGED:
        // added IsBot so frmGameSession can check whether current turn
        // belongs to a human player or a bot
        public virtual bool IsBot => false;

        public Player(int id, string name)
        {
            Id = id;
            Name = name;

            // CHANGED:
            // start at position 1 instead of 0
            // because your board logic and frmGameSession token movement
            // are already using tile 1 as the starting tile
            Position = 1;
        }

        public virtual int RollDice()
        {
            // CHANGED:
            // use shared Random above instead of:
            // Random rnd = new Random();
            return rnd.Next(1, 7);
        }

        public void MoveForward(int steps)
        {
            Position += steps;
        }

        public void MoveBackward(int steps)
        {
            Position -= steps;

            // CHANGED:
            // prevent player from going below tile 1
            // because current game starts from tile 1, not 0
            if (Position < 1)
                Position = 1;
        }

        public void SetPosition(int newPosition)
        {
            // CHANGED:
            // added protection so position cannot go below 1
            // helps avoid invalid board position during movement/animation
            if (newPosition < 1)
                Position = 1;
            else
                Position = newPosition;
        }

        public bool CheckWin()
        {
            return Position >= 100;
        }

        public virtual bool SubmitAnswer(string playerAnswer, string correctAnswer)
        {
            // CHANGED:
            // trim spaces before comparing answers
            // so accidental spaces do not make correct answer become wrong
            return playerAnswer.Trim() == correctAnswer.Trim();
        }
    }

    public class Bot : Player
    {
        private string difficulty;

        // CHANGED:
        // bot overrides IsBot so frmGameSession can detect bot turn
        public override bool IsBot => true;

        public Bot(int id, string name, string difficulty) : base(id, name)
        {
            this.difficulty = difficulty;
        }

        public override bool SubmitAnswer(string playerAnswer, string correctAnswer)
        {
            // CHANGED:
            // use shared Random from Player class
            // instead of creating new Random() every bot turn
            int chance = rnd.Next(1, 101);

            if (difficulty == "Easy")
                return chance <= 60;

            if (difficulty == "Medium")
                return chance <= 80;

            if (difficulty == "Hard")
                return chance <= 90;

            return false;
        }
    }
}