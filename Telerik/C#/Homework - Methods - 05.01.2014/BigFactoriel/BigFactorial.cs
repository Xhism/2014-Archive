using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace BigFactoriel
{
    class BigFactorial
    {
        // Write a program to calculate n! for each n in the range [1..100]. Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 

        static void Main(string[] args)
        {
            int[] n = new int[100];
            for (int i = 0; i < 100; i++)
            {
                n[i] = i+1;
            }
            ArrayFactorials(n);
        }
        static BigInteger Factorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static void ArrayFactorials(int[] arr)
        {
            for (int i = 1; i <= arr.Length; i++)
            {
                Console.WriteLine(Factorial(i));
            }
        }
    }
}
