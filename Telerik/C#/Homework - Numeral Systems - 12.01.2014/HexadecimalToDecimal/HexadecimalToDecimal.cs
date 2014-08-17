using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {


        static void Main()
        {
            Console.Write("Input desired hex number without the beginning \"0x...\": ");
            string hexNumber = Console.ReadLine();
            int count = hexNumber.Length - 1;
            int digit = 0;
            int result = 0;

            for (int i = 0; i < hexNumber.Length; i++)
            {
                switch (hexNumber[i])
                {
                    case 'A':
                    case 'a':
                        digit = 10; break;
                    case 'B':
                    case 'b':
                        digit = 11; break;
                    case 'C':
                    case 'c':
                        digit = 12; break;
                    case 'D':
                    case 'd':
                        digit = 13; break;
                    case 'E':
                    case 'e':
                        digit = 14; break;
                    case 'F':
                    case 'f':
                        digit = 15; break;
                    default: digit = int.Parse(Convert.ToString(hexNumber[i])); break;
                }

                result += digit * Power(count);
                count--;
            }

            Console.WriteLine("Decimal: " + result);
        }
        private static int Power(int sqr)
        {
            return (1 << (sqr * 4));
        }
    }
}
