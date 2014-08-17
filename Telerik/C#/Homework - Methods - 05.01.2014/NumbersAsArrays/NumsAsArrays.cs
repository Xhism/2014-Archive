using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace NumbersAsArrays
{
    class NumsAsArrays
    {
        // Write a method that adds two positive integer numbers represented as arrays of digits 
        // (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
        // Each of the numbers that will be added could have up to 10 000 digits.
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());

            int[] arr1 = BigIntToArr(num1);
            int[] arr2 = BigIntToArr(num2);
            int[] arr3 = SumArrays(arr1, arr2);
            Console.Write("Sum = ");
            for (int i = arr3.Length - 1; i >= 0; i--)
            {
                Console.Write(arr3[i]);
            }
            Console.WriteLine();
        }
        static int[] BigIntToArr(BigInteger n)
        {
            int[] digits = new int[GetDigitCount(n)];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = (int)(n % 10);
                n = n / 10;
            }
            return digits;
        }
        static int GetDigitCount(BigInteger n)
        {
            int count = 1;
            for (BigInteger i = 10; n / i != 0; i *= 10)
            {
                count++;
            }
            return count;
        }
        static int[] SumArrays(int[] arr1, int[] arr2)
        {
            int[] arr3 = new int[Math.Max(arr1.Length, arr2.Length) + 1];
            int carry = 0;

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                arr3[i] = (arr1[i] + arr2[i] + carry) % 10;
                if (arr1[i] + arr2[i] + carry >= 10)
                    carry = 1;
                else
                    carry = 0;
            }

            if (arr1.Length >= arr2.Length)
            {
                for (int i = arr2.Length; i < arr1.Length; i++)
                {
                    arr3[i] = arr1[i] + carry;
                    if (arr1[i] + carry >= 10)
                        carry = 1;
                    else
                        carry = 0;
                }
            }
            else
            {
                for (int i = arr1.Length; i < arr2.Length; i++)
                {
                    arr3[i] = arr2[i] + carry;
                    if (arr2[i] + carry >= 10)
                        carry = 1;
                    else
                        carry = 0;
                }
            }
            if (carry == 0)
            {
                Array.Resize(ref arr3, arr3.Length - 1);
            }
            else
            {
                arr3[arr3.Length - 1] += carry;
            }
            
            return arr3;
        }
    }
}
