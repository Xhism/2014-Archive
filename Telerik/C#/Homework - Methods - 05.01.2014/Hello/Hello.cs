using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Hello
    {
        // Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
        //  Write a program to test this method.

        static void Main(string[] args)
        {
            PrintName();
        }
        static void PrintName()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
        }
    }
}
