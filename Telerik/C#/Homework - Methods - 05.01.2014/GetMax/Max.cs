using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class Max
    {
        // Write a method GetMax() with two parameters that returns the bigger of two integers. 
        // Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

        static void Main(string[] args)
        {
            Console.Write("Input first integer: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input second integer: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Input third integer: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("The Biggest integer is " + GetMax(a,GetMax(b,c)));
        }
        static int GetMax(int n1, int n2)
        {
            if (n1 > n2)
                return n1;
            else
                return n2;
        }
    }
}
