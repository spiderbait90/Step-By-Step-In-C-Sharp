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
            var Juniors = int.Parse(Console.ReadLine());
            var Seniors = int.Parse(Console.ReadLine());
            string Trace = Console.ReadLine();
            double total=0;
            
            if (Trace=="trail")
            {
                total = (Juniors * 5.50) + (Seniors * 7.00);
            }
            else if (Trace == "cross-country")
            {
                double taxSen = 9.50;
                double TaxJun = 8.00;
                if (Juniors+Seniors>=50)
                {
                    taxSen = 9.50 - (9.50 * 0.25);
                    TaxJun = 8.00 - (8.00 * 0.25);
                }
                total = (Juniors * TaxJun) + (Seniors * taxSen);
            }
            else if (Trace == "downhill")
            {
                total = (Juniors * 12.25) + (Seniors * 13.75);
            }
            else if (Trace == "road")
            {
                total = (Juniors * 20.00) + (Seniors * 21.50);
            }
            total-= (total * 0.05);
            Console.WriteLine($"{total:f2}");
        }
    }
}
