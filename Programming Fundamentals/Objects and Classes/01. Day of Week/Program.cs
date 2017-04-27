using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = DateTime.ParseExact(Console.ReadLine(),
                "d-M-yyyy",CultureInfo.InvariantCulture);

            Console.WriteLine(input.DayOfWeek);
        }
    }
}
