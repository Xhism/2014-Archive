using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeConvert
{
    class UnicodeConvert
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input desired string: ");
            string text = Console.ReadLine();

            string converted = ConvertToUTF(text);
            Console.WriteLine(converted);
        }
        static string ConvertToUTF(string str)
        {
            StringBuilder utf = new StringBuilder();

            foreach (char character in str)
                utf.AppendFormat("\\u{0:X4}", (int)character);

            return utf.ToString();
        }
    }
}
