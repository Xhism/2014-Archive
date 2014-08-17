using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSum
{
    class SubsetSum
    {
        static void Main(string[] args)
        {
            Console.Write("Input the wanted sum: ");
            int sum = int.Parse(Console.ReadLine());
            Console.Write("Input the number of elements: ");
            int inputLength = int.Parse(Console.ReadLine());
            int[] inputArray = new int[inputLength];
            int count = 0;
            string subset = "";
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                inputArray[i] = int.Parse(Console.ReadLine());
            }
            int maxSubsets = (int)Math.Pow(2, inputLength) - 1;
            for (int i = 1; i <= maxSubsets; i++)
            {
                subset = "";
                int checkSum = 0;
                for (int j = 0; j <= inputLength; j++)
                {
                    int mask = 1 << j;
                    int nAndMask = i & mask;
                    int bit = nAndMask >> j;
                    if (bit == 1)
                    {
                        checkSum = checkSum + inputArray[j];
                        subset = subset + " " + inputArray[j];
                    }
                }
                if (checkSum == sum)
                {
                    count++;
                    Console.WriteLine(subset);
                }
            }
            Console.WriteLine("Total: {0} subsets with the required sum.", count);
        }
    }
}
