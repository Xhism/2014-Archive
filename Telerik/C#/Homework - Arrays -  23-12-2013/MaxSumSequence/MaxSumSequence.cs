using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumSequence
{
    class MaxSumSequence
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            int max = array[0];
            int maxEnd = array[0];
            int maxLength = 1;
            int currentLength = 0;
            int bestStart = 0;
            int currentStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] + maxEnd > array[i])
                {
                    maxEnd = array[i] + maxEnd;
                    currentLength++;
                }

                else
                {
                    maxEnd = array[i];
                    currentStart = i;
                    maxLength = 1;
                }

                if (maxEnd > max)
                {
                    max = maxEnd;
                    maxLength = currentLength;
                    bestStart = currentStart;
                }
            }


            for (int i = bestStart; i < bestStart + maxLength - 1; i++)
            {
                Console.Write(array[i] + ", ");
            }

            Console.WriteLine(" with sum of " + max);
        }
    }
}
