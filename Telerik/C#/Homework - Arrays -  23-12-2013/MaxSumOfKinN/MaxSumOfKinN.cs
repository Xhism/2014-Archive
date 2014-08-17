using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumOfKinN
{
    class MaxSumOfKinN
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            int[] inputArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            int currentSum = 0;
            int bestSum = 0;

            int currentStart = 0;
            int bestStart = 0;

            for (int i = 0; i < n - k; i++)
            {
                for (int j = i; j < k + i; j++)
                {
                    currentSum += inputArray[j];
                }

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestStart = currentStart;
                }

                currentStart = i + 1;
                currentSum = 0;

            }

            for (int i = 0; i < k; i++)
            {
                Console.Write("{0}, ", inputArray[bestStart + i]);
            }

            Console.WriteLine(" with sum of {0}", bestSum);
        }
    }
}
