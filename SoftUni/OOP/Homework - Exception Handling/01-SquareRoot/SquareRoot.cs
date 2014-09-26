using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            string input = Console.ReadLine();
            try
            {
                int num = int.Parse(input);
                if (num < 0)
                {
                    throw new ArithmeticException();
                }
                double sqrt = Math.Sqrt(num);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good Bye");
            }
        }
    }
}
