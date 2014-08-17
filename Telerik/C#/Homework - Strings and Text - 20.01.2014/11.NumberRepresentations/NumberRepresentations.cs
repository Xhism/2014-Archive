using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumberRepresentations
{
    class NumberRepresentations
    {
        static void Main(string[] args)
        {
            Console.Write("Input desired number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}", number);
            Console.WriteLine("{0,15:X}", number); // Hex
            Console.WriteLine("{0,15:P}", number); // %
            Console.WriteLine("{0,15:E}", number); // Scientific
        }
    }
}
