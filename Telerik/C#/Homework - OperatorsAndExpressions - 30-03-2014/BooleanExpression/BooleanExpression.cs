using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanExpression
{
    class BooleanExpression
    {
        //Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

        static void Main(string[] args)
        {
            int givenInteger = 36;
            bool canBeDivided = true;
            if (givenInteger % 5 != 0 || givenInteger % 7 != 0) canBeDivided = false;
            Console.WriteLine("It is {0} that the given integer can be divided both by 7 and 5", canBeDivided);
        }
    }
}
