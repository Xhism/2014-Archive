using System;
using System.IO;

namespace ConcatFiles
{
    class ConcatFiles
    {
        static void Main()
        {
            Console.Write("Input directory of first file:  ");
            string input1 = Console.ReadLine();
            Console.Write("Input directory of second file:  ");
            string input2 = Console.ReadLine();
            Console.Write("Input directory of desired output file:  ");
            string outputFile = Console.ReadLine();
            using (StreamWriter output = new StreamWriter(outputFile))
            {
                WriteToFile(output, input1);
                WriteToFile(output, input2);
            }
        }
        static void WriteToFile(StreamWriter output, string file)
        {
            using (StreamReader input = new StreamReader(file))
                for (string line; (line = input.ReadLine()) != null; )
                    output.WriteLine(line);
        }


    }
}
