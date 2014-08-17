using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInArray
{
    class NumberInArray
    {
        // Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.
        static void Main(string[] args)
        {
            Console.Write("Input total desired amount of numbers in array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Input the number you're searching for: ");
            int searchedNum = int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} appears {1} time(s)", searchedNum, NumberCount(arr, searchedNum)); 
        }
        static int NumberCount(int[] Array, int searchedNum)
        {
            int count = 0;
            foreach(int number in Array)
            {
                if (number == searchedNum)
                    count++;
            }
            return count;
        }
    }
}
