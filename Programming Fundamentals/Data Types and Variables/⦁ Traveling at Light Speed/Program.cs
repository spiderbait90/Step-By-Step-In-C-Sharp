using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace __Traveling_at_Light_Speed
{
    class Program
    {
        static void Main(string[] args)
        {
            var years = decimal.Parse(Console.ReadLine());

            var km = years * 9450000000000;
            var secTotal = km / 300000;
            var min = secTotal / 60;
            var hour = min / 60;
            var days = hour / 24;
            var weeks = days / 7;
            Console.WriteLine((int)(weeks)+@" weeks");
            days = days % 7;
            Console.WriteLine((int)(days)+@" days");
            hour = hour % 24;
            Console.WriteLine((int)(hour) + @" hours");
            min = min % 60;
            Console.WriteLine((int)(min) + @" minutes");
            secTotal = secTotal % 60;
            Console.WriteLine((int)(secTotal) + @" seconds");
        }
    }
}
