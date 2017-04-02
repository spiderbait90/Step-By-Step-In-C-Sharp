using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = double.Parse(Console.ReadLine());
            var food = double.Parse(Console.ReadLine());
            var dog = double.Parse(Console.ReadLine());
            var cat = double.Parse(Console.ReadLine());
            var turtle = double.Parse(Console.ReadLine());
            var total = (days * dog) + (days * cat) + (days *(turtle/1000));
            if (total <= food) Console.WriteLine($"{Math.Floor(Math.Abs(food-total))} kilos of food left.");
            else if (total>food) Console.WriteLine($"{Math.Ceiling(Math.Abs(total-food))} more kilos of food are needed.");
        }
    }
}
