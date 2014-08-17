using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorielExpression
{
    class FactorielExpression
    {
        // Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
        static void Main(string[] args)
        {
            Console.WriteLine("Input N:");
            int n = 0;
            bool nCheck = int.TryParse(Console.ReadLine(), out n);

            nCheck = 1 < n;// checks whether 1<N<K

            Console.WriteLine("Input K:");
            int k = 0;
            bool kCheck = int.TryParse(Console.ReadLine(), out k); 

            if ((nCheck && kCheck) && k > n)
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
                Console.WriteLine("N! * K! / (N - K) = {0}", nFactoriel * kFactoriel / (n-k));
            }
            else Console.WriteLine("Error, check given conditions.");
        }
    }
}
