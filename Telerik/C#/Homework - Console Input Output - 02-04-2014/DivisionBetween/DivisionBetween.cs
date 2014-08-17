using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionBetween
{
    class DivisionBetween
    {
        // Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.

        static void Main(string[] args)
        {
            Console.Write("Please input the number to begin from: ");
            int beginNum = int.Parse(Console.ReadLine());
            Console.Write("Please input the number to end at: ");
            int endNum = int.Parse(Console.ReadLine());
            int result = 0;

            if (beginNum > endNum)
            {
                int tempNum = endNum;
                endNum = beginNum;
                beginNum = tempNum;
            }

            for (int i = beginNum; i <= endNum; i++)
            {
                if (i % 5 == 0) result++;
            }
            Console.WriteLine("The count of all the numbers divisible by 5\nthat exist between {0} and {1} is {2}", beginNum, endNum, result);
        }
    }
}
