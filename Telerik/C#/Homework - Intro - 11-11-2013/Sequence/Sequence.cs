using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence
{
    // Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

    class Sequence
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                int count = 2;
                count += i;
                if (count % 2 == 0) Console.Write("{0}  ",count);
                else Console.Write("{0}  ", -count);
            }
        }
    }
}
