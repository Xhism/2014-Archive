using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            string url = "http://randomsite.com/stuff";
            ExtractURL(url);
        }
        public static void ExtractURL(string url)
        {
            int index = 0;
            index = url.IndexOf(':');
            Console.WriteLine("[protocol] = \"{0}\"", url.Substring(0, index));
            url = url.Remove(0, index + 3);

            index = url.IndexOf('/');
            Console.WriteLine("[server] = \"{0}\"", url.Substring(0, index));
            url = url.Remove(0, index + 1);

            Console.WriteLine("[resource] = \"{0}\"", url);

        }


    }
}
