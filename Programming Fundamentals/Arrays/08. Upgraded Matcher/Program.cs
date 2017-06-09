using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Upgraded_Matcher
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

            var input = Console.ReadLine();
            while (input != "done")
            {
                var splited = input.Split();
                var product = splited[0];
                var quantity = long.Parse(splited[1]);

                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i]==product)
                    {
                        long inStock = 0;
                        if (i <= quantities.Length - 1)
                            inStock = quantities[i];

                        if (inStock==0||inStock-quantity<0)
                            Console.WriteLine($"We do not have enough {product}");
                        else
                        {
                            quantities[i] -= quantity;
                            Console.WriteLine($"{product} x {quantity} costs " +
                                $"{quantity*prices[i]:f2}");
                        }
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
