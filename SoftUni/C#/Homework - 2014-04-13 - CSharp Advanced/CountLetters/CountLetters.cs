using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountLetters
{
    class CountLetters
    {
        static void Main()
        {
            string[] letters = Console.ReadLine().Split(' ');
            Array.Sort(letters);

            var alphabet = new HashSet<string>();
            for (int i = 0; i < letters.Length; i++)
            {
                alphabet.Add(letters[i]);
            }

            int count = 0;
            foreach (string letter in alphabet)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (letter == letters[j]) count++;
                }

                Console.WriteLine(letter + " -> " + count);
                count = 0;
            }
            Console.WriteLine();
        }
    }
}
