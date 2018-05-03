using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class Floor
    {
        public int floorNumber = 1;
        public Apartment[] apartments = new Apartment[5];
        public Floor()
        {
            for (int i = 0; i < apartments.Length; i++)
            {
                apartments[i] = new Apartment();
                apartments[i].apartmentNumber = i+floorNumber*5;
            }
        }
    }
}
