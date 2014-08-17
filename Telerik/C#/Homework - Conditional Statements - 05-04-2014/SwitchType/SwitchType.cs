using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchType
{
    class SwitchType
    {
        // Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1.
        // If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.
        static void Main(string[] args)
        {
            Console.WriteLine("Please input 1 for Int, 2 for Double, or 3 for String");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please input desired integer:");
                    int n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Starting variable: {0}\nModified variable: {1}", n1, n1+1);
                    break;
                case 2:
                    Console.WriteLine("Please input desired floating-point variable:");
                    double n2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Starting varuable: {0}\nModified variable: {1}", n2, n2+1);
                    break;
                case 3:
                    Console.WriteLine("Please input desired string:");
                    string input = Console.ReadLine();
                    Console.WriteLine("Starting string: {0}\nModified string: {1}", input, input+'*');
                    break;
                default:
                    Console.WriteLine("Incorrect Input.");
                    break;
            }
        }
    }
}
