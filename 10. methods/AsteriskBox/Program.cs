using System;

namespace AsteriskBox {
	class Program {
		static void Main(string[] args) {
            PrintAsteriskBox(20, 10);
            PrintAsteriskBox(5, 3);
			Console.ReadLine();
		}
        static void PrintAsteriskBox(int numberOfStars, int numberOfLines)
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                PrintAsterisk(numberOfStars);
            }
            
        }
        static void PrintAsterisk(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
	}
}
