using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var shirochina = double.Parse(Console.ReadLine());
            var dyljina = double.Parse(Console.ReadLine());
            var TriangleSide = double.Parse(Console.ReadLine());
            var TriangleHight = double.Parse(Console.ReadLine());
            var PricePlochka = double.Parse(Console.ReadLine());
            var Cost = double.Parse(Console.ReadLine());
            var Plosht = shirochina * dyljina;
            var PloshtPlochka = TriangleSide * TriangleHight / 2;
            var neededPlochki = (Plosht / PloshtPlochka) + 5.00;
            var total = (Math.Ceiling(neededPlochki) * PricePlochka) + Cost;
            if(total<=money)           
                Console.WriteLine($"{money-total:f2} lv left.");
            else if (total > money)
                Console.WriteLine($"You'll need {total-money:f2} lv more.");
        }
    }
}
