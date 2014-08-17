using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxOfGivenNumbers
{
    class MaxGivenNumber
    {
        // Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
        static void Main(string[] args)
        {
            Console.WriteLine("Input desired amount of integers in the sequence");
            int N;
            bool checkN = int.TryParse(Console.ReadLine(), out N);
            if (checkN)
            {
                int[] arr = new int[N];
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine("Input integer {0}", i+1);
                    arr[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Min = {0}\nMax = {1}", arr.Min(), arr.Max());
            }

        }
    }
}
