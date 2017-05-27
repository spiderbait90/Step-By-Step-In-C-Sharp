using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            var itemsCount = decimal.Parse(Console.ReadLine());
            decimal spend = 0;

            for (int i = 0; i < itemsCount; i++)
            {
                var item = Console.ReadLine();
                var price = decimal.Parse(Console.ReadLine());
                var count = decimal.Parse(Console.ReadLine());  
                
                spend += (price*count);   
                
                if (count!=1)
                    Console.WriteLine($"Adding {count} {item}s to cart.");
                else
                    Console.WriteLine($"Adding {count} {item} to cart.");
            }

            Console.WriteLine($"Subtotal: ${spend:f2}");

            if (spend>budget)
                Console.WriteLine($"Not enough. We need ${spend-budget:f2} more.");
            else
                Console.WriteLine($"Money left: ${budget-spend:f2}");
        }
    }
}
