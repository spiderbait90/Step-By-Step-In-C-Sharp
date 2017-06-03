using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var meter = float.Parse(Console.ReadLine());
            var hour = float.Parse(Console.ReadLine());
            var min = float.Parse(Console.ReadLine());
            var sec = float.Parse(Console.ReadLine());
            float hours = ((sec / 60) / 60) + (min / 60) + hour;
            float speedMs = ((hour * 60) * 60)+(min*60) + sec;
            speedMs = meter / speedMs;
            float speedKm = meter / 1000;
            speedKm /= hours;
            float milesPH = meter / 1609;
            milesPH /= hours;            

            Console.WriteLine($"{speedMs}\n{speedKm}\n{milesPH}");
            
        }
    }
}
