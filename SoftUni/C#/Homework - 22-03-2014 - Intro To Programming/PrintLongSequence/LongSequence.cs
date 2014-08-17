using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    class LongSequence
    {
        static void Main(string[] args)
        {
            int startNum = 2;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(startNum + i);
                else
                    Console.WriteLine(-startNum - i);
            }
        }
    }
}
