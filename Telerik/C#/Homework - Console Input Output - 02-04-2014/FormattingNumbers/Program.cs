using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer a: ");
            int a = int.Parse(Console.ReadLine());
            while (a < 0 || a > 500)
            {
                Console.WriteLine("Invalid input.");
                a = int.Parse(Console.ReadLine());
            }
            Console.Write("Input floating-point b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input floating-point c: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("///");
            Console.Write("{0,-10:x}", a);
            Console.Write("///");
            Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write("///");
            Console.Write("{0,10:F2}", b);
            Console.Write("///");
            Console.Write("{0,-10:F3}", c);
            Console.WriteLine("///");
        }
    }
}
