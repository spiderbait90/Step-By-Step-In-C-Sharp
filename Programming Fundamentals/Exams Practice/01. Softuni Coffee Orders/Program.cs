using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var n = int.Parse(Console.ReadLine());
            decimal total = 0;
            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var date = DateTime.ParseExact(Console.ReadLine(),
                    @"d/M/yyyy", CultureInfo.InvariantCulture);

                var month = DateTime.DaysInMonth(date.Year, date.Month);
                var capsuleCount = decimal.Parse(Console.ReadLine());
                var result = pricePerCapsule * capsuleCount * month;

                total += result;
                Console.WriteLine($"The price for the coffee is: ${result:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");

        }
    }
}
