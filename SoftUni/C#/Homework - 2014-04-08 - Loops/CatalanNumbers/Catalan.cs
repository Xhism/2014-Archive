using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class Catalan
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            int factorial2n = 1;
            int nFactorial = 1;
            if (n >= 0 && n <= 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    nFactorial *= i;
                }
                for (int j = 1; j <= n * 2; j++)
                {
                    factorial2n *= j;
                }
                Console.WriteLine("Catalan(n) = " + factorial2n / (nFactorial * nFactorial * (n + 1)));
            }
            else
                Console.WriteLine("Error: 0 <= n <= 100!");

        }
    }
}
