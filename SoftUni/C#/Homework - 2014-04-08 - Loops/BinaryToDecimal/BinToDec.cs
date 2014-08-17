using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinToDec
    {
        static void Main(string[] args)
        {
            Console.Write("Input a binary number: ");
            string input = Console.ReadLine();
            int dec = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if(input[input.Length-i-1] == '1')
                    dec += (int)Math.Pow(2, i);
            }
            Console.WriteLine("Decimal Representation: " + dec);
        }
    }
}
