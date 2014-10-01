using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_StringBuilderExtensions
{
    public static class SbExtensions
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder("Hello, I am a StringBuilder extension.");
            Console.WriteLine(text.Substring(14, text.Length+1));
            text.RemoveText("Hello, ");
            Console.WriteLine(text);
            Console.WriteLine();
            StringBuilder chat = new StringBuilder();
            chat.AppendAll(new List<string>() { "Do ", "you ", "like ", "SoftUni?" })
            .AppendAll(new List<string>() { "\nYes, ", "I ", "do" });
            Console.WriteLine(chat);
        }

        public static StringBuilder Substring(this StringBuilder strBuilder,
        int startIndex, int length)
        {
            StringBuilder result = new StringBuilder();
            string str = strBuilder.ToString();
            for (int i = 0; i < length; i++)
            {
                result.Append(str[startIndex]);
                startIndex++;
                if (startIndex > str.Length - 1)
                {
                    break;
                }
            }
            return result;
        }

        public static StringBuilder RemoveText(this StringBuilder strBuilder,
        string textToReplace)
        {
            strBuilder.Replace(textToReplace, "");
            return strBuilder;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder strBuilder,
        IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                strBuilder.Append(item);
            }
            return strBuilder;
        }
    }
}
