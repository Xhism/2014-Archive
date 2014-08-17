using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace RemoveTest
{
    class RemoveTest
    {
        static void Main(string[] args)
        {
            DeleteTestPrefix("../../input.txt");
        }

        private static void DeleteTestPrefix(string fileName)
        {
            List<string> fileInfo = new List<string>();
            using (StreamReader input = new StreamReader(fileName))
            {
                string line = input.ReadLine();
                string pattern = "\\btest\\w*";
                while (line != null)
                {
                    Regex rgx = new Regex(pattern);
                    line = rgx.Replace(line, "");
                    fileInfo.Add(line);
                    line = input.ReadLine();
                }
            }

            using (StreamWriter output = new StreamWriter(fileName))
            {
                for (int i = 0; i < fileInfo.Count; i++)
                {
                    output.WriteLine(fileInfo[i]);
                }
            }
        }
    }
}
