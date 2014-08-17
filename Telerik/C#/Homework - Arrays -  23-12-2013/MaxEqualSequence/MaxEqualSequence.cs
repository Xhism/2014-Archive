using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxEqualSequence
{
    class MaxEqualSequence
    {
        static void Main(string[] args)
        {
            int[] givenArray = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

            int length = 1;
            int maxLength = 0;

            int currentStart = 0;
            int bestStart = 0;

            for (int cell = 0; cell < givenArray.Length-1; cell++)
            {
                if (givenArray[cell] == givenArray[cell + 1])
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                        bestStart = currentStart;
                    }
                }
                else
                {
                    length = 1;
                    currentStart = cell + 1;
                }
            }

            for (int i = 0; i < maxLength; i++)
            {
                Console.Write("{0}, ", givenArray[bestStart + i]);
            }
            Console.WriteLine();
        }
    }
}
