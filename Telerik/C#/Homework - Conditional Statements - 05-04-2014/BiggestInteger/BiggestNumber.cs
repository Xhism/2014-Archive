using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestInteger
{
    class BiggestNumber
    {
        // Write a program that finds the biggest of three numbers.
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Input third number: ");
            double n3 = double.Parse(Console.ReadLine());
            if (n2 > n1)
            {
                n1 = n2;
            }
            if (n3 > n1)
            {
                n1 = n3;
            }
            Console.WriteLine("The biggest of the three integers is {0}", n1);
        }
    }
}
