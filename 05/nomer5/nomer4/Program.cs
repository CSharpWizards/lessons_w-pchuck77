using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                mas[i] = rnd.Next(-100, 100);
                Console.Write(mas[i] + " ");

            }
            Console.WriteLine();
            mas[int.Parse(Console.ReadLine())] = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
