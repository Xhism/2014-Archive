using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMyName
{
    class PrintMyName
    {
        static void Main(string[] args)
        {
            Console.Write("Input your name here: ");
            string name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
        }
    }
}
