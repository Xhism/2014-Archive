using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciN
{
    class FibonacciN
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci({0}) = {1}", input, Fib(input));
        }
        static ulong Fib(int n)
        {
            ulong prevFib = 0;
            ulong fib = 1;
            for (int i = 0; i < n; i++)
            {
                ulong temp = prevFib;
                prevFib = fib;
                fib+=temp;
            }
            return fib;
        }
    }
}
