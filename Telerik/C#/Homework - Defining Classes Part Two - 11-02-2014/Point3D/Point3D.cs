using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Point3D
{
    class Point3D
    {
        public struct strPoint3D
        {
            private double x;
            private double y;
            private double z;

            public strPoint3D(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public double X
            {
                get { return x; }
                set { x = value; }
            }

            public double Y
            {
                get { return y; }
                set { y = value; }
            }

            public double Z
            {
                get { return z; }
                set { z = value; }
            }

            static readonly strPoint3D startPoint3D = new strPoint3D(0, 0, 0);

            public strPoint3D StartPoint3D
            {
                get { return startPoint3D; }
            }

            public override string ToString()
            {
                return "X: " + this.x + ", Y: " + this.y + ", Z: " + this.z;
            }

        }


        public static class CalcPoints3D // within Point3D class
        {
            public static double CalcDistance(strPoint3D point1, strPoint3D point2)
            {
                double distance = 0, tmpDistance = 0;
                double min, max;

                min = Math.Min(point1.X, point2.X);
                max = Math.Max(point1.X, point2.X);
                tmpDistance = min - max;
                distance += tmpDistance * tmpDistance;

                min = Math.Min(point1.Y, point2.Y);
                max = Math.Max(point1.Y, point2.Y);
                tmpDistance = min - max;
                distance += tmpDistance * tmpDistance;

                min = Math.Min(point1.Z, point2.Z);
                max = Math.Max(point1.Z, point2.Z);
                tmpDistance = min - max;
                distance += tmpDistance * tmpDistance;

                distance = Math.Sqrt(distance);

                return distance;
            }
        }
        public class Path // within Point3D class
        {
            private strPoint3D point = new strPoint3D();


            public Path(double x, double y, double z)
            {
                this.point.X = x;
                this.point.Y = y;
                this.point.Z = z;
            }


            public double X
            {
                get { return point.X; }
                set { point.X = value; }
            }

            public double Y
            {
                get { return point.Y; }
                set { point.Y = value; }
            }

            public double Z
            {
                get { return point.Z; }
                set { point.Z = value; }
            }

            public override string ToString()
            {
                return this.X + ";" + this.Y + ";" + this.Z + ";";
            }
        }

        public static class PathStorage // within Point3D class
        {

            public static void SavePath(string fileName, string buffer)
            {
                try
                {
                    StreamWriter writer = new StreamWriter(fileName);
                    using (writer)
                    {
                        writer.Write(buffer);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("You does not have the required permission for file: {0}", fileName);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File {0} not found", fileName);
                }
                catch (IOException)
                {
                    Console.WriteLine("An I/O error occurred while opening the file: {0}", fileName);
                }
            }

            public static string LoadPath(string fileName)
            {
                string buffer = string.Empty;
                try
                {
                    StreamReader reader = new StreamReader(fileName);
                    using (reader)
                    {
                        buffer = reader.ReadToEnd();
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    Console.WriteLine("You does not have the required permission for file: {0}", fileName);
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File {0} not found", fileName);
                }
                catch (IOException)
                {
                    Console.WriteLine("An I/O error occurred while opening the file: {0}", fileName);
                }

                return buffer;
            }
        }

        public static void Point3DTest()
        {
            strPoint3D Point3D_1 = new strPoint3D(1, 1, 1);
            strPoint3D Point3D_2 = new strPoint3D(5, 5, 5);

            Console.Write("Start point: ");
            Console.WriteLine(Point3D_1.StartPoint3D.ToString());

            Console.Write("Point 1: ");
            Console.WriteLine(Point3D_1.ToString());

            Console.Write("Point 2: ");
            Console.WriteLine(Point3D_2.ToString());

            Console.Write("Distance: ");
            Console.WriteLine(CalcPoints3D.CalcDistance(Point3D_1, Point3D_2));

            List<Path> PointHistory = new List<Path>();

            Path tempPath1 = new Path(2, 45, 19);
            PointHistory.Add(tempPath1);

            Path tempPath2 = new Path(21, 15, 4);
            PointHistory.Add(tempPath2);

            Path tempPath3 = new Path(12, 4, 33);
            PointHistory.Add(tempPath3);

            Console.WriteLine("Save Path history:");
            string buffer = string.Empty;
            foreach (var path in PointHistory)
            {
                Console.WriteLine(path.ToString());
                buffer += path.ToString() + "\r\n";
            }
            PathStorage.SavePath(@"..\..\Save.txt", buffer);

            Console.WriteLine("Load Path history:");
            buffer = PathStorage.LoadPath(@"..\..\Save.txt");
            Console.WriteLine(buffer);
        }
    }
}
