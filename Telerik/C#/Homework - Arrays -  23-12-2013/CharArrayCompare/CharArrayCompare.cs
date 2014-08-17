using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharArrayCompare
{
    class CharArrayCompare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first array (no separators between chars):");
            string input1 = Console.ReadLine();

            Console.WriteLine("Input first array (no separators between chars):");
            string input2 = Console.ReadLine();

            char[] firstArray = input1.ToCharArray();
            char[] secondArray = input2.ToCharArray();

            int maxLength;
            int smallerArray = 0;

            if (firstArray.Length <= secondArray.Length)
            {
                maxLength = firstArray.Length;
            }
            else
            {
                maxLength = secondArray.Length;
            }

            for (int i = 0; i < maxLength; i++)
            {
                if (firstArray[i] < secondArray[i])
                {
                    smallerArray = 1;
                    break;
                }
                else if (firstArray[i] > secondArray[i])
                {
                    smallerArray = 2;
                    break;
                }
            }

            if (smallerArray == 1)
            {
                Console.WriteLine("The first array is earlier.");
            }
            else if (smallerArray == 2)
            {
                Console.WriteLine("The second array is earlier.");
            }
            else
            {
                if (firstArray.Length > secondArray.Length)
                {
                    Console.WriteLine("The second array is earlier.");
                }
                else if (firstArray.Length < secondArray.Length)
                {
                    Console.WriteLine("The first array is earlier.");
                }
                else
                {
                    Console.WriteLine("The two arrays are the same.");
                }
            }
        }
    }
}
