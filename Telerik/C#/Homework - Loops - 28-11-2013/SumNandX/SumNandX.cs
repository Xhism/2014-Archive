using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNandX
{
    class SumNandX
    {
        // Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N
        static void Main(string[] args)
        {
            Console.WriteLine("Input N:");
            uint n = 0;
            bool nCheck = uint.TryParse(Console.ReadLine(), out n);

            Console.WriteLine("Input X:");
            int x = 0;
            bool xCheck = int.TryParse(Console.ReadLine(), out x);

            decimal sum = 1;
            uint nFactoriel = 1;

            if (nCheck && xCheck)
            {
                if (n != 0 && x != 0)
                {
                    for (uint i = 1; i <= n; i++)
                    {
                        nFactoriel *= i;
                        sum +=(decimal)nFactoriel/(x*i);
                    }
                }
                else Console.WriteLine("Error: N and X need to both be different by 0 to avoid illegal division.");
            }
            else Console.WriteLine("Error: N needs to be a positive integer and X needs to be an integer.");
            Console.WriteLine("S = "+sum);
        }
    }
}
