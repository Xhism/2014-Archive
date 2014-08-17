using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedFactoriel
{
    class DividedFactoriel
    {
        // Write a program that calculates N!/K! for given N and K (1<K<N).
        static void Main(string[] args)
        {
            Console.WriteLine("Input N:");
            int n = 0;
            bool nCheck = int.TryParse(Console.ReadLine(), out n);

            Console.WriteLine("Input K:");
            int k = 0;
            bool kCheck = int.TryParse(Console.ReadLine(), out k);

            kCheck = 1 < k; // Checks whether 1<K<N

            if((nCheck && kCheck) && k<n)
            {
                double nFactoriel = 1;
                for (int i = 1; i < n; i++)
                {
                    nFactoriel *= i;
                }
                double kFactoriel = 1;
                for (int i = 1; i < k; i++)
                {
                    kFactoriel *= 1;
                }
                Console.WriteLine("N! / K! = {0}", nFactoriel/kFactoriel);
            }
            else Console.WriteLine("Error, check given conditions.");
        }
    }
}
