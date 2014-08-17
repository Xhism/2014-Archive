using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode
{
    class Unicode
    {
        // Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72.

        static void Main(string[] args)
        {
            int var1 = 72;
            Console.WriteLine("The Unicode for 72 is {0}", (char)var1);
        }
    }
}
