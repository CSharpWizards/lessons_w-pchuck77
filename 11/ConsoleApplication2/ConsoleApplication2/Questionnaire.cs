using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Questionnaire
    {
        public string name="";
        public string age="";
        public string color = "";
        public Questionnaire(string name )
        {
            this.name = name;
        }
        public Questionnaire(string name,int age)
        {
            this.name = name;
            this.age = age.ToString(); 
        }
        public Questionnaire(string name,int age,string color)
        {
            this.name = name;
            this.age = age.ToString();
            this.color = color;
        }
        public void Write()
        {
            Console.Write(name+" "+age+" "+color);
        }

    }
}
