using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());

            var totalMinutes = (hour * 60) + min + 30;

            var hh = (totalMinutes / 60) % 24;
            var mm = totalMinutes % 60;

            Console.WriteLine($"{hh}:{mm:d2}");
        }
    }
}
