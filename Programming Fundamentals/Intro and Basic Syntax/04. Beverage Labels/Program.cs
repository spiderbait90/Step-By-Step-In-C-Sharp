using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = double.Parse(Console.ReadLine());
            var energy = double.Parse(Console.ReadLine());
            var suger = double.Parse(Console.ReadLine());
            

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy*(volume/100)}kcal, " +
                $"{suger*(volume/100)}g sugars");
        }
    }
}
