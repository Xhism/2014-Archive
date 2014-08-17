using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quotations
{
    // Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
    // Do the above in two different ways: with and without using quoted strings.

    class Quotations
    {
        static void Main(string[] args)
        {
            string quot1 = "The \"use\" of quotations causes difficulties.";
            string quot2 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(quot1);
            Console.WriteLine(quot2);
        }
    }
}
