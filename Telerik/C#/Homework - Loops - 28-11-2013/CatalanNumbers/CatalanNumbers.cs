using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        // In the combinatorial mathematics, the Catalan numbers are calculated by the following formula: check Presentation - Loops - Slide 59: Exercises (3)
        // Write a program to calculate the Nth Catalan number by given N.
        static void Main(string[] args)
        {
            int n;
            bool checkN = int.TryParse(Console.ReadLine(), out n);
            do
            {
                n = int.Parse(Console.ReadLine());
            } while (n < 0);

            int factoriel2n = 1;
            int factorielNplus1 = 1;
            int nFactoriel = 1;

            for (int i = 1; i <= n; i++)
            {
                nFactoriel *= i;
            }

            for (int j = 1; j <= 2 * n; j++)
            {
                factoriel2n *= j;
            }

            for (int h = 1; h <= n + 1; h++)
            {
                factorielNplus1 *= h;
            }

            Console.WriteLine(factoriel2n / (factorielNplus1 * nFactoriel));   
        }
    }
}
