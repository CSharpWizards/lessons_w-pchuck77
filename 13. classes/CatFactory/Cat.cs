using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatFactory
{
    public class Cat
    {
        public string name;
        public double age;
        public double mass;
        public double strange;
        public Cat(string name, double age, double mass, double strange)
        {
            this.name = name;
            this.age = age;
            this.mass = mass;
            this.strange = strange;

        }
        public string Fight(Cat enemyCat)
        {
            int score = 0;
            if (age>enemyCat.age)
            {
                score = score + 1;
            }
            else
            {
                score = score - 1;
            }
            if (mass > enemyCat.mass)
            {
                score = score + 1;
            }
            else
            {
                score = score - 1;
            }
            if (strange > enemyCat.strange)
            {
                score = score + 1;
            }
            else
            {
                score = score - 1;
            }
            if (score > 0)
            {
                return name;
            }
            else
            {
                return enemyCat.name;
            }
	
        }
    }
}
