using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var countpeople = 0;
            var car = 0.0;var microbus = 0.0;var smallbus = 0.0;var bigbus = 0.0;var train = 0.0;

            for (int i = 1; i <= n; i++)
            {
                var howmany = int.Parse(Console.ReadLine());
                countpeople += howmany;
                if (howmany <= 5) car += howmany;
                else if (howmany <= 12) microbus += howmany;
                else if (howmany <= 25) smallbus += howmany;
                else if (howmany <= 40) bigbus += howmany;
                else if (howmany >= 41) train += howmany;

            }
            car = car / countpeople * 100;
            microbus = microbus / countpeople * 100;
            smallbus = smallbus / countpeople * 100;
            bigbus = bigbus / countpeople * 100;
            train = train / countpeople * 100;

            Console.WriteLine($"{car:f2}%");
            Console.WriteLine($"{microbus:f2}%");
            Console.WriteLine($"{smallbus:f2}%");
            Console.WriteLine($"{bigbus:f2}%");
            Console.WriteLine($"{train:f2}%");
        }
    }
}
