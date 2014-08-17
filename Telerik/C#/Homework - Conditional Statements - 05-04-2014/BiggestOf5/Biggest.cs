using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestInteger
{
    class BiggestInteger
    {
        // Write a program that finds the biggest of five numbers by using only five if statements. 
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Input third number: ");
            double n3 = double.Parse(Console.ReadLine());
            Console.Write("Input fourth number: ");
            double n4 = double.Parse(Console.ReadLine());
            Console.Write("Input fifth number: ");
            double n5 = double.Parse(Console.ReadLine());

            if (n2 > n1)
                n1 = n2;

            if (n3 > n1)
                n1 = n3;

            if (n4 > n1)
                n1 = n4;

            if (n5 > n1)
                n1 = n5;

            Console.WriteLine("The biggest of the five integers is {0}", n1);
        } // Author notes: I don't know why the task allows 5 if statements, when only 4 are needed.
    }
}
