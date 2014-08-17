using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class GCD
    {
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int temp = 0;
            while(num2!=0)
            {
                temp = num1 % num2;
                num1 = num2;
                num2 = temp;
            }
            Console.WriteLine("GCD = " + num1);
        }
    }
}
