using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDivisible
{
    class NotDivisible
    {
        // Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
        static void Main(string[] args)
        {
            int n = 35;
            for (int i = 0; i <= n; i++)
            {
                if (i % (3 * 7) != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
