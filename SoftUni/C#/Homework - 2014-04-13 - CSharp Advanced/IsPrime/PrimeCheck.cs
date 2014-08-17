using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine("Is {0} prime? {1}", input, IsPrime(input));
        }
        static bool IsPrime(long n)
        {
            if (n > 10000) Console.WriteLine("Hold on, this process may take a while...");
            for (long i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
