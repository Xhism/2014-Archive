using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOrMinus
{
    class PlusOrMinus
    {
        // Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.Write("Input third number: ");
            double n3 = double.Parse(Console.ReadLine());
            bool res1 = false, res2 = false, res3 = false;
            if (n1 > 0)
            {
                res1 = true;
            }
            if (n2 > 0)
            {
                res2 = true;
            }
            if (n3 > 0)
            {
                res3 = true;
            }
            if(n1 == 0 || n2 == 0 || n3 == 0)
            {
                Console.WriteLine("0");
            }
            else if ((res1 ^ res2) ^ res3 == true)
            {
                Console.WriteLine("+");
            }
            else 
            {
                Console.WriteLine("-");
            }
        }
    }
}
