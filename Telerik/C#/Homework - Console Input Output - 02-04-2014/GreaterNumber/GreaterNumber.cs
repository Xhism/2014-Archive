using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class GreaterNumber
    {
        // Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
        static void Main(string[] args)
        {
            Console.Write("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The greater of the two numbers is: {0}", Math.Max(num1,num2));
        }
    }
}
