using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractLetters
{
    class ExtractLetters
    {
        static void Main()
        {
            string str = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";

            int[] values = new int['z' - 'a' + 1];

            foreach (char character in str.ToLower())
                if ('a' <= character && character <= 'z') values[character - 'a']++;

            for (int i = 0; i < values.Length; i++)
                if (values[i] != 0) Console.WriteLine("{0}: {1}", (char)(i + 'a'), values[i]);
        }
    }
}
