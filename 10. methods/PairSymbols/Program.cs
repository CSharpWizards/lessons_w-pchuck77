using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PairSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckPairs("namespace ConsoleApplication1 {class Program {static void Main(string[] args) {}", "{", "}");
            CheckPairs("graphics = e.Graphics;graphics.SmoothingMode = SmoothingMode.AntiAlias;graphics.Clear(Color.FromArgb(0x44444400));DrawCar(carX, 200);", "(", ")");
            CheckPairs("DrawCar(carX, 200))(;", "(", ")");

            Console.ReadLine();
        }
        static void CheckPairs(string text, string open, string close)
        {
            int number = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]==open[0])
                {
                    number = number + 1;
                }
                if (text[i] == close[0])
                {
                    number = number - 1;
                }
                if (number<0)
                {
                    Console.WriteLine("есть ошибки");
                    return;
                }
            }
            if (number==0)
            {
                Console.WriteLine("нет ошибок");
            }
            else
            {
                Console.WriteLine("есть ошибки");
            }
        }
    }
}
