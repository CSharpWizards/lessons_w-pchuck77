using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class House
    {
        public int number=1;
        public Floor[] floors = new Floor[5];
        public House()
        {
            for (int i = 0; i < floors.Length; i++)
            {
                floors[i] = new Floor();
                floors[i].floorNumber = i;
            }
        }
        public void GetAllPrices()
        {
            for (int i = 0; i < floors.Length; i++)
            {
                for (int b = 0; b < floors[i].apartments.Length; b++)
                {
                    Console.Write(floors[i].apartments[b].price + " ");
                }
                Console.WriteLine();
            }
        }
        public List<int> GetPrices(int maxPrice)
        {
            List<int> prices=new List<int>();

            for (int i = 0; i < floors.Length; i++)
            {
                for (int b = 0; b < floors[i].apartments.Length; b++)
                {
                    if (floors[i].apartments[b].price <= maxPrice)
                    {
                        prices.Add(floors[i].apartments[b].price);
                    }
                } 
            }
            return prices;
        }

    }
}
