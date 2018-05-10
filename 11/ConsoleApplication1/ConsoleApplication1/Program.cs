using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 13; i++)
            {
                ;
                houses.Add(new House(i*9, Console.WindowHeight, 6, 5));
            }
            
            while (true)
            {
                while (!Console.KeyAvailable)
                {
                    Console.Clear();
                      Update(); 
                    Thread.Sleep(100);
                }
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Spacebar)
                {
                    Bomb bomb= new Bomb(airCraft.x,airCraft.y+1);
                    bombs.Add(bomb);
                }
            }
         
        }
        static List<House> houses = new List<House>();
        static List<Bomb> bombs = new List<Bomb>();
        static AirCraft airCraft = new AirCraft();
        static void Update()
        {
            airCraft.Move();
            for (int i = 0; i < houses.Count; i++)
            {
                houses[i].Draw();
            }
            for (int i = 0; i < bombs.Count; i++)
            {
                if (bombs[i].y>Console.WindowHeight)
                {
                    bombs[i].Explosion();
                    HouseExplotion(bombs[i]);
                    bombs.RemoveAt(i);
                    i = i - 1;

                }
                else
                {
                    bombs[i].Fall();
                }
                
            }
        }

        private static void HouseExplotion(Bomb bomb)
        {
            for (int b = 0; b < houses.Count; b++)
            {
                if (Math.Abs(bomb.x - (houses[b].x + houses[b].width / 2)) < 8)
                {
                    houses.RemoveAt(b);
                    b = b - 1;
                }
            }
        }
    }
}
