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
            Random rnd=new Random();
            for (int i = 0; i <5; i++)
            {
                mas[i] = rnd.Next(-100,100);
                Console.Write(mas[i] + " ");
                
            }
            Console.WriteLine();
            if (mas[int.Parse(Console.ReadLine())]>0)
            {
                Console.WriteLine("это число положительное");
            }
            else
            {
                Console.WriteLine("это число не положительное");
            }
            Console.ReadLine();
        }
    }
}
