using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var KM = double.Parse(Console.ReadLine());
            var time1 = double.Parse(Console.ReadLine());
            var time2 = double.Parse(Console.ReadLine());
            var time3 = double.Parse(Console.ReadLine());

            time1 = KM * (time1 / 60);
            time2 = (KM + (KM * 0.10)) * (time2 / 60);
            KM = (KM + (KM * 0.10));
            time3 = (KM - (KM * 0.05)) * (time3 / 60);
            Console.WriteLine($"{time1 + time2 + time3:f2}");
        }
    }
}
