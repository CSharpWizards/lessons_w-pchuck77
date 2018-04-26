using System;

namespace UpgradedSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string sentence = Console.ReadLine();

            int spacesAmount = CountSpaces(sentence);
            string spacesForm = GetSpacesForm(spacesAmount);
            Console.Write("Предложение '" + sentence + "' содержит " + spacesAmount + " " + spacesForm);
            Console.ReadLine();
        }
        static int CountSpaces(string text)
        {
            int spaceCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    spaceCount = spaceCount + 1;
                }
            }
            return spaceCount;
        }
        static string GetSpacesForm(int spacesAmount)
        {
            string text;
            if (spacesAmount > 4)
            {
                 text = "пробелов";
            }
            else if (spacesAmount == 1)
            {
                 text = "пробел";
            }
            else
            {
                 text = "пробела";
            }
            return text;
        }
    }
}
