using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _17.AfterSixHours
{
    class AfterSixHours
    {
        static void Main()
        {
            string str = "20.01.2014 23:59:00";

            DateTime date = DateTime.ParseExact(str, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            date = date.AddHours(6.5);

            Console.WriteLine("In 6:30 hours it will be: {0} {1}", date.ToString("dddd", new CultureInfo("bg-BG")), date);
        }
    }
}
