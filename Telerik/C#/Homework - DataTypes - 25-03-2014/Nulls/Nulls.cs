using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulls
{
    // Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

    class Nulls
    {
        static void Main(string[] args)
        {
            int? var1 = null;
            double? var2 = null;
            Console.WriteLine(var1 + " " + var2);
            var1 += null;
            var2 += null;
            Console.WriteLine(var1 + " " + var2);
            var1 += 4;
            var2 += 5;
            Console.WriteLine(var1 + " " + var2);
        }
    }
}
