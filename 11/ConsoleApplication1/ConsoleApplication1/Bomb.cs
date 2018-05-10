using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Bomb
    {
        public int x;
        public int y;
        public Bomb(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public void Fall()
        {
            
            Console.SetCursorPosition(x, y);
            Console.Write("0");
            
            y = y + 2;

        }
        public void Explosion()
        {
            Console.SetCursorPosition(x, y - 3);
            Console.Write("#");
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(x-1+i, y - 2);
                Console.Write("#");
            }
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(x - 2 + i, y - 1);
                Console.Write("#");
            }
        }
    }
}
