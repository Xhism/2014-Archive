using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveEquation
{
    class SolveEquation
    {
        // Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Input c: ");
            double c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        Console.WriteLine("Any number solves the equation.");
                    else 
                        Console.WriteLine("All real numbers solve the equation.");
                }
                else
                    Console.WriteLine("Single real root: {0}", - (c / b));
            }
            else
            {
                double D = b * b - 4 * a * c;
                if (D == 0)
                {
                    Console.WriteLine("Single real root: {0}", (-b) / (2 * a));
                }
                if (D > 0)
                {
                    Console.WriteLine("Two real roots: {0} and {1}", (-b + D) / (2 * a), (-b - D) / (2 * a));
                }
                if (D < 0)
                {
                    Console.WriteLine("No real roots.");
                }
            }
        }
    }
}
