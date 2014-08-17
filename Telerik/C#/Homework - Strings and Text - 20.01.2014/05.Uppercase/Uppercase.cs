using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Uppercase
{
    class Uppercase
    {
        static void Main(string[] args)
        {
            string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            Console.WriteLine(ToUppercase(text));
        }

        static string ToUppercase(string str)
        {
            int upperStart = 0;
            int upperEnd = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if(str.Substring(i, 8) == "<upcase>")
                {
                    upperStart = i + 8;
                    i = upperStart;
                }

                if(str.Substring(i,9) == "</upcase>")
                {
                    upperEnd = i;
                    int length = upperEnd - upperStart;
                    string upper = str.Substring(upperStart, length).ToUpper();
                    str = str.Remove(upperStart, length);
                    str = str.Insert(upperStart, upper);
                    str = str.Remove(upperStart - 8, 8);
                    str = str.Remove(upperEnd - 8, 9);
                }
                
            }
            return str;
        }
    }
}
