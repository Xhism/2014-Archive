using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class FibonacciSequence
    {
        // Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers of the sequence would you like printed? ");
            int n = int.Parse(Console.ReadLine());
            ulong a = 0;
            ulong b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a);
                if (i < n - 1)
                    Console.Write(", ");
                else
                    Console.WriteLine();
                ulong temp = a;
                a = b;
                b += temp;
            }
        } // Note: Starts making mistakes at the 94th calculation.
    }
}
