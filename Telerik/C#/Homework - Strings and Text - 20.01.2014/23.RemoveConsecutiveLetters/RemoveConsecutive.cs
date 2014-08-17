using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _23.RemoveConsecutiveLetters
{
    class RemoveConsecutive
    {
        static void Main()
        {
            string str = "aaaaabbbbbcdddeeeedssaa";

            Console.WriteLine(Regex.Replace(str, @"(\w)\1+", "$1"));
        }
    }
}
