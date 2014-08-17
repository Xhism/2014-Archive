using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitValue
{
    class ExtractBitValue
    {
        //Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 -> value=1.

        static void Main(string[] args)
        {
            int i = 5;
            int b = 2;
            Console.WriteLine(i >> b & 1);
        }
    }
}
