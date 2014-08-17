using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Reverse
{
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input desired string:");
            string str = Console.ReadLine();
            char[] strCopy = str.ToCharArray();
            Array.Reverse(strCopy);
            Console.WriteLine(strCopy);
        }
    }
}
