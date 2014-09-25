using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03___Point3D
{
    class Paths
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Point3D.StartingPoint.ToString());
            Point3D rectA = new Point3D("A", 1.2, 3, 5.6);
            Point3D rectB = new Point3D("B", -1.2, 3, 5.6);
            Point3D rectC = new Point3D("C", 1.2, -3, 5.6);
            Point3D rectD = new Point3D("D", 1.2, 3, -5.6);
            Path3D path = new Path3D(rectA, rectB, rectC, rectD);
            Console.WriteLine();

            Console.WriteLine(path.ToString());

            for (int i = 0; i < path.Count; i++)
            {
                Console.WriteLine(path[i]);
            }
            Console.WriteLine();

            Console.WriteLine(DistanceCalculator.CalculateDistance3D(rectA, rectD));
            Console.WriteLine();

            Storage.SavePath(@"../../Paths/SavedPaths.txt", true, path);
            Storage.SavePath(@"../../Paths/SavedPaths.txt", false, path);
            var loadedList = Storage.LoadPaths(@"../../Paths/SavedPaths.txt");
            loadedList.ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
