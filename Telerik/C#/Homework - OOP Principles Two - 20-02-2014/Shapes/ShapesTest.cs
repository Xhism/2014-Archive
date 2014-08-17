using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSurfaceForDiferentShapes
{
    class ShapesTest
    {
        static void Main(string[] args)
        {
            int shapeCount = 0;

            Circle circle = new Circle(5);

            Triangle triangle = new Triangle(5, 6);

            Rectangle rectangle = new Rectangle(5, 4);

            Shape[] array = { circle, triangle, rectangle };
            foreach (Shape shape in array)
            {
                shapeCount++;
                Console.WriteLine("Shape " + shapeCount + " has a surface of " + shape.CalculateSurface());
            }
        }
    }
}
