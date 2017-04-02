using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hours = double.Parse(Console.ReadLine());
            var Days = double.Parse(Console.ReadLine());
            var Workers = double.Parse(Console.ReadLine());
            double DaysPerc = (Days - (Days * 10 / 100))*8;
            Workers = Workers * (2 * Days);
            var TotalHours = Math.Truncate(DaysPerc + Workers);
            if (TotalHours >= Hours) 
            {
                var result = TotalHours - Hours;
                Console.WriteLine("Yes!{0} hours left.", result);
            }
            else
            {
                var result = Hours - TotalHours;
                Console.WriteLine("Not enough time!{0} hours needed.", result);
            }
           
        }
    }
}
