using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestArea
{
    class LongestArea
    {
        static void Main()
        {
            Console.Write("Input amount of words: ");
            int n = int.Parse(Console.ReadLine());
            string[] words = new string[n];

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write("Input word number {0}: ", i+1);
                words[i] = Console.ReadLine();
            }

            int maxSequence = 0;
            string value = null;

            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;

                for (int j = i; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        count++;

                        if (maxSequence < count)
                        {
                            maxSequence = count;
                            value = words[i];
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine("\n{0} times", maxSequence);
            for (int i = 0; i < maxSequence; i++)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
        }
    }
}
