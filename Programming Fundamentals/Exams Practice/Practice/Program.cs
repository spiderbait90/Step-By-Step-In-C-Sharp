using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine()
                .Split(':')
                .Select(long.Parse)
                .ToArray();
            var sec = time[2];
            var min = time[1];
            var hh = time[0];

            var numberSteps = long.Parse(Console.ReadLine());
            var timeSteps = long.Parse(Console.ReadLine());

            var totalSeconds = (numberSteps * timeSteps)
                + (min * 60) + (hh * 3600) + sec;

            var hour = (totalSeconds % 86400) / 3600;
            var minn = (totalSeconds % 3600) / 60;
            var secc = (totalSeconds % 60);

            Console.WriteLine($"Time Arrival: {hour:00}:{minn:00}:{secc:00}");
        }
    }
}
