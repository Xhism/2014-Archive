using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExtractPalindrome
{
    class ExtractPalindrome
    {
        static void Main()
        {
            string text = "Hello, .exe, I will lamal your ABBA!";
            char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
            string[] splitted = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);


            foreach (string word in splitted)
            {
                bool isPalindrome = true;
                for (int j = 0; j < (word.Length / 2); j++)
                {
                    if (word[j] != word[word.Length - 1 - j])
                    {
                        isPalindrome = false;
                        break;
                    }
                }
                if (isPalindrome && word.Length > 1)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
