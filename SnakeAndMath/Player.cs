using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndMath
{
    public class Player
    {
        public int Id { get; }
        public string Name { get; }
        public int Position { get; private set; }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
            Position = 0;
        }

        public virtual int RollDice()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }

        public void MoveForward(int steps)
        {
            Position += steps;
        }

        public void MoveBackward(int steps)
        {
            Position -= steps;

            if (Position < 0)
                Position = 0;
        }

        public void SetPosition(int newPosition)
        {
            Position = newPosition;
        }

        public bool CheckWin()
        {
            return Position >= 100;
        }

        public virtual bool SubmitAnswer(string playerAnswer, string correctAnswer)
        {
            return playerAnswer == correctAnswer;
        }
    }

    public class Bot : Player
    {
        private string difficulty;

        public Bot(int id, string name, string difficulty) : base(id, name)
        {
            this.difficulty = difficulty;
        }

        public override bool SubmitAnswer(string playerAnswer, string correctAnswer)
        {
            Random rnd = new Random();
            int chance = rnd.Next(1, 101);

            if (difficulty == "Easy")
                return chance <= 40;

            if (difficulty == "Medium")
                return chance <= 60;

            if (difficulty == "Hard")
                return chance <= 85;

            return false;
        }
    }

}
 