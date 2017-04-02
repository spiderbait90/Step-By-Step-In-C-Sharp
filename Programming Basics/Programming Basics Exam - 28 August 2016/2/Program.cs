using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var hourswork = (days - (days * 0.10))*8;
            var hourswork2 = workers * (2 * days);
            var totalhours = Math.Floor(hourswork + hourswork2);
            
            if (hours <= totalhours) Console.WriteLine($"Yes!{totalhours-hours} hours left.");
            else Console.WriteLine($"Not enough time!{hours-totalhours} hours needed.");
        }
    }
}
