using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

            int givenInteger = 1732;
            givenInteger /= 100;
            Console.WriteLine(givenInteger % 10 == 7? "True" : "False");
        }
    }
}
