using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var cargo = double.Parse(Console.ReadLine());
            var allcargo = 0.0;
            var bus = 0.0; var truck = 0.0; var train = 0.0;
            for (int i = 0; i < cargo; i++)
            {
                var n = double.Parse(Console.ReadLine());
                allcargo += n;
                if (n <= 3)
                {
                    bus = bus + n;
                }
                else if (n <= 11)
                {
                    truck = truck + n;
                }
                else if (n > 11)
                {
                    train = train + n;
                }

            }
            var total = (bus * 200 + truck * 175 + train * 120) / allcargo;
            var p1 = bus / allcargo * 100;
            var p2 = truck / allcargo * 100;
            var p3 = train / allcargo * 100;
            Console.WriteLine($"{total:f2}");
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
        }
    }
}
