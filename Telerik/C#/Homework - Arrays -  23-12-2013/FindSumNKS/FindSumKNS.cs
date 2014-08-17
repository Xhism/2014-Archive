using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumNKS
{
    class FindSumKNS
    {
        static void Main(string[] args)
        {
            Console.Write("Input the length of the subset (K): ");
            int subLength = int.Parse(Console.ReadLine());

            Console.Write("Input the wanted sum of the subsets (S): ");
            int sum = int.Parse(Console.ReadLine());

            Console.Write("Input the number of elements (N): ");
            int inputLength = int.Parse(Console.ReadLine());

            int[] inputArray = new int[inputLength];
            int count = 0;
            string subset = "";
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                inputArray[i] = int.Parse(Console.ReadLine());
            }
            int maxSubsets = (int)Math.Pow(2, inputLength);
            for (int i = 1; i < maxSubsets; i++)
            {
                subset = "";
                int checkSum = 0;
                int lengthCount = 0;
                for (int j = 0; j <= inputLength; j++)
                {
                    int mask = 1 << j;
                    int iAndMask = i & mask;
                    int bit = iAndMask >> j;
                    if (bit == 1)
                    {
                        checkSum = checkSum + inputArray[j];
                        subset = subset + " " + inputArray[j];
                        lengthCount++;
                    }
                }
                if (checkSum == sum && lengthCount == subLength)
                {
                    count++;
                    Console.WriteLine(subset);
                }
            }
            Console.WriteLine("Total: {0} subsets.", count);
        }
    }
}
