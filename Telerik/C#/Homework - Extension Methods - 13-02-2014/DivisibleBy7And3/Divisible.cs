using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7And3
{
    /* 06.
     * Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
     * Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
     */

    class Divisible
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 63, 23, 3, 21, 7, 42, 456 };
            var divisibleLambda = numbers.Where(x => (x % 21) == 0);
            Console.WriteLine("Numbers divisible by 3 and 7 using Lambda:");
            foreach (var number in divisibleLambda)
            {
                Console.WriteLine(number);
            }
            var divisibleLINQ =
                from number in numbers
                where (number % 21) == 0
                select number;
            Console.WriteLine("Numbers divisible by 3 and 7 with LINQ:");
            foreach (var number in divisibleLINQ)
            {
                Console.WriteLine(number);
            }
        }
    }
}
