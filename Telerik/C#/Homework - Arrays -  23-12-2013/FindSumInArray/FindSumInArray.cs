using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumInArray
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 4, 3, 1, 4, 2, 5, 8 };
            int S = 11;

            int start = 0;
            int checkSum = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                checkSum += inputArray[i];
                start = i;
                for (int j = i + 1; j < inputArray.Length; j++)
                {
                    checkSum += inputArray[j];
                    if (checkSum == S)
                    {
                        for (int k = start; k <= j; k++)
                        {
                            Console.Write(inputArray[k] + ", ");
                        }
                        Console.WriteLine();
                        return;
                    }
                }
                checkSum = 0;
            }
            Console.WriteLine("The given sum was not found within the array.");
        }
    }
}
