using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferenceBetweenDates
{
    class Difference
    {
        static void Main(string[] args)
        {
            Console.Write("Input first date(format - DD.MM.YY): ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Input second date(format - DD.MM.YY): ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());
            TimeSpan time = secondDate - firstDate;
            Console.WriteLine("The difference is " + time.TotalDays);
        }
    }
}
