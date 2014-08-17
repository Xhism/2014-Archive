using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersN
{
    class NumbersN
    {
        // Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 
        static void Main(string[] args)
        {
            Console.Write("Input number count: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Input number {0}: ", i + 1);
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The total sum is: " + sum);
        }
    }
}
