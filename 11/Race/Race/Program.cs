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
            Random random = new Random();
            SpaceCraft[] spaceCrafts = new SpaceCraft[7];
            for (int i = 0; i < 7; i++)
            {
                spaceCrafts[i] = new SpaceCraft();
                spaceCrafts[i].speed = random.Next(1, 7);
            }
            bool finish = false;
            while (finish==false)
            {
                for (int i = 0; i < 7; i++)
                {
                    spaceCrafts[i].Mowe();
                    Console.WriteLine();
                    if (spaceCrafts[i].distance>20)
                    {
                        finish=true;
                    }

                }
                Line();
                Thread.Sleep(1000);
                if (finish==false)
                {
                    Console.Clear();
                }
                
            }
            Console.WriteLine("Финиш");
            Console.ReadLine();


        }

        static void Line()
        {
            for (int i = 0; i < 7; i++)
			{
                Console.SetCursorPosition(20, i);
                Console.Write("|");


			}
            
        }
    }
}
