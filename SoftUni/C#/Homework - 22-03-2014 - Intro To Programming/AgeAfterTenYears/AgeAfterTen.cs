using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfterTenYears
{
    class AgeAfterTen
    {
        static void Main(string[] args)
        {
            Console.Write("Input your Birthday here (format: DD/MM/YYYY): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            int currentAge = DateTime.Now.Year - birthday.Year;

            if (DateTime.Now.Month < birthday.Month)
            {
                currentAge -= 1;
            }

            if (DateTime.Now.Month == birthday.Month)
            {
                if (DateTime.Now.Day < birthday.Day)
                    currentAge -= 1;
                if (DateTime.Now.Day == birthday.Day)
                    Console.WriteLine("\nHappy Birthday!");
            }

            Console.WriteLine("\nYou are currently " + currentAge + " years old\nAnd will be " + (currentAge + 10) + " in 10 years.\n");
        }
    }
}
