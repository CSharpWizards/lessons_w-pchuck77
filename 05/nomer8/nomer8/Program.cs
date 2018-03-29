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
            int[] mas = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                mas[i] = rnd.Next(-100, 100);
                Console.Write(mas[i] + " ");

            }
            Console.WriteLine();
            int sum=0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + mas[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
