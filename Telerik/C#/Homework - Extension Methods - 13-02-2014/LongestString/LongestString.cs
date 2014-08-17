using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    public class LongestString
    {
        public static int StringLength(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                count++;
            }
            return count;
        }

        public static List<T> EnumerableToList<T>(IOrderedEnumerable<T> current)
        {
            List<T> listed = new List<T>();

            foreach (var item in current)
            {
                listed.Add(item);
            }

            return listed;
        }
        static void Main()
        {
            List<string> listOfStrings = new List<string>() {"This is sample text", "asdfgfshg", "234626", "My name is Bob.", "Hello.", "12314235134"};

            var longestString = listOfStrings.OrderBy(st => StringLength(st));

            var sortedList = EnumerableToList(longestString);

            Console.WriteLine("The longest string is: {0}", sortedList[sortedList.Count - 1]);

            Console.WriteLine();
        }
    }
}
