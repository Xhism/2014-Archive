using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceSubstrings
{
    class ReplaceSub
    {
        static void Main()
        {
            using (StreamReader input = new StreamReader("../../input.txt"))
            using (StreamWriter output = new StreamWriter("../../output.txt"))
                for (string line; (line = input.ReadLine()) != null; )
                    // output.WriteLine(line.Replace("start", "finish")); // Ex.07
                    output.WriteLine(Regex.Replace(line, @"\bstart\b", "finish")); // Ex.08
        }
    }
}
