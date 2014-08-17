using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToBinary
{
    class HexadecimalToBinary
    {
        static void Main()
        {
            Console.Write("Input desired hexadecimal number: ");
            string hex = Console.ReadLine();
            HexToBin(hex);
        }
        static void HexToBin(string hexNumber)
        {
            int binary = 0;
            int count = 0;
            for (int i = hexNumber.Length - 1; i >= 0; i--, count++)
            {
                switch (hexNumber[i])
                {
                    case 'A':
                    case 'a':
                        binary = binary | (10 << 4 * count); break;
                    case 'B':
                    case 'b':
                        binary = binary | (11 << 4 * count); break;
                    case 'C':
                    case 'c':
                        binary = binary | (12 << 4 * count); break;
                    case 'D':
                    case 'd':
                        binary = binary | (13 << 4 * count); break;
                    case 'E':
                    case 'e':
                        binary = binary | (14 << 4 * count); break;
                    case 'F':
                    case 'f':
                        binary = binary | (15 << 4 * count); break;
                    default:
                        binary = binary | ((hexNumber[i] - 48) << 4 * count); break;
                }
            }
            Console.WriteLine("Binary: " + Convert.ToString(binary, 2));
        }
    }
}
