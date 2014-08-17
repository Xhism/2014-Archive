using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Tasks
    {
        /*
           Write a program that can solve these tasks:
         *   Reverses the digits of a number
         *   Calculates the average of a sequence of integers
         *   Solves a linear equation a * x + b = 0
		   Create appropriate methods.
		   Provide a simple text-based menu for the user to choose which task to solve.
		   Validate the input data:
         *   The decimal number should be non-negative
         *   The sequence should not be empty
         *   a should not be equal to 0
        */
        static void Main()
        {
            Console.WriteLine("0: Reverse Digits; 1: Average; 2: Calculate Equation");

            int n = int.Parse(Console.ReadLine());
            CheckChoice(n);
        }
        static void CheckChoice(int choice)
        {
            if (choice == 0) InputReverseDigits();
            else if (choice == 1) InputAverage();
            else if (choice == 2) InputEquation();
            else Console.WriteLine("Incorrect choice.");
        }
        static int ReverseDigits(int n, int r = 0)
        {
            if (n == 0) return r;

            return ReverseDigits(n / 10, r * 10 + (n % 10));
        }

        static double GetAverage(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++) sum += arr[i];

            return (double)sum / arr.Length;
        }

        static double CalculateEquation(int a, int b)
        {
            return (double)-b / a;
        }

        static void InputReverseDigits()
        {
            Console.Write("Enter number, which digits you want reversed: ");

            int n = int.Parse(Console.ReadLine());

            if (n >= 0) Console.WriteLine("Reverse: " + ReverseDigits(n));
            else Console.WriteLine("Number should be non-negative.");
        }

        static void InputAverage()
        {
            Console.Write("Enter array size: ");

            int[] arr = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            if (arr.Length > 0) Console.WriteLine("Average = " + GetAverage(arr));
            else Console.WriteLine("Array should have elements.");
        }

        static void InputEquation()
        {
            Console.WriteLine("Equation:");
            Console.Write("Input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            int b = int.Parse(Console.ReadLine());

            if (a != 0) Console.WriteLine("x = " + CalculateEquation(a, b));
            else Console.WriteLine("Coefficient 'a' should not be zero.");
        }

        
    }
}
