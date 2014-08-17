using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSum
{
    class Sum
    {
        // Write a program that reads 3 real numbers from the console and prints their sum.
        static void Main(string[] args)
        {
            Console.Write("Please input first number: ");
            double num1 = int.Parse(Console.ReadLine());
            Console.Write("Please input second number: ");
            double num2 = int.Parse(Console.ReadLine());
            Console.Write("Please input third number: ");
            double num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Sum = {0}", num1 + num2 + num3);
        }
    }
}
