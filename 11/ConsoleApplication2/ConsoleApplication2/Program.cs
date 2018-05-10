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
            Questionnaire questionnaire = new Questionnaire("123", 12,"1246");
            questionnaire.Write();
            Console.ReadLine();
        }
    }
}
