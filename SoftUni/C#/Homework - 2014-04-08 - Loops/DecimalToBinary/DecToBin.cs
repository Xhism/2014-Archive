using System;

namespace DecimalToBinary
{
    class DecToBin
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number in the Decimal system: ");
            int n = int.Parse(Console.ReadLine());
            string binary = string.Empty;
            while (n > 0)
            {
                binary = n % 2 + binary;
                n /= 2;
            }
            Console.WriteLine("Binary: " + binary);
        }
    }
}
