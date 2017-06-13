using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Work_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                @"dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                @"dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] nonWorkingDays =
            {
                new DateTime(4,01,01),
                new DateTime(4,03,03),
                new DateTime(4,05,01),
                new DateTime(4,05,06),
                new DateTime(4,05,24),
                new DateTime(4,09,06),
                new DateTime(4,09,22),
                new DateTime(4,11,01),
                new DateTime(4,12,24),
                new DateTime(4,12,25),
                new DateTime(4,12,26)                
            };
            
            long count = 0;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                var temp = new DateTime(4, date.Month, date.Day);
                if (date.DayOfWeek != DayOfWeek.Saturday &&
                    date.DayOfWeek != DayOfWeek.Sunday&&
                    !nonWorkingDays.Contains(temp))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
