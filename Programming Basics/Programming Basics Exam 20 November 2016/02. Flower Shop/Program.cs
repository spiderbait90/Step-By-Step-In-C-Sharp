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
            var flower1 = int.Parse(Console.ReadLine());
            var flower2 = int.Parse(Console.ReadLine());
            var flower3 = int.Parse(Console.ReadLine());
            var flower4 = int.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var sum = flower1 * 3.25 + flower2 * 4.00 + flower3 * 3.5 + flower4 * 8.00;
            sum = sum - (sum * 0.05);
            
            if(price>sum)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(price-sum)} leva.");
            }
            else if (sum>=price)
            {
                Console.WriteLine($"She is left with {Math.Floor(sum-price)} leva.");
            }
        }
    }
}
