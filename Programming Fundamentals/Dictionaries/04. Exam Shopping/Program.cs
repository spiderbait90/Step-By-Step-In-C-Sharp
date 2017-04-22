using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Exam_Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var shop = new Dictionary<string, int>();

            while (input != "shopping time")
            {
                var itemQuantity = input.Split(' ');
                if (shop.ContainsKey(itemQuantity[1]))
                    shop[itemQuantity[1]] += int.Parse(itemQuantity[2]);
                else
                    shop.Add(itemQuantity[1], int.Parse(itemQuantity[2]));

                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "exam time")
            {
                var itemQuantity = input.Split(' ');
                if (shop.ContainsKey(itemQuantity[1]))
                {
                    if (shop[itemQuantity[1]] > 0)
                        shop[itemQuantity[1]] -= int.Parse(itemQuantity[2]);
                    else
                        Console.WriteLine($"{itemQuantity[1]} out of stock");
                }
                else if (!shop.ContainsKey(itemQuantity[1]))
                {
                    Console.WriteLine($"{itemQuantity[1]} doesn't exist");
                }
                input = Console.ReadLine();
            }

            foreach (var kv in shop)
            {
                if (kv.Value > 0)
                    Console.WriteLine($"{kv.Key} -> {kv.Value}");
            }
        }
    }
}
