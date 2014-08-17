using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Age
    {
        static void Main(string[] args)
        {
            Console.Write("Please input your age: ");
            try
            {
                int age = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("You will be {0} years old in 10 years", age + 10);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please input a number.");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("You can't possibly be of that age.");
            }
        }
    }
}
