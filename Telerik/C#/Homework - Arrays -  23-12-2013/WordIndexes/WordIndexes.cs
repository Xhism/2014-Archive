using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordIndexes
{
    class WordIndexes
    {
        static void Main(string[] args)
        {
            int[] letterIndexes = new int[53];
            string testWord = "abzABZ";

            //put the Small letters in the array
            for (int i = 1; i < letterIndexes.Length / 2 + 1; i++)
            {
                letterIndexes[i] = 'a' + i - 1;
            }

            //put the Capital letters in the array
            for (int i = letterIndexes.Length / 2 + 1; i < letterIndexes.Length; i++)
            {
                letterIndexes[i] = 'A' + (i - (letterIndexes.Length / 2 + 1));
            }
            //Find the letters of the word in the array
            for (int i = 0; i < testWord.Length; i++)
            {
                for (int j = 0; j < letterIndexes.Length; j++)
                {
                    if (testWord[i] == letterIndexes[j])
                    {
                        Console.WriteLine("Letter {0} has index: {1}", testWord[i], j);
                        break;
                    }
                }
            }
        }
    }
}
