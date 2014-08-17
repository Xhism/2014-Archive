using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.CaseInsensitiveSearch
{
    class CIS
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string sub = "in";
            Console.WriteLine("\"{0}\" was found {1} time(s).", sub, Regex.Matches(text, sub, RegexOptions.IgnoreCase).Count);
        }
    }
}
