using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciN
{
    class FibonacciN
    {
        // Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
        // Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
        static void Main(string[] args)
        {
            Console.WriteLine("Input N:");
            int n = 0;
            bool nCheck = int.TryParse(Console.ReadLine(), out n);

            int a = 0;
            int b = 1;

            if (nCheck)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(a);
                    int temp = a;
                    a = b;
                    b += temp;
                }
            }
            else Console.WriteLine("Error: N needs to be a positive integer.");
        }
    }
}
