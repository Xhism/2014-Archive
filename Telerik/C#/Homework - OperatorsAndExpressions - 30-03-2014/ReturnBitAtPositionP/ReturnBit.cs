using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnBitAtPositionP
{
    class ReturnBit
    {
        //Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1 -> false.

        static void Main(string[] args)
        {
            int p = 1;
            int v = 5;
            bool bitAtP = (v >> p & 1) == 1;
            Console.WriteLine(bitAtP);
        }
    }
}
