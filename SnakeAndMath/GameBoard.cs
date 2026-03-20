using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndMath
{
    internal class GameBoard
    {
        private int size;
        private Dictionary<int, int> snakes; //key = snakes head, value = snakes tail
        private Dictionary<int, int> ladders; //key = ladder start, value = ladder end

        public int Size
        {
            get { return size; }
            private set { size = value; }
        }

        public GameBoard()
        {
            this.size = 100;
            snakes = new Dictionary<int, int>();
            ladders = new Dictionary<int, int>();

            InitializeBoard();
        }

        private void InitializeBoard()
        {
            // Snake: head -> tail (e.g 29 head, 7 tail)
            snakes.Add(29, 7);
            snakes.Add(75, 33);
            snakes.Add(98, 79);

            // Ladder: start -> end
            ladders.Add(72, 86);
            ladders.Add(39, 63);
            ladders.Add(17, 25);
        }
        
        //checkposition method- use this function to check whether player is in snake or ladder position
        //example of use - player.SetPosition(GameBoard.Checkposition(player.position))
        public int CheckPosition(int position) //insert the player position inside this argument
        {
            if (snakes.ContainsKey(position))
                return snakes[position];

            if (ladders.ContainsKey(position))
                return ladders[position];

            return position;
        }

        public int MovePlayer(Player player, int diceValue) //insert player object as argument
        {
            int newPos = player.Position + diceValue;

            // Prevent going over board limit
            if (newPos > size)
                return player.Position;

            // Check snake or ladder
            newPos = CheckPosition(newPos);

            player.SetPosition(newPos);

            return newPos;
        }

        public bool IsGameFinished(Player player)
        {
            return player.CheckWin();
        }
    }
}
