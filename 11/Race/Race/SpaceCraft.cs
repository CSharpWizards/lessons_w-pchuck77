using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class SpaceCraft
    {
        public int distance = 1;
       
        public int speed;
       
        public int Mowe(){
            distance = distance + speed;
            
            for (int b = 0; b <distance; b++)
            {
                Console.Write("*");
            }
            return distance;
        }
    }
}
