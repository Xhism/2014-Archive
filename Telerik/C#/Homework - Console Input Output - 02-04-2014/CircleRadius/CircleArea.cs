using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleRadius
{
    class CircleArea
    {
        // Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 decimal point.
        static void Main(string[] args)
        {
            Console.Write("Input circle radius: ");
            double r = double.Parse(Console.ReadLine());
            double perimeter = 2*r*3.14159;
            double area = r*r*3.14159;
            Console.WriteLine("Perimeter= {0}", perimeter.ToString("0.00"));
            Console.WriteLine("Area= {0}", area.ToString("0.00"));
        }
    }
}
