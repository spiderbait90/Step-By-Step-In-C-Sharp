using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practiceee
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            var sumMin = hour * 60 + min + 15;
            hour = sumMin / 60;
            min = sumMin % 60;
            if (hour >= 24)
                hour -= 24;
            if (min < 10) Console.WriteLine($"{hour}:0{min}");
            else Console.WriteLine($"{hour}:{min}");
        }
        }
}
