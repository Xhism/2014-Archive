using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigit
{
    class LastDigit
    {
        // Write a method that returns the last digit of given integer as an English word.
        // Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine".
        static void Main(string[] args)
        {
            Console.Write("Input desired number: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("The last digit of that number is ");
            GetLastDigit(num);
        }
        static void GetLastDigit(int num)
        {
            int lastDigit = num % 10;
            switch (lastDigit)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 0:
                    Console.WriteLine("zero");
                    break;
                default:
                    Console.WriteLine("not a valid number");
                    break;
            }
        }
    }
}
