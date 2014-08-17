using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNames
{
    class CountNames
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ');
            Array.Sort(names);

            var alphabet = new HashSet<string>();
            for (int i = 0; i < names.Length; i++)
            {
                alphabet.Add(names[i]);
            }

            int count = 0;
            foreach (string letter in alphabet)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    if (letter == names[j]) count++;
                }

                Console.WriteLine(letter + " -> " + count);
                count = 0;
            }
            Console.WriteLine();
        }
    }
}
