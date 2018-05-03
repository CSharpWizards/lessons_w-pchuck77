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
            House house = new House();
            house.GetAllPrices();
            int maxPrice=int.Parse(Console.ReadLine());
            List<int> prices = house.GetPrices(maxPrice);
            for (int i = 0; i < prices.Count; i++)
            {
                Console.WriteLine(prices[i]);
            }
            Console.ReadLine();
        }

    }
}
