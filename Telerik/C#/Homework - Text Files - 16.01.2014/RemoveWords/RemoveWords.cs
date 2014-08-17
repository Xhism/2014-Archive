using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RemoveWords
{
    class RemoveWords
    {
        static void Main()
        {
            try
            {
                string regex = @"\b(" + String.Join("|", File.ReadAllLines("../../words.txt")) + @")\b";

                using (StreamReader input = new StreamReader("../../input.txt"))
                using (StreamWriter output = new StreamWriter("../../output.txt"))
                    for (string line; (line = input.ReadLine()) != null; )
                        output.WriteLine(Regex.Replace(line, regex, String.Empty));
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
