using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToN
{
    class OneToN
    {
        // Write a program that prints all the numbers from 1 to N.
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 0; i <= n; i++)
            {
                Console.Write(i+", ");
            }
        }
    }
}
