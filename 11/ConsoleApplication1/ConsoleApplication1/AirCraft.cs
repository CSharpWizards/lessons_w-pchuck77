using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class AirCraft
    {

        int speed = 3;
       public int x;
       public int y;
       int maxX = Console.WindowWidth;
       int maxY = Console.WindowHeight;
       public AirCraft()
       {
           x = 0;
           y = 4;
       }
       public void Move()
        {
            if (x>maxX-1)
            {
                x = 0;
            }
            
            Console.SetCursorPosition(x, y);
            Console.Write(">");
            x = x + speed;
           

        }
    }
}
