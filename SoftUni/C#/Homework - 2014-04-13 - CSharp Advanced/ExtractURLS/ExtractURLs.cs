using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractURLS
{
    class ExtractURLs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input text:");
            string[] words = Console.ReadLine().Split(' ');
            Console.WriteLine("\nURLs:");
            foreach(string word in words)
            {
                if (word.Split(':').Contains("http") || (word.Split('.').Contains("www") && (word.Split('.').Contains("com") 
                    || word.Split('.').Contains("org") || word.Split('.').Contains("net") || word.Split('.').Contains("bg"))))
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
