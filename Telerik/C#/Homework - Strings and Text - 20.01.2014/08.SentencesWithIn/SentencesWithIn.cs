using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _08.SentencesWithIn
{
    class SentencesWithIn
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string word = "in";
            SentWithWord(text, word);
        }
        static void SentWithWord(string str, string word)
        {
            string[] sentences = str.Split('.');
            for (int i = 0; i < sentences.Length; i++)
            {
                if (Regex.Matches(sentences[i], @"\b" + word + @"\b.?", RegexOptions.IgnoreCase).Count > 0)
                {
                    Console.WriteLine((sentences[i] + ".").Trim());
                }
            }
        }
    }
}
