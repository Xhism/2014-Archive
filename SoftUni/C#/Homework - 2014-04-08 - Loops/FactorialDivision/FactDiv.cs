using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialDivision
{
    class FactDiv
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input k: ");
            int k = int.Parse(Console.ReadLine());
            int result = 1;
            if (n <= 1 || k <= 1 || n >= 100 || k >= 100 || k >= n)
            {
                Console.WriteLine("Error: 1 < k < n < 100");
            }
            else
            {
                for (int i = n; i > k; i--)
                {
                    result *= i;
                }
                Console.WriteLine("n!/k! = " + result);
            }
        }
    }
}
