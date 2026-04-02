using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAndMath
{

    internal interface IItem //interface for Items
    {
        void Activate(Player player, GameBoard gameboard);
    }
    internal class SnakeShield : IItem //Class for SnakeShield Item
    {
        public bool IsActive { get; private set; } = false;

        public void Activate(Player player, GameBoard board)
        {
            //Activate Shield against the snake
            IsActive = true;
            MessageBox.Show(player.Name + " snake shield's activated!");
        }

        public void Deactivate()
        {
            IsActive = false;
        }
    }

    internal class TimeBoost : IItem //class for TimeBoost Item
    {
        public bool IsActive { get; private set; } = false;

        public void Activate(Player player, GameBoard board)
        {
            IsActive = true;
            MessageBox.Show(player.Name + " received a Time Boost! Next turn time is doubled.");
        }

        public void Deactivate()
        {
            IsActive = false;
        }
    }
}

