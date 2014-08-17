using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class OddOrEven
    {
        //Write an expression that checks if given integer is odd or even.
        static void Main(string[] args)
        {
            int givenInteger = 9;
            Console.WriteLine(givenInteger % 2 == 0? "Integer is Even" : "Integer is Odd");
        }
    }
}
