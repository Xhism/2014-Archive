using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class GCD
    {
        // Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).
        static void Main(string[] args)
        {
            int a = 32;
            int b = 84;

            while(b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            Console.WriteLine("The Greatest common divisor is " + a);
        }
    }
}
