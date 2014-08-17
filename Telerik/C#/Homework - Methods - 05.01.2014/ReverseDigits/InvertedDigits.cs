using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseDigits
{
    class InvertedDigits
    {
        // Write a method that reverses the digits of given decimal number. Example: 256 -> 652

        static void Main(string[] args)
        {
            Console.Write("Input desired number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Reverse: " + ReverseDigits(n));
        }
        static int ReverseDigits(int num)
        {
            int tempNum = num;
            int result = 0;
            while(tempNum > 0)
            {
                result = result * 10 + tempNum % 10;
                tempNum /= 10;
            }
            return result;
        }
    }
}
