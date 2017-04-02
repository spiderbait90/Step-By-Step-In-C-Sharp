using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var MonthDays = 0;            
            
            if (month == 04 || month == 06 || month == 09 || month == 11)
                    MonthDays = 30;
            else if (month == 02)
                    MonthDays = 28;
            else
                    MonthDays = 31;
            day += 5;

            if (month == 12 && day > MonthDays)
            {
                day = day - MonthDays;
                month = 1;
            }
            else if (day>MonthDays)
            {
                month += 1;
                day = day - MonthDays;
            }
            
            if(month<10)
            Console.WriteLine($"{day}.0{month}");
            else if (month>=10) Console.WriteLine($"{day}.{month}");

        }
    }
}
