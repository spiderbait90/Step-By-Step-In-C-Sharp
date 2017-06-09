using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split();
            var quantities = Console.ReadLine().Split()
                .Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split()
                .Select(decimal.Parse).ToArray();

            var product = Console.ReadLine();
            while (product!="done")
            {
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i]==product)
                    {
                        Console.WriteLine($"{product} costs: {prices[i]};" +
                            $" Available quantity: {quantities[i]}");
                    }
                }
                product = Console.ReadLine();
            }
        }
    }
}
