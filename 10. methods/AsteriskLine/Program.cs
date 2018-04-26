using System;
namespace AsteriskLine {
	class Program {
		static void Main(string[] args) {
            PrintAsterisks(10);
            PrintAsterisks(30);
			Console.ReadLine();
		}
        static void PrintAsterisks(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
	}

}
