using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestWord
{
    class LongestWord
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string[] words = Console.ReadLine().Split(' ', '.', ',', ';', ':');
            int maxLength = int.MinValue;
            string longestWord = string.Empty;
            foreach (string word in words)
            {

                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    longestWord = word;
                }
            }
            Console.WriteLine("Longest word: " + longestWord);
            Console.WriteLine(" - {0} symbols.", maxLength);
        }
    }
}
