using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Apartment
    {
        public int apartmentNumber = 1;
        
        public int price;
        static Random random = new Random();
        public Apartment()
        {
            price = random.Next(100, 100000);
        }
    }
}
