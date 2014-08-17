using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyrightTriangle
{
    // Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol.
    // Note: the © symbol may be displayed incorrectly.

    class CopyrightTriangle
    {
        static void Main(string[] args)
        {
            char copyright = '\u00A9';
            for (int i = 1; i <= 5; i+=2)
            {
                Console.Write(new string(' ', 2-(i-1)/2));
                Console.WriteLine(new string(copyright, i));

            }
        }
    }
}
