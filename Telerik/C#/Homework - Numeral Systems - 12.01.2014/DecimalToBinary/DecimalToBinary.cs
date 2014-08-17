using System;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Input desired Decimal number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary: " + DecToBin(n));
        }
        static string DecToBin(int num)
        {
            string binary = string.Empty;
            while (num > 0)
            {
                binary = num % 2 + binary;
                num /= 2;
            }

            return binary;
        }
    }
}
