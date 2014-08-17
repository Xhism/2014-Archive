using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointWithinCircle
{
    class PointWithinCircle
    {
        //Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

        static void Main(string[] args)
        {
            int givenPointX = 2;
            int givenPointY = 3;
            Console.WriteLine(givenPointX*givenPointX + givenPointY*givenPointY <= 25? "The Point is within the given Circle" : "The Point is NOT within the Given Circle");

        }
    }
}
