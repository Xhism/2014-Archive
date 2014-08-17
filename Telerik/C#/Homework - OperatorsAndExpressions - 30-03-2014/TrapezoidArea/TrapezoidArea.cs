using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        //Write an expression that calculates trapezoid's area by given sides a and b and height h.

        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            int h = 7;
            Console.WriteLine("The area of a trapezoid with sides {0} and {1} and height {2} has an area of {3}", a, b, h, (double)(a+b)*h/2);
        }
    }
}
