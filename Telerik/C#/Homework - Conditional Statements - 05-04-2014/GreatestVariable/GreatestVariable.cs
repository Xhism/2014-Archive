using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestVariable
{
    class GreatestVariable
    {
        // Write a program that finds the greatest of given 5 variables.
        static void Main(string[] args)
        {
            int n1 = 5;
            int n2 = 10;
            int n3 = 15;
            int n4 = 0;
            int n5 = -5;

            if (n1 < n2)
            {
                n1 = n2;
            }

            if (n1 < n3)
            {
                n1 = n3;
            }
            
            if (n1 < n4)
            {
                n1 = n4;
            }

            if (n1 < n5)
            {
                n1 = n5;
            }
            Console.WriteLine("The greatest variable is {0}", n1);
        }
    }
}
