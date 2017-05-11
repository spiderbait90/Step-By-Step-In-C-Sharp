using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var p = long.Parse(Console.ReadLine());

            var distance = (n / 1000) * m;
            var time = n / 100;
            var rest = (n / p) * 5;
            var result = rest + time;
            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{result} s.");
        }
    }
}
