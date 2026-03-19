using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndMath
{
    internal class dice
    {
        public int roll()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
