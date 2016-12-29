using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int score; // declaring variable: type, name
            score = 0; // assigning value to variable

            int theMeaningOfLife = 42; // declare and initialize  

            int a = 5;
            int b = 2;

            b = a;
            a = -3;

            Console.WriteLine(b);
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
