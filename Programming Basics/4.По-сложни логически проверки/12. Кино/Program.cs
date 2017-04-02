using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Кино
{
    class Program
    {
        static void Main(string[] args)
        {
            var cinema = Console.ReadLine().ToLower();
            var rows = double.Parse(Console.ReadLine());
            var colums = double.Parse(Console.ReadLine());
            if (cinema == "premiere") Console.WriteLine(12.00 * (rows * colums)+" leva");
            else if (cinema == "normal") Console.WriteLine(7.50 * (rows * colums) + " leva");
            else if (cinema == "discount") Console.WriteLine(Math.Round(5.00 * (rows * colums),2) + " leva");

        }
    }
}
