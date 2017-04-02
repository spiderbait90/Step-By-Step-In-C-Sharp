using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var HowMany = int.Parse(Console.ReadLine());
            double bus = 0;double truck = 0;double train = 0;
            double totalTons = 0;
            for (int i = 1; i <= HowMany; i++)
            {
                var Tonaj = int.Parse(Console.ReadLine());
                if (Tonaj <= 3) bus += Tonaj;
                else if (Tonaj <= 11) truck += Tonaj;
                else if (Tonaj >= 12) train += Tonaj;
                totalTons += Tonaj;
            }
            double AvaregeTon = (((bus * 200) + (truck * 175) + (train * 120)) / totalTons);

            bus = bus / totalTons * 100;
            truck = truck / totalTons * 100;
            train = train / totalTons * 100;

            Console.WriteLine($"{AvaregeTon:f2}");
            Console.WriteLine($"{bus:f2}%");
            Console.WriteLine($"{truck:f2}%");
            Console.WriteLine($"{train:f2}%");
        }
    }
}
