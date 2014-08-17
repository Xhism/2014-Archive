using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        // Write a program that enters the coefficients a, b and c of a quadratic equation
		// a*x^2 + b*x + c = 0
		// and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
        static void Main(string[] args)
        {
            double a = 2;
            double b = 6;
            double c = 3;
            double D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("No Real Roots");
            }
            if (D == 0)
            {
                Console.WriteLine("One Real Root: {0}", -b/(2*a));
            }
            if (D > 0)
            {
                Console.WriteLine("Two Real Roots:\n{0} and\n{1}", (-b+Math.Sqrt(D))/(2*a), (-b-Math.Sqrt(D))/(2*a));
            }
        }
    }
}
