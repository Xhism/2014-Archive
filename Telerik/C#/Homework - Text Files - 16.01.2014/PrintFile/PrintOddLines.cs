using System;
using System.IO;

namespace PrintFile
{
    class PrintOddLines
    {
        static void Main(string[] args)
        {
            Console.Write("Input file path: ");
            string inputPath = Console.ReadLine();
            using (StreamReader fileContents = new StreamReader(inputPath))
            {
                int lineNumber = 0;
                for (string line; (line = fileContents.ReadLine()) != null; lineNumber++)
                {
                    if (lineNumber % 2 == 1)
                        Console.WriteLine(lineNumber + ":  " + line);
                }
            }
        }
    }
}
