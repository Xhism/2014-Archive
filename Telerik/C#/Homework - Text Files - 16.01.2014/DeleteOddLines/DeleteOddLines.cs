using System;
using System.IO;
using System.Collections.Generic;

namespace DeleteOddLines
{
    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            List<string> fileInfo = new List<string>();
            using (StreamReader input = new StreamReader("../../input.txt"))
            {
                string line = input.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        fileInfo.Add(line);
                    }
                    line = input.ReadLine();
                    lineNumber++;
                }
            }
            using (StreamWriter output = new StreamWriter("../../input.txt"))
            {
                for (int i = 0; i < fileInfo.Count; i++)
                {
                    output.WriteLine(fileInfo[i]);
                }
            }
        }
    }
}
