using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class RectangleArea
    {
        //Write an expression that calculates rectangle’s area by given width and height.

        static void Main(string[] args)
        {
            int width = 5;
            int height = 7;
            Console.WriteLine("A rectangle with width {0} and height {1} has an area of {2}", width, height, width*height);
        }
    }
}
