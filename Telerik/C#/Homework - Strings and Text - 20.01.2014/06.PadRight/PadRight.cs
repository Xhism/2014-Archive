using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PadRight
{
    /*Write a program that reads from the console a string of maximum 20 characters. 
     * If the length of the string is less than 20, the rest of the characters should be filled with '*'.
     * Print the result string into the console. */

    class PadRight
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input desired string:");
            string text = Console.ReadLine();

            Console.WriteLine("\nResult:");
            if(text.Length <= 20)
                Console.WriteLine(text.PadRight(20,'*'));
            else
                Console.WriteLine("The string was too long.");
        }
    }
}
