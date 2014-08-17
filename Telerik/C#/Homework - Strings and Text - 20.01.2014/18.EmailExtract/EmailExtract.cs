using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _18.EmailExtract
{
    class EmailExtract
    {
        static void Main()
        {
            string str = "Hello, nakov@telerik.com! I have stolen the following email address from you:  nakov@gmail.com ";

            foreach (var item in Regex.Matches(str, @"\w+@\w+\.\w+"))
                Console.WriteLine(item);
        }
    }
}
