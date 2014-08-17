using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareRoot
{
    class SqrRoot
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Input desired number: ");
                int num = int.Parse(Console.ReadLine());
                double sqrRoot = Math.Sqrt(num);
                Console.WriteLine("Square root = " + num);
            }
            catch (FormatException formatException)
            {
                throw new FormatException("Invalid number! " + formatException.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The input number is too big or too small!");
            }
            finally
            {
                Console.WriteLine("Goodbye!");
            }
        }

        static void CheckForNegativeNumber(int number)
        {
            if (number < 0)
            {
                throw new ArithmeticException("Invalid number!");
            }
        }
    }
}
