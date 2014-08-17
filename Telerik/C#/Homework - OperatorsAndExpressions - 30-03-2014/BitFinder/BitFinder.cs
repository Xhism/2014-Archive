using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitFinder
{
    class BitFinder
    {
        //Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

        static void Main(string[] args)
        {
            int givenInteger = 9;
            givenInteger = givenInteger >> 3;
            Console.WriteLine("Bit 3 equals {0}", givenInteger & 1);

        }
    }
}
