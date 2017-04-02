using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var kgFood = int.Parse(Console.ReadLine());
            var dog = double.Parse(Console.ReadLine());
            var cat = double.Parse(Console.ReadLine());
            var turtle = double.Parse(Console.ReadLine());

            dog *= days;
            cat *= days;
            turtle *= days;
            turtle /= 1000;
            var total = dog + cat + turtle;
            if (total <= kgFood) Console.WriteLine($"{Math.Floor(kgFood-total)} kilos of food left.");
            else Console.WriteLine($"{Math.Ceiling(total-kgFood)} more kilos of food are needed.");
        }
    }
}
