using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnolii = int.Parse(Console.ReadLine());
            var ziumbiuli = int.Parse(Console.ReadLine());
            var rozi = int.Parse(Console.ReadLine());
            var kaktusi = int.Parse(Console.ReadLine());
            var PriceGift = double.Parse(Console.ReadLine());

            double total = (magnolii * 3.25) + (ziumbiuli * 4.00) + (rozi * 3.50) + (kaktusi * 8.00);
            total -= (total * 0.05);
            if (total >= PriceGift) Console.WriteLine($"She is left with {Math.Floor(total-PriceGift)} leva.");
            else Console.WriteLine($"She will have to borrow {Math.Ceiling(PriceGift-total)} leva.");
        }
    }
}
