using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        //Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

        static void Main(string[] args)
        {
            int pX = 2; // Given Point's X Coordinate
            int pY = 3; // Given Point's Y Coordinate

            Console.WriteLine(Math.Pow(pX - 1, 2) + Math.Pow(pY - 1, 2) <= 3 * 3 ? "The Point is within the given Circle" : "The Point is out of the given Circle");
            Console.WriteLine((pX < -1 || pX > 5 || pY < 1 || pY > 3) ? "The Point is out of the given Rectangle" : "The Point is within the given Rectangle");

            Console.WriteLine(((Math.Pow(pX - 1, 2) + Math.Pow(pY - 1, 2) <= 3 * 3) && (pX < -1 || pX > 5 || pY < 1 || pY > 3)) ? "The given Point Satisfies both conditions" : "The given point doesn't satisfy both conditions");
            // The first two expressions serve as individual checks for each of the conditions
            // The third expression combines the first two into one as that is the requirement for solving the problem
        }
    }
}
