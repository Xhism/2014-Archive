using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueExchange
{
    class ValueExchange
    {
        // Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
        static void Main(string[] args)
        {
            int a = 15;
            int b = 5;
            Console.WriteLine("Starting values: {0}, {1}", a, b);
            if (a > b)
            {
                int c = a;
                a = b;
                b = c;
            }
            Console.WriteLine("Ending values: {0}, {1}", a, b);
        }
    }
}
