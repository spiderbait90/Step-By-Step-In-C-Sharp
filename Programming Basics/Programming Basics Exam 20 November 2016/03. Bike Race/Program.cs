using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var young = int.Parse(Console.ReadLine());
            var old = int.Parse(Console.ReadLine());
            var trace = Console.ReadLine();
            var sum = 0.00;
            if (trace == "trail")
            {
                sum = young * 5.50 + old * 7.00;
            }
            else if (trace == "cross-country")
            {
                if (young + old >= 50)
                    sum = (young * (8.00-8.00*0.25)) + (old * (9.50-9.50*0.25));
                else
                    sum = young * 8.00 + old * 9.50;
            }
            else if (trace == "downhill")
            {
                sum = young * 12.25 + old * 13.75;
            }
            else if (trace == "road")
            {
                sum = young * 20.00 + old * 21.50;
            }
            sum = sum - sum * 0.05;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
