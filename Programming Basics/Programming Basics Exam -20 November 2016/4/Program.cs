using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var car = 0.0;var microbus = 0.0;var smallbuss = 0.0;var bigbus = 0.0;var train = 0.0;
            for (int i = 1; i <= n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num <= 5) car += num;
                else if (num >5&&num<= 12) microbus += num;
                else if (num>12&&num <= 25) smallbuss += num;
                else if (num>25&&num <= 40) bigbus += num;
                else if (num > 40) train += num;
            }
            var total = car + microbus + smallbuss + bigbus + train;
            car = (car/total) * 100;
            microbus = (microbus / total) * 100;
            smallbuss = (smallbuss / total) * 100;
            bigbus = (bigbus / total) * 100;
            train = (train / total) * 100;
            Console.WriteLine($"{car:f2}%");
            Console.WriteLine($"{microbus:f2}%");
            Console.WriteLine($"{smallbuss:f2}%");
            Console.WriteLine($"{bigbus:f2}%");
            Console.WriteLine($"{train:f2}%");
        }
    }
}
