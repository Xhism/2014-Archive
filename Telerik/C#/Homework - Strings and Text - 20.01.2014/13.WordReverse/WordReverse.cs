using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _13.WordReverse
{
    class WordReverse
    {
        static void Main()
        {
            string str = "C# is not C++, not PHP and not Delphi!";
            List<char> listLetters = new List<char>();

            for (char i = 'a'; i <= 'z'; i++) listLetters.Add(i);
            for (char i = 'A'; i <= 'Z'; i++) listLetters.Add(i);
            for (char i = '0'; i <= '9'; i++) listLetters.Add(i);

            listLetters.Add('@'); listLetters.Add('#'); listLetters.Add('$');
            listLetters.Add('%'); listLetters.Add('&'); listLetters.Add('&');
            listLetters.Add('*'); listLetters.Add('+'); listLetters.Add('-');
            listLetters.Add('^'); listLetters.Add('~');

            string[] strWords = str.Split(new char[] { '.', ',', '!', '?', ':', ';', '"', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] signs = str.Split(listLetters.ToArray(), StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(strWords);
            StringBuilder strWordsReversed = new StringBuilder();

            for (int i = 0; i < signs.Length; i++)
            {
                strWordsReversed.Append(strWords[i]);
                strWordsReversed.Append(signs[i]);
            }
            Console.WriteLine(strWordsReversed.ToString());
        }
    }
}
