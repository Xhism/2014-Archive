using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNum
{
    class MostFrequentNum
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };

            Array.Sort(inputArray);

            int currentLength = 1;
            int maxLength = 0;
            int currentNum = 0;
            for (int i = 0; i < inputArray.Length-1; i++)
            {
                if (inputArray[i] == inputArray[i + 1])
                {
                    currentLength++;
                    if (maxLength < currentLength)
                    {
                        maxLength = currentLength;
                        currentNum = inputArray[i];
                    }
                }
                else 
                    currentLength = 1;
            }
            Console.WriteLine("Most Frequent number is {0}, found {1} times", currentNum, maxLength);
        }
    }
}
