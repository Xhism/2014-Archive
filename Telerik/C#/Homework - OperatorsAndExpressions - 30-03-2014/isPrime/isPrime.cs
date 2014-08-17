using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPrime
{
    class IsPrime
    {
        //Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

        static void Main(string[] args)
        {
            byte n = 4;
            for(int i = 2; i < n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine("Given number is not prime");
                    return;
                }
            }
            Console.WriteLine("Given number is prime");
        }
    }
}
