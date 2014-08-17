using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Dictionary
{
    class Dictionary
    {
        static void Main()
        {
            string text = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";
            string[] words = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] = dict[word] + 1;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }

            foreach (var word in dict)
            {
                Console.WriteLine("{0,-15} - {1} times", word.Key, word.Value);
            }
        }
    }
}
