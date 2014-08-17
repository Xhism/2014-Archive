using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrecisionCompare
{
    // Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01) false;  (5.00000001 ; 5.00000003) true

    class PrecisionCompare
    {
        static void Main(string[] args)
        {
            float num1 = 5.000000001f;
            float num2 = 5.000000003f; // The numbers we are currently comparing
            bool areEqual = false;
            if (num1 == num2) areEqual = true;
            Console.WriteLine(areEqual);
        }
    }
}
