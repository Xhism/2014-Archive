using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFirstAndLastName
{
    class PrintNames
    {
        static void Main(string[] args)
        {
            Console.Write("Input your first name here: ");
            string firstName = Console.ReadLine();

            Console.Write("Input your last name here: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Your full name is\n"+firstName+"\n"+lastName);
        }
    }
}
