using System;
using System.IO;

namespace InsertLineNumbers
{
    class InsertLineNumbers
    {
        static void Main(string[] args)
        {
            int lineNumber = 0;
            Console.WriteLine("Please input the directory of the file whose line numbers are to be added: ");
            string inputFile = Console.ReadLine();
            Console.WriteLine("Please input the desired output file directory: ");
            string outputFile = Console.ReadLine();
            using(StreamReader input = new StreamReader(inputFile))
            using(StreamWriter output = new StreamWriter(outputFile))
            for(string line; (line = input.ReadLine()) != null; lineNumber++)
            {
                output.WriteLine(lineNumber + ":  " + line);
            }
        }
    }
}
