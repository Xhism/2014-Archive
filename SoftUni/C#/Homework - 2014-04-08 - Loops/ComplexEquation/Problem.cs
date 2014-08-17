using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexEquation
{
    class Problem
    {
        static void Main(string[] args)
        {
            double sum = 1;
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input x: ");
            int x = int.Parse(Console.ReadLine());
            double currentDivident = 1;
            double currentDivisor = 1;
            for (int i = 1; i <= n; i++)
            {
                currentDivident *= i;
                currentDivisor *= x;
                sum += currentDivident / currentDivisor;
            }
            Console.WriteLine("Result: {0:0.00000}", sum);
        }
    }
}
