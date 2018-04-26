using System;

namespace Spaces {
	class Program {
		static void Main(string[] args) {
			Console.Write("Введите предложение: ");
			string sentence = Console.ReadLine();

			int spacesAmount = CountSpaces(sentence);
			Console.Write("Предложение '" + sentence + "' содержит " + spacesAmount + " пробелов");
			Console.ReadLine();
		}
        static int CountSpaces(string text)
        {
            int spaceCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]==' ')
                {
                    spaceCount = spaceCount + 1;
                }
            }
            return spaceCount;
        }
	}
}
