using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var quantityD = new Dictionary<string, long>();
            var priceD = new Dictionary<string, decimal>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stocked")
                    break;

                var split = input.Split();
                var product = split[0];
                var price = decimal.Parse(split[1]);
                var quantity = long.Parse(split[2]);

                if (!quantityD.ContainsKey(product))
                {
                    quantityD[product] = quantity*2;
                    priceD[product] = price;
                }
                else
                {
                    quantityD[product] += quantity;
                    priceD[product] = price;
                }                
            }
            decimal total = 0;
            foreach (var product in priceD)
            {
                Console.WriteLine($"{product.Key}: ${product.Value} *" +
                    $" {quantityD[product.Key]} = ${product.Value* (quantityD[product.Key])}");

                total += product.Value * (quantityD[product.Key]);
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand Total: ${total}");
        }
    }
}
