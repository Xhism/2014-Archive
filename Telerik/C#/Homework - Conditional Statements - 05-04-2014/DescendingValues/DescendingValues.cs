using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescendingValues
{
    class DescendingValues
    {
        // Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality. 
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
                double temp = n1;
                n1 = n2;
                n2 = temp;  
            }

            if (n3 > n1)
            {
                double temp2 = n3;
                n3 = n1;
                n1 = temp2;
            }
            if (n3 > n2)
            {
                double temp3 = n3;
                n3 = n2;
                n2 = temp3;
            }
            Console.WriteLine("The numbers in descending order are as follows: {0}, {1}, {2}", n1, n2, n3);
        }
    }
}
