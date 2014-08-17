using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersN
{
    class Sum
    {
        // Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 
        static void Main(string[] args)
        {
            // This program can get as many numbers as you want from the console,
            // but works essentially the same way as you would need it only for 5.
            string[] input = Console.ReadLine().Split();
            double sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int temp = Convert.ToInt32(input[i]);
                sum += temp;
            }
            Console.WriteLine(sum);
        }
    }
}
