using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Combinations
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input k: ");
            int k = int.Parse(Console.ReadLine());
            double nFact = 1, resFact = 1, kFact = 1;
            double result = 1;
            if (n <= 1 || k <= 1 || n >= 100 || k >= 100 || k >= n)
            {
                Console.WriteLine("Error: 1 < k < n < 100");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    nFact *= i;
                }
                for (int i = 1; i <= k; i++)
                {
                    kFact *= i;
                }
                for (int i = 1; i <= n-k; i++)
                {
                    resFact *= i;
                }
                result = nFact / (kFact * resFact);
                Console.WriteLine("n! / (k! * (n-k)!) = " + result);
            }
        }
    }
}
