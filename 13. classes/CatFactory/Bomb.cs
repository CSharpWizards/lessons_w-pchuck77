using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatFactory
{
   public class Bomb
    {
        public int x;
        public int y;
        public void Fall()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("0");
            y = y - 2;

        }
    }
}
