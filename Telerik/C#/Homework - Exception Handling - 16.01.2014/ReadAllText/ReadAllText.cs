using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAllText
{
    class ReadAllText
    {
        static void Main()
        {
            Console.Write("Input file directory:");
            try
            {
                Console.WriteLine(System.IO.File.ReadAllText(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught!\n{0}:{1}", e.GetType().Name, e.Message);
            }
        }
    }
}
