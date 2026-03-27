using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAndMath
{

    internal interface IItem
    {
        void Activate(Player player, GameBoard gameboard);
    }
    internal class SnakeShield : IItem
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
}

