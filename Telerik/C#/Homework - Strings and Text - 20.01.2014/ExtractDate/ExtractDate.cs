using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace ExtractDate
{
    class ExtractDate
    {
        static void Main()
        {
            string str = "Static void Main() 20.01.2014, 32.16.2793";

            DateTime date;
            foreach (Match item in Regex.Matches(str, @"\b\d{2}.\d{2}.\d{4}\b"))
                if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
        }
    }
}
