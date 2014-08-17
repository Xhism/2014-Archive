using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinSearch
{
    class BinSearchK
    {
        // Write a program, that reads from the console an array of N integers and an integer K,
        // sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

        static void Main(string[] args)
        {
            int Result;
            Console.Write("Please input the amount of integers: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Integer {0} =", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Please input K: ");
            int k = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            if (arr[0] > k) Console.WriteLine("There is no number that is less than or equal to K.");
            else
            {
                int IndexOfElement = Array.BinarySearch(arr, k);
                if (IndexOfElement >= 0) Result = arr[IndexOfElement];
                else Result = arr[~IndexOfElement - 1];
                Console.WriteLine(Result);
            }
        }
    }
}