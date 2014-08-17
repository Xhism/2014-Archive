using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _16.DateOffset
{
    class DateOffset
    {
        static void Main()
        {
            string start = "20.01.2014";
            string end = "24.01.2014";

            DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("Offset: " + (endDate - startDate).TotalDays);
        }
    }
}
