using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    class PrintSequence
    {
        static void Main(string[] args)
        {
            int startNum = 2;
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    Console.Write((startNum + i) + ", ");
                else
                    Console.Write((-startNum-i) + ", ");
            }
        }
    }
}
