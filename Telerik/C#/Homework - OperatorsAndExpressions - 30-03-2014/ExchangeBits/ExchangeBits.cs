using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeBits
{
    class ExchangeBits
    {
        //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

        static void Main(string[] args)
        {
            uint givenInteger = 50;
            Console.WriteLine("Number at START: {0}", givenInteger);
            Console.WriteLine("Binary for the Number: {0}", Convert.ToString(givenInteger, 2).PadLeft(32, '0')); // Prints the Binary value with 0s in front
            uint bit345 = (7 << 3) & givenInteger;
            uint bit242526 = (7 << 24) & givenInteger;
            givenInteger = (givenInteger ^ (bit345 | bit242526)) | (bit242526 >> 21) | (bit345 << 21); // Exchanges the bit values using the XOR and OR operators
            Console.WriteLine("Number at END: {0}", givenInteger);
            Console.WriteLine("Binary for the Number: {0}", Convert.ToString(givenInteger, 2).PadLeft(32, '0')); // Prints the Binary value with 0s in front
        }
    }
}
