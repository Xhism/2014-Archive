using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueExchange
{
    // Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

    class ValueExchange
    {
        

        static void Main(string[] args)
        {
            int val1 = 5;
            int val2 = 10;
            Console.WriteLine("Current values: {0}, {1}", val1, val2);
            val1 = val1 + val2;
            val2 = val1 - val2;
            val1 = val1 - val2;
            Console.WriteLine("Swapped values: {0}, {1}", val1, val2);

        }
    }
}
