using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace _01_03___Point3D
{
    static class Storage
    {
        public static void SavePath(string fullFilename, bool append, Path3D path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fullFilename, append, Encoding.GetEncoding("UTF-8")))
                {
                    sw.WriteLine(path.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex.InnerException;
            }
        }
        public static List<Path3D> LoadPaths(string fullFilename)
        {
            try
            {
                List<Path3D> paths = new List<Path3D>();
                using (StreamReader sr = new StreamReader(fullFilename, Encoding.GetEncoding("UTF-8")))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        Path3D points = new Path3D();
                        var lines = line.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var l in lines)
                        {
                            points.Add(Point3D.Deserialize(l));
                        }
                        line = sr.ReadLine();
                        paths.Add(points);
                    }
                }
                return paths;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex.InnerException;
            }
        }
    }
}
