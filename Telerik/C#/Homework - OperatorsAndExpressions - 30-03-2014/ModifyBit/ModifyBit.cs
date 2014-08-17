using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class ModifyBit
    {
        //We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	    //Example: n = 5 (00000101), p=3, v=1 -> 13 (00001101); n = 5 (00000101), p=2, v=0 -> 1 (00000001)

        static void Main(string[] args)
        {
            int n = 5; // The given integer that we want to modify
            int p = 3; // The position of the bit we are changing
            int v = 1; // The value of the changed bit (0 or 1)
            int checkV = ((1 << p & n) >> p);

            if (checkV == v) Console.WriteLine("Nothing to change;\nn = {0}", n);
            else if (v == 0) Console.WriteLine("Modified n = {0}", n ^ (1 << p));
            else if (v == 1) Console.WriteLine("Modified n = {0}", (1 << p) | n);
            else Console.WriteLine("Wrong Bit value for v;\n Please input 0 or 1");
        }
    }
}
