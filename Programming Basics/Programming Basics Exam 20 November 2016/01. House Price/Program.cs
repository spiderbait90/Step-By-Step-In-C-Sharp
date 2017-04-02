using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var smallroom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var secondroom = smallroom + (smallroom * 0.10);
            var thirdroom = secondroom + (secondroom * 0.10);
            var bathroom = smallroom / 2;
            var total = smallroom + kitchen + secondroom + thirdroom + bathroom;
            total = total + (total * 0.05);
            total = total * price;
            Console.WriteLine($"{total:f2}");
        }
    }
}
