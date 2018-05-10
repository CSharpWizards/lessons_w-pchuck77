using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class House
    {
        public int x;
        public int y;
        public int hight;
        public int width;
        //┐
        //┌
        public House(int x, int y, int hight, int wight)
        {
            this.x = x;
            this.y = y;
            this.hight = hight;
            this.width = wight;

        }
        public void Draw()
        {



            for (int i = 0; i < hight; i++)
            {
                Console.SetCursorPosition(x, y - i);
                Console.Write("|");
                Console.SetCursorPosition(x + width + 1, y - i);
                Console.Write("|");

            }
            Console.SetCursorPosition(x, y - hight);
            Console.Write("┌");
            for (int i = 0; i < width; i++)
            {
                Console.Write("─");
            }
            Console.Write("┐");
        }

    }
}
