using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingridients = Console.ReadLine().Split();
            var lenght = int.Parse(Console.ReadLine());

            var recipie = "";
            var count = 0;
            for (int i = 0; i < ingridients.Length; i++)
            {
                if (ingridients[i].Length==lenght)
                {
                    Console.WriteLine($"Adding {ingridients[i]}.");
                    recipie += ingridients[i]+" ";
                    count++;
                }
                if (count == 10)
                    break;
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are:" +
                $" {string.Join(", ",recipie.Trim().Split())}.");
        }
    }
}
