using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Реколта
{
    class Program
    {
        static void Main(string[] args)
        {
            var Loze = int.Parse(Console.ReadLine());
            
            var Grape = double.Parse(Console.ReadLine());
            var Wine = double.Parse(Console.ReadLine());
            var Workers = double.Parse(Console.ReadLine());
            var GrapeResult = Loze * Grape; 
            var lozePerc = GrapeResult * 40 / 100;
            var WineResult = lozePerc / 2.5;
            if (WineResult >= Wine)
            {
                var result = WineResult - Wine;
                var liters = result / Workers;

                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(WineResult));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(result), Math.Ceiling(liters));

            }
            else if (WineResult < Wine)
            {
                double result = Wine-WineResult;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(result));
            }


        }
    }
}
